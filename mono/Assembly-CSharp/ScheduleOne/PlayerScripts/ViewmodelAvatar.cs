using System;
using ScheduleOne.AvatarFramework;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x02000609 RID: 1545
	public class ViewmodelAvatar : Singleton<ViewmodelAvatar>
	{
		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600284F RID: 10319 RVA: 0x000A5BEE File Offset: 0x000A3DEE
		// (set) Token: 0x06002850 RID: 10320 RVA: 0x000A5BF6 File Offset: 0x000A3DF6
		public bool IsVisible { get; private set; }

		// Token: 0x06002851 RID: 10321 RVA: 0x000A5C00 File Offset: 0x000A3E00
		protected override void Awake()
		{
			base.Awake();
			this.baseOffset = base.transform.localPosition;
			this.SetVisibility(false);
			if (this.ParentAvatar.CurrentSettings != null)
			{
				this.SetAppearance(this.ParentAvatar.CurrentSettings);
			}
			this.ParentAvatar.onSettingsLoaded.AddListener(new UnityAction(delegate()
			{
				this.SetAppearance(this.ParentAvatar.CurrentSettings);
			}));
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x000A5C6B File Offset: 0x000A3E6B
		public void SetVisibility(bool isVisible)
		{
			this.SetOffset(Vector3.zero);
			this.IsVisible = isVisible;
			base.gameObject.SetActive(isVisible);
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x000A5C8C File Offset: 0x000A3E8C
		public void SetAppearance(AvatarSettings settings)
		{
			AvatarSettings avatarSettings = Object.Instantiate<AvatarSettings>(settings);
			avatarSettings.Height = 0.25f;
			this.Avatar.LoadAvatarSettings(avatarSettings);
			LayerUtility.SetLayerRecursively(base.gameObject, LayerMask.NameToLayer("Viewmodel"));
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

		// Token: 0x06002854 RID: 10324 RVA: 0x000A5D37 File Offset: 0x000A3F37
		public void SetAnimatorController(RuntimeAnimatorController controller)
		{
			this.Animator.runtimeAnimatorController = controller;
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x000A5D45 File Offset: 0x000A3F45
		public void SetOffset(Vector3 offset)
		{
			base.transform.localPosition = this.baseOffset + offset;
		}

		// Token: 0x04001D60 RID: 7520
		public Avatar ParentAvatar;

		// Token: 0x04001D61 RID: 7521
		public Animator Animator;

		// Token: 0x04001D62 RID: 7522
		public Avatar Avatar;

		// Token: 0x04001D63 RID: 7523
		public Transform RightHandContainer;

		// Token: 0x04001D64 RID: 7524
		private Vector3 baseOffset;
	}
}
