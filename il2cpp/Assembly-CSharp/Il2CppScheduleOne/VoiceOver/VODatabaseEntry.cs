using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.VoiceOver
{
	// Token: 0x02000170 RID: 368
	[Serializable]
	public class VODatabaseEntry : Il2CppSystem.Object
	{
		// Token: 0x06001D9E RID: 7582 RVA: 0x000CC8DC File Offset: 0x000CAADC
		// Note: this type is marked as 'beforefieldinit'.
		static VODatabaseEntry()
		{
			Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.VoiceOver", "VODatabaseEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr);
			VODatabaseEntry.NativeFieldInfoPtr_LineType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, "LineType");
			VODatabaseEntry.NativeFieldInfoPtr_Clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, "Clips");
			VODatabaseEntry.NativeFieldInfoPtr_lastClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, "lastClip");
			VODatabaseEntry.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, "VolumeMultiplier");
			VODatabaseEntry.NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, 100666666);
			VODatabaseEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, 100666667);
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x000CC984 File Offset: 0x000CAB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106237, XrefRangeEnd = 106245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioClip GetRandomClip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabaseEntry.NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x000CC9C4 File Offset: 0x000CABC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106245, XrefRangeEnd = 106246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VODatabaseEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabaseEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00010BD2 File Offset: 0x0000EDD2
		public VODatabaseEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x000CCA00 File Offset: 0x000CAC00
		// (set) Token: 0x06001DA3 RID: 7587 RVA: 0x00010BDB File Offset: 0x0000EDDB
		public unsafe EVOLineType LineType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_LineType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_LineType)) = value;
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x000CCA28 File Offset: 0x000CAC28
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x00010BF6 File Offset: 0x0000EDF6
		public unsafe Il2CppReferenceArray<AudioClip> Clips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_Clips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_Clips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x000CCA58 File Offset: 0x000CAC58
		// (set) Token: 0x06001DA7 RID: 7591 RVA: 0x00010C15 File Offset: 0x0000EE15
		public unsafe AudioClip lastClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_lastClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_lastClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x000CCA88 File Offset: 0x000CAC88
		// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x00010C34 File Offset: 0x0000EE34
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeFieldInfoPtr_LineType;

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeFieldInfoPtr_Clips;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeFieldInfoPtr_lastClip;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_0;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
