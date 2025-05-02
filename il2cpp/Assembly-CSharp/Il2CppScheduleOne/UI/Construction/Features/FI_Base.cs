using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Construction.Features;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI.Construction.Features
{
	// Token: 0x02000723 RID: 1827
	public class FI_Base : MonoBehaviour
	{
		// Token: 0x0600A491 RID: 42129 RVA: 0x00293ACC File Offset: 0x00291CCC
		// Note: this type is marked as 'beforefieldinit'.
		static FI_Base()
		{
			Il2CppClassPointerStore<FI_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Construction.Features", "FI_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FI_Base>.NativeClassPtr);
			FI_Base.NativeFieldInfoPtr_feature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_Base>.NativeClassPtr, "feature");
			FI_Base.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_Base>.NativeClassPtr, "onClose");
			FI_Base.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Feature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_Base>.NativeClassPtr, 100683403);
			FI_Base.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_Base>.NativeClassPtr, 100683404);
			FI_Base.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_Base>.NativeClassPtr, 100683405);
		}

		// Token: 0x0600A492 RID: 42130 RVA: 0x00293B60 File Offset: 0x00291D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(Feature _feature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_feature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FI_Base.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Feature_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A493 RID: 42131 RVA: 0x00293BB0 File Offset: 0x00291DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287990, XrefRangeEnd = 287996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FI_Base.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A494 RID: 42132 RVA: 0x00293BEC File Offset: 0x00291DEC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FI_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FI_Base>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_Base.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A495 RID: 42133 RVA: 0x00051217 File Offset: 0x0004F417
		public FI_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032C6 RID: 12998
		// (get) Token: 0x0600A496 RID: 42134 RVA: 0x00293C28 File Offset: 0x00291E28
		// (set) Token: 0x0600A497 RID: 42135 RVA: 0x00051220 File Offset: 0x0004F420
		public unsafe Feature feature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_Base.NativeFieldInfoPtr_feature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Feature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_Base.NativeFieldInfoPtr_feature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C7 RID: 12999
		// (get) Token: 0x0600A498 RID: 42136 RVA: 0x00293C58 File Offset: 0x00291E58
		// (set) Token: 0x0600A499 RID: 42137 RVA: 0x0005123F File Offset: 0x0004F43F
		public unsafe UnityEvent onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_Base.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_Base.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006E52 RID: 28242
		private static readonly IntPtr NativeFieldInfoPtr_feature;

		// Token: 0x04006E53 RID: 28243
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x04006E54 RID: 28244
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Feature_0;

		// Token: 0x04006E55 RID: 28245
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04006E56 RID: 28246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
