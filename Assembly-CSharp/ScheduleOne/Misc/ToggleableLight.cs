using System;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Misc
{
	// Token: 0x02000C0D RID: 3085
	public class ToggleableLight : MonoBehaviour
	{
		// Token: 0x060056C4 RID: 22212 RVA: 0x0016CFA8 File Offset: 0x0016B1A8
		protected virtual void Awake()
		{
			this.constructable = base.GetComponentInParent<Constructable_GridBased>();
			this.SetLights(this.isOn);
		}

		// Token: 0x060056C5 RID: 22213 RVA: 0x0016CFC2 File Offset: 0x0016B1C2
		private void OnValidate()
		{
			if (this.isOn != this.lightsApplied)
			{
				this.SetLights(this.isOn);
			}
		}

		// Token: 0x060056C6 RID: 22214 RVA: 0x0016CFC2 File Offset: 0x0016B1C2
		protected virtual void Update()
		{
			if (this.isOn != this.lightsApplied)
			{
				this.SetLights(this.isOn);
			}
		}

		// Token: 0x060056C7 RID: 22215 RVA: 0x0016CFDE File Offset: 0x0016B1DE
		public void TurnOn()
		{
			this.isOn = true;
			this.Update();
		}

		// Token: 0x060056C8 RID: 22216 RVA: 0x0016CFED File Offset: 0x0016B1ED
		public void TurnOff()
		{
			this.isOn = false;
			this.Update();
		}

		// Token: 0x060056C9 RID: 22217 RVA: 0x0016CFFC File Offset: 0x0016B1FC
		protected virtual void SetLights(bool active)
		{
			this.lightsApplied = this.isOn;
			foreach (OptimizedLight optimizedLight in this.lightSources)
			{
				if (!(optimizedLight == null))
				{
					optimizedLight.Enabled = active;
				}
			}
			Material material = active ? this.lightOnMat : this.lightOffMat;
			foreach (MeshRenderer meshRenderer in this.lightSurfacesMeshes)
			{
				if (!(meshRenderer == null))
				{
					Material[] sharedMaterials = meshRenderer.sharedMaterials;
					sharedMaterials[this.MaterialIndex] = material;
					meshRenderer.materials = sharedMaterials;
				}
			}
		}

		// Token: 0x04004020 RID: 16416
		public bool isOn;

		// Token: 0x04004021 RID: 16417
		[Header("References")]
		[SerializeField]
		protected OptimizedLight[] lightSources;

		// Token: 0x04004022 RID: 16418
		[SerializeField]
		protected MeshRenderer[] lightSurfacesMeshes;

		// Token: 0x04004023 RID: 16419
		public int MaterialIndex;

		// Token: 0x04004024 RID: 16420
		[Header("Materials")]
		[SerializeField]
		protected Material lightOnMat;

		// Token: 0x04004025 RID: 16421
		[SerializeField]
		protected Material lightOffMat;

		// Token: 0x04004026 RID: 16422
		private Constructable_GridBased constructable;

		// Token: 0x04004027 RID: 16423
		private bool lightsApplied;
	}
}
