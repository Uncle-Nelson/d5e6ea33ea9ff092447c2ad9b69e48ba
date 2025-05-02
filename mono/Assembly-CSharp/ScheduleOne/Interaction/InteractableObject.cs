using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Interaction
{
	// Token: 0x02000611 RID: 1553
	public class InteractableObject : MonoBehaviour
	{
		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x000A7A08 File Offset: 0x000A5C08
		public InteractableObject.EInteractionType _interactionType
		{
			get
			{
				return this.interactionType;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060028B0 RID: 10416 RVA: 0x000A7A10 File Offset: 0x000A5C10
		public InteractableObject.EInteractableState _interactionState
		{
			get
			{
				return this.interactionState;
			}
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x000A7A18 File Offset: 0x000A5C18
		public void SetInteractionType(InteractableObject.EInteractionType type)
		{
			this.interactionType = type;
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x000A7A21 File Offset: 0x000A5C21
		public void SetInteractableState(InteractableObject.EInteractableState state)
		{
			this.interactionState = state;
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x000A7A2A File Offset: 0x000A5C2A
		public void SetMessage(string _message)
		{
			this.message = _message;
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x000A7A33 File Offset: 0x000A5C33
		public virtual void Hovered()
		{
			if (this.onHovered != null)
			{
				this.onHovered.Invoke();
			}
			if (this.interactionState != InteractableObject.EInteractableState.Disabled)
			{
				this.ShowMessage();
			}
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x000A7A57 File Offset: 0x000A5C57
		public virtual void StartInteract()
		{
			if (this.interactionState == InteractableObject.EInteractableState.Invalid)
			{
				return;
			}
			if (this.onInteractStart != null)
			{
				this.onInteractStart.Invoke();
			}
			Singleton<InteractionManager>.Instance.LerpDisplayScale(0.9f);
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x000A7A85 File Offset: 0x000A5C85
		public virtual void EndInteract()
		{
			if (this.onInteractEnd != null)
			{
				this.onInteractEnd.Invoke();
			}
			Singleton<InteractionManager>.Instance.LerpDisplayScale(1f);
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x000A7AAC File Offset: 0x000A5CAC
		protected virtual void ShowMessage()
		{
			Vector3 pos = base.transform.position;
			if (this.displayLocationCollider != null)
			{
				pos = this.displayLocationCollider.ClosestPoint(PlayerSingleton<PlayerCamera>.Instance.transform.position);
			}
			else if (this.displayLocationPoint != null)
			{
				pos = this.displayLocationPoint.position;
			}
			Sprite icon = null;
			string spriteText = string.Empty;
			Color iconColor = Color.white;
			Color messageColor = Color.white;
			switch (this.interactionState)
			{
			case InteractableObject.EInteractableState.Default:
			{
				messageColor = Singleton<InteractionManager>.Instance.messageColor_Default;
				InteractableObject.EInteractionType einteractionType = this.interactionType;
				if (einteractionType != InteractableObject.EInteractionType.Key_Press)
				{
					if (einteractionType != InteractableObject.EInteractionType.LeftMouse_Click)
					{
						Console.LogWarning("EInteractionType not accounted for!", null);
					}
					else
					{
						icon = Singleton<InteractionManager>.Instance.icon_LeftMouse;
						iconColor = Singleton<InteractionManager>.Instance.iconColor_Default;
					}
				}
				else
				{
					icon = Singleton<InteractionManager>.Instance.icon_Key;
					spriteText = Singleton<InteractionManager>.Instance.InteractKey;
					iconColor = Singleton<InteractionManager>.Instance.iconColor_Default_Key;
				}
				break;
			}
			case InteractableObject.EInteractableState.Invalid:
				icon = Singleton<InteractionManager>.Instance.icon_Cross;
				iconColor = Singleton<InteractionManager>.Instance.iconColor_Invalid;
				messageColor = Singleton<InteractionManager>.Instance.messageColor_Invalid;
				break;
			case InteractableObject.EInteractableState.Disabled:
				return;
			case InteractableObject.EInteractableState.Label:
				icon = null;
				messageColor = Singleton<InteractionManager>.Instance.messageColor_Default;
				break;
			default:
				Console.LogWarning("EInteractableState not accounted for!", null);
				return;
			}
			Singleton<InteractionManager>.Instance.EnableInteractionDisplay(pos, icon, spriteText, this.message, messageColor, iconColor);
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x000A7C04 File Offset: 0x000A5E04
		public bool CheckAngleLimit(Vector3 interactionSource)
		{
			if (!this.LimitInteractionAngle)
			{
				return true;
			}
			Vector3 normalized = (interactionSource - base.transform.position).normalized;
			return Mathf.Abs(Vector3.SignedAngle(base.transform.forward, normalized, Vector3.up)) < this.AngleLimit;
		}

		// Token: 0x04001DBC RID: 7612
		[Header("Settings")]
		[SerializeField]
		protected string message = "<Message>";

		// Token: 0x04001DBD RID: 7613
		[SerializeField]
		protected InteractableObject.EInteractionType interactionType;

		// Token: 0x04001DBE RID: 7614
		[SerializeField]
		protected InteractableObject.EInteractableState interactionState;

		// Token: 0x04001DBF RID: 7615
		public float MaxInteractionRange = 5f;

		// Token: 0x04001DC0 RID: 7616
		public bool RequiresUniqueClick = true;

		// Token: 0x04001DC1 RID: 7617
		public int Priority;

		// Token: 0x04001DC2 RID: 7618
		[SerializeField]
		protected Collider displayLocationCollider;

		// Token: 0x04001DC3 RID: 7619
		public Transform displayLocationPoint;

		// Token: 0x04001DC4 RID: 7620
		[Header("Angle Limits")]
		public bool LimitInteractionAngle;

		// Token: 0x04001DC5 RID: 7621
		public float AngleLimit = 90f;

		// Token: 0x04001DC6 RID: 7622
		[Header("Events")]
		public UnityEvent onHovered = new UnityEvent();

		// Token: 0x04001DC7 RID: 7623
		public UnityEvent onInteractStart = new UnityEvent();

		// Token: 0x04001DC8 RID: 7624
		public UnityEvent onInteractEnd = new UnityEvent();

		// Token: 0x02000612 RID: 1554
		public enum EInteractionType
		{
			// Token: 0x04001DCA RID: 7626
			Key_Press,
			// Token: 0x04001DCB RID: 7627
			LeftMouse_Click
		}

		// Token: 0x02000613 RID: 1555
		public enum EInteractableState
		{
			// Token: 0x04001DCD RID: 7629
			Default,
			// Token: 0x04001DCE RID: 7630
			Invalid,
			// Token: 0x04001DCF RID: 7631
			Disabled,
			// Token: 0x04001DD0 RID: 7632
			Label
		}
	}
}
