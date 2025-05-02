using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Variables;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001CB RID: 459
	[Serializable]
	public class SystemTrigger : Object
	{
		// Token: 0x0600271E RID: 10014 RVA: 0x000EB1E0 File Offset: 0x000E93E0
		// Note: this type is marked as 'beforefieldinit'.
		static SystemTrigger()
		{
			Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "SystemTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr);
			SystemTrigger.NativeFieldInfoPtr_Conditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "Conditions");
			SystemTrigger.NativeFieldInfoPtr_onEvaluateTrueVariableSetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "onEvaluateTrueVariableSetters");
			SystemTrigger.NativeFieldInfoPtr_onEvaluateTrueQuestSetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "onEvaluateTrueQuestSetters");
			SystemTrigger.NativeFieldInfoPtr_onEvaluateTrue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "onEvaluateTrue");
			SystemTrigger.NativeFieldInfoPtr_onEvaluateFalseVariableSetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "onEvaluateFalseVariableSetters");
			SystemTrigger.NativeFieldInfoPtr_onEvaluateFalseQuestSetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "onEvaluateFalseQuestSetters");
			SystemTrigger.NativeFieldInfoPtr_onEvaluateFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "onEvaluateFalse");
			SystemTrigger.NativeMethodInfoPtr_Trigger_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, 100667662);
			SystemTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, 100667663);
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x000EB2C4 File Offset: 0x000E94C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 117752, RefRangeEnd = 117756, XrefRangeStart = 117746, XrefRangeEnd = 117752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Trigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTrigger.NativeMethodInfoPtr_Trigger_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x000EB300 File Offset: 0x000E9500
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemTrigger() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x00015AB3 File Offset: 0x00013CB3
		public SystemTrigger(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06002722 RID: 10018 RVA: 0x000EB33C File Offset: 0x000E953C
		// (set) Token: 0x06002723 RID: 10019 RVA: 0x00015ABC File Offset: 0x00013CBC
		public unsafe Conditions Conditions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_Conditions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Conditions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_Conditions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06002724 RID: 10020 RVA: 0x000EB36C File Offset: 0x000E956C
		// (set) Token: 0x06002725 RID: 10021 RVA: 0x00015ADB File Offset: 0x00013CDB
		public unsafe Il2CppReferenceArray<VariableSetter> onEvaluateTrueVariableSetters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateTrueVariableSetters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VariableSetter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateTrueVariableSetters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06002726 RID: 10022 RVA: 0x000EB39C File Offset: 0x000E959C
		// (set) Token: 0x06002727 RID: 10023 RVA: 0x00015AFA File Offset: 0x00013CFA
		public unsafe Il2CppReferenceArray<QuestStateSetter> onEvaluateTrueQuestSetters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateTrueQuestSetters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestStateSetter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateTrueQuestSetters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06002728 RID: 10024 RVA: 0x000EB3CC File Offset: 0x000E95CC
		// (set) Token: 0x06002729 RID: 10025 RVA: 0x00015B19 File Offset: 0x00013D19
		public unsafe UnityEvent onEvaluateTrue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateTrue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateTrue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x0600272A RID: 10026 RVA: 0x000EB3FC File Offset: 0x000E95FC
		// (set) Token: 0x0600272B RID: 10027 RVA: 0x00015B38 File Offset: 0x00013D38
		public unsafe Il2CppReferenceArray<VariableSetter> onEvaluateFalseVariableSetters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateFalseVariableSetters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VariableSetter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateFalseVariableSetters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x0600272C RID: 10028 RVA: 0x000EB42C File Offset: 0x000E962C
		// (set) Token: 0x0600272D RID: 10029 RVA: 0x00015B57 File Offset: 0x00013D57
		public unsafe Il2CppReferenceArray<QuestStateSetter> onEvaluateFalseQuestSetters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateFalseQuestSetters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestStateSetter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateFalseQuestSetters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x0600272E RID: 10030 RVA: 0x000EB45C File Offset: 0x000E965C
		// (set) Token: 0x0600272F RID: 10031 RVA: 0x00015B76 File Offset: 0x00013D76
		public unsafe UnityEvent onEvaluateFalse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateFalse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateFalse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019FC RID: 6652
		private static readonly IntPtr NativeFieldInfoPtr_Conditions;

		// Token: 0x040019FD RID: 6653
		private static readonly IntPtr NativeFieldInfoPtr_onEvaluateTrueVariableSetters;

		// Token: 0x040019FE RID: 6654
		private static readonly IntPtr NativeFieldInfoPtr_onEvaluateTrueQuestSetters;

		// Token: 0x040019FF RID: 6655
		private static readonly IntPtr NativeFieldInfoPtr_onEvaluateTrue;

		// Token: 0x04001A00 RID: 6656
		private static readonly IntPtr NativeFieldInfoPtr_onEvaluateFalseVariableSetters;

		// Token: 0x04001A01 RID: 6657
		private static readonly IntPtr NativeFieldInfoPtr_onEvaluateFalseQuestSetters;

		// Token: 0x04001A02 RID: 6658
		private static readonly IntPtr NativeFieldInfoPtr_onEvaluateFalse;

		// Token: 0x04001A03 RID: 6659
		private static readonly IntPtr NativeMethodInfoPtr_Trigger_Public_Boolean_0;

		// Token: 0x04001A04 RID: 6660
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
