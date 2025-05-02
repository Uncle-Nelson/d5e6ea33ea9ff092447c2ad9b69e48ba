using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x0200021A RID: 538
	public class LoadEventTransmitter : MonoBehaviour
	{
		// Token: 0x06002CB0 RID: 11440 RVA: 0x000FE868 File Offset: 0x000FCA68
		// Note: this type is marked as 'beforefieldinit'.
		static LoadEventTransmitter()
		{
			Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "LoadEventTransmitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr);
			LoadEventTransmitter.NativeFieldInfoPtr_onLoadComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr, "onLoadComplete");
			LoadEventTransmitter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr, 100668344);
			LoadEventTransmitter.NativeMethodInfoPtr_OnLoadComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr, 100668345);
			LoadEventTransmitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr, 100668346);
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x000FE8E8 File Offset: 0x000FCAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124596, XrefRangeEnd = 124608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadEventTransmitter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x000FE91C File Offset: 0x000FCB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124608, XrefRangeEnd = 124609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLoadComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadEventTransmitter.NativeMethodInfoPtr_OnLoadComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x000FE950 File Offset: 0x000FCB50
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadEventTransmitter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadEventTransmitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x000180D1 File Offset: 0x000162D1
		public LoadEventTransmitter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06002CB5 RID: 11445 RVA: 0x000FE98C File Offset: 0x000FCB8C
		// (set) Token: 0x06002CB6 RID: 11446 RVA: 0x000180DA File Offset: 0x000162DA
		public unsafe UnityEvent onLoadComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadEventTransmitter.NativeFieldInfoPtr_onLoadComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadEventTransmitter.NativeFieldInfoPtr_onLoadComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DAD RID: 7597
		private static readonly IntPtr NativeFieldInfoPtr_onLoadComplete;

		// Token: 0x04001DAE RID: 7598
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001DAF RID: 7599
		private static readonly IntPtr NativeMethodInfoPtr_OnLoadComplete_Private_Void_0;

		// Token: 0x04001DB0 RID: 7600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
