using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D7 RID: 983
	[Serializable]
	public class LawActivitySettings : Object
	{
		// Token: 0x06004BDE RID: 19422 RVA: 0x0016DF44 File Offset: 0x0016C144
		// Note: this type is marked as 'beforefieldinit'.
		static LawActivitySettings()
		{
			Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "LawActivitySettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr);
			LawActivitySettings.NativeFieldInfoPtr_Patrols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "Patrols");
			LawActivitySettings.NativeFieldInfoPtr_Checkpoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "Checkpoints");
			LawActivitySettings.NativeFieldInfoPtr_Curfews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "Curfews");
			LawActivitySettings.NativeFieldInfoPtr_VehiclePatrols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "VehiclePatrols");
			LawActivitySettings.NativeFieldInfoPtr_Sentries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "Sentries");
			LawActivitySettings.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, 100672685);
			LawActivitySettings.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, 100672686);
			LawActivitySettings.NativeMethodInfoPtr_OnLoaded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, 100672687);
			LawActivitySettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, 100672688);
		}

		// Token: 0x06004BDF RID: 19423 RVA: 0x0016E028 File Offset: 0x0016C228
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165233, RefRangeEnd = 165234, XrefRangeStart = 165201, XrefRangeEnd = 165233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawActivitySettings.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BE0 RID: 19424 RVA: 0x0016E05C File Offset: 0x0016C25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165234, XrefRangeEnd = 165235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawActivitySettings.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BE1 RID: 19425 RVA: 0x0016E090 File Offset: 0x0016C290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165235, XrefRangeEnd = 165250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawActivitySettings.NativeMethodInfoPtr_OnLoaded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BE2 RID: 19426 RVA: 0x0016E0C4 File Offset: 0x0016C2C4
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawActivitySettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawActivitySettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BE3 RID: 19427 RVA: 0x000247C1 File Offset: 0x000229C1
		public LawActivitySettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x06004BE4 RID: 19428 RVA: 0x0016E100 File Offset: 0x0016C300
		// (set) Token: 0x06004BE5 RID: 19429 RVA: 0x000247CA File Offset: 0x000229CA
		public unsafe Il2CppReferenceArray<PatrolInstance> Patrols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Patrols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PatrolInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Patrols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x06004BE6 RID: 19430 RVA: 0x0016E130 File Offset: 0x0016C330
		// (set) Token: 0x06004BE7 RID: 19431 RVA: 0x000247E9 File Offset: 0x000229E9
		public unsafe Il2CppReferenceArray<CheckpointInstance> Checkpoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Checkpoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CheckpointInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Checkpoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x06004BE8 RID: 19432 RVA: 0x0016E160 File Offset: 0x0016C360
		// (set) Token: 0x06004BE9 RID: 19433 RVA: 0x00024808 File Offset: 0x00022A08
		public unsafe Il2CppReferenceArray<CurfewInstance> Curfews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Curfews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CurfewInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Curfews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x06004BEA RID: 19434 RVA: 0x0016E190 File Offset: 0x0016C390
		// (set) Token: 0x06004BEB RID: 19435 RVA: 0x00024827 File Offset: 0x00022A27
		public unsafe Il2CppReferenceArray<VehiclePatrolInstance> VehiclePatrols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_VehiclePatrols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VehiclePatrolInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_VehiclePatrols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x06004BEC RID: 19436 RVA: 0x0016E1C0 File Offset: 0x0016C3C0
		// (set) Token: 0x06004BED RID: 19437 RVA: 0x00024846 File Offset: 0x00022A46
		public unsafe Il2CppReferenceArray<SentryInstance> Sentries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Sentries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SentryInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Sentries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003322 RID: 13090
		private static readonly IntPtr NativeFieldInfoPtr_Patrols;

		// Token: 0x04003323 RID: 13091
		private static readonly IntPtr NativeFieldInfoPtr_Checkpoints;

		// Token: 0x04003324 RID: 13092
		private static readonly IntPtr NativeFieldInfoPtr_Curfews;

		// Token: 0x04003325 RID: 13093
		private static readonly IntPtr NativeFieldInfoPtr_VehiclePatrols;

		// Token: 0x04003326 RID: 13094
		private static readonly IntPtr NativeFieldInfoPtr_Sentries;

		// Token: 0x04003327 RID: 13095
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x04003328 RID: 13096
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x04003329 RID: 13097
		private static readonly IntPtr NativeMethodInfoPtr_OnLoaded_Public_Void_0;

		// Token: 0x0400332A RID: 13098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
