using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using ScheduleOne.UI.Compass;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000340 RID: 832
	public class Task
	{
		// Token: 0x17000379 RID: 889
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x0005195D File Offset: 0x0004FB5D
		// (set) Token: 0x060012A6 RID: 4774 RVA: 0x00051965 File Offset: 0x0004FB65
		public virtual string TaskName { get; protected set; }

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x0005196E File Offset: 0x0004FB6E
		// (set) Token: 0x060012A8 RID: 4776 RVA: 0x00051976 File Offset: 0x0004FB76
		public string CurrentInstruction { get; protected set; } = string.Empty;

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x0005197F File Offset: 0x0004FB7F
		// (set) Token: 0x060012AA RID: 4778 RVA: 0x00051987 File Offset: 0x0004FB87
		public bool TaskActive { get; private set; }

		// Token: 0x060012AB RID: 4779 RVA: 0x00051990 File Offset: 0x0004FB90
		public Task()
		{
			this.TaskActive = true;
			Singleton<TaskManager>.Instance.StartTask(this);
			Singleton<CompassManager>.Instance.SetVisible(false);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(this.TaskName);
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00051A10 File Offset: 0x0004FC10
		public virtual void StopTask()
		{
			Singleton<TaskManager>.Instance.currentTask = null;
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(this.TaskName);
			Singleton<CompassManager>.Instance.SetVisible(true);
			Singleton<CursorManager>.Instance.SetCursorAppearance(CursorManager.ECursorType.Default);
			this.TaskActive = false;
			if (this.clickable != null)
			{
				this.clickable.EndClick();
			}
			if (this.onTaskStop != null)
			{
				this.onTaskStop();
			}
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00051A81 File Offset: 0x0004FC81
		public virtual void Success()
		{
			this.Outcome = Task.EOutcome.Success;
			this.StopTask();
			Singleton<TaskManager>.Instance.PlayTaskCompleteSound();
			if (this.onTaskSuccess != null)
			{
				this.onTaskSuccess();
			}
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x00051AAD File Offset: 0x0004FCAD
		public virtual void Fail()
		{
			this.Outcome = Task.EOutcome.Fail;
			this.StopTask();
			if (this.onTaskFail != null)
			{
				this.onTaskFail();
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00051AD0 File Offset: 0x0004FCD0
		public virtual void Update()
		{
			if (this.ClickDetectionEnabled && !this.isMultiDragging)
			{
				if (GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick))
				{
					RaycastHit hit;
					this.clickable = this.GetClickable(out hit);
					if (this.clickable != null)
					{
						this.clickable.StartClick(hit);
					}
					if (this.clickable is Draggable)
					{
						this.draggable = (this.clickable as Draggable);
						this.constraint = this.draggable.GetComponent<DraggableConstraint>();
					}
				}
				if (this.clickable != null && (!GameInput.GetButton(GameInput.ButtonCode.PrimaryClick) || !this.clickable.ClickableEnabled) && !this.forcedClickables.Contains(this.clickable))
				{
					this.clickable.EndClick();
					this.clickable = null;
					this.draggable = null;
				}
			}
			else if (this.clickable != null)
			{
				this.clickable.EndClick();
				this.clickable = null;
			}
			this.UpdateCursor();
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00051BCC File Offset: 0x0004FDCC
		protected virtual void UpdateCursor()
		{
			if (this.draggable != null || this.isMultiDragging)
			{
				Singleton<CursorManager>.Instance.SetCursorAppearance(CursorManager.ECursorType.Grab);
				return;
			}
			RaycastHit raycastHit;
			Clickable clickable = this.GetClickable(out raycastHit);
			if (clickable != null)
			{
				Singleton<CursorManager>.Instance.SetCursorAppearance(clickable.HoveredCursor);
				return;
			}
			Singleton<CursorManager>.Instance.SetCursorAppearance(CursorManager.ECursorType.Default);
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00051C2C File Offset: 0x0004FE2C
		public virtual void LateUpdate()
		{
			if (this.isMultiDragging)
			{
				Singleton<TaskManagerUI>.Instance.multiGrabIndicator.position = Input.mousePosition;
				Vector3 multiDragOrigin = this.GetMultiDragOrigin();
				Vector3 a = PlayerSingleton<PlayerCamera>.Instance.Camera.WorldToScreenPoint(multiDragOrigin);
				Vector3 position = multiDragOrigin + PlayerSingleton<PlayerCamera>.Instance.transform.right * this.MultiGrabRadius;
				Vector3 b = PlayerSingleton<PlayerCamera>.Instance.Camera.WorldToScreenPoint(position);
				float num = Vector3.Distance(a, b) / Singleton<TaskManagerUI>.Instance.canvas.scaleFactor;
				Singleton<TaskManagerUI>.Instance.multiGrabIndicator.sizeDelta = new Vector2(num * 2f, num * 2f);
				Singleton<TaskManagerUI>.Instance.multiGrabIndicator.gameObject.SetActive(true);
				return;
			}
			Singleton<TaskManagerUI>.Instance.multiGrabIndicator.gameObject.SetActive(false);
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00051D08 File Offset: 0x0004FF08
		private Vector3 GetMultiDragOrigin()
		{
			Ray ray = PlayerSingleton<PlayerCamera>.Instance.Camera.ScreenPointToRay(Input.mousePosition);
			Plane plane = new Plane(this.multiGrabProjectionPlane.forward, this.multiGrabProjectionPlane.position);
			float num;
			plane.Raycast(ray, out num);
			LayerMask layerMask = default(LayerMask) | 1 << LayerMask.NameToLayer("Default");
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.MouseRaycast(num, out raycastHit, layerMask, false, 0f))
			{
				return raycastHit.point;
			}
			return ray.GetPoint(num);
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00051D9C File Offset: 0x0004FF9C
		public virtual void FixedUpdate()
		{
			this.UpdateDraggablePhysics();
			if (this.ClickDetectionEnabled && this.multiDraggingEnabled && this.multiGrabProjectionPlane != null && GameInput.GetButton(GameInput.ButtonCode.SecondaryClick) && this.draggable == null)
			{
				this.isMultiDragging = true;
				Vector3 multiDragOrigin = this.GetMultiDragOrigin();
				Collider[] array = Physics.OverlapSphere(multiDragOrigin, this.MultiGrabRadius, LayerMask.GetMask(new string[]
				{
					"Task"
				}));
				List<Draggable> list = new List<Draggable>();
				Collider[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					Draggable componentInParent = array2[i].GetComponentInParent<Draggable>();
					if (componentInParent != null && componentInParent.ClickableEnabled && componentInParent.CanBeMultiDragged)
					{
						list.Add(componentInParent);
					}
				}
				foreach (Draggable draggable in list)
				{
					if (!this.multiDragTargets.Contains(draggable))
					{
						this.multiDragTargets.Add(draggable);
						draggable.StartClick(default(RaycastHit));
						draggable.Rb.useGravity = false;
					}
					Vector3 vector = (multiDragOrigin - draggable.transform.position) * 10f * draggable.DragForceMultiplier * 1.25f;
					draggable.Rb.AddForce(vector, 5);
				}
				foreach (Draggable draggable2 in this.multiDragTargets.ToArray())
				{
					if (!list.Contains(draggable2))
					{
						this.multiDragTargets.Remove(draggable2);
						draggable2.EndClick();
						draggable2.Rb.useGravity = true;
					}
				}
				return;
			}
			this.isMultiDragging = false;
			foreach (Draggable draggable3 in this.multiDragTargets.ToArray())
			{
				this.multiDragTargets.Remove(draggable3);
				draggable3.EndClick();
				draggable3.Rb.useGravity = true;
			}
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00051FBC File Offset: 0x000501BC
		public void ForceStartClick(Clickable _clickable)
		{
			if (!this.forcedClickables.Contains(_clickable))
			{
				this.forcedClickables.Add(_clickable);
			}
			_clickable.StartClick(default(RaycastHit));
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00051FF2 File Offset: 0x000501F2
		public void ForceEndClick(Clickable _clickable)
		{
			if (_clickable != null)
			{
				_clickable.EndClick();
				this.forcedClickables.Remove(_clickable);
			}
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00052010 File Offset: 0x00050210
		private void UpdateDraggablePhysics()
		{
			if (this.draggable != null)
			{
				Vector3 normalized = Vector3.ProjectOnPlane(PlayerSingleton<PlayerCamera>.Instance.Camera.transform.forward, Vector3.up).normalized;
				Vector3 inNormal = (this.draggable.DragProjectionMode == Draggable.EDragProjectionMode.CameraForward) ? PlayerSingleton<PlayerCamera>.Instance.transform.forward : normalized;
				if (this.constraint != null && this.constraint.ProportionalZClamp)
				{
					inNormal = this.constraint.Container.forward;
				}
				Plane plane = new Plane(inNormal, this.draggable.originalHitPoint);
				Ray ray = PlayerSingleton<PlayerCamera>.Instance.Camera.ScreenPointToRay(Input.mousePosition);
				float distance;
				plane.Raycast(ray, out distance);
				Vector3 vector = (ray.GetPoint(distance) - this.draggable.transform.TransformPoint(this.relativeHitOffset)) * 10f * this.draggable.DragForceMultiplier;
				if (this.draggable.DragForceOrigin != null)
				{
					this.draggable.Rb.AddForceAtPosition(vector, this.draggable.DragForceOrigin.position, 5);
				}
				else
				{
					this.draggable.Rb.AddForce(vector, 5);
				}
				if (this.draggable.RotationEnabled)
				{
					float x = GameInput.MotionAxis.x;
					Vector3 a = normalized;
					this.draggable.Rb.AddTorque(a * -x * this.draggable.TorqueMultiplier, 5);
				}
				this.draggable.PostFixedUpdate();
			}
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x000521B4 File Offset: 0x000503B4
		protected virtual Clickable GetClickable(out RaycastHit hit)
		{
			LayerMask layerMask = default(LayerMask) | 1 << LayerMask.NameToLayer("Task");
			layerMask |= 1 << LayerMask.NameToLayer("Temporary");
			if (PlayerSingleton<PlayerCamera>.Instance.MouseRaycast(3f, out hit, layerMask, true, this.ClickDetectionRadius))
			{
				Clickable componentInParent = hit.collider.GetComponentInParent<Clickable>();
				if (componentInParent != null)
				{
					if (!componentInParent.enabled)
					{
						return null;
					}
					if (!componentInParent.ClickableEnabled)
					{
						return null;
					}
					if (componentInParent.IsHeld)
					{
						return null;
					}
					this.hitDistance = Vector3.Distance(PlayerSingleton<PlayerCamera>.Instance.transform.position, hit.point);
					componentInParent.SetOriginalHitPoint(hit.point);
					if (componentInParent.AutoCalculateOffset)
					{
						this.relativeHitOffset = componentInParent.transform.InverseTransformPoint(hit.point);
						if (componentInParent.FlattenZOffset)
						{
							this.relativeHitOffset.z = 0f;
						}
					}
					else
					{
						this.relativeHitOffset = Vector3.zero;
					}
				}
				return componentInParent;
			}
			return null;
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x000522C7 File Offset: 0x000504C7
		protected void EnableMultiDragging(Transform projectionPlane, float radius = 0.08f)
		{
			this.multiDraggingEnabled = true;
			this.multiGrabProjectionPlane = projectionPlane;
			this.MultiGrabRadius = radius;
		}

		// Token: 0x0400120A RID: 4618
		public const float ClickDetectionRange = 3f;

		// Token: 0x0400120B RID: 4619
		public float ClickDetectionRadius;

		// Token: 0x0400120C RID: 4620
		protected float MultiGrabRadius = 0.08f;

		// Token: 0x0400120D RID: 4621
		public const float MultiGrabForceMultiplier = 1.25f;

		// Token: 0x04001211 RID: 4625
		public bool ClickDetectionEnabled = true;

		// Token: 0x04001212 RID: 4626
		public Task.EOutcome Outcome;

		// Token: 0x04001213 RID: 4627
		public Action onTaskSuccess;

		// Token: 0x04001214 RID: 4628
		public Action onTaskFail;

		// Token: 0x04001215 RID: 4629
		public Action onTaskStop;

		// Token: 0x04001216 RID: 4630
		protected Clickable clickable;

		// Token: 0x04001217 RID: 4631
		protected Draggable draggable;

		// Token: 0x04001218 RID: 4632
		protected DraggableConstraint constraint;

		// Token: 0x04001219 RID: 4633
		protected float hitDistance;

		// Token: 0x0400121A RID: 4634
		protected Vector3 relativeHitOffset = Vector3.zero;

		// Token: 0x0400121B RID: 4635
		private bool multiDraggingEnabled;

		// Token: 0x0400121C RID: 4636
		private Transform multiGrabProjectionPlane;

		// Token: 0x0400121D RID: 4637
		private List<Draggable> multiDragTargets = new List<Draggable>();

		// Token: 0x0400121E RID: 4638
		private bool isMultiDragging;

		// Token: 0x0400121F RID: 4639
		private List<Clickable> forcedClickables = new List<Clickable>();

		// Token: 0x02000341 RID: 833
		public enum EOutcome
		{
			// Token: 0x04001221 RID: 4641
			Cancelled,
			// Token: 0x04001222 RID: 4642
			Success,
			// Token: 0x04001223 RID: 4643
			Fail
		}
	}
}
