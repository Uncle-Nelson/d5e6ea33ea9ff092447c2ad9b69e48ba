using System;
using UnityEngine;

namespace ScheduleOne.Management
{
	// Token: 0x02000592 RID: 1426
	public class TransitRouteMaterial : MonoBehaviour
	{
		// Token: 0x0600237C RID: 9084 RVA: 0x00090D3B File Offset: 0x0008EF3B
		private void Awake()
		{
			Material material = base.GetComponent<MeshRenderer>().material;
			material.SetInt("unity_GUIZTestMode", 8);
			material.renderQueue = 3000;
		}
	}
}
