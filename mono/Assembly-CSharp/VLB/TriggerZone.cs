using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000152 RID: 338
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeamAbstractBase))]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-triggerzone/")]
	public class TriggerZone : MonoBehaviour
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0001CC78 File Offset: 0x0001AE78
		private TriggerZone.TriggerZoneUpdateRate updateRate
		{
			get
			{
				if (UtilsBeamProps.GetDimensions(this.m_Beam) == Dimensions.Dim3D)
				{
					return TriggerZone.TriggerZoneUpdateRate.OnEnable;
				}
				if (!(this.m_DynamicOcclusionRaycasting != null))
				{
					return TriggerZone.TriggerZoneUpdateRate.OnEnable;
				}
				return TriggerZone.TriggerZoneUpdateRate.OnOcclusionChange;
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0001CC9C File Offset: 0x0001AE9C
		private void OnEnable()
		{
			this.m_Beam = base.GetComponent<VolumetricLightBeamAbstractBase>();
			this.m_DynamicOcclusionRaycasting = base.GetComponent<DynamicOcclusionRaycasting>();
			TriggerZone.TriggerZoneUpdateRate updateRate = this.updateRate;
			if (updateRate == TriggerZone.TriggerZoneUpdateRate.OnEnable)
			{
				this.ComputeZone();
				base.enabled = false;
				return;
			}
			if (updateRate != TriggerZone.TriggerZoneUpdateRate.OnOcclusionChange)
			{
				return;
			}
			if (this.m_DynamicOcclusionRaycasting)
			{
				this.m_DynamicOcclusionRaycasting.onOcclusionProcessed += this.OnOcclusionProcessed;
			}
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0001CD02 File Offset: 0x0001AF02
		private void OnOcclusionProcessed()
		{
			this.ComputeZone();
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0001CD0C File Offset: 0x0001AF0C
		private void ComputeZone()
		{
			if (this.m_Beam)
			{
				float coneRadiusStart = UtilsBeamProps.GetConeRadiusStart(this.m_Beam);
				float num = UtilsBeamProps.GetFallOffEnd(this.m_Beam) * this.rangeMultiplier;
				float num2 = Mathf.LerpUnclamped(coneRadiusStart, UtilsBeamProps.GetConeRadiusEnd(this.m_Beam), this.rangeMultiplier);
				if (UtilsBeamProps.GetDimensions(this.m_Beam) == Dimensions.Dim3D)
				{
					MeshCollider orAddComponent = base.gameObject.GetOrAddComponent<MeshCollider>();
					Mathf.Min(UtilsBeamProps.GetGeomSides(this.m_Beam), 8);
					Mesh mesh = MeshGenerator.GenerateConeZ_Radii_DoubleCaps(num, coneRadiusStart, num2, 8, false);
					mesh.hideFlags = Consts.Internal.ProceduralObjectsHideFlags;
					orAddComponent.sharedMesh = mesh;
					orAddComponent.convex = this.setIsTrigger;
					orAddComponent.isTrigger = this.setIsTrigger;
					return;
				}
				if (this.m_PolygonCollider2D == null)
				{
					this.m_PolygonCollider2D = base.gameObject.GetOrAddComponent<PolygonCollider2D>();
				}
				Vector2[] array = new Vector2[]
				{
					new Vector2(0f, -coneRadiusStart),
					new Vector2(num, -num2),
					new Vector2(num, num2),
					new Vector2(0f, coneRadiusStart)
				};
				if (this.m_DynamicOcclusionRaycasting && this.m_DynamicOcclusionRaycasting.planeEquationWS.IsValid())
				{
					Plane planeEquationWS = this.m_DynamicOcclusionRaycasting.planeEquationWS;
					if (Utils.IsAlmostZero(planeEquationWS.normal.z))
					{
						Vector3 vector = planeEquationWS.ClosestPointOnPlaneCustom(Vector3.zero);
						Vector3 vector2 = planeEquationWS.ClosestPointOnPlaneCustom(Vector3.up);
						if (Utils.IsAlmostZero(Vector3.SqrMagnitude(vector - vector2)))
						{
							vector = planeEquationWS.ClosestPointOnPlaneCustom(Vector3.right);
						}
						vector = base.transform.InverseTransformPoint(vector);
						vector2 = base.transform.InverseTransformPoint(vector2);
						PolygonHelper.Plane2D plane2D = PolygonHelper.Plane2D.FromPoints(vector, vector2);
						if (plane2D.normal.x > 0f)
						{
							plane2D.Flip();
						}
						array = plane2D.CutConvex(array);
					}
				}
				this.m_PolygonCollider2D.points = array;
				this.m_PolygonCollider2D.isTrigger = this.setIsTrigger;
			}
		}

		// Token: 0x0400074F RID: 1871
		public const string ClassName = "TriggerZone";

		// Token: 0x04000750 RID: 1872
		public bool setIsTrigger = true;

		// Token: 0x04000751 RID: 1873
		public float rangeMultiplier = 1f;

		// Token: 0x04000752 RID: 1874
		private const int kMeshColliderNumSides = 8;

		// Token: 0x04000753 RID: 1875
		private VolumetricLightBeamAbstractBase m_Beam;

		// Token: 0x04000754 RID: 1876
		private DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting;

		// Token: 0x04000755 RID: 1877
		private PolygonCollider2D m_PolygonCollider2D;

		// Token: 0x02000153 RID: 339
		private enum TriggerZoneUpdateRate
		{
			// Token: 0x04000757 RID: 1879
			OnEnable,
			// Token: 0x04000758 RID: 1880
			OnOcclusionChange
		}
	}
}
