using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200002C RID: 44
	public class GarageDoorStatus : MonoBehaviour
	{
		// Token: 0x06000334 RID: 820 RVA: 0x0007A584 File Offset: 0x00078784
		// Note: this type is marked as 'beforefieldinit'.
		static GarageDoorStatus()
		{
			Il2CppClassPointerStore<GarageDoorStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GarageDoorStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GarageDoorStatus>.NativeClassPtr);
			GarageDoorStatus.NativeFieldInfoPtr_doorIsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorStatus>.NativeClassPtr, "doorIsOpen");
			GarageDoorStatus.NativeFieldInfoPtr_canRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorStatus>.NativeClassPtr, "canRotate");
			GarageDoorStatus.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorStatus>.NativeClassPtr, 100663605);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0007A5F0 File Offset: 0x000787F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73279, XrefRangeEnd = 73280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GarageDoorStatus() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GarageDoorStatus>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorStatus.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00003CDB File Offset: 0x00001EDB
		public GarageDoorStatus(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000337 RID: 823 RVA: 0x0007A62C File Offset: 0x0007882C
		// (set) Token: 0x06000338 RID: 824 RVA: 0x00003CE4 File Offset: 0x00001EE4
		public unsafe bool doorIsOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorStatus.NativeFieldInfoPtr_doorIsOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorStatus.NativeFieldInfoPtr_doorIsOpen)) = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000339 RID: 825 RVA: 0x0007A654 File Offset: 0x00078854
		// (set) Token: 0x0600033A RID: 826 RVA: 0x00003CFF File Offset: 0x00001EFF
		public unsafe bool canRotate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorStatus.NativeFieldInfoPtr_canRotate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorStatus.NativeFieldInfoPtr_canRotate)) = value;
			}
		}

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeFieldInfoPtr_doorIsOpen;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr_canRotate;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
