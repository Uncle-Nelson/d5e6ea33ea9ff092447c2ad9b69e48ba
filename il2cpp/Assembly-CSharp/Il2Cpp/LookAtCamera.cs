using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000034 RID: 52
	public class LookAtCamera : MonoBehaviour
	{
		// Token: 0x060003A5 RID: 933 RVA: 0x0007B9F8 File Offset: 0x00079BF8
		// Note: this type is marked as 'beforefieldinit'.
		static LookAtCamera()
		{
			Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LookAtCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr);
			LookAtCamera.NativeFieldInfoPtr_lookAtCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr, "lookAtCamera");
			LookAtCamera.NativeFieldInfoPtr_lookOnlyOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr, "lookOnlyOnAwake");
			LookAtCamera.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr, 100663642);
			LookAtCamera.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr, 100663643);
			LookAtCamera.NativeMethodInfoPtr_LookCam_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr, 100663644);
			LookAtCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr, 100663645);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0007BAA0 File Offset: 0x00079CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73729, XrefRangeEnd = 73738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAtCamera.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0007BAD4 File Offset: 0x00079CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73738, XrefRangeEnd = 73741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAtCamera.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0007BB08 File Offset: 0x00079D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73741, XrefRangeEnd = 73745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookCam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAtCamera.NativeMethodInfoPtr_LookCam_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0007BB3C File Offset: 0x00079D3C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LookAtCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAtCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000413B File Offset: 0x0000233B
		public LookAtCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0007BB78 File Offset: 0x00079D78
		// (set) Token: 0x060003AC RID: 940 RVA: 0x00004144 File Offset: 0x00002344
		public unsafe Camera lookAtCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtCamera.NativeFieldInfoPtr_lookAtCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtCamera.NativeFieldInfoPtr_lookAtCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0007BBA8 File Offset: 0x00079DA8
		// (set) Token: 0x060003AE RID: 942 RVA: 0x00004163 File Offset: 0x00002363
		public unsafe bool lookOnlyOnAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtCamera.NativeFieldInfoPtr_lookOnlyOnAwake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtCamera.NativeFieldInfoPtr_lookOnlyOnAwake)) = value;
			}
		}

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeFieldInfoPtr_lookAtCamera;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeFieldInfoPtr_lookOnlyOnAwake;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_LookCam_Public_Void_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
