using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000158 RID: 344
	[Serializable]
	public class CharacterAnimationPreset : Il2CppSystem.Object
	{
		// Token: 0x06001C0C RID: 7180 RVA: 0x000C7B68 File Offset: 0x000C5D68
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterAnimationPreset()
		{
			Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterAnimationPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr);
			CharacterAnimationPreset.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr, "name");
			CharacterAnimationPreset.NativeFieldInfoPtr_blendshapes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr, "blendshapes");
			CharacterAnimationPreset.NativeFieldInfoPtr_UseGlobalBlendCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr, "UseGlobalBlendCurve");
			CharacterAnimationPreset.NativeFieldInfoPtr_GlobalBlendAnimationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr, "GlobalBlendAnimationCurve");
			CharacterAnimationPreset.NativeFieldInfoPtr_AnimationPlayDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr, "AnimationPlayDuration");
			CharacterAnimationPreset.NativeFieldInfoPtr_weightPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr, "weightPower");
			CharacterAnimationPreset.NativeFieldInfoPtr_applyToAllCharacterMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr, "applyToAllCharacterMeshes");
			CharacterAnimationPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr, 100666237);
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x000C7C38 File Offset: 0x000C5E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100590, XrefRangeEnd = 100609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterAnimationPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x0000FF7E File Offset: 0x0000E17E
		public CharacterAnimationPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001C0F RID: 7183 RVA: 0x000C7C74 File Offset: 0x000C5E74
		// (set) Token: 0x06001C10 RID: 7184 RVA: 0x0000FF87 File Offset: 0x0000E187
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001C11 RID: 7185 RVA: 0x000C7C9C File Offset: 0x000C5E9C
		// (set) Token: 0x06001C12 RID: 7186 RVA: 0x0000FFA6 File Offset: 0x0000E1A6
		public unsafe List<BlendshapeEmotionValue> blendshapes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_blendshapes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BlendshapeEmotionValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_blendshapes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001C13 RID: 7187 RVA: 0x000C7CCC File Offset: 0x000C5ECC
		// (set) Token: 0x06001C14 RID: 7188 RVA: 0x0000FFC5 File Offset: 0x0000E1C5
		public unsafe bool UseGlobalBlendCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_UseGlobalBlendCurve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_UseGlobalBlendCurve)) = value;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001C15 RID: 7189 RVA: 0x000C7CF4 File Offset: 0x000C5EF4
		// (set) Token: 0x06001C16 RID: 7190 RVA: 0x0000FFE0 File Offset: 0x0000E1E0
		public unsafe AnimationCurve GlobalBlendAnimationCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_GlobalBlendAnimationCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_GlobalBlendAnimationCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x000C7D24 File Offset: 0x000C5F24
		// (set) Token: 0x06001C18 RID: 7192 RVA: 0x0000FFFF File Offset: 0x0000E1FF
		public unsafe float AnimationPlayDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_AnimationPlayDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_AnimationPlayDuration)) = value;
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x000C7D4C File Offset: 0x000C5F4C
		// (set) Token: 0x06001C1A RID: 7194 RVA: 0x0001001A File Offset: 0x0000E21A
		public unsafe float weightPower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_weightPower);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_weightPower)) = value;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x000C7D74 File Offset: 0x000C5F74
		// (set) Token: 0x06001C1C RID: 7196 RVA: 0x00010035 File Offset: 0x0000E235
		public unsafe bool applyToAllCharacterMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_applyToAllCharacterMeshes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_applyToAllCharacterMeshes)) = value;
			}
		}

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeFieldInfoPtr_blendshapes;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeFieldInfoPtr_UseGlobalBlendCurve;

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeFieldInfoPtr_GlobalBlendAnimationCurve;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeFieldInfoPtr_AnimationPlayDuration;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeFieldInfoPtr_weightPower;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeFieldInfoPtr_applyToAllCharacterMeshes;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
