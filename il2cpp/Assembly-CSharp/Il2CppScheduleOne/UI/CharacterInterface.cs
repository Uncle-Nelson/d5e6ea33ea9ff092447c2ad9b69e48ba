using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200062C RID: 1580
	public class CharacterInterface : MonoBehaviour
	{
		// Token: 0x06008B51 RID: 35665 RVA: 0x00247290 File Offset: 0x00245490
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterInterface()
		{
			Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CharacterInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr);
			CharacterInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			CharacterInterface.NativeFieldInfoPtr_ClothingSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "ClothingSlots");
			CharacterInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "Container");
			CharacterInterface.NativeFieldInfoPtr_RotationSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "RotationSlider");
			CharacterInterface.NativeFieldInfoPtr_SlotAlignmentPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "SlotAlignmentPoints");
			CharacterInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680599);
			CharacterInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680600);
			CharacterInterface.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680601);
			CharacterInterface.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680602);
			CharacterInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680603);
			CharacterInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680604);
			CharacterInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680605);
		}

		// Token: 0x17002A7E RID: 10878
		// (get) Token: 0x06008B52 RID: 35666 RVA: 0x002473B0 File Offset: 0x002455B0
		// (set) Token: 0x06008B53 RID: 35667 RVA: 0x002473EC File Offset: 0x002455EC
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008B54 RID: 35668 RVA: 0x0024742C File Offset: 0x0024562C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255287, RefRangeEnd = 255288, XrefRangeStart = 255284, XrefRangeEnd = 255287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B55 RID: 35669 RVA: 0x00247460 File Offset: 0x00245660
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255305, RefRangeEnd = 255306, XrefRangeStart = 255288, XrefRangeEnd = 255305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B56 RID: 35670 RVA: 0x00247494 File Offset: 0x00245694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255355, RefRangeEnd = 255356, XrefRangeStart = 255306, XrefRangeEnd = 255355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B57 RID: 35671 RVA: 0x002474C8 File Offset: 0x002456C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255287, RefRangeEnd = 255288, XrefRangeStart = 255287, XrefRangeEnd = 255288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B58 RID: 35672 RVA: 0x002474FC File Offset: 0x002456FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255356, XrefRangeEnd = 255364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B59 RID: 35673 RVA: 0x00042B3E File Offset: 0x00040D3E
		public CharacterInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A79 RID: 10873
		// (get) Token: 0x06008B5A RID: 35674 RVA: 0x00247538 File Offset: 0x00245738
		// (set) Token: 0x06008B5B RID: 35675 RVA: 0x00042B47 File Offset: 0x00040D47
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A7A RID: 10874
		// (get) Token: 0x06008B5C RID: 35676 RVA: 0x00247560 File Offset: 0x00245760
		// (set) Token: 0x06008B5D RID: 35677 RVA: 0x00042B62 File Offset: 0x00040D62
		public unsafe Il2CppReferenceArray<ClothingSlotUI> ClothingSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_ClothingSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ClothingSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_ClothingSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A7B RID: 10875
		// (get) Token: 0x06008B5E RID: 35678 RVA: 0x00247590 File Offset: 0x00245790
		// (set) Token: 0x06008B5F RID: 35679 RVA: 0x00042B81 File Offset: 0x00040D81
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A7C RID: 10876
		// (get) Token: 0x06008B60 RID: 35680 RVA: 0x002475C0 File Offset: 0x002457C0
		// (set) Token: 0x06008B61 RID: 35681 RVA: 0x00042BA0 File Offset: 0x00040DA0
		public unsafe Slider RotationSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_RotationSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_RotationSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A7D RID: 10877
		// (get) Token: 0x06008B62 RID: 35682 RVA: 0x002475F0 File Offset: 0x002457F0
		// (set) Token: 0x06008B63 RID: 35683 RVA: 0x00042BBF File Offset: 0x00040DBF
		public unsafe Dictionary<ClothingSlotUI, Transform> SlotAlignmentPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_SlotAlignmentPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ClothingSlotUI, Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_SlotAlignmentPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005E76 RID: 24182
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005E77 RID: 24183
		private static readonly IntPtr NativeFieldInfoPtr_ClothingSlots;

		// Token: 0x04005E78 RID: 24184
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005E79 RID: 24185
		private static readonly IntPtr NativeFieldInfoPtr_RotationSlider;

		// Token: 0x04005E7A RID: 24186
		private static readonly IntPtr NativeFieldInfoPtr_SlotAlignmentPoints;

		// Token: 0x04005E7B RID: 24187
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005E7C RID: 24188
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04005E7D RID: 24189
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005E7E RID: 24190
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005E7F RID: 24191
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04005E80 RID: 24192
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005E81 RID: 24193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B17 RID: 2839
		[ObfuscatedName("ScheduleOne.UI.CharacterInterface+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D6E3 RID: 55011 RVA: 0x003321FC File Offset: 0x003303FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass10_0>.NativeClassPtr);
				CharacterInterface.__c__DisplayClass10_0.NativeFieldInfoPtr_slotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass10_0>.NativeClassPtr, "slotUI");
				CharacterInterface.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass10_0>.NativeClassPtr, 100680606);
				CharacterInterface.__c__DisplayClass10_0.NativeMethodInfoPtr__Open_b__0_Internal_Boolean_SlotAlignmentPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass10_0>.NativeClassPtr, 100680607);
			}

			// Token: 0x0600D6E4 RID: 55012 RVA: 0x00332264 File Offset: 0x00330464
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6E5 RID: 55013 RVA: 0x003322A0 File Offset: 0x003304A0
			[CallerCount(0)]
			public unsafe bool _Open_b__0(CharacterDisplay.SlotAlignmentPoint x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.__c__DisplayClass10_0.NativeMethodInfoPtr__Open_b__0_Internal_Boolean_SlotAlignmentPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D6E6 RID: 55014 RVA: 0x00068955 File Offset: 0x00066B55
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004291 RID: 17041
			// (get) Token: 0x0600D6E7 RID: 55015 RVA: 0x003322F0 File Offset: 0x003304F0
			// (set) Token: 0x0600D6E8 RID: 55016 RVA: 0x0006895E File Offset: 0x00066B5E
			public unsafe ClothingSlotUI slotUI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.__c__DisplayClass10_0.NativeFieldInfoPtr_slotUI);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothingSlotUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.__c__DisplayClass10_0.NativeFieldInfoPtr_slotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009081 RID: 36993
			private static readonly IntPtr NativeFieldInfoPtr_slotUI;

			// Token: 0x04009082 RID: 36994
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009083 RID: 36995
			private static readonly IntPtr NativeMethodInfoPtr__Open_b__0_Internal_Boolean_SlotAlignmentPoint_0;
		}
	}
}
