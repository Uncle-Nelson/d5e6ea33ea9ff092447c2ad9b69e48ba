using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Variables;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A4B RID: 2635
	public class TaskManagerUI : Singleton<TaskManagerUI>
	{
		// Token: 0x06004714 RID: 18196 RVA: 0x00129CA3 File Offset: 0x00127EA3
		protected virtual void Update()
		{
			this.UpdateInstructionLabel();
			this.canvas.enabled = (Singleton<TaskManager>.Instance.currentTask != null);
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x00129CC3 File Offset: 0x00127EC3
		protected override void Start()
		{
			base.Start();
			TaskManager instance = Singleton<TaskManager>.Instance;
			instance.OnTaskStarted = (Action<Task>)Delegate.Combine(instance.OnTaskStarted, new Action<Task>(this.TaskStarted));
			this.multiGrabIndicator.gameObject.SetActive(false);
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x00129D04 File Offset: 0x00127F04
		protected virtual void UpdateInstructionLabel()
		{
			if (Singleton<TaskManager>.Instance.currentTask != null && Singleton<TaskManager>.Instance.currentTask.CurrentInstruction != string.Empty)
			{
				this.textShown = true;
				Singleton<HUD>.Instance.ShowTopScreenText(Singleton<TaskManager>.Instance.currentTask.CurrentInstruction);
				return;
			}
			if (this.textShown)
			{
				this.textShown = false;
				Singleton<HUD>.Instance.HideTopScreenText();
			}
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x00129D74 File Offset: 0x00127F74
		private void TaskStarted(Task task)
		{
			bool value = NetworkSingleton<VariableDatabase>.Instance.GetValue<bool>("InputHintsTutorialDone");
			this.multiGrabIndicator.gameObject.SetActive(false);
			if (GameManager.IS_TUTORIAL && !value && !Application.isEditor)
			{
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("InputHintsTutorialDone", true.ToString(), true);
				this.inputPromptUI.Open();
			}
		}

		// Token: 0x0400347C RID: 13436
		private bool textShown;

		// Token: 0x0400347D RID: 13437
		public GenericUIScreen inputPromptUI;

		// Token: 0x0400347E RID: 13438
		public Canvas canvas;

		// Token: 0x0400347F RID: 13439
		public RectTransform multiGrabIndicator;

		// Token: 0x04003480 RID: 13440
		public GenericUIScreen PackagingStationMK2TutorialDone;
	}
}
