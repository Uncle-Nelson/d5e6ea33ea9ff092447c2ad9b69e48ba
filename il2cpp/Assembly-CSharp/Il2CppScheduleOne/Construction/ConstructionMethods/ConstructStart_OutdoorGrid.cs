using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x02000489 RID: 1161
	public class ConstructStart_OutdoorGrid : ConstructStart_Base
	{
		// Token: 0x060064AD RID: 25773 RVA: 0x001C7530 File Offset: 0x001C5730
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructStart_OutdoorGrid()
		{
			Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructStart_OutdoorGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr);
			ConstructStart_OutdoorGrid.NativeFieldInfoPtr_constructable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr, "constructable");
			ConstructStart_OutdoorGrid.NativeFieldInfoPtr_ghostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr, "ghostModel");
			ConstructStart_OutdoorGrid.NativeMethodInfoPtr_StartConstruction_Public_Virtual_Void_String_Constructable_GridBased_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr, 100676053);
			ConstructStart_OutdoorGrid.NativeMethodInfoPtr_GenerateGhostModel_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr, 100676054);
			ConstructStart_OutdoorGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr, 100676055);
		}

		// Token: 0x060064AE RID: 25774 RVA: 0x001C75C4 File Offset: 0x001C57C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204639, XrefRangeEnd = 204667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartConstruction(string constructableID, Constructable_GridBased movedConstructable = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(constructableID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(movedConstructable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructStart_OutdoorGrid.NativeMethodInfoPtr_StartConstruction_Public_Virtual_Void_String_Constructable_GridBased_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064AF RID: 25775 RVA: 0x001C7624 File Offset: 0x001C5824
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204713, RefRangeEnd = 204714, XrefRangeStart = 204667, XrefRangeEnd = 204713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateGhostModel(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructStart_OutdoorGrid.NativeMethodInfoPtr_GenerateGhostModel_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064B0 RID: 25776 RVA: 0x001C7668 File Offset: 0x001C5868
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructStart_OutdoorGrid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructStart_OutdoorGrid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructStart_OutdoorGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064B1 RID: 25777 RVA: 0x0002F999 File Offset: 0x0002DB99
		public ConstructStart_OutdoorGrid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x060064B2 RID: 25778 RVA: 0x001C76A4 File Offset: 0x001C58A4
		// (set) Token: 0x060064B3 RID: 25779 RVA: 0x0002F9A2 File Offset: 0x0002DBA2
		public unsafe Constructable_GridBased constructable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructStart_OutdoorGrid.NativeFieldInfoPtr_constructable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructStart_OutdoorGrid.NativeFieldInfoPtr_constructable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x060064B4 RID: 25780 RVA: 0x001C76D4 File Offset: 0x001C58D4
		// (set) Token: 0x060064B5 RID: 25781 RVA: 0x0002F9C1 File Offset: 0x0002DBC1
		public unsafe Transform ghostModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructStart_OutdoorGrid.NativeFieldInfoPtr_ghostModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructStart_OutdoorGrid.NativeFieldInfoPtr_ghostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040044B3 RID: 17587
		private static readonly IntPtr NativeFieldInfoPtr_constructable;

		// Token: 0x040044B4 RID: 17588
		private static readonly IntPtr NativeFieldInfoPtr_ghostModel;

		// Token: 0x040044B5 RID: 17589
		private static readonly IntPtr NativeMethodInfoPtr_StartConstruction_Public_Virtual_Void_String_Constructable_GridBased_0;

		// Token: 0x040044B6 RID: 17590
		private static readonly IntPtr NativeMethodInfoPtr_GenerateGhostModel_Private_Void_String_0;

		// Token: 0x040044B7 RID: 17591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
