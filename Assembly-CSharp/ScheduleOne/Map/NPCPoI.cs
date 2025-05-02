using System;
using ScheduleOne.NPCs;
using UnityEngine.UI;

namespace ScheduleOne.Map
{
	// Token: 0x02000C27 RID: 3111
	public class NPCPoI : POI
	{
		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06005743 RID: 22339 RVA: 0x0016E94E File Offset: 0x0016CB4E
		// (set) Token: 0x06005744 RID: 22340 RVA: 0x0016E956 File Offset: 0x0016CB56
		public NPC NPC { get; private set; }

		// Token: 0x06005745 RID: 22341 RVA: 0x0016E960 File Offset: 0x0016CB60
		public override void InitializeUI()
		{
			base.InitializeUI();
			if (base.IconContainer != null && this.NPC != null)
			{
				base.IconContainer.Find("Outline/Icon").GetComponent<Image>().sprite = this.NPC.MugshotSprite;
			}
		}

		// Token: 0x06005746 RID: 22342 RVA: 0x0016E9B4 File Offset: 0x0016CBB4
		public void SetNPC(NPC npc)
		{
			this.NPC = npc;
			if (base.IconContainer != null && this.NPC != null)
			{
				base.IconContainer.Find("Outline/Icon").GetComponent<Image>().sprite = this.NPC.MugshotSprite;
			}
		}
	}
}
