using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x0200091F RID: 2335
	public class Equippable_AvatarViewmodel : Equippable_Viewmodel
	{
		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06003F26 RID: 16166 RVA: 0x0010A75B File Offset: 0x0010895B
		protected bool equipAnimDone
		{
			get
			{
				return this.timeEquipped >= this.EquipTime;
			}
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x0010A770 File Offset: 0x00108970
		public override void Equip(ItemInstance item)
		{
			base.transform.SetParent(Singleton<ViewmodelAvatar>.Instance.RightHandContainer);
			if (this.AnimatorController != null)
			{
				Singleton<ViewmodelAvatar>.Instance.SetAnimatorController(this.AnimatorController);
				Singleton<ViewmodelAvatar>.Instance.SetVisibility(true);
				Singleton<ViewmodelAvatar>.Instance.SetOffset(this.ViewmodelAvatarOffset);
			}
			base.Equip(item);
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x0010A7D2 File Offset: 0x001089D2
		public override void Unequip()
		{
			base.Unequip();
			Singleton<ViewmodelAvatar>.Instance.SetVisibility(false);
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x0010A7E5 File Offset: 0x001089E5
		protected override void PlayEquipAnimation()
		{
			base.PlayEquipAnimation();
			if (this.EquipTrigger != string.Empty)
			{
				Singleton<ViewmodelAvatar>.Instance.Animator.SetTrigger(this.EquipTrigger);
			}
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x0010A814 File Offset: 0x00108A14
		protected override void Update()
		{
			base.Update();
			this.timeEquipped += Time.deltaTime;
		}

		// Token: 0x04002D51 RID: 11601
		public RuntimeAnimatorController AnimatorController;

		// Token: 0x04002D52 RID: 11602
		public Vector3 ViewmodelAvatarOffset = Vector3.zero;

		// Token: 0x04002D53 RID: 11603
		[Header("Equipping")]
		public float EquipTime = 0.4f;

		// Token: 0x04002D54 RID: 11604
		public string EquipTrigger = "Equip";

		// Token: 0x04002D55 RID: 11605
		protected float timeEquipped;
	}
}
