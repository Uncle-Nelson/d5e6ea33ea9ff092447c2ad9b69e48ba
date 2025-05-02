using System;
using System.Collections;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x020005AA RID: 1450
	[RequireComponent(typeof(ReflectionProbe))]
	public class ReflectionProbeUpdater : MonoBehaviour
	{
		// Token: 0x060023ED RID: 9197 RVA: 0x00091E99 File Offset: 0x00090099
		private void OnValidate()
		{
			if (this.Probe == null)
			{
				this.Probe = base.GetComponent<ReflectionProbe>();
			}
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x00091EB8 File Offset: 0x000900B8
		private void Start()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onHourPass = (Action)Delegate.Combine(instance.onHourPass, new Action(this.UpdateProbe));
			this.UpdateProbe();
			if (ReflectionProbeUpdater.RenderRoutine == null)
			{
				ReflectionProbeUpdater.RenderRoutine = base.StartCoroutine(this.ProcessQueue());
			}
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x00091F09 File Offset: 0x00090109
		private void UpdateProbe()
		{
			if (!ReflectionProbeUpdater.renderQueue.Contains(this.Probe))
			{
				ReflectionProbeUpdater.renderQueue.Add(this.Probe);
			}
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x00091F2D File Offset: 0x0009012D
		private IEnumerator ProcessQueue()
		{
			int renderDuration_Frames = 14;
			for (;;)
			{
				if (ReflectionProbeUpdater.renderQueue.Count > 0)
				{
					ReflectionProbeUpdater.renderQueue[0].RenderProbe();
					ReflectionProbeUpdater.renderQueue.RemoveAt(0);
				}
				int num;
				for (int i = 0; i < renderDuration_Frames; i = num + 1)
				{
					yield return new WaitForEndOfFrame();
					num = i;
				}
			}
			yield break;
		}

		// Token: 0x04001AD1 RID: 6865
		public ReflectionProbe Probe;

		// Token: 0x04001AD2 RID: 6866
		private static List<ReflectionProbe> renderQueue = new List<ReflectionProbe>();

		// Token: 0x04001AD3 RID: 6867
		private static Coroutine RenderRoutine = null;
	}
}
