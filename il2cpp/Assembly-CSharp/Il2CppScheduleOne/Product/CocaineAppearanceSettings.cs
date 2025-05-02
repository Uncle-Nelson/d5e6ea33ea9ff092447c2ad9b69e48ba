using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000597 RID: 1431
	[Serializable]
	public class CocaineAppearanceSettings : Il2CppSystem.Object
	{
		// Token: 0x06007DD4 RID: 32212 RVA: 0x0021AF28 File Offset: 0x00219128
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineAppearanceSettings()
		{
			Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "CocaineAppearanceSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr);
			CocaineAppearanceSettings.NativeFieldInfoPtr_MainColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, "MainColor");
			CocaineAppearanceSettings.NativeFieldInfoPtr_SecondaryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, "SecondaryColor");
			CocaineAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, 100679025);
			CocaineAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, 100679026);
			CocaineAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, 100679027);
		}

		// Token: 0x06007DD5 RID: 32213 RVA: 0x0021AFBC File Offset: 0x002191BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238399, XrefRangeEnd = 238400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineAppearanceSettings(Color32 mainColor, Color32 secondaryColor) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mainColor;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondaryColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DD6 RID: 32214 RVA: 0x0021B014 File Offset: 0x00219214
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineAppearanceSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DD7 RID: 32215 RVA: 0x0021B050 File Offset: 0x00219250
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238400, RefRangeEnd = 238402, XrefRangeStart = 238400, XrefRangeEnd = 238400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUnintialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007DD8 RID: 32216 RVA: 0x0003BD67 File Offset: 0x00039F67
		public CocaineAppearanceSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700261A RID: 9754
		// (get) Token: 0x06007DD9 RID: 32217 RVA: 0x0021B08C File Offset: 0x0021928C
		// (set) Token: 0x06007DDA RID: 32218 RVA: 0x0003BD70 File Offset: 0x00039F70
		public unsafe Color32 MainColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineAppearanceSettings.NativeFieldInfoPtr_MainColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineAppearanceSettings.NativeFieldInfoPtr_MainColor)) = value;
			}
		}

		// Token: 0x1700261B RID: 9755
		// (get) Token: 0x06007DDB RID: 32219 RVA: 0x0021B0B4 File Offset: 0x002192B4
		// (set) Token: 0x06007DDC RID: 32220 RVA: 0x0003BD8B File Offset: 0x00039F8B
		public unsafe Color32 SecondaryColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineAppearanceSettings.NativeFieldInfoPtr_SecondaryColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineAppearanceSettings.NativeFieldInfoPtr_SecondaryColor)) = value;
			}
		}

		// Token: 0x04005590 RID: 21904
		private static readonly IntPtr NativeFieldInfoPtr_MainColor;

		// Token: 0x04005591 RID: 21905
		private static readonly IntPtr NativeFieldInfoPtr_SecondaryColor;

		// Token: 0x04005592 RID: 21906
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0;

		// Token: 0x04005593 RID: 21907
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005594 RID: 21908
		private static readonly IntPtr NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0;
	}
}
