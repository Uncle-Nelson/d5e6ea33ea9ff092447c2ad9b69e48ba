using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000150 RID: 336
	[Serializable]
	public class GeneratorExclude : Object
	{
		// Token: 0x06001BA5 RID: 7077 RVA: 0x000C6CFC File Offset: 0x000C4EFC
		// Note: this type is marked as 'beforefieldinit'.
		static GeneratorExclude()
		{
			Il2CppClassPointerStore<GeneratorExclude>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "GeneratorExclude");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneratorExclude>.NativeClassPtr);
			GeneratorExclude.NativeFieldInfoPtr_ExcludeItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorExclude>.NativeClassPtr, "ExcludeItem");
			GeneratorExclude.NativeFieldInfoPtr_targetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorExclude>.NativeClassPtr, "targetIndex");
			GeneratorExclude.NativeFieldInfoPtr_exclude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorExclude>.NativeClassPtr, "exclude");
			GeneratorExclude.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratorExclude>.NativeClassPtr, 100666228);
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x000C6D7C File Offset: 0x000C4F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100482, XrefRangeEnd = 100490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GeneratorExclude() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneratorExclude>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratorExclude.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0000FA99 File Offset: 0x0000DC99
		public GeneratorExclude(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x000C6DB8 File Offset: 0x000C4FB8
		// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x0000FAA2 File Offset: 0x0000DCA2
		public unsafe ExcludeItem ExcludeItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneratorExclude.NativeFieldInfoPtr_ExcludeItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneratorExclude.NativeFieldInfoPtr_ExcludeItem)) = value;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x000C6DE0 File Offset: 0x000C4FE0
		// (set) Token: 0x06001BAB RID: 7083 RVA: 0x0000FABD File Offset: 0x0000DCBD
		public unsafe int targetIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneratorExclude.NativeFieldInfoPtr_targetIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneratorExclude.NativeFieldInfoPtr_targetIndex)) = value;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x000C6E08 File Offset: 0x000C5008
		// (set) Token: 0x06001BAD RID: 7085 RVA: 0x0000FAD8 File Offset: 0x0000DCD8
		public unsafe List<ExcludeIndexes> exclude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneratorExclude.NativeFieldInfoPtr_exclude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ExcludeIndexes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneratorExclude.NativeFieldInfoPtr_exclude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeFieldInfoPtr_ExcludeItem;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeFieldInfoPtr_targetIndex;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeFieldInfoPtr_exclude;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
