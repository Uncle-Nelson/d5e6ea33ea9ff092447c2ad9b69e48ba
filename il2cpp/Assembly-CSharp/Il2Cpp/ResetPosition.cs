using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000048 RID: 72
	public class ResetPosition : MonoBehaviour
	{
		// Token: 0x06000612 RID: 1554 RVA: 0x00082708 File Offset: 0x00080908
		// Note: this type is marked as 'beforefieldinit'.
		static ResetPosition()
		{
			Il2CppClassPointerStore<ResetPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResetPosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr);
			ResetPosition.NativeFieldInfoPtr_distanceToReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr, "distanceToReset");
			ResetPosition.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr, "startPosition");
			ResetPosition.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr, 100663863);
			ResetPosition.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr, 100663864);
			ResetPosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr, 100663865);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0008279C File Offset: 0x0008099C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetPosition.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x000827D0 File Offset: 0x000809D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75760, XrefRangeEnd = 75769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetPosition.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00082804 File Offset: 0x00080A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75769, XrefRangeEnd = 75770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResetPosition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetPosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00005970 File Offset: 0x00003B70
		public ResetPosition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x00082840 File Offset: 0x00080A40
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x00005979 File Offset: 0x00003B79
		public unsafe float distanceToReset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPosition.NativeFieldInfoPtr_distanceToReset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPosition.NativeFieldInfoPtr_distanceToReset)) = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x00082868 File Offset: 0x00080A68
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x00005994 File Offset: 0x00003B94
		public unsafe Vector3 startPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPosition.NativeFieldInfoPtr_startPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPosition.NativeFieldInfoPtr_startPosition)) = value;
			}
		}

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeFieldInfoPtr_distanceToReset;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeFieldInfoPtr_startPosition;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
