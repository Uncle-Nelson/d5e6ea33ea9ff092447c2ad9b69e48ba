using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001B5 RID: 437
	public class ProfileGroupDefinition
	{
		// Token: 0x060008C4 RID: 2244 RVA: 0x0002774C File Offset: 0x0002594C
		public static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, string tooltip)
		{
			return ProfileGroupDefinition.NumberGroupDefinition(groupName, propKey, minimumValue, maximumValue, value, ProfileGroupDefinition.RebuildType.None, null, false, tooltip);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0002776C File Offset: 0x0002596C
		public static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return ProfileGroupDefinition.NumberGroupDefinition(groupName, propKey, minimumValue, maximumValue, value, ProfileGroupDefinition.RebuildType.None, ProfileGroupDefinition.FormatStyle.Float, dependsOnKeyword, dependsOnValue, tooltip);
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0002778C File Offset: 0x0002598C
		public static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return ProfileGroupDefinition.NumberGroupDefinition(groupName, propKey, minimumValue, maximumValue, value, rebuildType, ProfileGroupDefinition.FormatStyle.Float, dependsOnKeyword, dependsOnValue, tooltip);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x000277B0 File Offset: 0x000259B0
		public static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, ProfileGroupDefinition.RebuildType rebuildType, ProfileGroupDefinition.FormatStyle formatStyle, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return new ProfileGroupDefinition
			{
				type = ProfileGroupDefinition.GroupType.Number,
				formatStyle = formatStyle,
				groupName = groupName,
				propertyKey = propKey,
				value = value,
				minimumValue = minimumValue,
				maximumValue = maximumValue,
				tooltip = tooltip,
				rebuildType = rebuildType,
				dependsOnFeature = dependsOnKeyword,
				dependsOnValue = dependsOnValue
			};
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00027815 File Offset: 0x00025A15
		public static ProfileGroupDefinition ColorGroupDefinition(string groupName, string propKey, Color color, string tooltip)
		{
			return ProfileGroupDefinition.ColorGroupDefinition(groupName, propKey, color, ProfileGroupDefinition.RebuildType.None, null, false, tooltip);
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00027823 File Offset: 0x00025A23
		public static ProfileGroupDefinition ColorGroupDefinition(string groupName, string propKey, Color color, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			return ProfileGroupDefinition.ColorGroupDefinition(groupName, propKey, color, ProfileGroupDefinition.RebuildType.None, dependsOnFeature, dependsOnValue, tooltip);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00027834 File Offset: 0x00025A34
		public static ProfileGroupDefinition ColorGroupDefinition(string groupName, string propKey, Color color, ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return new ProfileGroupDefinition
			{
				type = ProfileGroupDefinition.GroupType.Color,
				propertyKey = propKey,
				groupName = groupName,
				color = color,
				tooltip = tooltip,
				rebuildType = rebuildType,
				dependsOnFeature = dependsOnKeyword,
				dependsOnValue = dependsOnValue
			};
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00027881 File Offset: 0x00025A81
		public static ProfileGroupDefinition SpherePointGroupDefinition(string groupName, string propKey, float horizontalRotation, float verticalRotation, string tooltip)
		{
			return ProfileGroupDefinition.SpherePointGroupDefinition(groupName, propKey, horizontalRotation, verticalRotation, ProfileGroupDefinition.RebuildType.None, null, false, tooltip);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00027894 File Offset: 0x00025A94
		public static ProfileGroupDefinition SpherePointGroupDefinition(string groupName, string propKey, float horizontalRotation, float verticalRotation, ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return new ProfileGroupDefinition
			{
				type = ProfileGroupDefinition.GroupType.SpherePoint,
				propertyKey = propKey,
				groupName = groupName,
				tooltip = tooltip,
				rebuildType = rebuildType,
				dependsOnFeature = dependsOnKeyword,
				dependsOnValue = dependsOnValue,
				spherePoint = new SpherePoint(horizontalRotation, verticalRotation)
			};
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x000278E8 File Offset: 0x00025AE8
		public static ProfileGroupDefinition TextureGroupDefinition(string groupName, string propKey, Texture2D texture, string tooltip)
		{
			return ProfileGroupDefinition.TextureGroupDefinition(groupName, propKey, texture, ProfileGroupDefinition.RebuildType.None, null, false, tooltip);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x000278F6 File Offset: 0x00025AF6
		public static ProfileGroupDefinition TextureGroupDefinition(string groupName, string propKey, Texture2D texture, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return ProfileGroupDefinition.TextureGroupDefinition(groupName, propKey, texture, ProfileGroupDefinition.RebuildType.None, dependsOnKeyword, dependsOnValue, tooltip);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00027908 File Offset: 0x00025B08
		public static ProfileGroupDefinition TextureGroupDefinition(string groupName, string propKey, Texture2D texture, ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return new ProfileGroupDefinition
			{
				type = ProfileGroupDefinition.GroupType.Texture,
				groupName = groupName,
				propertyKey = propKey,
				texture = texture,
				tooltip = tooltip,
				rebuildType = rebuildType,
				dependsOnFeature = dependsOnKeyword,
				dependsOnValue = dependsOnValue
			};
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00027955 File Offset: 0x00025B55
		public static ProfileGroupDefinition BoolGroupDefinition(string groupName, string propKey, bool value, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return new ProfileGroupDefinition
			{
				type = ProfileGroupDefinition.GroupType.Boolean,
				groupName = groupName,
				propertyKey = propKey,
				dependsOnFeature = dependsOnKeyword,
				dependsOnValue = dependsOnValue,
				tooltip = tooltip,
				boolValue = value
			};
		}

		// Token: 0x040009B3 RID: 2483
		public ProfileGroupDefinition.GroupType type;

		// Token: 0x040009B4 RID: 2484
		public ProfileGroupDefinition.FormatStyle formatStyle;

		// Token: 0x040009B5 RID: 2485
		public ProfileGroupDefinition.RebuildType rebuildType;

		// Token: 0x040009B6 RID: 2486
		public string propertyKey;

		// Token: 0x040009B7 RID: 2487
		public string groupName;

		// Token: 0x040009B8 RID: 2488
		public Color color;

		// Token: 0x040009B9 RID: 2489
		public SpherePoint spherePoint;

		// Token: 0x040009BA RID: 2490
		public float minimumValue = -1f;

		// Token: 0x040009BB RID: 2491
		public float maximumValue = -1f;

		// Token: 0x040009BC RID: 2492
		public float value = -1f;

		// Token: 0x040009BD RID: 2493
		public bool boolValue;

		// Token: 0x040009BE RID: 2494
		public Texture2D texture;

		// Token: 0x040009BF RID: 2495
		public string tooltip;

		// Token: 0x040009C0 RID: 2496
		public string dependsOnFeature;

		// Token: 0x040009C1 RID: 2497
		public bool dependsOnValue;

		// Token: 0x020001B6 RID: 438
		public enum GroupType
		{
			// Token: 0x040009C3 RID: 2499
			None,
			// Token: 0x040009C4 RID: 2500
			Color,
			// Token: 0x040009C5 RID: 2501
			Number,
			// Token: 0x040009C6 RID: 2502
			Texture,
			// Token: 0x040009C7 RID: 2503
			SpherePoint,
			// Token: 0x040009C8 RID: 2504
			Boolean
		}

		// Token: 0x020001B7 RID: 439
		public enum FormatStyle
		{
			// Token: 0x040009CA RID: 2506
			None,
			// Token: 0x040009CB RID: 2507
			Integer,
			// Token: 0x040009CC RID: 2508
			Float
		}

		// Token: 0x020001B8 RID: 440
		public enum RebuildType
		{
			// Token: 0x040009CE RID: 2510
			None,
			// Token: 0x040009CF RID: 2511
			Stars
		}
	}
}
