using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Quests
{
	// Token: 0x020002FF RID: 767
	public class StateMachine : MonoBehaviour
	{
		// Token: 0x06001108 RID: 4360 RVA: 0x0004C115 File Offset: 0x0004A315
		private void Start()
		{
			Singleton<LoadManager>.Instance.onPreSceneChange.AddListener(new UnityAction(this.Clean));
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x0004C132 File Offset: 0x0004A332
		private void Update()
		{
			if (StateMachine.stateChanged)
			{
				Action onStateChange = StateMachine.OnStateChange;
				if (onStateChange != null)
				{
					onStateChange();
				}
				StateMachine.stateChanged = false;
			}
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0004C151 File Offset: 0x0004A351
		private void Clean()
		{
			Debug.Log("Clearing state change...");
			StateMachine.OnStateChange = null;
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0004C163 File Offset: 0x0004A363
		public static void ChangeState()
		{
			StateMachine.stateChanged = true;
		}

		// Token: 0x0400112F RID: 4399
		public static Action OnStateChange;

		// Token: 0x04001130 RID: 4400
		private static bool stateChanged;
	}
}
