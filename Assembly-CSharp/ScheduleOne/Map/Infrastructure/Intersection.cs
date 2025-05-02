using System;
using System.Collections;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Map.Infrastructure
{
	// Token: 0x02000C39 RID: 3129
	public class Intersection : MonoBehaviour
	{
		// Token: 0x060057A7 RID: 22439 RVA: 0x0016FBE2 File Offset: 0x0016DDE2
		protected virtual void Start()
		{
			Singleton<CoroutineService>.Instance.StartCoroutine(this.Run());
		}

		// Token: 0x060057A8 RID: 22440 RVA: 0x0016FBF5 File Offset: 0x0016DDF5
		protected IEnumerator Run()
		{
			for (;;)
			{
				this.SetPath1Lights(TrafficLight.State.Green);
				this.SetPath2Lights(TrafficLight.State.Red);
				if (this.timeOffset != 0f)
				{
					yield return new WaitForSecondsRealtime(Mathf.Abs(this.timeOffset));
					this.timeOffset = 0f;
				}
				yield return new WaitForSecondsRealtime(this.path1Time);
				this.SetPath1Lights(TrafficLight.State.Orange);
				yield return new WaitForSecondsRealtime(TrafficLight.amberTime);
				this.SetPath1Lights(TrafficLight.State.Red);
				yield return new WaitForSecondsRealtime(1f);
				this.SetPath2Lights(TrafficLight.State.Green);
				yield return new WaitForSecondsRealtime(this.path2Time);
				this.SetPath2Lights(TrafficLight.State.Orange);
				yield return new WaitForSecondsRealtime(TrafficLight.amberTime);
				this.SetPath2Lights(TrafficLight.State.Red);
				yield return new WaitForSecondsRealtime(1f);
			}
			yield break;
		}

		// Token: 0x060057A9 RID: 22441 RVA: 0x0016FC04 File Offset: 0x0016DE04
		protected void SetPath1Lights(TrafficLight.State state)
		{
			foreach (TrafficLight trafficLight in this.path1Lights)
			{
				trafficLight.state = state;
			}
			if (state == TrafficLight.State.Green)
			{
				using (List<GameObject>.Enumerator enumerator2 = this.path1Obstacles.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						GameObject gameObject = enumerator2.Current;
						gameObject.gameObject.SetActive(false);
					}
					return;
				}
			}
			foreach (GameObject gameObject2 in this.path1Obstacles)
			{
				gameObject2.gameObject.SetActive(true);
			}
		}

		// Token: 0x060057AA RID: 22442 RVA: 0x0016FCE4 File Offset: 0x0016DEE4
		protected void SetPath2Lights(TrafficLight.State state)
		{
			foreach (TrafficLight trafficLight in this.path2Lights)
			{
				trafficLight.state = state;
			}
			if (state == TrafficLight.State.Green)
			{
				using (List<GameObject>.Enumerator enumerator2 = this.path2Obstacles.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						GameObject gameObject = enumerator2.Current;
						gameObject.gameObject.SetActive(false);
					}
					return;
				}
			}
			foreach (GameObject gameObject2 in this.path2Obstacles)
			{
				gameObject2.gameObject.SetActive(true);
			}
		}

		// Token: 0x040040ED RID: 16621
		[Header("References")]
		[SerializeField]
		protected List<TrafficLight> path1Lights = new List<TrafficLight>();

		// Token: 0x040040EE RID: 16622
		[SerializeField]
		protected List<TrafficLight> path2Lights = new List<TrafficLight>();

		// Token: 0x040040EF RID: 16623
		[SerializeField]
		protected List<GameObject> path1Obstacles = new List<GameObject>();

		// Token: 0x040040F0 RID: 16624
		[SerializeField]
		protected List<GameObject> path2Obstacles = new List<GameObject>();

		// Token: 0x040040F1 RID: 16625
		[Header("Settings")]
		[SerializeField]
		protected float path1Time = 10f;

		// Token: 0x040040F2 RID: 16626
		[SerializeField]
		protected float path2Time = 10f;

		// Token: 0x040040F3 RID: 16627
		[SerializeField]
		protected float timeOffset;
	}
}
