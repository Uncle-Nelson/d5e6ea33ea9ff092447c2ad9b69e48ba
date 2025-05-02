using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000774 RID: 1908
	public class DarkMarketAccessZone : TimedAccessZone
	{
		// Token: 0x0600B50C RID: 46348 RVA: 0x002D0C64 File Offset: 0x002CEE64
		// Note: this type is marked as 'beforefieldinit'.
		static DarkMarketAccessZone()
		{
			Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "DarkMarketAccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr);
			DarkMarketAccessZone.NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr, 100685565);
			DarkMarketAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr, 100685566);
		}

		// Token: 0x0600B50D RID: 46349 RVA: 0x002D0CBC File Offset: 0x002CEEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310157, XrefRangeEnd = 310169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetIsOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarketAccessZone.NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B50E RID: 46350 RVA: 0x002D0D04 File Offset: 0x002CEF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310169, XrefRangeEnd = 310170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DarkMarketAccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B50F RID: 46351 RVA: 0x00058D08 File Offset: 0x00056F08
		public DarkMarketAccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04007A06 RID: 31238
		private static readonly IntPtr NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_Boolean_0;

		// Token: 0x04007A07 RID: 31239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
