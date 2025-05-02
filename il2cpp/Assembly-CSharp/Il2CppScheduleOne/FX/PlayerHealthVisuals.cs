using System;
using Il2CppBeautify.Universal;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x020003F9 RID: 1017
	public class PlayerHealthVisuals : MonoBehaviour
	{
		// Token: 0x060054A7 RID: 21671 RVA: 0x0018C9C4 File Offset: 0x0018ABC4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerHealthVisuals()
		{
			Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "PlayerHealthVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr);
			PlayerHealthVisuals.NativeFieldInfoPtr_GlobalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "GlobalVolume");
			PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "VignetteAlpha_MaxHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MinHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "VignetteAlpha_MinHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_OuterRingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "OuterRingCurve");
			PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "Saturation_MaxHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MinHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "Saturation_MinHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "ChromAb_MaxHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MinHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "ChromAb_MinHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "LensDirt_MaxHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MinHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "LensDirt_MinHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr__beautifySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "_beautifySettings");
			PlayerHealthVisuals.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100673834);
			PlayerHealthVisuals.NativeMethodInfoPtr_Spawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100673835);
			PlayerHealthVisuals.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100673836);
			PlayerHealthVisuals.NativeMethodInfoPtr_UpdateEffects_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100673837);
			PlayerHealthVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100673838);
		}

		// Token: 0x060054A8 RID: 21672 RVA: 0x0018CB34 File Offset: 0x0018AD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180271, XrefRangeEnd = 180340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054A9 RID: 21673 RVA: 0x0018CB68 File Offset: 0x0018AD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180340, XrefRangeEnd = 180360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Spawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr_Spawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x0018CB9C File Offset: 0x0018AD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180360, XrefRangeEnd = 180367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054AB RID: 21675 RVA: 0x0018CBD0 File Offset: 0x0018ADD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180372, RefRangeEnd = 180373, XrefRangeStart = 180367, XrefRangeEnd = 180372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEffects(float newHealth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newHealth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr_UpdateEffects_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054AC RID: 21676 RVA: 0x0018CC10 File Offset: 0x0018AE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180373, XrefRangeEnd = 180374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerHealthVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x00028987 File Offset: 0x00026B87
		public PlayerHealthVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x060054AE RID: 21678 RVA: 0x0018CC4C File Offset: 0x0018AE4C
		// (set) Token: 0x060054AF RID: 21679 RVA: 0x00028990 File Offset: 0x00026B90
		public unsafe Volume GlobalVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_GlobalVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Volume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_GlobalVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x060054B0 RID: 21680 RVA: 0x0018CC7C File Offset: 0x0018AE7C
		// (set) Token: 0x060054B1 RID: 21681 RVA: 0x000289AF File Offset: 0x00026BAF
		public unsafe float VignetteAlpha_MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MaxHealth)) = value;
			}
		}

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x060054B2 RID: 21682 RVA: 0x0018CCA4 File Offset: 0x0018AEA4
		// (set) Token: 0x060054B3 RID: 21683 RVA: 0x000289CA File Offset: 0x00026BCA
		public unsafe float VignetteAlpha_MinHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MinHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MinHealth)) = value;
			}
		}

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x060054B4 RID: 21684 RVA: 0x0018CCCC File Offset: 0x0018AECC
		// (set) Token: 0x060054B5 RID: 21685 RVA: 0x000289E5 File Offset: 0x00026BE5
		public unsafe AnimationCurve OuterRingCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_OuterRingCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_OuterRingCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x060054B6 RID: 21686 RVA: 0x0018CCFC File Offset: 0x0018AEFC
		// (set) Token: 0x060054B7 RID: 21687 RVA: 0x00028A04 File Offset: 0x00026C04
		public unsafe float Saturation_MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MaxHealth)) = value;
			}
		}

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x060054B8 RID: 21688 RVA: 0x0018CD24 File Offset: 0x0018AF24
		// (set) Token: 0x060054B9 RID: 21689 RVA: 0x00028A1F File Offset: 0x00026C1F
		public unsafe float Saturation_MinHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MinHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MinHealth)) = value;
			}
		}

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x060054BA RID: 21690 RVA: 0x0018CD4C File Offset: 0x0018AF4C
		// (set) Token: 0x060054BB RID: 21691 RVA: 0x00028A3A File Offset: 0x00026C3A
		public unsafe float ChromAb_MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MaxHealth)) = value;
			}
		}

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x060054BC RID: 21692 RVA: 0x0018CD74 File Offset: 0x0018AF74
		// (set) Token: 0x060054BD RID: 21693 RVA: 0x00028A55 File Offset: 0x00026C55
		public unsafe float ChromAb_MinHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MinHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MinHealth)) = value;
			}
		}

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x060054BE RID: 21694 RVA: 0x0018CD9C File Offset: 0x0018AF9C
		// (set) Token: 0x060054BF RID: 21695 RVA: 0x00028A70 File Offset: 0x00026C70
		public unsafe float LensDirt_MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MaxHealth)) = value;
			}
		}

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x060054C0 RID: 21696 RVA: 0x0018CDC4 File Offset: 0x0018AFC4
		// (set) Token: 0x060054C1 RID: 21697 RVA: 0x00028A8B File Offset: 0x00026C8B
		public unsafe float LensDirt_MinHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MinHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MinHealth)) = value;
			}
		}

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x060054C2 RID: 21698 RVA: 0x0018CDEC File Offset: 0x0018AFEC
		// (set) Token: 0x060054C3 RID: 21699 RVA: 0x00028AA6 File Offset: 0x00026CA6
		public unsafe Beautify _beautifySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr__beautifySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Beautify>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr__beautifySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400394F RID: 14671
		private static readonly IntPtr NativeFieldInfoPtr_GlobalVolume;

		// Token: 0x04003950 RID: 14672
		private static readonly IntPtr NativeFieldInfoPtr_VignetteAlpha_MaxHealth;

		// Token: 0x04003951 RID: 14673
		private static readonly IntPtr NativeFieldInfoPtr_VignetteAlpha_MinHealth;

		// Token: 0x04003952 RID: 14674
		private static readonly IntPtr NativeFieldInfoPtr_OuterRingCurve;

		// Token: 0x04003953 RID: 14675
		private static readonly IntPtr NativeFieldInfoPtr_Saturation_MaxHealth;

		// Token: 0x04003954 RID: 14676
		private static readonly IntPtr NativeFieldInfoPtr_Saturation_MinHealth;

		// Token: 0x04003955 RID: 14677
		private static readonly IntPtr NativeFieldInfoPtr_ChromAb_MaxHealth;

		// Token: 0x04003956 RID: 14678
		private static readonly IntPtr NativeFieldInfoPtr_ChromAb_MinHealth;

		// Token: 0x04003957 RID: 14679
		private static readonly IntPtr NativeFieldInfoPtr_LensDirt_MaxHealth;

		// Token: 0x04003958 RID: 14680
		private static readonly IntPtr NativeFieldInfoPtr_LensDirt_MinHealth;

		// Token: 0x04003959 RID: 14681
		private static readonly IntPtr NativeFieldInfoPtr__beautifySettings;

		// Token: 0x0400395A RID: 14682
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400395B RID: 14683
		private static readonly IntPtr NativeMethodInfoPtr_Spawned_Private_Void_0;

		// Token: 0x0400395C RID: 14684
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400395D RID: 14685
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEffects_Private_Void_Single_0;

		// Token: 0x0400395E RID: 14686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
