using System;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x0200095A RID: 2394
	public class Accessory : MonoBehaviour
	{
		// Token: 0x060040D5 RID: 16597 RVA: 0x001101A4 File Offset: 0x0010E3A4
		private void Awake()
		{
			for (int i = 0; i < this.skinnedMeshesToBind.Length; i++)
			{
				this.skinnedMeshesToBind[i].updateWhenOffscreen = true;
			}
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x001101D4 File Offset: 0x0010E3D4
		public void ApplyColor(Color col)
		{
			foreach (MeshRenderer meshRenderer in this.meshesToColor)
			{
				for (int j = 0; j < meshRenderer.materials.Length; j++)
				{
					meshRenderer.materials[j].color = col;
					if (!this.ColorAllMeshes)
					{
						break;
					}
				}
			}
			foreach (SkinnedMeshRenderer skinnedMeshRenderer in this.skinnedMeshesToColor)
			{
				for (int k = 0; k < skinnedMeshRenderer.materials.Length; k++)
				{
					skinnedMeshRenderer.materials[k].color = col;
					if (!this.ColorAllMeshes)
					{
						break;
					}
				}
			}
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x00110270 File Offset: 0x0010E470
		public void ApplyShapeKeys(float gender, float weight)
		{
			foreach (SkinnedMeshRenderer skinnedMeshRenderer in this.shapeKeyMeshRends)
			{
				if (skinnedMeshRenderer.sharedMesh.blendShapeCount >= 2)
				{
					skinnedMeshRenderer.SetBlendShapeWeight(0, gender);
					skinnedMeshRenderer.SetBlendShapeWeight(1, weight);
				}
			}
		}

		// Token: 0x060040D8 RID: 16600 RVA: 0x001102B4 File Offset: 0x0010E4B4
		public void BindBones(Transform[] bones)
		{
			SkinnedMeshRenderer[] array = this.skinnedMeshesToBind;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].bones = bones;
			}
		}

		// Token: 0x04002E6F RID: 11887
		[Header("Settings")]
		public string Name;

		// Token: 0x04002E70 RID: 11888
		public string AssetPath;

		// Token: 0x04002E71 RID: 11889
		public bool ReduceFootSize;

		// Token: 0x04002E72 RID: 11890
		[Range(0f, 1f)]
		public float FootSizeReduction = 1f;

		// Token: 0x04002E73 RID: 11891
		public bool ShouldBlockHair;

		// Token: 0x04002E74 RID: 11892
		public bool ColorAllMeshes = true;

		// Token: 0x04002E75 RID: 11893
		[Header("References")]
		public MeshRenderer[] meshesToColor;

		// Token: 0x04002E76 RID: 11894
		public SkinnedMeshRenderer[] skinnedMeshesToColor;

		// Token: 0x04002E77 RID: 11895
		public SkinnedMeshRenderer[] skinnedMeshesToBind;

		// Token: 0x04002E78 RID: 11896
		public SkinnedMeshRenderer[] shapeKeyMeshRends;
	}
}
