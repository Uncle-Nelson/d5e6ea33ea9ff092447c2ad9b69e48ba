using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x020005FE RID: 1534
	public class AvatarEquippable : MonoBehaviour
	{
		// Token: 0x0600872C RID: 34604 RVA: 0x0023B384 File Offset: 0x00239584
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEquippable()
		{
			Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarEquippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr);
			AvatarEquippable.NativeFieldInfoPtr_AlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "AlignmentPoint");
			AvatarEquippable.NativeFieldInfoPtr_Suspiciousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "Suspiciousness");
			AvatarEquippable.NativeFieldInfoPtr_Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "Hand");
			AvatarEquippable.NativeFieldInfoPtr_TriggerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "TriggerType");
			AvatarEquippable.NativeFieldInfoPtr_AnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "AnimationTrigger");
			AvatarEquippable.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "AssetPath");
			AvatarEquippable.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "avatar");
			AvatarEquippable.NativeMethodInfoPtr_RecalculateAssetPath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680170);
			AvatarEquippable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680171);
			AvatarEquippable.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680172);
			AvatarEquippable.NativeMethodInfoPtr_InitializeAnimation_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680173);
			AvatarEquippable.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680174);
			AvatarEquippable.NativeMethodInfoPtr_PositionAnimationModel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680175);
			AvatarEquippable.NativeMethodInfoPtr_SetTrigger_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680176);
			AvatarEquippable.NativeMethodInfoPtr_SetBool_Protected_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680177);
			AvatarEquippable.NativeMethodInfoPtr_ResetTrigger_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680178);
			AvatarEquippable.NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680179);
			AvatarEquippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680180);
		}

		// Token: 0x0600872D RID: 34605 RVA: 0x0023B51C File Offset: 0x0023971C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251545, XrefRangeEnd = 251559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateAssetPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_RecalculateAssetPath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600872E RID: 34606 RVA: 0x0023B550 File Offset: 0x00239750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251559, XrefRangeEnd = 251571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600872F RID: 34607 RVA: 0x0023B58C File Offset: 0x0023978C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 251595, RefRangeEnd = 251598, XrefRangeStart = 251571, XrefRangeEnd = 251595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Equip(Avatar _avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_Avatar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008730 RID: 34608 RVA: 0x0023B5DC File Offset: 0x002397DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251598, XrefRangeEnd = 251600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_InitializeAnimation_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008731 RID: 34609 RVA: 0x0023B618 File Offset: 0x00239818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251600, XrefRangeEnd = 251610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008732 RID: 34610 RVA: 0x0023B654 File Offset: 0x00239854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 251624, RefRangeEnd = 251625, XrefRangeStart = 251610, XrefRangeEnd = 251624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionAnimationModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_PositionAnimationModel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008733 RID: 34611 RVA: 0x0023B688 File Offset: 0x00239888
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 251641, RefRangeEnd = 251648, XrefRangeStart = 251625, XrefRangeEnd = 251641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrigger(string anim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(anim);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_SetTrigger_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008734 RID: 34612 RVA: 0x0023B6CC File Offset: 0x002398CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 251664, RefRangeEnd = 251667, XrefRangeStart = 251648, XrefRangeEnd = 251664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBool(string anim, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(anim);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_SetBool_Protected_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008735 RID: 34613 RVA: 0x0023B71C File Offset: 0x0023991C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 251683, RefRangeEnd = 251688, XrefRangeStart = 251667, XrefRangeEnd = 251683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTrigger(string anim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(anim);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_ResetTrigger_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008736 RID: 34614 RVA: 0x0023B760 File Offset: 0x00239960
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveMessage(string message, Il2CppSystem.Object parameter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008737 RID: 34615 RVA: 0x0023B7C0 File Offset: 0x002399C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251688, XrefRangeEnd = 251696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEquippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008738 RID: 34616 RVA: 0x00040516 File Offset: 0x0003E716
		public AvatarEquippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002915 RID: 10517
		// (get) Token: 0x06008739 RID: 34617 RVA: 0x0023B7FC File Offset: 0x002399FC
		// (set) Token: 0x0600873A RID: 34618 RVA: 0x0004051F File Offset: 0x0003E71F
		public unsafe Transform AlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002916 RID: 10518
		// (get) Token: 0x0600873B RID: 34619 RVA: 0x0023B82C File Offset: 0x00239A2C
		// (set) Token: 0x0600873C RID: 34620 RVA: 0x0004053E File Offset: 0x0003E73E
		public unsafe float Suspiciousness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_Suspiciousness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_Suspiciousness)) = value;
			}
		}

		// Token: 0x17002917 RID: 10519
		// (get) Token: 0x0600873D RID: 34621 RVA: 0x0023B854 File Offset: 0x00239A54
		// (set) Token: 0x0600873E RID: 34622 RVA: 0x00040559 File Offset: 0x0003E759
		public unsafe AvatarEquippable.EHand Hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_Hand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_Hand)) = value;
			}
		}

		// Token: 0x17002918 RID: 10520
		// (get) Token: 0x0600873F RID: 34623 RVA: 0x0023B87C File Offset: 0x00239A7C
		// (set) Token: 0x06008740 RID: 34624 RVA: 0x00040574 File Offset: 0x0003E774
		public unsafe AvatarEquippable.ETriggerType TriggerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_TriggerType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_TriggerType)) = value;
			}
		}

		// Token: 0x17002919 RID: 10521
		// (get) Token: 0x06008741 RID: 34625 RVA: 0x0023B8A4 File Offset: 0x00239AA4
		// (set) Token: 0x06008742 RID: 34626 RVA: 0x0004058F File Offset: 0x0003E78F
		public unsafe string AnimationTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700291A RID: 10522
		// (get) Token: 0x06008743 RID: 34627 RVA: 0x0023B8CC File Offset: 0x00239ACC
		// (set) Token: 0x06008744 RID: 34628 RVA: 0x000405AE File Offset: 0x0003E7AE
		public unsafe string AssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700291B RID: 10523
		// (get) Token: 0x06008745 RID: 34629 RVA: 0x0023B8F4 File Offset: 0x00239AF4
		// (set) Token: 0x06008746 RID: 34630 RVA: 0x000405CD File Offset: 0x0003E7CD
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BF8 RID: 23544
		private static readonly IntPtr NativeFieldInfoPtr_AlignmentPoint;

		// Token: 0x04005BF9 RID: 23545
		private static readonly IntPtr NativeFieldInfoPtr_Suspiciousness;

		// Token: 0x04005BFA RID: 23546
		private static readonly IntPtr NativeFieldInfoPtr_Hand;

		// Token: 0x04005BFB RID: 23547
		private static readonly IntPtr NativeFieldInfoPtr_TriggerType;

		// Token: 0x04005BFC RID: 23548
		private static readonly IntPtr NativeFieldInfoPtr_AnimationTrigger;

		// Token: 0x04005BFD RID: 23549
		private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

		// Token: 0x04005BFE RID: 23550
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04005BFF RID: 23551
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateAssetPath_Public_Void_0;

		// Token: 0x04005C00 RID: 23552
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005C01 RID: 23553
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_Avatar_0;

		// Token: 0x04005C02 RID: 23554
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAnimation_Public_Virtual_New_Void_0;

		// Token: 0x04005C03 RID: 23555
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0;

		// Token: 0x04005C04 RID: 23556
		private static readonly IntPtr NativeMethodInfoPtr_PositionAnimationModel_Private_Void_0;

		// Token: 0x04005C05 RID: 23557
		private static readonly IntPtr NativeMethodInfoPtr_SetTrigger_Protected_Void_String_0;

		// Token: 0x04005C06 RID: 23558
		private static readonly IntPtr NativeMethodInfoPtr_SetBool_Protected_Void_String_Boolean_0;

		// Token: 0x04005C07 RID: 23559
		private static readonly IntPtr NativeMethodInfoPtr_ResetTrigger_Protected_Void_String_0;

		// Token: 0x04005C08 RID: 23560
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_New_Void_String_Object_0;

		// Token: 0x04005C09 RID: 23561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AF5 RID: 2805
		[OriginalName("Assembly-CSharp.dll", "", "ETriggerType")]
		public enum ETriggerType
		{
			// Token: 0x04008FD8 RID: 36824
			Trigger,
			// Token: 0x04008FD9 RID: 36825
			Bool
		}

		// Token: 0x02000AF6 RID: 2806
		[OriginalName("Assembly-CSharp.dll", "", "EHand")]
		public enum EHand
		{
			// Token: 0x04008FDB RID: 36827
			Left,
			// Token: 0x04008FDC RID: 36828
			Right
		}
	}
}
