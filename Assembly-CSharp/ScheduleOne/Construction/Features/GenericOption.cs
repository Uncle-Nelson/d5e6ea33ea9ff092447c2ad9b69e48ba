using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Construction.Features
{
	// Token: 0x02000729 RID: 1833
	public class GenericOption : MonoBehaviour
	{
		// Token: 0x060031A0 RID: 12704 RVA: 0x000CDA52 File Offset: 0x000CBC52
		public virtual void Install()
		{
			if (this.onInstalled != null)
			{
				this.onInstalled.Invoke();
			}
			this.SetVisible();
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x000CDA6D File Offset: 0x000CBC6D
		public virtual void Uninstall()
		{
			if (this.onUninstalled != null)
			{
				this.onUninstalled.Invoke();
			}
			this.SetInvisible();
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x000CDA88 File Offset: 0x000CBC88
		public virtual void SetVisible()
		{
			if (this.onSetVisible != null)
			{
				this.onSetVisible.Invoke();
			}
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x000CDA9D File Offset: 0x000CBC9D
		public virtual void SetInvisible()
		{
			if (this.onSetInvisible != null)
			{
				this.onSetInvisible.Invoke();
			}
		}

		// Token: 0x04002356 RID: 9046
		[Header("Interface settings")]
		public string optionName;

		// Token: 0x04002357 RID: 9047
		public Color optionButtonColor;

		// Token: 0x04002358 RID: 9048
		public float optionPrice;

		// Token: 0x04002359 RID: 9049
		[Header("Events")]
		public UnityEvent onInstalled;

		// Token: 0x0400235A RID: 9050
		public UnityEvent onUninstalled;

		// Token: 0x0400235B RID: 9051
		public UnityEvent onSetVisible;

		// Token: 0x0400235C RID: 9052
		public UnityEvent onSetInvisible;
	}
}
