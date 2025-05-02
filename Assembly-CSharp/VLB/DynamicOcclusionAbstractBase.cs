using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB
{
	// Token: 0x0200013A RID: 314
	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeamSD))]
	public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		// Token: 0x0600057B RID: 1403 RVA: 0x0001A716 File Offset: 0x00018916
		public void ProcessOcclusionManually()
		{
			this.ProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource.User);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600057C RID: 1404 RVA: 0x0001A720 File Offset: 0x00018920
		// (remove) Token: 0x0600057D RID: 1405 RVA: 0x0001A758 File Offset: 0x00018958
		public event Action onOcclusionProcessed;

		// Token: 0x0600057E RID: 1406 RVA: 0x0001A790 File Offset: 0x00018990
		protected void ProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			if (!Config.Instance.featureEnabledDynamicOcclusion)
			{
				return;
			}
			if (this.m_LastFrameRendered == Time.frameCount && Application.isPlaying && source == DynamicOcclusionAbstractBase.ProcessOcclusionSource.OnEnable)
			{
				return;
			}
			bool flag = this.OnProcessOcclusion(source);
			if (this.onOcclusionProcessed != null)
			{
				this.onOcclusionProcessed();
			}
			if (this.m_Master)
			{
				this.m_Master._INTERNAL_SetDynamicOcclusionCallback(this.GetShaderKeyword(), flag ? this.m_MaterialModifierCallbackCached : null);
			}
			if (this.updateRate.HasFlag(DynamicOcclusionUpdateRate.OnBeamMove))
			{
				this.m_TransformPacked = base.transform.GetWorldPacked();
			}
			bool flag2 = this.m_LastFrameRendered < 0;
			this.m_LastFrameRendered = Time.frameCount;
			if (flag2 && DynamicOcclusionAbstractBase._INTERNAL_ApplyRandomFrameOffset)
			{
				this.m_LastFrameRendered += Random.Range(0, this.waitXFrames);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0001A867 File Offset: 0x00018A67
		public int _INTERNAL_LastFrameRendered
		{
			get
			{
				return this.m_LastFrameRendered;
			}
		}

		// Token: 0x06000580 RID: 1408
		protected abstract string GetShaderKeyword();

		// Token: 0x06000581 RID: 1409
		protected abstract MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode();

		// Token: 0x06000582 RID: 1410
		protected abstract bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source);

		// Token: 0x06000583 RID: 1411
		protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

		// Token: 0x06000584 RID: 1412
		protected abstract void OnEnablePostValidate();

		// Token: 0x06000585 RID: 1413 RVA: 0x0001A86F File Offset: 0x00018A6F
		protected virtual void OnValidateProperties()
		{
			this.waitXFrames = Mathf.Clamp(this.waitXFrames, 1, 60);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0001A885 File Offset: 0x00018A85
		protected virtual void Awake()
		{
			this.m_Master = base.GetComponent<VolumetricLightBeamSD>();
			this.m_Master._INTERNAL_DynamicOcclusionMode = this.GetDynamicOcclusionMode();
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0001A8A4 File Offset: 0x00018AA4
		protected virtual void OnDestroy()
		{
			this.m_Master._INTERNAL_DynamicOcclusionMode = MaterialManager.SD.DynamicOcclusion.Off;
			this.DisableOcclusion();
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0001A8B8 File Offset: 0x00018AB8
		protected virtual void OnEnable()
		{
			this.m_MaterialModifierCallbackCached = new MaterialModifier.Callback(this.OnModifyMaterialCallback);
			this.OnValidateProperties();
			this.OnEnablePostValidate();
			this.m_Master.onWillCameraRenderThisBeam += this.OnWillCameraRender;
			if (!this.updateRate.HasFlag(DynamicOcclusionUpdateRate.Never))
			{
				this.m_Master.RegisterOnBeamGeometryInitializedCallback(delegate
				{
					this.ProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource.OnEnable);
				});
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0001A92A File Offset: 0x00018B2A
		protected virtual void OnDisable()
		{
			this.m_Master.onWillCameraRenderThisBeam -= this.OnWillCameraRender;
			this.DisableOcclusion();
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0001A94C File Offset: 0x00018B4C
		private void OnWillCameraRender(Camera cam)
		{
			if (cam != null && cam.enabled && Time.frameCount != this.m_LastFrameRendered)
			{
				bool flag = false;
				if (!flag && this.updateRate.HasFlag(DynamicOcclusionUpdateRate.OnBeamMove) && !this.m_TransformPacked.IsSame(base.transform))
				{
					flag = true;
				}
				if (!flag && this.updateRate.HasFlag(DynamicOcclusionUpdateRate.EveryXFrames) && Time.frameCount >= this.m_LastFrameRendered + this.waitXFrames)
				{
					flag = true;
				}
				if (flag)
				{
					this.ProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource.RenderLoop);
				}
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0001A9E7 File Offset: 0x00018BE7
		private void DisableOcclusion()
		{
			this.m_Master._INTERNAL_SetDynamicOcclusionCallback(this.GetShaderKeyword(), null);
		}

		// Token: 0x04000696 RID: 1686
		public const string ClassName = "DynamicOcclusionAbstractBase";

		// Token: 0x04000697 RID: 1687
		public DynamicOcclusionUpdateRate updateRate = DynamicOcclusionUpdateRate.EveryXFrames;

		// Token: 0x04000698 RID: 1688
		[FormerlySerializedAs("waitFrameCount")]
		public int waitXFrames = 3;

		// Token: 0x0400069A RID: 1690
		public static bool _INTERNAL_ApplyRandomFrameOffset = true;

		// Token: 0x0400069B RID: 1691
		private TransformUtils.Packed m_TransformPacked;

		// Token: 0x0400069C RID: 1692
		private int m_LastFrameRendered = int.MinValue;

		// Token: 0x0400069D RID: 1693
		protected VolumetricLightBeamSD m_Master;

		// Token: 0x0400069E RID: 1694
		protected MaterialModifier.Callback m_MaterialModifierCallbackCached;

		// Token: 0x0200013B RID: 315
		protected enum ProcessOcclusionSource
		{
			// Token: 0x040006A0 RID: 1696
			RenderLoop,
			// Token: 0x040006A1 RID: 1697
			OnEnable,
			// Token: 0x040006A2 RID: 1698
			EditorUpdate,
			// Token: 0x040006A3 RID: 1699
			User
		}
	}
}
