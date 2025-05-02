using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FluffyUnderware.DevTools.Extensions;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.Map;
using ScheduleOne.NPCs;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Doors
{
	// Token: 0x02000692 RID: 1682
	public class StaticDoor : MonoBehaviour
	{
		// Token: 0x06002E9A RID: 11930 RVA: 0x000C34F4 File Offset: 0x000C16F4
		protected virtual void Awake()
		{
			this.IntObj.onHovered.AddListener(new UnityAction(this.Hovered));
			this.IntObj.onInteractStart.AddListener(new UnityAction(this.Interacted));
			if (this.Building == null)
			{
				this.Building = base.GetComponentInParent<NPCEnterableBuilding>();
				if (this.Building == null && (this.Usable || this.CanKnock))
				{
					Console.LogWarning("StaticDoor " + base.name + " has no NPCEnterableBuilding!", null);
					this.Usable = false;
					this.CanKnock = false;
				}
			}
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x000C359C File Offset: 0x000C179C
		protected virtual void OnValidate()
		{
			if (this.Building == null)
			{
				this.Building = base.GetComponentInParent<NPCEnterableBuilding>();
			}
			if (this.Building != null && !base.transform.IsChildOf(this.Building.transform))
			{
				Console.LogWarning("StaticDoor " + base.name + " is not a child of " + this.Building.BuildingName, null);
			}
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x000C360F File Offset: 0x000C180F
		protected virtual void Update()
		{
			if (this.timeSinceLastKnock < 2f)
			{
				this.timeSinceLastKnock += Time.deltaTime;
			}
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x000C3630 File Offset: 0x000C1830
		protected virtual void Hovered()
		{
			if (!this.CanKnockNow())
			{
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				return;
			}
			string message;
			if (this.IsKnockValid(out message))
			{
				this.IntObj.SetMessage("Knock");
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				return;
			}
			this.IntObj.SetMessage(message);
			this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Invalid);
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x000C3691 File Offset: 0x000C1891
		protected virtual bool CanKnockNow()
		{
			return this.CanKnock && this.timeSinceLastKnock >= 2f && this.Building != null;
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x00070B96 File Offset: 0x0006ED96
		protected virtual bool IsKnockValid(out string message)
		{
			message = string.Empty;
			return true;
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x000C36B6 File Offset: 0x000C18B6
		protected virtual void Interacted()
		{
			this.Knock();
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x000C36BE File Offset: 0x000C18BE
		protected virtual void Knock()
		{
			this.timeSinceLastKnock = 0f;
			if (this.KnockSound != null)
			{
				this.KnockSound.Play();
			}
			base.StartCoroutine(this.<Knock>g__knockRoutine|16_0());
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x000C36F4 File Offset: 0x000C18F4
		protected virtual void NPCSelected(NPC npc)
		{
			npc.behaviour.Summon(this.Building.GUID.ToString(), ArrayExt.IndexOf<StaticDoor>(this.Building.Doors, this), 8f);
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x000C375C File Offset: 0x000C195C
		[CompilerGenerated]
		private IEnumerator <Knock>g__knockRoutine|16_0()
		{
			yield return new WaitForSeconds(0.7f);
			if (this.Building.OccupantCount > 0)
			{
				if (this.Building.OccupantCount == 1)
				{
					this.NPCSelected(this.Building.GetSummonableNPCs()[0]);
				}
				else
				{
					Singleton<NPCSummonMenu>.Instance.Open(this.Building.GetSummonableNPCs(), new Action<NPC>(this.NPCSelected));
				}
			}
			else
			{
				Console.Log("Building is empty!", null);
			}
			yield break;
		}

		// Token: 0x0400211B RID: 8475
		public const float KNOCK_COOLDOWN = 2f;

		// Token: 0x0400211C RID: 8476
		public const float SUMMON_DURATION = 8f;

		// Token: 0x0400211D RID: 8477
		[Header("References")]
		public Transform AccessPoint;

		// Token: 0x0400211E RID: 8478
		public InteractableObject IntObj;

		// Token: 0x0400211F RID: 8479
		public AudioSourceController KnockSound;

		// Token: 0x04002120 RID: 8480
		public NPCEnterableBuilding Building;

		// Token: 0x04002121 RID: 8481
		[Header("Settings")]
		public bool Usable = true;

		// Token: 0x04002122 RID: 8482
		public bool CanKnock = true;

		// Token: 0x04002123 RID: 8483
		private float timeSinceLastKnock = 2f;
	}
}
