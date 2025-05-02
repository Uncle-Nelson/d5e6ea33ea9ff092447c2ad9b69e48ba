using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x020009DE RID: 2526
	public class DocumentViewer : Singleton<DocumentViewer>
	{
		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06004430 RID: 17456 RVA: 0x0011E063 File Offset: 0x0011C263
		// (set) Token: 0x06004431 RID: 17457 RVA: 0x0011E06B File Offset: 0x0011C26B
		public bool IsOpen { get; protected set; }

		// Token: 0x06004432 RID: 17458 RVA: 0x0011E074 File Offset: 0x0011C274
		protected override void Start()
		{
			base.Start();
			this.IsOpen = false;
			this.Canvas.enabled = false;
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 15);
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x0011E0A2 File Offset: 0x0011C2A2
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.IsOpen)
			{
				return;
			}
			if (action.exitType == ExitType.Escape)
			{
				action.used = true;
				this.Close();
			}
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x0011E0CC File Offset: 0x0011C2CC
		public void Open(string documentName)
		{
			this.IsOpen = true;
			for (int i = 0; i < this.Documents.Length; i++)
			{
				this.Documents[i].gameObject.SetActive(this.Documents[i].name == documentName);
			}
			this.Canvas.enabled = true;
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(true, 0f);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
			Singleton<HUD>.Instance.canvas.enabled = false;
			if (this.onOpen != null)
			{
				this.onOpen.Invoke();
			}
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x0011E1A4 File Offset: 0x0011C3A4
		public void Close()
		{
			this.IsOpen = false;
			this.Canvas.enabled = false;
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(false, 0f);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			Singleton<HUD>.Instance.canvas.enabled = true;
		}

		// Token: 0x040031BA RID: 12730
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040031BB RID: 12731
		public RectTransform[] Documents;

		// Token: 0x040031BC RID: 12732
		public UnityEvent onOpen;
	}
}
