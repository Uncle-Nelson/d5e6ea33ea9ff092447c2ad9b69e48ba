using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Interaction;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000730 RID: 1840
	public class Bed : NetworkBehaviour
	{
		// Token: 0x0600A72C RID: 42796 RVA: 0x0029C9F0 File Offset: 0x0029ABF0
		// Note: this type is marked as 'beforefieldinit'.
		static Bed()
		{
			Il2CppClassPointerStore<Bed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Bed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bed>.NativeClassPtr);
			Bed.NativeFieldInfoPtr_MIN_SLEEP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "MIN_SLEEP_TIME");
			Bed.NativeFieldInfoPtr_SLEEP_TIME_SCALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "SLEEP_TIME_SCALE");
			Bed.NativeFieldInfoPtr__AssignedEmployee_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "<AssignedEmployee>k__BackingField");
			Bed.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "intObj");
			Bed.NativeFieldInfoPtr_Clipboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "Clipboard");
			Bed.NativeFieldInfoPtr_MugshotSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "MugshotSprite");
			Bed.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "NameLabel");
			Bed.NativeFieldInfoPtr_BlanketMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "BlanketMesh");
			Bed.NativeFieldInfoPtr_DefaultBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "DefaultBlanket");
			Bed.NativeFieldInfoPtr_BotanistBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "BotanistBlanket");
			Bed.NativeFieldInfoPtr_ChemistBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "ChemistBlanket");
			Bed.NativeFieldInfoPtr_PackagerBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "PackagerBlanket");
			Bed.NativeFieldInfoPtr_CleanerBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "CleanerBlanket");
			Bed.NativeFieldInfoPtr_onAssignedEmployeeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "onAssignedEmployeeChanged");
			Bed.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.BedAssembly-CSharp.dll_Excuted");
			Bed.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.BedAssembly-CSharp.dll_Excuted");
			Bed.NativeMethodInfoPtr_get_AssignedEmployee_Public_get_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683755);
			Bed.NativeMethodInfoPtr_set_AssignedEmployee_Protected_set_Void_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683756);
			Bed.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683757);
			Bed.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683758);
			Bed.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683759);
			Bed.NativeMethodInfoPtr_CanSleep_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683760);
			Bed.NativeMethodInfoPtr_SetAssignedEmployee_Public_Void_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683761);
			Bed.NativeMethodInfoPtr_UpdateMaterial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683762);
			Bed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683763);
			Bed.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683764);
			Bed.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683765);
			Bed.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683766);
			Bed.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683767);
		}

		// Token: 0x170033A6 RID: 13222
		// (get) Token: 0x0600A72D RID: 42797 RVA: 0x0029CC64 File Offset: 0x0029AE64
		// (set) Token: 0x0600A72E RID: 42798 RVA: 0x0029CCA4 File Offset: 0x0029AEA4
		public unsafe Employee AssignedEmployee
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_get_AssignedEmployee_Public_get_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_set_AssignedEmployee_Protected_set_Void_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A72F RID: 42799 RVA: 0x0029CCE8 File Offset: 0x0029AEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291528, XrefRangeEnd = 291536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bed.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A730 RID: 42800 RVA: 0x0029CD24 File Offset: 0x0029AF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291536, XrefRangeEnd = 291563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A731 RID: 42801 RVA: 0x0029CD58 File Offset: 0x0029AF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291563, XrefRangeEnd = 291574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A732 RID: 42802 RVA: 0x0029CD8C File Offset: 0x0029AF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291574, XrefRangeEnd = 291580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanSleep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_CanSleep_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A733 RID: 42803 RVA: 0x0029CDC8 File Offset: 0x0029AFC8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 291595, RefRangeEnd = 291603, XrefRangeStart = 291580, XrefRangeEnd = 291595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAssignedEmployee(Employee employee)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(employee);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_SetAssignedEmployee_Public_Void_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A734 RID: 42804 RVA: 0x0029CE0C File Offset: 0x0029B00C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 291614, RefRangeEnd = 291617, XrefRangeStart = 291603, XrefRangeEnd = 291614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_UpdateMaterial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A735 RID: 42805 RVA: 0x0029CE40 File Offset: 0x0029B040
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 134906, RefRangeEnd = 134928, XrefRangeStart = 134906, XrefRangeEnd = 134928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bed() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A736 RID: 42806 RVA: 0x0029CE7C File Offset: 0x0029B07C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bed.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A737 RID: 42807 RVA: 0x0029CEB8 File Offset: 0x0029B0B8
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bed.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A738 RID: 42808 RVA: 0x0029CEF4 File Offset: 0x0029B0F4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bed.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A739 RID: 42809 RVA: 0x0029CF30 File Offset: 0x0029B130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291617, XrefRangeEnd = 291625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A73A RID: 42810 RVA: 0x000525BA File Offset: 0x000507BA
		public Bed(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003396 RID: 13206
		// (get) Token: 0x0600A73B RID: 42811 RVA: 0x0029CF64 File Offset: 0x0029B164
		// (set) Token: 0x0600A73C RID: 42812 RVA: 0x000525C3 File Offset: 0x000507C3
		public unsafe static int MIN_SLEEP_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Bed.NativeFieldInfoPtr_MIN_SLEEP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bed.NativeFieldInfoPtr_MIN_SLEEP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17003397 RID: 13207
		// (get) Token: 0x0600A73D RID: 42813 RVA: 0x0029CF80 File Offset: 0x0029B180
		// (set) Token: 0x0600A73E RID: 42814 RVA: 0x000525D1 File Offset: 0x000507D1
		public unsafe static float SLEEP_TIME_SCALE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Bed.NativeFieldInfoPtr_SLEEP_TIME_SCALE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bed.NativeFieldInfoPtr_SLEEP_TIME_SCALE, (void*)(&value));
			}
		}

		// Token: 0x17003398 RID: 13208
		// (get) Token: 0x0600A73F RID: 42815 RVA: 0x0029CF9C File Offset: 0x0029B19C
		// (set) Token: 0x0600A740 RID: 42816 RVA: 0x000525DF File Offset: 0x000507DF
		public unsafe Employee _AssignedEmployee_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr__AssignedEmployee_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr__AssignedEmployee_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003399 RID: 13209
		// (get) Token: 0x0600A741 RID: 42817 RVA: 0x0029CFCC File Offset: 0x0029B1CC
		// (set) Token: 0x0600A742 RID: 42818 RVA: 0x000525FE File Offset: 0x000507FE
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700339A RID: 13210
		// (get) Token: 0x0600A743 RID: 42819 RVA: 0x0029CFFC File Offset: 0x0029B1FC
		// (set) Token: 0x0600A744 RID: 42820 RVA: 0x0005261D File Offset: 0x0005081D
		public unsafe GameObject Clipboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_Clipboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_Clipboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700339B RID: 13211
		// (get) Token: 0x0600A745 RID: 42821 RVA: 0x0029D02C File Offset: 0x0029B22C
		// (set) Token: 0x0600A746 RID: 42822 RVA: 0x0005263C File Offset: 0x0005083C
		public unsafe SpriteRenderer MugshotSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_MugshotSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_MugshotSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700339C RID: 13212
		// (get) Token: 0x0600A747 RID: 42823 RVA: 0x0029D05C File Offset: 0x0029B25C
		// (set) Token: 0x0600A748 RID: 42824 RVA: 0x0005265B File Offset: 0x0005085B
		public unsafe TextMeshPro NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700339D RID: 13213
		// (get) Token: 0x0600A749 RID: 42825 RVA: 0x0029D08C File Offset: 0x0029B28C
		// (set) Token: 0x0600A74A RID: 42826 RVA: 0x0005267A File Offset: 0x0005087A
		public unsafe MeshRenderer BlanketMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_BlanketMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_BlanketMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700339E RID: 13214
		// (get) Token: 0x0600A74B RID: 42827 RVA: 0x0029D0BC File Offset: 0x0029B2BC
		// (set) Token: 0x0600A74C RID: 42828 RVA: 0x00052699 File Offset: 0x00050899
		public unsafe Material DefaultBlanket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_DefaultBlanket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_DefaultBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700339F RID: 13215
		// (get) Token: 0x0600A74D RID: 42829 RVA: 0x0029D0EC File Offset: 0x0029B2EC
		// (set) Token: 0x0600A74E RID: 42830 RVA: 0x000526B8 File Offset: 0x000508B8
		public unsafe Material BotanistBlanket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_BotanistBlanket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_BotanistBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033A0 RID: 13216
		// (get) Token: 0x0600A74F RID: 42831 RVA: 0x0029D11C File Offset: 0x0029B31C
		// (set) Token: 0x0600A750 RID: 42832 RVA: 0x000526D7 File Offset: 0x000508D7
		public unsafe Material ChemistBlanket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_ChemistBlanket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_ChemistBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033A1 RID: 13217
		// (get) Token: 0x0600A751 RID: 42833 RVA: 0x0029D14C File Offset: 0x0029B34C
		// (set) Token: 0x0600A752 RID: 42834 RVA: 0x000526F6 File Offset: 0x000508F6
		public unsafe Material PackagerBlanket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_PackagerBlanket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_PackagerBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033A2 RID: 13218
		// (get) Token: 0x0600A753 RID: 42835 RVA: 0x0029D17C File Offset: 0x0029B37C
		// (set) Token: 0x0600A754 RID: 42836 RVA: 0x00052715 File Offset: 0x00050915
		public unsafe Material CleanerBlanket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_CleanerBlanket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_CleanerBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033A3 RID: 13219
		// (get) Token: 0x0600A755 RID: 42837 RVA: 0x0029D1AC File Offset: 0x0029B3AC
		// (set) Token: 0x0600A756 RID: 42838 RVA: 0x00052734 File Offset: 0x00050934
		public unsafe UnityEvent onAssignedEmployeeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_onAssignedEmployeeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_onAssignedEmployeeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033A4 RID: 13220
		// (get) Token: 0x0600A757 RID: 42839 RVA: 0x0029D1DC File Offset: 0x0029B3DC
		// (set) Token: 0x0600A758 RID: 42840 RVA: 0x00052753 File Offset: 0x00050953
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170033A5 RID: 13221
		// (get) Token: 0x0600A759 RID: 42841 RVA: 0x0029D204 File Offset: 0x0029B404
		// (set) Token: 0x0600A75A RID: 42842 RVA: 0x0005276E File Offset: 0x0005096E
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007023 RID: 28707
		private static readonly IntPtr NativeFieldInfoPtr_MIN_SLEEP_TIME;

		// Token: 0x04007024 RID: 28708
		private static readonly IntPtr NativeFieldInfoPtr_SLEEP_TIME_SCALE;

		// Token: 0x04007025 RID: 28709
		private static readonly IntPtr NativeFieldInfoPtr__AssignedEmployee_k__BackingField;

		// Token: 0x04007026 RID: 28710
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x04007027 RID: 28711
		private static readonly IntPtr NativeFieldInfoPtr_Clipboard;

		// Token: 0x04007028 RID: 28712
		private static readonly IntPtr NativeFieldInfoPtr_MugshotSprite;

		// Token: 0x04007029 RID: 28713
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x0400702A RID: 28714
		private static readonly IntPtr NativeFieldInfoPtr_BlanketMesh;

		// Token: 0x0400702B RID: 28715
		private static readonly IntPtr NativeFieldInfoPtr_DefaultBlanket;

		// Token: 0x0400702C RID: 28716
		private static readonly IntPtr NativeFieldInfoPtr_BotanistBlanket;

		// Token: 0x0400702D RID: 28717
		private static readonly IntPtr NativeFieldInfoPtr_ChemistBlanket;

		// Token: 0x0400702E RID: 28718
		private static readonly IntPtr NativeFieldInfoPtr_PackagerBlanket;

		// Token: 0x0400702F RID: 28719
		private static readonly IntPtr NativeFieldInfoPtr_CleanerBlanket;

		// Token: 0x04007030 RID: 28720
		private static readonly IntPtr NativeFieldInfoPtr_onAssignedEmployeeChanged;

		// Token: 0x04007031 RID: 28721
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007032 RID: 28722
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007033 RID: 28723
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedEmployee_Public_get_Employee_0;

		// Token: 0x04007034 RID: 28724
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedEmployee_Protected_set_Void_Employee_0;

		// Token: 0x04007035 RID: 28725
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04007036 RID: 28726
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04007037 RID: 28727
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04007038 RID: 28728
		private static readonly IntPtr NativeMethodInfoPtr_CanSleep_Private_Boolean_0;

		// Token: 0x04007039 RID: 28729
		private static readonly IntPtr NativeMethodInfoPtr_SetAssignedEmployee_Public_Void_Employee_0;

		// Token: 0x0400703A RID: 28730
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterial_Private_Void_0;

		// Token: 0x0400703B RID: 28731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400703C RID: 28732
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400703D RID: 28733
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400703E RID: 28734
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400703F RID: 28735
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;
	}
}
