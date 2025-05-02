using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200052E RID: 1326
	public class CameraOverrider : MonoBehaviour
	{
		// Token: 0x06007661 RID: 30305 RVA: 0x00203058 File Offset: 0x00201258
		// Note: this type is marked as 'beforefieldinit'.
		static CameraOverrider()
		{
			Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CameraOverrider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr);
			CameraOverrider.NativeFieldInfoPtr_FOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr, "FOV");
			CameraOverrider.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr, 100678204);
			CameraOverrider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr, 100678205);
		}

		// Token: 0x06007662 RID: 30306 RVA: 0x002030C4 File Offset: 0x002012C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230929, XrefRangeEnd = 230943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOverrider.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007663 RID: 30307 RVA: 0x002030F8 File Offset: 0x002012F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230943, XrefRangeEnd = 230944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraOverrider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOverrider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007664 RID: 30308 RVA: 0x000381A3 File Offset: 0x000363A3
		public CameraOverrider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023D8 RID: 9176
		// (get) Token: 0x06007665 RID: 30309 RVA: 0x00203134 File Offset: 0x00201334
		// (set) Token: 0x06007666 RID: 30310 RVA: 0x000381AC File Offset: 0x000363AC
		public unsafe float FOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOverrider.NativeFieldInfoPtr_FOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOverrider.NativeFieldInfoPtr_FOV)) = value;
			}
		}

		// Token: 0x040050DF RID: 20703
		private static readonly IntPtr NativeFieldInfoPtr_FOV;

		// Token: 0x040050E0 RID: 20704
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x040050E1 RID: 20705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
