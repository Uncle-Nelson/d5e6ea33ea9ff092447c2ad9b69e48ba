using System;
using System.Collections.Generic;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Casino
{
	// Token: 0x0200075D RID: 1885
	public class CasinoGamePlayerData
	{
		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06003324 RID: 13092 RVA: 0x000D509F File Offset: 0x000D329F
		// (set) Token: 0x06003325 RID: 13093 RVA: 0x000D50A7 File Offset: 0x000D32A7
		public CasinoGamePlayers Parent { get; private set; }

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06003326 RID: 13094 RVA: 0x000D50B0 File Offset: 0x000D32B0
		// (set) Token: 0x06003327 RID: 13095 RVA: 0x000D50B8 File Offset: 0x000D32B8
		public Player Player { get; private set; }

		// Token: 0x06003328 RID: 13096 RVA: 0x000D50C4 File Offset: 0x000D32C4
		public CasinoGamePlayerData(CasinoGamePlayers parent, Player player)
		{
			this.Parent = parent;
			this.Player = player;
			this.bools = new Dictionary<string, bool>();
			this.floats = new Dictionary<string, float>();
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x000D5114 File Offset: 0x000D3314
		public T GetData<T>(string key)
		{
			if (typeof(T) == typeof(bool))
			{
				if (this.bools.ContainsKey(key))
				{
					return (T)((object)this.bools[key]);
				}
			}
			else if (typeof(T) == typeof(float) && this.floats.ContainsKey(key))
			{
				return (T)((object)this.floats[key]);
			}
			return default(T);
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x000D51AC File Offset: 0x000D33AC
		public void SetData<T>(string key, T value, bool network = true)
		{
			if (network)
			{
				if (typeof(T) == typeof(bool))
				{
					this.Parent.SendPlayerBool(this.Player.NetworkObject, key, (bool)((object)value));
				}
				else if (typeof(T) == typeof(float))
				{
					this.Parent.SendPlayerFloat(this.Player.NetworkObject, key, (float)((object)value));
				}
			}
			if (!(typeof(T) == typeof(bool)))
			{
				if (typeof(T) == typeof(float))
				{
					if (this.floats.ContainsKey(key))
					{
						this.floats[key] = (float)((object)value);
						return;
					}
					this.floats.Add(key, (float)((object)value));
				}
				return;
			}
			if (this.bools.ContainsKey(key))
			{
				this.bools[key] = (bool)((object)value);
				return;
			}
			this.bools.Add(key, (bool)((object)value));
		}

		// Token: 0x04002488 RID: 9352
		protected Dictionary<string, bool> bools = new Dictionary<string, bool>();

		// Token: 0x04002489 RID: 9353
		protected Dictionary<string, float> floats = new Dictionary<string, float>();
	}
}
