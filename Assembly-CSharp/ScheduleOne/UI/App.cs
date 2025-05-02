using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.Phone;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A18 RID: 2584
	public abstract class App<T> : PlayerSingleton<T> where T : PlayerSingleton<T>
	{
		// Token: 0x060045A4 RID: 17828 RVA: 0x0012416D File Offset: 0x0012236D
		public static App<T> GetApp(int index)
		{
			if (index < 0 || index >= App<T>.Apps.Count)
			{
				return null;
			}
			return App<T>.Apps[index];
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x060045A5 RID: 17829 RVA: 0x0012418D File Offset: 0x0012238D
		// (set) Token: 0x060045A6 RID: 17830 RVA: 0x00124195 File Offset: 0x00122395
		public bool isOpen { get; protected set; }

		// Token: 0x060045A7 RID: 17831 RVA: 0x001241A0 File Offset: 0x001223A0
		public override void OnStartClient(bool IsOwner)
		{
			base.OnStartClient(IsOwner);
			if (!IsOwner)
			{
				return;
			}
			if (!this.AvailableInTutorial && NetworkSingleton<GameManager>.Instance.IsTutorial)
			{
				this.appContainer.gameObject.SetActive(false);
				return;
			}
			this.GenerateHomeScreenIcon();
			App<T>.Apps.Add(this);
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x001241F0 File Offset: 0x001223F0
		protected override void Start()
		{
			base.Start();
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 1);
			Phone instance = PlayerSingleton<Phone>.Instance;
			instance.closeApps = (Action)Delegate.Combine(instance.closeApps, new Action(this.Close));
			Phone instance2 = PlayerSingleton<Phone>.Instance;
			instance2.onPhoneOpened = (Action)Delegate.Combine(instance2.onPhoneOpened, new Action(this.OnPhoneOpened));
			this.SetOpen(false);
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x0012426A File Offset: 0x0012246A
		private void Close()
		{
			if (this.isOpen)
			{
				this.SetOpen(false);
			}
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x0012427B File Offset: 0x0012247B
		protected virtual void Update()
		{
			if (this.isOpen && PlayerSingleton<Phone>.Instance.IsOpen && this.IsHoveringButton() && GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick))
			{
				this.SetOpen(false);
			}
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x001242A8 File Offset: 0x001224A8
		private bool IsHoveringButton()
		{
			RaycastHit raycastHit;
			return Physics.Raycast(Singleton<GameplayMenu>.Instance.OverlayCamera.ScreenPointToRay(Input.mousePosition), ref raycastHit, 2f, 1 << LayerMask.NameToLayer("Overlay")) && raycastHit.collider.gameObject.name == "Button";
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x00124308 File Offset: 0x00122508
		private void GenerateHomeScreenIcon()
		{
			this.appIconButton = PlayerSingleton<HomeScreen>.Instance.GenerateAppIcon<T>(this);
			this.appIconButton.onClick.AddListener(new UnityAction(this.ShortcutClicked));
			this.notificationContainer = this.appIconButton.transform.Find("Notifications").GetComponent<RectTransform>();
			this.notificationText = this.notificationContainer.Find("Text").GetComponent<Text>();
			this.notificationContainer.gameObject.SetActive(false);
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x0012438E File Offset: 0x0012258E
		public void SetNotificationCount(int amount)
		{
			this.notificationText.text = amount.ToString();
			this.notificationContainer.gameObject.SetActive(amount > 0);
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x001243B6 File Offset: 0x001225B6
		protected virtual void OnPhoneOpened()
		{
			if (this.isOpen)
			{
				if (this.Orientation == App<T>.EOrientation.Horizontal)
				{
					PlayerSingleton<Phone>.Instance.SetLookOffsetMultiplier(0.6f);
					return;
				}
				PlayerSingleton<Phone>.Instance.SetLookOffsetMultiplier(1f);
			}
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x001243E7 File Offset: 0x001225E7
		private void ShortcutClicked()
		{
			this.SetOpen(!this.isOpen);
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x001243F8 File Offset: 0x001225F8
		public virtual void Exit(ExitAction exit)
		{
			if (exit.used)
			{
				return;
			}
			if (this.isOpen && PlayerSingleton<Phone>.InstanceExists && PlayerSingleton<Phone>.Instance.IsOpen)
			{
				exit.used = true;
				this.SetOpen(false);
			}
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x0012442C File Offset: 0x0012262C
		public virtual void SetOpen(bool open)
		{
			if (open && Phone.ActiveApp != null)
			{
				Console.LogWarning(Phone.ActiveApp.name + " is already open", null);
			}
			this.isOpen = open;
			PlayerSingleton<AppsCanvas>.Instance.SetIsOpen(open);
			PlayerSingleton<HomeScreen>.Instance.SetIsOpen(!open);
			if (this.isOpen)
			{
				if (this.Orientation == App<T>.EOrientation.Horizontal)
				{
					PlayerSingleton<Phone>.Instance.SetIsHorizontal(true);
					PlayerSingleton<Phone>.Instance.SetLookOffsetMultiplier(0.6f);
				}
				else
				{
					PlayerSingleton<Phone>.Instance.SetLookOffsetMultiplier(1f);
				}
				Phone.ActiveApp = base.gameObject;
			}
			else
			{
				if (Phone.ActiveApp == base.gameObject)
				{
					Phone.ActiveApp = null;
				}
				PlayerSingleton<Phone>.Instance.SetIsHorizontal(false);
				PlayerSingleton<Phone>.Instance.SetLookOffsetMultiplier(1f);
				Singleton<CursorManager>.Instance.SetCursorAppearance(CursorManager.ECursorType.Default);
			}
			this.appContainer.gameObject.SetActive(open);
		}

		// Token: 0x0400333D RID: 13117
		public static List<App<T>> Apps = new List<App<T>>();

		// Token: 0x0400333E RID: 13118
		[Header("Settings")]
		public string AppName;

		// Token: 0x0400333F RID: 13119
		public string IconLabel;

		// Token: 0x04003340 RID: 13120
		public Sprite AppIcon;

		// Token: 0x04003341 RID: 13121
		public App<T>.EOrientation Orientation;

		// Token: 0x04003342 RID: 13122
		public bool AvailableInTutorial = true;

		// Token: 0x04003343 RID: 13123
		[Header("References")]
		[SerializeField]
		protected RectTransform appContainer;

		// Token: 0x04003344 RID: 13124
		protected RectTransform notificationContainer;

		// Token: 0x04003345 RID: 13125
		protected Text notificationText;

		// Token: 0x04003347 RID: 13127
		protected Button appIconButton;

		// Token: 0x02000A19 RID: 2585
		public enum EOrientation
		{
			// Token: 0x04003349 RID: 13129
			Horizontal,
			// Token: 0x0400334A RID: 13130
			Vertical
		}
	}
}
