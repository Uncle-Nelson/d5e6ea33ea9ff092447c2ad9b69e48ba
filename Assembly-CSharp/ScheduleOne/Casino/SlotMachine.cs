using System;
using EasyButtons;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Casino
{
	// Token: 0x0200076E RID: 1902
	public class SlotMachine : NetworkBehaviour
	{
		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x060033E1 RID: 13281 RVA: 0x000D86EB File Offset: 0x000D68EB
		// (set) Token: 0x060033E2 RID: 13282 RVA: 0x000D86F3 File Offset: 0x000D68F3
		public bool IsSpinning { get; private set; }

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x060033E3 RID: 13283 RVA: 0x000D86FC File Offset: 0x000D68FC
		private int currentBetAmount
		{
			get
			{
				return SlotMachine.BetAmounts[this.currentBetIndex];
			}
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x000D870C File Offset: 0x000D690C
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Casino.SlotMachine_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x000D872B File Offset: 0x000D692B
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (this.currentBetIndex != 1)
			{
				this.SetBetIndex(connection, this.currentBetIndex);
			}
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x000D874A File Offset: 0x000D694A
		private void DownHovered()
		{
			if (this.IsSpinning)
			{
				this.DownButton.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				return;
			}
			this.DownButton.SetInteractableState(InteractableObject.EInteractableState.Default);
			this.DownButton.SetMessage("Decrease bet");
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x000D877D File Offset: 0x000D697D
		private void DownInteracted()
		{
			if (this.onDownPressed != null)
			{
				this.onDownPressed.Invoke();
			}
			this.SendBetIndex(this.currentBetIndex - 1);
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x000D87A0 File Offset: 0x000D69A0
		private void UpHovered()
		{
			if (this.IsSpinning)
			{
				this.UpButton.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				return;
			}
			this.UpButton.SetInteractableState(InteractableObject.EInteractableState.Default);
			this.UpButton.SetMessage("Increase bet");
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x000D87D3 File Offset: 0x000D69D3
		private void UpInteracted()
		{
			if (this.onUpPressed != null)
			{
				this.onUpPressed.Invoke();
			}
			this.SendBetIndex(this.currentBetIndex + 1);
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x000D87F8 File Offset: 0x000D69F8
		private void HandleHovered()
		{
			if (this.IsSpinning)
			{
				this.HandleIntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				return;
			}
			int currentBetAmount = this.currentBetAmount;
			if (NetworkSingleton<MoneyManager>.Instance.cashBalance < (float)currentBetAmount)
			{
				this.HandleIntObj.SetInteractableState(InteractableObject.EInteractableState.Invalid);
				this.HandleIntObj.SetMessage("Insufficient cash");
				return;
			}
			this.HandleIntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
			this.HandleIntObj.SetMessage("Pull handle");
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x000D8868 File Offset: 0x000D6A68
		[Button]
		public void HandleInteracted()
		{
			if (this.IsSpinning)
			{
				return;
			}
			if (this.onHandlePulled != null)
			{
				this.onHandlePulled.Invoke();
			}
			NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance((float)(-(float)this.currentBetAmount), true, false);
			this.SendStartSpin(Player.Local.LocalConnection, this.currentBetAmount);
		}

		// Token: 0x060033EC RID: 13292 RVA: 0x000D88BB File Offset: 0x000D6ABB
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendBetIndex(int index)
		{
			this.RpcWriter___Server_SendBetIndex_3316948804(index);
			this.RpcLogic___SendBetIndex_3316948804(index);
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x000D88D1 File Offset: 0x000D6AD1
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetBetIndex(NetworkConnection conn, int index)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetBetIndex_2681120339(conn, index);
				this.RpcLogic___SetBetIndex_2681120339(conn, index);
			}
			else
			{
				this.RpcWriter___Target_SetBetIndex_2681120339(conn, index);
			}
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x000D8908 File Offset: 0x000D6B08
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendStartSpin(NetworkConnection spinner, int betAmount)
		{
			this.RpcWriter___Server_SendStartSpin_2681120339(spinner, betAmount);
			this.RpcLogic___SendStartSpin_2681120339(spinner, betAmount);
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x000D8934 File Offset: 0x000D6B34
		[ObserversRpc(RunLocally = true)]
		public void StartSpin(NetworkConnection spinner, SlotMachine.ESymbol[] symbols, int betAmount)
		{
			this.RpcWriter___Observers_StartSpin_2659526290(spinner, symbols, betAmount);
			this.RpcLogic___StartSpin_2659526290(spinner, symbols, betAmount);
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x000D8965 File Offset: 0x000D6B65
		private SlotMachine.EOutcome EvaluateOutcome(SlotMachine.ESymbol[] outcome)
		{
			if (this.IsUniform(outcome))
			{
				if (outcome[0] == SlotMachine.ESymbol.Seven)
				{
					return SlotMachine.EOutcome.Jackpot;
				}
				if (outcome[0] == SlotMachine.ESymbol.Bell)
				{
					return SlotMachine.EOutcome.BigWin;
				}
				if (this.IsFruit(outcome[0]))
				{
					return SlotMachine.EOutcome.SmallWin;
				}
			}
			if (this.IsAllFruit(outcome))
			{
				return SlotMachine.EOutcome.MiniWin;
			}
			return SlotMachine.EOutcome.NoWin;
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x000D8999 File Offset: 0x000D6B99
		private int GetWinAmount(SlotMachine.EOutcome outcome, int betAmount)
		{
			switch (outcome)
			{
			case SlotMachine.EOutcome.Jackpot:
				return betAmount * 100;
			case SlotMachine.EOutcome.BigWin:
				return betAmount * 25;
			case SlotMachine.EOutcome.SmallWin:
				return betAmount * 10;
			case SlotMachine.EOutcome.MiniWin:
				return betAmount * 2;
			default:
				return 0;
			}
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x000D89C8 File Offset: 0x000D6BC8
		private void DisplayOutcome(SlotMachine.EOutcome outcome, int winAmount)
		{
			TextMeshProUGUI[] winAmountLabels = this.WinAmountLabels;
			for (int i = 0; i < winAmountLabels.Length; i++)
			{
				winAmountLabels[i].text = MoneyManager.FormatAmount((float)winAmount, false, false);
			}
			if (outcome == SlotMachine.EOutcome.Jackpot)
			{
				this.ScreenAnimation.Play(this.JackpotAnimation.name);
				ParticleSystem[] jackpotParticles = this.JackpotParticles;
				for (int i = 0; i < jackpotParticles.Length; i++)
				{
					jackpotParticles[i].Play();
				}
				return;
			}
			if (outcome == SlotMachine.EOutcome.BigWin)
			{
				this.ScreenAnimation.Play(this.BigWinAnimation.name);
				this.BigWinSound.Play();
				return;
			}
			if (outcome == SlotMachine.EOutcome.SmallWin)
			{
				this.ScreenAnimation.Play(this.SmallWinAnimation.name);
				this.SmallWinSound.Play();
				return;
			}
			if (outcome == SlotMachine.EOutcome.MiniWin)
			{
				this.ScreenAnimation.Play(this.MiniWinAnimation.name);
				this.MiniWinSound.Play();
			}
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x000D8AA7 File Offset: 0x000D6CA7
		public static SlotMachine.ESymbol GetRandomSymbol()
		{
			if (Application.isEditor)
			{
				return SlotMachine.ESymbol.Seven;
			}
			return (SlotMachine.ESymbol)Random.Range(0, Enum.GetValues(typeof(SlotMachine.ESymbol)).Length);
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x000D8ACC File Offset: 0x000D6CCC
		private bool IsFruit(SlotMachine.ESymbol symbol)
		{
			return symbol == SlotMachine.ESymbol.Cherry || symbol == SlotMachine.ESymbol.Lemon || symbol == SlotMachine.ESymbol.Grape || symbol == SlotMachine.ESymbol.Watermelon;
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x000D8AE0 File Offset: 0x000D6CE0
		private bool IsAllFruit(SlotMachine.ESymbol[] symbols)
		{
			for (int i = 0; i < symbols.Length; i++)
			{
				if (!this.IsFruit(symbols[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x000D8B0C File Offset: 0x000D6D0C
		private bool IsUniform(SlotMachine.ESymbol[] symbols)
		{
			for (int i = 1; i < symbols.Length; i++)
			{
				if (symbols[i] != symbols[i - 1])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x000D8B34 File Offset: 0x000D6D34
		[Button]
		public void SimulateMany()
		{
			int num = 100;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			for (int i = 0; i < num; i++)
			{
				num2--;
				SlotMachine.ESymbol[] array = new SlotMachine.ESymbol[this.Reels.Length];
				for (int j = 0; j < this.Reels.Length; j++)
				{
					array[j] = SlotMachine.GetRandomSymbol();
				}
				SlotMachine.EOutcome eoutcome = this.EvaluateOutcome(array);
				if (eoutcome == SlotMachine.EOutcome.MiniWin)
				{
					num4++;
				}
				if (eoutcome == SlotMachine.EOutcome.SmallWin)
				{
					num3++;
				}
				if (eoutcome == SlotMachine.EOutcome.BigWin)
				{
					num5++;
				}
				if (eoutcome == SlotMachine.EOutcome.Jackpot)
				{
					num6++;
				}
				int winAmount = this.GetWinAmount(eoutcome, 1);
				num2 += winAmount;
			}
			Console.Log("Simulated " + num.ToString() + " spins. Net win: " + num2.ToString(), null);
			Console.Log(string.Concat(new string[]
			{
				"Mini wins: ",
				num4.ToString(),
				" Small wins: ",
				num3.ToString(),
				" Big wins: ",
				num5.ToString(),
				" Jackpots: ",
				num6.ToString()
			}), null);
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x000D8C78 File Offset: 0x000D6E78
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Casino.SlotMachineAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Casino.SlotMachineAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendBetIndex_3316948804));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_SetBetIndex_2681120339));
			base.RegisterTargetRpc(2U, new ClientRpcDelegate(this.RpcReader___Target_SetBetIndex_2681120339));
			base.RegisterServerRpc(3U, new ServerRpcDelegate(this.RpcReader___Server_SendStartSpin_2681120339));
			base.RegisterObserversRpc(4U, new ClientRpcDelegate(this.RpcReader___Observers_StartSpin_2659526290));
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x000D8D09 File Offset: 0x000D6F09
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Casino.SlotMachineAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Casino.SlotMachineAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x000D8D1C File Offset: 0x000D6F1C
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x000D8D2C File Offset: 0x000D6F2C
		private void RpcWriter___Server_SendBetIndex_3316948804(int index)
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
			writer.WriteInt32(index, AutoPackType.Packed);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x000D8DD8 File Offset: 0x000D6FD8
		private void RpcLogic___SendBetIndex_3316948804(int index)
		{
			this.SetBetIndex(null, index);
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x000D8DE4 File Offset: 0x000D6FE4
		private void RpcReader___Server_SendBetIndex_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int index = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendBetIndex_3316948804(index);
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x000D8E28 File Offset: 0x000D7028
		private void RpcWriter___Observers_SetBetIndex_2681120339(NetworkConnection conn, int index)
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
			writer.WriteInt32(index, AutoPackType.Packed);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x000D8EE3 File Offset: 0x000D70E3
		public void RpcLogic___SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
			this.currentBetIndex = Mathf.Clamp(index, 0, SlotMachine.BetAmounts.Length - 1);
			this.BetAmountLabel.text = MoneyManager.FormatAmount((float)this.currentBetAmount, false, false);
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x000D8F14 File Offset: 0x000D7114
		private void RpcReader___Observers_SetBetIndex_2681120339(PooledReader PooledReader0, Channel channel)
		{
			int index = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetBetIndex_2681120339(null, index);
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x000D8F58 File Offset: 0x000D7158
		private void RpcWriter___Target_SetBetIndex_2681120339(NetworkConnection conn, int index)
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
			writer.WriteInt32(index, AutoPackType.Packed);
			base.SendTargetRpc(2U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x000D9014 File Offset: 0x000D7214
		private void RpcReader___Target_SetBetIndex_2681120339(PooledReader PooledReader0, Channel channel)
		{
			int index = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetBetIndex_2681120339(base.LocalConnection, index);
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x000D9050 File Offset: 0x000D7250
		private void RpcWriter___Server_SendStartSpin_2681120339(NetworkConnection spinner, int betAmount)
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
			writer.WriteNetworkConnection(spinner);
			writer.WriteInt32(betAmount, AutoPackType.Packed);
			base.SendServerRpc(3U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x000D910C File Offset: 0x000D730C
		public void RpcLogic___SendStartSpin_2681120339(NetworkConnection spinner, int betAmount)
		{
			SlotMachine.ESymbol[] array = new SlotMachine.ESymbol[this.Reels.Length];
			for (int i = 0; i < this.Reels.Length; i++)
			{
				array[i] = SlotMachine.GetRandomSymbol();
			}
			this.StartSpin(spinner, array, betAmount);
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x000D914C File Offset: 0x000D734C
		private void RpcReader___Server_SendStartSpin_2681120339(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkConnection spinner = PooledReader0.ReadNetworkConnection();
			int betAmount = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendStartSpin_2681120339(spinner, betAmount);
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x000D91A0 File Offset: 0x000D73A0
		private void RpcWriter___Observers_StartSpin_2659526290(NetworkConnection spinner, SlotMachine.ESymbol[] symbols, int betAmount)
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
			writer.WriteNetworkConnection(spinner);
			writer.Write___ScheduleOne.Casino.SlotMachine/ESymbol[]FishNet.Serializing.Generated(symbols);
			writer.WriteInt32(betAmount, AutoPackType.Packed);
			base.SendObserversRpc(4U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x000D9278 File Offset: 0x000D7478
		public void RpcLogic___StartSpin_2659526290(NetworkConnection spinner, SlotMachine.ESymbol[] symbols, int betAmount)
		{
			SlotMachine.<>c__DisplayClass41_0 CS$<>8__locals1 = new SlotMachine.<>c__DisplayClass41_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.symbols = symbols;
			CS$<>8__locals1.betAmount = betAmount;
			CS$<>8__locals1.spinner = spinner;
			if (this.IsSpinning)
			{
				return;
			}
			this.IsSpinning = true;
			Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<StartSpin>g__Spin|0());
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x000D92C8 File Offset: 0x000D74C8
		private void RpcReader___Observers_StartSpin_2659526290(PooledReader PooledReader0, Channel channel)
		{
			NetworkConnection spinner = PooledReader0.ReadNetworkConnection();
			SlotMachine.ESymbol[] symbols = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Casino.SlotMachine/ESymbol[]FishNet.Serializing.Generateds(PooledReader0);
			int betAmount = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___StartSpin_2659526290(spinner, symbols, betAmount);
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x000D932C File Offset: 0x000D752C
		private void dll()
		{
			this.DownButton.onHovered.AddListener(new UnityAction(this.DownHovered));
			this.DownButton.onInteractStart.AddListener(new UnityAction(this.DownInteracted));
			this.UpButton.onHovered.AddListener(new UnityAction(this.UpHovered));
			this.UpButton.onInteractStart.AddListener(new UnityAction(this.UpInteracted));
			this.HandleIntObj.onHovered.AddListener(new UnityAction(this.HandleHovered));
			this.HandleIntObj.onInteractStart.AddListener(new UnityAction(this.HandleInteracted));
			this.SetBetIndex(null, this.currentBetIndex);
		}

		// Token: 0x040024F3 RID: 9459
		public static int[] BetAmounts = new int[]
		{
			5,
			10,
			25,
			50,
			100
		};

		// Token: 0x040024F5 RID: 9461
		[Header("References")]
		public InteractableObject DownButton;

		// Token: 0x040024F6 RID: 9462
		public InteractableObject UpButton;

		// Token: 0x040024F7 RID: 9463
		public InteractableObject HandleIntObj;

		// Token: 0x040024F8 RID: 9464
		public TextMeshPro BetAmountLabel;

		// Token: 0x040024F9 RID: 9465
		public SlotReel[] Reels;

		// Token: 0x040024FA RID: 9466
		public AudioSourceController SpinLoop;

		// Token: 0x040024FB RID: 9467
		public Animation ScreenAnimation;

		// Token: 0x040024FC RID: 9468
		public ParticleSystem[] JackpotParticles;

		// Token: 0x040024FD RID: 9469
		[Header("Win Animations")]
		public TextMeshProUGUI[] WinAmountLabels;

		// Token: 0x040024FE RID: 9470
		public AnimationClip MiniWinAnimation;

		// Token: 0x040024FF RID: 9471
		public AnimationClip SmallWinAnimation;

		// Token: 0x04002500 RID: 9472
		public AnimationClip BigWinAnimation;

		// Token: 0x04002501 RID: 9473
		public AnimationClip JackpotAnimation;

		// Token: 0x04002502 RID: 9474
		public AudioSourceController MiniWinSound;

		// Token: 0x04002503 RID: 9475
		public AudioSourceController SmallWinSound;

		// Token: 0x04002504 RID: 9476
		public AudioSourceController BigWinSound;

		// Token: 0x04002505 RID: 9477
		public AudioSourceController JackpotSound;

		// Token: 0x04002506 RID: 9478
		public UnityEvent onDownPressed;

		// Token: 0x04002507 RID: 9479
		public UnityEvent onUpPressed;

		// Token: 0x04002508 RID: 9480
		public UnityEvent onHandlePulled;

		// Token: 0x04002509 RID: 9481
		private int currentBetIndex = 1;

		// Token: 0x0400250A RID: 9482
		private bool dll_Excuted;

		// Token: 0x0400250B RID: 9483
		private bool dll_Excuted;

		// Token: 0x0200076F RID: 1903
		public enum ESymbol
		{
			// Token: 0x0400250D RID: 9485
			Cherry,
			// Token: 0x0400250E RID: 9486
			Lemon,
			// Token: 0x0400250F RID: 9487
			Grape,
			// Token: 0x04002510 RID: 9488
			Watermelon,
			// Token: 0x04002511 RID: 9489
			Bell,
			// Token: 0x04002512 RID: 9490
			Seven
		}

		// Token: 0x02000770 RID: 1904
		public enum EOutcome
		{
			// Token: 0x04002514 RID: 9492
			Jackpot,
			// Token: 0x04002515 RID: 9493
			BigWin,
			// Token: 0x04002516 RID: 9494
			SmallWin,
			// Token: 0x04002517 RID: 9495
			MiniWin,
			// Token: 0x04002518 RID: 9496
			NoWin
		}
	}
}
