using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.Variables;
using UnityEngine;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004C3 RID: 1219
	public class Lily : NPC
	{
		// Token: 0x06001AF8 RID: 6904 RVA: 0x00071CEB File Offset: 0x0006FEEB
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.CharacterClasses.Lily_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x00071CFF File Offset: 0x0006FEFF
		private void Unlocked(NPCRelationData.EUnlockType type, bool b)
		{
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Lily_Unlocked", "true", true);
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00071D16 File Offset: 0x0006FF16
		protected override void MinPass()
		{
			base.MinPass();
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00071D1E File Offset: 0x0006FF1E
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.LilyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.LilyAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00071D37 File Offset: 0x0006FF37
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.LilyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.LilyAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00071D50 File Offset: 0x0006FF50
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x00071D5E File Offset: 0x0006FF5E
		protected virtual void dll()
		{
			base.Awake();
			NPCRelationData relationData = this.RelationData;
			relationData.onUnlocked = (Action<NPCRelationData.EUnlockType, bool>)Delegate.Combine(relationData.onUnlocked, new Action<NPCRelationData.EUnlockType, bool>(this.Unlocked));
		}

		// Token: 0x040016C6 RID: 5830
		[Header("References")]
		public Transform TutorialScheduleGroup;

		// Token: 0x040016C7 RID: 5831
		public Transform RegularScheduleGroup;

		// Token: 0x040016C8 RID: 5832
		public Conditions TutorialConditions;

		// Token: 0x040016C9 RID: 5833
		private bool dll_Excuted;

		// Token: 0x040016CA RID: 5834
		private bool dll_Excuted;
	}
}
