using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000617 RID: 1559
	[Serializable]
	public class BasicAvatarSettings : ScriptableObject
	{
		// Token: 0x0600899D RID: 35229 RVA: 0x00242320 File Offset: 0x00240520
		// Note: this type is marked as 'beforefieldinit'.
		static BasicAvatarSettings()
		{
			Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "BasicAvatarSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr);
			BasicAvatarSettings.NativeFieldInfoPtr_GENDER_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "GENDER_MULTIPLIER");
			BasicAvatarSettings.NativeFieldInfoPtr_MaleUnderwearPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "MaleUnderwearPath");
			BasicAvatarSettings.NativeFieldInfoPtr_FemaleUnderwearPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "FemaleUnderwearPath");
			BasicAvatarSettings.NativeFieldInfoPtr_Gender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Gender");
			BasicAvatarSettings.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Weight");
			BasicAvatarSettings.NativeFieldInfoPtr_SkinColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "SkinColor");
			BasicAvatarSettings.NativeFieldInfoPtr_HairStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "HairStyle");
			BasicAvatarSettings.NativeFieldInfoPtr_HairColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "HairColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Mouth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Mouth");
			BasicAvatarSettings.NativeFieldInfoPtr_FacialHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "FacialHair");
			BasicAvatarSettings.NativeFieldInfoPtr_FacialDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "FacialDetails");
			BasicAvatarSettings.NativeFieldInfoPtr_FacialDetailsIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "FacialDetailsIntensity");
			BasicAvatarSettings.NativeFieldInfoPtr_EyeballColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyeballColor");
			BasicAvatarSettings.NativeFieldInfoPtr_UpperEyeLidRestingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "UpperEyeLidRestingPosition");
			BasicAvatarSettings.NativeFieldInfoPtr_LowerEyeLidRestingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "LowerEyeLidRestingPosition");
			BasicAvatarSettings.NativeFieldInfoPtr_PupilDilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "PupilDilation");
			BasicAvatarSettings.NativeFieldInfoPtr_EyebrowScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyebrowScale");
			BasicAvatarSettings.NativeFieldInfoPtr_EyebrowThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyebrowThickness");
			BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyebrowRestingHeight");
			BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyebrowRestingAngle");
			BasicAvatarSettings.NativeFieldInfoPtr_Top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Top");
			BasicAvatarSettings.NativeFieldInfoPtr_TopColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "TopColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Bottom");
			BasicAvatarSettings.NativeFieldInfoPtr_BottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "BottomColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Shoes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Shoes");
			BasicAvatarSettings.NativeFieldInfoPtr_ShoesColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "ShoesColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Headwear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Headwear");
			BasicAvatarSettings.NativeFieldInfoPtr_HeadwearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "HeadwearColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Eyewear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Eyewear");
			BasicAvatarSettings.NativeFieldInfoPtr_EyewearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyewearColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Tattoos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Tattoos");
			BasicAvatarSettings.NativeMethodInfoPtr_SetValue_Public_T_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100680425);
			BasicAvatarSettings.NativeMethodInfoPtr_GetValue_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100680426);
			BasicAvatarSettings.NativeMethodInfoPtr_GetAvatarSettings_Public_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100680427);
			BasicAvatarSettings.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100680428);
			BasicAvatarSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100680429);
		}

		// Token: 0x0600899E RID: 35230 RVA: 0x00242620 File Offset: 0x00240820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253776, XrefRangeEnd = 253781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T SetValue<T>(string fieldName, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicAvatarSettings.MethodInfoStoreGeneric_SetValue_Public_T_String_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600899F RID: 35231 RVA: 0x002426C8 File Offset: 0x002408C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253787, RefRangeEnd = 253788, XrefRangeStart = 253781, XrefRangeEnd = 253787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetValue<T>(string fieldName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicAvatarSettings.MethodInfoStoreGeneric_GetValue_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060089A0 RID: 35232 RVA: 0x00242714 File Offset: 0x00240914
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 253890, RefRangeEnd = 253901, XrefRangeStart = 253788, XrefRangeEnd = 253890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSettings GetAvatarSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicAvatarSettings.NativeMethodInfoPtr_GetAvatarSettings_Public_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr3) : null;
		}

		// Token: 0x060089A1 RID: 35233 RVA: 0x00242754 File Offset: 0x00240954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetJson(bool prettyPrint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref prettyPrint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicAvatarSettings.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060089A2 RID: 35234 RVA: 0x002427A4 File Offset: 0x002409A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253901, XrefRangeEnd = 253909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicAvatarSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicAvatarSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089A3 RID: 35235 RVA: 0x00041B6D File Offset: 0x0003FD6D
		public BasicAvatarSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029ED RID: 10733
		// (get) Token: 0x060089A4 RID: 35236 RVA: 0x002427E0 File Offset: 0x002409E0
		// (set) Token: 0x060089A5 RID: 35237 RVA: 0x00041B76 File Offset: 0x0003FD76
		public unsafe static float GENDER_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BasicAvatarSettings.NativeFieldInfoPtr_GENDER_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BasicAvatarSettings.NativeFieldInfoPtr_GENDER_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x170029EE RID: 10734
		// (get) Token: 0x060089A6 RID: 35238 RVA: 0x002427FC File Offset: 0x002409FC
		// (set) Token: 0x060089A7 RID: 35239 RVA: 0x00041B84 File Offset: 0x0003FD84
		public unsafe static string MaleUnderwearPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BasicAvatarSettings.NativeFieldInfoPtr_MaleUnderwearPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BasicAvatarSettings.NativeFieldInfoPtr_MaleUnderwearPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029EF RID: 10735
		// (get) Token: 0x060089A8 RID: 35240 RVA: 0x0024281C File Offset: 0x00240A1C
		// (set) Token: 0x060089A9 RID: 35241 RVA: 0x00041B96 File Offset: 0x0003FD96
		public unsafe static string FemaleUnderwearPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BasicAvatarSettings.NativeFieldInfoPtr_FemaleUnderwearPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BasicAvatarSettings.NativeFieldInfoPtr_FemaleUnderwearPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029F0 RID: 10736
		// (get) Token: 0x060089AA RID: 35242 RVA: 0x0024283C File Offset: 0x00240A3C
		// (set) Token: 0x060089AB RID: 35243 RVA: 0x00041BA8 File Offset: 0x0003FDA8
		public unsafe int Gender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Gender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Gender)) = value;
			}
		}

		// Token: 0x170029F1 RID: 10737
		// (get) Token: 0x060089AC RID: 35244 RVA: 0x00242864 File Offset: 0x00240A64
		// (set) Token: 0x060089AD RID: 35245 RVA: 0x00041BC3 File Offset: 0x0003FDC3
		public unsafe float Weight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Weight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Weight)) = value;
			}
		}

		// Token: 0x170029F2 RID: 10738
		// (get) Token: 0x060089AE RID: 35246 RVA: 0x0024288C File Offset: 0x00240A8C
		// (set) Token: 0x060089AF RID: 35247 RVA: 0x00041BDE File Offset: 0x0003FDDE
		public unsafe Color SkinColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_SkinColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_SkinColor)) = value;
			}
		}

		// Token: 0x170029F3 RID: 10739
		// (get) Token: 0x060089B0 RID: 35248 RVA: 0x002428B4 File Offset: 0x00240AB4
		// (set) Token: 0x060089B1 RID: 35249 RVA: 0x00041BF9 File Offset: 0x0003FDF9
		public unsafe string HairStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HairStyle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HairStyle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029F4 RID: 10740
		// (get) Token: 0x060089B2 RID: 35250 RVA: 0x002428DC File Offset: 0x00240ADC
		// (set) Token: 0x060089B3 RID: 35251 RVA: 0x00041C18 File Offset: 0x0003FE18
		public unsafe Color HairColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HairColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HairColor)) = value;
			}
		}

		// Token: 0x170029F5 RID: 10741
		// (get) Token: 0x060089B4 RID: 35252 RVA: 0x00242904 File Offset: 0x00240B04
		// (set) Token: 0x060089B5 RID: 35253 RVA: 0x00041C33 File Offset: 0x0003FE33
		public unsafe string Mouth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Mouth);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Mouth), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029F6 RID: 10742
		// (get) Token: 0x060089B6 RID: 35254 RVA: 0x0024292C File Offset: 0x00240B2C
		// (set) Token: 0x060089B7 RID: 35255 RVA: 0x00041C52 File Offset: 0x0003FE52
		public unsafe string FacialHair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialHair);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialHair), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029F7 RID: 10743
		// (get) Token: 0x060089B8 RID: 35256 RVA: 0x00242954 File Offset: 0x00240B54
		// (set) Token: 0x060089B9 RID: 35257 RVA: 0x00041C71 File Offset: 0x0003FE71
		public unsafe string FacialDetails
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialDetails);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialDetails), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029F8 RID: 10744
		// (get) Token: 0x060089BA RID: 35258 RVA: 0x0024297C File Offset: 0x00240B7C
		// (set) Token: 0x060089BB RID: 35259 RVA: 0x00041C90 File Offset: 0x0003FE90
		public unsafe float FacialDetailsIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialDetailsIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialDetailsIntensity)) = value;
			}
		}

		// Token: 0x170029F9 RID: 10745
		// (get) Token: 0x060089BC RID: 35260 RVA: 0x002429A4 File Offset: 0x00240BA4
		// (set) Token: 0x060089BD RID: 35261 RVA: 0x00041CAB File Offset: 0x0003FEAB
		public unsafe Color EyeballColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyeballColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyeballColor)) = value;
			}
		}

		// Token: 0x170029FA RID: 10746
		// (get) Token: 0x060089BE RID: 35262 RVA: 0x002429CC File Offset: 0x00240BCC
		// (set) Token: 0x060089BF RID: 35263 RVA: 0x00041CC6 File Offset: 0x0003FEC6
		public unsafe float UpperEyeLidRestingPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_UpperEyeLidRestingPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_UpperEyeLidRestingPosition)) = value;
			}
		}

		// Token: 0x170029FB RID: 10747
		// (get) Token: 0x060089C0 RID: 35264 RVA: 0x002429F4 File Offset: 0x00240BF4
		// (set) Token: 0x060089C1 RID: 35265 RVA: 0x00041CE1 File Offset: 0x0003FEE1
		public unsafe float LowerEyeLidRestingPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_LowerEyeLidRestingPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_LowerEyeLidRestingPosition)) = value;
			}
		}

		// Token: 0x170029FC RID: 10748
		// (get) Token: 0x060089C2 RID: 35266 RVA: 0x00242A1C File Offset: 0x00240C1C
		// (set) Token: 0x060089C3 RID: 35267 RVA: 0x00041CFC File Offset: 0x0003FEFC
		public unsafe float PupilDilation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_PupilDilation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_PupilDilation)) = value;
			}
		}

		// Token: 0x170029FD RID: 10749
		// (get) Token: 0x060089C4 RID: 35268 RVA: 0x00242A44 File Offset: 0x00240C44
		// (set) Token: 0x060089C5 RID: 35269 RVA: 0x00041D17 File Offset: 0x0003FF17
		public unsafe float EyebrowScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowScale)) = value;
			}
		}

		// Token: 0x170029FE RID: 10750
		// (get) Token: 0x060089C6 RID: 35270 RVA: 0x00242A6C File Offset: 0x00240C6C
		// (set) Token: 0x060089C7 RID: 35271 RVA: 0x00041D32 File Offset: 0x0003FF32
		public unsafe float EyebrowThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowThickness)) = value;
			}
		}

		// Token: 0x170029FF RID: 10751
		// (get) Token: 0x060089C8 RID: 35272 RVA: 0x00242A94 File Offset: 0x00240C94
		// (set) Token: 0x060089C9 RID: 35273 RVA: 0x00041D4D File Offset: 0x0003FF4D
		public unsafe float EyebrowRestingHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight)) = value;
			}
		}

		// Token: 0x17002A00 RID: 10752
		// (get) Token: 0x060089CA RID: 35274 RVA: 0x00242ABC File Offset: 0x00240CBC
		// (set) Token: 0x060089CB RID: 35275 RVA: 0x00041D68 File Offset: 0x0003FF68
		public unsafe float EyebrowRestingAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle)) = value;
			}
		}

		// Token: 0x17002A01 RID: 10753
		// (get) Token: 0x060089CC RID: 35276 RVA: 0x00242AE4 File Offset: 0x00240CE4
		// (set) Token: 0x060089CD RID: 35277 RVA: 0x00041D83 File Offset: 0x0003FF83
		public unsafe string Top
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Top);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Top), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A02 RID: 10754
		// (get) Token: 0x060089CE RID: 35278 RVA: 0x00242B0C File Offset: 0x00240D0C
		// (set) Token: 0x060089CF RID: 35279 RVA: 0x00041DA2 File Offset: 0x0003FFA2
		public unsafe Color TopColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_TopColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_TopColor)) = value;
			}
		}

		// Token: 0x17002A03 RID: 10755
		// (get) Token: 0x060089D0 RID: 35280 RVA: 0x00242B34 File Offset: 0x00240D34
		// (set) Token: 0x060089D1 RID: 35281 RVA: 0x00041DBD File Offset: 0x0003FFBD
		public unsafe string Bottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Bottom);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Bottom), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A04 RID: 10756
		// (get) Token: 0x060089D2 RID: 35282 RVA: 0x00242B5C File Offset: 0x00240D5C
		// (set) Token: 0x060089D3 RID: 35283 RVA: 0x00041DDC File Offset: 0x0003FFDC
		public unsafe Color BottomColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_BottomColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_BottomColor)) = value;
			}
		}

		// Token: 0x17002A05 RID: 10757
		// (get) Token: 0x060089D4 RID: 35284 RVA: 0x00242B84 File Offset: 0x00240D84
		// (set) Token: 0x060089D5 RID: 35285 RVA: 0x00041DF7 File Offset: 0x0003FFF7
		public unsafe string Shoes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Shoes);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Shoes), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A06 RID: 10758
		// (get) Token: 0x060089D6 RID: 35286 RVA: 0x00242BAC File Offset: 0x00240DAC
		// (set) Token: 0x060089D7 RID: 35287 RVA: 0x00041E16 File Offset: 0x00040016
		public unsafe Color ShoesColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_ShoesColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_ShoesColor)) = value;
			}
		}

		// Token: 0x17002A07 RID: 10759
		// (get) Token: 0x060089D8 RID: 35288 RVA: 0x00242BD4 File Offset: 0x00240DD4
		// (set) Token: 0x060089D9 RID: 35289 RVA: 0x00041E31 File Offset: 0x00040031
		public unsafe string Headwear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Headwear);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Headwear), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A08 RID: 10760
		// (get) Token: 0x060089DA RID: 35290 RVA: 0x00242BFC File Offset: 0x00240DFC
		// (set) Token: 0x060089DB RID: 35291 RVA: 0x00041E50 File Offset: 0x00040050
		public unsafe Color HeadwearColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HeadwearColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HeadwearColor)) = value;
			}
		}

		// Token: 0x17002A09 RID: 10761
		// (get) Token: 0x060089DC RID: 35292 RVA: 0x00242C24 File Offset: 0x00240E24
		// (set) Token: 0x060089DD RID: 35293 RVA: 0x00041E6B File Offset: 0x0004006B
		public unsafe string Eyewear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Eyewear);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Eyewear), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A0A RID: 10762
		// (get) Token: 0x060089DE RID: 35294 RVA: 0x00242C4C File Offset: 0x00240E4C
		// (set) Token: 0x060089DF RID: 35295 RVA: 0x00041E8A File Offset: 0x0004008A
		public unsafe Color EyewearColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyewearColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyewearColor)) = value;
			}
		}

		// Token: 0x17002A0B RID: 10763
		// (get) Token: 0x060089E0 RID: 35296 RVA: 0x00242C74 File Offset: 0x00240E74
		// (set) Token: 0x060089E1 RID: 35297 RVA: 0x00041EA5 File Offset: 0x000400A5
		public unsafe List<string> Tattoos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Tattoos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Tattoos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D6E RID: 23918
		private static readonly IntPtr NativeFieldInfoPtr_GENDER_MULTIPLIER;

		// Token: 0x04005D6F RID: 23919
		private static readonly IntPtr NativeFieldInfoPtr_MaleUnderwearPath;

		// Token: 0x04005D70 RID: 23920
		private static readonly IntPtr NativeFieldInfoPtr_FemaleUnderwearPath;

		// Token: 0x04005D71 RID: 23921
		private static readonly IntPtr NativeFieldInfoPtr_Gender;

		// Token: 0x04005D72 RID: 23922
		private static readonly IntPtr NativeFieldInfoPtr_Weight;

		// Token: 0x04005D73 RID: 23923
		private static readonly IntPtr NativeFieldInfoPtr_SkinColor;

		// Token: 0x04005D74 RID: 23924
		private static readonly IntPtr NativeFieldInfoPtr_HairStyle;

		// Token: 0x04005D75 RID: 23925
		private static readonly IntPtr NativeFieldInfoPtr_HairColor;

		// Token: 0x04005D76 RID: 23926
		private static readonly IntPtr NativeFieldInfoPtr_Mouth;

		// Token: 0x04005D77 RID: 23927
		private static readonly IntPtr NativeFieldInfoPtr_FacialHair;

		// Token: 0x04005D78 RID: 23928
		private static readonly IntPtr NativeFieldInfoPtr_FacialDetails;

		// Token: 0x04005D79 RID: 23929
		private static readonly IntPtr NativeFieldInfoPtr_FacialDetailsIntensity;

		// Token: 0x04005D7A RID: 23930
		private static readonly IntPtr NativeFieldInfoPtr_EyeballColor;

		// Token: 0x04005D7B RID: 23931
		private static readonly IntPtr NativeFieldInfoPtr_UpperEyeLidRestingPosition;

		// Token: 0x04005D7C RID: 23932
		private static readonly IntPtr NativeFieldInfoPtr_LowerEyeLidRestingPosition;

		// Token: 0x04005D7D RID: 23933
		private static readonly IntPtr NativeFieldInfoPtr_PupilDilation;

		// Token: 0x04005D7E RID: 23934
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowScale;

		// Token: 0x04005D7F RID: 23935
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowThickness;

		// Token: 0x04005D80 RID: 23936
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowRestingHeight;

		// Token: 0x04005D81 RID: 23937
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowRestingAngle;

		// Token: 0x04005D82 RID: 23938
		private static readonly IntPtr NativeFieldInfoPtr_Top;

		// Token: 0x04005D83 RID: 23939
		private static readonly IntPtr NativeFieldInfoPtr_TopColor;

		// Token: 0x04005D84 RID: 23940
		private static readonly IntPtr NativeFieldInfoPtr_Bottom;

		// Token: 0x04005D85 RID: 23941
		private static readonly IntPtr NativeFieldInfoPtr_BottomColor;

		// Token: 0x04005D86 RID: 23942
		private static readonly IntPtr NativeFieldInfoPtr_Shoes;

		// Token: 0x04005D87 RID: 23943
		private static readonly IntPtr NativeFieldInfoPtr_ShoesColor;

		// Token: 0x04005D88 RID: 23944
		private static readonly IntPtr NativeFieldInfoPtr_Headwear;

		// Token: 0x04005D89 RID: 23945
		private static readonly IntPtr NativeFieldInfoPtr_HeadwearColor;

		// Token: 0x04005D8A RID: 23946
		private static readonly IntPtr NativeFieldInfoPtr_Eyewear;

		// Token: 0x04005D8B RID: 23947
		private static readonly IntPtr NativeFieldInfoPtr_EyewearColor;

		// Token: 0x04005D8C RID: 23948
		private static readonly IntPtr NativeFieldInfoPtr_Tattoos;

		// Token: 0x04005D8D RID: 23949
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_T_String_T_0;

		// Token: 0x04005D8E RID: 23950
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_T_String_0;

		// Token: 0x04005D8F RID: 23951
		private static readonly IntPtr NativeMethodInfoPtr_GetAvatarSettings_Public_AvatarSettings_0;

		// Token: 0x04005D90 RID: 23952
		private static readonly IntPtr NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0;

		// Token: 0x04005D91 RID: 23953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B0A RID: 2826
		private sealed class MethodInfoStoreGeneric_SetValue_Public_T_String_T_0<T>
		{
			// Token: 0x04009045 RID: 36933
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BasicAvatarSettings.NativeMethodInfoPtr_SetValue_Public_T_String_T_0, Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000B0B RID: 2827
		private sealed class MethodInfoStoreGeneric_GetValue_Public_T_String_0<T>
		{
			// Token: 0x04009046 RID: 36934
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BasicAvatarSettings.NativeMethodInfoPtr_GetValue_Public_T_String_0, Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
