using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppRadiantGI.Universal
{
	// Token: 0x020000C5 RID: 197
	public class ToggleEffect : MonoBehaviour
	{
		// Token: 0x06000EBD RID: 3773 RVA: 0x0009F5DC File Offset: 0x0009D7DC
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleEffect()
		{
			Il2CppClassPointerStore<ToggleEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RadiantGI.Universal", "ToggleEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleEffect>.NativeClassPtr);
			ToggleEffect.NativeFieldInfoPtr_profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleEffect>.NativeClassPtr, "profile");
			ToggleEffect.NativeFieldInfoPtr_radiant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleEffect>.NativeClassPtr, "radiant");
			ToggleEffect.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleEffect>.NativeClassPtr, 100665052);
			ToggleEffect.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleEffect>.NativeClassPtr, 100665053);
			ToggleEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleEffect>.NativeClassPtr, 100665054);
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x0009F670 File Offset: 0x0009D870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85922, XrefRangeEnd = 85926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleEffect.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x0009F6A4 File Offset: 0x0009D8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85926, XrefRangeEnd = 85927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleEffect.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x0009F6D8 File Offset: 0x0009D8D8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleEffect() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x000093CF File Offset: 0x000075CF
		public ToggleEffect(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x0009F714 File Offset: 0x0009D914
		// (set) Token: 0x06000EC3 RID: 3779 RVA: 0x000093D8 File Offset: 0x000075D8
		public unsafe VolumeProfile profile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleEffect.NativeFieldInfoPtr_profile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleEffect.NativeFieldInfoPtr_profile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x0009F744 File Offset: 0x0009D944
		// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x000093F7 File Offset: 0x000075F7
		public unsafe RadiantGlobalIllumination radiant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleEffect.NativeFieldInfoPtr_radiant);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RadiantGlobalIllumination>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleEffect.NativeFieldInfoPtr_radiant), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeFieldInfoPtr_profile;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeFieldInfoPtr_radiant;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
