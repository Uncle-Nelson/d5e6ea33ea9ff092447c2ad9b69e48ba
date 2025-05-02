using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x020009EF RID: 2543
	public class GenericUIScreen : MonoBehaviour
	{
		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06004496 RID: 17558 RVA: 0x0011F70F File Offset: 0x0011D90F
		// (set) Token: 0x06004497 RID: 17559 RVA: 0x0011F717 File Offset: 0x0011D917
		public bool IsOpen { get; private set; }

		// Token: 0x06004498 RID: 17560 RVA: 0x0011F720 File Offset: 0x0011D920
		private void Awake()
		{
			if (this.UseExitActions)
			{
				GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), this.ExitActionPriority);
			}
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x0011F744 File Offset: 0x0011D944
		public void Open()
		{
			this.IsOpen = true;
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(this.Name);
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			if (this.onOpen != null)
			{
				this.onOpen.Invoke();
			}
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x0011F7A8 File Offset: 0x0011D9A8
		public void Close()
		{
			this.IsOpen = false;
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(this.Name);
			if (this.ReenableControlsOnClose)
			{
				PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
				PlayerSingleton<PlayerCamera>.Instance.LockMouse();
				PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			}
			if (this.ReenableInventoryOnClose)
			{
				PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			}
			if (!this.ReenableEquippingOnClose)
			{
				PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			}
			if (this.onClose != null)
			{
				this.onClose.Invoke();
			}
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x0011F82D File Offset: 0x0011DA2D
		private void Exit(ExitAction action)
		{
			if (!this.IsOpen)
			{
				return;
			}
			if (action.used)
			{
				return;
			}
			if (this.CanExitWithRightClick || action.exitType == ExitType.Escape)
			{
				action.used = true;
				this.Close();
			}
		}

		// Token: 0x0400320C RID: 12812
		[Header("Settings")]
		public string Name;

		// Token: 0x0400320D RID: 12813
		public bool UseExitActions = true;

		// Token: 0x0400320E RID: 12814
		public int ExitActionPriority;

		// Token: 0x0400320F RID: 12815
		public bool CanExitWithRightClick = true;

		// Token: 0x04003210 RID: 12816
		public bool ReenableControlsOnClose = true;

		// Token: 0x04003211 RID: 12817
		public bool ReenableInventoryOnClose = true;

		// Token: 0x04003212 RID: 12818
		public bool ReenableEquippingOnClose = true;

		// Token: 0x04003213 RID: 12819
		public UnityEvent onOpen;

		// Token: 0x04003214 RID: 12820
		public UnityEvent onClose;
	}
}
