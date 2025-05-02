using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;

namespace Il2CppScheduleOne.Police
{
	// Token: 0x020001F6 RID: 502
	public class Investigation : Object
	{
		// Token: 0x060028A9 RID: 10409 RVA: 0x000F1070 File Offset: 0x000EF270
		// Note: this type is marked as 'beforefieldinit'.
		static Investigation()
		{
			Il2CppClassPointerStore<Investigation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Police", "Investigation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Investigation>.NativeClassPtr);
			Investigation.NativeFieldInfoPtr__CurrentProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Investigation>.NativeClassPtr, "<CurrentProgress>k__BackingField");
			Investigation.NativeFieldInfoPtr__Target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Investigation>.NativeClassPtr, "<Target>k__BackingField");
			Investigation.NativeMethodInfoPtr_get_CurrentProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Investigation>.NativeClassPtr, 100667881);
			Investigation.NativeMethodInfoPtr_set_CurrentProgress_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Investigation>.NativeClassPtr, 100667882);
			Investigation.NativeMethodInfoPtr_get_Target_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Investigation>.NativeClassPtr, 100667883);
			Investigation.NativeMethodInfoPtr_set_Target_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Investigation>.NativeClassPtr, 100667884);
			Investigation.NativeMethodInfoPtr__ctor_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Investigation>.NativeClassPtr, 100667885);
			Investigation.NativeMethodInfoPtr_ChangeProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Investigation>.NativeClassPtr, 100667886);
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x060028AA RID: 10410 RVA: 0x000F1140 File Offset: 0x000EF340
		// (set) Token: 0x060028AB RID: 10411 RVA: 0x000F117C File Offset: 0x000EF37C
		public unsafe float CurrentProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Investigation.NativeMethodInfoPtr_get_CurrentProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 29950, RefRangeEnd = 29954, XrefRangeStart = 29950, XrefRangeEnd = 29954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Investigation.NativeMethodInfoPtr_set_CurrentProgress_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x060028AC RID: 10412 RVA: 0x000F11BC File Offset: 0x000EF3BC
		// (set) Token: 0x060028AD RID: 10413 RVA: 0x000F11FC File Offset: 0x000EF3FC
		public unsafe Player Target
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Investigation.NativeMethodInfoPtr_get_Target_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Investigation.NativeMethodInfoPtr_set_Target_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x000F1240 File Offset: 0x000EF440
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 118753, RefRangeEnd = 118757, XrefRangeStart = 118751, XrefRangeEnd = 118753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Investigation(Player target) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Investigation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Investigation.NativeMethodInfoPtr__ctor_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x000F128C File Offset: 0x000EF48C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 118757, RefRangeEnd = 118763, XrefRangeStart = 118757, XrefRangeEnd = 118757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Investigation.NativeMethodInfoPtr_ChangeProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x000161A6 File Offset: 0x000143A6
		public Investigation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x000F12CC File Offset: 0x000EF4CC
		// (set) Token: 0x060028B2 RID: 10418 RVA: 0x000161AF File Offset: 0x000143AF
		public unsafe float _CurrentProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Investigation.NativeFieldInfoPtr__CurrentProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Investigation.NativeFieldInfoPtr__CurrentProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x000F12F4 File Offset: 0x000EF4F4
		// (set) Token: 0x060028B4 RID: 10420 RVA: 0x000161CA File Offset: 0x000143CA
		public unsafe Player _Target_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Investigation.NativeFieldInfoPtr__Target_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Investigation.NativeFieldInfoPtr__Target_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AFA RID: 6906
		private static readonly IntPtr NativeFieldInfoPtr__CurrentProgress_k__BackingField;

		// Token: 0x04001AFB RID: 6907
		private static readonly IntPtr NativeFieldInfoPtr__Target_k__BackingField;

		// Token: 0x04001AFC RID: 6908
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentProgress_Public_get_Single_0;

		// Token: 0x04001AFD RID: 6909
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentProgress_Protected_set_Void_Single_0;

		// Token: 0x04001AFE RID: 6910
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Player_0;

		// Token: 0x04001AFF RID: 6911
		private static readonly IntPtr NativeMethodInfoPtr_set_Target_Protected_set_Void_Player_0;

		// Token: 0x04001B00 RID: 6912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Player_0;

		// Token: 0x04001B01 RID: 6913
		private static readonly IntPtr NativeMethodInfoPtr_ChangeProgress_Public_Void_Single_0;
	}
}
