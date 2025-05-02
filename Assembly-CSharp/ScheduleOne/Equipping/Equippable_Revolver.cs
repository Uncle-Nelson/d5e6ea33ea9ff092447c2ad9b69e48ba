using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000929 RID: 2345
	public class Equippable_Revolver : Equippable_RangedWeapon
	{
		// Token: 0x06003F7B RID: 16251 RVA: 0x0010C133 File Offset: 0x0010A333
		public override void Equip(ItemInstance item)
		{
			base.Equip(item);
			this.SetDisplayedBullets(this.weaponItem.Value);
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x0010C14D File Offset: 0x0010A34D
		public override void Fire()
		{
			base.Fire();
			this.SetDisplayedBullets(this.weaponItem.Value);
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x0010C166 File Offset: 0x0010A366
		public override void Reload()
		{
			base.Reload();
			this.SetDisplayedBullets(this.weaponItem.Value);
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x0010C17F File Offset: 0x0010A37F
		protected override void NotifyIncrementalReload()
		{
			base.NotifyIncrementalReload();
			this.SetDisplayedBullets(this.weaponItem.Value);
		}

		// Token: 0x06003F7F RID: 16255 RVA: 0x0010C198 File Offset: 0x0010A398
		private void SetDisplayedBullets(int count)
		{
			for (int i = 0; i < this.Bullets.Length; i++)
			{
				this.Bullets[i].gameObject.SetActive(i < count);
			}
		}

		// Token: 0x04002DB0 RID: 11696
		public Transform[] Bullets;
	}
}
