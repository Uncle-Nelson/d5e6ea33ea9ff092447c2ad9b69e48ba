using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.GameTime;
using ScheduleOne.Growing;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Levelling;
using ScheduleOne.Lighting;
using ScheduleOne.Management;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;
using ScheduleOne.Tiles;
using ScheduleOne.Tools;
using ScheduleOne.UI.Management;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BA3 RID: 2979
	public class Pot : GridItem, IUsable, IConfigurable, ITransitEntity
	{
		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06005000 RID: 20480 RVA: 0x00151188 File Offset: 0x0014F388
		// (set) Token: 0x06005001 RID: 20481 RVA: 0x00151190 File Offset: 0x0014F390
		public float SoilLevel
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<SoilLevel>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.sync___set_value_<SoilLevel>k__BackingField(value, true);
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06005002 RID: 20482 RVA: 0x0015119A File Offset: 0x0014F39A
		// (set) Token: 0x06005003 RID: 20483 RVA: 0x001511A2 File Offset: 0x0014F3A2
		public string SoilID
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<SoilID>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.sync___set_value_<SoilID>k__BackingField(value, true);
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06005004 RID: 20484 RVA: 0x001511AC File Offset: 0x0014F3AC
		// (set) Token: 0x06005005 RID: 20485 RVA: 0x001511B4 File Offset: 0x0014F3B4
		public int RemainingSoilUses
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<RemainingSoilUses>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.sync___set_value_<RemainingSoilUses>k__BackingField(value, true);
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06005006 RID: 20486 RVA: 0x001511BE File Offset: 0x0014F3BE
		// (set) Token: 0x06005007 RID: 20487 RVA: 0x001511C6 File Offset: 0x0014F3C6
		public float WaterLevel
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<WaterLevel>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.sync___set_value_<WaterLevel>k__BackingField(value, true);
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06005008 RID: 20488 RVA: 0x001511D0 File Offset: 0x0014F3D0
		public float NormalizedWaterLevel
		{
			get
			{
				return this.WaterLevel / this.WaterCapacity;
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06005009 RID: 20489 RVA: 0x001511DF File Offset: 0x0014F3DF
		public bool IsFilledWithSoil
		{
			get
			{
				return this.SoilLevel >= this.SoilCapacity;
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x0600500A RID: 20490 RVA: 0x001511F2 File Offset: 0x0014F3F2
		// (set) Token: 0x0600500B RID: 20491 RVA: 0x001511FA File Offset: 0x0014F3FA
		public Plant Plant { get; protected set; }

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x0600500C RID: 20492 RVA: 0x00151203 File Offset: 0x0014F403
		// (set) Token: 0x0600500D RID: 20493 RVA: 0x0015120B File Offset: 0x0014F40B
		public NetworkObject NPCUserObject
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<NPCUserObject>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.sync___set_value_<NPCUserObject>k__BackingField(value, true);
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x0600500E RID: 20494 RVA: 0x00151215 File Offset: 0x0014F415
		// (set) Token: 0x0600500F RID: 20495 RVA: 0x0015121D File Offset: 0x0014F41D
		public NetworkObject PlayerUserObject
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<PlayerUserObject>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.sync___set_value_<PlayerUserObject>k__BackingField(value, true);
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06005010 RID: 20496 RVA: 0x00151227 File Offset: 0x0014F427
		public EntityConfiguration Configuration
		{
			get
			{
				return this.potConfiguration;
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06005011 RID: 20497 RVA: 0x0015122F File Offset: 0x0014F42F
		// (set) Token: 0x06005012 RID: 20498 RVA: 0x00151237 File Offset: 0x0014F437
		protected PotConfiguration potConfiguration { get; set; }

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06005013 RID: 20499 RVA: 0x00151240 File Offset: 0x0014F440
		public ConfigurationReplicator ConfigReplicator
		{
			get
			{
				return this.configReplicator;
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06005014 RID: 20500 RVA: 0x000141BA File Offset: 0x000123BA
		public EConfigurableType ConfigurableType
		{
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06005015 RID: 20501 RVA: 0x00151248 File Offset: 0x0014F448
		// (set) Token: 0x06005016 RID: 20502 RVA: 0x00151250 File Offset: 0x0014F450
		public WorldspaceUIElement WorldspaceUI { get; set; }

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06005017 RID: 20503 RVA: 0x00151259 File Offset: 0x0014F459
		// (set) Token: 0x06005018 RID: 20504 RVA: 0x00151261 File Offset: 0x0014F461
		public NetworkObject CurrentPlayerConfigurer
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<CurrentPlayerConfigurer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.sync___set_value_<CurrentPlayerConfigurer>k__BackingField(value, true);
			}
		}

		// Token: 0x06005019 RID: 20505 RVA: 0x0015126B File Offset: 0x0014F46B
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
			this.RpcWriter___Server_SetConfigurer_3323014238(player);
			this.RpcLogic___SetConfigurer_3323014238(player);
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x0600501A RID: 20506 RVA: 0x00151281 File Offset: 0x0014F481
		public Sprite TypeIcon
		{
			get
			{
				return this.typeIcon;
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x0600501B RID: 20507 RVA: 0x000AEDCB File Offset: 0x000ACFCB
		public Transform Transform
		{
			get
			{
				return base.transform;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x0600501C RID: 20508 RVA: 0x00151289 File Offset: 0x0014F489
		public Transform UIPoint
		{
			get
			{
				return this.uiPoint;
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x0600501D RID: 20509 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool CanBeSelected
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x0600501E RID: 20510 RVA: 0x00150487 File Offset: 0x0014E687
		public string Name
		{
			get
			{
				return base.ItemInstance.Name;
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x0600501F RID: 20511 RVA: 0x00151291 File Offset: 0x0014F491
		// (set) Token: 0x06005020 RID: 20512 RVA: 0x00151299 File Offset: 0x0014F499
		public List<ItemSlot> InputSlots { get; set; }

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06005021 RID: 20513 RVA: 0x001512A2 File Offset: 0x0014F4A2
		// (set) Token: 0x06005022 RID: 20514 RVA: 0x001512AA File Offset: 0x0014F4AA
		public List<ItemSlot> OutputSlots { get; set; }

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06005023 RID: 20515 RVA: 0x001512B3 File Offset: 0x0014F4B3
		public Transform LinkOrigin
		{
			get
			{
				return this.UIPoint;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06005024 RID: 20516 RVA: 0x001512BB File Offset: 0x0014F4BB
		public Transform[] AccessPoints
		{
			get
			{
				return this.accessPoints;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06005025 RID: 20517 RVA: 0x001512C3 File Offset: 0x0014F4C3
		public bool Selectable { get; }

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06005026 RID: 20518 RVA: 0x001512CB File Offset: 0x0014F4CB
		// (set) Token: 0x06005027 RID: 20519 RVA: 0x001512D3 File Offset: 0x0014F4D3
		public bool IsAcceptingItems { get; set; }

		// Token: 0x06005028 RID: 20520 RVA: 0x001512DC File Offset: 0x0014F4DC
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.ObjectScripts.Pot_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x001512F0 File Offset: 0x0014F4F0
		protected override void Start()
		{
			base.Start();
			this.WaterLoggedVisuals.gameObject.SetActive(false);
			this.SetSoilState(Pot.ESoilState.Flat);
			this.UpdateSoilScale();
			this.UpdateSoilMaterial();
			this.WaterLevelSlider.value = this.WaterLevel / this.WaterCapacity;
			this.NoWaterIcon.gameObject.SetActive(this.WaterLevel <= 0f);
			this.WaterLevelCanvas.gameObject.SetActive(false);
			this.TaskBounds.gameObject.SetActive(false);
			SoilChunk[] soilChunks = this.SoilChunks;
			for (int i = 0; i < soilChunks.Length; i++)
			{
				soilChunks[i].ClickableEnabled = false;
			}
		}

		// Token: 0x0600502A RID: 20522 RVA: 0x001513A0 File Offset: 0x0014F5A0
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			foreach (Additive additive in this.AppliedAdditives)
			{
				this.ApplyAdditive(connection, additive.AssetPath, false);
			}
			if (this.Plant != null)
			{
				this.PlantSeed(connection, this.Plant.SeedDefinition.ID, this.Plant.NormalizedGrowthProgress, this.Plant.YieldLevel, this.Plant.QualityLevel);
				for (int i = 0; i < this.Plant.ActiveHarvestables.Count; i++)
				{
					this.SetHarvestableActive(connection, this.Plant.ActiveHarvestables[i], true);
				}
			}
			this.SendConfigurationToClient(connection);
		}

		// Token: 0x0600502B RID: 20523 RVA: 0x00151484 File Offset: 0x0014F684
		public void SendConfigurationToClient(NetworkConnection conn)
		{
			Pot.<>c__DisplayClass143_0 CS$<>8__locals1 = new Pot.<>c__DisplayClass143_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.conn = conn;
			if (CS$<>8__locals1.conn.IsHost)
			{
				return;
			}
			Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SendConfigurationToClient>g__WaitForConfig|0());
		}

		// Token: 0x0600502C RID: 20524 RVA: 0x001514C4 File Offset: 0x0014F6C4
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
			bool initialized = base.Initialized;
			base.InitializeGridItem(instance, grid, originCoordinate, rotation, GUID);
			if (initialized)
			{
				return;
			}
			if (!this.isGhost)
			{
				TimeManager instance2 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
				instance2.onMinutePass = (Action)Delegate.Combine(instance2.onMinutePass, new Action(this.OnMinPass));
				TimeManager instance3 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
				instance3.onTimeSkip = (Action<int>)Delegate.Combine(instance3.onTimeSkip, new Action<int>(this.TimeSkipped));
				base.ParentProperty.AddConfigurable(this);
				this.potConfiguration = new PotConfiguration(this.configReplicator, this, this);
				this.CreateWorldspaceUI();
				this.outputSlot = new ItemSlot();
				this.OutputSlots.Add(this.outputSlot);
			}
		}

		// Token: 0x0600502D RID: 20525 RVA: 0x00151580 File Offset: 0x0014F780
		public override void DestroyItem(bool callOnServer = true)
		{
			TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.OnMinPass));
			TimeManager instance2 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance2.onTimeSkip = (Action<int>)Delegate.Remove(instance2.onTimeSkip, new Action<int>(this.TimeSkipped));
			if (this.Plant != null)
			{
				this.Plant.Destroy(false);
			}
			if (this.Configuration != null)
			{
				this.Configuration.Destroy();
				this.DestroyWorldspaceUI();
				base.ParentProperty.RemoveConfigurable(this);
			}
			base.DestroyItem(callOnServer);
		}

		// Token: 0x0600502E RID: 20526 RVA: 0x00151620 File Offset: 0x0014F820
		protected virtual void LateUpdate()
		{
			if (!this.intObjSetThisFrame)
			{
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				if (this.Plant != null && (!Singleton<ManagementClipboard>.InstanceExists || !Singleton<ManagementClipboard>.Instance.IsEquipped))
				{
					if (this.Plant.IsFullyGrown)
					{
						this.IntObj.SetMessage("Use trimmers to harvest");
					}
					else
					{
						this.IntObj.SetMessage(Mathf.FloorToInt(this.Plant.NormalizedGrowthProgress * 100f).ToString() + "% grown");
					}
					this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Label);
				}
			}
			this.intObjSetThisFrame = false;
			if (this.rotationOverridden)
			{
				this.ModelTransform.localRotation = Quaternion.Lerp(this.ModelTransform.localRotation, Quaternion.Euler(0f, this.rotation, 0f), Time.deltaTime * 10f);
			}
			else if (Mathf.Abs(this.ModelTransform.localEulerAngles.y) > 0.1f)
			{
				this.ModelTransform.localRotation = Quaternion.Lerp(this.ModelTransform.localRotation, Quaternion.Euler(0f, 0f, 0f), Time.deltaTime * 10f);
			}
			this.UpdateCanvas();
			this.rotationOverridden = false;
		}

		// Token: 0x0600502F RID: 20527 RVA: 0x00151774 File Offset: 0x0014F974
		protected void UpdateCanvas()
		{
			if (Player.Local == null)
			{
				return;
			}
			if (Player.Local.CurrentProperty != base.ParentProperty)
			{
				this.WaterLevelCanvas.gameObject.SetActive(false);
				return;
			}
			if (!this.IsFilledWithSoil)
			{
				this.WaterLevelCanvas.gameObject.SetActive(false);
				return;
			}
			float num = Vector3.Distance(this.WaterLevelCanvas.transform.position, PlayerSingleton<PlayerCamera>.Instance.transform.position);
			if (num > 2.75f)
			{
				this.WaterLevelCanvas.gameObject.SetActive(false);
				return;
			}
			Vector3 normalized = Vector3.ProjectOnPlane(PlayerSingleton<PlayerCamera>.Instance.transform.position - this.WaterCanvasContainer.position, Vector3.up).normalized;
			this.WaterCanvasContainer.forward = normalized;
			this.WaterLevelCanvas.transform.rotation = Quaternion.LookRotation((PlayerSingleton<PlayerCamera>.Instance.transform.position - this.WaterLevelCanvas.transform.position).normalized, PlayerSingleton<PlayerCamera>.Instance.transform.up);
			float num2 = 0.5f;
			float a = 1f - Mathf.Clamp01(Mathf.InverseLerp(2.75f - num2, 2.75f, num));
			float b = Mathf.Clamp01(Mathf.InverseLerp(0.5f, 0.75f, num));
			this.WaterLevelCanvasGroup.alpha = Mathf.Min(a, b);
			this.WaterLevelCanvas.gameObject.SetActive(true);
		}

		// Token: 0x06005030 RID: 20528 RVA: 0x00151900 File Offset: 0x0014FB00
		private void OnMinPass()
		{
			float num = this.WaterDrainPerHour * this.WaterCapacity / 60f * this.MoistureDrainMultiplier;
			this.WaterLevel = Mathf.Clamp(this.WaterLevel - num, 0f, this.WaterCapacity);
			this.UpdateSoilMaterial();
			if (this.Plant != null)
			{
				this.Plant.MinPass();
			}
		}

		// Token: 0x06005031 RID: 20529 RVA: 0x00151968 File Offset: 0x0014FB68
		private void TimeSkipped(int minsSkippped)
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			for (int i = 0; i < minsSkippped; i++)
			{
				this.OnMinPass();
			}
			if (this.Plant != null)
			{
				this.SetGrowProgress(this.Plant.NormalizedGrowthProgress);
			}
		}

		// Token: 0x06005032 RID: 20530 RVA: 0x001519AE File Offset: 0x0014FBAE
		public void ConfigureInteraction(string message, InteractableObject.EInteractableState state, bool useHighLabelPos = false)
		{
			this.intObjSetThisFrame = true;
			this.IntObj.SetMessage(message);
			this.IntObj.SetInteractableState(state);
			this.IntObj.displayLocationPoint = (useHighLabelPos ? this.IntObjLabel_High : this.IntObjLabel_Low);
		}

		// Token: 0x06005033 RID: 20531 RVA: 0x001519EC File Offset: 0x0014FBEC
		public void PositionCameraContainer()
		{
			if (!this.AutoRotateCameraContainer)
			{
				return;
			}
			Vector3 vector = this.CameraContainer.parent.TransformPoint(new Vector3(0f, 0.75f, 0f));
			Vector3 a = PlayerSingleton<PlayerCamera>.Instance.transform.position - vector;
			a.y = 0f;
			a = a.normalized;
			this.CameraContainer.localPosition = new Vector3(0f, 0.75f, 0f);
			this.CameraContainer.position += a * 0.7f;
			Vector3 normalized = (vector - PlayerSingleton<PlayerCamera>.Instance.transform.position).normalized;
			normalized.y = 0f;
			this.CameraContainer.rotation = Quaternion.LookRotation(normalized, Vector3.up);
		}

		// Token: 0x06005034 RID: 20532 RVA: 0x00151AD4 File Offset: 0x0014FCD4
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
			this.RpcWriter___Server_SetPlayerUser_3323014238(playerObject);
			this.RpcLogic___SetPlayerUser_3323014238(playerObject);
		}

		// Token: 0x06005035 RID: 20533 RVA: 0x00151AF5 File Offset: 0x0014FCF5
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
			this.RpcWriter___Server_SetNPCUser_3323014238(npcObject);
			this.RpcLogic___SetNPCUser_3323014238(npcObject);
		}

		// Token: 0x06005036 RID: 20534 RVA: 0x00151B0C File Offset: 0x0014FD0C
		[ObserversRpc(RunLocally = true)]
		public virtual void ResetPot()
		{
			this.RpcWriter___Observers_ResetPot_2166136261();
			this.RpcLogic___ResetPot_2166136261();
		}

		// Token: 0x06005037 RID: 20535 RVA: 0x00151B28 File Offset: 0x0014FD28
		public float GetAverageLightExposure(out float growSpeedMultiplier)
		{
			growSpeedMultiplier = 1f;
			float num = 0f;
			if (this.LightSourceOverride != null)
			{
				return this.LightSourceOverride.GrowSpeedMultiplier;
			}
			for (int i = 0; i < this.CoordinatePairs.Count; i++)
			{
				float num2;
				num += base.OwnerGrid.GetTile(this.CoordinatePairs[i].coord2).LightExposureNode.GetTotalExposure(out num2);
				growSpeedMultiplier += num2;
			}
			growSpeedMultiplier /= (float)this.CoordinatePairs.Count;
			return num / (float)this.CoordinatePairs.Count;
		}

		// Token: 0x06005038 RID: 20536 RVA: 0x00151BC4 File Offset: 0x0014FDC4
		public bool CanAcceptSeed(out string reason)
		{
			if (this.SoilLevel < this.SoilCapacity)
			{
				reason = "No soil";
				return false;
			}
			if (this.NormalizedWaterLevel >= 1f)
			{
				reason = "Waterlogged";
				return false;
			}
			if (this.Plant != null)
			{
				reason = "Already contains seed";
				return false;
			}
			reason = string.Empty;
			return this.SoilLevel >= this.SoilCapacity;
		}

		// Token: 0x06005039 RID: 20537 RVA: 0x00151C30 File Offset: 0x0014FE30
		public bool IsReadyForHarvest(out string reason)
		{
			if (this.Plant == null)
			{
				reason = "No plant in this pot";
				return false;
			}
			if (!this.Plant.IsFullyGrown)
			{
				reason = Mathf.Floor(this.Plant.NormalizedGrowthProgress * 100f).ToString() + "% grown";
				return false;
			}
			reason = string.Empty;
			return true;
		}

		// Token: 0x0600503A RID: 20538 RVA: 0x00151C95 File Offset: 0x0014FE95
		public override bool CanBeDestroyed(out string reason)
		{
			if (this.Plant != null)
			{
				reason = "Contains plant";
				return false;
			}
			if (((IUsable)this).IsInUse)
			{
				reason = "In use by other player";
				return false;
			}
			return base.CanBeDestroyed(out reason);
		}

		// Token: 0x0600503B RID: 20539 RVA: 0x00151CC6 File Offset: 0x0014FEC6
		public void OverrideRotation(float angle)
		{
			this.rotationOverridden = true;
			this.rotation = angle;
		}

		// Token: 0x0600503C RID: 20540 RVA: 0x00151CD6 File Offset: 0x0014FED6
		public Transform GetCameraPosition(Pot.ECameraPosition pos)
		{
			switch (pos)
			{
			case Pot.ECameraPosition.Closeup:
				return this.CloseupPosition;
			case Pot.ECameraPosition.Midshot:
				return this.MidshotPosition;
			case Pot.ECameraPosition.Fullshot:
				return this.FullshotPosition;
			case Pot.ECameraPosition.BirdsEye:
				return this.BirdsEyePosition;
			default:
				return null;
			}
		}

		// Token: 0x0600503D RID: 20541 RVA: 0x00151D0D File Offset: 0x0014FF0D
		public virtual void AddSoil(float amount)
		{
			this.SoilLevel = Mathf.Clamp(this.SoilLevel + amount, 0f, this.SoilCapacity);
			this.UpdateSoilScale();
		}

		// Token: 0x0600503E RID: 20542 RVA: 0x00151D33 File Offset: 0x0014FF33
		private void SoilLevelChanged(float _prev, float _new, bool asServer)
		{
			this.UpdateSoilScale();
		}

		// Token: 0x0600503F RID: 20543 RVA: 0x00151D3C File Offset: 0x0014FF3C
		protected virtual void UpdateSoilScale()
		{
			Vector3 localScale = Vector3.Lerp(this.DirtMinScale, this.DirtMaxScale, this.SoilLevel / this.SoilCapacity);
			this.Dirt_Flat.localScale = localScale;
		}

		// Token: 0x06005040 RID: 20544 RVA: 0x00151D74 File Offset: 0x0014FF74
		public virtual void SetSoilID(string id)
		{
			this.SoilID = id;
			this.appliedSoilDefinition = (Registry.GetItem(this.SoilID) as SoilDefinition);
			this.UpdateSoilMaterial();
		}

		// Token: 0x06005041 RID: 20545 RVA: 0x00151D99 File Offset: 0x0014FF99
		public virtual void SetSoilUses(int uses)
		{
			this.RemainingSoilUses = uses;
		}

		// Token: 0x06005042 RID: 20546 RVA: 0x00151DA2 File Offset: 0x0014FFA2
		public void PushSoilDataToServer()
		{
			this.SendSoilData(this.SoilID, this.SoilLevel, this.RemainingSoilUses);
		}

		// Token: 0x06005043 RID: 20547 RVA: 0x00151DBC File Offset: 0x0014FFBC
		[ServerRpc(RequireOwnership = false)]
		public void SendSoilData(string soilID, float soilLevel, int soilUses)
		{
			this.RpcWriter___Server_SendSoilData_3104499779(soilID, soilLevel, soilUses);
		}

		// Token: 0x06005044 RID: 20548 RVA: 0x00151DDC File Offset: 0x0014FFDC
		public void SetSoilState(Pot.ESoilState state)
		{
			if (state == Pot.ESoilState.Flat && this.Plant == null)
			{
				this.Dirt_Parted.gameObject.SetActive(false);
				this.Dirt_Flat.gameObject.SetActive(true);
				return;
			}
			if (state == Pot.ESoilState.Parted || state == Pot.ESoilState.Packed)
			{
				this.Dirt_Parted.gameObject.SetActive(true);
				this.Dirt_Flat.gameObject.SetActive(false);
				if (state == Pot.ESoilState.Packed)
				{
					for (int i = 0; i < this.SoilChunks.Length; i++)
					{
						this.SoilChunks[i].SetLerpedTransform(1f);
					}
					return;
				}
				for (int j = 0; j < this.SoilChunks.Length; j++)
				{
					this.SoilChunks[j].SetLerpedTransform(0f);
				}
			}
		}

		// Token: 0x06005045 RID: 20549 RVA: 0x00151E98 File Offset: 0x00150098
		protected virtual void UpdateSoilMaterial()
		{
			if (this.SoilID == string.Empty)
			{
				return;
			}
			if (this.appliedSoilDefinition == null)
			{
				this.appliedSoilDefinition = (Registry.GetItem(this.SoilID) as SoilDefinition);
			}
			Material material = this.appliedSoilDefinition.WetSoilMat;
			if (this.NormalizedWaterLevel <= 0f)
			{
				material = this.appliedSoilDefinition.DrySoilMat;
			}
			for (int i = 0; i < this.DirtRenderers.Count; i++)
			{
				if (!(this.DirtRenderers[i] == null))
				{
					this.DirtRenderers[i].material = material;
				}
			}
			this.WaterLoggedVisuals.SetActive(this.NormalizedWaterLevel > 1f);
		}

		// Token: 0x06005046 RID: 20550 RVA: 0x00151F58 File Offset: 0x00150158
		public void ChangeWaterAmount(float change)
		{
			this.WaterLevel = Mathf.Clamp(this.WaterLevel + change, 0f, this.WaterCapacity);
			this.UpdateSoilMaterial();
			this.WaterLevelSlider.value = this.WaterLevel / this.WaterCapacity;
			this.NoWaterIcon.gameObject.SetActive(this.WaterLevel <= 0f);
		}

		// Token: 0x06005047 RID: 20551 RVA: 0x00151FC1 File Offset: 0x001501C1
		public void PushWaterDataToServer()
		{
			this.SendWaterData(this.WaterLevel);
		}

		// Token: 0x06005048 RID: 20552 RVA: 0x00151FCF File Offset: 0x001501CF
		[ServerRpc(RequireOwnership = false)]
		public void SendWaterData(float waterLevel)
		{
			this.RpcWriter___Server_SendWaterData_431000436(waterLevel);
		}

		// Token: 0x06005049 RID: 20553 RVA: 0x00151FDB File Offset: 0x001501DB
		private void WaterLevelChanged(float _prev, float _new, bool asServer)
		{
			this.UpdateSoilMaterial();
			this.WaterLevelSlider.value = this.WaterLevel / this.WaterCapacity;
			this.NoWaterIcon.gameObject.SetActive(this.WaterLevel <= 0f);
		}

		// Token: 0x0600504A RID: 20554 RVA: 0x0015201B File Offset: 0x0015021B
		public void SetTargetActive(bool active)
		{
			this.Target.gameObject.SetActive(active);
		}

		// Token: 0x0600504B RID: 20555 RVA: 0x00152030 File Offset: 0x00150230
		public void RandomizeTarget()
		{
			int num = 0;
			Vector3 vector;
			do
			{
				Vector3 insideUnitSphere = Random.insideUnitSphere;
				insideUnitSphere.y = 0f;
				vector = base.transform.position + insideUnitSphere * (this.PotRadius * 0.85f);
				vector.y = this.Target.position.y;
				num++;
			}
			while (Vector3.Distance(this.Target.position, vector) < 0.15f && num < 100);
			this.Target.position = vector;
		}

		// Token: 0x0600504C RID: 20556 RVA: 0x001520B8 File Offset: 0x001502B8
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendAdditive(string additiveAssetPath, bool initial)
		{
			this.RpcWriter___Server_SendAdditive_310431262(additiveAssetPath, initial);
			this.RpcLogic___SendAdditive_310431262(additiveAssetPath, initial);
		}

		// Token: 0x0600504D RID: 20557 RVA: 0x001520D8 File Offset: 0x001502D8
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void ApplyAdditive(NetworkConnection conn, string additiveAssetPath, bool initial)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_ApplyAdditive_619441887(conn, additiveAssetPath, initial);
				this.RpcLogic___ApplyAdditive_619441887(conn, additiveAssetPath, initial);
			}
			else
			{
				this.RpcWriter___Target_ApplyAdditive_619441887(conn, additiveAssetPath, initial);
			}
		}

		// Token: 0x0600504E RID: 20558 RVA: 0x00152128 File Offset: 0x00150328
		public float GetAdditiveGrowthMultiplier()
		{
			float num = 1f;
			foreach (Additive additive in this.AppliedAdditives)
			{
				num *= additive.GrowSpeedMultiplier;
			}
			return num;
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x00152184 File Offset: 0x00150384
		public float GetNetYieldChange()
		{
			float num = 0f;
			foreach (Additive additive in this.AppliedAdditives)
			{
				num += additive.YieldChange;
			}
			return num;
		}

		// Token: 0x06005050 RID: 20560 RVA: 0x001521E0 File Offset: 0x001503E0
		public float GetNetQualityChange()
		{
			float num = 0f;
			foreach (Additive additive in this.AppliedAdditives)
			{
				num += additive.QualityChange;
			}
			return num;
		}

		// Token: 0x06005051 RID: 20561 RVA: 0x0015223C File Offset: 0x0015043C
		public Additive GetAdditive(string additiveName)
		{
			return this.AppliedAdditives.Find((Additive x) => x.AdditiveName.ToLower() == additiveName.ToLower());
		}

		// Token: 0x06005052 RID: 20562 RVA: 0x0015226D File Offset: 0x0015046D
		[ObserversRpc(RunLocally = true)]
		public void FullyGrowPlant()
		{
			this.RpcWriter___Observers_FullyGrowPlant_2166136261();
			this.RpcLogic___FullyGrowPlant_2166136261();
		}

		// Token: 0x06005053 RID: 20563 RVA: 0x0015227B File Offset: 0x0015047B
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPlantSeed(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			this.RpcWriter___Server_SendPlantSeed_2530605204(seedID, normalizedSeedProgress, yieldLevel, qualityLevel);
			this.RpcLogic___SendPlantSeed_2530605204(seedID, normalizedSeedProgress, yieldLevel, qualityLevel);
		}

		// Token: 0x06005054 RID: 20564 RVA: 0x001522AC File Offset: 0x001504AC
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void PlantSeed(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_PlantSeed_709433087(conn, seedID, normalizedSeedProgress, yieldLevel, qualityLevel);
				this.RpcLogic___PlantSeed_709433087(conn, seedID, normalizedSeedProgress, yieldLevel, qualityLevel);
			}
			else
			{
				this.RpcWriter___Target_PlantSeed_709433087(conn, seedID, normalizedSeedProgress, yieldLevel, qualityLevel);
			}
		}

		// Token: 0x06005055 RID: 20565 RVA: 0x00152311 File Offset: 0x00150511
		[ObserversRpc]
		private void SetGrowProgress(float progress)
		{
			this.RpcWriter___Observers_SetGrowProgress_431000436(progress);
		}

		// Token: 0x06005056 RID: 20566 RVA: 0x00152320 File Offset: 0x00150520
		private void PlantSeed(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			if (this.Plant != null)
			{
				return;
			}
			if (this.SoilLevel < this.SoilCapacity)
			{
				Console.LogWarning("Pot not full of soil!", null);
				return;
			}
			SeedDefinition seedDefinition = Registry.GetItem(seedID) as SeedDefinition;
			if (seedDefinition == null)
			{
				string str = "PlantSeed: seed not found with ID '";
				SeedDefinition seedDefinition2 = seedDefinition;
				Console.LogWarning(str + ((seedDefinition2 != null) ? seedDefinition2.ToString() : null) + "'", null);
				return;
			}
			this.SetSoilState(Pot.ESoilState.Packed);
			this.Plant = Object.Instantiate<GameObject>(seedDefinition.PlantPrefab.gameObject, this.PlantContainer).GetComponent<Plant>();
			this.Plant.transform.localEulerAngles = new Vector3(0f, Random.Range(0f, 360f), 0f);
			this.Plant.Initialize(base.NetworkObject, normalizedSeedProgress, yieldLevel, qualityLevel);
		}

		// Token: 0x06005057 RID: 20567 RVA: 0x001523FC File Offset: 0x001505FC
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetHarvestableActive(NetworkConnection conn, int harvestableIndex, bool active)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetHarvestableActive_338960014(conn, harvestableIndex, active);
				this.RpcLogic___SetHarvestableActive_338960014(conn, harvestableIndex, active);
			}
			else
			{
				this.RpcWriter___Target_SetHarvestableActive_338960014(conn, harvestableIndex, active);
			}
		}

		// Token: 0x06005058 RID: 20568 RVA: 0x0015244C File Offset: 0x0015064C
		public void SetHarvestableActive_Local(int harvestableIndex, bool active)
		{
			if (this.Plant == null)
			{
				Console.LogWarning("SetHarvestableActive called but plant is null!", null);
				return;
			}
			if (this.Plant.IsHarvestableActive(harvestableIndex) == active)
			{
				return;
			}
			int count = this.Plant.ActiveHarvestables.Count;
			this.Plant.SetHarvestableActive(harvestableIndex, active);
			if (count > 0 && this.Plant.ActiveHarvestables.Count == 0)
			{
				if (InstanceFinder.IsServer)
				{
					float value = NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("HarvestedPlantCount");
					NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("HarvestedPlantCount", (value + 1f).ToString(), true);
					NetworkSingleton<LevelManager>.Instance.AddXP(5);
				}
				this.ResetPot();
			}
		}

		// Token: 0x06005059 RID: 20569 RVA: 0x001524FC File Offset: 0x001506FC
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendHarvestableActive(int harvestableIndex, bool active)
		{
			this.RpcWriter___Server_SendHarvestableActive_3658436649(harvestableIndex, active);
			this.RpcLogic___SendHarvestableActive_3658436649(harvestableIndex, active);
		}

		// Token: 0x0600505A RID: 20570 RVA: 0x0015251A File Offset: 0x0015071A
		public void SendHarvestableActive_Local(int harvestableIndex, bool active)
		{
			this.SetHarvestableActive_Local(harvestableIndex, active);
		}

		// Token: 0x0600505B RID: 20571 RVA: 0x00152524 File Offset: 0x00150724
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			if (this.WorldspaceUI != null)
			{
				Console.LogWarning(base.gameObject.name + " already has a worldspace UI element!", null);
			}
			if (base.ParentProperty == null)
			{
				Property parentProperty = base.ParentProperty;
				Console.LogError(((parentProperty != null) ? parentProperty.ToString() : null) + " is not a child of a property!", null);
				return null;
			}
			PotUIElement component = Object.Instantiate<PotUIElement>(this.WorldspaceUIPrefab, base.ParentProperty.WorldspaceUIContainer).GetComponent<PotUIElement>();
			component.Initialize(this);
			this.WorldspaceUI = component;
			return component;
		}

		// Token: 0x0600505C RID: 20572 RVA: 0x001525B7 File Offset: 0x001507B7
		public void DestroyWorldspaceUI()
		{
			if (this.WorldspaceUI != null)
			{
				this.WorldspaceUI.Destroy();
			}
		}

		// Token: 0x0600505D RID: 20573 RVA: 0x001525D4 File Offset: 0x001507D4
		public override string GetSaveString()
		{
			PlantData plantData = null;
			if (this.Plant != null)
			{
				plantData = this.Plant.GetPlantData();
			}
			return new PotData(base.GUID, base.ItemInstance, 0, base.OwnerGrid, this.OriginCoordinate, this.Rotation, this.SoilID, this.SoilLevel, this.RemainingSoilUses, this.WaterLevel, this.AppliedAdditives.ConvertAll<string>((Additive x) => x.AssetPath).ToArray(), plantData).GetJson(true);
		}

		// Token: 0x0600505E RID: 20574 RVA: 0x00152670 File Offset: 0x00150870
		public override List<string> WriteData(string parentFolderPath)
		{
			List<string> list = new List<string>();
			if (this.Configuration.ShouldSave())
			{
				list.Add("Configuration.json");
				((ISaveable)this).WriteSubfile(parentFolderPath, "Configuration", this.Configuration.GetSaveString());
			}
			list.AddRange(base.WriteData(parentFolderPath));
			return list;
		}

		// Token: 0x0600505F RID: 20575 RVA: 0x001526C4 File Offset: 0x001508C4
		public virtual void LoadPlant(PlantData data)
		{
			Pot.<>c__DisplayClass196_0 CS$<>8__locals1 = new Pot.<>c__DisplayClass196_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.data = data;
			if (string.IsNullOrEmpty(CS$<>8__locals1.data.SeedID))
			{
				return;
			}
			base.StartCoroutine(CS$<>8__locals1.<LoadPlant>g__Wait|0());
		}

		// Token: 0x06005060 RID: 20576 RVA: 0x00152708 File Offset: 0x00150908
		public Pot()
		{
			this.<SoilID>k__BackingField = string.Empty;
			this.AppliedAdditives = new List<Additive>();
			this.InputSlots = new List<ItemSlot>();
			this.OutputSlots = new List<ItemSlot>();
			this.IsAcceptingItems = true;
			base..ctor();
		}

		// Token: 0x06005061 RID: 20577 RVA: 0x001527C0 File Offset: 0x001509C0
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.PotAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.PotAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField = new SyncVar<NetworkObject>(this, 6U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.<CurrentPlayerConfigurer>k__BackingField);
			this.syncVar___<PlayerUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 5U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<PlayerUserObject>k__BackingField);
			this.syncVar___<NPCUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 4U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<NPCUserObject>k__BackingField);
			this.syncVar___<WaterLevel>k__BackingField = new SyncVar<float>(this, 3U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<WaterLevel>k__BackingField);
			this.syncVar___<WaterLevel>k__BackingField.OnChange += this.WaterLevelChanged;
			this.syncVar___<RemainingSoilUses>k__BackingField = new SyncVar<int>(this, 2U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<RemainingSoilUses>k__BackingField);
			this.syncVar___<SoilID>k__BackingField = new SyncVar<string>(this, 1U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<SoilID>k__BackingField);
			this.syncVar___<SoilLevel>k__BackingField = new SyncVar<float>(this, 0U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<SoilLevel>k__BackingField);
			this.syncVar___<SoilLevel>k__BackingField.OnChange += this.SoilLevelChanged;
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_SetConfigurer_3323014238));
			base.RegisterServerRpc(9U, new ServerRpcDelegate(this.RpcReader___Server_SetPlayerUser_3323014238));
			base.RegisterServerRpc(10U, new ServerRpcDelegate(this.RpcReader___Server_SetNPCUser_3323014238));
			base.RegisterObserversRpc(11U, new ClientRpcDelegate(this.RpcReader___Observers_ResetPot_2166136261));
			base.RegisterServerRpc(12U, new ServerRpcDelegate(this.RpcReader___Server_SendSoilData_3104499779));
			base.RegisterServerRpc(13U, new ServerRpcDelegate(this.RpcReader___Server_SendWaterData_431000436));
			base.RegisterServerRpc(14U, new ServerRpcDelegate(this.RpcReader___Server_SendAdditive_310431262));
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_ApplyAdditive_619441887));
			base.RegisterTargetRpc(16U, new ClientRpcDelegate(this.RpcReader___Target_ApplyAdditive_619441887));
			base.RegisterObserversRpc(17U, new ClientRpcDelegate(this.RpcReader___Observers_FullyGrowPlant_2166136261));
			base.RegisterServerRpc(18U, new ServerRpcDelegate(this.RpcReader___Server_SendPlantSeed_2530605204));
			base.RegisterObserversRpc(19U, new ClientRpcDelegate(this.RpcReader___Observers_PlantSeed_709433087));
			base.RegisterTargetRpc(20U, new ClientRpcDelegate(this.RpcReader___Target_PlantSeed_709433087));
			base.RegisterObserversRpc(21U, new ClientRpcDelegate(this.RpcReader___Observers_SetGrowProgress_431000436));
			base.RegisterObserversRpc(22U, new ClientRpcDelegate(this.RpcReader___Observers_SetHarvestableActive_338960014));
			base.RegisterTargetRpc(23U, new ClientRpcDelegate(this.RpcReader___Target_SetHarvestableActive_338960014));
			base.RegisterServerRpc(24U, new ServerRpcDelegate(this.RpcReader___Server_SendHarvestableActive_3658436649));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.ObjectScripts.Pot));
		}

		// Token: 0x06005062 RID: 20578 RVA: 0x00152AD8 File Offset: 0x00150CD8
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.PotAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.PotAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___<CurrentPlayerConfigurer>k__BackingField.SetRegistered();
			this.syncVar___<PlayerUserObject>k__BackingField.SetRegistered();
			this.syncVar___<NPCUserObject>k__BackingField.SetRegistered();
			this.syncVar___<WaterLevel>k__BackingField.SetRegistered();
			this.syncVar___<RemainingSoilUses>k__BackingField.SetRegistered();
			this.syncVar___<SoilID>k__BackingField.SetRegistered();
			this.syncVar___<SoilLevel>k__BackingField.SetRegistered();
		}

		// Token: 0x06005063 RID: 20579 RVA: 0x00152B49 File Offset: 0x00150D49
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06005064 RID: 20580 RVA: 0x00152B58 File Offset: 0x00150D58
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteNetworkObject(player);
			base.SendServerRpc(8U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005065 RID: 20581 RVA: 0x00152BFF File Offset: 0x00150DFF
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			this.CurrentPlayerConfigurer = player;
		}

		// Token: 0x06005066 RID: 20582 RVA: 0x00152C08 File Offset: 0x00150E08
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject player = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetConfigurer_3323014238(player);
		}

		// Token: 0x06005067 RID: 20583 RVA: 0x00152C48 File Offset: 0x00150E48
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteNetworkObject(playerObject);
			base.SendServerRpc(9U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005068 RID: 20584 RVA: 0x00152CF0 File Offset: 0x00150EF0
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			if (this.PlayerUserObject != null && this.PlayerUserObject.Owner.IsLocalClient && playerObject != null && !playerObject.Owner.IsLocalClient)
			{
				Singleton<GameInput>.Instance.ExitAll();
			}
			this.PlayerUserObject = playerObject;
		}

		// Token: 0x06005069 RID: 20585 RVA: 0x00152D44 File Offset: 0x00150F44
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject playerObject = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetPlayerUser_3323014238(playerObject);
		}

		// Token: 0x0600506A RID: 20586 RVA: 0x00152D84 File Offset: 0x00150F84
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteNetworkObject(npcObject);
			base.SendServerRpc(10U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600506B RID: 20587 RVA: 0x00152E2B File Offset: 0x0015102B
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			this.NPCUserObject = npcObject;
		}

		// Token: 0x0600506C RID: 20588 RVA: 0x00152E34 File Offset: 0x00151034
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject npcObject = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetNPCUser_3323014238(npcObject);
		}

		// Token: 0x0600506D RID: 20589 RVA: 0x00152E74 File Offset: 0x00151074
		private void RpcWriter___Observers_ResetPot_2166136261()
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
			base.SendObserversRpc(11U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600506E RID: 20590 RVA: 0x00152F20 File Offset: 0x00151120
		public virtual void RpcLogic___ResetPot_2166136261()
		{
			if (this.Plant != null)
			{
				this.Plant.Destroy(true);
			}
			this.Plant = null;
			if (InstanceFinder.IsServer)
			{
				int remainingSoilUses = this.RemainingSoilUses;
				this.RemainingSoilUses = remainingSoilUses - 1;
			}
			if (this.RemainingSoilUses <= 0)
			{
				this.WaterLevel = 0f;
				this.appliedSoilDefinition = null;
				this.SoilID = string.Empty;
				this.SoilLevel = 0f;
			}
			foreach (Additive additive in this.AppliedAdditives)
			{
				Object.Destroy(additive.gameObject);
			}
			this.AppliedAdditives.Clear();
			this.SetSoilState(Pot.ESoilState.Flat);
			this.UpdateSoilScale();
			this.UpdateSoilMaterial();
			base.HasChanged = true;
		}

		// Token: 0x0600506F RID: 20591 RVA: 0x00153004 File Offset: 0x00151204
		private void RpcReader___Observers_ResetPot_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ResetPot_2166136261();
		}

		// Token: 0x06005070 RID: 20592 RVA: 0x00153030 File Offset: 0x00151230
		private void RpcWriter___Server_SendSoilData_3104499779(string soilID, float soilLevel, int soilUses)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(soilID);
			writer.WriteSingle(soilLevel, AutoPackType.Unpacked);
			writer.WriteInt32(soilUses, AutoPackType.Packed);
			base.SendServerRpc(12U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005071 RID: 20593 RVA: 0x001530FC File Offset: 0x001512FC
		public void RpcLogic___SendSoilData_3104499779(string soilID, float soilLevel, int soilUses)
		{
			this.SoilID = soilID;
			if (soilID != string.Empty)
			{
				this.appliedSoilDefinition = (Registry.GetItem(this.SoilID) as SoilDefinition);
			}
			else
			{
				this.appliedSoilDefinition = null;
			}
			this.SoilLevel = soilLevel;
			this.RemainingSoilUses = soilUses;
		}

		// Token: 0x06005072 RID: 20594 RVA: 0x0015314C File Offset: 0x0015134C
		private void RpcReader___Server_SendSoilData_3104499779(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string soilID = PooledReader0.ReadString();
			float soilLevel = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			int soilUses = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendSoilData_3104499779(soilID, soilLevel, soilUses);
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x001531AC File Offset: 0x001513AC
		private void RpcWriter___Server_SendWaterData_431000436(float waterLevel)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteSingle(waterLevel, AutoPackType.Unpacked);
			base.SendServerRpc(13U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x00153258 File Offset: 0x00151458
		public void RpcLogic___SendWaterData_431000436(float waterLevel)
		{
			this.WaterLevel = waterLevel;
		}

		// Token: 0x06005075 RID: 20597 RVA: 0x00153264 File Offset: 0x00151464
		private void RpcReader___Server_SendWaterData_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			float waterLevel = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendWaterData_431000436(waterLevel);
		}

		// Token: 0x06005076 RID: 20598 RVA: 0x0015329C File Offset: 0x0015149C
		private void RpcWriter___Server_SendAdditive_310431262(string additiveAssetPath, bool initial)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(additiveAssetPath);
			writer.WriteBoolean(initial);
			base.SendServerRpc(14U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x00153350 File Offset: 0x00151550
		public void RpcLogic___SendAdditive_310431262(string additiveAssetPath, bool initial)
		{
			this.ApplyAdditive(null, additiveAssetPath, initial);
		}

		// Token: 0x06005078 RID: 20600 RVA: 0x0015335C File Offset: 0x0015155C
		private void RpcReader___Server_SendAdditive_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string additiveAssetPath = PooledReader0.ReadString();
			bool initial = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendAdditive_310431262(additiveAssetPath, initial);
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x001533AC File Offset: 0x001515AC
		private void RpcWriter___Observers_ApplyAdditive_619441887(NetworkConnection conn, string additiveAssetPath, bool initial)
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
			writer.WriteString(additiveAssetPath);
			writer.WriteBoolean(initial);
			base.SendObserversRpc(15U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600507A RID: 20602 RVA: 0x00153470 File Offset: 0x00151670
		public void RpcLogic___ApplyAdditive_619441887(NetworkConnection conn, string additiveAssetPath, bool initial)
		{
			if (this.AppliedAdditives.Find((Additive x) => x.AssetPath == additiveAssetPath))
			{
				Console.Log("Pot already contains additive at " + additiveAssetPath, null);
				return;
			}
			GameObject gameObject = Resources.Load(additiveAssetPath) as GameObject;
			if (gameObject == null)
			{
				Console.LogWarning("Failed to load additive at path: " + additiveAssetPath, null);
				return;
			}
			Additive component = Object.Instantiate<GameObject>(gameObject, this.AdditivesContainer).GetComponent<Additive>();
			component.transform.localPosition = Vector3.zero;
			component.transform.localRotation = Quaternion.identity;
			if (this.Plant != null)
			{
				this.Plant.QualityLevel += component.QualityChange;
				this.Plant.YieldLevel += component.YieldChange;
				if (initial)
				{
					this.Plant.SetNormalizedGrowthProgress(this.Plant.NormalizedGrowthProgress + component.InstantGrowth);
					if (component.InstantGrowth > 0f)
					{
						this.PoofParticles.Play();
						this.PoofSound.Play();
					}
				}
			}
			this.AppliedAdditives.Add(component);
		}

		// Token: 0x0600507B RID: 20603 RVA: 0x001535B0 File Offset: 0x001517B0
		private void RpcReader___Observers_ApplyAdditive_619441887(PooledReader PooledReader0, Channel channel)
		{
			string additiveAssetPath = PooledReader0.ReadString();
			bool initial = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ApplyAdditive_619441887(null, additiveAssetPath, initial);
		}

		// Token: 0x0600507C RID: 20604 RVA: 0x00153600 File Offset: 0x00151800
		private void RpcWriter___Target_ApplyAdditive_619441887(NetworkConnection conn, string additiveAssetPath, bool initial)
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
			writer.WriteString(additiveAssetPath);
			writer.WriteBoolean(initial);
			base.SendTargetRpc(16U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x0600507D RID: 20605 RVA: 0x001536C4 File Offset: 0x001518C4
		private void RpcReader___Target_ApplyAdditive_619441887(PooledReader PooledReader0, Channel channel)
		{
			string additiveAssetPath = PooledReader0.ReadString();
			bool initial = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ApplyAdditive_619441887(base.LocalConnection, additiveAssetPath, initial);
		}

		// Token: 0x0600507E RID: 20606 RVA: 0x0015370C File Offset: 0x0015190C
		private void RpcWriter___Observers_FullyGrowPlant_2166136261()
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
			base.SendObserversRpc(17U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600507F RID: 20607 RVA: 0x001537B5 File Offset: 0x001519B5
		public void RpcLogic___FullyGrowPlant_2166136261()
		{
			if (this.Plant == null)
			{
				Console.LogWarning("FullyGrowPlant called but plant is null!", null);
				return;
			}
			this.Plant.SetNormalizedGrowthProgress(1f);
		}

		// Token: 0x06005080 RID: 20608 RVA: 0x001537E4 File Offset: 0x001519E4
		private void RpcReader___Observers_FullyGrowPlant_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___FullyGrowPlant_2166136261();
		}

		// Token: 0x06005081 RID: 20609 RVA: 0x00153810 File Offset: 0x00151A10
		private void RpcWriter___Server_SendPlantSeed_2530605204(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(seedID);
			writer.WriteSingle(normalizedSeedProgress, AutoPackType.Unpacked);
			writer.WriteSingle(yieldLevel, AutoPackType.Unpacked);
			writer.WriteSingle(qualityLevel, AutoPackType.Unpacked);
			base.SendServerRpc(18U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005082 RID: 20610 RVA: 0x001538ED File Offset: 0x00151AED
		public void RpcLogic___SendPlantSeed_2530605204(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			this.PlantSeed(null, seedID, normalizedSeedProgress, yieldLevel, qualityLevel);
		}

		// Token: 0x06005083 RID: 20611 RVA: 0x001538FC File Offset: 0x00151AFC
		private void RpcReader___Server_SendPlantSeed_2530605204(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string seedID = PooledReader0.ReadString();
			float normalizedSeedProgress = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			float yieldLevel = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			float qualityLevel = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendPlantSeed_2530605204(seedID, normalizedSeedProgress, yieldLevel, qualityLevel);
		}

		// Token: 0x06005084 RID: 20612 RVA: 0x0015397C File Offset: 0x00151B7C
		private void RpcWriter___Observers_PlantSeed_709433087(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
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
			writer.WriteString(seedID);
			writer.WriteSingle(normalizedSeedProgress, AutoPackType.Unpacked);
			writer.WriteSingle(yieldLevel, AutoPackType.Unpacked);
			writer.WriteSingle(qualityLevel, AutoPackType.Unpacked);
			base.SendObserversRpc(19U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06005085 RID: 20613 RVA: 0x00153A68 File Offset: 0x00151C68
		public void RpcLogic___PlantSeed_709433087(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			this.PlantSeed(seedID, normalizedSeedProgress, yieldLevel, qualityLevel);
		}

		// Token: 0x06005086 RID: 20614 RVA: 0x00153A78 File Offset: 0x00151C78
		private void RpcReader___Observers_PlantSeed_709433087(PooledReader PooledReader0, Channel channel)
		{
			string seedID = PooledReader0.ReadString();
			float normalizedSeedProgress = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			float yieldLevel = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			float qualityLevel = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___PlantSeed_709433087(null, seedID, normalizedSeedProgress, yieldLevel, qualityLevel);
		}

		// Token: 0x06005087 RID: 20615 RVA: 0x00153AF8 File Offset: 0x00151CF8
		private void RpcWriter___Target_PlantSeed_709433087(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
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
			writer.WriteString(seedID);
			writer.WriteSingle(normalizedSeedProgress, AutoPackType.Unpacked);
			writer.WriteSingle(yieldLevel, AutoPackType.Unpacked);
			writer.WriteSingle(qualityLevel, AutoPackType.Unpacked);
			base.SendTargetRpc(20U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06005088 RID: 20616 RVA: 0x00153BE4 File Offset: 0x00151DE4
		private void RpcReader___Target_PlantSeed_709433087(PooledReader PooledReader0, Channel channel)
		{
			string seedID = PooledReader0.ReadString();
			float normalizedSeedProgress = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			float yieldLevel = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			float qualityLevel = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___PlantSeed_709433087(base.LocalConnection, seedID, normalizedSeedProgress, yieldLevel, qualityLevel);
		}

		// Token: 0x06005089 RID: 20617 RVA: 0x00153C60 File Offset: 0x00151E60
		private void RpcWriter___Observers_SetGrowProgress_431000436(float progress)
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
			writer.WriteSingle(progress, AutoPackType.Unpacked);
			base.SendObserversRpc(21U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600508A RID: 20618 RVA: 0x00153D1B File Offset: 0x00151F1B
		private void RpcLogic___SetGrowProgress_431000436(float progress)
		{
			if (this.Plant == null)
			{
				Console.LogWarning("SetGrowProgress called but plant is null!", null);
				return;
			}
			this.Plant.SetNormalizedGrowthProgress(progress);
		}

		// Token: 0x0600508B RID: 20619 RVA: 0x00153D44 File Offset: 0x00151F44
		private void RpcReader___Observers_SetGrowProgress_431000436(PooledReader PooledReader0, Channel channel)
		{
			float progress = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetGrowProgress_431000436(progress);
		}

		// Token: 0x0600508C RID: 20620 RVA: 0x00153D7C File Offset: 0x00151F7C
		private void RpcWriter___Observers_SetHarvestableActive_338960014(NetworkConnection conn, int harvestableIndex, bool active)
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
			writer.WriteInt32(harvestableIndex, AutoPackType.Packed);
			writer.WriteBoolean(active);
			base.SendObserversRpc(22U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600508D RID: 20621 RVA: 0x00153E44 File Offset: 0x00152044
		public void RpcLogic___SetHarvestableActive_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
			this.SetHarvestableActive_Local(harvestableIndex, active);
		}

		// Token: 0x0600508E RID: 20622 RVA: 0x00153E50 File Offset: 0x00152050
		private void RpcReader___Observers_SetHarvestableActive_338960014(PooledReader PooledReader0, Channel channel)
		{
			int harvestableIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool active = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetHarvestableActive_338960014(null, harvestableIndex, active);
		}

		// Token: 0x0600508F RID: 20623 RVA: 0x00153EA4 File Offset: 0x001520A4
		private void RpcWriter___Target_SetHarvestableActive_338960014(NetworkConnection conn, int harvestableIndex, bool active)
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
			writer.WriteInt32(harvestableIndex, AutoPackType.Packed);
			writer.WriteBoolean(active);
			base.SendTargetRpc(23U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06005090 RID: 20624 RVA: 0x00153F6C File Offset: 0x0015216C
		private void RpcReader___Target_SetHarvestableActive_338960014(PooledReader PooledReader0, Channel channel)
		{
			int harvestableIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool active = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetHarvestableActive_338960014(base.LocalConnection, harvestableIndex, active);
		}

		// Token: 0x06005091 RID: 20625 RVA: 0x00153FBC File Offset: 0x001521BC
		private void RpcWriter___Server_SendHarvestableActive_3658436649(int harvestableIndex, bool active)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteInt32(harvestableIndex, AutoPackType.Packed);
			writer.WriteBoolean(active);
			base.SendServerRpc(24U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005092 RID: 20626 RVA: 0x00154075 File Offset: 0x00152275
		public void RpcLogic___SendHarvestableActive_3658436649(int harvestableIndex, bool active)
		{
			this.SetHarvestableActive(null, harvestableIndex, active);
		}

		// Token: 0x06005093 RID: 20627 RVA: 0x00154080 File Offset: 0x00152280
		private void RpcReader___Server_SendHarvestableActive_3658436649(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int harvestableIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool active = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendHarvestableActive_3658436649(harvestableIndex, active);
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06005094 RID: 20628 RVA: 0x001540D4 File Offset: 0x001522D4
		// (set) Token: 0x06005095 RID: 20629 RVA: 0x001540DC File Offset: 0x001522DC
		public float SyncAccessor_<SoilLevel>k__BackingField
		{
			get
			{
				return this.<SoilLevel>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<SoilLevel>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<SoilLevel>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x06005096 RID: 20630 RVA: 0x00154118 File Offset: 0x00152318
		public virtual bool Pot(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 == 6U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_<CurrentPlayerConfigurer>k__BackingField(this.syncVar___<CurrentPlayerConfigurer>k__BackingField.GetValue(true), true);
					return true;
				}
				NetworkObject value = PooledReader0.ReadNetworkObject();
				this.sync___set_value_<CurrentPlayerConfigurer>k__BackingField(value, Boolean2);
				return true;
			}
			else if (UInt321 == 5U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_<PlayerUserObject>k__BackingField(this.syncVar___<PlayerUserObject>k__BackingField.GetValue(true), true);
					return true;
				}
				NetworkObject value2 = PooledReader0.ReadNetworkObject();
				this.sync___set_value_<PlayerUserObject>k__BackingField(value2, Boolean2);
				return true;
			}
			else if (UInt321 == 4U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_<NPCUserObject>k__BackingField(this.syncVar___<NPCUserObject>k__BackingField.GetValue(true), true);
					return true;
				}
				NetworkObject value3 = PooledReader0.ReadNetworkObject();
				this.sync___set_value_<NPCUserObject>k__BackingField(value3, Boolean2);
				return true;
			}
			else if (UInt321 == 3U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_<WaterLevel>k__BackingField(this.syncVar___<WaterLevel>k__BackingField.GetValue(true), true);
					return true;
				}
				float value4 = PooledReader0.ReadSingle(AutoPackType.Unpacked);
				this.sync___set_value_<WaterLevel>k__BackingField(value4, Boolean2);
				return true;
			}
			else if (UInt321 == 2U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_<RemainingSoilUses>k__BackingField(this.syncVar___<RemainingSoilUses>k__BackingField.GetValue(true), true);
					return true;
				}
				int value5 = PooledReader0.ReadInt32(AutoPackType.Packed);
				this.sync___set_value_<RemainingSoilUses>k__BackingField(value5, Boolean2);
				return true;
			}
			else if (UInt321 == 1U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_<SoilID>k__BackingField(this.syncVar___<SoilID>k__BackingField.GetValue(true), true);
					return true;
				}
				string value6 = PooledReader0.ReadString();
				this.sync___set_value_<SoilID>k__BackingField(value6, Boolean2);
				return true;
			}
			else
			{
				if (UInt321 != 0U)
				{
					return false;
				}
				if (PooledReader0 == null)
				{
					this.sync___set_value_<SoilLevel>k__BackingField(this.syncVar___<SoilLevel>k__BackingField.GetValue(true), true);
					return true;
				}
				float value7 = PooledReader0.ReadSingle(AutoPackType.Unpacked);
				this.sync___set_value_<SoilLevel>k__BackingField(value7, Boolean2);
				return true;
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06005097 RID: 20631 RVA: 0x00154311 File Offset: 0x00152511
		// (set) Token: 0x06005098 RID: 20632 RVA: 0x00154319 File Offset: 0x00152519
		public string SyncAccessor_<SoilID>k__BackingField
		{
			get
			{
				return this.<SoilID>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<SoilID>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<SoilID>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06005099 RID: 20633 RVA: 0x00154355 File Offset: 0x00152555
		// (set) Token: 0x0600509A RID: 20634 RVA: 0x0015435D File Offset: 0x0015255D
		public int SyncAccessor_<RemainingSoilUses>k__BackingField
		{
			get
			{
				return this.<RemainingSoilUses>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<RemainingSoilUses>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<RemainingSoilUses>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x0600509B RID: 20635 RVA: 0x00154399 File Offset: 0x00152599
		// (set) Token: 0x0600509C RID: 20636 RVA: 0x001543A1 File Offset: 0x001525A1
		public float SyncAccessor_<WaterLevel>k__BackingField
		{
			get
			{
				return this.<WaterLevel>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<WaterLevel>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<WaterLevel>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x0600509D RID: 20637 RVA: 0x001543DD File Offset: 0x001525DD
		// (set) Token: 0x0600509E RID: 20638 RVA: 0x001543E5 File Offset: 0x001525E5
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			get
			{
				return this.<NPCUserObject>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<NPCUserObject>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<NPCUserObject>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x0600509F RID: 20639 RVA: 0x00154421 File Offset: 0x00152621
		// (set) Token: 0x060050A0 RID: 20640 RVA: 0x00154429 File Offset: 0x00152629
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			get
			{
				return this.<PlayerUserObject>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<PlayerUserObject>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<PlayerUserObject>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x060050A1 RID: 20641 RVA: 0x00154465 File Offset: 0x00152665
		// (set) Token: 0x060050A2 RID: 20642 RVA: 0x0015446D File Offset: 0x0015266D
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			get
			{
				return this.<CurrentPlayerConfigurer>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<CurrentPlayerConfigurer>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<CurrentPlayerConfigurer>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x060050A3 RID: 20643 RVA: 0x001544A9 File Offset: 0x001526A9
		protected virtual void dll()
		{
			base.Awake();
			this.SoilCover.gameObject.SetActive(false);
			this.SetTargetActive(false);
		}

		// Token: 0x04003C4E RID: 15438
		public const float DryThreshold = 0f;

		// Token: 0x04003C4F RID: 15439
		public const float WaterloggedThreshold = 1f;

		// Token: 0x04003C50 RID: 15440
		public const float ROTATION_SPEED = 10f;

		// Token: 0x04003C51 RID: 15441
		public const float MAX_CAMERA_DISTANCE = 2.75f;

		// Token: 0x04003C52 RID: 15442
		public const float MIN_CAMERA_DISTANCE = 0.5f;

		// Token: 0x04003C53 RID: 15443
		[Header("References")]
		public Transform ModelTransform;

		// Token: 0x04003C54 RID: 15444
		public InteractableObject IntObj;

		// Token: 0x04003C55 RID: 15445
		public Transform PourableStartPoint;

		// Token: 0x04003C56 RID: 15446
		public Transform SeedStartPoint;

		// Token: 0x04003C57 RID: 15447
		public Transform SeedRestingPoint;

		// Token: 0x04003C58 RID: 15448
		public GameObject WaterLoggedVisuals;

		// Token: 0x04003C59 RID: 15449
		public Transform LookAtPoint;

		// Token: 0x04003C5A RID: 15450
		public Transform AdditivesContainer;

		// Token: 0x04003C5B RID: 15451
		public Transform PlantContainer;

		// Token: 0x04003C5C RID: 15452
		public Transform IntObjLabel_Low;

		// Token: 0x04003C5D RID: 15453
		public Transform IntObjLabel_High;

		// Token: 0x04003C5E RID: 15454
		public Transform uiPoint;

		// Token: 0x04003C5F RID: 15455
		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		// Token: 0x04003C60 RID: 15456
		public Transform[] accessPoints;

		// Token: 0x04003C61 RID: 15457
		public Transform TaskBounds;

		// Token: 0x04003C62 RID: 15458
		public PotSoilCover SoilCover;

		// Token: 0x04003C63 RID: 15459
		public Transform LeafDropPoint;

		// Token: 0x04003C64 RID: 15460
		public ParticleSystem PoofParticles;

		// Token: 0x04003C65 RID: 15461
		public AudioSourceController PoofSound;

		// Token: 0x04003C66 RID: 15462
		[Header("UI")]
		public Transform WaterCanvasContainer;

		// Token: 0x04003C67 RID: 15463
		public Canvas WaterLevelCanvas;

		// Token: 0x04003C68 RID: 15464
		public CanvasGroup WaterLevelCanvasGroup;

		// Token: 0x04003C69 RID: 15465
		public Slider WaterLevelSlider;

		// Token: 0x04003C6A RID: 15466
		public GameObject NoWaterIcon;

		// Token: 0x04003C6B RID: 15467
		public PotUIElement WorldspaceUIPrefab;

		// Token: 0x04003C6C RID: 15468
		public Sprite typeIcon;

		// Token: 0x04003C6D RID: 15469
		[Header("Camera References")]
		public Transform CameraContainer;

		// Token: 0x04003C6E RID: 15470
		public Transform MidshotPosition;

		// Token: 0x04003C6F RID: 15471
		public Transform CloseupPosition;

		// Token: 0x04003C70 RID: 15472
		public Transform FullshotPosition;

		// Token: 0x04003C71 RID: 15473
		public Transform BirdsEyePosition;

		// Token: 0x04003C72 RID: 15474
		public bool AutoRotateCameraContainer = true;

		// Token: 0x04003C73 RID: 15475
		[Header("Dirt references")]
		public Transform Dirt_Flat;

		// Token: 0x04003C74 RID: 15476
		public Transform Dirt_Parted;

		// Token: 0x04003C75 RID: 15477
		public SoilChunk[] SoilChunks;

		// Token: 0x04003C76 RID: 15478
		public List<MeshRenderer> DirtRenderers = new List<MeshRenderer>();

		// Token: 0x04003C77 RID: 15479
		[Header("Pot Settings")]
		public float PotRadius = 0.2f;

		// Token: 0x04003C78 RID: 15480
		[Range(0.2f, 2f)]
		public float YieldMultiplier = 1f;

		// Token: 0x04003C79 RID: 15481
		[Range(0.2f, 2f)]
		public float GrowSpeedMultiplier = 1f;

		// Token: 0x04003C7A RID: 15482
		[Range(0.2f, 2f)]
		public float MoistureDrainMultiplier = 1f;

		// Token: 0x04003C7B RID: 15483
		public bool AlignLeafDropToPlayer = true;

		// Token: 0x04003C7C RID: 15484
		[Header("Capacity Settings")]
		public float SoilCapacity = 20f;

		// Token: 0x04003C7D RID: 15485
		public float WaterCapacity = 5f;

		// Token: 0x04003C7E RID: 15486
		public float WaterDrainPerHour = 2f;

		// Token: 0x04003C7F RID: 15487
		[Header("Dirt Settings")]
		[SerializeField]
		protected Vector3 DirtMinScale;

		// Token: 0x04003C80 RID: 15488
		[SerializeField]
		protected Vector3 DirtMaxScale = Vector3.one;

		// Token: 0x04003C81 RID: 15489
		[Header("Pour Target")]
		public Transform Target;

		// Token: 0x04003C82 RID: 15490
		[Header("Lighting")]
		public UsableLightSource LightSourceOverride;

		// Token: 0x04003C88 RID: 15496
		public List<Additive> AppliedAdditives;

		// Token: 0x04003C92 RID: 15506
		private bool intObjSetThisFrame;

		// Token: 0x04003C93 RID: 15507
		private ItemSlot outputSlot;

		// Token: 0x04003C94 RID: 15508
		private float rotation;

		// Token: 0x04003C95 RID: 15509
		private bool rotationOverridden;

		// Token: 0x04003C96 RID: 15510
		private SoilDefinition appliedSoilDefinition;

		// Token: 0x04003C97 RID: 15511
		public SyncVar<float> syncVar___<SoilLevel>k__BackingField;

		// Token: 0x04003C98 RID: 15512
		public SyncVar<string> syncVar___<SoilID>k__BackingField;

		// Token: 0x04003C99 RID: 15513
		public SyncVar<int> syncVar___<RemainingSoilUses>k__BackingField;

		// Token: 0x04003C9A RID: 15514
		public SyncVar<float> syncVar___<WaterLevel>k__BackingField;

		// Token: 0x04003C9B RID: 15515
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04003C9C RID: 15516
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04003C9D RID: 15517
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04003C9E RID: 15518
		private bool dll_Excuted;

		// Token: 0x04003C9F RID: 15519
		private bool dll_Excuted;

		// Token: 0x02000BA4 RID: 2980
		public enum ECameraPosition
		{
			// Token: 0x04003CA1 RID: 15521
			Closeup,
			// Token: 0x04003CA2 RID: 15522
			Midshot,
			// Token: 0x04003CA3 RID: 15523
			Fullshot,
			// Token: 0x04003CA4 RID: 15524
			BirdsEye
		}

		// Token: 0x02000BA5 RID: 2981
		public enum ESoilState
		{
			// Token: 0x04003CA6 RID: 15526
			Flat,
			// Token: 0x04003CA7 RID: 15527
			Parted,
			// Token: 0x04003CA8 RID: 15528
			Packed
		}
	}
}
