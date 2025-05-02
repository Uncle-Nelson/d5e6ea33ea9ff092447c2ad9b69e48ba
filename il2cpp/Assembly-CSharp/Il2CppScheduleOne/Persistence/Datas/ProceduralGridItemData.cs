using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200029F RID: 671
	[Serializable]
	public class ProceduralGridItemData : BuildableItemData
	{
		// Token: 0x060030F6 RID: 12534 RVA: 0x0010C04C File Offset: 0x0010A24C
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralGridItemData()
		{
			Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ProceduralGridItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr);
			ProceduralGridItemData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr, "Rotation");
			ProceduralGridItemData.NativeFieldInfoPtr_FootprintMatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr, "FootprintMatches");
			ProceduralGridItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Int32_Il2CppReferenceArray_1_FootprintMatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr, 100668823);
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x0010C0B8 File Offset: 0x0010A2B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131068, RefRangeEnd = 131069, XrefRangeStart = 131063, XrefRangeEnd = 131068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralGridItemData(Guid guid, ItemInstance item, int loadOrder, int rotation, Il2CppReferenceArray<FootprintMatchData> footprintMatches) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(footprintMatches);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Int32_Il2CppReferenceArray_1_FootprintMatchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x0001A1F0 File Offset: 0x000183F0
		public ProceduralGridItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x060030F9 RID: 12537 RVA: 0x0010C140 File Offset: 0x0010A340
		// (set) Token: 0x060030FA RID: 12538 RVA: 0x0001A1F9 File Offset: 0x000183F9
		public unsafe int Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItemData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItemData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x060030FB RID: 12539 RVA: 0x0010C168 File Offset: 0x0010A368
		// (set) Token: 0x060030FC RID: 12540 RVA: 0x0001A214 File Offset: 0x00018414
		public unsafe Il2CppReferenceArray<FootprintMatchData> FootprintMatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItemData.NativeFieldInfoPtr_FootprintMatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FootprintMatchData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItemData.NativeFieldInfoPtr_FootprintMatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FF1 RID: 8177
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04001FF2 RID: 8178
		private static readonly IntPtr NativeFieldInfoPtr_FootprintMatches;

		// Token: 0x04001FF3 RID: 8179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Int32_Il2CppReferenceArray_1_FootprintMatchData_0;
	}
}
