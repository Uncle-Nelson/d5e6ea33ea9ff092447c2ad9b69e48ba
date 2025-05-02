using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Employees;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000514 RID: 1300
	public class StartLabOvenBehaviour : Behaviour
	{
		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001EBD RID: 7869 RVA: 0x0007E3D8 File Offset: 0x0007C5D8
		// (set) Token: 0x06001EBE RID: 7870 RVA: 0x0007E3E0 File Offset: 0x0007C5E0
		public LabOven targetOven { get; private set; }

		// Token: 0x06001EBF RID: 7871 RVA: 0x0007E3E9 File Offset: 0x0007C5E9
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.Behaviour.StartLabOvenBehaviour_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x0007E3FD File Offset: 0x0007C5FD
		public void SetTargetOven(LabOven oven)
		{
			this.targetOven = oven;
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x0007E406 File Offset: 0x0007C606
		protected override void End()
		{
			base.End();
			if (this.targetOven != null)
			{
				this.targetOven.Door.SetPosition(0f);
			}
			if (this.cookRoutine != null)
			{
				this.StopCook();
			}
			this.Disable();
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x0007E448 File Offset: 0x0007C648
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (this.cookRoutine != null)
			{
				base.Npc.Avatar.LookController.OverrideLookTarget(this.targetOven.UIPoint.position, 5, false);
				return;
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!base.Npc.Movement.IsMoving)
			{
				if (this.IsAtStation())
				{
					this.StartCook();
					return;
				}
				base.SetDestination(this.GetStationAccessPoint(), true);
			}
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x0007E4C1 File Offset: 0x0007C6C1
		[ObserversRpc(RunLocally = true)]
		private void StartCook()
		{
			this.RpcWriter___Observers_StartCook_2166136261();
			this.RpcLogic___StartCook_2166136261();
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x0007E4D0 File Offset: 0x0007C6D0
		private bool CanCookStart()
		{
			return !(this.targetOven == null) && (!((IUsable)this.targetOven).IsInUse || !(((IUsable)this.targetOven).NPCUserObject != base.Npc.NetworkObject)) && this.targetOven.CurrentOperation == null && this.targetOven.IsIngredientCookable();
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x0007E538 File Offset: 0x0007C738
		private void StopCook()
		{
			if (this.targetOven != null)
			{
				this.targetOven.SetNPCUser(null);
			}
			if (this.cookRoutine != null)
			{
				base.StopCoroutine(this.cookRoutine);
				this.cookRoutine = null;
			}
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x0007E56F File Offset: 0x0007C76F
		private Vector3 GetStationAccessPoint()
		{
			if (this.targetOven == null)
			{
				return base.Npc.transform.position;
			}
			return ((ITransitEntity)this.targetOven).AccessPoints[0].position;
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x0007E5A2 File Offset: 0x0007C7A2
		private bool IsAtStation()
		{
			return !(this.targetOven == null) && Vector3.Distance(base.Npc.transform.position, this.GetStationAccessPoint()) < 1f;
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x0007E5D6 File Offset: 0x0007C7D6
		[CompilerGenerated]
		private IEnumerator <StartCook>g__CookRoutine|11_0()
		{
			Console.Log("Starting cook...", null);
			this.targetOven.SetNPCUser(base.Npc.NetworkObject);
			base.Npc.Movement.FacePoint(this.targetOven.transform.position, 0.5f);
			yield return new WaitForSeconds(0.5f);
			if (!this.CanCookStart())
			{
				this.StopCook();
				base.End_Networked(null);
				yield break;
			}
			this.targetOven.Door.SetPosition(1f);
			yield return new WaitForSeconds(0.5f);
			this.targetOven.WireTray.SetPosition(1f);
			yield return new WaitForSeconds(5f);
			this.targetOven.Door.SetPosition(0f);
			yield return new WaitForSeconds(1f);
			ItemInstance itemInstance = this.targetOven.IngredientSlot.ItemInstance;
			if (itemInstance == null)
			{
				Console.LogWarning("No ingredient in oven!", null);
				this.StopCook();
				base.End_Networked(null);
				yield break;
			}
			int num = 1;
			if ((itemInstance.Definition as StorableItemDefinition).StationItem.GetModule<CookableModule>().CookType == CookableModule.ECookableType.Solid)
			{
				num = Mathf.Min(this.targetOven.IngredientSlot.Quantity, 10);
			}
			itemInstance.ChangeQuantity(-num);
			string id = (itemInstance.Definition as StorableItemDefinition).StationItem.GetModule<CookableModule>().Product.ID;
			EQuality ingredientQuality = EQuality.Standard;
			if (itemInstance is QualityItemInstance)
			{
				ingredientQuality = (itemInstance as QualityItemInstance).Quality;
			}
			this.targetOven.SendCookOperation(new OvenCookOperation(itemInstance.ID, ingredientQuality, num, id));
			this.StopCook();
			base.End_Networked(null);
			yield break;
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x0007E5E5 File Offset: 0x0007C7E5
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartLabOvenBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartLabOvenBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_StartCook_2166136261));
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x0007E615 File Offset: 0x0007C815
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartLabOvenBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartLabOvenBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x0007E62E File Offset: 0x0007C82E
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x0007E63C File Offset: 0x0007C83C
		private void RpcWriter___Observers_StartCook_2166136261()
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendObserversRpc(15U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x0007E6E5 File Offset: 0x0007C8E5
		private void RpcLogic___StartCook_2166136261()
		{
			if (this.cookRoutine != null)
			{
				return;
			}
			if (this.targetOven == null)
			{
				return;
			}
			this.cookRoutine = base.StartCoroutine(this.<StartCook>g__CookRoutine|11_0());
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x0007E714 File Offset: 0x0007C914
		private void RpcReader___Observers_StartCook_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___StartCook_2166136261();
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x0007E73E File Offset: 0x0007C93E
		protected virtual void dll()
		{
			base.Awake();
			this.chemist = (base.Npc as Chemist);
		}

		// Token: 0x0400183E RID: 6206
		public const float POUR_TIME = 5f;

		// Token: 0x04001840 RID: 6208
		private Chemist chemist;

		// Token: 0x04001841 RID: 6209
		private Coroutine cookRoutine;

		// Token: 0x04001842 RID: 6210
		private bool dll_Excuted;

		// Token: 0x04001843 RID: 6211
		private bool dll_Excuted;
	}
}
