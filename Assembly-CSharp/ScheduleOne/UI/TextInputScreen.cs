using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A51 RID: 2641
	public class TextInputScreen : Singleton<TextInputScreen>
	{
		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06004726 RID: 18214 RVA: 0x0012A148 File Offset: 0x00128348
		public bool IsOpen
		{
			get
			{
				return this.Canvas.enabled;
			}
		}

		// Token: 0x06004727 RID: 18215 RVA: 0x0012A155 File Offset: 0x00128355
		protected override void Awake()
		{
			base.Awake();
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 2);
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x0012A16F File Offset: 0x0012836F
		public void Submit()
		{
			this.Close(true);
		}

		// Token: 0x06004729 RID: 18217 RVA: 0x0012A178 File Offset: 0x00128378
		public void Cancel()
		{
			this.Close(false);
		}

		// Token: 0x0600472A RID: 18218 RVA: 0x0012A181 File Offset: 0x00128381
		private void Update()
		{
			if (!this.IsOpen)
			{
				return;
			}
			if (Input.GetKeyDown(KeyCode.Return))
			{
				this.Submit();
			}
		}

		// Token: 0x0600472B RID: 18219 RVA: 0x0012A19B File Offset: 0x0012839B
		public void Exit(ExitAction action)
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
				this.Close(false);
			}
		}

		// Token: 0x0600472C RID: 18220 RVA: 0x0012A1C8 File Offset: 0x001283C8
		public void Open(string header, string text, TextInputScreen.OnSubmit _onSubmit, int maxChars = 10000)
		{
			this.HeaderLabel.text = header;
			this.InputField.SetTextWithoutNotify(text);
			this.Canvas.enabled = true;
			this.InputField.characterLimit = maxChars;
			this.InputField.ActivateInputField();
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			this.onSubmit = _onSubmit;
		}

		// Token: 0x0600472D RID: 18221 RVA: 0x0012A254 File Offset: 0x00128454
		private void Close(bool submit)
		{
			this.Canvas.enabled = false;
			this.InputField.DeactivateInputField(false);
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			if (submit)
			{
				string text = this.InputField.text;
				if (this.onSubmit != null)
				{
					this.onSubmit(text);
				}
			}
		}

		// Token: 0x04003495 RID: 13461
		public Canvas Canvas;

		// Token: 0x04003496 RID: 13462
		public TextMeshProUGUI HeaderLabel;

		// Token: 0x04003497 RID: 13463
		public TMP_InputField InputField;

		// Token: 0x04003498 RID: 13464
		private TextInputScreen.OnSubmit onSubmit;

		// Token: 0x02000A52 RID: 2642
		// (Invoke) Token: 0x06004730 RID: 18224
		public delegate void OnSubmit(string text);
	}
}
