using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000591 RID: 1425
	public class PourableModule : ItemModule
	{
		// Token: 0x06007D46 RID: 32070 RVA: 0x0021959C File Offset: 0x0021779C
		// Note: this type is marked as 'beforefieldinit'.
		static PourableModule()
		{
			Il2CppClassPointerStore<PourableModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "PourableModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableModule>.NativeClassPtr);
			PourableModule.NativeFieldInfoPtr__IsPouring_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "<IsPouring>k__BackingField");
			PourableModule.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "<NormalizedPourRate>k__BackingField");
			PourableModule.NativeFieldInfoPtr__LiquidLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "<LiquidLevel>k__BackingField");
			PourableModule.NativeFieldInfoPtr_LiquidType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "LiquidType");
			PourableModule.NativeFieldInfoPtr_PourRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourRate");
			PourableModule.NativeFieldInfoPtr_AngleFromUpToPour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "AngleFromUpToPour");
			PourableModule.NativeFieldInfoPtr_OnlyEmptyOverFillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "OnlyEmptyOverFillable");
			PourableModule.NativeFieldInfoPtr_LiquidCapacity_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "LiquidCapacity_L");
			PourableModule.NativeFieldInfoPtr_LiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "LiquidColor");
			PourableModule.NativeFieldInfoPtr_DefaultLiquid_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "DefaultLiquid_L");
			PourableModule.NativeFieldInfoPtr_PourParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourParticles");
			PourableModule.NativeFieldInfoPtr_PourPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourPoint");
			PourableModule.NativeFieldInfoPtr_LiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "LiquidContainer");
			PourableModule.NativeFieldInfoPtr_Draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "Draggable");
			PourableModule.NativeFieldInfoPtr_DraggableConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "DraggableConstraint");
			PourableModule.NativeFieldInfoPtr_PourSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourSound");
			PourableModule.NativeFieldInfoPtr_PourParticlesColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourParticlesColor");
			PourableModule.NativeFieldInfoPtr_ParticleMinMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "ParticleMinMultiplier");
			PourableModule.NativeFieldInfoPtr_ParticleMaxMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "ParticleMaxMultiplier");
			PourableModule.NativeFieldInfoPtr_particleMinSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "particleMinSizes");
			PourableModule.NativeFieldInfoPtr_particleMaxSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "particleMaxSizes");
			PourableModule.NativeFieldInfoPtr_activeFillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "activeFillable");
			PourableModule.NativeFieldInfoPtr_timeSinceFillableHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "timeSinceFillableHit");
			PourableModule.NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678974);
			PourableModule.NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678975);
			PourableModule.NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678976);
			PourableModule.NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678977);
			PourableModule.NativeMethodInfoPtr_get_LiquidLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678978);
			PourableModule.NativeMethodInfoPtr_set_LiquidLevel_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678979);
			PourableModule.NativeMethodInfoPtr_get_NormalizedLiquidLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678980);
			PourableModule.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678981);
			PourableModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678982);
			PourableModule.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678983);
			PourableModule.NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678984);
			PourableModule.NativeMethodInfoPtr_UpdatePourSound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678985);
			PourableModule.NativeMethodInfoPtr_ChangeLiquidLevel_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678986);
			PourableModule.NativeMethodInfoPtr_SetLiquidLevel_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678987);
			PourableModule.NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678988);
			PourableModule.NativeMethodInfoPtr_ParticleCollision_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678989);
			PourableModule.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678990);
			PourableModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678991);
		}

		// Token: 0x170025FC RID: 9724
		// (get) Token: 0x06007D47 RID: 32071 RVA: 0x00219900 File Offset: 0x00217B00
		// (set) Token: 0x06007D48 RID: 32072 RVA: 0x0021993C File Offset: 0x00217B3C
		public unsafe bool IsPouring
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025FD RID: 9725
		// (get) Token: 0x06007D49 RID: 32073 RVA: 0x0021997C File Offset: 0x00217B7C
		// (set) Token: 0x06007D4A RID: 32074 RVA: 0x002199B8 File Offset: 0x00217BB8
		public unsafe float NormalizedPourRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025FE RID: 9726
		// (get) Token: 0x06007D4B RID: 32075 RVA: 0x002199F8 File Offset: 0x00217BF8
		// (set) Token: 0x06007D4C RID: 32076 RVA: 0x00219A34 File Offset: 0x00217C34
		public unsafe float LiquidLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_get_LiquidLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 49126, RefRangeEnd = 49129, XrefRangeStart = 49126, XrefRangeEnd = 49129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_set_LiquidLevel_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025FF RID: 9727
		// (get) Token: 0x06007D4D RID: 32077 RVA: 0x00219A74 File Offset: 0x00217C74
		public unsafe float NormalizedLiquidLevel
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 237935, RefRangeEnd = 237940, XrefRangeStart = 237935, XrefRangeEnd = 237935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_get_NormalizedLiquidLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007D4E RID: 32078 RVA: 0x00219AB0 File Offset: 0x00217CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237940, XrefRangeEnd = 237980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D4F RID: 32079 RVA: 0x00219AEC File Offset: 0x00217CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237980, XrefRangeEnd = 237991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActivateModule(StationItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D50 RID: 32080 RVA: 0x00219B3C File Offset: 0x00217D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237991, XrefRangeEnd = 237999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D51 RID: 32081 RVA: 0x00219B78 File Offset: 0x00217D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237999, XrefRangeEnd = 238025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePouring()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D52 RID: 32082 RVA: 0x00219BB4 File Offset: 0x00217DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238025, XrefRangeEnd = 238031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePourSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_UpdatePourSound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D53 RID: 32083 RVA: 0x00219BE8 File Offset: 0x00217DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238031, XrefRangeEnd = 238037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ChangeLiquidLevel(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_ChangeLiquidLevel_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D54 RID: 32084 RVA: 0x00219C34 File Offset: 0x00217E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238037, XrefRangeEnd = 238043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLiquidLevel(float level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_SetLiquidLevel_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D55 RID: 32085 RVA: 0x00219C80 File Offset: 0x00217E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238043, XrefRangeEnd = 238061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D56 RID: 32086 RVA: 0x00219CCC File Offset: 0x00217ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238061, XrefRangeEnd = 238070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParticleCollision(GameObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_ParticleCollision_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D57 RID: 32087 RVA: 0x00219D10 File Offset: 0x00217F10
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007D58 RID: 32088 RVA: 0x00219D58 File Offset: 0x00217F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238070, XrefRangeEnd = 238075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourableModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D59 RID: 32089 RVA: 0x0003B822 File Offset: 0x00039A22
		public PourableModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025E5 RID: 9701
		// (get) Token: 0x06007D5A RID: 32090 RVA: 0x00219D94 File Offset: 0x00217F94
		// (set) Token: 0x06007D5B RID: 32091 RVA: 0x0003B82B File Offset: 0x00039A2B
		public unsafe bool _IsPouring_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__IsPouring_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__IsPouring_k__BackingField)) = value;
			}
		}

		// Token: 0x170025E6 RID: 9702
		// (get) Token: 0x06007D5C RID: 32092 RVA: 0x00219DBC File Offset: 0x00217FBC
		// (set) Token: 0x06007D5D RID: 32093 RVA: 0x0003B846 File Offset: 0x00039A46
		public unsafe float _NormalizedPourRate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField)) = value;
			}
		}

		// Token: 0x170025E7 RID: 9703
		// (get) Token: 0x06007D5E RID: 32094 RVA: 0x00219DE4 File Offset: 0x00217FE4
		// (set) Token: 0x06007D5F RID: 32095 RVA: 0x0003B861 File Offset: 0x00039A61
		public unsafe float _LiquidLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__LiquidLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__LiquidLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x170025E8 RID: 9704
		// (get) Token: 0x06007D60 RID: 32096 RVA: 0x00219E0C File Offset: 0x0021800C
		// (set) Token: 0x06007D61 RID: 32097 RVA: 0x0003B87C File Offset: 0x00039A7C
		public unsafe string LiquidType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170025E9 RID: 9705
		// (get) Token: 0x06007D62 RID: 32098 RVA: 0x00219E34 File Offset: 0x00218034
		// (set) Token: 0x06007D63 RID: 32099 RVA: 0x0003B89B File Offset: 0x00039A9B
		public unsafe float PourRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourRate)) = value;
			}
		}

		// Token: 0x170025EA RID: 9706
		// (get) Token: 0x06007D64 RID: 32100 RVA: 0x00219E5C File Offset: 0x0021805C
		// (set) Token: 0x06007D65 RID: 32101 RVA: 0x0003B8B6 File Offset: 0x00039AB6
		public unsafe float AngleFromUpToPour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_AngleFromUpToPour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_AngleFromUpToPour)) = value;
			}
		}

		// Token: 0x170025EB RID: 9707
		// (get) Token: 0x06007D66 RID: 32102 RVA: 0x00219E84 File Offset: 0x00218084
		// (set) Token: 0x06007D67 RID: 32103 RVA: 0x0003B8D1 File Offset: 0x00039AD1
		public unsafe bool OnlyEmptyOverFillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_OnlyEmptyOverFillable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_OnlyEmptyOverFillable)) = value;
			}
		}

		// Token: 0x170025EC RID: 9708
		// (get) Token: 0x06007D68 RID: 32104 RVA: 0x00219EAC File Offset: 0x002180AC
		// (set) Token: 0x06007D69 RID: 32105 RVA: 0x0003B8EC File Offset: 0x00039AEC
		public unsafe float LiquidCapacity_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidCapacity_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidCapacity_L)) = value;
			}
		}

		// Token: 0x170025ED RID: 9709
		// (get) Token: 0x06007D6A RID: 32106 RVA: 0x00219ED4 File Offset: 0x002180D4
		// (set) Token: 0x06007D6B RID: 32107 RVA: 0x0003B907 File Offset: 0x00039B07
		public unsafe Color LiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidColor)) = value;
			}
		}

		// Token: 0x170025EE RID: 9710
		// (get) Token: 0x06007D6C RID: 32108 RVA: 0x00219EFC File Offset: 0x002180FC
		// (set) Token: 0x06007D6D RID: 32109 RVA: 0x0003B922 File Offset: 0x00039B22
		public unsafe float DefaultLiquid_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_DefaultLiquid_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_DefaultLiquid_L)) = value;
			}
		}

		// Token: 0x170025EF RID: 9711
		// (get) Token: 0x06007D6E RID: 32110 RVA: 0x00219F24 File Offset: 0x00218124
		// (set) Token: 0x06007D6F RID: 32111 RVA: 0x0003B93D File Offset: 0x00039B3D
		public unsafe Il2CppReferenceArray<ParticleSystem> PourParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F0 RID: 9712
		// (get) Token: 0x06007D70 RID: 32112 RVA: 0x00219F54 File Offset: 0x00218154
		// (set) Token: 0x06007D71 RID: 32113 RVA: 0x0003B95C File Offset: 0x00039B5C
		public unsafe Transform PourPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F1 RID: 9713
		// (get) Token: 0x06007D72 RID: 32114 RVA: 0x00219F84 File Offset: 0x00218184
		// (set) Token: 0x06007D73 RID: 32115 RVA: 0x0003B97B File Offset: 0x00039B7B
		public unsafe LiquidContainer LiquidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F2 RID: 9714
		// (get) Token: 0x06007D74 RID: 32116 RVA: 0x00219FB4 File Offset: 0x002181B4
		// (set) Token: 0x06007D75 RID: 32117 RVA: 0x0003B99A File Offset: 0x00039B9A
		public unsafe Draggable Draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_Draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_Draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F3 RID: 9715
		// (get) Token: 0x06007D76 RID: 32118 RVA: 0x00219FE4 File Offset: 0x002181E4
		// (set) Token: 0x06007D77 RID: 32119 RVA: 0x0003B9B9 File Offset: 0x00039BB9
		public unsafe DraggableConstraint DraggableConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_DraggableConstraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_DraggableConstraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F4 RID: 9716
		// (get) Token: 0x06007D78 RID: 32120 RVA: 0x0021A014 File Offset: 0x00218214
		// (set) Token: 0x06007D79 RID: 32121 RVA: 0x0003B9D8 File Offset: 0x00039BD8
		public unsafe AudioSourceController PourSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F5 RID: 9717
		// (get) Token: 0x06007D7A RID: 32122 RVA: 0x0021A044 File Offset: 0x00218244
		// (set) Token: 0x06007D7B RID: 32123 RVA: 0x0003B9F7 File Offset: 0x00039BF7
		public unsafe Color PourParticlesColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourParticlesColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourParticlesColor)) = value;
			}
		}

		// Token: 0x170025F6 RID: 9718
		// (get) Token: 0x06007D7C RID: 32124 RVA: 0x0021A06C File Offset: 0x0021826C
		// (set) Token: 0x06007D7D RID: 32125 RVA: 0x0003BA12 File Offset: 0x00039C12
		public unsafe float ParticleMinMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_ParticleMinMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_ParticleMinMultiplier)) = value;
			}
		}

		// Token: 0x170025F7 RID: 9719
		// (get) Token: 0x06007D7E RID: 32126 RVA: 0x0021A094 File Offset: 0x00218294
		// (set) Token: 0x06007D7F RID: 32127 RVA: 0x0003BA2D File Offset: 0x00039C2D
		public unsafe float ParticleMaxMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_ParticleMaxMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_ParticleMaxMultiplier)) = value;
			}
		}

		// Token: 0x170025F8 RID: 9720
		// (get) Token: 0x06007D80 RID: 32128 RVA: 0x0021A0BC File Offset: 0x002182BC
		// (set) Token: 0x06007D81 RID: 32129 RVA: 0x0003BA48 File Offset: 0x00039C48
		public unsafe Il2CppStructArray<float> particleMinSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_particleMinSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_particleMinSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F9 RID: 9721
		// (get) Token: 0x06007D82 RID: 32130 RVA: 0x0021A0EC File Offset: 0x002182EC
		// (set) Token: 0x06007D83 RID: 32131 RVA: 0x0003BA67 File Offset: 0x00039C67
		public unsafe Il2CppStructArray<float> particleMaxSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_particleMaxSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_particleMaxSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025FA RID: 9722
		// (get) Token: 0x06007D84 RID: 32132 RVA: 0x0021A11C File Offset: 0x0021831C
		// (set) Token: 0x06007D85 RID: 32133 RVA: 0x0003BA86 File Offset: 0x00039C86
		public unsafe Fillable activeFillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_activeFillable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Fillable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_activeFillable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025FB RID: 9723
		// (get) Token: 0x06007D86 RID: 32134 RVA: 0x0021A14C File Offset: 0x0021834C
		// (set) Token: 0x06007D87 RID: 32135 RVA: 0x0003BAA5 File Offset: 0x00039CA5
		public unsafe float timeSinceFillableHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_timeSinceFillableHit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_timeSinceFillableHit)) = value;
			}
		}

		// Token: 0x0400553B RID: 21819
		private static readonly IntPtr NativeFieldInfoPtr__IsPouring_k__BackingField;

		// Token: 0x0400553C RID: 21820
		private static readonly IntPtr NativeFieldInfoPtr__NormalizedPourRate_k__BackingField;

		// Token: 0x0400553D RID: 21821
		private static readonly IntPtr NativeFieldInfoPtr__LiquidLevel_k__BackingField;

		// Token: 0x0400553E RID: 21822
		private static readonly IntPtr NativeFieldInfoPtr_LiquidType;

		// Token: 0x0400553F RID: 21823
		private static readonly IntPtr NativeFieldInfoPtr_PourRate;

		// Token: 0x04005540 RID: 21824
		private static readonly IntPtr NativeFieldInfoPtr_AngleFromUpToPour;

		// Token: 0x04005541 RID: 21825
		private static readonly IntPtr NativeFieldInfoPtr_OnlyEmptyOverFillable;

		// Token: 0x04005542 RID: 21826
		private static readonly IntPtr NativeFieldInfoPtr_LiquidCapacity_L;

		// Token: 0x04005543 RID: 21827
		private static readonly IntPtr NativeFieldInfoPtr_LiquidColor;

		// Token: 0x04005544 RID: 21828
		private static readonly IntPtr NativeFieldInfoPtr_DefaultLiquid_L;

		// Token: 0x04005545 RID: 21829
		private static readonly IntPtr NativeFieldInfoPtr_PourParticles;

		// Token: 0x04005546 RID: 21830
		private static readonly IntPtr NativeFieldInfoPtr_PourPoint;

		// Token: 0x04005547 RID: 21831
		private static readonly IntPtr NativeFieldInfoPtr_LiquidContainer;

		// Token: 0x04005548 RID: 21832
		private static readonly IntPtr NativeFieldInfoPtr_Draggable;

		// Token: 0x04005549 RID: 21833
		private static readonly IntPtr NativeFieldInfoPtr_DraggableConstraint;

		// Token: 0x0400554A RID: 21834
		private static readonly IntPtr NativeFieldInfoPtr_PourSound;

		// Token: 0x0400554B RID: 21835
		private static readonly IntPtr NativeFieldInfoPtr_PourParticlesColor;

		// Token: 0x0400554C RID: 21836
		private static readonly IntPtr NativeFieldInfoPtr_ParticleMinMultiplier;

		// Token: 0x0400554D RID: 21837
		private static readonly IntPtr NativeFieldInfoPtr_ParticleMaxMultiplier;

		// Token: 0x0400554E RID: 21838
		private static readonly IntPtr NativeFieldInfoPtr_particleMinSizes;

		// Token: 0x0400554F RID: 21839
		private static readonly IntPtr NativeFieldInfoPtr_particleMaxSizes;

		// Token: 0x04005550 RID: 21840
		private static readonly IntPtr NativeFieldInfoPtr_activeFillable;

		// Token: 0x04005551 RID: 21841
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceFillableHit;

		// Token: 0x04005552 RID: 21842
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0;

		// Token: 0x04005553 RID: 21843
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0;

		// Token: 0x04005554 RID: 21844
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0;

		// Token: 0x04005555 RID: 21845
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0;

		// Token: 0x04005556 RID: 21846
		private static readonly IntPtr NativeMethodInfoPtr_get_LiquidLevel_Public_get_Single_0;

		// Token: 0x04005557 RID: 21847
		private static readonly IntPtr NativeMethodInfoPtr_set_LiquidLevel_Protected_set_Void_Single_0;

		// Token: 0x04005558 RID: 21848
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedLiquidLevel_Public_get_Single_0;

		// Token: 0x04005559 RID: 21849
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x0400555A RID: 21850
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0;

		// Token: 0x0400555B RID: 21851
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400555C RID: 21852
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0;

		// Token: 0x0400555D RID: 21853
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePourSound_Private_Void_0;

		// Token: 0x0400555E RID: 21854
		private static readonly IntPtr NativeMethodInfoPtr_ChangeLiquidLevel_Public_Virtual_New_Void_Single_0;

		// Token: 0x0400555F RID: 21855
		private static readonly IntPtr NativeMethodInfoPtr_SetLiquidLevel_Public_Virtual_New_Void_Single_0;

		// Token: 0x04005560 RID: 21856
		private static readonly IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0;

		// Token: 0x04005561 RID: 21857
		private static readonly IntPtr NativeMethodInfoPtr_ParticleCollision_Private_Void_GameObject_0;

		// Token: 0x04005562 RID: 21858
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0;

		// Token: 0x04005563 RID: 21859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
