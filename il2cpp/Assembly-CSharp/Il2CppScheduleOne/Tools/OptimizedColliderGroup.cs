using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000543 RID: 1347
	public class OptimizedColliderGroup : MonoBehaviour
	{
		// Token: 0x06007751 RID: 30545 RVA: 0x00205D68 File Offset: 0x00203F68
		// Note: this type is marked as 'beforefieldinit'.
		static OptimizedColliderGroup()
		{
			Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "OptimizedColliderGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr);
			OptimizedColliderGroup.NativeFieldInfoPtr_UPDATE_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "UPDATE_DISTANCE");
			OptimizedColliderGroup.NativeFieldInfoPtr_Colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "Colliders");
			OptimizedColliderGroup.NativeFieldInfoPtr_ColliderEnableMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "ColliderEnableMaxDistance");
			OptimizedColliderGroup.NativeFieldInfoPtr_sqrColliderEnableMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "sqrColliderEnableMaxDistance");
			OptimizedColliderGroup.NativeFieldInfoPtr_collidersEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "collidersEnabled");
			OptimizedColliderGroup.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678327);
			OptimizedColliderGroup.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678328);
			OptimizedColliderGroup.NativeMethodInfoPtr_RegisterEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678329);
			OptimizedColliderGroup.NativeMethodInfoPtr_GetColliders_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678330);
			OptimizedColliderGroup.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678331);
			OptimizedColliderGroup.NativeMethodInfoPtr_Refresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678332);
			OptimizedColliderGroup.NativeMethodInfoPtr_SetCollidersEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678333);
			OptimizedColliderGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678334);
		}

		// Token: 0x06007752 RID: 30546 RVA: 0x00205E9C File Offset: 0x0020409C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231740, XrefRangeEnd = 231764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007753 RID: 30547 RVA: 0x00205ED0 File Offset: 0x002040D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231764, XrefRangeEnd = 231778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007754 RID: 30548 RVA: 0x00205F04 File Offset: 0x00204104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 231809, RefRangeEnd = 231810, XrefRangeStart = 231778, XrefRangeEnd = 231809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_RegisterEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007755 RID: 30549 RVA: 0x00205F38 File Offset: 0x00204138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231810, XrefRangeEnd = 231814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetColliders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_GetColliders_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007756 RID: 30550 RVA: 0x00205F6C File Offset: 0x0020416C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007757 RID: 30551 RVA: 0x00205FA0 File Offset: 0x002041A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231814, XrefRangeEnd = 231840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_Refresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007758 RID: 30552 RVA: 0x00205FD4 File Offset: 0x002041D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231840, XrefRangeEnd = 231846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCollidersEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_SetCollidersEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x00206014 File Offset: 0x00204214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231846, XrefRangeEnd = 231847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptimizedColliderGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x00038850 File Offset: 0x00036A50
		public OptimizedColliderGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002415 RID: 9237
		// (get) Token: 0x0600775B RID: 30555 RVA: 0x00206050 File Offset: 0x00204250
		// (set) Token: 0x0600775C RID: 30556 RVA: 0x00038859 File Offset: 0x00036A59
		public unsafe static int UPDATE_DISTANCE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(OptimizedColliderGroup.NativeFieldInfoPtr_UPDATE_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OptimizedColliderGroup.NativeFieldInfoPtr_UPDATE_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17002416 RID: 9238
		// (get) Token: 0x0600775D RID: 30557 RVA: 0x0020606C File Offset: 0x0020426C
		// (set) Token: 0x0600775E RID: 30558 RVA: 0x00038867 File Offset: 0x00036A67
		public unsafe Il2CppReferenceArray<Collider> Colliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_Colliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_Colliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002417 RID: 9239
		// (get) Token: 0x0600775F RID: 30559 RVA: 0x0020609C File Offset: 0x0020429C
		// (set) Token: 0x06007760 RID: 30560 RVA: 0x00038886 File Offset: 0x00036A86
		public unsafe float ColliderEnableMaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_ColliderEnableMaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_ColliderEnableMaxDistance)) = value;
			}
		}

		// Token: 0x17002418 RID: 9240
		// (get) Token: 0x06007761 RID: 30561 RVA: 0x002060C4 File Offset: 0x002042C4
		// (set) Token: 0x06007762 RID: 30562 RVA: 0x000388A1 File Offset: 0x00036AA1
		public unsafe float sqrColliderEnableMaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_sqrColliderEnableMaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_sqrColliderEnableMaxDistance)) = value;
			}
		}

		// Token: 0x17002419 RID: 9241
		// (get) Token: 0x06007763 RID: 30563 RVA: 0x002060EC File Offset: 0x002042EC
		// (set) Token: 0x06007764 RID: 30564 RVA: 0x000388BC File Offset: 0x00036ABC
		public unsafe bool collidersEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_collidersEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_collidersEnabled)) = value;
			}
		}

		// Token: 0x0400516F RID: 20847
		private static readonly IntPtr NativeFieldInfoPtr_UPDATE_DISTANCE;

		// Token: 0x04005170 RID: 20848
		private static readonly IntPtr NativeFieldInfoPtr_Colliders;

		// Token: 0x04005171 RID: 20849
		private static readonly IntPtr NativeFieldInfoPtr_ColliderEnableMaxDistance;

		// Token: 0x04005172 RID: 20850
		private static readonly IntPtr NativeFieldInfoPtr_sqrColliderEnableMaxDistance;

		// Token: 0x04005173 RID: 20851
		private static readonly IntPtr NativeFieldInfoPtr_collidersEnabled;

		// Token: 0x04005174 RID: 20852
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04005175 RID: 20853
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005176 RID: 20854
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEvent_Private_Void_0;

		// Token: 0x04005177 RID: 20855
		private static readonly IntPtr NativeMethodInfoPtr_GetColliders_Public_Void_0;

		// Token: 0x04005178 RID: 20856
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04005179 RID: 20857
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_0;

		// Token: 0x0400517A RID: 20858
		private static readonly IntPtr NativeMethodInfoPtr_SetCollidersEnabled_Private_Void_Boolean_0;

		// Token: 0x0400517B RID: 20859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
