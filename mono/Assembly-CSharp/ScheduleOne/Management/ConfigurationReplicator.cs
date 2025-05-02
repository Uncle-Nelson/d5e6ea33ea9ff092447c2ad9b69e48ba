using System;
using System.Collections.Generic;
using System.Linq;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.Management
{
	// Token: 0x02000562 RID: 1378
	public class ConfigurationReplicator : NetworkBehaviour
	{
		// Token: 0x060021A0 RID: 8608 RVA: 0x0008A6C4 File Offset: 0x000888C4
		public void ReplicateField(ConfigField field, NetworkConnection conn = null)
		{
			int num = this.Configuration.Fields.IndexOf(field);
			if (num == -1)
			{
				Console.LogError("Failed to find field in configuration", null);
				return;
			}
			if (field is ItemField)
			{
				ItemField itemField = (ItemField)field;
				this.SendItemField(num, (itemField.SelectedItem != null) ? itemField.SelectedItem.name : string.Empty);
				return;
			}
			if (field is NPCField)
			{
				NPCField npcfield = (NPCField)field;
				this.SendNPCField(num, (npcfield.SelectedNPC != null) ? npcfield.SelectedNPC.NetworkObject : null);
				return;
			}
			if (field is ObjectField)
			{
				ObjectField objectField = (ObjectField)field;
				NetworkObject obj = null;
				if (objectField.SelectedObject != null)
				{
					obj = objectField.SelectedObject.NetworkObject;
				}
				this.SendObjectField(num, obj);
				return;
			}
			if (field is ObjectListField)
			{
				ObjectListField objectListField = (ObjectListField)field;
				List<NetworkObject> list = new List<NetworkObject>();
				for (int i = 0; i < objectListField.SelectedObjects.Count; i++)
				{
					list.Add(objectListField.SelectedObjects[i].NetworkObject);
				}
				this.SendObjectListField(num, list);
				return;
			}
			if (field is StationRecipeField)
			{
				StationRecipeField stationRecipeField = (StationRecipeField)field;
				int recipeIndex = -1;
				if (stationRecipeField.SelectedRecipe != null)
				{
					recipeIndex = stationRecipeField.Options.IndexOf(stationRecipeField.SelectedRecipe);
				}
				this.SendRecipeField(num, recipeIndex);
				return;
			}
			if (field is NumberField)
			{
				NumberField numberField = (NumberField)field;
				this.SendNumberField(num, numberField.Value);
				return;
			}
			if (field is RouteListField)
			{
				RouteListField routeListField = (RouteListField)field;
				this.SendRouteListField(num, (from x in routeListField.Routes
				select x.GetData()).ToArray<AdvancedTransitRouteData>());
				return;
			}
			if (field is QualityField)
			{
				QualityField qualityField = (QualityField)field;
				this.SendQualityField(num, qualityField.Value);
				return;
			}
			string str = "Failed to find replication method for ";
			Type type = field.GetType();
			Console.LogError(str + ((type != null) ? type.ToString() : null), null);
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x0008A8D3 File Offset: 0x00088AD3
		[ServerRpc(RequireOwnership = false)]
		private void SendItemField(int fieldIndex, string value)
		{
			this.RpcWriter___Server_SendItemField_2801973956(fieldIndex, value);
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x0008A8E4 File Offset: 0x00088AE4
		[ObserversRpc]
		private void ReceiveItemField(int fieldIndex, string value)
		{
			this.RpcWriter___Observers_ReceiveItemField_2801973956(fieldIndex, value);
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x0008A8FF File Offset: 0x00088AFF
		[ServerRpc(RequireOwnership = false)]
		private void SendNPCField(int fieldIndex, NetworkObject npcObject)
		{
			this.RpcWriter___Server_SendNPCField_1687693739(fieldIndex, npcObject);
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x0008A910 File Offset: 0x00088B10
		[ObserversRpc]
		private void ReceiveNPCField(int fieldIndex, NetworkObject npcObject)
		{
			this.RpcWriter___Observers_ReceiveNPCField_1687693739(fieldIndex, npcObject);
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x0008A92B File Offset: 0x00088B2B
		[ServerRpc(RequireOwnership = false)]
		private void SendObjectField(int fieldIndex, NetworkObject obj)
		{
			this.RpcWriter___Server_SendObjectField_1687693739(fieldIndex, obj);
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x0008A93C File Offset: 0x00088B3C
		[ObserversRpc]
		private void ReceiveObjectField(int fieldIndex, NetworkObject obj)
		{
			this.RpcWriter___Observers_ReceiveObjectField_1687693739(fieldIndex, obj);
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x0008A957 File Offset: 0x00088B57
		[ServerRpc(RequireOwnership = false)]
		private void SendObjectListField(int fieldIndex, List<NetworkObject> objects)
		{
			this.RpcWriter___Server_SendObjectListField_690244341(fieldIndex, objects);
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x0008A968 File Offset: 0x00088B68
		[ObserversRpc]
		private void ReceiveObjectListField(int fieldIndex, List<NetworkObject> objects)
		{
			this.RpcWriter___Observers_ReceiveObjectListField_690244341(fieldIndex, objects);
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x0008A983 File Offset: 0x00088B83
		[ServerRpc(RequireOwnership = false)]
		private void SendRecipeField(int fieldIndex, int recipeIndex)
		{
			this.RpcWriter___Server_SendRecipeField_1692629761(fieldIndex, recipeIndex);
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x0008A994 File Offset: 0x00088B94
		[ObserversRpc]
		private void ReceiveRecipeField(int fieldIndex, int recipeIndex)
		{
			this.RpcWriter___Observers_ReceiveRecipeField_1692629761(fieldIndex, recipeIndex);
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x0008A9AF File Offset: 0x00088BAF
		[ServerRpc(RequireOwnership = false)]
		private void SendNumberField(int fieldIndex, float value)
		{
			this.RpcWriter___Server_SendNumberField_1293284375(fieldIndex, value);
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x0008A9BF File Offset: 0x00088BBF
		[ObserversRpc]
		private void ReceiveNumberField(int fieldIndex, float value)
		{
			this.RpcWriter___Observers_ReceiveNumberField_1293284375(fieldIndex, value);
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x0008A9CF File Offset: 0x00088BCF
		[ServerRpc(RequireOwnership = false)]
		private void SendRouteListField(int fieldIndex, AdvancedTransitRouteData[] value)
		{
			this.RpcWriter___Server_SendRouteListField_3226448297(fieldIndex, value);
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x0008A9E0 File Offset: 0x00088BE0
		[ObserversRpc]
		private void ReceiveRouteListField(int fieldIndex, AdvancedTransitRouteData[] value)
		{
			this.RpcWriter___Observers_ReceiveRouteListField_3226448297(fieldIndex, value);
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x0008A9FB File Offset: 0x00088BFB
		[ServerRpc(RequireOwnership = false)]
		private void SendQualityField(int fieldIndex, EQuality quality)
		{
			this.RpcWriter___Server_SendQualityField_3536682170(fieldIndex, quality);
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x0008AA0B File Offset: 0x00088C0B
		[ObserversRpc]
		private void ReceiveQualityField(int fieldIndex, EQuality value)
		{
			this.RpcWriter___Observers_ReceiveQualityField_3536682170(fieldIndex, value);
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x0008AA1C File Offset: 0x00088C1C
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Management.ConfigurationReplicatorAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Management.ConfigurationReplicatorAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendItemField_2801973956));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveItemField_2801973956));
			base.RegisterServerRpc(2U, new ServerRpcDelegate(this.RpcReader___Server_SendNPCField_1687693739));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveNPCField_1687693739));
			base.RegisterServerRpc(4U, new ServerRpcDelegate(this.RpcReader___Server_SendObjectField_1687693739));
			base.RegisterObserversRpc(5U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveObjectField_1687693739));
			base.RegisterServerRpc(6U, new ServerRpcDelegate(this.RpcReader___Server_SendObjectListField_690244341));
			base.RegisterObserversRpc(7U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveObjectListField_690244341));
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_SendRecipeField_1692629761));
			base.RegisterObserversRpc(9U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveRecipeField_1692629761));
			base.RegisterServerRpc(10U, new ServerRpcDelegate(this.RpcReader___Server_SendNumberField_1293284375));
			base.RegisterObserversRpc(11U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveNumberField_1293284375));
			base.RegisterServerRpc(12U, new ServerRpcDelegate(this.RpcReader___Server_SendRouteListField_3226448297));
			base.RegisterObserversRpc(13U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveRouteListField_3226448297));
			base.RegisterServerRpc(14U, new ServerRpcDelegate(this.RpcReader___Server_SendQualityField_3536682170));
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveQualityField_3536682170));
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x0008ABAA File Offset: 0x00088DAA
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Management.ConfigurationReplicatorAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Management.ConfigurationReplicatorAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x0008ABBD File Offset: 0x00088DBD
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x0008ABCC File Offset: 0x00088DCC
		private void RpcWriter___Server_SendItemField_2801973956(int fieldIndex, string value)
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
			writer.WriteInt32(fieldIndex, AutoPackType.Packed);
			writer.WriteString(value);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x0008AC85 File Offset: 0x00088E85
		private void RpcLogic___SendItemField_2801973956(int fieldIndex, string value)
		{
			this.ReceiveItemField(fieldIndex, value);
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x0008AC90 File Offset: 0x00088E90
		private void RpcReader___Server_SendItemField_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int fieldIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			string value = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendItemField_2801973956(fieldIndex, value);
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x0008ACD8 File Offset: 0x00088ED8
		private void RpcWriter___Observers_ReceiveItemField_2801973956(int fieldIndex, string value)
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
			writer.WriteInt32(fieldIndex, AutoPackType.Packed);
			writer.WriteString(value);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x0008ADA0 File Offset: 0x00088FA0
		private void RpcLogic___ReceiveItemField_2801973956(int fieldIndex, string value)
		{
			ItemField itemField = this.Configuration.Fields[fieldIndex] as ItemField;
			ItemDefinition item = null;
			if (value != string.Empty)
			{
				item = Registry.GetItem(value);
			}
			itemField.SetItem(item, false);
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x0008ADE0 File Offset: 0x00088FE0
		private void RpcReader___Observers_ReceiveItemField_2801973956(PooledReader PooledReader0, Channel channel)
		{
			int fieldIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			string value = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveItemField_2801973956(fieldIndex, value);
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x0008AE28 File Offset: 0x00089028
		private void RpcWriter___Server_SendNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
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
			writer.WriteInt32(fieldIndex, AutoPackType.Packed);
			writer.WriteNetworkObject(npcObject);
			base.SendServerRpc(2U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x0008AEE1 File Offset: 0x000890E1
		private void RpcLogic___SendNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
			this.ReceiveNPCField(fieldIndex, npcObject);
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0008AEEC File Offset: 0x000890EC
		private void RpcReader___Server_SendNPCField_1687693739(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int fieldIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			NetworkObject npcObject = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendNPCField_1687693739(fieldIndex, npcObject);
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x0008AF34 File Offset: 0x00089134
		private void RpcWriter___Observers_ReceiveNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
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
			writer.WriteInt32(fieldIndex, AutoPackType.Packed);
			writer.WriteNetworkObject(npcObject);
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x0008AFFC File Offset: 0x000891FC
		private void RpcLogic___ReceiveNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
			NPCField npcfield = this.Configuration.Fields[fieldIndex] as NPCField;
			NPC npc = null;
			if (npcObject != null)
			{
				npc = npcObject.GetComponent<NPC>();
			}
			npcfield.SetNPC(npc, false);
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x0008B038 File Offset: 0x00089238
		private void RpcReader___Observers_ReceiveNPCField_1687693739(PooledReader PooledReader0, Channel channel)
		{
			int fieldIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			NetworkObject npcObject = PooledReader0.ReadNetworkObject();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveNPCField_1687693739(fieldIndex, npcObject);
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x0008B080 File Offset: 0x00089280
		private void RpcWriter___Server_SendObjectField_1687693739(int fieldIndex, NetworkObject obj)
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
			writer.WriteInt32(fieldIndex, AutoPackType.Packed);
			writer.WriteNetworkObject(obj);
			base.SendServerRpc(4U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x0008B139 File Offset: 0x00089339
		private void RpcLogic___SendObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
			this.ReceiveObjectField(fieldIndex, obj);
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x0008B144 File Offset: 0x00089344
		private void RpcReader___Server_SendObjectField_1687693739(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int fieldIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			NetworkObject obj = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendObjectField_1687693739(fieldIndex, obj);
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x0008B18C File Offset: 0x0008938C
		private void RpcWriter___Observers_ReceiveObjectField_1687693739(int fieldIndex, NetworkObject obj)
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
			writer.WriteInt32(fieldIndex, AutoPackType.Packed);
			writer.WriteNetworkObject(obj);
			base.SendObserversRpc(5U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x0008B254 File Offset: 0x00089454
		private void RpcLogic___ReceiveObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
			ObjectField objectField = this.Configuration.Fields[fieldIndex] as ObjectField;
			BuildableItem obj2 = null;
			if (obj != null)
			{
				obj2 = obj.GetComponent<BuildableItem>();
			}
			objectField.SetObject(obj2, false);
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x0008B290 File Offset: 0x00089490
		private void RpcReader___Observers_ReceiveObjectField_1687693739(PooledReader PooledReader0, Channel channel)
		{
			int fieldIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			NetworkObject obj = PooledReader0.ReadNetworkObject();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveObjectField_1687693739(fieldIndex, obj);
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x0008B2D8 File Offset: 0x000894D8
		private void RpcWriter___Server_SendObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
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
			writer.WriteInt32(fieldIndex, AutoPackType.Packed);
			writer.Write___System.Collections.Generic.List`1<FishNet.Object.NetworkObject>FishNet.Serializing.Generated(objects);
			base.SendServerRpc(6U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x0008B391 File Offset: 0x00089591
		private void RpcLogic___SendObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
			this.ReceiveObjectListField(fieldIndex, objects);
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x0008B39C File Offset: 0x0008959C
		private void RpcReader___Server_SendObjectListField_690244341(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int fieldIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			List<NetworkObject> objects = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<FishNet.Object.NetworkObject>FishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendObjectListField_690244341(fieldIndex, objects);
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x0008B3E4 File Offset: 0x000895E4
		private void RpcWriter___Observers_ReceiveObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
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
			writer.WriteInt32(fieldIndex, AutoPackType.Packed);
			writer.Write___System.Collections.Generic.List`1<FishNet.Object.NetworkObject>FishNet.Serializing.Generated(objects);
			base.SendObserversRpc(7U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x0008B4AC File Offset: 0x000896AC
		private void RpcLogic___ReceiveObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
			ObjectListField objectListField = this.Configuration.Fields[fieldIndex] as ObjectListField;
			List<BuildableItem> list = new List<BuildableItem>();
			for (int i = 0; i < objects.Count; i++)
			{
				list.Add(objects[i].GetComponent<BuildableItem>());
			}
			objectListField.SetList(list, false);
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x0008B504 File Offset: 0x00089704
		private void RpcReader___Observers_ReceiveObjectListField_690244341(PooledReader PooledReader0, Channel channel)
		{
			int fieldIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			List<NetworkObject> objects = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<FishNet.Object.NetworkObject>FishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveObjectListField_690244341(fieldIndex, objects);
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x0008B54C File Offset: 0x0008974C
		private void RpcWriter___Server_SendRecipeField_1692629761(int fieldIndex, int recipeIndex)
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
			writer.WriteInt32(fieldIndex, AutoPackType.Packed);
			writer.WriteInt32(recipeIndex, AutoPackType.Packed);
			base.SendServerRpc(8U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x0008B60A File Offset: 0x0008980A
		private void RpcLogic___SendRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
			this.ReceiveRecipeField(fieldIndex, recipeIndex);
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x0008B614 File Offset: 0x00089814
		private void RpcReader___Server_SendRecipeField_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int fieldIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			int recipeIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendRecipeField_1692629761(fieldIndex, recipeIndex);
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x0008B660 File Offset: 0x00089860
		private void RpcWriter___Observers_ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex)
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
			writer.WriteInt32(fieldIndex, AutoPackType.Packed);
			writer.WriteInt32(recipeIndex, AutoPackType.Packed);
			base.SendObserversRpc(9U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x0008B730 File Offset: 0x00089930
		private void RpcLogic___ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
			StationRecipeField stationRecipeField = this.Configuration.Fields[fieldIndex] as StationRecipeField;
			StationRecipe recipe = null;
			if (recipeIndex != -1)
			{
				recipe = stationRecipeField.Options[recipeIndex];
			}
			stationRecipeField.SetRecipe(recipe, false);
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x0008B770 File Offset: 0x00089970
		private void RpcReader___Observers_ReceiveRecipeField_1692629761(PooledReader PooledReader0, Channel channel)
		{
			int fieldIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			int recipeIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveRecipeField_1692629761(fieldIndex, recipeIndex);
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x0008B7BC File Offset: 0x000899BC
		private void RpcWriter___Server_SendNumberField_1293284375(int fieldIndex, float value)
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
			writer.WriteInt32(fieldIndex, AutoPackType.Packed);
			writer.WriteSingle(value, AutoPackType.Unpacked);
			base.SendServerRpc(10U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x0008B87A File Offset: 0x00089A7A
		private void RpcLogic___SendNumberField_1293284375(int fieldIndex, float value)
		{
			this.ReceiveNumberField(fieldIndex, value);
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x0008B884 File Offset: 0x00089A84
		private void RpcReader___Server_SendNumberField_1293284375(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int fieldIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			float value = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendNumberField_1293284375(fieldIndex, value);
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x0008B8D0 File Offset: 0x00089AD0
		private void RpcWriter___Observers_ReceiveNumberField_1293284375(int fieldIndex, float value)
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
			writer.WriteInt32(fieldIndex, AutoPackType.Packed);
			writer.WriteSingle(value, AutoPackType.Unpacked);
			base.SendObserversRpc(11U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0008B99D File Offset: 0x00089B9D
		private void RpcLogic___ReceiveNumberField_1293284375(int fieldIndex, float value)
		{
			(this.Configuration.Fields[fieldIndex] as NumberField).SetValue(value, false);
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x0008B9BC File Offset: 0x00089BBC
		private void RpcReader___Observers_ReceiveNumberField_1293284375(PooledReader PooledReader0, Channel channel)
		{
			int fieldIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			float value = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveNumberField_1293284375(fieldIndex, value);
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x0008BA08 File Offset: 0x00089C08
		private void RpcWriter___Server_SendRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value)
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
			writer.WriteInt32(fieldIndex, AutoPackType.Packed);
			writer.Write___ScheduleOne.Persistence.Datas.AdvancedTransitRouteData[]FishNet.Serializing.Generated(value);
			base.SendServerRpc(12U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x0008BAC1 File Offset: 0x00089CC1
		private void RpcLogic___SendRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value)
		{
			this.ReceiveRouteListField(fieldIndex, value);
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x0008BACC File Offset: 0x00089CCC
		private void RpcReader___Server_SendRouteListField_3226448297(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int fieldIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			AdvancedTransitRouteData[] value = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.AdvancedTransitRouteData[]FishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendRouteListField_3226448297(fieldIndex, value);
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x0008BB14 File Offset: 0x00089D14
		private void RpcWriter___Observers_ReceiveRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value)
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
			writer.WriteInt32(fieldIndex, AutoPackType.Packed);
			writer.Write___ScheduleOne.Persistence.Datas.AdvancedTransitRouteData[]FishNet.Serializing.Generated(value);
			base.SendObserversRpc(13U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x0008BBDC File Offset: 0x00089DDC
		private void RpcLogic___ReceiveRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value)
		{
			(this.Configuration.Fields[fieldIndex] as RouteListField).SetList((from x in value
			select new AdvancedTransitRoute(x)).ToList<AdvancedTransitRoute>(), false, false);
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x0008BC30 File Offset: 0x00089E30
		private void RpcReader___Observers_ReceiveRouteListField_3226448297(PooledReader PooledReader0, Channel channel)
		{
			int fieldIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			AdvancedTransitRouteData[] value = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.AdvancedTransitRouteData[]FishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveRouteListField_3226448297(fieldIndex, value);
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x0008BC78 File Offset: 0x00089E78
		private void RpcWriter___Server_SendQualityField_3536682170(int fieldIndex, EQuality quality)
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
			writer.WriteInt32(fieldIndex, AutoPackType.Packed);
			writer.Write___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generated(quality);
			base.SendServerRpc(14U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x0008BD31 File Offset: 0x00089F31
		private void RpcLogic___SendQualityField_3536682170(int fieldIndex, EQuality quality)
		{
			this.ReceiveQualityField(fieldIndex, quality);
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x0008BD3C File Offset: 0x00089F3C
		private void RpcReader___Server_SendQualityField_3536682170(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int fieldIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			EQuality quality = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendQualityField_3536682170(fieldIndex, quality);
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x0008BD84 File Offset: 0x00089F84
		private void RpcWriter___Observers_ReceiveQualityField_3536682170(int fieldIndex, EQuality value)
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
			writer.WriteInt32(fieldIndex, AutoPackType.Packed);
			writer.Write___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generated(value);
			base.SendObserversRpc(15U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x0008BE4C File Offset: 0x0008A04C
		private void RpcLogic___ReceiveQualityField_3536682170(int fieldIndex, EQuality value)
		{
			(this.Configuration.Fields[fieldIndex] as QualityField).SetValue(value, false);
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x0008BE6C File Offset: 0x0008A06C
		private void RpcReader___Observers_ReceiveQualityField_3536682170(PooledReader PooledReader0, Channel channel)
		{
			int fieldIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			EQuality value = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveQualityField_3536682170(fieldIndex, value);
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x0008ABBD File Offset: 0x00088DBD
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040019CD RID: 6605
		public EntityConfiguration Configuration;

		// Token: 0x040019CE RID: 6606
		private bool dll_Excuted;

		// Token: 0x040019CF RID: 6607
		private bool dll_Excuted;
	}
}
