using System;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.Lighting;
using ScheduleOne.PlayerScripts;
using ScheduleOne.ScriptableObjects;
using ScheduleOne.UI.Phone;
using UnityEngine;

namespace ScheduleOne.Calling
{
	// Token: 0x0200077B RID: 1915
	public class PayPhone : MonoBehaviour
	{
		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06003461 RID: 13409 RVA: 0x000DAD44 File Offset: 0x000D8F44
		public PhoneCallData QueuedCall
		{
			get
			{
				return Singleton<CallManager>.Instance.QueuedCallData;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06003462 RID: 13410 RVA: 0x000DAD50 File Offset: 0x000D8F50
		public PhoneCallData ActiveCall
		{
			get
			{
				return Singleton<CallInterface>.Instance.ActiveCallData;
			}
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x000DAD5C File Offset: 0x000D8F5C
		public void FixedUpdate()
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			this.timeSinceLastRing += Time.fixedDeltaTime;
			float num = Vector3.SqrMagnitude(PlayerSingleton<PlayerCamera>.Instance.transform.position - base.transform.position);
			this.Light.IsOn = (this.QueuedCall != null && this.ActiveCall == null);
			if (num < 81f && this.QueuedCall != null && this.timeSinceLastRing >= 4f && this.ActiveCall == null)
			{
				this.timeSinceLastRing = 0f;
				this.RingSound.Play();
			}
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x000DAE15 File Offset: 0x000D9015
		public void Hovered()
		{
			if (this.CanInteract())
			{
				this.IntObj.SetMessage("Answer phone");
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				return;
			}
			this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x000DAE48 File Offset: 0x000D9048
		public void Interacted()
		{
			if (!this.CanInteract())
			{
				return;
			}
			Singleton<CallInterface>.Instance.StartCall(this.QueuedCall, this.QueuedCall.CallerID, 0);
			this.RingSound.Stop();
			this.AnswerSound.Play();
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.CameraPosition.position, this.CameraPosition.rotation, 0.2f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(60f, 0.2f);
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x000DAECA File Offset: 0x000D90CA
		private bool CanInteract()
		{
			return !(this.QueuedCall == null) && !(this.ActiveCall != null) && !Singleton<CallInterface>.Instance.IsOpen;
		}

		// Token: 0x0400256C RID: 9580
		public const float RING_INTERVAL = 4f;

		// Token: 0x0400256D RID: 9581
		public const float RING_RANGE = 9f;

		// Token: 0x0400256E RID: 9582
		public BlinkingLight Light;

		// Token: 0x0400256F RID: 9583
		public AudioSourceController RingSound;

		// Token: 0x04002570 RID: 9584
		public AudioSourceController AnswerSound;

		// Token: 0x04002571 RID: 9585
		public InteractableObject IntObj;

		// Token: 0x04002572 RID: 9586
		public Transform CameraPosition;

		// Token: 0x04002573 RID: 9587
		private float timeSinceLastRing = 100f;

		// Token: 0x04002574 RID: 9588
		private const float ringRangeSquared = 81f;
	}
}
