using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x02000370 RID: 880
	public class TransportInitializer : MonoBehaviour
	{
		// Token: 0x060044C6 RID: 17606 RVA: 0x0015365C File Offset: 0x0015185C
		// Note: this type is marked as 'beforefieldinit'.
		static TransportInitializer()
		{
			Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "TransportInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr);
			TransportInitializer.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr, 100671692);
			TransportInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr, 100671693);
		}

		// Token: 0x060044C7 RID: 17607 RVA: 0x001536B4 File Offset: 0x001518B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155620, XrefRangeEnd = 155630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportInitializer.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x001536E8 File Offset: 0x001518E8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransportInitializer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x0002196B File Offset: 0x0001FB6B
		public TransportInitializer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002E0E RID: 11790
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04002E0F RID: 11791
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
