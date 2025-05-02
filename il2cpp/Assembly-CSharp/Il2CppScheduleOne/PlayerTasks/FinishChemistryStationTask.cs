using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000207 RID: 519
	public class FinishChemistryStationTask : Task
	{
		// Token: 0x06002B2D RID: 11053 RVA: 0x00017629 File Offset: 0x00015829
		// Note: this type is marked as 'beforefieldinit'.
		static FinishChemistryStationTask()
		{
			Il2CppClassPointerStore<FinishChemistryStationTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "FinishChemistryStationTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinishChemistryStationTask>.NativeClassPtr);
			FinishChemistryStationTask.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishChemistryStationTask>.NativeClassPtr, 100668145);
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x000F93E8 File Offset: 0x000F75E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121636, XrefRangeEnd = 121637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FinishChemistryStationTask() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinishChemistryStationTask>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishChemistryStationTask.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x00017662 File Offset: 0x00015862
		public FinishChemistryStationTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001CA5 RID: 7333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
