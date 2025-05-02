using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000610 RID: 1552
	public class PoliceBelt : Accessory
	{
		// Token: 0x06008950 RID: 35152 RVA: 0x00241364 File Offset: 0x0023F564
		// Note: this type is marked as 'beforefieldinit'.
		static PoliceBelt()
		{
			Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "PoliceBelt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr);
			PoliceBelt.NativeFieldInfoPtr_BatonObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, "BatonObject");
			PoliceBelt.NativeFieldInfoPtr_TaserObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, "TaserObject");
			PoliceBelt.NativeFieldInfoPtr_GunObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, "GunObject");
			PoliceBelt.NativeMethodInfoPtr_SetBatonVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, 100680388);
			PoliceBelt.NativeMethodInfoPtr_SetTaserVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, 100680389);
			PoliceBelt.NativeMethodInfoPtr_SetGunVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, 100680390);
			PoliceBelt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, 100680391);
		}

		// Token: 0x06008951 RID: 35153 RVA: 0x00241420 File Offset: 0x0023F620
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253545, RefRangeEnd = 253548, XrefRangeStart = 253542, XrefRangeEnd = 253545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBatonVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceBelt.NativeMethodInfoPtr_SetBatonVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008952 RID: 35154 RVA: 0x00241460 File Offset: 0x0023F660
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253551, RefRangeEnd = 253554, XrefRangeStart = 253548, XrefRangeEnd = 253551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTaserVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceBelt.NativeMethodInfoPtr_SetTaserVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008953 RID: 35155 RVA: 0x002414A0 File Offset: 0x0023F6A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253557, RefRangeEnd = 253560, XrefRangeStart = 253554, XrefRangeEnd = 253557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGunVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceBelt.NativeMethodInfoPtr_SetGunVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008954 RID: 35156 RVA: 0x002414E0 File Offset: 0x0023F6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253560, XrefRangeEnd = 253561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceBelt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceBelt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008955 RID: 35157 RVA: 0x00041933 File Offset: 0x0003FB33
		public PoliceBelt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029DC RID: 10716
		// (get) Token: 0x06008956 RID: 35158 RVA: 0x0024151C File Offset: 0x0023F71C
		// (set) Token: 0x06008957 RID: 35159 RVA: 0x0004193C File Offset: 0x0003FB3C
		public unsafe GameObject BatonObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_BatonObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_BatonObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029DD RID: 10717
		// (get) Token: 0x06008958 RID: 35160 RVA: 0x0024154C File Offset: 0x0023F74C
		// (set) Token: 0x06008959 RID: 35161 RVA: 0x0004195B File Offset: 0x0003FB5B
		public unsafe GameObject TaserObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_TaserObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_TaserObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029DE RID: 10718
		// (get) Token: 0x0600895A RID: 35162 RVA: 0x0024157C File Offset: 0x0023F77C
		// (set) Token: 0x0600895B RID: 35163 RVA: 0x0004197A File Offset: 0x0003FB7A
		public unsafe GameObject GunObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_GunObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_GunObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D40 RID: 23872
		private static readonly IntPtr NativeFieldInfoPtr_BatonObject;

		// Token: 0x04005D41 RID: 23873
		private static readonly IntPtr NativeFieldInfoPtr_TaserObject;

		// Token: 0x04005D42 RID: 23874
		private static readonly IntPtr NativeFieldInfoPtr_GunObject;

		// Token: 0x04005D43 RID: 23875
		private static readonly IntPtr NativeMethodInfoPtr_SetBatonVisible_Public_Void_Boolean_0;

		// Token: 0x04005D44 RID: 23876
		private static readonly IntPtr NativeMethodInfoPtr_SetTaserVisible_Public_Void_Boolean_0;

		// Token: 0x04005D45 RID: 23877
		private static readonly IntPtr NativeMethodInfoPtr_SetGunVisible_Public_Void_Boolean_0;

		// Token: 0x04005D46 RID: 23878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
