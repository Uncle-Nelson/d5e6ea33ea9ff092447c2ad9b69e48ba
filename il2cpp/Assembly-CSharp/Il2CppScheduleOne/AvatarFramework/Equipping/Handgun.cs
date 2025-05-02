using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000603 RID: 1539
	public class Handgun : AvatarRangedWeapon
	{
		// Token: 0x060087B2 RID: 34738 RVA: 0x0023CAC0 File Offset: 0x0023ACC0
		// Note: this type is marked as 'beforefieldinit'.
		static Handgun()
		{
			Il2CppClassPointerStore<Handgun>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "Handgun");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Handgun>.NativeClassPtr);
			Handgun.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "Anim");
			Handgun.NativeFieldInfoPtr_ShellParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "ShellParticles");
			Handgun.NativeFieldInfoPtr_SmokeParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "SmokeParticles");
			Handgun.NativeFieldInfoPtr_FlashObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "FlashObject");
			Handgun.NativeFieldInfoPtr_RayPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "RayPrefab");
			Handgun.NativeFieldInfoPtr_flashRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "flashRoutine");
			Handgun.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun>.NativeClassPtr, 100680220);
			Handgun.NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun>.NativeClassPtr, 100680221);
			Handgun.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun>.NativeClassPtr, 100680222);
		}

		// Token: 0x060087B3 RID: 34739 RVA: 0x0023CBA4 File Offset: 0x0023ADA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251969, XrefRangeEnd = 251989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Shoot(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Handgun.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087B4 RID: 34740 RVA: 0x0023CBF0 File Offset: 0x0023ADF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251989, XrefRangeEnd = 251994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Flash(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun.NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060087B5 RID: 34741 RVA: 0x0023CC3C File Offset: 0x0023AE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251994, XrefRangeEnd = 251998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Handgun() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Handgun>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087B6 RID: 34742 RVA: 0x00040A30 File Offset: 0x0003EC30
		public Handgun(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002944 RID: 10564
		// (get) Token: 0x060087B7 RID: 34743 RVA: 0x0023CC78 File Offset: 0x0023AE78
		// (set) Token: 0x060087B8 RID: 34744 RVA: 0x00040A39 File Offset: 0x0003EC39
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002945 RID: 10565
		// (get) Token: 0x060087B9 RID: 34745 RVA: 0x0023CCA8 File Offset: 0x0023AEA8
		// (set) Token: 0x060087BA RID: 34746 RVA: 0x00040A58 File Offset: 0x0003EC58
		public unsafe ParticleSystem ShellParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_ShellParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_ShellParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002946 RID: 10566
		// (get) Token: 0x060087BB RID: 34747 RVA: 0x0023CCD8 File Offset: 0x0023AED8
		// (set) Token: 0x060087BC RID: 34748 RVA: 0x00040A77 File Offset: 0x0003EC77
		public unsafe ParticleSystem SmokeParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_SmokeParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_SmokeParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002947 RID: 10567
		// (get) Token: 0x060087BD RID: 34749 RVA: 0x0023CD08 File Offset: 0x0023AF08
		// (set) Token: 0x060087BE RID: 34750 RVA: 0x00040A96 File Offset: 0x0003EC96
		public unsafe Transform FlashObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_FlashObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_FlashObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002948 RID: 10568
		// (get) Token: 0x060087BF RID: 34751 RVA: 0x0023CD38 File Offset: 0x0023AF38
		// (set) Token: 0x060087C0 RID: 34752 RVA: 0x00040AB5 File Offset: 0x0003ECB5
		public unsafe GameObject RayPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_RayPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_RayPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002949 RID: 10569
		// (get) Token: 0x060087C1 RID: 34753 RVA: 0x0023CD68 File Offset: 0x0023AF68
		// (set) Token: 0x060087C2 RID: 34754 RVA: 0x00040AD4 File Offset: 0x0003ECD4
		public unsafe Coroutine flashRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_flashRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_flashRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005C47 RID: 23623
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04005C48 RID: 23624
		private static readonly IntPtr NativeFieldInfoPtr_ShellParticles;

		// Token: 0x04005C49 RID: 23625
		private static readonly IntPtr NativeFieldInfoPtr_SmokeParticles;

		// Token: 0x04005C4A RID: 23626
		private static readonly IntPtr NativeFieldInfoPtr_FlashObject;

		// Token: 0x04005C4B RID: 23627
		private static readonly IntPtr NativeFieldInfoPtr_RayPrefab;

		// Token: 0x04005C4C RID: 23628
		private static readonly IntPtr NativeFieldInfoPtr_flashRoutine;

		// Token: 0x04005C4D RID: 23629
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Public_Virtual_Void_Vector3_0;

		// Token: 0x04005C4E RID: 23630
		private static readonly IntPtr NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0;

		// Token: 0x04005C4F RID: 23631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AFA RID: 2810
		[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.Handgun+<Flash>d__7")]
		public sealed class _Flash_d__7 : Il2CppSystem.Object
		{
			// Token: 0x0600D603 RID: 54787 RVA: 0x0032F99C File Offset: 0x0032DB9C
			// Note: this type is marked as 'beforefieldinit'.
			static _Flash_d__7()
			{
				Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "<Flash>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr);
				Handgun._Flash_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, "<>1__state");
				Handgun._Flash_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, "<>2__current");
				Handgun._Flash_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, "<>4__this");
				Handgun._Flash_d__7.NativeFieldInfoPtr_endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, "endPoint");
				Handgun._Flash_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, 100680223);
				Handgun._Flash_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, 100680224);
				Handgun._Flash_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, 100680225);
				Handgun._Flash_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, 100680226);
				Handgun._Flash_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, 100680227);
				Handgun._Flash_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, 100680228);
			}

			// Token: 0x0600D604 RID: 54788 RVA: 0x0032FA90 File Offset: 0x0032DC90
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Flash_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun._Flash_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D605 RID: 54789 RVA: 0x0032FAD8 File Offset: 0x0032DCD8
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun._Flash_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D606 RID: 54790 RVA: 0x0032FB0C File Offset: 0x0032DD0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251926, XrefRangeEnd = 251964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun._Flash_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004257 RID: 16983
			// (get) Token: 0x0600D607 RID: 54791 RVA: 0x0032FB48 File Offset: 0x0032DD48
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun._Flash_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D608 RID: 54792 RVA: 0x0032FB88 File Offset: 0x0032DD88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251964, XrefRangeEnd = 251969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun._Flash_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004258 RID: 16984
			// (get) Token: 0x0600D609 RID: 54793 RVA: 0x0032FBBC File Offset: 0x0032DDBC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun._Flash_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D60A RID: 54794 RVA: 0x00068280 File Offset: 0x00066480
			public _Flash_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004253 RID: 16979
			// (get) Token: 0x0600D60B RID: 54795 RVA: 0x0032FBFC File Offset: 0x0032DDFC
			// (set) Token: 0x0600D60C RID: 54796 RVA: 0x00068289 File Offset: 0x00066489
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004254 RID: 16980
			// (get) Token: 0x0600D60D RID: 54797 RVA: 0x0032FC24 File Offset: 0x0032DE24
			// (set) Token: 0x0600D60E RID: 54798 RVA: 0x000682A4 File Offset: 0x000664A4
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004255 RID: 16981
			// (get) Token: 0x0600D60F RID: 54799 RVA: 0x0032FC54 File Offset: 0x0032DE54
			// (set) Token: 0x0600D610 RID: 54800 RVA: 0x000682C3 File Offset: 0x000664C3
			public unsafe Handgun __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Handgun>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004256 RID: 16982
			// (get) Token: 0x0600D611 RID: 54801 RVA: 0x0032FC84 File Offset: 0x0032DE84
			// (set) Token: 0x0600D612 RID: 54802 RVA: 0x000682E2 File Offset: 0x000664E2
			public unsafe Vector3 endPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr_endPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr_endPoint)) = value;
				}
			}

			// Token: 0x04008FF3 RID: 36851
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008FF4 RID: 36852
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008FF5 RID: 36853
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FF6 RID: 36854
			private static readonly IntPtr NativeFieldInfoPtr_endPoint;

			// Token: 0x04008FF7 RID: 36855
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008FF8 RID: 36856
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FF9 RID: 36857
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008FFA RID: 36858
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008FFB RID: 36859
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FFC RID: 36860
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
