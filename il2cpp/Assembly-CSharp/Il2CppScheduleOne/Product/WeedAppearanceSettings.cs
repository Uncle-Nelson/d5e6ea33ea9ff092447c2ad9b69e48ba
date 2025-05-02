using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005B0 RID: 1456
	[Serializable]
	public class WeedAppearanceSettings : Il2CppSystem.Object
	{
		// Token: 0x06008003 RID: 32771 RVA: 0x002241D0 File Offset: 0x002223D0
		// Note: this type is marked as 'beforefieldinit'.
		static WeedAppearanceSettings()
		{
			Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "WeedAppearanceSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr);
			WeedAppearanceSettings.NativeFieldInfoPtr_MainColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, "MainColor");
			WeedAppearanceSettings.NativeFieldInfoPtr_SecondaryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, "SecondaryColor");
			WeedAppearanceSettings.NativeFieldInfoPtr_LeafColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, "LeafColor");
			WeedAppearanceSettings.NativeFieldInfoPtr_StemColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, "StemColor");
			WeedAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, 100679379);
			WeedAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, 100679380);
			WeedAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, 100679381);
		}

		// Token: 0x06008004 RID: 32772 RVA: 0x0022428C File Offset: 0x0022248C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243912, RefRangeEnd = 243913, XrefRangeStart = 243911, XrefRangeEnd = 243912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedAppearanceSettings(Color32 mainColor, Color32 secondaryColor, Color32 leafColor, Color32 stemColor) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mainColor;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondaryColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leafColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stemColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_Color32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008005 RID: 32773 RVA: 0x00224300 File Offset: 0x00222500
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedAppearanceSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008006 RID: 32774 RVA: 0x0022433C File Offset: 0x0022253C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243913, RefRangeEnd = 243914, XrefRangeStart = 243913, XrefRangeEnd = 243913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUnintialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008007 RID: 32775 RVA: 0x0003CAEC File Offset: 0x0003ACEC
		public WeedAppearanceSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026AB RID: 9899
		// (get) Token: 0x06008008 RID: 32776 RVA: 0x00224378 File Offset: 0x00222578
		// (set) Token: 0x06008009 RID: 32777 RVA: 0x0003CAF5 File Offset: 0x0003ACF5
		public unsafe Color32 MainColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_MainColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_MainColor)) = value;
			}
		}

		// Token: 0x170026AC RID: 9900
		// (get) Token: 0x0600800A RID: 32778 RVA: 0x002243A0 File Offset: 0x002225A0
		// (set) Token: 0x0600800B RID: 32779 RVA: 0x0003CB10 File Offset: 0x0003AD10
		public unsafe Color32 SecondaryColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_SecondaryColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_SecondaryColor)) = value;
			}
		}

		// Token: 0x170026AD RID: 9901
		// (get) Token: 0x0600800C RID: 32780 RVA: 0x002243C8 File Offset: 0x002225C8
		// (set) Token: 0x0600800D RID: 32781 RVA: 0x0003CB2B File Offset: 0x0003AD2B
		public unsafe Color32 LeafColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_LeafColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_LeafColor)) = value;
			}
		}

		// Token: 0x170026AE RID: 9902
		// (get) Token: 0x0600800E RID: 32782 RVA: 0x002243F0 File Offset: 0x002225F0
		// (set) Token: 0x0600800F RID: 32783 RVA: 0x0003CB46 File Offset: 0x0003AD46
		public unsafe Color32 StemColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_StemColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_StemColor)) = value;
			}
		}

		// Token: 0x04005739 RID: 22329
		private static readonly IntPtr NativeFieldInfoPtr_MainColor;

		// Token: 0x0400573A RID: 22330
		private static readonly IntPtr NativeFieldInfoPtr_SecondaryColor;

		// Token: 0x0400573B RID: 22331
		private static readonly IntPtr NativeFieldInfoPtr_LeafColor;

		// Token: 0x0400573C RID: 22332
		private static readonly IntPtr NativeFieldInfoPtr_StemColor;

		// Token: 0x0400573D RID: 22333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_Color32_Color32_0;

		// Token: 0x0400573E RID: 22334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400573F RID: 22335
		private static readonly IntPtr NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0;
	}
}
