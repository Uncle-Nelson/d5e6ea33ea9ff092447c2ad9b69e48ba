using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x020000DF RID: 223
	public abstract class BeamGeometryAbstractBase : MonoBehaviour
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x000153AD File Offset: 0x000135AD
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x000153B5 File Offset: 0x000135B5
		public MeshRenderer meshRenderer { get; protected set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x000153BE File Offset: 0x000135BE
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x000153C6 File Offset: 0x000135C6
		public MeshFilter meshFilter { get; protected set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x000153CF File Offset: 0x000135CF
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x000153D7 File Offset: 0x000135D7
		public Mesh coneMesh { get; protected set; }

		// Token: 0x060003A7 RID: 935
		protected abstract VolumetricLightBeamAbstractBase GetMaster();

		// Token: 0x060003A8 RID: 936 RVA: 0x000153E0 File Offset: 0x000135E0
		private void Start()
		{
			this.DestroyInvalidOwner();
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000153E8 File Offset: 0x000135E8
		private void OnDestroy()
		{
			if (this.m_CustomMaterial)
			{
				Object.DestroyImmediate(this.m_CustomMaterial);
				this.m_CustomMaterial = null;
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00015409 File Offset: 0x00013609
		private void DestroyInvalidOwner()
		{
			if (!this.GetMaster())
			{
				BeamGeometryAbstractBase.DestroyBeamGeometryGameObject(this);
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0001541E File Offset: 0x0001361E
		public static void DestroyBeamGeometryGameObject(BeamGeometryAbstractBase beamGeom)
		{
			if (beamGeom)
			{
				Object.DestroyImmediate(beamGeom.gameObject);
			}
		}

		// Token: 0x0400048E RID: 1166
		protected Matrix4x4 m_ColorGradientMatrix;

		// Token: 0x0400048F RID: 1167
		protected Material m_CustomMaterial;
	}
}
