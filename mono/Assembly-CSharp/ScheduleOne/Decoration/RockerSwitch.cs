using System;
using UnityEngine;

namespace ScheduleOne.Decoration
{
	// Token: 0x02000C06 RID: 3078
	public class RockerSwitch : MonoBehaviour
	{
		// Token: 0x06005693 RID: 22163 RVA: 0x0016C156 File Offset: 0x0016A356
		private void Awake()
		{
			this.SetIsOn(this.isOn);
		}

		// Token: 0x06005694 RID: 22164 RVA: 0x0016C164 File Offset: 0x0016A364
		public void SetIsOn(bool on)
		{
			this.isOn = on;
			this.Light.enabled = on;
			this.ButtonTransform.localEulerAngles = new Vector3(on ? 10f : -10f, 0f, 0f);
		}

		// Token: 0x04003FF2 RID: 16370
		public MeshRenderer ButtonMesh;

		// Token: 0x04003FF3 RID: 16371
		public Transform ButtonTransform;

		// Token: 0x04003FF4 RID: 16372
		public Light Light;

		// Token: 0x04003FF5 RID: 16373
		public bool isOn;
	}
}
