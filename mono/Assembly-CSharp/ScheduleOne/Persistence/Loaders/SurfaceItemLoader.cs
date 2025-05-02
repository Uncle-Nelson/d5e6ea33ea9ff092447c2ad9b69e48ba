using System;
using ScheduleOne.Building;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003CC RID: 972
	public class SurfaceItemLoader : BuildableItemLoader
	{
		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x0005F005 File Offset: 0x0005D205
		public override string ItemType
		{
			get
			{
				return typeof(SurfaceItemData).Name;
			}
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x0005F016 File Offset: 0x0005D216
		public override void Load(string mainPath)
		{
			this.LoadAndCreate(mainPath);
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0005F020 File Offset: 0x0005D220
		protected SurfaceItem LoadAndCreate(string mainPath)
		{
			string text;
			if (base.TryLoadFile(mainPath, "Data", out text))
			{
				SurfaceItemData surfaceItemData = null;
				try
				{
					surfaceItemData = JsonUtility.FromJson<SurfaceItemData>(text);
				}
				catch (Exception ex)
				{
					Type type = base.GetType();
					string str = (type != null) ? type.ToString() : null;
					string str2 = " error reading data: ";
					Exception ex2 = ex;
					Console.LogError(str + str2 + ((ex2 != null) ? ex2.ToString() : null), null);
				}
				if (surfaceItemData != null)
				{
					ItemInstance itemInstance = ItemDeserializer.LoadItem(surfaceItemData.ItemString);
					if (itemInstance == null)
					{
						return null;
					}
					Surface @object = GUIDManager.GetObject<Surface>(new Guid(surfaceItemData.ParentSurfaceGUID));
					if (@object == null)
					{
						Console.LogWarning("Failed to find parent surface for " + surfaceItemData.ParentSurfaceGUID, null);
						return null;
					}
					return Singleton<BuildManager>.Instance.CreateSurfaceItem(itemInstance, @object, surfaceItemData.RelativePosition, surfaceItemData.RelativeRotation, surfaceItemData.GUID);
				}
			}
			return null;
		}
	}
}
