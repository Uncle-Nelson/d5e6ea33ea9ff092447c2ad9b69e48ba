using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000114 RID: 276
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-hd/")]
	public class VolumetricLightBeamHD2D : VolumetricLightBeamHD
	{
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00017E60 File Offset: 0x00016060
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00017E68 File Offset: 0x00016068
		public int sortingLayerID
		{
			get
			{
				return this.m_SortingLayerID;
			}
			set
			{
				this.m_SortingLayerID = value;
				if (this.m_BeamGeom)
				{
					this.m_BeamGeom.sortingLayerID = value;
				}
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00017E8A File Offset: 0x0001608A
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00017E97 File Offset: 0x00016097
		public string sortingLayerName
		{
			get
			{
				return SortingLayer.IDToName(this.sortingLayerID);
			}
			set
			{
				this.sortingLayerID = SortingLayer.NameToID(value);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00017EA5 File Offset: 0x000160A5
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00017EAD File Offset: 0x000160AD
		public int sortingOrder
		{
			get
			{
				return this.m_SortingOrder;
			}
			set
			{
				this.m_SortingOrder = value;
				if (this.m_BeamGeom)
				{
					this.m_BeamGeom.sortingOrder = value;
				}
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000022C9 File Offset: 0x000004C9
		public override Dimensions GetDimensions()
		{
			return Dimensions.Dim2D;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x000022C9 File Offset: 0x000004C9
		public override bool DoesSupportSorting2D()
		{
			return true;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00017ECF File Offset: 0x000160CF
		public override int GetSortingLayerID()
		{
			return this.sortingLayerID;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00017ED7 File Offset: 0x000160D7
		public override int GetSortingOrder()
		{
			return this.sortingOrder;
		}

		// Token: 0x0400061C RID: 1564
		[SerializeField]
		private int m_SortingLayerID;

		// Token: 0x0400061D RID: 1565
		[SerializeField]
		private int m_SortingOrder;
	}
}
