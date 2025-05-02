using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006E7 RID: 1767
	public class JoinLocal : MonoBehaviour
	{
		// Token: 0x06009E58 RID: 40536 RVA: 0x00280378 File Offset: 0x0027E578
		// Note: this type is marked as 'beforefieldinit'.
		static JoinLocal()
		{
			Il2CppClassPointerStore<JoinLocal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "JoinLocal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr);
			JoinLocal.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr, 100682724);
			JoinLocal.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr, 100682725);
			JoinLocal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr, 100682726);
		}

		// Token: 0x06009E59 RID: 40537 RVA: 0x002803E4 File Offset: 0x0027E5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280346, XrefRangeEnd = 280358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinLocal.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E5A RID: 40538 RVA: 0x00280418 File Offset: 0x0027E618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280358, XrefRangeEnd = 280366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinLocal.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E5B RID: 40539 RVA: 0x0028044C File Offset: 0x0027E64C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JoinLocal() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinLocal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E5C RID: 40540 RVA: 0x0004DA9E File Offset: 0x0004BC9E
		public JoinLocal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04006A4A RID: 27210
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006A4B RID: 27211
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04006A4C RID: 27212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
