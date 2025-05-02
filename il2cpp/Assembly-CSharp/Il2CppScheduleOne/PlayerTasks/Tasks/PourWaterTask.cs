using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x02000213 RID: 531
	public class PourWaterTask : PourOntoTargetTask
	{
		// Token: 0x06002C42 RID: 11330 RVA: 0x000FCBA4 File Offset: 0x000FADA4
		// Note: this type is marked as 'beforefieldinit'.
		static PourWaterTask()
		{
			Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks.Tasks", "PourWaterTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr);
			PourWaterTask.NativeFieldInfoPtr_NORMALIZED_FILL_PER_TARGET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, "NORMALIZED_FILL_PER_TARGET");
			PourWaterTask.NativeFieldInfoPtr_hintShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, "hintShown");
			PourWaterTask.NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, 100668274);
			PourWaterTask.NativeMethodInfoPtr_get_FailOnEmpty_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, 100668275);
			PourWaterTask.NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_get_ECameraPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, 100668276);
			PourWaterTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, 100668277);
			PourWaterTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, 100668278);
			PourWaterTask.NativeMethodInfoPtr_TargetReached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, 100668279);
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06002C43 RID: 11331 RVA: 0x000FCC74 File Offset: 0x000FAE74
		public unsafe override bool UseCoverage
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourWaterTask.NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06002C44 RID: 11332 RVA: 0x000FCCBC File Offset: 0x000FAEBC
		public unsafe override bool FailOnEmpty
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourWaterTask.NativeMethodInfoPtr_get_FailOnEmpty_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x000FCD04 File Offset: 0x000FAF04
		public unsafe override Pot.ECameraPosition CameraPosition
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 121083, RefRangeEnd = 121088, XrefRangeStart = 121083, XrefRangeEnd = 121088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourWaterTask.NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_get_ECameraPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x000FCD4C File Offset: 0x000FAF4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123682, RefRangeEnd = 123683, XrefRangeStart = 123651, XrefRangeEnd = 123682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourWaterTask(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_itemInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_pourablePrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourWaterTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x000FCDBC File Offset: 0x000FAFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123683, XrefRangeEnd = 123687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourWaterTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x000FCDF8 File Offset: 0x000FAFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123687, XrefRangeEnd = 123710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TargetReached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourWaterTask.NativeMethodInfoPtr_TargetReached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x00017EB6 File Offset: 0x000160B6
		public PourWaterTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06002C4A RID: 11338 RVA: 0x000FCE34 File Offset: 0x000FB034
		// (set) Token: 0x06002C4B RID: 11339 RVA: 0x00017EBF File Offset: 0x000160BF
		public unsafe static float NORMALIZED_FILL_PER_TARGET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PourWaterTask.NativeFieldInfoPtr_NORMALIZED_FILL_PER_TARGET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PourWaterTask.NativeFieldInfoPtr_NORMALIZED_FILL_PER_TARGET, (void*)(&value));
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06002C4C RID: 11340 RVA: 0x000FCE50 File Offset: 0x000FB050
		// (set) Token: 0x06002C4D RID: 11341 RVA: 0x00017ECD File Offset: 0x000160CD
		public unsafe static bool hintShown
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(PourWaterTask.NativeFieldInfoPtr_hintShown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PourWaterTask.NativeFieldInfoPtr_hintShown, (void*)(&value));
			}
		}

		// Token: 0x04001D5B RID: 7515
		private static readonly IntPtr NativeFieldInfoPtr_NORMALIZED_FILL_PER_TARGET;

		// Token: 0x04001D5C RID: 7516
		private static readonly IntPtr NativeFieldInfoPtr_hintShown;

		// Token: 0x04001D5D RID: 7517
		private static readonly IntPtr NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_get_Boolean_0;

		// Token: 0x04001D5E RID: 7518
		private static readonly IntPtr NativeMethodInfoPtr_get_FailOnEmpty_Protected_Virtual_get_Boolean_0;

		// Token: 0x04001D5F RID: 7519
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_get_ECameraPosition_0;

		// Token: 0x04001D60 RID: 7520
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0;

		// Token: 0x04001D61 RID: 7521
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001D62 RID: 7522
		private static readonly IntPtr NativeMethodInfoPtr_TargetReached_Public_Virtual_Void_0;
	}
}
