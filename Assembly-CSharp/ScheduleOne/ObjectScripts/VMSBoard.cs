using System;
using TMPro;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000B94 RID: 2964
	public class VMSBoard : MonoBehaviour
	{
		// Token: 0x06004F17 RID: 20247 RVA: 0x0014D9A0 File Offset: 0x0014BBA0
		public void SetText(string text, Color col)
		{
			this.Label.text = text;
			this.Label.color = col;
		}

		// Token: 0x06004F18 RID: 20248 RVA: 0x0014D9BA File Offset: 0x0014BBBA
		public void SetText(string text)
		{
			this.SetText(text, new Color32(byte.MaxValue, 215, 50, byte.MaxValue));
		}

		// Token: 0x04003BAF RID: 15279
		[Header("References")]
		public TextMeshProUGUI Label;
	}
}
