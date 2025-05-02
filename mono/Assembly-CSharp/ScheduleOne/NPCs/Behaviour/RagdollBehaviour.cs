using System;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200052D RID: 1325
	public class RagdollBehaviour : Behaviour
	{
		// Token: 0x06001FFE RID: 8190 RVA: 0x00083B70 File Offset: 0x00081D70
		private void Start()
		{
			base.InvokeRepeating("InfrequentUpdate", 0f, 0.1f);
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x00083B88 File Offset: 0x00081D88
		private void InfrequentUpdate()
		{
			if (this.Seizure)
			{
				Rigidbody[] ragdollRBs = base.Npc.Avatar.RagdollRBs;
				for (int i = 0; i < ragdollRBs.Length; i++)
				{
					ragdollRBs[i].AddForce(Random.insideUnitSphere * this.SeizureForce, 5);
				}
			}
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x00083BE8 File Offset: 0x00081DE8
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.RagdollBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.RagdollBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x00083C01 File Offset: 0x00081E01
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.RagdollBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.RagdollBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x00083C1A File Offset: 0x00081E1A
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x00083C28 File Offset: 0x00081E28
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040018E1 RID: 6369
		public bool Seizure;

		// Token: 0x040018E2 RID: 6370
		public float SeizureForce = 1f;

		// Token: 0x040018E3 RID: 6371
		private bool dll_Excuted;

		// Token: 0x040018E4 RID: 6372
		private bool dll_Excuted;
	}
}
