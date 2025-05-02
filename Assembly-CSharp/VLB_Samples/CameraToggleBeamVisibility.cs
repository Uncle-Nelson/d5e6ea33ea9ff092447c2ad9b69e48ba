using System;
using UnityEngine;
using VLB;

namespace VLB_Samples
{
	// Token: 0x0200015C RID: 348
	[RequireComponent(typeof(Camera))]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		// Token: 0x060006BA RID: 1722 RVA: 0x0001E440 File Offset: 0x0001C640
		private void Update()
		{
			if (Input.GetKeyDown(this.m_KeyCode))
			{
				Camera component = base.GetComponent<Camera>();
				int geometryLayerID = Config.Instance.geometryLayerID;
				int num = 1 << geometryLayerID;
				if ((component.cullingMask & num) == num)
				{
					component.cullingMask &= ~num;
					return;
				}
				component.cullingMask |= num;
			}
		}

		// Token: 0x04000780 RID: 1920
		[SerializeField]
		private KeyCode m_KeyCode = KeyCode.Space;
	}
}
