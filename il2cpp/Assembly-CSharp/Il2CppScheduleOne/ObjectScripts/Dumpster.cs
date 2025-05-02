using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000755 RID: 1877
	public class Dumpster : GridItem
	{
		// Token: 0x0600B26E RID: 45678 RVA: 0x002C846C File Offset: 0x002C666C
		// Note: this type is marked as 'beforefieldinit'.
		static Dumpster()
		{
			Il2CppClassPointerStore<Dumpster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Dumpster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dumpster>.NativeClassPtr);
			Dumpster.NativeFieldInfoPtr_capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "capacity");
			Dumpster.NativeFieldInfoPtr_lid_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "lid_IntObj");
			Dumpster.NativeFieldInfoPtr_inner_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "inner_IntObj");
			Dumpster.NativeFieldInfoPtr_lid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "lid");
			Dumpster.NativeFieldInfoPtr_trash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "trash");
			Dumpster.NativeFieldInfoPtr_standPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "standPoint");
			Dumpster.NativeFieldInfoPtr_trash_MinY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "trash_MinY");
			Dumpster.NativeFieldInfoPtr_trash_MaxY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "trash_MaxY");
			Dumpster.NativeFieldInfoPtr__lidOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "<lidOpen>k__BackingField");
			Dumpster.NativeFieldInfoPtr__currentTrashLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "<currentTrashLevel>k__BackingField");
			Dumpster.NativeFieldInfoPtr_lid_CurrentAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "lid_CurrentAngle");
			Dumpster.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.DumpsterAssembly-CSharp.dll_Excuted");
			Dumpster.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.DumpsterAssembly-CSharp.dll_Excuted");
			Dumpster.NativeMethodInfoPtr_get_lidOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685290);
			Dumpster.NativeMethodInfoPtr_set_lidOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685291);
			Dumpster.NativeMethodInfoPtr_get_currentTrashLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685292);
			Dumpster.NativeMethodInfoPtr_set_currentTrashLevel_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685293);
			Dumpster.NativeMethodInfoPtr_get_isFull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685294);
			Dumpster.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685295);
			Dumpster.NativeMethodInfoPtr_Lid_Hovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685296);
			Dumpster.NativeMethodInfoPtr_Lid_Interacted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685297);
			Dumpster.NativeMethodInfoPtr_DoesPlayerHaveBinEquipped_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685298);
			Dumpster.NativeMethodInfoPtr_ChangeTrashLevel_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685299);
			Dumpster.NativeMethodInfoPtr_SetTrashLevel_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685300);
			Dumpster.NativeMethodInfoPtr_UpdateTrashVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685301);
			Dumpster.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685302);
			Dumpster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685303);
			Dumpster.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685305);
			Dumpster.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685306);
			Dumpster.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685307);
			Dumpster.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685308);
		}

		// Token: 0x17003768 RID: 14184
		// (get) Token: 0x0600B26F RID: 45679 RVA: 0x002C8708 File Offset: 0x002C6908
		// (set) Token: 0x0600B270 RID: 45680 RVA: 0x002C8744 File Offset: 0x002C6944
		public unsafe bool lidOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_get_lidOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_set_lidOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003769 RID: 14185
		// (get) Token: 0x0600B271 RID: 45681 RVA: 0x002C8784 File Offset: 0x002C6984
		// (set) Token: 0x0600B272 RID: 45682 RVA: 0x002C87C0 File Offset: 0x002C69C0
		public unsafe float currentTrashLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_get_currentTrashLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_set_currentTrashLevel_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700376A RID: 14186
		// (get) Token: 0x0600B273 RID: 45683 RVA: 0x002C8800 File Offset: 0x002C6A00
		public unsafe bool isFull
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307735, XrefRangeEnd = 307739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_get_isFull_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600B274 RID: 45684 RVA: 0x002C883C File Offset: 0x002C6A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307739, XrefRangeEnd = 307745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B275 RID: 45685 RVA: 0x002C8878 File Offset: 0x002C6A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307745, XrefRangeEnd = 307752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Lid_Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_Lid_Hovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B276 RID: 45686 RVA: 0x002C88B4 File Offset: 0x002C6AB4
		[CallerCount(0)]
		public unsafe virtual void Lid_Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_Lid_Interacted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B277 RID: 45687 RVA: 0x002C88F0 File Offset: 0x002C6AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307752, XrefRangeEnd = 307763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesPlayerHaveBinEquipped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_DoesPlayerHaveBinEquipped_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B278 RID: 45688 RVA: 0x002C892C File Offset: 0x002C6B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307763, XrefRangeEnd = 307777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeTrashLevel(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_ChangeTrashLevel_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B279 RID: 45689 RVA: 0x002C896C File Offset: 0x002C6B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307777, XrefRangeEnd = 307791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrashLevel(float trashLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref trashLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_SetTrashLevel_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B27A RID: 45690 RVA: 0x002C89AC File Offset: 0x002C6BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307791, XrefRangeEnd = 307800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTrashVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_UpdateTrashVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B27B RID: 45691 RVA: 0x002C89E0 File Offset: 0x002C6BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307800, XrefRangeEnd = 307805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600B27C RID: 45692 RVA: 0x002C8A44 File Offset: 0x002C6C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dumpster() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dumpster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B27D RID: 45693 RVA: 0x002C8A80 File Offset: 0x002C6C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307805, XrefRangeEnd = 307806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B27E RID: 45694 RVA: 0x002C8ABC File Offset: 0x002C6CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307806, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B27F RID: 45695 RVA: 0x002C8AF8 File Offset: 0x002C6CF8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B280 RID: 45696 RVA: 0x002C8B34 File Offset: 0x002C6D34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291098, RefRangeEnd = 291099, XrefRangeStart = 291098, XrefRangeEnd = 291099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B281 RID: 45697 RVA: 0x00057835 File Offset: 0x00055A35
		public Dumpster(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700375B RID: 14171
		// (get) Token: 0x0600B282 RID: 45698 RVA: 0x002C8B70 File Offset: 0x002C6D70
		// (set) Token: 0x0600B283 RID: 45699 RVA: 0x0005783E File Offset: 0x00055A3E
		public unsafe static float capacity
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Dumpster.NativeFieldInfoPtr_capacity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dumpster.NativeFieldInfoPtr_capacity, (void*)(&value));
			}
		}

		// Token: 0x1700375C RID: 14172
		// (get) Token: 0x0600B284 RID: 45700 RVA: 0x002C8B8C File Offset: 0x002C6D8C
		// (set) Token: 0x0600B285 RID: 45701 RVA: 0x0005784C File Offset: 0x00055A4C
		public unsafe InteractableObject lid_IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_lid_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_lid_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700375D RID: 14173
		// (get) Token: 0x0600B286 RID: 45702 RVA: 0x002C8BBC File Offset: 0x002C6DBC
		// (set) Token: 0x0600B287 RID: 45703 RVA: 0x0005786B File Offset: 0x00055A6B
		public unsafe InteractableObject inner_IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_inner_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_inner_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700375E RID: 14174
		// (get) Token: 0x0600B288 RID: 45704 RVA: 0x002C8BEC File Offset: 0x002C6DEC
		// (set) Token: 0x0600B289 RID: 45705 RVA: 0x0005788A File Offset: 0x00055A8A
		public unsafe Transform lid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_lid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_lid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700375F RID: 14175
		// (get) Token: 0x0600B28A RID: 45706 RVA: 0x002C8C1C File Offset: 0x002C6E1C
		// (set) Token: 0x0600B28B RID: 45707 RVA: 0x000578A9 File Offset: 0x00055AA9
		public unsafe Transform trash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_trash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_trash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003760 RID: 14176
		// (get) Token: 0x0600B28C RID: 45708 RVA: 0x002C8C4C File Offset: 0x002C6E4C
		// (set) Token: 0x0600B28D RID: 45709 RVA: 0x000578C8 File Offset: 0x00055AC8
		public unsafe Transform standPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_standPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_standPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003761 RID: 14177
		// (get) Token: 0x0600B28E RID: 45710 RVA: 0x002C8C7C File Offset: 0x002C6E7C
		// (set) Token: 0x0600B28F RID: 45711 RVA: 0x000578E7 File Offset: 0x00055AE7
		public unsafe float trash_MinY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_trash_MinY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_trash_MinY)) = value;
			}
		}

		// Token: 0x17003762 RID: 14178
		// (get) Token: 0x0600B290 RID: 45712 RVA: 0x002C8CA4 File Offset: 0x002C6EA4
		// (set) Token: 0x0600B291 RID: 45713 RVA: 0x00057902 File Offset: 0x00055B02
		public unsafe float trash_MaxY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_trash_MaxY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_trash_MaxY)) = value;
			}
		}

		// Token: 0x17003763 RID: 14179
		// (get) Token: 0x0600B292 RID: 45714 RVA: 0x002C8CCC File Offset: 0x002C6ECC
		// (set) Token: 0x0600B293 RID: 45715 RVA: 0x0005791D File Offset: 0x00055B1D
		public unsafe bool _lidOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr__lidOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr__lidOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003764 RID: 14180
		// (get) Token: 0x0600B294 RID: 45716 RVA: 0x002C8CF4 File Offset: 0x002C6EF4
		// (set) Token: 0x0600B295 RID: 45717 RVA: 0x00057938 File Offset: 0x00055B38
		public unsafe float _currentTrashLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr__currentTrashLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr__currentTrashLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x17003765 RID: 14181
		// (get) Token: 0x0600B296 RID: 45718 RVA: 0x002C8D1C File Offset: 0x002C6F1C
		// (set) Token: 0x0600B297 RID: 45719 RVA: 0x00057953 File Offset: 0x00055B53
		public unsafe float lid_CurrentAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_lid_CurrentAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_lid_CurrentAngle)) = value;
			}
		}

		// Token: 0x17003766 RID: 14182
		// (get) Token: 0x0600B298 RID: 45720 RVA: 0x002C8D44 File Offset: 0x002C6F44
		// (set) Token: 0x0600B299 RID: 45721 RVA: 0x0005796E File Offset: 0x00055B6E
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003767 RID: 14183
		// (get) Token: 0x0600B29A RID: 45722 RVA: 0x002C8D6C File Offset: 0x002C6F6C
		// (set) Token: 0x0600B29B RID: 45723 RVA: 0x00057989 File Offset: 0x00055B89
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007857 RID: 30807
		private static readonly IntPtr NativeFieldInfoPtr_capacity;

		// Token: 0x04007858 RID: 30808
		private static readonly IntPtr NativeFieldInfoPtr_lid_IntObj;

		// Token: 0x04007859 RID: 30809
		private static readonly IntPtr NativeFieldInfoPtr_inner_IntObj;

		// Token: 0x0400785A RID: 30810
		private static readonly IntPtr NativeFieldInfoPtr_lid;

		// Token: 0x0400785B RID: 30811
		private static readonly IntPtr NativeFieldInfoPtr_trash;

		// Token: 0x0400785C RID: 30812
		private static readonly IntPtr NativeFieldInfoPtr_standPoint;

		// Token: 0x0400785D RID: 30813
		private static readonly IntPtr NativeFieldInfoPtr_trash_MinY;

		// Token: 0x0400785E RID: 30814
		private static readonly IntPtr NativeFieldInfoPtr_trash_MaxY;

		// Token: 0x0400785F RID: 30815
		private static readonly IntPtr NativeFieldInfoPtr__lidOpen_k__BackingField;

		// Token: 0x04007860 RID: 30816
		private static readonly IntPtr NativeFieldInfoPtr__currentTrashLevel_k__BackingField;

		// Token: 0x04007861 RID: 30817
		private static readonly IntPtr NativeFieldInfoPtr_lid_CurrentAngle;

		// Token: 0x04007862 RID: 30818
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007863 RID: 30819
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007864 RID: 30820
		private static readonly IntPtr NativeMethodInfoPtr_get_lidOpen_Public_get_Boolean_0;

		// Token: 0x04007865 RID: 30821
		private static readonly IntPtr NativeMethodInfoPtr_set_lidOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04007866 RID: 30822
		private static readonly IntPtr NativeMethodInfoPtr_get_currentTrashLevel_Public_get_Single_0;

		// Token: 0x04007867 RID: 30823
		private static readonly IntPtr NativeMethodInfoPtr_set_currentTrashLevel_Protected_set_Void_Single_0;

		// Token: 0x04007868 RID: 30824
		private static readonly IntPtr NativeMethodInfoPtr_get_isFull_Public_get_Boolean_0;

		// Token: 0x04007869 RID: 30825
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400786A RID: 30826
		private static readonly IntPtr NativeMethodInfoPtr_Lid_Hovered_Public_Virtual_New_Void_0;

		// Token: 0x0400786B RID: 30827
		private static readonly IntPtr NativeMethodInfoPtr_Lid_Interacted_Public_Virtual_New_Void_0;

		// Token: 0x0400786C RID: 30828
		private static readonly IntPtr NativeMethodInfoPtr_DoesPlayerHaveBinEquipped_Protected_Boolean_0;

		// Token: 0x0400786D RID: 30829
		private static readonly IntPtr NativeMethodInfoPtr_ChangeTrashLevel_Public_Void_Single_0;

		// Token: 0x0400786E RID: 30830
		private static readonly IntPtr NativeMethodInfoPtr_SetTrashLevel_Public_Void_Single_0;

		// Token: 0x0400786F RID: 30831
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTrashVisuals_Private_Void_0;

		// Token: 0x04007870 RID: 30832
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x04007871 RID: 30833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007872 RID: 30834
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04007873 RID: 30835
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04007874 RID: 30836
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007875 RID: 30837
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
