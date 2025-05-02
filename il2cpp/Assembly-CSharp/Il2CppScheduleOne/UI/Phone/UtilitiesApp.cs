using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006A0 RID: 1696
	public class UtilitiesApp : App<UtilitiesApp>
	{
		// Token: 0x06009765 RID: 38757 RVA: 0x0026B4D8 File Offset: 0x002696D8
		// Note: this type is marked as 'beforefieldinit'.
		static UtilitiesApp()
		{
			Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "UtilitiesApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr);
			UtilitiesApp.NativeFieldInfoPtr_water_Usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "water_Usage");
			UtilitiesApp.NativeFieldInfoPtr_water_Cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "water_Cost");
			UtilitiesApp.NativeFieldInfoPtr_water_Total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "water_Total");
			UtilitiesApp.NativeFieldInfoPtr_electricity_Usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "electricity_Usage");
			UtilitiesApp.NativeFieldInfoPtr_electricity_Cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "electricity_Cost");
			UtilitiesApp.NativeFieldInfoPtr_electricity_Total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "electricity_Total");
			UtilitiesApp.NativeFieldInfoPtr_dumpster_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "dumpster_Count");
			UtilitiesApp.NativeFieldInfoPtr_dumpster_EmptyCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "dumpster_EmptyCost");
			UtilitiesApp.NativeFieldInfoPtr_dumpster_Total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "dumpster_Total");
			UtilitiesApp.NativeFieldInfoPtr_dumpsterButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "dumpsterButton");
			UtilitiesApp.NativeFieldInfoPtr_propertySelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "propertySelector");
			UtilitiesApp.NativeFieldInfoPtr_selectedProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "selectedProperty");
			UtilitiesApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100681979);
			UtilitiesApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100681980);
			UtilitiesApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100681981);
			UtilitiesApp.NativeMethodInfoPtr_RefreshShownValues_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100681982);
			UtilitiesApp.NativeMethodInfoPtr_OnDayPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100681983);
			UtilitiesApp.NativeMethodInfoPtr_Round_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100681984);
			UtilitiesApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100681985);
			UtilitiesApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100681986);
		}

		// Token: 0x06009766 RID: 38758 RVA: 0x0026B698 File Offset: 0x00269898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271177, XrefRangeEnd = 271235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UtilitiesApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009767 RID: 38759 RVA: 0x0026B6D4 File Offset: 0x002698D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271235, XrefRangeEnd = 271267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UtilitiesApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009768 RID: 38760 RVA: 0x0026B710 File Offset: 0x00269910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271267, XrefRangeEnd = 271272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UtilitiesApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009769 RID: 38761 RVA: 0x0026B74C File Offset: 0x0026994C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271272, XrefRangeEnd = 271331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshShownValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UtilitiesApp.NativeMethodInfoPtr_RefreshShownValues_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600976A RID: 38762 RVA: 0x0026B788 File Offset: 0x00269988
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UtilitiesApp.NativeMethodInfoPtr_OnDayPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600976B RID: 38763 RVA: 0x0026B7C4 File Offset: 0x002699C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271331, XrefRangeEnd = 271334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Round(float n, float decimals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref n;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decimals;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilitiesApp.NativeMethodInfoPtr_Round_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600976C RID: 38764 RVA: 0x0026B81C File Offset: 0x00269A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271334, XrefRangeEnd = 271337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UtilitiesApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600976D RID: 38765 RVA: 0x0026B868 File Offset: 0x00269A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271337, XrefRangeEnd = 271343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UtilitiesApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilitiesApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600976E RID: 38766 RVA: 0x000499A3 File Offset: 0x00047BA3
		public UtilitiesApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E6F RID: 11887
		// (get) Token: 0x0600976F RID: 38767 RVA: 0x0026B8A4 File Offset: 0x00269AA4
		// (set) Token: 0x06009770 RID: 38768 RVA: 0x000499AC File Offset: 0x00047BAC
		public unsafe Text water_Usage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_water_Usage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_water_Usage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E70 RID: 11888
		// (get) Token: 0x06009771 RID: 38769 RVA: 0x0026B8D4 File Offset: 0x00269AD4
		// (set) Token: 0x06009772 RID: 38770 RVA: 0x000499CB File Offset: 0x00047BCB
		public unsafe Text water_Cost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_water_Cost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_water_Cost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E71 RID: 11889
		// (get) Token: 0x06009773 RID: 38771 RVA: 0x0026B904 File Offset: 0x00269B04
		// (set) Token: 0x06009774 RID: 38772 RVA: 0x000499EA File Offset: 0x00047BEA
		public unsafe Text water_Total
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_water_Total);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_water_Total), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E72 RID: 11890
		// (get) Token: 0x06009775 RID: 38773 RVA: 0x0026B934 File Offset: 0x00269B34
		// (set) Token: 0x06009776 RID: 38774 RVA: 0x00049A09 File Offset: 0x00047C09
		public unsafe Text electricity_Usage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_electricity_Usage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_electricity_Usage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E73 RID: 11891
		// (get) Token: 0x06009777 RID: 38775 RVA: 0x0026B964 File Offset: 0x00269B64
		// (set) Token: 0x06009778 RID: 38776 RVA: 0x00049A28 File Offset: 0x00047C28
		public unsafe Text electricity_Cost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_electricity_Cost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_electricity_Cost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E74 RID: 11892
		// (get) Token: 0x06009779 RID: 38777 RVA: 0x0026B994 File Offset: 0x00269B94
		// (set) Token: 0x0600977A RID: 38778 RVA: 0x00049A47 File Offset: 0x00047C47
		public unsafe Text electricity_Total
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_electricity_Total);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_electricity_Total), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E75 RID: 11893
		// (get) Token: 0x0600977B RID: 38779 RVA: 0x0026B9C4 File Offset: 0x00269BC4
		// (set) Token: 0x0600977C RID: 38780 RVA: 0x00049A66 File Offset: 0x00047C66
		public unsafe Text dumpster_Count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpster_Count);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpster_Count), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E76 RID: 11894
		// (get) Token: 0x0600977D RID: 38781 RVA: 0x0026B9F4 File Offset: 0x00269BF4
		// (set) Token: 0x0600977E RID: 38782 RVA: 0x00049A85 File Offset: 0x00047C85
		public unsafe Text dumpster_EmptyCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpster_EmptyCost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpster_EmptyCost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E77 RID: 11895
		// (get) Token: 0x0600977F RID: 38783 RVA: 0x0026BA24 File Offset: 0x00269C24
		// (set) Token: 0x06009780 RID: 38784 RVA: 0x00049AA4 File Offset: 0x00047CA4
		public unsafe Text dumpster_Total
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpster_Total);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpster_Total), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E78 RID: 11896
		// (get) Token: 0x06009781 RID: 38785 RVA: 0x0026BA54 File Offset: 0x00269C54
		// (set) Token: 0x06009782 RID: 38786 RVA: 0x00049AC3 File Offset: 0x00047CC3
		public unsafe Button dumpsterButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpsterButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpsterButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E79 RID: 11897
		// (get) Token: 0x06009783 RID: 38787 RVA: 0x0026BA84 File Offset: 0x00269C84
		// (set) Token: 0x06009784 RID: 38788 RVA: 0x00049AE2 File Offset: 0x00047CE2
		public unsafe PropertyDropdown propertySelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_propertySelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyDropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_propertySelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E7A RID: 11898
		// (get) Token: 0x06009785 RID: 38789 RVA: 0x0026BAB4 File Offset: 0x00269CB4
		// (set) Token: 0x06009786 RID: 38790 RVA: 0x00049B01 File Offset: 0x00047D01
		public unsafe Property selectedProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_selectedProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_selectedProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006602 RID: 26114
		private static readonly IntPtr NativeFieldInfoPtr_water_Usage;

		// Token: 0x04006603 RID: 26115
		private static readonly IntPtr NativeFieldInfoPtr_water_Cost;

		// Token: 0x04006604 RID: 26116
		private static readonly IntPtr NativeFieldInfoPtr_water_Total;

		// Token: 0x04006605 RID: 26117
		private static readonly IntPtr NativeFieldInfoPtr_electricity_Usage;

		// Token: 0x04006606 RID: 26118
		private static readonly IntPtr NativeFieldInfoPtr_electricity_Cost;

		// Token: 0x04006607 RID: 26119
		private static readonly IntPtr NativeFieldInfoPtr_electricity_Total;

		// Token: 0x04006608 RID: 26120
		private static readonly IntPtr NativeFieldInfoPtr_dumpster_Count;

		// Token: 0x04006609 RID: 26121
		private static readonly IntPtr NativeFieldInfoPtr_dumpster_EmptyCost;

		// Token: 0x0400660A RID: 26122
		private static readonly IntPtr NativeFieldInfoPtr_dumpster_Total;

		// Token: 0x0400660B RID: 26123
		private static readonly IntPtr NativeFieldInfoPtr_dumpsterButton;

		// Token: 0x0400660C RID: 26124
		private static readonly IntPtr NativeFieldInfoPtr_propertySelector;

		// Token: 0x0400660D RID: 26125
		private static readonly IntPtr NativeFieldInfoPtr_selectedProperty;

		// Token: 0x0400660E RID: 26126
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400660F RID: 26127
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04006610 RID: 26128
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04006611 RID: 26129
		private static readonly IntPtr NativeMethodInfoPtr_RefreshShownValues_Protected_Virtual_New_Void_0;

		// Token: 0x04006612 RID: 26130
		private static readonly IntPtr NativeMethodInfoPtr_OnDayPass_Protected_Virtual_New_Void_0;

		// Token: 0x04006613 RID: 26131
		private static readonly IntPtr NativeMethodInfoPtr_Round_Private_Single_Single_Single_0;

		// Token: 0x04006614 RID: 26132
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006615 RID: 26133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
