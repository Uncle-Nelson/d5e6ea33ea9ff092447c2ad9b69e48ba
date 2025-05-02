using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Materials;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D1 RID: 1233
	public class FootstepSounds : MonoBehaviour
	{
		// Token: 0x06006C05 RID: 27653 RVA: 0x001E0460 File Offset: 0x001DE660
		// Note: this type is marked as 'beforefieldinit'.
		static FootstepSounds()
		{
			Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "FootstepSounds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr);
			FootstepSounds.NativeFieldInfoPtr_COOLDOWN_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "COOLDOWN_TIME");
			FootstepSounds.NativeFieldInfoPtr_sources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "sources");
			FootstepSounds.NativeFieldInfoPtr_soundGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "soundGroups");
			FootstepSounds.NativeFieldInfoPtr_materialFootstepSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "materialFootstepSounds");
			FootstepSounds.NativeFieldInfoPtr_lastStepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "lastStepTime");
			FootstepSounds.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, 100676945);
			FootstepSounds.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, 100676946);
			FootstepSounds.NativeMethodInfoPtr_Step_Public_Void_EMaterialType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, 100676947);
			FootstepSounds.NativeMethodInfoPtr_GetFreeSource_Public_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, 100676948);
			FootstepSounds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, 100676949);
		}

		// Token: 0x06006C06 RID: 27654 RVA: 0x001E0558 File Offset: 0x001DE758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216628, XrefRangeEnd = 216715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C07 RID: 27655 RVA: 0x001E058C File Offset: 0x001DE78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216715, XrefRangeEnd = 216716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C08 RID: 27656 RVA: 0x001E05C0 File Offset: 0x001DE7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216716, XrefRangeEnd = 216765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Step(EMaterialType materialType, float hardness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref materialType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hardness;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.NativeMethodInfoPtr_Step_Public_Void_EMaterialType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C09 RID: 27657 RVA: 0x001E060C File Offset: 0x001DE80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216765, XrefRangeEnd = 216783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSourceController GetFreeSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.NativeMethodInfoPtr_GetFreeSource_Public_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr3) : null;
		}

		// Token: 0x06006C0A RID: 27658 RVA: 0x001E064C File Offset: 0x001DE84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216783, XrefRangeEnd = 216805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootstepSounds() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C0B RID: 27659 RVA: 0x00033234 File Offset: 0x00031434
		public FootstepSounds(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x06006C0C RID: 27660 RVA: 0x001E0688 File Offset: 0x001DE888
		// (set) Token: 0x06006C0D RID: 27661 RVA: 0x0003323D File Offset: 0x0003143D
		public unsafe static float COOLDOWN_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FootstepSounds.NativeFieldInfoPtr_COOLDOWN_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FootstepSounds.NativeFieldInfoPtr_COOLDOWN_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x06006C0E RID: 27662 RVA: 0x001E06A4 File Offset: 0x001DE8A4
		// (set) Token: 0x06006C0F RID: 27663 RVA: 0x0003324B File Offset: 0x0003144B
		public unsafe List<AudioSourceController> sources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_sources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_sources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x06006C10 RID: 27664 RVA: 0x001E06D4 File Offset: 0x001DE8D4
		// (set) Token: 0x06006C11 RID: 27665 RVA: 0x0003326A File Offset: 0x0003146A
		public unsafe List<FootstepSounds.FootstepSoundGroup> soundGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_soundGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FootstepSounds.FootstepSoundGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_soundGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x06006C12 RID: 27666 RVA: 0x001E0704 File Offset: 0x001DE904
		// (set) Token: 0x06006C13 RID: 27667 RVA: 0x00033289 File Offset: 0x00031489
		public unsafe Dictionary<EMaterialType, FootstepSounds.FootstepSoundGroup> materialFootstepSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_materialFootstepSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EMaterialType, FootstepSounds.FootstepSoundGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_materialFootstepSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x06006C14 RID: 27668 RVA: 0x001E0734 File Offset: 0x001DE934
		// (set) Token: 0x06006C15 RID: 27669 RVA: 0x000332A8 File Offset: 0x000314A8
		public unsafe float lastStepTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_lastStepTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_lastStepTime)) = value;
			}
		}

		// Token: 0x040049E2 RID: 18914
		private static readonly IntPtr NativeFieldInfoPtr_COOLDOWN_TIME;

		// Token: 0x040049E3 RID: 18915
		private static readonly IntPtr NativeFieldInfoPtr_sources;

		// Token: 0x040049E4 RID: 18916
		private static readonly IntPtr NativeFieldInfoPtr_soundGroups;

		// Token: 0x040049E5 RID: 18917
		private static readonly IntPtr NativeFieldInfoPtr_materialFootstepSounds;

		// Token: 0x040049E6 RID: 18918
		private static readonly IntPtr NativeFieldInfoPtr_lastStepTime;

		// Token: 0x040049E7 RID: 18919
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040049E8 RID: 18920
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040049E9 RID: 18921
		private static readonly IntPtr NativeMethodInfoPtr_Step_Public_Void_EMaterialType_Single_0;

		// Token: 0x040049EA RID: 18922
		private static readonly IntPtr NativeMethodInfoPtr_GetFreeSource_Public_AudioSourceController_0;

		// Token: 0x040049EB RID: 18923
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A5C RID: 2652
		[Serializable]
		public class FootstepSoundGroup : Il2CppSystem.Object
		{
			// Token: 0x0600D0A1 RID: 53409 RVA: 0x00320700 File Offset: 0x0031E900
			// Note: this type is marked as 'beforefieldinit'.
			static FootstepSoundGroup()
			{
				Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "FootstepSoundGroup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr);
				FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "name");
				FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "clips");
				FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_appliesTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "appliesTo");
				FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_PitchMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "PitchMin");
				FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_PitchMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "PitchMax");
				FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "Volume");
				FootstepSounds.FootstepSoundGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, 100676950);
			}

			// Token: 0x0600D0A2 RID: 53410 RVA: 0x003207B8 File Offset: 0x0031E9B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216595, XrefRangeEnd = 216610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FootstepSoundGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.FootstepSoundGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0A3 RID: 53411 RVA: 0x0006591F File Offset: 0x00063B1F
			public FootstepSoundGroup(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040CD RID: 16589
			// (get) Token: 0x0600D0A4 RID: 53412 RVA: 0x003207F4 File Offset: 0x0031E9F4
			// (set) Token: 0x0600D0A5 RID: 53413 RVA: 0x00065928 File Offset: 0x00063B28
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170040CE RID: 16590
			// (get) Token: 0x0600D0A6 RID: 53414 RVA: 0x0032081C File Offset: 0x0031EA1C
			// (set) Token: 0x0600D0A7 RID: 53415 RVA: 0x00065947 File Offset: 0x00063B47
			public unsafe List<AudioClip> clips
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_clips);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_clips), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040CF RID: 16591
			// (get) Token: 0x0600D0A8 RID: 53416 RVA: 0x0032084C File Offset: 0x0031EA4C
			// (set) Token: 0x0600D0A9 RID: 53417 RVA: 0x00065966 File Offset: 0x00063B66
			public unsafe List<FootstepSounds.FootstepSoundGroup.MaterialType> appliesTo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_appliesTo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FootstepSounds.FootstepSoundGroup.MaterialType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_appliesTo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040D0 RID: 16592
			// (get) Token: 0x0600D0AA RID: 53418 RVA: 0x0032087C File Offset: 0x0031EA7C
			// (set) Token: 0x0600D0AB RID: 53419 RVA: 0x00065985 File Offset: 0x00063B85
			public unsafe float PitchMin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_PitchMin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_PitchMin)) = value;
				}
			}

			// Token: 0x170040D1 RID: 16593
			// (get) Token: 0x0600D0AC RID: 53420 RVA: 0x003208A4 File Offset: 0x0031EAA4
			// (set) Token: 0x0600D0AD RID: 53421 RVA: 0x000659A0 File Offset: 0x00063BA0
			public unsafe float PitchMax
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_PitchMax);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_PitchMax)) = value;
				}
			}

			// Token: 0x170040D2 RID: 16594
			// (get) Token: 0x0600D0AE RID: 53422 RVA: 0x003208CC File Offset: 0x0031EACC
			// (set) Token: 0x0600D0AF RID: 53423 RVA: 0x000659BB File Offset: 0x00063BBB
			public unsafe float Volume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_Volume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_Volume)) = value;
				}
			}

			// Token: 0x04008CCD RID: 36045
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04008CCE RID: 36046
			private static readonly IntPtr NativeFieldInfoPtr_clips;

			// Token: 0x04008CCF RID: 36047
			private static readonly IntPtr NativeFieldInfoPtr_appliesTo;

			// Token: 0x04008CD0 RID: 36048
			private static readonly IntPtr NativeFieldInfoPtr_PitchMin;

			// Token: 0x04008CD1 RID: 36049
			private static readonly IntPtr NativeFieldInfoPtr_PitchMax;

			// Token: 0x04008CD2 RID: 36050
			private static readonly IntPtr NativeFieldInfoPtr_Volume;

			// Token: 0x04008CD3 RID: 36051
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000C5E RID: 3166
			[Serializable]
			public class MaterialType : Il2CppSystem.Object
			{
				// Token: 0x0600E3F4 RID: 58356 RVA: 0x00357B38 File Offset: 0x00355D38
				// Note: this type is marked as 'beforefieldinit'.
				static MaterialType()
				{
					Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup.MaterialType>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "MaterialType");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup.MaterialType>.NativeClassPtr);
					FootstepSounds.FootstepSoundGroup.MaterialType.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup.MaterialType>.NativeClassPtr, "type");
					FootstepSounds.FootstepSoundGroup.MaterialType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup.MaterialType>.NativeClassPtr, 100676951);
				}

				// Token: 0x0600E3F5 RID: 58357 RVA: 0x00357B8C File Offset: 0x00355D8C
				[CallerCount(2261)]
				[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe MaterialType() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup.MaterialType>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.FootstepSoundGroup.MaterialType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3F6 RID: 58358 RVA: 0x0006F1E4 File Offset: 0x0006D3E4
				public MaterialType(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046C2 RID: 18114
				// (get) Token: 0x0600E3F7 RID: 58359 RVA: 0x00357BC8 File Offset: 0x00355DC8
				// (set) Token: 0x0600E3F8 RID: 58360 RVA: 0x0006F1ED File Offset: 0x0006D3ED
				public unsafe EMaterialType type
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.MaterialType.NativeFieldInfoPtr_type);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.MaterialType.NativeFieldInfoPtr_type)) = value;
					}
				}

				// Token: 0x04009884 RID: 39044
				private static readonly IntPtr NativeFieldInfoPtr_type;

				// Token: 0x04009885 RID: 39045
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}
		}

		// Token: 0x02000A5D RID: 2653
		[ObfuscatedName("ScheduleOne.Audio.FootstepSounds+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D0B0 RID: 53424 RVA: 0x003208F4 File Offset: 0x0031EAF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr);
				FootstepSounds.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr, "<>9");
				FootstepSounds.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr, "<>9__9_0");
				FootstepSounds.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr, 100676953);
				FootstepSounds.__c.NativeMethodInfoPtr__GetFreeSource_b__9_0_Internal_Boolean_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr, 100676954);
			}

			// Token: 0x0600D0B1 RID: 53425 RVA: 0x00320970 File Offset: 0x0031EB70
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0B2 RID: 53426 RVA: 0x003209AC File Offset: 0x0031EBAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216610, XrefRangeEnd = 216611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFreeSource_b__9_0(AudioSourceController source)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c.NativeMethodInfoPtr__GetFreeSource_b__9_0_Internal_Boolean_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0B3 RID: 53427 RVA: 0x000659D6 File Offset: 0x00063BD6
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040D3 RID: 16595
			// (get) Token: 0x0600D0B4 RID: 53428 RVA: 0x003209FC File Offset: 0x0031EBFC
			// (set) Token: 0x0600D0B5 RID: 53429 RVA: 0x000659DF File Offset: 0x00063BDF
			public unsafe static FootstepSounds.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FootstepSounds.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootstepSounds.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FootstepSounds.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040D4 RID: 16596
			// (get) Token: 0x0600D0B6 RID: 53430 RVA: 0x00320A24 File Offset: 0x0031EC24
			// (set) Token: 0x0600D0B7 RID: 53431 RVA: 0x000659F1 File Offset: 0x00063BF1
			public unsafe static Func<AudioSourceController, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FootstepSounds.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AudioSourceController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FootstepSounds.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CD4 RID: 36052
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008CD5 RID: 36053
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04008CD6 RID: 36054
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CD7 RID: 36055
			private static readonly IntPtr NativeMethodInfoPtr__GetFreeSource_b__9_0_Internal_Boolean_AudioSourceController_0;
		}

		// Token: 0x02000A5E RID: 2654
		[ObfuscatedName("ScheduleOne.Audio.FootstepSounds+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D0B8 RID: 53432 RVA: 0x00320A4C File Offset: 0x0031EC4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0>.NativeClassPtr);
				FootstepSounds.__c__DisplayClass8_0.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0>.NativeClassPtr, "source");
				FootstepSounds.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0>.NativeClassPtr, 100676955);
				FootstepSounds.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0>.NativeClassPtr, 100676956);
			}

			// Token: 0x0600D0B9 RID: 53433 RVA: 0x00320AB4 File Offset: 0x0031ECB4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0BA RID: 53434 RVA: 0x00320AF0 File Offset: 0x0031ECF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216623, XrefRangeEnd = 216628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D0BB RID: 53435 RVA: 0x00065A03 File Offset: 0x00063C03
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040D5 RID: 16597
			// (get) Token: 0x0600D0BC RID: 53436 RVA: 0x00320B30 File Offset: 0x0031ED30
			// (set) Token: 0x0600D0BD RID: 53437 RVA: 0x00065A0C File Offset: 0x00063C0C
			public unsafe AudioSourceController source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass8_0.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass8_0.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CD8 RID: 36056
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04008CD9 RID: 36057
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CDA RID: 36058
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C5F RID: 3167
			[ObfuscatedName("ScheduleOne.Audio.FootstepSounds+<>c__DisplayClass8_0+<<Step>g__DisableSource|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E3F9 RID: 58361 RVA: 0x00357BF0 File Offset: 0x00355DF0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0>.NativeClassPtr, "<<Step>g__DisableSource|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676957);
					FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676958);
					FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676959);
					FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676960);
					FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676961);
					FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676962);
				}

				// Token: 0x0600E3FA RID: 58362 RVA: 0x00357CD0 File Offset: 0x00355ED0
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3FB RID: 58363 RVA: 0x00357D18 File Offset: 0x00355F18
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3FC RID: 58364 RVA: 0x00357D4C File Offset: 0x00355F4C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216611, XrefRangeEnd = 216618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046C6 RID: 18118
				// (get) Token: 0x0600E3FD RID: 58365 RVA: 0x00357D88 File Offset: 0x00355F88
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3FE RID: 58366 RVA: 0x00357DC8 File Offset: 0x00355FC8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216618, XrefRangeEnd = 216623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046C7 RID: 18119
				// (get) Token: 0x0600E3FF RID: 58367 RVA: 0x00357DFC File Offset: 0x00355FFC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E400 RID: 58368 RVA: 0x0006F208 File Offset: 0x0006D408
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046C3 RID: 18115
				// (get) Token: 0x0600E401 RID: 58369 RVA: 0x00357E3C File Offset: 0x0035603C
				// (set) Token: 0x0600E402 RID: 58370 RVA: 0x0006F211 File Offset: 0x0006D411
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046C4 RID: 18116
				// (get) Token: 0x0600E403 RID: 58371 RVA: 0x00357E64 File Offset: 0x00356064
				// (set) Token: 0x0600E404 RID: 58372 RVA: 0x0006F22C File Offset: 0x0006D42C
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046C5 RID: 18117
				// (get) Token: 0x0600E405 RID: 58373 RVA: 0x00357E94 File Offset: 0x00356094
				// (set) Token: 0x0600E406 RID: 58374 RVA: 0x0006F24B File Offset: 0x0006D44B
				public unsafe FootstepSounds.__c__DisplayClass8_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootstepSounds.__c__DisplayClass8_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009886 RID: 39046
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009887 RID: 39047
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009888 RID: 39048
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009889 RID: 39049
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400988A RID: 39050
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400988B RID: 39051
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400988C RID: 39052
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400988D RID: 39053
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400988E RID: 39054
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
