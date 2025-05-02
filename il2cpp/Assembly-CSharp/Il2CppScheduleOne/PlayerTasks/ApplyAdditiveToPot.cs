using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerTasks.Tasks;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000203 RID: 515
	public class ApplyAdditiveToPot : PourIntoPotTask
	{
		// Token: 0x06002ADC RID: 10972 RVA: 0x000F82FC File Offset: 0x000F64FC
		// Note: this type is marked as 'beforefieldinit'.
		static ApplyAdditiveToPot()
		{
			Il2CppClassPointerStore<ApplyAdditiveToPot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "ApplyAdditiveToPot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyAdditiveToPot>.NativeClassPtr);
			ApplyAdditiveToPot.NativeFieldInfoPtr_def = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyAdditiveToPot>.NativeClassPtr, "def");
			ApplyAdditiveToPot.NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToPot>.NativeClassPtr, 100668098);
			ApplyAdditiveToPot.NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_get_ECameraPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToPot>.NativeClassPtr, 100668099);
			ApplyAdditiveToPot.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToPot>.NativeClassPtr, 100668100);
			ApplyAdditiveToPot.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToPot>.NativeClassPtr, 100668101);
			ApplyAdditiveToPot.NativeMethodInfoPtr_FullyCovered_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToPot>.NativeClassPtr, 100668102);
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06002ADD RID: 10973 RVA: 0x000F83A4 File Offset: 0x000F65A4
		public unsafe override bool UseCoverage
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToPot.NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06002ADE RID: 10974 RVA: 0x000F83EC File Offset: 0x000F65EC
		public unsafe override Pot.ECameraPosition CameraPosition
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 121083, RefRangeEnd = 121088, XrefRangeStart = 121083, XrefRangeEnd = 121083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToPot.NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_get_ECameraPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x000F8434 File Offset: 0x000F6634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121106, RefRangeEnd = 121107, XrefRangeStart = 121088, XrefRangeEnd = 121106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApplyAdditiveToPot(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplyAdditiveToPot>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_itemInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_pourablePrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplyAdditiveToPot.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x000F84A4 File Offset: 0x000F66A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121107, XrefRangeEnd = 121130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToPot.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x000F84E0 File Offset: 0x000F66E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121130, XrefRangeEnd = 121135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FullyCovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToPot.NativeMethodInfoPtr_FullyCovered_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x000173EE File Offset: 0x000155EE
		public ApplyAdditiveToPot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06002AE3 RID: 10979 RVA: 0x000F851C File Offset: 0x000F671C
		// (set) Token: 0x06002AE4 RID: 10980 RVA: 0x000173F7 File Offset: 0x000155F7
		public unsafe AdditiveDefinition def
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyAdditiveToPot.NativeFieldInfoPtr_def);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdditiveDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyAdditiveToPot.NativeFieldInfoPtr_def), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C6F RID: 7279
		private static readonly IntPtr NativeFieldInfoPtr_def;

		// Token: 0x04001C70 RID: 7280
		private static readonly IntPtr NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_get_Boolean_0;

		// Token: 0x04001C71 RID: 7281
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_get_ECameraPosition_0;

		// Token: 0x04001C72 RID: 7282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0;

		// Token: 0x04001C73 RID: 7283
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001C74 RID: 7284
		private static readonly IntPtr NativeMethodInfoPtr_FullyCovered_Protected_Virtual_Void_0;
	}
}
