using System;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020009AE RID: 2478
	public class CustomizationManager : Singleton<CustomizationManager>
	{
		// Token: 0x060042FE RID: 17150 RVA: 0x001190AE File Offset: 0x001172AE
		protected override void Start()
		{
			base.Start();
			this.LoadSettings(Object.Instantiate<AvatarSettings>(this.DefaultSettings));
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x000045B1 File Offset: 0x000027B1
		public void CreateSettings(string name)
		{
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x001190C7 File Offset: 0x001172C7
		public void CreateSettings()
		{
			if (this.SaveInputField.text == "")
			{
				Console.LogWarning("No name entered for settings file.", null);
				return;
			}
			this.CreateSettings(this.SaveInputField.text);
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x00119100 File Offset: 0x00117300
		public void LoadSettings(AvatarSettings loadedSettings)
		{
			if (loadedSettings == null)
			{
				Console.LogWarning("Settings are null!", null);
				return;
			}
			this.ActiveSettings = loadedSettings;
			Debug.Log("Settings loaded: " + this.ActiveSettings.name);
			this.TemplateAvatar.LoadAvatarSettings(this.ActiveSettings);
			if (this.OnAvatarSettingsChanged != null)
			{
				this.OnAvatarSettingsChanged(this.ActiveSettings);
			}
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x00119170 File Offset: 0x00117370
		public void LoadSettings(string settingsName, bool editOriginal = false)
		{
			this.isEditingOriginal = editOriginal;
			AvatarSettings loadedSettings;
			if (editOriginal)
			{
				loadedSettings = Resources.Load<AvatarSettings>("CharacterSettings/" + settingsName);
				this.SaveInputField.SetTextWithoutNotify(settingsName);
			}
			else
			{
				loadedSettings = Object.Instantiate<AvatarSettings>(Resources.Load<AvatarSettings>("CharacterSettings/" + settingsName));
			}
			this.LoadSettings(loadedSettings);
		}

		// Token: 0x06004303 RID: 17155 RVA: 0x001191C8 File Offset: 0x001173C8
		private void ApplyDefaultSettings(AvatarSettings settings)
		{
			settings.SkinColor = new Color32(150, 120, 95, byte.MaxValue);
			settings.Height = 0.98f;
			settings.Gender = 0f;
			settings.Weight = 0.4f;
			settings.EyebrowScale = 1f;
			settings.EyebrowThickness = 1f;
			settings.EyebrowRestingHeight = 0f;
			settings.EyebrowRestingAngle = 0f;
			settings.LeftEyeLidColor = new Color32(150, 120, 95, byte.MaxValue);
			settings.RightEyeLidColor = new Color32(150, 120, 95, byte.MaxValue);
			settings.LeftEyeRestingState = new Eye.EyeLidConfiguration
			{
				bottomLidOpen = 0.5f,
				topLidOpen = 0.5f
			};
			settings.RightEyeRestingState = new Eye.EyeLidConfiguration
			{
				bottomLidOpen = 0.5f,
				topLidOpen = 0.5f
			};
			settings.EyeballMaterialIdentifier = "Default";
			settings.EyeBallTint = Color.white;
			settings.PupilDilation = 1f;
			settings.HairPath = string.Empty;
			settings.HairColor = Color.black;
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x00119304 File Offset: 0x00117504
		public void LoadSettings()
		{
			this.isEditingOriginal = true;
			Debug.Log("Loading!: " + this.LoadInputField.text);
			this.LoadSettings(this.LoadInputField.text, this.LoadInputField.text != "Default");
		}

		// Token: 0x06004305 RID: 17157 RVA: 0x00119358 File Offset: 0x00117558
		public void GenderChanged(float genderScale)
		{
			this.ActiveSettings.Gender = genderScale;
			this.TemplateAvatar.ApplyBodySettings(this.ActiveSettings);
		}

		// Token: 0x06004306 RID: 17158 RVA: 0x00119377 File Offset: 0x00117577
		public void WeightChanged(float weightScale)
		{
			this.ActiveSettings.Weight = weightScale;
			this.TemplateAvatar.ApplyBodySettings(this.ActiveSettings);
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x00119396 File Offset: 0x00117596
		public void HeightChanged(float height)
		{
			this.ActiveSettings.Height = height;
			this.TemplateAvatar.ApplyBodySettings(this.ActiveSettings);
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x001193B8 File Offset: 0x001175B8
		public void SkinColorChanged(Color col)
		{
			this.ActiveSettings.SkinColor = col;
			this.TemplateAvatar.ApplyBodySettings(this.ActiveSettings);
			if (Input.GetKey(KeyCode.LeftControl))
			{
				this.ActiveSettings.LeftEyeLidColor = col;
				this.ActiveSettings.RightEyeLidColor = col;
			}
			this.TemplateAvatar.ApplyEyeLidColorSettings(this.ActiveSettings);
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x00119417 File Offset: 0x00117617
		public void HairChanged(Accessory newHair)
		{
			this.ActiveSettings.HairPath = ((newHair != null) ? newHair.AssetPath : string.Empty);
			this.TemplateAvatar.ApplyHairSettings(this.ActiveSettings);
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x0011944B File Offset: 0x0011764B
		public void HairColorChanged(Color newCol)
		{
			this.ActiveSettings.HairColor = newCol;
			this.TemplateAvatar.ApplyHairColorSettings(this.ActiveSettings);
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x0011946A File Offset: 0x0011766A
		public void EyeBallTintChanged(Color col)
		{
			this.ActiveSettings.EyeBallTint = col;
			this.TemplateAvatar.ApplyEyeBallSettings(this.ActiveSettings);
		}

		// Token: 0x0600430C RID: 17164 RVA: 0x00119489 File Offset: 0x00117689
		public void UpperEyeLidRestingPositionChanged(float newVal)
		{
			this.ActiveSettings.LeftEyeRestingState.topLidOpen = newVal;
			this.ActiveSettings.RightEyeRestingState.topLidOpen = newVal;
			this.TemplateAvatar.ApplyEyeLidSettings(this.ActiveSettings);
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x001194BE File Offset: 0x001176BE
		public void LowerEyeLidRestingPositionChanged(float newVal)
		{
			this.ActiveSettings.LeftEyeRestingState.bottomLidOpen = newVal;
			this.ActiveSettings.RightEyeRestingState.bottomLidOpen = newVal;
			this.TemplateAvatar.ApplyEyeLidSettings(this.ActiveSettings);
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x001194F3 File Offset: 0x001176F3
		public void EyebrowScaleChanged(float newVal)
		{
			this.ActiveSettings.EyebrowScale = newVal;
			this.TemplateAvatar.ApplyEyebrowSettings(this.ActiveSettings);
		}

		// Token: 0x0600430F RID: 17167 RVA: 0x00119512 File Offset: 0x00117712
		public void EyebrowThicknessChanged(float newVal)
		{
			this.ActiveSettings.EyebrowThickness = newVal;
			this.TemplateAvatar.ApplyEyebrowSettings(this.ActiveSettings);
		}

		// Token: 0x06004310 RID: 17168 RVA: 0x00119531 File Offset: 0x00117731
		public void EyebrowRestingHeightChanged(float newVal)
		{
			this.ActiveSettings.EyebrowRestingHeight = newVal;
			this.TemplateAvatar.ApplyEyebrowSettings(this.ActiveSettings);
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x00119550 File Offset: 0x00117750
		public void EyebrowRestingAngleChanged(float newVal)
		{
			this.ActiveSettings.EyebrowRestingAngle = newVal;
			this.TemplateAvatar.ApplyEyebrowSettings(this.ActiveSettings);
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x0011956F File Offset: 0x0011776F
		public void PupilDilationChanged(float dilation)
		{
			this.ActiveSettings.PupilDilation = dilation;
			this.TemplateAvatar.ApplyEyeBallSettings(this.ActiveSettings);
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x00119590 File Offset: 0x00117790
		public void FaceLayerChanged(FaceLayer layer, int index)
		{
			string layerPath = (layer != null) ? layer.AssetPath : string.Empty;
			Color layerTint = this.ActiveSettings.FaceLayerSettings[index].layerTint;
			this.ActiveSettings.FaceLayerSettings[index] = new AvatarSettings.LayerSetting
			{
				layerPath = layerPath,
				layerTint = layerTint
			};
			this.TemplateAvatar.ApplyFaceLayerSettings(this.ActiveSettings);
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x00119608 File Offset: 0x00117808
		public void FaceLayerColorChanged(Color col, int index)
		{
			string layerPath = this.ActiveSettings.FaceLayerSettings[index].layerPath;
			this.ActiveSettings.FaceLayerSettings[index] = new AvatarSettings.LayerSetting
			{
				layerPath = layerPath,
				layerTint = col
			};
			this.TemplateAvatar.ApplyFaceLayerSettings(this.ActiveSettings);
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x00119668 File Offset: 0x00117868
		public void BodyLayerChanged(AvatarLayer layer, int index)
		{
			string layerPath = (layer != null) ? layer.AssetPath : string.Empty;
			Color layerTint = this.ActiveSettings.BodyLayerSettings[index].layerTint;
			this.ActiveSettings.BodyLayerSettings[index] = new AvatarSettings.LayerSetting
			{
				layerPath = layerPath,
				layerTint = layerTint
			};
			this.TemplateAvatar.ApplyBodyLayerSettings(this.ActiveSettings, -1);
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x001196E0 File Offset: 0x001178E0
		public void BodyLayerColorChanged(Color col, int index)
		{
			string layerPath = this.ActiveSettings.BodyLayerSettings[index].layerPath;
			this.ActiveSettings.BodyLayerSettings[index] = new AvatarSettings.LayerSetting
			{
				layerPath = layerPath,
				layerTint = col
			};
			this.TemplateAvatar.ApplyBodyLayerSettings(this.ActiveSettings, -1);
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x00119740 File Offset: 0x00117940
		public void AccessoryChanged(Accessory acc, int index)
		{
			Debug.Log("Accessory changed: " + ((acc != null) ? acc.AssetPath : null));
			string path = (acc != null) ? acc.AssetPath : string.Empty;
			while (this.ActiveSettings.AccessorySettings.Count <= index)
			{
				this.ActiveSettings.AccessorySettings.Add(new AvatarSettings.AccessorySetting());
			}
			Color color = this.ActiveSettings.AccessorySettings[index].color;
			this.ActiveSettings.AccessorySettings[index] = new AvatarSettings.AccessorySetting
			{
				path = path,
				color = color
			};
			this.TemplateAvatar.ApplyAccessorySettings(this.ActiveSettings);
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x001197F8 File Offset: 0x001179F8
		public void AccessoryColorChanged(Color col, int index)
		{
			string path = this.ActiveSettings.AccessorySettings[index].path;
			this.ActiveSettings.AccessorySettings[index] = new AvatarSettings.AccessorySetting
			{
				path = path,
				color = col
			};
			this.TemplateAvatar.ApplyAccessorySettings(this.ActiveSettings);
		}

		// Token: 0x040030BA RID: 12474
		[SerializeField]
		private AvatarSettings ActiveSettings;

		// Token: 0x040030BB RID: 12475
		public Avatar TemplateAvatar;

		// Token: 0x040030BC RID: 12476
		public TMP_InputField SaveInputField;

		// Token: 0x040030BD RID: 12477
		public TMP_InputField LoadInputField;

		// Token: 0x040030BE RID: 12478
		public CustomizationManager.AvatarSettingsChanged OnAvatarSettingsChanged;

		// Token: 0x040030BF RID: 12479
		public AvatarSettings DefaultSettings;

		// Token: 0x040030C0 RID: 12480
		private bool isEditingOriginal;

		// Token: 0x020009AF RID: 2479
		// (Invoke) Token: 0x0600431B RID: 17179
		public delegate void AvatarSettingsChanged(AvatarSettings settings);
	}
}
