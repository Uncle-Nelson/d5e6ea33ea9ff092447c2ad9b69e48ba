using System;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000979 RID: 2425
	[RequireComponent(typeof(AvatarEquippable))]
	public class AvatarEquippableLookAt : MonoBehaviour
	{
		// Token: 0x060041EB RID: 16875 RVA: 0x00114987 File Offset: 0x00112B87
		private void Start()
		{
			this.avatar = base.GetComponentInParent<Avatar>();
			if (this.avatar == null)
			{
				Debug.LogError("AvatarEquippableLookAt must be a child of an Avatar object.");
				return;
			}
		}

		// Token: 0x060041EC RID: 16876 RVA: 0x001149AE File Offset: 0x00112BAE
		private void LateUpdate()
		{
			if (this.avatar == null)
			{
				return;
			}
			this.avatar.LookController.OverrideLookTarget(this.avatar.CurrentEquippable.transform.position, this.Priority, false);
		}

		// Token: 0x04002F6F RID: 12143
		public int Priority;

		// Token: 0x04002F70 RID: 12144
		private Avatar avatar;
	}
}
