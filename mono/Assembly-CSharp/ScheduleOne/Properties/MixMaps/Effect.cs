using System;
using UnityEngine;

namespace ScheduleOne.Properties.MixMaps
{
	// Token: 0x0200032C RID: 812
	public class Effect : MonoBehaviour
	{
		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x0004DD2F File Offset: 0x0004BF2F
		public Vector2 Position
		{
			get
			{
				return new Vector2(base.transform.position.x, base.transform.position.z);
			}
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0004DD56 File Offset: 0x0004BF56
		public void OnValidate()
		{
			if (this.Property == null)
			{
				return;
			}
			base.gameObject.name = this.Property.Name;
		}

		// Token: 0x04001167 RID: 4455
		public Property Property;

		// Token: 0x04001168 RID: 4456
		[Range(0.05f, 3f)]
		public float Radius = 0.5f;
	}
}
