using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.VoiceOver
{
	// Token: 0x02000171 RID: 369
	public class VOEmitter : MonoBehaviour
	{
		// Token: 0x06001DAA RID: 7594 RVA: 0x000CCAB0 File Offset: 0x000CACB0
		// Note: this type is marked as 'beforefieldinit'.
		static VOEmitter()
		{
			Il2CppClassPointerStore<VOEmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.VoiceOver", "VOEmitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr);
			VOEmitter.NativeFieldInfoPtr_PitchVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "PitchVariation");
			VOEmitter.NativeFieldInfoPtr_Database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "Database");
			VOEmitter.NativeFieldInfoPtr_PitchMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "PitchMultiplier");
			VOEmitter.NativeFieldInfoPtr_runtimePitchMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "runtimePitchMultiplier");
			VOEmitter.NativeFieldInfoPtr_audioSourceController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "audioSourceController");
			VOEmitter.NativeFieldInfoPtr_defaultVODatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "defaultVODatabase");
			VOEmitter.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100666668);
			VOEmitter.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100666669);
			VOEmitter.NativeMethodInfoPtr_SetRuntimePitchMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100666670);
			VOEmitter.NativeMethodInfoPtr_SetDatabase_Public_Void_VODatabase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100666671);
			VOEmitter.NativeMethodInfoPtr_ResetDatabase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100666672);
			VOEmitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100666673);
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x000CCBD0 File Offset: 0x000CADD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106246, XrefRangeEnd = 106250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VOEmitter.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x000CCC0C File Offset: 0x000CAE0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106277, RefRangeEnd = 106279, XrefRangeStart = 106250, XrefRangeEnd = 106277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Play(EVOLineType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VOEmitter.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_EVOLineType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x000CCC58 File Offset: 0x000CAE58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106279, RefRangeEnd = 106281, XrefRangeStart = 106279, XrefRangeEnd = 106279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRuntimePitchMultiplier(float pitchMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pitchMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VOEmitter.NativeMethodInfoPtr_SetRuntimePitchMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x000CCC98 File Offset: 0x000CAE98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106283, RefRangeEnd = 106285, XrefRangeStart = 106281, XrefRangeEnd = 106283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDatabase(VODatabase database, bool writeDefault = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(database);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeDefault;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VOEmitter.NativeMethodInfoPtr_SetDatabase_Public_Void_VODatabase_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x000CCCE8 File Offset: 0x000CAEE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106286, RefRangeEnd = 106287, XrefRangeStart = 106285, XrefRangeEnd = 106286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetDatabase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VOEmitter.NativeMethodInfoPtr_ResetDatabase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x000CCD1C File Offset: 0x000CAF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VOEmitter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VOEmitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00010C4F File Offset: 0x0000EE4F
		public VOEmitter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x000CCD58 File Offset: 0x000CAF58
		// (set) Token: 0x06001DB3 RID: 7603 RVA: 0x00010C58 File Offset: 0x0000EE58
		public unsafe static float PitchVariation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VOEmitter.NativeFieldInfoPtr_PitchVariation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VOEmitter.NativeFieldInfoPtr_PitchVariation, (void*)(&value));
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x000CCD74 File Offset: 0x000CAF74
		// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x00010C66 File Offset: 0x0000EE66
		public unsafe VODatabase Database
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_Database);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VODatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_Database), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x000CCDA4 File Offset: 0x000CAFA4
		// (set) Token: 0x06001DB7 RID: 7607 RVA: 0x00010C85 File Offset: 0x0000EE85
		public unsafe float PitchMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_PitchMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_PitchMultiplier)) = value;
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x000CCDCC File Offset: 0x000CAFCC
		// (set) Token: 0x06001DB9 RID: 7609 RVA: 0x00010CA0 File Offset: 0x0000EEA0
		public unsafe float runtimePitchMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_runtimePitchMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_runtimePitchMultiplier)) = value;
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06001DBA RID: 7610 RVA: 0x000CCDF4 File Offset: 0x000CAFF4
		// (set) Token: 0x06001DBB RID: 7611 RVA: 0x00010CBB File Offset: 0x0000EEBB
		public unsafe AudioSourceController audioSourceController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_audioSourceController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_audioSourceController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x000CCE24 File Offset: 0x000CB024
		// (set) Token: 0x06001DBD RID: 7613 RVA: 0x00010CDA File Offset: 0x0000EEDA
		public unsafe VODatabase defaultVODatabase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_defaultVODatabase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VODatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr_defaultVODatabase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeFieldInfoPtr_PitchVariation;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeFieldInfoPtr_Database;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeFieldInfoPtr_PitchMultiplier;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeFieldInfoPtr_runtimePitchMultiplier;

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeFieldInfoPtr_audioSourceController;

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeFieldInfoPtr_defaultVODatabase;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_New_Void_EVOLineType_0;

		// Token: 0x040013C5 RID: 5061
		private static readonly IntPtr NativeMethodInfoPtr_SetRuntimePitchMultiplier_Public_Void_Single_0;

		// Token: 0x040013C6 RID: 5062
		private static readonly IntPtr NativeMethodInfoPtr_SetDatabase_Public_Void_VODatabase_Boolean_0;

		// Token: 0x040013C7 RID: 5063
		private static readonly IntPtr NativeMethodInfoPtr_ResetDatabase_Public_Void_0;

		// Token: 0x040013C8 RID: 5064
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
