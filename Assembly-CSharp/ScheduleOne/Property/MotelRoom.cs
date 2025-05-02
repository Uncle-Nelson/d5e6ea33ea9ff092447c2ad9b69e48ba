using System;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.Growing;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Variables;

namespace ScheduleOne.Property
{
	// Token: 0x02000812 RID: 2066
	public class MotelRoom : Property
	{
		// Token: 0x0600381C RID: 14364 RVA: 0x000ED049 File Offset: 0x000EB249
		protected override void Start()
		{
			base.Start();
			base.InvokeRepeating("UpdateVariables", 0f, 0.5f);
		}

		// Token: 0x0600381D RID: 14365 RVA: 0x000EDD98 File Offset: 0x000EBF98
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
			Pot[] componentsInChildren = this.Container.GetComponentsInChildren<Pot>();
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = this.Container.GetComponentsInChildren<PackagingStation>().Length;
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (componentsInChildren[i].IsFilledWithSoil)
				{
					num++;
				}
				if (componentsInChildren[i].NormalizedWaterLevel > 0.2f)
				{
					num2++;
				}
				if (componentsInChildren[i].Plant != null)
				{
					num3++;
				}
				if (componentsInChildren[i].AppliedAdditives.Find((Additive x) => x.AdditiveName == "Speed Grow"))
				{
					num4++;
				}
			}
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Motel_Pots", componentsInChildren.Length.ToString(), true);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Motel_Soil_Pots", num.ToString(), true);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Motel_Watered_Pots", num2.ToString(), true);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Motel_Seed_Pots", num3.ToString(), true);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Motel_PackagingStations", num5.ToString(), true);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Motel_MixingStations", this.Container.GetComponentsInChildren<MixingStation>().Length.ToString(), true);
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x000EDEFB File Offset: 0x000EC0FB
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Property.MotelRoomAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Property.MotelRoomAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x000EDF14 File Offset: 0x000EC114
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Property.MotelRoomAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Property.MotelRoomAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x000EDF2D File Offset: 0x000EC12D
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x000EDF3B File Offset: 0x000EC13B
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040028DA RID: 10458
		private bool dll_Excuted;

		// Token: 0x040028DB RID: 10459
		private bool dll_Excuted;
	}
}
