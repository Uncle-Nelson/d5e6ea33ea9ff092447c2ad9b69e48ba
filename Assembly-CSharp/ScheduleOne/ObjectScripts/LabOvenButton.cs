using System;
using System.Collections;
using ScheduleOne.DevUtilities;
using ScheduleOne.Misc;
using ScheduleOne.PlayerTasks;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BD9 RID: 3033
	public class LabOvenButton : MonoBehaviour
	{
		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x060053DD RID: 21469 RVA: 0x00161B26 File Offset: 0x0015FD26
		// (set) Token: 0x060053DE RID: 21470 RVA: 0x00161B2E File Offset: 0x0015FD2E
		public bool Pressed { get; private set; }

		// Token: 0x060053DF RID: 21471 RVA: 0x00161B37 File Offset: 0x0015FD37
		private void Start()
		{
			this.SetInteractable(false);
			this.Clickable.onClickStart.AddListener(new UnityAction<RaycastHit>(this.Press));
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x00161B5C File Offset: 0x0015FD5C
		public void SetInteractable(bool interactable)
		{
			this.Clickable.ClickableEnabled = interactable;
		}

		// Token: 0x060053E1 RID: 21473 RVA: 0x00161B6A File Offset: 0x0015FD6A
		public void Press(RaycastHit hit)
		{
			this.SetPressed(true);
		}

		// Token: 0x060053E2 RID: 21474 RVA: 0x00161B74 File Offset: 0x0015FD74
		public void SetPressed(bool pressed)
		{
			if (this.Pressed == pressed)
			{
				return;
			}
			this.Pressed = pressed;
			this.Light.isOn = pressed;
			if (this.Pressed)
			{
				if (this.pressCoroutine != null)
				{
					base.StopCoroutine(this.pressCoroutine);
				}
				this.pressCoroutine = Singleton<CoroutineService>.Instance.StartCoroutine(this.MoveButton(this.PressedTransform));
				return;
			}
			if (this.pressCoroutine != null)
			{
				base.StopCoroutine(this.pressCoroutine);
			}
			this.pressCoroutine = Singleton<CoroutineService>.Instance.StartCoroutine(this.MoveButton(this.DepressedTransform));
		}

		// Token: 0x060053E3 RID: 21475 RVA: 0x00161C07 File Offset: 0x0015FE07
		private IEnumerator MoveButton(Transform destination)
		{
			Vector3 startPos = this.Button.localPosition;
			Vector3 endPos = destination.localPosition;
			float lerpTime = 0.2f;
			for (float t = 0f; t < lerpTime; t += Time.deltaTime)
			{
				this.Button.localPosition = Vector3.Lerp(startPos, endPos, t / lerpTime);
				yield return null;
			}
			this.Button.localPosition = endPos;
			this.pressCoroutine = null;
			yield break;
		}

		// Token: 0x04003E72 RID: 15986
		public Transform Button;

		// Token: 0x04003E73 RID: 15987
		public Transform PressedTransform;

		// Token: 0x04003E74 RID: 15988
		public Transform DepressedTransform;

		// Token: 0x04003E75 RID: 15989
		public ToggleableLight Light;

		// Token: 0x04003E76 RID: 15990
		public Clickable Clickable;

		// Token: 0x04003E77 RID: 15991
		private Coroutine pressCoroutine;
	}
}
