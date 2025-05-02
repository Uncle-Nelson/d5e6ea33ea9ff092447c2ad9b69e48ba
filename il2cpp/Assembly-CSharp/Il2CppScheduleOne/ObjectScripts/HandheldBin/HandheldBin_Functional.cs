using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.HandheldBin
{
	// Token: 0x0200075F RID: 1887
	public class HandheldBin_Functional : MonoBehaviour
	{
		// Token: 0x0600B371 RID: 45937 RVA: 0x002CC0B4 File Offset: 0x002CA2B4
		// Note: this type is marked as 'beforefieldinit'.
		static HandheldBin_Functional()
		{
			Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.HandheldBin", "HandheldBin_Functional");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr);
			HandheldBin_Functional.NativeFieldInfoPtr_trash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, "trash");
			HandheldBin_Functional.NativeFieldInfoPtr_trash_MinY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, "trash_MinY");
			HandheldBin_Functional.NativeFieldInfoPtr_trash_MaxY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, "trash_MaxY");
			HandheldBin_Functional.NativeFieldInfoPtr__fillLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, "<fillLevel>k__BackingField");
			HandheldBin_Functional.NativeMethodInfoPtr_get_fillLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, 100685422);
			HandheldBin_Functional.NativeMethodInfoPtr_set_fillLevel_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, 100685423);
			HandheldBin_Functional.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, 100685424);
			HandheldBin_Functional.NativeMethodInfoPtr_SetAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, 100685425);
			HandheldBin_Functional.NativeMethodInfoPtr_UpdateTrashVisuals_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, 100685426);
			HandheldBin_Functional.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, 100685427);
		}

		// Token: 0x170037A4 RID: 14244
		// (get) Token: 0x0600B372 RID: 45938 RVA: 0x002CC1AC File Offset: 0x002CA3AC
		// (set) Token: 0x0600B373 RID: 45939 RVA: 0x002CC1E8 File Offset: 0x002CA3E8
		public unsafe float fillLevel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30021, RefRangeEnd = 30022, XrefRangeStart = 30021, XrefRangeEnd = 30022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandheldBin_Functional.NativeMethodInfoPtr_get_fillLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30022, RefRangeEnd = 30024, XrefRangeStart = 30022, XrefRangeEnd = 30024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandheldBin_Functional.NativeMethodInfoPtr_set_fillLevel_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B374 RID: 45940 RVA: 0x002CC228 File Offset: 0x002CA428
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HandheldBin_Functional.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B375 RID: 45941 RVA: 0x002CC264 File Offset: 0x002CA464
		[CallerCount(0)]
		public unsafe void SetAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandheldBin_Functional.NativeMethodInfoPtr_SetAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B376 RID: 45942 RVA: 0x002CC2A4 File Offset: 0x002CA4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308889, XrefRangeEnd = 308892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateTrashVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HandheldBin_Functional.NativeMethodInfoPtr_UpdateTrashVisuals_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B377 RID: 45943 RVA: 0x002CC2E0 File Offset: 0x002CA4E0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandheldBin_Functional() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandheldBin_Functional.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B378 RID: 45944 RVA: 0x00057EEB File Offset: 0x000560EB
		public HandheldBin_Functional(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037A0 RID: 14240
		// (get) Token: 0x0600B379 RID: 45945 RVA: 0x002CC31C File Offset: 0x002CA51C
		// (set) Token: 0x0600B37A RID: 45946 RVA: 0x00057EF4 File Offset: 0x000560F4
		public unsafe Transform trash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr_trash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr_trash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037A1 RID: 14241
		// (get) Token: 0x0600B37B RID: 45947 RVA: 0x002CC34C File Offset: 0x002CA54C
		// (set) Token: 0x0600B37C RID: 45948 RVA: 0x00057F13 File Offset: 0x00056113
		public unsafe float trash_MinY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr_trash_MinY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr_trash_MinY)) = value;
			}
		}

		// Token: 0x170037A2 RID: 14242
		// (get) Token: 0x0600B37D RID: 45949 RVA: 0x002CC374 File Offset: 0x002CA574
		// (set) Token: 0x0600B37E RID: 45950 RVA: 0x00057F2E File Offset: 0x0005612E
		public unsafe float trash_MaxY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr_trash_MaxY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr_trash_MaxY)) = value;
			}
		}

		// Token: 0x170037A3 RID: 14243
		// (get) Token: 0x0600B37F RID: 45951 RVA: 0x002CC39C File Offset: 0x002CA59C
		// (set) Token: 0x0600B380 RID: 45952 RVA: 0x00057F49 File Offset: 0x00056149
		public unsafe float _fillLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr__fillLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr__fillLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x0400790D RID: 30989
		private static readonly IntPtr NativeFieldInfoPtr_trash;

		// Token: 0x0400790E RID: 30990
		private static readonly IntPtr NativeFieldInfoPtr_trash_MinY;

		// Token: 0x0400790F RID: 30991
		private static readonly IntPtr NativeFieldInfoPtr_trash_MaxY;

		// Token: 0x04007910 RID: 30992
		private static readonly IntPtr NativeFieldInfoPtr__fillLevel_k__BackingField;

		// Token: 0x04007911 RID: 30993
		private static readonly IntPtr NativeMethodInfoPtr_get_fillLevel_Public_get_Single_0;

		// Token: 0x04007912 RID: 30994
		private static readonly IntPtr NativeMethodInfoPtr_set_fillLevel_Protected_set_Void_Single_0;

		// Token: 0x04007913 RID: 30995
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04007914 RID: 30996
		private static readonly IntPtr NativeMethodInfoPtr_SetAmount_Public_Void_Single_0;

		// Token: 0x04007915 RID: 30997
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTrashVisuals_Protected_Virtual_New_Void_0;

		// Token: 0x04007916 RID: 30998
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
