using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200073B RID: 1851
	public class BrickPressHandle : MonoBehaviour
	{
		// Token: 0x0600A9E9 RID: 43497 RVA: 0x002A70B4 File Offset: 0x002A52B4
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressHandle()
		{
			Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "BrickPressHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr);
			BrickPressHandle.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "<Interactable>k__BackingField");
			BrickPressHandle.NativeFieldInfoPtr__CurrentPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "<CurrentPosition>k__BackingField");
			BrickPressHandle.NativeFieldInfoPtr__TargetPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "<TargetPosition>k__BackingField");
			BrickPressHandle.NativeFieldInfoPtr_lastClickPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "lastClickPosition");
			BrickPressHandle.NativeFieldInfoPtr_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "MoveSpeed");
			BrickPressHandle.NativeFieldInfoPtr_Locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "Locked");
			BrickPressHandle.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "PlaneNormal");
			BrickPressHandle.NativeFieldInfoPtr_RaisedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "RaisedTransform");
			BrickPressHandle.NativeFieldInfoPtr_LoweredTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "LoweredTransform");
			BrickPressHandle.NativeFieldInfoPtr_HandleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "HandleClickable");
			BrickPressHandle.NativeFieldInfoPtr_ClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "ClickSound");
			BrickPressHandle.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "clickOffset");
			BrickPressHandle.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "isMoving");
			BrickPressHandle.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684142);
			BrickPressHandle.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684143);
			BrickPressHandle.NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684144);
			BrickPressHandle.NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684145);
			BrickPressHandle.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684146);
			BrickPressHandle.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684147);
			BrickPressHandle.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684148);
			BrickPressHandle.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684149);
			BrickPressHandle.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684150);
			BrickPressHandle.NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684151);
			BrickPressHandle.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684152);
			BrickPressHandle.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684153);
			BrickPressHandle.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684154);
			BrickPressHandle.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684155);
			BrickPressHandle.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684156);
			BrickPressHandle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100684157);
		}

		// Token: 0x1700348E RID: 13454
		// (get) Token: 0x0600A9EA RID: 43498 RVA: 0x002A7328 File Offset: 0x002A5528
		// (set) Token: 0x0600A9EB RID: 43499 RVA: 0x002A7364 File Offset: 0x002A5564
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700348F RID: 13455
		// (get) Token: 0x0600A9EC RID: 43500 RVA: 0x002A73A4 File Offset: 0x002A55A4
		// (set) Token: 0x0600A9ED RID: 43501 RVA: 0x002A73E0 File Offset: 0x002A55E0
		public unsafe float CurrentPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29977, RefRangeEnd = 29988, XrefRangeStart = 29977, XrefRangeEnd = 29988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003490 RID: 13456
		// (get) Token: 0x0600A9EE RID: 43502 RVA: 0x002A7420 File Offset: 0x002A5620
		// (set) Token: 0x0600A9EF RID: 43503 RVA: 0x002A745C File Offset: 0x002A565C
		public unsafe float TargetPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59852, RefRangeEnd = 59853, XrefRangeStart = 59852, XrefRangeEnd = 59853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A9F0 RID: 43504 RVA: 0x002A749C File Offset: 0x002A569C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295567, XrefRangeEnd = 295584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9F1 RID: 43505 RVA: 0x002A74D0 File Offset: 0x002A56D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295584, XrefRangeEnd = 295596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9F2 RID: 43506 RVA: 0x002A7504 File Offset: 0x002A5704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295604, RefRangeEnd = 295605, XrefRangeStart = 295596, XrefRangeEnd = 295604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9F3 RID: 43507 RVA: 0x002A7538 File Offset: 0x002A5738
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 81310, RefRangeEnd = 81320, XrefRangeStart = 81310, XrefRangeEnd = 81320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSound(float difference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref difference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9F4 RID: 43508 RVA: 0x002A7578 File Offset: 0x002A5778
		[CallerCount(0)]
		public unsafe void SetPosition(float position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9F5 RID: 43509 RVA: 0x002A75B8 File Offset: 0x002A57B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 295605, RefRangeEnd = 295608, XrefRangeStart = 295605, XrefRangeEnd = 295605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref e;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9F6 RID: 43510 RVA: 0x002A75F8 File Offset: 0x002A57F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295608, XrefRangeEnd = 295611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9F7 RID: 43511 RVA: 0x002A7638 File Offset: 0x002A5838
		[CallerCount(0)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9F8 RID: 43512 RVA: 0x002A766C File Offset: 0x002A586C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295624, RefRangeEnd = 295626, XrefRangeStart = 295611, XrefRangeEnd = 295624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A9F9 RID: 43513 RVA: 0x002A76A8 File Offset: 0x002A58A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295626, XrefRangeEnd = 295629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressHandle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9FA RID: 43514 RVA: 0x000539B3 File Offset: 0x00051BB3
		public BrickPressHandle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003481 RID: 13441
		// (get) Token: 0x0600A9FB RID: 43515 RVA: 0x002A76E4 File Offset: 0x002A58E4
		// (set) Token: 0x0600A9FC RID: 43516 RVA: 0x000539BC File Offset: 0x00051BBC
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x17003482 RID: 13442
		// (get) Token: 0x0600A9FD RID: 43517 RVA: 0x002A770C File Offset: 0x002A590C
		// (set) Token: 0x0600A9FE RID: 43518 RVA: 0x000539D7 File Offset: 0x00051BD7
		public unsafe float _CurrentPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__CurrentPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__CurrentPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17003483 RID: 13443
		// (get) Token: 0x0600A9FF RID: 43519 RVA: 0x002A7734 File Offset: 0x002A5934
		// (set) Token: 0x0600AA00 RID: 43520 RVA: 0x000539F2 File Offset: 0x00051BF2
		public unsafe float _TargetPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__TargetPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__TargetPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17003484 RID: 13444
		// (get) Token: 0x0600AA01 RID: 43521 RVA: 0x002A775C File Offset: 0x002A595C
		// (set) Token: 0x0600AA02 RID: 43522 RVA: 0x00053A0D File Offset: 0x00051C0D
		public unsafe float lastClickPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_lastClickPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_lastClickPosition)) = value;
			}
		}

		// Token: 0x17003485 RID: 13445
		// (get) Token: 0x0600AA03 RID: 43523 RVA: 0x002A7784 File Offset: 0x002A5984
		// (set) Token: 0x0600AA04 RID: 43524 RVA: 0x00053A28 File Offset: 0x00051C28
		public unsafe float MoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_MoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_MoveSpeed)) = value;
			}
		}

		// Token: 0x17003486 RID: 13446
		// (get) Token: 0x0600AA05 RID: 43525 RVA: 0x002A77AC File Offset: 0x002A59AC
		// (set) Token: 0x0600AA06 RID: 43526 RVA: 0x00053A43 File Offset: 0x00051C43
		public unsafe bool Locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_Locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_Locked)) = value;
			}
		}

		// Token: 0x17003487 RID: 13447
		// (get) Token: 0x0600AA07 RID: 43527 RVA: 0x002A77D4 File Offset: 0x002A59D4
		// (set) Token: 0x0600AA08 RID: 43528 RVA: 0x00053A5E File Offset: 0x00051C5E
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003488 RID: 13448
		// (get) Token: 0x0600AA09 RID: 43529 RVA: 0x002A7804 File Offset: 0x002A5A04
		// (set) Token: 0x0600AA0A RID: 43530 RVA: 0x00053A7D File Offset: 0x00051C7D
		public unsafe Transform RaisedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_RaisedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_RaisedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003489 RID: 13449
		// (get) Token: 0x0600AA0B RID: 43531 RVA: 0x002A7834 File Offset: 0x002A5A34
		// (set) Token: 0x0600AA0C RID: 43532 RVA: 0x00053A9C File Offset: 0x00051C9C
		public unsafe Transform LoweredTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_LoweredTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_LoweredTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700348A RID: 13450
		// (get) Token: 0x0600AA0D RID: 43533 RVA: 0x002A7864 File Offset: 0x002A5A64
		// (set) Token: 0x0600AA0E RID: 43534 RVA: 0x00053ABB File Offset: 0x00051CBB
		public unsafe Clickable HandleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_HandleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_HandleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700348B RID: 13451
		// (get) Token: 0x0600AA0F RID: 43535 RVA: 0x002A7894 File Offset: 0x002A5A94
		// (set) Token: 0x0600AA10 RID: 43536 RVA: 0x00053ADA File Offset: 0x00051CDA
		public unsafe AudioSourceController ClickSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_ClickSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_ClickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700348C RID: 13452
		// (get) Token: 0x0600AA11 RID: 43537 RVA: 0x002A78C4 File Offset: 0x002A5AC4
		// (set) Token: 0x0600AA12 RID: 43538 RVA: 0x00053AF9 File Offset: 0x00051CF9
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x1700348D RID: 13453
		// (get) Token: 0x0600AA13 RID: 43539 RVA: 0x002A78EC File Offset: 0x002A5AEC
		// (set) Token: 0x0600AA14 RID: 43540 RVA: 0x00053B14 File Offset: 0x00051D14
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x0400721B RID: 29211
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x0400721C RID: 29212
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPosition_k__BackingField;

		// Token: 0x0400721D RID: 29213
		private static readonly IntPtr NativeFieldInfoPtr__TargetPosition_k__BackingField;

		// Token: 0x0400721E RID: 29214
		private static readonly IntPtr NativeFieldInfoPtr_lastClickPosition;

		// Token: 0x0400721F RID: 29215
		private static readonly IntPtr NativeFieldInfoPtr_MoveSpeed;

		// Token: 0x04007220 RID: 29216
		private static readonly IntPtr NativeFieldInfoPtr_Locked;

		// Token: 0x04007221 RID: 29217
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x04007222 RID: 29218
		private static readonly IntPtr NativeFieldInfoPtr_RaisedTransform;

		// Token: 0x04007223 RID: 29219
		private static readonly IntPtr NativeFieldInfoPtr_LoweredTransform;

		// Token: 0x04007224 RID: 29220
		private static readonly IntPtr NativeFieldInfoPtr_HandleClickable;

		// Token: 0x04007225 RID: 29221
		private static readonly IntPtr NativeFieldInfoPtr_ClickSound;

		// Token: 0x04007226 RID: 29222
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x04007227 RID: 29223
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x04007228 RID: 29224
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x04007229 RID: 29225
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x0400722A RID: 29226
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0;

		// Token: 0x0400722B RID: 29227
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0;

		// Token: 0x0400722C RID: 29228
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0;

		// Token: 0x0400722D RID: 29229
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0;

		// Token: 0x0400722E RID: 29230
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400722F RID: 29231
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04007230 RID: 29232
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x04007231 RID: 29233
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0;

		// Token: 0x04007232 RID: 29234
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Single_0;

		// Token: 0x04007233 RID: 29235
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x04007234 RID: 29236
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x04007235 RID: 29237
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x04007236 RID: 29238
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x04007237 RID: 29239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
