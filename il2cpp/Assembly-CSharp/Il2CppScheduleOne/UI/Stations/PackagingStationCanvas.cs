using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x02000682 RID: 1666
	public class PackagingStationCanvas : Singleton<PackagingStationCanvas>
	{
		// Token: 0x0600954E RID: 38222 RVA: 0x00264CE4 File Offset: 0x00262EE4
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingStationCanvas()
		{
			Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "PackagingStationCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr);
			PackagingStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			PackagingStationCanvas.NativeFieldInfoPtr__PackagingStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "<PackagingStation>k__BackingField");
			PackagingStationCanvas.NativeFieldInfoPtr_ShowHintOnOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ShowHintOnOpen");
			PackagingStationCanvas.NativeFieldInfoPtr_ShowShiftClickHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ShowShiftClickHint");
			PackagingStationCanvas.NativeFieldInfoPtr_CurrentMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "CurrentMode");
			PackagingStationCanvas.NativeFieldInfoPtr_InstructionWarningColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "InstructionWarningColor");
			PackagingStationCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "Canvas");
			PackagingStationCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "Container");
			PackagingStationCanvas.NativeFieldInfoPtr_PackagingSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "PackagingSlotUI");
			PackagingStationCanvas.NativeFieldInfoPtr_ProductSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ProductSlotUI");
			PackagingStationCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "OutputSlotUI");
			PackagingStationCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "InstructionLabel");
			PackagingStationCanvas.NativeFieldInfoPtr_InstructionShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "InstructionShadow");
			PackagingStationCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "BeginButton");
			PackagingStationCanvas.NativeFieldInfoPtr_ModeAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ModeAnimation");
			PackagingStationCanvas.NativeFieldInfoPtr_ButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ButtonLabel");
			PackagingStationCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681760);
			PackagingStationCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681761);
			PackagingStationCanvas.NativeMethodInfoPtr_get_PackagingStation_Public_get_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681762);
			PackagingStationCanvas.NativeMethodInfoPtr_set_PackagingStation_Protected_set_Void_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681763);
			PackagingStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681764);
			PackagingStationCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681765);
			PackagingStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681766);
			PackagingStationCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_PackagingStation_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681767);
			PackagingStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681768);
			PackagingStationCanvas.NativeMethodInfoPtr_UpdateSlotPositions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681769);
			PackagingStationCanvas.NativeMethodInfoPtr_ToggleMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681770);
			PackagingStationCanvas.NativeMethodInfoPtr_SetMode_Public_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681771);
			PackagingStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100681772);
		}

		// Token: 0x17002DEC RID: 11756
		// (get) Token: 0x0600954F RID: 38223 RVA: 0x00264F58 File Offset: 0x00263158
		// (set) Token: 0x06009550 RID: 38224 RVA: 0x00264F94 File Offset: 0x00263194
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37992, RefRangeEnd = 38015, XrefRangeStart = 37992, XrefRangeEnd = 38015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DED RID: 11757
		// (get) Token: 0x06009551 RID: 38225 RVA: 0x00264FD4 File Offset: 0x002631D4
		// (set) Token: 0x06009552 RID: 38226 RVA: 0x00265014 File Offset: 0x00263214
		public unsafe PackagingStation PackagingStation
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_get_PackagingStation_Public_get_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_set_PackagingStation_Protected_set_Void_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009553 RID: 38227 RVA: 0x00265058 File Offset: 0x00263258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268649, XrefRangeEnd = 268660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009554 RID: 38228 RVA: 0x00265094 File Offset: 0x00263294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268660, XrefRangeEnd = 268664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009555 RID: 38229 RVA: 0x002650D0 File Offset: 0x002632D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268664, XrefRangeEnd = 268699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009556 RID: 38230 RVA: 0x0026510C File Offset: 0x0026330C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 268790, RefRangeEnd = 268794, XrefRangeStart = 268699, XrefRangeEnd = 268790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(PackagingStation station, bool open, bool removeUI = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeUI;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_PackagingStation_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009557 RID: 38231 RVA: 0x0026516C File Offset: 0x0026336C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268811, RefRangeEnd = 268812, XrefRangeStart = 268794, XrefRangeEnd = 268811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009558 RID: 38232 RVA: 0x002651A0 File Offset: 0x002633A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268812, XrefRangeEnd = 268835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSlotPositions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_UpdateSlotPositions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009559 RID: 38233 RVA: 0x002651D4 File Offset: 0x002633D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268835, XrefRangeEnd = 268836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_ToggleMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600955A RID: 38234 RVA: 0x00265208 File Offset: 0x00263408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268882, RefRangeEnd = 268883, XrefRangeStart = 268836, XrefRangeEnd = 268882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMode(PackagingStation.EMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_SetMode_Public_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600955B RID: 38235 RVA: 0x00265248 File Offset: 0x00263448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268883, XrefRangeEnd = 268886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStationCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600955C RID: 38236 RVA: 0x00048938 File Offset: 0x00046B38
		public PackagingStationCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DDC RID: 11740
		// (get) Token: 0x0600955D RID: 38237 RVA: 0x00265284 File Offset: 0x00263484
		// (set) Token: 0x0600955E RID: 38238 RVA: 0x00048941 File Offset: 0x00046B41
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002DDD RID: 11741
		// (get) Token: 0x0600955F RID: 38239 RVA: 0x002652AC File Offset: 0x002634AC
		// (set) Token: 0x06009560 RID: 38240 RVA: 0x0004895C File Offset: 0x00046B5C
		public unsafe PackagingStation _PackagingStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr__PackagingStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr__PackagingStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DDE RID: 11742
		// (get) Token: 0x06009561 RID: 38241 RVA: 0x002652DC File Offset: 0x002634DC
		// (set) Token: 0x06009562 RID: 38242 RVA: 0x0004897B File Offset: 0x00046B7B
		public unsafe bool ShowHintOnOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ShowHintOnOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ShowHintOnOpen)) = value;
			}
		}

		// Token: 0x17002DDF RID: 11743
		// (get) Token: 0x06009563 RID: 38243 RVA: 0x00265304 File Offset: 0x00263504
		// (set) Token: 0x06009564 RID: 38244 RVA: 0x00048996 File Offset: 0x00046B96
		public unsafe bool ShowShiftClickHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ShowShiftClickHint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ShowShiftClickHint)) = value;
			}
		}

		// Token: 0x17002DE0 RID: 11744
		// (get) Token: 0x06009565 RID: 38245 RVA: 0x0026532C File Offset: 0x0026352C
		// (set) Token: 0x06009566 RID: 38246 RVA: 0x000489B1 File Offset: 0x00046BB1
		public unsafe PackagingStation.EMode CurrentMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_CurrentMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_CurrentMode)) = value;
			}
		}

		// Token: 0x17002DE1 RID: 11745
		// (get) Token: 0x06009567 RID: 38247 RVA: 0x00265354 File Offset: 0x00263554
		// (set) Token: 0x06009568 RID: 38248 RVA: 0x000489CC File Offset: 0x00046BCC
		public unsafe Color InstructionWarningColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionWarningColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionWarningColor)) = value;
			}
		}

		// Token: 0x17002DE2 RID: 11746
		// (get) Token: 0x06009569 RID: 38249 RVA: 0x0026537C File Offset: 0x0026357C
		// (set) Token: 0x0600956A RID: 38250 RVA: 0x000489E7 File Offset: 0x00046BE7
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE3 RID: 11747
		// (get) Token: 0x0600956B RID: 38251 RVA: 0x002653AC File Offset: 0x002635AC
		// (set) Token: 0x0600956C RID: 38252 RVA: 0x00048A06 File Offset: 0x00046C06
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE4 RID: 11748
		// (get) Token: 0x0600956D RID: 38253 RVA: 0x002653DC File Offset: 0x002635DC
		// (set) Token: 0x0600956E RID: 38254 RVA: 0x00048A25 File Offset: 0x00046C25
		public unsafe ItemSlotUI PackagingSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_PackagingSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_PackagingSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE5 RID: 11749
		// (get) Token: 0x0600956F RID: 38255 RVA: 0x0026540C File Offset: 0x0026360C
		// (set) Token: 0x06009570 RID: 38256 RVA: 0x00048A44 File Offset: 0x00046C44
		public unsafe ItemSlotUI ProductSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ProductSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ProductSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE6 RID: 11750
		// (get) Token: 0x06009571 RID: 38257 RVA: 0x0026543C File Offset: 0x0026363C
		// (set) Token: 0x06009572 RID: 38258 RVA: 0x00048A63 File Offset: 0x00046C63
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE7 RID: 11751
		// (get) Token: 0x06009573 RID: 38259 RVA: 0x0026546C File Offset: 0x0026366C
		// (set) Token: 0x06009574 RID: 38260 RVA: 0x00048A82 File Offset: 0x00046C82
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE8 RID: 11752
		// (get) Token: 0x06009575 RID: 38261 RVA: 0x0026549C File Offset: 0x0026369C
		// (set) Token: 0x06009576 RID: 38262 RVA: 0x00048AA1 File Offset: 0x00046CA1
		public unsafe Image InstructionShadow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionShadow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionShadow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE9 RID: 11753
		// (get) Token: 0x06009577 RID: 38263 RVA: 0x002654CC File Offset: 0x002636CC
		// (set) Token: 0x06009578 RID: 38264 RVA: 0x00048AC0 File Offset: 0x00046CC0
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DEA RID: 11754
		// (get) Token: 0x06009579 RID: 38265 RVA: 0x002654FC File Offset: 0x002636FC
		// (set) Token: 0x0600957A RID: 38266 RVA: 0x00048ADF File Offset: 0x00046CDF
		public unsafe Animation ModeAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ModeAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ModeAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DEB RID: 11755
		// (get) Token: 0x0600957B RID: 38267 RVA: 0x0026552C File Offset: 0x0026372C
		// (set) Token: 0x0600957C RID: 38268 RVA: 0x00048AFE File Offset: 0x00046CFE
		public unsafe TextMeshProUGUI ButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040064B2 RID: 25778
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x040064B3 RID: 25779
		private static readonly IntPtr NativeFieldInfoPtr__PackagingStation_k__BackingField;

		// Token: 0x040064B4 RID: 25780
		private static readonly IntPtr NativeFieldInfoPtr_ShowHintOnOpen;

		// Token: 0x040064B5 RID: 25781
		private static readonly IntPtr NativeFieldInfoPtr_ShowShiftClickHint;

		// Token: 0x040064B6 RID: 25782
		private static readonly IntPtr NativeFieldInfoPtr_CurrentMode;

		// Token: 0x040064B7 RID: 25783
		private static readonly IntPtr NativeFieldInfoPtr_InstructionWarningColor;

		// Token: 0x040064B8 RID: 25784
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040064B9 RID: 25785
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040064BA RID: 25786
		private static readonly IntPtr NativeFieldInfoPtr_PackagingSlotUI;

		// Token: 0x040064BB RID: 25787
		private static readonly IntPtr NativeFieldInfoPtr_ProductSlotUI;

		// Token: 0x040064BC RID: 25788
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x040064BD RID: 25789
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x040064BE RID: 25790
		private static readonly IntPtr NativeFieldInfoPtr_InstructionShadow;

		// Token: 0x040064BF RID: 25791
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x040064C0 RID: 25792
		private static readonly IntPtr NativeFieldInfoPtr_ModeAnimation;

		// Token: 0x040064C1 RID: 25793
		private static readonly IntPtr NativeFieldInfoPtr_ButtonLabel;

		// Token: 0x040064C2 RID: 25794
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x040064C3 RID: 25795
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040064C4 RID: 25796
		private static readonly IntPtr NativeMethodInfoPtr_get_PackagingStation_Public_get_PackagingStation_0;

		// Token: 0x040064C5 RID: 25797
		private static readonly IntPtr NativeMethodInfoPtr_set_PackagingStation_Protected_set_Void_PackagingStation_0;

		// Token: 0x040064C6 RID: 25798
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040064C7 RID: 25799
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040064C8 RID: 25800
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040064C9 RID: 25801
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_PackagingStation_Boolean_Boolean_0;

		// Token: 0x040064CA RID: 25802
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x040064CB RID: 25803
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSlotPositions_Private_Void_0;

		// Token: 0x040064CC RID: 25804
		private static readonly IntPtr NativeMethodInfoPtr_ToggleMode_Public_Void_0;

		// Token: 0x040064CD RID: 25805
		private static readonly IntPtr NativeMethodInfoPtr_SetMode_Public_Void_EMode_0;

		// Token: 0x040064CE RID: 25806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
