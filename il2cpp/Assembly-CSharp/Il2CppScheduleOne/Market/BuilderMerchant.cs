using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI;
using UnityEngine;

namespace Il2CppScheduleOne.Market
{
	// Token: 0x0200037C RID: 892
	public class BuilderMerchant : MonoBehaviour
	{
		// Token: 0x060045DC RID: 17884 RVA: 0x00157CFC File Offset: 0x00155EFC
		// Note: this type is marked as 'beforefieldinit'.
		static BuilderMerchant()
		{
			Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Market", "BuilderMerchant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr);
			BuilderMerchant.NativeFieldInfoPtr_openTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, "openTime");
			BuilderMerchant.NativeFieldInfoPtr_closeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, "closeTime");
			BuilderMerchant.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, "intObj");
			BuilderMerchant.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, "selector");
			BuilderMerchant.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, 100671886);
			BuilderMerchant.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, 100671887);
			BuilderMerchant.NativeMethodInfoPtr_PropertySelected_Private_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, 100671888);
			BuilderMerchant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr, 100671889);
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x00157DCC File Offset: 0x00155FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157851, XrefRangeEnd = 157866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuilderMerchant.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x00157E00 File Offset: 0x00156000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157866, XrefRangeEnd = 157874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuilderMerchant.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x00157E34 File Offset: 0x00156034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157874, XrefRangeEnd = 157880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PropertySelected(Property p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuilderMerchant.NativeMethodInfoPtr_PropertySelected_Private_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045E0 RID: 17888 RVA: 0x00157E78 File Offset: 0x00156078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157880, XrefRangeEnd = 157881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuilderMerchant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuilderMerchant>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuilderMerchant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x00022045 File Offset: 0x00020245
		public BuilderMerchant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x060045E2 RID: 17890 RVA: 0x00157EB4 File Offset: 0x001560B4
		// (set) Token: 0x060045E3 RID: 17891 RVA: 0x0002204E File Offset: 0x0002024E
		public unsafe int openTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_openTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_openTime)) = value;
			}
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x060045E4 RID: 17892 RVA: 0x00157EDC File Offset: 0x001560DC
		// (set) Token: 0x060045E5 RID: 17893 RVA: 0x00022069 File Offset: 0x00020269
		public unsafe int closeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_closeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_closeTime)) = value;
			}
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x060045E6 RID: 17894 RVA: 0x00157F04 File Offset: 0x00156104
		// (set) Token: 0x060045E7 RID: 17895 RVA: 0x00022084 File Offset: 0x00020284
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x060045E8 RID: 17896 RVA: 0x00157F34 File Offset: 0x00156134
		// (set) Token: 0x060045E9 RID: 17897 RVA: 0x000220A3 File Offset: 0x000202A3
		public unsafe PropertySelector selector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_selector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertySelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuilderMerchant.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002EE6 RID: 12006
		private static readonly IntPtr NativeFieldInfoPtr_openTime;

		// Token: 0x04002EE7 RID: 12007
		private static readonly IntPtr NativeFieldInfoPtr_closeTime;

		// Token: 0x04002EE8 RID: 12008
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x04002EE9 RID: 12009
		private static readonly IntPtr NativeFieldInfoPtr_selector;

		// Token: 0x04002EEA RID: 12010
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04002EEB RID: 12011
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04002EEC RID: 12012
		private static readonly IntPtr NativeMethodInfoPtr_PropertySelected_Private_Void_Property_0;

		// Token: 0x04002EED RID: 12013
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
