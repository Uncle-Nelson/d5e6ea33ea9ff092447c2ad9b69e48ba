using System;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x0200088E RID: 2190
	public class FunctionalJar : FunctionalPackaging
	{
		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06003B44 RID: 15172 RVA: 0x000F9259 File Offset: 0x000F7459
		// (set) Token: 0x06003B45 RID: 15173 RVA: 0x000F9261 File Offset: 0x000F7461
		public override CursorManager.ECursorType HoveredCursor { get; protected set; } = CursorManager.ECursorType.Finger;

		// Token: 0x06003B46 RID: 15174 RVA: 0x000F926C File Offset: 0x000F746C
		public override void Initialize(PackagingStation _station, Transform alignment, bool align = false)
		{
			base.Initialize(_station, alignment, align);
			this.lidPosition = base.transform.InverseTransformPoint(this.Lid.transform.position);
			this.LidObject = this.Lid.gameObject;
			this.Lid.transform.SetParent(_station.Container);
			this.Lid.transform.position = this.LidStartPoint.position;
			this.Lid.transform.rotation = this.LidStartPoint.rotation;
			this.LidSensor.enabled = false;
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x000F930C File Offset: 0x000F750C
		public override void Destroy()
		{
			Object.Destroy(this.LidObject);
			base.Destroy();
		}

		// Token: 0x06003B48 RID: 15176 RVA: 0x000F931F File Offset: 0x000F751F
		protected override void EnableSealing()
		{
			base.EnableSealing();
			this.Lid.enabled = true;
			this.Lid.ClickableEnabled = true;
			this.Lid.Rb.isKinematic = false;
			this.LidSensor.enabled = true;
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x000F935C File Offset: 0x000F755C
		protected override void LateUpdate()
		{
			base.LateUpdate();
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x000F9364 File Offset: 0x000F7564
		protected override void OnTriggerStay(Collider other)
		{
			base.OnTriggerStay(other);
			if (this.Lid != null && this.Lid.enabled && other.gameObject.name == "LidTrigger")
			{
				this.Seal();
			}
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x000F93B0 File Offset: 0x000F75B0
		public override void Seal()
		{
			base.Seal();
			this.Lid.enabled = false;
			this.Lid.ClickableEnabled = false;
			this.Lid.transform.SetParent(base.transform);
			Object.Destroy(this.Lid.Rb);
			Object.Destroy(this.Lid);
			Object.Destroy(this.LidCollider);
			this.Lid.transform.position = base.transform.TransformPoint(this.lidPosition);
			this.LidSensor.enabled = false;
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x000F9444 File Offset: 0x000F7644
		protected override void FullyPacked()
		{
			base.FullyPacked();
			this.FullyPackedBlocker.SetActive(true);
		}

		// Token: 0x04002AC7 RID: 10951
		[Header("References")]
		public Draggable Lid;

		// Token: 0x04002AC8 RID: 10952
		public Transform LidStartPoint;

		// Token: 0x04002AC9 RID: 10953
		public Collider LidSensor;

		// Token: 0x04002ACA RID: 10954
		public Collider LidCollider;

		// Token: 0x04002ACB RID: 10955
		public GameObject FullyPackedBlocker;

		// Token: 0x04002ACC RID: 10956
		private GameObject LidObject;

		// Token: 0x04002ACD RID: 10957
		private Vector3 lidPosition = Vector3.zero;
	}
}
