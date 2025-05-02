using System;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006F7 RID: 1783
	public static class PlayerUtilities
	{
		// Token: 0x06003079 RID: 12409 RVA: 0x000C9E51 File Offset: 0x000C8051
		public static void OpenMenu()
		{
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			Singleton<HUD>.Instance.SetCrosshairVisible(false);
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x000C9E89 File Offset: 0x000C8089
		public static void CloseMenu(bool reenableLookInstantly = false, bool reenableInventory = true)
		{
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			if (reenableLookInstantly)
			{
				PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
			}
			if (reenableInventory)
			{
				PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			}
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			Singleton<HUD>.Instance.SetCrosshairVisible(true);
		}
	}
}
