using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000147 RID: 327
	[Serializable]
	public class CharacterCustomizationSetup : Object
	{
		// Token: 0x06001B37 RID: 6967 RVA: 0x000C5BE8 File Offset: 0x000C3DE8
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCustomizationSetup()
		{
			Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterCustomizationSetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr);
			CharacterCustomizationSetup.NativeFieldInfoPtr_settingsName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "settingsName");
			CharacterCustomizationSetup.NativeFieldInfoPtr_selectedElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "selectedElements");
			CharacterCustomizationSetup.NativeFieldInfoPtr_blendshapes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "blendshapes");
			CharacterCustomizationSetup.NativeFieldInfoPtr_MinLod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "MinLod");
			CharacterCustomizationSetup.NativeFieldInfoPtr_MaxLod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "MaxLod");
			CharacterCustomizationSetup.NativeFieldInfoPtr_SkinColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "SkinColor");
			CharacterCustomizationSetup.NativeFieldInfoPtr_EyeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "EyeColor");
			CharacterCustomizationSetup.NativeFieldInfoPtr_HairColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "HairColor");
			CharacterCustomizationSetup.NativeFieldInfoPtr_UnderpantsColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "UnderpantsColor");
			CharacterCustomizationSetup.NativeFieldInfoPtr_TeethColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "TeethColor");
			CharacterCustomizationSetup.NativeFieldInfoPtr_OralCavityColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "OralCavityColor");
			CharacterCustomizationSetup.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "Height");
			CharacterCustomizationSetup.NativeFieldInfoPtr_HeadSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "HeadSize");
			CharacterCustomizationSetup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, 100666212);
			CharacterCustomizationSetup.NativeMethodInfoPtr_ApplyToCharacter_Public_Void_CharacterCustomization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, 100666213);
			CharacterCustomizationSetup.NativeMethodInfoPtr_Serialize_Public_String_CharacterFileSaveFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, 100666214);
			CharacterCustomizationSetup.NativeMethodInfoPtr_Deserialize_Public_Static_CharacterCustomizationSetup_String_CharacterFileSaveFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, 100666215);
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x000C5D6C File Offset: 0x000C3F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100257, RefRangeEnd = 100258, XrefRangeStart = 100244, XrefRangeEnd = 100257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCustomizationSetup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationSetup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x000C5DA8 File Offset: 0x000C3FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100274, RefRangeEnd = 100275, XrefRangeStart = 100258, XrefRangeEnd = 100274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyToCharacter(CharacterCustomization cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationSetup.NativeMethodInfoPtr_ApplyToCharacter_Public_Void_CharacterCustomization_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x000C5DEC File Offset: 0x000C3FEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100285, RefRangeEnd = 100286, XrefRangeStart = 100275, XrefRangeEnd = 100285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Serialize(CharacterCustomizationSetup.CharacterFileSaveFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationSetup.NativeMethodInfoPtr_Serialize_Public_String_CharacterFileSaveFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x000C5E30 File Offset: 0x000C4030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100286, XrefRangeEnd = 100296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharacterCustomizationSetup Deserialize(string data, CharacterCustomizationSetup.CharacterFileSaveFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationSetup.NativeMethodInfoPtr_Deserialize_Public_Static_CharacterCustomizationSetup_String_CharacterFileSaveFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationSetup>(intPtr3) : null;
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x0000F5C0 File Offset: 0x0000D7C0
		public CharacterCustomizationSetup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001B3D RID: 6973 RVA: 0x000C5E84 File Offset: 0x000C4084
		// (set) Token: 0x06001B3E RID: 6974 RVA: 0x0000F5C9 File Offset: 0x0000D7C9
		public unsafe string settingsName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_settingsName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_settingsName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001B3F RID: 6975 RVA: 0x000C5EAC File Offset: 0x000C40AC
		// (set) Token: 0x06001B40 RID: 6976 RVA: 0x0000F5E8 File Offset: 0x0000D7E8
		public unsafe CharacterSelectedElements selectedElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_selectedElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSelectedElements>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_selectedElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x000C5EDC File Offset: 0x000C40DC
		// (set) Token: 0x06001B42 RID: 6978 RVA: 0x0000F607 File Offset: 0x0000D807
		public unsafe List<CharacterBlendshapeData> blendshapes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_blendshapes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterBlendshapeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_blendshapes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001B43 RID: 6979 RVA: 0x000C5F0C File Offset: 0x000C410C
		// (set) Token: 0x06001B44 RID: 6980 RVA: 0x0000F626 File Offset: 0x0000D826
		public unsafe int MinLod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_MinLod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_MinLod)) = value;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x000C5F34 File Offset: 0x000C4134
		// (set) Token: 0x06001B46 RID: 6982 RVA: 0x0000F641 File Offset: 0x0000D841
		public unsafe int MaxLod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_MaxLod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_MaxLod)) = value;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x000C5F5C File Offset: 0x000C415C
		// (set) Token: 0x06001B48 RID: 6984 RVA: 0x0000F65C File Offset: 0x0000D85C
		public unsafe Il2CppStructArray<float> SkinColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_SkinColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_SkinColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x000C5F8C File Offset: 0x000C418C
		// (set) Token: 0x06001B4A RID: 6986 RVA: 0x0000F67B File Offset: 0x0000D87B
		public unsafe Il2CppStructArray<float> EyeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_EyeColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_EyeColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x000C5FBC File Offset: 0x000C41BC
		// (set) Token: 0x06001B4C RID: 6988 RVA: 0x0000F69A File Offset: 0x0000D89A
		public unsafe Il2CppStructArray<float> HairColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_HairColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_HairColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x000C5FEC File Offset: 0x000C41EC
		// (set) Token: 0x06001B4E RID: 6990 RVA: 0x0000F6B9 File Offset: 0x0000D8B9
		public unsafe Il2CppStructArray<float> UnderpantsColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_UnderpantsColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_UnderpantsColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x000C601C File Offset: 0x000C421C
		// (set) Token: 0x06001B50 RID: 6992 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
		public unsafe Il2CppStructArray<float> TeethColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_TeethColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_TeethColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x000C604C File Offset: 0x000C424C
		// (set) Token: 0x06001B52 RID: 6994 RVA: 0x0000F6F7 File Offset: 0x0000D8F7
		public unsafe Il2CppStructArray<float> OralCavityColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_OralCavityColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_OralCavityColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x000C607C File Offset: 0x000C427C
		// (set) Token: 0x06001B54 RID: 6996 RVA: 0x0000F716 File Offset: 0x0000D916
		public unsafe float Height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_Height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_Height)) = value;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x000C60A4 File Offset: 0x000C42A4
		// (set) Token: 0x06001B56 RID: 6998 RVA: 0x0000F731 File Offset: 0x0000D931
		public unsafe float HeadSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_HeadSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_HeadSize)) = value;
			}
		}

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeFieldInfoPtr_settingsName;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeFieldInfoPtr_selectedElements;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeFieldInfoPtr_blendshapes;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeFieldInfoPtr_MinLod;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeFieldInfoPtr_MaxLod;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeFieldInfoPtr_SkinColor;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeFieldInfoPtr_EyeColor;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeFieldInfoPtr_HairColor;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeFieldInfoPtr_UnderpantsColor;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeFieldInfoPtr_TeethColor;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeFieldInfoPtr_OralCavityColor;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeFieldInfoPtr_Height;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeFieldInfoPtr_HeadSize;

		// Token: 0x04001201 RID: 4609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToCharacter_Public_Void_CharacterCustomization_0;

		// Token: 0x04001203 RID: 4611
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_String_CharacterFileSaveFormat_0;

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_CharacterCustomizationSetup_String_CharacterFileSaveFormat_0;

		// Token: 0x02000863 RID: 2147
		[OriginalName("Assembly-CSharp.dll", "", "CharacterFileSaveFormat")]
		public enum CharacterFileSaveFormat
		{
			// Token: 0x040082B0 RID: 33456
			Json,
			// Token: 0x040082B1 RID: 33457
			Xml,
			// Token: 0x040082B2 RID: 33458
			Binary
		}
	}
}
