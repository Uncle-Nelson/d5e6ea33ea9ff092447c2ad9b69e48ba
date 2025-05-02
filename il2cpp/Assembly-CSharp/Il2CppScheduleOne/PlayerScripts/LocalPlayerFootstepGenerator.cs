using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Materials;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003E1 RID: 993
	public class LocalPlayerFootstepGenerator : MonoBehaviour
	{
		// Token: 0x06004CBE RID: 19646 RVA: 0x001707AC File Offset: 0x0016E9AC
		// Note: this type is marked as 'beforefieldinit'.
		static LocalPlayerFootstepGenerator()
		{
			Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "LocalPlayerFootstepGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr);
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_DistancePerStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "DistancePerStep");
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_ReferencePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "ReferencePoint");
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_GroundDetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "GroundDetectionMask");
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_onStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "onStep");
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_currentDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "currentDistance");
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "lastFramePosition");
			LocalPlayerFootstepGenerator.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, 100672768);
			LocalPlayerFootstepGenerator.NativeMethodInfoPtr_TriggerStep_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, 100672769);
			LocalPlayerFootstepGenerator.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_EMaterialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, 100672770);
			LocalPlayerFootstepGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, 100672771);
		}

		// Token: 0x06004CBF RID: 19647 RVA: 0x001708A4 File Offset: 0x0016EAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166071, XrefRangeEnd = 166096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerFootstepGenerator.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CC0 RID: 19648 RVA: 0x001708D8 File Offset: 0x0016EAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166096, XrefRangeEnd = 166105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerStep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerFootstepGenerator.NativeMethodInfoPtr_TriggerStep_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CC1 RID: 19649 RVA: 0x0017090C File Offset: 0x0016EB0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166117, RefRangeEnd = 166119, XrefRangeStart = 166105, XrefRangeEnd = 166117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGrounded(out EMaterialType surfaceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &surfaceType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerFootstepGenerator.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_EMaterialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004CC2 RID: 19650 RVA: 0x00170958 File Offset: 0x0016EB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166119, XrefRangeEnd = 166129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalPlayerFootstepGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerFootstepGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CC3 RID: 19651 RVA: 0x00024EA4 File Offset: 0x000230A4
		public LocalPlayerFootstepGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x06004CC4 RID: 19652 RVA: 0x00170994 File Offset: 0x0016EB94
		// (set) Token: 0x06004CC5 RID: 19653 RVA: 0x00024EAD File Offset: 0x000230AD
		public unsafe float DistancePerStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_DistancePerStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_DistancePerStep)) = value;
			}
		}

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x06004CC6 RID: 19654 RVA: 0x001709BC File Offset: 0x0016EBBC
		// (set) Token: 0x06004CC7 RID: 19655 RVA: 0x00024EC8 File Offset: 0x000230C8
		public unsafe Transform ReferencePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_ReferencePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_ReferencePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x06004CC8 RID: 19656 RVA: 0x001709EC File Offset: 0x0016EBEC
		// (set) Token: 0x06004CC9 RID: 19657 RVA: 0x00024EE7 File Offset: 0x000230E7
		public unsafe LayerMask GroundDetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_GroundDetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_GroundDetectionMask)) = value;
			}
		}

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x06004CCA RID: 19658 RVA: 0x00170A14 File Offset: 0x0016EC14
		// (set) Token: 0x06004CCB RID: 19659 RVA: 0x00024F02 File Offset: 0x00023102
		public unsafe UnityEvent<EMaterialType, float> onStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_onStep);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EMaterialType, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_onStep), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x06004CCC RID: 19660 RVA: 0x00170A44 File Offset: 0x0016EC44
		// (set) Token: 0x06004CCD RID: 19661 RVA: 0x00024F21 File Offset: 0x00023121
		public unsafe float currentDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_currentDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_currentDistance)) = value;
			}
		}

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x06004CCE RID: 19662 RVA: 0x00170A6C File Offset: 0x0016EC6C
		// (set) Token: 0x06004CCF RID: 19663 RVA: 0x00024F3C File Offset: 0x0002313C
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x040033AC RID: 13228
		private static readonly IntPtr NativeFieldInfoPtr_DistancePerStep;

		// Token: 0x040033AD RID: 13229
		private static readonly IntPtr NativeFieldInfoPtr_ReferencePoint;

		// Token: 0x040033AE RID: 13230
		private static readonly IntPtr NativeFieldInfoPtr_GroundDetectionMask;

		// Token: 0x040033AF RID: 13231
		private static readonly IntPtr NativeFieldInfoPtr_onStep;

		// Token: 0x040033B0 RID: 13232
		private static readonly IntPtr NativeFieldInfoPtr_currentDistance;

		// Token: 0x040033B1 RID: 13233
		private static readonly IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x040033B2 RID: 13234
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040033B3 RID: 13235
		private static readonly IntPtr NativeMethodInfoPtr_TriggerStep_Public_Void_0;

		// Token: 0x040033B4 RID: 13236
		private static readonly IntPtr NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_EMaterialType_0;

		// Token: 0x040033B5 RID: 13237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
