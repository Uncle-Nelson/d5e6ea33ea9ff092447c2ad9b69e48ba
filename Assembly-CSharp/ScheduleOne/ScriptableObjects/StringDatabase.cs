using System;
using UnityEngine;

namespace ScheduleOne.ScriptableObjects
{
	// Token: 0x0200077F RID: 1919
	[CreateAssetMenu(fileName = "StringDatabase", menuName = "ScriptableObjects/StringDatabase", order = 1)]
	[Serializable]
	public class StringDatabase : ScriptableObject
	{
		// Token: 0x0400257D RID: 9597
		[TextArea(2, 10)]
		public string[] Strings;
	}
}
