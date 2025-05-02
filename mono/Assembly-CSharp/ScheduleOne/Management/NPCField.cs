using System;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x02000575 RID: 1397
	public class NPCField : ConfigField
	{
		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x0008EE6E File Offset: 0x0008D06E
		// (set) Token: 0x060022B3 RID: 8883 RVA: 0x0008EE76 File Offset: 0x0008D076
		public NPC SelectedNPC { get; protected set; }

		// Token: 0x060022B4 RID: 8884 RVA: 0x0008EE7F File Offset: 0x0008D07F
		public NPCField(EntityConfiguration parentConfig) : base(parentConfig)
		{
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x0008EE93 File Offset: 0x0008D093
		public void SetNPC(NPC npc, bool network)
		{
			if (this.SelectedNPC == npc)
			{
				return;
			}
			this.SelectedNPC = npc;
			if (network)
			{
				base.ParentConfig.ReplicateField(this, null);
			}
			if (this.onNPCChanged != null)
			{
				this.onNPCChanged.Invoke(npc);
			}
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x0008EECF File Offset: 0x0008D0CF
		public bool DoesNPCMatchRequirement(NPC npc)
		{
			return this.TypeRequirement == null || npc.GetType() == this.TypeRequirement;
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x0008EEF2 File Offset: 0x0008D0F2
		public override bool IsValueDefault()
		{
			return this.SelectedNPC == null;
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x0008EF00 File Offset: 0x0008D100
		public NPCFieldData GetData()
		{
			return new NPCFieldData((this.SelectedNPC != null) ? this.SelectedNPC.GUID.ToString() : "");
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x0008EF40 File Offset: 0x0008D140
		public void Load(NPCFieldData data)
		{
			if (data != null && !string.IsNullOrEmpty(data.NPCGuid))
			{
				NPC @object = GUIDManager.GetObject<NPC>(new Guid(data.NPCGuid));
				if (@object != null)
				{
					this.SetNPC(@object, true);
				}
			}
		}

		// Token: 0x04001A2D RID: 6701
		public Type TypeRequirement;

		// Token: 0x04001A2E RID: 6702
		public UnityEvent<NPC> onNPCChanged = new UnityEvent<NPC>();
	}
}
