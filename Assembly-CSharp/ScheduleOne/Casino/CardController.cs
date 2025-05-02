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
using UnityEngine;

namespace ScheduleOne.Casino
{
	// Token: 0x0200075A RID: 1882
	public class CardController : NetworkBehaviour
	{
		// Token: 0x060032F2 RID: 13042 RVA: 0x000D4328 File Offset: 0x000D2528
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Casino.CardController_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x000D4347 File Offset: 0x000D2547
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCardValue(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			this.RpcWriter___Server_SendCardValue_3709737967(cardId, suit, value);
			this.RpcLogic___SendCardValue_3709737967(cardId, suit, value);
		}

		// Token: 0x060032F4 RID: 13044 RVA: 0x000D4370 File Offset: 0x000D2570
		[ObserversRpc(RunLocally = true)]
		private void SetCardValue(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			this.RpcWriter___Observers_SetCardValue_3709737967(cardId, suit, value);
			this.RpcLogic___SetCardValue_3709737967(cardId, suit, value);
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x000D43A1 File Offset: 0x000D25A1
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCardFaceUp(string cardId, bool faceUp)
		{
			this.RpcWriter___Server_SendCardFaceUp_310431262(cardId, faceUp);
			this.RpcLogic___SendCardFaceUp_310431262(cardId, faceUp);
		}

		// Token: 0x060032F6 RID: 13046 RVA: 0x000D43C0 File Offset: 0x000D25C0
		[ObserversRpc(RunLocally = true)]
		private void SetCardFaceUp(string cardId, bool faceUp)
		{
			this.RpcWriter___Observers_SetCardFaceUp_310431262(cardId, faceUp);
			this.RpcLogic___SetCardFaceUp_310431262(cardId, faceUp);
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x000D43E9 File Offset: 0x000D25E9
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCardGlide(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			this.RpcWriter___Server_SendCardGlide_2833372058(cardId, position, rotation, glideTime);
			this.RpcLogic___SendCardGlide_2833372058(cardId, position, rotation, glideTime);
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x000D4418 File Offset: 0x000D2618
		[ObserversRpc(RunLocally = true)]
		private void SetCardGlide(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			this.RpcWriter___Observers_SetCardGlide_2833372058(cardId, position, rotation, glideTime);
			this.RpcLogic___SetCardGlide_2833372058(cardId, position, rotation, glideTime);
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x000D4451 File Offset: 0x000D2651
		private PlayingCard GetCard(string cardId)
		{
			return this.cardDictionary[cardId];
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x000D4480 File Offset: 0x000D2680
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Casino.CardControllerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Casino.CardControllerAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendCardValue_3709737967));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_SetCardValue_3709737967));
			base.RegisterServerRpc(2U, new ServerRpcDelegate(this.RpcReader___Server_SendCardFaceUp_310431262));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_SetCardFaceUp_310431262));
			base.RegisterServerRpc(4U, new ServerRpcDelegate(this.RpcReader___Server_SendCardGlide_2833372058));
			base.RegisterObserversRpc(5U, new ClientRpcDelegate(this.RpcReader___Observers_SetCardGlide_2833372058));
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x000D4528 File Offset: 0x000D2728
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Casino.CardControllerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Casino.CardControllerAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x000D453B File Offset: 0x000D273B
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x000D454C File Offset: 0x000D274C
		private void RpcWriter___Server_SendCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
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
			writer.WriteString(cardId);
			writer.Write___ScheduleOne.Casino.PlayingCard/ECardSuitFishNet.Serializing.Generated(suit);
			writer.Write___ScheduleOne.Casino.PlayingCard/ECardValueFishNet.Serializing.Generated(value);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060032FF RID: 13055 RVA: 0x000D460D File Offset: 0x000D280D
		public void RpcLogic___SendCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			this.SetCardValue(cardId, suit, value);
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x000D4618 File Offset: 0x000D2818
		private void RpcReader___Server_SendCardValue_3709737967(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string cardId = PooledReader0.ReadString();
			PlayingCard.ECardSuit suit = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Casino.PlayingCard/ECardSuitFishNet.Serializing.Generateds(PooledReader0);
			PlayingCard.ECardValue value = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Casino.PlayingCard/ECardValueFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendCardValue_3709737967(cardId, suit, value);
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x000D4678 File Offset: 0x000D2878
		private void RpcWriter___Observers_SetCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
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
			writer.WriteString(cardId);
			writer.Write___ScheduleOne.Casino.PlayingCard/ECardSuitFishNet.Serializing.Generated(suit);
			writer.Write___ScheduleOne.Casino.PlayingCard/ECardValueFishNet.Serializing.Generated(value);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x000D4748 File Offset: 0x000D2948
		private void RpcLogic___SetCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			PlayingCard card = this.GetCard(cardId);
			if (card != null)
			{
				card.SetCard(suit, value, false);
			}
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x000D4770 File Offset: 0x000D2970
		private void RpcReader___Observers_SetCardValue_3709737967(PooledReader PooledReader0, Channel channel)
		{
			string cardId = PooledReader0.ReadString();
			PlayingCard.ECardSuit suit = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Casino.PlayingCard/ECardSuitFishNet.Serializing.Generateds(PooledReader0);
			PlayingCard.ECardValue value = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Casino.PlayingCard/ECardValueFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetCardValue_3709737967(cardId, suit, value);
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x000D47D0 File Offset: 0x000D29D0
		private void RpcWriter___Server_SendCardFaceUp_310431262(string cardId, bool faceUp)
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
			writer.WriteString(cardId);
			writer.WriteBoolean(faceUp);
			base.SendServerRpc(2U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003305 RID: 13061 RVA: 0x000D4884 File Offset: 0x000D2A84
		public void RpcLogic___SendCardFaceUp_310431262(string cardId, bool faceUp)
		{
			this.SetCardFaceUp(cardId, faceUp);
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x000D4890 File Offset: 0x000D2A90
		private void RpcReader___Server_SendCardFaceUp_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string cardId = PooledReader0.ReadString();
			bool faceUp = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendCardFaceUp_310431262(cardId, faceUp);
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x000D48E0 File Offset: 0x000D2AE0
		private void RpcWriter___Observers_SetCardFaceUp_310431262(string cardId, bool faceUp)
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
			writer.WriteString(cardId);
			writer.WriteBoolean(faceUp);
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x000D49A4 File Offset: 0x000D2BA4
		private void RpcLogic___SetCardFaceUp_310431262(string cardId, bool faceUp)
		{
			PlayingCard card = this.GetCard(cardId);
			if (card != null)
			{
				card.SetFaceUp(faceUp, false);
			}
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x000D49CC File Offset: 0x000D2BCC
		private void RpcReader___Observers_SetCardFaceUp_310431262(PooledReader PooledReader0, Channel channel)
		{
			string cardId = PooledReader0.ReadString();
			bool faceUp = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetCardFaceUp_310431262(cardId, faceUp);
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x000D4A18 File Offset: 0x000D2C18
		private void RpcWriter___Server_SendCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
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
			writer.WriteString(cardId);
			writer.WriteVector3(position);
			writer.WriteQuaternion(rotation, AutoPackType.Packed);
			writer.WriteSingle(glideTime, AutoPackType.Unpacked);
			base.SendServerRpc(4U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x000D4AF0 File Offset: 0x000D2CF0
		public void RpcLogic___SendCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			this.SetCardGlide(cardId, position, rotation, glideTime);
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x000D4B00 File Offset: 0x000D2D00
		private void RpcReader___Server_SendCardGlide_2833372058(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string cardId = PooledReader0.ReadString();
			Vector3 position = PooledReader0.ReadVector3();
			Quaternion rotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			float glideTime = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendCardGlide_2833372058(cardId, position, rotation, glideTime);
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x000D4B7C File Offset: 0x000D2D7C
		private void RpcWriter___Observers_SetCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
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
			writer.WriteString(cardId);
			writer.WriteVector3(position);
			writer.WriteQuaternion(rotation, AutoPackType.Packed);
			writer.WriteSingle(glideTime, AutoPackType.Unpacked);
			base.SendObserversRpc(5U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x000D4C64 File Offset: 0x000D2E64
		private void RpcLogic___SetCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			PlayingCard card = this.GetCard(cardId);
			if (card != null)
			{
				card.GlideTo(position, rotation, glideTime, false);
			}
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x000D4C90 File Offset: 0x000D2E90
		private void RpcReader___Observers_SetCardGlide_2833372058(PooledReader PooledReader0, Channel channel)
		{
			string cardId = PooledReader0.ReadString();
			Vector3 position = PooledReader0.ReadVector3();
			Quaternion rotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			float glideTime = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetCardGlide_2833372058(cardId, position, rotation, glideTime);
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x000D4D08 File Offset: 0x000D2F08
		private void dll()
		{
			this.cards = new List<PlayingCard>(base.GetComponentsInChildren<PlayingCard>());
			foreach (PlayingCard playingCard in this.cards)
			{
				playingCard.SetCardController(this);
				if (this.cardDictionary.ContainsKey(playingCard.CardID))
				{
					Debug.LogError("Card ID " + playingCard.CardID + " already exists in the dictionary.");
				}
				else
				{
					this.cardDictionary.Add(playingCard.CardID, playingCard);
				}
			}
		}

		// Token: 0x04002475 RID: 9333
		private List<PlayingCard> cards = new List<PlayingCard>();

		// Token: 0x04002476 RID: 9334
		private Dictionary<string, PlayingCard> cardDictionary = new Dictionary<string, PlayingCard>();

		// Token: 0x04002477 RID: 9335
		private bool dll_Excuted;

		// Token: 0x04002478 RID: 9336
		private bool dll_Excuted;
	}
}
