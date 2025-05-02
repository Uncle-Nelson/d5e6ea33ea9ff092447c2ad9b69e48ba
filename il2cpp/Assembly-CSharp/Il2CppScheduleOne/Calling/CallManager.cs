using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ScriptableObjects;

namespace Il2CppScheduleOne.Calling
{
	// Token: 0x020004AD RID: 1197
	public class CallManager : Singleton<CallManager>
	{
		// Token: 0x06006990 RID: 27024 RVA: 0x001D8BD4 File Offset: 0x001D6DD4
		// Note: this type is marked as 'beforefieldinit'.
		static CallManager()
		{
			Il2CppClassPointerStore<CallManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Calling", "CallManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallManager>.NativeClassPtr);
			CallManager.NativeFieldInfoPtr__QueuedCallData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallManager>.NativeClassPtr, "<QueuedCallData>k__BackingField");
			CallManager.NativeMethodInfoPtr_get_QueuedCallData_Public_get_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676706);
			CallManager.NativeMethodInfoPtr_set_QueuedCallData_Private_set_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676707);
			CallManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676708);
			CallManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676709);
			CallManager.NativeMethodInfoPtr_QueueCall_Public_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676710);
			CallManager.NativeMethodInfoPtr_ClearQueuedCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676711);
			CallManager.NativeMethodInfoPtr_CallCompleted_Private_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676712);
			CallManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676713);
		}

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x06006991 RID: 27025 RVA: 0x001D8CB8 File Offset: 0x001D6EB8
		// (set) Token: 0x06006992 RID: 27026 RVA: 0x001D8CF8 File Offset: 0x001D6EF8
		public unsafe PhoneCallData QueuedCallData
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_get_QueuedCallData_Public_get_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_set_QueuedCallData_Private_set_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006993 RID: 27027 RVA: 0x001D8D3C File Offset: 0x001D6F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213080, XrefRangeEnd = 213116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006994 RID: 27028 RVA: 0x001D8D78 File Offset: 0x001D6F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213116, XrefRangeEnd = 213143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006995 RID: 27029 RVA: 0x001D8DB4 File Offset: 0x001D6FB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueCall(PhoneCallData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_QueueCall_Public_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006996 RID: 27030 RVA: 0x001D8DF8 File Offset: 0x001D6FF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213144, RefRangeEnd = 213145, XrefRangeStart = 213143, XrefRangeEnd = 213144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearQueuedCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_ClearQueuedCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006997 RID: 27031 RVA: 0x001D8E2C File Offset: 0x001D702C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213145, XrefRangeEnd = 213150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallCompleted(PhoneCallData call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_CallCompleted_Private_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006998 RID: 27032 RVA: 0x001D8E70 File Offset: 0x001D7070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213150, XrefRangeEnd = 213153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006999 RID: 27033 RVA: 0x00031E5B File Offset: 0x0003005B
		public CallManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x0600699A RID: 27034 RVA: 0x001D8EAC File Offset: 0x001D70AC
		// (set) Token: 0x0600699B RID: 27035 RVA: 0x00031E64 File Offset: 0x00030064
		public unsafe PhoneCallData _QueuedCallData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallManager.NativeFieldInfoPtr__QueuedCallData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallManager.NativeFieldInfoPtr__QueuedCallData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004853 RID: 18515
		private static readonly IntPtr NativeFieldInfoPtr__QueuedCallData_k__BackingField;

		// Token: 0x04004854 RID: 18516
		private static readonly IntPtr NativeMethodInfoPtr_get_QueuedCallData_Public_get_PhoneCallData_0;

		// Token: 0x04004855 RID: 18517
		private static readonly IntPtr NativeMethodInfoPtr_set_QueuedCallData_Private_set_Void_PhoneCallData_0;

		// Token: 0x04004856 RID: 18518
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004857 RID: 18519
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04004858 RID: 18520
		private static readonly IntPtr NativeMethodInfoPtr_QueueCall_Public_Void_PhoneCallData_0;

		// Token: 0x04004859 RID: 18521
		private static readonly IntPtr NativeMethodInfoPtr_ClearQueuedCall_Public_Void_0;

		// Token: 0x0400485A RID: 18522
		private static readonly IntPtr NativeMethodInfoPtr_CallCompleted_Private_Void_PhoneCallData_0;

		// Token: 0x0400485B RID: 18523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
