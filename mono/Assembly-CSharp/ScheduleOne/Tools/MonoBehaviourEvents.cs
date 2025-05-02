using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000866 RID: 2150
	public class MonoBehaviourEvents : MonoBehaviour
	{
		// Token: 0x06003AA4 RID: 15012 RVA: 0x000F7191 File Offset: 0x000F5391
		private void Awake()
		{
			UnityEvent unityEvent = this.onAwake;
			if (unityEvent == null)
			{
				return;
			}
			unityEvent.Invoke();
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x000F71A3 File Offset: 0x000F53A3
		private void Start()
		{
			UnityEvent unityEvent = this.onStart;
			if (unityEvent == null)
			{
				return;
			}
			unityEvent.Invoke();
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x000F71B5 File Offset: 0x000F53B5
		private void Update()
		{
			UnityEvent unityEvent = this.onUpdate;
			if (unityEvent == null)
			{
				return;
			}
			unityEvent.Invoke();
		}

		// Token: 0x04002A32 RID: 10802
		public UnityEvent onAwake;

		// Token: 0x04002A33 RID: 10803
		public UnityEvent onStart;

		// Token: 0x04002A34 RID: 10804
		public UnityEvent onUpdate;
	}
}
