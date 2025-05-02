using System;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006E5 RID: 1765
	public class LightOptimizer : MonoBehaviour
	{
		// Token: 0x06003005 RID: 12293 RVA: 0x000C7FE5 File Offset: 0x000C61E5
		public void Awake()
		{
			this.lights = base.GetComponentsInChildren<OptimizedLight>();
		}

		// Token: 0x06003006 RID: 12294 RVA: 0x000C7FF4 File Offset: 0x000C61F4
		public void FixedUpdate()
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			OptimizedLight[] array;
			if (Vector3.Distance(base.transform.position, PlayerSingleton<PlayerCamera>.Instance.transform.position) > this.checkRange)
			{
				array = this.lights;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].DisabledForOptimization = true;
				}
				return;
			}
			if (this.activationZones.Length == 0 && this.viewPoints.Length == 0)
			{
				this.ApplyLights();
				return;
			}
			BoxCollider[] array2 = this.activationZones;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i].bounds.Contains(PlayerSingleton<PlayerCamera>.Instance.transform.position))
				{
					this.ApplyLights();
					return;
				}
			}
			GeometryUtility.CalculateFrustumPlanes(PlayerSingleton<PlayerCamera>.Instance.Camera);
			foreach (Transform transform in this.viewPoints)
			{
				if (this.PointInCameraView(transform.position))
				{
					this.ApplyLights();
					return;
				}
			}
			array = this.lights;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DisabledForOptimization = true;
			}
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x000C8108 File Offset: 0x000C6308
		public void ApplyLights()
		{
			OptimizedLight[] array = this.lights;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DisabledForOptimization = false;
			}
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x000C8134 File Offset: 0x000C6334
		public bool PointInCameraView(Vector3 point)
		{
			Camera camera = PlayerSingleton<PlayerCamera>.Instance.Camera;
			bool flag = camera.WorldToViewportPoint(point).z > -1f;
			bool flag2 = false;
			Vector3 normalized = (point - camera.transform.position).normalized;
			float num = Vector3.Distance(camera.transform.position, point);
			RaycastHit raycastHit;
			if (Physics.Raycast(camera.transform.position, normalized, ref raycastHit, num + 0.05f, 1 << LayerMask.NameToLayer("Default")) && raycastHit.point != point)
			{
				flag2 = true;
			}
			return flag && !flag2;
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x0009E989 File Offset: 0x0009CB89
		public bool Is01(float a)
		{
			return a > 0f && a < 1f;
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x000C81D3 File Offset: 0x000C63D3
		public void LightsEnabled_True()
		{
			this.LightsEnabled = true;
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x000C81DC File Offset: 0x000C63DC
		public void LightsEnabled_False()
		{
			this.LightsEnabled = false;
		}

		// Token: 0x04002222 RID: 8738
		public bool LightsEnabled = true;

		// Token: 0x04002223 RID: 8739
		[Header("References")]
		[SerializeField]
		protected BoxCollider[] activationZones;

		// Token: 0x04002224 RID: 8740
		[SerializeField]
		protected Transform[] viewPoints;

		// Token: 0x04002225 RID: 8741
		[Header("Settings")]
		public float checkRange = 50f;

		// Token: 0x04002226 RID: 8742
		protected OptimizedLight[] lights;
	}
}
