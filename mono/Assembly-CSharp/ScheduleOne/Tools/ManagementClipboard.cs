using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using ScheduleOne.UI.Management;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x0200083D RID: 2109
	public class ManagementClipboard : Singleton<ManagementClipboard>
	{
		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06003A0A RID: 14858 RVA: 0x000F5951 File Offset: 0x000F3B51
		// (set) Token: 0x06003A0B RID: 14859 RVA: 0x000F5959 File Offset: 0x000F3B59
		public bool IsOpen { get; protected set; }

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06003A0C RID: 14860 RVA: 0x000F5962 File Offset: 0x000F3B62
		// (set) Token: 0x06003A0D RID: 14861 RVA: 0x000F596A File Offset: 0x000F3B6A
		public bool StatePreserved { get; protected set; }

		// Token: 0x06003A0E RID: 14862 RVA: 0x000F5974 File Offset: 0x000F3B74
		protected override void Awake()
		{
			base.Awake();
			this.ClipboardTransform.gameObject.SetActive(false);
			this.ClipboardTransform.localPosition = new Vector3(this.ClipboardTransform.localPosition.x, this.ClosedOffset, this.ClipboardTransform.localPosition.z);
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 10);
		}

		// Token: 0x06003A0F RID: 14863 RVA: 0x000F59E4 File Offset: 0x000F3BE4
		private void Update()
		{
			for (int i = 0; i < this.CurrentConfigurables.Count; i++)
			{
				if (this.CurrentConfigurables[i].IsBeingConfiguredByOtherPlayer)
				{
					this.Close(false);
				}
			}
		}

		// Token: 0x06003A10 RID: 14864 RVA: 0x000F5A21 File Offset: 0x000F3C21
		private void Exit(ExitAction exitAction)
		{
			if (!this.IsOpen)
			{
				return;
			}
			if (exitAction.used)
			{
				return;
			}
			this.Close(false);
			exitAction.used = true;
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x000F5A44 File Offset: 0x000F3C44
		public void Open(List<IConfigurable> selection, ManagementClipboard_Equippable equippable)
		{
			this.IsOpen = true;
			this.OverlayCamera.enabled = true;
			this.OverlayLight.enabled = true;
			this.ClipboardTransform.gameObject.SetActive(true);
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(true, 0.06f);
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(true, 0.06f);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			this.SelectionInfo.Set(selection);
			this.LerpToVerticalPosition(true, null);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			Singleton<ManagementInterface>.Instance.Open(selection, equippable);
			this.CurrentConfigurables.AddRange(selection);
			for (int i = 0; i < this.CurrentConfigurables.Count; i++)
			{
				this.CurrentConfigurables[i].SetConfigurer(Player.Local.NetworkObject);
			}
			if (this.onOpened != null)
			{
				this.onOpened.Invoke();
			}
		}

		// Token: 0x06003A12 RID: 14866 RVA: 0x000F5B44 File Offset: 0x000F3D44
		public void Close(bool preserveState = false)
		{
			this.IsOpen = false;
			this.StatePreserved = preserveState;
			this.OverlayLight.enabled = false;
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(false, 0.06f);
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			Singleton<ManagementInterface>.Instance.Close(preserveState);
			if (this.onClosed != null)
			{
				this.onClosed.Invoke();
			}
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			for (int i = 0; i < this.CurrentConfigurables.Count; i++)
			{
				if (this.CurrentConfigurables[i].CurrentPlayerConfigurer == Player.Local.NetworkObject)
				{
					this.CurrentConfigurables[i].SetConfigurer(null);
				}
			}
			this.CurrentConfigurables.Clear();
			this.LerpToVerticalPosition(false, delegate
			{
				this.<Close>g__Done|25_1();
			});
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x000F5C34 File Offset: 0x000F3E34
		private void LerpToVerticalPosition(bool open, Action callback)
		{
			ManagementClipboard.<>c__DisplayClass26_0 CS$<>8__locals1 = new ManagementClipboard.<>c__DisplayClass26_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callback = callback;
			CS$<>8__locals1.endPos = new Vector3(this.ClipboardTransform.localPosition.x, open ? 0f : this.ClosedOffset, this.ClipboardTransform.localPosition.z);
			CS$<>8__locals1.startPos = this.ClipboardTransform.localPosition;
			if (this.lerpRoutine != null)
			{
				base.StopCoroutine(this.lerpRoutine);
			}
			this.lerpRoutine = base.StartCoroutine(CS$<>8__locals1.<LerpToVerticalPosition>g__Lerp|0());
		}

		// Token: 0x06003A16 RID: 14870 RVA: 0x000F5CED File Offset: 0x000F3EED
		[CompilerGenerated]
		private void <Close>g__Done|25_1()
		{
			if (!Singleton<GameplayMenu>.Instance.IsOpen)
			{
				this.ClipboardTransform.gameObject.SetActive(false);
				this.OverlayCamera.enabled = false;
			}
		}

		// Token: 0x040029BE RID: 10686
		public bool IsEquipped;

		// Token: 0x040029C1 RID: 10689
		public const float OpenTime = 0.06f;

		// Token: 0x040029C2 RID: 10690
		[Header("References")]
		public Transform ClipboardTransform;

		// Token: 0x040029C3 RID: 10691
		public Camera OverlayCamera;

		// Token: 0x040029C4 RID: 10692
		public Light OverlayLight;

		// Token: 0x040029C5 RID: 10693
		public SelectionInfoUI SelectionInfo;

		// Token: 0x040029C6 RID: 10694
		[Header("Settings")]
		public float ClosedOffset = -0.2f;

		// Token: 0x040029C7 RID: 10695
		public UnityEvent onClipboardEquipped;

		// Token: 0x040029C8 RID: 10696
		public UnityEvent onClipboardUnequipped;

		// Token: 0x040029C9 RID: 10697
		public UnityEvent onOpened;

		// Token: 0x040029CA RID: 10698
		public UnityEvent onClosed;

		// Token: 0x040029CB RID: 10699
		private Coroutine lerpRoutine;

		// Token: 0x040029CC RID: 10700
		private List<IConfigurable> CurrentConfigurables = new List<IConfigurable>();
	}
}
