using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020009A9 RID: 2473
	[CreateAssetMenu(fileName = "BasicAvatarSettings", menuName = "ScriptableObjects/BasicAvatarSettings", order = 1)]
	[Serializable]
	public class BasicAvatarSettings : ScriptableObject
	{
		// Token: 0x060042DF RID: 17119 RVA: 0x00118601 File Offset: 0x00116801
		public T SetValue<T>(string fieldName, T value)
		{
			base.GetType().GetField(fieldName).SetValue(this, value);
			return value;
		}

		// Token: 0x060042E0 RID: 17120 RVA: 0x0011861C File Offset: 0x0011681C
		public T GetValue<T>(string fieldName)
		{
			FieldInfo field = base.GetType().GetField(fieldName);
			if (field == null)
			{
				return default(T);
			}
			return (T)((object)field.GetValue(this));
		}

		// Token: 0x060042E1 RID: 17121 RVA: 0x00118658 File Offset: 0x00116858
		public AvatarSettings GetAvatarSettings()
		{
			AvatarSettings avatarSettings = ScriptableObject.CreateInstance<AvatarSettings>();
			avatarSettings.Gender = (float)this.Gender * 0.7f;
			avatarSettings.Weight = this.Weight;
			avatarSettings.Height = 1f;
			avatarSettings.SkinColor = this.SkinColor;
			avatarSettings.HairPath = this.HairStyle;
			avatarSettings.HairColor = this.HairColor;
			avatarSettings.FaceLayerSettings.Add(new AvatarSettings.LayerSetting
			{
				layerPath = this.Mouth,
				layerTint = Color.black
			});
			avatarSettings.FaceLayerSettings.Add(new AvatarSettings.LayerSetting
			{
				layerPath = this.FacialHair,
				layerTint = Color.white
			});
			avatarSettings.FaceLayerSettings.Add(new AvatarSettings.LayerSetting
			{
				layerPath = this.FacialDetails,
				layerTint = new Color(0f, 0f, 0f, this.FacialDetailsIntensity)
			});
			avatarSettings.FaceLayerSettings.Add(new AvatarSettings.LayerSetting
			{
				layerPath = "Avatar/Layers/Face/EyeShadow",
				layerTint = new Color(0f, 0f, 0f, 0.7f)
			});
			avatarSettings.EyeBallTint = this.EyeballColor;
			avatarSettings.LeftEyeLidColor = this.SkinColor;
			avatarSettings.RightEyeLidColor = this.SkinColor;
			avatarSettings.EyeballMaterialIdentifier = "Default";
			avatarSettings.PupilDilation = this.PupilDilation;
			Eye.EyeLidConfiguration eyeLidConfiguration = new Eye.EyeLidConfiguration
			{
				topLidOpen = this.UpperEyeLidRestingPosition,
				bottomLidOpen = this.LowerEyeLidRestingPosition
			};
			avatarSettings.LeftEyeRestingState = eyeLidConfiguration;
			avatarSettings.RightEyeRestingState = eyeLidConfiguration;
			avatarSettings.EyebrowScale = this.EyebrowScale;
			avatarSettings.EyebrowThickness = this.EyebrowThickness;
			avatarSettings.EyebrowRestingHeight = this.EyebrowRestingHeight;
			avatarSettings.EyebrowRestingAngle = this.EyebrowRestingAngle;
			avatarSettings.BodyLayerSettings.Add(new AvatarSettings.LayerSetting
			{
				layerPath = "Avatar/Layers/Top/Nipples",
				layerTint = new Color32(212, 181, 142, byte.MaxValue)
			});
			string layerPath = ((float)this.Gender <= 0.5f) ? "Avatar/Layers/Bottom/MaleUnderwear" : "Avatar/Layers/Bottom/FemaleUnderwear";
			avatarSettings.BodyLayerSettings.Add(new AvatarSettings.LayerSetting
			{
				layerPath = layerPath,
				layerTint = Color.white
			});
			if (!string.IsNullOrEmpty(this.Top))
			{
				avatarSettings.BodyLayerSettings.Add(new AvatarSettings.LayerSetting
				{
					layerPath = this.Top,
					layerTint = this.TopColor
				});
			}
			if (!string.IsNullOrEmpty(this.Bottom))
			{
				avatarSettings.BodyLayerSettings.Add(new AvatarSettings.LayerSetting
				{
					layerPath = this.Bottom,
					layerTint = this.BottomColor
				});
			}
			if (this.Tattoos != null)
			{
				for (int i = 0; i < this.Tattoos.Count; i++)
				{
					if (this.Tattoos[i].Contains("/Face/"))
					{
						avatarSettings.FaceLayerSettings.Add(new AvatarSettings.LayerSetting
						{
							layerPath = this.Tattoos[i],
							layerTint = Color.white
						});
					}
					else
					{
						avatarSettings.BodyLayerSettings.Add(new AvatarSettings.LayerSetting
						{
							layerPath = this.Tattoos[i],
							layerTint = Color.white
						});
					}
				}
			}
			if (!string.IsNullOrEmpty(this.Shoes))
			{
				avatarSettings.AccessorySettings.Add(new AvatarSettings.AccessorySetting
				{
					path = this.Shoes,
					color = this.ShoesColor
				});
			}
			if (!string.IsNullOrEmpty(this.Headwear))
			{
				avatarSettings.AccessorySettings.Add(new AvatarSettings.AccessorySetting
				{
					path = this.Headwear,
					color = this.HeadwearColor
				});
			}
			if (!string.IsNullOrEmpty(this.Eyewear))
			{
				avatarSettings.AccessorySettings.Add(new AvatarSettings.AccessorySetting
				{
					path = this.Eyewear,
					color = this.EyewearColor
				});
			}
			return avatarSettings;
		}

		// Token: 0x060042E2 RID: 17122 RVA: 0x00112F8F File Offset: 0x0011118F
		public virtual string GetJson(bool prettyPrint = true)
		{
			return JsonUtility.ToJson(this, prettyPrint);
		}

		// Token: 0x0400307F RID: 12415
		public const float GENDER_MULTIPLIER = 0.7f;

		// Token: 0x04003080 RID: 12416
		public const string MaleUnderwearPath = "Avatar/Layers/Bottom/MaleUnderwear";

		// Token: 0x04003081 RID: 12417
		public const string FemaleUnderwearPath = "Avatar/Layers/Bottom/FemaleUnderwear";

		// Token: 0x04003082 RID: 12418
		public int Gender;

		// Token: 0x04003083 RID: 12419
		public float Weight;

		// Token: 0x04003084 RID: 12420
		public Color SkinColor;

		// Token: 0x04003085 RID: 12421
		public string HairStyle;

		// Token: 0x04003086 RID: 12422
		public Color HairColor;

		// Token: 0x04003087 RID: 12423
		public string Mouth;

		// Token: 0x04003088 RID: 12424
		public string FacialHair;

		// Token: 0x04003089 RID: 12425
		public string FacialDetails;

		// Token: 0x0400308A RID: 12426
		public float FacialDetailsIntensity;

		// Token: 0x0400308B RID: 12427
		public Color EyeballColor;

		// Token: 0x0400308C RID: 12428
		public float UpperEyeLidRestingPosition;

		// Token: 0x0400308D RID: 12429
		public float LowerEyeLidRestingPosition;

		// Token: 0x0400308E RID: 12430
		public float PupilDilation = 1f;

		// Token: 0x0400308F RID: 12431
		public float EyebrowScale;

		// Token: 0x04003090 RID: 12432
		public float EyebrowThickness;

		// Token: 0x04003091 RID: 12433
		public float EyebrowRestingHeight;

		// Token: 0x04003092 RID: 12434
		public float EyebrowRestingAngle;

		// Token: 0x04003093 RID: 12435
		public string Top;

		// Token: 0x04003094 RID: 12436
		public Color TopColor;

		// Token: 0x04003095 RID: 12437
		public string Bottom;

		// Token: 0x04003096 RID: 12438
		public Color BottomColor;

		// Token: 0x04003097 RID: 12439
		public string Shoes;

		// Token: 0x04003098 RID: 12440
		public Color ShoesColor;

		// Token: 0x04003099 RID: 12441
		public string Headwear;

		// Token: 0x0400309A RID: 12442
		public Color HeadwearColor;

		// Token: 0x0400309B RID: 12443
		public string Eyewear;

		// Token: 0x0400309C RID: 12444
		public Color EyewearColor;

		// Token: 0x0400309D RID: 12445
		public List<string> Tattoos = new List<string>();
	}
}
