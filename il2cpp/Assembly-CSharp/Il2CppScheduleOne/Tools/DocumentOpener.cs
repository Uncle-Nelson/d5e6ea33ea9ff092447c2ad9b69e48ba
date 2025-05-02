using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000536 RID: 1334
	public class DocumentOpener : MonoBehaviour
	{
		// Token: 0x060076C9 RID: 30409 RVA: 0x00204340 File Offset: 0x00202540
		// Note: this type is marked as 'beforefieldinit'.
		static DocumentOpener()
		{
			Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "DocumentOpener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr);
			DocumentOpener.NativeFieldInfoPtr_DocumentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr, "DocumentName");
			DocumentOpener.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr, 100678255);
			DocumentOpener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr, 100678256);
		}

		// Token: 0x060076CA RID: 30410 RVA: 0x002043AC File Offset: 0x002025AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231262, XrefRangeEnd = 231268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentOpener.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076CB RID: 30411 RVA: 0x002043E0 File Offset: 0x002025E0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DocumentOpener() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentOpener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076CC RID: 30412 RVA: 0x000384BC File Offset: 0x000366BC
		public DocumentOpener(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023F5 RID: 9205
		// (get) Token: 0x060076CD RID: 30413 RVA: 0x0020441C File Offset: 0x0020261C
		// (set) Token: 0x060076CE RID: 30414 RVA: 0x000384C5 File Offset: 0x000366C5
		public unsafe string DocumentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentOpener.NativeFieldInfoPtr_DocumentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentOpener.NativeFieldInfoPtr_DocumentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400511D RID: 20765
		private static readonly IntPtr NativeFieldInfoPtr_DocumentName;

		// Token: 0x0400511E RID: 20766
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x0400511F RID: 20767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
