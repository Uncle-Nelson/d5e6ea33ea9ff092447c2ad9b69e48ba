using System;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Persistence
{
	// Token: 0x02000380 RID: 896
	public class SavePoint : MonoBehaviour
	{
		// Token: 0x06001463 RID: 5219 RVA: 0x0005B28C File Offset: 0x0005948C
		public void Awake()
		{
			this.IntObj.onHovered.AddListener(new UnityAction(this.Hovered));
			this.IntObj.onInteractStart.AddListener(new UnityAction(this.Interacted));
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0005B2C8 File Offset: 0x000594C8
		public void Hovered()
		{
			if (!InstanceFinder.IsServer)
			{
				this.IntObj.SetMessage("Only host can save");
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Invalid);
				return;
			}
			if (Singleton<SaveManager>.Instance.IsSaving)
			{
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
			}
			string message;
			if (this.CanSave(out message))
			{
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				this.IntObj.SetMessage("Save game");
				return;
			}
			if (Singleton<SaveManager>.Instance.SecondsSinceLastSave < 10f)
			{
				this.IntObj.SetMessage("Game saved!");
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Label);
				return;
			}
			this.IntObj.SetMessage(message);
			this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Invalid);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0005B380 File Offset: 0x00059580
		private bool CanSave(out string reason)
		{
			reason = string.Empty;
			if (Singleton<SaveManager>.Instance.SecondsSinceLastSave < 60f)
			{
				reason = "Wait " + Mathf.Ceil(60f - Singleton<SaveManager>.Instance.SecondsSinceLastSave).ToString() + "s";
				return false;
			}
			if (Singleton<SaveManager>.Instance.SecondsSinceLastSave < 60f)
			{
				reason = "Wait " + Mathf.Ceil(60f - Singleton<SaveManager>.Instance.SecondsSinceLastSave).ToString() + "s";
				return false;
			}
			return true;
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0005B418 File Offset: 0x00059618
		public void Interacted()
		{
			string text;
			if (!this.CanSave(out text))
			{
				return;
			}
			this.Save();
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0005B438 File Offset: 0x00059638
		private void Save()
		{
			Singleton<SaveManager>.Instance.onSaveComplete.RemoveListener(new UnityAction(this.OnSaveComplete));
			Singleton<SaveManager>.Instance.onSaveComplete.AddListener(new UnityAction(this.OnSaveComplete));
			Singleton<SaveManager>.Instance.Save();
			if (this.onSaveStart != null)
			{
				this.onSaveStart.Invoke();
			}
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0005B498 File Offset: 0x00059698
		public void OnSaveComplete()
		{
			if (this.onSaveComplete != null)
			{
				this.onSaveComplete.Invoke();
			}
		}

		// Token: 0x04001338 RID: 4920
		public const float SAVE_COOLDOWN = 60f;

		// Token: 0x04001339 RID: 4921
		public InteractableObject IntObj;

		// Token: 0x0400133A RID: 4922
		public UnityEvent onSaveStart;

		// Token: 0x0400133B RID: 4923
		public UnityEvent onSaveComplete;
	}
}
