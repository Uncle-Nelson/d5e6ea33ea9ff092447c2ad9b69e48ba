using System;
using FishNet.Connection;
using FishNet.Object;
using ScheduleOne.Property;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Management
{
	// Token: 0x0200057D RID: 1405
	public interface IConfigurable
	{
		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060022EE RID: 8942
		EntityConfiguration Configuration { get; }

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060022EF RID: 8943
		ConfigurationReplicator ConfigReplicator { get; }

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060022F0 RID: 8944
		EConfigurableType ConfigurableType { get; }

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060022F1 RID: 8945
		// (set) Token: 0x060022F2 RID: 8946
		WorldspaceUIElement WorldspaceUI { get; set; }

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060022F3 RID: 8947
		// (set) Token: 0x060022F4 RID: 8948
		NetworkObject CurrentPlayerConfigurer { get; set; }

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x0008F985 File Offset: 0x0008DB85
		bool IsBeingConfiguredByOtherPlayer
		{
			get
			{
				return this.CurrentPlayerConfigurer != null && !this.CurrentPlayerConfigurer.IsOwner;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060022F6 RID: 8950
		Sprite TypeIcon { get; }

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060022F7 RID: 8951
		Transform Transform { get; }

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060022F8 RID: 8952
		Transform UIPoint { get; }

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x0008F9A5 File Offset: 0x0008DBA5
		bool IsDestroyed
		{
			get
			{
				return this == null || this.Transform == null;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060022FA RID: 8954
		bool CanBeSelected { get; }

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060022FB RID: 8955
		Property ParentProperty { get; }

		// Token: 0x060022FC RID: 8956
		WorldspaceUIElement CreateWorldspaceUI();

		// Token: 0x060022FD RID: 8957
		void DestroyWorldspaceUI();

		// Token: 0x060022FE RID: 8958
		void ShowOutline(Color color);

		// Token: 0x060022FF RID: 8959
		void HideOutline();

		// Token: 0x06002300 RID: 8960 RVA: 0x0008F9B8 File Offset: 0x0008DBB8
		void Selected()
		{
			this.Configuration.Selected();
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x0008F9C5 File Offset: 0x0008DBC5
		void Deselected()
		{
			this.Configuration.Deselected();
		}

		// Token: 0x06002302 RID: 8962
		void SetConfigurer(NetworkObject player);

		// Token: 0x06002303 RID: 8963
		void SendConfigurationToClient(NetworkConnection conn);
	}
}
