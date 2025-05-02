using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C7 RID: 455
	public class Quest_WeNeedToCook : Quest
	{
		// Token: 0x060026F2 RID: 9970 RVA: 0x000EAB24 File Offset: 0x000E8D24
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_WeNeedToCook()
		{
			Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_WeNeedToCook");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr);
			Quest_WeNeedToCook.NativeFieldInfoPtr_PrerequisiteQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr, "PrerequisiteQuests");
			Quest_WeNeedToCook.NativeFieldInfoPtr_MethSupplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr, "MethSupplier");
			Quest_WeNeedToCook.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr, 100667652);
			Quest_WeNeedToCook.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr, 100667653);
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x000EABA4 File Offset: 0x000E8DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117682, XrefRangeEnd = 117685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_WeNeedToCook.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x000EABE0 File Offset: 0x000E8DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117685, XrefRangeEnd = 117689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_WeNeedToCook() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WeNeedToCook.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x0001593A File Offset: 0x00013B3A
		public Quest_WeNeedToCook(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x060026F6 RID: 9974 RVA: 0x000EAC1C File Offset: 0x000E8E1C
		// (set) Token: 0x060026F7 RID: 9975 RVA: 0x00015943 File Offset: 0x00013B43
		public unsafe Il2CppReferenceArray<Quest> PrerequisiteQuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WeNeedToCook.NativeFieldInfoPtr_PrerequisiteQuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Quest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WeNeedToCook.NativeFieldInfoPtr_PrerequisiteQuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x060026F8 RID: 9976 RVA: 0x000EAC4C File Offset: 0x000E8E4C
		// (set) Token: 0x060026F9 RID: 9977 RVA: 0x00015962 File Offset: 0x00013B62
		public unsafe Supplier MethSupplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WeNeedToCook.NativeFieldInfoPtr_MethSupplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WeNeedToCook.NativeFieldInfoPtr_MethSupplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019E5 RID: 6629
		private static readonly IntPtr NativeFieldInfoPtr_PrerequisiteQuests;

		// Token: 0x040019E6 RID: 6630
		private static readonly IntPtr NativeFieldInfoPtr_MethSupplier;

		// Token: 0x040019E7 RID: 6631
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040019E8 RID: 6632
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
