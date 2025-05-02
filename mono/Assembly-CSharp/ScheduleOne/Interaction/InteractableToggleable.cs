using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Interaction
{
	// Token: 0x02000614 RID: 1556
	public class InteractableToggleable : MonoBehaviour
	{
		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060028BA RID: 10426 RVA: 0x000A7CB4 File Offset: 0x000A5EB4
		// (set) Token: 0x060028BB RID: 10427 RVA: 0x000A7CBC File Offset: 0x000A5EBC
		public bool IsActivated { get; private set; }

		// Token: 0x060028BC RID: 10428 RVA: 0x000A7CC5 File Offset: 0x000A5EC5
		public void Start()
		{
			this.IntObj.onHovered.AddListener(new UnityAction(this.Hovered));
			this.IntObj.onInteractStart.AddListener(new UnityAction(this.Interacted));
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x000A7D00 File Offset: 0x000A5F00
		public void Hovered()
		{
			if (Time.time - this.lastActivated < this.CoolDown)
			{
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				return;
			}
			this.IntObj.SetMessage(this.IsActivated ? this.DeactivateMessage : this.ActivateMessage);
			this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x000A7D5B File Offset: 0x000A5F5B
		public void Interacted()
		{
			this.Toggle();
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x000A7D64 File Offset: 0x000A5F64
		public void Toggle()
		{
			this.lastActivated = Time.time;
			this.IsActivated = !this.IsActivated;
			if (this.onToggle != null)
			{
				this.onToggle.Invoke();
			}
			if (this.IsActivated)
			{
				this.onActivate.Invoke();
				return;
			}
			this.onDeactivate.Invoke();
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x000A7DC0 File Offset: 0x000A5FC0
		public void SetState(bool activated)
		{
			if (this.IsActivated == activated)
			{
				return;
			}
			this.lastActivated = Time.time;
			this.IsActivated = !this.IsActivated;
			if (this.IsActivated)
			{
				this.onActivate.Invoke();
				return;
			}
			this.onDeactivate.Invoke();
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x000A7E10 File Offset: 0x000A6010
		public void PoliceDetected()
		{
			if (!this.IsActivated)
			{
				this.Toggle();
			}
		}

		// Token: 0x04001DD2 RID: 7634
		public string ActivateMessage = "Activate";

		// Token: 0x04001DD3 RID: 7635
		public string DeactivateMessage = "Deactivate";

		// Token: 0x04001DD4 RID: 7636
		public float CoolDown;

		// Token: 0x04001DD5 RID: 7637
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04001DD6 RID: 7638
		public UnityEvent onToggle = new UnityEvent();

		// Token: 0x04001DD7 RID: 7639
		public UnityEvent onActivate = new UnityEvent();

		// Token: 0x04001DD8 RID: 7640
		public UnityEvent onDeactivate = new UnityEvent();

		// Token: 0x04001DD9 RID: 7641
		private float lastActivated;
	}
}
