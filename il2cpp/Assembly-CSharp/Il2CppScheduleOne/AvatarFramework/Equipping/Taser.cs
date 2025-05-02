using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000604 RID: 1540
	public class Taser : AvatarRangedWeapon
	{
		// Token: 0x060087C3 RID: 34755 RVA: 0x0023CD98 File Offset: 0x0023AF98
		// Note: this type is marked as 'beforefieldinit'.
		static Taser()
		{
			Il2CppClassPointerStore<Taser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "Taser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Taser>.NativeClassPtr);
			Taser.NativeFieldInfoPtr_TaseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "TaseDuration");
			Taser.NativeFieldInfoPtr_TaseMoveSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "TaseMoveSpeedMultiplier");
			Taser.NativeFieldInfoPtr_FlashObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "FlashObject");
			Taser.NativeFieldInfoPtr_ChargeSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "ChargeSound");
			Taser.NativeFieldInfoPtr_RayPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "RayPrefab");
			Taser.NativeFieldInfoPtr_flashRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "flashRoutine");
			Taser.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100680229);
			Taser.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100680230);
			Taser.NativeMethodInfoPtr_SetIsRaised_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100680231);
			Taser.NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100680232);
			Taser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100680233);
		}

		// Token: 0x060087C4 RID: 34756 RVA: 0x0023CEA4 File Offset: 0x0023B0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252039, XrefRangeEnd = 252050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(Avatar _avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Taser.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087C5 RID: 34757 RVA: 0x0023CEF4 File Offset: 0x0023B0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252050, XrefRangeEnd = 252061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Shoot(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Taser.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087C6 RID: 34758 RVA: 0x0023CF40 File Offset: 0x0023B140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252061, XrefRangeEnd = 252067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetIsRaised(bool raised)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref raised;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Taser.NativeMethodInfoPtr_SetIsRaised_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087C7 RID: 34759 RVA: 0x0023CF8C File Offset: 0x0023B18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252067, XrefRangeEnd = 252072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Flash(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser.NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060087C8 RID: 34760 RVA: 0x0023CFD8 File Offset: 0x0023B1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252072, XrefRangeEnd = 252076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Taser() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Taser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087C9 RID: 34761 RVA: 0x00040AF3 File Offset: 0x0003ECF3
		public Taser(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700294A RID: 10570
		// (get) Token: 0x060087CA RID: 34762 RVA: 0x0023D014 File Offset: 0x0023B214
		// (set) Token: 0x060087CB RID: 34763 RVA: 0x00040AFC File Offset: 0x0003ECFC
		public unsafe static float TaseDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Taser.NativeFieldInfoPtr_TaseDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Taser.NativeFieldInfoPtr_TaseDuration, (void*)(&value));
			}
		}

		// Token: 0x1700294B RID: 10571
		// (get) Token: 0x060087CC RID: 34764 RVA: 0x0023D030 File Offset: 0x0023B230
		// (set) Token: 0x060087CD RID: 34765 RVA: 0x00040B0A File Offset: 0x0003ED0A
		public unsafe static float TaseMoveSpeedMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Taser.NativeFieldInfoPtr_TaseMoveSpeedMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Taser.NativeFieldInfoPtr_TaseMoveSpeedMultiplier, (void*)(&value));
			}
		}

		// Token: 0x1700294C RID: 10572
		// (get) Token: 0x060087CE RID: 34766 RVA: 0x0023D04C File Offset: 0x0023B24C
		// (set) Token: 0x060087CF RID: 34767 RVA: 0x00040B18 File Offset: 0x0003ED18
		public unsafe GameObject FlashObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_FlashObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_FlashObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700294D RID: 10573
		// (get) Token: 0x060087D0 RID: 34768 RVA: 0x0023D07C File Offset: 0x0023B27C
		// (set) Token: 0x060087D1 RID: 34769 RVA: 0x00040B37 File Offset: 0x0003ED37
		public unsafe AudioSourceController ChargeSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_ChargeSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_ChargeSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700294E RID: 10574
		// (get) Token: 0x060087D2 RID: 34770 RVA: 0x0023D0AC File Offset: 0x0023B2AC
		// (set) Token: 0x060087D3 RID: 34771 RVA: 0x00040B56 File Offset: 0x0003ED56
		public unsafe GameObject RayPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_RayPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_RayPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700294F RID: 10575
		// (get) Token: 0x060087D4 RID: 34772 RVA: 0x0023D0DC File Offset: 0x0023B2DC
		// (set) Token: 0x060087D5 RID: 34773 RVA: 0x00040B75 File Offset: 0x0003ED75
		public unsafe Coroutine flashRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_flashRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_flashRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005C50 RID: 23632
		private static readonly IntPtr NativeFieldInfoPtr_TaseDuration;

		// Token: 0x04005C51 RID: 23633
		private static readonly IntPtr NativeFieldInfoPtr_TaseMoveSpeedMultiplier;

		// Token: 0x04005C52 RID: 23634
		private static readonly IntPtr NativeFieldInfoPtr_FlashObject;

		// Token: 0x04005C53 RID: 23635
		private static readonly IntPtr NativeFieldInfoPtr_ChargeSound;

		// Token: 0x04005C54 RID: 23636
		private static readonly IntPtr NativeFieldInfoPtr_RayPrefab;

		// Token: 0x04005C55 RID: 23637
		private static readonly IntPtr NativeFieldInfoPtr_flashRoutine;

		// Token: 0x04005C56 RID: 23638
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0;

		// Token: 0x04005C57 RID: 23639
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Public_Virtual_Void_Vector3_0;

		// Token: 0x04005C58 RID: 23640
		private static readonly IntPtr NativeMethodInfoPtr_SetIsRaised_Public_Virtual_Void_Boolean_0;

		// Token: 0x04005C59 RID: 23641
		private static readonly IntPtr NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0;

		// Token: 0x04005C5A RID: 23642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AFB RID: 2811
		[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.Taser+<Flash>d__9")]
		public sealed class _Flash_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600D613 RID: 54803 RVA: 0x0032FCAC File Offset: 0x0032DEAC
			// Note: this type is marked as 'beforefieldinit'.
			static _Flash_d__9()
			{
				Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Taser>.NativeClassPtr, "<Flash>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr);
				Taser._Flash_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, "<>1__state");
				Taser._Flash_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, "<>2__current");
				Taser._Flash_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, "<>4__this");
				Taser._Flash_d__9.NativeFieldInfoPtr_endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, "endPoint");
				Taser._Flash_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, 100680234);
				Taser._Flash_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, 100680235);
				Taser._Flash_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, 100680236);
				Taser._Flash_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, 100680237);
				Taser._Flash_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, 100680238);
				Taser._Flash_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, 100680239);
			}

			// Token: 0x0600D614 RID: 54804 RVA: 0x0032FDA0 File Offset: 0x0032DFA0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Flash_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D615 RID: 54805 RVA: 0x0032FDE8 File Offset: 0x0032DFE8
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D616 RID: 54806 RVA: 0x0032FE1C File Offset: 0x0032E01C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251998, XrefRangeEnd = 252034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700425D RID: 16989
			// (get) Token: 0x0600D617 RID: 54807 RVA: 0x0032FE58 File Offset: 0x0032E058
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D618 RID: 54808 RVA: 0x0032FE98 File Offset: 0x0032E098
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252034, XrefRangeEnd = 252039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700425E RID: 16990
			// (get) Token: 0x0600D619 RID: 54809 RVA: 0x0032FECC File Offset: 0x0032E0CC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D61A RID: 54810 RVA: 0x000682FD File Offset: 0x000664FD
			public _Flash_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004259 RID: 16985
			// (get) Token: 0x0600D61B RID: 54811 RVA: 0x0032FF0C File Offset: 0x0032E10C
			// (set) Token: 0x0600D61C RID: 54812 RVA: 0x00068306 File Offset: 0x00066506
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700425A RID: 16986
			// (get) Token: 0x0600D61D RID: 54813 RVA: 0x0032FF34 File Offset: 0x0032E134
			// (set) Token: 0x0600D61E RID: 54814 RVA: 0x00068321 File Offset: 0x00066521
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700425B RID: 16987
			// (get) Token: 0x0600D61F RID: 54815 RVA: 0x0032FF64 File Offset: 0x0032E164
			// (set) Token: 0x0600D620 RID: 54816 RVA: 0x00068340 File Offset: 0x00066540
			public unsafe Taser __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Taser>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700425C RID: 16988
			// (get) Token: 0x0600D621 RID: 54817 RVA: 0x0032FF94 File Offset: 0x0032E194
			// (set) Token: 0x0600D622 RID: 54818 RVA: 0x0006835F File Offset: 0x0006655F
			public unsafe Vector3 endPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr_endPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr_endPoint)) = value;
				}
			}

			// Token: 0x04008FFD RID: 36861
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008FFE RID: 36862
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008FFF RID: 36863
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009000 RID: 36864
			private static readonly IntPtr NativeFieldInfoPtr_endPoint;

			// Token: 0x04009001 RID: 36865
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009002 RID: 36866
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009003 RID: 36867
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009004 RID: 36868
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009005 RID: 36869
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009006 RID: 36870
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
