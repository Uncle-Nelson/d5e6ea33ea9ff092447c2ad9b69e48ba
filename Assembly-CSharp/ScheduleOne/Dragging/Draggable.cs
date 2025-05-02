using System;
using EasyButtons;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Dragging
{
	// Token: 0x02000683 RID: 1667
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(InteractableObject))]
	public class Draggable : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06002E11 RID: 11793 RVA: 0x000C103B File Offset: 0x000BF23B
		public bool IsBeingDragged
		{
			get
			{
				return this.CurrentDragger != null;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06002E12 RID: 11794 RVA: 0x000C1049 File Offset: 0x000BF249
		// (set) Token: 0x06002E13 RID: 11795 RVA: 0x000C1051 File Offset: 0x000BF251
		public Player CurrentDragger { get; protected set; }

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06002E14 RID: 11796 RVA: 0x000C105A File Offset: 0x000BF25A
		// (set) Token: 0x06002E15 RID: 11797 RVA: 0x000C1062 File Offset: 0x000BF262
		public Guid GUID { get; protected set; }

		// Token: 0x06002E16 RID: 11798 RVA: 0x000C106C File Offset: 0x000BF26C
		[Button]
		public void RegenerateGUID()
		{
			this.BakedGUID = Guid.NewGuid().ToString();
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06002E17 RID: 11799 RVA: 0x000C1092 File Offset: 0x000BF292
		// (set) Token: 0x06002E18 RID: 11800 RVA: 0x000C109A File Offset: 0x000BF29A
		public Vector3 initialPosition { get; private set; }

		// Token: 0x06002E19 RID: 11801 RVA: 0x000C10A4 File Offset: 0x000BF2A4
		protected virtual void Awake()
		{
			this.IntObj.MaxInteractionRange = 2.5f;
			this.IntObj.onHovered.AddListener(new UnityAction(this.Hovered));
			this.IntObj.onInteractStart.AddListener(new UnityAction(this.Interacted));
			this.IntObj.SetMessage("Pick up");
			this.initialPosition = base.transform.position;
			if (this.CreateCoM)
			{
				Transform transform = new GameObject("CenterOfMass").transform;
				transform.SetParent(base.transform);
				transform.localPosition = this.Rigidbody.centerOfMass;
				this.IntObj.displayLocationPoint = transform;
				this.DragOrigin = transform;
			}
			if (!string.IsNullOrEmpty(this.BakedGUID))
			{
				this.GUID = new Guid(this.BakedGUID);
				GUIDManager.RegisterObject(this);
			}
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x000C1188 File Offset: 0x000BF388
		protected virtual void Start()
		{
			NetworkSingleton<DragManager>.Instance.RegisterDraggable(this);
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x000C1195 File Offset: 0x000BF395
		public void SetGUID(Guid guid)
		{
			this.GUID = guid;
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x000C11A4 File Offset: 0x000BF3A4
		protected void OnValidate()
		{
			if (this.IntObj == null)
			{
				this.IntObj = base.GetComponent<InteractableObject>();
			}
			if (this.Rigidbody == null)
			{
				this.Rigidbody = base.GetComponent<Rigidbody>();
			}
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x000C11DA File Offset: 0x000BF3DA
		protected void OnDestroy()
		{
			if (NetworkSingleton<DragManager>.InstanceExists)
			{
				if (this.IsBeingDragged && NetworkSingleton<DragManager>.Instance.CurrentDraggable == this)
				{
					NetworkSingleton<DragManager>.Instance.StopDragging(Vector3.zero);
				}
				NetworkSingleton<DragManager>.Instance.Deregister(this);
			}
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x000C1218 File Offset: 0x000BF418
		private void FixedUpdate()
		{
			if (this.IsBeingDragged)
			{
				this.timeSinceLastDrag = 0f;
			}
			else if (this.timeSinceLastDrag < 1f)
			{
				this.timeSinceLastDrag += Time.fixedDeltaTime;
			}
			if (this.IsBeingDragged && this.CurrentDragger != Player.Local)
			{
				Vector3 targetPosition = this.CurrentDragger.MimicCamera.position + this.CurrentDragger.MimicCamera.forward * 1.25f * this.HoldDistanceMultiplier;
				this.ApplyDragForces(targetPosition);
			}
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x000C12B8 File Offset: 0x000BF4B8
		public void ApplyDragForces(Vector3 targetPosition)
		{
			Vector3 vector = targetPosition - base.transform.position;
			if (this.DragOrigin != null)
			{
				vector = targetPosition - this.DragOrigin.position;
			}
			float magnitude = vector.magnitude;
			Vector3 a = vector.normalized * NetworkSingleton<DragManager>.Instance.DragForce * magnitude;
			a -= this.Rigidbody.velocity * NetworkSingleton<DragManager>.Instance.DampingFactor;
			this.Rigidbody.AddForce(a * this.DragForceMultiplier, 5);
			Vector3 a2 = Vector3.Cross(base.transform.up, Vector3.up);
			a2 -= this.Rigidbody.angularVelocity * NetworkSingleton<DragManager>.Instance.TorqueDampingFactor;
			this.Rigidbody.AddTorque(a2 * NetworkSingleton<DragManager>.Instance.TorqueForce, 5);
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x000C13A8 File Offset: 0x000BF5A8
		protected virtual void Hovered()
		{
			if (this.CanInteract() && base.enabled)
			{
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				this.IntObj.SetMessage("Pick up");
			}
			else
			{
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
			}
			if (this.onHovered != null)
			{
				this.onHovered.Invoke();
			}
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x000C1402 File Offset: 0x000BF602
		protected virtual void Interacted()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.onInteracted != null)
			{
				this.onInteracted.Invoke();
			}
			if (!this.CanInteract())
			{
				return;
			}
			NetworkSingleton<DragManager>.Instance.StartDragging(this);
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x000C1434 File Offset: 0x000BF634
		private bool CanInteract()
		{
			return !this.IsBeingDragged && this.timeSinceLastDrag >= 0.1f && !NetworkSingleton<DragManager>.Instance.IsDragging && NetworkSingleton<DragManager>.Instance.IsDraggingAllowed();
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x000C146C File Offset: 0x000BF66C
		public void StartDragging(Player dragger)
		{
			if (this.IsBeingDragged)
			{
				return;
			}
			this.CurrentDragger = dragger;
			this.Rigidbody.useGravity = false;
			if (this.onDragStart != null)
			{
				this.onDragStart.Invoke();
			}
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x000C149D File Offset: 0x000BF69D
		public void StopDragging()
		{
			if (!this.IsBeingDragged)
			{
				return;
			}
			this.CurrentDragger = null;
			this.Rigidbody.useGravity = true;
			if (this.onDragEnd != null)
			{
				this.onDragEnd.Invoke();
			}
		}

		// Token: 0x040020AE RID: 8366
		public const float INITIAL_REPLICATION_DISTANCE = 1f;

		// Token: 0x040020AF RID: 8367
		public const float MAX_DRAG_START_RANGE = 2.5f;

		// Token: 0x040020B0 RID: 8368
		public const float MAX_TARGET_OFFSET = 1.5f;

		// Token: 0x040020B3 RID: 8371
		[SerializeField]
		protected string BakedGUID = string.Empty;

		// Token: 0x040020B4 RID: 8372
		[Header("References")]
		public Rigidbody Rigidbody;

		// Token: 0x040020B5 RID: 8373
		public InteractableObject IntObj;

		// Token: 0x040020B6 RID: 8374
		public Transform DragOrigin;

		// Token: 0x040020B7 RID: 8375
		[Header("Settings")]
		public bool CreateCoM = true;

		// Token: 0x040020B8 RID: 8376
		[Range(0.5f, 2f)]
		public float HoldDistanceMultiplier = 1f;

		// Token: 0x040020B9 RID: 8377
		[Range(0f, 5f)]
		public float DragForceMultiplier = 1f;

		// Token: 0x040020BA RID: 8378
		public Draggable.EInitialReplicationMode InitialReplicationMode;

		// Token: 0x040020BB RID: 8379
		private float timeSinceLastDrag = 100f;

		// Token: 0x040020BC RID: 8380
		public UnityEvent onDragStart;

		// Token: 0x040020BD RID: 8381
		public UnityEvent onDragEnd;

		// Token: 0x040020BE RID: 8382
		public UnityEvent onHovered;

		// Token: 0x040020BF RID: 8383
		public UnityEvent onInteracted;

		// Token: 0x02000684 RID: 1668
		public enum EInitialReplicationMode
		{
			// Token: 0x040020C2 RID: 8386
			Off,
			// Token: 0x040020C3 RID: 8387
			OnlyIfMoved,
			// Token: 0x040020C4 RID: 8388
			Full
		}
	}
}
