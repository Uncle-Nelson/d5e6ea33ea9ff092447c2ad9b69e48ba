using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000023 RID: 35
	public class ModifySkyAtRuntime : MonoBehaviour
	{
		// Token: 0x060002B1 RID: 689 RVA: 0x00078E48 File Offset: 0x00077048
		// Note: this type is marked as 'beforefieldinit'.
		static ModifySkyAtRuntime()
		{
			Il2CppClassPointerStore<ModifySkyAtRuntime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ModifySkyAtRuntime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifySkyAtRuntime>.NativeClassPtr);
			ModifySkyAtRuntime.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifySkyAtRuntime>.NativeClassPtr, "speed");
			ModifySkyAtRuntime.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifySkyAtRuntime>.NativeClassPtr, 100663551);
			ModifySkyAtRuntime.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifySkyAtRuntime>.NativeClassPtr, 100663552);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00078EB4 File Offset: 0x000770B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72741, XrefRangeEnd = 72764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifySkyAtRuntime.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00078EE8 File Offset: 0x000770E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72764, XrefRangeEnd = 72765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModifySkyAtRuntime() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifySkyAtRuntime>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifySkyAtRuntime.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00003872 File Offset: 0x00001A72
		public ModifySkyAtRuntime(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00078F24 File Offset: 0x00077124
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x0000387B File Offset: 0x00001A7B
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifySkyAtRuntime.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifySkyAtRuntime.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
