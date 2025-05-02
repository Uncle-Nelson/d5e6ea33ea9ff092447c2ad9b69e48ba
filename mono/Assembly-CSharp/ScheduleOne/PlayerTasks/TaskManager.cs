using System;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000342 RID: 834
	public class TaskManager : Singleton<TaskManager>
	{
		// Token: 0x060012B9 RID: 4793 RVA: 0x000522DE File Offset: 0x000504DE
		protected override void Start()
		{
			base.Start();
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 5);
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000522F8 File Offset: 0x000504F8
		protected virtual void Update()
		{
			if (this.currentTask != null)
			{
				this.currentTask.Update();
			}
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0005230D File Offset: 0x0005050D
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (action.exitType == ExitType.Escape && this.currentTask != null)
			{
				action.used = true;
				this.currentTask.Outcome = Task.EOutcome.Cancelled;
				this.currentTask.StopTask();
			}
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x00052347 File Offset: 0x00050547
		protected virtual void LateUpdate()
		{
			if (this.currentTask != null)
			{
				this.currentTask.LateUpdate();
			}
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x0005235C File Offset: 0x0005055C
		protected virtual void FixedUpdate()
		{
			if (this.currentTask != null)
			{
				this.currentTask.FixedUpdate();
			}
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00052371 File Offset: 0x00050571
		public void PlayTaskCompleteSound()
		{
			this.TaskCompleteSound.Play();
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0005237E File Offset: 0x0005057E
		public void StartTask(Task task)
		{
			this.currentTask = task;
			if (this.OnTaskStarted != null)
			{
				this.OnTaskStarted(task);
			}
		}

		// Token: 0x04001224 RID: 4644
		public Task currentTask;

		// Token: 0x04001225 RID: 4645
		public AudioSourceController TaskCompleteSound;

		// Token: 0x04001226 RID: 4646
		public Action<Task> OnTaskStarted;
	}
}
