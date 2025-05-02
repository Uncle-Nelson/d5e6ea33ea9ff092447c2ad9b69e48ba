using System;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x02000960 RID: 2400
	[CreateAssetMenu(fileName = "Avatar Layer", menuName = "ScriptableObjects/Avatar Layer", order = 1)]
	[Serializable]
	public class AvatarLayer : ScriptableObject
	{
		// Token: 0x04002ED1 RID: 11985
		public string Name;

		// Token: 0x04002ED2 RID: 11986
		public string AssetPath;

		// Token: 0x04002ED3 RID: 11987
		public Texture2D Texture;

		// Token: 0x04002ED4 RID: 11988
		public Texture2D Normal;

		// Token: 0x04002ED5 RID: 11989
		public Texture2D Normal_DefaultFormat;

		// Token: 0x04002ED6 RID: 11990
		public int Order;

		// Token: 0x04002ED7 RID: 11991
		public Material CombinedMaterial;
	}
}
