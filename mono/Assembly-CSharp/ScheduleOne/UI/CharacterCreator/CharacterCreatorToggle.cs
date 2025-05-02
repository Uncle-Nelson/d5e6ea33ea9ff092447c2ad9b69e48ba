using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000B4B RID: 2891
	public class CharacterCreatorToggle : CharacterCreatorField<int>
	{
		// Token: 0x06004CD0 RID: 19664 RVA: 0x00143DB6 File Offset: 0x00141FB6
		protected override void Awake()
		{
			base.Awake();
			this.Button1.onClick.AddListener(new UnityAction(this.OnButton1));
			this.Button2.onClick.AddListener(new UnityAction(this.OnButton2));
		}

		// Token: 0x06004CD1 RID: 19665 RVA: 0x00143DF6 File Offset: 0x00141FF6
		public override void ApplyValue()
		{
			base.ApplyValue();
			this.Button1.interactable = (base.value != 0);
			this.Button2.interactable = (base.value == 0);
		}

		// Token: 0x06004CD2 RID: 19666 RVA: 0x00143E26 File Offset: 0x00142026
		public void OnButton1()
		{
			base.value = 0;
			this.WriteValue(true);
		}

		// Token: 0x06004CD3 RID: 19667 RVA: 0x00143E36 File Offset: 0x00142036
		public void OnButton2()
		{
			base.value = 1;
			this.WriteValue(true);
		}

		// Token: 0x040039E1 RID: 14817
		[Header("References")]
		public Button Button1;

		// Token: 0x040039E2 RID: 14818
		public Button Button2;
	}
}
