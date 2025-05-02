using System;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Property;
using ScheduleOne.Tiles;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BDF RID: 3039
	public class LaunderingStation : GridItem
	{
		// Token: 0x06005418 RID: 21528 RVA: 0x0016244F File Offset: 0x0016064F
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
			bool initialized = base.Initialized;
			base.InitializeGridItem(instance, grid, originCoordinate, rotation, GUID);
			if (!initialized)
			{
				this.Interface.Initialize(base.ParentProperty as Business);
			}
		}

		// Token: 0x06005419 RID: 21529 RVA: 0x0016247C File Offset: 0x0016067C
		private void Update()
		{
			if (this.Interface != null && this.Interface.business != null)
			{
				this.CashCounter.IsOn = (this.Interface.business.currentLaunderTotal > 0f);
			}
		}

		// Token: 0x0600541A RID: 21530 RVA: 0x001624CC File Offset: 0x001606CC
		public override bool CanBeDestroyed(out string reason)
		{
			reason = string.Empty;
			return false;
		}

		// Token: 0x0600541C RID: 21532 RVA: 0x001624D6 File Offset: 0x001606D6
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.LaunderingStationAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.LaunderingStationAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x0600541D RID: 21533 RVA: 0x001624EF File Offset: 0x001606EF
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.LaunderingStationAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.LaunderingStationAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x0600541E RID: 21534 RVA: 0x00162508 File Offset: 0x00160708
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600541F RID: 21535 RVA: 0x00162516 File Offset: 0x00160716
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04003EB3 RID: 16051
		[Header("References")]
		public LaunderingInterface Interface;

		// Token: 0x04003EB4 RID: 16052
		[SerializeField]
		protected CashCounter CashCounter;

		// Token: 0x04003EB5 RID: 16053
		private bool dll_Excuted;

		// Token: 0x04003EB6 RID: 16054
		private bool dll_Excuted;
	}
}
