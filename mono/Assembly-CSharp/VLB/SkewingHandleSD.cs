using System;
using System.Collections;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000142 RID: 322
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-skewinghandle-sd/")]
	public class SkewingHandleSD : MonoBehaviour
	{
		// Token: 0x060005C6 RID: 1478 RVA: 0x0001B6D6 File Offset: 0x000198D6
		public bool IsAttachedToSelf()
		{
			return this.volumetricLightBeam != null && this.volumetricLightBeam.gameObject == base.gameObject;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0001B6FE File Offset: 0x000198FE
		public bool CanSetSkewingVector()
		{
			return this.volumetricLightBeam != null && this.volumetricLightBeam.canHaveMeshSkewing;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0001B71B File Offset: 0x0001991B
		public bool CanUpdateEachFrame()
		{
			return this.CanSetSkewingVector() && this.volumetricLightBeam.trackChangesDuringPlaytime;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0001B732 File Offset: 0x00019932
		private bool ShouldUpdateEachFrame()
		{
			return this.shouldUpdateEachFrame && this.CanUpdateEachFrame();
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0001B744 File Offset: 0x00019944
		private void OnEnable()
		{
			if (this.CanSetSkewingVector())
			{
				this.SetSkewingVector();
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0001B754 File Offset: 0x00019954
		private void Start()
		{
			if (Application.isPlaying && this.ShouldUpdateEachFrame())
			{
				base.StartCoroutine(this.CoUpdate());
			}
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0001B772 File Offset: 0x00019972
		private IEnumerator CoUpdate()
		{
			while (this.ShouldUpdateEachFrame())
			{
				this.SetSkewingVector();
				yield return null;
			}
			yield break;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0001B784 File Offset: 0x00019984
		private void SetSkewingVector()
		{
			Vector3 skewingLocalForwardDirection = this.volumetricLightBeam.transform.InverseTransformPoint(base.transform.position);
			this.volumetricLightBeam.skewingLocalForwardDirection = skewingLocalForwardDirection;
		}

		// Token: 0x040006C9 RID: 1737
		public const string ClassName = "SkewingHandleSD";

		// Token: 0x040006CA RID: 1738
		public VolumetricLightBeamSD volumetricLightBeam;

		// Token: 0x040006CB RID: 1739
		public bool shouldUpdateEachFrame;
	}
}
