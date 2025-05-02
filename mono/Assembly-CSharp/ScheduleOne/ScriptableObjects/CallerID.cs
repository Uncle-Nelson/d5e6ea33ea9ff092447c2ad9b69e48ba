using System;
using UnityEngine;

namespace ScheduleOne.ScriptableObjects
{
	// Token: 0x0200077C RID: 1916
	[CreateAssetMenu(fileName = "CallerID", menuName = "ScriptableObjects/CallerID", order = 1)]
	[Serializable]
	public class CallerID : ScriptableObject
	{
		// Token: 0x04002575 RID: 9589
		public string Name;

		// Token: 0x04002576 RID: 9590
		public Sprite ProfilePicture;
	}
}
