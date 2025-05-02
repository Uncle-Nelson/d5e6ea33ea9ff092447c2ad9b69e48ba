using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.Doors;
using ScheduleOne.Interaction;
using ScheduleOne.Levelling;
using ScheduleOne.NPCs.CharacterClasses;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000C16 RID: 3094
	public class DarkMarketMainDoor : MonoBehaviour
	{
		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x060056F5 RID: 22261 RVA: 0x0016DA1C File Offset: 0x0016BC1C
		// (set) Token: 0x060056F6 RID: 22262 RVA: 0x0016DA24 File Offset: 0x0016BC24
		public bool KnockingEnabled { get; private set; } = true;

		// Token: 0x060056F7 RID: 22263 RVA: 0x0016DA2D File Offset: 0x0016BC2D
		private void Start()
		{
			this.Igor.gameObject.SetActive(false);
		}

		// Token: 0x060056F8 RID: 22264 RVA: 0x0016DA40 File Offset: 0x0016BC40
		public void SetKnockingEnabled(bool enabled)
		{
			this.InteractableObject.gameObject.SetActive(enabled);
			this.KnockingEnabled = enabled;
		}

		// Token: 0x060056F9 RID: 22265 RVA: 0x0016DA5C File Offset: 0x0016BC5C
		public void Hovered()
		{
			if (this.KnockingEnabled && this.knockRoutine == null && Player.Local.CrimeData.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.None)
			{
				this.InteractableObject.SetMessage("Knock");
				this.InteractableObject.SetInteractableState(InteractableObject.EInteractableState.Default);
				return;
			}
			this.InteractableObject.SetInteractableState(InteractableObject.EInteractableState.Disabled);
		}

		// Token: 0x060056FA RID: 22266 RVA: 0x0016DAB3 File Offset: 0x0016BCB3
		public void Interacted()
		{
			this.Knocked();
		}

		// Token: 0x060056FB RID: 22267 RVA: 0x0016DABB File Offset: 0x0016BCBB
		private void Knocked()
		{
			this.knockRoutine = base.StartCoroutine(this.<Knocked>g__Knock|16_0());
		}

		// Token: 0x060056FD RID: 22269 RVA: 0x0016DADE File Offset: 0x0016BCDE
		[CompilerGenerated]
		private IEnumerator <Knocked>g__Knock|16_0()
		{
			this.KnockSound.Play();
			this.Igor.gameObject.SetActive(true);
			this.Igor.Avatar.LookController.ForceLookTarget = PlayerSingleton<PlayerCamera>.Instance.transform;
			yield return new WaitForSeconds(0.75f);
			this.Igor.gameObject.SetActive(true);
			this.Peephole.Open();
			yield return new WaitForSeconds(0.3f);
			bool shouldUnlock = false;
			if (Vector3.Distance(Player.Local.transform.position, base.transform.position) < 3f)
			{
				shouldUnlock = (NetworkSingleton<LevelManager>.Instance.GetFullRank() >= NetworkSingleton<DarkMarket>.Instance.UnlockRank);
				DialogueContainer container = shouldUnlock ? (NetworkSingleton<DarkMarket>.Instance.IsOpen ? this.SuccessDialogue : this.SuccessDialogueNotOpen) : this.FailDialogue;
				this.Igor.dialogueHandler.InitializeDialogue(container);
				yield return new WaitUntil(() => !this.Igor.dialogueHandler.IsPlaying);
			}
			else
			{
				yield return new WaitForSeconds(1f);
			}
			yield return new WaitForSeconds(0.2f);
			this.Peephole.Close();
			yield return new WaitForSeconds(0.2f);
			if (shouldUnlock)
			{
				NetworkSingleton<DarkMarket>.Instance.SendUnlocked();
			}
			else
			{
				HintDisplay instance = Singleton<HintDisplay>.Instance;
				string str = "Reach the rank of <h1>";
				FullRank unlockRank = NetworkSingleton<DarkMarket>.Instance.UnlockRank;
				instance.ShowHint(str + unlockRank.ToString() + "</h> to access this area.", 15f);
			}
			yield return new WaitForSeconds(0.5f);
			this.Igor.gameObject.SetActive(false);
			this.knockRoutine = null;
			yield break;
		}

		// Token: 0x04004049 RID: 16457
		public AudioSource KnockSound;

		// Token: 0x0400404A RID: 16458
		public InteractableObject InteractableObject;

		// Token: 0x0400404B RID: 16459
		public Peephole Peephole;

		// Token: 0x0400404C RID: 16460
		public Igor Igor;

		// Token: 0x0400404D RID: 16461
		public DialogueContainer FailDialogue;

		// Token: 0x0400404E RID: 16462
		public DialogueContainer SuccessDialogue;

		// Token: 0x0400404F RID: 16463
		public DialogueContainer SuccessDialogueNotOpen;

		// Token: 0x04004050 RID: 16464
		private Coroutine knockRoutine;
	}
}
