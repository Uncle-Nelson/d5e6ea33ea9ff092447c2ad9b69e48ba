using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.Tiles;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BEF RID: 3055
	public class Sprinkler : GridItem
	{
		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x060055C5 RID: 21957 RVA: 0x00169596 File Offset: 0x00167796
		// (set) Token: 0x060055C6 RID: 21958 RVA: 0x0016959E File Offset: 0x0016779E
		public bool IsSprinkling { get; private set; }

		// Token: 0x060055C7 RID: 21959 RVA: 0x001695A7 File Offset: 0x001677A7
		public void Hovered()
		{
			if (this.isGhost)
			{
				return;
			}
			if (this.CanWater())
			{
				this.IntObj.SetMessage("Activate sprinkler");
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				return;
			}
			this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
		}

		// Token: 0x060055C8 RID: 21960 RVA: 0x001695E3 File Offset: 0x001677E3
		public void Interacted()
		{
			if (this.isGhost)
			{
				return;
			}
			if (!this.CanWater())
			{
				return;
			}
			this.SendWater();
		}

		// Token: 0x060055C9 RID: 21961 RVA: 0x001695FD File Offset: 0x001677FD
		private bool CanWater()
		{
			return !this.IsSprinkling;
		}

		// Token: 0x060055CA RID: 21962 RVA: 0x00169608 File Offset: 0x00167808
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendWater()
		{
			this.RpcWriter___Server_SendWater_2166136261();
			this.RpcLogic___SendWater_2166136261();
		}

		// Token: 0x060055CB RID: 21963 RVA: 0x00169616 File Offset: 0x00167816
		[ObserversRpc(RunLocally = true)]
		private void Water()
		{
			this.RpcWriter___Observers_Water_2166136261();
			this.RpcLogic___Water_2166136261();
		}

		// Token: 0x060055CC RID: 21964 RVA: 0x00169624 File Offset: 0x00167824
		public void ApplyWater(float normalizedAmount)
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			List<Pot> pots = this.GetPots();
			for (int i = 0; i < pots.Count; i++)
			{
				pots[i].ChangeWaterAmount(pots[i].WaterCapacity * normalizedAmount);
			}
		}

		// Token: 0x060055CD RID: 21965 RVA: 0x0016966C File Offset: 0x0016786C
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

		// Token: 0x060055CF RID: 21967 RVA: 0x0016978E File Offset: 0x0016798E
		[CompilerGenerated]
		private IEnumerator <Water>g__Routine|15_0()
		{
			if (this.onSprinklerStart != null)
			{
				this.onSprinklerStart.Invoke();
			}
			this.WaterSound.Play();
			for (int j = 0; j < this.WaterParticles.Length; j++)
			{
				this.WaterParticles[j].Play();
			}
			int segments = 5;
			int num;
			for (int i = 0; i < segments; i = num + 1)
			{
				yield return new WaitForSeconds(this.ApplyWaterDelay / (float)segments);
				if (InstanceFinder.IsServer)
				{
					this.ApplyWater(1f / (float)segments);
				}
				num = i;
			}
			yield return new WaitForSeconds(this.ParticleStopDelay);
			for (int k = 0; k < this.WaterParticles.Length; k++)
			{
				this.WaterParticles[k].Stop();
			}
			this.WaterSound.Stop();
			this.IsSprinkling = false;
			yield break;
		}

		// Token: 0x060055D0 RID: 21968 RVA: 0x001697A0 File Offset: 0x001679A0
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.SprinklerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.SprinklerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_SendWater_2166136261));
			base.RegisterObserversRpc(9U, new ClientRpcDelegate(this.RpcReader___Observers_Water_2166136261));
		}

		// Token: 0x060055D1 RID: 21969 RVA: 0x001697F2 File Offset: 0x001679F2
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.SprinklerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.SprinklerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060055D2 RID: 21970 RVA: 0x0016980B File Offset: 0x00167A0B
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060055D3 RID: 21971 RVA: 0x0016981C File Offset: 0x00167A1C
		private void RpcWriter___Server_SendWater_2166136261()
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

		// Token: 0x060055D4 RID: 21972 RVA: 0x001698B6 File Offset: 0x00167AB6
		private void RpcLogic___SendWater_2166136261()
		{
			this.Water();
		}

		// Token: 0x060055D5 RID: 21973 RVA: 0x001698C0 File Offset: 0x00167AC0
		private void RpcReader___Server_SendWater_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendWater_2166136261();
		}

		// Token: 0x060055D6 RID: 21974 RVA: 0x001698F0 File Offset: 0x00167AF0
		private void RpcWriter___Observers_Water_2166136261()
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

		// Token: 0x060055D7 RID: 21975 RVA: 0x00169999 File Offset: 0x00167B99
		private void RpcLogic___Water_2166136261()
		{
			if (this.IsSprinkling)
			{
				return;
			}
			this.IsSprinkling = true;
			this.ClickSound.Play();
			base.StartCoroutine(this.<Water>g__Routine|15_0());
		}

		// Token: 0x060055D8 RID: 21976 RVA: 0x001699C4 File Offset: 0x00167BC4
		private void RpcReader___Observers_Water_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___Water_2166136261();
		}

		// Token: 0x060055D9 RID: 21977 RVA: 0x001699EE File Offset: 0x00167BEE
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04003F79 RID: 16249
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04003F7A RID: 16250
		public ParticleSystem[] WaterParticles;

		// Token: 0x04003F7B RID: 16251
		public AudioSourceController ClickSound;

		// Token: 0x04003F7C RID: 16252
		public AudioSourceController WaterSound;

		// Token: 0x04003F7D RID: 16253
		[Header("Settings")]
		public float ApplyWaterDelay = 6f;

		// Token: 0x04003F7E RID: 16254
		public float ParticleStopDelay = 2.5f;

		// Token: 0x04003F7F RID: 16255
		public UnityEvent onSprinklerStart;

		// Token: 0x04003F80 RID: 16256
		private bool dll_Excuted;

		// Token: 0x04003F81 RID: 16257
		private bool dll_Excuted;
	}
}
