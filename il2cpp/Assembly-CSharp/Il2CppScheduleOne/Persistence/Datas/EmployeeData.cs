using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200028F RID: 655
	[Serializable]
	public class EmployeeData : NPCData
	{
		// Token: 0x06003048 RID: 12360 RVA: 0x0010A03C File Offset: 0x0010823C
		// Note: this type is marked as 'beforefieldinit'.
		static EmployeeData()
		{
			Il2CppClassPointerStore<EmployeeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "EmployeeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr);
			EmployeeData.NativeFieldInfoPtr_AssignedProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "AssignedProperty");
			EmployeeData.NativeFieldInfoPtr_FirstName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "FirstName");
			EmployeeData.NativeFieldInfoPtr_LastName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "LastName");
			EmployeeData.NativeFieldInfoPtr_IsMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "IsMale");
			EmployeeData.NativeFieldInfoPtr_AppearanceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "AppearanceIndex");
			EmployeeData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "Position");
			EmployeeData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "Rotation");
			EmployeeData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "GUID");
			EmployeeData.NativeFieldInfoPtr_PaidForToday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "PaidForToday");
			EmployeeData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, 100668807);
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x0010A134 File Offset: 0x00108334
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130949, RefRangeEnd = 130950, XrefRangeStart = 130942, XrefRangeEnd = 130949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmployeeData(string id, string assignedProperty, string firstName, string lastName, bool isMale, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assignedProperty);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMale;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guid;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paidForToday;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x00019A2B File Offset: 0x00017C2B
		public EmployeeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x0600304B RID: 12363 RVA: 0x0010A20C File Offset: 0x0010840C
		// (set) Token: 0x0600304C RID: 12364 RVA: 0x00019A34 File Offset: 0x00017C34
		public unsafe string AssignedProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_AssignedProperty);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_AssignedProperty), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x0600304D RID: 12365 RVA: 0x0010A234 File Offset: 0x00108434
		// (set) Token: 0x0600304E RID: 12366 RVA: 0x00019A53 File Offset: 0x00017C53
		public unsafe string FirstName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_FirstName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_FirstName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x0600304F RID: 12367 RVA: 0x0010A25C File Offset: 0x0010845C
		// (set) Token: 0x06003050 RID: 12368 RVA: 0x00019A72 File Offset: 0x00017C72
		public unsafe string LastName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_LastName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_LastName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x06003051 RID: 12369 RVA: 0x0010A284 File Offset: 0x00108484
		// (set) Token: 0x06003052 RID: 12370 RVA: 0x00019A91 File Offset: 0x00017C91
		public unsafe bool IsMale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_IsMale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_IsMale)) = value;
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06003053 RID: 12371 RVA: 0x0010A2AC File Offset: 0x001084AC
		// (set) Token: 0x06003054 RID: 12372 RVA: 0x00019AAC File Offset: 0x00017CAC
		public unsafe int AppearanceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_AppearanceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_AppearanceIndex)) = value;
			}
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06003055 RID: 12373 RVA: 0x0010A2D4 File Offset: 0x001084D4
		// (set) Token: 0x06003056 RID: 12374 RVA: 0x00019AC7 File Offset: 0x00017CC7
		public unsafe Vector3 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06003057 RID: 12375 RVA: 0x0010A2FC File Offset: 0x001084FC
		// (set) Token: 0x06003058 RID: 12376 RVA: 0x00019AE2 File Offset: 0x00017CE2
		public unsafe Quaternion Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06003059 RID: 12377 RVA: 0x0010A324 File Offset: 0x00108524
		// (set) Token: 0x0600305A RID: 12378 RVA: 0x00019AFD File Offset: 0x00017CFD
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x0600305B RID: 12379 RVA: 0x0010A34C File Offset: 0x0010854C
		// (set) Token: 0x0600305C RID: 12380 RVA: 0x00019B1C File Offset: 0x00017D1C
		public unsafe bool PaidForToday
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_PaidForToday);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_PaidForToday)) = value;
			}
		}

		// Token: 0x04001FA2 RID: 8098
		private static readonly IntPtr NativeFieldInfoPtr_AssignedProperty;

		// Token: 0x04001FA3 RID: 8099
		private static readonly IntPtr NativeFieldInfoPtr_FirstName;

		// Token: 0x04001FA4 RID: 8100
		private static readonly IntPtr NativeFieldInfoPtr_LastName;

		// Token: 0x04001FA5 RID: 8101
		private static readonly IntPtr NativeFieldInfoPtr_IsMale;

		// Token: 0x04001FA6 RID: 8102
		private static readonly IntPtr NativeFieldInfoPtr_AppearanceIndex;

		// Token: 0x04001FA7 RID: 8103
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04001FA8 RID: 8104
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04001FA9 RID: 8105
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04001FAA RID: 8106
		private static readonly IntPtr NativeFieldInfoPtr_PaidForToday;

		// Token: 0x04001FAB RID: 8107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_0;
	}
}
