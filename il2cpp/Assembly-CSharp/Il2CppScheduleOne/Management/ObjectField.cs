using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000396 RID: 918
	public class ObjectField : ConfigField
	{
		// Token: 0x06004810 RID: 18448 RVA: 0x00160C60 File Offset: 0x0015EE60
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectField()
		{
			Il2CppClassPointerStore<ObjectField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ObjectField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectField>.NativeClassPtr);
			ObjectField.NativeFieldInfoPtr_SelectedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "SelectedObject");
			ObjectField.NativeFieldInfoPtr_onObjectChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "onObjectChanged");
			ObjectField.NativeFieldInfoPtr_objectFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "objectFilter");
			ObjectField.NativeFieldInfoPtr_TypeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "TypeRequirements");
			ObjectField.NativeFieldInfoPtr_DrawTransitLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "DrawTransitLine");
			ObjectField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100672204);
			ObjectField.NativeMethodInfoPtr_SetObject_Public_Void_BuildableItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100672205);
			ObjectField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100672206);
			ObjectField.NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100672207);
			ObjectField.NativeMethodInfoPtr_Load_Public_Void_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100672208);
			ObjectField.NativeMethodInfoPtr_GetData_Public_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100672209);
		}

		// Token: 0x06004811 RID: 18449 RVA: 0x00160D6C File Offset: 0x0015EF6C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 161660, RefRangeEnd = 161673, XrefRangeStart = 161645, XrefRangeEnd = 161660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004812 RID: 18450 RVA: 0x00160DB8 File Offset: 0x0015EFB8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 161700, RefRangeEnd = 161708, XrefRangeStart = 161673, XrefRangeEnd = 161700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObject(BuildableItem obj, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr_SetObject_Public_Void_BuildableItem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004813 RID: 18451 RVA: 0x00160E08 File Offset: 0x0015F008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161708, XrefRangeEnd = 161712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004814 RID: 18452 RVA: 0x00160E50 File Offset: 0x0015F050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161712, XrefRangeEnd = 161713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectedObjectDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004815 RID: 18453 RVA: 0x00160E84 File Offset: 0x0015F084
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 161726, RefRangeEnd = 161739, XrefRangeStart = 161713, XrefRangeEnd = 161726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(ObjectFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr_Load_Public_Void_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004816 RID: 18454 RVA: 0x00160EC8 File Offset: 0x0015F0C8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 161751, RefRangeEnd = 161764, XrefRangeStart = 161739, XrefRangeEnd = 161751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr_GetData_Public_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr3) : null;
		}

		// Token: 0x06004817 RID: 18455 RVA: 0x00022DB5 File Offset: 0x00020FB5
		public ObjectField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x06004818 RID: 18456 RVA: 0x00160F08 File Offset: 0x0015F108
		// (set) Token: 0x06004819 RID: 18457 RVA: 0x00022DBE File Offset: 0x00020FBE
		public unsafe BuildableItem SelectedObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_SelectedObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_SelectedObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x0600481A RID: 18458 RVA: 0x00160F38 File Offset: 0x0015F138
		// (set) Token: 0x0600481B RID: 18459 RVA: 0x00022DDD File Offset: 0x00020FDD
		public unsafe UnityEvent<BuildableItem> onObjectChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_onObjectChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_onObjectChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x0600481C RID: 18460 RVA: 0x00160F68 File Offset: 0x0015F168
		// (set) Token: 0x0600481D RID: 18461 RVA: 0x00022DFC File Offset: 0x00020FFC
		public unsafe ObjectSelector.ObjectFilter objectFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_objectFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelector.ObjectFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_objectFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x0600481E RID: 18462 RVA: 0x00160F98 File Offset: 0x0015F198
		// (set) Token: 0x0600481F RID: 18463 RVA: 0x00022E1B File Offset: 0x0002101B
		public unsafe List<Type> TypeRequirements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_TypeRequirements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_TypeRequirements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x06004820 RID: 18464 RVA: 0x00160FC8 File Offset: 0x0015F1C8
		// (set) Token: 0x06004821 RID: 18465 RVA: 0x00022E3A File Offset: 0x0002103A
		public unsafe bool DrawTransitLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_DrawTransitLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_DrawTransitLine)) = value;
			}
		}

		// Token: 0x04003091 RID: 12433
		private static readonly IntPtr NativeFieldInfoPtr_SelectedObject;

		// Token: 0x04003092 RID: 12434
		private static readonly IntPtr NativeFieldInfoPtr_onObjectChanged;

		// Token: 0x04003093 RID: 12435
		private static readonly IntPtr NativeFieldInfoPtr_objectFilter;

		// Token: 0x04003094 RID: 12436
		private static readonly IntPtr NativeFieldInfoPtr_TypeRequirements;

		// Token: 0x04003095 RID: 12437
		private static readonly IntPtr NativeFieldInfoPtr_DrawTransitLine;

		// Token: 0x04003096 RID: 12438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x04003097 RID: 12439
		private static readonly IntPtr NativeMethodInfoPtr_SetObject_Public_Void_BuildableItem_Boolean_0;

		// Token: 0x04003098 RID: 12440
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x04003099 RID: 12441
		private static readonly IntPtr NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_0;

		// Token: 0x0400309A RID: 12442
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_ObjectFieldData_0;

		// Token: 0x0400309B RID: 12443
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_ObjectFieldData_0;
	}
}
