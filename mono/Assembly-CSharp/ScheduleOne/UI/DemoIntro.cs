using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EasyButtons;
using FishNet;
using ScheduleOne.Audio;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x020009D8 RID: 2520
	public class DemoIntro : Singleton<DemoIntro>
	{
		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06004402 RID: 17410 RVA: 0x0011CFB9 File Offset: 0x0011B1B9
		// (set) Token: 0x06004403 RID: 17411 RVA: 0x0011CFC1 File Offset: 0x0011B1C1
		public bool IsPlaying { get; protected set; }

		// Token: 0x06004404 RID: 17412 RVA: 0x0011CFCC File Offset: 0x0011B1CC
		private void Update()
		{
			if (this.waitingForCutsceneEnd && !this.Anim.isPlaying)
			{
				this.CutsceneDone();
			}
			if (this.Anim.isPlaying)
			{
				if ((GameInput.GetButton(GameInput.ButtonCode.Jump) || GameInput.GetButton(GameInput.ButtonCode.Submit) || GameInput.GetButton(GameInput.ButtonCode.PrimaryClick)) && this.depressed && this.CurrentStep < this.SkipEvents - 1)
				{
					this.currentSkipTime += Time.deltaTime;
					if (this.currentSkipTime >= 0.5f)
					{
						this.currentSkipTime = 0f;
						if (this.IsPlaying)
						{
							Debug.Log("Skipping!");
							int num = this.CurrentStep + 1;
							float time = this.Anim.clip.events[num].time;
							this.Anim[this.Anim.clip.name].time = time;
							this.CurrentStep = num;
							this.depressed = false;
						}
					}
					this.SkipDial.fillAmount = this.currentSkipTime / 0.5f;
					this.SkipContainer.SetActive(true);
					return;
				}
				this.currentSkipTime = 0f;
				this.SkipContainer.SetActive(false);
				if (!GameInput.GetButton(GameInput.ButtonCode.Jump) && !GameInput.GetButton(GameInput.ButtonCode.Submit) && !GameInput.GetButton(GameInput.ButtonCode.PrimaryClick))
				{
					this.depressed = true;
				}
			}
		}

		// Token: 0x06004405 RID: 17413 RVA: 0x0011D128 File Offset: 0x0011B328
		[Button]
		public void Play()
		{
			this.IsPlaying = true;
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			Singleton<HUD>.Instance.canvas.enabled = false;
			this.Anim.Play();
			base.Invoke("PlayMusic", 1f);
			if (this.onStart != null)
			{
				this.onStart.Invoke();
			}
			this.waitingForCutsceneEnd = true;
			if (InstanceFinder.IsServer && this.onStartAsServer != null)
			{
				this.onStartAsServer.Invoke();
			}
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x0011D1CD File Offset: 0x0011B3CD
		private void PlayMusic()
		{
			Singleton<MusicPlayer>.Instance.Tracks.Find((MusicTrack t) => t.TrackName == this.MusicName).GetComponent<AmbientTrack>().ForcePlay();
		}

		// Token: 0x06004407 RID: 17415 RVA: 0x0011D1F4 File Offset: 0x0011B3F4
		public void ShowAvatar()
		{
			Singleton<CharacterCreator>.Instance.Open(Singleton<CharacterCreator>.Instance.DefaultSettings, false);
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x0011D20C File Offset: 0x0011B40C
		public void CutsceneDone()
		{
			this.waitingForCutsceneEnd = false;
			Singleton<CharacterCreator>.Instance.ShowUI();
			Singleton<CharacterCreator>.Instance.onComplete.AddListener(new UnityAction<BasicAvatarSettings>(this.CharacterCreationDone));
			if (this.onCutsceneDone != null)
			{
				this.onCutsceneDone.Invoke();
			}
			this.IsPlaying = false;
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x0011D25F File Offset: 0x0011B45F
		public void PassedStep(int stepIndex)
		{
			this.CurrentStep = stepIndex;
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x0011D268 File Offset: 0x0011B468
		public void CharacterCreationDone(BasicAvatarSettings avatar)
		{
			base.StartCoroutine(this.<CharacterCreationDone>g__Wait|26_0());
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x0011D2A0 File Offset: 0x0011B4A0
		[CompilerGenerated]
		private IEnumerator <CharacterCreationDone>g__Wait|26_0()
		{
			Singleton<BlackOverlay>.Instance.Open(0.5f);
			yield return new WaitForSeconds(0.5f);
			Player.Local.transform.position = this.PlayerInitialPosition.position;
			Player.Local.transform.rotation = this.PlayerInitialPosition.rotation;
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0f, false, true);
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0f);
			Singleton<CharacterCreator>.Instance.DisableStuff();
			yield return new WaitForSeconds(0.5f);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			Singleton<HUD>.Instance.canvas.enabled = true;
			Singleton<BlackOverlay>.Instance.Close(1f);
			if (this.onIntroDone != null)
			{
				this.onIntroDone.Invoke();
			}
			if (InstanceFinder.IsServer)
			{
				if (this.onIntroDoneAsServer != null)
				{
					this.onIntroDoneAsServer.Invoke();
				}
				Singleton<SaveManager>.Instance.Save();
			}
			else
			{
				Player.Local.RequestSavePlayer();
			}
			base.gameObject.SetActive(false);
			yield break;
		}

		// Token: 0x04003181 RID: 12673
		public const float SKIP_TIME = 0.5f;

		// Token: 0x04003183 RID: 12675
		public Animation Anim;

		// Token: 0x04003184 RID: 12676
		public Transform PlayerInitialPosition;

		// Token: 0x04003185 RID: 12677
		public GameObject SkipContainer;

		// Token: 0x04003186 RID: 12678
		public Image SkipDial;

		// Token: 0x04003187 RID: 12679
		public int SkipEvents = 3;

		// Token: 0x04003188 RID: 12680
		public UnityEvent onStart;

		// Token: 0x04003189 RID: 12681
		public UnityEvent onStartAsServer;

		// Token: 0x0400318A RID: 12682
		public UnityEvent onCutsceneDone;

		// Token: 0x0400318B RID: 12683
		public UnityEvent onIntroDone;

		// Token: 0x0400318C RID: 12684
		public UnityEvent onIntroDoneAsServer;

		// Token: 0x0400318D RID: 12685
		private int CurrentStep;

		// Token: 0x0400318E RID: 12686
		public string MusicName;

		// Token: 0x0400318F RID: 12687
		private float currentSkipTime;

		// Token: 0x04003190 RID: 12688
		private bool depressed = true;

		// Token: 0x04003191 RID: 12689
		private bool waitingForCutsceneEnd;
	}
}
