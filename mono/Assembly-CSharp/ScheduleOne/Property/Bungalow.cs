using System;
using System.Linq;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Growing;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Variables;
using UnityEngine;

namespace ScheduleOne.Property
{
	// Token: 0x0200080B RID: 2059
	public class Bungalow : Property
	{
		// Token: 0x060037D8 RID: 14296 RVA: 0x000ED049 File Offset: 0x000EB249
		protected override void Start()
		{
			base.Start();
			base.InvokeRepeating("UpdateVariables", 0f, 0.5f);
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x000ED068 File Offset: 0x000EB268
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
			int num5 = (from x in this.BuildableItems
			where x is PackagingStation
			select x).Count<BuildableItem>();
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
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Bungalow_Pots", array.Length.ToString(), true);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Bungalow_Soil_Pots", num.ToString(), true);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Bungalow_Watered_Pots", num2.ToString(), true);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Bungalow_Seed_Pots", num3.ToString(), true);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Bungalow_PackagingStations", num5.ToString(), true);
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x000ED217 File Offset: 0x000EB417
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Property.BungalowAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Property.BungalowAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x000ED230 File Offset: 0x000EB430
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Property.BungalowAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Property.BungalowAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060037DD RID: 14301 RVA: 0x000ED249 File Offset: 0x000EB449
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060037DE RID: 14302 RVA: 0x000ED257 File Offset: 0x000EB457
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040028BD RID: 10429
		public Transform ModelContainer;

		// Token: 0x040028BE RID: 10430
		private bool dll_Excuted;

		// Token: 0x040028BF RID: 10431
		private bool dll_Excuted;
	}
}
