using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000453 RID: 1107
	public class CopyPosition : MonoBehaviour
	{
		// Token: 0x06006044 RID: 24644 RVA: 0x001B89B0 File Offset: 0x001B6BB0
		// Note: this type is marked as 'beforefieldinit'.
		static CopyPosition()
		{
			Il2CppClassPointerStore<CopyPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "CopyPosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr);
			CopyPosition.NativeFieldInfoPtr_ToCopy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr, "ToCopy");
			CopyPosition.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr, 100675548);
			CopyPosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr, 100675549);
		}

		// Token: 0x06006045 RID: 24645 RVA: 0x001B8A1C File Offset: 0x001B6C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199119, XrefRangeEnd = 199122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyPosition.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006046 RID: 24646 RVA: 0x001B8A50 File Offset: 0x001B6C50
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CopyPosition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyPosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x0002D826 File Offset: 0x0002BA26
		public CopyPosition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x06006048 RID: 24648 RVA: 0x001B8A8C File Offset: 0x001B6C8C
		// (set) Token: 0x06006049 RID: 24649 RVA: 0x0002D82F File Offset: 0x0002BA2F
		public unsafe Transform ToCopy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyPosition.NativeFieldInfoPtr_ToCopy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyPosition.NativeFieldInfoPtr_ToCopy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040041B8 RID: 16824
		private static readonly IntPtr NativeFieldInfoPtr_ToCopy;

		// Token: 0x040041B9 RID: 16825
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040041BA RID: 16826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
