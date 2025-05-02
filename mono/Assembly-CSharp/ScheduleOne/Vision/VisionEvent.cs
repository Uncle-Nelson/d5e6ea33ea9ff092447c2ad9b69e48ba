using System;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Vision
{
	// Token: 0x02000284 RID: 644
	public class VisionEvent
	{
		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x0003C186 File Offset: 0x0003A386
		// (set) Token: 0x06000D6E RID: 3438 RVA: 0x0003C18E File Offset: 0x0003A38E
		public Player Target { get; protected set; }

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x0003C197 File Offset: 0x0003A397
		// (set) Token: 0x06000D70 RID: 3440 RVA: 0x0003C19F File Offset: 0x0003A39F
		public PlayerVisualState.VisualState State { get; protected set; }

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x0003C1A8 File Offset: 0x0003A3A8
		// (set) Token: 0x06000D72 RID: 3442 RVA: 0x0003C1B0 File Offset: 0x0003A3B0
		public VisionCone Owner { get; protected set; }

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x0003C1B9 File Offset: 0x0003A3B9
		// (set) Token: 0x06000D74 RID: 3444 RVA: 0x0003C1C1 File Offset: 0x0003A3C1
		public float FullNoticeTime { get; protected set; }

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x0003C1CA File Offset: 0x0003A3CA
		public float NormalizedNoticeLevel
		{
			get
			{
				return this.currentNoticeTime / this.FullNoticeTime;
			}
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0003C1DC File Offset: 0x0003A3DC
		public VisionEvent(VisionCone _owner, Player _target, PlayerVisualState.VisualState _state, float _noticeTime)
		{
			this.Owner = _owner;
			this.Target = _target;
			this.State = _state;
			this.FullNoticeTime = _noticeTime;
			PlayerVisualState.VisualState state = this.State;
			state.stateDestroyed = (Action)Delegate.Combine(state.stateDestroyed, new Action(this.EndEvent));
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x0003C234 File Offset: 0x0003A434
		public void UpdateEvent(float visionDeltaThisFrame, float tickTime)
		{
			float normalizedNoticeLevel = this.NormalizedNoticeLevel;
			if (visionDeltaThisFrame > 0f)
			{
				this.timeSinceSighted = 0f;
			}
			else
			{
				this.timeSinceSighted += tickTime;
			}
			if (visionDeltaThisFrame > 0f)
			{
				this.currentNoticeTime += visionDeltaThisFrame * (this.Owner.Attentiveness * VisionCone.UniversalAttentivenessScale) * tickTime;
			}
			else if (this.timeSinceSighted > 1f * (this.Owner.Memory * VisionCone.UniversalMemoryScale))
			{
				this.currentNoticeTime -= tickTime / (this.Owner.Memory * VisionCone.UniversalMemoryScale);
			}
			this.currentNoticeTime = Mathf.Clamp(this.currentNoticeTime, 0f, this.FullNoticeTime);
			if (this.Target.Visibility.HighestVisionEvent == null || this.NormalizedNoticeLevel > this.Target.Visibility.HighestVisionEvent.NormalizedNoticeLevel)
			{
				this.Target.Visibility.HighestVisionEvent = this;
			}
			if (this.NormalizedNoticeLevel <= 0f && normalizedNoticeLevel > 0f)
			{
				this.EndEvent();
			}
			if (this.NormalizedNoticeLevel >= 0.5f && normalizedNoticeLevel < 0.5f)
			{
				if (this.Target.Visibility.HighestVisionEvent == this)
				{
					this.Target.Visibility.HighestVisionEvent = null;
				}
				this.Owner.EventHalfNoticed(this);
			}
			if (this.NormalizedNoticeLevel >= 1f && normalizedNoticeLevel < 1f)
			{
				if (this.Target.Visibility.HighestVisionEvent == this)
				{
					this.Target.Visibility.HighestVisionEvent = null;
				}
				this.Owner.EventFullyNoticed(this);
			}
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x0003C3D7 File Offset: 0x0003A5D7
		public void EndEvent()
		{
			if (this.Target.Visibility.HighestVisionEvent == this)
			{
				this.Target.Visibility.HighestVisionEvent = null;
			}
			this.Owner.EventReachedZero(this);
		}

		// Token: 0x04000E0F RID: 3599
		private const float NOTICE_DROP_THRESHOLD = 1f;

		// Token: 0x04000E14 RID: 3604
		private float timeSinceSighted;

		// Token: 0x04000E15 RID: 3605
		private float currentNoticeTime;
	}
}
