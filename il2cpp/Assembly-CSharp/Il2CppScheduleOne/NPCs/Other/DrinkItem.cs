using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Other
{
	// Token: 0x020002F4 RID: 756
	public class DrinkItem : MonoBehaviour
	{
		// Token: 0x06003926 RID: 14630 RVA: 0x0012A518 File Offset: 0x00128718
		// Note: this type is marked as 'beforefieldinit'.
		static DrinkItem()
		{
			Il2CppClassPointerStore<DrinkItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Other", "DrinkItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr);
			DrinkItem.NativeFieldInfoPtr_Npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, "Npc");
			DrinkItem.NativeFieldInfoPtr_DrinkPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, "DrinkPrefab");
			DrinkItem.NativeFieldInfoPtr__active_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, "<active>k__BackingField");
			DrinkItem.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100669944);
			DrinkItem.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100669945);
			DrinkItem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100669946);
			DrinkItem.NativeMethodInfoPtr_Begin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100669947);
			DrinkItem.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100669948);
			DrinkItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100669949);
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06003927 RID: 14631 RVA: 0x0012A5FC File Offset: 0x001287FC
		// (set) Token: 0x06003928 RID: 14632 RVA: 0x0012A638 File Offset: 0x00128838
		public unsafe bool active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x0012A678 File Offset: 0x00128878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141895, XrefRangeEnd = 141903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x0012A6AC File Offset: 0x001288AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141903, XrefRangeEnd = 141909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_Begin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x0012A6E0 File Offset: 0x001288E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141909, XrefRangeEnd = 141917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x0012A714 File Offset: 0x00128914
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrinkItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x0001D63E File Offset: 0x0001B83E
		public DrinkItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x0600392E RID: 14638 RVA: 0x0012A750 File Offset: 0x00128950
		// (set) Token: 0x0600392F RID: 14639 RVA: 0x0001D647 File Offset: 0x0001B847
		public unsafe NPC Npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr_Npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr_Npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06003930 RID: 14640 RVA: 0x0012A780 File Offset: 0x00128980
		// (set) Token: 0x06003931 RID: 14641 RVA: 0x0001D666 File Offset: 0x0001B866
		public unsafe AvatarEquippable DrinkPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr_DrinkPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr_DrinkPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06003932 RID: 14642 RVA: 0x0012A7B0 File Offset: 0x001289B0
		// (set) Token: 0x06003933 RID: 14643 RVA: 0x0001D685 File Offset: 0x0001B885
		public unsafe bool _active_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr__active_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr__active_k__BackingField)) = value;
			}
		}

		// Token: 0x040025B8 RID: 9656
		private static readonly IntPtr NativeFieldInfoPtr_Npc;

		// Token: 0x040025B9 RID: 9657
		private static readonly IntPtr NativeFieldInfoPtr_DrinkPrefab;

		// Token: 0x040025BA RID: 9658
		private static readonly IntPtr NativeFieldInfoPtr__active_k__BackingField;

		// Token: 0x040025BB RID: 9659
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x040025BC RID: 9660
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0;

		// Token: 0x040025BD RID: 9661
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040025BE RID: 9662
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_0;

		// Token: 0x040025BF RID: 9663
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x040025C0 RID: 9664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
