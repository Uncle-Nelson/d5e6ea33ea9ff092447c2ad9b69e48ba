using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB
{
	// Token: 0x0200013E RID: 318
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-sd-raycasting/")]
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0001AE31 File Offset: 0x00019031
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x0001AE39 File Offset: 0x00019039
		[Obsolete("Use 'fadeDistanceToSurface' instead")]
		public float fadeDistanceToPlane
		{
			get
			{
				return this.fadeDistanceToSurface;
			}
			set
			{
				this.fadeDistanceToSurface = value;
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0001AE42 File Offset: 0x00019042
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return this.planeEquationWS.IsValid() && !GeometryUtility.TestPlanesAABB(new Plane[]
			{
				this.planeEquationWS
			}, collider.bounds);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0001AE74 File Offset: 0x00019074
		protected override string GetShaderKeyword()
		{
			return "VLB_OCCLUSION_CLIPPING_PLANE";
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x000022C9 File Offset: 0x000004C9
		protected override MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return MaterialManager.SD.DynamicOcclusion.ClippingPlane;
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0001AE7B File Offset: 0x0001907B
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x0001AE83 File Offset: 0x00019083
		public Plane planeEquationWS { get; private set; }

		// Token: 0x060005A9 RID: 1449 RVA: 0x0001AE8C File Offset: 0x0001908C
		protected override void OnValidateProperties()
		{
			base.OnValidateProperties();
			this.minOccluderArea = Mathf.Max(this.minOccluderArea, 0f);
			this.fadeDistanceToSurface = Mathf.Max(this.fadeDistanceToSurface, 0f);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0001AEC0 File Offset: 0x000190C0
		protected override void OnEnablePostValidate()
		{
			this.m_CurrentHit.SetNull();
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0001AECD File Offset: 0x000190CD
		protected override void OnDisable()
		{
			base.OnDisable();
			this.SetHitNull();
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0001AEDC File Offset: 0x000190DC
		private void Start()
		{
			if (Application.isPlaying)
			{
				TriggerZone component = base.GetComponent<TriggerZone>();
				if (component)
				{
					this.m_RangeMultiplier = Mathf.Max(1f, component.rangeMultiplier);
				}
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0001AF18 File Offset: 0x00019118
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			float num = angleDiff * 0.5f;
			return Quaternion.Euler(Random.Range(-num, num), Random.Range(-num, num), Random.Range(-num, num)) * direction;
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0001AF50 File Offset: 0x00019150
		private QueryTriggerInteraction queryTriggerInteraction
		{
			get
			{
				if (!this.considerTriggers)
				{
					return 1;
				}
				return 2;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0001AF5D File Offset: 0x0001915D
		private float raycastMaxDistance
		{
			get
			{
				return this.m_Master.raycastDistance * this.m_RangeMultiplier * this.m_Master.GetLossyScale().z;
			}
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0001AF82 File Offset: 0x00019182
		private DynamicOcclusionRaycasting.HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			if (this.dimensions != Dimensions.Dim2D)
			{
				return this.GetBestHit3D(rayPos, rayDir);
			}
			return this.GetBestHit2D(rayPos, rayDir);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0001AFA0 File Offset: 0x000191A0
		private DynamicOcclusionRaycasting.HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			RaycastHit[] array = Physics.RaycastAll(rayPos, rayDir, this.raycastMaxDistance, this.layerMask.value, this.queryTriggerInteraction);
			int num = -1;
			float num2 = float.MaxValue;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].collider.gameObject != this.m_Master.gameObject && array[i].collider.bounds.GetMaxArea2D() >= this.minOccluderArea && array[i].distance < num2)
				{
					num2 = array[i].distance;
					num = i;
				}
			}
			if (num != -1)
			{
				return new DynamicOcclusionRaycasting.HitResult(ref array[num]);
			}
			return default(DynamicOcclusionRaycasting.HitResult);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0001B05C File Offset: 0x0001925C
		private DynamicOcclusionRaycasting.HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			RaycastHit2D[] array = Physics2D.RaycastAll(new Vector2(rayPos.x, rayPos.y), new Vector2(rayDir.x, rayDir.y), this.raycastMaxDistance, this.layerMask.value);
			int num = -1;
			float num2 = float.MaxValue;
			for (int i = 0; i < array.Length; i++)
			{
				if ((this.considerTriggers || !array[i].collider.isTrigger) && array[i].collider.gameObject != this.m_Master.gameObject && array[i].collider.bounds.GetMaxArea2D() >= this.minOccluderArea && array[i].distance < num2)
				{
					num2 = array[i].distance;
					num = i;
				}
			}
			if (num != -1)
			{
				return new DynamicOcclusionRaycasting.HitResult(ref array[num]);
			}
			return default(DynamicOcclusionRaycasting.HitResult);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0001B150 File Offset: 0x00019350
		private uint GetDirectionCount()
		{
			if (this.dimensions != Dimensions.Dim2D)
			{
				return 4U;
			}
			return 2U;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0001B160 File Offset: 0x00019360
		private Vector3 GetDirection(uint dirInt)
		{
			dirInt %= this.GetDirectionCount();
			switch (dirInt)
			{
			case 0U:
				return this.m_Master.raycastGlobalUp;
			case 1U:
				return -this.m_Master.raycastGlobalUp;
			case 2U:
				return -this.m_Master.raycastGlobalRight;
			case 3U:
				return this.m_Master.raycastGlobalRight;
			default:
				return Vector3.zero;
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0001B1CE File Offset: 0x000193CE
		private bool IsHitValid(ref DynamicOcclusionRaycasting.HitResult hit, Vector3 forwardVec)
		{
			return hit.hasCollider && Vector3.Dot(hit.normal, -forwardVec) >= this.maxSurfaceDot;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0001B1F8 File Offset: 0x000193F8
		protected override bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			Vector3 raycastGlobalForward = this.m_Master.raycastGlobalForward;
			DynamicOcclusionRaycasting.HitResult hitResult = this.GetBestHit(base.transform.position, raycastGlobalForward);
			if (this.IsHitValid(ref hitResult, raycastGlobalForward))
			{
				if (this.minSurfaceRatio > 0.5f)
				{
					float raycastDistance = this.m_Master.raycastDistance;
					for (uint num = 0U; num < this.GetDirectionCount(); num += 1U)
					{
						Vector3 a = this.GetDirection(num + this.m_PrevNonSubHitDirectionId) * (this.minSurfaceRatio * 2f - 1f);
						a.Scale(base.transform.localScale);
						Vector3 vector = base.transform.position + a * this.m_Master.coneRadiusStart;
						Vector3 a2 = base.transform.position + a * this.m_Master.coneRadiusEnd + raycastGlobalForward * raycastDistance;
						DynamicOcclusionRaycasting.HitResult bestHit = this.GetBestHit(vector, (a2 - vector).normalized);
						if (!this.IsHitValid(ref bestHit, raycastGlobalForward))
						{
							this.m_PrevNonSubHitDirectionId = num;
							hitResult.SetNull();
							break;
						}
						if (bestHit.distance > hitResult.distance)
						{
							hitResult = bestHit;
						}
					}
				}
			}
			else
			{
				hitResult.SetNull();
			}
			this.SetHit(ref hitResult);
			return hitResult.hasCollider;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0001B358 File Offset: 0x00019558
		private void SetHit(ref DynamicOcclusionRaycasting.HitResult hit)
		{
			if (!hit.hasCollider)
			{
				this.SetHitNull();
				return;
			}
			PlaneAlignment planeAlignment = this.planeAlignment;
			if (planeAlignment != PlaneAlignment.Surface && planeAlignment == PlaneAlignment.Beam)
			{
				this.SetClippingPlane(new Plane(-this.m_Master.raycastGlobalForward, hit.point));
			}
			else
			{
				this.SetClippingPlane(new Plane(hit.normal, hit.point));
			}
			this.m_CurrentHit = hit;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0001B3C8 File Offset: 0x000195C8
		private void SetHitNull()
		{
			this.SetClippingPlaneOff();
			this.m_CurrentHit.SetNull();
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0001B3DC File Offset: 0x000195DC
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
			Plane planeEquationWS = this.planeEquationWS;
			owner.SetMaterialProp(ShaderProperties.SD.DynamicOcclusionClippingPlaneWS, new Vector4(planeEquationWS.normal.x, planeEquationWS.normal.y, planeEquationWS.normal.z, planeEquationWS.distance));
			owner.SetMaterialProp(ShaderProperties.SD.DynamicOcclusionClippingPlaneProps, this.fadeDistanceToSurface);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0001B43C File Offset: 0x0001963C
		private void SetClippingPlane(Plane planeWS)
		{
			planeWS = planeWS.TranslateCustom(planeWS.normal * this.planeOffset);
			this.SetPlaneWS(planeWS);
			this.m_Master._INTERNAL_SetDynamicOcclusionCallback(this.GetShaderKeyword(), this.m_MaterialModifierCallbackCached);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0001B478 File Offset: 0x00019678
		private void SetClippingPlaneOff()
		{
			this.SetPlaneWS(default(Plane));
			this.m_Master._INTERNAL_SetDynamicOcclusionCallback(this.GetShaderKeyword(), null);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0001B4A6 File Offset: 0x000196A6
		private void SetPlaneWS(Plane planeWS)
		{
			this.planeEquationWS = planeWS;
		}

		// Token: 0x040006AD RID: 1709
		public new const string ClassName = "DynamicOcclusionRaycasting";

		// Token: 0x040006AE RID: 1710
		public Dimensions dimensions;

		// Token: 0x040006AF RID: 1711
		public LayerMask layerMask = Consts.DynOcclusion.LayerMaskDefault;

		// Token: 0x040006B0 RID: 1712
		public bool considerTriggers;

		// Token: 0x040006B1 RID: 1713
		public float minOccluderArea;

		// Token: 0x040006B2 RID: 1714
		public float minSurfaceRatio = 0.5f;

		// Token: 0x040006B3 RID: 1715
		public float maxSurfaceDot = 0.25f;

		// Token: 0x040006B4 RID: 1716
		public PlaneAlignment planeAlignment;

		// Token: 0x040006B5 RID: 1717
		public float planeOffset = 0.1f;

		// Token: 0x040006B6 RID: 1718
		[FormerlySerializedAs("fadeDistanceToPlane")]
		public float fadeDistanceToSurface = 0.25f;

		// Token: 0x040006B7 RID: 1719
		private DynamicOcclusionRaycasting.HitResult m_CurrentHit;

		// Token: 0x040006B8 RID: 1720
		private float m_RangeMultiplier = 1f;

		// Token: 0x040006BA RID: 1722
		private uint m_PrevNonSubHitDirectionId;

		// Token: 0x0200013F RID: 319
		public struct HitResult
		{
			// Token: 0x060005BE RID: 1470 RVA: 0x0001B505 File Offset: 0x00019705
			public HitResult(ref RaycastHit hit3D)
			{
				this.point = hit3D.point;
				this.normal = hit3D.normal;
				this.distance = hit3D.distance;
				this.collider3D = hit3D.collider;
				this.collider2D = null;
			}

			// Token: 0x060005BF RID: 1471 RVA: 0x0001B540 File Offset: 0x00019740
			public HitResult(ref RaycastHit2D hit2D)
			{
				this.point = hit2D.point;
				this.normal = hit2D.normal;
				this.distance = hit2D.distance;
				this.collider2D = hit2D.collider;
				this.collider3D = null;
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0001B58E File Offset: 0x0001978E
			public bool hasCollider
			{
				get
				{
					return this.collider2D || this.collider3D;
				}
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0001B5AA File Offset: 0x000197AA
			public string name
			{
				get
				{
					if (this.collider3D)
					{
						return this.collider3D.name;
					}
					if (this.collider2D)
					{
						return this.collider2D.name;
					}
					return "null collider";
				}
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0001B5E4 File Offset: 0x000197E4
			public Bounds bounds
			{
				get
				{
					if (this.collider3D)
					{
						return this.collider3D.bounds;
					}
					if (this.collider2D)
					{
						return this.collider2D.bounds;
					}
					return default(Bounds);
				}
			}

			// Token: 0x060005C3 RID: 1475 RVA: 0x0001B62C File Offset: 0x0001982C
			public void SetNull()
			{
				this.collider2D = null;
				this.collider3D = null;
			}

			// Token: 0x040006BB RID: 1723
			public Vector3 point;

			// Token: 0x040006BC RID: 1724
			public Vector3 normal;

			// Token: 0x040006BD RID: 1725
			public float distance;

			// Token: 0x040006BE RID: 1726
			private Collider2D collider2D;

			// Token: 0x040006BF RID: 1727
			private Collider collider3D;
		}

		// Token: 0x02000140 RID: 320
		private enum Direction
		{
			// Token: 0x040006C1 RID: 1729
			Up,
			// Token: 0x040006C2 RID: 1730
			Down,
			// Token: 0x040006C3 RID: 1731
			Left,
			// Token: 0x040006C4 RID: 1732
			Right,
			// Token: 0x040006C5 RID: 1733
			Max2D = 1,
			// Token: 0x040006C6 RID: 1734
			Max3D = 3
		}
	}
}
