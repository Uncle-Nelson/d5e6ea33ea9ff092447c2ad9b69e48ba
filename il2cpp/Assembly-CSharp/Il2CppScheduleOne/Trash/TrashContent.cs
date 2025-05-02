using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000521 RID: 1313
	[Serializable]
	public class TrashContent : Object
	{
		// Token: 0x060074E9 RID: 29929 RVA: 0x001FD4EC File Offset: 0x001FB6EC
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContent()
		{
			Il2CppClassPointerStore<TrashContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent>.NativeClassPtr);
			TrashContent.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "Entries");
			TrashContent.NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677991);
			TrashContent.NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677992);
			TrashContent.NativeMethodInfoPtr_GetTrashQuantity_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677993);
			TrashContent.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677994);
			TrashContent.NativeMethodInfoPtr_GetTotalSize_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677995);
			TrashContent.NativeMethodInfoPtr_GetData_Public_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677996);
			TrashContent.NativeMethodInfoPtr_LoadFromData_Public_Void_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677997);
			TrashContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677998);
		}

		// Token: 0x060074EA RID: 29930 RVA: 0x001FD5D0 File Offset: 0x001FB7D0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 228443, RefRangeEnd = 228449, XrefRangeStart = 228405, XrefRangeEnd = 228443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrash(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074EB RID: 29931 RVA: 0x001FD620 File Offset: 0x001FB820
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228466, RefRangeEnd = 228467, XrefRangeStart = 228449, XrefRangeEnd = 228466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrash(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074EC RID: 29932 RVA: 0x001FD670 File Offset: 0x001FB870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228467, XrefRangeEnd = 228481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTrashQuantity(string trashID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_GetTrashQuantity_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060074ED RID: 29933 RVA: 0x001FD6C0 File Offset: 0x001FB8C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228483, RefRangeEnd = 228484, XrefRangeStart = 228481, XrefRangeEnd = 228483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074EE RID: 29934 RVA: 0x001FD6F4 File Offset: 0x001FB8F4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 228498, RefRangeEnd = 228509, XrefRangeStart = 228484, XrefRangeEnd = 228498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_GetTotalSize_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060074EF RID: 29935 RVA: 0x001FD730 File Offset: 0x001FB930
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 228529, RefRangeEnd = 228536, XrefRangeStart = 228509, XrefRangeEnd = 228529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContentData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_GetData_Public_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashContentData>(intPtr3) : null;
		}

		// Token: 0x060074F0 RID: 29936 RVA: 0x001FD770 File Offset: 0x001FB970
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 228538, RefRangeEnd = 228541, XrefRangeStart = 228536, XrefRangeEnd = 228538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadFromData(TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_LoadFromData_Public_Void_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F1 RID: 29937 RVA: 0x001FD7B4 File Offset: 0x001FB9B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 228549, RefRangeEnd = 228553, XrefRangeStart = 228541, XrefRangeEnd = 228549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F2 RID: 29938 RVA: 0x000377E3 File Offset: 0x000359E3
		public TrashContent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700236A RID: 9066
		// (get) Token: 0x060074F3 RID: 29939 RVA: 0x001FD7F0 File Offset: 0x001FB9F0
		// (set) Token: 0x060074F4 RID: 29940 RVA: 0x000377EC File Offset: 0x000359EC
		public unsafe List<TrashContent.Entry> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashContent.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004FD5 RID: 20437
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x04004FD6 RID: 20438
		private static readonly IntPtr NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0;

		// Token: 0x04004FD7 RID: 20439
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0;

		// Token: 0x04004FD8 RID: 20440
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashQuantity_Public_Int32_String_0;

		// Token: 0x04004FD9 RID: 20441
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04004FDA RID: 20442
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalSize_Public_Int32_0;

		// Token: 0x04004FDB RID: 20443
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_TrashContentData_0;

		// Token: 0x04004FDC RID: 20444
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromData_Public_Void_TrashContentData_0;

		// Token: 0x04004FDD RID: 20445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A8E RID: 2702
		[Serializable]
		public class Entry : Object
		{
			// Token: 0x0600D27B RID: 53883 RVA: 0x00325AA0 File Offset: 0x00323CA0
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr);
				TrashContent.Entry.NativeFieldInfoPtr_TrashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, "TrashID");
				TrashContent.Entry.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, "Quantity");
				TrashContent.Entry.NativeFieldInfoPtr__UnitSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, "<UnitSize>k__BackingField");
				TrashContent.Entry.NativeFieldInfoPtr__UnitValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, "<UnitValue>k__BackingField");
				TrashContent.Entry.NativeMethodInfoPtr_get_UnitSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100677999);
				TrashContent.Entry.NativeMethodInfoPtr_set_UnitSize_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100678000);
				TrashContent.Entry.NativeMethodInfoPtr_get_UnitValue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100678001);
				TrashContent.Entry.NativeMethodInfoPtr_set_UnitValue_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100678002);
				TrashContent.Entry.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100678003);
			}

			// Token: 0x17004152 RID: 16722
			// (get) Token: 0x0600D27C RID: 53884 RVA: 0x00325B80 File Offset: 0x00323D80
			// (set) Token: 0x0600D27D RID: 53885 RVA: 0x00325BBC File Offset: 0x00323DBC
			public unsafe int UnitSize
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr_get_UnitSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 41641, RefRangeEnd = 41642, XrefRangeStart = 41641, XrefRangeEnd = 41642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr_set_UnitSize_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004153 RID: 16723
			// (get) Token: 0x0600D27E RID: 53886 RVA: 0x00325BFC File Offset: 0x00323DFC
			// (set) Token: 0x0600D27F RID: 53887 RVA: 0x00325C38 File Offset: 0x00323E38
			public unsafe int UnitValue
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 20564, RefRangeEnd = 20565, XrefRangeStart = 20564, XrefRangeEnd = 20565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr_get_UnitValue_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 29976, RefRangeEnd = 29977, XrefRangeStart = 29976, XrefRangeEnd = 29977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr_set_UnitValue_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600D280 RID: 53888 RVA: 0x00325C78 File Offset: 0x00323E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228394, XrefRangeEnd = 228405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry(string id, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D281 RID: 53889 RVA: 0x00066771 File Offset: 0x00064971
			public Entry(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700414E RID: 16718
			// (get) Token: 0x0600D282 RID: 53890 RVA: 0x00325CD4 File Offset: 0x00323ED4
			// (set) Token: 0x0600D283 RID: 53891 RVA: 0x0006677A File Offset: 0x0006497A
			public unsafe string TrashID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr_TrashID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr_TrashID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700414F RID: 16719
			// (get) Token: 0x0600D284 RID: 53892 RVA: 0x00325CFC File Offset: 0x00323EFC
			// (set) Token: 0x0600D285 RID: 53893 RVA: 0x00066799 File Offset: 0x00064999
			public unsafe int Quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x17004150 RID: 16720
			// (get) Token: 0x0600D286 RID: 53894 RVA: 0x00325D24 File Offset: 0x00323F24
			// (set) Token: 0x0600D287 RID: 53895 RVA: 0x000667B4 File Offset: 0x000649B4
			public unsafe int _UnitSize_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr__UnitSize_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr__UnitSize_k__BackingField)) = value;
				}
			}

			// Token: 0x17004151 RID: 16721
			// (get) Token: 0x0600D288 RID: 53896 RVA: 0x00325D4C File Offset: 0x00323F4C
			// (set) Token: 0x0600D289 RID: 53897 RVA: 0x000667CF File Offset: 0x000649CF
			public unsafe int _UnitValue_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr__UnitValue_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr__UnitValue_k__BackingField)) = value;
				}
			}

			// Token: 0x04008DF0 RID: 36336
			private static readonly IntPtr NativeFieldInfoPtr_TrashID;

			// Token: 0x04008DF1 RID: 36337
			private static readonly IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x04008DF2 RID: 36338
			private static readonly IntPtr NativeFieldInfoPtr__UnitSize_k__BackingField;

			// Token: 0x04008DF3 RID: 36339
			private static readonly IntPtr NativeFieldInfoPtr__UnitValue_k__BackingField;

			// Token: 0x04008DF4 RID: 36340
			private static readonly IntPtr NativeMethodInfoPtr_get_UnitSize_Public_get_Int32_0;

			// Token: 0x04008DF5 RID: 36341
			private static readonly IntPtr NativeMethodInfoPtr_set_UnitSize_Private_set_Void_Int32_0;

			// Token: 0x04008DF6 RID: 36342
			private static readonly IntPtr NativeMethodInfoPtr_get_UnitValue_Public_get_Int32_0;

			// Token: 0x04008DF7 RID: 36343
			private static readonly IntPtr NativeMethodInfoPtr_set_UnitValue_Private_set_Void_Int32_0;

			// Token: 0x04008DF8 RID: 36344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
		}

		// Token: 0x02000A8F RID: 2703
		[ObfuscatedName("ScheduleOne.Trash.TrashContent+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600D28A RID: 53898 RVA: 0x00325D74 File Offset: 0x00323F74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr);
				TrashContent.__c__DisplayClass2_0.NativeFieldInfoPtr_trashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr, "trashID");
				TrashContent.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr, 100678004);
				TrashContent.__c__DisplayClass2_0.NativeMethodInfoPtr__AddTrash_b__0_Internal_Boolean_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr, 100678005);
			}

			// Token: 0x0600D28B RID: 53899 RVA: 0x00325DDC File Offset: 0x00323FDC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D28C RID: 53900 RVA: 0x00325E18 File Offset: 0x00324018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddTrash_b__0(TrashContent.Entry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass2_0.NativeMethodInfoPtr__AddTrash_b__0_Internal_Boolean_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D28D RID: 53901 RVA: 0x000667EA File Offset: 0x000649EA
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004154 RID: 16724
			// (get) Token: 0x0600D28E RID: 53902 RVA: 0x00325E68 File Offset: 0x00324068
			// (set) Token: 0x0600D28F RID: 53903 RVA: 0x000667F3 File Offset: 0x000649F3
			public unsafe string trashID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass2_0.NativeFieldInfoPtr_trashID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass2_0.NativeFieldInfoPtr_trashID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008DF9 RID: 36345
			private static readonly IntPtr NativeFieldInfoPtr_trashID;

			// Token: 0x04008DFA RID: 36346
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DFB RID: 36347
			private static readonly IntPtr NativeMethodInfoPtr__AddTrash_b__0_Internal_Boolean_Entry_0;
		}

		// Token: 0x02000A90 RID: 2704
		[ObfuscatedName("ScheduleOne.Trash.TrashContent+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600D290 RID: 53904 RVA: 0x00325E90 File Offset: 0x00324090
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr);
				TrashContent.__c__DisplayClass3_0.NativeFieldInfoPtr_trashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr, "trashID");
				TrashContent.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr, 100678006);
				TrashContent.__c__DisplayClass3_0.NativeMethodInfoPtr__RemoveTrash_b__0_Internal_Boolean_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr, 100678007);
			}

			// Token: 0x0600D291 RID: 53905 RVA: 0x00325EF8 File Offset: 0x003240F8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D292 RID: 53906 RVA: 0x00325F34 File Offset: 0x00324134
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveTrash_b__0(TrashContent.Entry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass3_0.NativeMethodInfoPtr__RemoveTrash_b__0_Internal_Boolean_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D293 RID: 53907 RVA: 0x00066812 File Offset: 0x00064A12
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004155 RID: 16725
			// (get) Token: 0x0600D294 RID: 53908 RVA: 0x00325F84 File Offset: 0x00324184
			// (set) Token: 0x0600D295 RID: 53909 RVA: 0x0006681B File Offset: 0x00064A1B
			public unsafe string trashID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass3_0.NativeFieldInfoPtr_trashID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass3_0.NativeFieldInfoPtr_trashID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008DFC RID: 36348
			private static readonly IntPtr NativeFieldInfoPtr_trashID;

			// Token: 0x04008DFD RID: 36349
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DFE RID: 36350
			private static readonly IntPtr NativeMethodInfoPtr__RemoveTrash_b__0_Internal_Boolean_Entry_0;
		}

		// Token: 0x02000A91 RID: 2705
		[ObfuscatedName("ScheduleOne.Trash.TrashContent+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600D296 RID: 53910 RVA: 0x00325FAC File Offset: 0x003241AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr);
				TrashContent.__c__DisplayClass4_0.NativeFieldInfoPtr_trashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr, "trashID");
				TrashContent.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr, 100678008);
				TrashContent.__c__DisplayClass4_0.NativeMethodInfoPtr__GetTrashQuantity_b__0_Internal_Boolean_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr, 100678009);
			}

			// Token: 0x0600D297 RID: 53911 RVA: 0x00326014 File Offset: 0x00324214
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D298 RID: 53912 RVA: 0x00326050 File Offset: 0x00324250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTrashQuantity_b__0(TrashContent.Entry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass4_0.NativeMethodInfoPtr__GetTrashQuantity_b__0_Internal_Boolean_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D299 RID: 53913 RVA: 0x0006683A File Offset: 0x00064A3A
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004156 RID: 16726
			// (get) Token: 0x0600D29A RID: 53914 RVA: 0x003260A0 File Offset: 0x003242A0
			// (set) Token: 0x0600D29B RID: 53915 RVA: 0x00066843 File Offset: 0x00064A43
			public unsafe string trashID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass4_0.NativeFieldInfoPtr_trashID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass4_0.NativeFieldInfoPtr_trashID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008DFF RID: 36351
			private static readonly IntPtr NativeFieldInfoPtr_trashID;

			// Token: 0x04008E00 RID: 36352
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E01 RID: 36353
			private static readonly IntPtr NativeMethodInfoPtr__GetTrashQuantity_b__0_Internal_Boolean_Entry_0;
		}
	}
}
