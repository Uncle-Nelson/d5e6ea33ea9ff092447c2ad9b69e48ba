using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004C1 RID: 1217
	public class BuildUpdate_Surface : BuildUpdate_Base
	{
		// Token: 0x06006AA6 RID: 27302 RVA: 0x001DC410 File Offset: 0x001DA610
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_Surface()
		{
			Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_Surface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr);
			BuildUpdate_Surface.NativeFieldInfoPtr_GhostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "GhostModel");
			BuildUpdate_Surface.NativeFieldInfoPtr_BuildableItemClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "BuildableItemClass");
			BuildUpdate_Surface.NativeFieldInfoPtr_ItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "ItemInstance");
			BuildUpdate_Surface.NativeFieldInfoPtr_CurrentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "CurrentRotation");
			BuildUpdate_Surface.NativeFieldInfoPtr_DetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "DetectionMask");
			BuildUpdate_Surface.NativeFieldInfoPtr_validPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "validPosition");
			BuildUpdate_Surface.NativeFieldInfoPtr_currentGhostMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "currentGhostMaterial");
			BuildUpdate_Surface.NativeFieldInfoPtr_hoveredValidSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "hoveredValidSurface");
			BuildUpdate_Surface.NativeMethodInfoPtr_get_detectionRange_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676822);
			BuildUpdate_Surface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676823);
			BuildUpdate_Surface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676824);
			BuildUpdate_Surface.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676825);
			BuildUpdate_Surface.NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676826);
			BuildUpdate_Surface.NativeMethodInfoPtr_IsSurfaceValidForItem_Private_Boolean_Surface_Collider_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676827);
			BuildUpdate_Surface.NativeMethodInfoPtr_CheckRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676828);
			BuildUpdate_Surface.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676829);
			BuildUpdate_Surface.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676830);
			BuildUpdate_Surface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676831);
		}

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x06006AA7 RID: 27303 RVA: 0x001DC5A8 File Offset: 0x001DA7A8
		public unsafe float detectionRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_get_detectionRange_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006AA8 RID: 27304 RVA: 0x001DC5E4 File Offset: 0x001DA7E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 38038, RefRangeEnd = 38043, XrefRangeStart = 38038, XrefRangeEnd = 38043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Surface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AA9 RID: 27305 RVA: 0x001DC620 File Offset: 0x001DA820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215185, XrefRangeEnd = 215203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Surface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AAA RID: 27306 RVA: 0x001DC65C File Offset: 0x001DA85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215203, XrefRangeEnd = 215295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Surface.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AAB RID: 27307 RVA: 0x001DC698 File Offset: 0x001DA898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215355, RefRangeEnd = 215356, XrefRangeStart = 215295, XrefRangeEnd = 215355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionObjectInFrontOfPlayer(float dist, bool sanitizeForward)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dist;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sanitizeForward;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AAC RID: 27308 RVA: 0x001DC6E4 File Offset: 0x001DA8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215356, XrefRangeEnd = 215368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSurfaceValidForItem(Surface surface, Collider hitCollider, Vector3 hitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(surface);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hitCollider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_IsSurfaceValidForItem_Private_Boolean_Surface_Collider_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006AAD RID: 27309 RVA: 0x001DC754 File Offset: 0x001DA954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215368, XrefRangeEnd = 215381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_CheckRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AAE RID: 27310 RVA: 0x001DC788 File Offset: 0x001DA988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215397, RefRangeEnd = 215398, XrefRangeStart = 215381, XrefRangeEnd = 215397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AAF RID: 27311 RVA: 0x001DC7BC File Offset: 0x001DA9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215398, XrefRangeEnd = 215433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Place()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Surface.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AB0 RID: 27312 RVA: 0x001DC7F8 File Offset: 0x001DA9F8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19447, RefRangeEnd = 19461, XrefRangeStart = 19447, XrefRangeEnd = 19461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_Surface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AB1 RID: 27313 RVA: 0x00032698 File Offset: 0x00030898
		public BuildUpdate_Surface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x06006AB2 RID: 27314 RVA: 0x001DC834 File Offset: 0x001DAA34
		// (set) Token: 0x06006AB3 RID: 27315 RVA: 0x000326A1 File Offset: 0x000308A1
		public unsafe GameObject GhostModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_GhostModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_GhostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x06006AB4 RID: 27316 RVA: 0x001DC864 File Offset: 0x001DAA64
		// (set) Token: 0x06006AB5 RID: 27317 RVA: 0x000326C0 File Offset: 0x000308C0
		public unsafe SurfaceItem BuildableItemClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_BuildableItemClass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SurfaceItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_BuildableItemClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x06006AB6 RID: 27318 RVA: 0x001DC894 File Offset: 0x001DAA94
		// (set) Token: 0x06006AB7 RID: 27319 RVA: 0x000326DF File Offset: 0x000308DF
		public unsafe ItemInstance ItemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_ItemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_ItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x06006AB8 RID: 27320 RVA: 0x001DC8C4 File Offset: 0x001DAAC4
		// (set) Token: 0x06006AB9 RID: 27321 RVA: 0x000326FE File Offset: 0x000308FE
		public unsafe float CurrentRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_CurrentRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_CurrentRotation)) = value;
			}
		}

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x06006ABA RID: 27322 RVA: 0x001DC8EC File Offset: 0x001DAAEC
		// (set) Token: 0x06006ABB RID: 27323 RVA: 0x00032719 File Offset: 0x00030919
		public unsafe LayerMask DetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_DetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_DetectionMask)) = value;
			}
		}

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x06006ABC RID: 27324 RVA: 0x001DC914 File Offset: 0x001DAB14
		// (set) Token: 0x06006ABD RID: 27325 RVA: 0x00032734 File Offset: 0x00030934
		public unsafe bool validPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_validPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_validPosition)) = value;
			}
		}

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x06006ABE RID: 27326 RVA: 0x001DC93C File Offset: 0x001DAB3C
		// (set) Token: 0x06006ABF RID: 27327 RVA: 0x0003274F File Offset: 0x0003094F
		public unsafe Material currentGhostMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_currentGhostMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_currentGhostMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x06006AC0 RID: 27328 RVA: 0x001DC96C File Offset: 0x001DAB6C
		// (set) Token: 0x06006AC1 RID: 27329 RVA: 0x0003276E File Offset: 0x0003096E
		public unsafe Surface hoveredValidSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_hoveredValidSurface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Surface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_hoveredValidSurface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004900 RID: 18688
		private static readonly IntPtr NativeFieldInfoPtr_GhostModel;

		// Token: 0x04004901 RID: 18689
		private static readonly IntPtr NativeFieldInfoPtr_BuildableItemClass;

		// Token: 0x04004902 RID: 18690
		private static readonly IntPtr NativeFieldInfoPtr_ItemInstance;

		// Token: 0x04004903 RID: 18691
		private static readonly IntPtr NativeFieldInfoPtr_CurrentRotation;

		// Token: 0x04004904 RID: 18692
		private static readonly IntPtr NativeFieldInfoPtr_DetectionMask;

		// Token: 0x04004905 RID: 18693
		private static readonly IntPtr NativeFieldInfoPtr_validPosition;

		// Token: 0x04004906 RID: 18694
		private static readonly IntPtr NativeFieldInfoPtr_currentGhostMaterial;

		// Token: 0x04004907 RID: 18695
		private static readonly IntPtr NativeFieldInfoPtr_hoveredValidSurface;

		// Token: 0x04004908 RID: 18696
		private static readonly IntPtr NativeMethodInfoPtr_get_detectionRange_Private_get_Single_0;

		// Token: 0x04004909 RID: 18697
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x0400490A RID: 18698
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400490B RID: 18699
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400490C RID: 18700
		private static readonly IntPtr NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_0;

		// Token: 0x0400490D RID: 18701
		private static readonly IntPtr NativeMethodInfoPtr_IsSurfaceValidForItem_Private_Boolean_Surface_Collider_Vector3_0;

		// Token: 0x0400490E RID: 18702
		private static readonly IntPtr NativeMethodInfoPtr_CheckRotation_Protected_Void_0;

		// Token: 0x0400490F RID: 18703
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0;

		// Token: 0x04004910 RID: 18704
		private static readonly IntPtr NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0;

		// Token: 0x04004911 RID: 18705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
