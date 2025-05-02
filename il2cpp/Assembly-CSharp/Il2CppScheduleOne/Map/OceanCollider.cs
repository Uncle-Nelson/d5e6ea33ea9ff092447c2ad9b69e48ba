using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000782 RID: 1922
	public class OceanCollider : MonoBehaviour
	{
		// Token: 0x0600B5E8 RID: 46568 RVA: 0x002D3480 File Offset: 0x002D1680
		// Note: this type is marked as 'beforefieldinit'.
		static OceanCollider()
		{
			Il2CppClassPointerStore<OceanCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "OceanCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr);
			OceanCollider.NativeFieldInfoPtr_localPlayerBeingWarped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, "localPlayerBeingWarped");
			OceanCollider.NativeFieldInfoPtr_warpedVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, "warpedVehicles");
			OceanCollider.NativeFieldInfoPtr_SplashSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, "SplashSound");
			OceanCollider.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, 100685654);
			OceanCollider.NativeMethodInfoPtr_WarpPlayer_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, 100685655);
			OceanCollider.NativeMethodInfoPtr_WarpVehicle_Private_IEnumerator_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, 100685656);
			OceanCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, 100685657);
		}

		// Token: 0x0600B5E9 RID: 46569 RVA: 0x002D353C File Offset: 0x002D173C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310940, XrefRangeEnd = 311010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5EA RID: 46570 RVA: 0x002D3580 File Offset: 0x002D1780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311010, XrefRangeEnd = 311015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WarpPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider.NativeMethodInfoPtr_WarpPlayer_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B5EB RID: 46571 RVA: 0x002D35C0 File Offset: 0x002D17C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311015, XrefRangeEnd = 311021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WarpVehicle(LandVehicle veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider.NativeMethodInfoPtr_WarpVehicle_Private_IEnumerator_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B5EC RID: 46572 RVA: 0x002D3610 File Offset: 0x002D1810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311021, XrefRangeEnd = 311029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OceanCollider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5ED RID: 46573 RVA: 0x00059473 File Offset: 0x00057673
		public OceanCollider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003863 RID: 14435
		// (get) Token: 0x0600B5EE RID: 46574 RVA: 0x002D364C File Offset: 0x002D184C
		// (set) Token: 0x0600B5EF RID: 46575 RVA: 0x0005947C File Offset: 0x0005767C
		public unsafe bool localPlayerBeingWarped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider.NativeFieldInfoPtr_localPlayerBeingWarped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider.NativeFieldInfoPtr_localPlayerBeingWarped)) = value;
			}
		}

		// Token: 0x17003864 RID: 14436
		// (get) Token: 0x0600B5F0 RID: 46576 RVA: 0x002D3674 File Offset: 0x002D1874
		// (set) Token: 0x0600B5F1 RID: 46577 RVA: 0x00059497 File Offset: 0x00057697
		public unsafe List<LandVehicle> warpedVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider.NativeFieldInfoPtr_warpedVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider.NativeFieldInfoPtr_warpedVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003865 RID: 14437
		// (get) Token: 0x0600B5F2 RID: 46578 RVA: 0x002D36A4 File Offset: 0x002D18A4
		// (set) Token: 0x0600B5F3 RID: 46579 RVA: 0x000594B6 File Offset: 0x000576B6
		public unsafe AudioSourceController SplashSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider.NativeFieldInfoPtr_SplashSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider.NativeFieldInfoPtr_SplashSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A91 RID: 31377
		private static readonly IntPtr NativeFieldInfoPtr_localPlayerBeingWarped;

		// Token: 0x04007A92 RID: 31378
		private static readonly IntPtr NativeFieldInfoPtr_warpedVehicles;

		// Token: 0x04007A93 RID: 31379
		private static readonly IntPtr NativeFieldInfoPtr_SplashSound;

		// Token: 0x04007A94 RID: 31380
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x04007A95 RID: 31381
		private static readonly IntPtr NativeMethodInfoPtr_WarpPlayer_Private_IEnumerator_0;

		// Token: 0x04007A96 RID: 31382
		private static readonly IntPtr NativeMethodInfoPtr_WarpVehicle_Private_IEnumerator_LandVehicle_0;

		// Token: 0x04007A97 RID: 31383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C00 RID: 3072
		[ObfuscatedName("ScheduleOne.Map.OceanCollider+<WarpPlayer>d__4")]
		public sealed class _WarpPlayer_d__4 : Il2CppSystem.Object
		{
			// Token: 0x0600DFFD RID: 57341 RVA: 0x0034C190 File Offset: 0x0034A390
			// Note: this type is marked as 'beforefieldinit'.
			static _WarpPlayer_d__4()
			{
				Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, "<WarpPlayer>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr);
				OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, "<>1__state");
				OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, "<>2__current");
				OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, "<>4__this");
				OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, 100685658);
				OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, 100685659);
				OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, 100685660);
				OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, 100685661);
				OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, 100685662);
				OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, 100685663);
			}

			// Token: 0x0600DFFE RID: 57342 RVA: 0x0034C270 File Offset: 0x0034A470
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WarpPlayer_d__4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFFF RID: 57343 RVA: 0x0034C2B8 File Offset: 0x0034A4B8
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E000 RID: 57344 RVA: 0x0034C2EC File Offset: 0x0034A4EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310882, XrefRangeEnd = 310888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004569 RID: 17769
			// (get) Token: 0x0600E001 RID: 57345 RVA: 0x0034C328 File Offset: 0x0034A528
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E002 RID: 57346 RVA: 0x0034C368 File Offset: 0x0034A568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310888, XrefRangeEnd = 310893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700456A RID: 17770
			// (get) Token: 0x0600E003 RID: 57347 RVA: 0x0034C39C File Offset: 0x0034A59C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E004 RID: 57348 RVA: 0x0006D36C File Offset: 0x0006B56C
			public _WarpPlayer_d__4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004566 RID: 17766
			// (get) Token: 0x0600E005 RID: 57349 RVA: 0x0034C3DC File Offset: 0x0034A5DC
			// (set) Token: 0x0600E006 RID: 57350 RVA: 0x0006D375 File Offset: 0x0006B575
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004567 RID: 17767
			// (get) Token: 0x0600E007 RID: 57351 RVA: 0x0034C404 File Offset: 0x0034A604
			// (set) Token: 0x0600E008 RID: 57352 RVA: 0x0006D390 File Offset: 0x0006B590
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004568 RID: 17768
			// (get) Token: 0x0600E009 RID: 57353 RVA: 0x0034C434 File Offset: 0x0034A634
			// (set) Token: 0x0600E00A RID: 57354 RVA: 0x0006D3AF File Offset: 0x0006B5AF
			public unsafe OceanCollider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OceanCollider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095FE RID: 38398
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040095FF RID: 38399
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009600 RID: 38400
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009601 RID: 38401
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009602 RID: 38402
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009603 RID: 38403
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009604 RID: 38404
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009605 RID: 38405
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009606 RID: 38406
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C01 RID: 3073
		[ObfuscatedName("ScheduleOne.Map.OceanCollider+<WarpVehicle>d__5")]
		public sealed class _WarpVehicle_d__5 : Il2CppSystem.Object
		{
			// Token: 0x0600E00B RID: 57355 RVA: 0x0034C464 File Offset: 0x0034A664
			// Note: this type is marked as 'beforefieldinit'.
			static _WarpVehicle_d__5()
			{
				Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, "<WarpVehicle>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr);
				OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, "<>1__state");
				OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, "<>2__current");
				OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr_veh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, "veh");
				OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, "<>4__this");
				OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr__faded_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, "<faded>5__2");
				OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, 100685664);
				OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, 100685665);
				OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, 100685666);
				OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, 100685667);
				OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, 100685668);
				OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, 100685669);
			}

			// Token: 0x0600E00C RID: 57356 RVA: 0x0034C56C File Offset: 0x0034A76C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WarpVehicle_d__5(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E00D RID: 57357 RVA: 0x0034C5B4 File Offset: 0x0034A7B4
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E00E RID: 57358 RVA: 0x0034C5E8 File Offset: 0x0034A7E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310893, XrefRangeEnd = 310935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004570 RID: 17776
			// (get) Token: 0x0600E00F RID: 57359 RVA: 0x0034C624 File Offset: 0x0034A824
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E010 RID: 57360 RVA: 0x0034C664 File Offset: 0x0034A864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310935, XrefRangeEnd = 310940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004571 RID: 17777
			// (get) Token: 0x0600E011 RID: 57361 RVA: 0x0034C698 File Offset: 0x0034A898
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E012 RID: 57362 RVA: 0x0006D3CE File Offset: 0x0006B5CE
			public _WarpVehicle_d__5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700456B RID: 17771
			// (get) Token: 0x0600E013 RID: 57363 RVA: 0x0034C6D8 File Offset: 0x0034A8D8
			// (set) Token: 0x0600E014 RID: 57364 RVA: 0x0006D3D7 File Offset: 0x0006B5D7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700456C RID: 17772
			// (get) Token: 0x0600E015 RID: 57365 RVA: 0x0034C700 File Offset: 0x0034A900
			// (set) Token: 0x0600E016 RID: 57366 RVA: 0x0006D3F2 File Offset: 0x0006B5F2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700456D RID: 17773
			// (get) Token: 0x0600E017 RID: 57367 RVA: 0x0034C730 File Offset: 0x0034A930
			// (set) Token: 0x0600E018 RID: 57368 RVA: 0x0006D411 File Offset: 0x0006B611
			public unsafe LandVehicle veh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr_veh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr_veh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700456E RID: 17774
			// (get) Token: 0x0600E019 RID: 57369 RVA: 0x0034C760 File Offset: 0x0034A960
			// (set) Token: 0x0600E01A RID: 57370 RVA: 0x0006D430 File Offset: 0x0006B630
			public unsafe OceanCollider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OceanCollider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700456F RID: 17775
			// (get) Token: 0x0600E01B RID: 57371 RVA: 0x0034C790 File Offset: 0x0034A990
			// (set) Token: 0x0600E01C RID: 57372 RVA: 0x0006D44F File Offset: 0x0006B64F
			public unsafe bool _faded_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr__faded_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr__faded_5__2)) = value;
				}
			}

			// Token: 0x04009607 RID: 38407
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009608 RID: 38408
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009609 RID: 38409
			private static readonly IntPtr NativeFieldInfoPtr_veh;

			// Token: 0x0400960A RID: 38410
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400960B RID: 38411
			private static readonly IntPtr NativeFieldInfoPtr__faded_5__2;

			// Token: 0x0400960C RID: 38412
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400960D RID: 38413
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400960E RID: 38414
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400960F RID: 38415
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009610 RID: 38416
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009611 RID: 38417
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
