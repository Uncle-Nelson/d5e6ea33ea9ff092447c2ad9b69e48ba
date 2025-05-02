using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000526 RID: 1318
	public class TrashSpawnVolume : MonoBehaviour
	{
		// Token: 0x060075E7 RID: 30183 RVA: 0x00201B00 File Offset: 0x001FFD00
		// Note: this type is marked as 'beforefieldinit'.
		static TrashSpawnVolume()
		{
			Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashSpawnVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr);
			TrashSpawnVolume.NativeFieldInfoPtr_CreatonVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, "CreatonVolume");
			TrashSpawnVolume.NativeFieldInfoPtr_DetectionVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, "DetectionVolume");
			TrashSpawnVolume.NativeFieldInfoPtr_TrashLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, "TrashLimit");
			TrashSpawnVolume.NativeFieldInfoPtr_TrashSpawnChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, "TrashSpawnChance");
			TrashSpawnVolume.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, 100678158);
			TrashSpawnVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, 100678159);
			TrashSpawnVolume.NativeMethodInfoPtr_SleepStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, 100678160);
			TrashSpawnVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, 100678161);
		}

		// Token: 0x060075E8 RID: 30184 RVA: 0x00201BD0 File Offset: 0x001FFDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230325, XrefRangeEnd = 230337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashSpawnVolume.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075E9 RID: 30185 RVA: 0x00201C04 File Offset: 0x001FFE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230337, XrefRangeEnd = 230351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashSpawnVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075EA RID: 30186 RVA: 0x00201C38 File Offset: 0x001FFE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230351, XrefRangeEnd = 230419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashSpawnVolume.NativeMethodInfoPtr_SleepStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075EB RID: 30187 RVA: 0x00201C6C File Offset: 0x001FFE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230419, XrefRangeEnd = 230420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashSpawnVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashSpawnVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075EC RID: 30188 RVA: 0x00037D26 File Offset: 0x00035F26
		public TrashSpawnVolume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023B3 RID: 9139
		// (get) Token: 0x060075ED RID: 30189 RVA: 0x00201CA8 File Offset: 0x001FFEA8
		// (set) Token: 0x060075EE RID: 30190 RVA: 0x00037D2F File Offset: 0x00035F2F
		public unsafe BoxCollider CreatonVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_CreatonVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_CreatonVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023B4 RID: 9140
		// (get) Token: 0x060075EF RID: 30191 RVA: 0x00201CD8 File Offset: 0x001FFED8
		// (set) Token: 0x060075F0 RID: 30192 RVA: 0x00037D4E File Offset: 0x00035F4E
		public unsafe BoxCollider DetectionVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_DetectionVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_DetectionVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023B5 RID: 9141
		// (get) Token: 0x060075F1 RID: 30193 RVA: 0x00201D08 File Offset: 0x001FFF08
		// (set) Token: 0x060075F2 RID: 30194 RVA: 0x00037D6D File Offset: 0x00035F6D
		public unsafe int TrashLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_TrashLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_TrashLimit)) = value;
			}
		}

		// Token: 0x170023B6 RID: 9142
		// (get) Token: 0x060075F3 RID: 30195 RVA: 0x00201D30 File Offset: 0x001FFF30
		// (set) Token: 0x060075F4 RID: 30196 RVA: 0x00037D88 File Offset: 0x00035F88
		public unsafe float TrashSpawnChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_TrashSpawnChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_TrashSpawnChance)) = value;
			}
		}

		// Token: 0x04005098 RID: 20632
		private static readonly IntPtr NativeFieldInfoPtr_CreatonVolume;

		// Token: 0x04005099 RID: 20633
		private static readonly IntPtr NativeFieldInfoPtr_DetectionVolume;

		// Token: 0x0400509A RID: 20634
		private static readonly IntPtr NativeFieldInfoPtr_TrashLimit;

		// Token: 0x0400509B RID: 20635
		private static readonly IntPtr NativeFieldInfoPtr_TrashSpawnChance;

		// Token: 0x0400509C RID: 20636
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x0400509D RID: 20637
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400509E RID: 20638
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Public_Void_0;

		// Token: 0x0400509F RID: 20639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
