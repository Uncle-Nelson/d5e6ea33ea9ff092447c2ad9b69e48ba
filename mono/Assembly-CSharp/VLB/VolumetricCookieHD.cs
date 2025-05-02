using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000112 RID: 274
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeamHD))]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-cookie-hd/")]
	public class VolumetricCookieHD : MonoBehaviour
	{
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0001702D File Offset: 0x0001522D
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x00017035 File Offset: 0x00015235
		public float contribution
		{
			get
			{
				return this.m_Contribution;
			}
			set
			{
				if (this.m_Contribution != value)
				{
					this.m_Contribution = value;
					this.SetDirty();
				}
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0001704D File Offset: 0x0001524D
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x00017055 File Offset: 0x00015255
		public Texture cookieTexture
		{
			get
			{
				return this.m_CookieTexture;
			}
			set
			{
				if (this.m_CookieTexture != value)
				{
					this.m_CookieTexture = value;
					this.SetDirty();
				}
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00017072 File Offset: 0x00015272
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x0001707A File Offset: 0x0001527A
		public CookieChannel channel
		{
			get
			{
				return this.m_Channel;
			}
			set
			{
				if (this.m_Channel != value)
				{
					this.m_Channel = value;
					this.SetDirty();
				}
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00017092 File Offset: 0x00015292
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x0001709A File Offset: 0x0001529A
		public bool negative
		{
			get
			{
				return this.m_Negative;
			}
			set
			{
				if (this.m_Negative != value)
				{
					this.m_Negative = value;
					this.SetDirty();
				}
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x000170B2 File Offset: 0x000152B2
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x000170BA File Offset: 0x000152BA
		public Vector2 translation
		{
			get
			{
				return this.m_Translation;
			}
			set
			{
				if (this.m_Translation != value)
				{
					this.m_Translation = value;
					this.SetDirty();
				}
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x000170D7 File Offset: 0x000152D7
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x000170DF File Offset: 0x000152DF
		public float rotation
		{
			get
			{
				return this.m_Rotation;
			}
			set
			{
				if (this.m_Rotation != value)
				{
					this.m_Rotation = value;
					this.SetDirty();
				}
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x000170F7 File Offset: 0x000152F7
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x000170FF File Offset: 0x000152FF
		public Vector2 scale
		{
			get
			{
				return this.m_Scale;
			}
			set
			{
				if (this.m_Scale != value)
				{
					this.m_Scale = value;
					this.SetDirty();
				}
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0001711C File Offset: 0x0001531C
		private void SetDirty()
		{
			if (this.m_Master)
			{
				this.m_Master.SetPropertyDirty(DirtyProps.CookieProps);
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0001713C File Offset: 0x0001533C
		public static void ApplyMaterialProperties(VolumetricCookieHD instance, BeamGeometryHD geom)
		{
			if (instance && instance.enabled && instance.cookieTexture != null)
			{
				geom.SetMaterialProp(ShaderProperties.HD.CookieTexture, instance.cookieTexture);
				geom.SetMaterialProp(ShaderProperties.HD.CookieProperties, new Vector4(instance.negative ? instance.contribution : (-instance.contribution), (float)instance.channel, Mathf.Cos(instance.rotation * 0.017453292f), Mathf.Sin(instance.rotation * 0.017453292f)));
				geom.SetMaterialProp(ShaderProperties.HD.CookiePosAndScale, new Vector4(instance.translation.x, instance.translation.y, instance.scale.x, instance.scale.y));
				return;
			}
			geom.SetMaterialProp(ShaderProperties.HD.CookieTexture, BeamGeometryHD.InvalidTexture.Null);
			geom.SetMaterialProp(ShaderProperties.HD.CookieProperties, Vector4.zero);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0001722A File Offset: 0x0001542A
		private void Awake()
		{
			this.m_Master = base.GetComponent<VolumetricLightBeamHD>();
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00017238 File Offset: 0x00015438
		private void OnEnable()
		{
			this.SetDirty();
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00017238 File Offset: 0x00015438
		private void OnDisable()
		{
			this.SetDirty();
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00017238 File Offset: 0x00015438
		private void OnDidApplyAnimationProperties()
		{
			this.SetDirty();
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00017240 File Offset: 0x00015440
		private void Start()
		{
			if (Application.isPlaying)
			{
				this.SetDirty();
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00017240 File Offset: 0x00015440
		private void OnDestroy()
		{
			if (Application.isPlaying)
			{
				this.SetDirty();
			}
		}

		// Token: 0x040005F5 RID: 1525
		public const string ClassName = "VolumetricCookieHD";

		// Token: 0x040005F6 RID: 1526
		[SerializeField]
		private float m_Contribution = 1f;

		// Token: 0x040005F7 RID: 1527
		[SerializeField]
		private Texture m_CookieTexture;

		// Token: 0x040005F8 RID: 1528
		[SerializeField]
		private CookieChannel m_Channel = CookieChannel.Alpha;

		// Token: 0x040005F9 RID: 1529
		[SerializeField]
		private bool m_Negative;

		// Token: 0x040005FA RID: 1530
		[SerializeField]
		private Vector2 m_Translation = Consts.Cookie.TranslationDefault;

		// Token: 0x040005FB RID: 1531
		[SerializeField]
		private float m_Rotation;

		// Token: 0x040005FC RID: 1532
		[SerializeField]
		private Vector2 m_Scale = Consts.Cookie.ScaleDefault;

		// Token: 0x040005FD RID: 1533
		private VolumetricLightBeamHD m_Master;
	}
}
