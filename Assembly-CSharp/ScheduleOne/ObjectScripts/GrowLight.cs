using System;
using System.Collections.Generic;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Lighting;
using ScheduleOne.Misc;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BA2 RID: 2978
	public class GrowLight : ProceduralGridItem
	{
		// Token: 0x06004FF8 RID: 20472 RVA: 0x00150FE8 File Offset: 0x0014F1E8
		public override void InitializeProceduralGridItem(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			base.InitializeProceduralGridItem(instance, _rotation, _footprintTileMatches, GUID);
			if (!this.isGhost)
			{
				this.SetIsOn(true);
				foreach (CoordinateProceduralTilePair coordinateProceduralTilePair in base.SyncAccessor_footprintTileMatches)
				{
					if (coordinateProceduralTilePair.tile.MatchedFootprintTile != null)
					{
						coordinateProceduralTilePair.tile.MatchedFootprintTile.MatchedStandardTile.LightExposureNode.AddSource(this.usableLightSource, 1f);
					}
				}
			}
		}

		// Token: 0x06004FF9 RID: 20473 RVA: 0x00151088 File Offset: 0x0014F288
		public void SetIsOn(bool isOn)
		{
			this.usableLightSource.isEmitting = isOn;
			this.Light.isOn = isOn;
		}

		// Token: 0x06004FFA RID: 20474 RVA: 0x001510A4 File Offset: 0x0014F2A4
		public override void DestroyItem(bool callOnServer = true)
		{
			foreach (CoordinateProceduralTilePair coordinateProceduralTilePair in base.SyncAccessor_footprintTileMatches)
			{
				if (coordinateProceduralTilePair.tile.MatchedFootprintTile != null)
				{
					coordinateProceduralTilePair.tile.MatchedFootprintTile.MatchedStandardTile.LightExposureNode.RemoveSource(this.usableLightSource);
				}
			}
			base.DestroyItem(callOnServer);
		}

		// Token: 0x06004FFC RID: 20476 RVA: 0x00151134 File Offset: 0x0014F334
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.GrowLightAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.GrowLightAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06004FFD RID: 20477 RVA: 0x0015114D File Offset: 0x0014F34D
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.GrowLightAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.GrowLightAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06004FFE RID: 20478 RVA: 0x00151166 File Offset: 0x0014F366
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06004FFF RID: 20479 RVA: 0x00151174 File Offset: 0x0014F374
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04003C4A RID: 15434
		[Header("References")]
		public ToggleableLight Light;

		// Token: 0x04003C4B RID: 15435
		public UsableLightSource usableLightSource;

		// Token: 0x04003C4C RID: 15436
		private bool dll_Excuted;

		// Token: 0x04003C4D RID: 15437
		private bool dll_Excuted;
	}
}
