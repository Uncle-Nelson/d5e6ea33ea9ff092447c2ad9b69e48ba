using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities.Power
{
	// Token: 0x0200051A RID: 1306
	public class PowerNode : MonoBehaviour
	{
		// Token: 0x06007452 RID: 29778 RVA: 0x001FB358 File Offset: 0x001F9558
		// Note: this type is marked as 'beforefieldinit'.
		static PowerNode()
		{
			Il2CppClassPointerStore<PowerNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities.Power", "PowerNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerNode>.NativeClassPtr);
			PowerNode.NativeFieldInfoPtr_poweredNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, "poweredNode");
			PowerNode.NativeFieldInfoPtr_consumptionNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, "consumptionNode");
			PowerNode.NativeFieldInfoPtr_isConnectedToPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, "isConnectedToPower");
			PowerNode.NativeFieldInfoPtr_connectionPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, "connectionPoint");
			PowerNode.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, "connections");
			PowerNode.NativeMethodInfoPtr_get_pConnectionPoint_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, 100677922);
			PowerNode.NativeMethodInfoPtr_IsConnectedTo_Public_Boolean_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, 100677923);
			PowerNode.NativeMethodInfoPtr_RecalculatePowerNetwork_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, 100677924);
			PowerNode.NativeMethodInfoPtr_GetConnectedNodes_Public_List_1_PowerNode_List_1_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, 100677925);
			PowerNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, 100677926);
		}

		// Token: 0x17002345 RID: 9029
		// (get) Token: 0x06007453 RID: 29779 RVA: 0x001FB450 File Offset: 0x001F9650
		public unsafe Transform pConnectionPoint
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerNode.NativeMethodInfoPtr_get_pConnectionPoint_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06007454 RID: 29780 RVA: 0x001FB490 File Offset: 0x001F9690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227527, XrefRangeEnd = 227544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsConnectedTo(PowerNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerNode.NativeMethodInfoPtr_IsConnectedTo_Public_Boolean_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007455 RID: 29781 RVA: 0x001FB4E0 File Offset: 0x001F96E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227576, RefRangeEnd = 227579, XrefRangeStart = 227544, XrefRangeEnd = 227576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculatePowerNetwork()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerNode.NativeMethodInfoPtr_RecalculatePowerNetwork_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007456 RID: 29782 RVA: 0x001FB514 File Offset: 0x001F9714
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227612, RefRangeEnd = 227614, XrefRangeStart = 227579, XrefRangeEnd = 227612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<PowerNode> GetConnectedNodes(List<PowerNode> exclusions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exclusions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerNode.NativeMethodInfoPtr_GetConnectedNodes_Public_List_1_PowerNode_List_1_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PowerNode>>(intPtr3) : null;
		}

		// Token: 0x06007457 RID: 29783 RVA: 0x001FB564 File Offset: 0x001F9764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227614, XrefRangeEnd = 227622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerNode() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007458 RID: 29784 RVA: 0x000373F6 File Offset: 0x000355F6
		public PowerNode(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002340 RID: 9024
		// (get) Token: 0x06007459 RID: 29785 RVA: 0x001FB5A0 File Offset: 0x001F97A0
		// (set) Token: 0x0600745A RID: 29786 RVA: 0x000373FF File Offset: 0x000355FF
		public unsafe bool poweredNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_poweredNode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_poweredNode)) = value;
			}
		}

		// Token: 0x17002341 RID: 9025
		// (get) Token: 0x0600745B RID: 29787 RVA: 0x001FB5C8 File Offset: 0x001F97C8
		// (set) Token: 0x0600745C RID: 29788 RVA: 0x0003741A File Offset: 0x0003561A
		public unsafe bool consumptionNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_consumptionNode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_consumptionNode)) = value;
			}
		}

		// Token: 0x17002342 RID: 9026
		// (get) Token: 0x0600745D RID: 29789 RVA: 0x001FB5F0 File Offset: 0x001F97F0
		// (set) Token: 0x0600745E RID: 29790 RVA: 0x00037435 File Offset: 0x00035635
		public unsafe bool isConnectedToPower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_isConnectedToPower);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_isConnectedToPower)) = value;
			}
		}

		// Token: 0x17002343 RID: 9027
		// (get) Token: 0x0600745F RID: 29791 RVA: 0x001FB618 File Offset: 0x001F9818
		// (set) Token: 0x06007460 RID: 29792 RVA: 0x00037450 File Offset: 0x00035650
		public unsafe Transform connectionPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_connectionPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_connectionPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002344 RID: 9028
		// (get) Token: 0x06007461 RID: 29793 RVA: 0x001FB648 File Offset: 0x001F9848
		// (set) Token: 0x06007462 RID: 29794 RVA: 0x0003746F File Offset: 0x0003566F
		public unsafe List<PowerLine> connections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_connections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PowerLine>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004F6E RID: 20334
		private static readonly IntPtr NativeFieldInfoPtr_poweredNode;

		// Token: 0x04004F6F RID: 20335
		private static readonly IntPtr NativeFieldInfoPtr_consumptionNode;

		// Token: 0x04004F70 RID: 20336
		private static readonly IntPtr NativeFieldInfoPtr_isConnectedToPower;

		// Token: 0x04004F71 RID: 20337
		private static readonly IntPtr NativeFieldInfoPtr_connectionPoint;

		// Token: 0x04004F72 RID: 20338
		private static readonly IntPtr NativeFieldInfoPtr_connections;

		// Token: 0x04004F73 RID: 20339
		private static readonly IntPtr NativeMethodInfoPtr_get_pConnectionPoint_Public_get_Transform_0;

		// Token: 0x04004F74 RID: 20340
		private static readonly IntPtr NativeMethodInfoPtr_IsConnectedTo_Public_Boolean_PowerNode_0;

		// Token: 0x04004F75 RID: 20341
		private static readonly IntPtr NativeMethodInfoPtr_RecalculatePowerNetwork_Public_Void_0;

		// Token: 0x04004F76 RID: 20342
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectedNodes_Public_List_1_PowerNode_List_1_PowerNode_0;

		// Token: 0x04004F77 RID: 20343
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
