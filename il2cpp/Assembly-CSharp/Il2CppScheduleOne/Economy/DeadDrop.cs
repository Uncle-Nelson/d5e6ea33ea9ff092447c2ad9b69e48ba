using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000411 RID: 1041
	public class DeadDrop : MonoBehaviour
	{
		// Token: 0x06005A5A RID: 23130 RVA: 0x001A4150 File Offset: 0x001A2350
		// Note: this type is marked as 'beforefieldinit'.
		static DeadDrop()
		{
			Il2CppClassPointerStore<DeadDrop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "DeadDrop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr);
			DeadDrop.NativeFieldInfoPtr_DeadDrops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "DeadDrops");
			DeadDrop.NativeFieldInfoPtr_DeadDropName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "DeadDropName");
			DeadDrop.NativeFieldInfoPtr_DeadDropDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "DeadDropDescription");
			DeadDrop.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "Storage");
			DeadDrop.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "PoI");
			DeadDrop.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "Light");
			DeadDrop.NativeFieldInfoPtr_ItemCountVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "ItemCountVariable");
			DeadDrop.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "<GUID>k__BackingField");
			DeadDrop.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "BakedGUID");
			DeadDrop.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674796);
			DeadDrop.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674797);
			DeadDrop.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674798);
			DeadDrop.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674799);
			DeadDrop.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674800);
			DeadDrop.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674801);
			DeadDrop.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674802);
			DeadDrop.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674803);
			DeadDrop.NativeMethodInfoPtr_GetRandomEmptyDrop_Public_Static_DeadDrop_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674804);
			DeadDrop.NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674805);
			DeadDrop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674806);
		}

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x06005A5B RID: 23131 RVA: 0x001A4310 File Offset: 0x001A2510
		// (set) Token: 0x06005A5C RID: 23132 RVA: 0x001A434C File Offset: 0x001A254C
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005A5D RID: 23133 RVA: 0x001A438C File Offset: 0x001A258C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190750, XrefRangeEnd = 190753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A5E RID: 23134 RVA: 0x001A43C0 File Offset: 0x001A25C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190753, XrefRangeEnd = 190767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeadDrop.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A5F RID: 23135 RVA: 0x001A43FC File Offset: 0x001A25FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190767, XrefRangeEnd = 190770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A60 RID: 23136 RVA: 0x001A4430 File Offset: 0x001A2630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190770, XrefRangeEnd = 190801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeadDrop.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A61 RID: 23137 RVA: 0x001A446C File Offset: 0x001A266C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190801, XrefRangeEnd = 190805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A62 RID: 23138 RVA: 0x001A44AC File Offset: 0x001A26AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190805, XrefRangeEnd = 190813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A63 RID: 23139 RVA: 0x001A44E0 File Offset: 0x001A26E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190864, RefRangeEnd = 190865, XrefRangeStart = 190813, XrefRangeEnd = 190864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DeadDrop GetRandomEmptyDrop(Vector3 origin)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_GetRandomEmptyDrop_Public_Static_DeadDrop_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeadDrop>(intPtr3) : null;
		}

		// Token: 0x06005A64 RID: 23140 RVA: 0x001A4520 File Offset: 0x001A2720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190865, XrefRangeEnd = 190877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDeadDrop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A65 RID: 23141 RVA: 0x001A4554 File Offset: 0x001A2754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190877, XrefRangeEnd = 190883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeadDrop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A66 RID: 23142 RVA: 0x0002AB47 File Offset: 0x00028D47
		public DeadDrop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x06005A67 RID: 23143 RVA: 0x001A4590 File Offset: 0x001A2790
		// (set) Token: 0x06005A68 RID: 23144 RVA: 0x0002AB50 File Offset: 0x00028D50
		public unsafe static List<DeadDrop> DeadDrops
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeadDrop.NativeFieldInfoPtr_DeadDrops, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeadDrop>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeadDrop.NativeFieldInfoPtr_DeadDrops, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x06005A69 RID: 23145 RVA: 0x001A45B8 File Offset: 0x001A27B8
		// (set) Token: 0x06005A6A RID: 23146 RVA: 0x0002AB62 File Offset: 0x00028D62
		public unsafe string DeadDropName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_DeadDropName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_DeadDropName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x06005A6B RID: 23147 RVA: 0x001A45E0 File Offset: 0x001A27E0
		// (set) Token: 0x06005A6C RID: 23148 RVA: 0x0002AB81 File Offset: 0x00028D81
		public unsafe string DeadDropDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_DeadDropDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_DeadDropDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x06005A6D RID: 23149 RVA: 0x001A4608 File Offset: 0x001A2808
		// (set) Token: 0x06005A6E RID: 23150 RVA: 0x0002ABA0 File Offset: 0x00028DA0
		public unsafe StorageEntity Storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_Storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x06005A6F RID: 23151 RVA: 0x001A4638 File Offset: 0x001A2838
		// (set) Token: 0x06005A70 RID: 23152 RVA: 0x0002ABBF File Offset: 0x00028DBF
		public unsafe POI PoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_PoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x06005A71 RID: 23153 RVA: 0x001A4668 File Offset: 0x001A2868
		// (set) Token: 0x06005A72 RID: 23154 RVA: 0x0002ABDE File Offset: 0x00028DDE
		public unsafe OptimizedLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x06005A73 RID: 23155 RVA: 0x001A4698 File Offset: 0x001A2898
		// (set) Token: 0x06005A74 RID: 23156 RVA: 0x0002ABFD File Offset: 0x00028DFD
		public unsafe string ItemCountVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_ItemCountVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_ItemCountVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x06005A75 RID: 23157 RVA: 0x001A46C0 File Offset: 0x001A28C0
		// (set) Token: 0x06005A76 RID: 23158 RVA: 0x0002AC1C File Offset: 0x00028E1C
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x06005A77 RID: 23159 RVA: 0x001A46E8 File Offset: 0x001A28E8
		// (set) Token: 0x06005A78 RID: 23160 RVA: 0x0002AC37 File Offset: 0x00028E37
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003DAD RID: 15789
		private static readonly IntPtr NativeFieldInfoPtr_DeadDrops;

		// Token: 0x04003DAE RID: 15790
		private static readonly IntPtr NativeFieldInfoPtr_DeadDropName;

		// Token: 0x04003DAF RID: 15791
		private static readonly IntPtr NativeFieldInfoPtr_DeadDropDescription;

		// Token: 0x04003DB0 RID: 15792
		private static readonly IntPtr NativeFieldInfoPtr_Storage;

		// Token: 0x04003DB1 RID: 15793
		private static readonly IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x04003DB2 RID: 15794
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04003DB3 RID: 15795
		private static readonly IntPtr NativeFieldInfoPtr_ItemCountVariable;

		// Token: 0x04003DB4 RID: 15796
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04003DB5 RID: 15797
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04003DB6 RID: 15798
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04003DB7 RID: 15799
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04003DB8 RID: 15800
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x04003DB9 RID: 15801
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04003DBA RID: 15802
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04003DBB RID: 15803
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04003DBC RID: 15804
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04003DBD RID: 15805
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x04003DBE RID: 15806
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomEmptyDrop_Public_Static_DeadDrop_Vector3_0;

		// Token: 0x04003DBF RID: 15807
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0;

		// Token: 0x04003DC0 RID: 15808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009E4 RID: 2532
		[ObfuscatedName("ScheduleOne.Economy.DeadDrop+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CD5E RID: 52574 RVA: 0x003178F8 File Offset: 0x00315AF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr);
				DeadDrop.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr, "<>9");
				DeadDrop.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr, "<>9__18_0");
				DeadDrop.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr, 100674809);
				DeadDrop.__c.NativeMethodInfoPtr__GetRandomEmptyDrop_b__18_0_Internal_Boolean_DeadDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr, 100674810);
			}

			// Token: 0x0600CD5F RID: 52575 RVA: 0x00317974 File Offset: 0x00315B74
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD60 RID: 52576 RVA: 0x003179B0 File Offset: 0x00315BB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190744, XrefRangeEnd = 190745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRandomEmptyDrop_b__18_0(DeadDrop drop)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(drop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.__c.NativeMethodInfoPtr__GetRandomEmptyDrop_b__18_0_Internal_Boolean_DeadDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD61 RID: 52577 RVA: 0x00063E42 File Offset: 0x00062042
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FEF RID: 16367
			// (get) Token: 0x0600CD62 RID: 52578 RVA: 0x00317A00 File Offset: 0x00315C00
			// (set) Token: 0x0600CD63 RID: 52579 RVA: 0x00063E4B File Offset: 0x0006204B
			public unsafe static DeadDrop.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeadDrop.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeadDrop.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeadDrop.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FF0 RID: 16368
			// (get) Token: 0x0600CD64 RID: 52580 RVA: 0x00317A28 File Offset: 0x00315C28
			// (set) Token: 0x0600CD65 RID: 52581 RVA: 0x00063E5D File Offset: 0x0006205D
			public unsafe static Func<DeadDrop, bool> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeadDrop.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DeadDrop, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeadDrop.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AC2 RID: 35522
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008AC3 RID: 35523
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04008AC4 RID: 35524
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AC5 RID: 35525
			private static readonly IntPtr NativeMethodInfoPtr__GetRandomEmptyDrop_b__18_0_Internal_Boolean_DeadDrop_0;
		}

		// Token: 0x020009E5 RID: 2533
		[ObfuscatedName("ScheduleOne.Economy.DeadDrop+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD66 RID: 52582 RVA: 0x00317A50 File Offset: 0x00315C50
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<DeadDrop.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass18_0>.NativeClassPtr);
				DeadDrop.__c__DisplayClass18_0.NativeFieldInfoPtr_origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass18_0>.NativeClassPtr, "origin");
				DeadDrop.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass18_0>.NativeClassPtr, 100674811);
				DeadDrop.__c__DisplayClass18_0.NativeMethodInfoPtr__GetRandomEmptyDrop_b__1_Internal_Single_DeadDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass18_0>.NativeClassPtr, 100674812);
			}

			// Token: 0x0600CD67 RID: 52583 RVA: 0x00317AB8 File Offset: 0x00315CB8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD68 RID: 52584 RVA: 0x00317AF4 File Offset: 0x00315CF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190745, XrefRangeEnd = 190750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetRandomEmptyDrop_b__1(DeadDrop drop)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(drop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.__c__DisplayClass18_0.NativeMethodInfoPtr__GetRandomEmptyDrop_b__1_Internal_Single_DeadDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD69 RID: 52585 RVA: 0x00063E6F File Offset: 0x0006206F
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FF1 RID: 16369
			// (get) Token: 0x0600CD6A RID: 52586 RVA: 0x00317B44 File Offset: 0x00315D44
			// (set) Token: 0x0600CD6B RID: 52587 RVA: 0x00063E78 File Offset: 0x00062078
			public unsafe Vector3 origin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.__c__DisplayClass18_0.NativeFieldInfoPtr_origin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.__c__DisplayClass18_0.NativeFieldInfoPtr_origin)) = value;
				}
			}

			// Token: 0x04008AC6 RID: 35526
			private static readonly IntPtr NativeFieldInfoPtr_origin;

			// Token: 0x04008AC7 RID: 35527
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AC8 RID: 35528
			private static readonly IntPtr NativeMethodInfoPtr__GetRandomEmptyDrop_b__1_Internal_Single_DeadDrop_0;
		}
	}
}
