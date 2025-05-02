using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000156 RID: 342
	public static class UtilsBeamProps
	{
		// Token: 0x06000683 RID: 1667 RVA: 0x0001D694 File Offset: 0x0001B894
		public static bool CanChangeDuringPlaytime(VolumetricLightBeamAbstractBase self)
		{
			VolumetricLightBeamSD volumetricLightBeamSD = self as VolumetricLightBeamSD;
			return !volumetricLightBeamSD || volumetricLightBeamSD.trackChangesDuringPlaytime;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0001D6B8 File Offset: 0x0001B8B8
		public static Quaternion GetInternalLocalRotation(VolumetricLightBeamAbstractBase self)
		{
			VolumetricLightBeamSD volumetricLightBeamSD = self as VolumetricLightBeamSD;
			if (volumetricLightBeamSD)
			{
				return volumetricLightBeamSD.beamInternalLocalRotation;
			}
			VolumetricLightBeamHD volumetricLightBeamHD = self as VolumetricLightBeamHD;
			if (volumetricLightBeamHD)
			{
				return volumetricLightBeamHD.beamInternalLocalRotation;
			}
			return Quaternion.identity;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0001D6F8 File Offset: 0x0001B8F8
		public static float GetThickness(VolumetricLightBeamAbstractBase self)
		{
			VolumetricLightBeamSD volumetricLightBeamSD = self as VolumetricLightBeamSD;
			if (volumetricLightBeamSD)
			{
				return Mathf.Clamp01(1f - volumetricLightBeamSD.fresnelPow / 10f);
			}
			VolumetricLightBeamHD volumetricLightBeamHD = self as VolumetricLightBeamHD;
			if (volumetricLightBeamHD)
			{
				return Mathf.Clamp01(1f - volumetricLightBeamHD.sideSoftness / 10f);
			}
			return 0f;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0001D758 File Offset: 0x0001B958
		public static float GetFallOffEnd(VolumetricLightBeamAbstractBase self)
		{
			VolumetricLightBeamSD volumetricLightBeamSD = self as VolumetricLightBeamSD;
			if (volumetricLightBeamSD)
			{
				return volumetricLightBeamSD.fallOffEnd;
			}
			VolumetricLightBeamHD volumetricLightBeamHD = self as VolumetricLightBeamHD;
			if (volumetricLightBeamHD)
			{
				return volumetricLightBeamHD.fallOffEnd;
			}
			return 0f;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0001D798 File Offset: 0x0001B998
		public static ColorMode GetColorMode(VolumetricLightBeamAbstractBase self)
		{
			VolumetricLightBeamSD volumetricLightBeamSD = self as VolumetricLightBeamSD;
			if (volumetricLightBeamSD)
			{
				return volumetricLightBeamSD.usedColorMode;
			}
			VolumetricLightBeamHD volumetricLightBeamHD = self as VolumetricLightBeamHD;
			if (volumetricLightBeamHD)
			{
				return volumetricLightBeamHD.colorMode;
			}
			return ColorMode.Flat;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0001D7D4 File Offset: 0x0001B9D4
		public static Color GetColorFlat(VolumetricLightBeamAbstractBase self)
		{
			VolumetricLightBeamSD volumetricLightBeamSD = self as VolumetricLightBeamSD;
			if (volumetricLightBeamSD)
			{
				return volumetricLightBeamSD.color;
			}
			VolumetricLightBeamHD volumetricLightBeamHD = self as VolumetricLightBeamHD;
			if (volumetricLightBeamHD)
			{
				return volumetricLightBeamHD.colorFlat;
			}
			return Color.white;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0001D814 File Offset: 0x0001BA14
		public static Gradient GetColorGradient(VolumetricLightBeamAbstractBase self)
		{
			VolumetricLightBeamSD volumetricLightBeamSD = self as VolumetricLightBeamSD;
			if (volumetricLightBeamSD)
			{
				return volumetricLightBeamSD.colorGradient;
			}
			VolumetricLightBeamHD volumetricLightBeamHD = self as VolumetricLightBeamHD;
			if (volumetricLightBeamHD)
			{
				return volumetricLightBeamHD.colorGradient;
			}
			return null;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0001D850 File Offset: 0x0001BA50
		public static float GetConeAngle(VolumetricLightBeamAbstractBase self)
		{
			VolumetricLightBeamSD volumetricLightBeamSD = self as VolumetricLightBeamSD;
			if (volumetricLightBeamSD)
			{
				return volumetricLightBeamSD.coneAngle;
			}
			VolumetricLightBeamHD volumetricLightBeamHD = self as VolumetricLightBeamHD;
			if (volumetricLightBeamHD)
			{
				return volumetricLightBeamHD.coneAngle;
			}
			return 0f;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0001D890 File Offset: 0x0001BA90
		public static float GetConeRadiusStart(VolumetricLightBeamAbstractBase self)
		{
			VolumetricLightBeamSD volumetricLightBeamSD = self as VolumetricLightBeamSD;
			if (volumetricLightBeamSD)
			{
				return volumetricLightBeamSD.coneRadiusStart;
			}
			VolumetricLightBeamHD volumetricLightBeamHD = self as VolumetricLightBeamHD;
			if (volumetricLightBeamHD)
			{
				return volumetricLightBeamHD.coneRadiusStart;
			}
			return 0f;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0001D8D0 File Offset: 0x0001BAD0
		public static float GetConeRadiusEnd(VolumetricLightBeamAbstractBase self)
		{
			VolumetricLightBeamSD volumetricLightBeamSD = self as VolumetricLightBeamSD;
			if (volumetricLightBeamSD)
			{
				return volumetricLightBeamSD.coneRadiusEnd;
			}
			VolumetricLightBeamHD volumetricLightBeamHD = self as VolumetricLightBeamHD;
			if (volumetricLightBeamHD)
			{
				return volumetricLightBeamHD.coneRadiusEnd;
			}
			return 0f;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0001D910 File Offset: 0x0001BB10
		public static int GetSortingLayerID(VolumetricLightBeamAbstractBase self)
		{
			VolumetricLightBeamSD volumetricLightBeamSD = self as VolumetricLightBeamSD;
			if (volumetricLightBeamSD)
			{
				return volumetricLightBeamSD.sortingLayerID;
			}
			VolumetricLightBeamHD volumetricLightBeamHD = self as VolumetricLightBeamHD;
			if (volumetricLightBeamHD)
			{
				return volumetricLightBeamHD.GetSortingLayerID();
			}
			return 0;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0001D94C File Offset: 0x0001BB4C
		public static int GetSortingOrder(VolumetricLightBeamAbstractBase self)
		{
			VolumetricLightBeamSD volumetricLightBeamSD = self as VolumetricLightBeamSD;
			if (volumetricLightBeamSD)
			{
				return volumetricLightBeamSD.sortingOrder;
			}
			VolumetricLightBeamHD volumetricLightBeamHD = self as VolumetricLightBeamHD;
			if (volumetricLightBeamHD)
			{
				return volumetricLightBeamHD.GetSortingOrder();
			}
			return 0;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0001D988 File Offset: 0x0001BB88
		public static bool GetFadeOutEnabled(VolumetricLightBeamAbstractBase self)
		{
			VolumetricLightBeamSD volumetricLightBeamSD = self as VolumetricLightBeamSD;
			return volumetricLightBeamSD && volumetricLightBeamSD.isFadeOutEnabled;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0001D9AC File Offset: 0x0001BBAC
		public static float GetFadeOutEnd(VolumetricLightBeamAbstractBase self)
		{
			VolumetricLightBeamSD volumetricLightBeamSD = self as VolumetricLightBeamSD;
			if (volumetricLightBeamSD)
			{
				return volumetricLightBeamSD.fadeOutEnd;
			}
			return 0f;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0001D9D4 File Offset: 0x0001BBD4
		public static Dimensions GetDimensions(VolumetricLightBeamAbstractBase self)
		{
			VolumetricLightBeamSD volumetricLightBeamSD = self as VolumetricLightBeamSD;
			if (volumetricLightBeamSD)
			{
				return volumetricLightBeamSD.dimensions;
			}
			VolumetricLightBeamHD volumetricLightBeamHD = self as VolumetricLightBeamHD;
			if (volumetricLightBeamHD)
			{
				return volumetricLightBeamHD.GetDimensions();
			}
			return Dimensions.Dim3D;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0001DA10 File Offset: 0x0001BC10
		public static int GetGeomSides(VolumetricLightBeamAbstractBase self)
		{
			VolumetricLightBeamSD volumetricLightBeamSD = self as VolumetricLightBeamSD;
			if (volumetricLightBeamSD)
			{
				return volumetricLightBeamSD.geomSides;
			}
			return Config.Instance.sharedMeshSides;
		}
	}
}
