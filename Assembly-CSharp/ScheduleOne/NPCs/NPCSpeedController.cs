using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000469 RID: 1129
	public class NPCSpeedController : MonoBehaviour
	{
		// Token: 0x060017E6 RID: 6118 RVA: 0x000698F9 File Offset: 0x00067AF9
		private void Awake()
		{
			this.AddSpeedControl(new NPCSpeedController.SpeedControl("default", 0, this.DefaultWalkSpeed));
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00069914 File Offset: 0x00067B14
		private void FixedUpdate()
		{
			NPCSpeedController.SpeedControl highestPriorityControl = this.GetHighestPriorityControl();
			this.ActiveSpeedControl = highestPriorityControl;
			if (this.Movement.DEBUG)
			{
				Debug.Log("Active speed control: " + highestPriorityControl.id + ", speed : " + highestPriorityControl.speed.ToString());
			}
			this.Movement.MovementSpeedScale = highestPriorityControl.speed * this.SpeedMultiplier;
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x00069979 File Offset: 0x00067B79
		private NPCSpeedController.SpeedControl GetHighestPriorityControl()
		{
			return this.speedControlStack[0];
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x00069988 File Offset: 0x00067B88
		public void AddSpeedControl(NPCSpeedController.SpeedControl control)
		{
			NPCSpeedController.SpeedControl speedControl = this.speedControlStack.Find((NPCSpeedController.SpeedControl x) => x.id == control.id);
			if (speedControl != null)
			{
				speedControl.priority = control.priority;
				speedControl.speed = control.speed;
				return;
			}
			for (int i = 0; i < this.speedControlStack.Count; i++)
			{
				if (control.priority >= this.speedControlStack[i].priority)
				{
					this.speedControlStack.Insert(i, control);
					return;
				}
			}
			this.speedControlStack.Add(control);
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x00069A38 File Offset: 0x00067C38
		public NPCSpeedController.SpeedControl GetSpeedControl(string id)
		{
			return this.speedControlStack.Find((NPCSpeedController.SpeedControl x) => x.id == id);
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00069A69 File Offset: 0x00067C69
		public bool DoesSpeedControlExist(string id)
		{
			return this.GetSpeedControl(id) != null;
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00069A78 File Offset: 0x00067C78
		public void RemoveSpeedControl(string id)
		{
			NPCSpeedController.SpeedControl speedControl = this.speedControlStack.Find((NPCSpeedController.SpeedControl x) => x.id == id);
			if (speedControl != null)
			{
				this.speedControlStack.Remove(speedControl);
			}
		}

		// Token: 0x0400157F RID: 5503
		[Header("Settings")]
		[Range(0f, 1f)]
		public float DefaultWalkSpeed = 0.08f;

		// Token: 0x04001580 RID: 5504
		public float SpeedMultiplier = 1f;

		// Token: 0x04001581 RID: 5505
		[Header("References")]
		public NPCMovement Movement;

		// Token: 0x04001582 RID: 5506
		protected List<NPCSpeedController.SpeedControl> speedControlStack = new List<NPCSpeedController.SpeedControl>();

		// Token: 0x04001583 RID: 5507
		[Header("Debug")]
		public NPCSpeedController.SpeedControl ActiveSpeedControl;

		// Token: 0x0200046A RID: 1130
		[Serializable]
		public class SpeedControl
		{
			// Token: 0x060017EE RID: 6126 RVA: 0x00069AE3 File Offset: 0x00067CE3
			public SpeedControl(string id, int priority, float speed)
			{
				this.id = id;
				this.priority = priority;
				this.speed = speed;
			}

			// Token: 0x04001584 RID: 5508
			public string id;

			// Token: 0x04001585 RID: 5509
			public int priority;

			// Token: 0x04001586 RID: 5510
			public float speed;
		}
	}
}
