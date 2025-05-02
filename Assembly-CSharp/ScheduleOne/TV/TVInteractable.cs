using System;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	// Token: 0x020002A6 RID: 678
	public class TVInteractable : MonoBehaviour
	{
		// Token: 0x06000E2C RID: 3628 RVA: 0x0003F558 File Offset: 0x0003D758
		private void Start()
		{
			this.IntObj.onHovered.AddListener(new UnityAction(this.Hovered));
			this.IntObj.onInteractStart.AddListener(new UnityAction(this.Interacted));
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x0003F592 File Offset: 0x0003D792
		private void Hovered()
		{
			if (this.Interface.CanOpen())
			{
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				this.IntObj.SetMessage("Use TV");
				return;
			}
			this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0003F5CA File Offset: 0x0003D7CA
		private void Interacted()
		{
			if (this.Interface.CanOpen())
			{
				this.Interface.Open();
			}
		}

		// Token: 0x04000EE2 RID: 3810
		public InteractableObject IntObj;

		// Token: 0x04000EE3 RID: 3811
		public TVInterface Interface;
	}
}
