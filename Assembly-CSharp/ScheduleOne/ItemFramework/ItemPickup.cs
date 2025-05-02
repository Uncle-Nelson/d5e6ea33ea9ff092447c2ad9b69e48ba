using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200094E RID: 2382
	[RequireComponent(typeof(InteractableObject))]
	public class ItemPickup : NetworkBehaviour
	{
		// Token: 0x0600405B RID: 16475 RVA: 0x0010E8CC File Offset: 0x0010CACC
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.ItemFramework.ItemPickup_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x0010E8EB File Offset: 0x0010CAEB
		private void Start()
		{
			if (Player.Local != null)
			{
				this.Init();
				return;
			}
			Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(this.Init));
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x0010E921 File Offset: 0x0010CB21
		private void Init()
		{
			Player.onLocalPlayerSpawned = (Action)Delegate.Remove(Player.onLocalPlayerSpawned, new Action(this.Init));
			Singleton<CoroutineService>.Instance.StartCoroutine(this.<Init>g__Wait|9_0());
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x0010E954 File Offset: 0x0010CB54
		protected virtual void Hovered()
		{
			if (this.CanPickup())
			{
				this.IntObj.SetMessage("Pick up " + this.ItemToGive.Name);
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				return;
			}
			this.IntObj.SetMessage("Inventory Full");
			this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Invalid);
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x0010E9B2 File Offset: 0x0010CBB2
		private void Interacted()
		{
			if (this.CanPickup())
			{
				this.Pickup();
			}
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x0010E9C2 File Offset: 0x0010CBC2
		protected virtual bool CanPickup()
		{
			return this.ItemToGive != null && PlayerSingleton<PlayerInventory>.Instance.CanItemFitInInventory(this.ItemToGive.GetDefaultInstance(1), 1);
		}

		// Token: 0x06004061 RID: 16481 RVA: 0x0010E9EC File Offset: 0x0010CBEC
		protected virtual void Pickup()
		{
			if (this.ItemToGive != null)
			{
				PlayerSingleton<PlayerInventory>.Instance.AddItemToInventory(this.ItemToGive.GetDefaultInstance(1));
			}
			if (this.onPickup != null)
			{
				this.onPickup.Invoke();
			}
			if (this.DestroyOnPickup)
			{
				if (this.Networked)
				{
					this.Destroy();
					return;
				}
				base.gameObject.SetActive(false);
			}
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x0010EA54 File Offset: 0x0010CC54
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void Destroy()
		{
			this.RpcWriter___Server_Destroy_2166136261();
			this.RpcLogic___Destroy_2166136261();
		}

		// Token: 0x06004064 RID: 16484 RVA: 0x0010EA83 File Offset: 0x0010CC83
		[CompilerGenerated]
		private IEnumerator <Init>g__Wait|9_0()
		{
			yield return new WaitUntil(() => Player.Local.playerDataRetrieveReturned);
			if (this.ConditionallyActive && this.ActiveCondition != null)
			{
				base.gameObject.SetActive(this.ActiveCondition.Evaluate());
			}
			yield break;
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x0010EA92 File Offset: 0x0010CC92
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ItemFramework.ItemPickupAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ItemFramework.ItemPickupAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_Destroy_2166136261));
		}

		// Token: 0x06004066 RID: 16486 RVA: 0x0010EABC File Offset: 0x0010CCBC
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ItemFramework.ItemPickupAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ItemFramework.ItemPickupAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x0010EACF File Offset: 0x0010CCCF
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x0010EAE0 File Offset: 0x0010CCE0
		private void RpcWriter___Server_Destroy_2166136261()
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
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x0010EB7C File Offset: 0x0010CD7C
		public void RpcLogic___Destroy_2166136261()
		{
			if (base.IsServer)
			{
				base.NetworkObject.Despawn(null);
			}
			Object.Destroy(base.gameObject);
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x0010EBB0 File Offset: 0x0010CDB0
		private void RpcReader___Server_Destroy_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___Destroy_2166136261();
		}

		// Token: 0x0600406B RID: 16491 RVA: 0x0010EBE0 File Offset: 0x0010CDE0
		protected virtual void dll()
		{
			if (this.ItemToGive != null)
			{
				this.IntObj.SetMessage("Pick up " + this.ItemToGive.Name);
			}
			this.IntObj.onHovered.AddListener(new UnityAction(this.Hovered));
			this.IntObj.onInteractStart.AddListener(new UnityAction(this.Interacted));
		}

		// Token: 0x04002E39 RID: 11833
		public ItemDefinition ItemToGive;

		// Token: 0x04002E3A RID: 11834
		public bool DestroyOnPickup = true;

		// Token: 0x04002E3B RID: 11835
		public bool ConditionallyActive;

		// Token: 0x04002E3C RID: 11836
		public Condition ActiveCondition;

		// Token: 0x04002E3D RID: 11837
		public bool Networked = true;

		// Token: 0x04002E3E RID: 11838
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04002E3F RID: 11839
		public UnityEvent onPickup;

		// Token: 0x04002E40 RID: 11840
		private bool dll_Excuted;

		// Token: 0x04002E41 RID: 11841
		private bool dll_Excuted;
	}
}
