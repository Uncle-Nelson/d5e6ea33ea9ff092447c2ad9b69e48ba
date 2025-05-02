using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities
{
	// Token: 0x02000515 RID: 1301
	public class CosmeticPowerLine : MonoBehaviour
	{
		// Token: 0x06007395 RID: 29589 RVA: 0x001F88E0 File Offset: 0x001F6AE0
		// Note: this type is marked as 'beforefieldinit'.
		static CosmeticPowerLine()
		{
			Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities", "CosmeticPowerLine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr);
			CosmeticPowerLine.NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr, "startPoint");
			CosmeticPowerLine.NativeFieldInfoPtr_endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr, "endPoint");
			CosmeticPowerLine.NativeFieldInfoPtr_segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr, "segments");
			CosmeticPowerLine.NativeFieldInfoPtr_LengthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr, "LengthFactor");
			CosmeticPowerLine.NativeMethodInfoPtr_Draw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr, 100677830);
			CosmeticPowerLine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr, 100677831);
		}

		// Token: 0x06007396 RID: 29590 RVA: 0x001F8988 File Offset: 0x001F6B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226285, XrefRangeEnd = 226297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CosmeticPowerLine.NativeMethodInfoPtr_Draw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007397 RID: 29591 RVA: 0x001F89BC File Offset: 0x001F6BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226297, XrefRangeEnd = 226305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CosmeticPowerLine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CosmeticPowerLine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007398 RID: 29592 RVA: 0x00036F01 File Offset: 0x00035101
		public CosmeticPowerLine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700230C RID: 8972
		// (get) Token: 0x06007399 RID: 29593 RVA: 0x001F89F8 File Offset: 0x001F6BF8
		// (set) Token: 0x0600739A RID: 29594 RVA: 0x00036F0A File Offset: 0x0003510A
		public unsafe Transform startPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_startPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_startPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700230D RID: 8973
		// (get) Token: 0x0600739B RID: 29595 RVA: 0x001F8A28 File Offset: 0x001F6C28
		// (set) Token: 0x0600739C RID: 29596 RVA: 0x00036F29 File Offset: 0x00035129
		public unsafe Transform endPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_endPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_endPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700230E RID: 8974
		// (get) Token: 0x0600739D RID: 29597 RVA: 0x001F8A58 File Offset: 0x001F6C58
		// (set) Token: 0x0600739E RID: 29598 RVA: 0x00036F48 File Offset: 0x00035148
		public unsafe List<Transform> segments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_segments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_segments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700230F RID: 8975
		// (get) Token: 0x0600739F RID: 29599 RVA: 0x001F8A88 File Offset: 0x001F6C88
		// (set) Token: 0x060073A0 RID: 29600 RVA: 0x00036F67 File Offset: 0x00035167
		public unsafe float LengthFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_LengthFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_LengthFactor)) = value;
			}
		}

		// Token: 0x04004EE8 RID: 20200
		private static readonly IntPtr NativeFieldInfoPtr_startPoint;

		// Token: 0x04004EE9 RID: 20201
		private static readonly IntPtr NativeFieldInfoPtr_endPoint;

		// Token: 0x04004EEA RID: 20202
		private static readonly IntPtr NativeFieldInfoPtr_segments;

		// Token: 0x04004EEB RID: 20203
		private static readonly IntPtr NativeFieldInfoPtr_LengthFactor;

		// Token: 0x04004EEC RID: 20204
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Public_Void_0;

		// Token: 0x04004EED RID: 20205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
