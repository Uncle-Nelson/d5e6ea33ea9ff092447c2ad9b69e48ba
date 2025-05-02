using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.FX;
using ScheduleOne.Law;
using ScheduleOne.Map;
using ScheduleOne.Persistence;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A23 RID: 2595
	public class DeathScreen : Singleton<DeathScreen>
	{
		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06004600 RID: 17920 RVA: 0x00125C4D File Offset: 0x00123E4D
		// (set) Token: 0x06004601 RID: 17921 RVA: 0x00125C55 File Offset: 0x00123E55
		public bool isOpen { get; protected set; }

		// Token: 0x06004602 RID: 17922 RVA: 0x00125C60 File Offset: 0x00123E60
		protected override void Awake()
		{
			base.Awake();
			this.respawnButton.onClick.AddListener(new UnityAction(this.RespawnClicked));
			this.loadSaveButton.onClick.AddListener(new UnityAction(this.LoadSaveClicked));
			this.canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			this.group.alpha = 0f;
			this.group.interactable = false;
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x00125CE4 File Offset: 0x00123EE4
		private void RespawnClicked()
		{
			if (!this.isOpen)
			{
				return;
			}
			this.isOpen = false;
			base.StartCoroutine(this.<RespawnClicked>g__Routine|13_0());
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x00125D03 File Offset: 0x00123F03
		private void LoadSaveClicked()
		{
			this.Close();
			Singleton<LoadManager>.Instance.ExitToMenu(Singleton<LoadManager>.Instance.ActiveSaveInfo, null, false);
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x00125D24 File Offset: 0x00123F24
		public void Open()
		{
			if (this.isOpen)
			{
				return;
			}
			this.isOpen = true;
			this.arrested = Player.Local.IsArrested;
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			this.Sound.Play();
			this.respawnButton.gameObject.SetActive(this.CanRespawn());
			this.loadSaveButton.gameObject.SetActive(!this.respawnButton.gameObject.activeSelf);
			base.StartCoroutine(this.<Open>g__Routine|15_0());
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x00125DB2 File Offset: 0x00123FB2
		private bool CanRespawn()
		{
			return Player.PlayerList.Count > 1;
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x00125DC4 File Offset: 0x00123FC4
		public void Close()
		{
			this.isOpen = false;
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			Singleton<PostProcessingManager>.Instance.SetBlur(0f);
			this.canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x00125E1C File Offset: 0x0012401C
		[CompilerGenerated]
		private IEnumerator <RespawnClicked>g__Routine|13_0()
		{
			Singleton<BlackOverlay>.Instance.Open(0.5f);
			yield return new WaitForSeconds(0.5f);
			this.Close();
			Singleton<HospitalBillScreen>.Instance.Open();
			Transform transform = Singleton<Map>.Instance.MedicalCentre.RespawnPoint;
			if (NetworkSingleton<CurfewManager>.Instance.IsCurrentlyActive && (Player.Local.LastVisitedProperty != null || Property.OwnedProperties.Count > 0))
			{
				if (Player.Local.LastVisitedProperty != null)
				{
					transform = Player.Local.LastVisitedProperty.InteriorSpawnPoint;
				}
				else
				{
					transform = Property.OwnedProperties[0].InteriorSpawnPoint;
				}
			}
			Player.Local.Health.SendRevive(transform.position + Vector3.up * 1f, transform.rotation);
			if (this.arrested)
			{
				Singleton<ArrestNoticeScreen>.Instance.RecordCrimes();
				Player.Local.Free();
			}
			yield return new WaitForSeconds(2f);
			Singleton<BlackOverlay>.Instance.Close(0.5f);
			yield break;
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x00125E2B File Offset: 0x0012402B
		[CompilerGenerated]
		private IEnumerator <Open>g__Routine|15_0()
		{
			yield return new WaitForSeconds(0.55f);
			this.Anim.Play();
			this.canvas.enabled = true;
			this.Container.gameObject.SetActive(true);
			float lerpTime = 0.75f;
			for (float i = 0f; i < lerpTime; i += Time.deltaTime)
			{
				Singleton<PostProcessingManager>.Instance.SetBlur(i / lerpTime);
				yield return new WaitForEndOfFrame();
			}
			Singleton<PostProcessingManager>.Instance.SetBlur(1f);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			this.group.interactable = true;
			yield break;
		}

		// Token: 0x04003397 RID: 13207
		[Header("References")]
		public Canvas canvas;

		// Token: 0x04003398 RID: 13208
		public RectTransform Container;

		// Token: 0x04003399 RID: 13209
		public CanvasGroup group;

		// Token: 0x0400339A RID: 13210
		public Button respawnButton;

		// Token: 0x0400339B RID: 13211
		public Button loadSaveButton;

		// Token: 0x0400339C RID: 13212
		public Animation Anim;

		// Token: 0x0400339D RID: 13213
		public AudioSourceController Sound;

		// Token: 0x0400339E RID: 13214
		private bool arrested;
	}
}
