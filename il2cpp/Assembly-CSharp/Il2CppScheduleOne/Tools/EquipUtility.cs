using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000538 RID: 1336
	public class EquipUtility : MonoBehaviour
	{
		// Token: 0x060076D5 RID: 30421 RVA: 0x00204548 File Offset: 0x00202748
		// Note: this type is marked as 'beforefieldinit'.
		static EquipUtility()
		{
			Il2CppClassPointerStore<EquipUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "EquipUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr);
			EquipUtility.NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, "Equippable");
			EquipUtility.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, 100678259);
			EquipUtility.NativeMethodInfoPtr_Equip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, 100678260);
			EquipUtility.NativeMethodInfoPtr_Unequip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, 100678261);
			EquipUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, 100678262);
		}

		// Token: 0x060076D6 RID: 30422 RVA: 0x002045DC File Offset: 0x002027DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231270, XrefRangeEnd = 231274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipUtility.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076D7 RID: 30423 RVA: 0x00204610 File Offset: 0x00202810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231274, XrefRangeEnd = 231278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Equip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipUtility.NativeMethodInfoPtr_Equip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076D8 RID: 30424 RVA: 0x00204644 File Offset: 0x00202844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231278, XrefRangeEnd = 231284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipUtility.NativeMethodInfoPtr_Unequip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076D9 RID: 30425 RVA: 0x00204678 File Offset: 0x00202878
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EquipUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076DA RID: 30426 RVA: 0x00038508 File Offset: 0x00036708
		public EquipUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023F7 RID: 9207
		// (get) Token: 0x060076DB RID: 30427 RVA: 0x002046B4 File Offset: 0x002028B4
		// (set) Token: 0x060076DC RID: 30428 RVA: 0x00038511 File Offset: 0x00036711
		public unsafe AvatarEquippable Equippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquipUtility.NativeFieldInfoPtr_Equippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquipUtility.NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005123 RID: 20771
		private static readonly IntPtr NativeFieldInfoPtr_Equippable;

		// Token: 0x04005124 RID: 20772
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04005125 RID: 20773
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Void_0;

		// Token: 0x04005126 RID: 20774
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Void_0;

		// Token: 0x04005127 RID: 20775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
