using System;
using FishNet.Object;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006EA RID: 1770
	public abstract class NetworkSingleton<T> : NetworkBehaviour where T : NetworkSingleton<T>
	{
		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x0600302D RID: 12333 RVA: 0x000C86CD File Offset: 0x000C68CD
		public static bool InstanceExists
		{
			get
			{
				return NetworkSingleton<T>.instance != null;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600302E RID: 12334 RVA: 0x000C86DF File Offset: 0x000C68DF
		// (set) Token: 0x0600302F RID: 12335 RVA: 0x000C86E6 File Offset: 0x000C68E6
		public static T Instance
		{
			get
			{
				return NetworkSingleton<T>.instance;
			}
			protected set
			{
				NetworkSingleton<T>.instance = value;
			}
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void Start()
		{
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x000C86EE File Offset: 0x000C68EE
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.DevUtilities.NetworkSingleton`1_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003032 RID: 12338 RVA: 0x000C8702 File Offset: 0x000C6902
		protected virtual void OnDestroy()
		{
			if (NetworkSingleton<T>.instance == this)
			{
				NetworkSingleton<T>.instance = default(T);
			}
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x000C8721 File Offset: 0x000C6921
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.DevUtilities.NetworkSingleton`1Assembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.DevUtilities.NetworkSingleton`1Assembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x000C8734 File Offset: 0x000C6934
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.DevUtilities.NetworkSingleton`1Assembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.DevUtilities.NetworkSingleton`1Assembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06003036 RID: 12342 RVA: 0x000C8747 File Offset: 0x000C6947
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x000C8755 File Offset: 0x000C6955
		protected virtual void NetworkSingleton()
		{
			if (NetworkSingleton<T>.instance != null)
			{
				Console.LogWarning("Multiple instances of " + base.name + " exist. Keeping prior instance reference.", null);
				return;
			}
			NetworkSingleton<T>.instance = (T)((object)this);
		}

		// Token: 0x04002236 RID: 8758
		private static T instance;

		// Token: 0x04002237 RID: 8759
		protected bool Destroyed;

		// Token: 0x04002238 RID: 8760
		private bool NetworkSingleton;

		// Token: 0x04002239 RID: 8761
		private bool NetworkSingleton;
	}
}
