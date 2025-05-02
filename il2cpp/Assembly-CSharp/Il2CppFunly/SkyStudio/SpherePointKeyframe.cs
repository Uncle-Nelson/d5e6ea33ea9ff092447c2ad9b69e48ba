using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000103 RID: 259
	[Serializable]
	public class SpherePointKeyframe : BaseKeyframe
	{
		// Token: 0x0600135D RID: 4957 RVA: 0x000AE6EC File Offset: 0x000AC8EC
		// Note: this type is marked as 'beforefieldinit'.
		static SpherePointKeyframe()
		{
			Il2CppClassPointerStore<SpherePointKeyframe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SpherePointKeyframe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpherePointKeyframe>.NativeClassPtr);
			SpherePointKeyframe.NativeFieldInfoPtr_spherePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePointKeyframe>.NativeClassPtr, "spherePoint");
			SpherePointKeyframe.NativeMethodInfoPtr__ctor_Public_Void_SpherePoint_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePointKeyframe>.NativeClassPtr, 100665528);
			SpherePointKeyframe.NativeMethodInfoPtr__ctor_Public_Void_SpherePointKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePointKeyframe>.NativeClassPtr, 100665529);
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x000AE758 File Offset: 0x000AC958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90297, XrefRangeEnd = 90312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePointKeyframe(SpherePoint spherePoint, float time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpherePointKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spherePoint);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePointKeyframe.NativeMethodInfoPtr__ctor_Public_Void_SpherePoint_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x000AE7B4 File Offset: 0x000AC9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90312, XrefRangeEnd = 90321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePointKeyframe(SpherePointKeyframe keyframe) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpherePointKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyframe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePointKeyframe.NativeMethodInfoPtr__ctor_Public_Void_SpherePointKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x0000B7AA File Offset: 0x000099AA
		public SpherePointKeyframe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x000AE800 File Offset: 0x000ACA00
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x0000B7B3 File Offset: 0x000099B3
		public unsafe SpherePoint spherePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpherePointKeyframe.NativeFieldInfoPtr_spherePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpherePoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpherePointKeyframe.NativeFieldInfoPtr_spherePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeFieldInfoPtr_spherePoint;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SpherePoint_Single_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SpherePointKeyframe_0;
	}
}
