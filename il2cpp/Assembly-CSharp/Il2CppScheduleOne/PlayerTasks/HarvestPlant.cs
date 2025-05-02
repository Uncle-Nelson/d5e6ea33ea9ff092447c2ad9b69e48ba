using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000208 RID: 520
	public class HarvestPlant : Task
	{
		// Token: 0x06002B30 RID: 11056 RVA: 0x000F9424 File Offset: 0x000F7624
		// Note: this type is marked as 'beforefieldinit'.
		static HarvestPlant()
		{
			Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "HarvestPlant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr);
			HarvestPlant.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "<TaskName>k__BackingField");
			HarvestPlant.NativeFieldInfoPtr_pot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "pot");
			HarvestPlant.NativeFieldInfoPtr_HarvestCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "HarvestCount");
			HarvestPlant.NativeFieldInfoPtr_HarvestTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "HarvestTotal");
			HarvestPlant.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "rotation");
			HarvestPlant.NativeFieldInfoPtr_hintShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "hintShown");
			HarvestPlant.NativeFieldInfoPtr_CanDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "CanDrag");
			HarvestPlant.NativeFieldInfoPtr_SoundLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "SoundLoop");
			HarvestPlant.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668146);
			HarvestPlant.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668147);
			HarvestPlant.NativeMethodInfoPtr__ctor_Public_Void_Pot_Boolean_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668148);
			HarvestPlant.NativeMethodInfoPtr_UpdateInstructionText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668149);
			HarvestPlant.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668150);
			HarvestPlant.NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668151);
			HarvestPlant.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668152);
			HarvestPlant.NativeMethodInfoPtr_GetHoveredHarvestable_Private_PlantHarvestable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668153);
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06002B31 RID: 11057 RVA: 0x000F9594 File Offset: 0x000F7794
		// (set) Token: 0x06002B32 RID: 11058 RVA: 0x000F95D8 File Offset: 0x000F77D8
		public unsafe override string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPlant.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPlant.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x000F9628 File Offset: 0x000F7828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121637, XrefRangeEnd = 121731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HarvestPlant(Pot _pot, bool canDrag, AudioSourceController soundLoopPrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canDrag;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(soundLoopPrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestPlant.NativeMethodInfoPtr__ctor_Public_Void_Pot_Boolean_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x000F9694 File Offset: 0x000F7894
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 121766, RefRangeEnd = 121768, XrefRangeStart = 121731, XrefRangeEnd = 121766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstructionText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestPlant.NativeMethodInfoPtr_UpdateInstructionText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x000F96C8 File Offset: 0x000F78C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121768, XrefRangeEnd = 121819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPlant.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x000F9704 File Offset: 0x000F7904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121819, XrefRangeEnd = 121833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPlant.NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x000F9740 File Offset: 0x000F7940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121833, XrefRangeEnd = 121912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPlant.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x000F977C File Offset: 0x000F797C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 121922, RefRangeEnd = 121924, XrefRangeStart = 121912, XrefRangeEnd = 121922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantHarvestable GetHoveredHarvestable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestPlant.NativeMethodInfoPtr_GetHoveredHarvestable_Private_PlantHarvestable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlantHarvestable>(intPtr3) : null;
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x0001766B File Offset: 0x0001586B
		public HarvestPlant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06002B3A RID: 11066 RVA: 0x000F97BC File Offset: 0x000F79BC
		// (set) Token: 0x06002B3B RID: 11067 RVA: 0x00017674 File Offset: 0x00015874
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06002B3C RID: 11068 RVA: 0x000F97E4 File Offset: 0x000F79E4
		// (set) Token: 0x06002B3D RID: 11069 RVA: 0x00017693 File Offset: 0x00015893
		public unsafe Pot pot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_pot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_pot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06002B3E RID: 11070 RVA: 0x000F9814 File Offset: 0x000F7A14
		// (set) Token: 0x06002B3F RID: 11071 RVA: 0x000176B2 File Offset: 0x000158B2
		public unsafe int HarvestCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_HarvestCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_HarvestCount)) = value;
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06002B40 RID: 11072 RVA: 0x000F983C File Offset: 0x000F7A3C
		// (set) Token: 0x06002B41 RID: 11073 RVA: 0x000176CD File Offset: 0x000158CD
		public unsafe int HarvestTotal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_HarvestTotal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_HarvestTotal)) = value;
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06002B42 RID: 11074 RVA: 0x000F9864 File Offset: 0x000F7A64
		// (set) Token: 0x06002B43 RID: 11075 RVA: 0x000176E8 File Offset: 0x000158E8
		public unsafe float rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06002B44 RID: 11076 RVA: 0x000F988C File Offset: 0x000F7A8C
		// (set) Token: 0x06002B45 RID: 11077 RVA: 0x00017703 File Offset: 0x00015903
		public unsafe static bool hintShown
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(HarvestPlant.NativeFieldInfoPtr_hintShown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HarvestPlant.NativeFieldInfoPtr_hintShown, (void*)(&value));
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x000F98A8 File Offset: 0x000F7AA8
		// (set) Token: 0x06002B47 RID: 11079 RVA: 0x00017711 File Offset: 0x00015911
		public unsafe static bool CanDrag
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(HarvestPlant.NativeFieldInfoPtr_CanDrag, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HarvestPlant.NativeFieldInfoPtr_CanDrag, (void*)(&value));
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06002B48 RID: 11080 RVA: 0x000F98C4 File Offset: 0x000F7AC4
		// (set) Token: 0x06002B49 RID: 11081 RVA: 0x0001771F File Offset: 0x0001591F
		public unsafe AudioSourceController SoundLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_SoundLoop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_SoundLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CA6 RID: 7334
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001CA7 RID: 7335
		private static readonly IntPtr NativeFieldInfoPtr_pot;

		// Token: 0x04001CA8 RID: 7336
		private static readonly IntPtr NativeFieldInfoPtr_HarvestCount;

		// Token: 0x04001CA9 RID: 7337
		private static readonly IntPtr NativeFieldInfoPtr_HarvestTotal;

		// Token: 0x04001CAA RID: 7338
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x04001CAB RID: 7339
		private static readonly IntPtr NativeFieldInfoPtr_hintShown;

		// Token: 0x04001CAC RID: 7340
		private static readonly IntPtr NativeFieldInfoPtr_CanDrag;

		// Token: 0x04001CAD RID: 7341
		private static readonly IntPtr NativeFieldInfoPtr_SoundLoop;

		// Token: 0x04001CAE RID: 7342
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0;

		// Token: 0x04001CAF RID: 7343
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0;

		// Token: 0x04001CB0 RID: 7344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Pot_Boolean_AudioSourceController_0;

		// Token: 0x04001CB1 RID: 7345
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstructionText_Private_Void_0;

		// Token: 0x04001CB2 RID: 7346
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001CB3 RID: 7347
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_Void_0;

		// Token: 0x04001CB4 RID: 7348
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001CB5 RID: 7349
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredHarvestable_Private_PlantHarvestable_0;
	}
}
