using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x0200014F RID: 335
	[Serializable]
	public class ExcludeIndexes : Object
	{
		// Token: 0x06001B9E RID: 7070 RVA: 0x000C6C04 File Offset: 0x000C4E04
		// Note: this type is marked as 'beforefieldinit'.
		static ExcludeIndexes()
		{
			Il2CppClassPointerStore<ExcludeIndexes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "ExcludeIndexes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeIndexes>.NativeClassPtr);
			ExcludeIndexes.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExcludeIndexes>.NativeClassPtr, "item");
			ExcludeIndexes.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExcludeIndexes>.NativeClassPtr, "index");
			ExcludeIndexes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeIndexes>.NativeClassPtr, 100666227);
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x000C6C70 File Offset: 0x000C4E70
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExcludeIndexes() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeIndexes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExcludeIndexes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x0000FA5A File Offset: 0x0000DC5A
		public ExcludeIndexes(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x000C6CAC File Offset: 0x000C4EAC
		// (set) Token: 0x06001BA2 RID: 7074 RVA: 0x0000FA63 File Offset: 0x0000DC63
		public unsafe ExcludeItem item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExcludeIndexes.NativeFieldInfoPtr_item);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExcludeIndexes.NativeFieldInfoPtr_item)) = value;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x000C6CD4 File Offset: 0x000C4ED4
		// (set) Token: 0x06001BA4 RID: 7076 RVA: 0x0000FA7E File Offset: 0x0000DC7E
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExcludeIndexes.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExcludeIndexes.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x04001230 RID: 4656
		private static readonly IntPtr NativeFieldInfoPtr_item;

		// Token: 0x04001231 RID: 4657
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
