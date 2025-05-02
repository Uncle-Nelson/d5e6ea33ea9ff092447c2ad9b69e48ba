using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200046F RID: 1135
	public class GUIDUtility : MonoBehaviour
	{
		// Token: 0x0600624D RID: 25165 RVA: 0x001BF414 File Offset: 0x001BD614
		// Note: this type is marked as 'beforefieldinit'.
		static GUIDUtility()
		{
			Il2CppClassPointerStore<GUIDUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "GUIDUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIDUtility>.NativeClassPtr);
			GUIDUtility.NativeMethodInfoPtr_GenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDUtility>.NativeClassPtr, 100675769);
			GUIDUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDUtility>.NativeClassPtr, 100675770);
		}

		// Token: 0x0600624E RID: 25166 RVA: 0x001BF46C File Offset: 0x001BD66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202110, XrefRangeEnd = 202116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDUtility.NativeMethodInfoPtr_GenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600624F RID: 25167 RVA: 0x001BF4A0 File Offset: 0x001BD6A0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIDUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIDUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006250 RID: 25168 RVA: 0x0002E762 File Offset: 0x0002C962
		public GUIDUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004305 RID: 17157
		private static readonly IntPtr NativeMethodInfoPtr_GenerateGUID_Public_Void_0;

		// Token: 0x04004306 RID: 17158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
