using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001CA RID: 458
	public class StateMachine : MonoBehaviour
	{
		// Token: 0x06002713 RID: 10003 RVA: 0x000EAFE0 File Offset: 0x000E91E0
		// Note: this type is marked as 'beforefieldinit'.
		static StateMachine()
		{
			Il2CppClassPointerStore<StateMachine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "StateMachine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachine>.NativeClassPtr);
			StateMachine.NativeFieldInfoPtr_OnStateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, "OnStateChange");
			StateMachine.NativeFieldInfoPtr_stateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, "stateChanged");
			StateMachine.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, 100667657);
			StateMachine.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, 100667658);
			StateMachine.NativeMethodInfoPtr_Clean_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, 100667659);
			StateMachine.NativeMethodInfoPtr_ChangeState_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, 100667660);
			StateMachine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, 100667661);
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x000EB09C File Offset: 0x000E929C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117716, XrefRangeEnd = 117728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachine.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x000EB0D0 File Offset: 0x000E92D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117728, XrefRangeEnd = 117731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachine.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x000EB104 File Offset: 0x000E9304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117731, XrefRangeEnd = 117741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachine.NativeMethodInfoPtr_Clean_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x000EB138 File Offset: 0x000E9338
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 117743, RefRangeEnd = 117746, XrefRangeStart = 117741, XrefRangeEnd = 117743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ChangeState()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachine.NativeMethodInfoPtr_ChangeState_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x000EB160 File Offset: 0x000E9360
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateMachine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x00015A8A File Offset: 0x00013C8A
		public StateMachine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x0600271A RID: 10010 RVA: 0x000EB19C File Offset: 0x000E939C
		// (set) Token: 0x0600271B RID: 10011 RVA: 0x00015A93 File Offset: 0x00013C93
		public unsafe static Action OnStateChange
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StateMachine.NativeFieldInfoPtr_OnStateChange, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StateMachine.NativeFieldInfoPtr_OnStateChange, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x0600271C RID: 10012 RVA: 0x000EB1C4 File Offset: 0x000E93C4
		// (set) Token: 0x0600271D RID: 10013 RVA: 0x00015AA5 File Offset: 0x00013CA5
		public unsafe static bool stateChanged
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(StateMachine.NativeFieldInfoPtr_stateChanged, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StateMachine.NativeFieldInfoPtr_stateChanged, (void*)(&value));
			}
		}

		// Token: 0x040019F5 RID: 6645
		private static readonly IntPtr NativeFieldInfoPtr_OnStateChange;

		// Token: 0x040019F6 RID: 6646
		private static readonly IntPtr NativeFieldInfoPtr_stateChanged;

		// Token: 0x040019F7 RID: 6647
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040019F8 RID: 6648
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040019F9 RID: 6649
		private static readonly IntPtr NativeMethodInfoPtr_Clean_Private_Void_0;

		// Token: 0x040019FA RID: 6650
		private static readonly IntPtr NativeMethodInfoPtr_ChangeState_Public_Static_Void_0;

		// Token: 0x040019FB RID: 6651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
