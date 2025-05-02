using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200046E RID: 1134
	public class VehicleSelector : Singleton<VehicleSelector>
	{
		// Token: 0x0600622D RID: 25133 RVA: 0x001BEDE0 File Offset: 0x001BCFE0
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleSelector()
		{
			Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "VehicleSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr);
			VehicleSelector.NativeFieldInfoPtr_detectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "detectionRange");
			VehicleSelector.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "detectionMask");
			VehicleSelector.NativeFieldInfoPtr__isSelecting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "<isSelecting>k__BackingField");
			VehicleSelector.NativeFieldInfoPtr_selectedVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "selectedVehicles");
			VehicleSelector.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "onClose");
			VehicleSelector.NativeFieldInfoPtr_selectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "selectionLimit");
			VehicleSelector.NativeFieldInfoPtr_exitOnSelectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "exitOnSelectionLimit");
			VehicleSelector.NativeFieldInfoPtr_hoveredVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "hoveredVehicle");
			VehicleSelector.NativeFieldInfoPtr_outlinedVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "outlinedVehicles");
			VehicleSelector.NativeFieldInfoPtr_vehicleFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "vehicleFilter");
			VehicleSelector.NativeMethodInfoPtr_get_isSelecting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675759);
			VehicleSelector.NativeMethodInfoPtr_set_isSelecting_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675760);
			VehicleSelector.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675761);
			VehicleSelector.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675762);
			VehicleSelector.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675763);
			VehicleSelector.NativeMethodInfoPtr_GetHoveredVehicle_Private_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675764);
			VehicleSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675765);
			VehicleSelector.NativeMethodInfoPtr_StartSelecting_Public_Void_String_byref_List_1_LandVehicle_Int32_Boolean_Func_2_LandVehicle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675766);
			VehicleSelector.NativeMethodInfoPtr_StopSelecting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675767);
			VehicleSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675768);
		}

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x0600622E RID: 25134 RVA: 0x001BEFA0 File Offset: 0x001BD1A0
		// (set) Token: 0x0600622F RID: 25135 RVA: 0x001BEFDC File Offset: 0x001BD1DC
		public unsafe bool isSelecting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr_get_isSelecting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr_set_isSelecting_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006230 RID: 25136 RVA: 0x001BF01C File Offset: 0x001BD21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201916, XrefRangeEnd = 201929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleSelector.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006231 RID: 25137 RVA: 0x001BF058 File Offset: 0x001BD258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201929, XrefRangeEnd = 201969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleSelector.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006232 RID: 25138 RVA: 0x001BF094 File Offset: 0x001BD294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201969, XrefRangeEnd = 201998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleSelector.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006233 RID: 25139 RVA: 0x001BF0D0 File Offset: 0x001BD2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201998, XrefRangeEnd = 202011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle GetHoveredVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr_GetHoveredVehicle_Private_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
		}

		// Token: 0x06006234 RID: 25140 RVA: 0x001BF110 File Offset: 0x001BD310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202011, XrefRangeEnd = 202012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006235 RID: 25141 RVA: 0x001BF154 File Offset: 0x001BD354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202012, XrefRangeEnd = 202038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSelecting(string selectionTitle, ref List<LandVehicle> initialSelection, int _selectionLimit, bool _exitOnSelectionLimit, Func<LandVehicle, bool> filter = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectionTitle);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(initialSelection);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _selectionLimit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _exitOnSelectionLimit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr_StartSelecting_Public_Void_String_byref_List_1_LandVehicle_Int32_Boolean_Func_2_LandVehicle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			initialSelection = ((intPtr4 == 0) ? null : new List<LandVehicle>(intPtr4));
		}

		// Token: 0x06006236 RID: 25142 RVA: 0x001BF1EC File Offset: 0x001BD3EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202058, RefRangeEnd = 202060, XrefRangeStart = 202038, XrefRangeEnd = 202058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSelecting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr_StopSelecting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006237 RID: 25143 RVA: 0x001BF220 File Offset: 0x001BD420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202060, XrefRangeEnd = 202110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006238 RID: 25144 RVA: 0x0002E637 File Offset: 0x0002C837
		public VehicleSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D85 RID: 7557
		// (get) Token: 0x06006239 RID: 25145 RVA: 0x001BF25C File Offset: 0x001BD45C
		// (set) Token: 0x0600623A RID: 25146 RVA: 0x0002E640 File Offset: 0x0002C840
		public unsafe float detectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_detectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_detectionRange)) = value;
			}
		}

		// Token: 0x17001D86 RID: 7558
		// (get) Token: 0x0600623B RID: 25147 RVA: 0x001BF284 File Offset: 0x001BD484
		// (set) Token: 0x0600623C RID: 25148 RVA: 0x0002E65B File Offset: 0x0002C85B
		public unsafe LayerMask detectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17001D87 RID: 7559
		// (get) Token: 0x0600623D RID: 25149 RVA: 0x001BF2AC File Offset: 0x001BD4AC
		// (set) Token: 0x0600623E RID: 25150 RVA: 0x0002E676 File Offset: 0x0002C876
		public unsafe bool _isSelecting_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr__isSelecting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr__isSelecting_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D88 RID: 7560
		// (get) Token: 0x0600623F RID: 25151 RVA: 0x001BF2D4 File Offset: 0x001BD4D4
		// (set) Token: 0x06006240 RID: 25152 RVA: 0x0002E691 File Offset: 0x0002C891
		public unsafe List<LandVehicle> selectedVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_selectedVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_selectedVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x06006241 RID: 25153 RVA: 0x001BF304 File Offset: 0x001BD504
		// (set) Token: 0x06006242 RID: 25154 RVA: 0x0002E6B0 File Offset: 0x0002C8B0
		public unsafe Action onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x06006243 RID: 25155 RVA: 0x001BF334 File Offset: 0x001BD534
		// (set) Token: 0x06006244 RID: 25156 RVA: 0x0002E6CF File Offset: 0x0002C8CF
		public unsafe int selectionLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_selectionLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_selectionLimit)) = value;
			}
		}

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x06006245 RID: 25157 RVA: 0x001BF35C File Offset: 0x001BD55C
		// (set) Token: 0x06006246 RID: 25158 RVA: 0x0002E6EA File Offset: 0x0002C8EA
		public unsafe bool exitOnSelectionLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_exitOnSelectionLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_exitOnSelectionLimit)) = value;
			}
		}

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x06006247 RID: 25159 RVA: 0x001BF384 File Offset: 0x001BD584
		// (set) Token: 0x06006248 RID: 25160 RVA: 0x0002E705 File Offset: 0x0002C905
		public unsafe LandVehicle hoveredVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_hoveredVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_hoveredVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x06006249 RID: 25161 RVA: 0x001BF3B4 File Offset: 0x001BD5B4
		// (set) Token: 0x0600624A RID: 25162 RVA: 0x0002E724 File Offset: 0x0002C924
		public unsafe List<LandVehicle> outlinedVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_outlinedVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_outlinedVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x0600624B RID: 25163 RVA: 0x001BF3E4 File Offset: 0x001BD5E4
		// (set) Token: 0x0600624C RID: 25164 RVA: 0x0002E743 File Offset: 0x0002C943
		public unsafe Func<LandVehicle, bool> vehicleFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_vehicleFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LandVehicle, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_vehicleFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040042F1 RID: 17137
		private static readonly IntPtr NativeFieldInfoPtr_detectionRange;

		// Token: 0x040042F2 RID: 17138
		private static readonly IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x040042F3 RID: 17139
		private static readonly IntPtr NativeFieldInfoPtr__isSelecting_k__BackingField;

		// Token: 0x040042F4 RID: 17140
		private static readonly IntPtr NativeFieldInfoPtr_selectedVehicles;

		// Token: 0x040042F5 RID: 17141
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x040042F6 RID: 17142
		private static readonly IntPtr NativeFieldInfoPtr_selectionLimit;

		// Token: 0x040042F7 RID: 17143
		private static readonly IntPtr NativeFieldInfoPtr_exitOnSelectionLimit;

		// Token: 0x040042F8 RID: 17144
		private static readonly IntPtr NativeFieldInfoPtr_hoveredVehicle;

		// Token: 0x040042F9 RID: 17145
		private static readonly IntPtr NativeFieldInfoPtr_outlinedVehicles;

		// Token: 0x040042FA RID: 17146
		private static readonly IntPtr NativeFieldInfoPtr_vehicleFilter;

		// Token: 0x040042FB RID: 17147
		private static readonly IntPtr NativeMethodInfoPtr_get_isSelecting_Public_get_Boolean_0;

		// Token: 0x040042FC RID: 17148
		private static readonly IntPtr NativeMethodInfoPtr_set_isSelecting_Protected_set_Void_Boolean_0;

		// Token: 0x040042FD RID: 17149
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040042FE RID: 17150
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040042FF RID: 17151
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004300 RID: 17152
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredVehicle_Private_LandVehicle_0;

		// Token: 0x04004301 RID: 17153
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04004302 RID: 17154
		private static readonly IntPtr NativeMethodInfoPtr_StartSelecting_Public_Void_String_byref_List_1_LandVehicle_Int32_Boolean_Func_2_LandVehicle_Boolean_0;

		// Token: 0x04004303 RID: 17155
		private static readonly IntPtr NativeMethodInfoPtr_StopSelecting_Public_Void_0;

		// Token: 0x04004304 RID: 17156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
