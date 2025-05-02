using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Trash;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008D0 RID: 2256
	public class StationItem : MonoBehaviour
	{
		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06003D46 RID: 15686 RVA: 0x001016A5 File Offset: 0x000FF8A5
		// (set) Token: 0x06003D47 RID: 15687 RVA: 0x001016AD File Offset: 0x000FF8AD
		public List<ItemModule> ActiveModules { get; protected set; } = new List<ItemModule>();

		// Token: 0x06003D48 RID: 15688 RVA: 0x00050B71 File Offset: 0x0004ED71
		protected virtual void Awake()
		{
			LayerUtility.SetLayerRecursively(base.gameObject, LayerMask.NameToLayer("Task"));
		}

		// Token: 0x06003D49 RID: 15689 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void Initialize(StorableItemDefinition itemDefinition)
		{
		}

		// Token: 0x06003D4A RID: 15690 RVA: 0x001016B8 File Offset: 0x000FF8B8
		public void ActivateModule<T>() where T : ItemModule
		{
			ItemModule itemModule = this.GetModule<T>();
			if (itemModule == null)
			{
				Console.LogWarning(itemModule.GetType().Name + " is not a valid module for " + base.name, null);
				return;
			}
			this.ActiveModules.Add(itemModule);
			itemModule.ActivateModule(this);
		}

		// Token: 0x06003D4B RID: 15691 RVA: 0x000FA546 File Offset: 0x000F8746
		public void Destroy()
		{
			Object.Destroy(base.gameObject);
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x0010170F File Offset: 0x000FF90F
		public bool HasModule<T>() where T : ItemModule
		{
			return this.Modules.Exists((ItemModule x) => x.GetType() == typeof(T));
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x0010173B File Offset: 0x000FF93B
		public T GetModule<T>() where T : ItemModule
		{
			return (T)((object)this.Modules.Find((ItemModule x) => x.GetType() == typeof(T)));
		}

		// Token: 0x04002C1B RID: 11291
		public List<ItemModule> Modules;

		// Token: 0x04002C1C RID: 11292
		public TrashItem TrashPrefab;
	}
}
