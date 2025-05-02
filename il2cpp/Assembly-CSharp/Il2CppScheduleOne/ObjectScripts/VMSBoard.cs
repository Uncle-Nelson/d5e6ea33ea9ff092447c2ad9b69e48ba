using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200072A RID: 1834
	public class VMSBoard : MonoBehaviour
	{
		// Token: 0x0600A5A1 RID: 42401 RVA: 0x00297594 File Offset: 0x00295794
		// Note: this type is marked as 'beforefieldinit'.
		static VMSBoard()
		{
			Il2CppClassPointerStore<VMSBoard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "VMSBoard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr);
			VMSBoard.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr, "Label");
			VMSBoard.NativeMethodInfoPtr_SetText_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr, 100683553);
			VMSBoard.NativeMethodInfoPtr_SetText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr, 100683554);
			VMSBoard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr, 100683555);
		}

		// Token: 0x0600A5A2 RID: 42402 RVA: 0x00297614 File Offset: 0x00295814
		[CallerCount(0)]
		public unsafe void SetText(string text, Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VMSBoard.NativeMethodInfoPtr_SetText_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5A3 RID: 42403 RVA: 0x00297664 File Offset: 0x00295864
		[CallerCount(0)]
		public unsafe void SetText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VMSBoard.NativeMethodInfoPtr_SetText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5A4 RID: 42404 RVA: 0x002976A8 File Offset: 0x002958A8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VMSBoard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VMSBoard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5A5 RID: 42405 RVA: 0x000519BB File Offset: 0x0004FBBB
		public VMSBoard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700331E RID: 13086
		// (get) Token: 0x0600A5A6 RID: 42406 RVA: 0x002976E4 File Offset: 0x002958E4
		// (set) Token: 0x0600A5A7 RID: 42407 RVA: 0x000519C4 File Offset: 0x0004FBC4
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VMSBoard.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VMSBoard.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006F0E RID: 28430
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006F0F RID: 28431
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Color_0;

		// Token: 0x04006F10 RID: 28432
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_0;

		// Token: 0x04006F11 RID: 28433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
