using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200052F RID: 1327
	public class CashPile : MonoBehaviour
	{
		// Token: 0x06007667 RID: 30311 RVA: 0x0020315C File Offset: 0x0020135C
		// Note: this type is marked as 'beforefieldinit'.
		static CashPile()
		{
			Il2CppClassPointerStore<CashPile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CashPile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashPile>.NativeClassPtr);
			CashPile.NativeFieldInfoPtr_MAX_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashPile>.NativeClassPtr, "MAX_AMOUNT");
			CashPile.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashPile>.NativeClassPtr, "Container");
			CashPile.NativeFieldInfoPtr_CashInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashPile>.NativeClassPtr, "CashInstances");
			CashPile.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPile>.NativeClassPtr, 100678206);
			CashPile.NativeMethodInfoPtr_SetDisplayedAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPile>.NativeClassPtr, 100678207);
			CashPile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPile>.NativeClassPtr, 100678208);
		}

		// Token: 0x06007668 RID: 30312 RVA: 0x00203204 File Offset: 0x00201404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230944, XrefRangeEnd = 230955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashPile.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007669 RID: 30313 RVA: 0x00203238 File Offset: 0x00201438
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230962, RefRangeEnd = 230963, XrefRangeStart = 230955, XrefRangeEnd = 230962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashPile.NativeMethodInfoPtr_SetDisplayedAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600766A RID: 30314 RVA: 0x00203278 File Offset: 0x00201478
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashPile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashPile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashPile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600766B RID: 30315 RVA: 0x000381C7 File Offset: 0x000363C7
		public CashPile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023D9 RID: 9177
		// (get) Token: 0x0600766C RID: 30316 RVA: 0x002032B4 File Offset: 0x002014B4
		// (set) Token: 0x0600766D RID: 30317 RVA: 0x000381D0 File Offset: 0x000363D0
		public unsafe static float MAX_AMOUNT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashPile.NativeFieldInfoPtr_MAX_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashPile.NativeFieldInfoPtr_MAX_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x170023DA RID: 9178
		// (get) Token: 0x0600766E RID: 30318 RVA: 0x002032D0 File Offset: 0x002014D0
		// (set) Token: 0x0600766F RID: 30319 RVA: 0x000381DE File Offset: 0x000363DE
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPile.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPile.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023DB RID: 9179
		// (get) Token: 0x06007670 RID: 30320 RVA: 0x00203300 File Offset: 0x00201500
		// (set) Token: 0x06007671 RID: 30321 RVA: 0x000381FD File Offset: 0x000363FD
		public unsafe Il2CppReferenceArray<Transform> CashInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPile.NativeFieldInfoPtr_CashInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPile.NativeFieldInfoPtr_CashInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040050E2 RID: 20706
		private static readonly IntPtr NativeFieldInfoPtr_MAX_AMOUNT;

		// Token: 0x040050E3 RID: 20707
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040050E4 RID: 20708
		private static readonly IntPtr NativeFieldInfoPtr_CashInstances;

		// Token: 0x040050E5 RID: 20709
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040050E6 RID: 20710
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedAmount_Public_Void_Single_0;

		// Token: 0x040050E7 RID: 20711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
