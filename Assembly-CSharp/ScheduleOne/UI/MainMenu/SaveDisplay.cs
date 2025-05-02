using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using ScheduleOne.Persistence;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000B23 RID: 2851
	public class SaveDisplay : MonoBehaviour
	{
		// Token: 0x06004BF7 RID: 19447 RVA: 0x0013F062 File Offset: 0x0013D262
		public void Awake()
		{
			Singleton<LoadManager>.Instance.onSaveInfoLoaded.AddListener(new UnityAction(this.Refresh));
			this.Refresh();
		}

		// Token: 0x06004BF8 RID: 19448 RVA: 0x0013F088 File Offset: 0x0013D288
		public void Refresh()
		{
			for (int i = 0; i < LoadManager.SaveGames.Length; i++)
			{
				this.SetDisplayedSave(i, LoadManager.SaveGames[i]);
			}
		}

		// Token: 0x06004BF9 RID: 19449 RVA: 0x0013F0B8 File Offset: 0x0013D2B8
		public void SetDisplayedSave(int index, SaveInfo info)
		{
			Transform transform = this.Slots[index].Find("Container");
			if (info == null)
			{
				transform.gameObject.SetActive(false);
				return;
			}
			transform.Find("Organisation").GetComponent<TextMeshProUGUI>().text = info.OrganisationName;
			transform.Find("Version").GetComponent<TextMeshProUGUI>().text = "v" + info.SaveVersion;
			float num = info.Networth;
			string text = string.Empty;
			Color color = new Color32(75, byte.MaxValue, 10, byte.MaxValue);
			if (num > 1000000f)
			{
				num /= 1000000f;
				text = "$" + this.RoundToDecimalPlaces(num, 1).ToString() + "M";
				color = new Color32(byte.MaxValue, 225, 10, byte.MaxValue);
			}
			else if (num > 1000f)
			{
				num /= 1000f;
				text = "$" + this.RoundToDecimalPlaces(num, 1).ToString() + "K";
			}
			else
			{
				text = MoneyManager.FormatAmount(num, false, false);
			}
			transform.Find("NetWorth/Text").GetComponent<TextMeshProUGUI>().text = text;
			transform.Find("NetWorth/Text").GetComponent<TextMeshProUGUI>().color = color;
			int hours = Mathf.RoundToInt((float)(DateTime.Now - info.DateCreated).TotalHours);
			transform.Find("Created/Text").GetComponent<TextMeshProUGUI>().text = this.GetTimeLabel(hours);
			int hours2 = Mathf.RoundToInt((float)(DateTime.Now - info.DateLastPlayed).TotalHours);
			transform.Find("LastPlayed/Text").GetComponent<TextMeshProUGUI>().text = this.GetTimeLabel(hours2);
			transform.gameObject.SetActive(true);
		}

		// Token: 0x06004BFA RID: 19450 RVA: 0x0013F28D File Offset: 0x0013D48D
		private float RoundToDecimalPlaces(float value, int decimalPlaces)
		{
			return SaveDisplay.ToSingle(Math.Floor((double)value * Math.Pow(10.0, (double)decimalPlaces)) / Math.Pow(10.0, (double)decimalPlaces));
		}

		// Token: 0x06004BFB RID: 19451 RVA: 0x0013F2BD File Offset: 0x0013D4BD
		public static float ToSingle(double value)
		{
			return (float)value;
		}

		// Token: 0x06004BFC RID: 19452 RVA: 0x0013F2C4 File Offset: 0x0013D4C4
		private string GetTimeLabel(int hours)
		{
			int num = hours / 24;
			if (num == 0)
			{
				return "Today";
			}
			if (num == 1)
			{
				return "Yesterday";
			}
			if (num > 365)
			{
				return "More than a year ago";
			}
			return num.ToString() + " days ago";
		}

		// Token: 0x040038F9 RID: 14585
		[Header("References")]
		public RectTransform[] Slots;
	}
}
