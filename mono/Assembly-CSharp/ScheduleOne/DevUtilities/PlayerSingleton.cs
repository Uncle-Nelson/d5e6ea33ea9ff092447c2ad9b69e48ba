using System;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006F6 RID: 1782
	public abstract class PlayerSingleton<T> : MonoBehaviour where T : PlayerSingleton<T>
	{
		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06003071 RID: 12401 RVA: 0x000C9DA2 File Offset: 0x000C7FA2
		public static bool InstanceExists
		{
			get
			{
				return PlayerSingleton<T>.instance != null;
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06003072 RID: 12402 RVA: 0x000C9DB4 File Offset: 0x000C7FB4
		// (set) Token: 0x06003073 RID: 12403 RVA: 0x000C9DBB File Offset: 0x000C7FBB
		public static T Instance
		{
			get
			{
				return PlayerSingleton<T>.instance;
			}
			protected set
			{
				PlayerSingleton<T>.instance = value;
			}
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x000C9DC3 File Offset: 0x000C7FC3
		protected virtual void Awake()
		{
			this.OnStartClient(true);
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void Start()
		{
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x000C9DCC File Offset: 0x000C7FCC
		public virtual void OnStartClient(bool IsOwner)
		{
			if (!IsOwner)
			{
				Console.Log("Destroying non-local player singleton: " + base.name, null);
				Object.Destroy(this);
				return;
			}
			if (PlayerSingleton<T>.instance != null)
			{
				Console.LogWarning("Multiple instances of " + base.name + " exist. Keeping prior instance reference.", null);
				return;
			}
			PlayerSingleton<T>.instance = (T)((object)this);
		}

		// Token: 0x06003077 RID: 12407 RVA: 0x000C9E32 File Offset: 0x000C8032
		protected virtual void OnDestroy()
		{
			if (PlayerSingleton<T>.instance == this)
			{
				PlayerSingleton<T>.instance = default(T);
			}
		}

		// Token: 0x04002273 RID: 8819
		private static T instance;
	}
}
