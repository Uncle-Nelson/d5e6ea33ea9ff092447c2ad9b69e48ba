using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Vision;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using UnityEngine;

namespace Il2CppScheduleOne.Stealth
{
	// Token: 0x020001A3 RID: 419
	public class PlayerVisibility : NetworkBehaviour
	{
		// Token: 0x06002251 RID: 8785 RVA: 0x000DBD2C File Offset: 0x000D9F2C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerVisibility()
		{
			Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Stealth", "PlayerVisibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr);
			PlayerVisibility.NativeFieldInfoPtr_MAX_VISIBLITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "MAX_VISIBLITY");
			PlayerVisibility.NativeFieldInfoPtr_CurrentVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "CurrentVisibility");
			PlayerVisibility.NativeFieldInfoPtr_activeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "activeAttributes");
			PlayerVisibility.NativeFieldInfoPtr_filteredAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "filteredAttributes");
			PlayerVisibility.NativeFieldInfoPtr_visibilityCheckMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "visibilityCheckMask");
			PlayerVisibility.NativeFieldInfoPtr_visibilityPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "visibilityPoints");
			PlayerVisibility.NativeFieldInfoPtr_environmentalVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "environmentalVisibility");
			PlayerVisibility.NativeFieldInfoPtr__HighestVisionEvent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "<HighestVisionEvent>k__BackingField");
			PlayerVisibility.NativeFieldInfoPtr_hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "hits");
			PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Stealth.PlayerVisibilityAssembly-CSharp.dll_Excuted");
			PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Stealth.PlayerVisibilityAssembly-CSharp.dll_Excuted");
			PlayerVisibility.NativeMethodInfoPtr_get_HighestVisionEvent_Public_get_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667165);
			PlayerVisibility.NativeMethodInfoPtr_set_HighestVisionEvent_Public_set_Void_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667166);
			PlayerVisibility.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667167);
			PlayerVisibility.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667168);
			PlayerVisibility.NativeMethodInfoPtr_CalculateVisibility_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667169);
			PlayerVisibility.NativeMethodInfoPtr_GetAttribute_Public_VisibilityAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667170);
			PlayerVisibility.NativeMethodInfoPtr_UpdateEnvironmentalVisibilityAttribute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667171);
			PlayerVisibility.NativeMethodInfoPtr_CalculateExposureToPoint_Public_Single_Vector3_Single_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667172);
			PlayerVisibility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667173);
			PlayerVisibility.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667174);
			PlayerVisibility.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667175);
			PlayerVisibility.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667176);
			PlayerVisibility.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667177);
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x000DBF3C File Offset: 0x000DA13C
		// (set) Token: 0x06002253 RID: 8787 RVA: 0x000DBF7C File Offset: 0x000DA17C
		public unsafe VisionEvent HighestVisionEvent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93787, RefRangeEnd = 93788, XrefRangeStart = 93787, XrefRangeEnd = 93788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_get_HighestVisionEvent_Public_get_VisionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisionEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111543, XrefRangeEnd = 111544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_set_HighestVisionEvent_Public_set_Void_VisionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x000DBFC0 File Offset: 0x000DA1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111544, XrefRangeEnd = 111553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x000DBFFC File Offset: 0x000DA1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111553, XrefRangeEnd = 111559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x000DC030 File Offset: 0x000DA230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111654, RefRangeEnd = 111655, XrefRangeStart = 111559, XrefRangeEnd = 111654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_CalculateVisibility_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x000DC06C File Offset: 0x000DA26C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111670, RefRangeEnd = 111671, XrefRangeStart = 111655, XrefRangeEnd = 111670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibilityAttribute GetAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_GetAttribute_Public_VisibilityAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisibilityAttribute>(intPtr3) : null;
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x000DC0BC File Offset: 0x000DA2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111671, XrefRangeEnd = 111676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEnvironmentalVisibilityAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_UpdateEnvironmentalVisibilityAttribute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x000DC0F0 File Offset: 0x000DA2F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111794, RefRangeEnd = 111796, XrefRangeStart = 111676, XrefRangeEnd = 111794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateExposureToPoint(Vector3 point, float checkRange = 50f, NPC checkingNPC = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkRange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(checkingNPC);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_CalculateExposureToPoint_Public_Single_Vector3_Single_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x000DC15C File Offset: 0x000DA35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111796, XrefRangeEnd = 111816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerVisibility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x000DC198 File Offset: 0x000DA398
		[CallerCount(0)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x000DC1D4 File Offset: 0x000DA3D4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x000DC210 File Offset: 0x000DA410
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x000DC24C File Offset: 0x000DA44C
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x0001328A File Offset: 0x0001148A
		public PlayerVisibility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x000DC288 File Offset: 0x000DA488
		// (set) Token: 0x06002261 RID: 8801 RVA: 0x00013293 File Offset: 0x00011493
		public unsafe static float MAX_VISIBLITY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.NativeFieldInfoPtr_MAX_VISIBLITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.NativeFieldInfoPtr_MAX_VISIBLITY, (void*)(&value));
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x000DC2A4 File Offset: 0x000DA4A4
		// (set) Token: 0x06002263 RID: 8803 RVA: 0x000132A1 File Offset: 0x000114A1
		public unsafe float CurrentVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_CurrentVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_CurrentVisibility)) = value;
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06002264 RID: 8804 RVA: 0x000DC2CC File Offset: 0x000DA4CC
		// (set) Token: 0x06002265 RID: 8805 RVA: 0x000132BC File Offset: 0x000114BC
		public unsafe List<VisibilityAttribute> activeAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_activeAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisibilityAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_activeAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x000DC2FC File Offset: 0x000DA4FC
		// (set) Token: 0x06002267 RID: 8807 RVA: 0x000132DB File Offset: 0x000114DB
		public unsafe List<VisibilityAttribute> filteredAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_filteredAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisibilityAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_filteredAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x000DC32C File Offset: 0x000DA52C
		// (set) Token: 0x06002269 RID: 8809 RVA: 0x000132FA File Offset: 0x000114FA
		public unsafe LayerMask visibilityCheckMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_visibilityCheckMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_visibilityCheckMask)) = value;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x000DC354 File Offset: 0x000DA554
		// (set) Token: 0x0600226B RID: 8811 RVA: 0x00013315 File Offset: 0x00011515
		public unsafe List<Transform> visibilityPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_visibilityPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_visibilityPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x000DC384 File Offset: 0x000DA584
		// (set) Token: 0x0600226D RID: 8813 RVA: 0x00013334 File Offset: 0x00011534
		public unsafe VisibilityAttribute environmentalVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_environmentalVisibility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_environmentalVisibility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x0600226E RID: 8814 RVA: 0x000DC3B4 File Offset: 0x000DA5B4
		// (set) Token: 0x0600226F RID: 8815 RVA: 0x00013353 File Offset: 0x00011553
		public unsafe VisionEvent _HighestVisionEvent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr__HighestVisionEvent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr__HighestVisionEvent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06002270 RID: 8816 RVA: 0x000DC3E4 File Offset: 0x000DA5E4
		// (set) Token: 0x06002271 RID: 8817 RVA: 0x00013372 File Offset: 0x00011572
		public unsafe List<RaycastHit> hits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_hits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RaycastHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_hits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x000DC414 File Offset: 0x000DA614
		// (set) Token: 0x06002273 RID: 8819 RVA: 0x00013391 File Offset: 0x00011591
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x000DC43C File Offset: 0x000DA63C
		// (set) Token: 0x06002275 RID: 8821 RVA: 0x000133AC File Offset: 0x000115AC
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040016D9 RID: 5849
		private static readonly IntPtr NativeFieldInfoPtr_MAX_VISIBLITY;

		// Token: 0x040016DA RID: 5850
		private static readonly IntPtr NativeFieldInfoPtr_CurrentVisibility;

		// Token: 0x040016DB RID: 5851
		private static readonly IntPtr NativeFieldInfoPtr_activeAttributes;

		// Token: 0x040016DC RID: 5852
		private static readonly IntPtr NativeFieldInfoPtr_filteredAttributes;

		// Token: 0x040016DD RID: 5853
		private static readonly IntPtr NativeFieldInfoPtr_visibilityCheckMask;

		// Token: 0x040016DE RID: 5854
		private static readonly IntPtr NativeFieldInfoPtr_visibilityPoints;

		// Token: 0x040016DF RID: 5855
		private static readonly IntPtr NativeFieldInfoPtr_environmentalVisibility;

		// Token: 0x040016E0 RID: 5856
		private static readonly IntPtr NativeFieldInfoPtr__HighestVisionEvent_k__BackingField;

		// Token: 0x040016E1 RID: 5857
		private static readonly IntPtr NativeFieldInfoPtr_hits;

		// Token: 0x040016E2 RID: 5858
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040016E3 RID: 5859
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040016E4 RID: 5860
		private static readonly IntPtr NativeMethodInfoPtr_get_HighestVisionEvent_Public_get_VisionEvent_0;

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeMethodInfoPtr_set_HighestVisionEvent_Public_set_Void_VisionEvent_0;

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x040016E7 RID: 5863
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040016E8 RID: 5864
		private static readonly IntPtr NativeMethodInfoPtr_CalculateVisibility_Private_Single_0;

		// Token: 0x040016E9 RID: 5865
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_VisibilityAttribute_String_0;

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEnvironmentalVisibilityAttribute_Private_Void_0;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeMethodInfoPtr_CalculateExposureToPoint_Public_Single_Vector3_Single_NPC_0;

		// Token: 0x040016EC RID: 5868
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040016ED RID: 5869
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040016EE RID: 5870
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040016EF RID: 5871
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040016F0 RID: 5872
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x020008C5 RID: 2245
		[ObfuscatedName("ScheduleOne.Stealth.PlayerVisibility+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C3B8 RID: 50104 RVA: 0x002FB8D4 File Offset: 0x002F9AD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr);
				PlayerVisibility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9");
				PlayerVisibility.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9__13_0");
				PlayerVisibility.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9__13_1");
				PlayerVisibility.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9__13_2");
				PlayerVisibility.__c.NativeFieldInfoPtr___9__13_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9__13_5");
				PlayerVisibility.__c.NativeFieldInfoPtr___9__13_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9__13_3");
				PlayerVisibility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100667179);
				PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_0_Internal_Boolean_VisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100667180);
				PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_1_Internal_String_UniqueVisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100667181);
				PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_2_Internal_String_IGrouping_2_String_UniqueVisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100667182);
				PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_3_Internal_Single_IGrouping_2_String_UniqueVisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100667183);
				PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_5_Internal_Single_UniqueVisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100667184);
			}

			// Token: 0x0600C3B9 RID: 50105 RVA: 0x002FB9F0 File Offset: 0x002F9BF0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3BA RID: 50106 RVA: 0x002FBA2C File Offset: 0x002F9C2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111511, XrefRangeEnd = 111512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculateVisibility_b__13_0(VisibilityAttribute a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_0_Internal_Boolean_VisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C3BB RID: 50107 RVA: 0x002FBA7C File Offset: 0x002F9C7C
			[CallerCount(0)]
			public unsafe string _CalculateVisibility_b__13_1(UniqueVisibilityAttribute uva)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uva);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_1_Internal_String_UniqueVisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C3BC RID: 50108 RVA: 0x002FBAC4 File Offset: 0x002F9CC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111512, XrefRangeEnd = 111516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CalculateVisibility_b__13_2(IGrouping<string, UniqueVisibilityAttribute> group)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_2_Internal_String_IGrouping_2_String_UniqueVisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C3BD RID: 50109 RVA: 0x002FBB0C File Offset: 0x002F9D0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111516, XrefRangeEnd = 111534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _CalculateVisibility_b__13_3(IGrouping<string, UniqueVisibilityAttribute> group)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_3_Internal_Single_IGrouping_2_String_UniqueVisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C3BE RID: 50110 RVA: 0x002FBB5C File Offset: 0x002F9D5C
			[CallerCount(0)]
			public unsafe float _CalculateVisibility_b__13_5(UniqueVisibilityAttribute uva)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uva);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_5_Internal_Single_UniqueVisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C3BF RID: 50111 RVA: 0x0005F473 File Offset: 0x0005D673
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D1C RID: 15644
			// (get) Token: 0x0600C3C0 RID: 50112 RVA: 0x002FBBAC File Offset: 0x002F9DAC
			// (set) Token: 0x0600C3C1 RID: 50113 RVA: 0x0005F47C File Offset: 0x0005D67C
			public unsafe static PlayerVisibility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisibility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D1D RID: 15645
			// (get) Token: 0x0600C3C2 RID: 50114 RVA: 0x002FBBD4 File Offset: 0x002F9DD4
			// (set) Token: 0x0600C3C3 RID: 50115 RVA: 0x0005F48E File Offset: 0x0005D68E
			public unsafe static Func<VisibilityAttribute, bool> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VisibilityAttribute, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D1E RID: 15646
			// (get) Token: 0x0600C3C4 RID: 50116 RVA: 0x002FBBFC File Offset: 0x002F9DFC
			// (set) Token: 0x0600C3C5 RID: 50117 RVA: 0x0005F4A0 File Offset: 0x0005D6A0
			public unsafe static Func<UniqueVisibilityAttribute, string> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniqueVisibilityAttribute, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D1F RID: 15647
			// (get) Token: 0x0600C3C6 RID: 50118 RVA: 0x002FBC24 File Offset: 0x002F9E24
			// (set) Token: 0x0600C3C7 RID: 50119 RVA: 0x0005F4B2 File Offset: 0x0005D6B2
			public unsafe static Func<IGrouping<string, UniqueVisibilityAttribute>, string> __9__13_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<string, UniqueVisibilityAttribute>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D20 RID: 15648
			// (get) Token: 0x0600C3C8 RID: 50120 RVA: 0x002FBC4C File Offset: 0x002F9E4C
			// (set) Token: 0x0600C3C9 RID: 50121 RVA: 0x0005F4C4 File Offset: 0x0005D6C4
			public unsafe static Func<UniqueVisibilityAttribute, float> __9__13_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniqueVisibilityAttribute, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D21 RID: 15649
			// (get) Token: 0x0600C3CA RID: 50122 RVA: 0x002FBC74 File Offset: 0x002F9E74
			// (set) Token: 0x0600C3CB RID: 50123 RVA: 0x0005F4D6 File Offset: 0x0005D6D6
			public unsafe static Func<IGrouping<string, UniqueVisibilityAttribute>, float> __9__13_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<string, UniqueVisibilityAttribute>, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084B1 RID: 33969
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040084B2 RID: 33970
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x040084B3 RID: 33971
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x040084B4 RID: 33972
			private static readonly IntPtr NativeFieldInfoPtr___9__13_2;

			// Token: 0x040084B5 RID: 33973
			private static readonly IntPtr NativeFieldInfoPtr___9__13_5;

			// Token: 0x040084B6 RID: 33974
			private static readonly IntPtr NativeFieldInfoPtr___9__13_3;

			// Token: 0x040084B7 RID: 33975
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084B8 RID: 33976
			private static readonly IntPtr NativeMethodInfoPtr__CalculateVisibility_b__13_0_Internal_Boolean_VisibilityAttribute_0;

			// Token: 0x040084B9 RID: 33977
			private static readonly IntPtr NativeMethodInfoPtr__CalculateVisibility_b__13_1_Internal_String_UniqueVisibilityAttribute_0;

			// Token: 0x040084BA RID: 33978
			private static readonly IntPtr NativeMethodInfoPtr__CalculateVisibility_b__13_2_Internal_String_IGrouping_2_String_UniqueVisibilityAttribute_0;

			// Token: 0x040084BB RID: 33979
			private static readonly IntPtr NativeMethodInfoPtr__CalculateVisibility_b__13_3_Internal_Single_IGrouping_2_String_UniqueVisibilityAttribute_0;

			// Token: 0x040084BC RID: 33980
			private static readonly IntPtr NativeMethodInfoPtr__CalculateVisibility_b__13_5_Internal_Single_UniqueVisibilityAttribute_0;
		}

		// Token: 0x020008C6 RID: 2246
		[ObfuscatedName("ScheduleOne.Stealth.PlayerVisibility+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C3CC RID: 50124 RVA: 0x002FBC9C File Offset: 0x002F9E9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass13_0>.NativeClassPtr);
				PlayerVisibility.__c__DisplayClass13_0.NativeFieldInfoPtr_maxPointsChangesByUniquenessCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass13_0>.NativeClassPtr, "maxPointsChangesByUniquenessCode");
				PlayerVisibility.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass13_0>.NativeClassPtr, 100667185);
				PlayerVisibility.__c__DisplayClass13_0.NativeMethodInfoPtr__CalculateVisibility_b__4_Internal_Boolean_VisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass13_0>.NativeClassPtr, 100667186);
			}

			// Token: 0x0600C3CD RID: 50125 RVA: 0x002FBD04 File Offset: 0x002F9F04
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3CE RID: 50126 RVA: 0x002FBD40 File Offset: 0x002F9F40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111534, XrefRangeEnd = 111539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculateVisibility_b__4(VisibilityAttribute attr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c__DisplayClass13_0.NativeMethodInfoPtr__CalculateVisibility_b__4_Internal_Boolean_VisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C3CF RID: 50127 RVA: 0x0005F4E8 File Offset: 0x0005D6E8
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D22 RID: 15650
			// (get) Token: 0x0600C3D0 RID: 50128 RVA: 0x002FBD90 File Offset: 0x002F9F90
			// (set) Token: 0x0600C3D1 RID: 50129 RVA: 0x0005F4F1 File Offset: 0x0005D6F1
			public unsafe Dictionary<string, float> maxPointsChangesByUniquenessCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.__c__DisplayClass13_0.NativeFieldInfoPtr_maxPointsChangesByUniquenessCode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.__c__DisplayClass13_0.NativeFieldInfoPtr_maxPointsChangesByUniquenessCode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084BD RID: 33981
			private static readonly IntPtr NativeFieldInfoPtr_maxPointsChangesByUniquenessCode;

			// Token: 0x040084BE RID: 33982
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084BF RID: 33983
			private static readonly IntPtr NativeMethodInfoPtr__CalculateVisibility_b__4_Internal_Boolean_VisibilityAttribute_0;
		}

		// Token: 0x020008C7 RID: 2247
		[ObfuscatedName("ScheduleOne.Stealth.PlayerVisibility+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C3D2 RID: 50130 RVA: 0x002FBDC0 File Offset: 0x002F9FC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass14_0>.NativeClassPtr);
				PlayerVisibility.__c__DisplayClass14_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass14_0>.NativeClassPtr, "name");
				PlayerVisibility.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass14_0>.NativeClassPtr, 100667187);
				PlayerVisibility.__c__DisplayClass14_0.NativeMethodInfoPtr__GetAttribute_b__0_Internal_Boolean_VisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass14_0>.NativeClassPtr, 100667188);
			}

			// Token: 0x0600C3D3 RID: 50131 RVA: 0x002FBE28 File Offset: 0x002FA028
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3D4 RID: 50132 RVA: 0x002FBE64 File Offset: 0x002FA064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111539, XrefRangeEnd = 111543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAttribute_b__0(VisibilityAttribute x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c__DisplayClass14_0.NativeMethodInfoPtr__GetAttribute_b__0_Internal_Boolean_VisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C3D5 RID: 50133 RVA: 0x0005F510 File Offset: 0x0005D710
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D23 RID: 15651
			// (get) Token: 0x0600C3D6 RID: 50134 RVA: 0x002FBEB4 File Offset: 0x002FA0B4
			// (set) Token: 0x0600C3D7 RID: 50135 RVA: 0x0005F519 File Offset: 0x0005D719
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.__c__DisplayClass14_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.__c__DisplayClass14_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040084C0 RID: 33984
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040084C1 RID: 33985
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084C2 RID: 33986
			private static readonly IntPtr NativeMethodInfoPtr__GetAttribute_b__0_Internal_Boolean_VisibilityAttribute_0;
		}
	}
}
