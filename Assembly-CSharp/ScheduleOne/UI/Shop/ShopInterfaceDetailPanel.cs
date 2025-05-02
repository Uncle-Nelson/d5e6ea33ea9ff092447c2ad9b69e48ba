using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000B67 RID: 2919
	public class ShopInterfaceDetailPanel : MonoBehaviour
	{
		// Token: 0x06004DCA RID: 19914 RVA: 0x00147CBA File Offset: 0x00145EBA
		private void Awake()
		{
			this.Panel.gameObject.SetActive(false);
		}

		// Token: 0x06004DCB RID: 19915 RVA: 0x00147CD0 File Offset: 0x00145ED0
		public void Open(ListingUI _listing)
		{
			this.listing = _listing;
			this.DescriptionLabel.text = this.listing.Listing.Item.Description;
			if (this.listing.Listing.Item.RequiresLevelToPurchase && !this.listing.Listing.Item.IsPurchasable)
			{
				this.UnlockLabel.text = "Unlocks at <color=#2DB92D>" + this.listing.Listing.Item.RequiredRank.ToString() + "</color>";
				this.UnlockLabel.gameObject.SetActive(true);
			}
			else
			{
				this.UnlockLabel.gameObject.SetActive(false);
			}
			Singleton<CoroutineService>.Instance.StartCoroutine(this.<Open>g__Wait|6_0());
		}

		// Token: 0x06004DCC RID: 19916 RVA: 0x00147DA1 File Offset: 0x00145FA1
		private void LateUpdate()
		{
			this.Position();
		}

		// Token: 0x06004DCD RID: 19917 RVA: 0x00147DAC File Offset: 0x00145FAC
		private void Position()
		{
			if (this.listing == null)
			{
				return;
			}
			this.Panel.position = this.listing.DetailPanelAnchor.position;
			this.Panel.anchoredPosition = new Vector2(this.Panel.anchoredPosition.x + this.Panel.sizeDelta.x / 2f, this.Panel.anchoredPosition.y);
		}

		// Token: 0x06004DCE RID: 19918 RVA: 0x00147E2A File Offset: 0x0014602A
		public void Close()
		{
			this.listing = null;
			this.Panel.gameObject.SetActive(false);
		}

		// Token: 0x06004DD0 RID: 19920 RVA: 0x00147E44 File Offset: 0x00146044
		[CompilerGenerated]
		private IEnumerator <Open>g__Wait|6_0()
		{
			this.LayoutGroup.enabled = false;
			yield return new WaitForEndOfFrame();
			this.Panel.gameObject.SetActive(true);
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.Panel);
			this.LayoutGroup.CalculateLayoutInputVertical();
			this.LayoutGroup.enabled = true;
			this.Position();
			yield break;
		}

		// Token: 0x04003AA4 RID: 15012
		[Header("References")]
		public RectTransform Panel;

		// Token: 0x04003AA5 RID: 15013
		public VerticalLayoutGroup LayoutGroup;

		// Token: 0x04003AA6 RID: 15014
		public TextMeshProUGUI DescriptionLabel;

		// Token: 0x04003AA7 RID: 15015
		public TextMeshProUGUI UnlockLabel;

		// Token: 0x04003AA8 RID: 15016
		private ListingUI listing;
	}
}
