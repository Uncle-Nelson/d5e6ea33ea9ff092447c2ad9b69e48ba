using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Map;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	// Token: 0x0200045D RID: 1117
	public class NPCManager : NetworkSingleton<NPCManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x000673AA File Offset: 0x000655AA
		public string SaveFolderName
		{
			get
			{
				return "NPCs";
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x000673AA File Offset: 0x000655AA
		public string SaveFileName
		{
			get
			{
				return "NPCs";
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x0600175B RID: 5979 RVA: 0x000673B1 File Offset: 0x000655B1
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x000673B9 File Offset: 0x000655B9
		// (set) Token: 0x0600175E RID: 5982 RVA: 0x000673C1 File Offset: 0x000655C1
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x000673CA File Offset: 0x000655CA
		// (set) Token: 0x06001760 RID: 5984 RVA: 0x000673D2 File Offset: 0x000655D2
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x000673DB File Offset: 0x000655DB
		// (set) Token: 0x06001762 RID: 5986 RVA: 0x000673E3 File Offset: 0x000655E3
		public bool HasChanged { get; set; }

		// Token: 0x06001763 RID: 5987 RVA: 0x000673EC File Offset: 0x000655EC
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.NPCManager_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00067400 File Offset: 0x00065600
		protected override void Start()
		{
			base.Start();
			Singleton<LoadManager>.Instance.onPreSceneChange.AddListener(new UnityAction(delegate()
			{
				NPCManager.NPCRegistry.Clear();
			}));
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x000045B1 File Offset: 0x000027B1
		public void Update()
		{
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x00067438 File Offset: 0x00065638
		public static NPC GetNPC(string id)
		{
			foreach (NPC npc in NPCManager.NPCRegistry)
			{
				if (npc.ID.ToLower() == id.ToLower())
				{
					return npc;
				}
			}
			return null;
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x000674A4 File Offset: 0x000656A4
		public static List<NPC> GetNPCsInRegion(EMapRegion region)
		{
			List<NPC> list = new List<NPC>();
			foreach (NPC npc in NPCManager.NPCRegistry)
			{
				if (!(npc == null) && npc.Region == region)
				{
					list.Add(npc);
				}
			}
			return list;
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x0003CEED File Offset: 0x0003B0ED
		public virtual string GetSaveString()
		{
			return string.Empty;
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00067510 File Offset: 0x00065710
		public List<Transform> GetOrderedDistanceWarpPoints(Vector3 origin)
		{
			return (from x in new List<Transform>(this.NPCWarpPoints)
			orderby Vector3.SqrMagnitude(x.position - origin)
			select x).ToList<Transform>();
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x0006754C File Offset: 0x0006574C
		public virtual List<string> WriteData(string parentFolderPath)
		{
			List<string> list = new List<string>();
			string containerFolder = ((ISaveable)this).GetContainerFolder(parentFolderPath);
			for (int i = 0; i < NPCManager.NPCRegistry.Count; i++)
			{
				if (NPCManager.NPCRegistry[i].ShouldSave())
				{
					new SaveRequest(NPCManager.NPCRegistry[i], containerFolder);
					list.Add(NPCManager.NPCRegistry[i].SaveFolderName);
				}
			}
			return list;
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x000675EC File Offset: 0x000657EC
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.NPCManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.NPCManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00067605 File Offset: 0x00065805
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.NPCManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.NPCManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x0006761E File Offset: 0x0006581E
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0006762C File Offset: 0x0006582C
		protected virtual void dll()
		{
			base.Awake();
			this.InitializeSaveable();
		}

		// Token: 0x04001514 RID: 5396
		public static List<NPC> NPCRegistry = new List<NPC>();

		// Token: 0x04001515 RID: 5397
		public Transform[] NPCWarpPoints;

		// Token: 0x04001516 RID: 5398
		public Transform NPCContainer;

		// Token: 0x04001517 RID: 5399
		[Header("Employee Prefabs")]
		public GameObject BotanistPrefab;

		// Token: 0x04001518 RID: 5400
		public GameObject PackagerPrefab;

		// Token: 0x04001519 RID: 5401
		[Header("Prefabs")]
		public NPCPoI NPCPoIPrefab;

		// Token: 0x0400151A RID: 5402
		public NPCPoI PotentialCustomerPoIPrefab;

		// Token: 0x0400151B RID: 5403
		public NPCPoI PotentialDealerPoIPrefab;

		// Token: 0x0400151C RID: 5404
		private NPCsLoader loader = new NPCsLoader();

		// Token: 0x04001520 RID: 5408
		private bool dll_Excuted;

		// Token: 0x04001521 RID: 5409
		private bool dll_Excuted;
	}
}
