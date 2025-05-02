using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Misc;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003B7 RID: 951
	public class LightTimer : MonoBehaviour
	{
		// Token: 0x06004A11 RID: 18961 RVA: 0x00167FA4 File Offset: 0x001661A4
		// Note: this type is marked as 'beforefieldinit'.
		static LightTimer()
		{
			Il2CppClassPointerStore<LightTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "LightTimer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightTimer>.NativeClassPtr);
			LightTimer.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, "StartTime");
			LightTimer.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, "EndTime");
			LightTimer.NativeFieldInfoPtr_StartTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, "StartTimeOffset");
			LightTimer.NativeFieldInfoPtr_toggleableLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, "toggleableLight");
			LightTimer.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100672481);
			LightTimer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100672482);
			LightTimer.NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100672483);
			LightTimer.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100672484);
			LightTimer.NativeMethodInfoPtr_SetState_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100672485);
			LightTimer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100672486);
		}

		// Token: 0x06004A12 RID: 18962 RVA: 0x0016809C File Offset: 0x0016629C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163843, XrefRangeEnd = 163863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightTimer.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x001680D8 File Offset: 0x001662D8
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightTimer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A14 RID: 18964 RVA: 0x0016810C File Offset: 0x0016630C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163863, XrefRangeEnd = 163868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightTimer.NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x00168148 File Offset: 0x00166348
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightTimer.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A16 RID: 18966 RVA: 0x0016817C File Offset: 0x0016637C
		[CallerCount(0)]
		public unsafe void SetState(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightTimer.NativeMethodInfoPtr_SetState_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x001681BC File Offset: 0x001663BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightTimer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightTimer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightTimer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x00023B24 File Offset: 0x00021D24
		public LightTimer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x06004A19 RID: 18969 RVA: 0x001681F8 File Offset: 0x001663F8
		// (set) Token: 0x06004A1A RID: 18970 RVA: 0x00023B2D File Offset: 0x00021D2D
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06004A1B RID: 18971 RVA: 0x00168220 File Offset: 0x00166420
		// (set) Token: 0x06004A1C RID: 18972 RVA: 0x00023B48 File Offset: 0x00021D48
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x06004A1D RID: 18973 RVA: 0x00168248 File Offset: 0x00166448
		// (set) Token: 0x06004A1E RID: 18974 RVA: 0x00023B63 File Offset: 0x00021D63
		public unsafe int StartTimeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_StartTimeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_StartTimeOffset)) = value;
			}
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x06004A1F RID: 18975 RVA: 0x00168270 File Offset: 0x00166470
		// (set) Token: 0x06004A20 RID: 18976 RVA: 0x00023B7E File Offset: 0x00021D7E
		public unsafe ToggleableLight toggleableLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_toggleableLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_toggleableLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031EC RID: 12780
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x040031ED RID: 12781
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x040031EE RID: 12782
		private static readonly IntPtr NativeFieldInfoPtr_StartTimeOffset;

		// Token: 0x040031EF RID: 12783
		private static readonly IntPtr NativeFieldInfoPtr_toggleableLight;

		// Token: 0x040031F0 RID: 12784
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040031F1 RID: 12785
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040031F2 RID: 12786
		private static readonly IntPtr NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0;

		// Token: 0x040031F3 RID: 12787
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x040031F4 RID: 12788
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Private_Void_Boolean_0;

		// Token: 0x040031F5 RID: 12789
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
