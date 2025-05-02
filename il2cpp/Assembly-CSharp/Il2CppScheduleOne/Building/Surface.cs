using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004C4 RID: 1220
	public class Surface : MonoBehaviour
	{
		// Token: 0x06006AD0 RID: 27344 RVA: 0x001DCBF4 File Offset: 0x001DADF4
		// Note: this type is marked as 'beforefieldinit'.
		static Surface()
		{
			Il2CppClassPointerStore<Surface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "Surface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Surface>.NativeClassPtr);
			Surface.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "<GUID>k__BackingField");
			Surface.NativeFieldInfoPtr_SurfaceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "SurfaceType");
			Surface.NativeFieldInfoPtr_ValidFaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "ValidFaces");
			Surface.NativeFieldInfoPtr_ParentProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "ParentProperty");
			Surface.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "BakedGUID");
			Surface.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676836);
			Surface.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676837);
			Surface.NativeMethodInfoPtr_get_Container_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676838);
			Surface.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676839);
			Surface.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676840);
			Surface.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676841);
			Surface.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676842);
			Surface.NativeMethodInfoPtr_GetRelativePosition_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676843);
			Surface.NativeMethodInfoPtr_GetRelativeRotation_Public_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676844);
			Surface.NativeMethodInfoPtr_IsFrontFace_Public_Boolean_Vector3_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676845);
			Surface.NativeMethodInfoPtr_IsPointValid_Public_Boolean_Vector3_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676846);
			Surface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676847);
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x06006AD1 RID: 27345 RVA: 0x001DCD78 File Offset: 0x001DAF78
		// (set) Token: 0x06006AD2 RID: 27346 RVA: 0x001DCDB4 File Offset: 0x001DAFB4
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x06006AD3 RID: 27347 RVA: 0x001DCDF4 File Offset: 0x001DAFF4
		public unsafe Transform Container
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215468, XrefRangeEnd = 215470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_get_Container_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06006AD4 RID: 27348 RVA: 0x001DCE34 File Offset: 0x001DB034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215470, XrefRangeEnd = 215473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD5 RID: 27349 RVA: 0x001DCE68 File Offset: 0x001DB068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215473, XrefRangeEnd = 215485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD6 RID: 27350 RVA: 0x001DCE9C File Offset: 0x001DB09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215485, XrefRangeEnd = 215514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Surface.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD7 RID: 27351 RVA: 0x001DCED8 File Offset: 0x001DB0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215514, XrefRangeEnd = 215518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD8 RID: 27352 RVA: 0x001DCF18 File Offset: 0x001DB118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215518, XrefRangeEnd = 215520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRelativePosition(Vector3 worldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_GetRelativePosition_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006AD9 RID: 27353 RVA: 0x001DCF64 File Offset: 0x001DB164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215523, RefRangeEnd = 215524, XrefRangeStart = 215520, XrefRangeEnd = 215523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion GetRelativeRotation(Quaternion worldRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_GetRelativeRotation_Public_Quaternion_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x001DCFB0 File Offset: 0x001DB1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215524, XrefRangeEnd = 215526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFrontFace(Vector3 point, Collider collider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_IsFrontFace_Public_Boolean_Vector3_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006ADB RID: 27355 RVA: 0x001DD00C File Offset: 0x001DB20C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215564, RefRangeEnd = 215566, XrefRangeStart = 215526, XrefRangeEnd = 215564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointValid(Vector3 point, Collider hitCollider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hitCollider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_IsPointValid_Public_Boolean_Vector3_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006ADC RID: 27356 RVA: 0x001DD068 File Offset: 0x001DB268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215566, XrefRangeEnd = 215583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Surface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Surface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ADD RID: 27357 RVA: 0x0003282D File Offset: 0x00030A2D
		public Surface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x06006ADE RID: 27358 RVA: 0x001DD0A4 File Offset: 0x001DB2A4
		// (set) Token: 0x06006ADF RID: 27359 RVA: 0x00032836 File Offset: 0x00030A36
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x06006AE0 RID: 27360 RVA: 0x001DD0CC File Offset: 0x001DB2CC
		// (set) Token: 0x06006AE1 RID: 27361 RVA: 0x00032851 File Offset: 0x00030A51
		public unsafe Surface.ESurfaceType SurfaceType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_SurfaceType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_SurfaceType)) = value;
			}
		}

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x06006AE2 RID: 27362 RVA: 0x001DD0F4 File Offset: 0x001DB2F4
		// (set) Token: 0x06006AE3 RID: 27363 RVA: 0x0003286C File Offset: 0x00030A6C
		public unsafe List<Surface.EFace> ValidFaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_ValidFaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Surface.EFace>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_ValidFaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x06006AE4 RID: 27364 RVA: 0x001DD124 File Offset: 0x001DB324
		// (set) Token: 0x06006AE5 RID: 27365 RVA: 0x0003288B File Offset: 0x00030A8B
		public unsafe Property ParentProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_ParentProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_ParentProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x06006AE6 RID: 27366 RVA: 0x001DD154 File Offset: 0x001DB354
		// (set) Token: 0x06006AE7 RID: 27367 RVA: 0x000328AA File Offset: 0x00030AAA
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004919 RID: 18713
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x0400491A RID: 18714
		private static readonly IntPtr NativeFieldInfoPtr_SurfaceType;

		// Token: 0x0400491B RID: 18715
		private static readonly IntPtr NativeFieldInfoPtr_ValidFaces;

		// Token: 0x0400491C RID: 18716
		private static readonly IntPtr NativeFieldInfoPtr_ParentProperty;

		// Token: 0x0400491D RID: 18717
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x0400491E RID: 18718
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x0400491F RID: 18719
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04004920 RID: 18720
		private static readonly IntPtr NativeMethodInfoPtr_get_Container_Public_get_Transform_0;

		// Token: 0x04004921 RID: 18721
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x04004922 RID: 18722
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04004923 RID: 18723
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004924 RID: 18724
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04004925 RID: 18725
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativePosition_Public_Vector3_Vector3_0;

		// Token: 0x04004926 RID: 18726
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativeRotation_Public_Quaternion_Quaternion_0;

		// Token: 0x04004927 RID: 18727
		private static readonly IntPtr NativeMethodInfoPtr_IsFrontFace_Public_Boolean_Vector3_Collider_0;

		// Token: 0x04004928 RID: 18728
		private static readonly IntPtr NativeMethodInfoPtr_IsPointValid_Public_Boolean_Vector3_Collider_0;

		// Token: 0x04004929 RID: 18729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A57 RID: 2647
		[OriginalName("Assembly-CSharp.dll", "", "ESurfaceType")]
		public enum ESurfaceType
		{
			// Token: 0x04008CAB RID: 36011
			Wall,
			// Token: 0x04008CAC RID: 36012
			Roof
		}

		// Token: 0x02000A58 RID: 2648
		[OriginalName("Assembly-CSharp.dll", "", "EFace")]
		public enum EFace
		{
			// Token: 0x04008CAE RID: 36014
			Front,
			// Token: 0x04008CAF RID: 36015
			Back,
			// Token: 0x04008CB0 RID: 36016
			Top,
			// Token: 0x04008CB1 RID: 36017
			Bottom,
			// Token: 0x04008CB2 RID: 36018
			Left,
			// Token: 0x04008CB3 RID: 36019
			Right
		}
	}
}
