using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000023 RID: 35
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00007988 File Offset: 0x00005B88
		public static T instance
		{
			get
			{
				return Singleton<T>.sInstance;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000798F File Offset: 0x00005B8F
		public static void Clear()
		{
			Singleton<T>.sInstance = default(T);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000799C File Offset: 0x00005B9C
		protected virtual void Awake()
		{
			if (Singleton<T>.sInstance != null)
			{
				Debug.LogError(base.name + "error: already initialized", this);
			}
			Singleton<T>.sInstance = (T)((object)this);
		}

		// Token: 0x040000DA RID: 218
		private static T sInstance;
	}
}
