using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace ScheduleOne.UI
{
	// Token: 0x020009CC RID: 2508
	public class ConsoleUI : MonoBehaviour
	{
		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06004396 RID: 17302 RVA: 0x0011B1A9 File Offset: 0x001193A9
		public bool IS_CONSOLE_ENABLED
		{
			get
			{
				return (NetworkSingleton<GameManager>.Instance.Settings.ConsoleEnabled && InstanceFinder.IsServer) || Application.isEditor;
			}
		}

		// Token: 0x06004397 RID: 17303 RVA: 0x0011B1CC File Offset: 0x001193CC
		private void Awake()
		{
			this.InputField.onSubmit.AddListener(new UnityAction<string>(this.Submit));
			this.Container.gameObject.SetActive(false);
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 5);
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x0011B218 File Offset: 0x00119418
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.BackQuote) && !Singleton<PauseMenu>.Instance.IsPaused && this.IS_CONSOLE_ENABLED)
			{
				this.SetIsOpen(!this.canvas.enabled);
			}
			if (!this.canvas.enabled)
			{
				return;
			}
			if (!Player.Local.Health.IsAlive)
			{
				this.SetIsOpen(false);
			}
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x0011B27C File Offset: 0x0011947C
		private void Exit(ExitAction exitAction)
		{
			if (this.canvas == null)
			{
				return;
			}
			if (!this.canvas.enabled)
			{
				return;
			}
			if (exitAction.used)
			{
				return;
			}
			if (exitAction.exitType == ExitType.Escape)
			{
				exitAction.used = true;
				this.SetIsOpen(false);
			}
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x0011B2BC File Offset: 0x001194BC
		public void SetIsOpen(bool open)
		{
			if (!InstanceFinder.IsHost && InstanceFinder.NetworkManager != null && !Application.isEditor && !Debug.isDebugBuild)
			{
				return;
			}
			this.canvas.enabled = open;
			this.Container.gameObject.SetActive(open);
			this.InputField.SetTextWithoutNotify("");
			if (open)
			{
				PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
				GameInput.IsTyping = true;
				base.StartCoroutine(this.<SetIsOpen>g__Routine|8_0());
				return;
			}
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			GameInput.IsTyping = false;
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x0011B356 File Offset: 0x00119556
		public void Submit(string val)
		{
			if (!this.canvas.enabled)
			{
				return;
			}
			Console.SubmitCommand(val);
			this.SetIsOpen(false);
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x0011B373 File Offset: 0x00119573
		[CompilerGenerated]
		private IEnumerator <SetIsOpen>g__Routine|8_0()
		{
			yield return null;
			EventSystem.current.SetSelectedGameObject(null);
			EventSystem.current.SetSelectedGameObject(this.InputField.gameObject);
			yield break;
		}

		// Token: 0x04003131 RID: 12593
		[Header("References")]
		public Canvas canvas;

		// Token: 0x04003132 RID: 12594
		public TMP_InputField InputField;

		// Token: 0x04003133 RID: 12595
		public GameObject Container;
	}
}
