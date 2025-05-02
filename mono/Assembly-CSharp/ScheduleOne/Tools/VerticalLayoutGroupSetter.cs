using System;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.Tools
{
	// Token: 0x0200087C RID: 2172
	public class VerticalLayoutGroupSetter : MonoBehaviour
	{
		// Token: 0x06003AF8 RID: 15096 RVA: 0x000F842A File Offset: 0x000F662A
		private void Awake()
		{
			this.layoutGroup = base.GetComponent<VerticalLayoutGroup>();
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x000F8438 File Offset: 0x000F6638
		public void Update()
		{
			if (this.layoutGroup.padding.left != (int)this.LeftSpacing)
			{
				this.layoutGroup.padding.left = (int)this.LeftSpacing;
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.layoutGroup.GetComponent<RectTransform>());
			}
		}

		// Token: 0x04002A78 RID: 10872
		public float LeftSpacing;

		// Token: 0x04002A79 RID: 10873
		private VerticalLayoutGroup layoutGroup;
	}
}
