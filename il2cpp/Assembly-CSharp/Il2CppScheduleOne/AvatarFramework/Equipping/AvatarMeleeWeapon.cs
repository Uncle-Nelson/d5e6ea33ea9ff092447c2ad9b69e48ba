using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000600 RID: 1536
	public class AvatarMeleeWeapon : AvatarWeapon
	{
		// Token: 0x06008750 RID: 34640 RVA: 0x0023BAB4 File Offset: 0x00239CB4
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarMeleeWeapon()
		{
			Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarMeleeWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr);
			AvatarMeleeWeapon.NativeFieldInfoPtr_GruntChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "GruntChance");
			AvatarMeleeWeapon.NativeFieldInfoPtr_AttackSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "AttackSound");
			AvatarMeleeWeapon.NativeFieldInfoPtr_HitSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "HitSound");
			AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "AttackRange");
			AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "AttackRadius");
			AvatarMeleeWeapon.NativeFieldInfoPtr_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "Damage");
			AvatarMeleeWeapon.NativeFieldInfoPtr_Attacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "Attacks");
			AvatarMeleeWeapon.NativeFieldInfoPtr_attackRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "attackRoutine");
			AvatarMeleeWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, 100680184);
			AvatarMeleeWeapon.NativeMethodInfoPtr_Attack_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, 100680185);
			AvatarMeleeWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, 100680186);
		}

		// Token: 0x06008751 RID: 34641 RVA: 0x0023BBC0 File Offset: 0x00239DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251757, XrefRangeEnd = 251769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarMeleeWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008752 RID: 34642 RVA: 0x0023BBFC File Offset: 0x00239DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251769, XrefRangeEnd = 251794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Attack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarMeleeWeapon.NativeMethodInfoPtr_Attack_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008753 RID: 34643 RVA: 0x0023BC38 File Offset: 0x00239E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251794, XrefRangeEnd = 251795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarMeleeWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008754 RID: 34644 RVA: 0x0004062F File Offset: 0x0003E82F
		public AvatarMeleeWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700291E RID: 10526
		// (get) Token: 0x06008755 RID: 34645 RVA: 0x0023BC74 File Offset: 0x00239E74
		// (set) Token: 0x06008756 RID: 34646 RVA: 0x00040638 File Offset: 0x0003E838
		public unsafe static float GruntChance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarMeleeWeapon.NativeFieldInfoPtr_GruntChance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarMeleeWeapon.NativeFieldInfoPtr_GruntChance, (void*)(&value));
			}
		}

		// Token: 0x1700291F RID: 10527
		// (get) Token: 0x06008757 RID: 34647 RVA: 0x0023BC90 File Offset: 0x00239E90
		// (set) Token: 0x06008758 RID: 34648 RVA: 0x00040646 File Offset: 0x0003E846
		public unsafe AudioSourceController AttackSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002920 RID: 10528
		// (get) Token: 0x06008759 RID: 34649 RVA: 0x0023BCC0 File Offset: 0x00239EC0
		// (set) Token: 0x0600875A RID: 34650 RVA: 0x00040665 File Offset: 0x0003E865
		public unsafe AudioSourceController HitSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_HitSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_HitSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002921 RID: 10529
		// (get) Token: 0x0600875B RID: 34651 RVA: 0x0023BCF0 File Offset: 0x00239EF0
		// (set) Token: 0x0600875C RID: 34652 RVA: 0x00040684 File Offset: 0x0003E884
		public unsafe float AttackRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRange)) = value;
			}
		}

		// Token: 0x17002922 RID: 10530
		// (get) Token: 0x0600875D RID: 34653 RVA: 0x0023BD18 File Offset: 0x00239F18
		// (set) Token: 0x0600875E RID: 34654 RVA: 0x0004069F File Offset: 0x0003E89F
		public unsafe float AttackRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRadius)) = value;
			}
		}

		// Token: 0x17002923 RID: 10531
		// (get) Token: 0x0600875F RID: 34655 RVA: 0x0023BD40 File Offset: 0x00239F40
		// (set) Token: 0x06008760 RID: 34656 RVA: 0x000406BA File Offset: 0x0003E8BA
		public unsafe float Damage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_Damage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_Damage)) = value;
			}
		}

		// Token: 0x17002924 RID: 10532
		// (get) Token: 0x06008761 RID: 34657 RVA: 0x0023BD68 File Offset: 0x00239F68
		// (set) Token: 0x06008762 RID: 34658 RVA: 0x000406D5 File Offset: 0x0003E8D5
		public unsafe Il2CppReferenceArray<AvatarMeleeWeapon.MeleeAttack> Attacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_Attacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarMeleeWeapon.MeleeAttack>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_Attacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002925 RID: 10533
		// (get) Token: 0x06008763 RID: 34659 RVA: 0x0023BD98 File Offset: 0x00239F98
		// (set) Token: 0x06008764 RID: 34660 RVA: 0x000406F4 File Offset: 0x0003E8F4
		public unsafe Coroutine attackRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_attackRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_attackRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005C0F RID: 23567
		private static readonly IntPtr NativeFieldInfoPtr_GruntChance;

		// Token: 0x04005C10 RID: 23568
		private static readonly IntPtr NativeFieldInfoPtr_AttackSound;

		// Token: 0x04005C11 RID: 23569
		private static readonly IntPtr NativeFieldInfoPtr_HitSound;

		// Token: 0x04005C12 RID: 23570
		private static readonly IntPtr NativeFieldInfoPtr_AttackRange;

		// Token: 0x04005C13 RID: 23571
		private static readonly IntPtr NativeFieldInfoPtr_AttackRadius;

		// Token: 0x04005C14 RID: 23572
		private static readonly IntPtr NativeFieldInfoPtr_Damage;

		// Token: 0x04005C15 RID: 23573
		private static readonly IntPtr NativeFieldInfoPtr_Attacks;

		// Token: 0x04005C16 RID: 23574
		private static readonly IntPtr NativeFieldInfoPtr_attackRoutine;

		// Token: 0x04005C17 RID: 23575
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005C18 RID: 23576
		private static readonly IntPtr NativeMethodInfoPtr_Attack_Public_Virtual_Void_0;

		// Token: 0x04005C19 RID: 23577
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AF7 RID: 2807
		[Serializable]
		public class MeleeAttack : Il2CppSystem.Object
		{
			// Token: 0x0600D5DA RID: 54746 RVA: 0x0032F2FC File Offset: 0x0032D4FC
			// Note: this type is marked as 'beforefieldinit'.
			static MeleeAttack()
			{
				Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "MeleeAttack");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr);
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_RangeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "RangeMultiplier");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "DamageMultiplier");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "AnimationTrigger");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "DamageDelay");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackSoundDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "AttackSoundDelay");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "AttackClips");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_HitClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "HitClips");
				AvatarMeleeWeapon.MeleeAttack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, 100680187);
			}

			// Token: 0x0600D5DB RID: 54747 RVA: 0x0032F3C8 File Offset: 0x0032D5C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251717, XrefRangeEnd = 251721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeleeAttack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.MeleeAttack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5DC RID: 54748 RVA: 0x000680E6 File Offset: 0x000662E6
			public MeleeAttack(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004244 RID: 16964
			// (get) Token: 0x0600D5DD RID: 54749 RVA: 0x0032F404 File Offset: 0x0032D604
			// (set) Token: 0x0600D5DE RID: 54750 RVA: 0x000680EF File Offset: 0x000662EF
			public unsafe float RangeMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_RangeMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_RangeMultiplier)) = value;
				}
			}

			// Token: 0x17004245 RID: 16965
			// (get) Token: 0x0600D5DF RID: 54751 RVA: 0x0032F42C File Offset: 0x0032D62C
			// (set) Token: 0x0600D5E0 RID: 54752 RVA: 0x0006810A File Offset: 0x0006630A
			public unsafe float DamageMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageMultiplier)) = value;
				}
			}

			// Token: 0x17004246 RID: 16966
			// (get) Token: 0x0600D5E1 RID: 54753 RVA: 0x0032F454 File Offset: 0x0032D654
			// (set) Token: 0x0600D5E2 RID: 54754 RVA: 0x00068125 File Offset: 0x00066325
			public unsafe string AnimationTrigger
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AnimationTrigger);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004247 RID: 16967
			// (get) Token: 0x0600D5E3 RID: 54755 RVA: 0x0032F47C File Offset: 0x0032D67C
			// (set) Token: 0x0600D5E4 RID: 54756 RVA: 0x00068144 File Offset: 0x00066344
			public unsafe float DamageDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageDelay)) = value;
				}
			}

			// Token: 0x17004248 RID: 16968
			// (get) Token: 0x0600D5E5 RID: 54757 RVA: 0x0032F4A4 File Offset: 0x0032D6A4
			// (set) Token: 0x0600D5E6 RID: 54758 RVA: 0x0006815F File Offset: 0x0006635F
			public unsafe float AttackSoundDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackSoundDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackSoundDelay)) = value;
				}
			}

			// Token: 0x17004249 RID: 16969
			// (get) Token: 0x0600D5E7 RID: 54759 RVA: 0x0032F4CC File Offset: 0x0032D6CC
			// (set) Token: 0x0600D5E8 RID: 54760 RVA: 0x0006817A File Offset: 0x0006637A
			public unsafe Il2CppReferenceArray<AudioClip> AttackClips
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackClips);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackClips), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700424A RID: 16970
			// (get) Token: 0x0600D5E9 RID: 54761 RVA: 0x0032F4FC File Offset: 0x0032D6FC
			// (set) Token: 0x0600D5EA RID: 54762 RVA: 0x00068199 File Offset: 0x00066399
			public unsafe Il2CppReferenceArray<AudioClip> HitClips
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_HitClips);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_HitClips), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FDD RID: 36829
			private static readonly IntPtr NativeFieldInfoPtr_RangeMultiplier;

			// Token: 0x04008FDE RID: 36830
			private static readonly IntPtr NativeFieldInfoPtr_DamageMultiplier;

			// Token: 0x04008FDF RID: 36831
			private static readonly IntPtr NativeFieldInfoPtr_AnimationTrigger;

			// Token: 0x04008FE0 RID: 36832
			private static readonly IntPtr NativeFieldInfoPtr_DamageDelay;

			// Token: 0x04008FE1 RID: 36833
			private static readonly IntPtr NativeFieldInfoPtr_AttackSoundDelay;

			// Token: 0x04008FE2 RID: 36834
			private static readonly IntPtr NativeFieldInfoPtr_AttackClips;

			// Token: 0x04008FE3 RID: 36835
			private static readonly IntPtr NativeFieldInfoPtr_HitClips;

			// Token: 0x04008FE4 RID: 36836
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AF8 RID: 2808
		[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.AvatarMeleeWeapon+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D5EB RID: 54763 RVA: 0x0032F52C File Offset: 0x0032D72C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr);
				AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr_attack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr, "attack");
				AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr, "npc");
				AvatarMeleeWeapon.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr, 100680188);
				AvatarMeleeWeapon.__c__DisplayClass10_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr, 100680189);
			}

			// Token: 0x0600D5EC RID: 54764 RVA: 0x0032F5BC File Offset: 0x0032D7BC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5ED RID: 54765 RVA: 0x0032F5F8 File Offset: 0x0032D7F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251752, XrefRangeEnd = 251757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D5EE RID: 54766 RVA: 0x000681B8 File Offset: 0x000663B8
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700424B RID: 16971
			// (get) Token: 0x0600D5EF RID: 54767 RVA: 0x0032F638 File Offset: 0x0032D838
			// (set) Token: 0x0600D5F0 RID: 54768 RVA: 0x000681C1 File Offset: 0x000663C1
			public unsafe AvatarMeleeWeapon.MeleeAttack attack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr_attack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarMeleeWeapon.MeleeAttack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr_attack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700424C RID: 16972
			// (get) Token: 0x0600D5F1 RID: 54769 RVA: 0x0032F668 File Offset: 0x0032D868
			// (set) Token: 0x0600D5F2 RID: 54770 RVA: 0x000681E0 File Offset: 0x000663E0
			public unsafe AvatarMeleeWeapon __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarMeleeWeapon>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700424D RID: 16973
			// (get) Token: 0x0600D5F3 RID: 54771 RVA: 0x0032F698 File Offset: 0x0032D898
			// (set) Token: 0x0600D5F4 RID: 54772 RVA: 0x000681FF File Offset: 0x000663FF
			public unsafe NPC npc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr_npc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FE5 RID: 36837
			private static readonly IntPtr NativeFieldInfoPtr_attack;

			// Token: 0x04008FE6 RID: 36838
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FE7 RID: 36839
			private static readonly IntPtr NativeFieldInfoPtr_npc;

			// Token: 0x04008FE8 RID: 36840
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FE9 RID: 36841
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C69 RID: 3177
			[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.AvatarMeleeWeapon+<>c__DisplayClass10_0+<<Attack>g__AttackRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E4A9 RID: 58537 RVA: 0x00359CA0 File Offset: 0x00357EA0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr, "<<Attack>g__AttackRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680190);
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680191);
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680192);
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680193);
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680194);
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680195);
				}

				// Token: 0x0600E4AA RID: 58538 RVA: 0x00359D80 File Offset: 0x00357F80
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4AB RID: 58539 RVA: 0x00359DC8 File Offset: 0x00357FC8
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4AC RID: 58540 RVA: 0x00359DFC File Offset: 0x00357FFC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251721, XrefRangeEnd = 251747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700470A RID: 18186
				// (get) Token: 0x0600E4AD RID: 58541 RVA: 0x00359E38 File Offset: 0x00358038
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4AE RID: 58542 RVA: 0x00359E78 File Offset: 0x00358078
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251747, XrefRangeEnd = 251752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700470B RID: 18187
				// (get) Token: 0x0600E4AF RID: 58543 RVA: 0x00359EAC File Offset: 0x003580AC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4B0 RID: 58544 RVA: 0x0006F7DA File Offset: 0x0006D9DA
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004707 RID: 18183
				// (get) Token: 0x0600E4B1 RID: 58545 RVA: 0x00359EEC File Offset: 0x003580EC
				// (set) Token: 0x0600E4B2 RID: 58546 RVA: 0x0006F7E3 File Offset: 0x0006D9E3
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004708 RID: 18184
				// (get) Token: 0x0600E4B3 RID: 58547 RVA: 0x00359F14 File Offset: 0x00358114
				// (set) Token: 0x0600E4B4 RID: 58548 RVA: 0x0006F7FE File Offset: 0x0006D9FE
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004709 RID: 18185
				// (get) Token: 0x0600E4B5 RID: 58549 RVA: 0x00359F44 File Offset: 0x00358144
				// (set) Token: 0x0600E4B6 RID: 58550 RVA: 0x0006F81D File Offset: 0x0006DA1D
				public unsafe AvatarMeleeWeapon.__c__DisplayClass10_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarMeleeWeapon.__c__DisplayClass10_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040098F2 RID: 39154
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040098F3 RID: 39155
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040098F4 RID: 39156
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040098F5 RID: 39157
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040098F6 RID: 39158
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098F7 RID: 39159
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040098F8 RID: 39160
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040098F9 RID: 39161
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098FA RID: 39162
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
