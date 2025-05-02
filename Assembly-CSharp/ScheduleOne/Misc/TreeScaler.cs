using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Misc
{
	// Token: 0x02000C0E RID: 3086
	public class TreeScaler : MonoBehaviour
	{
		// Token: 0x060056CB RID: 22219 RVA: 0x0016D093 File Offset: 0x0016B293
		protected virtual void Start()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.UpdateScale));
		}

		// Token: 0x060056CC RID: 22220 RVA: 0x0016D0BC File Offset: 0x0016B2BC
		private void UpdateScale()
		{
			float num = Mathf.Clamp(Vector3.Distance(base.transform.position, PlayerSingleton<PlayerCamera>.Instance.transform.position), this.minScaleDistance, this.maxScaleDistance) / (this.maxScaleDistance - this.minScaleDistance);
			float num2 = this.minScale + (this.maxScale - this.minScale) * num;
			foreach (Transform transform in this.branchMeshes)
			{
				transform.localScale = new Vector3(num2, 1f, num2);
			}
		}

		// Token: 0x04004028 RID: 16424
		[Header("References")]
		[SerializeField]
		protected List<Transform> branchMeshes = new List<Transform>();

		// Token: 0x04004029 RID: 16425
		public float minScale = 1f;

		// Token: 0x0400402A RID: 16426
		public float maxScale = 1.3f;

		// Token: 0x0400402B RID: 16427
		public float minScaleDistance = 20f;

		// Token: 0x0400402C RID: 16428
		public float maxScaleDistance = 100f;
	}
}
