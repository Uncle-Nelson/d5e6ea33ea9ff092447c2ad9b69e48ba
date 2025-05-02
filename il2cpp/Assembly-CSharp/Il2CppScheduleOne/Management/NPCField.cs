using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000394 RID: 916
	public class NPCField : ConfigField
	{
		// Token: 0x060047E6 RID: 18406 RVA: 0x0016025C File Offset: 0x0015E45C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCField()
		{
			Il2CppClassPointerStore<NPCField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "NPCField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCField>.NativeClassPtr);
			NPCField.NativeFieldInfoPtr__SelectedNPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCField>.NativeClassPtr, "<SelectedNPC>k__BackingField");
			NPCField.NativeFieldInfoPtr_TypeRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCField>.NativeClassPtr, "TypeRequirement");
			NPCField.NativeFieldInfoPtr_onNPCChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCField>.NativeClassPtr, "onNPCChanged");
			NPCField.NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672182);
			NPCField.NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672183);
			NPCField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672184);
			NPCField.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672185);
			NPCField.NativeMethodInfoPtr_DoesNPCMatchRequirement_Public_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672186);
			NPCField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672187);
			NPCField.NativeMethodInfoPtr_GetData_Public_NPCFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672188);
			NPCField.NativeMethodInfoPtr_Load_Public_Void_NPCFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672189);
		}

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x060047E7 RID: 18407 RVA: 0x00160368 File Offset: 0x0015E568
		// (set) Token: 0x060047E8 RID: 18408 RVA: 0x001603A8 File Offset: 0x0015E5A8
		public unsafe NPC SelectedNPC
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x001603EC File Offset: 0x0015E5EC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 161559, RefRangeEnd = 161567, XrefRangeStart = 161551, XrefRangeEnd = 161559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047EA RID: 18410 RVA: 0x00160438 File Offset: 0x0015E638
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 161576, RefRangeEnd = 161590, XrefRangeStart = 161567, XrefRangeEnd = 161576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNPC(NPC npc, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047EB RID: 18411 RVA: 0x00160488 File Offset: 0x0015E688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161590, XrefRangeEnd = 161594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesNPCMatchRequirement(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_DoesNPCMatchRequirement_Public_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047EC RID: 18412 RVA: 0x001604D8 File Offset: 0x0015E6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161594, XrefRangeEnd = 161598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047ED RID: 18413 RVA: 0x00160520 File Offset: 0x0015E720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161598, XrefRangeEnd = 161610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_GetData_Public_NPCFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCFieldData>(intPtr3) : null;
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x00160560 File Offset: 0x0015E760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161610, XrefRangeEnd = 161623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(NPCFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_Load_Public_Void_NPCFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x00022CBB File Offset: 0x00020EBB
		public NPCField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x060047F0 RID: 18416 RVA: 0x001605A4 File Offset: 0x0015E7A4
		// (set) Token: 0x060047F1 RID: 18417 RVA: 0x00022CC4 File Offset: 0x00020EC4
		public unsafe NPC _SelectedNPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr__SelectedNPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr__SelectedNPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x060047F2 RID: 18418 RVA: 0x001605D4 File Offset: 0x0015E7D4
		// (set) Token: 0x060047F3 RID: 18419 RVA: 0x00022CE3 File Offset: 0x00020EE3
		public unsafe Type TypeRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr_TypeRequirement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr_TypeRequirement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x060047F4 RID: 18420 RVA: 0x00160604 File Offset: 0x0015E804
		// (set) Token: 0x060047F5 RID: 18421 RVA: 0x00022D02 File Offset: 0x00020F02
		public unsafe UnityEvent<NPC> onNPCChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr_onNPCChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr_onNPCChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003073 RID: 12403
		private static readonly IntPtr NativeFieldInfoPtr__SelectedNPC_k__BackingField;

		// Token: 0x04003074 RID: 12404
		private static readonly IntPtr NativeFieldInfoPtr_TypeRequirement;

		// Token: 0x04003075 RID: 12405
		private static readonly IntPtr NativeFieldInfoPtr_onNPCChanged;

		// Token: 0x04003076 RID: 12406
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0;

		// Token: 0x04003077 RID: 12407
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0;

		// Token: 0x04003078 RID: 12408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x04003079 RID: 12409
		private static readonly IntPtr NativeMethodInfoPtr_SetNPC_Public_Void_NPC_Boolean_0;

		// Token: 0x0400307A RID: 12410
		private static readonly IntPtr NativeMethodInfoPtr_DoesNPCMatchRequirement_Public_Boolean_NPC_0;

		// Token: 0x0400307B RID: 12411
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x0400307C RID: 12412
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_NPCFieldData_0;

		// Token: 0x0400307D RID: 12413
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_NPCFieldData_0;
	}
}
