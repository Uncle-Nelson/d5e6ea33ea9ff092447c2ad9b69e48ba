using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x0200048D RID: 1165
	public class ConstructUpdate_OutdoorGrid : ConstructUpdate_Base
	{
		// Token: 0x060064C6 RID: 25798 RVA: 0x001C7A14 File Offset: 0x001C5C14
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructUpdate_OutdoorGrid()
		{
			Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructUpdate_OutdoorGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr);
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "detectionMask");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_ConstructableClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "ConstructableClass");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_GhostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "GhostModel");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_validPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "validPosition");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_currentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "currentRotation");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_currentGhostMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "currentGhostMaterial");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_closestIntersection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "closestIntersection");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_listingPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "listingPrice");
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676064);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676065);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676066);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676067);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676068);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_CheckTileIntersections_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676069);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676070);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_AreMetaReqsMet_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676071);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_PlaceNewConstructable_Protected_Virtual_New_Constructable_GridBased_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676072);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_FinalizeMoveConstructable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676073);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676074);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676075);
		}

		// Token: 0x060064C7 RID: 25799 RVA: 0x001C7BD4 File Offset: 0x001C5DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204735, XrefRangeEnd = 204748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064C8 RID: 25800 RVA: 0x001C7C10 File Offset: 0x001C5E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204748, XrefRangeEnd = 204765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064C9 RID: 25801 RVA: 0x001C7C4C File Offset: 0x001C5E4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204784, RefRangeEnd = 204785, XrefRangeStart = 204765, XrefRangeEnd = 204784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064CA RID: 25802 RVA: 0x001C7C88 File Offset: 0x001C5E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204785, XrefRangeEnd = 204792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064CB RID: 25803 RVA: 0x001C7CBC File Offset: 0x001C5EBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204802, RefRangeEnd = 204803, XrefRangeStart = 204792, XrefRangeEnd = 204802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064CC RID: 25804 RVA: 0x001C7CF0 File Offset: 0x001C5EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204803, XrefRangeEnd = 204903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckTileIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_CheckTileIntersections_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064CD RID: 25805 RVA: 0x001C7D2C File Offset: 0x001C5F2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204921, RefRangeEnd = 204922, XrefRangeStart = 204903, XrefRangeEnd = 204921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064CE RID: 25806 RVA: 0x001C7D60 File Offset: 0x001C5F60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 204930, RefRangeEnd = 204933, XrefRangeStart = 204922, XrefRangeEnd = 204930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreMetaReqsMet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_AreMetaReqsMet_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060064CF RID: 25807 RVA: 0x001C7D9C File Offset: 0x001C5F9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204969, RefRangeEnd = 204970, XrefRangeStart = 204933, XrefRangeEnd = 204969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Constructable_GridBased PlaceNewConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_PlaceNewConstructable_Protected_Virtual_New_Constructable_GridBased_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr3) : null;
		}

		// Token: 0x060064D0 RID: 25808 RVA: 0x001C7DE8 File Offset: 0x001C5FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204970, XrefRangeEnd = 204984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FinalizeMoveConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_FinalizeMoveConstructable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064D1 RID: 25809 RVA: 0x001C7E24 File Offset: 0x001C6024
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204992, RefRangeEnd = 204994, XrefRangeStart = 204984, XrefRangeEnd = 204992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetOriginCoordinate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060064D2 RID: 25810 RVA: 0x001C7E60 File Offset: 0x001C6060
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructUpdate_OutdoorGrid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064D3 RID: 25811 RVA: 0x0002FA53 File Offset: 0x0002DC53
		public ConstructUpdate_OutdoorGrid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x060064D4 RID: 25812 RVA: 0x001C7E9C File Offset: 0x001C609C
		// (set) Token: 0x060064D5 RID: 25813 RVA: 0x0002FA5C File Offset: 0x0002DC5C
		public unsafe LayerMask detectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x060064D6 RID: 25814 RVA: 0x001C7EC4 File Offset: 0x001C60C4
		// (set) Token: 0x060064D7 RID: 25815 RVA: 0x0002FA77 File Offset: 0x0002DC77
		public unsafe Constructable_GridBased ConstructableClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_ConstructableClass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_ConstructableClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x060064D8 RID: 25816 RVA: 0x001C7EF4 File Offset: 0x001C60F4
		// (set) Token: 0x060064D9 RID: 25817 RVA: 0x0002FA96 File Offset: 0x0002DC96
		public unsafe Transform GhostModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_GhostModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_GhostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x060064DA RID: 25818 RVA: 0x001C7F24 File Offset: 0x001C6124
		// (set) Token: 0x060064DB RID: 25819 RVA: 0x0002FAB5 File Offset: 0x0002DCB5
		public unsafe bool validPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_validPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_validPosition)) = value;
			}
		}

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x060064DC RID: 25820 RVA: 0x001C7F4C File Offset: 0x001C614C
		// (set) Token: 0x060064DD RID: 25821 RVA: 0x0002FAD0 File Offset: 0x0002DCD0
		public unsafe float currentRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_currentRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_currentRotation)) = value;
			}
		}

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x060064DE RID: 25822 RVA: 0x001C7F74 File Offset: 0x001C6174
		// (set) Token: 0x060064DF RID: 25823 RVA: 0x0002FAEB File Offset: 0x0002DCEB
		public unsafe Material currentGhostMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_currentGhostMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_currentGhostMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x060064E0 RID: 25824 RVA: 0x001C7FA4 File Offset: 0x001C61A4
		// (set) Token: 0x060064E1 RID: 25825 RVA: 0x0002FB0A File Offset: 0x0002DD0A
		public unsafe ConstructionManager.WorldIntersection closestIntersection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_closestIntersection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionManager.WorldIntersection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_closestIntersection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x060064E2 RID: 25826 RVA: 0x001C7FD4 File Offset: 0x001C61D4
		// (set) Token: 0x060064E3 RID: 25827 RVA: 0x0002FB29 File Offset: 0x0002DD29
		public unsafe float listingPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_listingPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_listingPrice)) = value;
			}
		}

		// Token: 0x040044C1 RID: 17601
		private static readonly IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x040044C2 RID: 17602
		private static readonly IntPtr NativeFieldInfoPtr_ConstructableClass;

		// Token: 0x040044C3 RID: 17603
		private static readonly IntPtr NativeFieldInfoPtr_GhostModel;

		// Token: 0x040044C4 RID: 17604
		private static readonly IntPtr NativeFieldInfoPtr_validPosition;

		// Token: 0x040044C5 RID: 17605
		private static readonly IntPtr NativeFieldInfoPtr_currentRotation;

		// Token: 0x040044C6 RID: 17606
		private static readonly IntPtr NativeFieldInfoPtr_currentGhostMaterial;

		// Token: 0x040044C7 RID: 17607
		private static readonly IntPtr NativeFieldInfoPtr_closestIntersection;

		// Token: 0x040044C8 RID: 17608
		private static readonly IntPtr NativeFieldInfoPtr_listingPrice;

		// Token: 0x040044C9 RID: 17609
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040044CA RID: 17610
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040044CB RID: 17611
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x040044CC RID: 17612
		private static readonly IntPtr NativeMethodInfoPtr_CheckRotation_Protected_Void_0;

		// Token: 0x040044CD RID: 17613
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRotation_Protected_Void_0;

		// Token: 0x040044CE RID: 17614
		private static readonly IntPtr NativeMethodInfoPtr_CheckTileIntersections_Protected_Virtual_New_Void_0;

		// Token: 0x040044CF RID: 17615
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0;

		// Token: 0x040044D0 RID: 17616
		private static readonly IntPtr NativeMethodInfoPtr_AreMetaReqsMet_Private_Boolean_0;

		// Token: 0x040044D1 RID: 17617
		private static readonly IntPtr NativeMethodInfoPtr_PlaceNewConstructable_Protected_Virtual_New_Constructable_GridBased_0;

		// Token: 0x040044D2 RID: 17618
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeMoveConstructable_Protected_Virtual_New_Void_0;

		// Token: 0x040044D3 RID: 17619
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0;

		// Token: 0x040044D4 RID: 17620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
