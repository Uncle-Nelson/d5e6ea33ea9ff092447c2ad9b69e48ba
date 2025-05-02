using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.Construction.Features;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.Construction.Features;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Construction
{
	// Token: 0x02000721 RID: 1825
	public class FeaturesManager : Singleton<FeaturesManager>
	{
		// Token: 0x0600A453 RID: 42067 RVA: 0x00292FAC File Offset: 0x002911AC
		// Note: this type is marked as 'beforefieldinit'.
		static FeaturesManager()
		{
			Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Construction", "FeaturesManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr);
			FeaturesManager.NativeFieldInfoPtr_activeConstructable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "activeConstructable");
			FeaturesManager.NativeFieldInfoPtr_selectedFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "selectedFeature");
			FeaturesManager.NativeFieldInfoPtr_featureIconsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "featureIconsContainer");
			FeaturesManager.NativeFieldInfoPtr_featureMenuRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "featureMenuRect");
			FeaturesManager.NativeFieldInfoPtr_featureMenuTitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "featureMenuTitleLabel");
			FeaturesManager.NativeFieldInfoPtr_featureInterfaceContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "featureInterfaceContainer");
			FeaturesManager.NativeFieldInfoPtr_featureIconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "featureIconPrefab");
			FeaturesManager.NativeFieldInfoPtr_currentFeatureInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "currentFeatureInterface");
			FeaturesManager.NativeFieldInfoPtr_roofSetInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "roofSetInvisible");
			FeaturesManager.NativeFieldInfoPtr_featureIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "featureIcons");
			FeaturesManager.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683383);
			FeaturesManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683384);
			FeaturesManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683385);
			FeaturesManager.NativeMethodInfoPtr_OpenFeatureMenu_Public_Void_Feature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683386);
			FeaturesManager.NativeMethodInfoPtr_CloseFeatureMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683387);
			FeaturesManager.NativeMethodInfoPtr_DeselectFeature_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683388);
			FeaturesManager.NativeMethodInfoPtr_Activate_Public_Void_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683389);
			FeaturesManager.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683390);
			FeaturesManager.NativeMethodInfoPtr_ClearIcons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683391);
			FeaturesManager.NativeMethodInfoPtr_CreateIcons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683392);
			FeaturesManager.NativeMethodInfoPtr_UpdateIconTransforms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683393);
			FeaturesManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683394);
		}

		// Token: 0x170032BB RID: 12987
		// (get) Token: 0x0600A454 RID: 42068 RVA: 0x00293194 File Offset: 0x00291394
		public unsafe bool isActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287643, XrefRangeEnd = 287647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600A455 RID: 42069 RVA: 0x002931D0 File Offset: 0x002913D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287647, XrefRangeEnd = 287651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeaturesManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A456 RID: 42070 RVA: 0x0029320C File Offset: 0x0029140C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287651, XrefRangeEnd = 287657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A457 RID: 42071 RVA: 0x00293240 File Offset: 0x00291440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287682, RefRangeEnd = 287683, XrefRangeStart = 287657, XrefRangeEnd = 287682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenFeatureMenu(Feature feature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(feature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_OpenFeatureMenu_Public_Void_Feature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A458 RID: 42072 RVA: 0x00293284 File Offset: 0x00291484
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 287700, RefRangeEnd = 287705, XrefRangeStart = 287683, XrefRangeEnd = 287700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseFeatureMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_CloseFeatureMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A459 RID: 42073 RVA: 0x002932B8 File Offset: 0x002914B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287705, XrefRangeEnd = 287726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeselectFeature()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_DeselectFeature_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A45A RID: 42074 RVA: 0x002932EC File Offset: 0x002914EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287726, XrefRangeEnd = 287729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate(Constructable constructable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_Activate_Public_Void_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A45B RID: 42075 RVA: 0x00293330 File Offset: 0x00291530
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287748, RefRangeEnd = 287751, XrefRangeStart = 287729, XrefRangeEnd = 287748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A45C RID: 42076 RVA: 0x00293364 File Offset: 0x00291564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287751, XrefRangeEnd = 287763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_ClearIcons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A45D RID: 42077 RVA: 0x00293398 File Offset: 0x00291598
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287796, RefRangeEnd = 287798, XrefRangeStart = 287763, XrefRangeEnd = 287796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_CreateIcons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A45E RID: 42078 RVA: 0x002933CC File Offset: 0x002915CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287813, RefRangeEnd = 287815, XrefRangeStart = 287798, XrefRangeEnd = 287813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIconTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_UpdateIconTransforms_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A45F RID: 42079 RVA: 0x00293400 File Offset: 0x00291600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287815, XrefRangeEnd = 287825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FeaturesManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A460 RID: 42080 RVA: 0x00050FA1 File Offset: 0x0004F1A1
		public FeaturesManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032B1 RID: 12977
		// (get) Token: 0x0600A461 RID: 42081 RVA: 0x0029343C File Offset: 0x0029163C
		// (set) Token: 0x0600A462 RID: 42082 RVA: 0x00050FAA File Offset: 0x0004F1AA
		public unsafe Constructable activeConstructable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_activeConstructable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_activeConstructable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B2 RID: 12978
		// (get) Token: 0x0600A463 RID: 42083 RVA: 0x0029346C File Offset: 0x0029166C
		// (set) Token: 0x0600A464 RID: 42084 RVA: 0x00050FC9 File Offset: 0x0004F1C9
		public unsafe Feature selectedFeature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_selectedFeature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Feature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_selectedFeature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B3 RID: 12979
		// (get) Token: 0x0600A465 RID: 42085 RVA: 0x0029349C File Offset: 0x0029169C
		// (set) Token: 0x0600A466 RID: 42086 RVA: 0x00050FE8 File Offset: 0x0004F1E8
		public unsafe RectTransform featureIconsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureIconsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureIconsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B4 RID: 12980
		// (get) Token: 0x0600A467 RID: 42087 RVA: 0x002934CC File Offset: 0x002916CC
		// (set) Token: 0x0600A468 RID: 42088 RVA: 0x00051007 File Offset: 0x0004F207
		public unsafe RectTransform featureMenuRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureMenuRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureMenuRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B5 RID: 12981
		// (get) Token: 0x0600A469 RID: 42089 RVA: 0x002934FC File Offset: 0x002916FC
		// (set) Token: 0x0600A46A RID: 42090 RVA: 0x00051026 File Offset: 0x0004F226
		public unsafe TextMeshProUGUI featureMenuTitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureMenuTitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureMenuTitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B6 RID: 12982
		// (get) Token: 0x0600A46B RID: 42091 RVA: 0x0029352C File Offset: 0x0029172C
		// (set) Token: 0x0600A46C RID: 42092 RVA: 0x00051045 File Offset: 0x0004F245
		public unsafe RectTransform featureInterfaceContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureInterfaceContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureInterfaceContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B7 RID: 12983
		// (get) Token: 0x0600A46D RID: 42093 RVA: 0x0029355C File Offset: 0x0029175C
		// (set) Token: 0x0600A46E RID: 42094 RVA: 0x00051064 File Offset: 0x0004F264
		public unsafe GameObject featureIconPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureIconPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureIconPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B8 RID: 12984
		// (get) Token: 0x0600A46F RID: 42095 RVA: 0x0029358C File Offset: 0x0029178C
		// (set) Token: 0x0600A470 RID: 42096 RVA: 0x00051083 File Offset: 0x0004F283
		public unsafe FI_Base currentFeatureInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_currentFeatureInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FI_Base>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_currentFeatureInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B9 RID: 12985
		// (get) Token: 0x0600A471 RID: 42097 RVA: 0x002935BC File Offset: 0x002917BC
		// (set) Token: 0x0600A472 RID: 42098 RVA: 0x000510A2 File Offset: 0x0004F2A2
		public unsafe bool roofSetInvisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_roofSetInvisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_roofSetInvisible)) = value;
			}
		}

		// Token: 0x170032BA RID: 12986
		// (get) Token: 0x0600A473 RID: 42099 RVA: 0x002935E4 File Offset: 0x002917E4
		// (set) Token: 0x0600A474 RID: 42100 RVA: 0x000510BD File Offset: 0x0004F2BD
		public unsafe List<FeatureIcon> featureIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FeatureIcon>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006E2C RID: 28204
		private static readonly IntPtr NativeFieldInfoPtr_activeConstructable;

		// Token: 0x04006E2D RID: 28205
		private static readonly IntPtr NativeFieldInfoPtr_selectedFeature;

		// Token: 0x04006E2E RID: 28206
		private static readonly IntPtr NativeFieldInfoPtr_featureIconsContainer;

		// Token: 0x04006E2F RID: 28207
		private static readonly IntPtr NativeFieldInfoPtr_featureMenuRect;

		// Token: 0x04006E30 RID: 28208
		private static readonly IntPtr NativeFieldInfoPtr_featureMenuTitleLabel;

		// Token: 0x04006E31 RID: 28209
		private static readonly IntPtr NativeFieldInfoPtr_featureInterfaceContainer;

		// Token: 0x04006E32 RID: 28210
		private static readonly IntPtr NativeFieldInfoPtr_featureIconPrefab;

		// Token: 0x04006E33 RID: 28211
		private static readonly IntPtr NativeFieldInfoPtr_currentFeatureInterface;

		// Token: 0x04006E34 RID: 28212
		private static readonly IntPtr NativeFieldInfoPtr_roofSetInvisible;

		// Token: 0x04006E35 RID: 28213
		private static readonly IntPtr NativeFieldInfoPtr_featureIcons;

		// Token: 0x04006E36 RID: 28214
		private static readonly IntPtr NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0;

		// Token: 0x04006E37 RID: 28215
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006E38 RID: 28216
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006E39 RID: 28217
		private static readonly IntPtr NativeMethodInfoPtr_OpenFeatureMenu_Public_Void_Feature_0;

		// Token: 0x04006E3A RID: 28218
		private static readonly IntPtr NativeMethodInfoPtr_CloseFeatureMenu_Public_Void_0;

		// Token: 0x04006E3B RID: 28219
		private static readonly IntPtr NativeMethodInfoPtr_DeselectFeature_Public_Void_0;

		// Token: 0x04006E3C RID: 28220
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_Constructable_0;

		// Token: 0x04006E3D RID: 28221
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;

		// Token: 0x04006E3E RID: 28222
		private static readonly IntPtr NativeMethodInfoPtr_ClearIcons_Private_Void_0;

		// Token: 0x04006E3F RID: 28223
		private static readonly IntPtr NativeMethodInfoPtr_CreateIcons_Private_Void_0;

		// Token: 0x04006E40 RID: 28224
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIconTransforms_Private_Void_0;

		// Token: 0x04006E41 RID: 28225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
