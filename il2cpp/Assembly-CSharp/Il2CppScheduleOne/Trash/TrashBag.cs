using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x0200051D RID: 1309
	public class TrashBag : TrashItem
	{
		// Token: 0x06007495 RID: 29845 RVA: 0x001FC004 File Offset: 0x001FA204
		// Note: this type is marked as 'beforefieldinit'.
		static TrashBag()
		{
			Il2CppClassPointerStore<TrashBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashBag>.NativeClassPtr);
			TrashBag.NativeFieldInfoPtr__Content_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, "<Content>k__BackingField");
			TrashBag.NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100677945);
			TrashBag.NativeMethodInfoPtr_set_Content_Private_set_Void_TrashContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100677946);
			TrashBag.NativeMethodInfoPtr_LoadContent_Public_Void_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100677947);
			TrashBag.NativeMethodInfoPtr_GetData_Public_Virtual_TrashItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100677948);
			TrashBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag>.NativeClassPtr, 100677949);
		}

		// Token: 0x17002358 RID: 9048
		// (get) Token: 0x06007496 RID: 29846 RVA: 0x001FC0AC File Offset: 0x001FA2AC
		// (set) Token: 0x06007497 RID: 29847 RVA: 0x001FC0EC File Offset: 0x001FA2EC
		public unsafe TrashContent Content
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 43173, RefRangeEnd = 43174, XrefRangeStart = 43173, XrefRangeEnd = 43174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag.NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag.NativeMethodInfoPtr_set_Content_Private_set_Void_TrashContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007498 RID: 29848 RVA: 0x001FC130 File Offset: 0x001FA330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227882, RefRangeEnd = 227883, XrefRangeStart = 227880, XrefRangeEnd = 227882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadContent(TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag.NativeMethodInfoPtr_LoadContent_Public_Void_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007499 RID: 29849 RVA: 0x001FC174 File Offset: 0x001FA374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227883, XrefRangeEnd = 227893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TrashItemData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashBag.NativeMethodInfoPtr_GetData_Public_Virtual_TrashItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItemData>(intPtr3) : null;
		}

		// Token: 0x0600749A RID: 29850 RVA: 0x001FC1C0 File Offset: 0x001FA3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227893, XrefRangeEnd = 227917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashBag() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashBag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600749B RID: 29851 RVA: 0x000375FA File Offset: 0x000357FA
		public TrashBag(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002357 RID: 9047
		// (get) Token: 0x0600749C RID: 29852 RVA: 0x001FC1FC File Offset: 0x001FA3FC
		// (set) Token: 0x0600749D RID: 29853 RVA: 0x00037603 File Offset: 0x00035803
		public unsafe TrashContent _Content_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag.NativeFieldInfoPtr__Content_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag.NativeFieldInfoPtr__Content_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004F98 RID: 20376
		private static readonly IntPtr NativeFieldInfoPtr__Content_k__BackingField;

		// Token: 0x04004F99 RID: 20377
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0;

		// Token: 0x04004F9A RID: 20378
		private static readonly IntPtr NativeMethodInfoPtr_set_Content_Private_set_Void_TrashContent_0;

		// Token: 0x04004F9B RID: 20379
		private static readonly IntPtr NativeMethodInfoPtr_LoadContent_Public_Void_TrashContentData_0;

		// Token: 0x04004F9C RID: 20380
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_TrashItemData_0;

		// Token: 0x04004F9D RID: 20381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
