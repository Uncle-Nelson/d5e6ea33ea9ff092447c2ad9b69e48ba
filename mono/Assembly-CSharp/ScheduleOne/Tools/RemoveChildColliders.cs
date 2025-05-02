using System;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000870 RID: 2160
	public class RemoveChildColliders : MonoBehaviour
	{
		// Token: 0x06003AD4 RID: 15060 RVA: 0x000F7A40 File Offset: 0x000F5C40
		private void Start()
		{
			Collider[] componentsInChildren = base.GetComponentsInChildren<Collider>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				Object.Destroy(componentsInChildren[i]);
			}
		}
	}
}
