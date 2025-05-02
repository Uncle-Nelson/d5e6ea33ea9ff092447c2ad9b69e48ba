using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Misc;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003B4 RID: 948
	public class BlinkingLight : MonoBehaviour
	{
		// Token: 0x060049DE RID: 18910 RVA: 0x00167724 File Offset: 0x00165924
		// Note: this type is marked as 'beforefieldinit'.
		static BlinkingLight()
		{
			Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "BlinkingLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr);
			BlinkingLight.NativeFieldInfoPtr_IsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "IsOn");
			BlinkingLight.NativeFieldInfoPtr_OnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "OnTime");
			BlinkingLight.NativeFieldInfoPtr_OffTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "OffTime");
			BlinkingLight.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "light");
			BlinkingLight.NativeFieldInfoPtr_blinkRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "blinkRoutine");
			BlinkingLight.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100672462);
			BlinkingLight.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100672463);
			BlinkingLight.NativeMethodInfoPtr_Blink_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100672464);
			BlinkingLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100672465);
		}

		// Token: 0x060049DF RID: 18911 RVA: 0x00167808 File Offset: 0x00165A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163750, XrefRangeEnd = 163754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049E0 RID: 18912 RVA: 0x0016783C File Offset: 0x00165A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163754, XrefRangeEnd = 163761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049E1 RID: 18913 RVA: 0x00167870 File Offset: 0x00165A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163761, XrefRangeEnd = 163766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Blink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr_Blink_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049E2 RID: 18914 RVA: 0x001678B0 File Offset: 0x00165AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163766, XrefRangeEnd = 163767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlinkingLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049E3 RID: 18915 RVA: 0x00023949 File Offset: 0x00021B49
		public BlinkingLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x060049E4 RID: 18916 RVA: 0x001678EC File Offset: 0x00165AEC
		// (set) Token: 0x060049E5 RID: 18917 RVA: 0x00023952 File Offset: 0x00021B52
		public unsafe bool IsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_IsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_IsOn)) = value;
			}
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x060049E6 RID: 18918 RVA: 0x00167914 File Offset: 0x00165B14
		// (set) Token: 0x060049E7 RID: 18919 RVA: 0x0002396D File Offset: 0x00021B6D
		public unsafe float OnTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_OnTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_OnTime)) = value;
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x060049E8 RID: 18920 RVA: 0x0016793C File Offset: 0x00165B3C
		// (set) Token: 0x060049E9 RID: 18921 RVA: 0x00023988 File Offset: 0x00021B88
		public unsafe float OffTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_OffTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_OffTime)) = value;
			}
		}

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x060049EA RID: 18922 RVA: 0x00167964 File Offset: 0x00165B64
		// (set) Token: 0x060049EB RID: 18923 RVA: 0x000239A3 File Offset: 0x00021BA3
		public unsafe ToggleableLight light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x060049EC RID: 18924 RVA: 0x00167994 File Offset: 0x00165B94
		// (set) Token: 0x060049ED RID: 18925 RVA: 0x000239C2 File Offset: 0x00021BC2
		public unsafe Coroutine blinkRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_blinkRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_blinkRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031CF RID: 12751
		private static readonly IntPtr NativeFieldInfoPtr_IsOn;

		// Token: 0x040031D0 RID: 12752
		private static readonly IntPtr NativeFieldInfoPtr_OnTime;

		// Token: 0x040031D1 RID: 12753
		private static readonly IntPtr NativeFieldInfoPtr_OffTime;

		// Token: 0x040031D2 RID: 12754
		private static readonly IntPtr NativeFieldInfoPtr_light;

		// Token: 0x040031D3 RID: 12755
		private static readonly IntPtr NativeFieldInfoPtr_blinkRoutine;

		// Token: 0x040031D4 RID: 12756
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040031D5 RID: 12757
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040031D6 RID: 12758
		private static readonly IntPtr NativeMethodInfoPtr_Blink_Private_IEnumerator_0;

		// Token: 0x040031D7 RID: 12759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000985 RID: 2437
		[ObfuscatedName("ScheduleOne.Lighting.BlinkingLight+<Blink>d__7")]
		public sealed class _Blink_d__7 : Il2CppSystem.Object
		{
			// Token: 0x0600CA2C RID: 51756 RVA: 0x0030E7A4 File Offset: 0x0030C9A4
			// Note: this type is marked as 'beforefieldinit'.
			static _Blink_d__7()
			{
				Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "<Blink>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr);
				BlinkingLight._Blink_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, "<>1__state");
				BlinkingLight._Blink_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, "<>2__current");
				BlinkingLight._Blink_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, "<>4__this");
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100672466);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100672467);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100672468);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100672469);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100672470);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100672471);
			}

			// Token: 0x0600CA2D RID: 51757 RVA: 0x0030E884 File Offset: 0x0030CA84
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Blink_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA2E RID: 51758 RVA: 0x0030E8CC File Offset: 0x0030CACC
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA2F RID: 51759 RVA: 0x0030E900 File Offset: 0x0030CB00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163744, XrefRangeEnd = 163745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F01 RID: 16129
			// (get) Token: 0x0600CA30 RID: 51760 RVA: 0x0030E93C File Offset: 0x0030CB3C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CA31 RID: 51761 RVA: 0x0030E97C File Offset: 0x0030CB7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163745, XrefRangeEnd = 163750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F02 RID: 16130
			// (get) Token: 0x0600CA32 RID: 51762 RVA: 0x0030E9B0 File Offset: 0x0030CBB0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CA33 RID: 51763 RVA: 0x000624D7 File Offset: 0x000606D7
			public _Blink_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EFE RID: 16126
			// (get) Token: 0x0600CA34 RID: 51764 RVA: 0x0030E9F0 File Offset: 0x0030CBF0
			// (set) Token: 0x0600CA35 RID: 51765 RVA: 0x000624E0 File Offset: 0x000606E0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003EFF RID: 16127
			// (get) Token: 0x0600CA36 RID: 51766 RVA: 0x0030EA18 File Offset: 0x0030CC18
			// (set) Token: 0x0600CA37 RID: 51767 RVA: 0x000624FB File Offset: 0x000606FB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F00 RID: 16128
			// (get) Token: 0x0600CA38 RID: 51768 RVA: 0x0030EA48 File Offset: 0x0030CC48
			// (set) Token: 0x0600CA39 RID: 51769 RVA: 0x0006251A File Offset: 0x0006071A
			public unsafe BlinkingLight __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlinkingLight>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088C3 RID: 35011
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040088C4 RID: 35012
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040088C5 RID: 35013
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088C6 RID: 35014
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040088C7 RID: 35015
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088C8 RID: 35016
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040088C9 RID: 35017
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040088CA RID: 35018
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088CB RID: 35019
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
