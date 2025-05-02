using System;
using System.Linq;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Growing;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Variables;

namespace ScheduleOne.Property
{
	// Token: 0x02000820 RID: 2080
	public class Sweatshop : Property
	{
		// Token: 0x060038B1 RID: 14513 RVA: 0x000ED049 File Offset: 0x000EB249
		protected override void Start()
		{
			base.Start();
			base.InvokeRepeating("UpdateVariables", 0f, 0.5f);
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x000EFB70 File Offset: 0x000EDD70
		private void UpdateVariables()
		{
			if (!NetworkSingleton<VariableDatabase>.InstanceExists)
			{
				return;
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			Pot[] array = (from x in this.BuildableItems
			where x is Pot
			select x as Pot).ToArray<Pot>();
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = this.Container.GetComponentsInChildren<PackagingStation>().Length;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].IsFilledWithSoil)
				{
					num++;
				}
				if (array[i].NormalizedWaterLevel > 0.2f)
				{
					num2++;
				}
				if (array[i].Plant != null)
				{
					num3++;
				}
				if (array[i].AppliedAdditives.Find((Additive x) => x.AdditiveName == "Speed Grow"))
				{
					num4++;
				}
			}
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Sweatshop_Pots", array.Length.ToString(), true);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Sweatshop_PackagingStations", num5.ToString(), true);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Sweatshop_MixingStations", this.Container.GetComponentsInChildren<MixingStation>().Length.ToString(), true);
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x000EFCD6 File Offset: 0x000EDED6
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Property.SweatshopAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Property.SweatshopAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x000EFCEF File Offset: 0x000EDEEF
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Property.SweatshopAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Property.SweatshopAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x000EFD08 File Offset: 0x000EDF08
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x000EFD16 File Offset: 0x000EDF16
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04002926 RID: 10534
		private bool dll_Excuted;

		// Token: 0x04002927 RID: 10535
		private bool dll_Excuted;
	}
}
