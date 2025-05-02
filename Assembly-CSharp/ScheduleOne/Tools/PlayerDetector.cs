using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x0200086D RID: 2157
	[RequireComponent(typeof(Rigidbody))]
	public class PlayerDetector : MonoBehaviour
	{
		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06003AC3 RID: 15043 RVA: 0x000F7511 File Offset: 0x000F5711
		// (set) Token: 0x06003AC4 RID: 15044 RVA: 0x000F7519 File Offset: 0x000F5719
		public bool IgnoreNewDetections { get; protected set; }

		// Token: 0x06003AC5 RID: 15045 RVA: 0x000F7524 File Offset: 0x000F5724
		private void Awake()
		{
			Rigidbody rigidbody = base.GetComponent<Rigidbody>();
			if (rigidbody == null)
			{
				rigidbody = base.gameObject.AddComponent<Rigidbody>();
			}
			rigidbody.isKinematic = true;
			this.detectionColliders = base.GetComponentsInChildren<Collider>();
		}

		// Token: 0x06003AC6 RID: 15046 RVA: 0x000F7560 File Offset: 0x000F5760
		private void Start()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onTick = (Action)Delegate.Combine(instance.onTick, new Action(this.MinPass));
		}

		// Token: 0x06003AC7 RID: 15047 RVA: 0x000F7588 File Offset: 0x000F5788
		private void OnDestroy()
		{
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onTick = (Action)Delegate.Remove(instance.onTick, new Action(this.MinPass));
			}
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x000F75B8 File Offset: 0x000F57B8
		private void MinPass()
		{
			bool flag = false;
			for (int i = 0; i < Player.PlayerList.Count; i++)
			{
				if (Vector3.SqrMagnitude(Player.PlayerList[i].Avatar.CenterPoint - base.transform.position) < 400f)
				{
					flag = true;
					break;
				}
			}
			if (flag != this.collidersEnabled)
			{
				this.collidersEnabled = flag;
				for (int j = 0; j < this.detectionColliders.Length; j++)
				{
					this.detectionColliders[j].enabled = this.collidersEnabled;
				}
			}
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x000F7648 File Offset: 0x000F5848
		private void OnTriggerEnter(Collider other)
		{
			if (this.IgnoreNewDetections)
			{
				return;
			}
			Player componentInParent = other.GetComponentInParent<Player>();
			if (componentInParent != null && !this.DetectedPlayers.Contains(componentInParent) && other == componentInParent.CapCol)
			{
				this.DetectedPlayers.Add(componentInParent);
				if (this.onPlayerEnter != null)
				{
					this.onPlayerEnter.Invoke(componentInParent);
				}
				if (componentInParent.IsOwner && this.onLocalPlayerEnter != null)
				{
					this.onLocalPlayerEnter.Invoke();
				}
			}
			if (this.DetectPlayerInVehicle)
			{
				LandVehicle componentInParent2 = other.GetComponentInParent<LandVehicle>();
				if (componentInParent2 != null)
				{
					foreach (Player player in componentInParent2.OccupantPlayers)
					{
						if (player != null && !this.DetectedPlayers.Contains(player))
						{
							this.DetectedPlayers.Add(player);
							if (this.onPlayerEnter != null)
							{
								this.onPlayerEnter.Invoke(player);
							}
							if (player.IsOwner && this.onLocalPlayerEnter != null)
							{
								this.onLocalPlayerEnter.Invoke();
							}
						}
					}
				}
			}
		}

		// Token: 0x06003ACA RID: 15050 RVA: 0x000F7774 File Offset: 0x000F5974
		private void FixedUpdate()
		{
			for (int i = 0; i < this.DetectedPlayers.Count; i++)
			{
				if (this.DetectedPlayers[i].CurrentVehicle != null)
				{
					this.OnTriggerExit(this.DetectedPlayers[i].CapCol);
				}
			}
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x000F77C8 File Offset: 0x000F59C8
		private void OnTriggerExit(Collider other)
		{
			if (this.ignoreExit)
			{
				return;
			}
			Player componentInParent = other.GetComponentInParent<Player>();
			if (componentInParent != null && this.DetectedPlayers.Contains(componentInParent) && other == componentInParent.CapCol)
			{
				this.DetectedPlayers.Remove(componentInParent);
				if (this.onPlayerExit != null)
				{
					this.onPlayerExit.Invoke(componentInParent);
				}
				if (componentInParent.IsOwner && this.onLocalPlayerExit != null)
				{
					this.onLocalPlayerExit.Invoke();
				}
			}
			if (this.DetectPlayerInVehicle)
			{
				LandVehicle componentInParent2 = other.GetComponentInParent<LandVehicle>();
				if (componentInParent2 != null)
				{
					foreach (Player player in componentInParent2.OccupantPlayers)
					{
						if (player != null && this.DetectedPlayers.Contains(player))
						{
							this.DetectedPlayers.Remove(player);
							if (this.onPlayerExit != null)
							{
								this.onPlayerExit.Invoke(player);
							}
							if (player.IsOwner && this.onLocalPlayerExit != null)
							{
								this.onLocalPlayerExit.Invoke();
							}
						}
					}
				}
			}
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x000F78F8 File Offset: 0x000F5AF8
		public void SetIgnoreNewCollisions(bool ignore)
		{
			this.IgnoreNewDetections = ignore;
			if (!ignore)
			{
				this.ignoreExit = true;
				Collider[] componentsInChildren = base.GetComponentsInChildren<Collider>();
				for (int i = 0; i < componentsInChildren.Length; i++)
				{
					if (componentsInChildren[i].isTrigger)
					{
						componentsInChildren[i].enabled = false;
						componentsInChildren[i].enabled = true;
					}
				}
				this.ignoreExit = false;
			}
		}

		// Token: 0x04002A42 RID: 10818
		public const float ACTIVATION_DISTANCE_SQ = 400f;

		// Token: 0x04002A43 RID: 10819
		public bool DetectPlayerInVehicle;

		// Token: 0x04002A44 RID: 10820
		public UnityEvent<Player> onPlayerEnter;

		// Token: 0x04002A45 RID: 10821
		public UnityEvent<Player> onPlayerExit;

		// Token: 0x04002A46 RID: 10822
		public UnityEvent onLocalPlayerEnter;

		// Token: 0x04002A47 RID: 10823
		public UnityEvent onLocalPlayerExit;

		// Token: 0x04002A48 RID: 10824
		public List<Player> DetectedPlayers = new List<Player>();

		// Token: 0x04002A4A RID: 10826
		private bool ignoreExit;

		// Token: 0x04002A4B RID: 10827
		private bool collidersEnabled = true;

		// Token: 0x04002A4C RID: 10828
		private Collider[] detectionColliders;
	}
}
