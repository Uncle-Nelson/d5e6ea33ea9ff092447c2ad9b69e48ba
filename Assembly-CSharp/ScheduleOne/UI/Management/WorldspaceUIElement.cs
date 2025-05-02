using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000B12 RID: 2834
	public class WorldspaceUIElement : MonoBehaviour
	{
		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06004BAF RID: 19375 RVA: 0x0013E2D1 File Offset: 0x0013C4D1
		// (set) Token: 0x06004BB0 RID: 19376 RVA: 0x0013E2D9 File Offset: 0x0013C4D9
		public bool IsEnabled { get; protected set; }

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06004BB1 RID: 19377 RVA: 0x0013E2E2 File Offset: 0x0013C4E2
		public bool IsVisible
		{
			get
			{
				return base.gameObject.activeSelf;
			}
		}

		// Token: 0x06004BB2 RID: 19378 RVA: 0x0013E2F0 File Offset: 0x0013C4F0
		public virtual void Show()
		{
			if (this == null || this.Container == null)
			{
				return;
			}
			if (base.gameObject == null)
			{
				return;
			}
			this.IsEnabled = true;
			base.gameObject.SetActive(true);
			this.SetScale(1f, null);
		}

		// Token: 0x06004BB3 RID: 19379 RVA: 0x0013E344 File Offset: 0x0013C544
		public virtual void Hide(Action callback = null)
		{
			if (this == null || this.Container == null)
			{
				return;
			}
			this.IsEnabled = false;
			this.SetScale(0f, delegate
			{
				base.<Hide>g__Done|1();
			});
		}

		// Token: 0x06004BB4 RID: 19380 RVA: 0x000FA546 File Offset: 0x000F8746
		public virtual void Destroy()
		{
			Object.Destroy(base.gameObject);
		}

		// Token: 0x06004BB5 RID: 19381 RVA: 0x0013E39C File Offset: 0x0013C59C
		public void UpdatePosition(Vector3 worldSpacePosition)
		{
			if (this == null || this.Container == null)
			{
				return;
			}
			if (PlayerSingleton<PlayerCamera>.Instance.transform.InverseTransformPoint(worldSpacePosition).z > 0f)
			{
				this.RectTransform.position = PlayerSingleton<PlayerCamera>.Instance.Camera.WorldToScreenPoint(worldSpacePosition);
				this.Container.gameObject.SetActive(true);
				return;
			}
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x06004BB6 RID: 19382 RVA: 0x0013E41B File Offset: 0x0013C61B
		public virtual void SetInternalScale(float scale)
		{
			if (this == null || this.Container == null)
			{
				return;
			}
			this.Container.localScale = new Vector3(scale, scale, 1f);
		}

		// Token: 0x06004BB7 RID: 19383 RVA: 0x0013E44C File Offset: 0x0013C64C
		private void SetScale(float scale, Action callback)
		{
			WorldspaceUIElement.<>c__DisplayClass17_0 CS$<>8__locals1 = new WorldspaceUIElement.<>c__DisplayClass17_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.scale = scale;
			CS$<>8__locals1.callback = callback;
			if (this == null || this.Container == null)
			{
				return;
			}
			if (this.scaleRoutine != null)
			{
				Singleton<CoroutineService>.Instance.StopCoroutine(this.scaleRoutine);
			}
			if (!base.gameObject.activeInHierarchy)
			{
				this.RectTransform.localScale = new Vector3(CS$<>8__locals1.scale, CS$<>8__locals1.scale, 1f);
				if (CS$<>8__locals1.callback != null)
				{
					CS$<>8__locals1.callback();
				}
				return;
			}
			CS$<>8__locals1.startScale = this.RectTransform.localScale.x;
			CS$<>8__locals1.lerpTime = 0.1f / Mathf.Abs(CS$<>8__locals1.startScale - CS$<>8__locals1.scale);
			this.scaleRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SetScale>g__Routine|0());
		}

		// Token: 0x06004BB8 RID: 19384 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void HoverStart()
		{
		}

		// Token: 0x06004BB9 RID: 19385 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void HoverEnd()
		{
		}

		// Token: 0x06004BBA RID: 19386 RVA: 0x0013E530 File Offset: 0x0013C730
		public void SetAssignedNPC(NPC npc)
		{
			if (this == null || this.Container == null)
			{
				return;
			}
			this.AssignedWorkerDisplay.Set(npc);
		}

		// Token: 0x040038BC RID: 14524
		public const float TRANSITION_TIME = 0.1f;

		// Token: 0x040038BE RID: 14526
		[Header("References")]
		public RectTransform RectTransform;

		// Token: 0x040038BF RID: 14527
		public RectTransform Container;

		// Token: 0x040038C0 RID: 14528
		public TextMeshProUGUI TitleLabel;

		// Token: 0x040038C1 RID: 14529
		public AssignedWorkerDisplay AssignedWorkerDisplay;

		// Token: 0x040038C2 RID: 14530
		private Coroutine scaleRoutine;
	}
}
