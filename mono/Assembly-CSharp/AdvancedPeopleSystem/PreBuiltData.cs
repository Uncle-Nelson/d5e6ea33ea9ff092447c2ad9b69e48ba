using System;
using System.Collections.Generic;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	// Token: 0x02000213 RID: 531
	[Serializable]
	public class PreBuiltData
	{
		// Token: 0x04000C82 RID: 3202
		[SerializeField]
		public string GroupName;

		// Token: 0x04000C83 RID: 3203
		[SerializeField]
		public List<Mesh> meshes = new List<Mesh>();

		// Token: 0x04000C84 RID: 3204
		[SerializeField]
		public List<Material> materials = new List<Material>();
	}
}
