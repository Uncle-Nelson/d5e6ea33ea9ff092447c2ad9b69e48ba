using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using ScheduleOne.UI.Compass;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	// Token: 0x020002A7 RID: 679
	public class TVInterface : MonoBehaviour
	{
		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x0003F5E4 File Offset: 0x0003D7E4
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x0003F5EC File Offset: 0x0003D7EC
		public bool IsOpen { get; private set; }

		// Token: 0x06000E32 RID: 3634 RVA: 0x0003F5F5 File Offset: 0x0003D7F5
		public void Awake()
		{
			this.Canvas.enabled = false;
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0003F629 File Offset: 0x0003D829
		public void Start()
		{
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 2);
			this.MinPass();
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0003F643 File Offset: 0x0003D843
		private void OnDestroy()
		{
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			}
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0003F674 File Offset: 0x0003D874
		private void MinPass()
		{
			this.TimeLabel.text = TimeManager.Get12HourTime((float)NetworkSingleton<TimeManager>.Instance.CurrentTime, true);
			this.Daylabel.text = NetworkSingleton<TimeManager>.Instance.CurrentDay.ToString();
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0003F6C0 File Offset: 0x0003D8C0
		public void Open()
		{
			if (this.IsOpen)
			{
				return;
			}
			this.IsOpen = true;
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.CameraPosition.position, this.CameraPosition.rotation, 0.15f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(60f, 0.15f);
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			Singleton<HUD>.Instance.SetCrosshairVisible(false);
			Singleton<CompassManager>.Instance.SetVisible(false);
			this.AddPlayer(Player.Local);
			this.Canvas.enabled = true;
			this.TimeLabel.gameObject.SetActive(false);
			this.HomeScreen.Open();
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x0003F79C File Offset: 0x0003D99C
		public void Close()
		{
			if (!this.IsOpen)
			{
				return;
			}
			this.IsOpen = false;
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0.15f, true, true);
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0.15f);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			this.RemovePlayer(Player.Local);
			this.Canvas.enabled = false;
			this.TimeLabel.gameObject.SetActive(true);
			Singleton<HUD>.Instance.SetCrosshairVisible(true);
			Singleton<CompassManager>.Instance.SetVisible(true);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x0003F847 File Offset: 0x0003DA47
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.IsOpen)
			{
				return;
			}
			action.used = true;
			this.Close();
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0003F868 File Offset: 0x0003DA68
		public bool CanOpen()
		{
			return !this.IsOpen;
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0003F873 File Offset: 0x0003DA73
		public void AddPlayer(Player player)
		{
			if (!this.Players.Contains(player))
			{
				this.Players.Add(player);
				if (this.onPlayerAdded != null)
				{
					this.onPlayerAdded.Invoke(player);
				}
			}
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0003F8A3 File Offset: 0x0003DAA3
		public void RemovePlayer(Player player)
		{
			if (this.Players.Contains(player))
			{
				this.Players.Remove(player);
				if (this.onPlayerRemoved != null)
				{
					this.onPlayerRemoved.Invoke(player);
				}
			}
		}

		// Token: 0x04000EE4 RID: 3812
		public const float OPEN_TIME = 0.15f;

		// Token: 0x04000EE5 RID: 3813
		public const float FOV = 60f;

		// Token: 0x04000EE7 RID: 3815
		public List<Player> Players = new List<Player>();

		// Token: 0x04000EE8 RID: 3816
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04000EE9 RID: 3817
		public Transform CameraPosition;

		// Token: 0x04000EEA RID: 3818
		public TVHomeScreen HomeScreen;

		// Token: 0x04000EEB RID: 3819
		public TextMeshPro TimeLabel;

		// Token: 0x04000EEC RID: 3820
		public TextMeshPro Daylabel;

		// Token: 0x04000EED RID: 3821
		public UnityEvent<Player> onPlayerAdded = new UnityEvent<Player>();

		// Token: 0x04000EEE RID: 3822
		public UnityEvent<Player> onPlayerRemoved = new UnityEvent<Player>();
	}
}
