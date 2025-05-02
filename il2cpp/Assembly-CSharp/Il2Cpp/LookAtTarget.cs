using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200003E RID: 62
	public class LookAtTarget : MonoBehaviour
	{
		// Token: 0x0600052D RID: 1325 RVA: 0x0007F5A8 File Offset: 0x0007D7A8
		// Note: this type is marked as 'beforefieldinit'.
		static LookAtTarget()
		{
			Il2CppClassPointerStore<LookAtTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LookAtTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LookAtTarget>.NativeClassPtr);
			LookAtTarget.NativeFieldInfoPtr__target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtTarget>.NativeClassPtr, "_target");
			LookAtTarget.NativeFieldInfoPtr__speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtTarget>.NativeClassPtr, "_speed");
			LookAtTarget.NativeFieldInfoPtr__lookAtTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtTarget>.NativeClassPtr, "_lookAtTarget");
			LookAtTarget.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtTarget>.NativeClassPtr, 100663734);
			LookAtTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtTarget>.NativeClassPtr, 100663735);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0007F63C File Offset: 0x0007D83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74787, XrefRangeEnd = 74792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAtTarget.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0007F670 File Offset: 0x0007D870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74792, XrefRangeEnd = 74793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LookAtTarget() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LookAtTarget>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAtTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x000051BB File Offset: 0x000033BB
		public LookAtTarget(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x0007F6AC File Offset: 0x0007D8AC
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x000051C4 File Offset: 0x000033C4
		public unsafe Transform _target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtTarget.NativeFieldInfoPtr__target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtTarget.NativeFieldInfoPtr__target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x0007F6DC File Offset: 0x0007D8DC
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x000051E3 File Offset: 0x000033E3
		public unsafe float _speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtTarget.NativeFieldInfoPtr__speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtTarget.NativeFieldInfoPtr__speed)) = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x0007F704 File Offset: 0x0007D904
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x000051FE File Offset: 0x000033FE
		public unsafe Vector3 _lookAtTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtTarget.NativeFieldInfoPtr__lookAtTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtTarget.NativeFieldInfoPtr__lookAtTarget)) = value;
			}
		}

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeFieldInfoPtr__target;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeFieldInfoPtr__speed;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeFieldInfoPtr__lookAtTarget;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
