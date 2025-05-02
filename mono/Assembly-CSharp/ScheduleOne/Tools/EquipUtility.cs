using System;
using EasyButtons;
using ScheduleOne.AvatarFramework;
using ScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000856 RID: 2134
	public class EquipUtility : MonoBehaviour
	{
		// Token: 0x06003A6A RID: 14954 RVA: 0x000F6B4B File Offset: 0x000F4D4B
		public void Update()
		{
			if (Input.GetKeyDown(KeyCode.Q))
			{
				this.Equip();
			}
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x000F6B5C File Offset: 0x000F4D5C
		[Button]
		public void Equip()
		{
			base.GetComponent<Avatar>().SetEquippable(this.Equippable.AssetPath);
		}

		// Token: 0x06003A6C RID: 14956 RVA: 0x000F6B75 File Offset: 0x000F4D75
		[Button]
		public void Unequip()
		{
			base.GetComponent<Avatar>().SetEquippable(string.Empty);
		}

		// Token: 0x04002A11 RID: 10769
		public AvatarEquippable Equippable;
	}
}
