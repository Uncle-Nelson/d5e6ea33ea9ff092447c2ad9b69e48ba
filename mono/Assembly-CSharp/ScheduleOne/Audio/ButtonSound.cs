using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.Audio
{
	// Token: 0x020007A6 RID: 1958
	[RequireComponent(typeof(Button))]
	[RequireComponent(typeof(EventTrigger))]
	[RequireComponent(typeof(AudioSourceController))]
	public class ButtonSound : MonoBehaviour
	{
		// Token: 0x06003540 RID: 13632 RVA: 0x000DFF20 File Offset: 0x000DE120
		public void Awake()
		{
			this.AddEventTrigger(this.EventTrigger, 0, new Action(this.Hovered));
			this.AddEventTrigger(this.EventTrigger, 4, new Action(this.Clicked));
			this.AudioSource.AudioSource.playOnAwake = false;
			this.Button = base.GetComponent<Button>();
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x000DFF7E File Offset: 0x000DE17E
		private void OnValidate()
		{
			if (this.AudioSource == null)
			{
				this.AudioSource = base.GetComponent<AudioSourceController>();
			}
			if (this.EventTrigger == null)
			{
				this.EventTrigger = base.GetComponent<EventTrigger>();
			}
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x000DFFB4 File Offset: 0x000DE1B4
		public void AddEventTrigger(EventTrigger eventTrigger, EventTriggerType eventTriggerType, Action action)
		{
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.eventID = eventTriggerType;
			entry.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
			{
				action();
			}));
			eventTrigger.triggers.Add(entry);
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x000E0000 File Offset: 0x000DE200
		protected virtual void Hovered()
		{
			if (!this.Button.interactable)
			{
				return;
			}
			this.AudioSource.VolumeMultiplier = this.HoverSoundVolume;
			this.AudioSource.AudioSource.clip = this.HoverClip;
			this.AudioSource.PitchMultiplier = 0.9f;
			this.AudioSource.Play();
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x000E0060 File Offset: 0x000DE260
		protected virtual void Clicked()
		{
			if (!this.Button.interactable)
			{
				return;
			}
			this.AudioSource.VolumeMultiplier = this.ClickSoundVolume;
			this.AudioSource.AudioSource.clip = this.ClickClip;
			this.AudioSource.Play();
		}

		// Token: 0x04002638 RID: 9784
		public AudioSourceController AudioSource;

		// Token: 0x04002639 RID: 9785
		public EventTrigger EventTrigger;

		// Token: 0x0400263A RID: 9786
		[Header("Clips")]
		public AudioClip HoverClip;

		// Token: 0x0400263B RID: 9787
		public float HoverSoundVolume = 1f;

		// Token: 0x0400263C RID: 9788
		public AudioClip ClickClip;

		// Token: 0x0400263D RID: 9789
		public float ClickSoundVolume = 1f;

		// Token: 0x0400263E RID: 9790
		private Button Button;
	}
}
