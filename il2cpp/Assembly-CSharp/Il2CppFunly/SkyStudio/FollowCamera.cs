using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200011A RID: 282
	public class FollowCamera : MonoBehaviour
	{
		// Token: 0x06001856 RID: 6230 RVA: 0x000BC608 File Offset: 0x000BA808
		// Note: this type is marked as 'beforefieldinit'.
		static FollowCamera()
		{
			Il2CppClassPointerStore<FollowCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "FollowCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FollowCamera>.NativeClassPtr);
			FollowCamera.NativeFieldInfoPtr_followCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FollowCamera>.NativeClassPtr, "followCamera");
			FollowCamera.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FollowCamera>.NativeClassPtr, "offset");
			FollowCamera.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FollowCamera>.NativeClassPtr, 100665889);
			FollowCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FollowCamera>.NativeClassPtr, 100665890);
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x000BC688 File Offset: 0x000BA888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95276, XrefRangeEnd = 95289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FollowCamera.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x000BC6BC File Offset: 0x000BA8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95289, XrefRangeEnd = 95292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FollowCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FollowCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FollowCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x0000DFC6 File Offset: 0x0000C1C6
		public FollowCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x000BC6F8 File Offset: 0x000BA8F8
		// (set) Token: 0x0600185B RID: 6235 RVA: 0x0000DFCF File Offset: 0x0000C1CF
		public unsafe Camera followCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FollowCamera.NativeFieldInfoPtr_followCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FollowCamera.NativeFieldInfoPtr_followCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x000BC728 File Offset: 0x000BA928
		// (set) Token: 0x0600185D RID: 6237 RVA: 0x0000DFEE File Offset: 0x0000C1EE
		public unsafe Vector3 offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FollowCamera.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FollowCamera.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x04001000 RID: 4096
		private static readonly IntPtr NativeFieldInfoPtr_followCamera;

		// Token: 0x04001001 RID: 4097
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001003 RID: 4099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
