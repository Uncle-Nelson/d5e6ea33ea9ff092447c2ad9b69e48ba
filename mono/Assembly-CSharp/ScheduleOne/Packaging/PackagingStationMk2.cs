using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.UI;
using ScheduleOne.Variables;

namespace ScheduleOne.Packaging
{
	// Token: 0x02000891 RID: 2193
	public class PackagingStationMk2 : PackagingStation
	{
		// Token: 0x06003B50 RID: 15184 RVA: 0x000F947C File Offset: 0x000F767C
		public override void StartTask()
		{
			new PackageProductTaskMk2(this);
			if (!NetworkSingleton<VariableDatabase>.Instance.GetValue<bool>("PackagingStationMk2TutorialDone"))
			{
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("PackagingStationMk2TutorialDone", true.ToString(), true);
				Singleton<TaskManagerUI>.Instance.PackagingStationMK2TutorialDone.Open();
			}
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x000F94D1 File Offset: 0x000F76D1
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Packaging.PackagingStationMk2Assembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Packaging.PackagingStationMk2Assembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06003B53 RID: 15187 RVA: 0x000F94EA File Offset: 0x000F76EA
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Packaging.PackagingStationMk2Assembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Packaging.PackagingStationMk2Assembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06003B54 RID: 15188 RVA: 0x000F9503 File Offset: 0x000F7703
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x000F9511 File Offset: 0x000F7711
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04002ACE RID: 10958
		public PackagingTool PackagingTool;

		// Token: 0x04002ACF RID: 10959
		private bool dll_Excuted;

		// Token: 0x04002AD0 RID: 10960
		private bool dll_Excuted;
	}
}
