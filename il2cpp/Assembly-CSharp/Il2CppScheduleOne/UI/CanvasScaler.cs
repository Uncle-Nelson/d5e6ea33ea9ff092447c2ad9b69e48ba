using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200062A RID: 1578
	public class CanvasScaler : MonoBehaviour
	{
		// Token: 0x06008B27 RID: 35623 RVA: 0x00246B08 File Offset: 0x00244D08
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasScaler()
		{
			Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CanvasScaler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr);
			CanvasScaler.NativeFieldInfoPtr_CanvasScaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "CanvasScaleFactor");
			CanvasScaler.NativeFieldInfoPtr_OnCanvasScaleFactorChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "OnCanvasScaleFactorChanged");
			CanvasScaler.NativeFieldInfoPtr_ScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "ScaleMultiplier");
			CanvasScaler.NativeFieldInfoPtr_referenceResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "referenceResolution");
			CanvasScaler.NativeFieldInfoPtr_canvasScaler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "canvasScaler");
			CanvasScaler.NativeMethodInfoPtr_get_NormalizedCanvasScaleFactor_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100680583);
			CanvasScaler.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100680584);
			CanvasScaler.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100680585);
			CanvasScaler.NativeMethodInfoPtr_RefreshScale_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100680586);
			CanvasScaler.NativeMethodInfoPtr_SetScaleFactor_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100680587);
			CanvasScaler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100680588);
		}

		// Token: 0x17002A70 RID: 10864
		// (get) Token: 0x06008B28 RID: 35624 RVA: 0x00246C14 File Offset: 0x00244E14
		public unsafe static float NormalizedCanvasScaleFactor
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 255125, RefRangeEnd = 255128, XrefRangeStart = 255121, XrefRangeEnd = 255125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_NormalizedCanvasScaleFactor_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06008B29 RID: 35625 RVA: 0x00246C44 File Offset: 0x00244E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255128, XrefRangeEnd = 255158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B2A RID: 35626 RVA: 0x00246C78 File Offset: 0x00244E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255158, XrefRangeEnd = 255178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B2B RID: 35627 RVA: 0x00246CAC File Offset: 0x00244EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255178, XrefRangeEnd = 255184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_RefreshScale_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B2C RID: 35628 RVA: 0x00246CE0 File Offset: 0x00244EE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255189, RefRangeEnd = 255191, XrefRangeStart = 255184, XrefRangeEnd = 255189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetScaleFactor(float scaleFactor)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scaleFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_SetScaleFactor_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B2D RID: 35629 RVA: 0x00246D14 File Offset: 0x00244F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255191, XrefRangeEnd = 255192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasScaler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B2E RID: 35630 RVA: 0x000429E6 File Offset: 0x00040BE6
		public CanvasScaler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A6B RID: 10859
		// (get) Token: 0x06008B2F RID: 35631 RVA: 0x00246D50 File Offset: 0x00244F50
		// (set) Token: 0x06008B30 RID: 35632 RVA: 0x000429EF File Offset: 0x00040BEF
		public unsafe static float CanvasScaleFactor
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CanvasScaler.NativeFieldInfoPtr_CanvasScaleFactor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasScaler.NativeFieldInfoPtr_CanvasScaleFactor, (void*)(&value));
			}
		}

		// Token: 0x17002A6C RID: 10860
		// (get) Token: 0x06008B31 RID: 35633 RVA: 0x00246D6C File Offset: 0x00244F6C
		// (set) Token: 0x06008B32 RID: 35634 RVA: 0x000429FD File Offset: 0x00040BFD
		public unsafe static Action OnCanvasScaleFactorChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CanvasScaler.NativeFieldInfoPtr_OnCanvasScaleFactorChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasScaler.NativeFieldInfoPtr_OnCanvasScaleFactorChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A6D RID: 10861
		// (get) Token: 0x06008B33 RID: 35635 RVA: 0x00246D94 File Offset: 0x00244F94
		// (set) Token: 0x06008B34 RID: 35636 RVA: 0x00042A0F File Offset: 0x00040C0F
		public unsafe float ScaleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_ScaleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_ScaleMultiplier)) = value;
			}
		}

		// Token: 0x17002A6E RID: 10862
		// (get) Token: 0x06008B35 RID: 35637 RVA: 0x00246DBC File Offset: 0x00244FBC
		// (set) Token: 0x06008B36 RID: 35638 RVA: 0x00042A2A File Offset: 0x00040C2A
		public unsafe Vector2 referenceResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_referenceResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_referenceResolution)) = value;
			}
		}

		// Token: 0x17002A6F RID: 10863
		// (get) Token: 0x06008B37 RID: 35639 RVA: 0x00246DE4 File Offset: 0x00244FE4
		// (set) Token: 0x06008B38 RID: 35640 RVA: 0x00042A45 File Offset: 0x00040C45
		public unsafe CanvasScaler canvasScaler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_canvasScaler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasScaler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_canvasScaler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005E5C RID: 24156
		private static readonly IntPtr NativeFieldInfoPtr_CanvasScaleFactor;

		// Token: 0x04005E5D RID: 24157
		private static readonly IntPtr NativeFieldInfoPtr_OnCanvasScaleFactorChanged;

		// Token: 0x04005E5E RID: 24158
		private static readonly IntPtr NativeFieldInfoPtr_ScaleMultiplier;

		// Token: 0x04005E5F RID: 24159
		private static readonly IntPtr NativeFieldInfoPtr_referenceResolution;

		// Token: 0x04005E60 RID: 24160
		private static readonly IntPtr NativeFieldInfoPtr_canvasScaler;

		// Token: 0x04005E61 RID: 24161
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedCanvasScaleFactor_Public_Static_get_Single_0;

		// Token: 0x04005E62 RID: 24162
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04005E63 RID: 24163
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005E64 RID: 24164
		private static readonly IntPtr NativeMethodInfoPtr_RefreshScale_Private_Void_0;

		// Token: 0x04005E65 RID: 24165
		private static readonly IntPtr NativeMethodInfoPtr_SetScaleFactor_Public_Static_Void_Single_0;

		// Token: 0x04005E66 RID: 24166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
