using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000C28 RID: 3112
	public class NPCPresenceAccessZone : AccessZone
	{
		// Token: 0x06005748 RID: 22344 RVA: 0x0016EA11 File Offset: 0x0016CC11
		protected override void Awake()
		{
			base.Awake();
		}

		// Token: 0x06005749 RID: 22345 RVA: 0x0016EA19 File Offset: 0x0016CC19
		protected virtual void Start()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x0600574A RID: 22346 RVA: 0x0016EA44 File Offset: 0x0016CC44
		protected virtual void MinPass()
		{
			if (this.TargetNPC == null)
			{
				return;
			}
			this.SetIsOpen(this.DetectionZone.bounds.Contains(this.TargetNPC.Avatar.CenterPoint));
		}

		// Token: 0x04004095 RID: 16533
		public const float CooldownTime = 0.5f;

		// Token: 0x04004096 RID: 16534
		public Collider DetectionZone;

		// Token: 0x04004097 RID: 16535
		public NPC TargetNPC;

		// Token: 0x04004098 RID: 16536
		private float timeSinceNPCSensed = float.MaxValue;
	}
}
