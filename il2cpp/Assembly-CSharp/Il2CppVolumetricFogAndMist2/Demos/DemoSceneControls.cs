using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppVolumetricFogAndMist2.Demos
{
	// Token: 0x020000C0 RID: 192
	public class DemoSceneControls : MonoBehaviour
	{
		// Token: 0x06000E44 RID: 3652 RVA: 0x0009E49C File Offset: 0x0009C69C
		// Note: this type is marked as 'beforefieldinit'.
		static DemoSceneControls()
		{
			Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VolumetricFogAndMist2.Demos", "DemoSceneControls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr);
			DemoSceneControls.NativeFieldInfoPtr_profiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr, "profiles");
			DemoSceneControls.NativeFieldInfoPtr_fogVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr, "fogVolume");
			DemoSceneControls.NativeFieldInfoPtr_presetNameDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr, "presetNameDisplay");
			DemoSceneControls.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr, "index");
			DemoSceneControls.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr, 100665035);
			DemoSceneControls.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr, 100665036);
			DemoSceneControls.NativeMethodInfoPtr_SetProfile_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr, 100665037);
			DemoSceneControls.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr, 100665038);
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0009E56C File Offset: 0x0009C76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85714, XrefRangeEnd = 85715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoSceneControls.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0009E5A0 File Offset: 0x0009C7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85715, XrefRangeEnd = 85722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoSceneControls.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0009E5D4 File Offset: 0x0009C7D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 85738, RefRangeEnd = 85740, XrefRangeStart = 85722, XrefRangeEnd = 85738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProfile(int profileIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref profileIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoSceneControls.NativeMethodInfoPtr_SetProfile_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0009E614 File Offset: 0x0009C814
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DemoSceneControls() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoSceneControls.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00008E85 File Offset: 0x00007085
		public DemoSceneControls(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x0009E650 File Offset: 0x0009C850
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x00008E8E File Offset: 0x0000708E
		public unsafe Il2CppReferenceArray<VolumetricFogProfile> profiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoSceneControls.NativeFieldInfoPtr_profiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VolumetricFogProfile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoSceneControls.NativeFieldInfoPtr_profiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x0009E680 File Offset: 0x0009C880
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x00008EAD File Offset: 0x000070AD
		public unsafe VolumetricFog fogVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoSceneControls.NativeFieldInfoPtr_fogVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricFog>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoSceneControls.NativeFieldInfoPtr_fogVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x0009E6B0 File Offset: 0x0009C8B0
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x00008ECC File Offset: 0x000070CC
		public unsafe Text presetNameDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoSceneControls.NativeFieldInfoPtr_presetNameDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoSceneControls.NativeFieldInfoPtr_presetNameDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x0009E6E0 File Offset: 0x0009C8E0
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x00008EEB File Offset: 0x000070EB
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoSceneControls.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoSceneControls.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeFieldInfoPtr_profiles;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeFieldInfoPtr_fogVolume;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeFieldInfoPtr_presetNameDisplay;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr_SetProfile_Private_Void_Int32_0;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
