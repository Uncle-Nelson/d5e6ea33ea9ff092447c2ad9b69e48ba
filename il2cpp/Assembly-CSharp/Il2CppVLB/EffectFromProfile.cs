using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000081 RID: 129
	public class EffectFromProfile : MonoBehaviour
	{
		// Token: 0x06000975 RID: 2421 RVA: 0x0008D848 File Offset: 0x0008BA48
		// Note: this type is marked as 'beforefieldinit'.
		static EffectFromProfile()
		{
			Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "EffectFromProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr);
			EffectFromProfile.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, "ClassName");
			EffectFromProfile.NativeFieldInfoPtr_m_EffectProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, "m_EffectProfile");
			EffectFromProfile.NativeFieldInfoPtr_m_EffectInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, "m_EffectInstance");
			EffectFromProfile.NativeMethodInfoPtr_get_effectProfile_Public_get_EffectAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, 100664316);
			EffectFromProfile.NativeMethodInfoPtr_set_effectProfile_Public_set_Void_EffectAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, 100664317);
			EffectFromProfile.NativeMethodInfoPtr_InitInstanceFromProfile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, 100664318);
			EffectFromProfile.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, 100664319);
			EffectFromProfile.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, 100664320);
			EffectFromProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, 100664321);
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x0008D92C File Offset: 0x0008BB2C
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x0008D96C File Offset: 0x0008BB6C
		public unsafe EffectAbstractBase effectProfile
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFromProfile.NativeMethodInfoPtr_get_effectProfile_Public_get_EffectAbstractBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EffectAbstractBase>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80207, XrefRangeEnd = 80209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFromProfile.NativeMethodInfoPtr_set_effectProfile_Public_set_Void_EffectAbstractBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0008D9B0 File Offset: 0x0008BBB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80217, RefRangeEnd = 80219, XrefRangeStart = 80209, XrefRangeEnd = 80217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitInstanceFromProfile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFromProfile.NativeMethodInfoPtr_InitInstanceFromProfile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0008D9E4 File Offset: 0x0008BBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80219, XrefRangeEnd = 80237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFromProfile.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0008DA18 File Offset: 0x0008BC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80237, XrefRangeEnd = 80242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFromProfile.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0008DA4C File Offset: 0x0008BC4C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EffectFromProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFromProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00007227 File Offset: 0x00005427
		public EffectFromProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x0008DA88 File Offset: 0x0008BC88
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x00007230 File Offset: 0x00005430
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EffectFromProfile.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EffectFromProfile.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x0008DAA8 File Offset: 0x0008BCA8
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x00007242 File Offset: 0x00005442
		public unsafe EffectAbstractBase m_EffectProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFromProfile.NativeFieldInfoPtr_m_EffectProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectAbstractBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFromProfile.NativeFieldInfoPtr_m_EffectProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x0008DAD8 File Offset: 0x0008BCD8
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x00007261 File Offset: 0x00005461
		public unsafe EffectAbstractBase m_EffectInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFromProfile.NativeFieldInfoPtr_m_EffectInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectAbstractBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFromProfile.NativeFieldInfoPtr_m_EffectInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectProfile;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectInstance;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_get_effectProfile_Public_get_EffectAbstractBase_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_set_effectProfile_Public_set_Void_EffectAbstractBase_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr_InitInstanceFromProfile_Public_Void_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
