using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000734 RID: 1844
	public class PotSoilCover : MonoBehaviour
	{
		// Token: 0x0600A8CD RID: 43213 RVA: 0x002A2C48 File Offset: 0x002A0E48
		// Note: this type is marked as 'beforefieldinit'.
		static PotSoilCover()
		{
			Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "PotSoilCover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr);
			PotSoilCover.NativeFieldInfoPtr_TEXTURE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "TEXTURE_SIZE");
			PotSoilCover.NativeFieldInfoPtr_POUR_RADIUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "POUR_RADIUS");
			PotSoilCover.NativeFieldInfoPtr_UPDATES_PER_SECOND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "UPDATES_PER_SECOND");
			PotSoilCover.NativeFieldInfoPtr_COVERAGE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "COVERAGE_THRESHOLD");
			PotSoilCover.NativeFieldInfoPtr_BASE_COVERAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "BASE_COVERAGE");
			PotSoilCover.NativeFieldInfoPtr_SUCCESS_COVERAGE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "SUCCESS_COVERAGE_THRESHOLD");
			PotSoilCover.NativeFieldInfoPtr_DELAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "DELAY");
			PotSoilCover.NativeFieldInfoPtr_CurrentCoverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "CurrentCoverage");
			PotSoilCover.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "Radius");
			PotSoilCover.NativeFieldInfoPtr_MeshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "MeshRenderer");
			PotSoilCover.NativeFieldInfoPtr_PourMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "PourMask");
			PotSoilCover.NativeFieldInfoPtr_onSufficientCoverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "onSufficientCoverage");
			PotSoilCover.NativeFieldInfoPtr_queued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "queued");
			PotSoilCover.NativeFieldInfoPtr_queuedWorldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "queuedWorldPos");
			PotSoilCover.NativeFieldInfoPtr_mainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "mainTex");
			PotSoilCover.NativeFieldInfoPtr_relative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "relative");
			PotSoilCover.NativeFieldInfoPtr_vector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "vector2");
			PotSoilCover.NativeFieldInfoPtr_normalizedOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "normalizedOffset");
			PotSoilCover.NativeFieldInfoPtr_originPixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "originPixel");
			PotSoilCover.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683975);
			PotSoilCover.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683976);
			PotSoilCover.NativeMethodInfoPtr_ConfigureAppearance_Public_Void_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683977);
			PotSoilCover.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683978);
			PotSoilCover.NativeMethodInfoPtr_QueuePour_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683979);
			PotSoilCover.NativeMethodInfoPtr_GetNormalizedProgress_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683980);
			PotSoilCover.NativeMethodInfoPtr_CheckQueue_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683981);
			PotSoilCover.NativeMethodInfoPtr_Blank_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683982);
			PotSoilCover.NativeMethodInfoPtr_DelayedApplyPour_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683983);
			PotSoilCover.NativeMethodInfoPtr_ApplyPour_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683984);
			PotSoilCover.NativeMethodInfoPtr_GetPourMaskValue_Private_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683985);
			PotSoilCover.NativeMethodInfoPtr_GetCoverage_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683986);
			PotSoilCover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683987);
		}

		// Token: 0x0600A8CE RID: 43214 RVA: 0x002A2EF8 File Offset: 0x002A10F8
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8CF RID: 43215 RVA: 0x002A2F2C File Offset: 0x002A112C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294041, XrefRangeEnd = 294047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8D0 RID: 43216 RVA: 0x002A2F60 File Offset: 0x002A1160
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294056, RefRangeEnd = 294058, XrefRangeStart = 294047, XrefRangeEnd = 294056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureAppearance(Color col, float transparency)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transparency;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_ConfigureAppearance_Public_Void_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8D1 RID: 43217 RVA: 0x002A2FAC File Offset: 0x002A11AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294071, RefRangeEnd = 294072, XrefRangeStart = 294058, XrefRangeEnd = 294071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8D2 RID: 43218 RVA: 0x002A2FE0 File Offset: 0x002A11E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294072, RefRangeEnd = 294073, XrefRangeStart = 294072, XrefRangeEnd = 294072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueuePour(Vector3 worldSpacePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldSpacePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_QueuePour_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8D3 RID: 43219 RVA: 0x002A3020 File Offset: 0x002A1220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294073, RefRangeEnd = 294074, XrefRangeStart = 294073, XrefRangeEnd = 294073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNormalizedProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_GetNormalizedProgress_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A8D4 RID: 43220 RVA: 0x002A305C File Offset: 0x002A125C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294074, XrefRangeEnd = 294079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CheckQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_CheckQueue_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A8D5 RID: 43221 RVA: 0x002A309C File Offset: 0x002A129C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294079, XrefRangeEnd = 294094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_Blank_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8D6 RID: 43222 RVA: 0x002A30D0 File Offset: 0x002A12D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294094, XrefRangeEnd = 294106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DelayedApplyPour(Vector3 worldSpace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldSpace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_DelayedApplyPour_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8D7 RID: 43223 RVA: 0x002A3110 File Offset: 0x002A1310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294106, XrefRangeEnd = 294120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPour(Vector3 worldSpace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldSpace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_ApplyPour_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8D8 RID: 43224 RVA: 0x002A3150 File Offset: 0x002A1350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294121, RefRangeEnd = 294122, XrefRangeStart = 294120, XrefRangeEnd = 294121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPourMaskValue(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_GetPourMaskValue_Private_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A8D9 RID: 43225 RVA: 0x002A31A8 File Offset: 0x002A13A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294122, XrefRangeEnd = 294123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCoverage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_GetCoverage_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A8DA RID: 43226 RVA: 0x002A31E4 File Offset: 0x002A13E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294123, XrefRangeEnd = 294126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotSoilCover() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8DB RID: 43227 RVA: 0x000531F0 File Offset: 0x000513F0
		public PotSoilCover(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003423 RID: 13347
		// (get) Token: 0x0600A8DC RID: 43228 RVA: 0x002A3220 File Offset: 0x002A1420
		// (set) Token: 0x0600A8DD RID: 43229 RVA: 0x000531F9 File Offset: 0x000513F9
		public unsafe static int TEXTURE_SIZE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_TEXTURE_SIZE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_TEXTURE_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17003424 RID: 13348
		// (get) Token: 0x0600A8DE RID: 43230 RVA: 0x002A323C File Offset: 0x002A143C
		// (set) Token: 0x0600A8DF RID: 43231 RVA: 0x00053207 File Offset: 0x00051407
		public unsafe static int POUR_RADIUS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_POUR_RADIUS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_POUR_RADIUS, (void*)(&value));
			}
		}

		// Token: 0x17003425 RID: 13349
		// (get) Token: 0x0600A8E0 RID: 43232 RVA: 0x002A3258 File Offset: 0x002A1458
		// (set) Token: 0x0600A8E1 RID: 43233 RVA: 0x00053215 File Offset: 0x00051415
		public unsafe static int UPDATES_PER_SECOND
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_UPDATES_PER_SECOND, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_UPDATES_PER_SECOND, (void*)(&value));
			}
		}

		// Token: 0x17003426 RID: 13350
		// (get) Token: 0x0600A8E2 RID: 43234 RVA: 0x002A3274 File Offset: 0x002A1474
		// (set) Token: 0x0600A8E3 RID: 43235 RVA: 0x00053223 File Offset: 0x00051423
		public unsafe static float COVERAGE_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_COVERAGE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_COVERAGE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17003427 RID: 13351
		// (get) Token: 0x0600A8E4 RID: 43236 RVA: 0x002A3290 File Offset: 0x002A1490
		// (set) Token: 0x0600A8E5 RID: 43237 RVA: 0x00053231 File Offset: 0x00051431
		public unsafe static float BASE_COVERAGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_BASE_COVERAGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_BASE_COVERAGE, (void*)(&value));
			}
		}

		// Token: 0x17003428 RID: 13352
		// (get) Token: 0x0600A8E6 RID: 43238 RVA: 0x002A32AC File Offset: 0x002A14AC
		// (set) Token: 0x0600A8E7 RID: 43239 RVA: 0x0005323F File Offset: 0x0005143F
		public unsafe static float SUCCESS_COVERAGE_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_SUCCESS_COVERAGE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_SUCCESS_COVERAGE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17003429 RID: 13353
		// (get) Token: 0x0600A8E8 RID: 43240 RVA: 0x002A32C8 File Offset: 0x002A14C8
		// (set) Token: 0x0600A8E9 RID: 43241 RVA: 0x0005324D File Offset: 0x0005144D
		public unsafe static float DELAY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_DELAY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_DELAY, (void*)(&value));
			}
		}

		// Token: 0x1700342A RID: 13354
		// (get) Token: 0x0600A8EA RID: 43242 RVA: 0x002A32E4 File Offset: 0x002A14E4
		// (set) Token: 0x0600A8EB RID: 43243 RVA: 0x0005325B File Offset: 0x0005145B
		public unsafe float CurrentCoverage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_CurrentCoverage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_CurrentCoverage)) = value;
			}
		}

		// Token: 0x1700342B RID: 13355
		// (get) Token: 0x0600A8EC RID: 43244 RVA: 0x002A330C File Offset: 0x002A150C
		// (set) Token: 0x0600A8ED RID: 43245 RVA: 0x00053276 File Offset: 0x00051476
		public unsafe float Radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_Radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_Radius)) = value;
			}
		}

		// Token: 0x1700342C RID: 13356
		// (get) Token: 0x0600A8EE RID: 43246 RVA: 0x002A3334 File Offset: 0x002A1534
		// (set) Token: 0x0600A8EF RID: 43247 RVA: 0x00053291 File Offset: 0x00051491
		public unsafe MeshRenderer MeshRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_MeshRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_MeshRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700342D RID: 13357
		// (get) Token: 0x0600A8F0 RID: 43248 RVA: 0x002A3364 File Offset: 0x002A1564
		// (set) Token: 0x0600A8F1 RID: 43249 RVA: 0x000532B0 File Offset: 0x000514B0
		public unsafe Texture2D PourMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_PourMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_PourMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700342E RID: 13358
		// (get) Token: 0x0600A8F2 RID: 43250 RVA: 0x002A3394 File Offset: 0x002A1594
		// (set) Token: 0x0600A8F3 RID: 43251 RVA: 0x000532CF File Offset: 0x000514CF
		public unsafe UnityEvent onSufficientCoverage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_onSufficientCoverage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_onSufficientCoverage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700342F RID: 13359
		// (get) Token: 0x0600A8F4 RID: 43252 RVA: 0x002A33C4 File Offset: 0x002A15C4
		// (set) Token: 0x0600A8F5 RID: 43253 RVA: 0x000532EE File Offset: 0x000514EE
		public unsafe bool queued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_queued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_queued)) = value;
			}
		}

		// Token: 0x17003430 RID: 13360
		// (get) Token: 0x0600A8F6 RID: 43254 RVA: 0x002A33EC File Offset: 0x002A15EC
		// (set) Token: 0x0600A8F7 RID: 43255 RVA: 0x00053309 File Offset: 0x00051509
		public unsafe Vector3 queuedWorldPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_queuedWorldPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_queuedWorldPos)) = value;
			}
		}

		// Token: 0x17003431 RID: 13361
		// (get) Token: 0x0600A8F8 RID: 43256 RVA: 0x002A3414 File Offset: 0x002A1614
		// (set) Token: 0x0600A8F9 RID: 43257 RVA: 0x00053324 File Offset: 0x00051524
		public unsafe Texture2D mainTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_mainTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_mainTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003432 RID: 13362
		// (get) Token: 0x0600A8FA RID: 43258 RVA: 0x002A3444 File Offset: 0x002A1644
		// (set) Token: 0x0600A8FB RID: 43259 RVA: 0x00053343 File Offset: 0x00051543
		public unsafe Vector3 relative
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_relative);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_relative)) = value;
			}
		}

		// Token: 0x17003433 RID: 13363
		// (get) Token: 0x0600A8FC RID: 43260 RVA: 0x002A346C File Offset: 0x002A166C
		// (set) Token: 0x0600A8FD RID: 43261 RVA: 0x0005335E File Offset: 0x0005155E
		public unsafe Vector2 vector2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_vector2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_vector2)) = value;
			}
		}

		// Token: 0x17003434 RID: 13364
		// (get) Token: 0x0600A8FE RID: 43262 RVA: 0x002A3494 File Offset: 0x002A1694
		// (set) Token: 0x0600A8FF RID: 43263 RVA: 0x00053379 File Offset: 0x00051579
		public unsafe Vector2 normalizedOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_normalizedOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_normalizedOffset)) = value;
			}
		}

		// Token: 0x17003435 RID: 13365
		// (get) Token: 0x0600A900 RID: 43264 RVA: 0x002A34BC File Offset: 0x002A16BC
		// (set) Token: 0x0600A901 RID: 43265 RVA: 0x00053394 File Offset: 0x00051594
		public unsafe Vector2 originPixel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_originPixel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_originPixel)) = value;
			}
		}

		// Token: 0x04007151 RID: 29009
		private static readonly IntPtr NativeFieldInfoPtr_TEXTURE_SIZE;

		// Token: 0x04007152 RID: 29010
		private static readonly IntPtr NativeFieldInfoPtr_POUR_RADIUS;

		// Token: 0x04007153 RID: 29011
		private static readonly IntPtr NativeFieldInfoPtr_UPDATES_PER_SECOND;

		// Token: 0x04007154 RID: 29012
		private static readonly IntPtr NativeFieldInfoPtr_COVERAGE_THRESHOLD;

		// Token: 0x04007155 RID: 29013
		private static readonly IntPtr NativeFieldInfoPtr_BASE_COVERAGE;

		// Token: 0x04007156 RID: 29014
		private static readonly IntPtr NativeFieldInfoPtr_SUCCESS_COVERAGE_THRESHOLD;

		// Token: 0x04007157 RID: 29015
		private static readonly IntPtr NativeFieldInfoPtr_DELAY;

		// Token: 0x04007158 RID: 29016
		private static readonly IntPtr NativeFieldInfoPtr_CurrentCoverage;

		// Token: 0x04007159 RID: 29017
		private static readonly IntPtr NativeFieldInfoPtr_Radius;

		// Token: 0x0400715A RID: 29018
		private static readonly IntPtr NativeFieldInfoPtr_MeshRenderer;

		// Token: 0x0400715B RID: 29019
		private static readonly IntPtr NativeFieldInfoPtr_PourMask;

		// Token: 0x0400715C RID: 29020
		private static readonly IntPtr NativeFieldInfoPtr_onSufficientCoverage;

		// Token: 0x0400715D RID: 29021
		private static readonly IntPtr NativeFieldInfoPtr_queued;

		// Token: 0x0400715E RID: 29022
		private static readonly IntPtr NativeFieldInfoPtr_queuedWorldPos;

		// Token: 0x0400715F RID: 29023
		private static readonly IntPtr NativeFieldInfoPtr_mainTex;

		// Token: 0x04007160 RID: 29024
		private static readonly IntPtr NativeFieldInfoPtr_relative;

		// Token: 0x04007161 RID: 29025
		private static readonly IntPtr NativeFieldInfoPtr_vector2;

		// Token: 0x04007162 RID: 29026
		private static readonly IntPtr NativeFieldInfoPtr_normalizedOffset;

		// Token: 0x04007163 RID: 29027
		private static readonly IntPtr NativeFieldInfoPtr_originPixel;

		// Token: 0x04007164 RID: 29028
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007165 RID: 29029
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04007166 RID: 29030
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureAppearance_Public_Void_Color_Single_0;

		// Token: 0x04007167 RID: 29031
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04007168 RID: 29032
		private static readonly IntPtr NativeMethodInfoPtr_QueuePour_Public_Void_Vector3_0;

		// Token: 0x04007169 RID: 29033
		private static readonly IntPtr NativeMethodInfoPtr_GetNormalizedProgress_Public_Single_0;

		// Token: 0x0400716A RID: 29034
		private static readonly IntPtr NativeMethodInfoPtr_CheckQueue_Private_IEnumerator_0;

		// Token: 0x0400716B RID: 29035
		private static readonly IntPtr NativeMethodInfoPtr_Blank_Private_Void_0;

		// Token: 0x0400716C RID: 29036
		private static readonly IntPtr NativeMethodInfoPtr_DelayedApplyPour_Private_Void_Vector3_0;

		// Token: 0x0400716D RID: 29037
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPour_Private_Void_Vector3_0;

		// Token: 0x0400716E RID: 29038
		private static readonly IntPtr NativeMethodInfoPtr_GetPourMaskValue_Private_Single_Int32_Int32_0;

		// Token: 0x0400716F RID: 29039
		private static readonly IntPtr NativeMethodInfoPtr_GetCoverage_Private_Single_0;

		// Token: 0x04007170 RID: 29040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BDC RID: 3036
		[ObfuscatedName("ScheduleOne.ObjectScripts.PotSoilCover+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DED1 RID: 57041 RVA: 0x00348B78 File Offset: 0x00346D78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr);
				PotSoilCover.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				PotSoilCover.__c__DisplayClass27_0.NativeFieldInfoPtr_worldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr, "worldSpace");
				PotSoilCover.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr, 100683988);
				PotSoilCover.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr, 100683989);
			}

			// Token: 0x0600DED2 RID: 57042 RVA: 0x00348BF4 File Offset: 0x00346DF4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DED3 RID: 57043 RVA: 0x00348C30 File Offset: 0x00346E30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294009, XrefRangeEnd = 294014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DED4 RID: 57044 RVA: 0x0006CA35 File Offset: 0x0006AC35
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004511 RID: 17681
			// (get) Token: 0x0600DED5 RID: 57045 RVA: 0x00348C70 File Offset: 0x00346E70
			// (set) Token: 0x0600DED6 RID: 57046 RVA: 0x0006CA3E File Offset: 0x0006AC3E
			public unsafe PotSoilCover __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotSoilCover>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004512 RID: 17682
			// (get) Token: 0x0600DED7 RID: 57047 RVA: 0x00348CA0 File Offset: 0x00346EA0
			// (set) Token: 0x0600DED8 RID: 57048 RVA: 0x0006CA5D File Offset: 0x0006AC5D
			public unsafe Vector3 worldSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.NativeFieldInfoPtr_worldSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.NativeFieldInfoPtr_worldSpace)) = value;
				}
			}

			// Token: 0x04009531 RID: 38193
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009532 RID: 38194
			private static readonly IntPtr NativeFieldInfoPtr_worldSpace;

			// Token: 0x04009533 RID: 38195
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009534 RID: 38196
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C87 RID: 3207
			[ObfuscatedName("ScheduleOne.ObjectScripts.PotSoilCover+<>c__DisplayClass27_0+<<DelayedApplyPour>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E6EC RID: 59116 RVA: 0x00360474 File Offset: 0x0035E674
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr, "<<DelayedApplyPour>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683990);
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683991);
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683992);
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683993);
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683994);
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683995);
				}

				// Token: 0x0600E6ED RID: 59117 RVA: 0x00360554 File Offset: 0x0035E754
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E6EE RID: 59118 RVA: 0x0036059C File Offset: 0x0035E79C
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E6EF RID: 59119 RVA: 0x003605D0 File Offset: 0x0035E7D0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293999, XrefRangeEnd = 294004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170047EF RID: 18415
				// (get) Token: 0x0600E6F0 RID: 59120 RVA: 0x0036060C File Offset: 0x0035E80C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E6F1 RID: 59121 RVA: 0x0036064C File Offset: 0x0035E84C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294004, XrefRangeEnd = 294009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170047F0 RID: 18416
				// (get) Token: 0x0600E6F2 RID: 59122 RVA: 0x00360680 File Offset: 0x0035E880
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E6F3 RID: 59123 RVA: 0x00070BD6 File Offset: 0x0006EDD6
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047EC RID: 18412
				// (get) Token: 0x0600E6F4 RID: 59124 RVA: 0x003606C0 File Offset: 0x0035E8C0
				// (set) Token: 0x0600E6F5 RID: 59125 RVA: 0x00070BDF File Offset: 0x0006EDDF
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047ED RID: 18413
				// (get) Token: 0x0600E6F6 RID: 59126 RVA: 0x003606E8 File Offset: 0x0035E8E8
				// (set) Token: 0x0600E6F7 RID: 59127 RVA: 0x00070BFA File Offset: 0x0006EDFA
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047EE RID: 18414
				// (get) Token: 0x0600E6F8 RID: 59128 RVA: 0x00360718 File Offset: 0x0035E918
				// (set) Token: 0x0600E6F9 RID: 59129 RVA: 0x00070C19 File Offset: 0x0006EE19
				public unsafe PotSoilCover.__c__DisplayClass27_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotSoilCover.__c__DisplayClass27_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009A50 RID: 39504
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009A51 RID: 39505
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009A52 RID: 39506
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009A53 RID: 39507
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009A54 RID: 39508
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A55 RID: 39509
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009A56 RID: 39510
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009A57 RID: 39511
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A58 RID: 39512
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BDD RID: 3037
		[ObfuscatedName("ScheduleOne.ObjectScripts.PotSoilCover+<CheckQueue>d__25")]
		public sealed class _CheckQueue_d__25 : Il2CppSystem.Object
		{
			// Token: 0x0600DED9 RID: 57049 RVA: 0x00348CC8 File Offset: 0x00346EC8
			// Note: this type is marked as 'beforefieldinit'.
			static _CheckQueue_d__25()
			{
				Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "<CheckQueue>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr);
				PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, "<>1__state");
				PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, "<>2__current");
				PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, "<>4__this");
				PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, 100683996);
				PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, 100683997);
				PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, 100683998);
				PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, 100683999);
				PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, 100684000);
				PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, 100684001);
			}

			// Token: 0x0600DEDA RID: 57050 RVA: 0x00348DA8 File Offset: 0x00346FA8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CheckQueue_d__25(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEDB RID: 57051 RVA: 0x00348DF0 File Offset: 0x00346FF0
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEDC RID: 57052 RVA: 0x00348E24 File Offset: 0x00347024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294014, XrefRangeEnd = 294036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004516 RID: 17686
			// (get) Token: 0x0600DEDD RID: 57053 RVA: 0x00348E60 File Offset: 0x00347060
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DEDE RID: 57054 RVA: 0x00348EA0 File Offset: 0x003470A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294036, XrefRangeEnd = 294041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004517 RID: 17687
			// (get) Token: 0x0600DEDF RID: 57055 RVA: 0x00348ED4 File Offset: 0x003470D4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DEE0 RID: 57056 RVA: 0x0006CA78 File Offset: 0x0006AC78
			public _CheckQueue_d__25(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004513 RID: 17683
			// (get) Token: 0x0600DEE1 RID: 57057 RVA: 0x00348F14 File Offset: 0x00347114
			// (set) Token: 0x0600DEE2 RID: 57058 RVA: 0x0006CA81 File Offset: 0x0006AC81
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004514 RID: 17684
			// (get) Token: 0x0600DEE3 RID: 57059 RVA: 0x00348F3C File Offset: 0x0034713C
			// (set) Token: 0x0600DEE4 RID: 57060 RVA: 0x0006CA9C File Offset: 0x0006AC9C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004515 RID: 17685
			// (get) Token: 0x0600DEE5 RID: 57061 RVA: 0x00348F6C File Offset: 0x0034716C
			// (set) Token: 0x0600DEE6 RID: 57062 RVA: 0x0006CABB File Offset: 0x0006ACBB
			public unsafe PotSoilCover __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotSoilCover>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009535 RID: 38197
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009536 RID: 38198
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009537 RID: 38199
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009538 RID: 38200
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009539 RID: 38201
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400953A RID: 38202
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400953B RID: 38203
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400953C RID: 38204
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400953D RID: 38205
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
