using System;
using ScheduleOne.AvatarFramework;
using ScheduleOne.Clothing;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.Items;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

namespace ScheduleOne.UI
{
	// Token: 0x020009C8 RID: 2504
	public class CharacterDisplay : Singleton<CharacterDisplay>
	{
		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06004384 RID: 17284 RVA: 0x0011ADCB File Offset: 0x00118FCB
		// (set) Token: 0x06004385 RID: 17285 RVA: 0x0011ADD3 File Offset: 0x00118FD3
		public bool IsOpen { get; private set; }

		// Token: 0x06004386 RID: 17286 RVA: 0x0011ADDC File Offset: 0x00118FDC
		protected override void Awake()
		{
			base.Awake();
			this.SetOpen(false);
			if (this.ParentAvatar.CurrentSettings != null)
			{
				this.SetAppearance(this.ParentAvatar.CurrentSettings);
			}
			this.ParentAvatar.onSettingsLoaded.AddListener(new UnityAction(delegate()
			{
				this.SetAppearance(this.ParentAvatar.CurrentSettings);
			}));
			AudioSource[] componentsInChildren = this.Avatar.GetComponentsInChildren<AudioSource>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].enabled = false;
			}
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x0011AE5C File Offset: 0x0011905C
		public void SetOpen(bool open)
		{
			this.IsOpen = open;
			this.Container.gameObject.SetActive(open);
			if (this.IsOpen)
			{
				LayerUtility.SetLayerRecursively(this.Container.gameObject, LayerMask.NameToLayer("Overlay"));
				this.SetAppearance(this.ParentAvatar.CurrentSettings);
				Singleton<ItemUIManager>.Instance.EnableQuickMove(PlayerSingleton<PlayerInventory>.Instance.GetAllInventorySlots(), Player.Local.Clothing.ItemSlots);
			}
		}

		// Token: 0x06004388 RID: 17288 RVA: 0x0011AED8 File Offset: 0x001190D8
		private void Update()
		{
			if (this.IsOpen)
			{
				this.targetRotation = Mathf.Lerp(this.targetRotation, Mathf.Lerp(0f, 359f, Singleton<GameplayMenuInterface>.Instance.CharacterInterface.RotationSlider.value), Time.deltaTime * 5f);
				this.AvatarContainer.localEulerAngles = new Vector3(0f, this.targetRotation, 0f);
			}
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x0011AF4C File Offset: 0x0011914C
		public void SetAppearance(AvatarSettings settings)
		{
			AvatarSettings settings2 = Object.Instantiate<AvatarSettings>(settings);
			this.Avatar.LoadAvatarSettings(settings2);
			LayerUtility.SetLayerRecursively(base.gameObject, LayerMask.NameToLayer("Overlay"));
			foreach (MeshRenderer meshRenderer in base.GetComponentsInChildren<MeshRenderer>())
			{
				if (meshRenderer.shadowCastingMode == ShadowCastingMode.ShadowsOnly)
				{
					meshRenderer.enabled = false;
				}
				else
				{
					meshRenderer.shadowCastingMode = ShadowCastingMode.Off;
				}
			}
			foreach (SkinnedMeshRenderer skinnedMeshRenderer in base.GetComponentsInChildren<SkinnedMeshRenderer>())
			{
				if (skinnedMeshRenderer.shadowCastingMode == ShadowCastingMode.ShadowsOnly)
				{
					skinnedMeshRenderer.enabled = false;
				}
				else
				{
					skinnedMeshRenderer.shadowCastingMode = ShadowCastingMode.Off;
				}
			}
		}

		// Token: 0x04003123 RID: 12579
		public CharacterDisplay.SlotAlignmentPoint[] AlignmentPoints;

		// Token: 0x04003124 RID: 12580
		[Header("References")]
		public Transform Container;

		// Token: 0x04003125 RID: 12581
		public Avatar ParentAvatar;

		// Token: 0x04003126 RID: 12582
		public Avatar Avatar;

		// Token: 0x04003127 RID: 12583
		public Transform AvatarContainer;

		// Token: 0x04003128 RID: 12584
		private float targetRotation;

		// Token: 0x020009C9 RID: 2505
		[Serializable]
		public class SlotAlignmentPoint
		{
			// Token: 0x04003129 RID: 12585
			public EClothingSlot SlotType;

			// Token: 0x0400312A RID: 12586
			public Transform Point;
		}
	}
}
