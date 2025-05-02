using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000744 RID: 1860
	[Serializable]
	public class DryingOperation : Object
	{
		// Token: 0x0600ACAF RID: 44207 RVA: 0x002B1638 File Offset: 0x002AF838
		// Note: this type is marked as 'beforefieldinit'.
		static DryingOperation()
		{
			Il2CppClassPointerStore<DryingOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "DryingOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr);
			DryingOperation.NativeFieldInfoPtr_ItemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, "ItemID");
			DryingOperation.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, "Quantity");
			DryingOperation.NativeFieldInfoPtr_StartQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, "StartQuality");
			DryingOperation.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, "Time");
			DryingOperation.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100684484);
			DryingOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100684485);
			DryingOperation.NativeMethodInfoPtr_IncreaseQuality_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100684486);
			DryingOperation.NativeMethodInfoPtr_GetQualityItemInstance_Public_QualityItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100684487);
			DryingOperation.NativeMethodInfoPtr_GetQuality_Public_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100684488);
		}

		// Token: 0x0600ACB0 RID: 44208 RVA: 0x002B171C File Offset: 0x002AF91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299168, XrefRangeEnd = 299170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingOperation(string itemID, int quantity, EQuality startQuality, int time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startQuality;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EQuality_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACB1 RID: 44209 RVA: 0x002B1794 File Offset: 0x002AF994
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACB2 RID: 44210 RVA: 0x002B17D0 File Offset: 0x002AF9D0
		[CallerCount(0)]
		public unsafe void IncreaseQuality()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr_IncreaseQuality_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACB3 RID: 44211 RVA: 0x002B1804 File Offset: 0x002AFA04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299174, RefRangeEnd = 299175, XrefRangeStart = 299170, XrefRangeEnd = 299174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemInstance GetQualityItemInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr_GetQualityItemInstance_Public_QualityItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QualityItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600ACB4 RID: 44212 RVA: 0x002B1844 File Offset: 0x002AFA44
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 299175, RefRangeEnd = 299180, XrefRangeStart = 299175, XrefRangeEnd = 299175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EQuality GetQuality()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr_GetQuality_Public_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ACB5 RID: 44213 RVA: 0x00054F70 File Offset: 0x00053170
		public DryingOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003579 RID: 13689
		// (get) Token: 0x0600ACB6 RID: 44214 RVA: 0x002B1880 File Offset: 0x002AFA80
		// (set) Token: 0x0600ACB7 RID: 44215 RVA: 0x00054F79 File Offset: 0x00053179
		public unsafe string ItemID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_ItemID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_ItemID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700357A RID: 13690
		// (get) Token: 0x0600ACB8 RID: 44216 RVA: 0x002B18A8 File Offset: 0x002AFAA8
		// (set) Token: 0x0600ACB9 RID: 44217 RVA: 0x00054F98 File Offset: 0x00053198
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x1700357B RID: 13691
		// (get) Token: 0x0600ACBA RID: 44218 RVA: 0x002B18D0 File Offset: 0x002AFAD0
		// (set) Token: 0x0600ACBB RID: 44219 RVA: 0x00054FB3 File Offset: 0x000531B3
		public unsafe EQuality StartQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_StartQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_StartQuality)) = value;
			}
		}

		// Token: 0x1700357C RID: 13692
		// (get) Token: 0x0600ACBC RID: 44220 RVA: 0x002B18F8 File Offset: 0x002AFAF8
		// (set) Token: 0x0600ACBD RID: 44221 RVA: 0x00054FCE File Offset: 0x000531CE
		public unsafe int Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_Time)) = value;
			}
		}

		// Token: 0x04007415 RID: 29717
		private static readonly IntPtr NativeFieldInfoPtr_ItemID;

		// Token: 0x04007416 RID: 29718
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x04007417 RID: 29719
		private static readonly IntPtr NativeFieldInfoPtr_StartQuality;

		// Token: 0x04007418 RID: 29720
		private static readonly IntPtr NativeFieldInfoPtr_Time;

		// Token: 0x04007419 RID: 29721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EQuality_Int32_0;

		// Token: 0x0400741A RID: 29722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400741B RID: 29723
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseQuality_Public_Void_0;

		// Token: 0x0400741C RID: 29724
		private static readonly IntPtr NativeMethodInfoPtr_GetQualityItemInstance_Public_QualityItemInstance_0;

		// Token: 0x0400741D RID: 29725
		private static readonly IntPtr NativeMethodInfoPtr_GetQuality_Public_EQuality_0;
	}
}
