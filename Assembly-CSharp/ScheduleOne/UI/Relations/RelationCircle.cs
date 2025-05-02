using System;
using EasyButtons;
using ScheduleOne.Economy;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Relations
{
	// Token: 0x02000A8B RID: 2699
	public class RelationCircle : MonoBehaviour
	{
		// Token: 0x0600488C RID: 18572 RVA: 0x001303A4 File Offset: 0x0012E5A4
		private void Awake()
		{
			this.LoadNPCData();
			if (this.AssignedNPC != null)
			{
				this.AssignNPC(this.AssignedNPC);
			}
			else if (this.AssignedNPC_ID != string.Empty)
			{
				Console.LogWarning("Failed to find NPC with ID '" + this.AssignedNPC_ID + "'", null);
			}
			this.Button.onClick.AddListener(new UnityAction(this.ButtonClicked));
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.eventID = 0;
			entry.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData <p0>)
			{
				this.HoverStart();
			}));
			this.Trigger.triggers.Add(entry);
			EventTrigger.Entry entry2 = new EventTrigger.Entry();
			entry2.eventID = 1;
			entry2.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData <p0>)
			{
				this.HoverEnd();
			}));
			this.Trigger.triggers.Add(entry2);
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x00130488 File Offset: 0x0012E688
		private void OnValidate()
		{
			if (this.AssignedNPC != null)
			{
				this.AssignedNPC_ID = this.AssignedNPC.ID;
				this.HeadshotImg.sprite = this.AssignedNPC.MugshotSprite;
			}
			if (this.AutoSetName && this.AssignedNPC != null)
			{
				base.gameObject.name = this.AssignedNPC_ID;
			}
		}

		// Token: 0x0600488E RID: 18574 RVA: 0x001304F4 File Offset: 0x0012E6F4
		public void AssignNPC(NPC npc)
		{
			if (npc != null)
			{
				this.UnassignNPC();
			}
			this.AssignedNPC = npc;
			NPCRelationData relationData = this.AssignedNPC.RelationData;
			relationData.onRelationshipChange = (Action<float>)Delegate.Combine(relationData.onRelationshipChange, new Action<float>(this.RelationshipChange));
			NPCRelationData relationData2 = this.AssignedNPC.RelationData;
			relationData2.onUnlocked = (Action<NPCRelationData.EUnlockType, bool>)Delegate.Combine(relationData2.onUnlocked, new Action<NPCRelationData.EUnlockType, bool>(this.SetUnlocked));
			foreach (NPC npc2 in this.AssignedNPC.RelationData.Connections)
			{
				NPCRelationData relationData3 = npc2.RelationData;
				relationData3.onUnlocked = (Action<NPCRelationData.EUnlockType, bool>)Delegate.Combine(relationData3.onUnlocked, new Action<NPCRelationData.EUnlockType, bool>(delegate(NPCRelationData.EUnlockType <p0>, bool <p1>)
				{
					this.UpdateBlackout();
				}));
			}
			if (npc.RelationData.Unlocked)
			{
				this.SetUnlocked(npc.RelationData.UnlockType, false);
			}
			else
			{
				this.SetLocked();
			}
			if (npc is Dealer)
			{
				(npc as Dealer).onRecommended.AddListener(new UnityAction(this.UpdateBlackout));
			}
			this.HeadshotImg.sprite = this.AssignedNPC.MugshotSprite;
			this.RefreshNotchPosition();
			this.RefreshDependenceDisplay();
			this.UpdateBlackout();
		}

		// Token: 0x0600488F RID: 18575 RVA: 0x00130650 File Offset: 0x0012E850
		private void UnassignNPC()
		{
			if (this.AssignedNPC != null)
			{
				NPCRelationData relationData = this.AssignedNPC.RelationData;
				relationData.onRelationshipChange = (Action<float>)Delegate.Remove(relationData.onRelationshipChange, new Action<float>(this.RelationshipChange));
				NPCRelationData relationData2 = this.AssignedNPC.RelationData;
				relationData2.onUnlocked = (Action<NPCRelationData.EUnlockType, bool>)Delegate.Remove(relationData2.onUnlocked, new Action<NPCRelationData.EUnlockType, bool>(this.SetUnlocked));
			}
		}

		// Token: 0x06004890 RID: 18576 RVA: 0x001306C3 File Offset: 0x0012E8C3
		private void RelationshipChange(float change)
		{
			this.RefreshNotchPosition();
		}

		// Token: 0x06004891 RID: 18577 RVA: 0x001306CB File Offset: 0x0012E8CB
		public void SetNotchPosition(float relationshipDelta)
		{
			this.NotchPivot.localRotation = Quaternion.Euler(0f, 0f, Mathf.Lerp(90f, -90f, relationshipDelta / 5f));
		}

		// Token: 0x06004892 RID: 18578 RVA: 0x001306FD File Offset: 0x0012E8FD
		private void RefreshNotchPosition()
		{
			this.SetNotchPosition(this.AssignedNPC.RelationData.RelationDelta);
		}

		// Token: 0x06004893 RID: 18579 RVA: 0x00130718 File Offset: 0x0012E918
		private void RefreshDependenceDisplay()
		{
			Customer component = this.AssignedNPC.GetComponent<Customer>();
			if (component == null)
			{
				this.PortraitBackground.color = RelationCircle.PortraitColor_ZeroDependence;
				return;
			}
			this.PortraitBackground.color = Color.Lerp(RelationCircle.PortraitColor_ZeroDependence, RelationCircle.PortraitColor_MaxDependence, component.CurrentAddiction);
		}

		// Token: 0x06004894 RID: 18580 RVA: 0x0013076B File Offset: 0x0012E96B
		[Button]
		public void SetLocked()
		{
			this.Locked.gameObject.SetActive(true);
			this.NotchPivot.gameObject.SetActive(false);
		}

		// Token: 0x06004895 RID: 18581 RVA: 0x0013078F File Offset: 0x0012E98F
		[Button]
		public void SetUnlocked(NPCRelationData.EUnlockType unlockType, bool notify = true)
		{
			this.Locked.gameObject.SetActive(false);
			this.NotchPivot.gameObject.SetActive(true);
			this.SetBlackedOut(false);
		}

		// Token: 0x06004896 RID: 18582 RVA: 0x001307BA File Offset: 0x0012E9BA
		[Button]
		public void LoadNPCData()
		{
			this.AssignedNPC = NPCManager.GetNPC(this.AssignedNPC_ID);
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x001307D0 File Offset: 0x0012E9D0
		private void UpdateBlackout()
		{
			bool blackedOut = false;
			if (!this.AssignedNPC.RelationData.Unlocked)
			{
				if (this.AssignedNPC is Dealer)
				{
					blackedOut = !(this.AssignedNPC as Dealer).HasBeenRecommended;
				}
				else if (this.AssignedNPC is Supplier)
				{
					blackedOut = true;
				}
				else if (this.AssignedNPC.GetComponent<Customer>() != null)
				{
					blackedOut = (!this.AssignedNPC.RelationData.Unlocked && !this.AssignedNPC.RelationData.IsMutuallyKnown());
				}
			}
			this.SetBlackedOut(blackedOut);
		}

		// Token: 0x06004898 RID: 18584 RVA: 0x00130868 File Offset: 0x0012EA68
		public void SetBlackedOut(bool blackedOut)
		{
			this.HeadshotImg.color = (blackedOut ? Color.black : Color.white);
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x00130884 File Offset: 0x0012EA84
		private void ButtonClicked()
		{
			if (this.onClicked != null)
			{
				this.onClicked();
			}
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x00130899 File Offset: 0x0012EA99
		private void HoverStart()
		{
			if (this.onHoverStart != null)
			{
				this.onHoverStart();
			}
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x001308AE File Offset: 0x0012EAAE
		private void HoverEnd()
		{
			if (this.onHoverEnd != null)
			{
				this.onHoverEnd();
			}
		}

		// Token: 0x040035A4 RID: 13732
		public const float NotchMinRot = 90f;

		// Token: 0x040035A5 RID: 13733
		public const float NotchMaxRot = -90f;

		// Token: 0x040035A6 RID: 13734
		public static Color PortraitColor_ZeroDependence = new Color32(60, 60, 60, byte.MaxValue);

		// Token: 0x040035A7 RID: 13735
		public static Color PortraitColor_MaxDependence = new Color32(120, 15, 15, byte.MaxValue);

		// Token: 0x040035A8 RID: 13736
		public string AssignedNPC_ID = string.Empty;

		// Token: 0x040035A9 RID: 13737
		public NPC AssignedNPC;

		// Token: 0x040035AA RID: 13738
		public Action onClicked;

		// Token: 0x040035AB RID: 13739
		public Action onHoverStart;

		// Token: 0x040035AC RID: 13740
		public Action onHoverEnd;

		// Token: 0x040035AD RID: 13741
		public bool AutoSetName;

		// Token: 0x040035AE RID: 13742
		[Header("References")]
		public RectTransform Rect;

		// Token: 0x040035AF RID: 13743
		public Image PortraitBackground;

		// Token: 0x040035B0 RID: 13744
		public Image HeadshotImg;

		// Token: 0x040035B1 RID: 13745
		public RectTransform NotchPivot;

		// Token: 0x040035B2 RID: 13746
		public RectTransform Locked;

		// Token: 0x040035B3 RID: 13747
		public Button Button;

		// Token: 0x040035B4 RID: 13748
		public EventTrigger Trigger;
	}
}
