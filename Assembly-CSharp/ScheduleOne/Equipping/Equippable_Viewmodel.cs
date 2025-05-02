using System;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Rendering;

namespace ScheduleOne.Equipping
{
	// Token: 0x0200092C RID: 2348
	public class Equippable_Viewmodel : Equippable_StorableItem
	{
		// Token: 0x06003F8A RID: 16266 RVA: 0x0010C370 File Offset: 0x0010A570
		public override void Equip(ItemInstance item)
		{
			base.Equip(item);
			base.transform.localPosition = this.localPosition;
			base.transform.localEulerAngles = this.localEulerAngles;
			base.transform.localScale = this.localScale;
			LayerUtility.SetLayerRecursively(base.gameObject, LayerMask.NameToLayer("Viewmodel"));
			foreach (MeshRenderer meshRenderer in base.gameObject.GetComponentsInChildren<MeshRenderer>())
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
			this.PlayEquipAnimation();
		}

		// Token: 0x06003F8B RID: 16267 RVA: 0x0010C409 File Offset: 0x0010A609
		public override void Unequip()
		{
			base.Unequip();
			this.PlayUnequipAnimation();
		}

		// Token: 0x06003F8C RID: 16268 RVA: 0x0010C417 File Offset: 0x0010A617
		protected virtual void PlayEquipAnimation()
		{
			if (this.AvatarEquippable != null)
			{
				Player.Local.SendEquippable_Networked(this.AvatarEquippable.AssetPath);
			}
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x0010C43C File Offset: 0x0010A63C
		protected virtual void PlayUnequipAnimation()
		{
			if (this.AvatarEquippable != null)
			{
				Player.Local.SendEquippable_Networked(string.Empty);
			}
		}

		// Token: 0x04002DB5 RID: 11701
		[Header("Viewmodel settings")]
		public Vector3 localPosition;

		// Token: 0x04002DB6 RID: 11702
		public Vector3 localEulerAngles;

		// Token: 0x04002DB7 RID: 11703
		public Vector3 localScale = Vector3.one;

		// Token: 0x04002DB8 RID: 11704
		[Header("Third person animation settings")]
		public AvatarEquippable AvatarEquippable;
	}
}
