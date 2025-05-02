using System;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000328 RID: 808
	public abstract class Property : ScriptableObject
	{
		// Token: 0x060011CC RID: 4556
		public abstract void ApplyToNPC(NPC npc);

		// Token: 0x060011CD RID: 4557
		public abstract void ClearFromNPC(NPC npc);

		// Token: 0x060011CE RID: 4558
		public abstract void ApplyToPlayer(Player player);

		// Token: 0x060011CF RID: 4559
		public abstract void ClearFromPlayer(Player player);

		// Token: 0x060011D0 RID: 4560 RVA: 0x0004D9A8 File Offset: 0x0004BBA8
		public void OnValidate()
		{
			if (this.Name == string.Empty)
			{
				this.Name = base.name;
			}
			if (this.ID == string.Empty)
			{
				this.ID = base.name.ToLower();
			}
		}

		// Token: 0x04001155 RID: 4437
		public string Name = string.Empty;

		// Token: 0x04001156 RID: 4438
		public string Description = string.Empty;

		// Token: 0x04001157 RID: 4439
		public string ID = string.Empty;

		// Token: 0x04001158 RID: 4440
		[Range(1f, 5f)]
		public int Tier = 1;

		// Token: 0x04001159 RID: 4441
		[Range(0f, 1f)]
		public float Addictiveness = 0.1f;

		// Token: 0x0400115A RID: 4442
		public Color ProductColor = Color.white;

		// Token: 0x0400115B RID: 4443
		public Color LabelColor = Color.white;

		// Token: 0x0400115C RID: 4444
		public bool ImplementedPriorMixingRework;

		// Token: 0x0400115D RID: 4445
		[Header("Value")]
		[Range(-100f, 100f)]
		public int ValueChange;

		// Token: 0x0400115E RID: 4446
		[Range(0f, 2f)]
		public float ValueMultiplier = 1f;

		// Token: 0x0400115F RID: 4447
		[Range(-1f, 1f)]
		public float AddBaseValueMultiple;

		// Token: 0x04001160 RID: 4448
		public Vector2 MixDirection = Vector2.zero;

		// Token: 0x04001161 RID: 4449
		public float MixMagnitude = 1f;
	}
}
