using System;
using FishNet;
using ScheduleOne.Doors;
using ScheduleOne.Misc;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Map
{
	// Token: 0x02000C12 RID: 3090
	public class AccessZone : MonoBehaviour
	{
		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x060056D3 RID: 22227 RVA: 0x0016D2C7 File Offset: 0x0016B4C7
		// (set) Token: 0x060056D4 RID: 22228 RVA: 0x0016D2CF File Offset: 0x0016B4CF
		public bool IsOpen { get; protected set; }

		// Token: 0x060056D5 RID: 22229 RVA: 0x0016D2D8 File Offset: 0x0016B4D8
		protected virtual void Awake()
		{
			this.IsOpen = true;
			this.SetIsOpen(false);
		}

		// Token: 0x060056D6 RID: 22230 RVA: 0x0016D2E8 File Offset: 0x0016B4E8
		public virtual void SetIsOpen(bool open)
		{
			bool isOpen = this.IsOpen;
			this.IsOpen = open;
			foreach (DoorController doorController in this.Doors)
			{
				if (this.IsOpen)
				{
					doorController.PlayerAccess = EDoorAccess.Open;
				}
				else if (this.AllowExitWhenClosed)
				{
					doorController.PlayerAccess = EDoorAccess.ExitOnly;
				}
				else
				{
					doorController.PlayerAccess = EDoorAccess.Locked;
				}
			}
			for (int j = 0; j < this.Lights.Length; j++)
			{
				this.Lights[j].isOn = this.IsOpen;
			}
			if (this.IsOpen && !isOpen && this.onOpen != null)
			{
				this.onOpen.Invoke();
			}
			if (!this.IsOpen && isOpen && this.onClose != null)
			{
				this.onClose.Invoke();
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.IsOpen && this.AutoCloseDoor)
			{
				foreach (DoorController doorController2 in this.Doors)
				{
					if ((!doorController2.openedByNPC || doorController2.timeSinceNPCSensed >= 1f) && doorController2.IsOpen && ((doorController2.timeSincePlayerSensed > 0.5f && doorController2.playerDetectedSinceOpened) || doorController2.timeSincePlayerSensed > 15f))
					{
						doorController2.SetIsOpen(null, false, EDoorSide.Interior);
					}
				}
			}
		}

		// Token: 0x04004037 RID: 16439
		[Header("Settings")]
		public bool AllowExitWhenClosed;

		// Token: 0x04004038 RID: 16440
		public bool AutoCloseDoor = true;

		// Token: 0x04004039 RID: 16441
		[Header("References")]
		public DoorController[] Doors;

		// Token: 0x0400403A RID: 16442
		public ToggleableLight[] Lights;

		// Token: 0x0400403B RID: 16443
		public UnityEvent onOpen;

		// Token: 0x0400403C RID: 16444
		public UnityEvent onClose;
	}
}
