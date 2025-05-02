using System;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006F9 RID: 1785
	public class SetTransform : MonoBehaviour
	{
		// Token: 0x06003082 RID: 12418 RVA: 0x000C9FBE File Offset: 0x000C81BE
		private void Awake()
		{
			if (this.SetOnAwake)
			{
				this.Set();
			}
		}

		// Token: 0x06003083 RID: 12419 RVA: 0x000C9FCE File Offset: 0x000C81CE
		private void Update()
		{
			if (this.SetOnUpdate)
			{
				this.Set();
			}
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x000C9FDE File Offset: 0x000C81DE
		private void LateUpdate()
		{
			if (this.SetOnLateUpdate)
			{
				this.Set();
			}
		}

		// Token: 0x06003085 RID: 12421 RVA: 0x000C9FF0 File Offset: 0x000C81F0
		private void Set()
		{
			if (base.gameObject.isStatic)
			{
				Console.LogWarning("SetTransform is being used on a static object.", null);
			}
			if (this.SetPosition)
			{
				base.transform.localPosition = this.LocalPosition;
			}
			if (this.SetRotation)
			{
				base.transform.localRotation = Quaternion.Euler(this.LocalRotation);
			}
			if (this.SetScale)
			{
				base.transform.localScale = this.LocalScale;
			}
		}

		// Token: 0x04002278 RID: 8824
		[Header("Frequency Settings")]
		public bool SetOnAwake = true;

		// Token: 0x04002279 RID: 8825
		public bool SetOnUpdate;

		// Token: 0x0400227A RID: 8826
		public bool SetOnLateUpdate;

		// Token: 0x0400227B RID: 8827
		[Header("Transform Settings")]
		public bool SetPosition;

		// Token: 0x0400227C RID: 8828
		public Vector3 LocalPosition = Vector3.zero;

		// Token: 0x0400227D RID: 8829
		public bool SetRotation;

		// Token: 0x0400227E RID: 8830
		public Vector3 LocalRotation = Vector3.zero;

		// Token: 0x0400227F RID: 8831
		public bool SetScale;

		// Token: 0x04002280 RID: 8832
		public Vector3 LocalScale = Vector3.one;
	}
}
