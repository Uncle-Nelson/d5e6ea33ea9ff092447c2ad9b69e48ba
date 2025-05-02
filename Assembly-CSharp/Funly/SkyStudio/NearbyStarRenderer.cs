using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000187 RID: 391
	public class NearbyStarRenderer : BaseStarDataRenderer
	{
		// Token: 0x06000807 RID: 2055 RVA: 0x00025ABC File Offset: 0x00023CBC
		private RenderTexture CreateRenderTexture(string name, int renderTextureSize, RenderTextureFormat format)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(renderTextureSize, renderTextureSize, 0, format, RenderTextureReadWrite.Linear);
			temporary.filterMode = FilterMode.Point;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary.name = name;
			return temporary;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00025AE0 File Offset: 0x00023CE0
		private Material GetNearbyStarMaterial(Vector4 randomSeed, int starCount)
		{
			Material material = new Material(new Material(Shader.Find("Hidden/Funly/Sky Studio/Computation/StarCalcNearby")));
			material.hideFlags = HideFlags.HideAndDontSave;
			material.SetFloat("_StarDensity", this.density);
			material.SetFloat("_NumStarPoints", (float)starCount);
			material.SetVector("_RandomSeed", randomSeed);
			material.SetFloat("_TextureSize", 2048f);
			return material;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00025B44 File Offset: 0x00023D44
		private void WriteDebugTexture(RenderTexture rt, string path)
		{
			Texture2D texture2D = this.ConvertToTexture2D(rt);
			File.WriteAllBytes(path, ImageConversion.EncodeToPNG(texture2D));
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00025B68 File Offset: 0x00023D68
		private Texture2D GetStarListTexture(string starTexKey, out int validStarPixelCount)
		{
			Texture2D texture2D = new Texture2D(2048, 1, TextureFormat.RGBAFloat, false, true);
			texture2D.filterMode = FilterMode.Point;
			int num = 0;
			float num2 = this.maxRadius * 2.1f;
			List<Vector4> list = new List<Vector4>();
			bool flag = this.maxRadius > 0.0015f;
			int i = 0;
			while (i < 2000)
			{
				Vector3 onUnitSphere = Random.onUnitSphere;
				if (!flag)
				{
					goto IL_86;
				}
				bool flag2 = false;
				for (int j = 0; j < list.Count; j++)
				{
					if (Vector3.Distance(onUnitSphere, list[j]) < num2)
					{
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					goto IL_86;
				}
				IL_BE:
				i++;
				continue;
				IL_86:
				list.Add(onUnitSphere);
				texture2D.SetPixel(num, 0, new Color(onUnitSphere.x, onUnitSphere.y, onUnitSphere.z, 0f));
				num++;
				goto IL_BE;
			}
			texture2D.Apply();
			validStarPixelCount = num;
			return texture2D;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00025C4F File Offset: 0x00023E4F
		public override IEnumerator ComputeStarData()
		{
			base.SendProgress(0f);
			RenderTexture renderTexture = this.CreateRenderTexture("Nearby Star " + this.layerId, (int)this.imageSize, RenderTextureFormat.ARGB32);
			RenderTexture active = RenderTexture.active;
			Random.State state = Random.state;
			Random.InitState(this.layerId.GetHashCode());
			Vector4 randomSeed = new Vector4(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			int val;
			Texture starListTexture = this.GetStarListTexture(this.layerId, out val);
			int starCount = Math.Min(Mathf.FloorToInt(Mathf.Clamp01(this.density) * 2000f), val);
			RenderTexture.active = renderTexture;
			Material nearbyStarMaterial = this.GetNearbyStarMaterial(randomSeed, starCount);
			Graphics.Blit(starListTexture, nearbyStarMaterial);
			Texture2D texture = this.ConvertToTexture2D(renderTexture);
			RenderTexture.active = active;
			renderTexture.Release();
			Random.state = state;
			base.SendCompletion(texture, true);
			yield break;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00025C60 File Offset: 0x00023E60
		private Texture2D ConvertToTexture2D(RenderTexture rt)
		{
			Texture2D texture2D = new Texture2D(rt.width, rt.height, TextureFormat.RGBA32, false);
			texture2D.name = this.layerId;
			texture2D.filterMode = FilterMode.Point;
			texture2D.wrapMode = TextureWrapMode.Clamp;
			texture2D.ReadPixels(new Rect(0f, 0f, (float)rt.width, (float)rt.height), 0, 0, false);
			texture2D.Apply(false);
			return texture2D;
		}

		// Token: 0x04000921 RID: 2337
		private const int kMaxStars = 2000;

		// Token: 0x04000922 RID: 2338
		private const int kStarPointTextureWidth = 2048;

		// Token: 0x04000923 RID: 2339
		private const float kStarPaddingRadiusMultipler = 2.1f;
	}
}
