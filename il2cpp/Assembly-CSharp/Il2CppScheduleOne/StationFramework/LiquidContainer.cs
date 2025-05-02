using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppLiquidVolumeFX;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x0200058C RID: 1420
	public class LiquidContainer : MonoBehaviour
	{
		// Token: 0x06007CFB RID: 31995 RVA: 0x00218888 File Offset: 0x00216A88
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidContainer()
		{
			Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "LiquidContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr);
			LiquidContainer.NativeFieldInfoPtr__CurrentLiquidLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "<CurrentLiquidLevel>k__BackingField");
			LiquidContainer.NativeFieldInfoPtr__LiquidColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "<LiquidColor>k__BackingField");
			LiquidContainer.NativeFieldInfoPtr_Viscosity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "Viscosity");
			LiquidContainer.NativeFieldInfoPtr_AdjustMurkiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "AdjustMurkiness");
			LiquidContainer.NativeFieldInfoPtr_LiquidVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "LiquidVolume");
			LiquidContainer.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "Collider");
			LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "ColliderTransform_Min");
			LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "ColliderTransform_Max");
			LiquidContainer.NativeFieldInfoPtr_MaxLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "MaxLevel");
			LiquidContainer.NativeFieldInfoPtr_liquidMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "liquidMesh");
			LiquidContainer.NativeMethodInfoPtr_get_CurrentLiquidLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678953);
			LiquidContainer.NativeMethodInfoPtr_set_CurrentLiquidLevel_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678954);
			LiquidContainer.NativeMethodInfoPtr_get_LiquidColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678955);
			LiquidContainer.NativeMethodInfoPtr_set_LiquidColor_Private_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678956);
			LiquidContainer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678957);
			LiquidContainer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678958);
			LiquidContainer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678959);
			LiquidContainer.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678960);
			LiquidContainer.NativeMethodInfoPtr_UpdateLighting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678961);
			LiquidContainer.NativeMethodInfoPtr_SetLiquidLevel_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678962);
			LiquidContainer.NativeMethodInfoPtr_SetLiquidColor_Public_Void_Color_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678963);
			LiquidContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678964);
		}

		// Token: 0x170025D7 RID: 9687
		// (get) Token: 0x06007CFC RID: 31996 RVA: 0x00218A70 File Offset: 0x00216C70
		// (set) Token: 0x06007CFD RID: 31997 RVA: 0x00218AAC File Offset: 0x00216CAC
		public unsafe float CurrentLiquidLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_get_CurrentLiquidLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29962, RefRangeEnd = 29963, XrefRangeStart = 29962, XrefRangeEnd = 29963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_set_CurrentLiquidLevel_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025D8 RID: 9688
		// (get) Token: 0x06007CFE RID: 31998 RVA: 0x00218AEC File Offset: 0x00216CEC
		// (set) Token: 0x06007CFF RID: 31999 RVA: 0x00218B28 File Offset: 0x00216D28
		public unsafe Color LiquidColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_get_LiquidColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_set_LiquidColor_Private_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007D00 RID: 32000 RVA: 0x00218B68 File Offset: 0x00216D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237795, XrefRangeEnd = 237802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D01 RID: 32001 RVA: 0x00218B9C File Offset: 0x00216D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237802, XrefRangeEnd = 237825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D02 RID: 32002 RVA: 0x00218BD0 File Offset: 0x00216DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237825, XrefRangeEnd = 237843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D03 RID: 32003 RVA: 0x00218C04 File Offset: 0x00216E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237843, XrefRangeEnd = 237844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D04 RID: 32004 RVA: 0x00218C38 File Offset: 0x00216E38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 237850, RefRangeEnd = 237854, XrefRangeStart = 237844, XrefRangeEnd = 237850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLighting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_UpdateLighting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D05 RID: 32005 RVA: 0x00218C6C File Offset: 0x00216E6C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 237889, RefRangeEnd = 237897, XrefRangeStart = 237854, XrefRangeEnd = 237889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLiquidLevel(float level, bool debug = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref debug;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_SetLiquidLevel_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D06 RID: 32006 RVA: 0x00218CB8 File Offset: 0x00216EB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 237900, RefRangeEnd = 237903, XrefRangeStart = 237897, XrefRangeEnd = 237900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLiquidColor(Color color, bool setColorVariable = true, bool updateLigting = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setColorVariable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateLigting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_SetLiquidColor_Public_Void_Color_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D07 RID: 32007 RVA: 0x00218D14 File Offset: 0x00216F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237903, XrefRangeEnd = 237904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D08 RID: 32008 RVA: 0x0003B56F File Offset: 0x0003976F
		public LiquidContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025CD RID: 9677
		// (get) Token: 0x06007D09 RID: 32009 RVA: 0x00218D50 File Offset: 0x00216F50
		// (set) Token: 0x06007D0A RID: 32010 RVA: 0x0003B578 File Offset: 0x00039778
		public unsafe float _CurrentLiquidLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr__CurrentLiquidLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr__CurrentLiquidLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x170025CE RID: 9678
		// (get) Token: 0x06007D0B RID: 32011 RVA: 0x00218D78 File Offset: 0x00216F78
		// (set) Token: 0x06007D0C RID: 32012 RVA: 0x0003B593 File Offset: 0x00039793
		public unsafe Color _LiquidColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr__LiquidColor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr__LiquidColor_k__BackingField)) = value;
			}
		}

		// Token: 0x170025CF RID: 9679
		// (get) Token: 0x06007D0D RID: 32013 RVA: 0x00218DA0 File Offset: 0x00216FA0
		// (set) Token: 0x06007D0E RID: 32014 RVA: 0x0003B5AE File Offset: 0x000397AE
		public unsafe float Viscosity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_Viscosity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_Viscosity)) = value;
			}
		}

		// Token: 0x170025D0 RID: 9680
		// (get) Token: 0x06007D0F RID: 32015 RVA: 0x00218DC8 File Offset: 0x00216FC8
		// (set) Token: 0x06007D10 RID: 32016 RVA: 0x0003B5C9 File Offset: 0x000397C9
		public unsafe bool AdjustMurkiness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_AdjustMurkiness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_AdjustMurkiness)) = value;
			}
		}

		// Token: 0x170025D1 RID: 9681
		// (get) Token: 0x06007D11 RID: 32017 RVA: 0x00218DF0 File Offset: 0x00216FF0
		// (set) Token: 0x06007D12 RID: 32018 RVA: 0x0003B5E4 File Offset: 0x000397E4
		public unsafe LiquidVolume LiquidVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_LiquidVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_LiquidVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025D2 RID: 9682
		// (get) Token: 0x06007D13 RID: 32019 RVA: 0x00218E20 File Offset: 0x00217020
		// (set) Token: 0x06007D14 RID: 32020 RVA: 0x0003B603 File Offset: 0x00039803
		public unsafe LiquidVolumeCollider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolumeCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025D3 RID: 9683
		// (get) Token: 0x06007D15 RID: 32021 RVA: 0x00218E50 File Offset: 0x00217050
		// (set) Token: 0x06007D16 RID: 32022 RVA: 0x0003B622 File Offset: 0x00039822
		public unsafe Transform ColliderTransform_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025D4 RID: 9684
		// (get) Token: 0x06007D17 RID: 32023 RVA: 0x00218E80 File Offset: 0x00217080
		// (set) Token: 0x06007D18 RID: 32024 RVA: 0x0003B641 File Offset: 0x00039841
		public unsafe Transform ColliderTransform_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025D5 RID: 9685
		// (get) Token: 0x06007D19 RID: 32025 RVA: 0x00218EB0 File Offset: 0x002170B0
		// (set) Token: 0x06007D1A RID: 32026 RVA: 0x0003B660 File Offset: 0x00039860
		public unsafe float MaxLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_MaxLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_MaxLevel)) = value;
			}
		}

		// Token: 0x170025D6 RID: 9686
		// (get) Token: 0x06007D1B RID: 32027 RVA: 0x00218ED8 File Offset: 0x002170D8
		// (set) Token: 0x06007D1C RID: 32028 RVA: 0x0003B67B File Offset: 0x0003987B
		public unsafe MeshRenderer liquidMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_liquidMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_liquidMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005510 RID: 21776
		private static readonly IntPtr NativeFieldInfoPtr__CurrentLiquidLevel_k__BackingField;

		// Token: 0x04005511 RID: 21777
		private static readonly IntPtr NativeFieldInfoPtr__LiquidColor_k__BackingField;

		// Token: 0x04005512 RID: 21778
		private static readonly IntPtr NativeFieldInfoPtr_Viscosity;

		// Token: 0x04005513 RID: 21779
		private static readonly IntPtr NativeFieldInfoPtr_AdjustMurkiness;

		// Token: 0x04005514 RID: 21780
		private static readonly IntPtr NativeFieldInfoPtr_LiquidVolume;

		// Token: 0x04005515 RID: 21781
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04005516 RID: 21782
		private static readonly IntPtr NativeFieldInfoPtr_ColliderTransform_Min;

		// Token: 0x04005517 RID: 21783
		private static readonly IntPtr NativeFieldInfoPtr_ColliderTransform_Max;

		// Token: 0x04005518 RID: 21784
		private static readonly IntPtr NativeFieldInfoPtr_MaxLevel;

		// Token: 0x04005519 RID: 21785
		private static readonly IntPtr NativeFieldInfoPtr_liquidMesh;

		// Token: 0x0400551A RID: 21786
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLiquidLevel_Public_get_Single_0;

		// Token: 0x0400551B RID: 21787
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLiquidLevel_Private_set_Void_Single_0;

		// Token: 0x0400551C RID: 21788
		private static readonly IntPtr NativeMethodInfoPtr_get_LiquidColor_Public_get_Color_0;

		// Token: 0x0400551D RID: 21789
		private static readonly IntPtr NativeMethodInfoPtr_set_LiquidColor_Private_set_Void_Color_0;

		// Token: 0x0400551E RID: 21790
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400551F RID: 21791
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005520 RID: 21792
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005521 RID: 21793
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04005522 RID: 21794
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLighting_Private_Void_0;

		// Token: 0x04005523 RID: 21795
		private static readonly IntPtr NativeMethodInfoPtr_SetLiquidLevel_Public_Void_Single_Boolean_0;

		// Token: 0x04005524 RID: 21796
		private static readonly IntPtr NativeMethodInfoPtr_SetLiquidColor_Public_Void_Color_Boolean_Boolean_0;

		// Token: 0x04005525 RID: 21797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
