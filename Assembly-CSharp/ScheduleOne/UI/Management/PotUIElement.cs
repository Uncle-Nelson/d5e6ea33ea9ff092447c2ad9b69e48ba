using System;
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000B11 RID: 2833
	public class PotUIElement : WorldspaceUIElement
	{
		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06004BAA RID: 19370 RVA: 0x0013E0EB File Offset: 0x0013C2EB
		// (set) Token: 0x06004BAB RID: 19371 RVA: 0x0013E0F3 File Offset: 0x0013C2F3
		public Pot AssignedPot { get; protected set; }

		// Token: 0x06004BAC RID: 19372 RVA: 0x0013E0FC File Offset: 0x0013C2FC
		public void Initialize(Pot pot)
		{
			this.AssignedPot = pot;
			this.AssignedPot.Configuration.onChanged.AddListener(new UnityAction(this.RefreshUI));
			this.RefreshUI();
			base.gameObject.SetActive(false);
		}

		// Token: 0x06004BAD RID: 19373 RVA: 0x0013E13C File Offset: 0x0013C33C
		protected virtual void RefreshUI()
		{
			PotConfiguration potConfiguration = this.AssignedPot.Configuration as PotConfiguration;
			this.NoSeed.gameObject.SetActive(potConfiguration.Seed.SelectedItem == null);
			this.SeedIcon.gameObject.SetActive(potConfiguration.Seed.SelectedItem != null);
			if (potConfiguration.Seed.SelectedItem != null)
			{
				this.SeedIcon.sprite = potConfiguration.Seed.SelectedItem.Icon;
			}
			if (potConfiguration.Additive1.SelectedItem != null)
			{
				this.Additive1Icon.sprite = potConfiguration.Additive1.SelectedItem.Icon;
				this.Additive1Icon.gameObject.SetActive(true);
			}
			else
			{
				this.Additive1Icon.gameObject.SetActive(false);
			}
			if (potConfiguration.Additive2.SelectedItem != null)
			{
				this.Additive2Icon.sprite = potConfiguration.Additive2.SelectedItem.Icon;
				this.Additive2Icon.gameObject.SetActive(true);
			}
			else
			{
				this.Additive2Icon.gameObject.SetActive(false);
			}
			if (potConfiguration.Additive3.SelectedItem != null)
			{
				this.Additive3Icon.sprite = potConfiguration.Additive3.SelectedItem.Icon;
				this.Additive3Icon.gameObject.SetActive(true);
			}
			else
			{
				this.Additive3Icon.gameObject.SetActive(false);
			}
			base.SetAssignedNPC(potConfiguration.AssignedBotanist.SelectedNPC);
		}

		// Token: 0x040038B6 RID: 14518
		[Header("References")]
		public Image SeedIcon;

		// Token: 0x040038B7 RID: 14519
		public GameObject NoSeed;

		// Token: 0x040038B8 RID: 14520
		public Image Additive1Icon;

		// Token: 0x040038B9 RID: 14521
		public Image Additive2Icon;

		// Token: 0x040038BA RID: 14522
		public Image Additive3Icon;
	}
}
