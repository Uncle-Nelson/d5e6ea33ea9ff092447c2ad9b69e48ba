using System;
using System.Collections;
using System.Collections.Generic;
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
	// Token: 0x02000510 RID: 1296
	public class StartChemistryStationBehaviour : Behaviour
	{
		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x0007D563 File Offset: 0x0007B763
		// (set) Token: 0x06001E81 RID: 7809 RVA: 0x0007D56B File Offset: 0x0007B76B
		public ChemistryStation targetStation { get; private set; }

		// Token: 0x06001E82 RID: 7810 RVA: 0x0007D574 File Offset: 0x0007B774
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.Behaviour.StartChemistryStationBehaviour_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x0007D588 File Offset: 0x0007B788
		public void SetTargetStation(ChemistryStation station)
		{
			this.targetStation = station;
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x0007D594 File Offset: 0x0007B794
		protected override void End()
		{
			base.End();
			if (this.beaker != null)
			{
				this.beaker.Destroy();
				this.beaker = null;
			}
			if (this.targetStation != null)
			{
				this.targetStation.StaticBeaker.gameObject.SetActive(true);
			}
			if (this.cookRoutine != null)
			{
				this.StopCook();
			}
			this.Disable();
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x0007D600 File Offset: 0x0007B800
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (this.cookRoutine != null)
			{
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

		// Token: 0x06001E86 RID: 7814 RVA: 0x0007D652 File Offset: 0x0007B852
		public override void BehaviourUpdate()
		{
			base.BehaviourUpdate();
			if (this.cookRoutine != null)
			{
				base.Npc.Avatar.LookController.OverrideLookTarget(this.targetStation.UIPoint.position, 5, false);
			}
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x0007D689 File Offset: 0x0007B889
		[ObserversRpc(RunLocally = true)]
		private void StartCook()
		{
			this.RpcWriter___Observers_StartCook_2166136261();
			this.RpcLogic___StartCook_2166136261();
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x0007D698 File Offset: 0x0007B898
		private void SetupBeaker()
		{
			if (this.beaker != null)
			{
				Console.LogWarning("Beaker already exists!", null);
				return;
			}
			this.beaker = this.targetStation.CreateBeaker();
			this.targetStation.StaticBeaker.gameObject.SetActive(false);
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x0007D6E8 File Offset: 0x0007B8E8
		private void FillBeaker(StationRecipe recipe, Beaker beaker)
		{
			for (int i = 0; i < recipe.Ingredients.Count; i++)
			{
				StorableItemDefinition storableItemDefinition = null;
				foreach (ItemDefinition itemDefinition in recipe.Ingredients[i].Items)
				{
					StorableItemDefinition storableItemDefinition2 = itemDefinition as StorableItemDefinition;
					for (int j = 0; j < this.targetStation.IngredientSlots.Length; j++)
					{
						if (this.targetStation.IngredientSlots[j].ItemInstance != null && this.targetStation.IngredientSlots[j].ItemInstance.Definition.ID == storableItemDefinition2.ID)
						{
							storableItemDefinition = storableItemDefinition2;
							break;
						}
					}
				}
				if (storableItemDefinition.StationItem == null)
				{
					Console.LogError("Ingredient '" + storableItemDefinition.Name + "' does not have a station item", null);
				}
				else
				{
					StationItem stationItem = storableItemDefinition.StationItem;
					if (!stationItem.HasModule<IngredientModule>())
					{
						if (stationItem.HasModule<PourableModule>())
						{
							PourableModule module = stationItem.GetModule<PourableModule>();
							beaker.Fillable.AddLiquid(module.LiquidType, module.LiquidCapacity_L, module.LiquidColor);
						}
						else
						{
							Console.LogError("Ingredient '" + storableItemDefinition.Name + "' does not have an ingredient or pourable module", null);
						}
					}
				}
			}
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x0007D84C File Offset: 0x0007BA4C
		private bool CanCookStart()
		{
			if (this.targetStation == null)
			{
				return false;
			}
			if (((IUsable)this.targetStation).IsInUse && ((IUsable)this.targetStation).NPCUserObject != base.Npc.NetworkObject)
			{
				return false;
			}
			ChemistryStationConfiguration chemistryStationConfiguration = this.targetStation.Configuration as ChemistryStationConfiguration;
			return !(chemistryStationConfiguration.Recipe.SelectedRecipe == null) && this.targetStation.HasIngredientsForRecipe(chemistryStationConfiguration.Recipe.SelectedRecipe);
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x0007D8D6 File Offset: 0x0007BAD6
		private void StopCook()
		{
			this.targetStation.SetNPCUser(null);
			base.Npc.SetAnimationBool_Networked(null, "UseChemistryStation", false);
			if (this.cookRoutine != null)
			{
				base.StopCoroutine(this.cookRoutine);
				this.cookRoutine = null;
			}
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x0007D911 File Offset: 0x0007BB11
		private Vector3 GetStationAccessPoint()
		{
			if (this.targetStation == null)
			{
				return base.Npc.transform.position;
			}
			return ((ITransitEntity)this.targetStation).AccessPoints[0].position;
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x0007D944 File Offset: 0x0007BB44
		private bool IsAtStation()
		{
			return !(this.targetStation == null) && Vector3.Distance(base.Npc.transform.position, this.GetStationAccessPoint()) < 1f;
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x0007D978 File Offset: 0x0007BB78
		[CompilerGenerated]
		private IEnumerator <StartCook>g__CookRoutine|15_0()
		{
			base.Npc.Movement.FacePoint(this.targetStation.transform.position, 0.5f);
			yield return new WaitForSeconds(0.5f);
			base.Npc.SetAnimationBool_Networked(null, "UseChemistryStation", true);
			if (!this.CanCookStart())
			{
				this.StopCook();
				base.End_Networked(null);
				yield break;
			}
			this.targetStation.SetNPCUser(base.Npc.NetworkObject);
			StationRecipe recipe = (this.targetStation.Configuration as ChemistryStationConfiguration).Recipe.SelectedRecipe;
			this.SetupBeaker();
			yield return new WaitForSeconds(1f);
			this.FillBeaker(recipe, this.beaker);
			yield return new WaitForSeconds(8f);
			yield return new WaitForSeconds(6f);
			yield return new WaitForSeconds(6f);
			List<ItemInstance> list = new List<ItemInstance>();
			for (int i = 0; i < recipe.Ingredients.Count; i++)
			{
				foreach (ItemDefinition itemDefinition in recipe.Ingredients[i].Items)
				{
					StorableItemDefinition storableItemDefinition = itemDefinition as StorableItemDefinition;
					for (int j = 0; j < this.targetStation.IngredientSlots.Length; j++)
					{
						if (this.targetStation.IngredientSlots[j].ItemInstance != null && this.targetStation.IngredientSlots[j].ItemInstance.Definition.ID == storableItemDefinition.ID)
						{
							list.Add(this.targetStation.IngredientSlots[j].ItemInstance.GetCopy(recipe.Ingredients[i].Quantity));
							this.targetStation.IngredientSlots[j].ChangeQuantity(-recipe.Ingredients[i].Quantity, false);
							break;
						}
					}
				}
			}
			EQuality productQuality = recipe.CalculateQuality(list);
			this.targetStation.SendCookOperation(new ChemistryCookOperation(recipe, productQuality, this.beaker.Container.LiquidColor, this.beaker.Fillable.LiquidContainer.CurrentLiquidLevel, 0));
			this.beaker.Destroy();
			this.beaker = null;
			this.StopCook();
			base.End_Networked(null);
			yield break;
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x0007D987 File Offset: 0x0007BB87
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartChemistryStationBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartChemistryStationBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_StartCook_2166136261));
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x0007D9B7 File Offset: 0x0007BBB7
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartChemistryStationBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartChemistryStationBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x0007D9D0 File Offset: 0x0007BBD0
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x0007D9E0 File Offset: 0x0007BBE0
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

		// Token: 0x06001E94 RID: 7828 RVA: 0x0007DA89 File Offset: 0x0007BC89
		private void RpcLogic___StartCook_2166136261()
		{
			if (this.cookRoutine != null)
			{
				return;
			}
			if (this.targetStation == null)
			{
				return;
			}
			this.cookRoutine = base.StartCoroutine(this.<StartCook>g__CookRoutine|15_0());
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x0007DAB8 File Offset: 0x0007BCB8
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

		// Token: 0x06001E96 RID: 7830 RVA: 0x0007DAE2 File Offset: 0x0007BCE2
		protected virtual void dll()
		{
			base.Awake();
			this.chemist = (base.Npc as Chemist);
		}

		// Token: 0x04001827 RID: 6183
		public const float PLACE_INGREDIENTS_TIME = 8f;

		// Token: 0x04001828 RID: 6184
		public const float STIR_TIME = 6f;

		// Token: 0x04001829 RID: 6185
		public const float BURNER_TIME = 6f;

		// Token: 0x0400182B RID: 6187
		private Chemist chemist;

		// Token: 0x0400182C RID: 6188
		private Coroutine cookRoutine;

		// Token: 0x0400182D RID: 6189
		private Beaker beaker;

		// Token: 0x0400182E RID: 6190
		private bool dll_Excuted;

		// Token: 0x0400182F RID: 6191
		private bool dll_Excuted;
	}
}
