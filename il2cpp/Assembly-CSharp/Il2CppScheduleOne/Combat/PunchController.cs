using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000497 RID: 1175
	public class PunchController : MonoBehaviour
	{
		// Token: 0x06006576 RID: 25974 RVA: 0x001C9D90 File Offset: 0x001C7F90
		// Note: this type is marked as 'beforefieldinit'.
		static PunchController()
		{
			Il2CppClassPointerStore<PunchController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "PunchController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunchController>.NativeClassPtr);
			PunchController.NativeFieldInfoPtr_MAX_PUNCH_LOAD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MAX_PUNCH_LOAD");
			PunchController.NativeFieldInfoPtr_MIN_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MIN_COOLDOWN");
			PunchController.NativeFieldInfoPtr_MAX_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MAX_COOLDOWN");
			PunchController.NativeFieldInfoPtr_PUNCH_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "PUNCH_RANGE");
			PunchController.NativeFieldInfoPtr_PUNCH_DEBOUNCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "PUNCH_DEBOUNCE");
			PunchController.NativeFieldInfoPtr__PunchingEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "<PunchingEnabled>k__BackingField");
			PunchController.NativeFieldInfoPtr__IsPunching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "<IsPunching>k__BackingField");
			PunchController.NativeFieldInfoPtr_ViewmodelAvatarOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "ViewmodelAvatarOffset");
			PunchController.NativeFieldInfoPtr_MinPunchDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MinPunchDamage");
			PunchController.NativeFieldInfoPtr_MaxPunchDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MaxPunchDamage");
			PunchController.NativeFieldInfoPtr_MinPunchForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MinPunchForce");
			PunchController.NativeFieldInfoPtr_MaxPunchForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MaxPunchForce");
			PunchController.NativeFieldInfoPtr_MinStaminaCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MinStaminaCost");
			PunchController.NativeFieldInfoPtr_MaxStaminaCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MaxStaminaCost");
			PunchController.NativeFieldInfoPtr_PunchSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "PunchSound");
			PunchController.NativeFieldInfoPtr_PunchAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "PunchAnimator");
			PunchController.NativeFieldInfoPtr_punchLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "punchLoad");
			PunchController.NativeFieldInfoPtr_remainingCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "remainingCooldown");
			PunchController.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "player");
			PunchController.NativeFieldInfoPtr_punchRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "punchRoutine");
			PunchController.NativeFieldInfoPtr_itemEquippedLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "itemEquippedLastFrame");
			PunchController.NativeFieldInfoPtr_timeSincePunchingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "timeSincePunchingEnabled");
			PunchController.NativeMethodInfoPtr_get_PunchingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676127);
			PunchController.NativeMethodInfoPtr_set_PunchingEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676128);
			PunchController.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676129);
			PunchController.NativeMethodInfoPtr_get_IsPunching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676130);
			PunchController.NativeMethodInfoPtr_set_IsPunching_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676131);
			PunchController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676132);
			PunchController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676133);
			PunchController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676134);
			PunchController.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676135);
			PunchController.NativeMethodInfoPtr_UpdateCooldown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676136);
			PunchController.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676137);
			PunchController.NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676138);
			PunchController.NativeMethodInfoPtr_StartLoad_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676139);
			PunchController.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676140);
			PunchController.NativeMethodInfoPtr_Punch_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676141);
			PunchController.NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676142);
			PunchController.NativeMethodInfoPtr_SetPunchingEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676143);
			PunchController.NativeMethodInfoPtr_ShouldBeEnabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676144);
			PunchController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676145);
			PunchController.NativeMethodInfoPtr__Start_b__31_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676146);
		}

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x06006577 RID: 25975 RVA: 0x001CA108 File Offset: 0x001C8308
		// (set) Token: 0x06006578 RID: 25976 RVA: 0x001CA144 File Offset: 0x001C8344
		public unsafe bool PunchingEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_get_PunchingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_set_PunchingEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x06006579 RID: 25977 RVA: 0x001CA184 File Offset: 0x001C8384
		public unsafe bool IsLoading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x0600657A RID: 25978 RVA: 0x001CA1C0 File Offset: 0x001C83C0
		// (set) Token: 0x0600657B RID: 25979 RVA: 0x001CA1FC File Offset: 0x001C83FC
		public unsafe bool IsPunching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_get_IsPunching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_set_IsPunching_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600657C RID: 25980 RVA: 0x001CA23C File Offset: 0x001C843C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206012, XrefRangeEnd = 206016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600657D RID: 25981 RVA: 0x001CA270 File Offset: 0x001C8470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206016, XrefRangeEnd = 206028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600657E RID: 25982 RVA: 0x001CA2A4 File Offset: 0x001C84A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206028, XrefRangeEnd = 206037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600657F RID: 25983 RVA: 0x001CA2D8 File Offset: 0x001C84D8
		[CallerCount(0)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006580 RID: 25984 RVA: 0x001CA30C File Offset: 0x001C850C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206037, XrefRangeEnd = 206039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCooldown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_UpdateCooldown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006581 RID: 25985 RVA: 0x001CA340 File Offset: 0x001C8540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206047, RefRangeEnd = 206048, XrefRangeStart = 206039, XrefRangeEnd = 206047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006582 RID: 25986 RVA: 0x001CA374 File Offset: 0x001C8574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206048, XrefRangeEnd = 206052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStartLoading()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006583 RID: 25987 RVA: 0x001CA3B0 File Offset: 0x001C85B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206052, XrefRangeEnd = 206083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLoad()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_StartLoad_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006584 RID: 25988 RVA: 0x001CA3E4 File Offset: 0x001C85E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206083, XrefRangeEnd = 206117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006585 RID: 25989 RVA: 0x001CA418 File Offset: 0x001C8618
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206133, RefRangeEnd = 206134, XrefRangeStart = 206117, XrefRangeEnd = 206133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Punch(float power)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref power;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Punch_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006586 RID: 25990 RVA: 0x001CA458 File Offset: 0x001C8658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206134, XrefRangeEnd = 206203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteHit(float power)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref power;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006587 RID: 25991 RVA: 0x001CA498 File Offset: 0x001C8698
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206219, RefRangeEnd = 206221, XrefRangeStart = 206203, XrefRangeEnd = 206219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPunchingEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_SetPunchingEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006588 RID: 25992 RVA: 0x001CA4D8 File Offset: 0x001C86D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206265, RefRangeEnd = 206266, XrefRangeStart = 206221, XrefRangeEnd = 206265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldBeEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_ShouldBeEnabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006589 RID: 25993 RVA: 0x001CA514 File Offset: 0x001C8714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206266, XrefRangeEnd = 206267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PunchController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PunchController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600658A RID: 25994 RVA: 0x001CA550 File Offset: 0x001C8750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206267, XrefRangeEnd = 206268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__31_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr__Start_b__31_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600658B RID: 25995 RVA: 0x00030007 File Offset: 0x0002E207
		public PunchController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x0600658C RID: 25996 RVA: 0x001CA584 File Offset: 0x001C8784
		// (set) Token: 0x0600658D RID: 25997 RVA: 0x00030010 File Offset: 0x0002E210
		public unsafe static float MAX_PUNCH_LOAD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_MAX_PUNCH_LOAD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_MAX_PUNCH_LOAD, (void*)(&value));
			}
		}

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x0600658E RID: 25998 RVA: 0x001CA5A0 File Offset: 0x001C87A0
		// (set) Token: 0x0600658F RID: 25999 RVA: 0x0003001E File Offset: 0x0002E21E
		public unsafe static float MIN_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_MIN_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_MIN_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x06006590 RID: 26000 RVA: 0x001CA5BC File Offset: 0x001C87BC
		// (set) Token: 0x06006591 RID: 26001 RVA: 0x0003002C File Offset: 0x0002E22C
		public unsafe static float MAX_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_MAX_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_MAX_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x06006592 RID: 26002 RVA: 0x001CA5D8 File Offset: 0x001C87D8
		// (set) Token: 0x06006593 RID: 26003 RVA: 0x0003003A File Offset: 0x0002E23A
		public unsafe static float PUNCH_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_PUNCH_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_PUNCH_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x06006594 RID: 26004 RVA: 0x001CA5F4 File Offset: 0x001C87F4
		// (set) Token: 0x06006595 RID: 26005 RVA: 0x00030048 File Offset: 0x0002E248
		public unsafe static float PUNCH_DEBOUNCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_PUNCH_DEBOUNCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_PUNCH_DEBOUNCE, (void*)(&value));
			}
		}

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x06006596 RID: 26006 RVA: 0x001CA610 File Offset: 0x001C8810
		// (set) Token: 0x06006597 RID: 26007 RVA: 0x00030056 File Offset: 0x0002E256
		public unsafe bool _PunchingEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr__PunchingEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr__PunchingEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x06006598 RID: 26008 RVA: 0x001CA638 File Offset: 0x001C8838
		// (set) Token: 0x06006599 RID: 26009 RVA: 0x00030071 File Offset: 0x0002E271
		public unsafe bool _IsPunching_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr__IsPunching_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr__IsPunching_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x0600659A RID: 26010 RVA: 0x001CA660 File Offset: 0x001C8860
		// (set) Token: 0x0600659B RID: 26011 RVA: 0x0003008C File Offset: 0x0002E28C
		public unsafe Vector3 ViewmodelAvatarOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_ViewmodelAvatarOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_ViewmodelAvatarOffset)) = value;
			}
		}

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x0600659C RID: 26012 RVA: 0x001CA688 File Offset: 0x001C8888
		// (set) Token: 0x0600659D RID: 26013 RVA: 0x000300A7 File Offset: 0x0002E2A7
		public unsafe float MinPunchDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinPunchDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinPunchDamage)) = value;
			}
		}

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x0600659E RID: 26014 RVA: 0x001CA6B0 File Offset: 0x001C88B0
		// (set) Token: 0x0600659F RID: 26015 RVA: 0x000300C2 File Offset: 0x0002E2C2
		public unsafe float MaxPunchDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxPunchDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxPunchDamage)) = value;
			}
		}

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x060065A0 RID: 26016 RVA: 0x001CA6D8 File Offset: 0x001C88D8
		// (set) Token: 0x060065A1 RID: 26017 RVA: 0x000300DD File Offset: 0x0002E2DD
		public unsafe float MinPunchForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinPunchForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinPunchForce)) = value;
			}
		}

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x060065A2 RID: 26018 RVA: 0x001CA700 File Offset: 0x001C8900
		// (set) Token: 0x060065A3 RID: 26019 RVA: 0x000300F8 File Offset: 0x0002E2F8
		public unsafe float MaxPunchForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxPunchForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxPunchForce)) = value;
			}
		}

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x060065A4 RID: 26020 RVA: 0x001CA728 File Offset: 0x001C8928
		// (set) Token: 0x060065A5 RID: 26021 RVA: 0x00030113 File Offset: 0x0002E313
		public unsafe float MinStaminaCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinStaminaCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinStaminaCost)) = value;
			}
		}

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x060065A6 RID: 26022 RVA: 0x001CA750 File Offset: 0x001C8950
		// (set) Token: 0x060065A7 RID: 26023 RVA: 0x0003012E File Offset: 0x0002E32E
		public unsafe float MaxStaminaCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxStaminaCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxStaminaCost)) = value;
			}
		}

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x060065A8 RID: 26024 RVA: 0x001CA778 File Offset: 0x001C8978
		// (set) Token: 0x060065A9 RID: 26025 RVA: 0x00030149 File Offset: 0x0002E349
		public unsafe AudioSourceController PunchSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_PunchSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_PunchSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x060065AA RID: 26026 RVA: 0x001CA7A8 File Offset: 0x001C89A8
		// (set) Token: 0x060065AB RID: 26027 RVA: 0x00030168 File Offset: 0x0002E368
		public unsafe RuntimeAnimatorController PunchAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_PunchAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_PunchAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x060065AC RID: 26028 RVA: 0x001CA7D8 File Offset: 0x001C89D8
		// (set) Token: 0x060065AD RID: 26029 RVA: 0x00030187 File Offset: 0x0002E387
		public unsafe float punchLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_punchLoad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_punchLoad)) = value;
			}
		}

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x060065AE RID: 26030 RVA: 0x001CA800 File Offset: 0x001C8A00
		// (set) Token: 0x060065AF RID: 26031 RVA: 0x000301A2 File Offset: 0x0002E3A2
		public unsafe float remainingCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_remainingCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_remainingCooldown)) = value;
			}
		}

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x060065B0 RID: 26032 RVA: 0x001CA828 File Offset: 0x001C8A28
		// (set) Token: 0x060065B1 RID: 26033 RVA: 0x000301BD File Offset: 0x0002E3BD
		public unsafe Player player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x060065B2 RID: 26034 RVA: 0x001CA858 File Offset: 0x001C8A58
		// (set) Token: 0x060065B3 RID: 26035 RVA: 0x000301DC File Offset: 0x0002E3DC
		public unsafe Coroutine punchRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_punchRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_punchRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x060065B4 RID: 26036 RVA: 0x001CA888 File Offset: 0x001C8A88
		// (set) Token: 0x060065B5 RID: 26037 RVA: 0x000301FB File Offset: 0x0002E3FB
		public unsafe bool itemEquippedLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_itemEquippedLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_itemEquippedLastFrame)) = value;
			}
		}

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x060065B6 RID: 26038 RVA: 0x001CA8B0 File Offset: 0x001C8AB0
		// (set) Token: 0x060065B7 RID: 26039 RVA: 0x00030216 File Offset: 0x0002E416
		public unsafe float timeSincePunchingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_timeSincePunchingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_timeSincePunchingEnabled)) = value;
			}
		}

		// Token: 0x0400453E RID: 17726
		private static readonly IntPtr NativeFieldInfoPtr_MAX_PUNCH_LOAD;

		// Token: 0x0400453F RID: 17727
		private static readonly IntPtr NativeFieldInfoPtr_MIN_COOLDOWN;

		// Token: 0x04004540 RID: 17728
		private static readonly IntPtr NativeFieldInfoPtr_MAX_COOLDOWN;

		// Token: 0x04004541 RID: 17729
		private static readonly IntPtr NativeFieldInfoPtr_PUNCH_RANGE;

		// Token: 0x04004542 RID: 17730
		private static readonly IntPtr NativeFieldInfoPtr_PUNCH_DEBOUNCE;

		// Token: 0x04004543 RID: 17731
		private static readonly IntPtr NativeFieldInfoPtr__PunchingEnabled_k__BackingField;

		// Token: 0x04004544 RID: 17732
		private static readonly IntPtr NativeFieldInfoPtr__IsPunching_k__BackingField;

		// Token: 0x04004545 RID: 17733
		private static readonly IntPtr NativeFieldInfoPtr_ViewmodelAvatarOffset;

		// Token: 0x04004546 RID: 17734
		private static readonly IntPtr NativeFieldInfoPtr_MinPunchDamage;

		// Token: 0x04004547 RID: 17735
		private static readonly IntPtr NativeFieldInfoPtr_MaxPunchDamage;

		// Token: 0x04004548 RID: 17736
		private static readonly IntPtr NativeFieldInfoPtr_MinPunchForce;

		// Token: 0x04004549 RID: 17737
		private static readonly IntPtr NativeFieldInfoPtr_MaxPunchForce;

		// Token: 0x0400454A RID: 17738
		private static readonly IntPtr NativeFieldInfoPtr_MinStaminaCost;

		// Token: 0x0400454B RID: 17739
		private static readonly IntPtr NativeFieldInfoPtr_MaxStaminaCost;

		// Token: 0x0400454C RID: 17740
		private static readonly IntPtr NativeFieldInfoPtr_PunchSound;

		// Token: 0x0400454D RID: 17741
		private static readonly IntPtr NativeFieldInfoPtr_PunchAnimator;

		// Token: 0x0400454E RID: 17742
		private static readonly IntPtr NativeFieldInfoPtr_punchLoad;

		// Token: 0x0400454F RID: 17743
		private static readonly IntPtr NativeFieldInfoPtr_remainingCooldown;

		// Token: 0x04004550 RID: 17744
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04004551 RID: 17745
		private static readonly IntPtr NativeFieldInfoPtr_punchRoutine;

		// Token: 0x04004552 RID: 17746
		private static readonly IntPtr NativeFieldInfoPtr_itemEquippedLastFrame;

		// Token: 0x04004553 RID: 17747
		private static readonly IntPtr NativeFieldInfoPtr_timeSincePunchingEnabled;

		// Token: 0x04004554 RID: 17748
		private static readonly IntPtr NativeMethodInfoPtr_get_PunchingEnabled_Public_get_Boolean_0;

		// Token: 0x04004555 RID: 17749
		private static readonly IntPtr NativeMethodInfoPtr_set_PunchingEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04004556 RID: 17750
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0;

		// Token: 0x04004557 RID: 17751
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPunching_Public_get_Boolean_0;

		// Token: 0x04004558 RID: 17752
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPunching_Private_set_Void_Boolean_0;

		// Token: 0x04004559 RID: 17753
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400455A RID: 17754
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400455B RID: 17755
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400455C RID: 17756
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400455D RID: 17757
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCooldown_Private_Void_0;

		// Token: 0x0400455E RID: 17758
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x0400455F RID: 17759
		private static readonly IntPtr NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0;

		// Token: 0x04004560 RID: 17760
		private static readonly IntPtr NativeMethodInfoPtr_StartLoad_Private_Void_0;

		// Token: 0x04004561 RID: 17761
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x04004562 RID: 17762
		private static readonly IntPtr NativeMethodInfoPtr_Punch_Private_Void_Single_0;

		// Token: 0x04004563 RID: 17763
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0;

		// Token: 0x04004564 RID: 17764
		private static readonly IntPtr NativeMethodInfoPtr_SetPunchingEnabled_Private_Void_Boolean_0;

		// Token: 0x04004565 RID: 17765
		private static readonly IntPtr NativeMethodInfoPtr_ShouldBeEnabled_Private_Boolean_0;

		// Token: 0x04004566 RID: 17766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004567 RID: 17767
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__31_0_Private_Void_0;

		// Token: 0x02000A30 RID: 2608
		[ObfuscatedName("ScheduleOne.Combat.PunchController+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CF80 RID: 53120 RVA: 0x0031D74C File Offset: 0x0031B94C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr);
				PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
				PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr_power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, "power");
				PunchController.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, 100676147);
				PunchController.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, 100676148);
			}

			// Token: 0x0600CF81 RID: 53121 RVA: 0x0031D7C8 File Offset: 0x0031B9C8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF82 RID: 53122 RVA: 0x0031D804 File Offset: 0x0031BA04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206007, XrefRangeEnd = 206012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CF83 RID: 53123 RVA: 0x00064F65 File Offset: 0x00063165
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700407C RID: 16508
			// (get) Token: 0x0600CF84 RID: 53124 RVA: 0x0031D844 File Offset: 0x0031BA44
			// (set) Token: 0x0600CF85 RID: 53125 RVA: 0x00064F6E File Offset: 0x0006316E
			public unsafe PunchController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PunchController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700407D RID: 16509
			// (get) Token: 0x0600CF86 RID: 53126 RVA: 0x0031D874 File Offset: 0x0031BA74
			// (set) Token: 0x0600CF87 RID: 53127 RVA: 0x00064F8D File Offset: 0x0006318D
			public unsafe float power
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr_power);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr_power)) = value;
				}
			}

			// Token: 0x04008BF5 RID: 35829
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008BF6 RID: 35830
			private static readonly IntPtr NativeFieldInfoPtr_power;

			// Token: 0x04008BF7 RID: 35831
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BF8 RID: 35832
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C57 RID: 3159
			[ObfuscatedName("ScheduleOne.Combat.PunchController+<>c__DisplayClass39_0+<<Punch>g__PunchRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E37A RID: 58234 RVA: 0x0035648C File Offset: 0x0035468C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, "<<Punch>g__PunchRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676149);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676150);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676151);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676152);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676153);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676154);
				}

				// Token: 0x0600E37B RID: 58235 RVA: 0x0035656C File Offset: 0x0035476C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E37C RID: 58236 RVA: 0x003565B4 File Offset: 0x003547B4
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E37D RID: 58237 RVA: 0x003565E8 File Offset: 0x003547E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205986, XrefRangeEnd = 206002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004696 RID: 18070
				// (get) Token: 0x0600E37E RID: 58238 RVA: 0x00356624 File Offset: 0x00354824
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E37F RID: 58239 RVA: 0x00356664 File Offset: 0x00354864
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206002, XrefRangeEnd = 206007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004697 RID: 18071
				// (get) Token: 0x0600E380 RID: 58240 RVA: 0x00356698 File Offset: 0x00354898
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E381 RID: 58241 RVA: 0x0006EDEA File Offset: 0x0006CFEA
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004693 RID: 18067
				// (get) Token: 0x0600E382 RID: 58242 RVA: 0x003566D8 File Offset: 0x003548D8
				// (set) Token: 0x0600E383 RID: 58243 RVA: 0x0006EDF3 File Offset: 0x0006CFF3
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004694 RID: 18068
				// (get) Token: 0x0600E384 RID: 58244 RVA: 0x00356700 File Offset: 0x00354900
				// (set) Token: 0x0600E385 RID: 58245 RVA: 0x0006EE0E File Offset: 0x0006D00E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004695 RID: 18069
				// (get) Token: 0x0600E386 RID: 58246 RVA: 0x00356730 File Offset: 0x00354930
				// (set) Token: 0x0600E387 RID: 58247 RVA: 0x0006EE2D File Offset: 0x0006D02D
				public unsafe PunchController.__c__DisplayClass39_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PunchController.__c__DisplayClass39_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009839 RID: 38969
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400983A RID: 38970
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400983B RID: 38971
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400983C RID: 38972
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400983D RID: 38973
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400983E RID: 38974
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400983F RID: 38975
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009840 RID: 38976
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009841 RID: 38977
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
