using System;
using System.Collections.Generic;
using EasyButtons;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008B9 RID: 2233
	public class WorldStorageEntity : StorageEntity, IGUIDRegisterable, ISaveable
	{
		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06003CB9 RID: 15545 RVA: 0x000FFC90 File Offset: 0x000FDE90
		// (set) Token: 0x06003CBA RID: 15546 RVA: 0x000FFC98 File Offset: 0x000FDE98
		public Guid GUID { get; protected set; }

		// Token: 0x06003CBB RID: 15547 RVA: 0x000FFCA4 File Offset: 0x000FDEA4
		[Button]
		public void RegenerateGUID()
		{
			this.BakedGUID = Guid.NewGuid().ToString();
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06003CBC RID: 15548 RVA: 0x000FFCCC File Offset: 0x000FDECC
		public string SaveFolderName
		{
			get
			{
				return "Entity_" + this.GUID.ToString().Substring(0, 6);
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06003CBD RID: 15549 RVA: 0x000FFD00 File Offset: 0x000FDF00
		public string SaveFileName
		{
			get
			{
				return "Entity_" + this.GUID.ToString().Substring(0, 6);
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06003CBE RID: 15550 RVA: 0x00046D4A File Offset: 0x00044F4A
		public Loader Loader
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06003CBF RID: 15551 RVA: 0x000141BA File Offset: 0x000123BA
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06003CC0 RID: 15552 RVA: 0x000FFD32 File Offset: 0x000FDF32
		// (set) Token: 0x06003CC1 RID: 15553 RVA: 0x000FFD3A File Offset: 0x000FDF3A
		public List<string> LocalExtraFiles { get; set; } = new List<string>
		{
			"Contents"
		};

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06003CC2 RID: 15554 RVA: 0x000FFD43 File Offset: 0x000FDF43
		// (set) Token: 0x06003CC3 RID: 15555 RVA: 0x000FFD4B File Offset: 0x000FDF4B
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06003CC4 RID: 15556 RVA: 0x000FFD54 File Offset: 0x000FDF54
		// (set) Token: 0x06003CC5 RID: 15557 RVA: 0x000FFD5C File Offset: 0x000FDF5C
		public bool HasChanged { get; set; }

		// Token: 0x06003CC6 RID: 15558 RVA: 0x000FFD68 File Offset: 0x000FDF68
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Storage.WorldStorageEntity_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003CC7 RID: 15559 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06003CC8 RID: 15560 RVA: 0x000FFD87 File Offset: 0x000FDF87
		public void SetGUID(Guid guid)
		{
			this.GUID = guid;
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x06003CC9 RID: 15561 RVA: 0x000FFD96 File Offset: 0x000FDF96
		public virtual bool ShouldSave()
		{
			return base.ItemCount > 0;
		}

		// Token: 0x06003CCA RID: 15562 RVA: 0x000FFDA1 File Offset: 0x000FDFA1
		public virtual string GetSaveString()
		{
			return new WorldStorageEntityData(this.GUID, new ItemSet(base.ItemSlots)).GetJson(true);
		}

		// Token: 0x06003CCB RID: 15563 RVA: 0x000FFDC0 File Offset: 0x000FDFC0
		public virtual void Load(WorldStorageEntityData data)
		{
			for (int i = 0; i < data.Contents.Items.Length; i++)
			{
				ItemInstance instance = ItemDeserializer.LoadItem(data.Contents.Items[i]);
				if (base.ItemSlots.Count > i)
				{
					base.ItemSlots[i].SetStoredItem(instance, false);
				}
			}
		}

		// Token: 0x06003CCC RID: 15564 RVA: 0x000FFE19 File Offset: 0x000FE019
		protected override void ContentsChanged()
		{
			base.ContentsChanged();
			this.HasChanged = true;
		}

		// Token: 0x06003CCF RID: 15567 RVA: 0x000FFE68 File Offset: 0x000FE068
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Storage.WorldStorageEntityAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Storage.WorldStorageEntityAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x000FFE81 File Offset: 0x000FE081
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Storage.WorldStorageEntityAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Storage.WorldStorageEntityAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x000FFE9A File Offset: 0x000FE09A
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003CD2 RID: 15570 RVA: 0x000FFEA8 File Offset: 0x000FE0A8
		protected virtual void dll()
		{
			base.Awake();
			WorldStorageEntity.All.Add(this);
			if (!GUIDManager.IsGUIDValid(this.BakedGUID))
			{
				Console.LogError(base.gameObject.name + "'s baked GUID is not valid! Bad.", null);
			}
			if (GUIDManager.IsGUIDAlreadyRegistered(new Guid(this.BakedGUID)))
			{
				Console.LogError(base.gameObject.name + "'s baked GUID is already registered! Bad.", this);
			}
			this.GUID = new Guid(this.BakedGUID);
			GUIDManager.RegisterObject(this);
			this.InitializeSaveable();
		}

		// Token: 0x04002B9F RID: 11167
		public static List<WorldStorageEntity> All = new List<WorldStorageEntity>();

		// Token: 0x04002BA1 RID: 11169
		[SerializeField]
		protected string BakedGUID = string.Empty;

		// Token: 0x04002BA5 RID: 11173
		private bool dll_Excuted;

		// Token: 0x04002BA6 RID: 11174
		private bool dll_Excuted;
	}
}
