using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D0 RID: 1232
	public class ButtonSound : MonoBehaviour
	{
		// Token: 0x06006BEF RID: 27631 RVA: 0x001E006C File Offset: 0x001DE26C
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonSound()
		{
			Il2CppClassPointerStore<ButtonSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "ButtonSound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr);
			ButtonSound.NativeFieldInfoPtr_AudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "AudioSource");
			ButtonSound.NativeFieldInfoPtr_EventTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "EventTrigger");
			ButtonSound.NativeFieldInfoPtr_HoverClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "HoverClip");
			ButtonSound.NativeFieldInfoPtr_HoverSoundVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "HoverSoundVolume");
			ButtonSound.NativeFieldInfoPtr_ClickClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "ClickClip");
			ButtonSound.NativeFieldInfoPtr_ClickSoundVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "ClickSoundVolume");
			ButtonSound.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "Button");
			ButtonSound.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100676937);
			ButtonSound.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100676938);
			ButtonSound.NativeMethodInfoPtr_AddEventTrigger_Public_Void_EventTrigger_EventTriggerType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100676939);
			ButtonSound.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100676940);
			ButtonSound.NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100676941);
			ButtonSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100676942);
		}

		// Token: 0x06006BF0 RID: 27632 RVA: 0x001E01A0 File Offset: 0x001DE3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216538, XrefRangeEnd = 216553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BF1 RID: 27633 RVA: 0x001E01D4 File Offset: 0x001DE3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216553, XrefRangeEnd = 216568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BF2 RID: 27634 RVA: 0x001E0208 File Offset: 0x001DE408
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216590, RefRangeEnd = 216592, XrefRangeStart = 216568, XrefRangeEnd = 216590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEventTrigger(EventTrigger eventTrigger, EventTriggerType eventTriggerType, Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventTrigger);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventTriggerType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.NativeMethodInfoPtr_AddEventTrigger_Public_Void_EventTrigger_EventTriggerType_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BF3 RID: 27635 RVA: 0x001E026C File Offset: 0x001DE46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216592, XrefRangeEnd = 216593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ButtonSound.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BF4 RID: 27636 RVA: 0x001E02A8 File Offset: 0x001DE4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216593, XrefRangeEnd = 216594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ButtonSound.NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BF5 RID: 27637 RVA: 0x001E02E4 File Offset: 0x001DE4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216594, XrefRangeEnd = 216595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BF6 RID: 27638 RVA: 0x0003315A File Offset: 0x0003135A
		public ButtonSound(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x06006BF7 RID: 27639 RVA: 0x001E0320 File Offset: 0x001DE520
		// (set) Token: 0x06006BF8 RID: 27640 RVA: 0x00033163 File Offset: 0x00031363
		public unsafe AudioSourceController AudioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_AudioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_AudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x06006BF9 RID: 27641 RVA: 0x001E0350 File Offset: 0x001DE550
		// (set) Token: 0x06006BFA RID: 27642 RVA: 0x00033182 File Offset: 0x00031382
		public unsafe EventTrigger EventTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_EventTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_EventTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x06006BFB RID: 27643 RVA: 0x001E0380 File Offset: 0x001DE580
		// (set) Token: 0x06006BFC RID: 27644 RVA: 0x000331A1 File Offset: 0x000313A1
		public unsafe AudioClip HoverClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_HoverClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_HoverClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x06006BFD RID: 27645 RVA: 0x001E03B0 File Offset: 0x001DE5B0
		// (set) Token: 0x06006BFE RID: 27646 RVA: 0x000331C0 File Offset: 0x000313C0
		public unsafe float HoverSoundVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_HoverSoundVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_HoverSoundVolume)) = value;
			}
		}

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x06006BFF RID: 27647 RVA: 0x001E03D8 File Offset: 0x001DE5D8
		// (set) Token: 0x06006C00 RID: 27648 RVA: 0x000331DB File Offset: 0x000313DB
		public unsafe AudioClip ClickClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_ClickClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_ClickClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x06006C01 RID: 27649 RVA: 0x001E0408 File Offset: 0x001DE608
		// (set) Token: 0x06006C02 RID: 27650 RVA: 0x000331FA File Offset: 0x000313FA
		public unsafe float ClickSoundVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_ClickSoundVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_ClickSoundVolume)) = value;
			}
		}

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x06006C03 RID: 27651 RVA: 0x001E0430 File Offset: 0x001DE630
		// (set) Token: 0x06006C04 RID: 27652 RVA: 0x00033215 File Offset: 0x00031415
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040049D5 RID: 18901
		private static readonly IntPtr NativeFieldInfoPtr_AudioSource;

		// Token: 0x040049D6 RID: 18902
		private static readonly IntPtr NativeFieldInfoPtr_EventTrigger;

		// Token: 0x040049D7 RID: 18903
		private static readonly IntPtr NativeFieldInfoPtr_HoverClip;

		// Token: 0x040049D8 RID: 18904
		private static readonly IntPtr NativeFieldInfoPtr_HoverSoundVolume;

		// Token: 0x040049D9 RID: 18905
		private static readonly IntPtr NativeFieldInfoPtr_ClickClip;

		// Token: 0x040049DA RID: 18906
		private static readonly IntPtr NativeFieldInfoPtr_ClickSoundVolume;

		// Token: 0x040049DB RID: 18907
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x040049DC RID: 18908
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040049DD RID: 18909
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040049DE RID: 18910
		private static readonly IntPtr NativeMethodInfoPtr_AddEventTrigger_Public_Void_EventTrigger_EventTriggerType_Action_0;

		// Token: 0x040049DF RID: 18911
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0;

		// Token: 0x040049E0 RID: 18912
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0;

		// Token: 0x040049E1 RID: 18913
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A5B RID: 2651
		[ObfuscatedName("ScheduleOne.Audio.ButtonSound+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D09B RID: 53403 RVA: 0x003205E8 File Offset: 0x0031E7E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<ButtonSound.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass9_0>.NativeClassPtr);
				ButtonSound.__c__DisplayClass9_0.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass9_0>.NativeClassPtr, "action");
				ButtonSound.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass9_0>.NativeClassPtr, 100676943);
				ButtonSound.__c__DisplayClass9_0.NativeMethodInfoPtr__AddEventTrigger_b__0_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass9_0>.NativeClassPtr, 100676944);
			}

			// Token: 0x0600D09C RID: 53404 RVA: 0x00320650 File Offset: 0x0031E850
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D09D RID: 53405 RVA: 0x0032068C File Offset: 0x0031E88C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddEventTrigger_b__0(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.__c__DisplayClass9_0.NativeMethodInfoPtr__AddEventTrigger_b__0_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D09E RID: 53406 RVA: 0x000658F7 File Offset: 0x00063AF7
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040CC RID: 16588
			// (get) Token: 0x0600D09F RID: 53407 RVA: 0x003206D0 File Offset: 0x0031E8D0
			// (set) Token: 0x0600D0A0 RID: 53408 RVA: 0x00065900 File Offset: 0x00063B00
			public unsafe Action action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.__c__DisplayClass9_0.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.__c__DisplayClass9_0.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CCA RID: 36042
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04008CCB RID: 36043
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CCC RID: 36044
			private static readonly IntPtr NativeMethodInfoPtr__AddEventTrigger_b__0_Internal_Void_BaseEventData_0;
		}
	}
}
