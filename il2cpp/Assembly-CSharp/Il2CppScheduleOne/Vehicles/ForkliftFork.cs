using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004DF RID: 1247
	public class ForkliftFork : MonoBehaviour
	{
		// Token: 0x06006D0F RID: 27919 RVA: 0x001E38CC File Offset: 0x001E1ACC
		// Note: this type is marked as 'beforefieldinit'.
		static ForkliftFork()
		{
			Il2CppClassPointerStore<ForkliftFork>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "ForkliftFork");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForkliftFork>.NativeClassPtr);
			ForkliftFork.NativeFieldInfoPtr_forklift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForkliftFork>.NativeClassPtr, "forklift");
			ForkliftFork.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForkliftFork>.NativeClassPtr, 100677078);
		}

		// Token: 0x06006D10 RID: 27920 RVA: 0x001E3924 File Offset: 0x001E1B24
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForkliftFork() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForkliftFork>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForkliftFork.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D11 RID: 27921 RVA: 0x00033A1A File Offset: 0x00031C1A
		public ForkliftFork(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x06006D12 RID: 27922 RVA: 0x001E3960 File Offset: 0x001E1B60
		// (set) Token: 0x06006D13 RID: 27923 RVA: 0x00033A23 File Offset: 0x00031C23
		public unsafe Forklift forklift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftFork.NativeFieldInfoPtr_forklift);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Forklift>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftFork.NativeFieldInfoPtr_forklift), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A8B RID: 19083
		private static readonly IntPtr NativeFieldInfoPtr_forklift;

		// Token: 0x04004A8C RID: 19084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
