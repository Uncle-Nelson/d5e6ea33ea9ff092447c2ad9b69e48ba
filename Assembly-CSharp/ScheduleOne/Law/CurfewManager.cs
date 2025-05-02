using System;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Law
{
	// Token: 0x020005CA RID: 1482
	public class CurfewManager : NetworkSingleton<CurfewManager>
	{
		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06002492 RID: 9362 RVA: 0x000938F2 File Offset: 0x00091AF2
		// (set) Token: 0x06002493 RID: 9363 RVA: 0x000938FA File Offset: 0x00091AFA
		public bool IsEnabled { get; protected set; }

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06002494 RID: 9364 RVA: 0x00093903 File Offset: 0x00091B03
		// (set) Token: 0x06002495 RID: 9365 RVA: 0x0009390B File Offset: 0x00091B0B
		public bool IsCurrentlyActive { get; protected set; }

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06002496 RID: 9366 RVA: 0x00093914 File Offset: 0x00091B14
		public bool IsCurrentlyActiveWithTolerance
		{
			get
			{
				return this.IsCurrentlyActive && NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsCurrentTimeWithinRange(2115, 500);
			}
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x00093934 File Offset: 0x00091B34
		protected override void Start()
		{
			base.Start();
			TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
			this.Disable();
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x00093968 File Offset: 0x00091B68
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (this.IsEnabled)
			{
				this.Enable(connection);
			}
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x00093980 File Offset: 0x00091B80
		[ObserversRpc]
		[TargetRpc]
		public void Enable(NetworkConnection conn)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_Enable_328543758(conn);
			}
			else
			{
				this.RpcWriter___Target_Enable_328543758(conn);
			}
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x000939AC File Offset: 0x00091BAC
		[ObserversRpc]
		public void Disable()
		{
			this.RpcWriter___Observers_Disable_2166136261();
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x000939C0 File Offset: 0x00091BC0
		private void MinPass()
		{
			if (!this.IsEnabled)
			{
				this.IsCurrentlyActive = false;
				return;
			}
			string text = "CURFEW TONIGHT\n9PM - 5AM";
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.CurrentTime == 2030 && !this.warningPlayed)
			{
				this.warningPlayed = true;
				if (this.onCurfewWarning != null)
				{
					this.onCurfewWarning.Invoke();
				}
				if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.ElapsedDays == 0 && this.onCurfewHint != null)
				{
					this.onCurfewHint.Invoke();
				}
				this.CurfewWarningSound.Play();
			}
			VMSBoard[] vmsboards;
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsCurrentTimeWithinRange(2100, 500))
			{
				if (!this.IsCurrentlyActive)
				{
					if (!NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.SleepInProgress && Singleton<LoadManager>.Instance.TimeSinceGameLoaded > 3f)
					{
						this.CurfewAlarmSound.Play();
					}
					this.IsCurrentlyActive = true;
				}
				text = "CURFEW ACTIVE\n UNTIL 5AM";
				vmsboards = this.VMSBoards;
				for (int i = 0; i < vmsboards.Length; i++)
				{
					vmsboards[i].SetText(text, new Color32(byte.MaxValue, 85, 60, byte.MaxValue));
				}
				return;
			}
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsCurrentTimeWithinRange(ScheduleOne.GameTime.TimeManager.AddMinutesTo24HourTime(2100, -60), 2100))
			{
				this.warningPlayed = false;
				this.IsCurrentlyActive = false;
				text = "CURFEW SOON\n" + (ScheduleOne.GameTime.TimeManager.GetMinSumFrom24HourTime(2100) - ScheduleOne.GameTime.TimeManager.GetMinSumFrom24HourTime(NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.CurrentTime)).ToString() + " MINS";
				vmsboards = this.VMSBoards;
				for (int i = 0; i < vmsboards.Length; i++)
				{
					vmsboards[i].SetText(text);
				}
				return;
			}
			this.warningPlayed = false;
			this.IsCurrentlyActive = false;
			vmsboards = this.VMSBoards;
			for (int i = 0; i < vmsboards.Length; i++)
			{
				vmsboards[i].SetText(text);
			}
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x00093B80 File Offset: 0x00091D80
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Law.CurfewManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Law.CurfewManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(0U, new ClientRpcDelegate(this.RpcReader___Observers_Enable_328543758));
			base.RegisterTargetRpc(1U, new ClientRpcDelegate(this.RpcReader___Target_Enable_328543758));
			base.RegisterObserversRpc(2U, new ClientRpcDelegate(this.RpcReader___Observers_Disable_2166136261));
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x00093BE9 File Offset: 0x00091DE9
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Law.CurfewManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Law.CurfewManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x00093C02 File Offset: 0x00091E02
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x00093C10 File Offset: 0x00091E10
		private void RpcWriter___Observers_Enable_328543758(NetworkConnection conn)
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
			base.SendObserversRpc(0U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x00093CBC File Offset: 0x00091EBC
		public void RpcLogic___Enable_328543758(NetworkConnection conn)
		{
			this.IsEnabled = true;
			if (this.onCurfewEnabled != null)
			{
				this.onCurfewEnabled.Invoke();
			}
			VMSBoard[] vmsboards = this.VMSBoards;
			for (int i = 0; i < vmsboards.Length; i++)
			{
				vmsboards[i].gameObject.SetActive(true);
			}
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x00093D08 File Offset: 0x00091F08
		private void RpcReader___Observers_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___Enable_328543758(null);
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x00093D2C File Offset: 0x00091F2C
		private void RpcWriter___Target_Enable_328543758(NetworkConnection conn)
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
			base.SendTargetRpc(1U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x00093DD4 File Offset: 0x00091FD4
		private void RpcReader___Target_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___Enable_328543758(base.LocalConnection);
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x00093DFC File Offset: 0x00091FFC
		private void RpcWriter___Observers_Disable_2166136261()
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

		// Token: 0x060024A6 RID: 9382 RVA: 0x00093EA8 File Offset: 0x000920A8
		public void RpcLogic___Disable_2166136261()
		{
			this.IsEnabled = false;
			if (this.onCurfewDisabled != null)
			{
				this.onCurfewDisabled.Invoke();
			}
			VMSBoard[] vmsboards = this.VMSBoards;
			for (int i = 0; i < vmsboards.Length; i++)
			{
				vmsboards[i].gameObject.SetActive(false);
			}
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x00093EF4 File Offset: 0x000920F4
		private void RpcReader___Observers_Disable_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___Disable_2166136261();
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x00093F14 File Offset: 0x00092114
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001B30 RID: 6960
		public const int WARNING_TIME = 2030;

		// Token: 0x04001B31 RID: 6961
		public const int CURFEW_START_TIME = 2100;

		// Token: 0x04001B32 RID: 6962
		public const int CURFEW_END_TIME = 500;

		// Token: 0x04001B35 RID: 6965
		[Header("References")]
		public VMSBoard[] VMSBoards;

		// Token: 0x04001B36 RID: 6966
		public AudioSourceController CurfewWarningSound;

		// Token: 0x04001B37 RID: 6967
		public AudioSourceController CurfewAlarmSound;

		// Token: 0x04001B38 RID: 6968
		public UnityEvent onCurfewEnabled;

		// Token: 0x04001B39 RID: 6969
		public UnityEvent onCurfewDisabled;

		// Token: 0x04001B3A RID: 6970
		public UnityEvent onCurfewHint;

		// Token: 0x04001B3B RID: 6971
		public UnityEvent onCurfewWarning;

		// Token: 0x04001B3C RID: 6972
		private bool warningPlayed;

		// Token: 0x04001B3D RID: 6973
		private bool dll_Excuted;

		// Token: 0x04001B3E RID: 6974
		private bool dll_Excuted;
	}
}
