using System;
using System.Collections.Generic;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Phone.Messages;
using UnityEngine;

namespace ScheduleOne.Messaging
{
	// Token: 0x02000547 RID: 1351
	public class MessagingManager : NetworkSingleton<MessagingManager>
	{
		// Token: 0x060020D6 RID: 8406 RVA: 0x00086D67 File Offset: 0x00084F67
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Messaging.MessagingManager_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x00086D7C File Offset: 0x00084F7C
		public override void OnSpawnServer(NetworkConnection connection)
		{
			MessagingManager.<>c__DisplayClass2_0 CS$<>8__locals1 = new MessagingManager.<>c__DisplayClass2_0();
			CS$<>8__locals1.connection = connection;
			CS$<>8__locals1.<>4__this = this;
			base.OnSpawnServer(CS$<>8__locals1.connection);
			if (CS$<>8__locals1.connection.IsLocalClient)
			{
				return;
			}
			base.StartCoroutine(CS$<>8__locals1.<OnSpawnServer>g__SendMessages|0());
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x00086DC4 File Offset: 0x00084FC4
		public MSGConversation GetConversation(NPC npc)
		{
			if (!this.ConversationMap.ContainsKey(npc))
			{
				Console.LogError("No conversation found for " + npc.fullName, null);
				return null;
			}
			return this.ConversationMap[npc];
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x00086DF8 File Offset: 0x00084FF8
		public void Register(NPC npc, MSGConversation convs)
		{
			if (this.ConversationMap.ContainsKey(npc))
			{
				Console.LogError("Conversation already registered for " + npc.fullName, null);
				return;
			}
			this.ConversationMap.Add(npc, convs);
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x00086E2C File Offset: 0x0008502C
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMessage(Message m, bool notify, string npcID)
		{
			this.RpcWriter___Server_SendMessage_2134336246(m, notify, npcID);
			this.RpcLogic___SendMessage_2134336246(m, notify, npcID);
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x00086E54 File Offset: 0x00085054
		[ObserversRpc(RunLocally = true)]
		private void ReceiveMessage(Message m, bool notify, string npcID)
		{
			this.RpcWriter___Observers_ReceiveMessage_2134336246(m, notify, npcID);
			this.RpcLogic___ReceiveMessage_2134336246(m, notify, npcID);
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x00086E85 File Offset: 0x00085085
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMessageChain(MessageChain m, string npcID, float initialDelay, bool notify)
		{
			this.RpcWriter___Server_SendMessageChain_3949292778(m, npcID, initialDelay, notify);
			this.RpcLogic___SendMessageChain_3949292778(m, npcID, initialDelay, notify);
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x00086EB4 File Offset: 0x000850B4
		[ObserversRpc(RunLocally = true)]
		private void ReceiveMessageChain(MessageChain m, string npcID, float initialDelay, bool notify)
		{
			this.RpcWriter___Observers_ReceiveMessageChain_3949292778(m, npcID, initialDelay, notify);
			this.RpcLogic___ReceiveMessageChain_3949292778(m, npcID, initialDelay, notify);
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x00086EED File Offset: 0x000850ED
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendResponse(int responseIndex, string npcID)
		{
			this.RpcWriter___Server_SendResponse_2801973956(responseIndex, npcID);
			this.RpcLogic___SendResponse_2801973956(responseIndex, npcID);
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x00086F0C File Offset: 0x0008510C
		[ObserversRpc(RunLocally = true)]
		private void ReceiveResponse(int responseIndex, string npcID)
		{
			this.RpcWriter___Observers_ReceiveResponse_2801973956(responseIndex, npcID);
			this.RpcLogic___ReceiveResponse_2801973956(responseIndex, npcID);
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x00086F35 File Offset: 0x00085135
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPlayerMessage(int sendableIndex, int sentIndex, string npcID)
		{
			this.RpcWriter___Server_SendPlayerMessage_1952281135(sendableIndex, sentIndex, npcID);
			this.RpcLogic___SendPlayerMessage_1952281135(sendableIndex, sentIndex, npcID);
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x00086F5C File Offset: 0x0008515C
		[ObserversRpc(RunLocally = true)]
		private void ReceivePlayerMessage(int sendableIndex, int sentIndex, string npcID)
		{
			this.RpcWriter___Observers_ReceivePlayerMessage_1952281135(sendableIndex, sentIndex, npcID);
			this.RpcLogic___ReceivePlayerMessage_1952281135(sendableIndex, sentIndex, npcID);
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x00086F90 File Offset: 0x00085190
		[TargetRpc]
		private void ReceiveMSGConversationData(NetworkConnection conn, string npcID, MSGConversationData data)
		{
			this.RpcWriter___Target_ReceiveMSGConversationData_2662241369(conn, npcID, data);
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x00086FAF File Offset: 0x000851AF
		[ServerRpc(RequireOwnership = false)]
		public void ClearResponses(string npcID)
		{
			this.RpcWriter___Server_ClearResponses_3615296227(npcID);
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x00086FBC File Offset: 0x000851BC
		[ObserversRpc]
		private void ReceiveClearResponses(string npcID)
		{
			this.RpcWriter___Observers_ReceiveClearResponses_3615296227(npcID);
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x00086FD3 File Offset: 0x000851D3
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void ShowResponses(string npcID, List<Response> responses, float delay)
		{
			this.RpcWriter___Server_ShowResponses_995803534(npcID, responses, delay);
			this.RpcLogic___ShowResponses_995803534(npcID, responses, delay);
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x00086FFC File Offset: 0x000851FC
		[ObserversRpc(RunLocally = true)]
		private void ReceiveShowResponses(string npcID, List<Response> responses, float delay)
		{
			this.RpcWriter___Observers_ReceiveShowResponses_995803534(npcID, responses, delay);
			this.RpcLogic___ReceiveShowResponses_995803534(npcID, responses, delay);
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x00087040 File Offset: 0x00085240
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Messaging.MessagingManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Messaging.MessagingManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendMessage_2134336246));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveMessage_2134336246));
			base.RegisterServerRpc(2U, new ServerRpcDelegate(this.RpcReader___Server_SendMessageChain_3949292778));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveMessageChain_3949292778));
			base.RegisterServerRpc(4U, new ServerRpcDelegate(this.RpcReader___Server_SendResponse_2801973956));
			base.RegisterObserversRpc(5U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveResponse_2801973956));
			base.RegisterServerRpc(6U, new ServerRpcDelegate(this.RpcReader___Server_SendPlayerMessage_1952281135));
			base.RegisterObserversRpc(7U, new ClientRpcDelegate(this.RpcReader___Observers_ReceivePlayerMessage_1952281135));
			base.RegisterTargetRpc(8U, new ClientRpcDelegate(this.RpcReader___Target_ReceiveMSGConversationData_2662241369));
			base.RegisterServerRpc(9U, new ServerRpcDelegate(this.RpcReader___Server_ClearResponses_3615296227));
			base.RegisterObserversRpc(10U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveClearResponses_3615296227));
			base.RegisterServerRpc(11U, new ServerRpcDelegate(this.RpcReader___Server_ShowResponses_995803534));
			base.RegisterObserversRpc(12U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveShowResponses_995803534));
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x0008718F File Offset: 0x0008538F
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Messaging.MessagingManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Messaging.MessagingManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x000871A8 File Offset: 0x000853A8
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x000871B8 File Offset: 0x000853B8
		private void RpcWriter___Server_SendMessage_2134336246(Message m, bool notify, string npcID)
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
			writer.Write___ScheduleOne.Messaging.MessageFishNet.Serializing.Generated(m);
			writer.WriteBoolean(notify);
			writer.WriteString(npcID);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x00087279 File Offset: 0x00085479
		public void RpcLogic___SendMessage_2134336246(Message m, bool notify, string npcID)
		{
			this.ReceiveMessage(m, notify, npcID);
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x00087284 File Offset: 0x00085484
		private void RpcReader___Server_SendMessage_2134336246(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			Message m = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Messaging.MessageFishNet.Serializing.Generateds(PooledReader0);
			bool notify = PooledReader0.ReadBoolean();
			string npcID = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendMessage_2134336246(m, notify, npcID);
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x000872E4 File Offset: 0x000854E4
		private void RpcWriter___Observers_ReceiveMessage_2134336246(Message m, bool notify, string npcID)
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
			writer.Write___ScheduleOne.Messaging.MessageFishNet.Serializing.Generated(m);
			writer.WriteBoolean(notify);
			writer.WriteString(npcID);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x000873B4 File Offset: 0x000855B4
		private void RpcLogic___ReceiveMessage_2134336246(Message m, bool notify, string npcID)
		{
			NPC npc = NPCManager.GetNPC(npcID);
			if (npc == null)
			{
				Console.LogError("NPC not found with ID " + npcID, null);
				return;
			}
			this.ConversationMap[npc].SendMessage(m, notify, false);
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x000873F8 File Offset: 0x000855F8
		private void RpcReader___Observers_ReceiveMessage_2134336246(PooledReader PooledReader0, Channel channel)
		{
			Message m = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Messaging.MessageFishNet.Serializing.Generateds(PooledReader0);
			bool notify = PooledReader0.ReadBoolean();
			string npcID = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ReceiveMessage_2134336246(m, notify, npcID);
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x00087458 File Offset: 0x00085658
		private void RpcWriter___Server_SendMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
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
			writer.Write___ScheduleOne.UI.Phone.Messages.MessageChainFishNet.Serializing.Generated(m);
			writer.WriteString(npcID);
			writer.WriteSingle(initialDelay, AutoPackType.Unpacked);
			writer.WriteBoolean(notify);
			base.SendServerRpc(2U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x0008752B File Offset: 0x0008572B
		public void RpcLogic___SendMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
			this.ReceiveMessageChain(m, npcID, initialDelay, notify);
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00087538 File Offset: 0x00085738
		private void RpcReader___Server_SendMessageChain_3949292778(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			MessageChain m = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.UI.Phone.Messages.MessageChainFishNet.Serializing.Generateds(PooledReader0);
			string npcID = PooledReader0.ReadString();
			float initialDelay = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			bool notify = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendMessageChain_3949292778(m, npcID, initialDelay, notify);
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x000875B0 File Offset: 0x000857B0
		private void RpcWriter___Observers_ReceiveMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
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
			writer.Write___ScheduleOne.UI.Phone.Messages.MessageChainFishNet.Serializing.Generated(m);
			writer.WriteString(npcID);
			writer.WriteSingle(initialDelay, AutoPackType.Unpacked);
			writer.WriteBoolean(notify);
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x00087694 File Offset: 0x00085894
		private void RpcLogic___ReceiveMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
			NPC npc = NPCManager.GetNPC(npcID);
			if (npc == null)
			{
				Console.LogError("NPC not found with ID " + npcID, null);
				return;
			}
			this.ConversationMap[npc].SendMessageChain(m, initialDelay, notify, false);
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x000876DC File Offset: 0x000858DC
		private void RpcReader___Observers_ReceiveMessageChain_3949292778(PooledReader PooledReader0, Channel channel)
		{
			MessageChain m = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.UI.Phone.Messages.MessageChainFishNet.Serializing.Generateds(PooledReader0);
			string npcID = PooledReader0.ReadString();
			float initialDelay = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			bool notify = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ReceiveMessageChain_3949292778(m, npcID, initialDelay, notify);
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x00087750 File Offset: 0x00085950
		private void RpcWriter___Server_SendResponse_2801973956(int responseIndex, string npcID)
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
			writer.WriteInt32(responseIndex, AutoPackType.Packed);
			writer.WriteString(npcID);
			base.SendServerRpc(4U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x00087809 File Offset: 0x00085A09
		public void RpcLogic___SendResponse_2801973956(int responseIndex, string npcID)
		{
			this.ReceiveResponse(responseIndex, npcID);
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x00087814 File Offset: 0x00085A14
		private void RpcReader___Server_SendResponse_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int responseIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			string npcID = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendResponse_2801973956(responseIndex, npcID);
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x00087868 File Offset: 0x00085A68
		private void RpcWriter___Observers_ReceiveResponse_2801973956(int responseIndex, string npcID)
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
			writer.WriteInt32(responseIndex, AutoPackType.Packed);
			writer.WriteString(npcID);
			base.SendObserversRpc(5U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x00087930 File Offset: 0x00085B30
		private void RpcLogic___ReceiveResponse_2801973956(int responseIndex, string npcID)
		{
			NPC npc = NPCManager.GetNPC(npcID);
			if (npc == null)
			{
				Console.LogError("NPC not found with ID " + npcID, null);
				return;
			}
			MSGConversation msgconversation = this.ConversationMap[npc];
			if (msgconversation.currentResponses.Count <= responseIndex)
			{
				Console.LogWarning("Response index out of range for " + npc.fullName, null);
				return;
			}
			msgconversation.ResponseChosen(msgconversation.currentResponses[responseIndex], false);
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x000879A4 File Offset: 0x00085BA4
		private void RpcReader___Observers_ReceiveResponse_2801973956(PooledReader PooledReader0, Channel channel)
		{
			int responseIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			string npcID = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ReceiveResponse_2801973956(responseIndex, npcID);
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x000879F8 File Offset: 0x00085BF8
		private void RpcWriter___Server_SendPlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
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
			writer.WriteInt32(sendableIndex, AutoPackType.Packed);
			writer.WriteInt32(sentIndex, AutoPackType.Packed);
			writer.WriteString(npcID);
			base.SendServerRpc(6U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x00087AC3 File Offset: 0x00085CC3
		public void RpcLogic___SendPlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
			this.ReceivePlayerMessage(sendableIndex, sentIndex, npcID);
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x00087AD0 File Offset: 0x00085CD0
		private void RpcReader___Server_SendPlayerMessage_1952281135(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int sendableIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			int sentIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			string npcID = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendPlayerMessage_1952281135(sendableIndex, sentIndex, npcID);
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x00087B3C File Offset: 0x00085D3C
		private void RpcWriter___Observers_ReceivePlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
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
			writer.WriteInt32(sendableIndex, AutoPackType.Packed);
			writer.WriteInt32(sentIndex, AutoPackType.Packed);
			writer.WriteString(npcID);
			base.SendObserversRpc(7U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x00087C18 File Offset: 0x00085E18
		private void RpcLogic___ReceivePlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
			NPC npc = NPCManager.GetNPC(npcID);
			if (npc == null)
			{
				Console.LogError("NPC not found with ID " + npcID, null);
				return;
			}
			this.ConversationMap[npc].SendPlayerMessage(sendableIndex, sentIndex, false);
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x00087C5C File Offset: 0x00085E5C
		private void RpcReader___Observers_ReceivePlayerMessage_1952281135(PooledReader PooledReader0, Channel channel)
		{
			int sendableIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			int sentIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			string npcID = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ReceivePlayerMessage_1952281135(sendableIndex, sentIndex, npcID);
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x00087CC4 File Offset: 0x00085EC4
		private void RpcWriter___Target_ReceiveMSGConversationData_2662241369(NetworkConnection conn, string npcID, MSGConversationData data)
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
			writer.WriteString(npcID);
			writer.Write___ScheduleOne.Persistence.Datas.MSGConversationDataFishNet.Serializing.Generated(data);
			base.SendTargetRpc(8U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x00087D88 File Offset: 0x00085F88
		private void RpcLogic___ReceiveMSGConversationData_2662241369(NetworkConnection conn, string npcID, MSGConversationData data)
		{
			NPC npc = NPCManager.GetNPC(npcID);
			if (npc == null)
			{
				Console.LogError("NPC not found with ID " + npcID, null);
				return;
			}
			this.ConversationMap[npc].Load(data);
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x00087DCC File Offset: 0x00085FCC
		private void RpcReader___Target_ReceiveMSGConversationData_2662241369(PooledReader PooledReader0, Channel channel)
		{
			string npcID = PooledReader0.ReadString();
			MSGConversationData data = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.MSGConversationDataFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveMSGConversationData_2662241369(base.LocalConnection, npcID, data);
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x00087E14 File Offset: 0x00086014
		private void RpcWriter___Server_ClearResponses_3615296227(string npcID)
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
			writer.WriteString(npcID);
			base.SendServerRpc(9U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x00087EBB File Offset: 0x000860BB
		public void RpcLogic___ClearResponses_3615296227(string npcID)
		{
			this.ReceiveClearResponses(npcID);
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x00087EC4 File Offset: 0x000860C4
		private void RpcReader___Server_ClearResponses_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string npcID = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___ClearResponses_3615296227(npcID);
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x00087EF8 File Offset: 0x000860F8
		private void RpcWriter___Observers_ReceiveClearResponses_3615296227(string npcID)
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
			writer.WriteString(npcID);
			base.SendObserversRpc(10U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x00087FB0 File Offset: 0x000861B0
		private void RpcLogic___ReceiveClearResponses_3615296227(string npcID)
		{
			NPC npc = NPCManager.GetNPC(npcID);
			if (npc == null)
			{
				Console.LogError("NPC not found with ID " + npcID, null);
				return;
			}
			this.ConversationMap[npc].ClearResponses(false);
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x00087FF4 File Offset: 0x000861F4
		private void RpcReader___Observers_ReceiveClearResponses_3615296227(PooledReader PooledReader0, Channel channel)
		{
			string npcID = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveClearResponses_3615296227(npcID);
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x00088028 File Offset: 0x00086228
		private void RpcWriter___Server_ShowResponses_995803534(string npcID, List<Response> responses, float delay)
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
			writer.WriteString(npcID);
			writer.Write___System.Collections.Generic.List`1<ScheduleOne.Messaging.Response>FishNet.Serializing.Generated(responses);
			writer.WriteSingle(delay, AutoPackType.Unpacked);
			base.SendServerRpc(11U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x000880EE File Offset: 0x000862EE
		public void RpcLogic___ShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
			this.ReceiveShowResponses(npcID, responses, delay);
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x000880FC File Offset: 0x000862FC
		private void RpcReader___Server_ShowResponses_995803534(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string npcID = PooledReader0.ReadString();
			List<Response> responses = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<ScheduleOne.Messaging.Response>FishNet.Serializing.Generateds(PooledReader0);
			float delay = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___ShowResponses_995803534(npcID, responses, delay);
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x00088164 File Offset: 0x00086364
		private void RpcWriter___Observers_ReceiveShowResponses_995803534(string npcID, List<Response> responses, float delay)
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
			writer.WriteString(npcID);
			writer.Write___System.Collections.Generic.List`1<ScheduleOne.Messaging.Response>FishNet.Serializing.Generated(responses);
			writer.WriteSingle(delay, AutoPackType.Unpacked);
			base.SendObserversRpc(12U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x0008823C File Offset: 0x0008643C
		private void RpcLogic___ReceiveShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
			NPC npc = NPCManager.GetNPC(npcID);
			if (npc == null)
			{
				Console.LogError("NPC not found with ID " + npcID, null);
				return;
			}
			this.ConversationMap[npc].ShowResponses(responses, delay, false);
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x00088280 File Offset: 0x00086480
		private void RpcReader___Observers_ReceiveShowResponses_995803534(PooledReader PooledReader0, Channel channel)
		{
			string npcID = PooledReader0.ReadString();
			List<Response> responses = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<ScheduleOne.Messaging.Response>FishNet.Serializing.Generateds(PooledReader0);
			float delay = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ReceiveShowResponses_995803534(npcID, responses, delay);
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x000882E2 File Offset: 0x000864E2
		protected virtual void dll()
		{
			base.Awake();
		}

		// Token: 0x0400195E RID: 6494
		protected Dictionary<NPC, MSGConversation> ConversationMap = new Dictionary<NPC, MSGConversation>();

		// Token: 0x0400195F RID: 6495
		private bool dll_Excuted;

		// Token: 0x04001960 RID: 6496
		private bool dll_Excuted;
	}
}
