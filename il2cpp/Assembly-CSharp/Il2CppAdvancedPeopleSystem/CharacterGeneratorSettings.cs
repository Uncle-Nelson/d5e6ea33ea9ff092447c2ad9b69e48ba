using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x0200014A RID: 330
	public class CharacterGeneratorSettings : ScriptableObject
	{
		// Token: 0x06001B5F RID: 7007 RVA: 0x000C62C4 File Offset: 0x000C44C4
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterGeneratorSettings()
		{
			Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterGeneratorSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr);
			CharacterGeneratorSettings.NativeFieldInfoPtr_hair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "hair");
			CharacterGeneratorSettings.NativeFieldInfoPtr_beard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "beard");
			CharacterGeneratorSettings.NativeFieldInfoPtr_hat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "hat");
			CharacterGeneratorSettings.NativeFieldInfoPtr_accessory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "accessory");
			CharacterGeneratorSettings.NativeFieldInfoPtr_shirt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "shirt");
			CharacterGeneratorSettings.NativeFieldInfoPtr_pants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "pants");
			CharacterGeneratorSettings.NativeFieldInfoPtr_shoes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "shoes");
			CharacterGeneratorSettings.NativeFieldInfoPtr_skinColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "skinColors");
			CharacterGeneratorSettings.NativeFieldInfoPtr_eyeColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "eyeColors");
			CharacterGeneratorSettings.NativeFieldInfoPtr_hairColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "hairColors");
			CharacterGeneratorSettings.NativeFieldInfoPtr_headSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "headSize");
			CharacterGeneratorSettings.NativeFieldInfoPtr_headOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "headOffset");
			CharacterGeneratorSettings.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "height");
			CharacterGeneratorSettings.NativeFieldInfoPtr_fat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "fat");
			CharacterGeneratorSettings.NativeFieldInfoPtr_muscles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "muscles");
			CharacterGeneratorSettings.NativeFieldInfoPtr_thin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "thin");
			CharacterGeneratorSettings.NativeFieldInfoPtr_facialBlendshapes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "facialBlendshapes");
			CharacterGeneratorSettings.NativeFieldInfoPtr_excludes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "excludes");
			CharacterGeneratorSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, 100666220);
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x000C6470 File Offset: 0x000C4670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100424, XrefRangeEnd = 100452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterGeneratorSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterGeneratorSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x0000F75E File Offset: 0x0000D95E
		public CharacterGeneratorSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001B62 RID: 7010 RVA: 0x000C64AC File Offset: 0x000C46AC
		// (set) Token: 0x06001B63 RID: 7011 RVA: 0x0000F767 File Offset: 0x0000D967
		public unsafe MinMaxIndex hair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_hair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxIndex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_hair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001B64 RID: 7012 RVA: 0x000C64DC File Offset: 0x000C46DC
		// (set) Token: 0x06001B65 RID: 7013 RVA: 0x0000F786 File Offset: 0x0000D986
		public unsafe MinMaxIndex beard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_beard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxIndex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_beard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001B66 RID: 7014 RVA: 0x000C650C File Offset: 0x000C470C
		// (set) Token: 0x06001B67 RID: 7015 RVA: 0x0000F7A5 File Offset: 0x0000D9A5
		public unsafe MinMaxIndex hat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_hat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxIndex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_hat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x000C653C File Offset: 0x000C473C
		// (set) Token: 0x06001B69 RID: 7017 RVA: 0x0000F7C4 File Offset: 0x0000D9C4
		public unsafe MinMaxIndex accessory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_accessory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxIndex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_accessory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x000C656C File Offset: 0x000C476C
		// (set) Token: 0x06001B6B RID: 7019 RVA: 0x0000F7E3 File Offset: 0x0000D9E3
		public unsafe MinMaxIndex shirt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_shirt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxIndex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_shirt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x000C659C File Offset: 0x000C479C
		// (set) Token: 0x06001B6D RID: 7021 RVA: 0x0000F802 File Offset: 0x0000DA02
		public unsafe MinMaxIndex pants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_pants);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxIndex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_pants), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001B6E RID: 7022 RVA: 0x000C65CC File Offset: 0x000C47CC
		// (set) Token: 0x06001B6F RID: 7023 RVA: 0x0000F821 File Offset: 0x0000DA21
		public unsafe MinMaxIndex shoes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_shoes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxIndex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_shoes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001B70 RID: 7024 RVA: 0x000C65FC File Offset: 0x000C47FC
		// (set) Token: 0x06001B71 RID: 7025 RVA: 0x0000F840 File Offset: 0x0000DA40
		public unsafe MinMaxColor skinColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_skinColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxColor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_skinColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x000C662C File Offset: 0x000C482C
		// (set) Token: 0x06001B73 RID: 7027 RVA: 0x0000F85F File Offset: 0x0000DA5F
		public unsafe MinMaxColor eyeColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_eyeColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxColor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_eyeColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001B74 RID: 7028 RVA: 0x000C665C File Offset: 0x000C485C
		// (set) Token: 0x06001B75 RID: 7029 RVA: 0x0000F87E File Offset: 0x0000DA7E
		public unsafe MinMaxColor hairColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_hairColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxColor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_hairColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x000C668C File Offset: 0x000C488C
		// (set) Token: 0x06001B77 RID: 7031 RVA: 0x0000F89D File Offset: 0x0000DA9D
		public unsafe MinMaxBlendshapes headSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_headSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxBlendshapes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_headSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x000C66BC File Offset: 0x000C48BC
		// (set) Token: 0x06001B79 RID: 7033 RVA: 0x0000F8BC File Offset: 0x0000DABC
		public unsafe MinMaxBlendshapes headOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_headOffset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxBlendshapes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_headOffset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x000C66EC File Offset: 0x000C48EC
		// (set) Token: 0x06001B7B RID: 7035 RVA: 0x0000F8DB File Offset: 0x0000DADB
		public unsafe MinMaxBlendshapes height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_height);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxBlendshapes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_height), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x000C671C File Offset: 0x000C491C
		// (set) Token: 0x06001B7D RID: 7037 RVA: 0x0000F8FA File Offset: 0x0000DAFA
		public unsafe MinMaxBlendshapes fat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_fat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxBlendshapes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_fat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x000C674C File Offset: 0x000C494C
		// (set) Token: 0x06001B7F RID: 7039 RVA: 0x0000F919 File Offset: 0x0000DB19
		public unsafe MinMaxBlendshapes muscles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_muscles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxBlendshapes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_muscles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001B80 RID: 7040 RVA: 0x000C677C File Offset: 0x000C497C
		// (set) Token: 0x06001B81 RID: 7041 RVA: 0x0000F938 File Offset: 0x0000DB38
		public unsafe MinMaxBlendshapes thin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_thin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxBlendshapes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_thin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001B82 RID: 7042 RVA: 0x000C67AC File Offset: 0x000C49AC
		// (set) Token: 0x06001B83 RID: 7043 RVA: 0x0000F957 File Offset: 0x0000DB57
		public unsafe List<MinMaxFacialBlendshapes> facialBlendshapes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_facialBlendshapes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MinMaxFacialBlendshapes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_facialBlendshapes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x000C67DC File Offset: 0x000C49DC
		// (set) Token: 0x06001B85 RID: 7045 RVA: 0x0000F976 File Offset: 0x0000DB76
		public unsafe List<GeneratorExclude> excludes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_excludes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GeneratorExclude>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_excludes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeFieldInfoPtr_hair;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeFieldInfoPtr_beard;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeFieldInfoPtr_hat;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeFieldInfoPtr_accessory;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeFieldInfoPtr_shirt;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeFieldInfoPtr_pants;

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeFieldInfoPtr_shoes;

		// Token: 0x04001210 RID: 4624
		private static readonly IntPtr NativeFieldInfoPtr_skinColors;

		// Token: 0x04001211 RID: 4625
		private static readonly IntPtr NativeFieldInfoPtr_eyeColors;

		// Token: 0x04001212 RID: 4626
		private static readonly IntPtr NativeFieldInfoPtr_hairColors;

		// Token: 0x04001213 RID: 4627
		private static readonly IntPtr NativeFieldInfoPtr_headSize;

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeFieldInfoPtr_headOffset;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeFieldInfoPtr_fat;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeFieldInfoPtr_muscles;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeFieldInfoPtr_thin;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeFieldInfoPtr_facialBlendshapes;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeFieldInfoPtr_excludes;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
