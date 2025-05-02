using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x020009CA RID: 2506
	public class CharacterInterface : MonoBehaviour
	{
		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x0600438D RID: 17293 RVA: 0x0011B007 File Offset: 0x00119207
		// (set) Token: 0x0600438E RID: 17294 RVA: 0x0011B00F File Offset: 0x0011920F
		public bool IsOpen { get; private set; }

		// Token: 0x0600438F RID: 17295 RVA: 0x0011B018 File Offset: 0x00119218
		private void Awake()
		{
			this.Close();
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x0011B020 File Offset: 0x00119220
		private void LateUpdate()
		{
			if (this.IsOpen)
			{
				foreach (ClothingSlotUI clothingSlotUI in this.ClothingSlots)
				{
					Transform component = clothingSlotUI.GetComponent<RectTransform>();
					Transform transform = this.SlotAlignmentPoints[clothingSlotUI];
					component.position = RectTransformUtility.WorldToScreenPoint(Singleton<GameplayMenu>.Instance.OverlayCamera, transform.position);
				}
			}
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x0011B080 File Offset: 0x00119280
		public void Open()
		{
			if (this.SlotAlignmentPoints.Count == 0)
			{
				ClothingSlotUI[] clothingSlots = this.ClothingSlots;
				for (int i = 0; i < clothingSlots.Length; i++)
				{
					ClothingSlotUI slotUI = clothingSlots[i];
					slotUI.AssignSlot(Player.Local.Clothing.ClothingSlots[slotUI.SlotType]);
					CharacterDisplay.SlotAlignmentPoint slotAlignmentPoint = Singleton<CharacterDisplay>.Instance.AlignmentPoints.FirstOrDefault((CharacterDisplay.SlotAlignmentPoint x) => x.SlotType == slotUI.SlotType);
					if (slotAlignmentPoint != null)
					{
						this.SlotAlignmentPoints.Add(slotUI, slotAlignmentPoint.Point);
					}
					else
					{
						Console.LogError(string.Format("No alignment point found for slot type {0}", slotUI.SlotType), null);
					}
				}
			}
			this.IsOpen = true;
			this.Container.gameObject.SetActive(true);
			this.LateUpdate();
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x0011B167 File Offset: 0x00119367
		public void Close()
		{
			this.IsOpen = false;
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x0400312C RID: 12588
		public ClothingSlotUI[] ClothingSlots;

		// Token: 0x0400312D RID: 12589
		public RectTransform Container;

		// Token: 0x0400312E RID: 12590
		public Slider RotationSlider;

		// Token: 0x0400312F RID: 12591
		private Dictionary<ClothingSlotUI, Transform> SlotAlignmentPoints = new Dictionary<ClothingSlotUI, Transform>();
	}
}
