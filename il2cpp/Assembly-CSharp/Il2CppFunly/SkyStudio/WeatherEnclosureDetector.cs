using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000130 RID: 304
	public class WeatherEnclosureDetector : MonoBehaviour
	{
		// Token: 0x060019F6 RID: 6646 RVA: 0x000C1B88 File Offset: 0x000BFD88
		// Note: this type is marked as 'beforefieldinit'.
		static WeatherEnclosureDetector()
		{
			Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "WeatherEnclosureDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr);
			WeatherEnclosureDetector.NativeFieldInfoPtr_mainEnclosure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, "mainEnclosure");
			WeatherEnclosureDetector.NativeFieldInfoPtr_triggeredEnclosures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, "triggeredEnclosures");
			WeatherEnclosureDetector.NativeFieldInfoPtr_rainController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, "rainController");
			WeatherEnclosureDetector.NativeFieldInfoPtr_enclosureChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, "enclosureChangedCallback");
			WeatherEnclosureDetector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, 100666052);
			WeatherEnclosureDetector.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, 100666053);
			WeatherEnclosureDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, 100666054);
			WeatherEnclosureDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, 100666055);
			WeatherEnclosureDetector.NativeMethodInfoPtr_ApplyEnclosure_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, 100666056);
			WeatherEnclosureDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, 100666057);
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x000C1C80 File Offset: 0x000BFE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96846, XrefRangeEnd = 96847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEnclosureDetector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x000C1CB4 File Offset: 0x000BFEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEnclosureDetector.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x000C1CE8 File Offset: 0x000BFEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96847, XrefRangeEnd = 96867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEnclosureDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x000C1D2C File Offset: 0x000BFF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96867, XrefRangeEnd = 96882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEnclosureDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x000C1D70 File Offset: 0x000BFF70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 96896, RefRangeEnd = 96900, XrefRangeStart = 96882, XrefRangeEnd = 96896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEnclosure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEnclosureDetector.NativeMethodInfoPtr_ApplyEnclosure_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x000C1DA4 File Offset: 0x000BFFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96900, XrefRangeEnd = 96908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeatherEnclosureDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEnclosureDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x0000EC72 File Offset: 0x0000CE72
		public WeatherEnclosureDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x000C1DE0 File Offset: 0x000BFFE0
		// (set) Token: 0x060019FF RID: 6655 RVA: 0x0000EC7B File Offset: 0x0000CE7B
		public unsafe WeatherEnclosure mainEnclosure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosureDetector.NativeFieldInfoPtr_mainEnclosure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherEnclosure>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosureDetector.NativeFieldInfoPtr_mainEnclosure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x000C1E10 File Offset: 0x000C0010
		// (set) Token: 0x06001A01 RID: 6657 RVA: 0x0000EC9A File Offset: 0x0000CE9A
		public unsafe List<WeatherEnclosure> triggeredEnclosures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosureDetector.NativeFieldInfoPtr_triggeredEnclosures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeatherEnclosure>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosureDetector.NativeFieldInfoPtr_triggeredEnclosures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x000C1E40 File Offset: 0x000C0040
		// (set) Token: 0x06001A03 RID: 6659 RVA: 0x0000ECB9 File Offset: 0x0000CEB9
		public unsafe RainDownfallController rainController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosureDetector.NativeFieldInfoPtr_rainController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RainDownfallController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosureDetector.NativeFieldInfoPtr_rainController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001A04 RID: 6660 RVA: 0x000C1E70 File Offset: 0x000C0070
		// (set) Token: 0x06001A05 RID: 6661 RVA: 0x0000ECD8 File Offset: 0x0000CED8
		public unsafe Action<WeatherEnclosure> enclosureChangedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosureDetector.NativeFieldInfoPtr_enclosureChangedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<WeatherEnclosure>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosureDetector.NativeFieldInfoPtr_enclosureChangedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeFieldInfoPtr_mainEnclosure;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeFieldInfoPtr_triggeredEnclosures;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeFieldInfoPtr_rainController;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeFieldInfoPtr_enclosureChangedCallback;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEnclosure_Public_Void_0;

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
