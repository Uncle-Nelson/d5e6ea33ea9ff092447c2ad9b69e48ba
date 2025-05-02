using System;
using System.Collections.Generic;
using EasyButtons;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Cutscenes
{
	// Token: 0x0200071F RID: 1823
	public class CutsceneManager : Singleton<CutsceneManager>
	{
		// Token: 0x06003161 RID: 12641 RVA: 0x000CD120 File Offset: 0x000CB320
		[Button]
		private void RunCutscene()
		{
			this.Play(this.cutsceneName);
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x000CD130 File Offset: 0x000CB330
		public void Play(string name)
		{
			Cutscene cutscene = this.Cutscenes.Find((Cutscene c) => c.Name == name);
			if (cutscene != null)
			{
				cutscene.Play();
				this.playingCutscene = cutscene;
				this.playingCutscene.onEnd.AddListener(new UnityAction(this.Ended));
			}
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x000CD194 File Offset: 0x000CB394
		private void Ended()
		{
			this.playingCutscene.onEnd.RemoveListener(new UnityAction(this.Ended));
			this.playingCutscene = null;
		}

		// Token: 0x0400232D RID: 9005
		public List<Cutscene> Cutscenes;

		// Token: 0x0400232E RID: 9006
		[Header("Run cutscene by name")]
		[SerializeField]
		private string cutsceneName = "Wake up morning";

		// Token: 0x0400232F RID: 9007
		private Cutscene playingCutscene;
	}
}
