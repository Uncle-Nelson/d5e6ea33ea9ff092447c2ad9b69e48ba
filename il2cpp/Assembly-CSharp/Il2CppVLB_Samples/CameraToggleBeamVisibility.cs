using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppVLB_Samples
{
	// Token: 0x020000B9 RID: 185
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		// Token: 0x06000DF0 RID: 3568 RVA: 0x0009D75C File Offset: 0x0009B95C
		// Note: this type is marked as 'beforefieldinit'.
		static CameraToggleBeamVisibility()
		{
			Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB_Samples", "CameraToggleBeamVisibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr);
			CameraToggleBeamVisibility.NativeFieldInfoPtr_m_KeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr, "m_KeyCode");
			CameraToggleBeamVisibility.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr, 100665015);
			CameraToggleBeamVisibility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr, 100665016);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0009D7C8 File Offset: 0x0009B9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85479, XrefRangeEnd = 85487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraToggleBeamVisibility.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0009D7FC File Offset: 0x0009B9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85487, XrefRangeEnd = 85488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraToggleBeamVisibility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraToggleBeamVisibility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00008B97 File Offset: 0x00006D97
		public CameraToggleBeamVisibility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x0009D838 File Offset: 0x0009BA38
		// (set) Token: 0x06000DF5 RID: 3573 RVA: 0x00008BA0 File Offset: 0x00006DA0
		public unsafe KeyCode m_KeyCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraToggleBeamVisibility.NativeFieldInfoPtr_m_KeyCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraToggleBeamVisibility.NativeFieldInfoPtr_m_KeyCode)) = value;
			}
		}

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyCode;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
