using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D9 RID: 1241
	public class SFXManager : Singleton<SFXManager>
	{
		// Token: 0x06006C7C RID: 27772 RVA: 0x001E1A28 File Offset: 0x001DFC28
		// Note: this type is marked as 'beforefieldinit'.
		static SFXManager()
		{
			Il2CppClassPointerStore<SFXManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "SFXManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SFXManager>.NativeClassPtr);
			SFXManager.NativeFieldInfoPtr_MAX_PLAYER_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "MAX_PLAYER_DISTANCE");
			SFXManager.NativeFieldInfoPtr_SQR_MAX_PLAYER_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "SQR_MAX_PLAYER_DISTANCE");
			SFXManager.NativeFieldInfoPtr_ImpactTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "ImpactTypes");
			SFXManager.NativeFieldInfoPtr_soundPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "soundPool");
			SFXManager.NativeFieldInfoPtr_soundsInUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "soundsInUse");
			SFXManager.NativeMethodInfoPtr_PlayImpactSound_Public_Void_EMaterial_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100677004);
			SFXManager.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100677005);
			SFXManager.NativeMethodInfoPtr_GetSource_Private_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100677006);
			SFXManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100677007);
		}

		// Token: 0x06006C7D RID: 27773 RVA: 0x001E1B0C File Offset: 0x001DFD0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 217227, RefRangeEnd = 217230, XrefRangeStart = 217159, XrefRangeEnd = 217227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayImpactSound(ImpactSoundEntity.EMaterial material, Vector3 position, float momentum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref material;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref momentum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr_PlayImpactSound_Public_Void_EMaterial_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C7E RID: 27774 RVA: 0x001E1B68 File Offset: 0x001DFD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217230, XrefRangeEnd = 217243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C7F RID: 27775 RVA: 0x001E1B9C File Offset: 0x001DFD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217243, XrefRangeEnd = 217253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSourceController GetSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr_GetSource_Private_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr3) : null;
		}

		// Token: 0x06006C80 RID: 27776 RVA: 0x001E1BDC File Offset: 0x001DFDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217253, XrefRangeEnd = 217275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SFXManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SFXManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C81 RID: 27777 RVA: 0x000335C9 File Offset: 0x000317C9
		public SFXManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x06006C82 RID: 27778 RVA: 0x001E1C18 File Offset: 0x001DFE18
		// (set) Token: 0x06006C83 RID: 27779 RVA: 0x000335D2 File Offset: 0x000317D2
		public unsafe static float MAX_PLAYER_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SFXManager.NativeFieldInfoPtr_MAX_PLAYER_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SFXManager.NativeFieldInfoPtr_MAX_PLAYER_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x06006C84 RID: 27780 RVA: 0x001E1C34 File Offset: 0x001DFE34
		// (set) Token: 0x06006C85 RID: 27781 RVA: 0x000335E0 File Offset: 0x000317E0
		public unsafe static float SQR_MAX_PLAYER_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SFXManager.NativeFieldInfoPtr_SQR_MAX_PLAYER_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SFXManager.NativeFieldInfoPtr_SQR_MAX_PLAYER_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x06006C86 RID: 27782 RVA: 0x001E1C50 File Offset: 0x001DFE50
		// (set) Token: 0x06006C87 RID: 27783 RVA: 0x000335EE File Offset: 0x000317EE
		public unsafe List<SFXManager.ImpactType> ImpactTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr_ImpactTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SFXManager.ImpactType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr_ImpactTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x06006C88 RID: 27784 RVA: 0x001E1C80 File Offset: 0x001DFE80
		// (set) Token: 0x06006C89 RID: 27785 RVA: 0x0003360D File Offset: 0x0003180D
		public unsafe List<AudioSourceController> soundPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr_soundPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr_soundPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x06006C8A RID: 27786 RVA: 0x001E1CB0 File Offset: 0x001DFEB0
		// (set) Token: 0x06006C8B RID: 27787 RVA: 0x0003362C File Offset: 0x0003182C
		public unsafe List<AudioSourceController> soundsInUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr_soundsInUse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr_soundsInUse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A2A RID: 18986
		private static readonly IntPtr NativeFieldInfoPtr_MAX_PLAYER_DISTANCE;

		// Token: 0x04004A2B RID: 18987
		private static readonly IntPtr NativeFieldInfoPtr_SQR_MAX_PLAYER_DISTANCE;

		// Token: 0x04004A2C RID: 18988
		private static readonly IntPtr NativeFieldInfoPtr_ImpactTypes;

		// Token: 0x04004A2D RID: 18989
		private static readonly IntPtr NativeFieldInfoPtr_soundPool;

		// Token: 0x04004A2E RID: 18990
		private static readonly IntPtr NativeFieldInfoPtr_soundsInUse;

		// Token: 0x04004A2F RID: 18991
		private static readonly IntPtr NativeMethodInfoPtr_PlayImpactSound_Public_Void_EMaterial_Vector3_Single_0;

		// Token: 0x04004A30 RID: 18992
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004A31 RID: 18993
		private static readonly IntPtr NativeMethodInfoPtr_GetSource_Private_AudioSourceController_0;

		// Token: 0x04004A32 RID: 18994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A62 RID: 2658
		[Serializable]
		public class ImpactType : Il2CppSystem.Object
		{
			// Token: 0x0600D0CA RID: 53450 RVA: 0x00320D98 File Offset: 0x0031EF98
			// Note: this type is marked as 'beforefieldinit'.
			static ImpactType()
			{
				Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "ImpactType");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr);
				SFXManager.ImpactType.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, "Material");
				SFXManager.ImpactType.NativeFieldInfoPtr_MinVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, "MinVolume");
				SFXManager.ImpactType.NativeFieldInfoPtr_MaxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, "MaxVolume");
				SFXManager.ImpactType.NativeFieldInfoPtr_MinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, "MinPitch");
				SFXManager.ImpactType.NativeFieldInfoPtr_MaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, "MaxPitch");
				SFXManager.ImpactType.NativeFieldInfoPtr_Clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, "Clips");
				SFXManager.ImpactType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, 100677008);
			}

			// Token: 0x0600D0CB RID: 53451 RVA: 0x00320E50 File Offset: 0x0031F050
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ImpactType() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.ImpactType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0CC RID: 53452 RVA: 0x00065A7B File Offset: 0x00063C7B
			public ImpactType(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040D8 RID: 16600
			// (get) Token: 0x0600D0CD RID: 53453 RVA: 0x00320E8C File Offset: 0x0031F08C
			// (set) Token: 0x0600D0CE RID: 53454 RVA: 0x00065A84 File Offset: 0x00063C84
			public unsafe ImpactSoundEntity.EMaterial Material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_Material);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_Material)) = value;
				}
			}

			// Token: 0x170040D9 RID: 16601
			// (get) Token: 0x0600D0CF RID: 53455 RVA: 0x00320EB4 File Offset: 0x0031F0B4
			// (set) Token: 0x0600D0D0 RID: 53456 RVA: 0x00065A9F File Offset: 0x00063C9F
			public unsafe float MinVolume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MinVolume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MinVolume)) = value;
				}
			}

			// Token: 0x170040DA RID: 16602
			// (get) Token: 0x0600D0D1 RID: 53457 RVA: 0x00320EDC File Offset: 0x0031F0DC
			// (set) Token: 0x0600D0D2 RID: 53458 RVA: 0x00065ABA File Offset: 0x00063CBA
			public unsafe float MaxVolume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MaxVolume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MaxVolume)) = value;
				}
			}

			// Token: 0x170040DB RID: 16603
			// (get) Token: 0x0600D0D3 RID: 53459 RVA: 0x00320F04 File Offset: 0x0031F104
			// (set) Token: 0x0600D0D4 RID: 53460 RVA: 0x00065AD5 File Offset: 0x00063CD5
			public unsafe float MinPitch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MinPitch);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MinPitch)) = value;
				}
			}

			// Token: 0x170040DC RID: 16604
			// (get) Token: 0x0600D0D5 RID: 53461 RVA: 0x00320F2C File Offset: 0x0031F12C
			// (set) Token: 0x0600D0D6 RID: 53462 RVA: 0x00065AF0 File Offset: 0x00063CF0
			public unsafe float MaxPitch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MaxPitch);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MaxPitch)) = value;
				}
			}

			// Token: 0x170040DD RID: 16605
			// (get) Token: 0x0600D0D7 RID: 53463 RVA: 0x00320F54 File Offset: 0x0031F154
			// (set) Token: 0x0600D0D8 RID: 53464 RVA: 0x00065B0B File Offset: 0x00063D0B
			public unsafe Il2CppReferenceArray<AudioClip> Clips
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_Clips);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_Clips), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CEC RID: 36076
			private static readonly IntPtr NativeFieldInfoPtr_Material;

			// Token: 0x04008CED RID: 36077
			private static readonly IntPtr NativeFieldInfoPtr_MinVolume;

			// Token: 0x04008CEE RID: 36078
			private static readonly IntPtr NativeFieldInfoPtr_MaxVolume;

			// Token: 0x04008CEF RID: 36079
			private static readonly IntPtr NativeFieldInfoPtr_MinPitch;

			// Token: 0x04008CF0 RID: 36080
			private static readonly IntPtr NativeFieldInfoPtr_MaxPitch;

			// Token: 0x04008CF1 RID: 36081
			private static readonly IntPtr NativeFieldInfoPtr_Clips;

			// Token: 0x04008CF2 RID: 36082
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A63 RID: 2659
		[ObfuscatedName("ScheduleOne.Audio.SFXManager+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D0D9 RID: 53465 RVA: 0x00320F84 File Offset: 0x0031F184
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<SFXManager.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SFXManager.__c__DisplayClass6_0>.NativeClassPtr);
				SFXManager.__c__DisplayClass6_0.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.__c__DisplayClass6_0>.NativeClassPtr, "material");
				SFXManager.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager.__c__DisplayClass6_0>.NativeClassPtr, 100677009);
				SFXManager.__c__DisplayClass6_0.NativeMethodInfoPtr__PlayImpactSound_b__0_Internal_Boolean_ImpactType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager.__c__DisplayClass6_0>.NativeClassPtr, 100677010);
			}

			// Token: 0x0600D0DA RID: 53466 RVA: 0x00320FEC File Offset: 0x0031F1EC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SFXManager.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0DB RID: 53467 RVA: 0x00321028 File Offset: 0x0031F228
			[CallerCount(0)]
			public unsafe bool _PlayImpactSound_b__0(SFXManager.ImpactType x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.__c__DisplayClass6_0.NativeMethodInfoPtr__PlayImpactSound_b__0_Internal_Boolean_ImpactType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0DC RID: 53468 RVA: 0x00065B2A File Offset: 0x00063D2A
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040DE RID: 16606
			// (get) Token: 0x0600D0DD RID: 53469 RVA: 0x00321078 File Offset: 0x0031F278
			// (set) Token: 0x0600D0DE RID: 53470 RVA: 0x00065B33 File Offset: 0x00063D33
			public unsafe ImpactSoundEntity.EMaterial material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.__c__DisplayClass6_0.NativeFieldInfoPtr_material);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.__c__DisplayClass6_0.NativeFieldInfoPtr_material)) = value;
				}
			}

			// Token: 0x04008CF3 RID: 36083
			private static readonly IntPtr NativeFieldInfoPtr_material;

			// Token: 0x04008CF4 RID: 36084
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CF5 RID: 36085
			private static readonly IntPtr NativeMethodInfoPtr__PlayImpactSound_b__0_Internal_Boolean_ImpactType_0;
		}
	}
}
