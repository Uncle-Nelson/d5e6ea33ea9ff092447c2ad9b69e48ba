using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FishNet;
using ScheduleOne.Clothing;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Networking;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using ScheduleOne.UI.CharacterCreator;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020009AA RID: 2474
	public class CharacterCreator : Singleton<CharacterCreator>
	{
		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x060042E4 RID: 17124 RVA: 0x00118A9D File Offset: 0x00116C9D
		// (set) Token: 0x060042E5 RID: 17125 RVA: 0x00118AA5 File Offset: 0x00116CA5
		public bool IsOpen { get; protected set; }

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x060042E6 RID: 17126 RVA: 0x00118AAE File Offset: 0x00116CAE
		// (set) Token: 0x060042E7 RID: 17127 RVA: 0x00118AB6 File Offset: 0x00116CB6
		public BasicAvatarSettings ActiveSettings { get; protected set; }

		// Token: 0x060042E8 RID: 17128 RVA: 0x00118ABF File Offset: 0x00116CBF
		protected override void Awake()
		{
			if (this.DemoCreator)
			{
				base.gameObject.SetActive(false);
				return;
			}
			base.Awake();
			this.Fields = this.Canvas.GetComponentsInChildren<BaseCharacterCreatorField>(true).ToList<BaseCharacterCreatorField>();
		}

		// Token: 0x060042E9 RID: 17129 RVA: 0x00118AF3 File Offset: 0x00116CF3
		protected override void Start()
		{
			base.Start();
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x060042EA RID: 17130 RVA: 0x00118B0C File Offset: 0x00116D0C
		private void Update()
		{
			this.RigContainer.localEulerAngles = Vector3.Lerp(this.RigContainer.localEulerAngles, new Vector3(0f, this.rigTargetY, 0f), Time.deltaTime * 5f);
		}

		// Token: 0x060042EB RID: 17131 RVA: 0x00118B4C File Offset: 0x00116D4C
		public void Open(BasicAvatarSettings initialSettings, bool showUI = true)
		{
			this.IsOpen = true;
			if (showUI)
			{
				this.ShowUI();
			}
			if (!this.DemoCreator)
			{
				PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(60f, 0f);
				PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.CameraPosition.position, this.CameraPosition.rotation, 0f, false);
			}
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			Singleton<HUD>.Instance.canvas.enabled = false;
			this.Container.gameObject.SetActive(true);
			if (InstanceFinder.IsServer && !Singleton<Lobby>.Instance.IsInLobby)
			{
				NetworkSingleton<TimeManager>.Instance.TimeProgressionMultiplier = 0f;
			}
			if (initialSettings != null)
			{
				this.ActiveSettings = Object.Instantiate<BasicAvatarSettings>(initialSettings);
			}
			else
			{
				this.ActiveSettings = ScriptableObject.CreateInstance<BasicAvatarSettings>();
			}
			this.Rig.LoadAvatarSettings(this.ActiveSettings.GetAvatarSettings());
			for (int i = 0; i < this.Fields.Count; i++)
			{
				this.Fields[i].ApplyValue();
				this.Fields[i].WriteValue(false);
			}
		}

		// Token: 0x060042EC RID: 17132 RVA: 0x00118C75 File Offset: 0x00116E75
		public void ShowUI()
		{
			this.Canvas.enabled = true;
			this.CanvasAnimation.Play("Character creator fade in");
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
		}

		// Token: 0x060042ED RID: 17133 RVA: 0x00118CAE File Offset: 0x00116EAE
		public void Close()
		{
			this.IsOpen = false;
			base.StartCoroutine(this.<Close>g__Close|28_0());
		}

		// Token: 0x060042EE RID: 17134 RVA: 0x00118CC4 File Offset: 0x00116EC4
		public void DisableStuff()
		{
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x060042EF RID: 17135 RVA: 0x00118CD8 File Offset: 0x00116ED8
		public void Done()
		{
			if (!this.IsOpen)
			{
				return;
			}
			List<ClothingInstance> list = new List<ClothingInstance>();
			if (!string.IsNullOrEmpty(this.ActiveSettings.Shoes))
			{
				EClothingColor clothingColor = ClothingColorExtensions.GetClothingColor(this.ActiveSettings.ShoesColor);
				list.Add(new ClothingInstance(this.lastSelectedClothingDefinitions["Shoes"], 1, clothingColor));
			}
			if (!string.IsNullOrEmpty(this.ActiveSettings.Top))
			{
				EClothingColor clothingColor2 = ClothingColorExtensions.GetClothingColor(this.ActiveSettings.TopColor);
				list.Add(new ClothingInstance(this.lastSelectedClothingDefinitions["Top"], 1, clothingColor2));
			}
			if (!string.IsNullOrEmpty(this.ActiveSettings.Bottom))
			{
				EClothingColor clothingColor3 = ClothingColorExtensions.GetClothingColor(this.ActiveSettings.BottomColor);
				list.Add(new ClothingInstance(this.lastSelectedClothingDefinitions["Bottom"], 1, clothingColor3));
			}
			if (this.onComplete != null)
			{
				this.onComplete.Invoke(this.ActiveSettings);
			}
			if (this.onCompleteWithClothing != null)
			{
				this.onCompleteWithClothing.Invoke(this.ActiveSettings, list);
			}
			this.Close();
		}

		// Token: 0x060042F0 RID: 17136 RVA: 0x00118DED File Offset: 0x00116FED
		public void SliderChanged(float newVal)
		{
			this.rigTargetY = newVal * 359f;
		}

		// Token: 0x060042F1 RID: 17137 RVA: 0x00118DFC File Offset: 0x00116FFC
		public T SetValue<T>(string fieldName, T value, ClothingDefinition definition)
		{
			if (!this.lastSelectedClothingDefinitions.ContainsKey(fieldName))
			{
				this.lastSelectedClothingDefinitions.Add(fieldName, definition);
			}
			else
			{
				this.lastSelectedClothingDefinitions[fieldName] = definition;
			}
			if (fieldName == "Preset")
			{
				this.SelectPreset(value as string);
				return default(T);
			}
			this.ActiveSettings.SetValue<T>(fieldName, value);
			return value;
		}

		// Token: 0x060042F2 RID: 17138 RVA: 0x00118E6C File Offset: 0x0011706C
		public void SelectPreset(string presetName)
		{
			BasicAvatarSettings basicAvatarSettings = this.Presets.Find((BasicAvatarSettings p) => p.name == presetName);
			if (basicAvatarSettings == null)
			{
				Debug.LogError("Preset not found: " + presetName);
				return;
			}
			this.ActiveSettings = Object.Instantiate<BasicAvatarSettings>(basicAvatarSettings);
			this.Rig.LoadAvatarSettings(this.ActiveSettings.GetAvatarSettings());
			for (int i = 0; i < this.Fields.Count; i++)
			{
				this.Fields[i].ApplyValue();
			}
		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x00118F08 File Offset: 0x00117108
		public void RefreshCategory(CharacterCreator.ECategory category)
		{
			AvatarSettings avatarSettings = this.ActiveSettings.GetAvatarSettings();
			switch (category)
			{
			case CharacterCreator.ECategory.Body:
				this.Rig.ApplyBodySettings(avatarSettings);
				this.Rig.ApplyEyeLidColorSettings(avatarSettings);
				this.Rig.ApplyBodyLayerSettings(avatarSettings, -1);
				return;
			case CharacterCreator.ECategory.Hair:
				this.Rig.ApplyHairSettings(avatarSettings);
				this.Rig.ApplyHairColorSettings(avatarSettings);
				this.Rig.ApplyFaceLayerSettings(avatarSettings);
				return;
			case CharacterCreator.ECategory.Face:
				this.Rig.ApplyFaceLayerSettings(avatarSettings);
				return;
			case CharacterCreator.ECategory.Eyes:
				this.Rig.ApplyEyeBallSettings(avatarSettings);
				this.Rig.ApplyEyeLidColorSettings(avatarSettings);
				this.Rig.ApplyEyeLidSettings(avatarSettings);
				return;
			case CharacterCreator.ECategory.Eyebrows:
				this.Rig.ApplyEyebrowSettings(avatarSettings);
				return;
			case CharacterCreator.ECategory.Clothing:
				this.Rig.ApplyBodyLayerSettings(avatarSettings, -1);
				return;
			case CharacterCreator.ECategory.Accessories:
				this.Rig.ApplyAccessorySettings(avatarSettings);
				return;
			default:
				return;
			}
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x00119006 File Offset: 0x00117206
		[CompilerGenerated]
		private IEnumerator <Close>g__Close|28_0()
		{
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			this.rigTargetY = 0f;
			this.Canvas.enabled = false;
			if (InstanceFinder.IsServer)
			{
				NetworkSingleton<TimeManager>.Instance.TimeProgressionMultiplier = 1f;
			}
			yield break;
		}

		// Token: 0x0400309F RID: 12447
		public List<BaseCharacterCreatorField> Fields = new List<BaseCharacterCreatorField>();

		// Token: 0x040030A1 RID: 12449
		[Header("References")]
		public Transform Container;

		// Token: 0x040030A2 RID: 12450
		public Transform CameraPosition;

		// Token: 0x040030A3 RID: 12451
		public Transform RigContainer;

		// Token: 0x040030A4 RID: 12452
		public Avatar Rig;

		// Token: 0x040030A5 RID: 12453
		public Canvas Canvas;

		// Token: 0x040030A6 RID: 12454
		public Animation CanvasAnimation;

		// Token: 0x040030A7 RID: 12455
		[Header("Settings")]
		public bool DemoCreator;

		// Token: 0x040030A8 RID: 12456
		public BasicAvatarSettings DefaultSettings;

		// Token: 0x040030A9 RID: 12457
		public List<BasicAvatarSettings> Presets;

		// Token: 0x040030AA RID: 12458
		public UnityEvent<BasicAvatarSettings> onComplete;

		// Token: 0x040030AB RID: 12459
		public UnityEvent<BasicAvatarSettings, List<ClothingInstance>> onCompleteWithClothing;

		// Token: 0x040030AC RID: 12460
		private Dictionary<string, ClothingDefinition> lastSelectedClothingDefinitions = new Dictionary<string, ClothingDefinition>();

		// Token: 0x040030AD RID: 12461
		private float rigTargetY;

		// Token: 0x020009AB RID: 2475
		public enum ECategory
		{
			// Token: 0x040030AF RID: 12463
			Body,
			// Token: 0x040030B0 RID: 12464
			Hair,
			// Token: 0x040030B1 RID: 12465
			Face,
			// Token: 0x040030B2 RID: 12466
			Eyes,
			// Token: 0x040030B3 RID: 12467
			Eyebrows,
			// Token: 0x040030B4 RID: 12468
			Clothing,
			// Token: 0x040030B5 RID: 12469
			Accessories
		}
	}
}
