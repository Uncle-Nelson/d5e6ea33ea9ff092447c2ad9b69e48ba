using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x02000A48 RID: 2632
	public class SaveIndicator : MonoBehaviour
	{
		// Token: 0x060046FC RID: 18172 RVA: 0x001297AC File Offset: 0x001279AC
		public void Awake()
		{
			this.Canvas.enabled = false;
		}

		// Token: 0x060046FD RID: 18173 RVA: 0x001297BA File Offset: 0x001279BA
		public void Start()
		{
			Singleton<SaveManager>.Instance.onSaveStart.AddListener(new UnityAction(this.Display));
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x001297D7 File Offset: 0x001279D7
		public void OnDestroy()
		{
			if (Singleton<SaveManager>.InstanceExists)
			{
				Singleton<SaveManager>.Instance.onSaveStart.RemoveListener(new UnityAction(this.Display));
			}
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x001297FB File Offset: 0x001279FB
		public void Display()
		{
			base.StartCoroutine(this.<Display>g__Routine|6_0());
		}

		// Token: 0x06004701 RID: 18177 RVA: 0x0012980A File Offset: 0x00127A0A
		[CompilerGenerated]
		private IEnumerator <Display>g__Routine|6_0()
		{
			this.Canvas.enabled = true;
			this.Icon.gameObject.SetActive(true);
			while (Singleton<SaveManager>.Instance.IsSaving)
			{
				this.Icon.Rotate(Vector3.forward, 360f * Time.unscaledDeltaTime);
				yield return new WaitForEndOfFrame();
			}
			this.Icon.gameObject.SetActive(false);
			this.Anim.Play();
			yield return new WaitForSecondsRealtime(5f);
			this.Canvas.enabled = false;
			yield break;
		}

		// Token: 0x0400346B RID: 13419
		public Canvas Canvas;

		// Token: 0x0400346C RID: 13420
		public RectTransform Icon;

		// Token: 0x0400346D RID: 13421
		public Animation Anim;
	}
}
