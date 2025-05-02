using System;
using System.Collections.Generic;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.UI.Construction.Features;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Construction.Features
{
	// Token: 0x0200072D RID: 1837
	public abstract class OptionListFeature : Feature
	{
		// Token: 0x060031B7 RID: 12727 RVA: 0x000CDDD9 File Offset: 0x000CBFD9
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Construction.Features.OptionListFeature_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x000CDDF0 File Offset: 0x000CBFF0
		public override FI_Base CreateInterface(Transform parent)
		{
			FI_OptionList component = Object.Instantiate<GameObject>(this.featureInterfacePrefab, parent).GetComponent<FI_OptionList>();
			component.Initialize(this, this.GetOptions());
			component.onSelectionChanged.AddListener(new UnityAction<int>(this.SelectOption));
			component.onSelectionPurchased.AddListener(new UnityAction<int>(this.PurchaseOption));
			return component;
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x000CDE4B File Offset: 0x000CC04B
		public override void Default()
		{
			this.PurchaseOption(this.defaultOptionIndex);
		}

		// Token: 0x060031BA RID: 12730
		protected abstract List<FI_OptionList.Option> GetOptions();

		// Token: 0x060031BB RID: 12731 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void SelectOption(int optionIndex)
		{
		}

		// Token: 0x060031BC RID: 12732 RVA: 0x000CDE59 File Offset: 0x000CC059
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		protected virtual void SetData(int colorIndex)
		{
			this.RpcWriter___Server_SetData_3316948804(colorIndex);
			this.RpcLogic___SetData_3316948804(colorIndex);
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x000CDE6F File Offset: 0x000CC06F
		private void ReceiveData()
		{
			this.SelectOption(this.SyncAccessor_ownedOptionIndex);
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x000CDE7D File Offset: 0x000CC07D
		public virtual void PurchaseOption(int optionIndex)
		{
			this.SetData(optionIndex);
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x000CDE90 File Offset: 0x000CC090
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Construction.Features.OptionListFeatureAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Construction.Features.OptionListFeatureAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___ownedOptionIndex = new SyncVar<int>(this, 0U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.ownedOptionIndex);
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SetData_3316948804));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.Construction.Features.OptionListFeature));
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x000CDF08 File Offset: 0x000CC108
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Construction.Features.OptionListFeatureAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Construction.Features.OptionListFeatureAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___ownedOptionIndex.SetRegistered();
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x000CDF2C File Offset: 0x000CC12C
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x000CDF3C File Offset: 0x000CC13C
		private void RpcWriter___Server_SetData_3316948804(int colorIndex)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteInt32(colorIndex, AutoPackType.Packed);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x000CDFE8 File Offset: 0x000CC1E8
		protected virtual void RpcLogic___SetData_3316948804(int colorIndex)
		{
			if (!base.IsSpawned)
			{
				this.SelectOption(colorIndex);
				return;
			}
			this.sync___set_value_ownedOptionIndex(colorIndex, true);
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x000CE004 File Offset: 0x000CC204
		private void RpcReader___Server_SetData_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int colorIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetData_3316948804(colorIndex);
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060031C6 RID: 12742 RVA: 0x000CE047 File Offset: 0x000CC247
		// (set) Token: 0x060031C7 RID: 12743 RVA: 0x000CE04F File Offset: 0x000CC24F
		public int SyncAccessor_ownedOptionIndex
		{
			get
			{
				return this.ownedOptionIndex;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.ownedOptionIndex = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___ownedOptionIndex.SetValue(value, value);
				}
			}
		}

		// Token: 0x060031C8 RID: 12744 RVA: 0x000CE08C File Offset: 0x000CC28C
		public virtual bool OptionListFeature(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 != 0U)
			{
				return false;
			}
			if (PooledReader0 == null)
			{
				this.sync___set_value_ownedOptionIndex(this.syncVar___ownedOptionIndex.GetValue(true), true);
				return true;
			}
			int value = PooledReader0.ReadInt32(AutoPackType.Packed);
			this.sync___set_value_ownedOptionIndex(value, Boolean2);
			return true;
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x000CE0E3 File Offset: 0x000CC2E3
		protected virtual void dll()
		{
			base.Awake();
		}

		// Token: 0x0400236A RID: 9066
		[Header("Option list feature settings")]
		public int defaultOptionIndex;

		// Token: 0x0400236B RID: 9067
		[SyncVar]
		public int ownedOptionIndex;

		// Token: 0x0400236C RID: 9068
		public SyncVar<int> syncVar___ownedOptionIndex;

		// Token: 0x0400236D RID: 9069
		private bool dll_Excuted;

		// Token: 0x0400236E RID: 9070
		private bool dll_Excuted;
	}
}
