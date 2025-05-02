using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x0200048B RID: 1163
	public class ConstructStop_Base : MonoBehaviour
	{
		// Token: 0x060064B9 RID: 25785 RVA: 0x001C7740 File Offset: 0x001C5940
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructStop_Base()
		{
			Il2CppClassPointerStore<ConstructStop_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructStop_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructStop_Base>.NativeClassPtr);
			ConstructStop_Base.NativeMethodInfoPtr_StopConstruction_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStop_Base>.NativeClassPtr, 100676057);
			ConstructStop_Base.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStop_Base>.NativeClassPtr, 100676058);
		}

		// Token: 0x060064BA RID: 25786 RVA: 0x001C7798 File Offset: 0x001C5998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204714, XrefRangeEnd = 204723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StopConstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructStop_Base.NativeMethodInfoPtr_StopConstruction_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064BB RID: 25787 RVA: 0x001C77D4 File Offset: 0x001C59D4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructStop_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructStop_Base>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructStop_Base.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064BC RID: 25788 RVA: 0x0002FA22 File Offset: 0x0002DC22
		public ConstructStop_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040044B9 RID: 17593
		private static readonly IntPtr NativeMethodInfoPtr_StopConstruction_Public_Virtual_New_Void_0;

		// Token: 0x040044BA RID: 17594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
