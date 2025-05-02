using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;
using ScheduleOne.UI.Input;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x02000583 RID: 1411
	public class ManagementMode : Singleton<ManagementMode>
	{
		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06002323 RID: 8995 RVA: 0x0008FFC7 File Offset: 0x0008E1C7
		// (set) Token: 0x06002324 RID: 8996 RVA: 0x0008FFCF File Offset: 0x0008E1CF
		public Property CurrentProperty { get; private set; }

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x0008FFD8 File Offset: 0x0008E1D8
		public bool isActive
		{
			get
			{
				return this.CurrentProperty != null;
			}
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x0008FFE6 File Offset: 0x0008E1E6
		protected override void Start()
		{
			base.Start();
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 1);
			this.Canvas.enabled = false;
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x0009000C File Offset: 0x0008E20C
		private void Update()
		{
			this.UpdateInput();
			if (this.isActive && Player.Local.CurrentProperty != this.CurrentProperty)
			{
				this.ExitManagementMode();
			}
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x0009003C File Offset: 0x0008E23C
		private void UpdateInput()
		{
			if (!Singleton<GameInput>.InstanceExists)
			{
				return;
			}
			this.ManagementModeInputPrompt.enabled = (this.isActive ? ManagementMode.CanExitManagementMode() : ManagementMode.CanEnterManagementMode());
			this.ManagementModeInputPrompt.Label = (this.isActive ? "Exit Management Mode" : "Enter Management Mode");
			if (GameInput.GetButtonDown(GameInput.ButtonCode.ManagementMode))
			{
				if (this.CurrentProperty != null)
				{
					this.ExitManagementMode();
					return;
				}
				if (Player.Local.CurrentProperty != null && Player.Local.CurrentProperty.IsOwned)
				{
					this.EnterManagementMode(Player.Local.CurrentProperty);
				}
			}
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x000900E0 File Offset: 0x0008E2E0
		private void Exit(ExitAction exitAction)
		{
			if (!this.isActive)
			{
				return;
			}
			if (exitAction.used)
			{
				return;
			}
			if (exitAction.exitType == ExitType.Escape)
			{
				this.ExitManagementMode();
				exitAction.used = true;
			}
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x0009010C File Offset: 0x0008E30C
		public void EnterManagementMode(Property property)
		{
			this.CurrentProperty = property;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			this.Canvas.enabled = true;
			if (this.OnEnterManagementMode != null)
			{
				this.OnEnterManagementMode.Invoke();
			}
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x0009015C File Offset: 0x0008E35C
		public void ExitManagementMode()
		{
			this.CurrentProperty = null;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			this.Canvas.enabled = false;
			if (this.onExitManagementMode != null)
			{
				this.onExitManagementMode.Invoke();
			}
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x000901AA File Offset: 0x0008E3AA
		public static bool CanEnterManagementMode()
		{
			return !(Player.Local.CurrentProperty == null) && PlayerSingleton<PlayerCamera>.Instance.activeUIElementCount <= 0;
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x000022C9 File Offset: 0x000004C9
		public static bool CanExitManagementMode()
		{
			return true;
		}

		// Token: 0x04001A4F RID: 6735
		[Header("References")]
		public InputPrompt ManagementModeInputPrompt;

		// Token: 0x04001A50 RID: 6736
		[Header("UI References")]
		public Canvas Canvas;

		// Token: 0x04001A51 RID: 6737
		public UnityEvent OnEnterManagementMode;

		// Token: 0x04001A52 RID: 6738
		public UnityEvent onExitManagementMode;
	}
}
