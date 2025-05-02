using System;
using ScheduleOne.PlayerTasks;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BC5 RID: 3013
	public class Beaker : StationItem
	{
		// Token: 0x060051FE RID: 20990 RVA: 0x001598C8 File Offset: 0x00157AC8
		private void Start()
		{
			this.Joint.connectedBody = this.Anchor;
			this.Draggable.Rb.centerOfMass = this.Draggable.Rb.transform.InverseTransformPoint(this.CenterOfMass.position);
		}

		// Token: 0x060051FF RID: 20991 RVA: 0x00159918 File Offset: 0x00157B18
		private void Update()
		{
			SoftJointLimit angularZLimit = this.Joint.angularZLimit;
			angularZLimit.limit = Mathf.Lerp(this.ClampAngle_MinLiquid, this.ClampAngle_MaxLiquid, this.Container.CurrentLiquidLevel);
			this.Joint.angularZLimit = angularZLimit;
			this.Pourable.AngleFromUpToPour = Mathf.Lerp(this.AngleToPour_MinLiquid, this.AngleToPour_MaxLiquid, this.Container.CurrentLiquidLevel);
		}

		// Token: 0x06005200 RID: 20992 RVA: 0x00159987 File Offset: 0x00157B87
		public void SetStatic(bool stat)
		{
			this.Draggable.ClickableEnabled = !stat;
			this.ConvexCollider.enabled = !stat;
			this.ConcaveCollider.enabled = stat;
			this.Draggable.Rb.isKinematic = stat;
		}

		// Token: 0x04003D66 RID: 15718
		public float ClampAngle_MaxLiquid = 50f;

		// Token: 0x04003D67 RID: 15719
		public float ClampAngle_MinLiquid = 100f;

		// Token: 0x04003D68 RID: 15720
		public float AngleToPour_MaxLiquid = 95f;

		// Token: 0x04003D69 RID: 15721
		public float AngleToPour_MinLiquid = 140f;

		// Token: 0x04003D6A RID: 15722
		[Header("References")]
		public Draggable Draggable;

		// Token: 0x04003D6B RID: 15723
		public DraggableConstraint Constraint;

		// Token: 0x04003D6C RID: 15724
		public Collider ConcaveCollider;

		// Token: 0x04003D6D RID: 15725
		public Collider ConvexCollider;

		// Token: 0x04003D6E RID: 15726
		public Transform CenterOfMass;

		// Token: 0x04003D6F RID: 15727
		public ConfigurableJoint Joint;

		// Token: 0x04003D70 RID: 15728
		public Rigidbody Anchor;

		// Token: 0x04003D71 RID: 15729
		public LiquidContainer Container;

		// Token: 0x04003D72 RID: 15730
		public Fillable Fillable;

		// Token: 0x04003D73 RID: 15731
		public PourableModule Pourable;

		// Token: 0x04003D74 RID: 15732
		public GameObject FilterPaper;
	}
}
