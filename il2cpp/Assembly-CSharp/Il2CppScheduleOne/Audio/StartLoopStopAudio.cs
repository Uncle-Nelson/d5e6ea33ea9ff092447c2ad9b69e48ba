using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004DB RID: 1243
	public class StartLoopStopAudio : MonoBehaviour
	{
		// Token: 0x06006C95 RID: 27797 RVA: 0x001E1EE8 File Offset: 0x001E00E8
		// Note: this type is marked as 'beforefieldinit'.
		static StartLoopStopAudio()
		{
			Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "StartLoopStopAudio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr);
			StartLoopStopAudio.NativeFieldInfoPtr__Runnning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "<Runnning>k__BackingField");
			StartLoopStopAudio.NativeFieldInfoPtr_StartSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "StartSound");
			StartLoopStopAudio.NativeFieldInfoPtr_LoopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "LoopSound");
			StartLoopStopAudio.NativeFieldInfoPtr_StopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "StopSound");
			StartLoopStopAudio.NativeFieldInfoPtr_FadeLoopIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "FadeLoopIn");
			StartLoopStopAudio.NativeFieldInfoPtr_FadeLoopOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "FadeLoopOut");
			StartLoopStopAudio.NativeFieldInfoPtr_timeSinceStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "timeSinceStart");
			StartLoopStopAudio.NativeFieldInfoPtr_timeSinceStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "timeSinceStop");
			StartLoopStopAudio.NativeMethodInfoPtr_get_Runnning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100677022);
			StartLoopStopAudio.NativeMethodInfoPtr_set_Runnning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100677023);
			StartLoopStopAudio.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100677024);
			StartLoopStopAudio.NativeMethodInfoPtr_StartAudio_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100677025);
			StartLoopStopAudio.NativeMethodInfoPtr_StopAudio_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100677026);
			StartLoopStopAudio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100677027);
		}

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x06006C96 RID: 27798 RVA: 0x001E2030 File Offset: 0x001E0230
		// (set) Token: 0x06006C97 RID: 27799 RVA: 0x001E206C File Offset: 0x001E026C
		public unsafe bool Runnning
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_get_Runnning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_set_Runnning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006C98 RID: 27800 RVA: 0x001E20AC File Offset: 0x001E02AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217311, XrefRangeEnd = 217318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C99 RID: 27801 RVA: 0x001E20E0 File Offset: 0x001E02E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 217319, RefRangeEnd = 217322, XrefRangeStart = 217318, XrefRangeEnd = 217319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_StartAudio_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C9A RID: 27802 RVA: 0x001E2114 File Offset: 0x001E0314
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 217323, RefRangeEnd = 217326, XrefRangeStart = 217322, XrefRangeEnd = 217323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_StopAudio_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C9B RID: 27803 RVA: 0x001E2148 File Offset: 0x001E0348
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartLoopStopAudio() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C9C RID: 27804 RVA: 0x00033673 File Offset: 0x00031873
		public StartLoopStopAudio(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x06006C9D RID: 27805 RVA: 0x001E2184 File Offset: 0x001E0384
		// (set) Token: 0x06006C9E RID: 27806 RVA: 0x0003367C File Offset: 0x0003187C
		public unsafe bool _Runnning_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__Runnning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__Runnning_k__BackingField)) = value;
			}
		}

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x06006C9F RID: 27807 RVA: 0x001E21AC File Offset: 0x001E03AC
		// (set) Token: 0x06006CA0 RID: 27808 RVA: 0x00033697 File Offset: 0x00031897
		public unsafe AudioSourceController StartSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_StartSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_StartSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x06006CA1 RID: 27809 RVA: 0x001E21DC File Offset: 0x001E03DC
		// (set) Token: 0x06006CA2 RID: 27810 RVA: 0x000336B6 File Offset: 0x000318B6
		public unsafe AudioSourceController LoopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_LoopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_LoopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x06006CA3 RID: 27811 RVA: 0x001E220C File Offset: 0x001E040C
		// (set) Token: 0x06006CA4 RID: 27812 RVA: 0x000336D5 File Offset: 0x000318D5
		public unsafe AudioSourceController StopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_StopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_StopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x06006CA5 RID: 27813 RVA: 0x001E223C File Offset: 0x001E043C
		// (set) Token: 0x06006CA6 RID: 27814 RVA: 0x000336F4 File Offset: 0x000318F4
		public unsafe bool FadeLoopIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_FadeLoopIn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_FadeLoopIn)) = value;
			}
		}

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x06006CA7 RID: 27815 RVA: 0x001E2264 File Offset: 0x001E0464
		// (set) Token: 0x06006CA8 RID: 27816 RVA: 0x0003370F File Offset: 0x0003190F
		public unsafe bool FadeLoopOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_FadeLoopOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_FadeLoopOut)) = value;
			}
		}

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x06006CA9 RID: 27817 RVA: 0x001E228C File Offset: 0x001E048C
		// (set) Token: 0x06006CAA RID: 27818 RVA: 0x0003372A File Offset: 0x0003192A
		public unsafe float timeSinceStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_timeSinceStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_timeSinceStart)) = value;
			}
		}

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x06006CAB RID: 27819 RVA: 0x001E22B4 File Offset: 0x001E04B4
		// (set) Token: 0x06006CAC RID: 27820 RVA: 0x00033745 File Offset: 0x00031945
		public unsafe float timeSinceStop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_timeSinceStop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_timeSinceStop)) = value;
			}
		}

		// Token: 0x04004A39 RID: 19001
		private static readonly IntPtr NativeFieldInfoPtr__Runnning_k__BackingField;

		// Token: 0x04004A3A RID: 19002
		private static readonly IntPtr NativeFieldInfoPtr_StartSound;

		// Token: 0x04004A3B RID: 19003
		private static readonly IntPtr NativeFieldInfoPtr_LoopSound;

		// Token: 0x04004A3C RID: 19004
		private static readonly IntPtr NativeFieldInfoPtr_StopSound;

		// Token: 0x04004A3D RID: 19005
		private static readonly IntPtr NativeFieldInfoPtr_FadeLoopIn;

		// Token: 0x04004A3E RID: 19006
		private static readonly IntPtr NativeFieldInfoPtr_FadeLoopOut;

		// Token: 0x04004A3F RID: 19007
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceStart;

		// Token: 0x04004A40 RID: 19008
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceStop;

		// Token: 0x04004A41 RID: 19009
		private static readonly IntPtr NativeMethodInfoPtr_get_Runnning_Public_get_Boolean_0;

		// Token: 0x04004A42 RID: 19010
		private static readonly IntPtr NativeMethodInfoPtr_set_Runnning_Private_set_Void_Boolean_0;

		// Token: 0x04004A43 RID: 19011
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004A44 RID: 19012
		private static readonly IntPtr NativeMethodInfoPtr_StartAudio_Public_Void_0;

		// Token: 0x04004A45 RID: 19013
		private static readonly IntPtr NativeMethodInfoPtr_StopAudio_Public_Void_0;

		// Token: 0x04004A46 RID: 19014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
