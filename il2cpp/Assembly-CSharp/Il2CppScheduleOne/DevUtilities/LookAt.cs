using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200045A RID: 1114
	public class LookAt : MonoBehaviour
	{
		// Token: 0x060060C3 RID: 24771 RVA: 0x001BA308 File Offset: 0x001B8508
		// Note: this type is marked as 'beforefieldinit'.
		static LookAt()
		{
			Il2CppClassPointerStore<LookAt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "LookAt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LookAt>.NativeClassPtr);
			LookAt.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAt>.NativeClassPtr, "Target");
			LookAt.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAt>.NativeClassPtr, 100675603);
			LookAt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAt>.NativeClassPtr, 100675604);
		}

		// Token: 0x060060C4 RID: 24772 RVA: 0x001BA374 File Offset: 0x001B8574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199640, XrefRangeEnd = 199646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAt.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060C5 RID: 24773 RVA: 0x001BA3A8 File Offset: 0x001B85A8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LookAt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LookAt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060C6 RID: 24774 RVA: 0x0002DC56 File Offset: 0x0002BE56
		public LookAt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x060060C7 RID: 24775 RVA: 0x001BA3E4 File Offset: 0x001B85E4
		// (set) Token: 0x060060C8 RID: 24776 RVA: 0x0002DC5F File Offset: 0x0002BE5F
		public unsafe Transform Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAt.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAt.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400420A RID: 16906
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x0400420B RID: 16907
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400420C RID: 16908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
