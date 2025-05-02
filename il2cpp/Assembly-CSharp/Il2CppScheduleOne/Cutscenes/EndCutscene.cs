using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Cutscenes
{
	// Token: 0x02000480 RID: 1152
	public class EndCutscene : Cutscene
	{
		// Token: 0x060063DA RID: 25562 RVA: 0x001C4738 File Offset: 0x001C2938
		// Note: this type is marked as 'beforefieldinit'.
		static EndCutscene()
		{
			Il2CppClassPointerStore<EndCutscene>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cutscenes", "EndCutscene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr);
			EndCutscene.NativeFieldInfoPtr_onStandUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, "onStandUp");
			EndCutscene.NativeFieldInfoPtr_onRunStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, "onRunStart");
			EndCutscene.NativeFieldInfoPtr_onEngineStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, "onEngineStart");
			EndCutscene.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, "Avatar");
			EndCutscene.NativeMethodInfoPtr_Play_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675952);
			EndCutscene.NativeMethodInfoPtr_StandUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675953);
			EndCutscene.NativeMethodInfoPtr_RunStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675954);
			EndCutscene.NativeMethodInfoPtr_EngineStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675955);
			EndCutscene.NativeMethodInfoPtr_On3rdPerson_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675956);
			EndCutscene.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675957);
		}

		// Token: 0x060063DB RID: 25563 RVA: 0x001C4830 File Offset: 0x001C2A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203981, XrefRangeEnd = 203988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EndCutscene.NativeMethodInfoPtr_Play_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DC RID: 25564 RVA: 0x001C486C File Offset: 0x001C2A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203988, XrefRangeEnd = 203995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StandUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr_StandUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x001C48A0 File Offset: 0x001C2AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203995, XrefRangeEnd = 204002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr_RunStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DE RID: 25566 RVA: 0x001C48D4 File Offset: 0x001C2AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204002, XrefRangeEnd = 204009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EngineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr_EngineStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x001C4908 File Offset: 0x001C2B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204009, XrefRangeEnd = 204015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void On3rdPerson()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr_On3rdPerson_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063E0 RID: 25568 RVA: 0x001C493C File Offset: 0x001C2B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndCutscene() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063E1 RID: 25569 RVA: 0x0002F38A File Offset: 0x0002D58A
		public EndCutscene(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x060063E2 RID: 25570 RVA: 0x001C4978 File Offset: 0x001C2B78
		// (set) Token: 0x060063E3 RID: 25571 RVA: 0x0002F393 File Offset: 0x0002D593
		public unsafe UnityEvent onStandUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onStandUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onStandUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x060063E4 RID: 25572 RVA: 0x001C49A8 File Offset: 0x001C2BA8
		// (set) Token: 0x060063E5 RID: 25573 RVA: 0x0002F3B2 File Offset: 0x0002D5B2
		public unsafe UnityEvent onRunStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onRunStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onRunStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x060063E6 RID: 25574 RVA: 0x001C49D8 File Offset: 0x001C2BD8
		// (set) Token: 0x060063E7 RID: 25575 RVA: 0x0002F3D1 File Offset: 0x0002D5D1
		public unsafe UnityEvent onEngineStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onEngineStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onEngineStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x060063E8 RID: 25576 RVA: 0x001C4A08 File Offset: 0x001C2C08
		// (set) Token: 0x060063E9 RID: 25577 RVA: 0x0002F3F0 File Offset: 0x0002D5F0
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004424 RID: 17444
		private static readonly IntPtr NativeFieldInfoPtr_onStandUp;

		// Token: 0x04004425 RID: 17445
		private static readonly IntPtr NativeFieldInfoPtr_onRunStart;

		// Token: 0x04004426 RID: 17446
		private static readonly IntPtr NativeFieldInfoPtr_onEngineStart;

		// Token: 0x04004427 RID: 17447
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04004428 RID: 17448
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Void_0;

		// Token: 0x04004429 RID: 17449
		private static readonly IntPtr NativeMethodInfoPtr_StandUp_Public_Void_0;

		// Token: 0x0400442A RID: 17450
		private static readonly IntPtr NativeMethodInfoPtr_RunStart_Public_Void_0;

		// Token: 0x0400442B RID: 17451
		private static readonly IntPtr NativeMethodInfoPtr_EngineStart_Public_Void_0;

		// Token: 0x0400442C RID: 17452
		private static readonly IntPtr NativeMethodInfoPtr_On3rdPerson_Public_Void_0;

		// Token: 0x0400442D RID: 17453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
