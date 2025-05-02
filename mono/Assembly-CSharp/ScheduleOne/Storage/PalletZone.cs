using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008A6 RID: 2214
	public class PalletZone : MonoBehaviour
	{
		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06003BFB RID: 15355 RVA: 0x000FC9AE File Offset: 0x000FABAE
		public bool isClear
		{
			get
			{
				return (this.pallets.Count == 0 || this.AreAllPalletsClear()) && !this.orderReceivedThisFrame;
			}
		}

		// Token: 0x06003BFC RID: 15356 RVA: 0x000FC9D0 File Offset: 0x000FABD0
		protected void OnTriggerStay(Collider other)
		{
			Pallet componentInParent = other.GetComponentInParent<Pallet>();
			if (componentInParent != null && !this.pallets.Contains(componentInParent))
			{
				this.pallets.Add(componentInParent);
			}
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x000FCA07 File Offset: 0x000FAC07
		protected void FixedUpdate()
		{
			this.pallets.Clear();
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x000FCA14 File Offset: 0x000FAC14
		protected void LateUpdate()
		{
			this.orderReceivedThisFrame = false;
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x000FCA1D File Offset: 0x000FAC1D
		public Pallet GeneratePallet()
		{
			Pallet component = Object.Instantiate<GameObject>(this.palletPrefab).GetComponent<Pallet>();
			component.transform.position = base.transform.position;
			component.transform.rotation = base.transform.rotation;
			return component;
		}

		// Token: 0x06003C00 RID: 15360 RVA: 0x000FCA5C File Offset: 0x000FAC5C
		private bool AreAllPalletsClear()
		{
			for (int i = 0; i < this.pallets.Count; i++)
			{
				if (!this.pallets[i].isEmpty)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04002B50 RID: 11088
		private List<Pallet> pallets = new List<Pallet>();

		// Token: 0x04002B51 RID: 11089
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject palletPrefab;

		// Token: 0x04002B52 RID: 11090
		private bool orderReceivedThisFrame;
	}
}
