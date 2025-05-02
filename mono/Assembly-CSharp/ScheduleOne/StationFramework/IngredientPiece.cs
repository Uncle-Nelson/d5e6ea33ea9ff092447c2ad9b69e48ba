using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008C7 RID: 2247
	[RequireComponent(typeof(Draggable))]
	public class IngredientPiece : MonoBehaviour
	{
		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06003D09 RID: 15625 RVA: 0x00100988 File Offset: 0x000FEB88
		// (set) Token: 0x06003D0A RID: 15626 RVA: 0x00100990 File Offset: 0x000FEB90
		public float CurrentDissolveAmount { get; private set; }

		// Token: 0x06003D0B RID: 15627 RVA: 0x00100999 File Offset: 0x000FEB99
		private void Start()
		{
			base.InvokeRepeating("CheckLiquid", 0f, 0.05f);
			this.draggable = base.GetComponent<Draggable>();
			this.defaultDrag = this.draggable.NormalRBDrag;
		}

		// Token: 0x06003D0C RID: 15628 RVA: 0x001009CD File Offset: 0x000FEBCD
		private void Update()
		{
			if (this.DisableInteractionInLiquid && this.CurrentLiquidContainer != null)
			{
				this.draggable.ClickableEnabled = false;
			}
		}

		// Token: 0x06003D0D RID: 15629 RVA: 0x001009F1 File Offset: 0x000FEBF1
		private void FixedUpdate()
		{
			this.UpdateDrag();
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x001009FC File Offset: 0x000FEBFC
		private void UpdateDrag()
		{
			if (this.CurrentLiquidContainer != null)
			{
				Vector3 a = -this.draggable.Rb.velocity.normalized;
				float d = this.CurrentLiquidContainer.Viscosity * this.draggable.Rb.velocity.magnitude * 100f * this.LiquidFrictionMultiplier;
				this.draggable.Rb.AddForce(a * d, 5);
			}
		}

		// Token: 0x06003D0F RID: 15631 RVA: 0x00100A80 File Offset: 0x000FEC80
		private void CheckLiquid()
		{
			this.CurrentLiquidContainer = null;
			if (!this.DetectLiquid)
			{
				return;
			}
			Collider[] array = Physics.OverlapSphere(base.transform.position, 0.001f, 1 << LayerMask.NameToLayer("Task"), 2);
			for (int i = 0; i < array.Length; i++)
			{
				LiquidVolumeCollider liquidVolumeCollider;
				if (array[i].isTrigger && array[i].TryGetComponent<LiquidVolumeCollider>(out liquidVolumeCollider))
				{
					this.CurrentLiquidContainer = liquidVolumeCollider.LiquidContainer;
					return;
				}
			}
		}

		// Token: 0x06003D10 RID: 15632 RVA: 0x00100AF4 File Offset: 0x000FECF4
		public void DissolveAmount(float amount, bool showParticles = true)
		{
			if (this.CurrentDissolveAmount >= 1f)
			{
				return;
			}
			this.CurrentDissolveAmount = Mathf.Clamp01(this.CurrentDissolveAmount + amount);
			this.ModelContainer.transform.localScale = Vector3.one * (1f - this.CurrentDissolveAmount);
			if (showParticles)
			{
				if (!this.DissolveParticles.isPlaying)
				{
					this.DissolveParticles.Play();
				}
				if (this.dissolveParticleRoutine != null)
				{
					base.StopCoroutine(this.dissolveParticleRoutine);
				}
				this.dissolveParticleRoutine = base.StartCoroutine(this.<DissolveAmount>g__DissolveParticlesRoutine|19_0());
			}
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x00100BAA File Offset: 0x000FEDAA
		[CompilerGenerated]
		private IEnumerator <DissolveAmount>g__DissolveParticlesRoutine|19_0()
		{
			yield return new WaitForSeconds(0.2f);
			this.DissolveParticles.Stop();
			this.dissolveParticleRoutine = null;
			yield break;
		}

		// Token: 0x04002BDD RID: 11229
		public const float LIQUID_FRICTION = 100f;

		// Token: 0x04002BDF RID: 11231
		public LiquidContainer CurrentLiquidContainer;

		// Token: 0x04002BE0 RID: 11232
		[Header("References")]
		public Transform ModelContainer;

		// Token: 0x04002BE1 RID: 11233
		public ParticleSystem DissolveParticles;

		// Token: 0x04002BE2 RID: 11234
		[Header("Settings")]
		public bool DetectLiquid = true;

		// Token: 0x04002BE3 RID: 11235
		public bool DisableInteractionInLiquid = true;

		// Token: 0x04002BE4 RID: 11236
		[Range(0f, 2f)]
		public float LiquidFrictionMultiplier = 1f;

		// Token: 0x04002BE5 RID: 11237
		private Draggable draggable;

		// Token: 0x04002BE6 RID: 11238
		private float defaultDrag;

		// Token: 0x04002BE7 RID: 11239
		private Coroutine dissolveParticleRoutine;
	}
}
