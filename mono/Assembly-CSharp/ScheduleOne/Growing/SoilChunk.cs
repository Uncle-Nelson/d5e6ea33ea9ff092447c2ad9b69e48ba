using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x02000887 RID: 2183
	public class SoilChunk : Clickable
	{
		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06003B21 RID: 15137 RVA: 0x000F8E0D File Offset: 0x000F700D
		// (set) Token: 0x06003B22 RID: 15138 RVA: 0x000F8E15 File Offset: 0x000F7015
		public float CurrentLerp { get; protected set; }

		// Token: 0x06003B23 RID: 15139 RVA: 0x000F8E1E File Offset: 0x000F701E
		protected virtual void Awake()
		{
			this.localPos_Start = base.transform.localPosition;
			this.localEulerAngles_Start = base.transform.localEulerAngles;
			this.localScale_Start = base.transform.localScale;
		}

		// Token: 0x06003B24 RID: 15140 RVA: 0x000F8E54 File Offset: 0x000F7054
		public void SetLerpedTransform(float _lerp)
		{
			this.CurrentLerp = Mathf.Clamp(_lerp, 0f, 1f);
			base.transform.localPosition = Vector3.Lerp(this.localPos_Start, this.EndTransform.localPosition, this.CurrentLerp);
			base.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(this.localEulerAngles_Start), Quaternion.Euler(this.EndTransform.localEulerAngles), this.CurrentLerp);
			base.transform.localScale = Vector3.Lerp(this.localScale_Start, this.EndTransform.localScale, this.CurrentLerp);
		}

		// Token: 0x06003B25 RID: 15141 RVA: 0x000F8EF6 File Offset: 0x000F70F6
		public override void StartClick(RaycastHit hit)
		{
			base.StartClick(hit);
			this.ClickableEnabled = false;
			this.StopLerp();
			this.lerpRoutine = base.StartCoroutine(this.<StartClick>g__Lerp|12_0());
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x000F8F1E File Offset: 0x000F711E
		public void StopLerp()
		{
			if (this.lerpRoutine != null)
			{
				base.StopCoroutine(this.lerpRoutine);
			}
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x000F8F47 File Offset: 0x000F7147
		[CompilerGenerated]
		private IEnumerator <StartClick>g__Lerp|12_0()
		{
			for (float i = 0f; i < this.LerpTime; i += Time.deltaTime)
			{
				this.SetLerpedTransform(Mathf.Lerp(0f, 1f, i / this.LerpTime));
				yield return new WaitForEndOfFrame();
			}
			this.SetLerpedTransform(1f);
			this.lerpRoutine = null;
			yield break;
		}

		// Token: 0x04002AAE RID: 10926
		public Transform EndTransform;

		// Token: 0x04002AAF RID: 10927
		public float LerpTime = 0.4f;

		// Token: 0x04002AB0 RID: 10928
		private Vector3 localPos_Start;

		// Token: 0x04002AB1 RID: 10929
		private Vector3 localEulerAngles_Start;

		// Token: 0x04002AB2 RID: 10930
		private Vector3 localScale_Start;

		// Token: 0x04002AB3 RID: 10931
		private Coroutine lerpRoutine;
	}
}
