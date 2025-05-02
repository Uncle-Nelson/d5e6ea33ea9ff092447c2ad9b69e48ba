using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000460 RID: 1120
	public class OptimizedLight : MonoBehaviour
	{
		// Token: 0x06006143 RID: 24899 RVA: 0x001BBE38 File Offset: 0x001BA038
		// Note: this type is marked as 'beforefieldinit'.
		static OptimizedLight()
		{
			Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "OptimizedLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr);
			OptimizedLight.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "Enabled");
			OptimizedLight.NativeFieldInfoPtr_DisabledForOptimization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "DisabledForOptimization");
			OptimizedLight.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "MaxDistance");
			OptimizedLight.NativeFieldInfoPtr__Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "_Light");
			OptimizedLight.NativeFieldInfoPtr_culled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "culled");
			OptimizedLight.NativeFieldInfoPtr_maxDistanceSquared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "maxDistanceSquared");
			OptimizedLight.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675657);
			OptimizedLight.NativeMethodInfoPtr_Start_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675658);
			OptimizedLight.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675659);
			OptimizedLight.NativeMethodInfoPtr_FixedUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675660);
			OptimizedLight.NativeMethodInfoPtr_UpdateCull_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675661);
			OptimizedLight.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675662);
			OptimizedLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675663);
			OptimizedLight.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675664);
		}

		// Token: 0x06006144 RID: 24900 RVA: 0x001BBF80 File Offset: 0x001BA180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200617, XrefRangeEnd = 200621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptimizedLight.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x001BBFBC File Offset: 0x001BA1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200621, XrefRangeEnd = 200645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_Start_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006146 RID: 24902 RVA: 0x001BBFF0 File Offset: 0x001BA1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200645, XrefRangeEnd = 200659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x001BC024 File Offset: 0x001BA224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200659, XrefRangeEnd = 200665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptimizedLight.NativeMethodInfoPtr_FixedUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x001BC060 File Offset: 0x001BA260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200665, XrefRangeEnd = 200681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_UpdateCull_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x001BC094 File Offset: 0x001BA294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600614A RID: 24906 RVA: 0x001BC0D4 File Offset: 0x001BA2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200681, XrefRangeEnd = 200682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptimizedLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600614B RID: 24907 RVA: 0x001BC110 File Offset: 0x001BA310
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200723, RefRangeEnd = 200724, XrefRangeStart = 200682, XrefRangeEnd = 200723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600614C RID: 24908 RVA: 0x0002DFA5 File Offset: 0x0002C1A5
		public OptimizedLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x0600614D RID: 24909 RVA: 0x001BC144 File Offset: 0x001BA344
		// (set) Token: 0x0600614E RID: 24910 RVA: 0x0002DFAE File Offset: 0x0002C1AE
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x0600614F RID: 24911 RVA: 0x001BC16C File Offset: 0x001BA36C
		// (set) Token: 0x06006150 RID: 24912 RVA: 0x0002DFC9 File Offset: 0x0002C1C9
		public unsafe bool DisabledForOptimization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_DisabledForOptimization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_DisabledForOptimization)) = value;
			}
		}

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x06006151 RID: 24913 RVA: 0x001BC194 File Offset: 0x001BA394
		// (set) Token: 0x06006152 RID: 24914 RVA: 0x0002DFE4 File Offset: 0x0002C1E4
		public unsafe float MaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_MaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_MaxDistance)) = value;
			}
		}

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x06006153 RID: 24915 RVA: 0x001BC1BC File Offset: 0x001BA3BC
		// (set) Token: 0x06006154 RID: 24916 RVA: 0x0002DFFF File Offset: 0x0002C1FF
		public unsafe Light _Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr__Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr__Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x06006155 RID: 24917 RVA: 0x001BC1EC File Offset: 0x001BA3EC
		// (set) Token: 0x06006156 RID: 24918 RVA: 0x0002E01E File Offset: 0x0002C21E
		public unsafe bool culled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_culled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_culled)) = value;
			}
		}

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x06006157 RID: 24919 RVA: 0x001BC214 File Offset: 0x001BA414
		// (set) Token: 0x06006158 RID: 24920 RVA: 0x0002E039 File Offset: 0x0002C239
		public unsafe float maxDistanceSquared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_maxDistanceSquared);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_maxDistanceSquared)) = value;
			}
		}

		// Token: 0x0400425E RID: 16990
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x0400425F RID: 16991
		private static readonly IntPtr NativeFieldInfoPtr_DisabledForOptimization;

		// Token: 0x04004260 RID: 16992
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistance;

		// Token: 0x04004261 RID: 16993
		private static readonly IntPtr NativeFieldInfoPtr__Light;

		// Token: 0x04004262 RID: 16994
		private static readonly IntPtr NativeFieldInfoPtr_culled;

		// Token: 0x04004263 RID: 16995
		private static readonly IntPtr NativeFieldInfoPtr_maxDistanceSquared;

		// Token: 0x04004264 RID: 16996
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0;

		// Token: 0x04004265 RID: 16997
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_1;

		// Token: 0x04004266 RID: 16998
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x04004267 RID: 16999
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04004268 RID: 17000
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCull_Private_Void_1;

		// Token: 0x04004269 RID: 17001
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0;

		// Token: 0x0400426A RID: 17002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400426B RID: 17003
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
