using System;
using System.Collections.Generic;
using System.Linq;
using FishNet;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x020009D0 RID: 2512
	public class DailySummary : NetworkSingleton<DailySummary>
	{
		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x060043C2 RID: 17346 RVA: 0x0011BE96 File Offset: 0x0011A096
		// (set) Token: 0x060043C3 RID: 17347 RVA: 0x0011BE9E File Offset: 0x0011A09E
		public bool IsOpen { get; private set; }

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x060043C4 RID: 17348 RVA: 0x0011BEA7 File Offset: 0x0011A0A7
		// (set) Token: 0x060043C5 RID: 17349 RVA: 0x0011BEAF File Offset: 0x0011A0AF
		public int xpGained { get; private set; }

		// Token: 0x060043C6 RID: 17350 RVA: 0x0011BEB8 File Offset: 0x0011A0B8
		protected override void Start()
		{
			base.Start();
			this.IsOpen = false;
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance._onSleepEnd.AddListener(new UnityAction(this.SleepEnd));
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x0011BF0C File Offset: 0x0011A10C
		public void Open()
		{
			DailySummary.<>c__DisplayClass21_0 CS$<>8__locals1 = new DailySummary.<>c__DisplayClass21_0();
			CS$<>8__locals1.<>4__this = this;
			this.IsOpen = true;
			this.TitleLabel.text = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.CurrentDay.ToString() + ", Day " + (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.ElapsedDays + 1).ToString();
			CS$<>8__locals1.items = this.itemsSoldByPlayer.Keys.ToArray<string>();
			for (int i = 0; i < this.ProductEntries.Length; i++)
			{
				if (i < CS$<>8__locals1.items.Length)
				{
					ItemDefinition item = Registry.GetItem(CS$<>8__locals1.items[i]);
					this.ProductEntries[i].Find("Quantity").GetComponent<TextMeshProUGUI>().text = this.itemsSoldByPlayer[CS$<>8__locals1.items[i]].ToString() + "x";
					this.ProductEntries[i].Find("Image").GetComponent<Image>().sprite = item.Icon;
					this.ProductEntries[i].Find("Name").GetComponent<TextMeshProUGUI>().text = item.Name;
					this.ProductEntries[i].gameObject.SetActive(true);
				}
				else
				{
					this.ProductEntries[i].gameObject.SetActive(false);
				}
			}
			this.PlayerEarningsLabel.text = MoneyManager.FormatAmount(this.moneyEarnedByPlayer, false, false);
			this.DealerEarningsLabel.text = MoneyManager.FormatAmount(this.moneyEarnedByDealers, false, false);
			this.XPGainedLabel.text = this.xpGained.ToString() + " XP";
			this.Anim.Play("Daily summary 1");
			this.Canvas.enabled = true;
			this.Container.gameObject.SetActive(true);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			base.StartCoroutine(CS$<>8__locals1.<Open>g__Wait|0());
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x0011C107 File Offset: 0x0011A307
		public void Close()
		{
			if (!this.IsOpen)
			{
				return;
			}
			this.IsOpen = false;
			this.Anim.Stop();
			this.Anim.Play("Daily summary close");
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x0011C145 File Offset: 0x0011A345
		private void SleepEnd()
		{
			this.ClearStats();
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x0011C150 File Offset: 0x0011A350
		[ObserversRpc]
		public void AddSoldItem(string id, int amount)
		{
			this.RpcWriter___Observers_AddSoldItem_3643459082(id, amount);
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x0011C16B File Offset: 0x0011A36B
		[ObserversRpc]
		public void AddPlayerMoney(float amount)
		{
			this.RpcWriter___Observers_AddPlayerMoney_431000436(amount);
		}

		// Token: 0x060043CC RID: 17356 RVA: 0x0011C177 File Offset: 0x0011A377
		[ObserversRpc]
		public void AddDealerMoney(float amount)
		{
			this.RpcWriter___Observers_AddDealerMoney_431000436(amount);
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x0011C183 File Offset: 0x0011A383
		[ObserversRpc]
		public void AddXP(int xp)
		{
			this.RpcWriter___Observers_AddXP_3316948804(xp);
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x0011C18F File Offset: 0x0011A38F
		private void ClearStats()
		{
			this.itemsSoldByPlayer.Clear();
			this.moneyEarnedByPlayer = 0f;
			this.moneyEarnedByDealers = 0f;
			this.xpGained = 0;
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x0011C1CC File Offset: 0x0011A3CC
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.UI.DailySummaryAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.UI.DailySummaryAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(0U, new ClientRpcDelegate(this.RpcReader___Observers_AddSoldItem_3643459082));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_AddPlayerMoney_431000436));
			base.RegisterObserversRpc(2U, new ClientRpcDelegate(this.RpcReader___Observers_AddDealerMoney_431000436));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_AddXP_3316948804));
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x0011C24C File Offset: 0x0011A44C
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.UI.DailySummaryAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.UI.DailySummaryAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x0011C265 File Offset: 0x0011A465
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x0011C274 File Offset: 0x0011A474
		private void RpcWriter___Observers_AddSoldItem_3643459082(string id, int amount)
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
			writer.WriteString(id);
			writer.WriteInt32(amount, AutoPackType.Packed);
			base.SendObserversRpc(0U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x0011C33C File Offset: 0x0011A53C
		public void RpcLogic___AddSoldItem_3643459082(string id, int amount)
		{
			if (this.itemsSoldByPlayer.ContainsKey(id))
			{
				Dictionary<string, int> dictionary = this.itemsSoldByPlayer;
				dictionary[id] += amount;
				return;
			}
			this.itemsSoldByPlayer.Add(id, amount);
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x0011C380 File Offset: 0x0011A580
		private void RpcReader___Observers_AddSoldItem_3643459082(PooledReader PooledReader0, Channel channel)
		{
			string id = PooledReader0.ReadString();
			int amount = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___AddSoldItem_3643459082(id, amount);
		}

		// Token: 0x060043D6 RID: 17366 RVA: 0x0011C3C8 File Offset: 0x0011A5C8
		private void RpcWriter___Observers_AddPlayerMoney_431000436(float amount)
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
			writer.WriteSingle(amount, AutoPackType.Unpacked);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x0011C483 File Offset: 0x0011A683
		public void RpcLogic___AddPlayerMoney_431000436(float amount)
		{
			this.moneyEarnedByPlayer += amount;
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x0011C494 File Offset: 0x0011A694
		private void RpcReader___Observers_AddPlayerMoney_431000436(PooledReader PooledReader0, Channel channel)
		{
			float amount = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___AddPlayerMoney_431000436(amount);
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x0011C4CC File Offset: 0x0011A6CC
		private void RpcWriter___Observers_AddDealerMoney_431000436(float amount)
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
			writer.WriteSingle(amount, AutoPackType.Unpacked);
			base.SendObserversRpc(2U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x0011C587 File Offset: 0x0011A787
		public void RpcLogic___AddDealerMoney_431000436(float amount)
		{
			this.moneyEarnedByDealers += amount;
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x0011C598 File Offset: 0x0011A798
		private void RpcReader___Observers_AddDealerMoney_431000436(PooledReader PooledReader0, Channel channel)
		{
			float amount = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___AddDealerMoney_431000436(amount);
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x0011C5D0 File Offset: 0x0011A7D0
		private void RpcWriter___Observers_AddXP_3316948804(int xp)
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
			writer.WriteInt32(xp, AutoPackType.Packed);
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x0011C68B File Offset: 0x0011A88B
		public void RpcLogic___AddXP_3316948804(int xp)
		{
			this.xpGained += xp;
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x0011C69C File Offset: 0x0011A89C
		private void RpcReader___Observers_AddXP_3316948804(PooledReader PooledReader0, Channel channel)
		{
			int xp = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___AddXP_3316948804(xp);
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x0011C6D2 File Offset: 0x0011A8D2
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400314E RID: 12622
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400314F RID: 12623
		public RectTransform Container;

		// Token: 0x04003150 RID: 12624
		public Animation Anim;

		// Token: 0x04003151 RID: 12625
		public TextMeshProUGUI TitleLabel;

		// Token: 0x04003152 RID: 12626
		public RectTransform[] ProductEntries;

		// Token: 0x04003153 RID: 12627
		public TextMeshProUGUI PlayerEarningsLabel;

		// Token: 0x04003154 RID: 12628
		public TextMeshProUGUI DealerEarningsLabel;

		// Token: 0x04003155 RID: 12629
		public TextMeshProUGUI XPGainedLabel;

		// Token: 0x04003156 RID: 12630
		public UnityEvent onClosed;

		// Token: 0x04003157 RID: 12631
		private Dictionary<string, int> itemsSoldByPlayer = new Dictionary<string, int>();

		// Token: 0x04003158 RID: 12632
		private float moneyEarnedByPlayer;

		// Token: 0x04003159 RID: 12633
		private float moneyEarnedByDealers;

		// Token: 0x0400315B RID: 12635
		private bool dll_Excuted;

		// Token: 0x0400315C RID: 12636
		private bool dll_Excuted;
	}
}
