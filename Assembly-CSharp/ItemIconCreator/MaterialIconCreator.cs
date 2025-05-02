using System;
using System.Collections;
using UnityEngine;

namespace ItemIconCreator
{
	// Token: 0x02000224 RID: 548
	[ExecuteInEditMode]
	public class MaterialIconCreator : IconCreator
	{
		// Token: 0x06000BAC RID: 2988 RVA: 0x000365BC File Offset: 0x000347BC
		public override void BuildIcons()
		{
			base.StartCoroutine(this.BuildIconsRotine());
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x000365CB File Offset: 0x000347CB
		public override bool CheckConditions()
		{
			if (!base.CheckConditions())
			{
				return false;
			}
			if (this.materials.Length == 0)
			{
				Debug.LogError("There's no materials");
				return false;
			}
			if (this.targetRenderer == null)
			{
				Debug.LogError("There's no target renderer");
				return false;
			}
			return true;
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00036607 File Offset: 0x00034807
		private IEnumerator BuildIconsRotine()
		{
			base.Initialize();
			if (this.dynamicFov)
			{
				base.UpdateFOV(this.targetRenderer.gameObject);
			}
			if (this.lookAtObjectCenter)
			{
				base.LookAtTargetCenter(this.targetRenderer.gameObject);
			}
			this.currentObject = this.targetRenderer.transform;
			yield return base.CaptureFrame(this.targetRenderer.name, 0);
			int num;
			for (int i = 0; i < this.materials.Length; i = num + 1)
			{
				this.targetRenderer.material = this.materials[i];
				this.targetRenderer.materials[0] = this.materials[i];
				if (IconCreatorCanvas.instance != null)
				{
					IconCreatorCanvas.instance.SetInfo(this.materials.Length, i, this.materials[i].name, true, this.nextIconKey);
				}
				if (this.whiteCam != null)
				{
					this.whiteCam.enabled = false;
				}
				if (this.whiteCam != null)
				{
					this.blackCam.enabled = false;
				}
				if (this.mode == IconCreator.Mode.Manual)
				{
					this.CanMove = true;
					yield return new WaitUntil(() => Input.GetKeyDown(this.nextIconKey));
					this.CanMove = false;
				}
				if (IconCreatorCanvas.instance != null)
				{
					IconCreatorCanvas.instance.SetTakingPicture();
					yield return null;
					yield return null;
					yield return null;
				}
				yield return base.CaptureFrame(this.materials[i].name, i);
				num = i;
			}
			if (IconCreatorCanvas.instance != null)
			{
				IconCreatorCanvas.instance.SetInfo(0, 0, "", false, this.nextIconKey);
			}
			base.RevealInFinder();
			base.DeleteCameras();
			yield break;
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00036616 File Offset: 0x00034816
		private void Reset()
		{
			this.targetRenderer = null;
			this.materials = new Material[0];
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0003662C File Offset: 0x0003482C
		protected override void Update()
		{
			if (this.preview && !this.isCreatingIcons)
			{
				if (this.targetRenderer != null)
				{
					if (this.dynamicFov)
					{
						base.UpdateFOV(this.targetRenderer.gameObject);
					}
					if (this.lookAtObjectCenter)
					{
						base.LookAtTargetCenter(this.targetRenderer.gameObject);
					}
				}
				return;
			}
			base.Update();
		}

		// Token: 0x04000D1E RID: 3358
		public Renderer targetRenderer;

		// Token: 0x04000D1F RID: 3359
		public Material[] materials;
	}
}
