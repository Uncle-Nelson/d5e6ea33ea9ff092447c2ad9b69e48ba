using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000558 RID: 1368
	public class Additive : MonoBehaviour
	{
		// Token: 0x06007860 RID: 30816 RVA: 0x00208BF4 File Offset: 0x00206DF4
		// Note: this type is marked as 'beforefieldinit'.
		static Additive()
		{
			Il2CppClassPointerStore<Additive>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "Additive");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Additive>.NativeClassPtr);
			Additive.NativeFieldInfoPtr_AdditiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "AdditiveName");
			Additive.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "AssetPath");
			Additive.NativeFieldInfoPtr_QualityChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "QualityChange");
			Additive.NativeFieldInfoPtr_YieldChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "YieldChange");
			Additive.NativeFieldInfoPtr_GrowSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "GrowSpeedMultiplier");
			Additive.NativeFieldInfoPtr_InstantGrowth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "InstantGrowth");
			Additive.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Additive>.NativeClassPtr, 100678414);
		}

		// Token: 0x06007861 RID: 30817 RVA: 0x00208CB0 File Offset: 0x00206EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232569, XrefRangeEnd = 232574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Additive() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Additive>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Additive.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007862 RID: 30818 RVA: 0x0003915B File Offset: 0x0003735B
		public Additive(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002462 RID: 9314
		// (get) Token: 0x06007863 RID: 30819 RVA: 0x00208CEC File Offset: 0x00206EEC
		// (set) Token: 0x06007864 RID: 30820 RVA: 0x00039164 File Offset: 0x00037364
		public unsafe string AdditiveName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_AdditiveName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_AdditiveName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002463 RID: 9315
		// (get) Token: 0x06007865 RID: 30821 RVA: 0x00208D14 File Offset: 0x00206F14
		// (set) Token: 0x06007866 RID: 30822 RVA: 0x00039183 File Offset: 0x00037383
		public unsafe string AssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_AssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002464 RID: 9316
		// (get) Token: 0x06007867 RID: 30823 RVA: 0x00208D3C File Offset: 0x00206F3C
		// (set) Token: 0x06007868 RID: 30824 RVA: 0x000391A2 File Offset: 0x000373A2
		public unsafe float QualityChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_QualityChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_QualityChange)) = value;
			}
		}

		// Token: 0x17002465 RID: 9317
		// (get) Token: 0x06007869 RID: 30825 RVA: 0x00208D64 File Offset: 0x00206F64
		// (set) Token: 0x0600786A RID: 30826 RVA: 0x000391BD File Offset: 0x000373BD
		public unsafe float YieldChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_YieldChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_YieldChange)) = value;
			}
		}

		// Token: 0x17002466 RID: 9318
		// (get) Token: 0x0600786B RID: 30827 RVA: 0x00208D8C File Offset: 0x00206F8C
		// (set) Token: 0x0600786C RID: 30828 RVA: 0x000391D8 File Offset: 0x000373D8
		public unsafe float GrowSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_GrowSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_GrowSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17002467 RID: 9319
		// (get) Token: 0x0600786D RID: 30829 RVA: 0x00208DB4 File Offset: 0x00206FB4
		// (set) Token: 0x0600786E RID: 30830 RVA: 0x000391F3 File Offset: 0x000373F3
		public unsafe float InstantGrowth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_InstantGrowth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_InstantGrowth)) = value;
			}
		}

		// Token: 0x04005209 RID: 21001
		private static readonly IntPtr NativeFieldInfoPtr_AdditiveName;

		// Token: 0x0400520A RID: 21002
		private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

		// Token: 0x0400520B RID: 21003
		private static readonly IntPtr NativeFieldInfoPtr_QualityChange;

		// Token: 0x0400520C RID: 21004
		private static readonly IntPtr NativeFieldInfoPtr_YieldChange;

		// Token: 0x0400520D RID: 21005
		private static readonly IntPtr NativeFieldInfoPtr_GrowSpeedMultiplier;

		// Token: 0x0400520E RID: 21006
		private static readonly IntPtr NativeFieldInfoPtr_InstantGrowth;

		// Token: 0x0400520F RID: 21007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
