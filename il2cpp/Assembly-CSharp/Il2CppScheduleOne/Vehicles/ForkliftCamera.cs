using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004DE RID: 1246
	public class ForkliftCamera : VehicleCamera
	{
		// Token: 0x06006D04 RID: 27908 RVA: 0x001E36E8 File Offset: 0x001E18E8
		// Note: this type is marked as 'beforefieldinit'.
		static ForkliftCamera()
		{
			Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "ForkliftCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr);
			ForkliftCamera.NativeFieldInfoPtr_forkCamPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr, "forkCamPos");
			ForkliftCamera.NativeFieldInfoPtr_guidanceLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr, "guidanceLight");
			ForkliftCamera.NativeFieldInfoPtr_forkliftCamActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr, "forkliftCamActive");
			ForkliftCamera.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr, 100677075);
			ForkliftCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr, 100677076);
			ForkliftCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr, 100677077);
		}

		// Token: 0x06006D05 RID: 27909 RVA: 0x001E3790 File Offset: 0x001E1990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217802, XrefRangeEnd = 217804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForkliftCamera.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D06 RID: 27910 RVA: 0x001E37CC File Offset: 0x001E19CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217804, XrefRangeEnd = 217818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForkliftCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D07 RID: 27911 RVA: 0x001E3808 File Offset: 0x001E1A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217818, XrefRangeEnd = 217819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForkliftCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForkliftCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForkliftCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D08 RID: 27912 RVA: 0x000339B8 File Offset: 0x00031BB8
		public ForkliftCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x06006D09 RID: 27913 RVA: 0x001E3844 File Offset: 0x001E1A44
		// (set) Token: 0x06006D0A RID: 27914 RVA: 0x000339C1 File Offset: 0x00031BC1
		public unsafe Transform forkCamPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftCamera.NativeFieldInfoPtr_forkCamPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftCamera.NativeFieldInfoPtr_forkCamPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x06006D0B RID: 27915 RVA: 0x001E3874 File Offset: 0x001E1A74
		// (set) Token: 0x06006D0C RID: 27916 RVA: 0x000339E0 File Offset: 0x00031BE0
		public unsafe Light guidanceLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftCamera.NativeFieldInfoPtr_guidanceLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftCamera.NativeFieldInfoPtr_guidanceLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x06006D0D RID: 27917 RVA: 0x001E38A4 File Offset: 0x001E1AA4
		// (set) Token: 0x06006D0E RID: 27918 RVA: 0x000339FF File Offset: 0x00031BFF
		public unsafe bool forkliftCamActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftCamera.NativeFieldInfoPtr_forkliftCamActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftCamera.NativeFieldInfoPtr_forkliftCamActive)) = value;
			}
		}

		// Token: 0x04004A85 RID: 19077
		private static readonly IntPtr NativeFieldInfoPtr_forkCamPos;

		// Token: 0x04004A86 RID: 19078
		private static readonly IntPtr NativeFieldInfoPtr_guidanceLight;

		// Token: 0x04004A87 RID: 19079
		private static readonly IntPtr NativeFieldInfoPtr_forkliftCamActive;

		// Token: 0x04004A88 RID: 19080
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04004A89 RID: 19081
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x04004A8A RID: 19082
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
