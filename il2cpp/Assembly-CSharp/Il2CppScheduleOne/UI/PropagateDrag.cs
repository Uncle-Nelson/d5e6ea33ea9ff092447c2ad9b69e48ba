using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000660 RID: 1632
	public class PropagateDrag : MonoBehaviour
	{
		// Token: 0x060091C7 RID: 37319 RVA: 0x0025A3C4 File Offset: 0x002585C4
		// Note: this type is marked as 'beforefieldinit'.
		static PropagateDrag()
		{
			Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PropagateDrag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr);
			PropagateDrag.NativeFieldInfoPtr_ScrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, "ScrollView");
			PropagateDrag.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681362);
			PropagateDrag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681363);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681364);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681365);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_2_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681366);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_3_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681367);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_4_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681368);
		}

		// Token: 0x060091C8 RID: 37320 RVA: 0x0025A494 File Offset: 0x00258694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263669, XrefRangeEnd = 263752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091C9 RID: 37321 RVA: 0x0025A4C8 File Offset: 0x002586C8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropagateDrag() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091CA RID: 37322 RVA: 0x0025A504 File Offset: 0x00258704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263752, XrefRangeEnd = 263756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091CB RID: 37323 RVA: 0x0025A548 File Offset: 0x00258748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263756, XrefRangeEnd = 263760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_1(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091CC RID: 37324 RVA: 0x0025A58C File Offset: 0x0025878C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263760, XrefRangeEnd = 263764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_2(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_2_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091CD RID: 37325 RVA: 0x0025A5D0 File Offset: 0x002587D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263764, XrefRangeEnd = 263768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_3(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_3_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091CE RID: 37326 RVA: 0x0025A614 File Offset: 0x00258814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263768, XrefRangeEnd = 263772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_4(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_4_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091CF RID: 37327 RVA: 0x00046829 File Offset: 0x00044A29
		public PropagateDrag(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CAE RID: 11438
		// (get) Token: 0x060091D0 RID: 37328 RVA: 0x0025A658 File Offset: 0x00258858
		// (set) Token: 0x060091D1 RID: 37329 RVA: 0x00046832 File Offset: 0x00044A32
		public unsafe ScrollRect ScrollView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagateDrag.NativeFieldInfoPtr_ScrollView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagateDrag.NativeFieldInfoPtr_ScrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006280 RID: 25216
		private static readonly IntPtr NativeFieldInfoPtr_ScrollView;

		// Token: 0x04006281 RID: 25217
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006282 RID: 25218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006283 RID: 25219
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_0_Private_Void_BaseEventData_0;

		// Token: 0x04006284 RID: 25220
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_1_Private_Void_BaseEventData_0;

		// Token: 0x04006285 RID: 25221
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_2_Private_Void_BaseEventData_0;

		// Token: 0x04006286 RID: 25222
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_3_Private_Void_BaseEventData_0;

		// Token: 0x04006287 RID: 25223
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_4_Private_Void_BaseEventData_0;
	}
}
