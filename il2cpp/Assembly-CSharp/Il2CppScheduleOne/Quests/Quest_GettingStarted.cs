using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.NPCs.CharacterClasses;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001BC RID: 444
	public class Quest_GettingStarted : Quest
	{
		// Token: 0x06002655 RID: 9813 RVA: 0x000E8E88 File Offset: 0x000E7088
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_GettingStarted()
		{
			Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_GettingStarted");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr);
			Quest_GettingStarted.NativeFieldInfoPtr_CashAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, "CashAmount");
			Quest_GettingStarted.NativeFieldInfoPtr_CashDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, "CashDrop");
			Quest_GettingStarted.NativeFieldInfoPtr_Nelson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, "Nelson");
			Quest_GettingStarted.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, 100667586);
			Quest_GettingStarted.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, 100667587);
			Quest_GettingStarted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, 100667588);
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x000E8F30 File Offset: 0x000E7130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116949, XrefRangeEnd = 116950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_GettingStarted.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x000E8F6C File Offset: 0x000E716C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116950, XrefRangeEnd = 116951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetQuestState(EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_GettingStarted.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x000E8FC4 File Offset: 0x000E71C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116951, XrefRangeEnd = 116955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_GettingStarted() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GettingStarted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x0001543E File Offset: 0x0001363E
		public Quest_GettingStarted(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x0600265A RID: 9818 RVA: 0x000E9000 File Offset: 0x000E7200
		// (set) Token: 0x0600265B RID: 9819 RVA: 0x00015447 File Offset: 0x00013647
		public unsafe float CashAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_CashAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_CashAmount)) = value;
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x0600265C RID: 9820 RVA: 0x000E9028 File Offset: 0x000E7228
		// (set) Token: 0x0600265D RID: 9821 RVA: 0x00015462 File Offset: 0x00013662
		public unsafe DeadDrop CashDrop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_CashDrop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeadDrop>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_CashDrop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x0600265E RID: 9822 RVA: 0x000E9058 File Offset: 0x000E7258
		// (set) Token: 0x0600265F RID: 9823 RVA: 0x00015481 File Offset: 0x00013681
		public unsafe UncleNelson Nelson
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_Nelson);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UncleNelson>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_Nelson), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001988 RID: 6536
		private static readonly IntPtr NativeFieldInfoPtr_CashAmount;

		// Token: 0x04001989 RID: 6537
		private static readonly IntPtr NativeFieldInfoPtr_CashDrop;

		// Token: 0x0400198A RID: 6538
		private static readonly IntPtr NativeFieldInfoPtr_Nelson;

		// Token: 0x0400198B RID: 6539
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x0400198C RID: 6540
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0;

		// Token: 0x0400198D RID: 6541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
