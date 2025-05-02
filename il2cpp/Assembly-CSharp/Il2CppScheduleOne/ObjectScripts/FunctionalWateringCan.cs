using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using Il2CppScheduleOne.PlayerTasks;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000753 RID: 1875
	public class FunctionalWateringCan : Pourable
	{
		// Token: 0x0600B23A RID: 45626 RVA: 0x002C7954 File Offset: 0x002C5B54
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalWateringCan()
		{
			Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "FunctionalWateringCan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr);
			FunctionalWateringCan.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr, "Visuals");
			FunctionalWateringCan.NativeFieldInfoPtr_itemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr, "itemInstance");
			FunctionalWateringCan.NativeMethodInfoPtr_Setup_Public_Void_WateringCanInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr, 100685260);
			FunctionalWateringCan.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr, 100685261);
			FunctionalWateringCan.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr, 100685262);
		}

		// Token: 0x0600B23B RID: 45627 RVA: 0x002C79E8 File Offset: 0x002C5BE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 307496, RefRangeEnd = 307497, XrefRangeStart = 307493, XrefRangeEnd = 307496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(WateringCanInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalWateringCan.NativeMethodInfoPtr_Setup_Public_Void_WateringCanInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B23C RID: 45628 RVA: 0x002C7A2C File Offset: 0x002C5C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307497, XrefRangeEnd = 307500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalWateringCan.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B23D RID: 45629 RVA: 0x002C7A78 File Offset: 0x002C5C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalWateringCan() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalWateringCan.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B23E RID: 45630 RVA: 0x000576C3 File Offset: 0x000558C3
		public FunctionalWateringCan(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700374E RID: 14158
		// (get) Token: 0x0600B23F RID: 45631 RVA: 0x002C7AB4 File Offset: 0x002C5CB4
		// (set) Token: 0x0600B240 RID: 45632 RVA: 0x000576CC File Offset: 0x000558CC
		public unsafe WateringCanVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalWateringCan.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalWateringCan.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700374F RID: 14159
		// (get) Token: 0x0600B241 RID: 45633 RVA: 0x002C7AE4 File Offset: 0x002C5CE4
		// (set) Token: 0x0600B242 RID: 45634 RVA: 0x000576EB File Offset: 0x000558EB
		public unsafe WateringCanInstance itemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalWateringCan.NativeFieldInfoPtr_itemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalWateringCan.NativeFieldInfoPtr_itemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007833 RID: 30771
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04007834 RID: 30772
		private static readonly IntPtr NativeFieldInfoPtr_itemInstance;

		// Token: 0x04007835 RID: 30773
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_WateringCanInstance_0;

		// Token: 0x04007836 RID: 30774
		private static readonly IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0;

		// Token: 0x04007837 RID: 30775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
