using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x0200077A RID: 1914
	public class Gate : MonoBehaviour
	{
		// Token: 0x0600B556 RID: 46422 RVA: 0x002D196C File Offset: 0x002CFB6C
		// Note: this type is marked as 'beforefieldinit'.
		static Gate()
		{
			Il2CppClassPointerStore<Gate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "Gate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gate>.NativeClassPtr);
			Gate.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "<IsOpen>k__BackingField");
			Gate.NativeFieldInfoPtr_Gate1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate1");
			Gate.NativeFieldInfoPtr_Gate1Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate1Open");
			Gate.NativeFieldInfoPtr_Gate1Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate1Closed");
			Gate.NativeFieldInfoPtr_Gate2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate2");
			Gate.NativeFieldInfoPtr_Gate2Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate2Open");
			Gate.NativeFieldInfoPtr_Gate2Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate2Closed");
			Gate.NativeFieldInfoPtr_OpenSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "OpenSpeed");
			Gate.NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Acceleration");
			Gate.NativeFieldInfoPtr_StartSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "StartSounds");
			Gate.NativeFieldInfoPtr_LoopSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "LoopSounds");
			Gate.NativeFieldInfoPtr_StopSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "StopSounds");
			Gate.NativeFieldInfoPtr_Momentum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Momentum");
			Gate.NativeFieldInfoPtr_openDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "openDelta");
			Gate.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100685596);
			Gate.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100685597);
			Gate.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100685598);
			Gate.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100685599);
			Gate.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100685600);
			Gate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100685601);
		}

		// Token: 0x17003843 RID: 14403
		// (get) Token: 0x0600B557 RID: 46423 RVA: 0x002D1B2C File Offset: 0x002CFD2C
		// (set) Token: 0x0600B558 RID: 46424 RVA: 0x002D1B68 File Offset: 0x002CFD68
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B559 RID: 46425 RVA: 0x002D1BA8 File Offset: 0x002CFDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310392, XrefRangeEnd = 310411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B55A RID: 46426 RVA: 0x002D1BDC File Offset: 0x002CFDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310411, XrefRangeEnd = 310412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B55B RID: 46427 RVA: 0x002D1C10 File Offset: 0x002CFE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310412, XrefRangeEnd = 310413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B55C RID: 46428 RVA: 0x002D1C44 File Offset: 0x002CFE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310413, XrefRangeEnd = 310414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Gate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Gate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B55D RID: 46429 RVA: 0x00058F8E File Offset: 0x0005718E
		public Gate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003835 RID: 14389
		// (get) Token: 0x0600B55E RID: 46430 RVA: 0x002D1C80 File Offset: 0x002CFE80
		// (set) Token: 0x0600B55F RID: 46431 RVA: 0x00058F97 File Offset: 0x00057197
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003836 RID: 14390
		// (get) Token: 0x0600B560 RID: 46432 RVA: 0x002D1CA8 File Offset: 0x002CFEA8
		// (set) Token: 0x0600B561 RID: 46433 RVA: 0x00058FB2 File Offset: 0x000571B2
		public unsafe Transform Gate1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003837 RID: 14391
		// (get) Token: 0x0600B562 RID: 46434 RVA: 0x002D1CD8 File Offset: 0x002CFED8
		// (set) Token: 0x0600B563 RID: 46435 RVA: 0x00058FD1 File Offset: 0x000571D1
		public unsafe Vector3 Gate1Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1Open)) = value;
			}
		}

		// Token: 0x17003838 RID: 14392
		// (get) Token: 0x0600B564 RID: 46436 RVA: 0x002D1D00 File Offset: 0x002CFF00
		// (set) Token: 0x0600B565 RID: 46437 RVA: 0x00058FEC File Offset: 0x000571EC
		public unsafe Vector3 Gate1Closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1Closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1Closed)) = value;
			}
		}

		// Token: 0x17003839 RID: 14393
		// (get) Token: 0x0600B566 RID: 46438 RVA: 0x002D1D28 File Offset: 0x002CFF28
		// (set) Token: 0x0600B567 RID: 46439 RVA: 0x00059007 File Offset: 0x00057207
		public unsafe Transform Gate2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700383A RID: 14394
		// (get) Token: 0x0600B568 RID: 46440 RVA: 0x002D1D58 File Offset: 0x002CFF58
		// (set) Token: 0x0600B569 RID: 46441 RVA: 0x00059026 File Offset: 0x00057226
		public unsafe Vector3 Gate2Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2Open)) = value;
			}
		}

		// Token: 0x1700383B RID: 14395
		// (get) Token: 0x0600B56A RID: 46442 RVA: 0x002D1D80 File Offset: 0x002CFF80
		// (set) Token: 0x0600B56B RID: 46443 RVA: 0x00059041 File Offset: 0x00057241
		public unsafe Vector3 Gate2Closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2Closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2Closed)) = value;
			}
		}

		// Token: 0x1700383C RID: 14396
		// (get) Token: 0x0600B56C RID: 46444 RVA: 0x002D1DA8 File Offset: 0x002CFFA8
		// (set) Token: 0x0600B56D RID: 46445 RVA: 0x0005905C File Offset: 0x0005725C
		public unsafe float OpenSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_OpenSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_OpenSpeed)) = value;
			}
		}

		// Token: 0x1700383D RID: 14397
		// (get) Token: 0x0600B56E RID: 46446 RVA: 0x002D1DD0 File Offset: 0x002CFFD0
		// (set) Token: 0x0600B56F RID: 46447 RVA: 0x00059077 File Offset: 0x00057277
		public unsafe float Acceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Acceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Acceleration)) = value;
			}
		}

		// Token: 0x1700383E RID: 14398
		// (get) Token: 0x0600B570 RID: 46448 RVA: 0x002D1DF8 File Offset: 0x002CFFF8
		// (set) Token: 0x0600B571 RID: 46449 RVA: 0x00059092 File Offset: 0x00057292
		public unsafe Il2CppReferenceArray<AudioSourceController> StartSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_StartSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_StartSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700383F RID: 14399
		// (get) Token: 0x0600B572 RID: 46450 RVA: 0x002D1E28 File Offset: 0x002D0028
		// (set) Token: 0x0600B573 RID: 46451 RVA: 0x000590B1 File Offset: 0x000572B1
		public unsafe Il2CppReferenceArray<AudioSourceController> LoopSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_LoopSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_LoopSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003840 RID: 14400
		// (get) Token: 0x0600B574 RID: 46452 RVA: 0x002D1E58 File Offset: 0x002D0058
		// (set) Token: 0x0600B575 RID: 46453 RVA: 0x000590D0 File Offset: 0x000572D0
		public unsafe Il2CppReferenceArray<AudioSourceController> StopSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_StopSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_StopSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003841 RID: 14401
		// (get) Token: 0x0600B576 RID: 46454 RVA: 0x002D1E88 File Offset: 0x002D0088
		// (set) Token: 0x0600B577 RID: 46455 RVA: 0x000590EF File Offset: 0x000572EF
		public unsafe float Momentum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Momentum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Momentum)) = value;
			}
		}

		// Token: 0x17003842 RID: 14402
		// (get) Token: 0x0600B578 RID: 46456 RVA: 0x002D1EB0 File Offset: 0x002D00B0
		// (set) Token: 0x0600B579 RID: 46457 RVA: 0x0005910A File Offset: 0x0005730A
		public unsafe float openDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_openDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_openDelta)) = value;
			}
		}

		// Token: 0x04007A38 RID: 31288
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04007A39 RID: 31289
		private static readonly IntPtr NativeFieldInfoPtr_Gate1;

		// Token: 0x04007A3A RID: 31290
		private static readonly IntPtr NativeFieldInfoPtr_Gate1Open;

		// Token: 0x04007A3B RID: 31291
		private static readonly IntPtr NativeFieldInfoPtr_Gate1Closed;

		// Token: 0x04007A3C RID: 31292
		private static readonly IntPtr NativeFieldInfoPtr_Gate2;

		// Token: 0x04007A3D RID: 31293
		private static readonly IntPtr NativeFieldInfoPtr_Gate2Open;

		// Token: 0x04007A3E RID: 31294
		private static readonly IntPtr NativeFieldInfoPtr_Gate2Closed;

		// Token: 0x04007A3F RID: 31295
		private static readonly IntPtr NativeFieldInfoPtr_OpenSpeed;

		// Token: 0x04007A40 RID: 31296
		private static readonly IntPtr NativeFieldInfoPtr_Acceleration;

		// Token: 0x04007A41 RID: 31297
		private static readonly IntPtr NativeFieldInfoPtr_StartSounds;

		// Token: 0x04007A42 RID: 31298
		private static readonly IntPtr NativeFieldInfoPtr_LoopSounds;

		// Token: 0x04007A43 RID: 31299
		private static readonly IntPtr NativeFieldInfoPtr_StopSounds;

		// Token: 0x04007A44 RID: 31300
		private static readonly IntPtr NativeFieldInfoPtr_Momentum;

		// Token: 0x04007A45 RID: 31301
		private static readonly IntPtr NativeFieldInfoPtr_openDelta;

		// Token: 0x04007A46 RID: 31302
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007A47 RID: 31303
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04007A48 RID: 31304
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007A49 RID: 31305
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04007A4A RID: 31306
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007A4B RID: 31307
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
