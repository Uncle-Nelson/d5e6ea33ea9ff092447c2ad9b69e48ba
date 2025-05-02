using System;
using System.Collections.Generic;
using System.IO;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007CF RID: 1999
	public class Shitbox : LandVehicle
	{
		// Token: 0x060036B2 RID: 14002 RVA: 0x000E63A8 File Offset: 0x000E45A8
		public override List<string> WriteData(string parentFolderPath)
		{
			List<string> list = new List<string>();
			if (this.LoanSharkVisuals != null && this.LoanSharkVisuals.BulletHoleDecals.activeSelf)
			{
				Shitbox.LoanSharkVisualsData loanSharkVisualsData = new Shitbox.LoanSharkVisualsData
				{
					Enabled = this.LoanSharkVisuals.BulletHoleDecals.activeSelf,
					NoteVisible = this.LoanSharkVisuals.Note.activeSelf
				};
				((ISaveable)this).WriteSubfile(parentFolderPath, "LoanSharkCarData", loanSharkVisualsData.GetJson(true));
				list.Add("LoanSharkCarData.json");
			}
			list.AddRange(base.WriteData(parentFolderPath));
			return list;
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x000E643C File Offset: 0x000E463C
		public override void Load(VehicleData data, string containerPath)
		{
			base.Load(data, containerPath);
			string text;
			if (this.LoanSharkVisuals != null && File.Exists(Path.Combine(containerPath, "LoanSharkCarData.json")) && base.Loader.TryLoadFile(containerPath, "LoanSharkCarData", out text))
			{
				Shitbox.LoanSharkVisualsData loanSharkVisualsData = null;
				try
				{
					loanSharkVisualsData = JsonUtility.FromJson<Shitbox.LoanSharkVisualsData>(text);
				}
				catch (Exception ex)
				{
					Console.LogWarning("Failed to deserialize LoanSharkVisualsData: " + ex.Message, null);
					return;
				}
				this.LoanSharkVisuals.Configure(loanSharkVisualsData.Enabled, loanSharkVisualsData.NoteVisible);
			}
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x000E64DC File Offset: 0x000E46DC
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Vehicles.ShitboxAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Vehicles.ShitboxAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x000E64F5 File Offset: 0x000E46F5
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Vehicles.ShitboxAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Vehicles.ShitboxAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x000E650E File Offset: 0x000E470E
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x000E651C File Offset: 0x000E471C
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04002733 RID: 10035
		public LoanSharkCarVisuals LoanSharkVisuals;

		// Token: 0x04002734 RID: 10036
		private bool dll_Excuted;

		// Token: 0x04002735 RID: 10037
		private bool dll_Excuted;

		// Token: 0x020007D0 RID: 2000
		[Serializable]
		public class LoanSharkVisualsData : SaveData
		{
			// Token: 0x04002736 RID: 10038
			public bool Enabled;

			// Token: 0x04002737 RID: 10039
			public bool NoteVisible;
		}
	}
}
