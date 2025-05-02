using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F5 RID: 1525
	public class Eye : MonoBehaviour
	{
		// Token: 0x06008637 RID: 34359 RVA: 0x00238740 File Offset: 0x00236940
		// Note: this type is marked as 'beforefieldinit'.
		static Eye()
		{
			Il2CppClassPointerStore<Eye>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Eye");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye>.NativeClassPtr);
			Eye.NativeFieldInfoPtr_PupilLookSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "PupilLookSpeed");
			Eye.NativeFieldInfoPtr_defaultScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "defaultScale");
			Eye.NativeFieldInfoPtr_maxRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "maxRotation");
			Eye.NativeFieldInfoPtr_minRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "minRotation");
			Eye.NativeFieldInfoPtr__CurrentConfiguration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "<CurrentConfiguration>k__BackingField");
			Eye.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "Container");
			Eye.NativeFieldInfoPtr_TopLidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "TopLidContainer");
			Eye.NativeFieldInfoPtr_BottomLidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "BottomLidContainer");
			Eye.NativeFieldInfoPtr_PupilContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "PupilContainer");
			Eye.NativeFieldInfoPtr_TopLidRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "TopLidRend");
			Eye.NativeFieldInfoPtr_BottomLidRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "BottomLidRend");
			Eye.NativeFieldInfoPtr_EyeBallRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "EyeBallRend");
			Eye.NativeFieldInfoPtr_EyeLookOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "EyeLookOrigin");
			Eye.NativeFieldInfoPtr_EyeLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "EyeLight");
			Eye.NativeFieldInfoPtr_PupilRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "PupilRend");
			Eye.NativeFieldInfoPtr_blinkRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "blinkRoutine");
			Eye.NativeFieldInfoPtr_stateRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "stateRoutine");
			Eye.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "avatar");
			Eye.NativeFieldInfoPtr_defaultEyeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "defaultEyeColor");
			Eye.NativeFieldInfoPtr_AngleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "AngleOffset");
			Eye.NativeMethodInfoPtr_get_CurrentConfiguration_Public_get_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680060);
			Eye.NativeMethodInfoPtr_set_CurrentConfiguration_Protected_set_Void_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680061);
			Eye.NativeMethodInfoPtr_get_IsBlinking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680062);
			Eye.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680063);
			Eye.NativeMethodInfoPtr_SetSize_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680064);
			Eye.NativeMethodInfoPtr_SetLidColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680065);
			Eye.NativeMethodInfoPtr_SetEyeballMaterial_Public_Void_Material_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680066);
			Eye.NativeMethodInfoPtr_SetEyeballColor_Public_Void_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680067);
			Eye.NativeMethodInfoPtr_ResetEyeballColor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680068);
			Eye.NativeMethodInfoPtr_ConfigureEyeLight_Public_Void_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680069);
			Eye.NativeMethodInfoPtr_SetDilation_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680070);
			Eye.NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680071);
			Eye.NativeMethodInfoPtr_StopExistingRoutines_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680072);
			Eye.NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680073);
			Eye.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680074);
			Eye.NativeMethodInfoPtr_Blink_Public_Void_Single_EyeLidConfiguration_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680075);
			Eye.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680076);
		}

		// Token: 0x170028D7 RID: 10455
		// (get) Token: 0x06008638 RID: 34360 RVA: 0x00238A54 File Offset: 0x00236C54
		// (set) Token: 0x06008639 RID: 34361 RVA: 0x00238A90 File Offset: 0x00236C90
		public unsafe Eye.EyeLidConfiguration CurrentConfiguration
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 54193, RefRangeEnd = 54194, XrefRangeStart = 54193, XrefRangeEnd = 54194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_get_CurrentConfiguration_Public_get_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_set_CurrentConfiguration_Protected_set_Void_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170028D8 RID: 10456
		// (get) Token: 0x0600863A RID: 34362 RVA: 0x00238AD0 File Offset: 0x00236CD0
		public unsafe bool IsBlinking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_get_IsBlinking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600863B RID: 34363 RVA: 0x00238B0C File Offset: 0x00236D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250947, XrefRangeEnd = 250951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600863C RID: 34364 RVA: 0x00238B40 File Offset: 0x00236D40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250956, RefRangeEnd = 250958, XrefRangeStart = 250951, XrefRangeEnd = 250956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSize(float size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetSize_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600863D RID: 34365 RVA: 0x00238B80 File Offset: 0x00236D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250958, XrefRangeEnd = 250962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLidColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetLidColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600863E RID: 34366 RVA: 0x00238BC0 File Offset: 0x00236DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250962, XrefRangeEnd = 250964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeballMaterial(Material mat, Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetEyeballMaterial_Public_Void_Material_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600863F RID: 34367 RVA: 0x00238C10 File Offset: 0x00236E10
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 250970, RefRangeEnd = 250982, XrefRangeStart = 250964, XrefRangeEnd = 250970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeballColor(Color col, float emission = 0.115f, bool writeDefault = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref emission;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeDefault;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetEyeballColor_Public_Void_Color_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008640 RID: 34368 RVA: 0x00238C6C File Offset: 0x00236E6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 250988, RefRangeEnd = 250992, XrefRangeStart = 250982, XrefRangeEnd = 250988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetEyeballColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_ResetEyeballColor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008641 RID: 34369 RVA: 0x00238CA0 File Offset: 0x00236EA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 251001, RefRangeEnd = 251003, XrefRangeStart = 250992, XrefRangeEnd = 251001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureEyeLight(Color color, float intensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_ConfigureEyeLight_Public_Void_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008642 RID: 34370 RVA: 0x00238CEC File Offset: 0x00236EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251003, XrefRangeEnd = 251005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDilation(float dil)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dil;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetDilation_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008643 RID: 34371 RVA: 0x00238D2C File Offset: 0x00236F2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 251026, RefRangeEnd = 251028, XrefRangeStart = 251005, XrefRangeEnd = 251026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeLidState(Eye.EyeLidConfiguration config, float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref config;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008644 RID: 34372 RVA: 0x00238D78 File Offset: 0x00236F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251028, XrefRangeEnd = 251030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopExistingRoutines()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_StopExistingRoutines_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008645 RID: 34373 RVA: 0x00238DAC File Offset: 0x00236FAC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 251059, RefRangeEnd = 251069, XrefRangeStart = 251030, XrefRangeEnd = 251059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeLidState(Eye.EyeLidConfiguration config, bool debug = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref config;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref debug;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008646 RID: 34374 RVA: 0x00238DF8 File Offset: 0x00236FF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 251097, RefRangeEnd = 251099, XrefRangeStart = 251069, XrefRangeEnd = 251097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 position, bool instant = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instant;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008647 RID: 34375 RVA: 0x00238E44 File Offset: 0x00237044
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 251123, RefRangeEnd = 251129, XrefRangeStart = 251099, XrefRangeEnd = 251123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blink(float blinkDuration, Eye.EyeLidConfiguration endState, bool debug = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blinkDuration;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endState;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref debug;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_Blink_Public_Void_Single_EyeLidConfiguration_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008648 RID: 34376 RVA: 0x00238EA0 File Offset: 0x002370A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251129, XrefRangeEnd = 251132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Eye() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008649 RID: 34377 RVA: 0x0003FC46 File Offset: 0x0003DE46
		public Eye(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028C3 RID: 10435
		// (get) Token: 0x0600864A RID: 34378 RVA: 0x00238EDC File Offset: 0x002370DC
		// (set) Token: 0x0600864B RID: 34379 RVA: 0x0003FC4F File Offset: 0x0003DE4F
		public unsafe static float PupilLookSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Eye.NativeFieldInfoPtr_PupilLookSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eye.NativeFieldInfoPtr_PupilLookSpeed, (void*)(&value));
			}
		}

		// Token: 0x170028C4 RID: 10436
		// (get) Token: 0x0600864C RID: 34380 RVA: 0x00238EF8 File Offset: 0x002370F8
		// (set) Token: 0x0600864D RID: 34381 RVA: 0x0003FC5D File Offset: 0x0003DE5D
		public unsafe static Vector3 defaultScale
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Eye.NativeFieldInfoPtr_defaultScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eye.NativeFieldInfoPtr_defaultScale, (void*)(&value));
			}
		}

		// Token: 0x170028C5 RID: 10437
		// (get) Token: 0x0600864E RID: 34382 RVA: 0x00238F14 File Offset: 0x00237114
		// (set) Token: 0x0600864F RID: 34383 RVA: 0x0003FC6B File Offset: 0x0003DE6B
		public unsafe static Vector3 maxRotation
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Eye.NativeFieldInfoPtr_maxRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eye.NativeFieldInfoPtr_maxRotation, (void*)(&value));
			}
		}

		// Token: 0x170028C6 RID: 10438
		// (get) Token: 0x06008650 RID: 34384 RVA: 0x00238F30 File Offset: 0x00237130
		// (set) Token: 0x06008651 RID: 34385 RVA: 0x0003FC79 File Offset: 0x0003DE79
		public unsafe static Vector3 minRotation
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Eye.NativeFieldInfoPtr_minRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eye.NativeFieldInfoPtr_minRotation, (void*)(&value));
			}
		}

		// Token: 0x170028C7 RID: 10439
		// (get) Token: 0x06008652 RID: 34386 RVA: 0x00238F4C File Offset: 0x0023714C
		// (set) Token: 0x06008653 RID: 34387 RVA: 0x0003FC87 File Offset: 0x0003DE87
		public unsafe Eye.EyeLidConfiguration _CurrentConfiguration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr__CurrentConfiguration_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr__CurrentConfiguration_k__BackingField)) = value;
			}
		}

		// Token: 0x170028C8 RID: 10440
		// (get) Token: 0x06008654 RID: 34388 RVA: 0x00238F74 File Offset: 0x00237174
		// (set) Token: 0x06008655 RID: 34389 RVA: 0x0003FCA2 File Offset: 0x0003DEA2
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C9 RID: 10441
		// (get) Token: 0x06008656 RID: 34390 RVA: 0x00238FA4 File Offset: 0x002371A4
		// (set) Token: 0x06008657 RID: 34391 RVA: 0x0003FCC1 File Offset: 0x0003DEC1
		public unsafe Transform TopLidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_TopLidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_TopLidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028CA RID: 10442
		// (get) Token: 0x06008658 RID: 34392 RVA: 0x00238FD4 File Offset: 0x002371D4
		// (set) Token: 0x06008659 RID: 34393 RVA: 0x0003FCE0 File Offset: 0x0003DEE0
		public unsafe Transform BottomLidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_BottomLidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_BottomLidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028CB RID: 10443
		// (get) Token: 0x0600865A RID: 34394 RVA: 0x00239004 File Offset: 0x00237204
		// (set) Token: 0x0600865B RID: 34395 RVA: 0x0003FCFF File Offset: 0x0003DEFF
		public unsafe Transform PupilContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_PupilContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_PupilContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028CC RID: 10444
		// (get) Token: 0x0600865C RID: 34396 RVA: 0x00239034 File Offset: 0x00237234
		// (set) Token: 0x0600865D RID: 34397 RVA: 0x0003FD1E File Offset: 0x0003DF1E
		public unsafe MeshRenderer TopLidRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_TopLidRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_TopLidRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028CD RID: 10445
		// (get) Token: 0x0600865E RID: 34398 RVA: 0x00239064 File Offset: 0x00237264
		// (set) Token: 0x0600865F RID: 34399 RVA: 0x0003FD3D File Offset: 0x0003DF3D
		public unsafe MeshRenderer BottomLidRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_BottomLidRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_BottomLidRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028CE RID: 10446
		// (get) Token: 0x06008660 RID: 34400 RVA: 0x00239094 File Offset: 0x00237294
		// (set) Token: 0x06008661 RID: 34401 RVA: 0x0003FD5C File Offset: 0x0003DF5C
		public unsafe MeshRenderer EyeBallRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeBallRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeBallRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028CF RID: 10447
		// (get) Token: 0x06008662 RID: 34402 RVA: 0x002390C4 File Offset: 0x002372C4
		// (set) Token: 0x06008663 RID: 34403 RVA: 0x0003FD7B File Offset: 0x0003DF7B
		public unsafe Transform EyeLookOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeLookOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeLookOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028D0 RID: 10448
		// (get) Token: 0x06008664 RID: 34404 RVA: 0x002390F4 File Offset: 0x002372F4
		// (set) Token: 0x06008665 RID: 34405 RVA: 0x0003FD9A File Offset: 0x0003DF9A
		public unsafe OptimizedLight EyeLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028D1 RID: 10449
		// (get) Token: 0x06008666 RID: 34406 RVA: 0x00239124 File Offset: 0x00237324
		// (set) Token: 0x06008667 RID: 34407 RVA: 0x0003FDB9 File Offset: 0x0003DFB9
		public unsafe SkinnedMeshRenderer PupilRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_PupilRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_PupilRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028D2 RID: 10450
		// (get) Token: 0x06008668 RID: 34408 RVA: 0x00239154 File Offset: 0x00237354
		// (set) Token: 0x06008669 RID: 34409 RVA: 0x0003FDD8 File Offset: 0x0003DFD8
		public unsafe Coroutine blinkRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_blinkRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_blinkRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028D3 RID: 10451
		// (get) Token: 0x0600866A RID: 34410 RVA: 0x00239184 File Offset: 0x00237384
		// (set) Token: 0x0600866B RID: 34411 RVA: 0x0003FDF7 File Offset: 0x0003DFF7
		public unsafe Coroutine stateRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_stateRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_stateRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028D4 RID: 10452
		// (get) Token: 0x0600866C RID: 34412 RVA: 0x002391B4 File Offset: 0x002373B4
		// (set) Token: 0x0600866D RID: 34413 RVA: 0x0003FE16 File Offset: 0x0003E016
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028D5 RID: 10453
		// (get) Token: 0x0600866E RID: 34414 RVA: 0x002391E4 File Offset: 0x002373E4
		// (set) Token: 0x0600866F RID: 34415 RVA: 0x0003FE35 File Offset: 0x0003E035
		public unsafe Color defaultEyeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_defaultEyeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_defaultEyeColor)) = value;
			}
		}

		// Token: 0x170028D6 RID: 10454
		// (get) Token: 0x06008670 RID: 34416 RVA: 0x0023920C File Offset: 0x0023740C
		// (set) Token: 0x06008671 RID: 34417 RVA: 0x0003FE50 File Offset: 0x0003E050
		public unsafe Vector2 AngleOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_AngleOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_AngleOffset)) = value;
			}
		}

		// Token: 0x04005B61 RID: 23393
		private static readonly IntPtr NativeFieldInfoPtr_PupilLookSpeed;

		// Token: 0x04005B62 RID: 23394
		private static readonly IntPtr NativeFieldInfoPtr_defaultScale;

		// Token: 0x04005B63 RID: 23395
		private static readonly IntPtr NativeFieldInfoPtr_maxRotation;

		// Token: 0x04005B64 RID: 23396
		private static readonly IntPtr NativeFieldInfoPtr_minRotation;

		// Token: 0x04005B65 RID: 23397
		private static readonly IntPtr NativeFieldInfoPtr__CurrentConfiguration_k__BackingField;

		// Token: 0x04005B66 RID: 23398
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005B67 RID: 23399
		private static readonly IntPtr NativeFieldInfoPtr_TopLidContainer;

		// Token: 0x04005B68 RID: 23400
		private static readonly IntPtr NativeFieldInfoPtr_BottomLidContainer;

		// Token: 0x04005B69 RID: 23401
		private static readonly IntPtr NativeFieldInfoPtr_PupilContainer;

		// Token: 0x04005B6A RID: 23402
		private static readonly IntPtr NativeFieldInfoPtr_TopLidRend;

		// Token: 0x04005B6B RID: 23403
		private static readonly IntPtr NativeFieldInfoPtr_BottomLidRend;

		// Token: 0x04005B6C RID: 23404
		private static readonly IntPtr NativeFieldInfoPtr_EyeBallRend;

		// Token: 0x04005B6D RID: 23405
		private static readonly IntPtr NativeFieldInfoPtr_EyeLookOrigin;

		// Token: 0x04005B6E RID: 23406
		private static readonly IntPtr NativeFieldInfoPtr_EyeLight;

		// Token: 0x04005B6F RID: 23407
		private static readonly IntPtr NativeFieldInfoPtr_PupilRend;

		// Token: 0x04005B70 RID: 23408
		private static readonly IntPtr NativeFieldInfoPtr_blinkRoutine;

		// Token: 0x04005B71 RID: 23409
		private static readonly IntPtr NativeFieldInfoPtr_stateRoutine;

		// Token: 0x04005B72 RID: 23410
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04005B73 RID: 23411
		private static readonly IntPtr NativeFieldInfoPtr_defaultEyeColor;

		// Token: 0x04005B74 RID: 23412
		private static readonly IntPtr NativeFieldInfoPtr_AngleOffset;

		// Token: 0x04005B75 RID: 23413
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentConfiguration_Public_get_EyeLidConfiguration_0;

		// Token: 0x04005B76 RID: 23414
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentConfiguration_Protected_set_Void_EyeLidConfiguration_0;

		// Token: 0x04005B77 RID: 23415
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBlinking_Public_get_Boolean_0;

		// Token: 0x04005B78 RID: 23416
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005B79 RID: 23417
		private static readonly IntPtr NativeMethodInfoPtr_SetSize_Public_Void_Single_0;

		// Token: 0x04005B7A RID: 23418
		private static readonly IntPtr NativeMethodInfoPtr_SetLidColor_Public_Void_Color_0;

		// Token: 0x04005B7B RID: 23419
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeballMaterial_Public_Void_Material_Color_0;

		// Token: 0x04005B7C RID: 23420
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeballColor_Public_Void_Color_Single_Boolean_0;

		// Token: 0x04005B7D RID: 23421
		private static readonly IntPtr NativeMethodInfoPtr_ResetEyeballColor_Public_Void_0;

		// Token: 0x04005B7E RID: 23422
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureEyeLight_Public_Void_Color_Single_0;

		// Token: 0x04005B7F RID: 23423
		private static readonly IntPtr NativeMethodInfoPtr_SetDilation_Public_Void_Single_0;

		// Token: 0x04005B80 RID: 23424
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Single_0;

		// Token: 0x04005B81 RID: 23425
		private static readonly IntPtr NativeMethodInfoPtr_StopExistingRoutines_Private_Void_0;

		// Token: 0x04005B82 RID: 23426
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Boolean_0;

		// Token: 0x04005B83 RID: 23427
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0;

		// Token: 0x04005B84 RID: 23428
		private static readonly IntPtr NativeMethodInfoPtr_Blink_Public_Void_Single_EyeLidConfiguration_Boolean_0;

		// Token: 0x04005B85 RID: 23429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AEF RID: 2799
		[Serializable]
		[StructLayout(2)]
		public struct EyeLidConfiguration
		{
			// Token: 0x0600D5A3 RID: 54691 RVA: 0x0032E96C File Offset: 0x0032CB6C
			// Note: this type is marked as 'beforefieldinit'.
			static EyeLidConfiguration()
			{
				Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye>.NativeClassPtr, "EyeLidConfiguration");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr);
				Eye.EyeLidConfiguration.NativeFieldInfoPtr_topLidOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, "topLidOpen");
				Eye.EyeLidConfiguration.NativeFieldInfoPtr_bottomLidOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, "bottomLidOpen");
				Eye.EyeLidConfiguration.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, 100680078);
				Eye.EyeLidConfiguration.NativeMethodInfoPtr_Lerp_Public_Static_EyeLidConfiguration_EyeLidConfiguration_EyeLidConfiguration_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, 100680079);
			}

			// Token: 0x0600D5A4 RID: 54692 RVA: 0x0032E9E8 File Offset: 0x0032CBE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250897, XrefRangeEnd = 250904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.EyeLidConfiguration.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D5A5 RID: 54693 RVA: 0x0032EA14 File Offset: 0x0032CC14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250904, XrefRangeEnd = 250906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Eye.EyeLidConfiguration Lerp(Eye.EyeLidConfiguration start, Eye.EyeLidConfiguration end, float lerp)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref start;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.EyeLidConfiguration.NativeMethodInfoPtr_Lerp_Public_Static_EyeLidConfiguration_EyeLidConfiguration_EyeLidConfiguration_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D5A6 RID: 54694 RVA: 0x00067EFF File Offset: 0x000660FF
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, ref this));
			}

			// Token: 0x04008FB2 RID: 36786
			private static readonly IntPtr NativeFieldInfoPtr_topLidOpen;

			// Token: 0x04008FB3 RID: 36787
			private static readonly IntPtr NativeFieldInfoPtr_bottomLidOpen;

			// Token: 0x04008FB4 RID: 36788
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04008FB5 RID: 36789
			private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_EyeLidConfiguration_EyeLidConfiguration_EyeLidConfiguration_Single_0;

			// Token: 0x04008FB6 RID: 36790
			[FieldOffset(0)]
			public float topLidOpen;

			// Token: 0x04008FB7 RID: 36791
			[FieldOffset(4)]
			public float bottomLidOpen;
		}

		// Token: 0x02000AF0 RID: 2800
		[ObfuscatedName("ScheduleOne.AvatarFramework.Eye+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D5A7 RID: 54695 RVA: 0x0032EA70 File Offset: 0x0032CC70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr);
				Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_startConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "startConfig");
				Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "config");
				Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "time");
				Eye.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "<>4__this");
				Eye.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, 100680080);
				Eye.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, 100680081);
			}

			// Token: 0x0600D5A8 RID: 54696 RVA: 0x0032EB14 File Offset: 0x0032CD14
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5A9 RID: 54697 RVA: 0x0032EB50 File Offset: 0x0032CD50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250921, XrefRangeEnd = 250926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D5AA RID: 54698 RVA: 0x00067F11 File Offset: 0x00066111
			public __c__DisplayClass34_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004233 RID: 16947
			// (get) Token: 0x0600D5AB RID: 54699 RVA: 0x0032EB90 File Offset: 0x0032CD90
			// (set) Token: 0x0600D5AC RID: 54700 RVA: 0x00067F1A File Offset: 0x0006611A
			public unsafe Eye.EyeLidConfiguration startConfig
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_startConfig);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_startConfig)) = value;
				}
			}

			// Token: 0x17004234 RID: 16948
			// (get) Token: 0x0600D5AD RID: 54701 RVA: 0x0032EBB8 File Offset: 0x0032CDB8
			// (set) Token: 0x0600D5AE RID: 54702 RVA: 0x00067F35 File Offset: 0x00066135
			public unsafe Eye.EyeLidConfiguration config
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_config);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_config)) = value;
				}
			}

			// Token: 0x17004235 RID: 16949
			// (get) Token: 0x0600D5AF RID: 54703 RVA: 0x0032EBE0 File Offset: 0x0032CDE0
			// (set) Token: 0x0600D5B0 RID: 54704 RVA: 0x00067F50 File Offset: 0x00066150
			public unsafe float time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x17004236 RID: 16950
			// (get) Token: 0x0600D5B1 RID: 54705 RVA: 0x0032EC08 File Offset: 0x0032CE08
			// (set) Token: 0x0600D5B2 RID: 54706 RVA: 0x00067F6B File Offset: 0x0006616B
			public unsafe Eye __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FB8 RID: 36792
			private static readonly IntPtr NativeFieldInfoPtr_startConfig;

			// Token: 0x04008FB9 RID: 36793
			private static readonly IntPtr NativeFieldInfoPtr_config;

			// Token: 0x04008FBA RID: 36794
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04008FBB RID: 36795
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FBC RID: 36796
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FBD RID: 36797
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C66 RID: 3174
			[ObfuscatedName("ScheduleOne.AvatarFramework.Eye+<>c__DisplayClass34_0+<<SetEyeLidState>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E473 RID: 58483 RVA: 0x003592BC File Offset: 0x003574BC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "<<SetEyeLidState>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680082);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680083);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680084);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680085);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680086);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680087);
				}

				// Token: 0x0600E474 RID: 58484 RVA: 0x003593B0 File Offset: 0x003575B0
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E475 RID: 58485 RVA: 0x003593F8 File Offset: 0x003575F8
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E476 RID: 58486 RVA: 0x0035942C File Offset: 0x0035762C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250906, XrefRangeEnd = 250916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046F6 RID: 18166
				// (get) Token: 0x0600E477 RID: 58487 RVA: 0x00359468 File Offset: 0x00357668
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E478 RID: 58488 RVA: 0x003594A8 File Offset: 0x003576A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250916, XrefRangeEnd = 250921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046F7 RID: 18167
				// (get) Token: 0x0600E479 RID: 58489 RVA: 0x003594DC File Offset: 0x003576DC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E47A RID: 58490 RVA: 0x0006F612 File Offset: 0x0006D812
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046F2 RID: 18162
				// (get) Token: 0x0600E47B RID: 58491 RVA: 0x0035951C File Offset: 0x0035771C
				// (set) Token: 0x0600E47C RID: 58492 RVA: 0x0006F61B File Offset: 0x0006D81B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046F3 RID: 18163
				// (get) Token: 0x0600E47D RID: 58493 RVA: 0x00359544 File Offset: 0x00357744
				// (set) Token: 0x0600E47E RID: 58494 RVA: 0x0006F636 File Offset: 0x0006D836
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046F4 RID: 18164
				// (get) Token: 0x0600E47F RID: 58495 RVA: 0x00359574 File Offset: 0x00357774
				// (set) Token: 0x0600E480 RID: 58496 RVA: 0x0006F655 File Offset: 0x0006D855
				public unsafe Eye.__c__DisplayClass34_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye.__c__DisplayClass34_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046F5 RID: 18165
				// (get) Token: 0x0600E481 RID: 58497 RVA: 0x003595A4 File Offset: 0x003577A4
				// (set) Token: 0x0600E482 RID: 58498 RVA: 0x0006F674 File Offset: 0x0006D874
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x040098D1 RID: 39121
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040098D2 RID: 39122
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040098D3 RID: 39123
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040098D4 RID: 39124
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x040098D5 RID: 39125
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040098D6 RID: 39126
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098D7 RID: 39127
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040098D8 RID: 39128
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040098D9 RID: 39129
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098DA RID: 39130
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000AF1 RID: 2801
		[ObfuscatedName("ScheduleOne.AvatarFramework.Eye+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D5B3 RID: 54707 RVA: 0x0032EC38 File Offset: 0x0032CE38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr);
				Eye.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "<>4__this");
				Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_blinkDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "blinkDuration");
				Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "debug");
				Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_endState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "endState");
				Eye.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, 100680088);
				Eye.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, 100680089);
			}

			// Token: 0x0600D5B4 RID: 54708 RVA: 0x0032ECDC File Offset: 0x0032CEDC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5B5 RID: 54709 RVA: 0x0032ED18 File Offset: 0x0032CF18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250942, XrefRangeEnd = 250947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D5B6 RID: 54710 RVA: 0x00067F8A File Offset: 0x0006618A
			public __c__DisplayClass38_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004237 RID: 16951
			// (get) Token: 0x0600D5B7 RID: 54711 RVA: 0x0032ED58 File Offset: 0x0032CF58
			// (set) Token: 0x0600D5B8 RID: 54712 RVA: 0x00067F93 File Offset: 0x00066193
			public unsafe Eye __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004238 RID: 16952
			// (get) Token: 0x0600D5B9 RID: 54713 RVA: 0x0032ED88 File Offset: 0x0032CF88
			// (set) Token: 0x0600D5BA RID: 54714 RVA: 0x00067FB2 File Offset: 0x000661B2
			public unsafe float blinkDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_blinkDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_blinkDuration)) = value;
				}
			}

			// Token: 0x17004239 RID: 16953
			// (get) Token: 0x0600D5BB RID: 54715 RVA: 0x0032EDB0 File Offset: 0x0032CFB0
			// (set) Token: 0x0600D5BC RID: 54716 RVA: 0x00067FCD File Offset: 0x000661CD
			public unsafe bool debug
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_debug);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_debug)) = value;
				}
			}

			// Token: 0x1700423A RID: 16954
			// (get) Token: 0x0600D5BD RID: 54717 RVA: 0x0032EDD8 File Offset: 0x0032CFD8
			// (set) Token: 0x0600D5BE RID: 54718 RVA: 0x00067FE8 File Offset: 0x000661E8
			public unsafe Eye.EyeLidConfiguration endState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_endState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_endState)) = value;
				}
			}

			// Token: 0x04008FBE RID: 36798
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FBF RID: 36799
			private static readonly IntPtr NativeFieldInfoPtr_blinkDuration;

			// Token: 0x04008FC0 RID: 36800
			private static readonly IntPtr NativeFieldInfoPtr_debug;

			// Token: 0x04008FC1 RID: 36801
			private static readonly IntPtr NativeFieldInfoPtr_endState;

			// Token: 0x04008FC2 RID: 36802
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FC3 RID: 36803
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C67 RID: 3175
			[ObfuscatedName("ScheduleOne.AvatarFramework.Eye+<>c__DisplayClass38_0+<<Blink>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E483 RID: 58499 RVA: 0x003595CC File Offset: 0x003577CC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique()
				{
					Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "<<Blink>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<>1__state");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<>2__current");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<>4__this");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__start_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<start>5__2");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__end_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<end>5__3");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__holdTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<holdTime>5__4");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__duration_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<duration>5__5");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<i>5__6");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100680090);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100680091);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100680092);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100680093);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100680094);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100680095);
				}

				// Token: 0x0600E484 RID: 58500 RVA: 0x00359710 File Offset: 0x00357910
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E485 RID: 58501 RVA: 0x00359758 File Offset: 0x00357958
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E486 RID: 58502 RVA: 0x0035978C File Offset: 0x0035798C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250926, XrefRangeEnd = 250937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004700 RID: 18176
				// (get) Token: 0x0600E487 RID: 58503 RVA: 0x003597C8 File Offset: 0x003579C8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E488 RID: 58504 RVA: 0x00359808 File Offset: 0x00357A08
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250937, XrefRangeEnd = 250942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004701 RID: 18177
				// (get) Token: 0x0600E489 RID: 58505 RVA: 0x0035983C File Offset: 0x00357A3C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E48A RID: 58506 RVA: 0x0006F68F File Offset: 0x0006D88F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046F8 RID: 18168
				// (get) Token: 0x0600E48B RID: 58507 RVA: 0x0035987C File Offset: 0x00357A7C
				// (set) Token: 0x0600E48C RID: 58508 RVA: 0x0006F698 File Offset: 0x0006D898
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046F9 RID: 18169
				// (get) Token: 0x0600E48D RID: 58509 RVA: 0x003598A4 File Offset: 0x00357AA4
				// (set) Token: 0x0600E48E RID: 58510 RVA: 0x0006F6B3 File Offset: 0x0006D8B3
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046FA RID: 18170
				// (get) Token: 0x0600E48F RID: 58511 RVA: 0x003598D4 File Offset: 0x00357AD4
				// (set) Token: 0x0600E490 RID: 58512 RVA: 0x0006F6D2 File Offset: 0x0006D8D2
				public unsafe Eye.__c__DisplayClass38_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye.__c__DisplayClass38_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046FB RID: 18171
				// (get) Token: 0x0600E491 RID: 58513 RVA: 0x00359904 File Offset: 0x00357B04
				// (set) Token: 0x0600E492 RID: 58514 RVA: 0x0006F6F1 File Offset: 0x0006D8F1
				public unsafe Eye.EyeLidConfiguration _start_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__start_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__start_5__2)) = value;
					}
				}

				// Token: 0x170046FC RID: 18172
				// (get) Token: 0x0600E493 RID: 58515 RVA: 0x0035992C File Offset: 0x00357B2C
				// (set) Token: 0x0600E494 RID: 58516 RVA: 0x0006F70C File Offset: 0x0006D90C
				public unsafe Eye.EyeLidConfiguration _end_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__end_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__end_5__3)) = value;
					}
				}

				// Token: 0x170046FD RID: 18173
				// (get) Token: 0x0600E495 RID: 58517 RVA: 0x00359954 File Offset: 0x00357B54
				// (set) Token: 0x0600E496 RID: 58518 RVA: 0x0006F727 File Offset: 0x0006D927
				public unsafe float _holdTime_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__holdTime_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__holdTime_5__4)) = value;
					}
				}

				// Token: 0x170046FE RID: 18174
				// (get) Token: 0x0600E497 RID: 58519 RVA: 0x0035997C File Offset: 0x00357B7C
				// (set) Token: 0x0600E498 RID: 58520 RVA: 0x0006F742 File Offset: 0x0006D942
				public unsafe float _duration_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__duration_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__duration_5__5)) = value;
					}
				}

				// Token: 0x170046FF RID: 18175
				// (get) Token: 0x0600E499 RID: 58521 RVA: 0x003599A4 File Offset: 0x00357BA4
				// (set) Token: 0x0600E49A RID: 58522 RVA: 0x0006F75D File Offset: 0x0006D95D
				public unsafe float _i_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__i_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__i_5__6)) = value;
					}
				}

				// Token: 0x040098DB RID: 39131
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040098DC RID: 39132
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040098DD RID: 39133
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040098DE RID: 39134
				private static readonly IntPtr NativeFieldInfoPtr__start_5__2;

				// Token: 0x040098DF RID: 39135
				private static readonly IntPtr NativeFieldInfoPtr__end_5__3;

				// Token: 0x040098E0 RID: 39136
				private static readonly IntPtr NativeFieldInfoPtr__holdTime_5__4;

				// Token: 0x040098E1 RID: 39137
				private static readonly IntPtr NativeFieldInfoPtr__duration_5__5;

				// Token: 0x040098E2 RID: 39138
				private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

				// Token: 0x040098E3 RID: 39139
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040098E4 RID: 39140
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098E5 RID: 39141
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040098E6 RID: 39142
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040098E7 RID: 39143
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098E8 RID: 39144
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
