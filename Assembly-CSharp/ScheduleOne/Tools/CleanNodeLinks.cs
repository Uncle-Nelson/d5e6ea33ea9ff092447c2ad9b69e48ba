using System;
using EasyButtons;
using Pathfinding;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000848 RID: 2120
	public class CleanNodeLinks : MonoBehaviour
	{
		// Token: 0x06003A38 RID: 14904 RVA: 0x000F6474 File Offset: 0x000F4674
		[Button]
		public void Clean()
		{
			foreach (NodeLink nodeLink in base.GetComponentsInChildren<NodeLink>())
			{
				if (nodeLink.End == null)
				{
					Console.Log("Destroying link: " + nodeLink.name, null);
					Object.DestroyImmediate(nodeLink);
				}
			}
		}
	}
}
