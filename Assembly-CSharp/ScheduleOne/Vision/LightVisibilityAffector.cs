using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.FX;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Vision
{
	// Token: 0x0200027A RID: 634
	[RequireComponent(typeof(Light))]
	public class LightVisibilityAffector : MonoBehaviour
	{
		// Token: 0x06000D34 RID: 3380 RVA: 0x0003A9DE File Offset: 0x00038BDE
		protected virtual void Awake()
		{
			this.light = base.GetComponent<Light>();
			Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(this.PlayerSpawned));
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0003AA0C File Offset: 0x00038C0C
		private void PlayerSpawned()
		{
			Player.onLocalPlayerSpawned = (Action)Delegate.Remove(Player.onLocalPlayerSpawned, new Action(this.PlayerSpawned));
			PlayerSingleton<PlayerMovement>.Instance.RegisterMovementEvent(this.updateDistanceThreshold, new Action(this.UpdateVisibility));
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x0003AA4B File Offset: 0x00038C4B
		private void OnDestroy()
		{
			if (PlayerSingleton<PlayerMovement>.Instance != null)
			{
				PlayerSingleton<PlayerMovement>.Instance.DeregisterMovementEvent(new Action(this.UpdateVisibility));
			}
			this.ClearAttribute();
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0003AA78 File Offset: 0x00038C78
		protected virtual void UpdateVisibility()
		{
			if (this.light == null || base.gameObject == null)
			{
				return;
			}
			if (!this.light.enabled || !base.gameObject.activeInHierarchy)
			{
				this.ClearAttribute();
				return;
			}
			if (Player.Local == null)
			{
				return;
			}
			float num = Player.Local.Visibility.CalculateExposureToPoint(base.transform.position, this.light.range, null);
			if (num == 0f)
			{
				this.ClearAttribute();
				return;
			}
			float num2 = Mathf.Pow(1f - Mathf.Clamp(Vector3.Distance(base.transform.position, Player.Local.Avatar.CenterPoint) / this.light.range, 0f, 1f), 2f);
			float num3 = 1f - Singleton<EnvironmentFX>.Instance.normalizedEnvironmentalBrightness;
			float num4 = 1f;
			if (this.light.type == LightType.Spot)
			{
				float num5 = Vector3.Angle(base.transform.forward, (Player.Local.Avatar.CenterPoint - base.transform.position).normalized);
				if (num5 > this.light.spotAngle * 0.5f)
				{
					num4 = 0f;
				}
				else
				{
					float num6 = this.light.spotAngle * 0.5f - num5;
					float num7 = this.light.spotAngle * 0.5f - this.light.innerSpotAngle * 0.5f;
					num4 = Mathf.Clamp(num6 / num7, 0f, 1f);
				}
			}
			float visibity = num * num2 * this.light.intensity * num3 * num4 * ((this.light.type == LightType.Spot) ? 10f : 15f) * this.EffectMultiplier;
			this.UpdateAttribute(visibity);
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x0003AC5C File Offset: 0x00038E5C
		private void UpdateAttribute(float visibity)
		{
			if (visibity <= 0f)
			{
				this.ClearAttribute();
				return;
			}
			if (this.attribute != null)
			{
				this.attribute.pointsChange = visibity;
				return;
			}
			if (this.uniquenessCode != string.Empty)
			{
				this.attribute = new UniqueVisibilityAttribute("Light Exposure (" + base.gameObject.name + ")", visibity, this.uniquenessCode, 1f, -1);
				return;
			}
			this.attribute = new VisibilityAttribute("Light Exposure (" + base.gameObject.name + ")", visibity, 1f, -1);
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0003ACFE File Offset: 0x00038EFE
		private void ClearAttribute()
		{
			if (this.attribute == null)
			{
				return;
			}
			this.attribute.Delete();
			this.attribute = null;
		}

		// Token: 0x04000DD2 RID: 3538
		public const float PointLightEffect = 15f;

		// Token: 0x04000DD3 RID: 3539
		public const float SpotLightEffect = 10f;

		// Token: 0x04000DD4 RID: 3540
		[Header("Settings")]
		public float EffectMultiplier = 1f;

		// Token: 0x04000DD5 RID: 3541
		public string uniquenessCode = "Light";

		// Token: 0x04000DD6 RID: 3542
		[Tooltip("How far does the player have to move for visibility to be recalculated?")]
		public int updateDistanceThreshold = 1;

		// Token: 0x04000DD7 RID: 3543
		protected Light light;

		// Token: 0x04000DD8 RID: 3544
		protected VisibilityAttribute attribute;
	}
}
