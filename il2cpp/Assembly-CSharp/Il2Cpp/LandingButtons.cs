using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200003B RID: 59
	public class LandingButtons : MonoBehaviour
	{
		// Token: 0x060004DD RID: 1245 RVA: 0x0007E8B0 File Offset: 0x0007CAB0
		// Note: this type is marked as 'beforefieldinit'.
		static LandingButtons()
		{
			Il2CppClassPointerStore<LandingButtons>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LandingButtons");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingButtons>.NativeClassPtr);
			LandingButtons.NativeFieldInfoPtr__landingSpotController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingButtons>.NativeClassPtr, "_landingSpotController");
			LandingButtons.NativeFieldInfoPtr__flockController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingButtons>.NativeClassPtr, "_flockController");
			LandingButtons.NativeFieldInfoPtr_hSliderValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingButtons>.NativeClassPtr, "hSliderValue");
			LandingButtons.NativeMethodInfoPtr_OnGUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingButtons>.NativeClassPtr, 100663698);
			LandingButtons.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingButtons>.NativeClassPtr, 100663699);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0007E944 File Offset: 0x0007CB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74378, XrefRangeEnd = 74448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingButtons.NativeMethodInfoPtr_OnGUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0007E978 File Offset: 0x0007CB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74448, XrefRangeEnd = 74449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandingButtons() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingButtons>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingButtons.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00004E8C File Offset: 0x0000308C
		public LandingButtons(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0007E9B4 File Offset: 0x0007CBB4
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00004E95 File Offset: 0x00003095
		public unsafe LandingSpotController _landingSpotController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingButtons.NativeFieldInfoPtr__landingSpotController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandingSpotController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingButtons.NativeFieldInfoPtr__landingSpotController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0007E9E4 File Offset: 0x0007CBE4
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00004EB4 File Offset: 0x000030B4
		public unsafe FlockController _flockController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingButtons.NativeFieldInfoPtr__flockController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingButtons.NativeFieldInfoPtr__flockController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0007EA14 File Offset: 0x0007CC14
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00004ED3 File Offset: 0x000030D3
		public unsafe float hSliderValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingButtons.NativeFieldInfoPtr_hSliderValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingButtons.NativeFieldInfoPtr_hSliderValue)) = value;
			}
		}

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeFieldInfoPtr__landingSpotController;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeFieldInfoPtr__flockController;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr_hSliderValue;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Public_Void_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
