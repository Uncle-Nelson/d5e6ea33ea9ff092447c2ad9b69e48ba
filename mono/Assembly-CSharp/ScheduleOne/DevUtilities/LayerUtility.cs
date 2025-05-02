using System;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006E4 RID: 1764
	public static class LayerUtility
	{
		// Token: 0x06003004 RID: 12292 RVA: 0x000C7FB4 File Offset: 0x000C61B4
		public static void SetLayerRecursively(GameObject go, int layerNumber)
		{
			Transform[] componentsInChildren = go.GetComponentsInChildren<Transform>(true);
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].gameObject.layer = layerNumber;
			}
		}
	}
}
