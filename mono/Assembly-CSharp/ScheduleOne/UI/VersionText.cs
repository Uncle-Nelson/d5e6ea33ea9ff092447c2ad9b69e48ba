using System;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A5B RID: 2651
	public class VersionText : MonoBehaviour
	{
		// Token: 0x06004764 RID: 18276 RVA: 0x0012ADAC File Offset: 0x00128FAC
		private void Awake()
		{
			base.GetComponent<TextMeshProUGUI>().text = "v" + Application.version;
		}
	}
}
