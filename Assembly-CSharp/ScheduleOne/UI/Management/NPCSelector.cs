using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AFD RID: 2813
	public class NPCSelector : MonoBehaviour
	{
		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06004B30 RID: 19248 RVA: 0x0013C214 File Offset: 0x0013A414
		// (set) Token: 0x06004B31 RID: 19249 RVA: 0x0013C21C File Offset: 0x0013A41C
		public bool IsOpen { get; protected set; }

		// Token: 0x06004B32 RID: 19250 RVA: 0x0013C225 File Offset: 0x0013A425
		private void Start()
		{
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 12);
			Singleton<ManagementClipboard>.Instance.onClipboardUnequipped.AddListener(new UnityAction(this.ClipboardClosed));
		}

		// Token: 0x06004B33 RID: 19251 RVA: 0x0013C258 File Offset: 0x0013A458
		public virtual void Open(string selectionTitle, Type typeRequirement, Action<NPC> _callback)
		{
			this.IsOpen = true;
			this.TypeRequirement = typeRequirement;
			this.callback = _callback;
			Singleton<HUD>.Instance.ShowTopScreenText(selectionTitle);
			Singleton<ManagementInterface>.Instance.EquippedClipboard.OverrideClipboardText(selectionTitle);
			Singleton<ManagementClipboard>.Instance.Close(true);
			Singleton<InputPromptsCanvas>.Instance.LoadModule("npcselector");
		}

		// Token: 0x06004B34 RID: 19252 RVA: 0x0013C2B0 File Offset: 0x0013A4B0
		public virtual void Close(bool returnToClipboard)
		{
			this.IsOpen = false;
			if (Singleton<InputPromptsCanvas>.Instance.currentModuleLabel == "npcselector")
			{
				Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			}
			Singleton<HUD>.Instance.HideTopScreenText();
			if (this.highlightedNPC != null)
			{
				this.highlightedNPC.HideOutline();
				this.highlightedNPC = null;
			}
			if (returnToClipboard)
			{
				Singleton<ManagementInterface>.Instance.EquippedClipboard.EndOverride();
				Singleton<ManagementClipboard>.Instance.Open(Singleton<ManagementInterface>.Instance.Configurables, Singleton<ManagementInterface>.Instance.EquippedClipboard);
			}
		}

		// Token: 0x06004B35 RID: 19253 RVA: 0x0013C340 File Offset: 0x0013A540
		private void Update()
		{
			if (!this.IsOpen)
			{
				return;
			}
			this.hoveredNPC = this.GetHoveredNPC();
			if (this.hoveredNPC != null && this.IsNPCTypeValid(this.hoveredNPC))
			{
				if (this.hoveredNPC != this.highlightedNPC)
				{
					if (this.highlightedNPC != null)
					{
						this.highlightedNPC.HideOutline();
						this.highlightedNPC = null;
					}
					this.highlightedNPC = this.hoveredNPC;
					this.highlightedNPC.ShowOutline(this.HoverOutlineColor);
				}
			}
			else if (this.highlightedNPC != null)
			{
				this.highlightedNPC.HideOutline();
				this.highlightedNPC = null;
			}
			if (GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick) && this.hoveredNPC != null && this.IsNPCTypeValid(this.hoveredNPC))
			{
				this.NPCClicked(this.hoveredNPC);
			}
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x0013C420 File Offset: 0x0013A620
		private NPC GetHoveredNPC()
		{
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast(5f, out raycastHit, this.DetectionMask, false, 0.1f))
			{
				return raycastHit.collider.GetComponentInParent<NPC>();
			}
			return null;
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x0013C45A File Offset: 0x0013A65A
		public bool IsNPCTypeValid(NPC npc)
		{
			return this.TypeRequirement == null || this.TypeRequirement.IsAssignableFrom(npc.GetType());
		}

		// Token: 0x06004B38 RID: 19256 RVA: 0x0013C47D File Offset: 0x0013A67D
		public void NPCClicked(NPC npc)
		{
			if (!this.IsNPCTypeValid(npc))
			{
				return;
			}
			Action<NPC> action = this.callback;
			if (action != null)
			{
				action(this.hoveredNPC);
			}
			this.Close(true);
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x0013C4A7 File Offset: 0x0013A6A7
		private void ClipboardClosed()
		{
			this.Close(false);
		}

		// Token: 0x06004B3A RID: 19258 RVA: 0x0013C4B0 File Offset: 0x0013A6B0
		private void Exit(ExitAction exitAction)
		{
			if (!this.IsOpen)
			{
				return;
			}
			if (exitAction.used)
			{
				return;
			}
			if (exitAction.exitType == ExitType.Escape)
			{
				exitAction.used = true;
				this.Close(true);
			}
		}

		// Token: 0x04003865 RID: 14437
		public const float SELECTION_RANGE = 5f;

		// Token: 0x04003867 RID: 14439
		[Header("Settings")]
		public LayerMask DetectionMask;

		// Token: 0x04003868 RID: 14440
		public Color HoverOutlineColor;

		// Token: 0x04003869 RID: 14441
		private Type TypeRequirement;

		// Token: 0x0400386A RID: 14442
		private Action<NPC> callback;

		// Token: 0x0400386B RID: 14443
		private NPC hoveredNPC;

		// Token: 0x0400386C RID: 14444
		private NPC highlightedNPC;
	}
}
