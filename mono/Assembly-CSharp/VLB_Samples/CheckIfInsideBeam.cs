using System;
using UnityEngine;
using VLB;

namespace VLB_Samples
{
	// Token: 0x0200015D RID: 349
	[RequireComponent(typeof(Collider), typeof(Rigidbody), typeof(MeshRenderer))]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		// Token: 0x060006BC RID: 1724 RVA: 0x0001E4AC File Offset: 0x0001C6AC
		private void Start()
		{
			this.m_Collider = base.GetComponent<Collider>();
			MeshRenderer component = base.GetComponent<MeshRenderer>();
			if (component)
			{
				this.m_Material = component.material;
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0001E4E0 File Offset: 0x0001C6E0
		private void Update()
		{
			if (this.m_Material)
			{
				this.m_Material.SetColor("_Color", this.isInsideBeam ? Color.green : Color.red);
			}
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0001E513 File Offset: 0x0001C713
		private void FixedUpdate()
		{
			this.isInsideBeam = false;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0001E51C File Offset: 0x0001C71C
		private void OnTriggerStay(Collider trigger)
		{
			DynamicOcclusionRaycasting component = trigger.GetComponent<DynamicOcclusionRaycasting>();
			if (component)
			{
				this.isInsideBeam = !component.IsColliderHiddenByDynamicOccluder(this.m_Collider);
				return;
			}
			this.isInsideBeam = true;
		}

		// Token: 0x04000781 RID: 1921
		private bool isInsideBeam;

		// Token: 0x04000782 RID: 1922
		private Material m_Material;

		// Token: 0x04000783 RID: 1923
		private Collider m_Collider;
	}
}
