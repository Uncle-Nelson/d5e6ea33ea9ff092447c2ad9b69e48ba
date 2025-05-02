using System;
using System.Collections;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000AA1 RID: 2721
	public class HomeScreen : PlayerSingleton<HomeScreen>
	{
		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06004932 RID: 18738 RVA: 0x00132E22 File Offset: 0x00131022
		// (set) Token: 0x06004933 RID: 18739 RVA: 0x00132E2A File Offset: 0x0013102A
		public bool isOpen { get; protected set; } = true;

		// Token: 0x06004934 RID: 18740 RVA: 0x00132E33 File Offset: 0x00131033
		protected override void Start()
		{
			base.Start();
			this.SetIsOpen(true);
		}

		// Token: 0x06004935 RID: 18741 RVA: 0x00132E44 File Offset: 0x00131044
		public override void OnStartClient(bool IsOwner)
		{
			base.OnStartClient(IsOwner);
			if (!IsOwner)
			{
				return;
			}
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
			Phone instance2 = PlayerSingleton<Phone>.Instance;
			instance2.onPhoneOpened = (Action)Delegate.Combine(instance2.onPhoneOpened, new Action(this.PhoneOpened));
			Phone instance3 = PlayerSingleton<Phone>.Instance;
			instance3.onPhoneClosed = (Action)Delegate.Combine(instance3.onPhoneClosed, new Action(this.PhoneClosed));
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x00132ECF File Offset: 0x001310CF
		protected override void OnDestroy()
		{
			base.OnDestroy();
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			}
		}

		// Token: 0x06004937 RID: 18743 RVA: 0x00132F05 File Offset: 0x00131105
		protected void PhoneOpened()
		{
			if (this.isOpen)
			{
				this.SetCanvasActive(true);
			}
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x00132F16 File Offset: 0x00131116
		protected void PhoneClosed()
		{
			this.delayedSetOpenRoutine = base.StartCoroutine(this.DelayedSetCanvasActive(false, 0.25f));
		}

		// Token: 0x06004939 RID: 18745 RVA: 0x00132F30 File Offset: 0x00131130
		private IEnumerator DelayedSetCanvasActive(bool active, float delay)
		{
			yield return new WaitForSeconds(delay);
			this.delayedSetOpenRoutine = null;
			this.SetCanvasActive(active);
			yield break;
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x00132F4D File Offset: 0x0013114D
		public void SetIsOpen(bool o)
		{
			this.isOpen = o;
			this.SetCanvasActive(o);
		}

		// Token: 0x0600493B RID: 18747 RVA: 0x00132F5D File Offset: 0x0013115D
		public void SetCanvasActive(bool a)
		{
			if (this.delayedSetOpenRoutine != null)
			{
				base.StopCoroutine(this.delayedSetOpenRoutine);
			}
			this.canvas.enabled = a;
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x00132F80 File Offset: 0x00131180
		protected virtual void Update()
		{
			if (PlayerSingleton<Phone>.Instance.IsOpen && this.isOpen)
			{
				int num = -1;
				if (Input.GetKeyDown(KeyCode.Alpha1))
				{
					num = 0;
				}
				else if (Input.GetKeyDown(KeyCode.Alpha2))
				{
					num = 1;
				}
				else if (Input.GetKeyDown(KeyCode.Alpha3))
				{
					num = 2;
				}
				else if (Input.GetKeyDown(KeyCode.Alpha4))
				{
					num = 3;
				}
				else if (Input.GetKeyDown(KeyCode.Alpha5))
				{
					num = 4;
				}
				else if (Input.GetKeyDown(KeyCode.Alpha6))
				{
					num = 5;
				}
				else if (Input.GetKeyDown(KeyCode.Alpha7))
				{
					num = 6;
				}
				else if (Input.GetKeyDown(KeyCode.Alpha8))
				{
					num = 7;
				}
				else if (Input.GetKeyDown(KeyCode.Alpha9))
				{
					num = 8;
				}
				if (num != -1 && this.appIcons.Count > num)
				{
					this.appIcons[num].onClick.Invoke();
				}
			}
		}

		// Token: 0x0600493D RID: 18749 RVA: 0x00133044 File Offset: 0x00131244
		protected virtual void MinPass()
		{
			if (NetworkSingleton<GameManager>.Instance.IsTutorial)
			{
				int num = TimeManager.Get24HourTimeFromMinSum(Mathf.RoundToInt(Mathf.Round((float)NetworkSingleton<TimeManager>.Instance.DailyMinTotal / 60f) * 60f));
				this.timeText.text = TimeManager.Get12HourTime((float)num, true) + " " + NetworkSingleton<TimeManager>.Instance.CurrentDay.ToString();
				return;
			}
			this.timeText.text = TimeManager.Get12HourTime((float)NetworkSingleton<TimeManager>.Instance.CurrentTime, true) + " " + NetworkSingleton<TimeManager>.Instance.CurrentDay.ToString();
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x001330F8 File Offset: 0x001312F8
		public Button GenerateAppIcon<T>(App<T> prog) where T : PlayerSingleton<T>
		{
			RectTransform component = Object.Instantiate<GameObject>(this.appIconPrefab, this.appIconContainer).GetComponent<RectTransform>();
			component.Find("Mask/Image").GetComponent<Image>().sprite = prog.AppIcon;
			component.Find("Label").GetComponent<Text>().text = prog.IconLabel;
			this.appIcons.Add(component.GetComponent<Button>());
			return component.GetComponent<Button>();
		}

		// Token: 0x04003652 RID: 13906
		[Header("References")]
		[SerializeField]
		protected Canvas canvas;

		// Token: 0x04003653 RID: 13907
		[SerializeField]
		protected Text timeText;

		// Token: 0x04003654 RID: 13908
		[SerializeField]
		protected RectTransform appIconContainer;

		// Token: 0x04003655 RID: 13909
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject appIconPrefab;

		// Token: 0x04003656 RID: 13910
		protected List<Button> appIcons = new List<Button>();

		// Token: 0x04003657 RID: 13911
		private Coroutine delayedSetOpenRoutine;
	}
}
