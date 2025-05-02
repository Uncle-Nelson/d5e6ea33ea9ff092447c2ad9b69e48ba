using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000111 RID: 273
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Light), typeof(VolumetricLightBeamHD))]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-trackrealtimechanges-hd/")]
	public class TrackRealtimeChangesOnLightHD : MonoBehaviour
	{
		// Token: 0x06000438 RID: 1080 RVA: 0x00017005 File Offset: 0x00015205
		private void Awake()
		{
			this.m_Master = base.GetComponent<VolumetricLightBeamHD>();
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00017013 File Offset: 0x00015213
		private void Update()
		{
			if (this.m_Master.enabled)
			{
				this.m_Master.AssignPropertiesFromAttachedSpotLight();
			}
		}

		// Token: 0x040005F3 RID: 1523
		public const string ClassName = "TrackRealtimeChangesOnLightHD";

		// Token: 0x040005F4 RID: 1524
		private VolumetricLightBeamHD m_Master;
	}
}
