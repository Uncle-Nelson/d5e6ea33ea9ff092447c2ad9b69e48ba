using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BF3 RID: 3059
	public class SoilPourer : GridItem
	{
		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x060055F8 RID: 22008 RVA: 0x00169DF2 File Offset: 0x00167FF2
		// (set) Token: 0x060055F9 RID: 22009 RVA: 0x00169DFA File Offset: 0x00167FFA
		public string SoilID { get; protected set; } = string.Empty;

		// Token: 0x060055FA RID: 22010 RVA: 0x00169E04 File Offset: 0x00168004
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (this.SoilID != string.Empty)
			{
				SoilDefinition item = Registry.GetItem<SoilDefinition>(this.SoilID);
				this.DirtPlane.material = item.DrySoilMat;
				this.SetSoilLevel(1f);
			}
		}

		// Token: 0x060055FB RID: 22011 RVA: 0x00169E52 File Offset: 0x00168052
		public void HandleHovered()
		{
			if (!string.IsNullOrEmpty(this.SoilID) && !this.isDispensing)
			{
				this.HandleIntObj.SetMessage("Dispense soil");
				this.HandleIntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				return;
			}
			this.HandleIntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
		}

		// Token: 0x060055FC RID: 22012 RVA: 0x00169E92 File Offset: 0x00168092
		public void HandleInteracted()
		{
			if (!string.IsNullOrEmpty(this.SoilID) && !this.isDispensing)
			{
				this.SendPourSoil();
				this.isDispensing = true;
			}
		}

		// Token: 0x060055FD RID: 22013 RVA: 0x00169EB6 File Offset: 0x001680B6
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendPourSoil()
		{
			this.RpcWriter___Server_SendPourSoil_2166136261();
			this.RpcLogic___SendPourSoil_2166136261();
		}

		// Token: 0x060055FE RID: 22014 RVA: 0x00169EC4 File Offset: 0x001680C4
		[ObserversRpc(RunLocally = true)]
		private void PourSoil()
		{
			this.RpcWriter___Observers_PourSoil_2166136261();
			this.RpcLogic___PourSoil_2166136261();
		}

		// Token: 0x060055FF RID: 22015 RVA: 0x00169ED4 File Offset: 0x001680D4
		private void ApplySoil(string ID)
		{
			Pot[] array = this.GetPots().ToArray();
			if (array != null && array.Length != 0 && array[0].SoilID == string.Empty)
			{
				array[0].SetSoilID(ID);
				array[0].SetSoilState(Pot.ESoilState.Flat);
				array[0].AddSoil(array[0].SoilCapacity);
				array[0].SetSoilUses(Registry.GetItem<SoilDefinition>(ID).Uses);
				if (InstanceFinder.IsServer)
				{
					array[0].PushSoilDataToServer();
				}
			}
		}

		// Token: 0x06005600 RID: 22016 RVA: 0x00169F4C File Offset: 0x0016814C
		public void FillHovered()
		{
			bool flag = false;
			if (PlayerSingleton<PlayerInventory>.Instance.isAnythingEquipped && PlayerSingleton<PlayerInventory>.Instance.equippedSlot.ItemInstance.Definition is SoilDefinition)
			{
				flag = true;
			}
			if (this.SoilID == string.Empty && flag)
			{
				this.FillIntObj.SetMessage("Insert soil");
				this.FillIntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				return;
			}
			this.FillIntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
		}

		// Token: 0x06005601 RID: 22017 RVA: 0x00169FC4 File Offset: 0x001681C4
		public void FillInteracted()
		{
			bool flag = false;
			if (PlayerSingleton<PlayerInventory>.Instance.isAnythingEquipped && PlayerSingleton<PlayerInventory>.Instance.equippedSlot.ItemInstance.Definition is SoilDefinition)
			{
				flag = true;
			}
			if (this.SoilID == string.Empty && flag)
			{
				this.FillSound.Play();
				this.SendSoil(PlayerSingleton<PlayerInventory>.Instance.equippedSlot.ItemInstance.Definition.ID);
				PlayerSingleton<PlayerInventory>.Instance.equippedSlot.ChangeQuantity(-1, false);
			}
		}

		// Token: 0x06005602 RID: 22018 RVA: 0x0016A04C File Offset: 0x0016824C
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendSoil(string ID)
		{
			this.RpcWriter___Server_SendSoil_3615296227(ID);
			this.RpcLogic___SendSoil_3615296227(ID);
		}

		// Token: 0x06005603 RID: 22019 RVA: 0x0016A064 File Offset: 0x00168264
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		protected void SetSoil(NetworkConnection conn, string ID)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetSoil_2971853958(conn, ID);
				this.RpcLogic___SetSoil_2971853958(conn, ID);
			}
			else
			{
				this.RpcWriter___Target_SetSoil_2971853958(conn, ID);
			}
		}

		// Token: 0x06005604 RID: 22020 RVA: 0x0016A0A8 File Offset: 0x001682A8
		public void SetSoilLevel(float level)
		{
			this.DirtPlane.transform.localPosition = Vector3.Lerp(this.Dirt_Min.localPosition, this.Dirt_Max.localPosition, level);
			this.DirtPlane.gameObject.SetActive(level > 0f);
		}

		// Token: 0x06005605 RID: 22021 RVA: 0x0016A0FC File Offset: 0x001682FC
		protected virtual List<Pot> GetPots()
		{
			List<Pot> list = new List<Pot>();
			Coordinate coord = new Coordinate(this.OriginCoordinate) + Coordinate.RotateCoordinates(new Coordinate(0, 1), (float)this.Rotation);
			Coordinate coord2 = new Coordinate(this.OriginCoordinate) + Coordinate.RotateCoordinates(new Coordinate(1, 1), (float)this.Rotation);
			Tile tile = base.OwnerGrid.GetTile(coord);
			Tile tile2 = base.OwnerGrid.GetTile(coord2);
			if (tile != null && tile2 != null)
			{
				Pot pot = null;
				foreach (GridItem gridItem in tile.BuildableOccupants)
				{
					if (gridItem is Pot)
					{
						pot = (gridItem as Pot);
						break;
					}
				}
				if (pot != null && tile2.BuildableOccupants.Contains(pot))
				{
					list.Add(pot);
				}
			}
			return list;
		}

		// Token: 0x06005606 RID: 22022 RVA: 0x0016A200 File Offset: 0x00168400
		public override string GetSaveString()
		{
			return new SoilPourerData(base.GUID, base.ItemInstance, 0, base.OwnerGrid, this.OriginCoordinate, this.Rotation, this.SoilID).GetJson(true);
		}

		// Token: 0x06005608 RID: 22024 RVA: 0x0016A250 File Offset: 0x00168450
		[CompilerGenerated]
		private IEnumerator <PourSoil>g__PourRoutine|20_0()
		{
			SoilDefinition item = Registry.GetItem<SoilDefinition>(this.SoilID);
			if (item == null)
			{
				Console.LogError("Soil definition not found for ID: " + this.SoilID, null);
				this.isDispensing = false;
				yield break;
			}
			this.ActivateSound.Play();
			this.PourParticles.startColor = item.ParticleColor;
			this.PourParticles.Play();
			this.PourAnimation.Play();
			this.DirtPourSound.Play();
			Pot targetPot = this.GetPots().FirstOrDefault<Pot>();
			if (targetPot != null)
			{
				targetPot.SetSoilID(this.SoilID);
				targetPot.SetSoilState(Pot.ESoilState.Flat);
				targetPot.SetSoilUses(item.Uses);
			}
			for (float i = 0f; i < this.AnimationDuration; i += Time.deltaTime)
			{
				float num = i / this.AnimationDuration;
				this.SetSoilLevel(1f - num);
				if (targetPot != null)
				{
					targetPot.AddSoil(targetPot.SoilCapacity * (Time.deltaTime / this.AnimationDuration));
				}
				yield return new WaitForEndOfFrame();
			}
			if (targetPot != null)
			{
				targetPot.AddSoil(targetPot.SoilCapacity - targetPot.SoilLevel);
			}
			this.ApplySoil(this.SoilID);
			this.SetSoil(null, string.Empty);
			this.PourParticles.Stop();
			this.isDispensing = false;
			yield return new WaitForSeconds(1f);
			this.DirtPourSound.Stop();
			yield break;
		}

		// Token: 0x06005609 RID: 22025 RVA: 0x0016A260 File Offset: 0x00168460
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.SoilPourerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.SoilPourerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_SendPourSoil_2166136261));
			base.RegisterObserversRpc(9U, new ClientRpcDelegate(this.RpcReader___Observers_PourSoil_2166136261));
			base.RegisterServerRpc(10U, new ServerRpcDelegate(this.RpcReader___Server_SendSoil_3615296227));
			base.RegisterObserversRpc(11U, new ClientRpcDelegate(this.RpcReader___Observers_SetSoil_2971853958));
			base.RegisterTargetRpc(12U, new ClientRpcDelegate(this.RpcReader___Target_SetSoil_2971853958));
		}

		// Token: 0x0600560A RID: 22026 RVA: 0x0016A2F7 File Offset: 0x001684F7
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.SoilPourerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.SoilPourerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x0600560B RID: 22027 RVA: 0x0016A310 File Offset: 0x00168510
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600560C RID: 22028 RVA: 0x0016A320 File Offset: 0x00168520
		private void RpcWriter___Server_SendPourSoil_2166136261()
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
			base.SendServerRpc(8U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600560D RID: 22029 RVA: 0x0016A3BA File Offset: 0x001685BA
		private void RpcLogic___SendPourSoil_2166136261()
		{
			this.PourSoil();
		}

		// Token: 0x0600560E RID: 22030 RVA: 0x0016A3C4 File Offset: 0x001685C4
		private void RpcReader___Server_SendPourSoil_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendPourSoil_2166136261();
		}

		// Token: 0x0600560F RID: 22031 RVA: 0x0016A3F4 File Offset: 0x001685F4
		private void RpcWriter___Observers_PourSoil_2166136261()
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
			base.SendObserversRpc(9U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06005610 RID: 22032 RVA: 0x0016A49D File Offset: 0x0016869D
		private void RpcLogic___PourSoil_2166136261()
		{
			if (this.isDispensing)
			{
				return;
			}
			this.isDispensing = true;
			base.StartCoroutine(this.<PourSoil>g__PourRoutine|20_0());
		}

		// Token: 0x06005611 RID: 22033 RVA: 0x0016A4BC File Offset: 0x001686BC
		private void RpcReader___Observers_PourSoil_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___PourSoil_2166136261();
		}

		// Token: 0x06005612 RID: 22034 RVA: 0x0016A4E8 File Offset: 0x001686E8
		private void RpcWriter___Server_SendSoil_3615296227(string ID)
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
			writer.WriteString(ID);
			base.SendServerRpc(10U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005613 RID: 22035 RVA: 0x0016A58F File Offset: 0x0016878F
		public void RpcLogic___SendSoil_3615296227(string ID)
		{
			this.SetSoil(null, ID);
		}

		// Token: 0x06005614 RID: 22036 RVA: 0x0016A59C File Offset: 0x0016879C
		private void RpcReader___Server_SendSoil_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string id = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendSoil_3615296227(id);
		}

		// Token: 0x06005615 RID: 22037 RVA: 0x0016A5DC File Offset: 0x001687DC
		private void RpcWriter___Observers_SetSoil_2971853958(NetworkConnection conn, string ID)
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
			writer.WriteString(ID);
			base.SendObserversRpc(11U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06005616 RID: 22038 RVA: 0x0016A694 File Offset: 0x00168894
		protected void RpcLogic___SetSoil_2971853958(NetworkConnection conn, string ID)
		{
			this.SoilID = ID;
			if (ID != string.Empty)
			{
				SoilDefinition item = Registry.GetItem<SoilDefinition>(this.SoilID);
				this.DirtPlane.material = item.DrySoilMat;
				this.SetSoilLevel(1f);
			}
		}

		// Token: 0x06005617 RID: 22039 RVA: 0x0016A6E0 File Offset: 0x001688E0
		private void RpcReader___Observers_SetSoil_2971853958(PooledReader PooledReader0, Channel channel)
		{
			string id = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetSoil_2971853958(null, id);
		}

		// Token: 0x06005618 RID: 22040 RVA: 0x0016A71C File Offset: 0x0016891C
		private void RpcWriter___Target_SetSoil_2971853958(NetworkConnection conn, string ID)
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
			writer.WriteString(ID);
			base.SendTargetRpc(12U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06005619 RID: 22041 RVA: 0x0016A7D4 File Offset: 0x001689D4
		private void RpcReader___Target_SetSoil_2971853958(PooledReader PooledReader0, Channel channel)
		{
			string id = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetSoil_2971853958(base.LocalConnection, id);
		}

		// Token: 0x0600561A RID: 22042 RVA: 0x0016A80B File Offset: 0x00168A0B
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04003F97 RID: 16279
		public float AnimationDuration = 8f;

		// Token: 0x04003F98 RID: 16280
		[Header("References")]
		public InteractableObject HandleIntObj;

		// Token: 0x04003F99 RID: 16281
		public InteractableObject FillIntObj;

		// Token: 0x04003F9A RID: 16282
		public MeshRenderer DirtPlane;

		// Token: 0x04003F9B RID: 16283
		public Transform Dirt_Min;

		// Token: 0x04003F9C RID: 16284
		public Transform Dirt_Max;

		// Token: 0x04003F9D RID: 16285
		public ParticleSystem PourParticles;

		// Token: 0x04003F9E RID: 16286
		public Animation PourAnimation;

		// Token: 0x04003F9F RID: 16287
		public AudioSourceController FillSound;

		// Token: 0x04003FA0 RID: 16288
		public AudioSourceController ActivateSound;

		// Token: 0x04003FA1 RID: 16289
		public AudioSourceController DirtPourSound;

		// Token: 0x04003FA2 RID: 16290
		private bool isDispensing;

		// Token: 0x04003FA3 RID: 16291
		private bool dll_Excuted;

		// Token: 0x04003FA4 RID: 16292
		private bool dll_Excuted;
	}
}
