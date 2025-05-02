using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006E1 RID: 1761
	public class PotUIElement : WorldspaceUIElement
	{
		// Token: 0x06009E03 RID: 40451 RVA: 0x0027F31C File Offset: 0x0027D51C
		// Note: this type is marked as 'beforefieldinit'.
		static PotUIElement()
		{
			Il2CppClassPointerStore<PotUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PotUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr);
			PotUIElement.NativeFieldInfoPtr_SeedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "SeedIcon");
			PotUIElement.NativeFieldInfoPtr_NoSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "NoSeed");
			PotUIElement.NativeFieldInfoPtr_Additive1Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "Additive1Icon");
			PotUIElement.NativeFieldInfoPtr_Additive2Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "Additive2Icon");
			PotUIElement.NativeFieldInfoPtr_Additive3Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "Additive3Icon");
			PotUIElement.NativeFieldInfoPtr__AssignedPot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, "<AssignedPot>k__BackingField");
			PotUIElement.NativeMethodInfoPtr_get_AssignedPot_Public_get_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100682676);
			PotUIElement.NativeMethodInfoPtr_set_AssignedPot_Protected_set_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100682677);
			PotUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100682678);
			PotUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100682679);
			PotUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr, 100682680);
		}

		// Token: 0x170030AD RID: 12461
		// (get) Token: 0x06009E04 RID: 40452 RVA: 0x0027F428 File Offset: 0x0027D628
		// (set) Token: 0x06009E05 RID: 40453 RVA: 0x0027F468 File Offset: 0x0027D668
		public unsafe Pot AssignedPot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45803, RefRangeEnd = 45804, XrefRangeStart = 45803, XrefRangeEnd = 45804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotUIElement.NativeMethodInfoPtr_get_AssignedPot_Public_get_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotUIElement.NativeMethodInfoPtr_set_AssignedPot_Protected_set_Void_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009E06 RID: 40454 RVA: 0x0027F4AC File Offset: 0x0027D6AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280077, RefRangeEnd = 280078, XrefRangeStart = 280067, XrefRangeEnd = 280077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E07 RID: 40455 RVA: 0x0027F4F0 File Offset: 0x0027D6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280078, XrefRangeEnd = 280120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E08 RID: 40456 RVA: 0x0027F52C File Offset: 0x0027D72C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E09 RID: 40457 RVA: 0x0004D80B File Offset: 0x0004BA0B
		public PotUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030A7 RID: 12455
		// (get) Token: 0x06009E0A RID: 40458 RVA: 0x0027F568 File Offset: 0x0027D768
		// (set) Token: 0x06009E0B RID: 40459 RVA: 0x0004D814 File Offset: 0x0004BA14
		public unsafe Image SeedIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_SeedIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_SeedIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030A8 RID: 12456
		// (get) Token: 0x06009E0C RID: 40460 RVA: 0x0027F598 File Offset: 0x0027D798
		// (set) Token: 0x06009E0D RID: 40461 RVA: 0x0004D833 File Offset: 0x0004BA33
		public unsafe GameObject NoSeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_NoSeed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_NoSeed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030A9 RID: 12457
		// (get) Token: 0x06009E0E RID: 40462 RVA: 0x0027F5C8 File Offset: 0x0027D7C8
		// (set) Token: 0x06009E0F RID: 40463 RVA: 0x0004D852 File Offset: 0x0004BA52
		public unsafe Image Additive1Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive1Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive1Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030AA RID: 12458
		// (get) Token: 0x06009E10 RID: 40464 RVA: 0x0027F5F8 File Offset: 0x0027D7F8
		// (set) Token: 0x06009E11 RID: 40465 RVA: 0x0004D871 File Offset: 0x0004BA71
		public unsafe Image Additive2Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive2Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive2Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030AB RID: 12459
		// (get) Token: 0x06009E12 RID: 40466 RVA: 0x0027F628 File Offset: 0x0027D828
		// (set) Token: 0x06009E13 RID: 40467 RVA: 0x0004D890 File Offset: 0x0004BA90
		public unsafe Image Additive3Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive3Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr_Additive3Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030AC RID: 12460
		// (get) Token: 0x06009E14 RID: 40468 RVA: 0x0027F658 File Offset: 0x0027D858
		// (set) Token: 0x06009E15 RID: 40469 RVA: 0x0004D8AF File Offset: 0x0004BAAF
		public unsafe Pot _AssignedPot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr__AssignedPot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotUIElement.NativeFieldInfoPtr__AssignedPot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A16 RID: 27158
		private static readonly IntPtr NativeFieldInfoPtr_SeedIcon;

		// Token: 0x04006A17 RID: 27159
		private static readonly IntPtr NativeFieldInfoPtr_NoSeed;

		// Token: 0x04006A18 RID: 27160
		private static readonly IntPtr NativeFieldInfoPtr_Additive1Icon;

		// Token: 0x04006A19 RID: 27161
		private static readonly IntPtr NativeFieldInfoPtr_Additive2Icon;

		// Token: 0x04006A1A RID: 27162
		private static readonly IntPtr NativeFieldInfoPtr_Additive3Icon;

		// Token: 0x04006A1B RID: 27163
		private static readonly IntPtr NativeFieldInfoPtr__AssignedPot_k__BackingField;

		// Token: 0x04006A1C RID: 27164
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedPot_Public_get_Pot_0;

		// Token: 0x04006A1D RID: 27165
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedPot_Protected_set_Void_Pot_0;

		// Token: 0x04006A1E RID: 27166
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Pot_0;

		// Token: 0x04006A1F RID: 27167
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006A20 RID: 27168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
