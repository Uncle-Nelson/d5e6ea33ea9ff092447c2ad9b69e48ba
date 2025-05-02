using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x02000787 RID: 1927
	public class BuildStart_ProceduralGrid : BuildStart_Base
	{
		// Token: 0x06003491 RID: 13457 RVA: 0x000DB7D8 File Offset: 0x000D99D8
		public override void StartBuilding(ItemInstance itemInstance)
		{
			ProceduralGridItem proceduralGridItem = this.CreateGhostModel(itemInstance.Definition as BuildableItemDefinition);
			if (proceduralGridItem == null)
			{
				return;
			}
			Singleton<HUD>.Instance.SetCrosshairVisible(false);
			ProceduralGridItem component = proceduralGridItem.GetComponent<ProceduralGridItem>();
			base.gameObject.GetComponent<BuildUpdate_ProceduralGrid>().GhostModel = proceduralGridItem.gameObject;
			base.gameObject.GetComponent<BuildUpdate_ProceduralGrid>().ItemClass = component;
			base.gameObject.GetComponent<BuildUpdate_ProceduralGrid>().ItemInstance = itemInstance;
			Singleton<InputPromptsCanvas>.Instance.LoadModule("building");
			for (int i = 0; i < component.CoordinateFootprintTilePairs.Count; i++)
			{
				component.CoordinateFootprintTilePairs[i].footprintTile.tileDetector.tileDetectionMode = ETileDetectionMode.ProceduralTile;
			}
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x000DB88C File Offset: 0x000D9A8C
		protected virtual ProceduralGridItem CreateGhostModel(BuildableItemDefinition itemDefinition)
		{
			itemDefinition.BuiltItem.isGhost = true;
			GameObject gameObject = Object.Instantiate<GameObject>(itemDefinition.BuiltItem.gameObject, base.transform);
			itemDefinition.BuiltItem.isGhost = false;
			ProceduralGridItem component = gameObject.GetComponent<ProceduralGridItem>();
			if (component == null)
			{
				Console.LogWarning("CreateGhostModel: asset path is not a BuildableItem!", null);
				return null;
			}
			component.enabled = false;
			component.isGhost = true;
			Singleton<BuildManager>.Instance.DisableColliders(gameObject);
			Singleton<BuildManager>.Instance.DisableNavigation(gameObject);
			Singleton<BuildManager>.Instance.DisableNetworking(gameObject);
			component.SetFootprintTileVisiblity(false);
			return component;
		}
	}
}
