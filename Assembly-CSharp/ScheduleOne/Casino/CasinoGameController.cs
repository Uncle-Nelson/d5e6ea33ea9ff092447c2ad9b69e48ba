using System;
using FishNet.Object;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.Compass;
using UnityEngine;

namespace ScheduleOne.Casino
{
	// Token: 0x0200075B RID: 1883
	public class CasinoGameController : NetworkBehaviour
	{
		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06003311 RID: 13073 RVA: 0x000D4DB0 File Offset: 0x000D2FB0
		// (set) Token: 0x06003312 RID: 13074 RVA: 0x000D4DB8 File Offset: 0x000D2FB8
		public bool IsOpen { get; private set; }

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06003313 RID: 13075 RVA: 0x000D4DC1 File Offset: 0x000D2FC1
		public CasinoGamePlayerData LocalPlayerData
		{
			get
			{
				return this.Players.GetPlayerData();
			}
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x000D4DCE File Offset: 0x000D2FCE
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Casino.CasinoGameController_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x000D4DE2 File Offset: 0x000D2FE2
		protected virtual void OnLocalPlayerRequestJoin(Player player)
		{
			this.Open();
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x000D4DEA File Offset: 0x000D2FEA
		protected virtual void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.IsOpen)
			{
				return;
			}
			if (action.exitType == ExitType.Escape)
			{
				this.Close();
				action.used = true;
			}
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void Update()
		{
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x000D4E14 File Offset: 0x000D3014
		protected virtual void Open()
		{
			this.IsOpen = true;
			this.Players.AddPlayer(Player.Local);
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			this.localDefaultCameraTransform = this.DefaultCameraTransforms[this.Players.GetPlayerIndex(Player.Local)];
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.localDefaultCameraTransform.position, this.localDefaultCameraTransform.rotation, 0.2f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(65f, 0.2f);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			Singleton<CompassManager>.Instance.SetVisible(false);
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x000D4ED8 File Offset: 0x000D30D8
		protected virtual void Close()
		{
			this.IsOpen = false;
			this.Players.RemovePlayer(Player.Local);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0.2f, true, true);
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0.2f);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
			Singleton<CompassManager>.Instance.SetVisible(true);
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x000D4F57 File Offset: 0x000D3157
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Casino.CasinoGameControllerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Casino.CasinoGameControllerAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x000D4F6A File Offset: 0x000D316A
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Casino.CasinoGameControllerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Casino.CasinoGameControllerAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x000D4F7D File Offset: 0x000D317D
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x000D4F8B File Offset: 0x000D318B
		protected virtual void dll()
		{
			CasinoGameInteraction interaction = this.Interaction;
			interaction.onLocalPlayerRequestJoin = (Action<Player>)Delegate.Combine(interaction.onLocalPlayerRequestJoin, new Action<Player>(this.OnLocalPlayerRequestJoin));
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 0);
		}

		// Token: 0x04002479 RID: 9337
		public const float FOV = 65f;

		// Token: 0x0400247A RID: 9338
		public const float CAMERA_LERP_TIME = 0.2f;

		// Token: 0x0400247C RID: 9340
		[Header("References")]
		public CasinoGamePlayers Players;

		// Token: 0x0400247D RID: 9341
		public CasinoGameInteraction Interaction;

		// Token: 0x0400247E RID: 9342
		public Transform[] DefaultCameraTransforms;

		// Token: 0x0400247F RID: 9343
		protected Transform localDefaultCameraTransform;

		// Token: 0x04002480 RID: 9344
		private bool dll_Excuted;

		// Token: 0x04002481 RID: 9345
		private bool dll_Excuted;
	}
}
