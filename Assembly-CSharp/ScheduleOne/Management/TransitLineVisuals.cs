using System;
using UnityEngine;

namespace ScheduleOne.Management
{
	// Token: 0x02000590 RID: 1424
	public class TransitLineVisuals : MonoBehaviour
	{
		// Token: 0x0600236D RID: 9069 RVA: 0x00090ABB File Offset: 0x0008ECBB
		public void SetSourcePosition(Vector3 position)
		{
			this.Renderer.SetPosition(0, position);
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x00090ACA File Offset: 0x0008ECCA
		public void SetDestinationPosition(Vector3 position)
		{
			this.Renderer.SetPosition(1, position);
		}

		// Token: 0x04001A80 RID: 6784
		public LineRenderer Renderer;
	}
}
