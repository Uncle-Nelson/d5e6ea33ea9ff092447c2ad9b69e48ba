using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.Cash
{
	// Token: 0x02000763 RID: 1891
	public class Cash : MonoBehaviour
	{
		// Token: 0x0600B3BA RID: 46010 RVA: 0x002CCE4C File Offset: 0x002CB04C
		// Note: this type is marked as 'beforefieldinit'.
		static Cash()
		{
			Il2CppClassPointerStore<Cash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Cash", "Cash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cash>.NativeClassPtr);
			Cash.NativeFieldInfoPtr_stackSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cash>.NativeClassPtr, "stackSize");
			Cash.NativeFieldInfoPtr_amounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cash>.NativeClassPtr, "amounts");
			Cash.NativeMethodInfoPtr_GetBillStacksToDisplay_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cash>.NativeClassPtr, 100685453);
			Cash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cash>.NativeClassPtr, 100685454);
		}

		// Token: 0x0600B3BB RID: 46011 RVA: 0x002CCECC File Offset: 0x002CB0CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309019, RefRangeEnd = 309020, XrefRangeStart = 309019, XrefRangeEnd = 309019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetBillStacksToDisplay(float amount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cash.NativeMethodInfoPtr_GetBillStacksToDisplay_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B3BC RID: 46012 RVA: 0x002CCF0C File Offset: 0x002CB10C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3BD RID: 46013 RVA: 0x0005815C File Offset: 0x0005635C
		public Cash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037B8 RID: 14264
		// (get) Token: 0x0600B3BE RID: 46014 RVA: 0x002CCF48 File Offset: 0x002CB148
		// (set) Token: 0x0600B3BF RID: 46015 RVA: 0x00058165 File Offset: 0x00056365
		public unsafe static float stackSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Cash.NativeFieldInfoPtr_stackSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Cash.NativeFieldInfoPtr_stackSize, (void*)(&value));
			}
		}

		// Token: 0x170037B9 RID: 14265
		// (get) Token: 0x0600B3C0 RID: 46016 RVA: 0x002CCF64 File Offset: 0x002CB164
		// (set) Token: 0x0600B3C1 RID: 46017 RVA: 0x00058173 File Offset: 0x00056373
		public unsafe static Il2CppStructArray<int> amounts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Cash.NativeFieldInfoPtr_amounts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Cash.NativeFieldInfoPtr_amounts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007939 RID: 31033
		private static readonly IntPtr NativeFieldInfoPtr_stackSize;

		// Token: 0x0400793A RID: 31034
		private static readonly IntPtr NativeFieldInfoPtr_amounts;

		// Token: 0x0400793B RID: 31035
		private static readonly IntPtr NativeMethodInfoPtr_GetBillStacksToDisplay_Public_Static_Int32_Single_0;

		// Token: 0x0400793C RID: 31036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
