using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using UnityEngine;

namespace Il2CppScheduleOne.Market
{
	// Token: 0x0200037E RID: 894
	public class Merchant : MonoBehaviour
	{
		// Token: 0x060045ED RID: 17901 RVA: 0x00157FA0 File Offset: 0x001561A0
		// Note: this type is marked as 'beforefieldinit'.
		static Merchant()
		{
			Il2CppClassPointerStore<Merchant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Market", "Merchant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Merchant>.NativeClassPtr);
			Merchant.NativeFieldInfoPtr_shopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "shopName");
			Merchant.NativeFieldInfoPtr_openTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "openTime");
			Merchant.NativeFieldInfoPtr_closeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "closeTime");
			Merchant.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "intObj");
			Merchant.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merchant>.NativeClassPtr, 100671891);
			Merchant.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merchant>.NativeClassPtr, 100671892);
			Merchant.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merchant>.NativeClassPtr, 100671893);
			Merchant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merchant>.NativeClassPtr, 100671894);
		}

		// Token: 0x060045EE RID: 17902 RVA: 0x00158070 File Offset: 0x00156270
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Merchant.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045EF RID: 17903 RVA: 0x001580AC File Offset: 0x001562AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157886, XrefRangeEnd = 157898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merchant.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x001580E0 File Offset: 0x001562E0
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Merchant.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x0015811C File Offset: 0x0015631C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Merchant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Merchant>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merchant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x00022104 File Offset: 0x00020304
		public Merchant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x060045F3 RID: 17907 RVA: 0x00158158 File Offset: 0x00156358
		// (set) Token: 0x060045F4 RID: 17908 RVA: 0x0002210D File Offset: 0x0002030D
		public unsafe string shopName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_shopName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_shopName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x060045F5 RID: 17909 RVA: 0x00158180 File Offset: 0x00156380
		// (set) Token: 0x060045F6 RID: 17910 RVA: 0x0002212C File Offset: 0x0002032C
		public unsafe int openTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_openTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_openTime)) = value;
			}
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x060045F7 RID: 17911 RVA: 0x001581A8 File Offset: 0x001563A8
		// (set) Token: 0x060045F8 RID: 17912 RVA: 0x00022147 File Offset: 0x00020347
		public unsafe int closeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_closeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_closeTime)) = value;
			}
		}

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x060045F9 RID: 17913 RVA: 0x001581D0 File Offset: 0x001563D0
		// (set) Token: 0x060045FA RID: 17914 RVA: 0x00022162 File Offset: 0x00020362
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002EEF RID: 12015
		private static readonly IntPtr NativeFieldInfoPtr_shopName;

		// Token: 0x04002EF0 RID: 12016
		private static readonly IntPtr NativeFieldInfoPtr_openTime;

		// Token: 0x04002EF1 RID: 12017
		private static readonly IntPtr NativeFieldInfoPtr_closeTime;

		// Token: 0x04002EF2 RID: 12018
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x04002EF3 RID: 12019
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04002EF4 RID: 12020
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04002EF5 RID: 12021
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0;

		// Token: 0x04002EF6 RID: 12022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
