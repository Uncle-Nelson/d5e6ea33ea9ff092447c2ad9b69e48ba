using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Impostors
{
	// Token: 0x02000975 RID: 2421
	public class ImpostorGenerator : MonoBehaviour
	{
		// Token: 0x04002F5E RID: 12126
		[Header("References")]
		public Camera ImpostorCamera;

		// Token: 0x04002F5F RID: 12127
		public Avatar Avatar;

		// Token: 0x04002F60 RID: 12128
		[Header("Settings")]
		public List<AvatarSettings> GenerationQueue = new List<AvatarSettings>();

		// Token: 0x04002F61 RID: 12129
		[SerializeField]
		private Texture2D output;
	}
}
