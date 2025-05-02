using System;
using EasyButtons;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000869 RID: 2153
	public class OptimizedColliderGroup : MonoBehaviour
	{
		// Token: 0x06003AAE RID: 15022 RVA: 0x000F72E4 File Offset: 0x000F54E4
		private void OnEnable()
		{
			this.sqrColliderEnableMaxDistance = this.ColliderEnableMaxDistance * this.ColliderEnableMaxDistance;
			if (PlayerSingleton<PlayerMovement>.InstanceExists)
			{
				this.RegisterEvent();
				return;
			}
			Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(this.RegisterEvent));
		}

		// Token: 0x06003AAF RID: 15023 RVA: 0x000F7332 File Offset: 0x000F5532
		private void OnDestroy()
		{
			if (PlayerSingleton<PlayerMovement>.InstanceExists)
			{
				PlayerSingleton<PlayerMovement>.Instance.DeregisterMovementEvent(new Action(this.Refresh));
			}
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x000F7351 File Offset: 0x000F5551
		private void RegisterEvent()
		{
			Player.onLocalPlayerSpawned = (Action)Delegate.Remove(Player.onLocalPlayerSpawned, new Action(this.RegisterEvent));
			PlayerSingleton<PlayerMovement>.Instance.RegisterMovementEvent(5, new Action(this.Refresh));
		}

		// Token: 0x06003AB1 RID: 15025 RVA: 0x000F738A File Offset: 0x000F558A
		[Button]
		public void GetColliders()
		{
			this.Colliders = base.GetComponentsInChildren<Collider>();
		}

		// Token: 0x06003AB2 RID: 15026 RVA: 0x000045B1 File Offset: 0x000027B1
		public void Start()
		{
		}

		// Token: 0x06003AB3 RID: 15027 RVA: 0x000F7398 File Offset: 0x000F5598
		private void Refresh()
		{
			if (Player.Local == null || Player.Local.Avatar == null)
			{
				return;
			}
			float sqrMagnitude = (Player.Local.Avatar.CenterPoint - base.transform.position).sqrMagnitude;
			this.SetCollidersEnabled(sqrMagnitude < this.sqrColliderEnableMaxDistance);
		}

		// Token: 0x06003AB4 RID: 15028 RVA: 0x000F73FC File Offset: 0x000F55FC
		private void SetCollidersEnabled(bool enabled)
		{
			if (this.collidersEnabled == enabled)
			{
				return;
			}
			this.collidersEnabled = enabled;
			foreach (Collider collider in this.Colliders)
			{
				if (!(collider == null))
				{
					collider.enabled = enabled;
				}
			}
		}

		// Token: 0x04002A3B RID: 10811
		public const int UPDATE_DISTANCE = 5;

		// Token: 0x04002A3C RID: 10812
		public Collider[] Colliders;

		// Token: 0x04002A3D RID: 10813
		public float ColliderEnableMaxDistance = 30f;

		// Token: 0x04002A3E RID: 10814
		private float sqrColliderEnableMaxDistance;

		// Token: 0x04002A3F RID: 10815
		private bool collidersEnabled = true;
	}
}
