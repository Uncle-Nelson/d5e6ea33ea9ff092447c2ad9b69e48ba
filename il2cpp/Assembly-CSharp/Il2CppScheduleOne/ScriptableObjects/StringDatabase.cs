using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ScriptableObjects
{
	// Token: 0x020004B1 RID: 1201
	[Serializable]
	public class StringDatabase : ScriptableObject
	{
		// Token: 0x060069C8 RID: 27080 RVA: 0x001D95E0 File Offset: 0x001D77E0
		// Note: this type is marked as 'beforefieldinit'.
		static StringDatabase()
		{
			Il2CppClassPointerStore<StringDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ScriptableObjects", "StringDatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringDatabase>.NativeClassPtr);
			StringDatabase.NativeFieldInfoPtr_Strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringDatabase>.NativeClassPtr, "Strings");
			StringDatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringDatabase>.NativeClassPtr, 100676727);
		}

		// Token: 0x060069C9 RID: 27081 RVA: 0x001D9638 File Offset: 0x001D7838
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88919, RefRangeEnd = 88931, XrefRangeStart = 88919, XrefRangeEnd = 88931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringDatabase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringDatabase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringDatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069CA RID: 27082 RVA: 0x00032019 File Offset: 0x00030219
		public StringDatabase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x060069CB RID: 27083 RVA: 0x001D9674 File Offset: 0x001D7874
		// (set) Token: 0x060069CC RID: 27084 RVA: 0x00032022 File Offset: 0x00030222
		public unsafe Il2CppStringArray Strings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringDatabase.NativeFieldInfoPtr_Strings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringDatabase.NativeFieldInfoPtr_Strings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004874 RID: 18548
		private static readonly IntPtr NativeFieldInfoPtr_Strings;

		// Token: 0x04004875 RID: 18549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
