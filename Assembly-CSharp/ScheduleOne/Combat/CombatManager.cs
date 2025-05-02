using System;
using System.Collections.Generic;
using EasyButtons;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x02000736 RID: 1846
	public class CombatManager : NetworkSingleton<CombatManager>
	{
		// Token: 0x060031F7 RID: 12791 RVA: 0x000CF678 File Offset: 0x000CD878
		[Button]
		public void CreateTestExplosion()
		{
			Vector3 origin = PlayerSingleton<PlayerCamera>.Instance.transform.position + PlayerSingleton<PlayerCamera>.Instance.transform.forward * 10f;
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast(10f, out raycastHit, this.ExplosionLayerMask, true, 0f))
			{
				origin = raycastHit.point;
			}
			this.CreateExplosion(origin, ExplosionData.DefaultSmall);
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x000CF6E8 File Offset: 0x000CD8E8
		public void CreateExplosion(Vector3 origin, ExplosionData data)
		{
			int id = Random.Range(0, int.MaxValue);
			this.CreateExplosion(origin, data, id);
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x000CF70A File Offset: 0x000CD90A
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void CreateExplosion(Vector3 origin, ExplosionData data, int id)
		{
			this.RpcWriter___Server_CreateExplosion_2907189355(origin, data, id);
			this.RpcLogic___CreateExplosion_2907189355(origin, data, id);
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x000CF730 File Offset: 0x000CD930
		[ObserversRpc(RunLocally = true)]
		private void Explosion(Vector3 origin, ExplosionData data, int id)
		{
			this.RpcWriter___Observers_Explosion_2907189355(origin, data, id);
			this.RpcLogic___Explosion_2907189355(origin, data, id);
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x000CF76C File Offset: 0x000CD96C
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Combat.CombatManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Combat.CombatManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_CreateExplosion_2907189355));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_Explosion_2907189355));
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x000CF7BE File Offset: 0x000CD9BE
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Combat.CombatManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Combat.CombatManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x000CF7D7 File Offset: 0x000CD9D7
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x000CF7E8 File Offset: 0x000CD9E8
		private void RpcWriter___Server_CreateExplosion_2907189355(Vector3 origin, ExplosionData data, int id)
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
			writer.WriteVector3(origin);
			writer.Write___ScheduleOne.Combat.ExplosionDataFishNet.Serializing.Generated(data);
			writer.WriteInt32(id, AutoPackType.Packed);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x000CF8AE File Offset: 0x000CDAAE
		private void RpcLogic___CreateExplosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
			this.Explosion(origin, data, id);
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x000CF8BC File Offset: 0x000CDABC
		private void RpcReader___Server_CreateExplosion_2907189355(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			Vector3 origin = PooledReader0.ReadVector3();
			ExplosionData data = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Combat.ExplosionDataFishNet.Serializing.Generateds(PooledReader0);
			int id = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___CreateExplosion_2907189355(origin, data, id);
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x000CF924 File Offset: 0x000CDB24
		private void RpcWriter___Observers_Explosion_2907189355(Vector3 origin, ExplosionData data, int id)
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
			writer.WriteVector3(origin);
			writer.Write___ScheduleOne.Combat.ExplosionDataFishNet.Serializing.Generated(data);
			writer.WriteInt32(id, AutoPackType.Packed);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x000CF9F9 File Offset: 0x000CDBF9
		private void RpcLogic___Explosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
			if (this.explosionIDs.Contains(id))
			{
				return;
			}
			this.explosionIDs.Add(id);
			Explosion explosion = Object.Instantiate<Explosion>(this.ExplosionPrefab);
			explosion.Initialize(origin, data);
			Object.Destroy(explosion.gameObject, 3f);
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x000CFA38 File Offset: 0x000CDC38
		private void RpcReader___Observers_Explosion_2907189355(PooledReader PooledReader0, Channel channel)
		{
			Vector3 origin = PooledReader0.ReadVector3();
			ExplosionData data = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Combat.ExplosionDataFishNet.Serializing.Generateds(PooledReader0);
			int id = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___Explosion_2907189355(origin, data, id);
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x000CFA9A File Offset: 0x000CDC9A
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400238A RID: 9098
		public LayerMask MeleeLayerMask;

		// Token: 0x0400238B RID: 9099
		public LayerMask ExplosionLayerMask;

		// Token: 0x0400238C RID: 9100
		public LayerMask RangedWeaponLayerMask;

		// Token: 0x0400238D RID: 9101
		public Explosion ExplosionPrefab;

		// Token: 0x0400238E RID: 9102
		private List<int> explosionIDs = new List<int>();

		// Token: 0x0400238F RID: 9103
		private bool dll_Excuted;

		// Token: 0x04002390 RID: 9104
		private bool dll_Excuted;
	}
}
