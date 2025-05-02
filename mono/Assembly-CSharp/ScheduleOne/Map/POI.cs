using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Phone.Map;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.Map
{
	// Token: 0x02000C2F RID: 3119
	public class POI : MonoBehaviour
	{
		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x0600576D RID: 22381 RVA: 0x0016F0F9 File Offset: 0x0016D2F9
		// (set) Token: 0x0600576E RID: 22382 RVA: 0x0016F101 File Offset: 0x0016D301
		public bool UISetup { get; protected set; }

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x0600576F RID: 22383 RVA: 0x0016F10A File Offset: 0x0016D30A
		// (set) Token: 0x06005770 RID: 22384 RVA: 0x0016F112 File Offset: 0x0016D312
		public string MainText { get; protected set; } = string.Empty;

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06005771 RID: 22385 RVA: 0x0016F11B File Offset: 0x0016D31B
		// (set) Token: 0x06005772 RID: 22386 RVA: 0x0016F123 File Offset: 0x0016D323
		public RectTransform UI { get; protected set; }

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06005773 RID: 22387 RVA: 0x0016F12C File Offset: 0x0016D32C
		// (set) Token: 0x06005774 RID: 22388 RVA: 0x0016F134 File Offset: 0x0016D334
		public RectTransform IconContainer { get; protected set; }

		// Token: 0x06005775 RID: 22389 RVA: 0x0016F140 File Offset: 0x0016D340
		private void OnEnable()
		{
			if (this.UI == null)
			{
				if (PlayerSingleton<MapApp>.Instance == null)
				{
					base.StartCoroutine(this.<OnEnable>g__Wait|27_0());
					return;
				}
				if (this.UI == null)
				{
					this.UI = Object.Instantiate<GameObject>(this.UIPrefab, PlayerSingleton<MapApp>.Instance.PoIContainer).GetComponent<RectTransform>();
					this.InitializeUI();
				}
			}
		}

		// Token: 0x06005776 RID: 22390 RVA: 0x0016F1AA File Offset: 0x0016D3AA
		private void OnDisable()
		{
			if (this.UI != null)
			{
				Object.Destroy(this.UI.gameObject);
				this.UI = null;
			}
		}

		// Token: 0x06005777 RID: 22391 RVA: 0x0016F1D1 File Offset: 0x0016D3D1
		private void Update()
		{
			if (this.AutoUpdatePosition && PlayerSingleton<MapApp>.InstanceExists && PlayerSingleton<MapApp>.Instance.isOpen)
			{
				this.UpdatePosition();
			}
		}

		// Token: 0x06005778 RID: 22392 RVA: 0x0016F1F4 File Offset: 0x0016D3F4
		public void SetMainText(string text)
		{
			this.mainTextSet = true;
			this.MainText = text;
			if (this.mainLabel != null)
			{
				this.mainLabel.text = text;
			}
		}

		// Token: 0x06005779 RID: 22393 RVA: 0x0016F220 File Offset: 0x0016D420
		public virtual void UpdatePosition()
		{
			if (this.UI == null)
			{
				return;
			}
			if (!Singleton<MapPositionUtility>.InstanceExists)
			{
				return;
			}
			this.UI.anchoredPosition = Singleton<MapPositionUtility>.Instance.GetMapPosition(base.transform.position);
			if (this.Rotate)
			{
				this.IconContainer.localEulerAngles = new Vector3(0f, 0f, Vector3.SignedAngle(base.transform.forward, Vector3.forward, Vector3.up));
			}
		}

		// Token: 0x0600577A RID: 22394 RVA: 0x0016F2A0 File Offset: 0x0016D4A0
		public virtual void InitializeUI()
		{
			this.mainLabel = this.UI.Find("MainLabel").GetComponent<Text>();
			if (this.mainLabel == null)
			{
				Console.LogError("Failed to find main label", null);
			}
			if (this.MainTextVisibility == POI.TextShowMode.Off || this.MainTextVisibility == POI.TextShowMode.OnHover)
			{
				this.mainLabel.enabled = false;
			}
			else
			{
				this.mainLabel.enabled = true;
			}
			this.eventTrigger = this.UI.GetComponent<EventTrigger>();
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.eventID = 0;
			entry.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
			{
				this.HoverStart();
			}));
			this.eventTrigger.triggers.Add(entry);
			entry = new EventTrigger.Entry();
			entry.eventID = 1;
			entry.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
			{
				this.HoverEnd();
			}));
			this.eventTrigger.triggers.Add(entry);
			this.button = this.UI.GetComponent<Button>();
			this.button.onClick.AddListener(new UnityAction(delegate()
			{
				this.Clicked();
			}));
			this.IconContainer = this.UI.Find("IconContainer").GetComponent<RectTransform>();
			if (this.IconContainer == null)
			{
				Console.LogError("Failed to find icon container", null);
			}
			if (!this.mainTextSet)
			{
				this.SetMainText(this.DefaultMainText);
			}
			else
			{
				this.SetMainText(this.MainText);
			}
			if (this.onUICreated != null)
			{
				this.onUICreated.Invoke();
			}
			this.UISetup = true;
			this.UpdatePosition();
		}

		// Token: 0x0600577B RID: 22395 RVA: 0x0016F42A File Offset: 0x0016D62A
		protected virtual void HoverStart()
		{
			if (this.MainTextVisibility == POI.TextShowMode.OnHover)
			{
				this.mainLabel.enabled = true;
			}
		}

		// Token: 0x0600577C RID: 22396 RVA: 0x0016F441 File Offset: 0x0016D641
		protected virtual void HoverEnd()
		{
			if (this.MainTextVisibility == POI.TextShowMode.OnHover)
			{
				this.mainLabel.enabled = false;
			}
		}

		// Token: 0x0600577D RID: 22397 RVA: 0x0016F458 File Offset: 0x0016D658
		protected virtual void Clicked()
		{
			PlayerSingleton<MapApp>.Instance.FocusPosition(this.UI.anchoredPosition);
		}

		// Token: 0x0600577F RID: 22399 RVA: 0x0016F49B File Offset: 0x0016D69B
		[CompilerGenerated]
		private IEnumerator <OnEnable>g__Wait|27_0()
		{
			yield return new WaitUntil(() => PlayerSingleton<MapApp>.Instance != null);
			if (!base.enabled)
			{
				yield break;
			}
			if (this.UI == null)
			{
				this.UI = Object.Instantiate<GameObject>(this.UIPrefab, PlayerSingleton<MapApp>.Instance.PoIContainer).GetComponent<RectTransform>();
				this.InitializeUI();
			}
			yield break;
		}

		// Token: 0x040040B5 RID: 16565
		public POI.TextShowMode MainTextVisibility = POI.TextShowMode.Always;

		// Token: 0x040040B6 RID: 16566
		public string DefaultMainText = "PoI Main Text";

		// Token: 0x040040B7 RID: 16567
		public bool AutoUpdatePosition = true;

		// Token: 0x040040B8 RID: 16568
		public bool Rotate;

		// Token: 0x040040BA RID: 16570
		[SerializeField]
		protected GameObject UIPrefab;

		// Token: 0x040040BD RID: 16573
		protected Text mainLabel;

		// Token: 0x040040BE RID: 16574
		protected Button button;

		// Token: 0x040040BF RID: 16575
		protected EventTrigger eventTrigger;

		// Token: 0x040040C0 RID: 16576
		private bool mainTextSet;

		// Token: 0x040040C1 RID: 16577
		public UnityEvent onUICreated;

		// Token: 0x02000C30 RID: 3120
		public enum TextShowMode
		{
			// Token: 0x040040C3 RID: 16579
			Off,
			// Token: 0x040040C4 RID: 16580
			Always,
			// Token: 0x040040C5 RID: 16581
			OnHover
		}
	}
}
