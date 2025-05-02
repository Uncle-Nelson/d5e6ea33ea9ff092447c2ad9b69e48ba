using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x0200047E RID: 1150
	public class NPCSignal : NPCAction
	{
		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x0006D8BD File Offset: 0x0006BABD
		public new string ActionName
		{
			get
			{
				return "Signal";
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060018FD RID: 6397 RVA: 0x0006D8C4 File Offset: 0x0006BAC4
		// (set) Token: 0x060018FE RID: 6398 RVA: 0x0006D8CC File Offset: 0x0006BACC
		public bool StartedThisCycle { get; protected set; }

		// Token: 0x060018FF RID: 6399 RVA: 0x0006D8D5 File Offset: 0x0006BAD5
		public override string GetName()
		{
			return this.ActionName;
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0006D8DD File Offset: 0x0006BADD
		public override void ActiveUpdate()
		{
			base.ActiveUpdate();
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x0006D8E5 File Offset: 0x0006BAE5
		public override string GetTimeDescription()
		{
			return ScheduleOne.GameTime.TimeManager.Get12HourTime((float)this.StartTime, true);
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x0006D8F4 File Offset: 0x0006BAF4
		public override int GetEndTime()
		{
			return ScheduleOne.GameTime.TimeManager.AddMinutesTo24HourTime(this.StartTime, this.MaxDuration);
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x0006D907 File Offset: 0x0006BB07
		public override void Started()
		{
			base.Started();
			this.StartedThisCycle = true;
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x0006D916 File Offset: 0x0006BB16
		public override void LateStarted()
		{
			base.LateStarted();
			this.StartedThisCycle = true;
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x0006D925 File Offset: 0x0006BB25
		public override bool ShouldStart()
		{
			return !this.StartedThisCycle && base.ShouldStart();
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x0006D937 File Offset: 0x0006BB37
		public override void Interrupt()
		{
			this.StartedThisCycle = false;
			base.Interrupt();
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x0006D946 File Offset: 0x0006BB46
		public override void MinPassed()
		{
			base.MinPassed();
			if (this.StartedThisCycle && !NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsCurrentTimeWithinRange(this.StartTime, this.GetEndTime()))
			{
				this.StartedThisCycle = false;
			}
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x0006D985 File Offset: 0x0006BB85
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignalAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignalAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x0006D99E File Offset: 0x0006BB9E
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignalAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignalAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x0006D9B7 File Offset: 0x0006BBB7
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x0006D9C5 File Offset: 0x0006BBC5
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040015EC RID: 5612
		public int MaxDuration = 60;

		// Token: 0x040015EE RID: 5614
		private bool dll_Excuted;

		// Token: 0x040015EF RID: 5615
		private bool dll_Excuted;
	}
}
