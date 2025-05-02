using System;
using System.Linq;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.GameTime;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Product;
using ScheduleOne.Storage;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Property
{
	// Token: 0x0200081E RID: 2078
	public class RV : Property
	{
		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x0600389A RID: 14490 RVA: 0x000EF726 File Offset: 0x000ED926
		// (set) Token: 0x0600389B RID: 14491 RVA: 0x000EF72E File Offset: 0x000ED92E
		public bool _isExploded { get; private set; }

		// Token: 0x0600389C RID: 14492 RVA: 0x000EF737 File Offset: 0x000ED937
		protected override void Start()
		{
			base.Start();
			base.InvokeRepeating("UpdateVariables", 0f, 0.5f);
			NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance._onSleepStart.AddListener(new UnityAction(this.OnSleep));
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x000EF76F File Offset: 0x000ED96F
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			bool isExploded = this._isExploded;
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x000EF780 File Offset: 0x000ED980
		private void UpdateVariables()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this._isExploded)
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
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].IsFilledWithSoil)
				{
					num++;
				}
				if (array[i].NormalizedWaterLevel > 0.9f)
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
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("RV_Soil_Pots", num.ToString(), true);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("RV_Watered_Pots", num2.ToString(), true);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("RV_Seed_Pots", num3.ToString(), true);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("RV_SpeedGrow_Pots", num4.ToString(), true);
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x000EF8DC File Offset: 0x000EDADC
		public void Ransack()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			Debug.Log("Ransacking RV");
			foreach (BuildableItem buildableItem in this.BuildableItems)
			{
				IItemSlotOwner itemSlotOwner = null;
				if (buildableItem is IItemSlotOwner)
				{
					itemSlotOwner = (buildableItem as IItemSlotOwner);
				}
				else
				{
					StorageEntity component = buildableItem.GetComponent<StorageEntity>();
					if (component != null)
					{
						itemSlotOwner = component;
					}
				}
				if (itemSlotOwner != null)
				{
					for (int i = 0; i < itemSlotOwner.ItemSlots.Count; i++)
					{
						if (itemSlotOwner.ItemSlots[i].ItemInstance != null && itemSlotOwner.ItemSlots[i].ItemInstance is ProductItemInstance)
						{
							itemSlotOwner.ItemSlots[i].SetQuantity(0, false);
						}
					}
				}
			}
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x000EF9C4 File Offset: 0x000EDBC4
		public override bool ShouldSave()
		{
			return !this._isExploded && base.ShouldSave();
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x000EF9D6 File Offset: 0x000EDBD6
		[TargetRpc]
		public void SetExploded(NetworkConnection conn)
		{
			this.RpcWriter___Target_SetExploded_328543758(conn);
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x000EF9E2 File Offset: 0x000EDBE2
		public void SetExploded()
		{
			this._isExploded = true;
			if (this.onSetExploded != null)
			{
				this.onSetExploded.Invoke();
			}
		}

		// Token: 0x060038A3 RID: 14499 RVA: 0x000EF9FE File Offset: 0x000EDBFE
		private void OnSleep()
		{
			if (this.FXContainer != null)
			{
				this.FXContainer.gameObject.SetActive(false);
			}
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x000EFA1F File Offset: 0x000EDC1F
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Property.RVAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Property.RVAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterTargetRpc(5U, new ClientRpcDelegate(this.RpcReader___Target_SetExploded_328543758));
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x000EFA4F File Offset: 0x000EDC4F
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Property.RVAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Property.RVAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x000EFA68 File Offset: 0x000EDC68
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x000EFA78 File Offset: 0x000EDC78
		private void RpcWriter___Target_SetExploded_328543758(NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendTargetRpc(5U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x000EFB20 File Offset: 0x000EDD20
		public void RpcLogic___SetExploded_328543758(NetworkConnection conn)
		{
			this.SetExploded();
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x000EFB28 File Offset: 0x000EDD28
		private void RpcReader___Target_SetExploded_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetExploded_328543758(base.LocalConnection);
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x000EFB4E File Offset: 0x000EDD4E
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400291C RID: 10524
		public Transform ModelContainer;

		// Token: 0x0400291D RID: 10525
		public Transform FXContainer;

		// Token: 0x0400291E RID: 10526
		public UnityEvent onSetExploded;

		// Token: 0x04002920 RID: 10528
		private bool dll_Excuted;

		// Token: 0x04002921 RID: 10529
		private bool dll_Excuted;
	}
}
