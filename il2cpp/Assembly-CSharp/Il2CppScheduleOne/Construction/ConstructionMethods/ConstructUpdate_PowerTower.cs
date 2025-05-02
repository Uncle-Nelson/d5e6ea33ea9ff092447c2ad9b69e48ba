using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Property.Utilities.Power;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x0200048F RID: 1167
	public class ConstructUpdate_PowerTower : ConstructUpdate_OutdoorGrid
	{
		// Token: 0x060064FD RID: 25853 RVA: 0x001C84DC File Offset: 0x001C66DC
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructUpdate_PowerTower()
		{
			Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructUpdate_PowerTower");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr);
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_specialMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "specialMat");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_powerLine_GhostMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "powerLine_GhostMat");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_cosmeticPowerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "cosmeticPowerNode");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_LengthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "LengthFactor");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_tempPowerLineContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "tempPowerLineContainer");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_tempSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "tempSegments");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_hoveredPowerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "hoveredPowerNode");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_startNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "startNode");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_powerLineInitialDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "powerLineInitialDistance");
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676085);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_ConstructionStop_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676086);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676087);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676088);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676089);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_GetHoveredPowerTower_Private_PowerTower_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676090);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_GetHoveredPowerNode_Protected_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676091);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_PlaceNewConstructable_Protected_Virtual_Constructable_GridBased_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676092);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_CompletePowerLine_Private_Void_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676093);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_StopCreatingPowerLine_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676094);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676095);
		}

		// Token: 0x060064FE RID: 25854 RVA: 0x001C869C File Offset: 0x001C689C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205287, XrefRangeEnd = 205352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerTower.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064FF RID: 25855 RVA: 0x001C86D8 File Offset: 0x001C68D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205352, XrefRangeEnd = 205363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConstructionStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerTower.NativeMethodInfoPtr_ConstructionStop_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006500 RID: 25856 RVA: 0x001C8714 File Offset: 0x001C6914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205363, XrefRangeEnd = 205417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerTower.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006501 RID: 25857 RVA: 0x001C8750 File Offset: 0x001C6950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205417, XrefRangeEnd = 205500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerTower.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006502 RID: 25858 RVA: 0x001C878C File Offset: 0x001C698C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205500, XrefRangeEnd = 205505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerTower.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006503 RID: 25859 RVA: 0x001C87D0 File Offset: 0x001C69D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205505, XrefRangeEnd = 205538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerTower GetHoveredPowerTower()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerTower.NativeMethodInfoPtr_GetHoveredPowerTower_Private_PowerTower_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PowerTower>(intPtr3) : null;
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x001C8810 File Offset: 0x001C6A10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205558, RefRangeEnd = 205560, XrefRangeStart = 205538, XrefRangeEnd = 205558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerNode GetHoveredPowerNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerTower.NativeMethodInfoPtr_GetHoveredPowerNode_Protected_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr3) : null;
		}

		// Token: 0x06006505 RID: 25861 RVA: 0x001C8850 File Offset: 0x001C6A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205560, XrefRangeEnd = 205589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Constructable_GridBased PlaceNewConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerTower.NativeMethodInfoPtr_PlaceNewConstructable_Protected_Virtual_Constructable_GridBased_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr3) : null;
		}

		// Token: 0x06006506 RID: 25862 RVA: 0x001C889C File Offset: 0x001C6A9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205612, RefRangeEnd = 205613, XrefRangeStart = 205589, XrefRangeEnd = 205612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompletePowerLine(PowerNode target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerTower.NativeMethodInfoPtr_CompletePowerLine_Private_Void_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006507 RID: 25863 RVA: 0x001C88E0 File Offset: 0x001C6AE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 205626, RefRangeEnd = 205629, XrefRangeStart = 205613, XrefRangeEnd = 205626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCreatingPowerLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerTower.NativeMethodInfoPtr_StopCreatingPowerLine_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006508 RID: 25864 RVA: 0x001C8914 File Offset: 0x001C6B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205629, XrefRangeEnd = 205637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructUpdate_PowerTower() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerTower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006509 RID: 25865 RVA: 0x0002FC22 File Offset: 0x0002DE22
		public ConstructUpdate_PowerTower(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x0600650A RID: 25866 RVA: 0x001C8950 File Offset: 0x001C6B50
		// (set) Token: 0x0600650B RID: 25867 RVA: 0x0002FC2B File Offset: 0x0002DE2B
		public unsafe Material specialMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_specialMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_specialMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x0600650C RID: 25868 RVA: 0x001C8980 File Offset: 0x001C6B80
		// (set) Token: 0x0600650D RID: 25869 RVA: 0x0002FC4A File Offset: 0x0002DE4A
		public unsafe Material powerLine_GhostMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_powerLine_GhostMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_powerLine_GhostMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x0600650E RID: 25870 RVA: 0x001C89B0 File Offset: 0x001C6BB0
		// (set) Token: 0x0600650F RID: 25871 RVA: 0x0002FC69 File Offset: 0x0002DE69
		public unsafe GameObject cosmeticPowerNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_cosmeticPowerNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_cosmeticPowerNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x06006510 RID: 25872 RVA: 0x001C89E0 File Offset: 0x001C6BE0
		// (set) Token: 0x06006511 RID: 25873 RVA: 0x0002FC88 File Offset: 0x0002DE88
		public unsafe float LengthFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_LengthFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_LengthFactor)) = value;
			}
		}

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x06006512 RID: 25874 RVA: 0x001C8A08 File Offset: 0x001C6C08
		// (set) Token: 0x06006513 RID: 25875 RVA: 0x0002FCA3 File Offset: 0x0002DEA3
		public unsafe Transform tempPowerLineContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_tempPowerLineContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_tempPowerLineContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x06006514 RID: 25876 RVA: 0x001C8A38 File Offset: 0x001C6C38
		// (set) Token: 0x06006515 RID: 25877 RVA: 0x0002FCC2 File Offset: 0x0002DEC2
		public unsafe List<Transform> tempSegments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_tempSegments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_tempSegments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x06006516 RID: 25878 RVA: 0x001C8A68 File Offset: 0x001C6C68
		// (set) Token: 0x06006517 RID: 25879 RVA: 0x0002FCE1 File Offset: 0x0002DEE1
		public unsafe PowerNode hoveredPowerNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_hoveredPowerNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_hoveredPowerNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x06006518 RID: 25880 RVA: 0x001C8A98 File Offset: 0x001C6C98
		// (set) Token: 0x06006519 RID: 25881 RVA: 0x0002FD00 File Offset: 0x0002DF00
		public unsafe PowerNode startNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_startNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_startNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x0600651A RID: 25882 RVA: 0x001C8AC8 File Offset: 0x001C6CC8
		// (set) Token: 0x0600651B RID: 25883 RVA: 0x0002FD1F File Offset: 0x0002DF1F
		public unsafe float powerLineInitialDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_powerLineInitialDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_powerLineInitialDistance)) = value;
			}
		}

		// Token: 0x040044E5 RID: 17637
		private static readonly IntPtr NativeFieldInfoPtr_specialMat;

		// Token: 0x040044E6 RID: 17638
		private static readonly IntPtr NativeFieldInfoPtr_powerLine_GhostMat;

		// Token: 0x040044E7 RID: 17639
		private static readonly IntPtr NativeFieldInfoPtr_cosmeticPowerNode;

		// Token: 0x040044E8 RID: 17640
		private static readonly IntPtr NativeFieldInfoPtr_LengthFactor;

		// Token: 0x040044E9 RID: 17641
		private static readonly IntPtr NativeFieldInfoPtr_tempPowerLineContainer;

		// Token: 0x040044EA RID: 17642
		private static readonly IntPtr NativeFieldInfoPtr_tempSegments;

		// Token: 0x040044EB RID: 17643
		private static readonly IntPtr NativeFieldInfoPtr_hoveredPowerNode;

		// Token: 0x040044EC RID: 17644
		private static readonly IntPtr NativeFieldInfoPtr_startNode;

		// Token: 0x040044ED RID: 17645
		private static readonly IntPtr NativeFieldInfoPtr_powerLineInitialDistance;

		// Token: 0x040044EE RID: 17646
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040044EF RID: 17647
		private static readonly IntPtr NativeMethodInfoPtr_ConstructionStop_Public_Virtual_Void_0;

		// Token: 0x040044F0 RID: 17648
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040044F1 RID: 17649
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x040044F2 RID: 17650
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x040044F3 RID: 17651
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredPowerTower_Private_PowerTower_0;

		// Token: 0x040044F4 RID: 17652
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredPowerNode_Protected_PowerNode_0;

		// Token: 0x040044F5 RID: 17653
		private static readonly IntPtr NativeMethodInfoPtr_PlaceNewConstructable_Protected_Virtual_Constructable_GridBased_0;

		// Token: 0x040044F6 RID: 17654
		private static readonly IntPtr NativeMethodInfoPtr_CompletePowerLine_Private_Void_PowerNode_0;

		// Token: 0x040044F7 RID: 17655
		private static readonly IntPtr NativeMethodInfoPtr_StopCreatingPowerLine_Private_Void_0;

		// Token: 0x040044F8 RID: 17656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
