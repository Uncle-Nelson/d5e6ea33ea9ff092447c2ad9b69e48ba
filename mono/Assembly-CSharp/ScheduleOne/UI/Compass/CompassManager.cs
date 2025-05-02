using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Compass
{
	// Token: 0x02000B33 RID: 2867
	public class CompassManager : Singleton<CompassManager>
	{
		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06004C49 RID: 19529 RVA: 0x00045196 File Offset: 0x00043396
		private Transform cam
		{
			get
			{
				return PlayerSingleton<PlayerCamera>.Instance.transform;
			}
		}

		// Token: 0x06004C4A RID: 19530 RVA: 0x0014204C File Offset: 0x0014024C
		protected override void Awake()
		{
			base.Awake();
			this.notchPositions = new List<Transform>(this.NotchPointContainer.GetComponentsInChildren<Transform>());
			this.notchPositions.Remove(this.NotchPointContainer);
			for (int i = 0; i < this.notchPositions.Count; i++)
			{
				GameObject original = this.NotchPrefab;
				int num = Mathf.RoundToInt((float)(i + 1) / (float)this.notchPositions.Count * 360f);
				if (num % 90 == 0)
				{
					original = this.DirectionIndicatorPrefab;
				}
				GameObject gameObject = Object.Instantiate<GameObject>(original, this.NotchUIContainer);
				CompassManager.Notch notch = new CompassManager.Notch();
				notch.Rect = gameObject.GetComponent<RectTransform>();
				notch.Group = gameObject.GetComponent<CanvasGroup>();
				this.notches.Add(notch);
				if (num % 90 == 0)
				{
					string text = "N";
					if (num == 90)
					{
						text = "E";
					}
					else if (num == 180)
					{
						text = "S";
					}
					else if (num == 270)
					{
						text = "W";
					}
					notch.Rect.GetComponentInChildren<TextMeshProUGUI>().text = text;
				}
			}
		}

		// Token: 0x06004C4B RID: 19531 RVA: 0x0014215D File Offset: 0x0014035D
		private void LateUpdate()
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			this.Canvas.enabled = (Singleton<HUD>.Instance.canvas.enabled && this.CompassEnabled);
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x0014218C File Offset: 0x0014038C
		private void FixedUpdate()
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			if (Singleton<HUD>.Instance.canvas.enabled)
			{
				this.UpdateNotches();
				this.UpdateElements();
			}
		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x001421B3 File Offset: 0x001403B3
		public void SetCompassEnabled(bool enabled)
		{
			this.CompassEnabled = enabled;
		}

		// Token: 0x06004C4E RID: 19534 RVA: 0x001421BC File Offset: 0x001403BC
		public void SetVisible(bool visible)
		{
			if (this.lerpContainerPositionCoroutine != null)
			{
				base.StopCoroutine(this.lerpContainerPositionCoroutine);
			}
			this.lerpContainerPositionCoroutine = base.StartCoroutine(this.<SetVisible>g__LerpContainerPosition|28_0(visible ? this.OpenYPos : this.ClosedYPos, visible));
		}

		// Token: 0x06004C4F RID: 19535 RVA: 0x001421F8 File Offset: 0x001403F8
		private void UpdateNotches()
		{
			for (int i = 0; i < this.notchPositions.Count; i++)
			{
				float x;
				float num;
				this.GetCompassData(this.notchPositions[i].position, out x, out num);
				this.notches[i].Rect.anchoredPosition = new Vector2(x, 0f);
				this.notches[i].Group.alpha = num;
				this.notches[i].Rect.gameObject.SetActive(num > 0f);
			}
		}

		// Token: 0x06004C50 RID: 19536 RVA: 0x00142294 File Offset: 0x00140494
		private void UpdateElements()
		{
			for (int i = 0; i < this.elements.Count; i++)
			{
				this.UpdateElement(this.elements[i]);
			}
		}

		// Token: 0x06004C51 RID: 19537 RVA: 0x001422CC File Offset: 0x001404CC
		private void UpdateElement(CompassManager.Element element)
		{
			if (!element.Visible || element.Transform == null)
			{
				element.Group.alpha = 0f;
			}
			else
			{
				float x;
				float alpha;
				this.GetCompassData(element.Transform.position, out x, out alpha);
				element.Rect.anchoredPosition = new Vector2(x, 0f);
				element.Group.alpha = alpha;
				float num = Vector3.Distance(this.cam.position, element.Transform.position);
				if (num <= 50f)
				{
					element.DistanceLabel.text = Mathf.CeilToInt(num).ToString() + "m";
				}
				else
				{
					element.DistanceLabel.text = string.Empty;
				}
			}
			element.Rect.gameObject.SetActive(element.Group.alpha > 0f);
		}

		// Token: 0x06004C52 RID: 19538 RVA: 0x001423B8 File Offset: 0x001405B8
		public void GetCompassData(Vector3 worldPosition, out float xPos, out float alpha)
		{
			Vector3 normalized = Vector3.ProjectOnPlane(this.cam.forward, Vector3.up).normalized;
			Vector3 to = worldPosition - this.cam.position;
			to.y = 0f;
			float num = Vector3.SignedAngle(normalized, to, Vector3.up);
			xPos = Mathf.Clamp(num / this.AngleDivisor, -1f, 1f) * this.CompassUIRange * 0.5f;
			alpha = 1f;
			if (Mathf.Abs(num) > this.FullAlphaRange)
			{
				alpha = 1f - (Mathf.Abs(num) - this.FullAlphaRange) / (this.AngleDivisor - this.FullAlphaRange);
			}
		}

		// Token: 0x06004C53 RID: 19539 RVA: 0x0014246C File Offset: 0x0014066C
		public CompassManager.Element AddElement(Transform transform, RectTransform contentPrefab, bool visible = true)
		{
			CompassManager.Element element = new CompassManager.Element();
			element.Transform = transform;
			element.Rect = Object.Instantiate<GameObject>(this.ElementPrefab, this.ElementUIContainer).GetComponent<RectTransform>();
			element.Group = element.Rect.GetComponent<CanvasGroup>();
			element.DistanceLabel = element.Rect.Find("Text").GetComponent<TextMeshProUGUI>();
			RectTransform component = Object.Instantiate<RectTransform>(contentPrefab, element.Rect).GetComponent<RectTransform>();
			component.anchoredPosition = Vector2.zero;
			component.sizeDelta = this.ElementContentSize;
			element.Visible = visible;
			this.elements.Add(element);
			this.UpdateElement(element);
			return element;
		}

		// Token: 0x06004C54 RID: 19540 RVA: 0x00142510 File Offset: 0x00140710
		public void RemoveElement(Transform transform, bool alsoDestroyRect = true)
		{
			for (int i = 0; i < this.elements.Count; i++)
			{
				if (this.elements[i].Transform == transform)
				{
					this.RemoveElement(this.elements[i], alsoDestroyRect);
					return;
				}
			}
		}

		// Token: 0x06004C55 RID: 19541 RVA: 0x00142560 File Offset: 0x00140760
		public void RemoveElement(CompassManager.Element el, bool alsoDestroyRect = true)
		{
			if (alsoDestroyRect)
			{
				Object.Destroy(el.Rect.gameObject);
			}
			this.elements.Remove(el);
		}

		// Token: 0x06004C57 RID: 19543 RVA: 0x0014260B File Offset: 0x0014080B
		[CompilerGenerated]
		private IEnumerator <SetVisible>g__LerpContainerPosition|28_0(float yPos, bool visible)
		{
			if (visible)
			{
				this.Container.gameObject.SetActive(true);
			}
			float t = 0f;
			Vector2 startPos = this.Container.anchoredPosition;
			Vector2 endPos = new Vector2(startPos.x, yPos);
			while (t < 1f)
			{
				t += Time.deltaTime * 7f;
				this.Container.anchoredPosition = new Vector2(0f, Mathf.Lerp(startPos.y, endPos.y, t));
				yield return null;
			}
			this.Container.anchoredPosition = endPos;
			this.Container.gameObject.SetActive(visible);
			yield break;
		}

		// Token: 0x04003961 RID: 14689
		public const float DISTANCE_LABEL_THRESHOLD = 50f;

		// Token: 0x04003962 RID: 14690
		[Header("References")]
		public RectTransform Container;

		// Token: 0x04003963 RID: 14691
		public Transform NotchPointContainer;

		// Token: 0x04003964 RID: 14692
		public RectTransform NotchUIContainer;

		// Token: 0x04003965 RID: 14693
		public RectTransform ElementUIContainer;

		// Token: 0x04003966 RID: 14694
		public Canvas Canvas;

		// Token: 0x04003967 RID: 14695
		[Header("Prefabs")]
		public GameObject DirectionIndicatorPrefab;

		// Token: 0x04003968 RID: 14696
		public GameObject NotchPrefab;

		// Token: 0x04003969 RID: 14697
		public GameObject ElementPrefab;

		// Token: 0x0400396A RID: 14698
		[Header("Settings")]
		public bool CompassEnabled = true;

		// Token: 0x0400396B RID: 14699
		public Vector2 ElementContentSize = new Vector2(20f, 20f);

		// Token: 0x0400396C RID: 14700
		public float CompassUIRange = 800f;

		// Token: 0x0400396D RID: 14701
		public float FullAlphaRange = 40f;

		// Token: 0x0400396E RID: 14702
		public float AngleDivisor = 60f;

		// Token: 0x0400396F RID: 14703
		public float ClosedYPos = 30f;

		// Token: 0x04003970 RID: 14704
		public float OpenYPos = -50f;

		// Token: 0x04003971 RID: 14705
		private List<Transform> notchPositions = new List<Transform>();

		// Token: 0x04003972 RID: 14706
		private List<CompassManager.Notch> notches = new List<CompassManager.Notch>();

		// Token: 0x04003973 RID: 14707
		private List<CompassManager.Element> elements = new List<CompassManager.Element>();

		// Token: 0x04003974 RID: 14708
		private Coroutine lerpContainerPositionCoroutine;

		// Token: 0x02000B34 RID: 2868
		public class Notch
		{
			// Token: 0x04003975 RID: 14709
			public RectTransform Rect;

			// Token: 0x04003976 RID: 14710
			public CanvasGroup Group;
		}

		// Token: 0x02000B35 RID: 2869
		public class Element
		{
			// Token: 0x04003977 RID: 14711
			public bool Visible;

			// Token: 0x04003978 RID: 14712
			public RectTransform Rect;

			// Token: 0x04003979 RID: 14713
			public CanvasGroup Group;

			// Token: 0x0400397A RID: 14714
			public TextMeshProUGUI DistanceLabel;

			// Token: 0x0400397B RID: 14715
			public Transform Transform;
		}
	}
}
