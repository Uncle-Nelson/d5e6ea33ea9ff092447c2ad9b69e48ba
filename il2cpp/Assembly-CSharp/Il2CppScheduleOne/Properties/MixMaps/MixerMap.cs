using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Properties.MixMaps
{
	// Token: 0x020001F3 RID: 499
	[Serializable]
	public class MixerMap : ScriptableObject
	{
		// Token: 0x06002888 RID: 10376 RVA: 0x000F0A9C File Offset: 0x000EEC9C
		// Note: this type is marked as 'beforefieldinit'.
		static MixerMap()
		{
			Il2CppClassPointerStore<MixerMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties.MixMaps", "MixerMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixerMap>.NativeClassPtr);
			MixerMap.NativeFieldInfoPtr_MapRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMap>.NativeClassPtr, "MapRadius");
			MixerMap.NativeFieldInfoPtr_Effects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMap>.NativeClassPtr, "Effects");
			MixerMap.NativeMethodInfoPtr_GetEffectAtPoint_Public_MixerMapEffect_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMap>.NativeClassPtr, 100667870);
			MixerMap.NativeMethodInfoPtr_GetEffect_Public_MixerMapEffect_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMap>.NativeClassPtr, 100667871);
			MixerMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMap>.NativeClassPtr, 100667872);
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x000F0B30 File Offset: 0x000EED30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118648, RefRangeEnd = 118649, XrefRangeStart = 118630, XrefRangeEnd = 118648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixerMapEffect GetEffectAtPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMap.NativeMethodInfoPtr_GetEffectAtPoint_Public_MixerMapEffect_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MixerMapEffect>(intPtr3) : null;
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x000F0B7C File Offset: 0x000EED7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118649, XrefRangeEnd = 118660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixerMapEffect GetEffect(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMap.NativeMethodInfoPtr_GetEffect_Public_MixerMapEffect_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MixerMapEffect>(intPtr3) : null;
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x000F0BCC File Offset: 0x000EEDCC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88919, RefRangeEnd = 88931, XrefRangeStart = 88919, XrefRangeEnd = 88931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixerMap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixerMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x00016084 File Offset: 0x00014284
		public MixerMap(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x0600288D RID: 10381 RVA: 0x000F0C08 File Offset: 0x000EEE08
		// (set) Token: 0x0600288E RID: 10382 RVA: 0x0001608D File Offset: 0x0001428D
		public unsafe float MapRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMap.NativeFieldInfoPtr_MapRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMap.NativeFieldInfoPtr_MapRadius)) = value;
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x0600288F RID: 10383 RVA: 0x000F0C30 File Offset: 0x000EEE30
		// (set) Token: 0x06002890 RID: 10384 RVA: 0x000160A8 File Offset: 0x000142A8
		public unsafe List<MixerMapEffect> Effects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMap.NativeFieldInfoPtr_Effects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MixerMapEffect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMap.NativeFieldInfoPtr_Effects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AE8 RID: 6888
		private static readonly IntPtr NativeFieldInfoPtr_MapRadius;

		// Token: 0x04001AE9 RID: 6889
		private static readonly IntPtr NativeFieldInfoPtr_Effects;

		// Token: 0x04001AEA RID: 6890
		private static readonly IntPtr NativeMethodInfoPtr_GetEffectAtPoint_Public_MixerMapEffect_Vector2_0;

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeMethodInfoPtr_GetEffect_Public_MixerMapEffect_Property_0;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
