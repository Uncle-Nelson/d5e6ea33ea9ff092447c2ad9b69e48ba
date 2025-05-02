using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000787 RID: 1927
	public class TimedAccessZone : AccessZone
	{
		// Token: 0x0600B676 RID: 46710 RVA: 0x002D4E74 File Offset: 0x002D3074
		// Note: this type is marked as 'beforefieldinit'.
		static TimedAccessZone()
		{
			Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "TimedAccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr);
			TimedAccessZone.NativeFieldInfoPtr_OpenTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, "OpenTime");
			TimedAccessZone.NativeFieldInfoPtr_CloseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, "CloseTime");
			TimedAccessZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, 100685722);
			TimedAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, 100685723);
			TimedAccessZone.NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, 100685724);
			TimedAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, 100685725);
		}

		// Token: 0x0600B677 RID: 46711 RVA: 0x002D4F1C File Offset: 0x002D311C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311466, XrefRangeEnd = 311482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimedAccessZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B678 RID: 46712 RVA: 0x002D4F58 File Offset: 0x002D3158
		[CallerCount(0)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimedAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B679 RID: 46713 RVA: 0x002D4F94 File Offset: 0x002D3194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311482, XrefRangeEnd = 311488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetIsOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimedAccessZone.NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B67A RID: 46714 RVA: 0x002D4FDC File Offset: 0x002D31DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimedAccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B67B RID: 46715 RVA: 0x000599A4 File Offset: 0x00057BA4
		public TimedAccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003895 RID: 14485
		// (get) Token: 0x0600B67C RID: 46716 RVA: 0x002D5018 File Offset: 0x002D3218
		// (set) Token: 0x0600B67D RID: 46717 RVA: 0x000599AD File Offset: 0x00057BAD
		public unsafe int OpenTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedAccessZone.NativeFieldInfoPtr_OpenTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedAccessZone.NativeFieldInfoPtr_OpenTime)) = value;
			}
		}

		// Token: 0x17003896 RID: 14486
		// (get) Token: 0x0600B67E RID: 46718 RVA: 0x002D5040 File Offset: 0x002D3240
		// (set) Token: 0x0600B67F RID: 46719 RVA: 0x000599C8 File Offset: 0x00057BC8
		public unsafe int CloseTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedAccessZone.NativeFieldInfoPtr_CloseTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedAccessZone.NativeFieldInfoPtr_CloseTime)) = value;
			}
		}

		// Token: 0x04007AE9 RID: 31465
		private static readonly IntPtr NativeFieldInfoPtr_OpenTime;

		// Token: 0x04007AEA RID: 31466
		private static readonly IntPtr NativeFieldInfoPtr_CloseTime;

		// Token: 0x04007AEB RID: 31467
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007AEC RID: 31468
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04007AED RID: 31469
		private static readonly IntPtr NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_New_Boolean_0;

		// Token: 0x04007AEE RID: 31470
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
