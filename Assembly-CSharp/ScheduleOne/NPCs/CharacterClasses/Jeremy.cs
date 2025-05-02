using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.Map;
using ScheduleOne.Persistence;
using ScheduleOne.Variables;
using ScheduleOne.Vehicles;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004B8 RID: 1208
	public class Jeremy : NPC
	{
		// Token: 0x06001ABF RID: 6847 RVA: 0x00071863 File Offset: 0x0006FA63
		protected override void Start()
		{
			base.Start();
			Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(this.Loaded));
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x00071886 File Offset: 0x0006FA86
		private void Loaded()
		{
			Singleton<LoadManager>.Instance.onLoadComplete.RemoveListener(new UnityAction(this.Loaded));
			if (!NetworkSingleton<VariableDatabase>.Instance.GetValue<bool>(this.GreetedVariable))
			{
				this.EnableGreeting();
			}
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x000718BB File Offset: 0x0006FABB
		private void EnableGreeting()
		{
			this.dialogueHandler.GetComponent<DialogueController>().OverrideContainer = this.GreetingDialogue;
			this.dialogueHandler.onConversationStart.AddListener(new UnityAction(this.SetGreeted));
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x000718F0 File Offset: 0x0006FAF0
		private void SetGreeted()
		{
			this.dialogueHandler.onConversationStart.RemoveListener(new UnityAction(this.SetGreeted));
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue(this.GreetedVariable, true.ToString(), true);
			this.dialogueHandler.GetComponent<DialogueController>().OverrideContainer = null;
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x00071962 File Offset: 0x0006FB62
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JeremyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JeremyAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x0007197B File Offset: 0x0006FB7B
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JeremyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JeremyAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x00071994 File Offset: 0x0006FB94
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x000719A2 File Offset: 0x0006FBA2
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016AD RID: 5805
		public Dealership Dealership;

		// Token: 0x040016AE RID: 5806
		public List<Jeremy.DealershipListing> Listings = new List<Jeremy.DealershipListing>();

		// Token: 0x040016AF RID: 5807
		public DialogueContainer GreetingDialogue;

		// Token: 0x040016B0 RID: 5808
		public string GreetedVariable = "JeremyGreeted";

		// Token: 0x040016B1 RID: 5809
		private bool dll_Excuted;

		// Token: 0x040016B2 RID: 5810
		private bool dll_Excuted;

		// Token: 0x020004B9 RID: 1209
		[Serializable]
		public class DealershipListing
		{
			// Token: 0x17000467 RID: 1127
			// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x000719B6 File Offset: 0x0006FBB6
			public string vehicleName
			{
				get
				{
					return NetworkSingleton<VehicleManager>.Instance.GetVehiclePrefab(this.vehicleCode).VehicleName;
				}
			}

			// Token: 0x17000468 RID: 1128
			// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x000719CD File Offset: 0x0006FBCD
			public float price
			{
				get
				{
					return NetworkSingleton<VehicleManager>.Instance.GetVehiclePrefab(this.vehicleCode).VehiclePrice;
				}
			}

			// Token: 0x040016B3 RID: 5811
			public string vehicleCode = string.Empty;
		}
	}
}
