using System;
using LiquidVolumeFX;
using ScheduleOne.DevUtilities;
using ScheduleOne.FX;
using ScheduleOne.GameTime;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008CA RID: 2250
	public class LiquidContainer : MonoBehaviour
	{
		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06003D1F RID: 15647 RVA: 0x00100C60 File Offset: 0x000FEE60
		// (set) Token: 0x06003D20 RID: 15648 RVA: 0x00100C68 File Offset: 0x000FEE68
		public float CurrentLiquidLevel { get; private set; }

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06003D21 RID: 15649 RVA: 0x00100C71 File Offset: 0x000FEE71
		// (set) Token: 0x06003D22 RID: 15650 RVA: 0x00100C79 File Offset: 0x000FEE79
		public Color LiquidColor { get; private set; } = Color.white;

		// Token: 0x06003D23 RID: 15651 RVA: 0x00100C82 File Offset: 0x000FEE82
		private void Awake()
		{
			this.liquidMesh = this.LiquidVolume.GetComponent<MeshRenderer>();
			this.SetLiquidColor(this.LiquidVolume.liquidColor1, true, true);
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x00100CA8 File Offset: 0x000FEEA8
		private void Start()
		{
			this.LiquidVolume.directionalLight = Singleton<EnvironmentFX>.Instance.SunLight;
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x00100CE5 File Offset: 0x000FEEE5
		private void OnDestroy()
		{
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			}
		}

		// Token: 0x06003D26 RID: 15654 RVA: 0x00100D14 File Offset: 0x000FEF14
		private void MinPass()
		{
			this.UpdateLighting();
		}

		// Token: 0x06003D27 RID: 15655 RVA: 0x00100D1C File Offset: 0x000FEF1C
		private void UpdateLighting()
		{
			if (this.AdjustMurkiness)
			{
				float t = Mathf.Abs((float)NetworkSingleton<TimeManager>.Instance.DailyMinTotal / 1440f - 0.5f) / 0.5f;
				float b = Mathf.Lerp(1f, 0.75f, t);
				this.SetLiquidColor(this.LiquidColor * b, false, false);
			}
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x00100D7C File Offset: 0x000FEF7C
		public void SetLiquidLevel(float level, bool debug = false)
		{
			if (debug)
			{
				Console.Log("setting liquid level to: " + level.ToString(), null);
			}
			this.CurrentLiquidLevel = Mathf.Clamp01(level);
			this.LiquidVolume.level = Mathf.Lerp(0f, this.MaxLevel, this.CurrentLiquidLevel);
			if (this.liquidMesh != null)
			{
				this.liquidMesh.enabled = (this.CurrentLiquidLevel > 0.01f);
			}
			if (this.Collider != null && this.ColliderTransform_Min != null && this.ColliderTransform_Max != null)
			{
				this.Collider.transform.localPosition = Vector3.Lerp(this.ColliderTransform_Min.localPosition, this.ColliderTransform_Max.localPosition, this.CurrentLiquidLevel);
				this.Collider.transform.localScale = Vector3.Lerp(this.ColliderTransform_Min.localScale, this.ColliderTransform_Max.localScale, this.CurrentLiquidLevel);
			}
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x00100E82 File Offset: 0x000FF082
		public void SetLiquidColor(Color color, bool setColorVariable = true, bool updateLigting = true)
		{
			if (setColorVariable)
			{
				this.LiquidColor = color;
			}
			this.LiquidVolume.liquidColor1 = color;
			this.LiquidVolume.liquidColor2 = color;
			if (updateLigting)
			{
				this.UpdateLighting();
			}
		}

		// Token: 0x04002BEF RID: 11247
		[Header("Settings")]
		[Range(0f, 1f)]
		public float Viscosity = 0.4f;

		// Token: 0x04002BF0 RID: 11248
		public bool AdjustMurkiness = true;

		// Token: 0x04002BF1 RID: 11249
		[Header("References")]
		public LiquidVolume LiquidVolume;

		// Token: 0x04002BF2 RID: 11250
		public LiquidVolumeCollider Collider;

		// Token: 0x04002BF3 RID: 11251
		public Transform ColliderTransform_Min;

		// Token: 0x04002BF4 RID: 11252
		public Transform ColliderTransform_Max;

		// Token: 0x04002BF5 RID: 11253
		[Header("Visuals Settings")]
		public float MaxLevel = 1f;

		// Token: 0x04002BF6 RID: 11254
		private MeshRenderer liquidMesh;
	}
}
