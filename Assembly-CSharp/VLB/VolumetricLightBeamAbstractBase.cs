using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x0200015A RID: 346
	public abstract class VolumetricLightBeamAbstractBase : MonoBehaviour
	{
		// Token: 0x060006AD RID: 1709
		public abstract BeamGeometryAbstractBase GetBeamGeometry();

		// Token: 0x060006AE RID: 1710
		protected abstract void SetBeamGeometryNull();

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x0001E370 File Offset: 0x0001C570
		public bool hasGeometry
		{
			get
			{
				return this.GetBeamGeometry() != null;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x0001E37E File Offset: 0x0001C57E
		public Bounds bounds
		{
			get
			{
				if (!(this.GetBeamGeometry() != null))
				{
					return new Bounds(Vector3.zero, Vector3.zero);
				}
				return this.GetBeamGeometry().meshRenderer.bounds;
			}
		}

		// Token: 0x060006B1 RID: 1713
		public abstract bool IsScalable();

		// Token: 0x060006B2 RID: 1714
		public abstract Vector3 GetLossyScale();

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x0001E3AE File Offset: 0x0001C5AE
		public int _INTERNAL_pluginVersion
		{
			get
			{
				return this.pluginVersion;
			}
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0001E3B8 File Offset: 0x0001C5B8
		public Light GetLightSpotAttachedSlow(out VolumetricLightBeamAbstractBase.AttachedLightType lightType)
		{
			Light component = base.GetComponent<Light>();
			if (!component)
			{
				lightType = VolumetricLightBeamAbstractBase.AttachedLightType.NoLight;
				return null;
			}
			if (component.type == LightType.Spot)
			{
				lightType = VolumetricLightBeamAbstractBase.AttachedLightType.SpotLight;
				return component;
			}
			lightType = VolumetricLightBeamAbstractBase.AttachedLightType.OtherLight;
			return null;
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0001E3EA File Offset: 0x0001C5EA
		public Light lightSpotAttached
		{
			get
			{
				return this.m_CachedLightSpot;
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0001E3F4 File Offset: 0x0001C5F4
		protected void InitLightSpotAttachedCached()
		{
			VolumetricLightBeamAbstractBase.AttachedLightType attachedLightType;
			this.m_CachedLightSpot = this.GetLightSpotAttachedSlow(out attachedLightType);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0001E40F File Offset: 0x0001C60F
		private void OnDestroy()
		{
			this.DestroyBeam();
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0001E417 File Offset: 0x0001C617
		protected void DestroyBeam()
		{
			if (Application.isPlaying)
			{
				BeamGeometryAbstractBase.DestroyBeamGeometryGameObject(this.GetBeamGeometry());
			}
			this.SetBeamGeometryNull();
		}

		// Token: 0x04000779 RID: 1913
		public const string ClassName = "VolumetricLightBeamAbstractBase";

		// Token: 0x0400077A RID: 1914
		[SerializeField]
		protected int pluginVersion = -1;

		// Token: 0x0400077B RID: 1915
		protected Light m_CachedLightSpot;

		// Token: 0x0200015B RID: 347
		public enum AttachedLightType
		{
			// Token: 0x0400077D RID: 1917
			NoLight,
			// Token: 0x0400077E RID: 1918
			OtherLight,
			// Token: 0x0400077F RID: 1919
			SpotLight
		}
	}
}
