using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Vehicles.Modification;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002BE RID: 702
	[Serializable]
	public class VehicleData : SaveData
	{
		// Token: 0x0600320B RID: 12811 RVA: 0x0010F128 File Offset: 0x0010D328
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleData()
		{
			Il2CppClassPointerStore<VehicleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "VehicleData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleData>.NativeClassPtr);
			VehicleData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "GUID");
			VehicleData.NativeFieldInfoPtr_VehicleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "VehicleCode");
			VehicleData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "Position");
			VehicleData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "Rotation");
			VehicleData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "Color");
			VehicleData.NativeMethodInfoPtr__ctor_Public_Void_Guid_String_Vector3_Quaternion_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, 100668862);
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x0010F1D0 File Offset: 0x0010D3D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131339, RefRangeEnd = 131340, XrefRangeStart = 131331, XrefRangeEnd = 131339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleData(Guid guid, string code, Vector3 pos, Quaternion rot, EVehicleColor col) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleData.NativeMethodInfoPtr__ctor_Public_Void_Guid_String_Vector3_Quaternion_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x0001AD4E File Offset: 0x00018F4E
		public VehicleData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x0600320E RID: 12814 RVA: 0x0010F254 File Offset: 0x0010D454
		// (set) Token: 0x0600320F RID: 12815 RVA: 0x0001AD57 File Offset: 0x00018F57
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x0010F27C File Offset: 0x0010D47C
		// (set) Token: 0x06003211 RID: 12817 RVA: 0x0001AD76 File Offset: 0x00018F76
		public unsafe string VehicleCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_VehicleCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_VehicleCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06003212 RID: 12818 RVA: 0x0010F2A4 File Offset: 0x0010D4A4
		// (set) Token: 0x06003213 RID: 12819 RVA: 0x0001AD95 File Offset: 0x00018F95
		public unsafe Vector3 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06003214 RID: 12820 RVA: 0x0010F2CC File Offset: 0x0010D4CC
		// (set) Token: 0x06003215 RID: 12821 RVA: 0x0001ADB0 File Offset: 0x00018FB0
		public unsafe Quaternion Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06003216 RID: 12822 RVA: 0x0010F2F4 File Offset: 0x0010D4F4
		// (set) Token: 0x06003217 RID: 12823 RVA: 0x0001ADCB File Offset: 0x00018FCB
		public unsafe string Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Color);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Color), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002070 RID: 8304
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04002071 RID: 8305
		private static readonly IntPtr NativeFieldInfoPtr_VehicleCode;

		// Token: 0x04002072 RID: 8306
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04002073 RID: 8307
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04002074 RID: 8308
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x04002075 RID: 8309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_String_Vector3_Quaternion_EVehicleColor_0;
	}
}
