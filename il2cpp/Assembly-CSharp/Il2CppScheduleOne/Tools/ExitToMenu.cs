using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000539 RID: 1337
	public class ExitToMenu : MonoBehaviour
	{
		// Token: 0x060076DD RID: 30429 RVA: 0x002046E4 File Offset: 0x002028E4
		// Note: this type is marked as 'beforefieldinit'.
		static ExitToMenu()
		{
			Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ExitToMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr);
			ExitToMenu.NativeMethodInfoPtr_Exit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr, 100678263);
			ExitToMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr, 100678264);
		}

		// Token: 0x060076DE RID: 30430 RVA: 0x0020473C File Offset: 0x0020293C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231284, XrefRangeEnd = 231289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitToMenu.NativeMethodInfoPtr_Exit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076DF RID: 30431 RVA: 0x00204770 File Offset: 0x00202970
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExitToMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitToMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076E0 RID: 30432 RVA: 0x00038530 File Offset: 0x00036730
		public ExitToMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005128 RID: 20776
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_0;

		// Token: 0x04005129 RID: 20777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
