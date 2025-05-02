using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D5 RID: 981
	[Serializable]
	public class CurfewInstance : Object
	{
		// Token: 0x06004B96 RID: 19350 RVA: 0x0016D0B4 File Offset: 0x0016B2B4
		// Note: this type is marked as 'beforefieldinit'.
		static CurfewInstance()
		{
			Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "CurfewInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr);
			CurfewInstance.NativeFieldInfoPtr_ActiveInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, "ActiveInstance");
			CurfewInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, "IntensityRequirement");
			CurfewInstance.NativeFieldInfoPtr__Enabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, "<Enabled>k__BackingField");
			CurfewInstance.NativeFieldInfoPtr_shouldDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, "shouldDisable");
			CurfewInstance.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672655);
			CurfewInstance.NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672656);
			CurfewInstance.NativeMethodInfoPtr_Evaluate_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672657);
			CurfewInstance.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672658);
			CurfewInstance.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672659);
			CurfewInstance.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672660);
			CurfewInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100672661);
		}

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06004B97 RID: 19351 RVA: 0x0016D1C0 File Offset: 0x0016B3C0
		// (set) Token: 0x06004B98 RID: 19352 RVA: 0x0016D1FC File Offset: 0x0016B3FC
		public unsafe bool Enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B99 RID: 19353 RVA: 0x0016D23C File Offset: 0x0016B43C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164971, RefRangeEnd = 164973, XrefRangeStart = 164963, XrefRangeEnd = 164971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate(bool ignoreSleepReq = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ignoreSleepReq;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_Evaluate_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B9A RID: 19354 RVA: 0x0016D27C File Offset: 0x0016B47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164973, XrefRangeEnd = 164981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B9B RID: 19355 RVA: 0x0016D2B0 File Offset: 0x0016B4B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 165008, RefRangeEnd = 165010, XrefRangeStart = 164981, XrefRangeEnd = 165008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B9C RID: 19356 RVA: 0x0016D2E4 File Offset: 0x0016B4E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165032, RefRangeEnd = 165033, XrefRangeStart = 165010, XrefRangeEnd = 165032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B9D RID: 19357 RVA: 0x0016D318 File Offset: 0x0016B518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165033, XrefRangeEnd = 165034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CurfewInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x000245C2 File Offset: 0x000227C2
		public CurfewInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x06004B9F RID: 19359 RVA: 0x0016D354 File Offset: 0x0016B554
		// (set) Token: 0x06004BA0 RID: 19360 RVA: 0x000245CB File Offset: 0x000227CB
		public unsafe static CurfewInstance ActiveInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CurfewInstance.NativeFieldInfoPtr_ActiveInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CurfewInstance>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewInstance.NativeFieldInfoPtr_ActiveInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x06004BA1 RID: 19361 RVA: 0x0016D37C File Offset: 0x0016B57C
		// (set) Token: 0x06004BA2 RID: 19362 RVA: 0x000245DD File Offset: 0x000227DD
		public unsafe int IntensityRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x06004BA3 RID: 19363 RVA: 0x0016D3A4 File Offset: 0x0016B5A4
		// (set) Token: 0x06004BA4 RID: 19364 RVA: 0x000245F8 File Offset: 0x000227F8
		public unsafe bool _Enabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr__Enabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr__Enabled_k__BackingField)) = value;
			}
		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x06004BA5 RID: 19365 RVA: 0x0016D3CC File Offset: 0x0016B5CC
		// (set) Token: 0x06004BA6 RID: 19366 RVA: 0x00024613 File Offset: 0x00022813
		public unsafe bool shouldDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr_shouldDisable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr_shouldDisable)) = value;
			}
		}

		// Token: 0x040032F1 RID: 13041
		private static readonly IntPtr NativeFieldInfoPtr_ActiveInstance;

		// Token: 0x040032F2 RID: 13042
		private static readonly IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x040032F3 RID: 13043
		private static readonly IntPtr NativeFieldInfoPtr__Enabled_k__BackingField;

		// Token: 0x040032F4 RID: 13044
		private static readonly IntPtr NativeFieldInfoPtr_shouldDisable;

		// Token: 0x040032F5 RID: 13045
		private static readonly IntPtr NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0;

		// Token: 0x040032F6 RID: 13046
		private static readonly IntPtr NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0;

		// Token: 0x040032F7 RID: 13047
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_Boolean_0;

		// Token: 0x040032F8 RID: 13048
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040032F9 RID: 13049
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;

		// Token: 0x040032FA RID: 13050
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x040032FB RID: 13051
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
