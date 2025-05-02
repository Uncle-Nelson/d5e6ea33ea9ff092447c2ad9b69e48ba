using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000185 RID: 389
	[ExecuteInEditMode]
	public class OrbitingBody : MonoBehaviour
	{
		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x0002588A File Offset: 0x00023A8A
		public Transform positionTransform
		{
			get
			{
				if (this.m_PositionTransform == null)
				{
					this.m_PositionTransform = base.transform.Find("Position");
				}
				return this.m_PositionTransform;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x000258B8 File Offset: 0x00023AB8
		public RotateBody rotateBody
		{
			get
			{
				if (this.m_RotateBody == null)
				{
					Transform positionTransform = this.positionTransform;
					if (!positionTransform)
					{
						Debug.LogError("Can't return rotation body without a position transform game object");
						return null;
					}
					this.m_RotateBody = positionTransform.GetComponent<RotateBody>();
				}
				return this.m_RotateBody;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x00025900 File Offset: 0x00023B00
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x00025908 File Offset: 0x00023B08
		public SpherePoint Point
		{
			get
			{
				return this.m_SpherePoint;
			}
			set
			{
				if (this.m_SpherePoint == null)
				{
					this.m_SpherePoint = new SpherePoint(0f, 0f);
				}
				else
				{
					this.m_SpherePoint = value;
				}
				this.m_CachedWorldDirection = this.m_SpherePoint.GetWorldDirection();
				this.LayoutOribit();
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x00025947 File Offset: 0x00023B47
		public Vector3 BodyGlobalDirection
		{
			get
			{
				return this.m_CachedWorldDirection;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00025950 File Offset: 0x00023B50
		public Light BodyLight
		{
			get
			{
				if (this.m_BodyLight == null)
				{
					this.m_BodyLight = base.transform.GetComponentInChildren<Light>();
					if (this.m_BodyLight != null)
					{
						this.m_BodyLight.transform.localRotation = Quaternion.identity;
					}
				}
				return this.m_BodyLight;
			}
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x000259A5 File Offset: 0x00023BA5
		public void ResetOrbit()
		{
			this.LayoutOribit();
			this.m_PositionTransform = null;
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x000259B4 File Offset: 0x00023BB4
		public void LayoutOribit()
		{
			base.transform.position = Vector3.zero;
			base.transform.rotation = Quaternion.identity;
			base.transform.forward = this.BodyGlobalDirection * -1f;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000259F1 File Offset: 0x00023BF1
		private void OnValidate()
		{
			this.LayoutOribit();
		}

		// Token: 0x0400091A RID: 2330
		private Transform m_PositionTransform;

		// Token: 0x0400091B RID: 2331
		private RotateBody m_RotateBody;

		// Token: 0x0400091C RID: 2332
		private SpherePoint m_SpherePoint = new SpherePoint(0f, 0f);

		// Token: 0x0400091D RID: 2333
		private Vector3 m_CachedWorldDirection = Vector3.right;

		// Token: 0x0400091E RID: 2334
		private Light m_BodyLight;
	}
}
