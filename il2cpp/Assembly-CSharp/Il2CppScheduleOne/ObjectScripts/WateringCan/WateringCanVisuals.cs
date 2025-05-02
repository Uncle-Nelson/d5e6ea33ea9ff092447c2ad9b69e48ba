using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x0200075E RID: 1886
	public class WateringCanVisuals : MonoBehaviour
	{
		// Token: 0x0600B35C RID: 45916 RVA: 0x002CBD80 File Offset: 0x002C9F80
		// Note: this type is marked as 'beforefieldinit'.
		static WateringCanVisuals()
		{
			Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.WateringCan", "WateringCanVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr);
			WateringCanVisuals.NativeFieldInfoPtr_OverflowParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "OverflowParticles");
			WateringCanVisuals.NativeFieldInfoPtr_WaterTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "WaterTransform");
			WateringCanVisuals.NativeFieldInfoPtr_WaterMaxY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "WaterMaxY");
			WateringCanVisuals.NativeFieldInfoPtr_WaterMinY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "WaterMinY");
			WateringCanVisuals.NativeFieldInfoPtr_SideWaterTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "SideWaterTransform");
			WateringCanVisuals.NativeFieldInfoPtr_SideWaterMinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "SideWaterMinScale");
			WateringCanVisuals.NativeFieldInfoPtr_SideWaterMaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "SideWaterMaxScale");
			WateringCanVisuals.NativeFieldInfoPtr_FillSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "FillSound");
			WateringCanVisuals.NativeMethodInfoPtr_SetFillLevel_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, 100685419);
			WateringCanVisuals.NativeMethodInfoPtr_SetOverflowParticles_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, 100685420);
			WateringCanVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, 100685421);
		}

		// Token: 0x0600B35D RID: 45917 RVA: 0x002CBE8C File Offset: 0x002CA08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308873, XrefRangeEnd = 308886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetFillLevel(float normalizedFillLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedFillLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WateringCanVisuals.NativeMethodInfoPtr_SetFillLevel_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B35E RID: 45918 RVA: 0x002CBED8 File Offset: 0x002CA0D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308888, RefRangeEnd = 308889, XrefRangeStart = 308886, XrefRangeEnd = 308888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOverflowParticles(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanVisuals.NativeMethodInfoPtr_SetOverflowParticles_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B35F RID: 45919 RVA: 0x002CBF18 File Offset: 0x002CA118
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WateringCanVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B360 RID: 45920 RVA: 0x00057DFA File Offset: 0x00055FFA
		public WateringCanVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003798 RID: 14232
		// (get) Token: 0x0600B361 RID: 45921 RVA: 0x002CBF54 File Offset: 0x002CA154
		// (set) Token: 0x0600B362 RID: 45922 RVA: 0x00057E03 File Offset: 0x00056003
		public unsafe ParticleSystem OverflowParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_OverflowParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_OverflowParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003799 RID: 14233
		// (get) Token: 0x0600B363 RID: 45923 RVA: 0x002CBF84 File Offset: 0x002CA184
		// (set) Token: 0x0600B364 RID: 45924 RVA: 0x00057E22 File Offset: 0x00056022
		public unsafe Transform WaterTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_WaterTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_WaterTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700379A RID: 14234
		// (get) Token: 0x0600B365 RID: 45925 RVA: 0x002CBFB4 File Offset: 0x002CA1B4
		// (set) Token: 0x0600B366 RID: 45926 RVA: 0x00057E41 File Offset: 0x00056041
		public unsafe float WaterMaxY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_WaterMaxY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_WaterMaxY)) = value;
			}
		}

		// Token: 0x1700379B RID: 14235
		// (get) Token: 0x0600B367 RID: 45927 RVA: 0x002CBFDC File Offset: 0x002CA1DC
		// (set) Token: 0x0600B368 RID: 45928 RVA: 0x00057E5C File Offset: 0x0005605C
		public unsafe float WaterMinY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_WaterMinY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_WaterMinY)) = value;
			}
		}

		// Token: 0x1700379C RID: 14236
		// (get) Token: 0x0600B369 RID: 45929 RVA: 0x002CC004 File Offset: 0x002CA204
		// (set) Token: 0x0600B36A RID: 45930 RVA: 0x00057E77 File Offset: 0x00056077
		public unsafe Transform SideWaterTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_SideWaterTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_SideWaterTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700379D RID: 14237
		// (get) Token: 0x0600B36B RID: 45931 RVA: 0x002CC034 File Offset: 0x002CA234
		// (set) Token: 0x0600B36C RID: 45932 RVA: 0x00057E96 File Offset: 0x00056096
		public unsafe float SideWaterMinScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_SideWaterMinScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_SideWaterMinScale)) = value;
			}
		}

		// Token: 0x1700379E RID: 14238
		// (get) Token: 0x0600B36D RID: 45933 RVA: 0x002CC05C File Offset: 0x002CA25C
		// (set) Token: 0x0600B36E RID: 45934 RVA: 0x00057EB1 File Offset: 0x000560B1
		public unsafe float SideWaterMaxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_SideWaterMaxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_SideWaterMaxScale)) = value;
			}
		}

		// Token: 0x1700379F RID: 14239
		// (get) Token: 0x0600B36F RID: 45935 RVA: 0x002CC084 File Offset: 0x002CA284
		// (set) Token: 0x0600B370 RID: 45936 RVA: 0x00057ECC File Offset: 0x000560CC
		public unsafe AudioSourceController FillSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_FillSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_FillSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007902 RID: 30978
		private static readonly IntPtr NativeFieldInfoPtr_OverflowParticles;

		// Token: 0x04007903 RID: 30979
		private static readonly IntPtr NativeFieldInfoPtr_WaterTransform;

		// Token: 0x04007904 RID: 30980
		private static readonly IntPtr NativeFieldInfoPtr_WaterMaxY;

		// Token: 0x04007905 RID: 30981
		private static readonly IntPtr NativeFieldInfoPtr_WaterMinY;

		// Token: 0x04007906 RID: 30982
		private static readonly IntPtr NativeFieldInfoPtr_SideWaterTransform;

		// Token: 0x04007907 RID: 30983
		private static readonly IntPtr NativeFieldInfoPtr_SideWaterMinScale;

		// Token: 0x04007908 RID: 30984
		private static readonly IntPtr NativeFieldInfoPtr_SideWaterMaxScale;

		// Token: 0x04007909 RID: 30985
		private static readonly IntPtr NativeFieldInfoPtr_FillSound;

		// Token: 0x0400790A RID: 30986
		private static readonly IntPtr NativeMethodInfoPtr_SetFillLevel_Public_Virtual_New_Void_Single_0;

		// Token: 0x0400790B RID: 30987
		private static readonly IntPtr NativeMethodInfoPtr_SetOverflowParticles_Public_Void_Boolean_0;

		// Token: 0x0400790C RID: 30988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
