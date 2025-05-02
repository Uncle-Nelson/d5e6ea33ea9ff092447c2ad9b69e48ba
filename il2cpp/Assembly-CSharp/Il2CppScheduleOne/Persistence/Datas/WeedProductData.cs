using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002AC RID: 684
	[Serializable]
	public class WeedProductData : ProductData
	{
		// Token: 0x06003154 RID: 12628 RVA: 0x0010D20C File Offset: 0x0010B40C
		// Note: this type is marked as 'beforefieldinit'.
		static WeedProductData()
		{
			Il2CppClassPointerStore<WeedProductData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "WeedProductData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedProductData>.NativeClassPtr);
			WeedProductData.NativeFieldInfoPtr_AppearanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedProductData>.NativeClassPtr, "AppearanceSettings");
			WeedProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_WeedAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedProductData>.NativeClassPtr, 100668837);
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x0010D264 File Offset: 0x0010B464
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131110, RefRangeEnd = 131113, XrefRangeStart = 131110, XrefRangeEnd = 131113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedProductData(string name, string id, EDrugType drugType, Il2CppStringArray properties, WeedAppearanceSettings appearanceSettings) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedProductData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appearanceSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_WeedAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x0001A576 File Offset: 0x00018776
		public WeedProductData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06003157 RID: 12631 RVA: 0x0010D2F8 File Offset: 0x0010B4F8
		// (set) Token: 0x06003158 RID: 12632 RVA: 0x0001A57F File Offset: 0x0001877F
		public unsafe WeedAppearanceSettings AppearanceSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedProductData.NativeFieldInfoPtr_AppearanceSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeedAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedProductData.NativeFieldInfoPtr_AppearanceSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400201A RID: 8218
		private static readonly IntPtr NativeFieldInfoPtr_AppearanceSettings;

		// Token: 0x0400201B RID: 8219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_WeedAppearanceSettings_0;
	}
}
