using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000674 RID: 1652
	public class VersionText : MonoBehaviour
	{
		// Token: 0x0600937B RID: 37755 RVA: 0x0025F5F8 File Offset: 0x0025D7F8
		// Note: this type is marked as 'beforefieldinit'.
		static VersionText()
		{
			Il2CppClassPointerStore<VersionText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "VersionText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionText>.NativeClassPtr);
			VersionText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionText>.NativeClassPtr, 100681582);
			VersionText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionText>.NativeClassPtr, 100681583);
		}

		// Token: 0x0600937C RID: 37756 RVA: 0x0025F650 File Offset: 0x0025D850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265714, XrefRangeEnd = 265725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600937D RID: 37757 RVA: 0x0025F684 File Offset: 0x0025D884
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600937E RID: 37758 RVA: 0x00047777 File Offset: 0x00045977
		public VersionText(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400638F RID: 25487
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006390 RID: 25488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
