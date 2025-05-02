using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A0 RID: 928
	public class ManagementUtilities : Singleton<ManagementUtilities>
	{
		// Token: 0x060048B3 RID: 18611 RVA: 0x001637EC File Offset: 0x001619EC
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementUtilities()
		{
			Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ManagementUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr);
			ManagementUtilities.NativeFieldInfoPtr_weedSeedAssetPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, "weedSeedAssetPaths");
			ManagementUtilities.NativeFieldInfoPtr_additiveAssetPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, "additiveAssetPaths");
			ManagementUtilities.NativeFieldInfoPtr_AdditiveDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, "AdditiveDefinitions");
			ManagementUtilities.NativeMethodInfoPtr_get_WeedSeedAssetPaths_Public_Static_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, 100672307);
			ManagementUtilities.NativeMethodInfoPtr_get_AdditiveAssetPaths_Public_Static_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, 100672308);
			ManagementUtilities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, 100672309);
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x060048B4 RID: 18612 RVA: 0x00163894 File Offset: 0x00161A94
		public unsafe static List<string> WeedSeedAssetPaths
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162683, XrefRangeEnd = 162687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementUtilities.NativeMethodInfoPtr_get_WeedSeedAssetPaths_Public_Static_get_List_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x060048B5 RID: 18613 RVA: 0x001638C8 File Offset: 0x00161AC8
		public unsafe static List<string> AdditiveAssetPaths
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162687, XrefRangeEnd = 162691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementUtilities.NativeMethodInfoPtr_get_AdditiveAssetPaths_Public_Static_get_List_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060048B6 RID: 18614 RVA: 0x001638FC File Offset: 0x00161AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162691, XrefRangeEnd = 162713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementUtilities() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementUtilities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x000230BF File Offset: 0x000212BF
		public ManagementUtilities(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x060048B8 RID: 18616 RVA: 0x00163938 File Offset: 0x00161B38
		// (set) Token: 0x060048B9 RID: 18617 RVA: 0x000230C8 File Offset: 0x000212C8
		public unsafe List<string> weedSeedAssetPaths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_weedSeedAssetPaths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_weedSeedAssetPaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x060048BA RID: 18618 RVA: 0x00163968 File Offset: 0x00161B68
		// (set) Token: 0x060048BB RID: 18619 RVA: 0x000230E7 File Offset: 0x000212E7
		public unsafe List<string> additiveAssetPaths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_additiveAssetPaths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_additiveAssetPaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x060048BC RID: 18620 RVA: 0x00163998 File Offset: 0x00161B98
		// (set) Token: 0x060048BD RID: 18621 RVA: 0x00023106 File Offset: 0x00021306
		public unsafe List<AdditiveDefinition> AdditiveDefinitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_AdditiveDefinitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AdditiveDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_AdditiveDefinitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400310D RID: 12557
		private static readonly IntPtr NativeFieldInfoPtr_weedSeedAssetPaths;

		// Token: 0x0400310E RID: 12558
		private static readonly IntPtr NativeFieldInfoPtr_additiveAssetPaths;

		// Token: 0x0400310F RID: 12559
		private static readonly IntPtr NativeFieldInfoPtr_AdditiveDefinitions;

		// Token: 0x04003110 RID: 12560
		private static readonly IntPtr NativeMethodInfoPtr_get_WeedSeedAssetPaths_Public_Static_get_List_1_String_0;

		// Token: 0x04003111 RID: 12561
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveAssetPaths_Public_Static_get_List_1_String_0;

		// Token: 0x04003112 RID: 12562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
