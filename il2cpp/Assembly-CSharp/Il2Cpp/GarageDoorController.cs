using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200002B RID: 43
	public class GarageDoorController : MonoBehaviour
	{
		// Token: 0x06000329 RID: 809 RVA: 0x0007A36C File Offset: 0x0007856C
		// Note: this type is marked as 'beforefieldinit'.
		static GarageDoorController()
		{
			Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GarageDoorController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr);
			GarageDoorController.NativeFieldInfoPtr_doorStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr, "doorStatus");
			GarageDoorController.NativeFieldInfoPtr_garageDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr, "garageDoor");
			GarageDoorController.NativeFieldInfoPtr_targetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr, "targetRotation");
			GarageDoorController.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr, 100663596);
			GarageDoorController.NativeMethodInfoPtr_Rotate_Private_IEnumerator_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr, 100663597);
			GarageDoorController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr, 100663598);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0007A414 File Offset: 0x00078614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73257, XrefRangeEnd = 73271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorController.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0007A458 File Offset: 0x00078658
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73276, RefRangeEnd = 73278, XrefRangeStart = 73271, XrefRangeEnd = 73276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Rotate(Vector3 axis, float angle, float duration = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref axis;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorController.NativeMethodInfoPtr_Rotate_Private_IEnumerator_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0007A4C0 File Offset: 0x000786C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73278, XrefRangeEnd = 73279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GarageDoorController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00003C79 File Offset: 0x00001E79
		public GarageDoorController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0007A4FC File Offset: 0x000786FC
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00003C82 File Offset: 0x00001E82
		public unsafe GarageDoorStatus doorStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController.NativeFieldInfoPtr_doorStatus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GarageDoorStatus>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController.NativeFieldInfoPtr_doorStatus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0007A52C File Offset: 0x0007872C
		// (set) Token: 0x06000331 RID: 817 RVA: 0x00003CA1 File Offset: 0x00001EA1
		public unsafe Transform garageDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController.NativeFieldInfoPtr_garageDoor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController.NativeFieldInfoPtr_garageDoor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0007A55C File Offset: 0x0007875C
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00003CC0 File Offset: 0x00001EC0
		public unsafe Quaternion targetRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController.NativeFieldInfoPtr_targetRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController.NativeFieldInfoPtr_targetRotation)) = value;
			}
		}

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeFieldInfoPtr_doorStatus;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeFieldInfoPtr_garageDoor;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeFieldInfoPtr_targetRotation;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Private_IEnumerator_Vector3_Single_Single_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007B2 RID: 1970
		[ObfuscatedName("GarageDoorController+<Rotate>d__4")]
		public sealed class _Rotate_d__4 : Il2CppSystem.Object
		{
			// Token: 0x0600B9AD RID: 47533 RVA: 0x002E1620 File Offset: 0x002DF820
			// Note: this type is marked as 'beforefieldinit'.
			static _Rotate_d__4()
			{
				Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr, "<Rotate>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr);
				GarageDoorController._Rotate_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, "<>1__state");
				GarageDoorController._Rotate_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, "<>2__current");
				GarageDoorController._Rotate_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, "<>4__this");
				GarageDoorController._Rotate_d__4.NativeFieldInfoPtr_axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, "axis");
				GarageDoorController._Rotate_d__4.NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, "angle");
				GarageDoorController._Rotate_d__4.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, "duration");
				GarageDoorController._Rotate_d__4.NativeFieldInfoPtr__from_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, "<from>5__2");
				GarageDoorController._Rotate_d__4.NativeFieldInfoPtr__to_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, "<to>5__3");
				GarageDoorController._Rotate_d__4.NativeFieldInfoPtr__elapsed_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, "<elapsed>5__4");
				GarageDoorController._Rotate_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, 100663599);
				GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, 100663600);
				GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, 100663601);
				GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, 100663602);
				GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, 100663603);
				GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, 100663604);
			}

			// Token: 0x0600B9AE RID: 47534 RVA: 0x002E1778 File Offset: 0x002DF978
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Rotate_d__4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorController._Rotate_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9AF RID: 47535 RVA: 0x002E17C0 File Offset: 0x002DF9C0
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9B0 RID: 47536 RVA: 0x002E17F4 File Offset: 0x002DF9F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73242, XrefRangeEnd = 73252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700394F RID: 14671
			// (get) Token: 0x0600B9B1 RID: 47537 RVA: 0x002E1830 File Offset: 0x002DFA30
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9B2 RID: 47538 RVA: 0x002E1870 File Offset: 0x002DFA70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73252, XrefRangeEnd = 73257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003950 RID: 14672
			// (get) Token: 0x0600B9B3 RID: 47539 RVA: 0x002E18A4 File Offset: 0x002DFAA4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9B4 RID: 47540 RVA: 0x0005AC4A File Offset: 0x00058E4A
			public _Rotate_d__4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003946 RID: 14662
			// (get) Token: 0x0600B9B5 RID: 47541 RVA: 0x002E18E4 File Offset: 0x002DFAE4
			// (set) Token: 0x0600B9B6 RID: 47542 RVA: 0x0005AC53 File Offset: 0x00058E53
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003947 RID: 14663
			// (get) Token: 0x0600B9B7 RID: 47543 RVA: 0x002E190C File Offset: 0x002DFB0C
			// (set) Token: 0x0600B9B8 RID: 47544 RVA: 0x0005AC6E File Offset: 0x00058E6E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003948 RID: 14664
			// (get) Token: 0x0600B9B9 RID: 47545 RVA: 0x002E193C File Offset: 0x002DFB3C
			// (set) Token: 0x0600B9BA RID: 47546 RVA: 0x0005AC8D File Offset: 0x00058E8D
			public unsafe GarageDoorController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GarageDoorController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003949 RID: 14665
			// (get) Token: 0x0600B9BB RID: 47547 RVA: 0x002E196C File Offset: 0x002DFB6C
			// (set) Token: 0x0600B9BC RID: 47548 RVA: 0x0005ACAC File Offset: 0x00058EAC
			public unsafe Vector3 axis
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr_axis);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr_axis)) = value;
				}
			}

			// Token: 0x1700394A RID: 14666
			// (get) Token: 0x0600B9BD RID: 47549 RVA: 0x002E1994 File Offset: 0x002DFB94
			// (set) Token: 0x0600B9BE RID: 47550 RVA: 0x0005ACC7 File Offset: 0x00058EC7
			public unsafe float angle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr_angle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr_angle)) = value;
				}
			}

			// Token: 0x1700394B RID: 14667
			// (get) Token: 0x0600B9BF RID: 47551 RVA: 0x002E19BC File Offset: 0x002DFBBC
			// (set) Token: 0x0600B9C0 RID: 47552 RVA: 0x0005ACE2 File Offset: 0x00058EE2
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x1700394C RID: 14668
			// (get) Token: 0x0600B9C1 RID: 47553 RVA: 0x002E19E4 File Offset: 0x002DFBE4
			// (set) Token: 0x0600B9C2 RID: 47554 RVA: 0x0005ACFD File Offset: 0x00058EFD
			public unsafe Quaternion _from_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr__from_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr__from_5__2)) = value;
				}
			}

			// Token: 0x1700394D RID: 14669
			// (get) Token: 0x0600B9C3 RID: 47555 RVA: 0x002E1A0C File Offset: 0x002DFC0C
			// (set) Token: 0x0600B9C4 RID: 47556 RVA: 0x0005AD18 File Offset: 0x00058F18
			public unsafe Quaternion _to_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr__to_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr__to_5__3)) = value;
				}
			}

			// Token: 0x1700394E RID: 14670
			// (get) Token: 0x0600B9C5 RID: 47557 RVA: 0x002E1A34 File Offset: 0x002DFC34
			// (set) Token: 0x0600B9C6 RID: 47558 RVA: 0x0005AD33 File Offset: 0x00058F33
			public unsafe float _elapsed_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr__elapsed_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr__elapsed_5__4)) = value;
				}
			}

			// Token: 0x04007D3F RID: 32063
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007D40 RID: 32064
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007D41 RID: 32065
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007D42 RID: 32066
			private static readonly IntPtr NativeFieldInfoPtr_axis;

			// Token: 0x04007D43 RID: 32067
			private static readonly IntPtr NativeFieldInfoPtr_angle;

			// Token: 0x04007D44 RID: 32068
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04007D45 RID: 32069
			private static readonly IntPtr NativeFieldInfoPtr__from_5__2;

			// Token: 0x04007D46 RID: 32070
			private static readonly IntPtr NativeFieldInfoPtr__to_5__3;

			// Token: 0x04007D47 RID: 32071
			private static readonly IntPtr NativeFieldInfoPtr__elapsed_5__4;

			// Token: 0x04007D48 RID: 32072
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007D49 RID: 32073
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D4A RID: 32074
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007D4B RID: 32075
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007D4C RID: 32076
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D4D RID: 32077
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
