using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A5C RID: 2652
	public class WorldspaceDialogueRenderer : MonoBehaviour
	{
		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06004766 RID: 18278 RVA: 0x0012ADC8 File Offset: 0x00128FC8
		// (set) Token: 0x06004767 RID: 18279 RVA: 0x0012ADD0 File Offset: 0x00128FD0
		public string ShownText { get; protected set; } = string.Empty;

		// Token: 0x06004768 RID: 18280 RVA: 0x0012ADD9 File Offset: 0x00128FD9
		private void Awake()
		{
			this.localOffset = base.transform.localPosition;
			this.SetOpacity(0f);
		}

		// Token: 0x06004769 RID: 18281 RVA: 0x0012ADF8 File Offset: 0x00128FF8
		private void FixedUpdate()
		{
			if (this.ShownText == string.Empty)
			{
				if (this.CurrentOpacity != 0f)
				{
					this.SetOpacity(0f);
				}
				return;
			}
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				if (this.CurrentOpacity != 0f)
				{
					this.SetOpacity(0f);
				}
				return;
			}
			if (Vector3.Distance(base.transform.position, PlayerSingleton<PlayerCamera>.Instance.transform.position) > this.MaxRange)
			{
				if (this.CurrentOpacity != 0f)
				{
					this.SetOpacity(0f);
				}
				return;
			}
			float num = Vector3.Distance(base.transform.position, PlayerSingleton<PlayerCamera>.Instance.transform.position);
			if (num < this.MaxRange - 2f)
			{
				this.SetOpacity(1f);
			}
			else
			{
				this.SetOpacity(1f - (num - (this.MaxRange - 2f)) / 2f);
			}
			this.Text.text = this.ShownText;
		}

		// Token: 0x0600476A RID: 18282 RVA: 0x0012AEFD File Offset: 0x001290FD
		private void LateUpdate()
		{
			if (this.CurrentOpacity > 0f)
			{
				this.UpdatePosition();
			}
		}

		// Token: 0x0600476B RID: 18283 RVA: 0x0012AF14 File Offset: 0x00129114
		private void UpdatePosition()
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			float num = this.BaseScale * this.Scale.Evaluate(Vector3.Distance(base.transform.position, PlayerSingleton<PlayerCamera>.Instance.transform.position) / this.MaxRange);
			this.Canvas.transform.localScale = new Vector3(num, num, num);
			this.Background.sizeDelta = new Vector2(this.Text.renderedWidth + this.Padding.x, this.Text.renderedHeight + this.Padding.y);
			this.Canvas.transform.LookAt(PlayerSingleton<PlayerCamera>.Instance.transform.position);
			base.transform.localPosition = this.localOffset;
			base.transform.position = base.transform.position + this.WorldSpaceOffset;
		}

		// Token: 0x0600476C RID: 18284 RVA: 0x0012B00C File Offset: 0x0012920C
		public void ShowText(string text, float duration = 0f)
		{
			if (this.hideCoroutine != null)
			{
				base.StopCoroutine(this.hideCoroutine);
				this.hideCoroutine = null;
			}
			this.ShownText = text;
			if (this.ShownText != string.Empty)
			{
				this.Text.text = this.ShownText;
				this.Text.ForceMeshUpdate(false, false);
				this.UpdatePosition();
			}
			if (!this.Canvas.enabled && this.Anim != null)
			{
				this.Anim.Play();
			}
			if (duration > 0f)
			{
				this.hideCoroutine = Singleton<CoroutineService>.Instance.StartCoroutine(this.<ShowText>g__Wait|22_0(duration));
			}
		}

		// Token: 0x0600476D RID: 18285 RVA: 0x0012B0B7 File Offset: 0x001292B7
		public void HideText()
		{
			if (this.hideCoroutine != null)
			{
				base.StopCoroutine(this.hideCoroutine);
				this.hideCoroutine = null;
			}
			this.ShownText = string.Empty;
		}

		// Token: 0x0600476E RID: 18286 RVA: 0x0012B0DF File Offset: 0x001292DF
		private void SetOpacity(float op)
		{
			this.CurrentOpacity = op;
			this.CanvasGroup.alpha = op;
			this.Canvas.enabled = (op > 0f);
		}

		// Token: 0x06004770 RID: 18288 RVA: 0x0012B146 File Offset: 0x00129346
		[CompilerGenerated]
		private IEnumerator <ShowText>g__Wait|22_0(float dur)
		{
			yield return new WaitForSeconds(dur);
			this.ShownText = string.Empty;
			this.hideCoroutine = null;
			yield break;
		}

		// Token: 0x040034C8 RID: 13512
		private const float FadeDist = 2f;

		// Token: 0x040034CA RID: 13514
		[Header("Settings")]
		public float MaxRange = 10f;

		// Token: 0x040034CB RID: 13515
		public float BaseScale = 0.01f;

		// Token: 0x040034CC RID: 13516
		public AnimationCurve Scale;

		// Token: 0x040034CD RID: 13517
		public Vector2 Padding;

		// Token: 0x040034CE RID: 13518
		public Vector3 WorldSpaceOffset = Vector3.zero;

		// Token: 0x040034CF RID: 13519
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040034D0 RID: 13520
		public CanvasGroup CanvasGroup;

		// Token: 0x040034D1 RID: 13521
		public RectTransform Background;

		// Token: 0x040034D2 RID: 13522
		public TextMeshProUGUI Text;

		// Token: 0x040034D3 RID: 13523
		public Animation Anim;

		// Token: 0x040034D4 RID: 13524
		private Vector3 localOffset = Vector3.zero;

		// Token: 0x040034D5 RID: 13525
		private float CurrentOpacity;

		// Token: 0x040034D6 RID: 13526
		private Coroutine hideCoroutine;
	}
}
