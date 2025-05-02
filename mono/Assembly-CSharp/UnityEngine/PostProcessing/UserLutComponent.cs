using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000091 RID: 145
	public sealed class UserLutComponent : PostProcessingComponentRenderTexture<UserLutModel>
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00012254 File Offset: 0x00010454
		public override bool active
		{
			get
			{
				UserLutModel.Settings settings = base.model.settings;
				return base.model.enabled && settings.lut != null && settings.contribution > 0f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && !this.context.interrupted;
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000122C4 File Offset: 0x000104C4
		public override void Prepare(Material uberMaterial)
		{
			UserLutModel.Settings settings = base.model.settings;
			uberMaterial.EnableKeyword("USER_LUT");
			uberMaterial.SetTexture(UserLutComponent.Uniforms._UserLut, settings.lut);
			uberMaterial.SetVector(UserLutComponent.Uniforms._UserLut_Params, new Vector4(1f / (float)settings.lut.width, 1f / (float)settings.lut.height, (float)settings.lut.height - 1f, settings.contribution));
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00012348 File Offset: 0x00010548
		public void OnGUI()
		{
			UserLutModel.Settings settings = base.model.settings;
			GUI.DrawTexture(new Rect(this.context.viewport.x * (float)Screen.width + 8f, 8f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
		}

		// Token: 0x02000092 RID: 146
		private static class Uniforms
		{
			// Token: 0x0400036C RID: 876
			internal static readonly int _UserLut = Shader.PropertyToID("_UserLut");

			// Token: 0x0400036D RID: 877
			internal static readonly int _UserLut_Params = Shader.PropertyToID("_UserLut_Params");
		}
	}
}
