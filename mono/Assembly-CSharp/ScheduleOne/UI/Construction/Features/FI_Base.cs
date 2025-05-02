using System;
using ScheduleOne.Construction.Features;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI.Construction.Features
{
	// Token: 0x02000B86 RID: 2950
	public class FI_Base : MonoBehaviour
	{
		// Token: 0x06004E81 RID: 20097 RVA: 0x0014B759 File Offset: 0x00149959
		public virtual void Initialize(Feature _feature)
		{
			this.feature = _feature;
		}

		// Token: 0x06004E82 RID: 20098 RVA: 0x0014B762 File Offset: 0x00149962
		public virtual void Close()
		{
			if (this.onClose != null)
			{
				this.onClose.Invoke();
			}
			Object.Destroy(base.gameObject);
		}

		// Token: 0x04003B49 RID: 15177
		protected Feature feature;

		// Token: 0x04003B4A RID: 15178
		public UnityEvent onClose;
	}
}
