using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005B3 RID: 1459
	public class MixChute : MonoBehaviour
	{
		// Token: 0x0600802C RID: 32812 RVA: 0x00224B5C File Offset: 0x00222D5C
		// Note: this type is marked as 'beforefieldinit'.
		static MixChute()
		{
			Il2CppClassPointerStore<MixChute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "MixChute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixChute>.NativeClassPtr);
			MixChute.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixChute>.NativeClassPtr, "IntObj");
			MixChute.NativeFieldInfoPtr_DoorAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixChute>.NativeClassPtr, "DoorAnim");
			MixChute.NativeFieldInfoPtr_isDoorOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixChute>.NativeClassPtr, "isDoorOpen");
			MixChute.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixChute>.NativeClassPtr, 100679399);
			MixChute.NativeMethodInfoPtr_UpdateDoor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixChute>.NativeClassPtr, 100679400);
			MixChute.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixChute>.NativeClassPtr, 100679401);
			MixChute.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixChute>.NativeClassPtr, 100679402);
			MixChute.NativeMethodInfoPtr_SetDoorOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixChute>.NativeClassPtr, 100679403);
			MixChute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixChute>.NativeClassPtr, 100679404);
		}

		// Token: 0x0600802D RID: 32813 RVA: 0x00224C40 File Offset: 0x00222E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244199, XrefRangeEnd = 244207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixChute.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600802E RID: 32814 RVA: 0x00224C74 File Offset: 0x00222E74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244223, RefRangeEnd = 244224, XrefRangeStart = 244207, XrefRangeEnd = 244223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixChute.NativeMethodInfoPtr_UpdateDoor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600802F RID: 32815 RVA: 0x00224CA8 File Offset: 0x00222EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244224, XrefRangeEnd = 244236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixChute.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008030 RID: 32816 RVA: 0x00224CDC File Offset: 0x00222EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244236, XrefRangeEnd = 244248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixChute.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008031 RID: 32817 RVA: 0x00224D10 File Offset: 0x00222F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244248, XrefRangeEnd = 244254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDoorOpen(bool isOpen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixChute.NativeMethodInfoPtr_SetDoorOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008032 RID: 32818 RVA: 0x00224D50 File Offset: 0x00222F50
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixChute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixChute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixChute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008033 RID: 32819 RVA: 0x0003CC0E File Offset: 0x0003AE0E
		public MixChute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026B4 RID: 9908
		// (get) Token: 0x06008034 RID: 32820 RVA: 0x00224D8C File Offset: 0x00222F8C
		// (set) Token: 0x06008035 RID: 32821 RVA: 0x0003CC17 File Offset: 0x0003AE17
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixChute.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixChute.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B5 RID: 9909
		// (get) Token: 0x06008036 RID: 32822 RVA: 0x00224DBC File Offset: 0x00222FBC
		// (set) Token: 0x06008037 RID: 32823 RVA: 0x0003CC36 File Offset: 0x0003AE36
		public unsafe Animation DoorAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixChute.NativeFieldInfoPtr_DoorAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixChute.NativeFieldInfoPtr_DoorAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B6 RID: 9910
		// (get) Token: 0x06008038 RID: 32824 RVA: 0x00224DEC File Offset: 0x00222FEC
		// (set) Token: 0x06008039 RID: 32825 RVA: 0x0003CC55 File Offset: 0x0003AE55
		public unsafe bool isDoorOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixChute.NativeFieldInfoPtr_isDoorOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixChute.NativeFieldInfoPtr_isDoorOpen)) = value;
			}
		}

		// Token: 0x04005753 RID: 22355
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04005754 RID: 22356
		private static readonly IntPtr NativeFieldInfoPtr_DoorAnim;

		// Token: 0x04005755 RID: 22357
		private static readonly IntPtr NativeFieldInfoPtr_isDoorOpen;

		// Token: 0x04005756 RID: 22358
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005757 RID: 22359
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDoor_Private_Void_0;

		// Token: 0x04005758 RID: 22360
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04005759 RID: 22361
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x0400575A RID: 22362
		private static readonly IntPtr NativeMethodInfoPtr_SetDoorOpen_Public_Void_Boolean_0;

		// Token: 0x0400575B RID: 22363
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
