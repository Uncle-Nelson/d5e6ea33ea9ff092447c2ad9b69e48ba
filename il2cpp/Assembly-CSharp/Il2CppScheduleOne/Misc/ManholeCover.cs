using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x02000769 RID: 1897
	public class ManholeCover : MonoBehaviour
	{
		// Token: 0x0600B418 RID: 46104 RVA: 0x002CDEC0 File Offset: 0x002CC0C0
		// Note: this type is marked as 'beforefieldinit'.
		static ManholeCover()
		{
			Il2CppClassPointerStore<ManholeCover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "ManholeCover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr);
			ManholeCover.NativeFieldInfoPtr_SteamParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr, "SteamParticles");
			ManholeCover.NativeFieldInfoPtr_SteamColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr, "SteamColor");
			ManholeCover.NativeFieldInfoPtr_SteamAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr, "SteamAlpha");
			ManholeCover.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr, 100685480);
			ManholeCover.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr, 100685481);
			ManholeCover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr, 100685482);
		}

		// Token: 0x0600B419 RID: 46105 RVA: 0x002CDF68 File Offset: 0x002CC168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309256, XrefRangeEnd = 309274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManholeCover.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B41A RID: 46106 RVA: 0x002CDF9C File Offset: 0x002CC19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309274, XrefRangeEnd = 309284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManholeCover.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B41B RID: 46107 RVA: 0x002CDFD0 File Offset: 0x002CC1D0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManholeCover() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManholeCover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B41C RID: 46108 RVA: 0x000584A2 File Offset: 0x000566A2
		public ManholeCover(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037D4 RID: 14292
		// (get) Token: 0x0600B41D RID: 46109 RVA: 0x002CE00C File Offset: 0x002CC20C
		// (set) Token: 0x0600B41E RID: 46110 RVA: 0x000584AB File Offset: 0x000566AB
		public unsafe ParticleSystem SteamParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCover.NativeFieldInfoPtr_SteamParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCover.NativeFieldInfoPtr_SteamParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037D5 RID: 14293
		// (get) Token: 0x0600B41F RID: 46111 RVA: 0x002CE03C File Offset: 0x002CC23C
		// (set) Token: 0x0600B420 RID: 46112 RVA: 0x000584CA File Offset: 0x000566CA
		public unsafe Gradient SteamColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCover.NativeFieldInfoPtr_SteamColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCover.NativeFieldInfoPtr_SteamColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037D6 RID: 14294
		// (get) Token: 0x0600B421 RID: 46113 RVA: 0x002CE06C File Offset: 0x002CC26C
		// (set) Token: 0x0600B422 RID: 46114 RVA: 0x000584E9 File Offset: 0x000566E9
		public unsafe AnimationCurve SteamAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCover.NativeFieldInfoPtr_SteamAlpha);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCover.NativeFieldInfoPtr_SteamAlpha), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400796F RID: 31087
		private static readonly IntPtr NativeFieldInfoPtr_SteamParticles;

		// Token: 0x04007970 RID: 31088
		private static readonly IntPtr NativeFieldInfoPtr_SteamColor;

		// Token: 0x04007971 RID: 31089
		private static readonly IntPtr NativeFieldInfoPtr_SteamAlpha;

		// Token: 0x04007972 RID: 31090
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007973 RID: 31091
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04007974 RID: 31092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
