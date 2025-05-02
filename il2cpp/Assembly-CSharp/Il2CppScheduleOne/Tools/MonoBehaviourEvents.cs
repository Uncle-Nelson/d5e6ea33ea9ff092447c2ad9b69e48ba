using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000540 RID: 1344
	public class MonoBehaviourEvents : MonoBehaviour
	{
		// Token: 0x0600772F RID: 30511 RVA: 0x002057A0 File Offset: 0x002039A0
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBehaviourEvents()
		{
			Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "MonoBehaviourEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr);
			MonoBehaviourEvents.NativeFieldInfoPtr_onAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, "onAwake");
			MonoBehaviourEvents.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, "onStart");
			MonoBehaviourEvents.NativeFieldInfoPtr_onUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, "onUpdate");
			MonoBehaviourEvents.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, 100678317);
			MonoBehaviourEvents.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, 100678318);
			MonoBehaviourEvents.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, 100678319);
			MonoBehaviourEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, 100678320);
		}

		// Token: 0x06007730 RID: 30512 RVA: 0x0020585C File Offset: 0x00203A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231693, XrefRangeEnd = 231694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourEvents.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007731 RID: 30513 RVA: 0x00205890 File Offset: 0x00203A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231694, XrefRangeEnd = 231695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourEvents.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007732 RID: 30514 RVA: 0x002058C4 File Offset: 0x00203AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231695, XrefRangeEnd = 231696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourEvents.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007733 RID: 30515 RVA: 0x002058F8 File Offset: 0x00203AF8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBehaviourEvents() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007734 RID: 30516 RVA: 0x00038737 File Offset: 0x00036937
		public MonoBehaviourEvents(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700240C RID: 9228
		// (get) Token: 0x06007735 RID: 30517 RVA: 0x00205934 File Offset: 0x00203B34
		// (set) Token: 0x06007736 RID: 30518 RVA: 0x00038740 File Offset: 0x00036940
		public unsafe UnityEvent onAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onAwake);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onAwake), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700240D RID: 9229
		// (get) Token: 0x06007737 RID: 30519 RVA: 0x00205964 File Offset: 0x00203B64
		// (set) Token: 0x06007738 RID: 30520 RVA: 0x0003875F File Offset: 0x0003695F
		public unsafe UnityEvent onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700240E RID: 9230
		// (get) Token: 0x06007739 RID: 30521 RVA: 0x00205994 File Offset: 0x00203B94
		// (set) Token: 0x0600773A RID: 30522 RVA: 0x0003877E File Offset: 0x0003697E
		public unsafe UnityEvent onUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400515C RID: 20828
		private static readonly IntPtr NativeFieldInfoPtr_onAwake;

		// Token: 0x0400515D RID: 20829
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x0400515E RID: 20830
		private static readonly IntPtr NativeFieldInfoPtr_onUpdate;

		// Token: 0x0400515F RID: 20831
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005160 RID: 20832
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005161 RID: 20833
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005162 RID: 20834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
