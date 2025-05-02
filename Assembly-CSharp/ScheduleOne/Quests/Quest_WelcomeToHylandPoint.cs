using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EasyButtons;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs.CharacterClasses;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;
using ScheduleOne.UI.Input;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace ScheduleOne.Quests
{
	// Token: 0x020002FA RID: 762
	public class Quest_WelcomeToHylandPoint : Quest
	{
		// Token: 0x060010F7 RID: 4343 RVA: 0x0004BDB4 File Offset: 0x00049FB4
		protected override void MinPass()
		{
			base.MinPass();
			if (base.QuestState == EQuestState.Active && this.ReadMessagesQuest.State == EQuestState.Active && this.Nelson.MSGConversation != null && this.Nelson.MSGConversation.read)
			{
				this.ReadMessagesQuest.Complete();
			}
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x0004BE08 File Offset: 0x0004A008
		private void Update()
		{
			if (base.QuestState == EQuestState.Active && this.ReturnToRVQuest.State == EQuestState.Active && InstanceFinder.IsServer)
			{
				float num;
				Player closestPlayer = Player.GetClosestPlayer(this.RV.transform.position, out num, null);
				if (num < this.ExplosionMinDist)
				{
					this.ReturnToRVQuest.Complete();
					return;
				}
				if (num < this.ExplosionMaxDist)
				{
					if (Vector3.Angle(closestPlayer.MimicCamera.forward, this.RV.transform.position - closestPlayer.MimicCamera.position) < 60f)
					{
						this.cameraLookTime += Time.deltaTime;
						if (this.cameraLookTime > 0.4f)
						{
							this.ReturnToRVQuest.Complete();
							return;
						}
					}
					else
					{
						this.cameraLookTime = 0f;
					}
				}
			}
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x0004BEE0 File Offset: 0x0004A0E0
		[Button]
		public void Explode()
		{
			Console.Log("RV exploding!", null);
			if (this.onExplode != null)
			{
				this.onExplode.Invoke();
			}
			base.StartCoroutine(Quest_WelcomeToHylandPoint.<Explode>g__Shake|11_0());
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0004BF0C File Offset: 0x0004A10C
		public override void SetQuestState(EQuestState state, bool network = true)
		{
			base.SetQuestState(state, network);
			if (state == EQuestState.Active)
			{
				string text;
				string controlPath;
				InputActionRebindingExtensions.GetBindingDisplayString(Singleton<GameInput>.Instance.GetAction(GameInput.ButtonCode.TogglePhone), 0, ref text, ref controlPath, 0);
				string displayNameForControlPath = Singleton<InputPromptsManager>.Instance.GetDisplayNameForControlPath(controlPath);
				this.ReadMessagesQuest.SetEntryTitle("Open your phone (press " + displayNameForControlPath + ") and read your messages");
			}
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0004BF82 File Offset: 0x0004A182
		[CompilerGenerated]
		internal static IEnumerator <Explode>g__Shake|11_0()
		{
			yield return new WaitForSeconds(0.35f);
			PlayerSingleton<PlayerCamera>.Instance.StartCameraShake(2f, 1f, true);
			yield break;
		}

		// Token: 0x04001119 RID: 4377
		public QuestEntry ReturnToRVQuest;

		// Token: 0x0400111A RID: 4378
		public QuestEntry ReadMessagesQuest;

		// Token: 0x0400111B RID: 4379
		public RV RV;

		// Token: 0x0400111C RID: 4380
		public UncleNelson Nelson;

		// Token: 0x0400111D RID: 4381
		[Header("Settings")]
		public float ExplosionMaxDist = 25f;

		// Token: 0x0400111E RID: 4382
		public float ExplosionMinDist = 50f;

		// Token: 0x0400111F RID: 4383
		public UnityEvent onExplode;

		// Token: 0x04001120 RID: 4384
		private bool exploded;

		// Token: 0x04001121 RID: 4385
		private float cameraLookTime;
	}
}
