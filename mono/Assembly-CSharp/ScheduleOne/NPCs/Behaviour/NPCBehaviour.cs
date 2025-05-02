using System;
using System.Collections.Generic;
using System.Linq;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.Doors;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.Product;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000523 RID: 1315
	public class NPCBehaviour : NetworkBehaviour
	{
		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x00080EB0 File Offset: 0x0007F0B0
		// (set) Token: 0x06001F86 RID: 8070 RVA: 0x00080EB8 File Offset: 0x0007F0B8
		public Behaviour activeBehaviour { get; set; }

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x00080EC1 File Offset: 0x0007F0C1
		// (set) Token: 0x06001F88 RID: 8072 RVA: 0x00080EC9 File Offset: 0x0007F0C9
		public NPC Npc { get; private set; }

		// Token: 0x06001F89 RID: 8073 RVA: 0x00080ED4 File Offset: 0x0007F0D4
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.Behaviour.NPCBehaviour_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x00080EF4 File Offset: 0x0007F0F4
		protected virtual void Start()
		{
			this.Npc.Avatar.Anim.onHeavyFlinch.AddListener(new UnityAction(this.HeavyFlinchBehaviour.Flinch));
			TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			TimeManager instance2 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance2.onMinutePass = (Action)Delegate.Combine(instance2.onMinutePass, new Action(this.MinPass));
			for (int i = 0; i < this.behaviourStack.Count; i++)
			{
				Behaviour b = this.behaviourStack[i];
				if (b.Enabled)
				{
					this.enabledBehaviours.Add(b);
				}
				b.onEnable.AddListener(new UnityAction(delegate()
				{
					this.AddEnabledBehaviour(b);
				}));
				b.onDisable.AddListener(new UnityAction(delegate()
				{
					this.RemoveEnabledBehaviour(b);
				}));
			}
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x00081008 File Offset: 0x0007F208
		private void OnDestroy()
		{
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
				instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			}
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x00081038 File Offset: 0x0007F238
		protected override void OnValidate()
		{
			base.OnValidate();
			this.behaviourStack = base.GetComponentsInChildren<Behaviour>().ToList<Behaviour>();
			this.SortBehaviourStack();
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x00081057 File Offset: 0x0007F257
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (this.activeBehaviour != null)
			{
				this.activeBehaviour.Begin_Networked(connection);
			}
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x0008107C File Offset: 0x0007F27C
		[ServerRpc(RequireOwnership = false)]
		public void Summon(string buildingGUID, int doorIndex, float duration)
		{
			this.RpcWriter___Server_Summon_900355577(buildingGUID, doorIndex, duration);
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x0008109B File Offset: 0x0007F29B
		[ServerRpc(RequireOwnership = false)]
		public void ConsumeProduct(ProductItemInstance product)
		{
			this.RpcWriter___Server_ConsumeProduct_2622925554(product);
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x000810A8 File Offset: 0x0007F2A8
		protected virtual void OnKnockOut()
		{
			this.CoweringBehaviour.Disable_Networked(null);
			this.RagdollBehaviour.Disable_Networked(null);
			this.CallPoliceBehaviour.Disable_Networked(null);
			this.GenericDialogueBehaviour.Disable_Networked(null);
			this.HeavyFlinchBehaviour.Disable_Networked(null);
			this.FacePlayerBehaviour.Disable_Networked(null);
			this.SummonBehaviour.Disable_Networked(null);
			this.ConsumeProductBehaviour.Disable_Networked(null);
			this.CombatBehaviour.Disable_Networked(null);
			this.FleeBehaviour.Disable_Networked(null);
			this.StationaryBehaviour.Disable_Networked(null);
			this.RequestProductBehaviour.Disable_Networked(null);
			foreach (Behaviour behaviour in this.behaviourStack)
			{
				if (!(behaviour == this.DeadBehaviour) && !(behaviour == this.UnconsciousBehaviour) && behaviour.Active)
				{
					behaviour.End_Networked(null);
				}
			}
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x000811B0 File Offset: 0x0007F3B0
		protected virtual void OnDie()
		{
			this.OnKnockOut();
			this.UnconsciousBehaviour.Disable_Networked(null);
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x000811C4 File Offset: 0x0007F3C4
		public Behaviour GetBehaviour(string BehaviourName)
		{
			Behaviour behaviour = this.behaviourStack.Find((Behaviour x) => x.Name.ToLower() == BehaviourName.ToLower());
			if (behaviour == null)
			{
				Console.LogWarning("No behaviour found with name '" + BehaviourName + "'", null);
			}
			return behaviour;
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x0008121C File Offset: 0x0007F41C
		public virtual void Update()
		{
			if (this.DEBUG_MODE && this.activeBehaviour != null)
			{
				Debug.Log("Active behaviour: " + this.activeBehaviour.Name);
			}
			if (InstanceFinder.IsHost)
			{
				Behaviour enabledBehaviour = this.GetEnabledBehaviour();
				if (enabledBehaviour != this.activeBehaviour)
				{
					if (this.activeBehaviour != null)
					{
						this.activeBehaviour.Pause_Networked(null);
					}
					if (enabledBehaviour != null)
					{
						if (enabledBehaviour.Started)
						{
							enabledBehaviour.Resume_Networked(null);
						}
						else
						{
							enabledBehaviour.Begin_Networked(null);
						}
					}
				}
			}
			if (this.activeBehaviour != null && this.activeBehaviour.Active)
			{
				this.activeBehaviour.BehaviourUpdate();
			}
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x000812D6 File Offset: 0x0007F4D6
		public virtual void LateUpdate()
		{
			if (this.activeBehaviour != null && this.activeBehaviour.Active)
			{
				this.activeBehaviour.BehaviourLateUpdate();
			}
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x000812FE File Offset: 0x0007F4FE
		protected virtual void MinPass()
		{
			if (this.activeBehaviour != null && this.activeBehaviour.Active)
			{
				this.activeBehaviour.ActiveMinPass();
			}
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x00081326 File Offset: 0x0007F526
		public void SortBehaviourStack()
		{
			this.behaviourStack = (from x in this.behaviourStack
			orderby x.Priority descending
			select x).ToList<Behaviour>();
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x0008135D File Offset: 0x0007F55D
		private Behaviour GetEnabledBehaviour()
		{
			return this.enabledBehaviours.FirstOrDefault<Behaviour>();
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x0008136C File Offset: 0x0007F56C
		private void AddEnabledBehaviour(Behaviour b)
		{
			if (!this.enabledBehaviours.Contains(b))
			{
				this.enabledBehaviours.Add(b);
				this.enabledBehaviours = (from x in this.enabledBehaviours
				orderby x.Priority descending
				select x).ToList<Behaviour>();
			}
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x000813C8 File Offset: 0x0007F5C8
		private void RemoveEnabledBehaviour(Behaviour b)
		{
			if (this.enabledBehaviours.Contains(b))
			{
				this.enabledBehaviours.Remove(b);
				this.enabledBehaviours = (from x in this.enabledBehaviours
				orderby x.Priority descending
				select x).ToList<Behaviour>();
			}
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x00081444 File Offset: 0x0007F644
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.NPCBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.NPCBehaviourAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_Summon_900355577));
			base.RegisterServerRpc(1U, new ServerRpcDelegate(this.RpcReader___Server_ConsumeProduct_2622925554));
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x00081490 File Offset: 0x0007F690
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.NPCBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.NPCBehaviourAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x000814A3 File Offset: 0x0007F6A3
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x000814B4 File Offset: 0x0007F6B4
		private void RpcWriter___Server_Summon_900355577(string buildingGUID, int doorIndex, float duration)
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
			writer.WriteString(buildingGUID);
			writer.WriteInt32(doorIndex, AutoPackType.Packed);
			writer.WriteSingle(duration, AutoPackType.Unpacked);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x00081580 File Offset: 0x0007F780
		public void RpcLogic___Summon_900355577(string buildingGUID, int doorIndex, float duration)
		{
			NPCBehaviour.<>c__DisplayClass32_0 CS$<>8__locals1 = new NPCBehaviour.<>c__DisplayClass32_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.duration = duration;
			NPCEnterableBuilding @object = GUIDManager.GetObject<NPCEnterableBuilding>(new Guid(buildingGUID));
			if (@object == null)
			{
				Console.LogError("Failed to find building with GUID: " + buildingGUID, null);
				return;
			}
			StaticDoor lastEnteredDoor = @object.Doors[doorIndex];
			this.Npc.LastEnteredDoor = lastEnteredDoor;
			this.SummonBehaviour.Enable_Networked(null);
			if (this.summonRoutine != null)
			{
				base.StopCoroutine(this.summonRoutine);
			}
			this.summonRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<Summon>g__Routine|0());
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x00081614 File Offset: 0x0007F814
		private void RpcReader___Server_Summon_900355577(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string buildingGUID = PooledReader0.ReadString();
			int doorIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			float duration = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___Summon_900355577(buildingGUID, doorIndex, duration);
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x00081674 File Offset: 0x0007F874
		private void RpcWriter___Server_ConsumeProduct_2622925554(ProductItemInstance product)
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
			writer.WriteProductItemInstance(product);
			base.SendServerRpc(1U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x0008171B File Offset: 0x0007F91B
		public void RpcLogic___ConsumeProduct_2622925554(ProductItemInstance product)
		{
			this.ConsumeProductBehaviour.SendProduct(product);
			this.ConsumeProductBehaviour.Enable_Networked(null);
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x00081738 File Offset: 0x0007F938
		private void RpcReader___Server_ConsumeProduct_2622925554(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			ProductItemInstance product = PooledReader0.ReadProductItemInstance();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___ConsumeProduct_2622925554(product);
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x0008176C File Offset: 0x0007F96C
		protected virtual void dll()
		{
			this.Npc = base.GetComponentInParent<NPC>();
			this.Npc.Health.onKnockedOut.AddListener(new UnityAction(this.OnKnockOut));
			this.Npc.Health.onDie.AddListener(new UnityAction(this.OnDie));
		}

		// Token: 0x04001889 RID: 6281
		public bool DEBUG_MODE;

		// Token: 0x0400188A RID: 6282
		[Header("References")]
		public NPCScheduleManager ScheduleManager;

		// Token: 0x0400188B RID: 6283
		[Header("Default Behaviours")]
		public CoweringBehaviour CoweringBehaviour;

		// Token: 0x0400188C RID: 6284
		public RagdollBehaviour RagdollBehaviour;

		// Token: 0x0400188D RID: 6285
		public CallPoliceBehaviour CallPoliceBehaviour;

		// Token: 0x0400188E RID: 6286
		public GenericDialogueBehaviour GenericDialogueBehaviour;

		// Token: 0x0400188F RID: 6287
		public HeavyFlinchBehaviour HeavyFlinchBehaviour;

		// Token: 0x04001890 RID: 6288
		public FacePlayerBehaviour FacePlayerBehaviour;

		// Token: 0x04001891 RID: 6289
		public DeadBehaviour DeadBehaviour;

		// Token: 0x04001892 RID: 6290
		public UnconsciousBehaviour UnconsciousBehaviour;

		// Token: 0x04001893 RID: 6291
		public Behaviour SummonBehaviour;

		// Token: 0x04001894 RID: 6292
		public ConsumeProductBehaviour ConsumeProductBehaviour;

		// Token: 0x04001895 RID: 6293
		public CombatBehaviour CombatBehaviour;

		// Token: 0x04001896 RID: 6294
		public FleeBehaviour FleeBehaviour;

		// Token: 0x04001897 RID: 6295
		public StationaryBehaviour StationaryBehaviour;

		// Token: 0x04001898 RID: 6296
		public RequestProductBehaviour RequestProductBehaviour;

		// Token: 0x04001899 RID: 6297
		[SerializeField]
		protected List<Behaviour> behaviourStack = new List<Behaviour>();

		// Token: 0x0400189C RID: 6300
		private Coroutine summonRoutine;

		// Token: 0x0400189D RID: 6301
		[SerializeField]
		private List<Behaviour> enabledBehaviours = new List<Behaviour>();

		// Token: 0x0400189E RID: 6302
		private bool dll_Excuted;

		// Token: 0x0400189F RID: 6303
		private bool dll_Excuted;
	}
}
