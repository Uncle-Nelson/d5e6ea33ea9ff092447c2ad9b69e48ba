using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x0200076D RID: 1901
	public class ToggleableLight : MonoBehaviour
	{
		// Token: 0x0600B486 RID: 46214 RVA: 0x002CF308 File Offset: 0x002CD508
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleableLight()
		{
			Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "ToggleableLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr);
			ToggleableLight.NativeFieldInfoPtr_isOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "isOn");
			ToggleableLight.NativeFieldInfoPtr_lightSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightSources");
			ToggleableLight.NativeFieldInfoPtr_lightSurfacesMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightSurfacesMeshes");
			ToggleableLight.NativeFieldInfoPtr_MaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "MaterialIndex");
			ToggleableLight.NativeFieldInfoPtr_lightOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightOnMat");
			ToggleableLight.NativeFieldInfoPtr_lightOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightOffMat");
			ToggleableLight.NativeFieldInfoPtr_constructable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "constructable");
			ToggleableLight.NativeFieldInfoPtr_lightsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightsApplied");
			ToggleableLight.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100685518);
			ToggleableLight.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100685519);
			ToggleableLight.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100685520);
			ToggleableLight.NativeMethodInfoPtr_TurnOn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100685521);
			ToggleableLight.NativeMethodInfoPtr_TurnOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100685522);
			ToggleableLight.NativeMethodInfoPtr_SetLights_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100685523);
			ToggleableLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100685524);
		}

		// Token: 0x0600B487 RID: 46215 RVA: 0x002CF464 File Offset: 0x002CD664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309760, XrefRangeEnd = 309764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableLight.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B488 RID: 46216 RVA: 0x002CF4A0 File Offset: 0x002CD6A0
		[CallerCount(0)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableLight.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B489 RID: 46217 RVA: 0x002CF4D4 File Offset: 0x002CD6D4
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableLight.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B48A RID: 46218 RVA: 0x002CF510 File Offset: 0x002CD710
		[CallerCount(0)]
		public unsafe void TurnOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableLight.NativeMethodInfoPtr_TurnOn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B48B RID: 46219 RVA: 0x002CF544 File Offset: 0x002CD744
		[CallerCount(0)]
		public unsafe void TurnOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableLight.NativeMethodInfoPtr_TurnOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B48C RID: 46220 RVA: 0x002CF578 File Offset: 0x002CD778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309764, XrefRangeEnd = 309778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLights(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableLight.NativeMethodInfoPtr_SetLights_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B48D RID: 46221 RVA: 0x002CF5C4 File Offset: 0x002CD7C4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleableLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B48E RID: 46222 RVA: 0x00058896 File Offset: 0x00056A96
		public ToggleableLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037F6 RID: 14326
		// (get) Token: 0x0600B48F RID: 46223 RVA: 0x002CF600 File Offset: 0x002CD800
		// (set) Token: 0x0600B490 RID: 46224 RVA: 0x0005889F File Offset: 0x00056A9F
		public unsafe bool isOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_isOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_isOn)) = value;
			}
		}

		// Token: 0x170037F7 RID: 14327
		// (get) Token: 0x0600B491 RID: 46225 RVA: 0x002CF628 File Offset: 0x002CD828
		// (set) Token: 0x0600B492 RID: 46226 RVA: 0x000588BA File Offset: 0x00056ABA
		public unsafe Il2CppReferenceArray<OptimizedLight> lightSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037F8 RID: 14328
		// (get) Token: 0x0600B493 RID: 46227 RVA: 0x002CF658 File Offset: 0x002CD858
		// (set) Token: 0x0600B494 RID: 46228 RVA: 0x000588D9 File Offset: 0x00056AD9
		public unsafe Il2CppReferenceArray<MeshRenderer> lightSurfacesMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightSurfacesMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightSurfacesMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037F9 RID: 14329
		// (get) Token: 0x0600B495 RID: 46229 RVA: 0x002CF688 File Offset: 0x002CD888
		// (set) Token: 0x0600B496 RID: 46230 RVA: 0x000588F8 File Offset: 0x00056AF8
		public unsafe int MaterialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_MaterialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_MaterialIndex)) = value;
			}
		}

		// Token: 0x170037FA RID: 14330
		// (get) Token: 0x0600B497 RID: 46231 RVA: 0x002CF6B0 File Offset: 0x002CD8B0
		// (set) Token: 0x0600B498 RID: 46232 RVA: 0x00058913 File Offset: 0x00056B13
		public unsafe Material lightOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037FB RID: 14331
		// (get) Token: 0x0600B499 RID: 46233 RVA: 0x002CF6E0 File Offset: 0x002CD8E0
		// (set) Token: 0x0600B49A RID: 46234 RVA: 0x00058932 File Offset: 0x00056B32
		public unsafe Material lightOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037FC RID: 14332
		// (get) Token: 0x0600B49B RID: 46235 RVA: 0x002CF710 File Offset: 0x002CD910
		// (set) Token: 0x0600B49C RID: 46236 RVA: 0x00058951 File Offset: 0x00056B51
		public unsafe Constructable_GridBased constructable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_constructable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_constructable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037FD RID: 14333
		// (get) Token: 0x0600B49D RID: 46237 RVA: 0x002CF740 File Offset: 0x002CD940
		// (set) Token: 0x0600B49E RID: 46238 RVA: 0x00058970 File Offset: 0x00056B70
		public unsafe bool lightsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightsApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightsApplied)) = value;
			}
		}

		// Token: 0x040079B3 RID: 31155
		private static readonly IntPtr NativeFieldInfoPtr_isOn;

		// Token: 0x040079B4 RID: 31156
		private static readonly IntPtr NativeFieldInfoPtr_lightSources;

		// Token: 0x040079B5 RID: 31157
		private static readonly IntPtr NativeFieldInfoPtr_lightSurfacesMeshes;

		// Token: 0x040079B6 RID: 31158
		private static readonly IntPtr NativeFieldInfoPtr_MaterialIndex;

		// Token: 0x040079B7 RID: 31159
		private static readonly IntPtr NativeFieldInfoPtr_lightOnMat;

		// Token: 0x040079B8 RID: 31160
		private static readonly IntPtr NativeFieldInfoPtr_lightOffMat;

		// Token: 0x040079B9 RID: 31161
		private static readonly IntPtr NativeFieldInfoPtr_constructable;

		// Token: 0x040079BA RID: 31162
		private static readonly IntPtr NativeFieldInfoPtr_lightsApplied;

		// Token: 0x040079BB RID: 31163
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040079BC RID: 31164
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040079BD RID: 31165
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040079BE RID: 31166
		private static readonly IntPtr NativeMethodInfoPtr_TurnOn_Public_Void_0;

		// Token: 0x040079BF RID: 31167
		private static readonly IntPtr NativeMethodInfoPtr_TurnOff_Public_Void_0;

		// Token: 0x040079C0 RID: 31168
		private static readonly IntPtr NativeMethodInfoPtr_SetLights_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040079C1 RID: 31169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
