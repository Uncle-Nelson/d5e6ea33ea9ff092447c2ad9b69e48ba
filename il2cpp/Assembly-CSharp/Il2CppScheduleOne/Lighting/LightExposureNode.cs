using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003B6 RID: 950
	public class LightExposureNode : MonoBehaviour
	{
		// Token: 0x06004A06 RID: 18950 RVA: 0x00167D40 File Offset: 0x00165F40
		// Note: this type is marked as 'beforefieldinit'.
		static LightExposureNode()
		{
			Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "LightExposureNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr);
			LightExposureNode.NativeFieldInfoPtr_ambientExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, "ambientExposure");
			LightExposureNode.NativeFieldInfoPtr_sources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, "sources");
			LightExposureNode.NativeMethodInfoPtr_GetTotalExposure_Public_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100672476);
			LightExposureNode.NativeMethodInfoPtr_AddSource_Public_Void_UsableLightSource_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100672477);
			LightExposureNode.NativeMethodInfoPtr_RemoveSource_Public_Void_UsableLightSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100672478);
			LightExposureNode.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100672479);
			LightExposureNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100672480);
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x00167DFC File Offset: 0x00165FFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163812, RefRangeEnd = 163814, XrefRangeStart = 163788, XrefRangeEnd = 163812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalExposure(out float growSpeedMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &growSpeedMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr_GetTotalExposure_Public_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x00167E48 File Offset: 0x00166048
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163824, RefRangeEnd = 163825, XrefRangeStart = 163814, XrefRangeEnd = 163824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSource(UsableLightSource source, float lightAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr_AddSource_Public_Void_UsableLightSource_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x00167E98 File Offset: 0x00166098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163829, RefRangeEnd = 163830, XrefRangeStart = 163825, XrefRangeEnd = 163829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSource(UsableLightSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr_RemoveSource_Public_Void_UsableLightSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x00167EDC File Offset: 0x001660DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163830, XrefRangeEnd = 163835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A0B RID: 18955 RVA: 0x00167F10 File Offset: 0x00166110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163835, XrefRangeEnd = 163843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightExposureNode() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A0C RID: 18956 RVA: 0x00023AE1 File Offset: 0x00021CE1
		public LightExposureNode(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x06004A0D RID: 18957 RVA: 0x00167F4C File Offset: 0x0016614C
		// (set) Token: 0x06004A0E RID: 18958 RVA: 0x00023AEA File Offset: 0x00021CEA
		public unsafe float ambientExposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightExposureNode.NativeFieldInfoPtr_ambientExposure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightExposureNode.NativeFieldInfoPtr_ambientExposure)) = value;
			}
		}

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x06004A0F RID: 18959 RVA: 0x00167F74 File Offset: 0x00166174
		// (set) Token: 0x06004A10 RID: 18960 RVA: 0x00023B05 File Offset: 0x00021D05
		public unsafe Dictionary<UsableLightSource, float> sources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightExposureNode.NativeFieldInfoPtr_sources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<UsableLightSource, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightExposureNode.NativeFieldInfoPtr_sources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031E5 RID: 12773
		private static readonly IntPtr NativeFieldInfoPtr_ambientExposure;

		// Token: 0x040031E6 RID: 12774
		private static readonly IntPtr NativeFieldInfoPtr_sources;

		// Token: 0x040031E7 RID: 12775
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalExposure_Public_Single_byref_Single_0;

		// Token: 0x040031E8 RID: 12776
		private static readonly IntPtr NativeMethodInfoPtr_AddSource_Public_Void_UsableLightSource_Single_0;

		// Token: 0x040031E9 RID: 12777
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSource_Public_Void_UsableLightSource_0;

		// Token: 0x040031EA RID: 12778
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x040031EB RID: 12779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
