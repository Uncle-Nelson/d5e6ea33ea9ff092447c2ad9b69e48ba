using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E7 RID: 1255
	public class Shitbox : LandVehicle
	{
		// Token: 0x06006ED4 RID: 28372 RVA: 0x001E9E34 File Offset: 0x001E8034
		// Note: this type is marked as 'beforefieldinit'.
		static Shitbox()
		{
			Il2CppClassPointerStore<Shitbox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "Shitbox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shitbox>.NativeClassPtr);
			Shitbox.NativeFieldInfoPtr_LoanSharkVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, "LoanSharkVisuals");
			Shitbox.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vehicles.ShitboxAssembly-CSharp.dll_Excuted");
			Shitbox.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vehicles.ShitboxAssembly-CSharp.dll_Excuted");
			Shitbox.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677307);
			Shitbox.NativeMethodInfoPtr_Load_Public_Virtual_Void_VehicleData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677308);
			Shitbox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677309);
			Shitbox.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677310);
			Shitbox.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677311);
			Shitbox.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677312);
			Shitbox.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677313);
		}

		// Token: 0x06006ED5 RID: 28373 RVA: 0x001E9F2C File Offset: 0x001E812C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220556, XrefRangeEnd = 220590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shitbox.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06006ED6 RID: 28374 RVA: 0x001E9F88 File Offset: 0x001E8188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220590, XrefRangeEnd = 220610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(VehicleData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shitbox.NativeMethodInfoPtr_Load_Public_Virtual_Void_VehicleData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ED7 RID: 28375 RVA: 0x001E9FE8 File Offset: 0x001E81E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220610, XrefRangeEnd = 220611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shitbox() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shitbox>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shitbox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ED8 RID: 28376 RVA: 0x001EA024 File Offset: 0x001E8224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220611, XrefRangeEnd = 220612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shitbox.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ED9 RID: 28377 RVA: 0x001EA060 File Offset: 0x001E8260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220612, XrefRangeEnd = 220613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shitbox.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EDA RID: 28378 RVA: 0x001EA09C File Offset: 0x001E829C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shitbox.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EDB RID: 28379 RVA: 0x001EA0D8 File Offset: 0x001E82D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220613, XrefRangeEnd = 220614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shitbox.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EDC RID: 28380 RVA: 0x00034733 File Offset: 0x00032933
		public Shitbox(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x06006EDD RID: 28381 RVA: 0x001EA114 File Offset: 0x001E8314
		// (set) Token: 0x06006EDE RID: 28382 RVA: 0x0003473C File Offset: 0x0003293C
		public unsafe LoanSharkCarVisuals LoanSharkVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.NativeFieldInfoPtr_LoanSharkVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoanSharkCarVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.NativeFieldInfoPtr_LoanSharkVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x06006EDF RID: 28383 RVA: 0x001EA144 File Offset: 0x001E8344
		// (set) Token: 0x06006EE0 RID: 28384 RVA: 0x0003475B File Offset: 0x0003295B
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x06006EE1 RID: 28385 RVA: 0x001EA16C File Offset: 0x001E836C
		// (set) Token: 0x06006EE2 RID: 28386 RVA: 0x00034776 File Offset: 0x00032976
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004BD1 RID: 19409
		private static readonly IntPtr NativeFieldInfoPtr_LoanSharkVisuals;

		// Token: 0x04004BD2 RID: 19410
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004BD3 RID: 19411
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004BD4 RID: 19412
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0;

		// Token: 0x04004BD5 RID: 19413
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_VehicleData_String_0;

		// Token: 0x04004BD6 RID: 19414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004BD7 RID: 19415
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004BD8 RID: 19416
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004BD9 RID: 19417
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004BDA RID: 19418
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A6A RID: 2666
		[Serializable]
		public class LoanSharkVisualsData : SaveData
		{
			// Token: 0x0600D12D RID: 53549 RVA: 0x00321F2C File Offset: 0x0032012C
			// Note: this type is marked as 'beforefieldinit'.
			static LoanSharkVisualsData()
			{
				Il2CppClassPointerStore<Shitbox.LoanSharkVisualsData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, "LoanSharkVisualsData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shitbox.LoanSharkVisualsData>.NativeClassPtr);
				Shitbox.LoanSharkVisualsData.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shitbox.LoanSharkVisualsData>.NativeClassPtr, "Enabled");
				Shitbox.LoanSharkVisualsData.NativeFieldInfoPtr_NoteVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shitbox.LoanSharkVisualsData>.NativeClassPtr, "NoteVisible");
				Shitbox.LoanSharkVisualsData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox.LoanSharkVisualsData>.NativeClassPtr, 100677314);
			}

			// Token: 0x0600D12E RID: 53550 RVA: 0x00321F94 File Offset: 0x00320194
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 130519, RefRangeEnd = 130520, XrefRangeStart = 130519, XrefRangeEnd = 130520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LoanSharkVisualsData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shitbox.LoanSharkVisualsData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shitbox.LoanSharkVisualsData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D12F RID: 53551 RVA: 0x00065D50 File Offset: 0x00063F50
			public LoanSharkVisualsData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040F4 RID: 16628
			// (get) Token: 0x0600D130 RID: 53552 RVA: 0x00321FD0 File Offset: 0x003201D0
			// (set) Token: 0x0600D131 RID: 53553 RVA: 0x00065D59 File Offset: 0x00063F59
			public unsafe bool Enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.LoanSharkVisualsData.NativeFieldInfoPtr_Enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.LoanSharkVisualsData.NativeFieldInfoPtr_Enabled)) = value;
				}
			}

			// Token: 0x170040F5 RID: 16629
			// (get) Token: 0x0600D132 RID: 53554 RVA: 0x00321FF8 File Offset: 0x003201F8
			// (set) Token: 0x0600D133 RID: 53555 RVA: 0x00065D74 File Offset: 0x00063F74
			public unsafe bool NoteVisible
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.LoanSharkVisualsData.NativeFieldInfoPtr_NoteVisible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.LoanSharkVisualsData.NativeFieldInfoPtr_NoteVisible)) = value;
				}
			}

			// Token: 0x04008D22 RID: 36130
			private static readonly IntPtr NativeFieldInfoPtr_Enabled;

			// Token: 0x04008D23 RID: 36131
			private static readonly IntPtr NativeFieldInfoPtr_NoteVisible;

			// Token: 0x04008D24 RID: 36132
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
