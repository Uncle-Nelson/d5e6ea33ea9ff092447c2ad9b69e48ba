using System;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006FA RID: 1786
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06003087 RID: 12423 RVA: 0x000CA095 File Offset: 0x000C8295
		public static bool InstanceExists
		{
			get
			{
				return Singleton<T>.instance != null;
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06003088 RID: 12424 RVA: 0x000CA0A7 File Offset: 0x000C82A7
		// (set) Token: 0x06003089 RID: 12425 RVA: 0x000CA0AE File Offset: 0x000C82AE
		public static T Instance
		{
			get
			{
				return Singleton<T>.instance;
			}
			protected set
			{
				Singleton<T>.instance = value;
			}
		}

		// Token: 0x0600308A RID: 12426 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void Start()
		{
		}

		// Token: 0x0600308B RID: 12427 RVA: 0x000CA0B8 File Offset: 0x000C82B8
		protected virtual void Awake()
		{
			if (Singleton<T>.instance != null)
			{
				Console.LogWarning("Multiple instances of " + base.name + " exist. Destroying this instance.", null);
				Object.Destroy(base.gameObject);
				return;
			}
			Singleton<T>.instance = (T)((object)this);
		}

		// Token: 0x0600308C RID: 12428 RVA: 0x000CA109 File Offset: 0x000C8309
		protected virtual void OnDestroy()
		{
			if (Singleton<T>.instance == this)
			{
				Singleton<T>.instance = default(T);
			}
		}

		// Token: 0x04002281 RID: 8833
		private static T instance;

		// Token: 0x04002282 RID: 8834
		protected bool Destroyed;
	}
}
