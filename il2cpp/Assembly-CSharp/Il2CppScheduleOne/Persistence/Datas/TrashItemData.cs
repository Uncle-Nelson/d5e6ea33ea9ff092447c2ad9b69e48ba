using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002BC RID: 700
	[Serializable]
	public class TrashItemData : SaveData
	{
		// Token: 0x060031F6 RID: 12790 RVA: 0x0010EDC8 File Offset: 0x0010CFC8
		// Note: this type is marked as 'beforefieldinit'.
		static TrashItemData()
		{
			Il2CppClassPointerStore<TrashItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr);
			TrashItemData.NativeFieldInfoPtr_TrashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "TrashID");
			TrashItemData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "GUID");
			TrashItemData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "Position");
			TrashItemData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "Rotation");
			TrashItemData.NativeFieldInfoPtr_Contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "Contents");
			TrashItemData.NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, 100668859);
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x0010EE70 File Offset: 0x0010D070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131321, RefRangeEnd = 131322, XrefRangeStart = 131318, XrefRangeEnd = 131321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItemData(string trashID, string guid, Vector3 position, Quaternion rotation) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItemData.NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x0001AC6B File Offset: 0x00018E6B
		public TrashItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x060031F9 RID: 12793 RVA: 0x0010EEEC File Offset: 0x0010D0EC
		// (set) Token: 0x060031FA RID: 12794 RVA: 0x0001AC74 File Offset: 0x00018E74
		public unsafe string TrashID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_TrashID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_TrashID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x060031FB RID: 12795 RVA: 0x0010EF14 File Offset: 0x0010D114
		// (set) Token: 0x060031FC RID: 12796 RVA: 0x0001AC93 File Offset: 0x00018E93
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x060031FD RID: 12797 RVA: 0x0010EF3C File Offset: 0x0010D13C
		// (set) Token: 0x060031FE RID: 12798 RVA: 0x0001ACB2 File Offset: 0x00018EB2
		public unsafe Vector3 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x060031FF RID: 12799 RVA: 0x0010EF64 File Offset: 0x0010D164
		// (set) Token: 0x06003200 RID: 12800 RVA: 0x0001ACCD File Offset: 0x00018ECD
		public unsafe Quaternion Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06003201 RID: 12801 RVA: 0x0010EF8C File Offset: 0x0010D18C
		// (set) Token: 0x06003202 RID: 12802 RVA: 0x0001ACE8 File Offset: 0x00018EE8
		public unsafe TrashContentData Contents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Contents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContentData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Contents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002066 RID: 8294
		private static readonly IntPtr NativeFieldInfoPtr_TrashID;

		// Token: 0x04002067 RID: 8295
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04002068 RID: 8296
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04002069 RID: 8297
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x0400206A RID: 8298
		private static readonly IntPtr NativeFieldInfoPtr_Contents;

		// Token: 0x0400206B RID: 8299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_0;
	}
}
