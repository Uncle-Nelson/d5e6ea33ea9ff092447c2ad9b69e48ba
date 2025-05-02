using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI.WorldspacePopup
{
	// Token: 0x02000A5E RID: 2654
	public class WorldspacePopup : MonoBehaviour
	{
		// Token: 0x06004777 RID: 18295 RVA: 0x0012B1D3 File Offset: 0x001293D3
		private void OnEnable()
		{
			if (!WorldspacePopup.ActivePopups.Contains(this))
			{
				WorldspacePopup.ActivePopups.Add(this);
			}
		}

		// Token: 0x06004778 RID: 18296 RVA: 0x0012B1ED File Offset: 0x001293ED
		private void OnDisable()
		{
			WorldspacePopup.ActivePopups.Remove(this);
		}

		// Token: 0x06004779 RID: 18297 RVA: 0x0012B1FC File Offset: 0x001293FC
		public WorldspacePopupUI CreateUI(RectTransform parent)
		{
			WorldspacePopupUI newUI = Object.Instantiate<WorldspacePopupUI>(this.UIPrefab, parent);
			newUI.Popup = this;
			newUI.SetFill(this.CurrentFillLevel);
			this.UIs.Add(newUI);
			newUI.onDestroyed.AddListener(new UnityAction(delegate()
			{
				this.UIs.Remove(newUI);
			}));
			return newUI;
		}

		// Token: 0x0600477A RID: 18298 RVA: 0x0012B278 File Offset: 0x00129478
		private void LateUpdate()
		{
			foreach (WorldspacePopupUI worldspacePopupUI in this.UIs)
			{
				worldspacePopupUI.SetFill(this.CurrentFillLevel);
			}
		}

		// Token: 0x0600477B RID: 18299 RVA: 0x0012B2D0 File Offset: 0x001294D0
		public void Popup()
		{
			if (this.popupCoroutine != null)
			{
				base.StopCoroutine(this.popupCoroutine);
			}
			this.popupCoroutine = base.StartCoroutine(this.<Popup>g__PopupCoroutine|18_0());
		}

		// Token: 0x0600477E RID: 18302 RVA: 0x0012B351 File Offset: 0x00129551
		[CompilerGenerated]
		private IEnumerator <Popup>g__PopupCoroutine|18_0()
		{
			base.enabled = true;
			this.SizeMultiplier = 0f;
			float lerpTime = 0.25f;
			for (float i = 0f; i < lerpTime; i += Time.deltaTime)
			{
				this.SizeMultiplier = i / lerpTime;
				yield return new WaitForEndOfFrame();
			}
			this.SizeMultiplier = 1f;
			yield return new WaitForSeconds(0.6f);
			base.enabled = false;
			this.popupCoroutine = null;
			yield break;
		}

		// Token: 0x040034DB RID: 13531
		public static List<WorldspacePopup> ActivePopups = new List<WorldspacePopup>();

		// Token: 0x040034DC RID: 13532
		[Range(0f, 1f)]
		public float CurrentFillLevel = 1f;

		// Token: 0x040034DD RID: 13533
		[Header("Settings")]
		public WorldspacePopupUI UIPrefab;

		// Token: 0x040034DE RID: 13534
		public bool DisplayOnHUD = true;

		// Token: 0x040034DF RID: 13535
		public bool ScaleWithDistance = true;

		// Token: 0x040034E0 RID: 13536
		public Vector3 WorldspaceOffset;

		// Token: 0x040034E1 RID: 13537
		public float Range = 50f;

		// Token: 0x040034E2 RID: 13538
		public float SizeMultiplier = 1f;

		// Token: 0x040034E3 RID: 13539
		[HideInInspector]
		public WorldspacePopupUI WorldspaceUI;

		// Token: 0x040034E4 RID: 13540
		[HideInInspector]
		public RectTransform HUDUI;

		// Token: 0x040034E5 RID: 13541
		[HideInInspector]
		public WorldspacePopupUI HUDUIIcon;

		// Token: 0x040034E6 RID: 13542
		[HideInInspector]
		public CanvasGroup HUDUICanvasGroup;

		// Token: 0x040034E7 RID: 13543
		private List<WorldspacePopupUI> UIs = new List<WorldspacePopupUI>();

		// Token: 0x040034E8 RID: 13544
		private Coroutine popupCoroutine;
	}
}
