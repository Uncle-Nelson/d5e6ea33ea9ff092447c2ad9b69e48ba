using System;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	// Token: 0x02000212 RID: 530
	[Serializable]
	public class PreBuiltBlendshape
	{
		// Token: 0x06000B7A RID: 2938 RVA: 0x00035762 File Offset: 0x00033962
		public PreBuiltBlendshape(string name, float weight)
		{
			this.name = name;
			this.weight = weight;
		}

		// Token: 0x04000C80 RID: 3200
		[SerializeField]
		public string name;

		// Token: 0x04000C81 RID: 3201
		[SerializeField]
		public float weight;
	}
}
