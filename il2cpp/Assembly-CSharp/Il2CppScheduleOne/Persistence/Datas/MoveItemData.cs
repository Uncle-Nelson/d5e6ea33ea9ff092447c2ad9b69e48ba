using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000290 RID: 656
	[Serializable]
	public class MoveItemData : Object
	{
		// Token: 0x0600305D RID: 12381 RVA: 0x0010A374 File Offset: 0x00108574
		// Note: this type is marked as 'beforefieldinit'.
		static MoveItemData()
		{
			Il2CppClassPointerStore<MoveItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MoveItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr);
			MoveItemData.NativeFieldInfoPtr_TemplateItemJSON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, "TemplateItemJSON");
			MoveItemData.NativeFieldInfoPtr_GrabbedItemQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, "GrabbedItemQuantity");
			MoveItemData.NativeFieldInfoPtr_SourceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, "SourceGUID");
			MoveItemData.NativeFieldInfoPtr_DestinationGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, "DestinationGUID");
			MoveItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Guid_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, 100668808);
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x0010A408 File Offset: 0x00108608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130959, RefRangeEnd = 130960, XrefRangeStart = 130950, XrefRangeEnd = 130959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveItemData(string templateItemJson, int grabbedItemQuantity, Guid sourceGUID, Guid destinationGUID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(templateItemJson);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref grabbedItemQuantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceGUID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationGUID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Guid_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x00019B37 File Offset: 0x00017D37
		public MoveItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x06003060 RID: 12384 RVA: 0x0010A480 File Offset: 0x00108680
		// (set) Token: 0x06003061 RID: 12385 RVA: 0x00019B40 File Offset: 0x00017D40
		public unsafe string TemplateItemJSON
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_TemplateItemJSON);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_TemplateItemJSON), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x0010A4A8 File Offset: 0x001086A8
		// (set) Token: 0x06003063 RID: 12387 RVA: 0x00019B5F File Offset: 0x00017D5F
		public unsafe int GrabbedItemQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_GrabbedItemQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_GrabbedItemQuantity)) = value;
			}
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x0010A4D0 File Offset: 0x001086D0
		// (set) Token: 0x06003065 RID: 12389 RVA: 0x00019B7A File Offset: 0x00017D7A
		public unsafe string SourceGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_SourceGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_SourceGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06003066 RID: 12390 RVA: 0x0010A4F8 File Offset: 0x001086F8
		// (set) Token: 0x06003067 RID: 12391 RVA: 0x00019B99 File Offset: 0x00017D99
		public unsafe string DestinationGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_DestinationGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_DestinationGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001FAC RID: 8108
		private static readonly IntPtr NativeFieldInfoPtr_TemplateItemJSON;

		// Token: 0x04001FAD RID: 8109
		private static readonly IntPtr NativeFieldInfoPtr_GrabbedItemQuantity;

		// Token: 0x04001FAE RID: 8110
		private static readonly IntPtr NativeFieldInfoPtr_SourceGUID;

		// Token: 0x04001FAF RID: 8111
		private static readonly IntPtr NativeFieldInfoPtr_DestinationGUID;

		// Token: 0x04001FB0 RID: 8112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Guid_Guid_0;
	}
}
