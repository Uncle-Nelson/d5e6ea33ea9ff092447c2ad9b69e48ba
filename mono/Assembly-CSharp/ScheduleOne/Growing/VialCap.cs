using System;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x0200087F RID: 2175
	public class VialCap : Clickable
	{
		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06003B00 RID: 15104 RVA: 0x000F85B5 File Offset: 0x000F67B5
		// (set) Token: 0x06003B01 RID: 15105 RVA: 0x000F85BD File Offset: 0x000F67BD
		public bool Removed { get; protected set; }

		// Token: 0x06003B02 RID: 15106 RVA: 0x000F85C6 File Offset: 0x000F67C6
		public override void StartClick(RaycastHit hit)
		{
			base.StartClick(hit);
			this.Pop();
		}

		// Token: 0x06003B03 RID: 15107 RVA: 0x000F85D8 File Offset: 0x000F67D8
		private void Pop()
		{
			this.RigidBody = base.gameObject.AddComponent<Rigidbody>();
			this.Removed = true;
			this.Collider.enabled = false;
			this.RigidBody.isKinematic = false;
			this.RigidBody.useGravity = true;
			base.transform.SetParent(null);
			this.RigidBody.AddRelativeForce(Vector3.forward * 1.5f, 2);
			this.RigidBody.AddRelativeForce(Vector3.up * 0.5f, 2);
			this.RigidBody.AddTorque(Vector3.up * 1.5f, 2);
			Object.Destroy(base.gameObject, 3f);
			base.enabled = false;
		}

		// Token: 0x04002A89 RID: 10889
		public Collider Collider;

		// Token: 0x04002A8A RID: 10890
		private Rigidbody RigidBody;
	}
}
