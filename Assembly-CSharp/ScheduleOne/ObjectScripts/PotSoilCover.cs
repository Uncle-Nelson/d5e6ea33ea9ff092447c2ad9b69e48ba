using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BAD RID: 2989
	public class PotSoilCover : MonoBehaviour
	{
		// Token: 0x060050BD RID: 20669 RVA: 0x000045B1 File Offset: 0x000027B1
		private void Awake()
		{
		}

		// Token: 0x060050BE RID: 20670 RVA: 0x001546F3 File Offset: 0x001528F3
		private void OnEnable()
		{
			base.StartCoroutine(this.CheckQueue());
		}

		// Token: 0x060050BF RID: 20671 RVA: 0x00154702 File Offset: 0x00152902
		public void ConfigureAppearance(Color col, float transparency)
		{
			this.MeshRenderer.material.SetColor("_MainColor", col);
			this.MeshRenderer.material.SetFloat("_Transparency", transparency);
		}

		// Token: 0x060050C0 RID: 20672 RVA: 0x00154730 File Offset: 0x00152930
		public void Reset()
		{
			this.Blank();
			this.CurrentCoverage = 0.215f;
		}

		// Token: 0x060050C1 RID: 20673 RVA: 0x00154743 File Offset: 0x00152943
		public void QueuePour(Vector3 worldSpacePosition)
		{
			this.queued = true;
			this.queuedWorldPos = worldSpacePosition;
		}

		// Token: 0x060050C2 RID: 20674 RVA: 0x00154753 File Offset: 0x00152953
		public float GetNormalizedProgress()
		{
			return (this.CurrentCoverage - 0.215f) / 0.735f;
		}

		// Token: 0x060050C3 RID: 20675 RVA: 0x00154767 File Offset: 0x00152967
		private IEnumerator CheckQueue()
		{
			while (base.gameObject != null)
			{
				if (this.queued)
				{
					this.queued = false;
					this.DelayedApplyPour(this.queuedWorldPos);
				}
				yield return new WaitForSeconds(0.041666668f);
			}
			yield break;
		}

		// Token: 0x060050C4 RID: 20676 RVA: 0x00154778 File Offset: 0x00152978
		private void Blank()
		{
			Texture2D texture2D = new Texture2D(128, 128);
			Color[] array = new Color[16384];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Color.black;
			}
			texture2D.SetPixels(array);
			texture2D.Apply();
			this.MeshRenderer.material.mainTexture = texture2D;
			this.mainTex = texture2D;
		}

		// Token: 0x060050C5 RID: 20677 RVA: 0x001547E0 File Offset: 0x001529E0
		private void DelayedApplyPour(Vector3 worldSpace)
		{
			PotSoilCover.<>c__DisplayClass27_0 CS$<>8__locals1 = new PotSoilCover.<>c__DisplayClass27_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.worldSpace = worldSpace;
			base.StartCoroutine(CS$<>8__locals1.<DelayedApplyPour>g__Routine|0());
		}

		// Token: 0x060050C6 RID: 20678 RVA: 0x00154810 File Offset: 0x00152A10
		private void ApplyPour(Vector3 worldSpace)
		{
			this.relative = base.transform.InverseTransformPoint(worldSpace);
			this.vector2 = new Vector2(this.relative.x, this.relative.z);
			if (this.vector2.magnitude > this.Radius)
			{
				return;
			}
			this.normalizedOffset = new Vector2(this.vector2.x / this.Radius, this.vector2.y / this.Radius);
			this.originPixel = new Vector2(64f * (1f + this.normalizedOffset.x), 64f * (1f + this.normalizedOffset.y));
			for (int i = 0; i < 64; i++)
			{
				for (int j = 0; j < 64; j++)
				{
					int num = (int)this.originPixel.x - 32 + i;
					int num2 = (int)this.originPixel.y - 32 + j;
					if (num >= 0 && num < 128 && num2 >= 0 && num2 < 128)
					{
						Color pixel = this.mainTex.GetPixel(num, num2);
						pixel.r += this.GetPourMaskValue(i, j);
						pixel.g = pixel.r;
						pixel.b = pixel.r;
						pixel.a = 1f;
						this.mainTex.SetPixel(num, num2, pixel);
					}
				}
			}
			this.mainTex.Apply();
			float currentCoverage = this.CurrentCoverage;
			float coverage = this.GetCoverage();
			this.CurrentCoverage = coverage;
			if (coverage >= 0.95f && currentCoverage < 0.95f && this.onSufficientCoverage != null)
			{
				this.onSufficientCoverage.Invoke();
			}
		}

		// Token: 0x060050C7 RID: 20679 RVA: 0x001549D8 File Offset: 0x00152BD8
		private float GetPourMaskValue(int x, int y)
		{
			return this.PourMask.GetPixel(x, y).grayscale;
		}

		// Token: 0x060050C8 RID: 20680 RVA: 0x001549FC File Offset: 0x00152BFC
		private float GetCoverage()
		{
			int num = 16384;
			int num2 = 0;
			for (int i = 0; i < 128; i++)
			{
				for (int j = 0; j < 128; j++)
				{
					if (this.mainTex.GetPixel(i, j).r > 0.5f)
					{
						num2++;
					}
				}
			}
			return Mathf.Clamp01((float)num2 / (float)num + 0.215f);
		}

		// Token: 0x04003CB7 RID: 15543
		public const int TEXTURE_SIZE = 128;

		// Token: 0x04003CB8 RID: 15544
		public const int POUR_RADIUS = 32;

		// Token: 0x04003CB9 RID: 15545
		public const int UPDATES_PER_SECOND = 24;

		// Token: 0x04003CBA RID: 15546
		public const float COVERAGE_THRESHOLD = 0.5f;

		// Token: 0x04003CBB RID: 15547
		public const float BASE_COVERAGE = 0.215f;

		// Token: 0x04003CBC RID: 15548
		public const float SUCCESS_COVERAGE_THRESHOLD = 0.95f;

		// Token: 0x04003CBD RID: 15549
		public const float DELAY = 0.35f;

		// Token: 0x04003CBE RID: 15550
		public float CurrentCoverage;

		// Token: 0x04003CBF RID: 15551
		[Header("Settings")]
		public float Radius;

		// Token: 0x04003CC0 RID: 15552
		[Header("References")]
		public MeshRenderer MeshRenderer;

		// Token: 0x04003CC1 RID: 15553
		public Texture2D PourMask;

		// Token: 0x04003CC2 RID: 15554
		public UnityEvent onSufficientCoverage;

		// Token: 0x04003CC3 RID: 15555
		private bool queued;

		// Token: 0x04003CC4 RID: 15556
		private Vector3 queuedWorldPos = Vector3.zero;

		// Token: 0x04003CC5 RID: 15557
		private Texture2D mainTex;

		// Token: 0x04003CC6 RID: 15558
		private Vector3 relative;

		// Token: 0x04003CC7 RID: 15559
		private Vector2 vector2;

		// Token: 0x04003CC8 RID: 15560
		private Vector2 normalizedOffset;

		// Token: 0x04003CC9 RID: 15561
		private Vector2 originPixel;
	}
}
