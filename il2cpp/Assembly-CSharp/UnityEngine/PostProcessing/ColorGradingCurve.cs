using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000075 RID: 117
	[Serializable]
	public sealed class ColorGradingCurve : Object
	{
		// Token: 0x0600085A RID: 2138 RVA: 0x0008A10C File Offset: 0x0008830C
		// Note: this type is marked as 'beforefieldinit'.
		static ColorGradingCurve()
		{
			Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "ColorGradingCurve");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr);
			ColorGradingCurve.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr, "curve");
			ColorGradingCurve.NativeFieldInfoPtr_m_Loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr, "m_Loop");
			ColorGradingCurve.NativeFieldInfoPtr_m_ZeroValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr, "m_ZeroValue");
			ColorGradingCurve.NativeFieldInfoPtr_m_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr, "m_Range");
			ColorGradingCurve.NativeFieldInfoPtr_m_InternalLoopingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr, "m_InternalLoopingCurve");
			ColorGradingCurve.NativeMethodInfoPtr__ctor_Public_Void_AnimationCurve_Single_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr, 100664183);
			ColorGradingCurve.NativeMethodInfoPtr_Cache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr, 100664184);
			ColorGradingCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr, 100664185);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0008A1DC File Offset: 0x000883DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78914, XrefRangeEnd = 78917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorGradingCurve(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(curve);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zeroValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loop;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingCurve.NativeMethodInfoPtr__ctor_Public_Void_AnimationCurve_Single_Boolean_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0008A254 File Offset: 0x00088454
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78933, RefRangeEnd = 78935, XrefRangeStart = 78917, XrefRangeEnd = 78933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingCurve.NativeMethodInfoPtr_Cache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0008A288 File Offset: 0x00088488
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 78939, RefRangeEnd = 78947, XrefRangeStart = 78935, XrefRangeEnd = 78939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Evaluate(float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x000068D6 File Offset: 0x00004AD6
		public ColorGradingCurve(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x0008A2D4 File Offset: 0x000884D4
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x000068DF File Offset: 0x00004ADF
		public unsafe AnimationCurve curve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_curve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x0008A304 File Offset: 0x00088504
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x000068FE File Offset: 0x00004AFE
		public unsafe bool m_Loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_m_Loop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_m_Loop)) = value;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x0008A32C File Offset: 0x0008852C
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x00006919 File Offset: 0x00004B19
		public unsafe float m_ZeroValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_m_ZeroValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_m_ZeroValue)) = value;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x0008A354 File Offset: 0x00088554
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x00006934 File Offset: 0x00004B34
		public unsafe float m_Range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_m_Range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_m_Range)) = value;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x0008A37C File Offset: 0x0008857C
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x0000694F File Offset: 0x00004B4F
		public unsafe AnimationCurve m_InternalLoopingCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_m_InternalLoopingCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_m_InternalLoopingCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeFieldInfoPtr_curve;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeFieldInfoPtr_m_Loop;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeFieldInfoPtr_m_ZeroValue;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeFieldInfoPtr_m_Range;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalLoopingCurve;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationCurve_Single_Boolean_Vector2_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_Cache_Public_Void_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_0;
	}
}
