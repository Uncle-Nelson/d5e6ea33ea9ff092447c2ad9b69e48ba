using System;
using System.Collections.Generic;
using System.Reflection;
using FishNet.Serializing.Helping;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x02000961 RID: 2401
	[CreateAssetMenu(fileName = "Avatar Settings", menuName = "ScriptableObjects/Avatar Settings", order = 1)]
	[Serializable]
	public class AvatarSettings : ScriptableObject
	{
		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06004142 RID: 16706 RVA: 0x00112917 File Offset: 0x00110B17
		public float UpperEyelidRestingPosition
		{
			get
			{
				return this.LeftEyeRestingState.topLidOpen;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06004143 RID: 16707 RVA: 0x00112924 File Offset: 0x00110B24
		public float LowerEyelidRestingPosition
		{
			get
			{
				return this.LeftEyeRestingState.bottomLidOpen;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06004144 RID: 16708 RVA: 0x00112931 File Offset: 0x00110B31
		public string FaceLayer1Path
		{
			get
			{
				if (this.FaceLayerSettings.Count <= 0)
				{
					return null;
				}
				return this.FaceLayerSettings[0].layerPath;
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06004145 RID: 16709 RVA: 0x00112954 File Offset: 0x00110B54
		public Color FaceLayer1Color
		{
			get
			{
				if (this.FaceLayerSettings.Count <= 0)
				{
					return Color.white;
				}
				return this.FaceLayerSettings[0].layerTint;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06004146 RID: 16710 RVA: 0x0011297B File Offset: 0x00110B7B
		public string FaceLayer2Path
		{
			get
			{
				if (this.FaceLayerSettings.Count <= 1)
				{
					return null;
				}
				return this.FaceLayerSettings[1].layerPath;
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06004147 RID: 16711 RVA: 0x0011299E File Offset: 0x00110B9E
		public Color FaceLayer2Color
		{
			get
			{
				if (this.FaceLayerSettings.Count <= 1)
				{
					return Color.white;
				}
				return this.FaceLayerSettings[1].layerTint;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06004148 RID: 16712 RVA: 0x001129C5 File Offset: 0x00110BC5
		public string FaceLayer3Path
		{
			get
			{
				if (this.FaceLayerSettings.Count <= 2)
				{
					return null;
				}
				return this.FaceLayerSettings[2].layerPath;
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06004149 RID: 16713 RVA: 0x001129E8 File Offset: 0x00110BE8
		public Color FaceLayer3Color
		{
			get
			{
				if (this.FaceLayerSettings.Count <= 2)
				{
					return Color.white;
				}
				return this.FaceLayerSettings[2].layerTint;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x0600414A RID: 16714 RVA: 0x00112A0F File Offset: 0x00110C0F
		public string FaceLayer4Path
		{
			get
			{
				if (this.FaceLayerSettings.Count <= 3)
				{
					return null;
				}
				return this.FaceLayerSettings[3].layerPath;
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x0600414B RID: 16715 RVA: 0x00112A32 File Offset: 0x00110C32
		public Color FaceLayer4Color
		{
			get
			{
				if (this.FaceLayerSettings.Count <= 3)
				{
					return Color.white;
				}
				return this.FaceLayerSettings[3].layerTint;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x0600414C RID: 16716 RVA: 0x00112A59 File Offset: 0x00110C59
		public string FaceLayer5Path
		{
			get
			{
				if (this.FaceLayerSettings.Count <= 4)
				{
					return null;
				}
				return this.FaceLayerSettings[4].layerPath;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x0600414D RID: 16717 RVA: 0x00112A7C File Offset: 0x00110C7C
		public Color FaceLayer5Color
		{
			get
			{
				if (this.FaceLayerSettings.Count <= 4)
				{
					return Color.white;
				}
				return this.FaceLayerSettings[4].layerTint;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x0600414E RID: 16718 RVA: 0x00112AA3 File Offset: 0x00110CA3
		public string FaceLayer6Path
		{
			get
			{
				if (this.FaceLayerSettings.Count <= 5)
				{
					return null;
				}
				return this.FaceLayerSettings[5].layerPath;
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x0600414F RID: 16719 RVA: 0x00112AC6 File Offset: 0x00110CC6
		public Color FaceLayer6Color
		{
			get
			{
				if (this.FaceLayerSettings.Count <= 5)
				{
					return Color.white;
				}
				return this.FaceLayerSettings[5].layerTint;
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06004150 RID: 16720 RVA: 0x00112AED File Offset: 0x00110CED
		public string BodyLayer1Path
		{
			get
			{
				if (this.BodyLayerSettings.Count <= 0)
				{
					return null;
				}
				return this.BodyLayerSettings[0].layerPath;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06004151 RID: 16721 RVA: 0x00112B10 File Offset: 0x00110D10
		public Color BodyLayer1Color
		{
			get
			{
				if (this.BodyLayerSettings.Count <= 0)
				{
					return Color.white;
				}
				return this.BodyLayerSettings[0].layerTint;
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06004152 RID: 16722 RVA: 0x00112B37 File Offset: 0x00110D37
		public string BodyLayer2Path
		{
			get
			{
				if (this.BodyLayerSettings.Count <= 1)
				{
					return null;
				}
				return this.BodyLayerSettings[1].layerPath;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06004153 RID: 16723 RVA: 0x00112B5A File Offset: 0x00110D5A
		public Color BodyLayer2Color
		{
			get
			{
				if (this.BodyLayerSettings.Count <= 1)
				{
					return Color.white;
				}
				return this.BodyLayerSettings[1].layerTint;
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06004154 RID: 16724 RVA: 0x00112B81 File Offset: 0x00110D81
		public string BodyLayer3Path
		{
			get
			{
				if (this.BodyLayerSettings.Count <= 2)
				{
					return null;
				}
				return this.BodyLayerSettings[2].layerPath;
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06004155 RID: 16725 RVA: 0x00112BA4 File Offset: 0x00110DA4
		public Color BodyLayer3Color
		{
			get
			{
				if (this.BodyLayerSettings.Count <= 2)
				{
					return Color.white;
				}
				return this.BodyLayerSettings[2].layerTint;
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06004156 RID: 16726 RVA: 0x00112BCB File Offset: 0x00110DCB
		public string BodyLayer4Path
		{
			get
			{
				if (this.BodyLayerSettings.Count <= 3)
				{
					return null;
				}
				return this.BodyLayerSettings[3].layerPath;
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06004157 RID: 16727 RVA: 0x00112BEE File Offset: 0x00110DEE
		public Color BodyLayer4Color
		{
			get
			{
				if (this.BodyLayerSettings.Count <= 3)
				{
					return Color.white;
				}
				return this.BodyLayerSettings[3].layerTint;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06004158 RID: 16728 RVA: 0x00112C15 File Offset: 0x00110E15
		public string BodyLayer5Path
		{
			get
			{
				if (this.BodyLayerSettings.Count <= 4)
				{
					return null;
				}
				return this.BodyLayerSettings[4].layerPath;
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06004159 RID: 16729 RVA: 0x00112C38 File Offset: 0x00110E38
		public Color BodyLayer5Color
		{
			get
			{
				if (this.BodyLayerSettings.Count <= 4)
				{
					return Color.white;
				}
				return this.BodyLayerSettings[4].layerTint;
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x0600415A RID: 16730 RVA: 0x00112C5F File Offset: 0x00110E5F
		public string BodyLayer6Path
		{
			get
			{
				if (this.BodyLayerSettings.Count <= 5)
				{
					return null;
				}
				return this.BodyLayerSettings[5].layerPath;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x0600415B RID: 16731 RVA: 0x00112C82 File Offset: 0x00110E82
		public Color BodyLayer6Color
		{
			get
			{
				if (this.BodyLayerSettings.Count <= 5)
				{
					return Color.white;
				}
				return this.BodyLayerSettings[5].layerTint;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x0600415C RID: 16732 RVA: 0x00112CA9 File Offset: 0x00110EA9
		public string Accessory1Path
		{
			get
			{
				if (this.AccessorySettings.Count <= 0)
				{
					return null;
				}
				return this.AccessorySettings[0].path;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x0600415D RID: 16733 RVA: 0x00112CCC File Offset: 0x00110ECC
		public Color Accessory1Color
		{
			get
			{
				if (this.AccessorySettings.Count <= 0)
				{
					return Color.white;
				}
				return this.AccessorySettings[0].color;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x0600415E RID: 16734 RVA: 0x00112CF3 File Offset: 0x00110EF3
		public string Accessory2Path
		{
			get
			{
				if (this.AccessorySettings.Count <= 1)
				{
					return null;
				}
				return this.AccessorySettings[1].path;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x0600415F RID: 16735 RVA: 0x00112D16 File Offset: 0x00110F16
		public Color Accessory2Color
		{
			get
			{
				if (this.AccessorySettings.Count <= 1)
				{
					return Color.white;
				}
				return this.AccessorySettings[1].color;
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06004160 RID: 16736 RVA: 0x00112D3D File Offset: 0x00110F3D
		public string Accessory3Path
		{
			get
			{
				if (this.AccessorySettings.Count <= 2)
				{
					return null;
				}
				return this.AccessorySettings[2].path;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06004161 RID: 16737 RVA: 0x00112D60 File Offset: 0x00110F60
		public Color Accessory3Color
		{
			get
			{
				if (this.AccessorySettings.Count <= 2)
				{
					return Color.white;
				}
				return this.AccessorySettings[2].color;
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06004162 RID: 16738 RVA: 0x00112D87 File Offset: 0x00110F87
		public string Accessory4Path
		{
			get
			{
				if (this.AccessorySettings.Count <= 3)
				{
					return null;
				}
				return this.AccessorySettings[3].path;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06004163 RID: 16739 RVA: 0x00112DAA File Offset: 0x00110FAA
		public Color Accessory4Color
		{
			get
			{
				if (this.AccessorySettings.Count <= 3)
				{
					return Color.white;
				}
				return this.AccessorySettings[3].color;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06004164 RID: 16740 RVA: 0x00112DD1 File Offset: 0x00110FD1
		public string Accessory5Path
		{
			get
			{
				if (this.AccessorySettings.Count <= 4)
				{
					return null;
				}
				return this.AccessorySettings[4].path;
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06004165 RID: 16741 RVA: 0x00112DF4 File Offset: 0x00110FF4
		public Color Accessory5Color
		{
			get
			{
				if (this.AccessorySettings.Count <= 4)
				{
					return Color.white;
				}
				return this.AccessorySettings[4].color;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06004166 RID: 16742 RVA: 0x00112E1B File Offset: 0x0011101B
		public string Accessory6Path
		{
			get
			{
				if (this.AccessorySettings.Count <= 5)
				{
					return null;
				}
				return this.AccessorySettings[5].path;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06004167 RID: 16743 RVA: 0x00112E3E File Offset: 0x0011103E
		public Color Accessory6Color
		{
			get
			{
				if (this.AccessorySettings.Count <= 5)
				{
					return Color.white;
				}
				return this.AccessorySettings[5].color;
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06004168 RID: 16744 RVA: 0x00112E65 File Offset: 0x00111065
		public string Accessory7Path
		{
			get
			{
				if (this.AccessorySettings.Count <= 6)
				{
					return null;
				}
				return this.AccessorySettings[6].path;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06004169 RID: 16745 RVA: 0x00112E88 File Offset: 0x00111088
		public Color Accessory7Color
		{
			get
			{
				if (this.AccessorySettings.Count <= 6)
				{
					return Color.white;
				}
				return this.AccessorySettings[6].color;
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x0600416A RID: 16746 RVA: 0x00112EAF File Offset: 0x001110AF
		public string Accessory8Path
		{
			get
			{
				if (this.AccessorySettings.Count <= 7)
				{
					return null;
				}
				return this.AccessorySettings[7].path;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x0600416B RID: 16747 RVA: 0x00112ED2 File Offset: 0x001110D2
		public Color Accessory8Color
		{
			get
			{
				if (this.AccessorySettings.Count <= 7)
				{
					return Color.white;
				}
				return this.AccessorySettings[7].color;
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x0600416C RID: 16748 RVA: 0x00112EF9 File Offset: 0x001110F9
		public string Accessory9Path
		{
			get
			{
				if (this.AccessorySettings.Count <= 8)
				{
					return null;
				}
				return this.AccessorySettings[8].path;
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x0600416D RID: 16749 RVA: 0x00112F1C File Offset: 0x0011111C
		public Color Accessory9Color
		{
			get
			{
				if (this.AccessorySettings.Count <= 8)
				{
					return Color.white;
				}
				return this.AccessorySettings[8].color;
			}
		}

		// Token: 0x17000942 RID: 2370
		public object this[string propertyName]
		{
			get
			{
				FieldInfo field = base.GetType().GetField(propertyName);
				PropertyInfo property = base.GetType().GetProperty(propertyName);
				if (field != null)
				{
					return field.GetValue(this);
				}
				if (property != null)
				{
					return property.GetValue(this, null);
				}
				return null;
			}
		}

		// Token: 0x0600416F RID: 16751 RVA: 0x00112F8F File Offset: 0x0011118F
		public virtual string GetJson(bool prettyPrint = true)
		{
			return JsonUtility.ToJson(this, prettyPrint);
		}

		// Token: 0x04002ED8 RID: 11992
		public Color SkinColor;

		// Token: 0x04002ED9 RID: 11993
		public float Height;

		// Token: 0x04002EDA RID: 11994
		public float Gender;

		// Token: 0x04002EDB RID: 11995
		public float Weight;

		// Token: 0x04002EDC RID: 11996
		public string HairPath;

		// Token: 0x04002EDD RID: 11997
		public Color HairColor;

		// Token: 0x04002EDE RID: 11998
		public float EyebrowScale;

		// Token: 0x04002EDF RID: 11999
		public float EyebrowThickness;

		// Token: 0x04002EE0 RID: 12000
		public float EyebrowRestingHeight;

		// Token: 0x04002EE1 RID: 12001
		public float EyebrowRestingAngle;

		// Token: 0x04002EE2 RID: 12002
		public Color LeftEyeLidColor;

		// Token: 0x04002EE3 RID: 12003
		public Color RightEyeLidColor;

		// Token: 0x04002EE4 RID: 12004
		public Eye.EyeLidConfiguration LeftEyeRestingState;

		// Token: 0x04002EE5 RID: 12005
		public Eye.EyeLidConfiguration RightEyeRestingState;

		// Token: 0x04002EE6 RID: 12006
		public string EyeballMaterialIdentifier;

		// Token: 0x04002EE7 RID: 12007
		public Color EyeBallTint;

		// Token: 0x04002EE8 RID: 12008
		public float PupilDilation;

		// Token: 0x04002EE9 RID: 12009
		public List<AvatarSettings.LayerSetting> FaceLayerSettings = new List<AvatarSettings.LayerSetting>();

		// Token: 0x04002EEA RID: 12010
		public List<AvatarSettings.LayerSetting> BodyLayerSettings = new List<AvatarSettings.LayerSetting>();

		// Token: 0x04002EEB RID: 12011
		public List<AvatarSettings.AccessorySetting> AccessorySettings = new List<AvatarSettings.AccessorySetting>();

		// Token: 0x04002EEC RID: 12012
		public bool UseCombinedLayer;

		// Token: 0x04002EED RID: 12013
		public string CombinedLayerPath;

		// Token: 0x04002EEE RID: 12014
		[CodegenExclude]
		public Texture2D ImpostorTexture;

		// Token: 0x02000962 RID: 2402
		[Serializable]
		public struct LayerSetting
		{
			// Token: 0x04002EEF RID: 12015
			public string layerPath;

			// Token: 0x04002EF0 RID: 12016
			public Color layerTint;
		}

		// Token: 0x02000963 RID: 2403
		[Serializable]
		public class AccessorySetting
		{
			// Token: 0x04002EF1 RID: 12017
			public string path;

			// Token: 0x04002EF2 RID: 12018
			public Color color;
		}
	}
}
