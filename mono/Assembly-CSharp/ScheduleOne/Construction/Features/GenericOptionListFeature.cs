using System;
using System.Collections.Generic;
using ScheduleOne.UI.Construction.Features;
using UnityEngine;

namespace ScheduleOne.Construction.Features
{
	// Token: 0x0200072A RID: 1834
	public class GenericOptionListFeature : OptionListFeature
	{
		// Token: 0x060031A5 RID: 12709 RVA: 0x000CDAB4 File Offset: 0x000CBCB4
		public override void Default()
		{
			for (int i = 0; i < this.options.Count; i++)
			{
				this.options[i].Uninstall();
			}
			this.PurchaseOption(this.defaultOptionIndex);
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x000CDAF4 File Offset: 0x000CBCF4
		protected override List<FI_OptionList.Option> GetOptions()
		{
			List<FI_OptionList.Option> list = new List<FI_OptionList.Option>();
			foreach (GenericOption genericOption in this.options)
			{
				list.Add(new FI_OptionList.Option(genericOption.optionName, genericOption.optionButtonColor, genericOption.optionPrice));
			}
			return list;
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x000CDB64 File Offset: 0x000CBD64
		public override void SelectOption(int optionIndex)
		{
			base.SelectOption(optionIndex);
			if (this.visibleOption != null && this.options[optionIndex] != this.visibleOption)
			{
				this.visibleOption.SetInvisible();
			}
			this.visibleOption = this.options[optionIndex];
			this.visibleOption.SetVisible();
		}

		// Token: 0x060031A8 RID: 12712 RVA: 0x000CDBC8 File Offset: 0x000CBDC8
		public override void PurchaseOption(int optionIndex)
		{
			base.PurchaseOption(optionIndex);
			if (this.installedOption != null && this.options[optionIndex] != this.installedOption)
			{
				this.installedOption.Uninstall();
			}
			this.installedOption = this.options[optionIndex];
			this.installedOption.Install();
		}

		// Token: 0x060031AA RID: 12714 RVA: 0x000CDC3E File Offset: 0x000CBE3E
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Construction.Features.GenericOptionListFeatureAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Construction.Features.GenericOptionListFeatureAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x060031AB RID: 12715 RVA: 0x000CDC57 File Offset: 0x000CBE57
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Construction.Features.GenericOptionListFeatureAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Construction.Features.GenericOptionListFeatureAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x000CDC70 File Offset: 0x000CBE70
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x000CDC7E File Offset: 0x000CBE7E
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400235D RID: 9053
		[Header("References")]
		[SerializeField]
		protected List<GenericOption> options = new List<GenericOption>();

		// Token: 0x0400235E RID: 9054
		private GenericOption visibleOption;

		// Token: 0x0400235F RID: 9055
		private GenericOption installedOption;

		// Token: 0x04002360 RID: 9056
		private bool dll_Excuted;

		// Token: 0x04002361 RID: 9057
		private bool dll_Excuted;
	}
}
