using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E8 RID: 1256
	public class VehicleAudio : MonoBehaviour
	{
		// Token: 0x06006EE3 RID: 28387 RVA: 0x001EA194 File Offset: 0x001E8394
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleAudio()
		{
			Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleAudio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr);
			VehicleAudio.NativeFieldInfoPtr_Vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "Vehicle");
			VehicleAudio.NativeFieldInfoPtr_Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "Lights");
			VehicleAudio.NativeFieldInfoPtr_EngineStartSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "EngineStartSound");
			VehicleAudio.NativeFieldInfoPtr_EngineStopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "EngineStopSound");
			VehicleAudio.NativeFieldInfoPtr_HeadlightsOnSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "HeadlightsOnSound");
			VehicleAudio.NativeFieldInfoPtr_HeadlightsOffSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "HeadlightsOffSound");
			VehicleAudio.NativeFieldInfoPtr_HornSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "HornSound");
			VehicleAudio.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, 100677315);
			VehicleAudio.NativeMethodInfoPtr_EngineStart_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, 100677316);
			VehicleAudio.NativeMethodInfoPtr_EngineStop_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, 100677317);
			VehicleAudio.NativeMethodInfoPtr_HeadlightsToggledOn_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, 100677318);
			VehicleAudio.NativeMethodInfoPtr_HeadlightsToggledOff_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, 100677319);
			VehicleAudio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, 100677320);
		}

		// Token: 0x06006EE4 RID: 28388 RVA: 0x001EA2C8 File Offset: 0x001E84C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220614, XrefRangeEnd = 220638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAudio.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EE5 RID: 28389 RVA: 0x001EA304 File Offset: 0x001E8504
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EngineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAudio.NativeMethodInfoPtr_EngineStart_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EE6 RID: 28390 RVA: 0x001EA340 File Offset: 0x001E8540
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EngineStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAudio.NativeMethodInfoPtr_EngineStop_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EE7 RID: 28391 RVA: 0x001EA37C File Offset: 0x001E857C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HeadlightsToggledOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAudio.NativeMethodInfoPtr_HeadlightsToggledOn_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EE8 RID: 28392 RVA: 0x001EA3B8 File Offset: 0x001E85B8
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HeadlightsToggledOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAudio.NativeMethodInfoPtr_HeadlightsToggledOff_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EE9 RID: 28393 RVA: 0x001EA3F4 File Offset: 0x001E85F4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleAudio() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAudio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EEA RID: 28394 RVA: 0x00034791 File Offset: 0x00032991
		public VehicleAudio(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x06006EEB RID: 28395 RVA: 0x001EA430 File Offset: 0x001E8630
		// (set) Token: 0x06006EEC RID: 28396 RVA: 0x0003479A File Offset: 0x0003299A
		public unsafe LandVehicle Vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_Vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_Vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x06006EED RID: 28397 RVA: 0x001EA460 File Offset: 0x001E8660
		// (set) Token: 0x06006EEE RID: 28398 RVA: 0x000347B9 File Offset: 0x000329B9
		public unsafe VehicleLights Lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_Lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleLights>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_Lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x06006EEF RID: 28399 RVA: 0x001EA490 File Offset: 0x001E8690
		// (set) Token: 0x06006EF0 RID: 28400 RVA: 0x000347D8 File Offset: 0x000329D8
		public unsafe AudioSource EngineStartSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_EngineStartSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_EngineStartSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x06006EF1 RID: 28401 RVA: 0x001EA4C0 File Offset: 0x001E86C0
		// (set) Token: 0x06006EF2 RID: 28402 RVA: 0x000347F7 File Offset: 0x000329F7
		public unsafe AudioSource EngineStopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_EngineStopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_EngineStopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x06006EF3 RID: 28403 RVA: 0x001EA4F0 File Offset: 0x001E86F0
		// (set) Token: 0x06006EF4 RID: 28404 RVA: 0x00034816 File Offset: 0x00032A16
		public unsafe AudioSource HeadlightsOnSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_HeadlightsOnSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_HeadlightsOnSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x06006EF5 RID: 28405 RVA: 0x001EA520 File Offset: 0x001E8720
		// (set) Token: 0x06006EF6 RID: 28406 RVA: 0x00034835 File Offset: 0x00032A35
		public unsafe AudioSource HeadlightsOffSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_HeadlightsOffSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_HeadlightsOffSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x06006EF7 RID: 28407 RVA: 0x001EA550 File Offset: 0x001E8750
		// (set) Token: 0x06006EF8 RID: 28408 RVA: 0x00034854 File Offset: 0x00032A54
		public unsafe AudioSource HornSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_HornSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_HornSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004BDB RID: 19419
		private static readonly IntPtr NativeFieldInfoPtr_Vehicle;

		// Token: 0x04004BDC RID: 19420
		private static readonly IntPtr NativeFieldInfoPtr_Lights;

		// Token: 0x04004BDD RID: 19421
		private static readonly IntPtr NativeFieldInfoPtr_EngineStartSound;

		// Token: 0x04004BDE RID: 19422
		private static readonly IntPtr NativeFieldInfoPtr_EngineStopSound;

		// Token: 0x04004BDF RID: 19423
		private static readonly IntPtr NativeFieldInfoPtr_HeadlightsOnSound;

		// Token: 0x04004BE0 RID: 19424
		private static readonly IntPtr NativeFieldInfoPtr_HeadlightsOffSound;

		// Token: 0x04004BE1 RID: 19425
		private static readonly IntPtr NativeFieldInfoPtr_HornSound;

		// Token: 0x04004BE2 RID: 19426
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004BE3 RID: 19427
		private static readonly IntPtr NativeMethodInfoPtr_EngineStart_Protected_Virtual_New_Void_0;

		// Token: 0x04004BE4 RID: 19428
		private static readonly IntPtr NativeMethodInfoPtr_EngineStop_Protected_Virtual_New_Void_0;

		// Token: 0x04004BE5 RID: 19429
		private static readonly IntPtr NativeMethodInfoPtr_HeadlightsToggledOn_Protected_Virtual_New_Void_0;

		// Token: 0x04004BE6 RID: 19430
		private static readonly IntPtr NativeMethodInfoPtr_HeadlightsToggledOff_Protected_Virtual_New_Void_0;

		// Token: 0x04004BE7 RID: 19431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
