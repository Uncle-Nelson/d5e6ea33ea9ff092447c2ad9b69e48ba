using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200044C RID: 1100
	public class ApplicationQuit : MonoBehaviour
	{
		// Token: 0x06005FB9 RID: 24505 RVA: 0x001B7300 File Offset: 0x001B5500
		// Note: this type is marked as 'beforefieldinit'.
		static ApplicationQuit()
		{
			Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "ApplicationQuit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr);
			ApplicationQuit.NativeMethodInfoPtr_Quit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr, 100675507);
			ApplicationQuit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr, 100675508);
		}

		// Token: 0x06005FBA RID: 24506 RVA: 0x001B7358 File Offset: 0x001B5558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198775, XrefRangeEnd = 198779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Quit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationQuit.NativeMethodInfoPtr_Quit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FBB RID: 24507 RVA: 0x001B738C File Offset: 0x001B558C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApplicationQuit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationQuit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FBC RID: 24508 RVA: 0x0002D2A8 File Offset: 0x0002B4A8
		public ApplicationQuit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004169 RID: 16745
		private static readonly IntPtr NativeMethodInfoPtr_Quit_Public_Void_0;

		// Token: 0x0400416A RID: 16746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
