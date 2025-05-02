using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E2 RID: 1250
	public class LoanSharkCarVisuals : MonoBehaviour
	{
		// Token: 0x06006E8F RID: 28303 RVA: 0x001E92BC File Offset: 0x001E74BC
		// Note: this type is marked as 'beforefieldinit'.
		static LoanSharkCarVisuals()
		{
			Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "LoanSharkCarVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr);
			LoanSharkCarVisuals.NativeFieldInfoPtr_Note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, "Note");
			LoanSharkCarVisuals.NativeFieldInfoPtr_BulletHoleDecals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, "BulletHoleDecals");
			LoanSharkCarVisuals.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, 100677289);
			LoanSharkCarVisuals.NativeMethodInfoPtr_Configure_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, 100677290);
			LoanSharkCarVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, 100677291);
		}

		// Token: 0x06006E90 RID: 28304 RVA: 0x001E9350 File Offset: 0x001E7550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220267, XrefRangeEnd = 220272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoanSharkCarVisuals.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E91 RID: 28305 RVA: 0x001E9384 File Offset: 0x001E7584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220272, XrefRangeEnd = 220275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Configure(bool enabled, bool noteVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noteVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoanSharkCarVisuals.NativeMethodInfoPtr_Configure_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E92 RID: 28306 RVA: 0x001E93D0 File Offset: 0x001E75D0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoanSharkCarVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoanSharkCarVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E93 RID: 28307 RVA: 0x000344B0 File Offset: 0x000326B0
		public LoanSharkCarVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x06006E94 RID: 28308 RVA: 0x001E940C File Offset: 0x001E760C
		// (set) Token: 0x06006E95 RID: 28309 RVA: 0x000344B9 File Offset: 0x000326B9
		public unsafe GameObject Note
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoanSharkCarVisuals.NativeFieldInfoPtr_Note);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoanSharkCarVisuals.NativeFieldInfoPtr_Note), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x06006E96 RID: 28310 RVA: 0x001E943C File Offset: 0x001E763C
		// (set) Token: 0x06006E97 RID: 28311 RVA: 0x000344D8 File Offset: 0x000326D8
		public unsafe GameObject BulletHoleDecals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoanSharkCarVisuals.NativeFieldInfoPtr_BulletHoleDecals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoanSharkCarVisuals.NativeFieldInfoPtr_BulletHoleDecals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004BAB RID: 19371
		private static readonly IntPtr NativeFieldInfoPtr_Note;

		// Token: 0x04004BAC RID: 19372
		private static readonly IntPtr NativeFieldInfoPtr_BulletHoleDecals;

		// Token: 0x04004BAD RID: 19373
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004BAE RID: 19374
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_Boolean_Boolean_0;

		// Token: 0x04004BAF RID: 19375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
