using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200001C RID: 28
	public abstract class LazySingleton<T> : MonoBehaviour where T : LazySingleton<T>
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00007242 File Offset: 0x00005442
		public static bool hasInstance
		{
			get
			{
				return LazySingleton<T>.sInstance != null;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00007254 File Offset: 0x00005454
		public static T instance
		{
			get
			{
				if (LazySingleton<T>.sInstance == null)
				{
					LazySingleton<T>.sInstance = new GameObject(typeof(T).ToString()).AddComponent<T>();
				}
				return LazySingleton<T>.sInstance;
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000728B File Offset: 0x0000548B
		protected virtual void Awake()
		{
			LazySingleton<T>.sInstance = (T)((object)this);
		}

		// Token: 0x040000CB RID: 203
		private static T sInstance;
	}
}
