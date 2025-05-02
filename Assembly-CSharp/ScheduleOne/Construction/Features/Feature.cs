using System;
using FishNet.Object;
using ScheduleOne.UI.Construction.Features;
using UnityEngine;

namespace ScheduleOne.Construction.Features
{
	// Token: 0x02000728 RID: 1832
	public abstract class Feature : NetworkBehaviour
	{
		// Token: 0x06003197 RID: 12695 RVA: 0x000CD9DD File Offset: 0x000CBBDD
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Construction.Features.Feature_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x0006129E File Offset: 0x0005F49E
		public override void OnStartClient()
		{
			base.OnStartClient();
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x000CD9F1 File Offset: 0x000CBBF1
		public virtual FI_Base CreateInterface(Transform parent)
		{
			FI_Base component = Object.Instantiate<GameObject>(this.featureInterfacePrefab, parent).GetComponent<FI_Base>();
			component.Initialize(this);
			return component;
		}

		// Token: 0x0600319A RID: 12698
		public abstract void Default();

		// Token: 0x0600319C RID: 12700 RVA: 0x000CDA1E File Offset: 0x000CBC1E
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Construction.Features.FeatureAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Construction.Features.FeatureAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x000CDA31 File Offset: 0x000CBC31
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Construction.Features.FeatureAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Construction.Features.FeatureAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x000CDA44 File Offset: 0x000CBC44
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600319F RID: 12703 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void dll()
		{
		}

		// Token: 0x0400234F RID: 9039
		public string featureName = "Feature name";

		// Token: 0x04002350 RID: 9040
		public Sprite featureIcon;

		// Token: 0x04002351 RID: 9041
		public Transform featureIconLocation;

		// Token: 0x04002352 RID: 9042
		public GameObject featureInterfacePrefab;

		// Token: 0x04002353 RID: 9043
		public bool disableRoofDisibility;

		// Token: 0x04002354 RID: 9044
		private bool dll_Excuted;

		// Token: 0x04002355 RID: 9045
		private bool dll_Excuted;
	}
}
