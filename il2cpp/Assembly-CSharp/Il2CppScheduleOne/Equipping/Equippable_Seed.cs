using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005B9 RID: 1465
	public class Equippable_Seed : Equippable_Viewmodel
	{
		// Token: 0x0600809C RID: 32924 RVA: 0x00225EB8 File Offset: 0x002240B8
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Seed()
		{
			Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Seed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr);
			Equippable_Seed.NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr, "Seed");
			Equippable_Seed.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr, 100679435);
			Equippable_Seed.NativeMethodInfoPtr_StartSowSeedTask_Protected_Virtual_New_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr, 100679436);
			Equippable_Seed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr, 100679437);
		}

		// Token: 0x0600809D RID: 32925 RVA: 0x00225F38 File Offset: 0x00224138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244712, XrefRangeEnd = 244758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Seed.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600809E RID: 32926 RVA: 0x00225F74 File Offset: 0x00224174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244758, XrefRangeEnd = 244762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartSowSeedTask(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Seed.NativeMethodInfoPtr_StartSowSeedTask_Protected_Virtual_New_Void_Pot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600809F RID: 32927 RVA: 0x00225FC4 File Offset: 0x002241C4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 244704, RefRangeEnd = 244712, XrefRangeStart = 244704, XrefRangeEnd = 244712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Seed() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Seed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080A0 RID: 32928 RVA: 0x0003D05B File Offset: 0x0003B25B
		public Equippable_Seed(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026DA RID: 9946
		// (get) Token: 0x060080A1 RID: 32929 RVA: 0x00226000 File Offset: 0x00224200
		// (set) Token: 0x060080A2 RID: 32930 RVA: 0x0003D064 File Offset: 0x0003B264
		public unsafe SeedDefinition Seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Seed.NativeFieldInfoPtr_Seed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SeedDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Seed.NativeFieldInfoPtr_Seed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005799 RID: 22425
		private static readonly IntPtr NativeFieldInfoPtr_Seed;

		// Token: 0x0400579A RID: 22426
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400579B RID: 22427
		private static readonly IntPtr NativeMethodInfoPtr_StartSowSeedTask_Protected_Virtual_New_Void_Pot_0;

		// Token: 0x0400579C RID: 22428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
