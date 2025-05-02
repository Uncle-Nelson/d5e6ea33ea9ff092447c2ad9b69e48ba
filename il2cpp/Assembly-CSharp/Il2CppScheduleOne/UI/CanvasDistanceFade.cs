using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000629 RID: 1577
	public class CanvasDistanceFade : MonoBehaviour
	{
		// Token: 0x06008B1D RID: 35613 RVA: 0x00246984 File Offset: 0x00244B84
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasDistanceFade()
		{
			Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CanvasDistanceFade");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr);
			CanvasDistanceFade.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, "CanvasGroup");
			CanvasDistanceFade.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, "MinDistance");
			CanvasDistanceFade.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, "MaxDistance");
			CanvasDistanceFade.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, 100680581);
			CanvasDistanceFade.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, 100680582);
		}

		// Token: 0x06008B1E RID: 35614 RVA: 0x00246A18 File Offset: 0x00244C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255103, XrefRangeEnd = 255120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasDistanceFade.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B1F RID: 35615 RVA: 0x00246A4C File Offset: 0x00244C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255120, XrefRangeEnd = 255121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasDistanceFade() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasDistanceFade.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B20 RID: 35616 RVA: 0x00042988 File Offset: 0x00040B88
		public CanvasDistanceFade(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A68 RID: 10856
		// (get) Token: 0x06008B21 RID: 35617 RVA: 0x00246A88 File Offset: 0x00244C88
		// (set) Token: 0x06008B22 RID: 35618 RVA: 0x00042991 File Offset: 0x00040B91
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A69 RID: 10857
		// (get) Token: 0x06008B23 RID: 35619 RVA: 0x00246AB8 File Offset: 0x00244CB8
		// (set) Token: 0x06008B24 RID: 35620 RVA: 0x000429B0 File Offset: 0x00040BB0
		public unsafe float MinDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_MinDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_MinDistance)) = value;
			}
		}

		// Token: 0x17002A6A RID: 10858
		// (get) Token: 0x06008B25 RID: 35621 RVA: 0x00246AE0 File Offset: 0x00244CE0
		// (set) Token: 0x06008B26 RID: 35622 RVA: 0x000429CB File Offset: 0x00040BCB
		public unsafe float MaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_MaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_MaxDistance)) = value;
			}
		}

		// Token: 0x04005E57 RID: 24151
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x04005E58 RID: 24152
		private static readonly IntPtr NativeFieldInfoPtr_MinDistance;

		// Token: 0x04005E59 RID: 24153
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistance;

		// Token: 0x04005E5A RID: 24154
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04005E5B RID: 24155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
