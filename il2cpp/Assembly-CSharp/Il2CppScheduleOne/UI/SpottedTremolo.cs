using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Stealth;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000621 RID: 1569
	public class SpottedTremolo : MonoBehaviour
	{
		// Token: 0x06008A65 RID: 35429 RVA: 0x002448D4 File Offset: 0x00242AD4
		// Note: this type is marked as 'beforefieldinit'.
		static SpottedTremolo()
		{
			Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "SpottedTremolo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr);
			SpottedTremolo.NativeFieldInfoPtr_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "Intensity");
			SpottedTremolo.NativeFieldInfoPtr_Loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "Loop");
			SpottedTremolo.NativeFieldInfoPtr_PlayerVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "PlayerVisibility");
			SpottedTremolo.NativeFieldInfoPtr_MinVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "MinVolume");
			SpottedTremolo.NativeFieldInfoPtr_MaxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "MaxVolume");
			SpottedTremolo.NativeFieldInfoPtr_MinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "MinPitch");
			SpottedTremolo.NativeFieldInfoPtr_MaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "MaxPitch");
			SpottedTremolo.NativeFieldInfoPtr_SmoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "SmoothTime");
			SpottedTremolo.NativeFieldInfoPtr_smoothedIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "smoothedIntensity");
			SpottedTremolo.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, 100680501);
			SpottedTremolo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, 100680502);
		}

		// Token: 0x06008A66 RID: 35430 RVA: 0x002449E0 File Offset: 0x00242BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254474, XrefRangeEnd = 254483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpottedTremolo.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A67 RID: 35431 RVA: 0x00244A14 File Offset: 0x00242C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254483, XrefRangeEnd = 254484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpottedTremolo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpottedTremolo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A68 RID: 35432 RVA: 0x000422F5 File Offset: 0x000404F5
		public SpottedTremolo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A29 RID: 10793
		// (get) Token: 0x06008A69 RID: 35433 RVA: 0x00244A50 File Offset: 0x00242C50
		// (set) Token: 0x06008A6A RID: 35434 RVA: 0x000422FE File Offset: 0x000404FE
		public unsafe float Intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_Intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_Intensity)) = value;
			}
		}

		// Token: 0x17002A2A RID: 10794
		// (get) Token: 0x06008A6B RID: 35435 RVA: 0x00244A78 File Offset: 0x00242C78
		// (set) Token: 0x06008A6C RID: 35436 RVA: 0x00042319 File Offset: 0x00040519
		public unsafe AudioSourceController Loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_Loop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_Loop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A2B RID: 10795
		// (get) Token: 0x06008A6D RID: 35437 RVA: 0x00244AA8 File Offset: 0x00242CA8
		// (set) Token: 0x06008A6E RID: 35438 RVA: 0x00042338 File Offset: 0x00040538
		public unsafe PlayerVisibility PlayerVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_PlayerVisibility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisibility>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_PlayerVisibility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A2C RID: 10796
		// (get) Token: 0x06008A6F RID: 35439 RVA: 0x00244AD8 File Offset: 0x00242CD8
		// (set) Token: 0x06008A70 RID: 35440 RVA: 0x00042357 File Offset: 0x00040557
		public unsafe float MinVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MinVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MinVolume)) = value;
			}
		}

		// Token: 0x17002A2D RID: 10797
		// (get) Token: 0x06008A71 RID: 35441 RVA: 0x00244B00 File Offset: 0x00242D00
		// (set) Token: 0x06008A72 RID: 35442 RVA: 0x00042372 File Offset: 0x00040572
		public unsafe float MaxVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MaxVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MaxVolume)) = value;
			}
		}

		// Token: 0x17002A2E RID: 10798
		// (get) Token: 0x06008A73 RID: 35443 RVA: 0x00244B28 File Offset: 0x00242D28
		// (set) Token: 0x06008A74 RID: 35444 RVA: 0x0004238D File Offset: 0x0004058D
		public unsafe float MinPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MinPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MinPitch)) = value;
			}
		}

		// Token: 0x17002A2F RID: 10799
		// (get) Token: 0x06008A75 RID: 35445 RVA: 0x00244B50 File Offset: 0x00242D50
		// (set) Token: 0x06008A76 RID: 35446 RVA: 0x000423A8 File Offset: 0x000405A8
		public unsafe float MaxPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MaxPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MaxPitch)) = value;
			}
		}

		// Token: 0x17002A30 RID: 10800
		// (get) Token: 0x06008A77 RID: 35447 RVA: 0x00244B78 File Offset: 0x00242D78
		// (set) Token: 0x06008A78 RID: 35448 RVA: 0x000423C3 File Offset: 0x000405C3
		public unsafe float SmoothTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_SmoothTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_SmoothTime)) = value;
			}
		}

		// Token: 0x17002A31 RID: 10801
		// (get) Token: 0x06008A79 RID: 35449 RVA: 0x00244BA0 File Offset: 0x00242DA0
		// (set) Token: 0x06008A7A RID: 35450 RVA: 0x000423DE File Offset: 0x000405DE
		public unsafe float smoothedIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_smoothedIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_smoothedIntensity)) = value;
			}
		}

		// Token: 0x04005DE8 RID: 24040
		private static readonly IntPtr NativeFieldInfoPtr_Intensity;

		// Token: 0x04005DE9 RID: 24041
		private static readonly IntPtr NativeFieldInfoPtr_Loop;

		// Token: 0x04005DEA RID: 24042
		private static readonly IntPtr NativeFieldInfoPtr_PlayerVisibility;

		// Token: 0x04005DEB RID: 24043
		private static readonly IntPtr NativeFieldInfoPtr_MinVolume;

		// Token: 0x04005DEC RID: 24044
		private static readonly IntPtr NativeFieldInfoPtr_MaxVolume;

		// Token: 0x04005DED RID: 24045
		private static readonly IntPtr NativeFieldInfoPtr_MinPitch;

		// Token: 0x04005DEE RID: 24046
		private static readonly IntPtr NativeFieldInfoPtr_MaxPitch;

		// Token: 0x04005DEF RID: 24047
		private static readonly IntPtr NativeFieldInfoPtr_SmoothTime;

		// Token: 0x04005DF0 RID: 24048
		private static readonly IntPtr NativeFieldInfoPtr_smoothedIntensity;

		// Token: 0x04005DF1 RID: 24049
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04005DF2 RID: 24050
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
