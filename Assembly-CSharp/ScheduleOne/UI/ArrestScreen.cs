using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.FX;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A1E RID: 2590
	public class ArrestScreen : Singleton<ArrestScreen>
	{
		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x060045E0 RID: 17888 RVA: 0x00125668 File Offset: 0x00123868
		// (set) Token: 0x060045E1 RID: 17889 RVA: 0x00125670 File Offset: 0x00123870
		public bool isOpen { get; protected set; }

		// Token: 0x060045E2 RID: 17890 RVA: 0x00125679 File Offset: 0x00123879
		protected override void Awake()
		{
			base.Awake();
			this.canvas.enabled = false;
			this.group.alpha = 0f;
			this.group.interactable = false;
		}

		// Token: 0x060045E3 RID: 17891 RVA: 0x001256A9 File Offset: 0x001238A9
		private void Continue()
		{
			if (!this.isOpen)
			{
				return;
			}
			this.isOpen = false;
			base.StartCoroutine(this.<Continue>g__Routine|9_0());
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x001256C8 File Offset: 0x001238C8
		private void LoadSaveClicked()
		{
			this.Close();
		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x001256D0 File Offset: 0x001238D0
		public void Open()
		{
			if (this.isOpen)
			{
				return;
			}
			this.isOpen = true;
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			this.Sound.Play();
			base.StartCoroutine(this.<Open>g__Routine|11_0());
		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x0012570A File Offset: 0x0012390A
		public void Close()
		{
			this.isOpen = false;
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			Singleton<PostProcessingManager>.Instance.SetBlur(0f);
			this.canvas.enabled = false;
		}

		// Token: 0x060045E8 RID: 17896 RVA: 0x00125746 File Offset: 0x00123946
		[CompilerGenerated]
		private IEnumerator <Continue>g__Routine|9_0()
		{
			Singleton<BlackOverlay>.Instance.Open(0.5f);
			yield return new WaitForSeconds(0.5f);
			this.Close();
			Singleton<ArrestNoticeScreen>.Instance.Open();
			Player.Local.Free();
			Player.Local.Health.SetHealth(100f);
			yield return new WaitForSeconds(2f);
			Singleton<BlackOverlay>.Instance.Close(0.5f);
			yield break;
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x00125755 File Offset: 0x00123955
		[CompilerGenerated]
		private IEnumerator <Open>g__Routine|11_0()
		{
			yield return new WaitForSeconds(0.5f);
			this.Anim.Play();
			this.canvas.enabled = true;
			float lerpTime = 0.75f;
			for (float i = 0f; i < lerpTime; i += Time.deltaTime)
			{
				Singleton<PostProcessingManager>.Instance.SetBlur(i / lerpTime);
				yield return new WaitForEndOfFrame();
			}
			Singleton<PostProcessingManager>.Instance.SetBlur(1f);
			yield return new WaitForSeconds(3f);
			this.Continue();
			yield break;
		}

		// Token: 0x04003379 RID: 13177
		[Header("References")]
		public Canvas canvas;

		// Token: 0x0400337A RID: 13178
		public CanvasGroup group;

		// Token: 0x0400337B RID: 13179
		public AudioSourceController Sound;

		// Token: 0x0400337C RID: 13180
		public Animation Anim;
	}
}
