using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.DevUtilities;
using ScheduleOne.Employees;
using ScheduleOne.Equipping;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;
using ScheduleOne.ObjectScripts.Soil;
using ScheduleOne.Trash;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000506 RID: 1286
	public class PotActionBehaviour : Behaviour
	{
		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x0007B584 File Offset: 0x00079784
		// (set) Token: 0x06001E0C RID: 7692 RVA: 0x0007B58C File Offset: 0x0007978C
		public bool Initialized { get; protected set; }

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x0007B595 File Offset: 0x00079795
		// (set) Token: 0x06001E0E RID: 7694 RVA: 0x0007B59D File Offset: 0x0007979D
		public Pot AssignedPot { get; protected set; }

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001E0F RID: 7695 RVA: 0x0007B5A6 File Offset: 0x000797A6
		// (set) Token: 0x06001E10 RID: 7696 RVA: 0x0007B5AE File Offset: 0x000797AE
		public PotActionBehaviour.EActionType CurrentActionType { get; protected set; }

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x0007B5B7 File Offset: 0x000797B7
		// (set) Token: 0x06001E12 RID: 7698 RVA: 0x0007B5BF File Offset: 0x000797BF
		public PotActionBehaviour.EState CurrentState { get; protected set; }

		// Token: 0x06001E13 RID: 7699 RVA: 0x0007B5C8 File Offset: 0x000797C8
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.Behaviour.PotActionBehaviour_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x0007B5DC File Offset: 0x000797DC
		public virtual void Initialize(Pot pot, PotActionBehaviour.EActionType actionType)
		{
			if (this.botanist.DEBUG)
			{
				Debug.Log("PotActionBehaviour.Initialize: " + ((pot != null) ? pot.ToString() : null) + " - " + actionType.ToString());
			}
			this.AssignedPot = pot;
			this.CurrentActionType = actionType;
			this.Initialized = true;
			this.CurrentState = PotActionBehaviour.EState.Idle;
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x0007B640 File Offset: 0x00079840
		protected override void Begin()
		{
			base.Begin();
			this.StartAction();
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x0007B64E File Offset: 0x0007984E
		protected override void Resume()
		{
			base.Resume();
			this.StartAction();
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x0007B65C File Offset: 0x0007985C
		protected override void Pause()
		{
			base.Pause();
			this.StopAllActions();
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00077BBF File Offset: 0x00075DBF
		public override void Disable()
		{
			base.Disable();
			if (base.Active)
			{
				this.End();
			}
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x0007B66A File Offset: 0x0007986A
		protected override void End()
		{
			base.End();
			this.StopAllActions();
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x0007B678 File Offset: 0x00079878
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (base.Npc.behaviour.DEBUG_MODE)
			{
				Console.Log("Current state: " + this.CurrentState.ToString(), null);
				Console.Log("Is walking: " + base.Npc.Movement.IsMoving.ToString(), null);
			}
			if (this.CurrentState == PotActionBehaviour.EState.Idle)
			{
				if (!this.DoesTaskTypeRequireSupplies(this.CurrentActionType) || base.Npc.Inventory.GetMaxItemCount(this.GetRequiredItemIDs()) > 0)
				{
					if (this.IsAtPot())
					{
						this.PerformAction();
						return;
					}
					this.WalkToPot();
					return;
				}
				else
				{
					if (this.AssignedPot == null)
					{
						string str = "PotActionBehaviour.ActiveMinPass: No pot assigned for botanist ";
						Botanist botanist = this.botanist;
						Console.LogWarning(str + ((botanist != null) ? botanist.ToString() : null), null);
						base.Disable_Networked(null);
						return;
					}
					if (this.IsAtSupplies())
					{
						if (this.DoesBotanistHaveMaterialsForTask(this.botanist, this.AssignedPot, this.CurrentActionType, this.AdditiveNumber))
						{
							this.GrabItem();
							return;
						}
						this.StopPerformAction();
						base.Disable_Networked(null);
						return;
					}
					else
					{
						this.WalkToSupplies();
					}
				}
			}
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x0007B7B4 File Offset: 0x000799B4
		private void StartAction()
		{
			if (!this.AreActionConditionsMet())
			{
				string str = "PotActionBehaviour.StartAction: Conditions not met for action ";
				string str2 = this.CurrentActionType.ToString();
				string str3 = " on pot ";
				Pot assignedPot = this.AssignedPot;
				Console.LogWarning(str + str2 + str3 + ((assignedPot != null) ? assignedPot.ToString() : null), null);
				base.Disable_Networked(null);
				return;
			}
			if (!this.DoesBotanistHaveMaterialsForTask(base.Npc as Botanist, this.AssignedPot, this.CurrentActionType, this.AdditiveNumber))
			{
				string str4 = "PotActionBehaviour.StartAction: Botanist does not have materials for action ";
				string str5 = this.CurrentActionType.ToString();
				string str6 = " on pot ";
				Pot assignedPot2 = this.AssignedPot;
				Console.LogWarning(str4 + str5 + str6 + ((assignedPot2 != null) ? assignedPot2.ToString() : null), null);
				base.Disable_Networked(null);
				return;
			}
			if (this.botanist.DEBUG)
			{
				string str7 = "PotActionBehaviour.StartAction: Starting action ";
				string str8 = this.CurrentActionType.ToString();
				string str9 = " on pot ";
				Pot assignedPot3 = this.AssignedPot;
				Console.Log(str7 + str8 + str9 + ((assignedPot3 != null) ? assignedPot3.ToString() : null), null);
			}
			this.CurrentState = PotActionBehaviour.EState.Idle;
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x0007B8C4 File Offset: 0x00079AC4
		private void StopAllActions()
		{
			if (this.walkToSuppliesRoutine != null)
			{
				base.StopCoroutine(this.walkToSuppliesRoutine);
				this.walkToSuppliesRoutine = null;
			}
			if (this.grabRoutine != null)
			{
				base.StopCoroutine(this.grabRoutine);
				this.grabRoutine = null;
			}
			if (this.walkToPotRoutine != null)
			{
				base.StopCoroutine(this.walkToPotRoutine);
				this.walkToPotRoutine = null;
			}
			if (this.performActionRoutine != null)
			{
				this.StopPerformAction();
			}
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x0007B930 File Offset: 0x00079B30
		public void WalkToSupplies()
		{
			if (!base.Npc.Movement.CanGetTo(this.AssignedPot, 1f))
			{
				string str = "PotActionBehaviour.WalkToPot: Can't get to pot ";
				Pot assignedPot = this.AssignedPot;
				Console.LogWarning(str + ((assignedPot != null) ? assignedPot.ToString() : null), null);
				base.Disable_Networked(null);
				return;
			}
			if (this.botanist.DEBUG)
			{
				string str2 = "PotActionBehaviour.WalkToSupplies: Walking to supplies for action ";
				string str3 = this.CurrentActionType.ToString();
				string str4 = " on pot ";
				Pot assignedPot2 = this.AssignedPot;
				Debug.Log(str2 + str3 + str4 + ((assignedPot2 != null) ? assignedPot2.ToString() : null));
			}
			this.CurrentState = PotActionBehaviour.EState.WalkingToSupplies;
			this.walkToSuppliesRoutine = base.StartCoroutine(this.<WalkToSupplies>g__Routine|38_0());
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x0007B9E4 File Offset: 0x00079BE4
		public void GrabItem()
		{
			if (this.botanist.DEBUG)
			{
				string str = "PotActionBehaviour.GrabItem: Grabbing item for action ";
				string str2 = this.CurrentActionType.ToString();
				string str3 = " on pot ";
				Pot assignedPot = this.AssignedPot;
				Debug.Log(str + str2 + str3 + ((assignedPot != null) ? assignedPot.ToString() : null));
			}
			this.CurrentState = PotActionBehaviour.EState.GrabbingSupplies;
			this.grabRoutine = base.StartCoroutine(this.<GrabItem>g__Routine|39_0());
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x0007BA54 File Offset: 0x00079C54
		public void WalkToPot()
		{
			if (!base.Npc.Movement.CanGetTo(this.GetPotAccessPoint().position, 1f))
			{
				string str = "PotActionBehaviour.WalkToPot: Can't get to pot ";
				Pot assignedPot = this.AssignedPot;
				Console.LogWarning(str + ((assignedPot != null) ? assignedPot.ToString() : null), null);
				base.Disable_Networked(null);
				return;
			}
			if (this.botanist.DEBUG)
			{
				string str2 = "PotActionBehaviour.WalkToPot: Walking to pot ";
				Pot assignedPot2 = this.AssignedPot;
				Debug.Log(str2 + ((assignedPot2 != null) ? assignedPot2.ToString() : null));
			}
			this.CurrentState = PotActionBehaviour.EState.WalkingToPot;
			this.walkToPotRoutine = base.StartCoroutine(this.<WalkToPot>g__Routine|40_0());
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x0007BAF4 File Offset: 0x00079CF4
		public void PerformAction()
		{
			if (this.botanist.DEBUG)
			{
				string str = "PotActionBehaviour.PerformAction: Performing action ";
				string str2 = this.CurrentActionType.ToString();
				string str3 = " on pot ";
				Pot assignedPot = this.AssignedPot;
				Debug.Log(str + str2 + str3 + ((assignedPot != null) ? assignedPot.ToString() : null));
			}
			this.CurrentState = PotActionBehaviour.EState.PerformingAction;
			this.performActionRoutine = base.StartCoroutine(this.<PerformAction>g__Routine|41_0());
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x0007BB64 File Offset: 0x00079D64
		private void CompleteAction()
		{
			if (this.AssignedPot == null)
			{
				string str = "PotActionBehaviour.CompleteAction: No pot assigned for botanist ";
				Botanist botanist = this.botanist;
				Console.LogWarning(str + ((botanist != null) ? botanist.ToString() : null), null);
				return;
			}
			ItemInstance itemInstance = null;
			string[] requiredItemIDs = this.GetRequiredItemIDs();
			for (int i = 0; i < requiredItemIDs.Length; i++)
			{
				itemInstance = base.Npc.Inventory.GetFirstItem(requiredItemIDs[i], null);
				if (itemInstance != null)
				{
					break;
				}
			}
			if (this.DoesTaskTypeRequireSupplies(this.CurrentActionType) && itemInstance == null)
			{
				string str2 = "PotActionBehaviour.CompleteAction: No item held for action ";
				string str3 = this.CurrentActionType.ToString();
				string str4 = " on pot ";
				Pot assignedPot = this.AssignedPot;
				Console.LogWarning(str2 + str3 + str4 + ((assignedPot != null) ? assignedPot.ToString() : null), null);
				return;
			}
			ItemInstance itemInstance2 = null;
			switch (this.CurrentActionType)
			{
			case PotActionBehaviour.EActionType.PourSoil:
			{
				SoilDefinition soilDefinition = itemInstance.Definition as SoilDefinition;
				if (soilDefinition == null)
				{
					string str5 = "PotActionBehaviour.CompleteAction: Required item is not soil for action ";
					string str6 = this.CurrentActionType.ToString();
					string str7 = " on pot ";
					Pot assignedPot2 = this.AssignedPot;
					Console.LogWarning(str5 + str6 + str7 + ((assignedPot2 != null) ? assignedPot2.ToString() : null), null);
					return;
				}
				this.AssignedPot.AddSoil(this.AssignedPot.SoilCapacity);
				this.AssignedPot.SetSoilID(soilDefinition.ID);
				this.AssignedPot.SetSoilUses(soilDefinition.Uses);
				NetworkSingleton<TrashManager>.Instance.CreateTrashItem((soilDefinition.Equippable as Equippable_Soil).PourablePrefab.TrashItem.ID, base.transform.position + Vector3.up * 0.5f, Random.rotation, default(Vector3), "", false);
				break;
			}
			case PotActionBehaviour.EActionType.SowSeed:
				this.AssignedPot.PlantSeed(null, itemInstance.ID, 0f, -1f, -1f);
				NetworkSingleton<TrashManager>.Instance.CreateTrashItem((itemInstance.Definition as SeedDefinition).FunctionSeedPrefab.TrashPrefab.ID, base.transform.position + Vector3.up * 0.5f, Random.rotation, default(Vector3), "", false);
				break;
			case PotActionBehaviour.EActionType.Water:
			{
				float num = Random.Range(this.botanist.TARGET_WATER_LEVEL_MIN, this.botanist.TARGET_WATER_LEVEL_MAX);
				this.AssignedPot.ChangeWaterAmount(num * this.AssignedPot.WaterCapacity - this.AssignedPot.WaterLevel);
				break;
			}
			case PotActionBehaviour.EActionType.ApplyAdditive:
				this.AssignedPot.ApplyAdditive(null, (itemInstance.Definition as AdditiveDefinition).AdditivePrefab.AssetPath, true);
				NetworkSingleton<TrashManager>.Instance.CreateTrashItem(((itemInstance.Definition as AdditiveDefinition).Equippable as Equippable_Additive).PourablePrefab.TrashItem.ID, base.transform.position + Vector3.up * 0.5f, Random.rotation, default(Vector3), "", false);
				break;
			case PotActionBehaviour.EActionType.Harvest:
				if (!this.DoesPotHaveValidDestination(this.AssignedPot))
				{
					string str8 = "PotActionBehaviour.CompleteAction: Pot ";
					Pot assignedPot3 = this.AssignedPot;
					Console.LogWarning(str8 + ((assignedPot3 != null) ? assignedPot3.ToString() : null) + " does not have a valid destination", null);
					return;
				}
				itemInstance2 = this.AssignedPot.Plant.GetHarvestedProduct(this.AssignedPot.Plant.ActiveHarvestables.Count);
				this.AssignedPot.ResetPot();
				break;
			}
			if (itemInstance != null)
			{
				itemInstance.ChangeQuantity(-1);
			}
			if (this.CurrentActionType == PotActionBehaviour.EActionType.Harvest)
			{
				((ITransitEntity)this.AssignedPot).InsertItemIntoOutput(itemInstance2, null);
				TransitRoute route = new TransitRoute(this.AssignedPot, (this.AssignedPot.Configuration as PotConfiguration).Destination.SelectedObject as ITransitEntity);
				this.botanist.MoveItemBehaviour.Initialize(route, itemInstance2, -1, true);
				this.botanist.MoveItemBehaviour.Enable_Networked(null);
			}
			base.Disable_Networked(null);
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x0007BF68 File Offset: 0x0007A168
		private void StopPerformAction()
		{
			if (this.CurrentActionType == PotActionBehaviour.EActionType.SowSeed && base.Npc.Avatar.Anim.IsCrouched)
			{
				base.Npc.SetCrouched_Networked(false);
			}
			this.CurrentState = PotActionBehaviour.EState.Idle;
			if (this.performActionRoutine != null)
			{
				base.StopCoroutine(this.performActionRoutine);
				this.performActionRoutine = null;
			}
			if (this.currentActionEquippable != null)
			{
				base.Npc.SetEquippable_Networked(null, string.Empty);
				this.currentActionEquippable = null;
			}
			if (this.currentActionAnimation != string.Empty)
			{
				base.Npc.SetAnimationBool_Networked(null, this.currentActionAnimation, false);
				this.currentActionAnimation = string.Empty;
			}
			if (this.AssignedPot != null && this.AssignedPot.NPCUserObject == this.botanist.NetworkObject)
			{
				this.AssignedPot.SetNPCUser(null);
			}
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x0007C050 File Offset: 0x0007A250
		private string GetActionAnimation(PotActionBehaviour.EActionType actionType)
		{
			switch (actionType)
			{
			case PotActionBehaviour.EActionType.PourSoil:
				return "PourItem";
			case PotActionBehaviour.EActionType.SowSeed:
				return "PatSoil";
			case PotActionBehaviour.EActionType.Water:
				return "PourItem";
			case PotActionBehaviour.EActionType.ApplyAdditive:
				return "PourItem";
			case PotActionBehaviour.EActionType.Harvest:
				return "Snipping";
			default:
				return string.Empty;
			}
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x0007C0A0 File Offset: 0x0007A2A0
		private AvatarEquippable GetActionEquippable(PotActionBehaviour.EActionType actionType)
		{
			switch (actionType)
			{
			case PotActionBehaviour.EActionType.SowSeed:
				return null;
			case PotActionBehaviour.EActionType.Water:
				return this.WateringCanEquippable;
			case PotActionBehaviour.EActionType.Harvest:
				return this.TrimmersEquippable;
			}
			ItemInstance itemInstance = null;
			string[] requiredItemIDs = this.GetRequiredItemIDs();
			for (int i = 0; i < requiredItemIDs.Length; i++)
			{
				itemInstance = base.Npc.Inventory.GetFirstItem(requiredItemIDs[i], null);
				if (itemInstance != null)
				{
					break;
				}
			}
			if (itemInstance == null)
			{
				return null;
			}
			Equippable_Viewmodel equippable_Viewmodel = itemInstance.Equippable as Equippable_Viewmodel;
			if (equippable_Viewmodel == null)
			{
				return null;
			}
			return equippable_Viewmodel.AvatarEquippable;
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x0007C124 File Offset: 0x0007A324
		public float GetWaitTime(PotActionBehaviour.EActionType actionType)
		{
			switch (actionType)
			{
			case PotActionBehaviour.EActionType.PourSoil:
				return this.botanist.SOIL_POUR_TIME;
			case PotActionBehaviour.EActionType.SowSeed:
				return this.botanist.SEED_SOW_TIME;
			case PotActionBehaviour.EActionType.Water:
				return this.botanist.WATER_POUR_TIME;
			case PotActionBehaviour.EActionType.ApplyAdditive:
				return this.botanist.ADDITIVE_POUR_TIME;
			case PotActionBehaviour.EActionType.Harvest:
				return this.botanist.HARVEST_TIME;
			default:
				Console.LogWarning("Can't find wait time for " + actionType.ToString(), null);
				return 10f;
			}
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x0007C1AD File Offset: 0x0007A3AD
		public bool CanGetToSupplies()
		{
			return base.Npc.Movement.CanGetTo((this.botanist.Configuration as BotanistConfiguration).Supplies.SelectedObject as ITransitEntity, 1f);
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x0007C1E3 File Offset: 0x0007A3E3
		private bool IsAtSupplies()
		{
			return NavMeshUtility.IsAtTransitEntity(this.GetSuppliesAsTransitEntity(), base.Npc, 0.4f);
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x0007C1FC File Offset: 0x0007A3FC
		private ITransitEntity GetSuppliesAsTransitEntity()
		{
			if ((this.botanist.Configuration as BotanistConfiguration).Supplies.SelectedObject == null)
			{
				string str = "PotActionBehaviour.GetSuppliesAsTransitEntity: No supplies selected for botanist ";
				Botanist botanist = this.botanist;
				Console.LogWarning(str + ((botanist != null) ? botanist.ToString() : null), null);
				return null;
			}
			return (this.botanist.Configuration as BotanistConfiguration).Supplies.SelectedObject as ITransitEntity;
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x0007C26E File Offset: 0x0007A46E
		public bool CanGetToPot()
		{
			return this.GetPotAccessPoint() != null;
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x0007C27C File Offset: 0x0007A47C
		private Transform GetPotAccessPoint()
		{
			if (this.AssignedPot == null)
			{
				string str = "PotActionBehaviour.GetpotAccessPoint: No pot selected for botanist ";
				Botanist botanist = this.botanist;
				Console.LogWarning(str + ((botanist != null) ? botanist.ToString() : null), null);
				return null;
			}
			Transform accessPoint = NavMeshUtility.GetAccessPoint(this.AssignedPot, base.Npc);
			if (accessPoint == null)
			{
				string str2 = "PotActionBehaviour.GetpotAccessPoint: No access point found for pot ";
				Pot assignedPot = this.AssignedPot;
				Console.LogWarning(str2 + ((assignedPot != null) ? assignedPot.ToString() : null), null);
				return this.AssignedPot.transform;
			}
			return accessPoint;
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x0007C308 File Offset: 0x0007A508
		private bool IsAtPot()
		{
			if (this.AssignedPot == null)
			{
				string str = "PotActionBehaviour.IsAtpot: No pot selected for botanist ";
				Botanist botanist = this.botanist;
				Console.LogWarning(str + ((botanist != null) ? botanist.ToString() : null), null);
				return false;
			}
			return NavMeshUtility.IsAtTransitEntity(this.AssignedPot, base.Npc, 0.4f);
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x0007C360 File Offset: 0x0007A560
		private string[] GetRequiredItemIDs(PotActionBehaviour.EActionType actionType, Pot pot)
		{
			PotConfiguration potConfiguration = pot.Configuration as PotConfiguration;
			switch (actionType)
			{
			case PotActionBehaviour.EActionType.PourSoil:
				return new string[]
				{
					"soil",
					"longlifesoil",
					"extralonglifesoil"
				};
			case PotActionBehaviour.EActionType.SowSeed:
				if (potConfiguration.Seed.SelectedItem == null)
				{
					return Singleton<Registry>.Instance.Seeds.ConvertAll<string>((SeedDefinition x) => x.ID).ToArray();
				}
				return new string[]
				{
					potConfiguration.Seed.SelectedItem.ID
				};
			case PotActionBehaviour.EActionType.ApplyAdditive:
				if (this.AdditiveNumber == 1)
				{
					return new string[]
					{
						potConfiguration.Additive1.SelectedItem.ID
					};
				}
				if (this.AdditiveNumber == 2)
				{
					return new string[]
					{
						potConfiguration.Additive2.SelectedItem.ID
					};
				}
				if (this.AdditiveNumber == 3)
				{
					return new string[]
					{
						potConfiguration.Additive3.SelectedItem.ID
					};
				}
				break;
			}
			return new string[0];
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x0007C485 File Offset: 0x0007A685
		private string[] GetRequiredItemIDs()
		{
			return this.GetRequiredItemIDs(this.CurrentActionType, this.AssignedPot);
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x0007C49C File Offset: 0x0007A69C
		private bool AreActionConditionsMet()
		{
			switch (this.CurrentActionType)
			{
			case PotActionBehaviour.EActionType.PourSoil:
				return this.CanPotHaveSoilPour(this.AssignedPot);
			case PotActionBehaviour.EActionType.SowSeed:
				return this.CanPotHaveSeedSown(this.AssignedPot);
			case PotActionBehaviour.EActionType.Water:
				return this.CanPotBeWatered(this.AssignedPot, 1f);
			case PotActionBehaviour.EActionType.ApplyAdditive:
			{
				int num;
				return this.CanPotHaveAdditiveApplied(this.AssignedPot, out num);
			}
			case PotActionBehaviour.EActionType.Harvest:
				return this.CanPotBeHarvested(this.AssignedPot);
			default:
				return false;
			}
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x0007C517 File Offset: 0x0007A717
		public bool DoesTaskTypeRequireSupplies(PotActionBehaviour.EActionType actionType)
		{
			return actionType - PotActionBehaviour.EActionType.PourSoil <= 1 || actionType == PotActionBehaviour.EActionType.ApplyAdditive;
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x0007C528 File Offset: 0x0007A728
		public bool DoesBotanistHaveMaterialsForTask(Botanist botanist, Pot pot, PotActionBehaviour.EActionType actionType, int additiveNumber = -1)
		{
			switch (actionType)
			{
			case PotActionBehaviour.EActionType.PourSoil:
				return this.GetSoilInSupplies() != null || base.Npc.Inventory.GetMaxItemCount(this.GetRequiredItemIDs(actionType, pot)) > 0;
			case PotActionBehaviour.EActionType.SowSeed:
				return this.GetSeedInSupplies(pot) != null || base.Npc.Inventory.GetMaxItemCount(this.GetRequiredItemIDs(actionType, pot)) > 0;
			case PotActionBehaviour.EActionType.ApplyAdditive:
				return this.GetAdditiveInSupplies(pot, additiveNumber) != null || base.Npc.Inventory.GetMaxItemCount(this.GetRequiredItemIDs(actionType, pot)) > 0;
			}
			return true;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x0007C5C8 File Offset: 0x0007A7C8
		private ItemInstance GetSoilInSupplies()
		{
			ItemInstance itemInSupplies = this.botanist.GetItemInSupplies("soil");
			if (itemInSupplies != null)
			{
				return itemInSupplies;
			}
			ItemInstance itemInSupplies2 = this.botanist.GetItemInSupplies("longlifesoil");
			if (itemInSupplies2 != null)
			{
				return itemInSupplies2;
			}
			ItemInstance itemInSupplies3 = this.botanist.GetItemInSupplies("extralonglifesoil");
			if (itemInSupplies3 != null)
			{
				return itemInSupplies3;
			}
			return null;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x0007C618 File Offset: 0x0007A818
		private ItemInstance GetSeedInSupplies(Pot pot)
		{
			PotConfiguration potConfiguration = pot.Configuration as PotConfiguration;
			if (potConfiguration.Seed.SelectedItem == null)
			{
				return this.botanist.GetSeedInSupplies();
			}
			return this.botanist.GetItemInSupplies(potConfiguration.Seed.SelectedItem.ID);
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x0007C66C File Offset: 0x0007A86C
		private ItemInstance GetAdditiveInSupplies(Pot pot, int additiveNumber)
		{
			PotConfiguration potConfiguration = pot.Configuration as PotConfiguration;
			ItemDefinition selectedItem;
			if (additiveNumber == 1)
			{
				selectedItem = potConfiguration.Additive1.SelectedItem;
			}
			else if (additiveNumber == 2)
			{
				selectedItem = potConfiguration.Additive2.SelectedItem;
			}
			else
			{
				if (additiveNumber != 3)
				{
					Console.LogWarning("PotActionBehaviour.DoesBotanistHaveMaterialsForTask: Invalid additive number " + additiveNumber.ToString(), null);
					return null;
				}
				selectedItem = potConfiguration.Additive3.SelectedItem;
			}
			if (selectedItem == null)
			{
				return null;
			}
			return this.botanist.GetItemInSupplies(selectedItem.ID);
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x0007C6F2 File Offset: 0x0007A8F2
		public bool CanPotBeWatered(Pot pot, float threshold)
		{
			return !((IUsable)pot).IsInUse && pot.IsFilledWithSoil && !(pot.Plant == null) && pot.WaterLevel <= threshold;
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x0007C724 File Offset: 0x0007A924
		public bool CanPotHaveSoilPour(Pot pot)
		{
			return !((IUsable)pot).IsInUse && !pot.IsFilledWithSoil;
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x0007C73B File Offset: 0x0007A93B
		public bool CanPotHaveSeedSown(Pot pot)
		{
			return !((IUsable)pot).IsInUse && pot.IsFilledWithSoil && !(pot.Plant != null);
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x0007C764 File Offset: 0x0007A964
		public bool CanPotHaveAdditiveApplied(Pot pot, out int additiveNumber)
		{
			additiveNumber = -1;
			if (((IUsable)pot).IsInUse)
			{
				return false;
			}
			if (!pot.IsFilledWithSoil)
			{
				return false;
			}
			if (pot.Plant == null)
			{
				return false;
			}
			PotConfiguration potConfiguration = pot.Configuration as PotConfiguration;
			if (potConfiguration.Additive1.SelectedItem != null && pot.GetAdditive((potConfiguration.Additive1.SelectedItem as AdditiveDefinition).AdditivePrefab.AdditiveName) == null)
			{
				additiveNumber = 1;
				return true;
			}
			if (potConfiguration.Additive2.SelectedItem != null && pot.GetAdditive((potConfiguration.Additive2.SelectedItem as AdditiveDefinition).AdditivePrefab.AdditiveName) == null)
			{
				additiveNumber = 2;
				return true;
			}
			if (potConfiguration.Additive3.SelectedItem != null && pot.GetAdditive((potConfiguration.Additive3.SelectedItem as AdditiveDefinition).AdditivePrefab.AdditiveName) == null)
			{
				additiveNumber = 3;
				return true;
			}
			return false;
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x0007C865 File Offset: 0x0007AA65
		public bool CanPotBeHarvested(Pot pot)
		{
			if (((IUsable)pot).IsInUse)
			{
				return false;
			}
			if (pot.Plant == null)
			{
				return false;
			}
			EntityConfiguration configuration = pot.Configuration;
			return pot.Plant.IsFullyGrown;
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x0007C898 File Offset: 0x0007AA98
		public bool DoesPotHaveValidDestination(Pot pot)
		{
			PotConfiguration potConfiguration = pot.Configuration as PotConfiguration;
			return !(potConfiguration.Destination.SelectedObject == null) && (potConfiguration.Destination.SelectedObject as ITransitEntity).GetInputCapacityForItem(pot.Plant.GetHarvestedProduct(1), this.botanist) >= pot.Plant.ActiveHarvestables.Count;
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x0007C91C File Offset: 0x0007AB1C
		[CompilerGenerated]
		private IEnumerator <WalkToSupplies>g__Routine|38_0()
		{
			base.SetDestination(this.GetSuppliesAsTransitEntity(), true);
			yield return new WaitForEndOfFrame();
			yield return new WaitUntil(() => !base.Npc.Movement.IsMoving);
			this.CurrentState = PotActionBehaviour.EState.Idle;
			this.walkToSuppliesRoutine = null;
			yield break;
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x0007C92B File Offset: 0x0007AB2B
		[CompilerGenerated]
		private IEnumerator <GrabItem>g__Routine|39_0()
		{
			base.Npc.Movement.FacePoint((this.botanist.Configuration as BotanistConfiguration).Supplies.SelectedObject.transform.position, 0.5f);
			base.Npc.Avatar.Anim.ResetTrigger("GrabItem");
			base.Npc.Avatar.Anim.SetTrigger("GrabItem");
			float seconds = 0.5f;
			yield return new WaitForSeconds(seconds);
			if (!this.DoesBotanistHaveMaterialsForTask(this.botanist, this.AssignedPot, this.CurrentActionType, this.AdditiveNumber))
			{
				string str = "Botanist does not have materials for action ";
				string str2 = this.CurrentActionType.ToString();
				string str3 = " on pot ";
				Pot assignedPot = this.AssignedPot;
				Console.LogWarning(str + str2 + str3 + ((assignedPot != null) ? assignedPot.ToString() : null), null);
				this.grabRoutine = null;
				this.CurrentState = PotActionBehaviour.EState.Idle;
				yield break;
			}
			if (!this.AreActionConditionsMet())
			{
				string str4 = "Conditions not met for action ";
				string str5 = this.CurrentActionType.ToString();
				string str6 = " on pot ";
				Pot assignedPot2 = this.AssignedPot;
				Console.LogWarning(str4 + str5 + str6 + ((assignedPot2 != null) ? assignedPot2.ToString() : null), null);
				this.grabRoutine = null;
				this.CurrentState = PotActionBehaviour.EState.Idle;
				yield break;
			}
			ItemSlot itemSlot = null;
			string[] requiredItemIDs = this.GetRequiredItemIDs();
			for (int i = 0; i < requiredItemIDs.Length; i++)
			{
				itemSlot = ((this.botanist.Configuration as BotanistConfiguration).Supplies.SelectedObject as ITransitEntity).GetFirstSlotContainingItem(requiredItemIDs[i], ITransitEntity.ESlotType.Both);
				if (itemSlot != null)
				{
					break;
				}
			}
			ItemInstance itemInstance = (itemSlot != null) ? itemSlot.ItemInstance : null;
			if (itemInstance == null)
			{
				string str7 = "PotActionBehaviour.GrabItem: No item found for action ";
				string str8 = this.CurrentActionType.ToString();
				string str9 = " on pot ";
				Pot assignedPot3 = this.AssignedPot;
				Console.LogWarning(str7 + str8 + str9 + ((assignedPot3 != null) ? assignedPot3.ToString() : null), null);
				this.grabRoutine = null;
				this.CurrentState = PotActionBehaviour.EState.Idle;
				yield break;
			}
			base.Npc.Inventory.InsertItem(itemInstance.GetCopy(1), true);
			itemSlot.ChangeQuantity(-1, false);
			yield return new WaitForSeconds(0.5f);
			this.grabRoutine = null;
			this.CurrentState = PotActionBehaviour.EState.Idle;
			yield break;
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x0007C93A File Offset: 0x0007AB3A
		[CompilerGenerated]
		private IEnumerator <WalkToPot>g__Routine|40_0()
		{
			base.SetDestination(this.GetPotAccessPoint().position, true);
			yield return new WaitForEndOfFrame();
			yield return new WaitUntil(() => !base.Npc.Movement.IsMoving);
			this.CurrentState = PotActionBehaviour.EState.Idle;
			this.walkToPotRoutine = null;
			yield break;
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x0007C949 File Offset: 0x0007AB49
		[CompilerGenerated]
		private IEnumerator <PerformAction>g__Routine|41_0()
		{
			this.AssignedPot.SetNPCUser(this.botanist.NetworkObject);
			base.Npc.Movement.FacePoint(this.AssignedPot.transform.position, 0.5f);
			string actionAnimation = this.GetActionAnimation(this.CurrentActionType);
			if (actionAnimation != string.Empty)
			{
				this.currentActionAnimation = actionAnimation;
				base.Npc.SetAnimationBool_Networked(null, actionAnimation, true);
			}
			if (this.CurrentActionType == PotActionBehaviour.EActionType.SowSeed && !base.Npc.Avatar.Anim.IsCrouched)
			{
				base.Npc.SetCrouched_Networked(true);
			}
			AvatarEquippable actionEquippable = this.GetActionEquippable(this.CurrentActionType);
			if (actionEquippable != null)
			{
				this.currentActionEquippable = base.Npc.SetEquippable_Networked_Return(null, actionEquippable.AssetPath);
			}
			float waitTime = this.GetWaitTime(this.CurrentActionType);
			for (float i = 0f; i < waitTime; i += Time.deltaTime)
			{
				base.Npc.Avatar.LookController.OverrideLookTarget(this.AssignedPot.transform.position, 0, false);
				yield return new WaitForEndOfFrame();
			}
			this.StopPerformAction();
			this.CompleteAction();
			yield break;
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x0007C958 File Offset: 0x0007AB58
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PotActionBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PotActionBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x0007C971 File Offset: 0x0007AB71
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PotActionBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PotActionBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x0007C98A File Offset: 0x0007AB8A
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x0007C998 File Offset: 0x0007AB98
		protected virtual void dll()
		{
			base.Awake();
			this.botanist = (base.Npc as Botanist);
		}

		// Token: 0x040017F2 RID: 6130
		[HideInInspector]
		public int AdditiveNumber = -1;

		// Token: 0x040017F3 RID: 6131
		[Header("Equippables")]
		public AvatarEquippable WateringCanEquippable;

		// Token: 0x040017F4 RID: 6132
		public AvatarEquippable TrimmersEquippable;

		// Token: 0x040017F5 RID: 6133
		private Botanist botanist;

		// Token: 0x040017F6 RID: 6134
		private Coroutine walkToSuppliesRoutine;

		// Token: 0x040017F7 RID: 6135
		private Coroutine grabRoutine;

		// Token: 0x040017F8 RID: 6136
		private Coroutine walkToPotRoutine;

		// Token: 0x040017F9 RID: 6137
		private Coroutine performActionRoutine;

		// Token: 0x040017FA RID: 6138
		private string currentActionAnimation = string.Empty;

		// Token: 0x040017FB RID: 6139
		private AvatarEquippable currentActionEquippable;

		// Token: 0x040017FC RID: 6140
		private bool dll_Excuted;

		// Token: 0x040017FD RID: 6141
		private bool dll_Excuted;

		// Token: 0x02000507 RID: 1287
		public enum EActionType
		{
			// Token: 0x040017FF RID: 6143
			None,
			// Token: 0x04001800 RID: 6144
			PourSoil,
			// Token: 0x04001801 RID: 6145
			SowSeed,
			// Token: 0x04001802 RID: 6146
			Water,
			// Token: 0x04001803 RID: 6147
			ApplyAdditive,
			// Token: 0x04001804 RID: 6148
			Harvest
		}

		// Token: 0x02000508 RID: 1288
		public enum EState
		{
			// Token: 0x04001806 RID: 6150
			Idle,
			// Token: 0x04001807 RID: 6151
			WalkingToSupplies,
			// Token: 0x04001808 RID: 6152
			GrabbingSupplies,
			// Token: 0x04001809 RID: 6153
			WalkingToPot,
			// Token: 0x0400180A RID: 6154
			PerformingAction,
			// Token: 0x0400180B RID: 6155
			WalkingToDestination
		}
	}
}
