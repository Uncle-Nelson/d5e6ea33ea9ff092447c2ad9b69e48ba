using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004C0 RID: 1216
	public class BuildUpdate_StoredItem : BuildUpdate_Base
	{
		// Token: 0x06006A80 RID: 27264 RVA: 0x001DBDA4 File Offset: 0x001D9FA4
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_StoredItem()
		{
			Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_StoredItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr);
			BuildUpdate_StoredItem.NativeFieldInfoPtr_itemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "itemInstance");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_ghostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "ghostModel");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_storedItemClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "storedItemClass");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_bestIntersection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "bestIntersection");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_detectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "detectionRange");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "detectionMask");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_storedItemHoldDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "storedItemHoldDistance");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_currentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "currentRotation");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_validPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "validPosition");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_currentGhostMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "currentGhostMaterial");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_mouseUpSinceStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "mouseUpSinceStart");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_mouseUpSincePlace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "mouseUpSincePlace");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_positionDuringLastValidPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "positionDuringLastValidPosition");
			BuildUpdate_StoredItem.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676811);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676812);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_CheckRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676813);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676814);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676815);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676816);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676817);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_PostPlace_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676818);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_GetOriginCoordinate_Protected_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676819);
			BuildUpdate_StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100676820);
		}

		// Token: 0x06006A81 RID: 27265 RVA: 0x001DBFA0 File Offset: 0x001DA1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214893, XrefRangeEnd = 214907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_StoredItem.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A82 RID: 27266 RVA: 0x001DBFDC File Offset: 0x001DA1DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214966, RefRangeEnd = 214967, XrefRangeStart = 214907, XrefRangeEnd = 214966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_StoredItem.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A83 RID: 27267 RVA: 0x001DC018 File Offset: 0x001DA218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214967, XrefRangeEnd = 214974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_StoredItem.NativeMethodInfoPtr_CheckRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A84 RID: 27268 RVA: 0x001DC04C File Offset: 0x001DA24C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214984, RefRangeEnd = 214985, XrefRangeStart = 214974, XrefRangeEnd = 214984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_StoredItem.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A85 RID: 27269 RVA: 0x001DC080 File Offset: 0x001DA280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214985, XrefRangeEnd = 215113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckGridIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_StoredItem.NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A86 RID: 27270 RVA: 0x001DC0BC File Offset: 0x001DA2BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215129, RefRangeEnd = 215131, XrefRangeStart = 215113, XrefRangeEnd = 215129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_StoredItem.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A87 RID: 27271 RVA: 0x001DC0F0 File Offset: 0x001DA2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215131, XrefRangeEnd = 215165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Place()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_StoredItem.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A88 RID: 27272 RVA: 0x001DC12C File Offset: 0x001DA32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215165, XrefRangeEnd = 215172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PostPlace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_StoredItem.NativeMethodInfoPtr_PostPlace_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A89 RID: 27273 RVA: 0x001DC168 File Offset: 0x001DA368
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215180, RefRangeEnd = 215182, XrefRangeStart = 215172, XrefRangeEnd = 215180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetOriginCoordinate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_StoredItem.NativeMethodInfoPtr_GetOriginCoordinate_Protected_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006A8A RID: 27274 RVA: 0x001DC1A4 File Offset: 0x001DA3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215182, XrefRangeEnd = 215185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_StoredItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A8B RID: 27275 RVA: 0x0003251C File Offset: 0x0003071C
		public BuildUpdate_StoredItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x06006A8C RID: 27276 RVA: 0x001DC1E0 File Offset: 0x001DA3E0
		// (set) Token: 0x06006A8D RID: 27277 RVA: 0x00032525 File Offset: 0x00030725
		public unsafe StorableItemInstance itemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_itemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_itemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x06006A8E RID: 27278 RVA: 0x001DC210 File Offset: 0x001DA410
		// (set) Token: 0x06006A8F RID: 27279 RVA: 0x00032544 File Offset: 0x00030744
		public unsafe GameObject ghostModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_ghostModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_ghostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x06006A90 RID: 27280 RVA: 0x001DC240 File Offset: 0x001DA440
		// (set) Token: 0x06006A91 RID: 27281 RVA: 0x00032563 File Offset: 0x00030763
		public unsafe StoredItem storedItemClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_storedItemClass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_storedItemClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x06006A92 RID: 27282 RVA: 0x001DC270 File Offset: 0x001DA470
		// (set) Token: 0x06006A93 RID: 27283 RVA: 0x00032582 File Offset: 0x00030782
		public unsafe BuildUpdate_StoredItem.StorageTileIntersection bestIntersection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_bestIntersection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildUpdate_StoredItem.StorageTileIntersection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_bestIntersection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x06006A94 RID: 27284 RVA: 0x001DC2A0 File Offset: 0x001DA4A0
		// (set) Token: 0x06006A95 RID: 27285 RVA: 0x000325A1 File Offset: 0x000307A1
		public unsafe float detectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_detectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_detectionRange)) = value;
			}
		}

		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x06006A96 RID: 27286 RVA: 0x001DC2C8 File Offset: 0x001DA4C8
		// (set) Token: 0x06006A97 RID: 27287 RVA: 0x000325BC File Offset: 0x000307BC
		public unsafe LayerMask detectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x06006A98 RID: 27288 RVA: 0x001DC2F0 File Offset: 0x001DA4F0
		// (set) Token: 0x06006A99 RID: 27289 RVA: 0x000325D7 File Offset: 0x000307D7
		public unsafe float storedItemHoldDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_storedItemHoldDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_storedItemHoldDistance)) = value;
			}
		}

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x06006A9A RID: 27290 RVA: 0x001DC318 File Offset: 0x001DA518
		// (set) Token: 0x06006A9B RID: 27291 RVA: 0x000325F2 File Offset: 0x000307F2
		public unsafe float currentRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_currentRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_currentRotation)) = value;
			}
		}

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x06006A9C RID: 27292 RVA: 0x001DC340 File Offset: 0x001DA540
		// (set) Token: 0x06006A9D RID: 27293 RVA: 0x0003260D File Offset: 0x0003080D
		public unsafe bool validPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_validPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_validPosition)) = value;
			}
		}

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x06006A9E RID: 27294 RVA: 0x001DC368 File Offset: 0x001DA568
		// (set) Token: 0x06006A9F RID: 27295 RVA: 0x00032628 File Offset: 0x00030828
		public unsafe Material currentGhostMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_currentGhostMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_currentGhostMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x06006AA0 RID: 27296 RVA: 0x001DC398 File Offset: 0x001DA598
		// (set) Token: 0x06006AA1 RID: 27297 RVA: 0x00032647 File Offset: 0x00030847
		public unsafe bool mouseUpSinceStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_mouseUpSinceStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_mouseUpSinceStart)) = value;
			}
		}

		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x06006AA2 RID: 27298 RVA: 0x001DC3C0 File Offset: 0x001DA5C0
		// (set) Token: 0x06006AA3 RID: 27299 RVA: 0x00032662 File Offset: 0x00030862
		public unsafe bool mouseUpSincePlace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_mouseUpSincePlace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_mouseUpSincePlace)) = value;
			}
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x06006AA4 RID: 27300 RVA: 0x001DC3E8 File Offset: 0x001DA5E8
		// (set) Token: 0x06006AA5 RID: 27301 RVA: 0x0003267D File Offset: 0x0003087D
		public unsafe Vector3 positionDuringLastValidPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_positionDuringLastValidPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_positionDuringLastValidPosition)) = value;
			}
		}

		// Token: 0x040048E9 RID: 18665
		private static readonly IntPtr NativeFieldInfoPtr_itemInstance;

		// Token: 0x040048EA RID: 18666
		private static readonly IntPtr NativeFieldInfoPtr_ghostModel;

		// Token: 0x040048EB RID: 18667
		private static readonly IntPtr NativeFieldInfoPtr_storedItemClass;

		// Token: 0x040048EC RID: 18668
		private static readonly IntPtr NativeFieldInfoPtr_bestIntersection;

		// Token: 0x040048ED RID: 18669
		private static readonly IntPtr NativeFieldInfoPtr_detectionRange;

		// Token: 0x040048EE RID: 18670
		private static readonly IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x040048EF RID: 18671
		private static readonly IntPtr NativeFieldInfoPtr_storedItemHoldDistance;

		// Token: 0x040048F0 RID: 18672
		private static readonly IntPtr NativeFieldInfoPtr_currentRotation;

		// Token: 0x040048F1 RID: 18673
		private static readonly IntPtr NativeFieldInfoPtr_validPosition;

		// Token: 0x040048F2 RID: 18674
		private static readonly IntPtr NativeFieldInfoPtr_currentGhostMaterial;

		// Token: 0x040048F3 RID: 18675
		private static readonly IntPtr NativeFieldInfoPtr_mouseUpSinceStart;

		// Token: 0x040048F4 RID: 18676
		private static readonly IntPtr NativeFieldInfoPtr_mouseUpSincePlace;

		// Token: 0x040048F5 RID: 18677
		private static readonly IntPtr NativeFieldInfoPtr_positionDuringLastValidPosition;

		// Token: 0x040048F6 RID: 18678
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040048F7 RID: 18679
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040048F8 RID: 18680
		private static readonly IntPtr NativeMethodInfoPtr_CheckRotation_Protected_Void_0;

		// Token: 0x040048F9 RID: 18681
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRotation_Protected_Void_0;

		// Token: 0x040048FA RID: 18682
		private static readonly IntPtr NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0;

		// Token: 0x040048FB RID: 18683
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0;

		// Token: 0x040048FC RID: 18684
		private static readonly IntPtr NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0;

		// Token: 0x040048FD RID: 18685
		private static readonly IntPtr NativeMethodInfoPtr_PostPlace_Protected_Virtual_New_Void_0;

		// Token: 0x040048FE RID: 18686
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginCoordinate_Protected_Vector2_0;

		// Token: 0x040048FF RID: 18687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A56 RID: 2646
		public class StorageTileIntersection : Il2CppSystem.Object
		{
			// Token: 0x0600D072 RID: 53362 RVA: 0x00320028 File Offset: 0x0031E228
			// Note: this type is marked as 'beforefieldinit'.
			static StorageTileIntersection()
			{
				Il2CppClassPointerStore<BuildUpdate_StoredItem.StorageTileIntersection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "StorageTileIntersection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_StoredItem.StorageTileIntersection>.NativeClassPtr);
				BuildUpdate_StoredItem.StorageTileIntersection.NativeFieldInfoPtr_footprintTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem.StorageTileIntersection>.NativeClassPtr, "footprintTile");
				BuildUpdate_StoredItem.StorageTileIntersection.NativeFieldInfoPtr_storageTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem.StorageTileIntersection>.NativeClassPtr, "storageTile");
				BuildUpdate_StoredItem.StorageTileIntersection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem.StorageTileIntersection>.NativeClassPtr, 100676821);
			}

			// Token: 0x0600D073 RID: 53363 RVA: 0x00320090 File Offset: 0x0031E290
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StorageTileIntersection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_StoredItem.StorageTileIntersection>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_StoredItem.StorageTileIntersection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D074 RID: 53364 RVA: 0x00065729 File Offset: 0x00063929
			public StorageTileIntersection(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040BC RID: 16572
			// (get) Token: 0x0600D075 RID: 53365 RVA: 0x003200CC File Offset: 0x0031E2CC
			// (set) Token: 0x0600D076 RID: 53366 RVA: 0x00065732 File Offset: 0x00063932
			public unsafe FootprintTile footprintTile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.StorageTileIntersection.NativeFieldInfoPtr_footprintTile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.StorageTileIntersection.NativeFieldInfoPtr_footprintTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040BD RID: 16573
			// (get) Token: 0x0600D077 RID: 53367 RVA: 0x003200FC File Offset: 0x0031E2FC
			// (set) Token: 0x0600D078 RID: 53368 RVA: 0x00065751 File Offset: 0x00063951
			public unsafe StorageTile storageTile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.StorageTileIntersection.NativeFieldInfoPtr_storageTile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.StorageTileIntersection.NativeFieldInfoPtr_storageTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CA7 RID: 36007
			private static readonly IntPtr NativeFieldInfoPtr_footprintTile;

			// Token: 0x04008CA8 RID: 36008
			private static readonly IntPtr NativeFieldInfoPtr_storageTile;

			// Token: 0x04008CA9 RID: 36009
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
