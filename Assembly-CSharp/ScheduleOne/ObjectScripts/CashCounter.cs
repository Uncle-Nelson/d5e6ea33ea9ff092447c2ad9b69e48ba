using System;
using System.Collections;
using System.Collections.Generic;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000B92 RID: 2962
	public class CashCounter : MonoBehaviour
	{
		// Token: 0x06004F0E RID: 20238 RVA: 0x0014D714 File Offset: 0x0014B914
		public virtual void LateUpdate()
		{
			this.UpperNotes.gameObject.SetActive(this.IsOn);
			this.LowerNotes.gameObject.SetActive(this.IsOn);
			if (this.IsOn)
			{
				if (!this.lerping)
				{
					this.lerping = true;
					for (int i = 0; i < this.MovingNotes.Count; i++)
					{
						base.StartCoroutine(this.LerpNote(this.MovingNotes[i]));
					}
				}
				if (!this.Audio.AudioSource.isPlaying)
				{
					this.Audio.Play();
					return;
				}
			}
			else
			{
				this.lerping = false;
				if (this.Audio.AudioSource.isPlaying)
				{
					this.Audio.Stop();
				}
			}
		}

		// Token: 0x06004F0F RID: 20239 RVA: 0x0014D7D5 File Offset: 0x0014B9D5
		private IEnumerator LerpNote(Transform note)
		{
			yield return new WaitForSeconds((float)this.MovingNotes.IndexOf(note) / (float)(this.MovingNotes.Count + 1) * 0.18f);
			note.gameObject.SetActive(true);
			while (this.IsOn)
			{
				note.position = this.NoteStartPoint.position;
				note.rotation = this.NoteStartPoint.rotation;
				for (float i = 0f; i < 0.18f; i += Time.deltaTime)
				{
					note.position = Vector3.Lerp(this.NoteStartPoint.position, this.NoteEndPoint.position, i / 0.18f);
					note.rotation = Quaternion.Lerp(this.NoteStartPoint.rotation, this.NoteEndPoint.rotation, i / 0.18f);
					yield return new WaitForEndOfFrame();
				}
			}
			note.gameObject.SetActive(false);
			yield break;
		}

		// Token: 0x04003BA1 RID: 15265
		public const float NoteLerpTime = 0.18f;

		// Token: 0x04003BA2 RID: 15266
		public bool IsOn;

		// Token: 0x04003BA3 RID: 15267
		[Header("References")]
		public GameObject UpperNotes;

		// Token: 0x04003BA4 RID: 15268
		public GameObject LowerNotes;

		// Token: 0x04003BA5 RID: 15269
		public Transform NoteStartPoint;

		// Token: 0x04003BA6 RID: 15270
		public Transform NoteEndPoint;

		// Token: 0x04003BA7 RID: 15271
		public List<Transform> MovingNotes = new List<Transform>();

		// Token: 0x04003BA8 RID: 15272
		public AudioSourceController Audio;

		// Token: 0x04003BA9 RID: 15273
		private bool lerping;
	}
}
