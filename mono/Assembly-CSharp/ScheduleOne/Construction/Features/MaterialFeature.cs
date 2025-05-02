using System;
using System.Collections.Generic;
using ScheduleOne.UI.Construction.Features;
using UnityEngine;

namespace ScheduleOne.Construction.Features
{
	// Token: 0x0200072B RID: 1835
	public class MaterialFeature : OptionListFeature
	{
		// Token: 0x060031AE RID: 12718 RVA: 0x000CDC92 File Offset: 0x000CBE92
		public override void SelectOption(int optionIndex)
		{
			base.SelectOption(optionIndex);
			this.ApplyMaterial(this.materials[optionIndex]);
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x000CDCB0 File Offset: 0x000CBEB0
		private void ApplyMaterial(MaterialFeature.NamedMaterial mat)
		{
			for (int i = 0; i < this.materialTargets.Count; i++)
			{
				this.materialTargets[i].material = mat.mat;
			}
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x000CDCEC File Offset: 0x000CBEEC
		protected override List<FI_OptionList.Option> GetOptions()
		{
			List<FI_OptionList.Option> list = new List<FI_OptionList.Option>();
			for (int i = 0; i < this.materials.Count; i++)
			{
				list.Add(new FI_OptionList.Option(this.materials[i].matName, this.materials[i].buttonColor, this.materials[i].price));
			}
			return list;
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x000CDD72 File Offset: 0x000CBF72
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Construction.Features.MaterialFeatureAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Construction.Features.MaterialFeatureAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x000CDD8B File Offset: 0x000CBF8B
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Construction.Features.MaterialFeatureAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Construction.Features.MaterialFeatureAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x000CDDA4 File Offset: 0x000CBFA4
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060031B5 RID: 12725 RVA: 0x000CDDB2 File Offset: 0x000CBFB2
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04002362 RID: 9058
		[Header("References")]
		[SerializeField]
		protected List<MeshRenderer> materialTargets = new List<MeshRenderer>();

		// Token: 0x04002363 RID: 9059
		[Header("Material settings")]
		public List<MaterialFeature.NamedMaterial> materials = new List<MaterialFeature.NamedMaterial>();

		// Token: 0x04002364 RID: 9060
		private bool dll_Excuted;

		// Token: 0x04002365 RID: 9061
		private bool dll_Excuted;

		// Token: 0x0200072C RID: 1836
		[Serializable]
		public class NamedMaterial
		{
			// Token: 0x04002366 RID: 9062
			public string matName;

			// Token: 0x04002367 RID: 9063
			public Color buttonColor;

			// Token: 0x04002368 RID: 9064
			public Material mat;

			// Token: 0x04002369 RID: 9065
			public float price = 100f;
		}
	}
}
