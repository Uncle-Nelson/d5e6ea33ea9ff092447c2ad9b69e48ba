using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAmplifyColor
{
	// Token: 0x02000799 RID: 1945
	[Serializable]
	public class VolumeEffect : Il2CppSystem.Object
	{
		// Token: 0x0600B81C RID: 47132 RVA: 0x002DAF80 File Offset: 0x002D9180
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeEffect()
		{
			Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyColor", "VolumeEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr);
			VolumeEffect.NativeFieldInfoPtr_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, "gameObject");
			VolumeEffect.NativeFieldInfoPtr_components = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, "components");
			VolumeEffect.NativeMethodInfoPtr__ctor_Public_Void_AmplifyColorEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685913);
			VolumeEffect.NativeMethodInfoPtr_BlendValuesToVolumeEffect_Public_Static_VolumeEffect_VolumeEffectFlags_VolumeEffect_VolumeEffect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685914);
			VolumeEffect.NativeMethodInfoPtr_AddComponent_Public_VolumeEffectComponent_Component_VolumeEffectComponentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685915);
			VolumeEffect.NativeMethodInfoPtr_RemoveEffectComponent_Public_Void_VolumeEffectComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685916);
			VolumeEffect.NativeMethodInfoPtr_UpdateVolume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685917);
			VolumeEffect.NativeMethodInfoPtr_SetValues_Public_Void_AmplifyColorEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685918);
			VolumeEffect.NativeMethodInfoPtr_BlendValues_Public_Void_AmplifyColorEffect_VolumeEffect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685919);
			VolumeEffect.NativeMethodInfoPtr_FindEffectComponent_Public_VolumeEffectComponent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685920);
			VolumeEffect.NativeMethodInfoPtr_ListAcceptableComponents_Public_Static_Il2CppReferenceArray_1_Component_AmplifyColorEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685921);
			VolumeEffect.NativeMethodInfoPtr_GetComponentNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685922);
		}

		// Token: 0x0600B81D RID: 47133 RVA: 0x002DB0A0 File Offset: 0x002D92A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 313317, RefRangeEnd = 313321, XrefRangeStart = 313308, XrefRangeEnd = 313317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffect(AmplifyColorEffect effect) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(effect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr__ctor_Public_Void_AmplifyColorEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B81E RID: 47134 RVA: 0x002DB0EC File Offset: 0x002D92EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313405, RefRangeEnd = 313407, XrefRangeStart = 313321, XrefRangeEnd = 313405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VolumeEffect BlendValuesToVolumeEffect(VolumeEffectFlags flags, VolumeEffect volume1, VolumeEffect volume2, float blend)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(flags);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(volume1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(volume2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr_BlendValuesToVolumeEffect_Public_Static_VolumeEffect_VolumeEffectFlags_VolumeEffect_VolumeEffect_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffect>(intPtr3) : null;
		}

		// Token: 0x0600B81F RID: 47135 RVA: 0x002DB164 File Offset: 0x002D9364
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313418, RefRangeEnd = 313420, XrefRangeStart = 313407, XrefRangeEnd = 313418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectComponent AddComponent(Component c, VolumeEffectComponentFlags compFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compFlags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr_AddComponent_Public_VolumeEffectComponent_Component_VolumeEffectComponentFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffectComponent>(intPtr3) : null;
		}

		// Token: 0x0600B820 RID: 47136 RVA: 0x002DB1C8 File Offset: 0x002D93C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313420, XrefRangeEnd = 313424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEffectComponent(VolumeEffectComponent comp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(comp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr_RemoveEffectComponent_Public_Void_VolumeEffectComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B821 RID: 47137 RVA: 0x002DB20C File Offset: 0x002D940C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313447, RefRangeEnd = 313449, XrefRangeStart = 313424, XrefRangeEnd = 313447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr_UpdateVolume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B822 RID: 47138 RVA: 0x002DB240 File Offset: 0x002D9440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313525, RefRangeEnd = 313526, XrefRangeStart = 313449, XrefRangeEnd = 313525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValues(AmplifyColorEffect targetColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetColor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr_SetValues_Public_Void_AmplifyColorEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B823 RID: 47139 RVA: 0x002DB284 File Offset: 0x002D9484
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313595, RefRangeEnd = 313596, XrefRangeStart = 313526, XrefRangeEnd = 313595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendValues(AmplifyColorEffect targetColor, VolumeEffect other, float blendAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetColor);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr_BlendValues_Public_Void_AmplifyColorEffect_VolumeEffect_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B824 RID: 47140 RVA: 0x002DB2E8 File Offset: 0x002D94E8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 313604, RefRangeEnd = 313610, XrefRangeStart = 313596, XrefRangeEnd = 313604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectComponent FindEffectComponent(string compName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(compName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr_FindEffectComponent_Public_VolumeEffectComponent_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffectComponent>(intPtr3) : null;
		}

		// Token: 0x0600B825 RID: 47141 RVA: 0x002DB338 File Offset: 0x002D9538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313610, XrefRangeEnd = 313646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Component> ListAcceptableComponents(AmplifyColorEffect go)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr_ListAcceptableComponents_Public_Static_Il2CppReferenceArray_1_Component_AmplifyColorEffect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Component>>(intPtr3) : null;
		}

		// Token: 0x0600B826 RID: 47142 RVA: 0x002DB37C File Offset: 0x002D957C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313646, XrefRangeEnd = 313667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetComponentNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr_GetComponentNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600B827 RID: 47143 RVA: 0x0005A646 File Offset: 0x00058846
		public VolumeEffect(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700390E RID: 14606
		// (get) Token: 0x0600B828 RID: 47144 RVA: 0x002DB3BC File Offset: 0x002D95BC
		// (set) Token: 0x0600B829 RID: 47145 RVA: 0x0005A64F File Offset: 0x0005884F
		public unsafe AmplifyColorEffect gameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffect.NativeFieldInfoPtr_gameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmplifyColorEffect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffect.NativeFieldInfoPtr_gameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700390F RID: 14607
		// (get) Token: 0x0600B82A RID: 47146 RVA: 0x002DB3EC File Offset: 0x002D95EC
		// (set) Token: 0x0600B82B RID: 47147 RVA: 0x0005A66E File Offset: 0x0005886E
		public unsafe List<VolumeEffectComponent> components
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffect.NativeFieldInfoPtr_components);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VolumeEffectComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffect.NativeFieldInfoPtr_components), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007C0C RID: 31756
		private static readonly IntPtr NativeFieldInfoPtr_gameObject;

		// Token: 0x04007C0D RID: 31757
		private static readonly IntPtr NativeFieldInfoPtr_components;

		// Token: 0x04007C0E RID: 31758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AmplifyColorEffect_0;

		// Token: 0x04007C0F RID: 31759
		private static readonly IntPtr NativeMethodInfoPtr_BlendValuesToVolumeEffect_Public_Static_VolumeEffect_VolumeEffectFlags_VolumeEffect_VolumeEffect_Single_0;

		// Token: 0x04007C10 RID: 31760
		private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_VolumeEffectComponent_Component_VolumeEffectComponentFlags_0;

		// Token: 0x04007C11 RID: 31761
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEffectComponent_Public_Void_VolumeEffectComponent_0;

		// Token: 0x04007C12 RID: 31762
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVolume_Public_Void_0;

		// Token: 0x04007C13 RID: 31763
		private static readonly IntPtr NativeMethodInfoPtr_SetValues_Public_Void_AmplifyColorEffect_0;

		// Token: 0x04007C14 RID: 31764
		private static readonly IntPtr NativeMethodInfoPtr_BlendValues_Public_Void_AmplifyColorEffect_VolumeEffect_Single_0;

		// Token: 0x04007C15 RID: 31765
		private static readonly IntPtr NativeMethodInfoPtr_FindEffectComponent_Public_VolumeEffectComponent_String_0;

		// Token: 0x04007C16 RID: 31766
		private static readonly IntPtr NativeMethodInfoPtr_ListAcceptableComponents_Public_Static_Il2CppReferenceArray_1_Component_AmplifyColorEffect_0;

		// Token: 0x04007C17 RID: 31767
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentNames_Public_Il2CppStringArray_0;

		// Token: 0x02000C0E RID: 3086
		[ObfuscatedName("AmplifyColor.VolumeEffect+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E067 RID: 57447 RVA: 0x0034D5C0 File Offset: 0x0034B7C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumeEffect.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffect.__c>.NativeClassPtr);
				VolumeEffect.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffect.__c>.NativeClassPtr, "<>9");
				VolumeEffect.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffect.__c>.NativeClassPtr, "<>9__10_0");
				VolumeEffect.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffect.__c>.NativeClassPtr, "<>9__11_0");
				VolumeEffect.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect.__c>.NativeClassPtr, 100685924);
				VolumeEffect.__c.NativeMethodInfoPtr__ListAcceptableComponents_b__10_0_Internal_Boolean_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect.__c>.NativeClassPtr, 100685925);
				VolumeEffect.__c.NativeMethodInfoPtr__GetComponentNames_b__11_0_Internal_String_VolumeEffectComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect.__c>.NativeClassPtr, 100685926);
			}

			// Token: 0x0600E068 RID: 57448 RVA: 0x0034D664 File Offset: 0x0034B864
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffect.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E069 RID: 57449 RVA: 0x0034D6A0 File Offset: 0x0034B8A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313296, XrefRangeEnd = 313308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ListAcceptableComponents_b__10_0(Component comp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.__c.NativeMethodInfoPtr__ListAcceptableComponents_b__10_0_Internal_Boolean_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E06A RID: 57450 RVA: 0x0034D6F0 File Offset: 0x0034B8F0
			[CallerCount(0)]
			public unsafe string _GetComponentNames_b__11_0(VolumeEffectComponent r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.__c.NativeMethodInfoPtr__GetComponentNames_b__11_0_Internal_String_VolumeEffectComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E06B RID: 57451 RVA: 0x0006D62E File Offset: 0x0006B82E
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004587 RID: 17799
			// (get) Token: 0x0600E06C RID: 57452 RVA: 0x0034D738 File Offset: 0x0034B938
			// (set) Token: 0x0600E06D RID: 57453 RVA: 0x0006D637 File Offset: 0x0006B837
			public unsafe static VolumeEffect.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffect.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffect.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffect.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004588 RID: 17800
			// (get) Token: 0x0600E06E RID: 57454 RVA: 0x0034D760 File Offset: 0x0034B960
			// (set) Token: 0x0600E06F RID: 57455 RVA: 0x0006D649 File Offset: 0x0006B849
			public unsafe static Func<Component, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffect.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Component, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffect.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004589 RID: 17801
			// (get) Token: 0x0600E070 RID: 57456 RVA: 0x0034D788 File Offset: 0x0034B988
			// (set) Token: 0x0600E071 RID: 57457 RVA: 0x0006D65B File Offset: 0x0006B85B
			public unsafe static Func<VolumeEffectComponent, string> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffect.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VolumeEffectComponent, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffect.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009652 RID: 38482
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009653 RID: 38483
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04009654 RID: 38484
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04009655 RID: 38485
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009656 RID: 38486
			private static readonly IntPtr NativeMethodInfoPtr__ListAcceptableComponents_b__10_0_Internal_Boolean_Component_0;

			// Token: 0x04009657 RID: 38487
			private static readonly IntPtr NativeMethodInfoPtr__GetComponentNames_b__11_0_Internal_String_VolumeEffectComponent_0;
		}
	}
}
