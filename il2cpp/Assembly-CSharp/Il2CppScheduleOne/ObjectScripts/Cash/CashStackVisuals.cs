using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.Cash
{
	// Token: 0x02000764 RID: 1892
	public class CashStackVisuals : MonoBehaviour
	{
		// Token: 0x0600B3C2 RID: 46018 RVA: 0x002CCF8C File Offset: 0x002CB18C
		// Note: this type is marked as 'beforefieldinit'.
		static CashStackVisuals()
		{
			Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Cash", "CashStackVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr);
			CashStackVisuals.NativeFieldInfoPtr_MAX_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "MAX_AMOUNT");
			CashStackVisuals.NativeFieldInfoPtr_Visuals_Under100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "Visuals_Under100");
			CashStackVisuals.NativeFieldInfoPtr_Notes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "Notes");
			CashStackVisuals.NativeFieldInfoPtr_Visuals_Over100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "Visuals_Over100");
			CashStackVisuals.NativeFieldInfoPtr_Bills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "Bills");
			CashStackVisuals.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, 100685456);
			CashStackVisuals.NativeMethodInfoPtr_ShowAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, 100685457);
			CashStackVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, 100685458);
		}

		// Token: 0x0600B3C3 RID: 46019 RVA: 0x002CD05C File Offset: 0x002CB25C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashStackVisuals.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3C4 RID: 46020 RVA: 0x002CD090 File Offset: 0x002CB290
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 309029, RefRangeEnd = 309032, XrefRangeStart = 309020, XrefRangeEnd = 309029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashStackVisuals.NativeMethodInfoPtr_ShowAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3C5 RID: 46021 RVA: 0x002CD0D0 File Offset: 0x002CB2D0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashStackVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashStackVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3C6 RID: 46022 RVA: 0x00058185 File Offset: 0x00056385
		public CashStackVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037BA RID: 14266
		// (get) Token: 0x0600B3C7 RID: 46023 RVA: 0x002CD10C File Offset: 0x002CB30C
		// (set) Token: 0x0600B3C8 RID: 46024 RVA: 0x0005818E File Offset: 0x0005638E
		public unsafe static float MAX_AMOUNT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashStackVisuals.NativeFieldInfoPtr_MAX_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashStackVisuals.NativeFieldInfoPtr_MAX_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x170037BB RID: 14267
		// (get) Token: 0x0600B3C9 RID: 46025 RVA: 0x002CD128 File Offset: 0x002CB328
		// (set) Token: 0x0600B3CA RID: 46026 RVA: 0x0005819C File Offset: 0x0005639C
		public unsafe GameObject Visuals_Under100
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Visuals_Under100);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Visuals_Under100), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037BC RID: 14268
		// (get) Token: 0x0600B3CB RID: 46027 RVA: 0x002CD158 File Offset: 0x002CB358
		// (set) Token: 0x0600B3CC RID: 46028 RVA: 0x000581BB File Offset: 0x000563BB
		public unsafe Il2CppReferenceArray<GameObject> Notes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Notes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Notes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037BD RID: 14269
		// (get) Token: 0x0600B3CD RID: 46029 RVA: 0x002CD188 File Offset: 0x002CB388
		// (set) Token: 0x0600B3CE RID: 46030 RVA: 0x000581DA File Offset: 0x000563DA
		public unsafe GameObject Visuals_Over100
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Visuals_Over100);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Visuals_Over100), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037BE RID: 14270
		// (get) Token: 0x0600B3CF RID: 46031 RVA: 0x002CD1B8 File Offset: 0x002CB3B8
		// (set) Token: 0x0600B3D0 RID: 46032 RVA: 0x000581F9 File Offset: 0x000563F9
		public unsafe Il2CppReferenceArray<GameObject> Bills
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Bills);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Bills), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400793D RID: 31037
		private static readonly IntPtr NativeFieldInfoPtr_MAX_AMOUNT;

		// Token: 0x0400793E RID: 31038
		private static readonly IntPtr NativeFieldInfoPtr_Visuals_Under100;

		// Token: 0x0400793F RID: 31039
		private static readonly IntPtr NativeFieldInfoPtr_Notes;

		// Token: 0x04007940 RID: 31040
		private static readonly IntPtr NativeFieldInfoPtr_Visuals_Over100;

		// Token: 0x04007941 RID: 31041
		private static readonly IntPtr NativeFieldInfoPtr_Bills;

		// Token: 0x04007942 RID: 31042
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007943 RID: 31043
		private static readonly IntPtr NativeMethodInfoPtr_ShowAmount_Public_Void_Single_0;

		// Token: 0x04007944 RID: 31044
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
