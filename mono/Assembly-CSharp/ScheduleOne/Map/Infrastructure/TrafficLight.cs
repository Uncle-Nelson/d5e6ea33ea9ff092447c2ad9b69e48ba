using System;
using UnityEngine;

namespace ScheduleOne.Map.Infrastructure
{
	// Token: 0x02000C3C RID: 3132
	public class TrafficLight : MonoBehaviour
	{
		// Token: 0x060057BA RID: 22458 RVA: 0x00170230 File Offset: 0x0016E430
		protected virtual void Start()
		{
			this.ApplyState();
		}

		// Token: 0x060057BB RID: 22459 RVA: 0x00170238 File Offset: 0x0016E438
		protected virtual void Update()
		{
			if (this.appliedState != this.state)
			{
				this.ApplyState();
			}
		}

		// Token: 0x060057BC RID: 22460 RVA: 0x00170250 File Offset: 0x0016E450
		protected virtual void ApplyState()
		{
			this.appliedState = this.state;
			this.redMesh.material = this.redOff_Mat;
			this.orangeMesh.material = this.orangeOff_Mat;
			this.greenMesh.material = this.greenOff_Mat;
			switch (this.state)
			{
			case TrafficLight.State.Red:
				this.redMesh.material = this.redOn_Mat;
				return;
			case TrafficLight.State.Orange:
				this.orangeMesh.material = this.orangeOn_Mat;
				return;
			case TrafficLight.State.Green:
				this.greenMesh.material = this.greenOn_Mat;
				return;
			default:
				return;
			}
		}

		// Token: 0x04004105 RID: 16645
		public static float amberTime = 3f;

		// Token: 0x04004106 RID: 16646
		[Header("References")]
		[SerializeField]
		protected MeshRenderer redMesh;

		// Token: 0x04004107 RID: 16647
		[SerializeField]
		protected MeshRenderer orangeMesh;

		// Token: 0x04004108 RID: 16648
		[SerializeField]
		protected MeshRenderer greenMesh;

		// Token: 0x04004109 RID: 16649
		[Header("Materials")]
		[SerializeField]
		protected Material redOn_Mat;

		// Token: 0x0400410A RID: 16650
		[SerializeField]
		protected Material redOff_Mat;

		// Token: 0x0400410B RID: 16651
		[SerializeField]
		protected Material orangeOn_Mat;

		// Token: 0x0400410C RID: 16652
		[SerializeField]
		protected Material orangeOff_Mat;

		// Token: 0x0400410D RID: 16653
		[SerializeField]
		protected Material greenOn_Mat;

		// Token: 0x0400410E RID: 16654
		[SerializeField]
		protected Material greenOff_Mat;

		// Token: 0x0400410F RID: 16655
		[Header("Settings")]
		public TrafficLight.State state;

		// Token: 0x04004110 RID: 16656
		private TrafficLight.State appliedState;

		// Token: 0x02000C3D RID: 3133
		public enum State
		{
			// Token: 0x04004112 RID: 16658
			Red,
			// Token: 0x04004113 RID: 16659
			Orange,
			// Token: 0x04004114 RID: 16660
			Green
		}
	}
}
