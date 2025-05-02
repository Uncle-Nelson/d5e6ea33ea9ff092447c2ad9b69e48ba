using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000911 RID: 2321
	public class MixChute : MonoBehaviour
	{
		// Token: 0x06003EDD RID: 16093 RVA: 0x001095B4 File Offset: 0x001077B4
		private void Update()
		{
			this.UpdateDoor();
			this.IntObj.gameObject.SetActive(!NetworkSingleton<ProductManager>.Instance.IsMixComplete);
		}

		// Token: 0x06003EDE RID: 16094 RVA: 0x001095DC File Offset: 0x001077DC
		private void UpdateDoor()
		{
			bool flag = false;
			if (NetworkSingleton<ProductManager>.Instance.IsMixComplete && NetworkSingleton<ProductManager>.Instance.CurrentMixOperation != null)
			{
				flag = true;
			}
			else if (Singleton<CreateMixInterface>.Instance.IsOpen)
			{
				flag = true;
			}
			if (flag != this.isDoorOpen)
			{
				this.SetDoorOpen(flag);
			}
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x00109628 File Offset: 0x00107828
		public void Hovered()
		{
			if (!NetworkSingleton<ProductManager>.Instance.IsMixComplete)
			{
				if (NetworkSingleton<ProductManager>.Instance.IsMixingInProgress)
				{
					this.IntObj.SetMessage("Mix will be ready tomorrow");
					this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Label);
					return;
				}
				this.IntObj.SetMessage("Create new mix");
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
			}
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x00109686 File Offset: 0x00107886
		public void Interacted()
		{
			if (!NetworkSingleton<ProductManager>.Instance.IsMixComplete && !NetworkSingleton<ProductManager>.Instance.IsMixingInProgress)
			{
				Singleton<CreateMixInterface>.Instance.Open();
			}
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x001096AA File Offset: 0x001078AA
		public void SetDoorOpen(bool isOpen)
		{
			this.isDoorOpen = isOpen;
			this.DoorAnim.Play(this.isDoorOpen ? "Cabin flap open" : "Cabin flap close");
		}

		// Token: 0x04002D09 RID: 11529
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04002D0A RID: 11530
		public Animation DoorAnim;

		// Token: 0x04002D0B RID: 11531
		private bool isDoorOpen;
	}
}
