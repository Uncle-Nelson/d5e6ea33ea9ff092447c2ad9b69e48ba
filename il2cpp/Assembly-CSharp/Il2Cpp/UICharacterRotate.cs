using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Il2Cpp
{
	// Token: 0x0200001F RID: 31
	public class UICharacterRotate : MonoBehaviour
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x00076A4C File Offset: 0x00074C4C
		// Note: this type is marked as 'beforefieldinit'.
		static UICharacterRotate()
		{
			Il2CppClassPointerStore<UICharacterRotate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UICharacterRotate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UICharacterRotate>.NativeClassPtr);
			UICharacterRotate.NativeFieldInfoPtr_uIController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICharacterRotate>.NativeClassPtr, "uIController");
			UICharacterRotate.NativeFieldInfoPtr_mouseRotateCharacterPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICharacterRotate>.NativeClassPtr, "mouseRotateCharacterPower");
			UICharacterRotate.NativeFieldInfoPtr_toogle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICharacterRotate>.NativeClassPtr, "toogle");
			UICharacterRotate.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICharacterRotate>.NativeClassPtr, 100663478);
			UICharacterRotate.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICharacterRotate>.NativeClassPtr, 100663479);
			UICharacterRotate.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICharacterRotate>.NativeClassPtr, 100663480);
			UICharacterRotate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICharacterRotate>.NativeClassPtr, 100663481);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00076B08 File Offset: 0x00074D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72331, XrefRangeEnd = 72332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UICharacterRotate.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00076B4C File Offset: 0x00074D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72332, XrefRangeEnd = 72333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UICharacterRotate.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00076B90 File Offset: 0x00074D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72333, XrefRangeEnd = 72343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UICharacterRotate.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00076BC4 File Offset: 0x00074DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72343, XrefRangeEnd = 72344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UICharacterRotate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UICharacterRotate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UICharacterRotate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00003159 File Offset: 0x00001359
		public UICharacterRotate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00076C00 File Offset: 0x00074E00
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00003162 File Offset: 0x00001362
		public unsafe UIControllerDEMO uIController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICharacterRotate.NativeFieldInfoPtr_uIController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIControllerDEMO>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICharacterRotate.NativeFieldInfoPtr_uIController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00076C30 File Offset: 0x00074E30
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00003181 File Offset: 0x00001381
		public unsafe float mouseRotateCharacterPower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICharacterRotate.NativeFieldInfoPtr_mouseRotateCharacterPower);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICharacterRotate.NativeFieldInfoPtr_mouseRotateCharacterPower)) = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00076C58 File Offset: 0x00074E58
		// (set) Token: 0x060001FF RID: 511 RVA: 0x0000319C File Offset: 0x0000139C
		public unsafe bool toogle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICharacterRotate.NativeFieldInfoPtr_toogle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICharacterRotate.NativeFieldInfoPtr_toogle)) = value;
			}
		}

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeFieldInfoPtr_uIController;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeFieldInfoPtr_mouseRotateCharacterPower;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeFieldInfoPtr_toogle;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
