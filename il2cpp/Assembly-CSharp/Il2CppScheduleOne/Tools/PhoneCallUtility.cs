using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ScriptableObjects;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000545 RID: 1349
	public class PhoneCallUtility : MonoBehaviour
	{
		// Token: 0x0600776F RID: 30575 RVA: 0x00206304 File Offset: 0x00204504
		// Note: this type is marked as 'beforefieldinit'.
		static PhoneCallUtility()
		{
			Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "PhoneCallUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr);
			PhoneCallUtility.NativeMethodInfoPtr_PromptCall_Public_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678339);
			PhoneCallUtility.NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678340);
			PhoneCallUtility.NativeMethodInfoPtr_SetQueuedCall_Public_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678341);
			PhoneCallUtility.NativeMethodInfoPtr_ClearCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678342);
			PhoneCallUtility.NativeMethodInfoPtr_SetPhoneOpenable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678343);
			PhoneCallUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678344);
		}

		// Token: 0x06007770 RID: 30576 RVA: 0x002063AC File Offset: 0x002045AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231872, XrefRangeEnd = 231878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PromptCall(PhoneCallData callData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_PromptCall_Public_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007771 RID: 30577 RVA: 0x002063F0 File Offset: 0x002045F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231878, XrefRangeEnd = 231884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCall(PhoneCallData callData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007772 RID: 30578 RVA: 0x00206434 File Offset: 0x00204634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231884, XrefRangeEnd = 231890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQueuedCall(PhoneCallData callData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_SetQueuedCall_Public_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007773 RID: 30579 RVA: 0x00206478 File Offset: 0x00204678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231890, XrefRangeEnd = 231896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_ClearCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007774 RID: 30580 RVA: 0x002064AC File Offset: 0x002046AC
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPhoneOpenable(bool openable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref openable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_SetPhoneOpenable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007775 RID: 30581 RVA: 0x002064EC File Offset: 0x002046EC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhoneCallUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007776 RID: 30582 RVA: 0x0003891E File Offset: 0x00036B1E
		public PhoneCallUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005182 RID: 20866
		private static readonly IntPtr NativeMethodInfoPtr_PromptCall_Public_Void_PhoneCallData_0;

		// Token: 0x04005183 RID: 20867
		private static readonly IntPtr NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_0;

		// Token: 0x04005184 RID: 20868
		private static readonly IntPtr NativeMethodInfoPtr_SetQueuedCall_Public_Void_PhoneCallData_0;

		// Token: 0x04005185 RID: 20869
		private static readonly IntPtr NativeMethodInfoPtr_ClearCall_Public_Void_0;

		// Token: 0x04005186 RID: 20870
		private static readonly IntPtr NativeMethodInfoPtr_SetPhoneOpenable_Public_Void_Boolean_0;

		// Token: 0x04005187 RID: 20871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
