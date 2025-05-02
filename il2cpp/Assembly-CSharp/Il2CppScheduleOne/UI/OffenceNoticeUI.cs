using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Police;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200065A RID: 1626
	public class OffenceNoticeUI : Singleton<OffenceNoticeUI>
	{
		// Token: 0x0600911E RID: 37150 RVA: 0x00258534 File Offset: 0x00256734
		// Note: this type is marked as 'beforefieldinit'.
		static OffenceNoticeUI()
		{
			Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "OffenceNoticeUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr);
			OffenceNoticeUI.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, "container");
			OffenceNoticeUI.NativeFieldInfoPtr_charges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, "charges");
			OffenceNoticeUI.NativeFieldInfoPtr_penalties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, "penalties");
			OffenceNoticeUI.NativeMethodInfoPtr_ShowOffenceNotice_Public_Void_Offense_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, 100681271);
			OffenceNoticeUI.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, 100681272);
			OffenceNoticeUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, 100681273);
		}

		// Token: 0x0600911F RID: 37151 RVA: 0x002585DC File Offset: 0x002567DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262625, XrefRangeEnd = 262676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOffenceNotice(Offense offence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(offence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffenceNoticeUI.NativeMethodInfoPtr_ShowOffenceNotice_Public_Void_Offense_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009120 RID: 37152 RVA: 0x00258620 File Offset: 0x00256820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262676, XrefRangeEnd = 262705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffenceNoticeUI.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009121 RID: 37153 RVA: 0x00258654 File Offset: 0x00256854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262705, XrefRangeEnd = 262720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OffenceNoticeUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffenceNoticeUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009122 RID: 37154 RVA: 0x0004620E File Offset: 0x0004440E
		public OffenceNoticeUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C76 RID: 11382
		// (get) Token: 0x06009123 RID: 37155 RVA: 0x00258690 File Offset: 0x00256890
		// (set) Token: 0x06009124 RID: 37156 RVA: 0x00046217 File Offset: 0x00044417
		public unsafe GameObject container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C77 RID: 11383
		// (get) Token: 0x06009125 RID: 37157 RVA: 0x002586C0 File Offset: 0x002568C0
		// (set) Token: 0x06009126 RID: 37158 RVA: 0x00046236 File Offset: 0x00044436
		public unsafe List<Text> charges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_charges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_charges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C78 RID: 11384
		// (get) Token: 0x06009127 RID: 37159 RVA: 0x002586F0 File Offset: 0x002568F0
		// (set) Token: 0x06009128 RID: 37160 RVA: 0x00046255 File Offset: 0x00044455
		public unsafe List<Text> penalties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_penalties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_penalties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006218 RID: 25112
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04006219 RID: 25113
		private static readonly IntPtr NativeFieldInfoPtr_charges;

		// Token: 0x0400621A RID: 25114
		private static readonly IntPtr NativeFieldInfoPtr_penalties;

		// Token: 0x0400621B RID: 25115
		private static readonly IntPtr NativeMethodInfoPtr_ShowOffenceNotice_Public_Void_Offense_0;

		// Token: 0x0400621C RID: 25116
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

		// Token: 0x0400621D RID: 25117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
