using System;
using System.Collections.Generic;
using EasyButtons;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x02000796 RID: 1942
	public class Surface : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060034DB RID: 13531 RVA: 0x000DE54F File Offset: 0x000DC74F
		// (set) Token: 0x060034DC RID: 13532 RVA: 0x000DE557 File Offset: 0x000DC757
		public Guid GUID { get; protected set; }

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060034DD RID: 13533 RVA: 0x000DE560 File Offset: 0x000DC760
		public Transform Container
		{
			get
			{
				return this.ParentProperty.Container.transform;
			}
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x000DE574 File Offset: 0x000DC774
		[Button]
		public void RegenerateGUID()
		{
			this.BakedGUID = Guid.NewGuid().ToString();
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x000DE59A File Offset: 0x000DC79A
		private void OnValidate()
		{
			if (this.ParentProperty == null)
			{
				this.ParentProperty = base.GetComponentInParent<Property>();
			}
			if (string.IsNullOrEmpty(this.BakedGUID))
			{
				this.RegenerateGUID();
			}
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x000DE5CC File Offset: 0x000DC7CC
		protected virtual void Awake()
		{
			if (!GUIDManager.IsGUIDValid(this.BakedGUID))
			{
				Console.LogError(base.gameObject.name + "'s baked GUID is not valid! Bad.", null);
			}
			if (GUIDManager.IsGUIDAlreadyRegistered(new Guid(this.BakedGUID)))
			{
				Console.LogError(base.gameObject.name + "'s baked GUID is already registered! Bad.", this);
			}
			this.GUID = new Guid(this.BakedGUID);
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x000DE645 File Offset: 0x000DC845
		public void SetGUID(Guid guid)
		{
			this.GUID = guid;
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x000DE654 File Offset: 0x000DC854
		public Vector3 GetRelativePosition(Vector3 worldPosition)
		{
			return base.transform.InverseTransformPoint(worldPosition);
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x000DE662 File Offset: 0x000DC862
		public Quaternion GetRelativeRotation(Quaternion worldRotation)
		{
			return Quaternion.Inverse(base.transform.rotation) * worldRotation;
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x000DE67A File Offset: 0x000DC87A
		public bool IsFrontFace(Vector3 point, Collider collider)
		{
			return collider.transform.InverseTransformPoint(point).z > 0f;
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x000DE694 File Offset: 0x000DC894
		public bool IsPointValid(Vector3 point, Collider hitCollider)
		{
			Vector3 b = Vector3.zero;
			if (hitCollider is BoxCollider)
			{
				b = (hitCollider as BoxCollider).center;
			}
			else if (hitCollider is MeshCollider)
			{
				b = (hitCollider as MeshCollider).sharedMesh.bounds.center;
			}
			Vector3 vector = hitCollider.transform.InverseTransformPoint(point) - b;
			using (List<Surface.EFace>.Enumerator enumerator = this.ValidFaces.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					switch (enumerator.Current)
					{
					case Surface.EFace.Front:
						if (vector.z >= 0f)
						{
							return true;
						}
						break;
					case Surface.EFace.Back:
						if (vector.z <= 0f)
						{
							return true;
						}
						break;
					case Surface.EFace.Top:
						if (vector.y >= 0f)
						{
							return true;
						}
						break;
					case Surface.EFace.Bottom:
						if (vector.y <= 0f)
						{
							return true;
						}
						break;
					case Surface.EFace.Left:
						if (vector.x <= 0f)
						{
							return true;
						}
						break;
					case Surface.EFace.Right:
						if (vector.x >= 0f)
						{
							return true;
						}
						break;
					}
				}
			}
			return false;
		}

		// Token: 0x040025C2 RID: 9666
		[Header("Settings")]
		public Surface.ESurfaceType SurfaceType;

		// Token: 0x040025C3 RID: 9667
		public List<Surface.EFace> ValidFaces = new List<Surface.EFace>
		{
			Surface.EFace.Front
		};

		// Token: 0x040025C4 RID: 9668
		public Property ParentProperty;

		// Token: 0x040025C5 RID: 9669
		[SerializeField]
		protected string BakedGUID = string.Empty;

		// Token: 0x02000797 RID: 1943
		public enum ESurfaceType
		{
			// Token: 0x040025C7 RID: 9671
			Wall,
			// Token: 0x040025C8 RID: 9672
			Roof
		}

		// Token: 0x02000798 RID: 1944
		public enum EFace
		{
			// Token: 0x040025CA RID: 9674
			Front,
			// Token: 0x040025CB RID: 9675
			Back,
			// Token: 0x040025CC RID: 9676
			Top,
			// Token: 0x040025CD RID: 9677
			Bottom,
			// Token: 0x040025CE RID: 9678
			Left,
			// Token: 0x040025CF RID: 9679
			Right
		}
	}
}
