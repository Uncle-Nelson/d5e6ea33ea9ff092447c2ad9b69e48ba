using System;
using ScheduleOne.Construction;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Interaction;
using ScheduleOne.Property;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Market
{
	// Token: 0x0200055C RID: 1372
	public class BuilderMerchant : MonoBehaviour
	{
		// Token: 0x0600218A RID: 8586 RVA: 0x0008A214 File Offset: 0x00088414
		public void Hovered()
		{
			if (Singleton<ConstructionManager>.Instance.constructionModeEnabled || this.selector.isOpen)
			{
				this.intObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				return;
			}
			if (NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(this.openTime, this.closeTime))
			{
				this.intObj.SetMessage("View construction menu");
				this.intObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				return;
			}
			this.intObj.SetInteractableState(InteractableObject.EInteractableState.Invalid);
			this.intObj.SetMessage("Closed");
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x0008A298 File Offset: 0x00088498
		public void Interacted()
		{
			this.selector.OpenSelector(new PropertySelector.PropertySelected(this.PropertySelected));
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x0008A2B1 File Offset: 0x000884B1
		private void PropertySelected(Property p)
		{
			Singleton<ConstructionManager>.Instance.EnterConstructionMode(p);
		}

		// Token: 0x040019C0 RID: 6592
		[Header("Settings")]
		[SerializeField]
		protected int openTime = 600;

		// Token: 0x040019C1 RID: 6593
		[SerializeField]
		protected int closeTime = 1800;

		// Token: 0x040019C2 RID: 6594
		[Header("References")]
		[SerializeField]
		protected InteractableObject intObj;

		// Token: 0x040019C3 RID: 6595
		[SerializeField]
		private PropertySelector selector;
	}
}
