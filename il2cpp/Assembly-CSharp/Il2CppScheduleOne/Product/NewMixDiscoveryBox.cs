using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005A4 RID: 1444
	public class NewMixDiscoveryBox : MonoBehaviour
	{
		// Token: 0x06007E34 RID: 32308 RVA: 0x0021C5E0 File Offset: 0x0021A7E0
		// Note: this type is marked as 'beforefieldinit'.
		static NewMixDiscoveryBox()
		{
			Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "NewMixDiscoveryBox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr);
			NewMixDiscoveryBox.NativeFieldInfoPtr_isOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "isOpen");
			NewMixDiscoveryBox.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "CameraPosition");
			NewMixDiscoveryBox.NativeFieldInfoPtr_PropertiesText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "PropertiesText");
			NewMixDiscoveryBox.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "Visuals");
			NewMixDiscoveryBox.NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "Animation");
			NewMixDiscoveryBox.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "IntObj");
			NewMixDiscoveryBox.NativeFieldInfoPtr_Lid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "Lid");
			NewMixDiscoveryBox.NativeFieldInfoPtr_closedLidPose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "closedLidPose");
			NewMixDiscoveryBox.NativeFieldInfoPtr_currentMix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "currentMix");
			NewMixDiscoveryBox.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679077);
			NewMixDiscoveryBox.NativeMethodInfoPtr_ShowProduct_Public_Void_ProductDefinition_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679078);
			NewMixDiscoveryBox.NativeMethodInfoPtr_CloseCase_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679079);
			NewMixDiscoveryBox.NativeMethodInfoPtr_OpenCase_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679080);
			NewMixDiscoveryBox.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679081);
			NewMixDiscoveryBox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679082);
		}

		// Token: 0x06007E35 RID: 32309 RVA: 0x0021C73C File Offset: 0x0021A93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238977, XrefRangeEnd = 238995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E36 RID: 32310 RVA: 0x0021C770 File Offset: 0x0021A970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 239203, RefRangeEnd = 239205, XrefRangeStart = 238995, XrefRangeEnd = 239203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowProduct(ProductDefinition baseDefinition, List<Property> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseDefinition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_ShowProduct_Public_Void_ProductDefinition_List_1_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E37 RID: 32311 RVA: 0x0021C7C4 File Offset: 0x0021A9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239205, XrefRangeEnd = 239207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseCase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_CloseCase_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E38 RID: 32312 RVA: 0x0021C7F8 File Offset: 0x0021A9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239207, XrefRangeEnd = 239211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenCase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_OpenCase_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E39 RID: 32313 RVA: 0x0021C82C File Offset: 0x0021AA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239211, XrefRangeEnd = 239216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E3A RID: 32314 RVA: 0x0021C860 File Offset: 0x0021AA60
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewMixDiscoveryBox() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E3B RID: 32315 RVA: 0x0003BF60 File Offset: 0x0003A160
		public NewMixDiscoveryBox(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700262A RID: 9770
		// (get) Token: 0x06007E3C RID: 32316 RVA: 0x0021C89C File Offset: 0x0021AA9C
		// (set) Token: 0x06007E3D RID: 32317 RVA: 0x0003BF69 File Offset: 0x0003A169
		public unsafe bool isOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_isOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_isOpen)) = value;
			}
		}

		// Token: 0x1700262B RID: 9771
		// (get) Token: 0x06007E3E RID: 32318 RVA: 0x0021C8C4 File Offset: 0x0021AAC4
		// (set) Token: 0x06007E3F RID: 32319 RVA: 0x0003BF84 File Offset: 0x0003A184
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700262C RID: 9772
		// (get) Token: 0x06007E40 RID: 32320 RVA: 0x0021C8F4 File Offset: 0x0021AAF4
		// (set) Token: 0x06007E41 RID: 32321 RVA: 0x0003BFA3 File Offset: 0x0003A1A3
		public unsafe TextMeshPro PropertiesText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_PropertiesText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_PropertiesText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700262D RID: 9773
		// (get) Token: 0x06007E42 RID: 32322 RVA: 0x0021C924 File Offset: 0x0021AB24
		// (set) Token: 0x06007E43 RID: 32323 RVA: 0x0003BFC2 File Offset: 0x0003A1C2
		public unsafe Il2CppReferenceArray<NewMixDiscoveryBox.DrugTypeVisuals> Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NewMixDiscoveryBox.DrugTypeVisuals>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700262E RID: 9774
		// (get) Token: 0x06007E44 RID: 32324 RVA: 0x0021C954 File Offset: 0x0021AB54
		// (set) Token: 0x06007E45 RID: 32325 RVA: 0x0003BFE1 File Offset: 0x0003A1E1
		public unsafe Animation Animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700262F RID: 9775
		// (get) Token: 0x06007E46 RID: 32326 RVA: 0x0021C984 File Offset: 0x0021AB84
		// (set) Token: 0x06007E47 RID: 32327 RVA: 0x0003C000 File Offset: 0x0003A200
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002630 RID: 9776
		// (get) Token: 0x06007E48 RID: 32328 RVA: 0x0021C9B4 File Offset: 0x0021ABB4
		// (set) Token: 0x06007E49 RID: 32329 RVA: 0x0003C01F File Offset: 0x0003A21F
		public unsafe Transform Lid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Lid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Lid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002631 RID: 9777
		// (get) Token: 0x06007E4A RID: 32330 RVA: 0x0021C9E4 File Offset: 0x0021ABE4
		// (set) Token: 0x06007E4B RID: 32331 RVA: 0x0003C03E File Offset: 0x0003A23E
		public unsafe Pose closedLidPose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_closedLidPose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_closedLidPose)) = value;
			}
		}

		// Token: 0x17002632 RID: 9778
		// (get) Token: 0x06007E4C RID: 32332 RVA: 0x0021CA0C File Offset: 0x0021AC0C
		// (set) Token: 0x06007E4D RID: 32333 RVA: 0x0003C059 File Offset: 0x0003A259
		public unsafe NewMixOperation currentMix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_currentMix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NewMixOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_currentMix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040055E5 RID: 21989
		private static readonly IntPtr NativeFieldInfoPtr_isOpen;

		// Token: 0x040055E6 RID: 21990
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x040055E7 RID: 21991
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesText;

		// Token: 0x040055E8 RID: 21992
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040055E9 RID: 21993
		private static readonly IntPtr NativeFieldInfoPtr_Animation;

		// Token: 0x040055EA RID: 21994
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x040055EB RID: 21995
		private static readonly IntPtr NativeFieldInfoPtr_Lid;

		// Token: 0x040055EC RID: 21996
		private static readonly IntPtr NativeFieldInfoPtr_closedLidPose;

		// Token: 0x040055ED RID: 21997
		private static readonly IntPtr NativeFieldInfoPtr_currentMix;

		// Token: 0x040055EE RID: 21998
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040055EF RID: 21999
		private static readonly IntPtr NativeMethodInfoPtr_ShowProduct_Public_Void_ProductDefinition_List_1_Property_0;

		// Token: 0x040055F0 RID: 22000
		private static readonly IntPtr NativeMethodInfoPtr_CloseCase_Private_Void_0;

		// Token: 0x040055F1 RID: 22001
		private static readonly IntPtr NativeMethodInfoPtr_OpenCase_Private_Void_0;

		// Token: 0x040055F2 RID: 22002
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x040055F3 RID: 22003
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AC7 RID: 2759
		[Serializable]
		public class DrugTypeVisuals : Il2CppSystem.Object
		{
			// Token: 0x0600D42F RID: 54319 RVA: 0x0032A710 File Offset: 0x00328910
			// Note: this type is marked as 'beforefieldinit'.
			static DrugTypeVisuals()
			{
				Il2CppClassPointerStore<NewMixDiscoveryBox.DrugTypeVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "DrugTypeVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMixDiscoveryBox.DrugTypeVisuals>.NativeClassPtr);
				NewMixDiscoveryBox.DrugTypeVisuals.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.DrugTypeVisuals>.NativeClassPtr, "DrugType");
				NewMixDiscoveryBox.DrugTypeVisuals.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.DrugTypeVisuals>.NativeClassPtr, "Visuals");
				NewMixDiscoveryBox.DrugTypeVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.DrugTypeVisuals>.NativeClassPtr, 100679083);
			}

			// Token: 0x0600D430 RID: 54320 RVA: 0x0032A778 File Offset: 0x00328978
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DrugTypeVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixDiscoveryBox.DrugTypeVisuals>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.DrugTypeVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D431 RID: 54321 RVA: 0x0006745E File Offset: 0x0006565E
			public DrugTypeVisuals(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041C7 RID: 16839
			// (get) Token: 0x0600D432 RID: 54322 RVA: 0x0032A7B4 File Offset: 0x003289B4
			// (set) Token: 0x0600D433 RID: 54323 RVA: 0x00067467 File Offset: 0x00065667
			public unsafe EDrugType DrugType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.DrugTypeVisuals.NativeFieldInfoPtr_DrugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.DrugTypeVisuals.NativeFieldInfoPtr_DrugType)) = value;
				}
			}

			// Token: 0x170041C8 RID: 16840
			// (get) Token: 0x0600D434 RID: 54324 RVA: 0x0032A7DC File Offset: 0x003289DC
			// (set) Token: 0x0600D435 RID: 54325 RVA: 0x00067482 File Offset: 0x00065682
			public unsafe FilledPackagingVisuals Visuals
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.DrugTypeVisuals.NativeFieldInfoPtr_Visuals);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.DrugTypeVisuals.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EE0 RID: 36576
			private static readonly IntPtr NativeFieldInfoPtr_DrugType;

			// Token: 0x04008EE1 RID: 36577
			private static readonly IntPtr NativeFieldInfoPtr_Visuals;

			// Token: 0x04008EE2 RID: 36578
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AC8 RID: 2760
		[ObfuscatedName("ScheduleOne.Product.NewMixDiscoveryBox+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D436 RID: 54326 RVA: 0x0032A80C File Offset: 0x00328A0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr);
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9");
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9__11_0");
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9__11_1");
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9__11_2");
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9__11_3");
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9__11_4");
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9__11_5");
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679085);
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_0_Internal_Boolean_DrugTypeVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679086);
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_1_Internal_Boolean_DrugTypeVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679087);
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_2_Internal_Boolean_DrugTypeVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679088);
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_3_Internal_Boolean_DrugTypeVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679089);
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_4_Internal_Boolean_DrugTypeVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679090);
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_5_Internal_Boolean_DrugTypeVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679091);
			}

			// Token: 0x0600D437 RID: 54327 RVA: 0x0032A950 File Offset: 0x00328B50
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D438 RID: 54328 RVA: 0x0032A98C File Offset: 0x00328B8C
			[CallerCount(0)]
			public unsafe bool _ShowProduct_b__11_0(NewMixDiscoveryBox.DrugTypeVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_0_Internal_Boolean_DrugTypeVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D439 RID: 54329 RVA: 0x0032A9DC File Offset: 0x00328BDC
			[CallerCount(0)]
			public unsafe bool _ShowProduct_b__11_1(NewMixDiscoveryBox.DrugTypeVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_1_Internal_Boolean_DrugTypeVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D43A RID: 54330 RVA: 0x0032AA2C File Offset: 0x00328C2C
			[CallerCount(0)]
			public unsafe bool _ShowProduct_b__11_2(NewMixDiscoveryBox.DrugTypeVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_2_Internal_Boolean_DrugTypeVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D43B RID: 54331 RVA: 0x0032AA7C File Offset: 0x00328C7C
			[CallerCount(0)]
			public unsafe bool _ShowProduct_b__11_3(NewMixDiscoveryBox.DrugTypeVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_3_Internal_Boolean_DrugTypeVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D43C RID: 54332 RVA: 0x0032AACC File Offset: 0x00328CCC
			[CallerCount(0)]
			public unsafe bool _ShowProduct_b__11_4(NewMixDiscoveryBox.DrugTypeVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_4_Internal_Boolean_DrugTypeVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D43D RID: 54333 RVA: 0x0032AB1C File Offset: 0x00328D1C
			[CallerCount(0)]
			public unsafe bool _ShowProduct_b__11_5(NewMixDiscoveryBox.DrugTypeVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_5_Internal_Boolean_DrugTypeVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D43E RID: 54334 RVA: 0x000674A1 File Offset: 0x000656A1
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041C9 RID: 16841
			// (get) Token: 0x0600D43F RID: 54335 RVA: 0x0032AB6C File Offset: 0x00328D6C
			// (set) Token: 0x0600D440 RID: 54336 RVA: 0x000674AA File Offset: 0x000656AA
			public unsafe static NewMixDiscoveryBox.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NewMixDiscoveryBox.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041CA RID: 16842
			// (get) Token: 0x0600D441 RID: 54337 RVA: 0x0032AB94 File Offset: 0x00328D94
			// (set) Token: 0x0600D442 RID: 54338 RVA: 0x000674BC File Offset: 0x000656BC
			public unsafe static Func<NewMixDiscoveryBox.DrugTypeVisuals, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NewMixDiscoveryBox.DrugTypeVisuals, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041CB RID: 16843
			// (get) Token: 0x0600D443 RID: 54339 RVA: 0x0032ABBC File Offset: 0x00328DBC
			// (set) Token: 0x0600D444 RID: 54340 RVA: 0x000674CE File Offset: 0x000656CE
			public unsafe static Func<NewMixDiscoveryBox.DrugTypeVisuals, bool> __9__11_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NewMixDiscoveryBox.DrugTypeVisuals, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041CC RID: 16844
			// (get) Token: 0x0600D445 RID: 54341 RVA: 0x0032ABE4 File Offset: 0x00328DE4
			// (set) Token: 0x0600D446 RID: 54342 RVA: 0x000674E0 File Offset: 0x000656E0
			public unsafe static Func<NewMixDiscoveryBox.DrugTypeVisuals, bool> __9__11_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NewMixDiscoveryBox.DrugTypeVisuals, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041CD RID: 16845
			// (get) Token: 0x0600D447 RID: 54343 RVA: 0x0032AC0C File Offset: 0x00328E0C
			// (set) Token: 0x0600D448 RID: 54344 RVA: 0x000674F2 File Offset: 0x000656F2
			public unsafe static Func<NewMixDiscoveryBox.DrugTypeVisuals, bool> __9__11_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NewMixDiscoveryBox.DrugTypeVisuals, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041CE RID: 16846
			// (get) Token: 0x0600D449 RID: 54345 RVA: 0x0032AC34 File Offset: 0x00328E34
			// (set) Token: 0x0600D44A RID: 54346 RVA: 0x00067504 File Offset: 0x00065704
			public unsafe static Func<NewMixDiscoveryBox.DrugTypeVisuals, bool> __9__11_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NewMixDiscoveryBox.DrugTypeVisuals, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041CF RID: 16847
			// (get) Token: 0x0600D44B RID: 54347 RVA: 0x0032AC5C File Offset: 0x00328E5C
			// (set) Token: 0x0600D44C RID: 54348 RVA: 0x00067516 File Offset: 0x00065716
			public unsafe static Func<NewMixDiscoveryBox.DrugTypeVisuals, bool> __9__11_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NewMixDiscoveryBox.DrugTypeVisuals, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EE3 RID: 36579
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008EE4 RID: 36580
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04008EE5 RID: 36581
			private static readonly IntPtr NativeFieldInfoPtr___9__11_1;

			// Token: 0x04008EE6 RID: 36582
			private static readonly IntPtr NativeFieldInfoPtr___9__11_2;

			// Token: 0x04008EE7 RID: 36583
			private static readonly IntPtr NativeFieldInfoPtr___9__11_3;

			// Token: 0x04008EE8 RID: 36584
			private static readonly IntPtr NativeFieldInfoPtr___9__11_4;

			// Token: 0x04008EE9 RID: 36585
			private static readonly IntPtr NativeFieldInfoPtr___9__11_5;

			// Token: 0x04008EEA RID: 36586
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EEB RID: 36587
			private static readonly IntPtr NativeMethodInfoPtr__ShowProduct_b__11_0_Internal_Boolean_DrugTypeVisuals_0;

			// Token: 0x04008EEC RID: 36588
			private static readonly IntPtr NativeMethodInfoPtr__ShowProduct_b__11_1_Internal_Boolean_DrugTypeVisuals_0;

			// Token: 0x04008EED RID: 36589
			private static readonly IntPtr NativeMethodInfoPtr__ShowProduct_b__11_2_Internal_Boolean_DrugTypeVisuals_0;

			// Token: 0x04008EEE RID: 36590
			private static readonly IntPtr NativeMethodInfoPtr__ShowProduct_b__11_3_Internal_Boolean_DrugTypeVisuals_0;

			// Token: 0x04008EEF RID: 36591
			private static readonly IntPtr NativeMethodInfoPtr__ShowProduct_b__11_4_Internal_Boolean_DrugTypeVisuals_0;

			// Token: 0x04008EF0 RID: 36592
			private static readonly IntPtr NativeMethodInfoPtr__ShowProduct_b__11_5_Internal_Boolean_DrugTypeVisuals_0;
		}
	}
}
