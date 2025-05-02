using System;
using System.Collections;
using System.Collections.Generic;
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
using ScheduleOne.GameTime;
using ScheduleOne.Interaction;
using ScheduleOne.Misc;
using ScheduleOne.Money;
using ScheduleOne.Trash;
using ScheduleOne.Variables;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000B95 RID: 2965
	public class Recycler : NetworkBehaviour
	{
		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06004F1A RID: 20250 RVA: 0x0014D9DE File Offset: 0x0014BBDE
		// (set) Token: 0x06004F1B RID: 20251 RVA: 0x0014D9E6 File Offset: 0x0014BBE6
		public Recycler.EState State { get; protected set; }

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06004F1C RID: 20252 RVA: 0x0014D9EF File Offset: 0x0014BBEF
		// (set) Token: 0x06004F1D RID: 20253 RVA: 0x0014D9F7 File Offset: 0x0014BBF7
		public bool IsHatchOpen { get; private set; }

		// Token: 0x06004F1E RID: 20254 RVA: 0x0014DA00 File Offset: 0x0014BC00
		public void Start()
		{
			this.HandleIntObj.onInteractStart.AddListener(new UnityAction(this.HandleInteracted));
			this.ButtonIntObj.onInteractStart.AddListener(new UnityAction(this.ButtonInteracted));
			this.CashIntObj.onInteractStart.AddListener(new UnityAction(this.CashInteracted));
			TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x06004F1F RID: 20255 RVA: 0x0014DA87 File Offset: 0x0014BC87
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			this.SetState(connection, this.State, true);
		}

		// Token: 0x06004F20 RID: 20256 RVA: 0x0014DA9E File Offset: 0x0014BC9E
		private void OnDestroy()
		{
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
				instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			}
		}

		// Token: 0x06004F21 RID: 20257 RVA: 0x0014DAD0 File Offset: 0x0014BCD0
		private void MinPass()
		{
			if (this.State == Recycler.EState.HatchOpen)
			{
				this.OpenHatchInstruction.gameObject.SetActive(false);
				this.InsertTrashInstruction.gameObject.SetActive(false);
				this.PressBeginInstruction.gameObject.SetActive(false);
				this.ProcessingScreen.gameObject.SetActive(false);
				if (this.GetTrash().Length != 0)
				{
					this.ButtonIntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
					this.ButtonLight.isOn = true;
					this.PressBeginInstruction.gameObject.SetActive(true);
					return;
				}
				this.ButtonIntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				this.ButtonLight.isOn = false;
				this.InsertTrashInstruction.gameObject.SetActive(true);
			}
		}

		// Token: 0x06004F22 RID: 20258 RVA: 0x0014DB89 File Offset: 0x0014BD89
		public void HandleInteracted()
		{
			this.SendState(Recycler.EState.HatchOpen);
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x0014DB94 File Offset: 0x0014BD94
		public void ButtonInteracted()
		{
			this.ProcessingLabel.text = "Processing...";
			this.ValueLabel.text = MoneyManager.FormatAmount(0f, false, false);
			this.PressSound.Play();
			this.SendState(Recycler.EState.Processing);
			base.StartCoroutine(this.Process(true));
		}

		// Token: 0x06004F24 RID: 20260 RVA: 0x0014DBE8 File Offset: 0x0014BDE8
		public void CashInteracted()
		{
			NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(this.cashValue, true, false);
			NetworkSingleton<MoneyManager>.Instance.ChangeLifetimeEarnings(this.cashValue);
			this.SendState(Recycler.EState.HatchClosed);
			this.BankNote.gameObject.SetActive(false);
			this.cashValue = 0f;
			this.SendCashCollected();
		}

		// Token: 0x06004F25 RID: 20261 RVA: 0x0014DC40 File Offset: 0x0014BE40
		[ServerRpc(RequireOwnership = false)]
		private void SendCashCollected()
		{
			this.RpcWriter___Server_SendCashCollected_2166136261();
		}

		// Token: 0x06004F26 RID: 20262 RVA: 0x0014DC48 File Offset: 0x0014BE48
		[ObserversRpc(RunLocally = true)]
		private void CashCollected()
		{
			this.RpcWriter___Observers_CashCollected_2166136261();
			this.RpcLogic___CashCollected_2166136261();
		}

		// Token: 0x06004F27 RID: 20263 RVA: 0x0014DC56 File Offset: 0x0014BE56
		[ObserversRpc(RunLocally = true)]
		private void EnableCash()
		{
			this.RpcWriter___Observers_EnableCash_2166136261();
			this.RpcLogic___EnableCash_2166136261();
		}

		// Token: 0x06004F28 RID: 20264 RVA: 0x0014DC64 File Offset: 0x0014BE64
		[ObserversRpc(RunLocally = true)]
		private void SetCashValue(float amount)
		{
			this.RpcWriter___Observers_SetCashValue_431000436(amount);
			this.RpcLogic___SetCashValue_431000436(amount);
		}

		// Token: 0x06004F29 RID: 20265 RVA: 0x0014DC7A File Offset: 0x0014BE7A
		private IEnumerator Process(bool startedByLocalPlayer)
		{
			yield return new WaitForSeconds(0.5f);
			if (this.onStart != null)
			{
				this.onStart.Invoke();
			}
			TrashItem[] trash = this.GetTrash();
			if (startedByLocalPlayer)
			{
				int num = trash.Length;
				float num2 = NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("TrashRecycled") + (float)num;
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("TrashRecycled", num2.ToString(), true);
				if (num2 >= 500f)
				{
					Singleton<AchievementManager>.Instance.UnlockAchievement(AchievementManager.EAchievement.UPSTANDING_CITIZEN);
				}
			}
			float value = 0f;
			TrashItem[] array = trash;
			int j = 0;
			while (j < array.Length)
			{
				TrashItem trashItem = array[j];
				if (trashItem is TrashBag)
				{
					using (List<TrashContent.Entry>.Enumerator enumerator = ((TrashBag)trashItem).Content.Entries.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							TrashContent.Entry entry = enumerator.Current;
							value += (float)(entry.UnitValue * entry.Quantity);
						}
						goto IL_14A;
					}
					goto IL_135;
				}
				goto IL_135;
				IL_14A:
				if (InstanceFinder.IsServer)
				{
					trashItem.DestroyTrash();
				}
				j++;
				continue;
				IL_135:
				value += (float)trashItem.SellValue;
				goto IL_14A;
			}
			if (this.cashValue <= 0f)
			{
				this.SetCashValue(value);
			}
			float lerpTime = 1.5f;
			for (float i = 0f; i < lerpTime; i += Time.deltaTime)
			{
				float t = i / lerpTime;
				float amount = Mathf.Lerp(0f, this.cashValue, t);
				this.ValueLabel.text = MoneyManager.FormatAmount(amount, true, false);
				yield return new WaitForEndOfFrame();
			}
			if (this.onStop != null)
			{
				this.onStop.Invoke();
			}
			this.ProcessingLabel.text = "Thank you";
			this.ValueLabel.text = MoneyManager.FormatAmount(value, false, false);
			this.DoneSound.Play();
			yield return new WaitForSeconds(0.3f);
			this.CashEjectSound.Play();
			this.CashAnim.Play();
			yield return new WaitForSeconds(0.25f);
			if (InstanceFinder.IsServer)
			{
				this.EnableCash();
			}
			yield break;
		}

		// Token: 0x06004F2A RID: 20266 RVA: 0x0014DC90 File Offset: 0x0014BE90
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendState(Recycler.EState state)
		{
			this.RpcWriter___Server_SendState_3569965459(state);
			this.RpcLogic___SendState_3569965459(state);
		}

		// Token: 0x06004F2B RID: 20267 RVA: 0x0014DCA8 File Offset: 0x0014BEA8
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetState(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetState_3790170803(conn, state, force);
				this.RpcLogic___SetState_3790170803(conn, state, force);
			}
			else
			{
				this.RpcWriter___Target_SetState_3790170803(conn, state, force);
			}
		}

		// Token: 0x06004F2C RID: 20268 RVA: 0x0014DCF8 File Offset: 0x0014BEF8
		private void SetHatchOpen(bool open)
		{
			if (open == this.IsHatchOpen)
			{
				return;
			}
			this.IsHatchOpen = open;
			if (this.IsHatchOpen)
			{
				this.OpenSound.Play();
				this.HatchAnim.Play("Recycler open");
				return;
			}
			this.CloseSound.Play();
			this.HatchAnim.Play("Recycler close");
		}

		// Token: 0x06004F2D RID: 20269 RVA: 0x0014DD58 File Offset: 0x0014BF58
		private TrashItem[] GetTrash()
		{
			List<TrashItem> list = new List<TrashItem>();
			Vector3 vector = this.CheckCollider.transform.TransformPoint(this.CheckCollider.center);
			Vector3 vector2 = Vector3.Scale(this.CheckCollider.size, this.CheckCollider.transform.lossyScale) * 0.5f;
			Collider[] array = Physics.OverlapBox(vector, vector2, this.CheckCollider.transform.rotation, this.DetectionMask, 2);
			for (int i = 0; i < array.Length; i++)
			{
				TrashItem componentInParent = array[i].GetComponentInParent<TrashItem>();
				if (componentInParent != null && !list.Contains(componentInParent))
				{
					list.Add(componentInParent);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06004F2E RID: 20270 RVA: 0x0014DE10 File Offset: 0x0014C010
		private void OnDrawGizmos()
		{
			Vector3 center = this.CheckCollider.transform.TransformPoint(this.CheckCollider.center);
			Vector3 a = Vector3.Scale(this.CheckCollider.size, this.CheckCollider.transform.lossyScale) * 0.5f;
			Gizmos.color = Color.red;
			Gizmos.DrawWireCube(center, a * 2f);
		}

		// Token: 0x06004F30 RID: 20272 RVA: 0x0014DE80 File Offset: 0x0014C080
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.RecyclerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.RecyclerAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendCashCollected_2166136261));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_CashCollected_2166136261));
			base.RegisterObserversRpc(2U, new ClientRpcDelegate(this.RpcReader___Observers_EnableCash_2166136261));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_SetCashValue_431000436));
			base.RegisterServerRpc(4U, new ServerRpcDelegate(this.RpcReader___Server_SendState_3569965459));
			base.RegisterObserversRpc(5U, new ClientRpcDelegate(this.RpcReader___Observers_SetState_3790170803));
			base.RegisterTargetRpc(6U, new ClientRpcDelegate(this.RpcReader___Target_SetState_3790170803));
		}

		// Token: 0x06004F31 RID: 20273 RVA: 0x0014DF3F File Offset: 0x0014C13F
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.RecyclerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.RecyclerAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06004F32 RID: 20274 RVA: 0x0014DF52 File Offset: 0x0014C152
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06004F33 RID: 20275 RVA: 0x0014DF60 File Offset: 0x0014C160
		private void RpcWriter___Server_SendCashCollected_2166136261()
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

		// Token: 0x06004F34 RID: 20276 RVA: 0x0014DFFA File Offset: 0x0014C1FA
		private void RpcLogic___SendCashCollected_2166136261()
		{
			this.CashCollected();
		}

		// Token: 0x06004F35 RID: 20277 RVA: 0x0014E004 File Offset: 0x0014C204
		private void RpcReader___Server_SendCashCollected_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendCashCollected_2166136261();
		}

		// Token: 0x06004F36 RID: 20278 RVA: 0x0014E024 File Offset: 0x0014C224
		private void RpcWriter___Observers_CashCollected_2166136261()
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
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06004F37 RID: 20279 RVA: 0x0014E0CD File Offset: 0x0014C2CD
		private void RpcLogic___CashCollected_2166136261()
		{
			this.SendState(Recycler.EState.HatchClosed);
			this.BankNote.gameObject.SetActive(false);
			this.cashValue = 0f;
		}

		// Token: 0x06004F38 RID: 20280 RVA: 0x0014E0F4 File Offset: 0x0014C2F4
		private void RpcReader___Observers_CashCollected_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___CashCollected_2166136261();
		}

		// Token: 0x06004F39 RID: 20281 RVA: 0x0014E120 File Offset: 0x0014C320
		private void RpcWriter___Observers_EnableCash_2166136261()
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
			base.SendObserversRpc(2U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06004F3A RID: 20282 RVA: 0x0014E1C9 File Offset: 0x0014C3C9
		private void RpcLogic___EnableCash_2166136261()
		{
			this.CashIntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
		}

		// Token: 0x06004F3B RID: 20283 RVA: 0x0014E1D8 File Offset: 0x0014C3D8
		private void RpcReader___Observers_EnableCash_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___EnableCash_2166136261();
		}

		// Token: 0x06004F3C RID: 20284 RVA: 0x0014E204 File Offset: 0x0014C404
		private void RpcWriter___Observers_SetCashValue_431000436(float amount)
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
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06004F3D RID: 20285 RVA: 0x0014E2BF File Offset: 0x0014C4BF
		private void RpcLogic___SetCashValue_431000436(float amount)
		{
			this.cashValue = amount;
		}

		// Token: 0x06004F3E RID: 20286 RVA: 0x0014E2C8 File Offset: 0x0014C4C8
		private void RpcReader___Observers_SetCashValue_431000436(PooledReader PooledReader0, Channel channel)
		{
			float amount = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetCashValue_431000436(amount);
		}

		// Token: 0x06004F3F RID: 20287 RVA: 0x0014E308 File Offset: 0x0014C508
		private void RpcWriter___Server_SendState_3569965459(Recycler.EState state)
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
			writer.Write___ScheduleOne.ObjectScripts.Recycler/EStateFishNet.Serializing.Generated(state);
			base.SendServerRpc(4U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06004F40 RID: 20288 RVA: 0x0014E3AF File Offset: 0x0014C5AF
		public void RpcLogic___SendState_3569965459(Recycler.EState state)
		{
			this.SetState(null, state, false);
		}

		// Token: 0x06004F41 RID: 20289 RVA: 0x0014E3BC File Offset: 0x0014C5BC
		private void RpcReader___Server_SendState_3569965459(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			Recycler.EState state = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.Recycler/EStateFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendState_3569965459(state);
		}

		// Token: 0x06004F42 RID: 20290 RVA: 0x0014E3FC File Offset: 0x0014C5FC
		private void RpcWriter___Observers_SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
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
			writer.Write___ScheduleOne.ObjectScripts.Recycler/EStateFishNet.Serializing.Generated(state);
			writer.WriteBoolean(force);
			base.SendObserversRpc(5U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06004F43 RID: 20291 RVA: 0x0014E4C0 File Offset: 0x0014C6C0
		private void RpcLogic___SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
			if (this.State == state && !force)
			{
				return;
			}
			this.State = state;
			this.HandleIntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
			this.ButtonIntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
			this.CashIntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
			this.OpenHatchInstruction.gameObject.SetActive(false);
			this.InsertTrashInstruction.gameObject.SetActive(false);
			this.PressBeginInstruction.gameObject.SetActive(false);
			this.ProcessingScreen.gameObject.SetActive(false);
			this.ButtonLight.isOn = false;
			this.Cash.gameObject.SetActive(false);
			switch (this.State)
			{
			case Recycler.EState.HatchClosed:
				this.HandleIntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				this.OpenHatchInstruction.gameObject.SetActive(true);
				return;
			case Recycler.EState.HatchOpen:
				if (this.GetTrash().Length != 0)
				{
					this.ButtonIntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
					this.ButtonLight.isOn = true;
					this.PressBeginInstruction.gameObject.SetActive(true);
				}
				else
				{
					this.InsertTrashInstruction.gameObject.SetActive(true);
				}
				this.SetHatchOpen(true);
				return;
			case Recycler.EState.Processing:
				base.StartCoroutine(this.Process(false));
				this.ProcessingScreen.gameObject.SetActive(true);
				this.ButtonAnim.Play();
				this.SetHatchOpen(false);
				return;
			default:
				return;
			}
		}

		// Token: 0x06004F44 RID: 20292 RVA: 0x0014E620 File Offset: 0x0014C820
		private void RpcReader___Observers_SetState_3790170803(PooledReader PooledReader0, Channel channel)
		{
			Recycler.EState state = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.Recycler/EStateFishNet.Serializing.Generateds(PooledReader0);
			bool force = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetState_3790170803(null, state, force);
		}

		// Token: 0x06004F45 RID: 20293 RVA: 0x0014E670 File Offset: 0x0014C870
		private void RpcWriter___Target_SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
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
			writer.Write___ScheduleOne.ObjectScripts.Recycler/EStateFishNet.Serializing.Generated(state);
			writer.WriteBoolean(force);
			base.SendTargetRpc(6U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06004F46 RID: 20294 RVA: 0x0014E734 File Offset: 0x0014C934
		private void RpcReader___Target_SetState_3790170803(PooledReader PooledReader0, Channel channel)
		{
			Recycler.EState state = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.Recycler/EStateFishNet.Serializing.Generateds(PooledReader0);
			bool force = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetState_3790170803(base.LocalConnection, state, force);
		}

		// Token: 0x06004F47 RID: 20295 RVA: 0x0014DF52 File Offset: 0x0014C152
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04003BB2 RID: 15282
		public LayerMask DetectionMask;

		// Token: 0x04003BB3 RID: 15283
		[Header("References")]
		public InteractableObject HandleIntObj;

		// Token: 0x04003BB4 RID: 15284
		public InteractableObject ButtonIntObj;

		// Token: 0x04003BB5 RID: 15285
		public InteractableObject CashIntObj;

		// Token: 0x04003BB6 RID: 15286
		public ToggleableLight ButtonLight;

		// Token: 0x04003BB7 RID: 15287
		public Animation ButtonAnim;

		// Token: 0x04003BB8 RID: 15288
		public Animation HatchAnim;

		// Token: 0x04003BB9 RID: 15289
		public Animation CashAnim;

		// Token: 0x04003BBA RID: 15290
		public RectTransform OpenHatchInstruction;

		// Token: 0x04003BBB RID: 15291
		public RectTransform InsertTrashInstruction;

		// Token: 0x04003BBC RID: 15292
		public RectTransform PressBeginInstruction;

		// Token: 0x04003BBD RID: 15293
		public RectTransform ProcessingScreen;

		// Token: 0x04003BBE RID: 15294
		public TextMeshProUGUI ProcessingLabel;

		// Token: 0x04003BBF RID: 15295
		public TextMeshProUGUI ValueLabel;

		// Token: 0x04003BC0 RID: 15296
		public BoxCollider CheckCollider;

		// Token: 0x04003BC1 RID: 15297
		public Transform Cash;

		// Token: 0x04003BC2 RID: 15298
		public GameObject BankNote;

		// Token: 0x04003BC3 RID: 15299
		[Header("Sound")]
		public AudioSourceController OpenSound;

		// Token: 0x04003BC4 RID: 15300
		public AudioSourceController CloseSound;

		// Token: 0x04003BC5 RID: 15301
		public AudioSourceController PressSound;

		// Token: 0x04003BC6 RID: 15302
		public AudioSourceController DoneSound;

		// Token: 0x04003BC7 RID: 15303
		public AudioSourceController CashEjectSound;

		// Token: 0x04003BC8 RID: 15304
		private float cashValue;

		// Token: 0x04003BC9 RID: 15305
		public UnityEvent onStart;

		// Token: 0x04003BCA RID: 15306
		public UnityEvent onStop;

		// Token: 0x04003BCB RID: 15307
		private bool dll_Excuted;

		// Token: 0x04003BCC RID: 15308
		private bool dll_Excuted;

		// Token: 0x02000B96 RID: 2966
		public enum EState
		{
			// Token: 0x04003BCE RID: 15310
			HatchClosed,
			// Token: 0x04003BCF RID: 15311
			HatchOpen,
			// Token: 0x04003BD0 RID: 15312
			Processing
		}
	}
}
