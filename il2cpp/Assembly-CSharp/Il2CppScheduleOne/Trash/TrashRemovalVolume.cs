using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000525 RID: 1317
	public class TrashRemovalVolume : MonoBehaviour
	{
		// Token: 0x060075DC RID: 30172 RVA: 0x002018D4 File Offset: 0x001FFAD4
		// Note: this type is marked as 'beforefieldinit'.
		static TrashRemovalVolume()
		{
			Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashRemovalVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr);
			TrashRemovalVolume.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, "Collider");
			TrashRemovalVolume.NativeFieldInfoPtr_RemovalChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, "RemovalChance");
			TrashRemovalVolume.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100678153);
			TrashRemovalVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100678154);
			TrashRemovalVolume.NativeMethodInfoPtr_SleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100678155);
			TrashRemovalVolume.NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100678156);
			TrashRemovalVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100678157);
		}

		// Token: 0x060075DD RID: 30173 RVA: 0x00201990 File Offset: 0x001FFB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230255, XrefRangeEnd = 230267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075DE RID: 30174 RVA: 0x002019C4 File Offset: 0x001FFBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230267, XrefRangeEnd = 230281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075DF RID: 30175 RVA: 0x002019F8 File Offset: 0x001FFBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230281, XrefRangeEnd = 230286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr_SleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075E0 RID: 30176 RVA: 0x00201A2C File Offset: 0x001FFC2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230323, RefRangeEnd = 230324, XrefRangeStart = 230286, XrefRangeEnd = 230323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TrashItem> GetTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashItem>>(intPtr3) : null;
		}

		// Token: 0x060075E1 RID: 30177 RVA: 0x00201A6C File Offset: 0x001FFC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230324, XrefRangeEnd = 230325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashRemovalVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075E2 RID: 30178 RVA: 0x00037CE3 File Offset: 0x00035EE3
		public TrashRemovalVolume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023B1 RID: 9137
		// (get) Token: 0x060075E3 RID: 30179 RVA: 0x00201AA8 File Offset: 0x001FFCA8
		// (set) Token: 0x060075E4 RID: 30180 RVA: 0x00037CEC File Offset: 0x00035EEC
		public unsafe BoxCollider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashRemovalVolume.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashRemovalVolume.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023B2 RID: 9138
		// (get) Token: 0x060075E5 RID: 30181 RVA: 0x00201AD8 File Offset: 0x001FFCD8
		// (set) Token: 0x060075E6 RID: 30182 RVA: 0x00037D0B File Offset: 0x00035F0B
		public unsafe float RemovalChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashRemovalVolume.NativeFieldInfoPtr_RemovalChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashRemovalVolume.NativeFieldInfoPtr_RemovalChance)) = value;
			}
		}

		// Token: 0x04005091 RID: 20625
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04005092 RID: 20626
		private static readonly IntPtr NativeFieldInfoPtr_RemovalChance;

		// Token: 0x04005093 RID: 20627
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04005094 RID: 20628
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005095 RID: 20629
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Private_Void_0;

		// Token: 0x04005096 RID: 20630
		private static readonly IntPtr NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0;

		// Token: 0x04005097 RID: 20631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
