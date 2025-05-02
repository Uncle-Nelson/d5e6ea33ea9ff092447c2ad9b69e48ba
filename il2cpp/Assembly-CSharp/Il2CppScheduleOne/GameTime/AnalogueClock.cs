using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.GameTime
{
	// Token: 0x02000190 RID: 400
	public class AnalogueClock : MonoBehaviour
	{
		// Token: 0x060020A9 RID: 8361 RVA: 0x000D60E0 File Offset: 0x000D42E0
		// Note: this type is marked as 'beforefieldinit'.
		static AnalogueClock()
		{
			Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GameTime", "AnalogueClock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr);
			AnalogueClock.NativeFieldInfoPtr_MinHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, "MinHand");
			AnalogueClock.NativeFieldInfoPtr_HourHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, "HourHand");
			AnalogueClock.NativeFieldInfoPtr_RotationAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, "RotationAxis");
			AnalogueClock.NativeFieldInfoPtr_onNoon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, "onNoon");
			AnalogueClock.NativeFieldInfoPtr_onMidnight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, "onMidnight");
			AnalogueClock.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, 100666939);
			AnalogueClock.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, 100666940);
			AnalogueClock.NativeMethodInfoPtr_MinPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, 100666941);
			AnalogueClock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr, 100666942);
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x000D61C4 File Offset: 0x000D43C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109184, XrefRangeEnd = 109217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalogueClock.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x000D61F8 File Offset: 0x000D43F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109217, XrefRangeEnd = 109235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalogueClock.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x000D622C File Offset: 0x000D442C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109243, RefRangeEnd = 109244, XrefRangeStart = 109235, XrefRangeEnd = 109243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalogueClock.NativeMethodInfoPtr_MinPass_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x000D6260 File Offset: 0x000D4460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109244, XrefRangeEnd = 109247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalogueClock() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalogueClock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalogueClock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x00012664 File Offset: 0x00010864
		public AnalogueClock(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x060020AF RID: 8367 RVA: 0x000D629C File Offset: 0x000D449C
		// (set) Token: 0x060020B0 RID: 8368 RVA: 0x0001266D File Offset: 0x0001086D
		public unsafe Transform MinHand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_MinHand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_MinHand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x000D62CC File Offset: 0x000D44CC
		// (set) Token: 0x060020B2 RID: 8370 RVA: 0x0001268C File Offset: 0x0001088C
		public unsafe Transform HourHand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_HourHand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_HourHand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x000D62FC File Offset: 0x000D44FC
		// (set) Token: 0x060020B4 RID: 8372 RVA: 0x000126AB File Offset: 0x000108AB
		public unsafe Vector3 RotationAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_RotationAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_RotationAxis)) = value;
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x000D6324 File Offset: 0x000D4524
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x000126C6 File Offset: 0x000108C6
		public unsafe UnityEvent onNoon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_onNoon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_onNoon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x060020B7 RID: 8375 RVA: 0x000D6354 File Offset: 0x000D4554
		// (set) Token: 0x060020B8 RID: 8376 RVA: 0x000126E5 File Offset: 0x000108E5
		public unsafe UnityEvent onMidnight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_onMidnight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalogueClock.NativeFieldInfoPtr_onMidnight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015A3 RID: 5539
		private static readonly IntPtr NativeFieldInfoPtr_MinHand;

		// Token: 0x040015A4 RID: 5540
		private static readonly IntPtr NativeFieldInfoPtr_HourHand;

		// Token: 0x040015A5 RID: 5541
		private static readonly IntPtr NativeFieldInfoPtr_RotationAxis;

		// Token: 0x040015A6 RID: 5542
		private static readonly IntPtr NativeFieldInfoPtr_onNoon;

		// Token: 0x040015A7 RID: 5543
		private static readonly IntPtr NativeFieldInfoPtr_onMidnight;

		// Token: 0x040015A8 RID: 5544
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040015A9 RID: 5545
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040015AA RID: 5546
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Public_Void_0;

		// Token: 0x040015AB RID: 5547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
