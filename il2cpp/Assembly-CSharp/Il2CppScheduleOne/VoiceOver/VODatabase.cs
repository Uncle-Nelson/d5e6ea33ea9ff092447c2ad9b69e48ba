using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.VoiceOver
{
	// Token: 0x0200016F RID: 367
	[Serializable]
	public class VODatabase : ScriptableObject
	{
		// Token: 0x06001D95 RID: 7573 RVA: 0x000CC71C File Offset: 0x000CA91C
		// Note: this type is marked as 'beforefieldinit'.
		static VODatabase()
		{
			Il2CppClassPointerStore<VODatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.VoiceOver", "VODatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VODatabase>.NativeClassPtr);
			VODatabase.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, "VolumeMultiplier");
			VODatabase.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, "Entries");
			VODatabase.NativeMethodInfoPtr_GetEntry_Public_VODatabaseEntry_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, 100666663);
			VODatabase.NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, 100666664);
			VODatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, 100666665);
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x000CC7B0 File Offset: 0x000CA9B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 106225, RefRangeEnd = 106228, XrefRangeStart = 106215, XrefRangeEnd = 106225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VODatabaseEntry GetEntry(EVOLineType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabase.NativeMethodInfoPtr_GetEntry_Public_VODatabaseEntry_EVOLineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VODatabaseEntry>(intPtr3) : null;
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x000CC7FC File Offset: 0x000CA9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106228, XrefRangeEnd = 106229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioClip GetRandomClip(EVOLineType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabase.NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_EVOLineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x000CC848 File Offset: 0x000CAA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106229, XrefRangeEnd = 106237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VODatabase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VODatabase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00010B8F File Offset: 0x0000ED8F
		public VODatabase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x000CC884 File Offset: 0x000CAA84
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x00010B98 File Offset: 0x0000ED98
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabase.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabase.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x000CC8AC File Offset: 0x000CAAAC
		// (set) Token: 0x06001D9D RID: 7581 RVA: 0x00010BB3 File Offset: 0x0000EDB3
		public unsafe List<VODatabaseEntry> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabase.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VODatabaseEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabase.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Public_VODatabaseEntry_EVOLineType_0;

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_EVOLineType_0;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
