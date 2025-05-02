using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Cutscenes
{
	// Token: 0x0200047F RID: 1151
	public class CutsceneManager : Singleton<CutsceneManager>
	{
		// Token: 0x060063CE RID: 25550 RVA: 0x001C450C File Offset: 0x001C270C
		// Note: this type is marked as 'beforefieldinit'.
		static CutsceneManager()
		{
			Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cutscenes", "CutsceneManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr);
			CutsceneManager.NativeFieldInfoPtr_Cutscenes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, "Cutscenes");
			CutsceneManager.NativeFieldInfoPtr_cutsceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, "cutsceneName");
			CutsceneManager.NativeFieldInfoPtr_playingCutscene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, "playingCutscene");
			CutsceneManager.NativeMethodInfoPtr_RunCutscene_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, 100675946);
			CutsceneManager.NativeMethodInfoPtr_Play_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, 100675947);
			CutsceneManager.NativeMethodInfoPtr_Ended_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, 100675948);
			CutsceneManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, 100675949);
		}

		// Token: 0x060063CF RID: 25551 RVA: 0x001C45C8 File Offset: 0x001C27C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203913, XrefRangeEnd = 203939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunCutscene()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.NativeMethodInfoPtr_RunCutscene_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063D0 RID: 25552 RVA: 0x001C45FC File Offset: 0x001C27FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203939, XrefRangeEnd = 203965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.NativeMethodInfoPtr_Play_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063D1 RID: 25553 RVA: 0x001C4640 File Offset: 0x001C2840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203965, XrefRangeEnd = 203974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Ended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.NativeMethodInfoPtr_Ended_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063D2 RID: 25554 RVA: 0x001C4674 File Offset: 0x001C2874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203974, XrefRangeEnd = 203981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutsceneManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063D3 RID: 25555 RVA: 0x0002F324 File Offset: 0x0002D524
		public CutsceneManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E1A RID: 7706
		// (get) Token: 0x060063D4 RID: 25556 RVA: 0x001C46B0 File Offset: 0x001C28B0
		// (set) Token: 0x060063D5 RID: 25557 RVA: 0x0002F32D File Offset: 0x0002D52D
		public unsafe List<Cutscene> Cutscenes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_Cutscenes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Cutscene>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_Cutscenes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x060063D6 RID: 25558 RVA: 0x001C46E0 File Offset: 0x001C28E0
		// (set) Token: 0x060063D7 RID: 25559 RVA: 0x0002F34C File Offset: 0x0002D54C
		public unsafe string cutsceneName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_cutsceneName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_cutsceneName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x060063D8 RID: 25560 RVA: 0x001C4708 File Offset: 0x001C2908
		// (set) Token: 0x060063D9 RID: 25561 RVA: 0x0002F36B File Offset: 0x0002D56B
		public unsafe Cutscene playingCutscene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_playingCutscene);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cutscene>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_playingCutscene), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400441D RID: 17437
		private static readonly IntPtr NativeFieldInfoPtr_Cutscenes;

		// Token: 0x0400441E RID: 17438
		private static readonly IntPtr NativeFieldInfoPtr_cutsceneName;

		// Token: 0x0400441F RID: 17439
		private static readonly IntPtr NativeFieldInfoPtr_playingCutscene;

		// Token: 0x04004420 RID: 17440
		private static readonly IntPtr NativeMethodInfoPtr_RunCutscene_Private_Void_0;

		// Token: 0x04004421 RID: 17441
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_String_0;

		// Token: 0x04004422 RID: 17442
		private static readonly IntPtr NativeMethodInfoPtr_Ended_Private_Void_0;

		// Token: 0x04004423 RID: 17443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A2A RID: 2602
		[ObfuscatedName("ScheduleOne.Cutscenes.CutsceneManager+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600CF4D RID: 53069 RVA: 0x0031CF84 File Offset: 0x0031B184
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr);
				CutsceneManager.__c__DisplayClass4_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr, "name");
				CutsceneManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr, 100675950);
				CutsceneManager.__c__DisplayClass4_0.NativeMethodInfoPtr__Play_b__0_Internal_Boolean_Cutscene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr, 100675951);
			}

			// Token: 0x0600CF4E RID: 53070 RVA: 0x0031CFEC File Offset: 0x0031B1EC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF4F RID: 53071 RVA: 0x0031D028 File Offset: 0x0031B228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Play_b__0(Cutscene c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.__c__DisplayClass4_0.NativeMethodInfoPtr__Play_b__0_Internal_Boolean_Cutscene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CF50 RID: 53072 RVA: 0x00064D8D File Offset: 0x00062F8D
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700406F RID: 16495
			// (get) Token: 0x0600CF51 RID: 53073 RVA: 0x0031D078 File Offset: 0x0031B278
			// (set) Token: 0x0600CF52 RID: 53074 RVA: 0x00064D96 File Offset: 0x00062F96
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.__c__DisplayClass4_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.__c__DisplayClass4_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008BDE RID: 35806
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04008BDF RID: 35807
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BE0 RID: 35808
			private static readonly IntPtr NativeMethodInfoPtr__Play_b__0_Internal_Boolean_Cutscene_0;
		}
	}
}
