using System;

namespace ScheduleOne.Vision
{
	// Token: 0x0200027B RID: 635
	[Serializable]
	public class UniqueVisibilityAttribute : VisibilityAttribute
	{
		// Token: 0x06000D3B RID: 3387 RVA: 0x0003AD40 File Offset: 0x00038F40
		public UniqueVisibilityAttribute(string _name, float _pointsChange, string _uniquenessCode, float _multiplier = 1f, int attributeIndex = -1) : base(_name, _pointsChange, _multiplier, attributeIndex)
		{
			this.uniquenessCode = _uniquenessCode;
		}

		// Token: 0x04000DD9 RID: 3545
		public string uniquenessCode;
	}
}
