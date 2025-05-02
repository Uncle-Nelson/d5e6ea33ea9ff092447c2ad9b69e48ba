using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppSystem;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001BB RID: 443
	public class Quest_GearingUp : Quest
	{
		// Token: 0x06002647 RID: 9799 RVA: 0x000E8C18 File Offset: 0x000E6E18
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_GearingUp()
		{
			Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_GearingUp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr);
			Quest_GearingUp.NativeFieldInfoPtr_WaitForDropEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "WaitForDropEntry");
			Quest_GearingUp.NativeFieldInfoPtr_CollectDropEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "CollectDropEntry");
			Quest_GearingUp.NativeFieldInfoPtr_Supplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "Supplier");
			Quest_GearingUp.NativeFieldInfoPtr_setCollectionPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "setCollectionPosition");
			Quest_GearingUp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, 100667579);
			Quest_GearingUp.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, 100667580);
			Quest_GearingUp.NativeMethodInfoPtr_DropReady_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, 100667581);
			Quest_GearingUp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, 100667582);
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x000E8CE8 File Offset: 0x000E6EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116900, XrefRangeEnd = 116909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_GearingUp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x000E8D24 File Offset: 0x000E6F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116909, XrefRangeEnd = 116944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_GearingUp.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x000E8D60 File Offset: 0x000E6F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116944, XrefRangeEnd = 116945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GearingUp.NativeMethodInfoPtr_DropReady_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x000E8D94 File Offset: 0x000E6F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116945, XrefRangeEnd = 116949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_GearingUp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GearingUp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x000153BD File Offset: 0x000135BD
		public Quest_GearingUp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x0600264D RID: 9805 RVA: 0x000E8DD0 File Offset: 0x000E6FD0
		// (set) Token: 0x0600264E RID: 9806 RVA: 0x000153C6 File Offset: 0x000135C6
		public unsafe QuestEntry WaitForDropEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_WaitForDropEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_WaitForDropEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x0600264F RID: 9807 RVA: 0x000E8E00 File Offset: 0x000E7000
		// (set) Token: 0x06002650 RID: 9808 RVA: 0x000153E5 File Offset: 0x000135E5
		public unsafe QuestEntry CollectDropEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_CollectDropEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_CollectDropEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06002651 RID: 9809 RVA: 0x000E8E30 File Offset: 0x000E7030
		// (set) Token: 0x06002652 RID: 9810 RVA: 0x00015404 File Offset: 0x00013604
		public unsafe Supplier Supplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_Supplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_Supplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06002653 RID: 9811 RVA: 0x000E8E60 File Offset: 0x000E7060
		// (set) Token: 0x06002654 RID: 9812 RVA: 0x00015423 File Offset: 0x00013623
		public unsafe bool setCollectionPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_setCollectionPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_setCollectionPosition)) = value;
			}
		}

		// Token: 0x04001980 RID: 6528
		private static readonly IntPtr NativeFieldInfoPtr_WaitForDropEntry;

		// Token: 0x04001981 RID: 6529
		private static readonly IntPtr NativeFieldInfoPtr_CollectDropEntry;

		// Token: 0x04001982 RID: 6530
		private static readonly IntPtr NativeFieldInfoPtr_Supplier;

		// Token: 0x04001983 RID: 6531
		private static readonly IntPtr NativeFieldInfoPtr_setCollectionPosition;

		// Token: 0x04001984 RID: 6532
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001985 RID: 6533
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04001986 RID: 6534
		private static readonly IntPtr NativeMethodInfoPtr_DropReady_Private_Void_0;

		// Token: 0x04001987 RID: 6535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008D2 RID: 2258
		[ObfuscatedName("ScheduleOne.Quests.Quest_GearingUp+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600C423 RID: 50211 RVA: 0x002FCC0C File Offset: 0x002FAE0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr);
				Quest_GearingUp.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr, "<>9");
				Quest_GearingUp.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr, "<>9__5_0");
				Quest_GearingUp.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr, 100667584);
				Quest_GearingUp.__c.NativeMethodInfoPtr__MinPass_b__5_0_Internal_Boolean_DeadDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr, 100667585);
			}

			// Token: 0x0600C424 RID: 50212 RVA: 0x002FCC88 File Offset: 0x002FAE88
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GearingUp.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C425 RID: 50213 RVA: 0x002FCCC4 File Offset: 0x002FAEC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116899, XrefRangeEnd = 116900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MinPass_b__5_0(DeadDrop x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GearingUp.__c.NativeMethodInfoPtr__MinPass_b__5_0_Internal_Boolean_DeadDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C426 RID: 50214 RVA: 0x0005F78D File Offset: 0x0005D98D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D38 RID: 15672
			// (get) Token: 0x0600C427 RID: 50215 RVA: 0x002FCD14 File Offset: 0x002FAF14
			// (set) Token: 0x0600C428 RID: 50216 RVA: 0x0005F796 File Offset: 0x0005D996
			public unsafe static Quest_GearingUp.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest_GearingUp.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest_GearingUp.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest_GearingUp.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D39 RID: 15673
			// (get) Token: 0x0600C429 RID: 50217 RVA: 0x002FCD3C File Offset: 0x002FAF3C
			// (set) Token: 0x0600C42A RID: 50218 RVA: 0x0005F7A8 File Offset: 0x0005D9A8
			public unsafe static Predicate<DeadDrop> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest_GearingUp.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<DeadDrop>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest_GearingUp.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084F0 RID: 34032
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040084F1 RID: 34033
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040084F2 RID: 34034
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084F3 RID: 34035
			private static readonly IntPtr NativeMethodInfoPtr__MinPass_b__5_0_Internal_Boolean_DeadDrop_0;
		}
	}
}
