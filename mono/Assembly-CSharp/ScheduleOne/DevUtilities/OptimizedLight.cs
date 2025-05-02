using System;
using System.Runtime.CompilerServices;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006EC RID: 1772
	[RequireComponent(typeof(Light))]
	[ExecuteInEditMode]
	public class OptimizedLight : MonoBehaviour
	{
		// Token: 0x06003043 RID: 12355 RVA: 0x000C8E43 File Offset: 0x000C7043
		public virtual void Awake()
		{
			this._Light = base.GetComponent<Light>();
			this.maxDistanceSquared = this.MaxDistance * this.MaxDistance;
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x000C8E64 File Offset: 0x000C7064
		private void Start()
		{
			if (PlayerSingleton<PlayerMovement>.InstanceExists)
			{
				this.<Start>g__Register|7_0();
				return;
			}
			Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(this.<Start>g__Register|7_0));
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x000C8E94 File Offset: 0x000C7094
		private void OnDestroy()
		{
			if (PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				PlayerSingleton<PlayerCamera>.Instance.DeregisterMovementEvent(new Action(this.UpdateCull));
			}
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x000C8EB3 File Offset: 0x000C70B3
		public virtual void FixedUpdate()
		{
			if (this._Light != null)
			{
				this._Light.enabled = (this.Enabled && !this.DisabledForOptimization && !this.culled);
			}
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x000C8EEC File Offset: 0x000C70EC
		private void UpdateCull()
		{
			if (this == null || base.gameObject == null)
			{
				return;
			}
			this.culled = (Vector3.SqrMagnitude(PlayerSingleton<PlayerCamera>.Instance.transform.position - base.transform.position) > this.maxDistanceSquared * QualitySettings.lodBias);
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x000C8F49 File Offset: 0x000C7149
		public void SetEnabled(bool enabled)
		{
			this.Enabled = enabled;
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x000C8F6C File Offset: 0x000C716C
		[CompilerGenerated]
		private void <Start>g__Register|7_0()
		{
			Player.onLocalPlayerSpawned = (Action)Delegate.Remove(Player.onLocalPlayerSpawned, new Action(this.<Start>g__Register|7_0));
			PlayerSingleton<PlayerCamera>.Instance.RegisterMovementEvent(Mathf.RoundToInt(Mathf.Clamp(this.MaxDistance / 10f, 0.5f, 20f)), new Action(this.UpdateCull));
		}

		// Token: 0x04002247 RID: 8775
		public bool Enabled = true;

		// Token: 0x04002248 RID: 8776
		[HideInInspector]
		public bool DisabledForOptimization;

		// Token: 0x04002249 RID: 8777
		[Range(10f, 500f)]
		public float MaxDistance = 100f;

		// Token: 0x0400224A RID: 8778
		public Light _Light;

		// Token: 0x0400224B RID: 8779
		private bool culled;

		// Token: 0x0400224C RID: 8780
		private float maxDistanceSquared;
	}
}
