using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x0200076C RID: 1900
	public class UtilityPole : MonoBehaviour
	{
		// Token: 0x0600B45D RID: 46173 RVA: 0x002CECF0 File Offset: 0x002CCEF0
		// Note: this type is marked as 'beforefieldinit'.
		static UtilityPole()
		{
			Il2CppClassPointerStore<UtilityPole>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "UtilityPole");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr);
			UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "CABLE_CULL_DISTANCE");
			UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE_SQR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "CABLE_CULL_DISTANCE_SQR");
			UtilityPole.NativeFieldInfoPtr_previousPole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "previousPole");
			UtilityPole.NativeFieldInfoPtr_nextPole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "nextPole");
			UtilityPole.NativeFieldInfoPtr_Connection1Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "Connection1Enabled");
			UtilityPole.NativeFieldInfoPtr_Connection2Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "Connection2Enabled");
			UtilityPole.NativeFieldInfoPtr_LengthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "LengthFactor");
			UtilityPole.NativeFieldInfoPtr_cable1Connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cable1Connection");
			UtilityPole.NativeFieldInfoPtr_cable2Connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cable2Connection");
			UtilityPole.NativeFieldInfoPtr_cable1Segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cable1Segments");
			UtilityPole.NativeFieldInfoPtr_cable2Segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cable2Segments");
			UtilityPole.NativeFieldInfoPtr_Cable1Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "Cable1Container");
			UtilityPole.NativeFieldInfoPtr_Cable2Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "Cable2Container");
			UtilityPole.NativeFieldInfoPtr_cableStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cableStart");
			UtilityPole.NativeFieldInfoPtr_cableEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cableEnd");
			UtilityPole.NativeFieldInfoPtr_cableMid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cableMid");
			UtilityPole.NativeMethodInfoPtr_Awake_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100685511);
			UtilityPole.NativeMethodInfoPtr_Start_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100685512);
			UtilityPole.NativeMethodInfoPtr_UpdateCulling_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100685513);
			UtilityPole.NativeMethodInfoPtr_Orient_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100685514);
			UtilityPole.NativeMethodInfoPtr_DrawLines_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100685515);
			UtilityPole.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100685516);
			UtilityPole.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100685517);
		}

		// Token: 0x0600B45E RID: 46174 RVA: 0x002CEEEC File Offset: 0x002CD0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309529, XrefRangeEnd = 309539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_Awake_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B45F RID: 46175 RVA: 0x002CEF20 File Offset: 0x002CD120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309539, XrefRangeEnd = 309563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_Start_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B460 RID: 46176 RVA: 0x002CEF54 File Offset: 0x002CD154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309563, XrefRangeEnd = 309591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCulling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_UpdateCulling_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B461 RID: 46177 RVA: 0x002CEF88 File Offset: 0x002CD188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309591, XrefRangeEnd = 309641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Orient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_Orient_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B462 RID: 46178 RVA: 0x002CEFBC File Offset: 0x002CD1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309641, XrefRangeEnd = 309709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawLines()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_DrawLines_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B463 RID: 46179 RVA: 0x002CEFF0 File Offset: 0x002CD1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309709, XrefRangeEnd = 309728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UtilityPole() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B464 RID: 46180 RVA: 0x002CF02C File Offset: 0x002CD22C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309759, RefRangeEnd = 309760, XrefRangeStart = 309728, XrefRangeEnd = 309759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B465 RID: 46181 RVA: 0x000586D7 File Offset: 0x000568D7
		public UtilityPole(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037E6 RID: 14310
		// (get) Token: 0x0600B466 RID: 46182 RVA: 0x002CF060 File Offset: 0x002CD260
		// (set) Token: 0x0600B467 RID: 46183 RVA: 0x000586E0 File Offset: 0x000568E0
		public unsafe static float CABLE_CULL_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170037E7 RID: 14311
		// (get) Token: 0x0600B468 RID: 46184 RVA: 0x002CF07C File Offset: 0x002CD27C
		// (set) Token: 0x0600B469 RID: 46185 RVA: 0x000586EE File Offset: 0x000568EE
		public unsafe static float CABLE_CULL_DISTANCE_SQR
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE_SQR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE_SQR, (void*)(&value));
			}
		}

		// Token: 0x170037E8 RID: 14312
		// (get) Token: 0x0600B46A RID: 46186 RVA: 0x002CF098 File Offset: 0x002CD298
		// (set) Token: 0x0600B46B RID: 46187 RVA: 0x000586FC File Offset: 0x000568FC
		public unsafe UtilityPole previousPole
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_previousPole);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UtilityPole>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_previousPole), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037E9 RID: 14313
		// (get) Token: 0x0600B46C RID: 46188 RVA: 0x002CF0C8 File Offset: 0x002CD2C8
		// (set) Token: 0x0600B46D RID: 46189 RVA: 0x0005871B File Offset: 0x0005691B
		public unsafe UtilityPole nextPole
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_nextPole);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UtilityPole>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_nextPole), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037EA RID: 14314
		// (get) Token: 0x0600B46E RID: 46190 RVA: 0x002CF0F8 File Offset: 0x002CD2F8
		// (set) Token: 0x0600B46F RID: 46191 RVA: 0x0005873A File Offset: 0x0005693A
		public unsafe bool Connection1Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Connection1Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Connection1Enabled)) = value;
			}
		}

		// Token: 0x170037EB RID: 14315
		// (get) Token: 0x0600B470 RID: 46192 RVA: 0x002CF120 File Offset: 0x002CD320
		// (set) Token: 0x0600B471 RID: 46193 RVA: 0x00058755 File Offset: 0x00056955
		public unsafe bool Connection2Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Connection2Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Connection2Enabled)) = value;
			}
		}

		// Token: 0x170037EC RID: 14316
		// (get) Token: 0x0600B472 RID: 46194 RVA: 0x002CF148 File Offset: 0x002CD348
		// (set) Token: 0x0600B473 RID: 46195 RVA: 0x00058770 File Offset: 0x00056970
		public unsafe float LengthFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_LengthFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_LengthFactor)) = value;
			}
		}

		// Token: 0x170037ED RID: 14317
		// (get) Token: 0x0600B474 RID: 46196 RVA: 0x002CF170 File Offset: 0x002CD370
		// (set) Token: 0x0600B475 RID: 46197 RVA: 0x0005878B File Offset: 0x0005698B
		public unsafe Transform cable1Connection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable1Connection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable1Connection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037EE RID: 14318
		// (get) Token: 0x0600B476 RID: 46198 RVA: 0x002CF1A0 File Offset: 0x002CD3A0
		// (set) Token: 0x0600B477 RID: 46199 RVA: 0x000587AA File Offset: 0x000569AA
		public unsafe Transform cable2Connection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable2Connection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable2Connection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037EF RID: 14319
		// (get) Token: 0x0600B478 RID: 46200 RVA: 0x002CF1D0 File Offset: 0x002CD3D0
		// (set) Token: 0x0600B479 RID: 46201 RVA: 0x000587C9 File Offset: 0x000569C9
		public unsafe List<Transform> cable1Segments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable1Segments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable1Segments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037F0 RID: 14320
		// (get) Token: 0x0600B47A RID: 46202 RVA: 0x002CF200 File Offset: 0x002CD400
		// (set) Token: 0x0600B47B RID: 46203 RVA: 0x000587E8 File Offset: 0x000569E8
		public unsafe List<Transform> cable2Segments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable2Segments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable2Segments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037F1 RID: 14321
		// (get) Token: 0x0600B47C RID: 46204 RVA: 0x002CF230 File Offset: 0x002CD430
		// (set) Token: 0x0600B47D RID: 46205 RVA: 0x00058807 File Offset: 0x00056A07
		public unsafe Transform Cable1Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Cable1Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Cable1Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037F2 RID: 14322
		// (get) Token: 0x0600B47E RID: 46206 RVA: 0x002CF260 File Offset: 0x002CD460
		// (set) Token: 0x0600B47F RID: 46207 RVA: 0x00058826 File Offset: 0x00056A26
		public unsafe Transform Cable2Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Cable2Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Cable2Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037F3 RID: 14323
		// (get) Token: 0x0600B480 RID: 46208 RVA: 0x002CF290 File Offset: 0x002CD490
		// (set) Token: 0x0600B481 RID: 46209 RVA: 0x00058845 File Offset: 0x00056A45
		public unsafe Vector3 cableStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cableStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cableStart)) = value;
			}
		}

		// Token: 0x170037F4 RID: 14324
		// (get) Token: 0x0600B482 RID: 46210 RVA: 0x002CF2B8 File Offset: 0x002CD4B8
		// (set) Token: 0x0600B483 RID: 46211 RVA: 0x00058860 File Offset: 0x00056A60
		public unsafe Vector3 cableEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cableEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cableEnd)) = value;
			}
		}

		// Token: 0x170037F5 RID: 14325
		// (get) Token: 0x0600B484 RID: 46212 RVA: 0x002CF2E0 File Offset: 0x002CD4E0
		// (set) Token: 0x0600B485 RID: 46213 RVA: 0x0005887B File Offset: 0x00056A7B
		public unsafe Vector3 cableMid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cableMid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cableMid)) = value;
			}
		}

		// Token: 0x0400799C RID: 31132
		private static readonly IntPtr NativeFieldInfoPtr_CABLE_CULL_DISTANCE;

		// Token: 0x0400799D RID: 31133
		private static readonly IntPtr NativeFieldInfoPtr_CABLE_CULL_DISTANCE_SQR;

		// Token: 0x0400799E RID: 31134
		private static readonly IntPtr NativeFieldInfoPtr_previousPole;

		// Token: 0x0400799F RID: 31135
		private static readonly IntPtr NativeFieldInfoPtr_nextPole;

		// Token: 0x040079A0 RID: 31136
		private static readonly IntPtr NativeFieldInfoPtr_Connection1Enabled;

		// Token: 0x040079A1 RID: 31137
		private static readonly IntPtr NativeFieldInfoPtr_Connection2Enabled;

		// Token: 0x040079A2 RID: 31138
		private static readonly IntPtr NativeFieldInfoPtr_LengthFactor;

		// Token: 0x040079A3 RID: 31139
		private static readonly IntPtr NativeFieldInfoPtr_cable1Connection;

		// Token: 0x040079A4 RID: 31140
		private static readonly IntPtr NativeFieldInfoPtr_cable2Connection;

		// Token: 0x040079A5 RID: 31141
		private static readonly IntPtr NativeFieldInfoPtr_cable1Segments;

		// Token: 0x040079A6 RID: 31142
		private static readonly IntPtr NativeFieldInfoPtr_cable2Segments;

		// Token: 0x040079A7 RID: 31143
		private static readonly IntPtr NativeFieldInfoPtr_Cable1Container;

		// Token: 0x040079A8 RID: 31144
		private static readonly IntPtr NativeFieldInfoPtr_Cable2Container;

		// Token: 0x040079A9 RID: 31145
		private static readonly IntPtr NativeFieldInfoPtr_cableStart;

		// Token: 0x040079AA RID: 31146
		private static readonly IntPtr NativeFieldInfoPtr_cableEnd;

		// Token: 0x040079AB RID: 31147
		private static readonly IntPtr NativeFieldInfoPtr_cableMid;

		// Token: 0x040079AC RID: 31148
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_1;

		// Token: 0x040079AD RID: 31149
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_1;

		// Token: 0x040079AE RID: 31150
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCulling_Private_Void_1;

		// Token: 0x040079AF RID: 31151
		private static readonly IntPtr NativeMethodInfoPtr_Orient_Public_Void_0;

		// Token: 0x040079B0 RID: 31152
		private static readonly IntPtr NativeMethodInfoPtr_DrawLines_Public_Void_0;

		// Token: 0x040079B1 RID: 31153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040079B2 RID: 31154
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
