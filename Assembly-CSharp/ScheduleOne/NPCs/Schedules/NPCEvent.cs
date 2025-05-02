using System;
using EasyButtons;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x0200047D RID: 1149
	public class NPCEvent : NPCAction
	{
		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x0006D73E File Offset: 0x0006B93E
		public new string ActionName
		{
			get
			{
				return "Event";
			}
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x0006D745 File Offset: 0x0006B945
		[Button]
		public void ApplyDuration()
		{
			Debug.Log("Applying duration");
			this.EndTime = ScheduleOne.GameTime.TimeManager.AddMinutesTo24HourTime(this.StartTime, this.Duration);
			base.GetComponentInParent<NPCScheduleManager>().InitializeActions();
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0006D774 File Offset: 0x0006B974
		[Button]
		public void ApplyEndTime()
		{
			if (this.EndTime > this.StartTime)
			{
				Debug.Log("Set duration");
				this.Duration = ScheduleOne.GameTime.TimeManager.GetMinSumFrom24HourTime(this.EndTime) - ScheduleOne.GameTime.TimeManager.GetMinSumFrom24HourTime(this.StartTime);
			}
			else
			{
				Debug.Log("Set duration");
				this.Duration = 1440 - ScheduleOne.GameTime.TimeManager.GetMinSumFrom24HourTime(this.StartTime) + ScheduleOne.GameTime.TimeManager.GetMinSumFrom24HourTime(this.EndTime);
			}
			base.GetComponentInParent<NPCScheduleManager>().InitializeActions();
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0006D7F0 File Offset: 0x0006B9F0
		public override void ActiveMinPassed()
		{
			base.ActiveMinPassed();
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.CurrentTime == this.GetEndTime())
			{
				this.End();
			}
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x0006D810 File Offset: 0x0006BA10
		public override void PendingMinPassed()
		{
			base.PendingMinPassed();
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x0006D818 File Offset: 0x0006BA18
		public override string GetName()
		{
			return this.ActionName;
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x0006D820 File Offset: 0x0006BA20
		public override string GetTimeDescription()
		{
			return ScheduleOne.GameTime.TimeManager.Get12HourTime((float)this.StartTime, true) + " - " + ScheduleOne.GameTime.TimeManager.Get12HourTime((float)this.GetEndTime(), true);
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x0006D846 File Offset: 0x0006BA46
		public override int GetEndTime()
		{
			return ScheduleOne.GameTime.TimeManager.AddMinutesTo24HourTime(this.StartTime, this.Duration);
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x0006D869 File Offset: 0x0006BA69
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEventAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEventAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x0006D882 File Offset: 0x0006BA82
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEventAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEventAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x0006D89B File Offset: 0x0006BA9B
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x0006D8A9 File Offset: 0x0006BAA9
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040015E8 RID: 5608
		public int Duration = 60;

		// Token: 0x040015E9 RID: 5609
		public int EndTime;

		// Token: 0x040015EA RID: 5610
		private bool dll_Excuted;

		// Token: 0x040015EB RID: 5611
		private bool dll_Excuted;
	}
}
