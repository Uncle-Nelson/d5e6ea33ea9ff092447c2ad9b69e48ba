using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using ScheduleOne.Audio;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.Clothing;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Persistence;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.Intro
{
	// Token: 0x0200060C RID: 1548
	public class IntroManager : Singleton<IntroManager>
	{
		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x000A7215 File Offset: 0x000A5415
		// (set) Token: 0x06002893 RID: 10387 RVA: 0x000A721D File Offset: 0x000A541D
		public bool IsPlaying { get; protected set; }

		// Token: 0x06002894 RID: 10388 RVA: 0x000A7226 File Offset: 0x000A5426
		protected override void Awake()
		{
			base.Awake();
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x000A7240 File Offset: 0x000A5440
		private void Update()
		{
			if (this.Anim.isPlaying)
			{
				if ((GameInput.GetButton(GameInput.ButtonCode.Jump) || GameInput.GetButton(GameInput.ButtonCode.Submit) || GameInput.GetButton(GameInput.ButtonCode.PrimaryClick)) && this.depressed)
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

		// Token: 0x06002896 RID: 10390 RVA: 0x000A736C File Offset: 0x000A556C
		[Button]
		public void Play()
		{
			this.IsPlaying = true;
			NetworkSingleton<TimeManager>.Instance.SetTimeOverridden(true, this.TimeOfDayOverride);
			Console.Log("Starting Intro...", null);
			this.Container.SetActive(true);
			this.rv.ModelContainer.gameObject.SetActive(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			Singleton<HUD>.Instance.canvas.enabled = false;
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(60f, 0f);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.CameraContainer.position, this.CameraContainer.rotation, 0f, false);
			PlayerSingleton<PlayerCamera>.Instance.CameraContainer.transform.SetParent(this.CameraContainer);
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			GameObject[] disableDuringIntro = this.DisableDuringIntro;
			for (int i = 0; i < disableDuringIntro.Length; i++)
			{
				disableDuringIntro[i].gameObject.SetActive(false);
			}
			base.StartCoroutine(this.<Play>g__Wait|23_0());
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x000A7482 File Offset: 0x000A5682
		private void PlayMusic()
		{
			Singleton<MusicPlayer>.Instance.Tracks.Find((MusicTrack t) => t.TrackName == this.MusicName).GetComponent<MusicTrack>().Enable();
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x000A74AC File Offset: 0x000A56AC
		public void CharacterCreationDone(BasicAvatarSettings avatar, List<ClothingInstance> clothes)
		{
			IntroManager.<>c__DisplayClass25_0 CS$<>8__locals1 = new IntroManager.<>c__DisplayClass25_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.clothes = clothes;
			base.StartCoroutine(CS$<>8__locals1.<CharacterCreationDone>g__Wait|0());
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x000A74DA File Offset: 0x000A56DA
		public void PassedStep(int stepIndex)
		{
			this.CurrentStep = stepIndex;
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x000A74FD File Offset: 0x000A56FD
		[CompilerGenerated]
		private IEnumerator <Play>g__Wait|23_0()
		{
			yield return new WaitUntil(() => Singleton<LoadManager>.Instance.IsGameLoaded);
			this.Anim.Play();
			this.PlayMusic();
			yield return new WaitForSeconds(0.1f);
			yield return new WaitUntil(() => !this.Anim.isPlaying);
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0f);
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0f, false, false);
			Singleton<BlackOverlay>.Instance.Open(0.5f);
			yield return new WaitForSeconds(2f);
			Singleton<CharacterCreator>.Instance.Open(Singleton<CharacterCreator>.Instance.DefaultSettings, true);
			Singleton<CharacterCreator>.Instance.onCompleteWithClothing.AddListener(new UnityAction<BasicAvatarSettings, List<ClothingInstance>>(this.CharacterCreationDone));
			yield return new WaitForSeconds(0.05f);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			this.Container.gameObject.SetActive(false);
			this.rv.ModelContainer.gameObject.SetActive(true);
			PlayerSingleton<PlayerMovement>.Instance.Teleport(NetworkSingleton<GameManager>.Instance.SpawnPoint.position);
			base.transform.forward = NetworkSingleton<GameManager>.Instance.SpawnPoint.forward;
			GameObject[] disableDuringIntro = this.DisableDuringIntro;
			for (int i = 0; i < disableDuringIntro.Length; i++)
			{
				disableDuringIntro[i].gameObject.SetActive(true);
			}
			yield return new WaitForSeconds(1f);
			Singleton<BlackOverlay>.Instance.Close(1f);
			yield break;
		}

		// Token: 0x04001DA0 RID: 7584
		public const float SKIP_TIME = 0.5f;

		// Token: 0x04001DA2 RID: 7586
		public int CurrentStep;

		// Token: 0x04001DA3 RID: 7587
		[Header("Settings")]
		public int TimeOfDayOverride = 2000;

		// Token: 0x04001DA4 RID: 7588
		[Header("References")]
		public GameObject Container;

		// Token: 0x04001DA5 RID: 7589
		public Transform PlayerInitialPosition;

		// Token: 0x04001DA6 RID: 7590
		public Transform PlayerInitialPosition_AfterRVExplosion;

		// Token: 0x04001DA7 RID: 7591
		public Transform CameraContainer;

		// Token: 0x04001DA8 RID: 7592
		public Animation Anim;

		// Token: 0x04001DA9 RID: 7593
		public GameObject SkipContainer;

		// Token: 0x04001DAA RID: 7594
		public Image SkipDial;

		// Token: 0x04001DAB RID: 7595
		public GameObject[] DisableDuringIntro;

		// Token: 0x04001DAC RID: 7596
		public RV rv;

		// Token: 0x04001DAD RID: 7597
		public UnityEvent onIntroDone;

		// Token: 0x04001DAE RID: 7598
		public UnityEvent onIntroDoneAsServer;

		// Token: 0x04001DAF RID: 7599
		public string MusicName;

		// Token: 0x04001DB0 RID: 7600
		private float currentSkipTime;

		// Token: 0x04001DB1 RID: 7601
		private bool depressed = true;
	}
}
