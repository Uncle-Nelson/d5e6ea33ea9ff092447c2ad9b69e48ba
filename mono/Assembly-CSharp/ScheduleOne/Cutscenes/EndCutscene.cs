using System;
using ScheduleOne.AvatarFramework;
using ScheduleOne.PlayerScripts;
using UnityEngine.Events;

namespace ScheduleOne.Cutscenes
{
	// Token: 0x02000721 RID: 1825
	public class EndCutscene : Cutscene
	{
		// Token: 0x06003167 RID: 12647 RVA: 0x000CD1DF File Offset: 0x000CB3DF
		public override void Play()
		{
			base.Play();
			this.Avatar.LoadAvatarSettings(Player.Local.Avatar.CurrentSettings);
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x000CD201 File Offset: 0x000CB401
		public void StandUp()
		{
			if (this.onStandUp != null)
			{
				Console.Log("StandUp", null);
				this.onStandUp.Invoke();
			}
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x000CD221 File Offset: 0x000CB421
		public void RunStart()
		{
			if (this.onRunStart != null)
			{
				Console.Log("RunStart", null);
				this.onRunStart.Invoke();
			}
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x000CD241 File Offset: 0x000CB441
		public void EngineStart()
		{
			if (this.onEngineStart != null)
			{
				Console.Log("EngineStart", null);
				this.onEngineStart.Invoke();
			}
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x000CD261 File Offset: 0x000CB461
		public void On3rdPerson()
		{
			this.Avatar.gameObject.SetActive(true);
			this.Avatar.Anim.SetBool("Sitting", true);
		}

		// Token: 0x04002331 RID: 9009
		public UnityEvent onStandUp;

		// Token: 0x04002332 RID: 9010
		public UnityEvent onRunStart;

		// Token: 0x04002333 RID: 9011
		public UnityEvent onEngineStart;

		// Token: 0x04002334 RID: 9012
		public Avatar Avatar;
	}
}
