using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Police
{
	// Token: 0x020001F8 RID: 504
	public class Offense : Object
	{
		// Token: 0x060028CC RID: 10444 RVA: 0x000F1B1C File Offset: 0x000EFD1C
		// Note: this type is marked as 'beforefieldinit'.
		static Offense()
		{
			Il2CppClassPointerStore<Offense>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Police", "Offense");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Offense>.NativeClassPtr);
			Offense.NativeFieldInfoPtr_charges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense>.NativeClassPtr, "charges");
			Offense.NativeFieldInfoPtr_penalties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense>.NativeClassPtr, "penalties");
			Offense.NativeMethodInfoPtr__ctor_Public_Void_List_1_Charge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offense>.NativeClassPtr, 100667906);
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x000F1B88 File Offset: 0x000EFD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118958, XrefRangeEnd = 118977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Offense(List<Offense.Charge> _charges) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Offense>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_charges);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Offense.NativeMethodInfoPtr__ctor_Public_Void_List_1_Charge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x00016211 File Offset: 0x00014411
		public Offense(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x060028CF RID: 10447 RVA: 0x000F1BD4 File Offset: 0x000EFDD4
		// (set) Token: 0x060028D0 RID: 10448 RVA: 0x0001621A File Offset: 0x0001441A
		public unsafe List<Offense.Charge> charges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.NativeFieldInfoPtr_charges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Offense.Charge>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.NativeFieldInfoPtr_charges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x060028D1 RID: 10449 RVA: 0x000F1C04 File Offset: 0x000EFE04
		// (set) Token: 0x060028D2 RID: 10450 RVA: 0x00016239 File Offset: 0x00014439
		public unsafe List<string> penalties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.NativeFieldInfoPtr_penalties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.NativeFieldInfoPtr_penalties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B16 RID: 6934
		private static readonly IntPtr NativeFieldInfoPtr_charges;

		// Token: 0x04001B17 RID: 6935
		private static readonly IntPtr NativeFieldInfoPtr_penalties;

		// Token: 0x04001B18 RID: 6936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_Charge_0;

		// Token: 0x020008DB RID: 2267
		public class Charge : Object
		{
			// Token: 0x0600C467 RID: 50279 RVA: 0x002FD8B0 File Offset: 0x002FBAB0
			// Note: this type is marked as 'beforefieldinit'.
			static Charge()
			{
				Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Offense>.NativeClassPtr, "Charge");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr);
				Offense.Charge.NativeFieldInfoPtr_chargeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr, "chargeName");
				Offense.Charge.NativeFieldInfoPtr_crimeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr, "crimeIndex");
				Offense.Charge.NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr, "quantity");
				Offense.Charge.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr, 100667907);
			}

			// Token: 0x0600C468 RID: 50280 RVA: 0x002FD92C File Offset: 0x002FBB2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118952, XrefRangeEnd = 118958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Charge(string _chargeName, int _crimeIndex, int _quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_chargeName);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _crimeIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Offense.Charge.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C469 RID: 50281 RVA: 0x0005F94B File Offset: 0x0005DB4B
			public Charge(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D4A RID: 15690
			// (get) Token: 0x0600C46A RID: 50282 RVA: 0x002FD994 File Offset: 0x002FBB94
			// (set) Token: 0x0600C46B RID: 50283 RVA: 0x0005F954 File Offset: 0x0005DB54
			public unsafe string chargeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_chargeName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_chargeName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003D4B RID: 15691
			// (get) Token: 0x0600C46C RID: 50284 RVA: 0x002FD9BC File Offset: 0x002FBBBC
			// (set) Token: 0x0600C46D RID: 50285 RVA: 0x0005F973 File Offset: 0x0005DB73
			public unsafe int crimeIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_crimeIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_crimeIndex)) = value;
				}
			}

			// Token: 0x17003D4C RID: 15692
			// (get) Token: 0x0600C46E RID: 50286 RVA: 0x002FD9E4 File Offset: 0x002FBBE4
			// (set) Token: 0x0600C46F RID: 50287 RVA: 0x0005F98E File Offset: 0x0005DB8E
			public unsafe int quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_quantity)) = value;
				}
			}

			// Token: 0x04008516 RID: 34070
			private static readonly IntPtr NativeFieldInfoPtr_chargeName;

			// Token: 0x04008517 RID: 34071
			private static readonly IntPtr NativeFieldInfoPtr_crimeIndex;

			// Token: 0x04008518 RID: 34072
			private static readonly IntPtr NativeFieldInfoPtr_quantity;

			// Token: 0x04008519 RID: 34073
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0;
		}
	}
}
