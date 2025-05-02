using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200000C RID: 12
	public class FrameTimingsHUDDisplay : MonoBehaviour
	{
		// Token: 0x0600011E RID: 286 RVA: 0x00074304 File Offset: 0x00072504
		// Note: this type is marked as 'beforefieldinit'.
		static FrameTimingsHUDDisplay()
		{
			Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FrameTimingsHUDDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr);
			FrameTimingsHUDDisplay.NativeFieldInfoPtr_m_Style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr, "m_Style");
			FrameTimingsHUDDisplay.NativeFieldInfoPtr_m_FrameTimings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr, "m_FrameTimings");
			FrameTimingsHUDDisplay.NativeFieldInfoPtr_SAMPLE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr, "SAMPLE_SIZE");
			FrameTimingsHUDDisplay.NativeFieldInfoPtr_frameTimingsHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr, "frameTimingsHistory");
			FrameTimingsHUDDisplay.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr, 100663368);
			FrameTimingsHUDDisplay.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr, 100663369);
			FrameTimingsHUDDisplay.NativeMethodInfoPtr_CaptureTimings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr, 100663370);
			FrameTimingsHUDDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr, 100663371);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000743D4 File Offset: 0x000725D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71377, XrefRangeEnd = 71385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimingsHUDDisplay.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00074408 File Offset: 0x00072608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71385, XrefRangeEnd = 71446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimingsHUDDisplay.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0007443C File Offset: 0x0007263C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71446, XrefRangeEnd = 71449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CaptureTimings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimingsHUDDisplay.NativeMethodInfoPtr_CaptureTimings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00074470 File Offset: 0x00072670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71449, XrefRangeEnd = 71461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FrameTimingsHUDDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimingsHUDDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002B5B File Offset: 0x00000D5B
		public FrameTimingsHUDDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000124 RID: 292 RVA: 0x000744AC File Offset: 0x000726AC
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00002B64 File Offset: 0x00000D64
		public unsafe GUIStyle m_Style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimingsHUDDisplay.NativeFieldInfoPtr_m_Style);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimingsHUDDisplay.NativeFieldInfoPtr_m_Style), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000126 RID: 294 RVA: 0x000744DC File Offset: 0x000726DC
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00002B83 File Offset: 0x00000D83
		public unsafe Il2CppStructArray<FrameTiming> m_FrameTimings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimingsHUDDisplay.NativeFieldInfoPtr_m_FrameTimings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<FrameTiming>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimingsHUDDisplay.NativeFieldInfoPtr_m_FrameTimings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0007450C File Offset: 0x0007270C
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00002BA2 File Offset: 0x00000DA2
		public unsafe static int SAMPLE_SIZE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FrameTimingsHUDDisplay.NativeFieldInfoPtr_SAMPLE_SIZE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FrameTimingsHUDDisplay.NativeFieldInfoPtr_SAMPLE_SIZE, (void*)(&value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00074528 File Offset: 0x00072728
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00002BB0 File Offset: 0x00000DB0
		public unsafe List<FrameTimingsHUDDisplay.FrameTimingPoint> frameTimingsHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimingsHUDDisplay.NativeFieldInfoPtr_frameTimingsHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FrameTimingsHUDDisplay.FrameTimingPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimingsHUDDisplay.NativeFieldInfoPtr_frameTimingsHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_m_Style;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_m_FrameTimings;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr_SAMPLE_SIZE;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeFieldInfoPtr_frameTimingsHistory;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_CaptureTimings_Private_Void_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007A3 RID: 1955
		[StructLayout(2)]
		public struct FrameTimingPoint
		{
			// Token: 0x0600B92A RID: 47402 RVA: 0x002DFDE4 File Offset: 0x002DDFE4
			// Note: this type is marked as 'beforefieldinit'.
			static FrameTimingPoint()
			{
				Il2CppClassPointerStore<FrameTimingsHUDDisplay.FrameTimingPoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FrameTimingsHUDDisplay>.NativeClassPtr, "FrameTimingPoint");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameTimingsHUDDisplay.FrameTimingPoint>.NativeClassPtr);
				FrameTimingsHUDDisplay.FrameTimingPoint.NativeFieldInfoPtr_cpuFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimingsHUDDisplay.FrameTimingPoint>.NativeClassPtr, "cpuFrameTime");
				FrameTimingsHUDDisplay.FrameTimingPoint.NativeFieldInfoPtr_cpuMainThreadFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimingsHUDDisplay.FrameTimingPoint>.NativeClassPtr, "cpuMainThreadFrameTime");
				FrameTimingsHUDDisplay.FrameTimingPoint.NativeFieldInfoPtr_cpuRenderThreadFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimingsHUDDisplay.FrameTimingPoint>.NativeClassPtr, "cpuRenderThreadFrameTime");
				FrameTimingsHUDDisplay.FrameTimingPoint.NativeFieldInfoPtr_gpuFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimingsHUDDisplay.FrameTimingPoint>.NativeClassPtr, "gpuFrameTime");
			}

			// Token: 0x0600B92B RID: 47403 RVA: 0x0005A8B4 File Offset: 0x00058AB4
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrameTimingsHUDDisplay.FrameTimingPoint>.NativeClassPtr, ref this));
			}

			// Token: 0x04007CF1 RID: 31985
			private static readonly IntPtr NativeFieldInfoPtr_cpuFrameTime;

			// Token: 0x04007CF2 RID: 31986
			private static readonly IntPtr NativeFieldInfoPtr_cpuMainThreadFrameTime;

			// Token: 0x04007CF3 RID: 31987
			private static readonly IntPtr NativeFieldInfoPtr_cpuRenderThreadFrameTime;

			// Token: 0x04007CF4 RID: 31988
			private static readonly IntPtr NativeFieldInfoPtr_gpuFrameTime;

			// Token: 0x04007CF5 RID: 31989
			[FieldOffset(0)]
			public double cpuFrameTime;

			// Token: 0x04007CF6 RID: 31990
			[FieldOffset(8)]
			public double cpuMainThreadFrameTime;

			// Token: 0x04007CF7 RID: 31991
			[FieldOffset(16)]
			public double cpuRenderThreadFrameTime;

			// Token: 0x04007CF8 RID: 31992
			[FieldOffset(24)]
			public double gpuFrameTime;
		}
	}
}
