using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000366 RID: 870
	public class UnconsciousBehaviour : Behaviour
	{
		// Token: 0x060043C8 RID: 17352 RVA: 0x00150538 File Offset: 0x0014E738
		// Note: this type is marked as 'beforefieldinit'.
		static UnconsciousBehaviour()
		{
			Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "UnconsciousBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr);
			UnconsciousBehaviour.NativeFieldInfoPtr_SnoreInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "SnoreInterval");
			UnconsciousBehaviour.NativeFieldInfoPtr_Particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "Particles");
			UnconsciousBehaviour.NativeFieldInfoPtr_PlaySnoreSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "PlaySnoreSounds");
			UnconsciousBehaviour.NativeFieldInfoPtr_timeOnLastSnore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "timeOnLastSnore");
			UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.UnconsciousBehaviourAssembly-CSharp.dll_Excuted");
			UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.UnconsciousBehaviourAssembly-CSharp.dll_Excuted");
			UnconsciousBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671584);
			UnconsciousBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671585);
			UnconsciousBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671586);
			UnconsciousBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671587);
			UnconsciousBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671588);
			UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671589);
			UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671590);
			UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671591);
			UnconsciousBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671592);
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x00150694 File Offset: 0x0014E894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154548, XrefRangeEnd = 154572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x001506D0 File Offset: 0x0014E8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154572, XrefRangeEnd = 154585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x0015070C File Offset: 0x0014E90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154585, XrefRangeEnd = 154590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043CC RID: 17356 RVA: 0x00150748 File Offset: 0x0014E948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x00150784 File Offset: 0x0014E984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154590, XrefRangeEnd = 154591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnconsciousBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnconsciousBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x001507C0 File Offset: 0x0014E9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x001507FC File Offset: 0x0014E9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x00150838 File Offset: 0x0014EA38
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x00150874 File Offset: 0x0014EA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x00021225 File Offset: 0x0001F425
		public UnconsciousBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x060043D3 RID: 17363 RVA: 0x001508B0 File Offset: 0x0014EAB0
		// (set) Token: 0x060043D4 RID: 17364 RVA: 0x0002122E File Offset: 0x0001F42E
		public unsafe static float SnoreInterval
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UnconsciousBehaviour.NativeFieldInfoPtr_SnoreInterval, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnconsciousBehaviour.NativeFieldInfoPtr_SnoreInterval, (void*)(&value));
			}
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x060043D5 RID: 17365 RVA: 0x001508CC File Offset: 0x0014EACC
		// (set) Token: 0x060043D6 RID: 17366 RVA: 0x0002123C File Offset: 0x0001F43C
		public unsafe ParticleSystem Particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_Particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_Particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x060043D7 RID: 17367 RVA: 0x001508FC File Offset: 0x0014EAFC
		// (set) Token: 0x060043D8 RID: 17368 RVA: 0x0002125B File Offset: 0x0001F45B
		public unsafe bool PlaySnoreSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_PlaySnoreSounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_PlaySnoreSounds)) = value;
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x060043D9 RID: 17369 RVA: 0x00150924 File Offset: 0x0014EB24
		// (set) Token: 0x060043DA RID: 17370 RVA: 0x00021276 File Offset: 0x0001F476
		public unsafe float timeOnLastSnore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_timeOnLastSnore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_timeOnLastSnore)) = value;
			}
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x060043DB RID: 17371 RVA: 0x0015094C File Offset: 0x0014EB4C
		// (set) Token: 0x060043DC RID: 17372 RVA: 0x00021291 File Offset: 0x0001F491
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x060043DD RID: 17373 RVA: 0x00150974 File Offset: 0x0014EB74
		// (set) Token: 0x060043DE RID: 17374 RVA: 0x000212AC File Offset: 0x0001F4AC
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002D62 RID: 11618
		private static readonly IntPtr NativeFieldInfoPtr_SnoreInterval;

		// Token: 0x04002D63 RID: 11619
		private static readonly IntPtr NativeFieldInfoPtr_Particles;

		// Token: 0x04002D64 RID: 11620
		private static readonly IntPtr NativeFieldInfoPtr_PlaySnoreSounds;

		// Token: 0x04002D65 RID: 11621
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLastSnore;

		// Token: 0x04002D66 RID: 11622
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002D67 RID: 11623
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002D68 RID: 11624
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002D69 RID: 11625
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002D6A RID: 11626
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002D6B RID: 11627
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002D6C RID: 11628
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D6D RID: 11629
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002D6E RID: 11630
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002D6F RID: 11631
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002D70 RID: 11632
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
