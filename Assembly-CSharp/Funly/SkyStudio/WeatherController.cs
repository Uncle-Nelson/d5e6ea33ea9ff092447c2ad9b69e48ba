using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001E2 RID: 482
	public class WeatherController : MonoBehaviour
	{
		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0002FB2C File Offset: 0x0002DD2C
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x0002FB34 File Offset: 0x0002DD34
		public RainDownfallController rainDownfallController { get; protected set; }

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0002FB3D File Offset: 0x0002DD3D
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x0002FB45 File Offset: 0x0002DD45
		public RainSplashController rainSplashController { get; protected set; }

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0002FB4E File Offset: 0x0002DD4E
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x0002FB56 File Offset: 0x0002DD56
		public LightningController lightningController { get; protected set; }

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0002FB5F File Offset: 0x0002DD5F
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x0002FB67 File Offset: 0x0002DD67
		public WeatherDepthCamera weatherDepthCamera { get; protected set; }

		// Token: 0x06000ABD RID: 2749 RVA: 0x0002FB70 File Offset: 0x0002DD70
		private void Awake()
		{
			this.DiscoverWeatherControllers();
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0002FB70 File Offset: 0x0002DD70
		private void Start()
		{
			this.DiscoverWeatherControllers();
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0002FB78 File Offset: 0x0002DD78
		private void OnEnable()
		{
			this.DiscoverWeatherControllers();
			if (this.detector == null)
			{
				Debug.LogError("Can't register for enclosure callbacks since there's no WeatherEnclosureDetector on any children");
				return;
			}
			WeatherEnclosureDetector weatherEnclosureDetector = this.detector;
			weatherEnclosureDetector.enclosureChangedCallback = (Action<WeatherEnclosure>)Delegate.Combine(weatherEnclosureDetector.enclosureChangedCallback, new Action<WeatherEnclosure>(this.OnEnclosureDidChange));
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0002FBCB File Offset: 0x0002DDCB
		private void DiscoverWeatherControllers()
		{
			this.rainDownfallController = base.GetComponentInChildren<RainDownfallController>();
			this.rainSplashController = base.GetComponentInChildren<RainSplashController>();
			this.lightningController = base.GetComponentInChildren<LightningController>();
			this.weatherDepthCamera = base.GetComponentInChildren<WeatherDepthCamera>();
			this.detector = base.GetComponentInChildren<WeatherEnclosureDetector>();
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0002FC09 File Offset: 0x0002DE09
		private void OnDisable()
		{
			if (this.detector == null)
			{
				return;
			}
			WeatherEnclosureDetector weatherEnclosureDetector = this.detector;
			weatherEnclosureDetector.enclosureChangedCallback = (Action<WeatherEnclosure>)Delegate.Remove(weatherEnclosureDetector.enclosureChangedCallback, new Action<WeatherEnclosure>(this.OnEnclosureDidChange));
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0002FC44 File Offset: 0x0002DE44
		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
			if (!skyProfile)
			{
				return;
			}
			this.m_Profile = skyProfile;
			this.m_TimeOfDay = timeOfDay;
			if (this.weatherDepthCamera != null)
			{
				this.weatherDepthCamera.enabled = skyProfile.IsFeatureEnabled("RainSplashFeature", true);
			}
			if (this.rainDownfallController != null)
			{
				this.rainDownfallController.UpdateForTimeOfDay(skyProfile, timeOfDay);
			}
			if (this.rainSplashController != null)
			{
				this.rainSplashController.UpdateForTimeOfDay(skyProfile, timeOfDay);
			}
			if (this.lightningController != null)
			{
				this.lightningController.UpdateForTimeOfDay(skyProfile, timeOfDay);
			}
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0002FCE0 File Offset: 0x0002DEE0
		private void LateUpdate()
		{
			if (this.m_Profile == null)
			{
				return;
			}
			if (this.m_EnclosureMeshRenderer && this.rainDownfallController && this.m_Profile.IsFeatureEnabled("RainFeature", true))
			{
				this.m_EnclosureMeshRenderer.enabled = true;
				return;
			}
			this.m_EnclosureMeshRenderer.enabled = false;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0002FD44 File Offset: 0x0002DF44
		private void OnEnclosureDidChange(WeatherEnclosure enclosure)
		{
			this.m_Enclosure = enclosure;
			if (this.m_Enclosure != null)
			{
				this.m_EnclosureMeshRenderer = this.m_Enclosure.GetComponentInChildren<MeshRenderer>();
			}
			this.rainDownfallController.SetWeatherEnclosure(this.m_Enclosure);
			this.UpdateForTimeOfDay(this.m_Profile, this.m_TimeOfDay);
		}

		// Token: 0x04000BA5 RID: 2981
		private WeatherEnclosure m_Enclosure;

		// Token: 0x04000BA6 RID: 2982
		private MeshRenderer m_EnclosureMeshRenderer;

		// Token: 0x04000BA7 RID: 2983
		private WeatherEnclosureDetector detector;

		// Token: 0x04000BA8 RID: 2984
		private SkyProfile m_Profile;

		// Token: 0x04000BA9 RID: 2985
		private float m_TimeOfDay;
	}
}
