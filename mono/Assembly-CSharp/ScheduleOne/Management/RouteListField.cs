using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x0200057A RID: 1402
	public class RouteListField : ConfigField
	{
		// Token: 0x060022DD RID: 8925 RVA: 0x0008F52A File Offset: 0x0008D72A
		public RouteListField(EntityConfiguration parentConfig) : base(parentConfig)
		{
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x0008F550 File Offset: 0x0008D750
		public void SetList(List<AdvancedTransitRoute> list, bool network, bool bypassSequenceCheck = false)
		{
			if (this.Routes.SequenceEqual(list) && !bypassSequenceCheck)
			{
				return;
			}
			this.Routes = new List<AdvancedTransitRoute>();
			this.Routes.AddRange(list);
			if (network)
			{
				base.ParentConfig.ReplicateField(this, null);
			}
			if (this.onListChanged != null)
			{
				this.onListChanged.Invoke(list);
			}
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x0008F5AA File Offset: 0x0008D7AA
		public void Replicate()
		{
			Console.Log("Replicating route list field", null);
			this.SetList(this.Routes, true, true);
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x0008F5C8 File Offset: 0x0008D7C8
		public void AddItem(AdvancedTransitRoute item)
		{
			if (this.Routes.Contains(item))
			{
				return;
			}
			if (this.Routes.Count >= this.MaxRoutes)
			{
				Console.LogWarning("Route cannot be added to " + base.ParentConfig.GetType().Name + " because the maximum number of routes has been reached", null);
				return;
			}
			this.SetList(new List<AdvancedTransitRoute>(this.Routes)
			{
				item
			}, true, false);
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x0008F63C File Offset: 0x0008D83C
		public void RemoveItem(AdvancedTransitRoute item)
		{
			if (!this.Routes.Contains(item))
			{
				return;
			}
			List<AdvancedTransitRoute> list = new List<AdvancedTransitRoute>(this.Routes);
			list.Remove(item);
			this.SetList(list, true, false);
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x0008F675 File Offset: 0x0008D875
		public override bool IsValueDefault()
		{
			return this.Routes.Count == 0;
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x0008F688 File Offset: 0x0008D888
		public RouteListData GetData()
		{
			List<AdvancedTransitRouteData> list = new List<AdvancedTransitRouteData>();
			for (int i = 0; i < this.Routes.Count; i++)
			{
				list.Add(this.Routes[i].GetData());
			}
			return new RouteListData(list);
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x0008F6D0 File Offset: 0x0008D8D0
		public void Load(RouteListData data)
		{
			if (data != null)
			{
				List<AdvancedTransitRoute> list = new List<AdvancedTransitRoute>();
				for (int i = 0; i < data.Routes.Count; i++)
				{
					if (string.IsNullOrEmpty(data.Routes[i].SourceGUID) || string.IsNullOrEmpty(data.Routes[i].DestinationGUID))
					{
						Console.LogWarning("Route data is missing source or destination GUID", null);
					}
					else
					{
						ITransitEntity source = null;
						ITransitEntity destination = null;
						try
						{
							source = GUIDManager.GetObject<ITransitEntity>(new Guid(data.Routes[i].SourceGUID));
							destination = GUIDManager.GetObject<ITransitEntity>(new Guid(data.Routes[i].DestinationGUID));
						}
						catch (Exception ex)
						{
							Console.LogError("Error loading route: " + ex.Message, null);
							goto IL_175;
						}
						AdvancedTransitRoute advancedTransitRoute = new AdvancedTransitRoute(source, destination);
						advancedTransitRoute.Filter.SetMode(data.Routes[i].FilterMode);
						for (int j = 0; j < data.Routes[i].FilterItemIDs.Count; j++)
						{
							ItemDefinition @object = GUIDManager.GetObject<ItemDefinition>(new Guid(data.Routes[i].FilterItemIDs[j]));
							if (@object == null)
							{
								Console.LogWarning("Could not find item definition with GUID " + data.Routes[i].FilterItemIDs[j], null);
							}
							else if (@object != null)
							{
								advancedTransitRoute.Filter.AddItem(@object);
							}
						}
						list.Add(advancedTransitRoute);
					}
					IL_175:;
				}
				this.SetList(list, true, false);
			}
		}

		// Token: 0x04001A40 RID: 6720
		public List<AdvancedTransitRoute> Routes = new List<AdvancedTransitRoute>();

		// Token: 0x04001A41 RID: 6721
		public int MaxRoutes = 1;

		// Token: 0x04001A42 RID: 6722
		public UnityEvent<List<AdvancedTransitRoute>> onListChanged = new UnityEvent<List<AdvancedTransitRoute>>();
	}
}
