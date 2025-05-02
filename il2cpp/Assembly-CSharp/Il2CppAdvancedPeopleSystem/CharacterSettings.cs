using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000155 RID: 341
	public class CharacterSettings : ScriptableObject
	{
		// Token: 0x06001BD1 RID: 7121 RVA: 0x000C7364 File Offset: 0x000C5564
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterSettings()
		{
			Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr);
			CharacterSettings.NativeFieldInfoPtr_OriginalMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, "OriginalMesh");
			CharacterSettings.NativeFieldInfoPtr_bodyMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, "bodyMaterial");
			CharacterSettings.NativeFieldInfoPtr_characterAnimationPresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, "characterAnimationPresets");
			CharacterSettings.NativeFieldInfoPtr_characterBlendshapeDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, "characterBlendshapeDatas");
			CharacterSettings.NativeFieldInfoPtr_hairPresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, "hairPresets");
			CharacterSettings.NativeFieldInfoPtr_beardPresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, "beardPresets");
			CharacterSettings.NativeFieldInfoPtr_hatsPresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, "hatsPresets");
			CharacterSettings.NativeFieldInfoPtr_accessoryPresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, "accessoryPresets");
			CharacterSettings.NativeFieldInfoPtr_shirtsPresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, "shirtsPresets");
			CharacterSettings.NativeFieldInfoPtr_pantsPresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, "pantsPresets");
			CharacterSettings.NativeFieldInfoPtr_shoesPresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, "shoesPresets");
			CharacterSettings.NativeFieldInfoPtr_item1Presets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, "item1Presets");
			CharacterSettings.NativeFieldInfoPtr_settingsSelectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, "settingsSelectors");
			CharacterSettings.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, "Animator");
			CharacterSettings.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, "Avatar");
			CharacterSettings.NativeFieldInfoPtr_generator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, "generator");
			CharacterSettings.NativeFieldInfoPtr_DefaultSelectedElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, "DefaultSelectedElements");
			CharacterSettings.NativeFieldInfoPtr_DisableBlendshapeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, "DisableBlendshapeModifier");
			CharacterSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr, 100666234);
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x000C7510 File Offset: 0x000C5710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100521, XrefRangeEnd = 100590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0000FC64 File Offset: 0x0000DE64
		public CharacterSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x000C754C File Offset: 0x000C574C
		// (set) Token: 0x06001BD5 RID: 7125 RVA: 0x0000FC6D File Offset: 0x0000DE6D
		public unsafe GameObject OriginalMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_OriginalMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_OriginalMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x000C757C File Offset: 0x000C577C
		// (set) Token: 0x06001BD7 RID: 7127 RVA: 0x0000FC8C File Offset: 0x0000DE8C
		public unsafe Material bodyMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_bodyMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_bodyMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x000C75AC File Offset: 0x000C57AC
		// (set) Token: 0x06001BD9 RID: 7129 RVA: 0x0000FCAB File Offset: 0x0000DEAB
		public unsafe List<CharacterAnimationPreset> characterAnimationPresets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_characterAnimationPresets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterAnimationPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_characterAnimationPresets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06001BDA RID: 7130 RVA: 0x000C75DC File Offset: 0x000C57DC
		// (set) Token: 0x06001BDB RID: 7131 RVA: 0x0000FCCA File Offset: 0x0000DECA
		public unsafe List<CharacterBlendshapeData> characterBlendshapeDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_characterBlendshapeDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterBlendshapeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_characterBlendshapeDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001BDC RID: 7132 RVA: 0x000C760C File Offset: 0x000C580C
		// (set) Token: 0x06001BDD RID: 7133 RVA: 0x0000FCE9 File Offset: 0x0000DEE9
		public unsafe List<CharacterElementsPreset> hairPresets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_hairPresets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterElementsPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_hairPresets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001BDE RID: 7134 RVA: 0x000C763C File Offset: 0x000C583C
		// (set) Token: 0x06001BDF RID: 7135 RVA: 0x0000FD08 File Offset: 0x0000DF08
		public unsafe List<CharacterElementsPreset> beardPresets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_beardPresets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterElementsPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_beardPresets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x000C766C File Offset: 0x000C586C
		// (set) Token: 0x06001BE1 RID: 7137 RVA: 0x0000FD27 File Offset: 0x0000DF27
		public unsafe List<CharacterElementsPreset> hatsPresets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_hatsPresets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterElementsPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_hatsPresets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x000C769C File Offset: 0x000C589C
		// (set) Token: 0x06001BE3 RID: 7139 RVA: 0x0000FD46 File Offset: 0x0000DF46
		public unsafe List<CharacterElementsPreset> accessoryPresets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_accessoryPresets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterElementsPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_accessoryPresets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x000C76CC File Offset: 0x000C58CC
		// (set) Token: 0x06001BE5 RID: 7141 RVA: 0x0000FD65 File Offset: 0x0000DF65
		public unsafe List<CharacterElementsPreset> shirtsPresets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_shirtsPresets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterElementsPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_shirtsPresets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x000C76FC File Offset: 0x000C58FC
		// (set) Token: 0x06001BE7 RID: 7143 RVA: 0x0000FD84 File Offset: 0x0000DF84
		public unsafe List<CharacterElementsPreset> pantsPresets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_pantsPresets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterElementsPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_pantsPresets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x000C772C File Offset: 0x000C592C
		// (set) Token: 0x06001BE9 RID: 7145 RVA: 0x0000FDA3 File Offset: 0x0000DFA3
		public unsafe List<CharacterElementsPreset> shoesPresets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_shoesPresets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterElementsPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_shoesPresets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001BEA RID: 7146 RVA: 0x000C775C File Offset: 0x000C595C
		// (set) Token: 0x06001BEB RID: 7147 RVA: 0x0000FDC2 File Offset: 0x0000DFC2
		public unsafe List<CharacterElementsPreset> item1Presets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_item1Presets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterElementsPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_item1Presets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06001BEC RID: 7148 RVA: 0x000C778C File Offset: 0x000C598C
		// (set) Token: 0x06001BED RID: 7149 RVA: 0x0000FDE1 File Offset: 0x0000DFE1
		public unsafe List<CharacterSettingsSelector> settingsSelectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_settingsSelectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterSettingsSelector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_settingsSelectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x000C77BC File Offset: 0x000C59BC
		// (set) Token: 0x06001BEF RID: 7151 RVA: 0x0000FE00 File Offset: 0x0000E000
		public unsafe RuntimeAnimatorController Animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_Animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x000C77EC File Offset: 0x000C59EC
		// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x0000FE1F File Offset: 0x0000E01F
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x000C781C File Offset: 0x000C5A1C
		// (set) Token: 0x06001BF3 RID: 7155 RVA: 0x0000FE3E File Offset: 0x0000E03E
		public unsafe CharacterGeneratorSettings generator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_generator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterGeneratorSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_generator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x000C784C File Offset: 0x000C5A4C
		// (set) Token: 0x06001BF5 RID: 7157 RVA: 0x0000FE5D File Offset: 0x0000E05D
		public unsafe CharacterSelectedElements DefaultSelectedElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_DefaultSelectedElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSelectedElements>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_DefaultSelectedElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x000C787C File Offset: 0x000C5A7C
		// (set) Token: 0x06001BF7 RID: 7159 RVA: 0x0000FE7C File Offset: 0x0000E07C
		public unsafe bool DisableBlendshapeModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_DisableBlendshapeModifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettings.NativeFieldInfoPtr_DisableBlendshapeModifier)) = value;
			}
		}

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeFieldInfoPtr_OriginalMesh;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeFieldInfoPtr_bodyMaterial;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeFieldInfoPtr_characterAnimationPresets;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeFieldInfoPtr_characterBlendshapeDatas;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeFieldInfoPtr_hairPresets;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeFieldInfoPtr_beardPresets;

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeFieldInfoPtr_hatsPresets;

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeFieldInfoPtr_accessoryPresets;

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeFieldInfoPtr_shirtsPresets;

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeFieldInfoPtr_pantsPresets;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeFieldInfoPtr_shoesPresets;

		// Token: 0x04001252 RID: 4690
		private static readonly IntPtr NativeFieldInfoPtr_item1Presets;

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeFieldInfoPtr_settingsSelectors;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeFieldInfoPtr_Animator;

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeFieldInfoPtr_generator;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSelectedElements;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeFieldInfoPtr_DisableBlendshapeModifier;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
