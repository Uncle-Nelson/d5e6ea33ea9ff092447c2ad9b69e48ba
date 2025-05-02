using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200054A RID: 1354
	public class RemoveChildColliders : MonoBehaviour
	{
		// Token: 0x060077B5 RID: 30645 RVA: 0x00207030 File Offset: 0x00205230
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveChildColliders()
		{
			Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "RemoveChildColliders");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr);
			RemoveChildColliders.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr, 100678365);
			RemoveChildColliders.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr, 100678366);
		}

		// Token: 0x060077B6 RID: 30646 RVA: 0x00207088 File Offset: 0x00205288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232147, XrefRangeEnd = 232155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveChildColliders.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077B7 RID: 30647 RVA: 0x002070BC File Offset: 0x002052BC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoveChildColliders() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveChildColliders>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveChildColliders.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077B8 RID: 30648 RVA: 0x00038B29 File Offset: 0x00036D29
		public RemoveChildColliders(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040051AD RID: 20909
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040051AE RID: 20910
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
