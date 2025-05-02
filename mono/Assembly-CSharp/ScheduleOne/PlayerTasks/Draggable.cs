using System;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200033A RID: 826
	public class Draggable : Clickable
	{
		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x00050BF2 File Offset: 0x0004EDF2
		// (set) Token: 0x0600127B RID: 4731 RVA: 0x00050BFA File Offset: 0x0004EDFA
		public Rigidbody Rb { get; protected set; }

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x00050C03 File Offset: 0x0004EE03
		// (set) Token: 0x0600127D RID: 4733 RVA: 0x00050C0B File Offset: 0x0004EE0B
		public override CursorManager.ECursorType HoveredCursor { get; protected set; } = CursorManager.ECursorType.OpenHand;

		// Token: 0x0600127E RID: 4734 RVA: 0x00050C14 File Offset: 0x0004EE14
		protected virtual void Awake()
		{
			this.Rb = base.GetComponent<Rigidbody>();
			this.constraint = base.GetComponent<DraggableConstraint>();
			if (base.gameObject.isStatic)
			{
				Console.LogWarning("Draggable object is static, this will cause issues with dragging.", null);
			}
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00050C48 File Offset: 0x0004EE48
		protected virtual void FixedUpdate()
		{
			if (this.Rb == null)
			{
				return;
			}
			this.Rb.drag = (base.IsHeld ? this.HeldRBDrag : this.NormalRBDrag);
			if (!base.IsHeld && !this.Rb.isKinematic)
			{
				this.Rb.angularVelocity = Vector3.ClampMagnitude(this.Rb.angularVelocity, this.Rb.angularVelocity.magnitude * 0.9f);
				this.Rb.velocity = Vector3.ClampMagnitude(this.Rb.velocity, this.Rb.velocity.magnitude * 0.95f);
				this.Rb.AddForce(Vector3.up * this.idleUpForce, 5);
			}
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void Update()
		{
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void PostFixedUpdate()
		{
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00050D24 File Offset: 0x0004EF24
		protected virtual void LateUpdate()
		{
			if (this.LocationRestrictionEnabled && Vector3.Distance(base.transform.position, this.Origin) > this.MaxDistanceFromOrigin)
			{
				base.transform.position = this.Origin + (base.transform.position - this.Origin).normalized * this.MaxDistanceFromOrigin;
			}
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00050D96 File Offset: 0x0004EF96
		protected virtual void OnTriggerExit(Collider other)
		{
			if (this.onTriggerExit != null)
			{
				this.onTriggerExit.Invoke(other);
			}
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00050DAC File Offset: 0x0004EFAC
		public override void StartClick(RaycastHit hit)
		{
			base.StartClick(hit);
			if (this.DisableGravityWhenDragged)
			{
				this.Rb.useGravity = false;
			}
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00050DC9 File Offset: 0x0004EFC9
		public override void EndClick()
		{
			base.EndClick();
			if (this.DisableGravityWhenDragged && this.Rb != null)
			{
				this.Rb.useGravity = true;
			}
		}

		// Token: 0x040011CF RID: 4559
		[Header("Drag Force")]
		public float DragForceMultiplier = 30f;

		// Token: 0x040011D0 RID: 4560
		public Transform DragForceOrigin;

		// Token: 0x040011D1 RID: 4561
		[Header("Rotation")]
		public bool RotationEnabled = true;

		// Token: 0x040011D2 RID: 4562
		public float TorqueMultiplier = 20f;

		// Token: 0x040011D3 RID: 4563
		[Header("Settings")]
		public Draggable.EDragProjectionMode DragProjectionMode;

		// Token: 0x040011D4 RID: 4564
		public bool DisableGravityWhenDragged;

		// Token: 0x040011D5 RID: 4565
		public float NormalRBDrag = 3f;

		// Token: 0x040011D6 RID: 4566
		public float HeldRBDrag = 15f;

		// Token: 0x040011D7 RID: 4567
		public bool CanBeMultiDragged = true;

		// Token: 0x040011DA RID: 4570
		[Header("Additional force")]
		public float idleUpForce;

		// Token: 0x040011DB RID: 4571
		[HideInInspector]
		public bool LocationRestrictionEnabled;

		// Token: 0x040011DC RID: 4572
		[HideInInspector]
		public Vector3 Origin = Vector3.zero;

		// Token: 0x040011DD RID: 4573
		[HideInInspector]
		public float MaxDistanceFromOrigin = 0.5f;

		// Token: 0x040011DE RID: 4574
		public UnityEvent<Collider> onTriggerExit;

		// Token: 0x040011DF RID: 4575
		protected DraggableConstraint constraint;

		// Token: 0x0200033B RID: 827
		public enum EDragProjectionMode
		{
			// Token: 0x040011E1 RID: 4577
			CameraForward,
			// Token: 0x040011E2 RID: 4578
			FlatCameraForward
		}
	}
}
