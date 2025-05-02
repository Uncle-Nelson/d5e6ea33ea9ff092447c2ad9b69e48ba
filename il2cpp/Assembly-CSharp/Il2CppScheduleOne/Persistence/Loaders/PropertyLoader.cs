using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000232 RID: 562
	public class PropertyLoader : Loader
	{
		// Token: 0x06002DF2 RID: 11762 RVA: 0x00102B08 File Offset: 0x00100D08
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyLoader()
		{
			Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "PropertyLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr);
			PropertyLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr, 100668573);
			PropertyLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr, 100668574);
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x00102B60 File Offset: 0x00100D60
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x00102B9C File Offset: 0x00100D9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127978, RefRangeEnd = 127979, XrefRangeStart = 127838, XrefRangeEnd = 127978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x000188BA File Offset: 0x00016ABA
		public PropertyLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E7A RID: 7802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E7B RID: 7803
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x020008FA RID: 2298
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.PropertyLoader+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600C55E RID: 50526 RVA: 0x003005B4 File Offset: 0x002FE7B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyLoader>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr);
				PropertyLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_objectPriorities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr, "objectPriorities");
				PropertyLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr, 100668575);
				PropertyLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__Load_b__0_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr, 100668576);
			}

			// Token: 0x0600C55F RID: 50527 RVA: 0x0030061C File Offset: 0x002FE81C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyLoader.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C560 RID: 50528 RVA: 0x00300658 File Offset: 0x002FE858
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127834, XrefRangeEnd = 127838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Load_b__0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__Load_b__0_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C561 RID: 50529 RVA: 0x0006009D File Offset: 0x0005E29D
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D94 RID: 15764
			// (get) Token: 0x0600C562 RID: 50530 RVA: 0x003006A8 File Offset: 0x002FE8A8
			// (set) Token: 0x0600C563 RID: 50531 RVA: 0x000600A6 File Offset: 0x0005E2A6
			public unsafe Dictionary<string, int> objectPriorities
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_objectPriorities);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_objectPriorities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085C9 RID: 34249
			private static readonly IntPtr NativeFieldInfoPtr_objectPriorities;

			// Token: 0x040085CA RID: 34250
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085CB RID: 34251
			private static readonly IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Int32_String_0;
		}
	}
}
