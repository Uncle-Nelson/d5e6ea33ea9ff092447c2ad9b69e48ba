using System;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Vision
{
	// Token: 0x0200027C RID: 636
	[Serializable]
	public class VisibilityAttribute
	{
		// Token: 0x06000D3C RID: 3388 RVA: 0x0003AD58 File Offset: 0x00038F58
		public VisibilityAttribute(string _name, float _pointsChange, float _multiplier = 1f, int attributeIndex = -1)
		{
			this.name = _name;
			this.pointsChange = _pointsChange;
			this.multiplier = _multiplier;
			if (attributeIndex == -1)
			{
				Player.Local.Visibility.activeAttributes.Add(this);
				return;
			}
			Player.Local.Visibility.activeAttributes.Insert(attributeIndex, this);
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x0003ADC8 File Offset: 0x00038FC8
		public void Delete()
		{
			Player.Local.Visibility.activeAttributes.Remove(this);
		}

		// Token: 0x04000DDA RID: 3546
		public string name = "Attribute Name";

		// Token: 0x04000DDB RID: 3547
		public float pointsChange;

		// Token: 0x04000DDC RID: 3548
		[Range(0f, 5f)]
		public float multiplier = 1f;
	}
}
