using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A8 RID: 936
	public class TransitRouteMaterial : MonoBehaviour
	{
		// Token: 0x0600494F RID: 18767 RVA: 0x00165814 File Offset: 0x00163A14
		// Note: this type is marked as 'beforefieldinit'.
		static TransitRouteMaterial()
		{
			Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "TransitRouteMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr);
			TransitRouteMaterial.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr, 100672384);
			TransitRouteMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr, 100672385);
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x0016586C File Offset: 0x00163A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163267, XrefRangeEnd = 163276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRouteMaterial.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x001658A0 File Offset: 0x00163AA0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitRouteMaterial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRouteMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004952 RID: 18770 RVA: 0x00023584 File Offset: 0x00021784
		public TransitRouteMaterial(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003173 RID: 12659
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003174 RID: 12660
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
