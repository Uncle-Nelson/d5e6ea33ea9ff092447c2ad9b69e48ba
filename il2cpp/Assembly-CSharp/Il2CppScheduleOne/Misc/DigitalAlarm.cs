using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x02000768 RID: 1896
	public class DigitalAlarm : MonoBehaviour
	{
		// Token: 0x0600B3FE RID: 46078 RVA: 0x002CDA2C File Offset: 0x002CBC2C
		// Note: this type is marked as 'beforefieldinit'.
		static DigitalAlarm()
		{
			Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "DigitalAlarm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr);
			DigitalAlarm.NativeFieldInfoPtr_FLASH_FREQUENCY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "FLASH_FREQUENCY");
			DigitalAlarm.NativeFieldInfoPtr_ScreenMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenMesh");
			DigitalAlarm.NativeFieldInfoPtr_ScreenMeshMaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenMeshMaterialIndex");
			DigitalAlarm.NativeFieldInfoPtr_ScreenText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenText");
			DigitalAlarm.NativeFieldInfoPtr_FlashScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "FlashScreen");
			DigitalAlarm.NativeFieldInfoPtr_DisplayCurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "DisplayCurrentTime");
			DigitalAlarm.NativeFieldInfoPtr_ScreenOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenOffMat");
			DigitalAlarm.NativeFieldInfoPtr_ScreenOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenOnMat");
			DigitalAlarm.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100685472);
			DigitalAlarm.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100685473);
			DigitalAlarm.NativeMethodInfoPtr_SetScreenLit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100685474);
			DigitalAlarm.NativeMethodInfoPtr_DisplayText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100685475);
			DigitalAlarm.NativeMethodInfoPtr_DisplayMinutes_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100685476);
			DigitalAlarm.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100685477);
			DigitalAlarm.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100685478);
			DigitalAlarm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100685479);
		}

		// Token: 0x0600B3FF RID: 46079 RVA: 0x002CDB9C File Offset: 0x002CBD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309174, XrefRangeEnd = 309192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B400 RID: 46080 RVA: 0x002CDBD0 File Offset: 0x002CBDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309192, XrefRangeEnd = 309214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B401 RID: 46081 RVA: 0x002CDC04 File Offset: 0x002CBE04
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 309223, RefRangeEnd = 309229, XrefRangeStart = 309214, XrefRangeEnd = 309223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScreenLit(bool lit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_SetScreenLit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B402 RID: 46082 RVA: 0x002CDC44 File Offset: 0x002CBE44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309230, RefRangeEnd = 309232, XrefRangeStart = 309229, XrefRangeEnd = 309230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_DisplayText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B403 RID: 46083 RVA: 0x002CDC88 File Offset: 0x002CBE88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 309240, RefRangeEnd = 309244, XrefRangeStart = 309232, XrefRangeEnd = 309240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayMinutes(int mins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mins;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_DisplayMinutes_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B404 RID: 46084 RVA: 0x002CDCC8 File Offset: 0x002CBEC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309244, XrefRangeEnd = 309249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B405 RID: 46085 RVA: 0x002CDCFC File Offset: 0x002CBEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309249, XrefRangeEnd = 309256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B406 RID: 46086 RVA: 0x002CDD30 File Offset: 0x002CBF30
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DigitalAlarm() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B407 RID: 46087 RVA: 0x000583BE File Offset: 0x000565BE
		public DigitalAlarm(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037CC RID: 14284
		// (get) Token: 0x0600B408 RID: 46088 RVA: 0x002CDD6C File Offset: 0x002CBF6C
		// (set) Token: 0x0600B409 RID: 46089 RVA: 0x000583C7 File Offset: 0x000565C7
		public unsafe static float FLASH_FREQUENCY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DigitalAlarm.NativeFieldInfoPtr_FLASH_FREQUENCY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DigitalAlarm.NativeFieldInfoPtr_FLASH_FREQUENCY, (void*)(&value));
			}
		}

		// Token: 0x170037CD RID: 14285
		// (get) Token: 0x0600B40A RID: 46090 RVA: 0x002CDD88 File Offset: 0x002CBF88
		// (set) Token: 0x0600B40B RID: 46091 RVA: 0x000583D5 File Offset: 0x000565D5
		public unsafe MeshRenderer ScreenMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037CE RID: 14286
		// (get) Token: 0x0600B40C RID: 46092 RVA: 0x002CDDB8 File Offset: 0x002CBFB8
		// (set) Token: 0x0600B40D RID: 46093 RVA: 0x000583F4 File Offset: 0x000565F4
		public unsafe int ScreenMeshMaterialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenMeshMaterialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenMeshMaterialIndex)) = value;
			}
		}

		// Token: 0x170037CF RID: 14287
		// (get) Token: 0x0600B40E RID: 46094 RVA: 0x002CDDE0 File Offset: 0x002CBFE0
		// (set) Token: 0x0600B40F RID: 46095 RVA: 0x0005840F File Offset: 0x0005660F
		public unsafe TextMeshPro ScreenText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037D0 RID: 14288
		// (get) Token: 0x0600B410 RID: 46096 RVA: 0x002CDE10 File Offset: 0x002CC010
		// (set) Token: 0x0600B411 RID: 46097 RVA: 0x0005842E File Offset: 0x0005662E
		public unsafe bool FlashScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_FlashScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_FlashScreen)) = value;
			}
		}

		// Token: 0x170037D1 RID: 14289
		// (get) Token: 0x0600B412 RID: 46098 RVA: 0x002CDE38 File Offset: 0x002CC038
		// (set) Token: 0x0600B413 RID: 46099 RVA: 0x00058449 File Offset: 0x00056649
		public unsafe bool DisplayCurrentTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_DisplayCurrentTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_DisplayCurrentTime)) = value;
			}
		}

		// Token: 0x170037D2 RID: 14290
		// (get) Token: 0x0600B414 RID: 46100 RVA: 0x002CDE60 File Offset: 0x002CC060
		// (set) Token: 0x0600B415 RID: 46101 RVA: 0x00058464 File Offset: 0x00056664
		public unsafe Material ScreenOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037D3 RID: 14291
		// (get) Token: 0x0600B416 RID: 46102 RVA: 0x002CDE90 File Offset: 0x002CC090
		// (set) Token: 0x0600B417 RID: 46103 RVA: 0x00058483 File Offset: 0x00056683
		public unsafe Material ScreenOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400795F RID: 31071
		private static readonly IntPtr NativeFieldInfoPtr_FLASH_FREQUENCY;

		// Token: 0x04007960 RID: 31072
		private static readonly IntPtr NativeFieldInfoPtr_ScreenMesh;

		// Token: 0x04007961 RID: 31073
		private static readonly IntPtr NativeFieldInfoPtr_ScreenMeshMaterialIndex;

		// Token: 0x04007962 RID: 31074
		private static readonly IntPtr NativeFieldInfoPtr_ScreenText;

		// Token: 0x04007963 RID: 31075
		private static readonly IntPtr NativeFieldInfoPtr_FlashScreen;

		// Token: 0x04007964 RID: 31076
		private static readonly IntPtr NativeFieldInfoPtr_DisplayCurrentTime;

		// Token: 0x04007965 RID: 31077
		private static readonly IntPtr NativeFieldInfoPtr_ScreenOffMat;

		// Token: 0x04007966 RID: 31078
		private static readonly IntPtr NativeFieldInfoPtr_ScreenOnMat;

		// Token: 0x04007967 RID: 31079
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007968 RID: 31080
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04007969 RID: 31081
		private static readonly IntPtr NativeMethodInfoPtr_SetScreenLit_Public_Void_Boolean_0;

		// Token: 0x0400796A RID: 31082
		private static readonly IntPtr NativeMethodInfoPtr_DisplayText_Public_Void_String_0;

		// Token: 0x0400796B RID: 31083
		private static readonly IntPtr NativeMethodInfoPtr_DisplayMinutes_Public_Void_Int32_0;

		// Token: 0x0400796C RID: 31084
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400796D RID: 31085
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400796E RID: 31086
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
