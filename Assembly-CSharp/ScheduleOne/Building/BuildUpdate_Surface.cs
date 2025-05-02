using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x02000793 RID: 1939
	public class BuildUpdate_Surface : BuildUpdate_Base
	{
		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060034CD RID: 13517 RVA: 0x000DDEA2 File Offset: 0x000DC0A2
		private float detectionRange
		{
			get
			{
				return Mathf.Max(this.BuildableItemClass.HoldDistance, 4f);
			}
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x000DDEB9 File Offset: 0x000DC0B9
		protected virtual void Start()
		{
			this.LateUpdate();
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x000DDEC1 File Offset: 0x000DC0C1
		protected virtual void Update()
		{
			this.CheckRotation();
			if (GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick) && this.validPosition)
			{
				this.Place();
			}
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x000DDEE0 File Offset: 0x000DC0E0
		protected virtual void LateUpdate()
		{
			this.validPosition = false;
			this.GhostModel.transform.up = Vector3.up;
			this.PositionObjectInFrontOfPlayer(this.BuildableItemClass.HoldDistance, true);
			Surface surface = null;
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast_ExcludeBuildables(this.detectionRange, out raycastHit, this.DetectionMask, true))
			{
				surface = raycastHit.collider.GetComponentInParent<Surface>();
			}
			if (this.IsSurfaceValidForItem(surface, raycastHit.collider, raycastHit.point))
			{
				this.hoveredValidSurface = surface;
				this.validPosition = true;
			}
			else
			{
				this.hoveredValidSurface = null;
			}
			float d;
			float d2;
			float d3;
			if ((!Application.isEditor || !Input.GetKey(KeyCode.LeftAlt)) && this.BuildableItemClass.GetPenetration(out d, out d2, out d3))
			{
				if (Vector3.Distance(this.GhostModel.transform.position - this.GhostModel.transform.right * d, PlayerSingleton<PlayerCamera>.Instance.transform.position) < Vector3.Distance(this.GhostModel.transform.position - this.GhostModel.transform.forward * d2, PlayerSingleton<PlayerCamera>.Instance.transform.position))
				{
					this.GhostModel.transform.position -= this.GhostModel.transform.right * d;
					if (this.BuildableItemClass.GetPenetration(out d, out d2, out d3))
					{
						this.GhostModel.transform.position -= this.GhostModel.transform.forward * d2;
					}
				}
				else
				{
					this.GhostModel.transform.position -= this.GhostModel.transform.forward * d2;
					if (this.BuildableItemClass.GetPenetration(out d, out d2, out d3))
					{
						this.GhostModel.transform.position -= this.GhostModel.transform.right * d;
					}
				}
				this.GhostModel.transform.position -= this.GhostModel.transform.up * d3;
			}
			this.UpdateMaterials();
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x000DE148 File Offset: 0x000DC348
		protected void PositionObjectInFrontOfPlayer(float dist, bool sanitizeForward)
		{
			Vector3 forward = PlayerSingleton<PlayerCamera>.Instance.transform.forward;
			if (sanitizeForward)
			{
				forward.y = 0f;
			}
			Vector3 vector = PlayerSingleton<PlayerCamera>.Instance.transform.position + forward * dist;
			Vector3 forward2 = (PlayerSingleton<PlayerCamera>.Instance.transform.position - vector).normalized;
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast_ExcludeBuildables(this.detectionRange, out raycastHit, this.DetectionMask, true))
			{
				vector = raycastHit.point;
				forward2 = raycastHit.normal;
			}
			else if (this.BuildableItemClass.MidAirCenterPoint != null)
			{
				vector += -this.GhostModel.transform.InverseTransformPoint(this.BuildableItemClass.MidAirCenterPoint.transform.position);
			}
			Quaternion lhs = Quaternion.LookRotation(forward2, Vector3.up);
			this.GhostModel.transform.rotation = lhs * Quaternion.Inverse(this.BuildableItemClass.BuildPoint.transform.rotation);
			this.GhostModel.transform.RotateAround(this.BuildableItemClass.BuildPoint.transform.position, this.BuildableItemClass.BuildPoint.transform.forward, this.CurrentRotation);
			this.GhostModel.transform.position = vector - this.GhostModel.transform.InverseTransformPoint(this.BuildableItemClass.BuildPoint.transform.position);
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x000DE2DC File Offset: 0x000DC4DC
		private bool IsSurfaceValidForItem(Surface surface, Collider hitCollider, Vector3 hitPoint)
		{
			return !(surface == null) && this.BuildableItemClass.ValidSurfaceTypes.Contains(surface.SurfaceType) && !(surface.ParentProperty == null) && surface.ParentProperty.IsOwned && surface.IsPointValid(hitPoint, hitCollider);
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x000DE338 File Offset: 0x000DC538
		protected void CheckRotation()
		{
			if (!this.BuildableItemClass.AllowRotation)
			{
				this.CurrentRotation = 0f;
				return;
			}
			if (GameInput.GetButtonDown(GameInput.ButtonCode.RotateLeft) && !GameInput.IsTyping)
			{
				this.CurrentRotation -= this.BuildableItemClass.RotationIncrement;
			}
			if (GameInput.GetButtonDown(GameInput.ButtonCode.RotateRight) && !GameInput.IsTyping)
			{
				this.CurrentRotation += this.BuildableItemClass.RotationIncrement;
			}
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x000DE3B0 File Offset: 0x000DC5B0
		protected void UpdateMaterials()
		{
			Material material = Singleton<BuildManager>.Instance.ghostMaterial_White;
			if (!this.validPosition)
			{
				material = Singleton<BuildManager>.Instance.ghostMaterial_Red;
			}
			if (this.currentGhostMaterial != material)
			{
				this.currentGhostMaterial = material;
				Singleton<BuildManager>.Instance.ApplyMaterial(this.GhostModel, material, true);
			}
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x000DE404 File Offset: 0x000DC604
		protected virtual void Place()
		{
			Mathf.RoundToInt(this.CurrentRotation);
			Vector3 relativePosition = this.hoveredValidSurface.GetRelativePosition(this.GhostModel.transform.position);
			Quaternion relativeRotation = this.hoveredValidSurface.GetRelativeRotation(this.GhostModel.transform.rotation);
			Singleton<BuildManager>.Instance.CreateSurfaceItem(this.ItemInstance.GetCopy(1), this.hoveredValidSurface, relativePosition, relativeRotation, "");
			PlayerSingleton<PlayerInventory>.Instance.equippedSlot.ChangeQuantity(-1, false);
			Singleton<BuildManager>.Instance.PlayBuildSound((this.ItemInstance.Definition as BuildableItemDefinition).BuildSoundType, this.GhostModel.transform.position);
		}

		// Token: 0x040025B6 RID: 9654
		public GameObject GhostModel;

		// Token: 0x040025B7 RID: 9655
		public SurfaceItem BuildableItemClass;

		// Token: 0x040025B8 RID: 9656
		public ItemInstance ItemInstance;

		// Token: 0x040025B9 RID: 9657
		public float CurrentRotation;

		// Token: 0x040025BA RID: 9658
		[Header("Settings")]
		public LayerMask DetectionMask;

		// Token: 0x040025BB RID: 9659
		protected bool validPosition;

		// Token: 0x040025BC RID: 9660
		protected Material currentGhostMaterial;

		// Token: 0x040025BD RID: 9661
		protected Surface hoveredValidSurface;
	}
}
