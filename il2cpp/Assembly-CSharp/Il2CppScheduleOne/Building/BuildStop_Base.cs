using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004BA RID: 1210
	public class BuildStop_Base : MonoBehaviour
	{
		// Token: 0x06006A17 RID: 27159 RVA: 0x001DA980 File Offset: 0x001D8B80
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStop_Base()
		{
			Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStop_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr);
			BuildStop_Base.NativeMethodInfoPtr_Stop_Building_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr, 100676771);
			BuildStop_Base.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr, 100676772);
		}

		// Token: 0x06006A18 RID: 27160 RVA: 0x001DA9D8 File Offset: 0x001D8BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213917, XrefRangeEnd = 213941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Stop_Building()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStop_Base.NativeMethodInfoPtr_Stop_Building_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A19 RID: 27161 RVA: 0x001DAA14 File Offset: 0x001D8C14
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStop_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStop_Base.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A1A RID: 27162 RVA: 0x000321D5 File Offset: 0x000303D5
		public BuildStop_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040048A7 RID: 18599
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Building_Public_Virtual_New_Void_0;

		// Token: 0x040048A8 RID: 18600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
