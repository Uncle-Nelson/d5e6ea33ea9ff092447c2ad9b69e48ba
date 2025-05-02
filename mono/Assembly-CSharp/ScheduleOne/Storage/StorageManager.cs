using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ScheduleOne.Storage
{
	// Token: 0x020008AF RID: 2223
	public class StorageManager : NetworkSingleton<StorageManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06003C65 RID: 15461 RVA: 0x000FE920 File Offset: 0x000FCB20
		public string SaveFolderName
		{
			get
			{
				return "WorldStorageEntities";
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06003C66 RID: 15462 RVA: 0x000FE920 File Offset: 0x000FCB20
		public string SaveFileName
		{
			get
			{
				return "WorldStorageEntities";
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06003C67 RID: 15463 RVA: 0x000FE927 File Offset: 0x000FCB27
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06003C68 RID: 15464 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06003C69 RID: 15465 RVA: 0x000FE92F File Offset: 0x000FCB2F
		// (set) Token: 0x06003C6A RID: 15466 RVA: 0x000FE937 File Offset: 0x000FCB37
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06003C6B RID: 15467 RVA: 0x000FE940 File Offset: 0x000FCB40
		// (set) Token: 0x06003C6C RID: 15468 RVA: 0x000FE948 File Offset: 0x000FCB48
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06003C6D RID: 15469 RVA: 0x000FE951 File Offset: 0x000FCB51
		// (set) Token: 0x06003C6E RID: 15470 RVA: 0x000FE959 File Offset: 0x000FCB59
		public bool HasChanged { get; set; }

		// Token: 0x06003C6F RID: 15471 RVA: 0x000FE962 File Offset: 0x000FCB62
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Storage.StorageManager_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003C70 RID: 15472 RVA: 0x000FE978 File Offset: 0x000FCB78
		public Pallet CreatePallet(Vector3 position, Quaternion rotation, string initialSlotGuid = "")
		{
			Pallet component = Object.Instantiate<GameObject>(this.PalletPrefab).GetComponent<Pallet>();
			component.transform.position = position;
			component.transform.rotation = rotation;
			base.NetworkObject.Spawn(component.gameObject, null, default(Scene));
			if (GUIDManager.IsGUIDValid(initialSlotGuid))
			{
				PalletSlot @object = GUIDManager.GetObject<PalletSlot>(new Guid(initialSlotGuid));
				if (@object != null)
				{
					component.BindToSlot_Server(@object.GUID);
				}
			}
			return component;
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x0003CEED File Offset: 0x0003B0ED
		public virtual string GetSaveString()
		{
			return string.Empty;
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x000FE9F4 File Offset: 0x000FCBF4
		public virtual List<string> WriteData(string parentFolderPath)
		{
			List<string> list = new List<string>();
			string containerFolder = ((ISaveable)this).GetContainerFolder(parentFolderPath);
			for (int i = 0; i < WorldStorageEntity.All.Count; i++)
			{
				if (WorldStorageEntity.All[i].ShouldSave())
				{
					new SaveRequest(WorldStorageEntity.All[i], containerFolder);
					list.Add(WorldStorageEntity.All[i].SaveFileName);
				}
			}
			return list;
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x000FEA88 File Offset: 0x000FCC88
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Storage.StorageManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Storage.StorageManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x000FEAA1 File Offset: 0x000FCCA1
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Storage.StorageManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Storage.StorageManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x000FEABA File Offset: 0x000FCCBA
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x000FEAC8 File Offset: 0x000FCCC8
		protected virtual void dll()
		{
			base.Awake();
			this.InitializeSaveable();
		}

		// Token: 0x04002B71 RID: 11121
		[Header("Prefabs")]
		public GameObject PalletPrefab;

		// Token: 0x04002B72 RID: 11122
		private StorageLoader loader = new StorageLoader();

		// Token: 0x04002B76 RID: 11126
		private bool dll_Excuted;

		// Token: 0x04002B77 RID: 11127
		private bool dll_Excuted;
	}
}
