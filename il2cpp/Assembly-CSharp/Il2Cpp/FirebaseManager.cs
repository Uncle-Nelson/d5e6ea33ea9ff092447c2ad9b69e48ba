using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace Il2Cpp
{
	// Token: 0x02000016 RID: 22
	public class FirebaseManager : MonoBehaviour
	{
		// Token: 0x06000181 RID: 385 RVA: 0x00075610 File Offset: 0x00073810
		// Note: this type is marked as 'beforefieldinit'.
		static FirebaseManager()
		{
			Il2CppClassPointerStore<FirebaseManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FirebaseManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirebaseManager>.NativeClassPtr);
			FirebaseManager.NativeMethodInfoPtr_FetchActiveVote_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirebaseManager>.NativeClassPtr, 100663422);
			FirebaseManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirebaseManager>.NativeClassPtr, 100663423);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00075668 File Offset: 0x00073868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72108, XrefRangeEnd = 72112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FetchActiveVote()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirebaseManager.NativeMethodInfoPtr_FetchActiveVote_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000756A8 File Offset: 0x000738A8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FirebaseManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FirebaseManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirebaseManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002D8A File Offset: 0x00000F8A
		public FirebaseManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_FetchActiveVote_Private_IEnumerator_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007A9 RID: 1961
		[ObfuscatedName("FirebaseManager+<FetchActiveVote>d__0")]
		public sealed class _FetchActiveVote_d__0 : Il2CppSystem.Object
		{
			// Token: 0x0600B94C RID: 47436 RVA: 0x002E0388 File Offset: 0x002DE588
			// Note: this type is marked as 'beforefieldinit'.
			static _FetchActiveVote_d__0()
			{
				Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FirebaseManager>.NativeClassPtr, "<FetchActiveVote>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr);
				FirebaseManager._FetchActiveVote_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, "<>1__state");
				FirebaseManager._FetchActiveVote_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, "<>2__current");
				FirebaseManager._FetchActiveVote_d__0.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, "<request>5__2");
				FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, 100663424);
				FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, 100663425);
				FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, 100663426);
				FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, 100663427);
				FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, 100663428);
				FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, 100663429);
				FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, 100663430);
			}

			// Token: 0x0600B94D RID: 47437 RVA: 0x002E047C File Offset: 0x002DE67C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FetchActiveVote_d__0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B94E RID: 47438 RVA: 0x002E04C4 File Offset: 0x002DE6C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72062, XrefRangeEnd = 72067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B94F RID: 47439 RVA: 0x002E04F8 File Offset: 0x002DE6F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72067, XrefRangeEnd = 72100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B950 RID: 47440 RVA: 0x002E0534 File Offset: 0x002DE734
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72100, XrefRangeEnd = 72103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003930 RID: 14640
			// (get) Token: 0x0600B951 RID: 47441 RVA: 0x002E0568 File Offset: 0x002DE768
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B952 RID: 47442 RVA: 0x002E05A8 File Offset: 0x002DE7A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72103, XrefRangeEnd = 72108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003931 RID: 14641
			// (get) Token: 0x0600B953 RID: 47443 RVA: 0x002E05DC File Offset: 0x002DE7DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B954 RID: 47444 RVA: 0x0005A994 File Offset: 0x00058B94
			public _FetchActiveVote_d__0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700392D RID: 14637
			// (get) Token: 0x0600B955 RID: 47445 RVA: 0x002E061C File Offset: 0x002DE81C
			// (set) Token: 0x0600B956 RID: 47446 RVA: 0x0005A99D File Offset: 0x00058B9D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirebaseManager._FetchActiveVote_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirebaseManager._FetchActiveVote_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700392E RID: 14638
			// (get) Token: 0x0600B957 RID: 47447 RVA: 0x002E0644 File Offset: 0x002DE844
			// (set) Token: 0x0600B958 RID: 47448 RVA: 0x0005A9B8 File Offset: 0x00058BB8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirebaseManager._FetchActiveVote_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirebaseManager._FetchActiveVote_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700392F RID: 14639
			// (get) Token: 0x0600B959 RID: 47449 RVA: 0x002E0674 File Offset: 0x002DE874
			// (set) Token: 0x0600B95A RID: 47450 RVA: 0x0005A9D7 File Offset: 0x00058BD7
			public unsafe UnityWebRequest _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirebaseManager._FetchActiveVote_d__0.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirebaseManager._FetchActiveVote_d__0.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D09 RID: 32009
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007D0A RID: 32010
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007D0B RID: 32011
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x04007D0C RID: 32012
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007D0D RID: 32013
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D0E RID: 32014
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007D0F RID: 32015
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04007D10 RID: 32016
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007D11 RID: 32017
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D12 RID: 32018
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
