using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200071B RID: 1819
	public class ProductItemInfoContent : QualityItemInfoContent
	{
		// Token: 0x0600A3C6 RID: 41926 RVA: 0x002913CC File Offset: 0x0028F5CC
		// Note: this type is marked as 'beforefieldinit'.
		static ProductItemInfoContent()
		{
			Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ProductItemInfoContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr);
			ProductItemInfoContent.NativeFieldInfoPtr_PropertyLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr, "PropertyLabels");
			ProductItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr, 100683320);
			ProductItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr, 100683321);
			ProductItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr, 100683322);
		}

		// Token: 0x0600A3C7 RID: 41927 RVA: 0x0029144C File Offset: 0x0028F64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286780, XrefRangeEnd = 286790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3C8 RID: 41928 RVA: 0x0029149C File Offset: 0x0028F69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286790, XrefRangeEnd = 286821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(ItemDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3C9 RID: 41929 RVA: 0x002914EC File Offset: 0x0028F6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286821, XrefRangeEnd = 286829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductItemInfoContent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3CA RID: 41930 RVA: 0x00050ADB File Offset: 0x0004ECDB
		public ProductItemInfoContent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003286 RID: 12934
		// (get) Token: 0x0600A3CB RID: 41931 RVA: 0x00291528 File Offset: 0x0028F728
		// (set) Token: 0x0600A3CC RID: 41932 RVA: 0x00050AE4 File Offset: 0x0004ECE4
		public unsafe List<TextMeshProUGUI> PropertyLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInfoContent.NativeFieldInfoPtr_PropertyLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInfoContent.NativeFieldInfoPtr_PropertyLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006DD2 RID: 28114
		private static readonly IntPtr NativeFieldInfoPtr_PropertyLabels;

		// Token: 0x04006DD3 RID: 28115
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006DD4 RID: 28116
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemDefinition_0;

		// Token: 0x04006DD5 RID: 28117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
