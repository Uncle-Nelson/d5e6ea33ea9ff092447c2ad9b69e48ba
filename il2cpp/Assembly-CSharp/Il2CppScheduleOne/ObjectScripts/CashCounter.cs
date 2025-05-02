using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000729 RID: 1833
	public class CashCounter : MonoBehaviour
	{
		// Token: 0x0600A58A RID: 42378 RVA: 0x00297220 File Offset: 0x00295420
		// Note: this type is marked as 'beforefieldinit'.
		static CashCounter()
		{
			Il2CppClassPointerStore<CashCounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "CashCounter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashCounter>.NativeClassPtr);
			CashCounter.NativeFieldInfoPtr_NoteLerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "NoteLerpTime");
			CashCounter.NativeFieldInfoPtr_IsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "IsOn");
			CashCounter.NativeFieldInfoPtr_UpperNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "UpperNotes");
			CashCounter.NativeFieldInfoPtr_LowerNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "LowerNotes");
			CashCounter.NativeFieldInfoPtr_NoteStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "NoteStartPoint");
			CashCounter.NativeFieldInfoPtr_NoteEndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "NoteEndPoint");
			CashCounter.NativeFieldInfoPtr_MovingNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "MovingNotes");
			CashCounter.NativeFieldInfoPtr_Audio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "Audio");
			CashCounter.NativeFieldInfoPtr_lerping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "lerping");
			CashCounter.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, 100683544);
			CashCounter.NativeMethodInfoPtr_LerpNote_Private_IEnumerator_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, 100683545);
			CashCounter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, 100683546);
		}

		// Token: 0x0600A58B RID: 42379 RVA: 0x00297340 File Offset: 0x00295540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289565, XrefRangeEnd = 289573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashCounter.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A58C RID: 42380 RVA: 0x0029737C File Offset: 0x0029557C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289573, XrefRangeEnd = 289579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpNote(Transform note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter.NativeMethodInfoPtr_LerpNote_Private_IEnumerator_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A58D RID: 42381 RVA: 0x002973CC File Offset: 0x002955CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289579, XrefRangeEnd = 289587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashCounter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashCounter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A58E RID: 42382 RVA: 0x000518B4 File Offset: 0x0004FAB4
		public CashCounter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003315 RID: 13077
		// (get) Token: 0x0600A58F RID: 42383 RVA: 0x00297408 File Offset: 0x00295608
		// (set) Token: 0x0600A590 RID: 42384 RVA: 0x000518BD File Offset: 0x0004FABD
		public unsafe static float NoteLerpTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashCounter.NativeFieldInfoPtr_NoteLerpTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashCounter.NativeFieldInfoPtr_NoteLerpTime, (void*)(&value));
			}
		}

		// Token: 0x17003316 RID: 13078
		// (get) Token: 0x0600A591 RID: 42385 RVA: 0x00297424 File Offset: 0x00295624
		// (set) Token: 0x0600A592 RID: 42386 RVA: 0x000518CB File Offset: 0x0004FACB
		public unsafe bool IsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_IsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_IsOn)) = value;
			}
		}

		// Token: 0x17003317 RID: 13079
		// (get) Token: 0x0600A593 RID: 42387 RVA: 0x0029744C File Offset: 0x0029564C
		// (set) Token: 0x0600A594 RID: 42388 RVA: 0x000518E6 File Offset: 0x0004FAE6
		public unsafe GameObject UpperNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_UpperNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_UpperNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003318 RID: 13080
		// (get) Token: 0x0600A595 RID: 42389 RVA: 0x0029747C File Offset: 0x0029567C
		// (set) Token: 0x0600A596 RID: 42390 RVA: 0x00051905 File Offset: 0x0004FB05
		public unsafe GameObject LowerNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_LowerNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_LowerNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003319 RID: 13081
		// (get) Token: 0x0600A597 RID: 42391 RVA: 0x002974AC File Offset: 0x002956AC
		// (set) Token: 0x0600A598 RID: 42392 RVA: 0x00051924 File Offset: 0x0004FB24
		public unsafe Transform NoteStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_NoteStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_NoteStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700331A RID: 13082
		// (get) Token: 0x0600A599 RID: 42393 RVA: 0x002974DC File Offset: 0x002956DC
		// (set) Token: 0x0600A59A RID: 42394 RVA: 0x00051943 File Offset: 0x0004FB43
		public unsafe Transform NoteEndPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_NoteEndPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_NoteEndPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700331B RID: 13083
		// (get) Token: 0x0600A59B RID: 42395 RVA: 0x0029750C File Offset: 0x0029570C
		// (set) Token: 0x0600A59C RID: 42396 RVA: 0x00051962 File Offset: 0x0004FB62
		public unsafe List<Transform> MovingNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_MovingNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_MovingNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700331C RID: 13084
		// (get) Token: 0x0600A59D RID: 42397 RVA: 0x0029753C File Offset: 0x0029573C
		// (set) Token: 0x0600A59E RID: 42398 RVA: 0x00051981 File Offset: 0x0004FB81
		public unsafe AudioSourceController Audio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_Audio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_Audio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700331D RID: 13085
		// (get) Token: 0x0600A59F RID: 42399 RVA: 0x0029756C File Offset: 0x0029576C
		// (set) Token: 0x0600A5A0 RID: 42400 RVA: 0x000519A0 File Offset: 0x0004FBA0
		public unsafe bool lerping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_lerping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_lerping)) = value;
			}
		}

		// Token: 0x04006F02 RID: 28418
		private static readonly IntPtr NativeFieldInfoPtr_NoteLerpTime;

		// Token: 0x04006F03 RID: 28419
		private static readonly IntPtr NativeFieldInfoPtr_IsOn;

		// Token: 0x04006F04 RID: 28420
		private static readonly IntPtr NativeFieldInfoPtr_UpperNotes;

		// Token: 0x04006F05 RID: 28421
		private static readonly IntPtr NativeFieldInfoPtr_LowerNotes;

		// Token: 0x04006F06 RID: 28422
		private static readonly IntPtr NativeFieldInfoPtr_NoteStartPoint;

		// Token: 0x04006F07 RID: 28423
		private static readonly IntPtr NativeFieldInfoPtr_NoteEndPoint;

		// Token: 0x04006F08 RID: 28424
		private static readonly IntPtr NativeFieldInfoPtr_MovingNotes;

		// Token: 0x04006F09 RID: 28425
		private static readonly IntPtr NativeFieldInfoPtr_Audio;

		// Token: 0x04006F0A RID: 28426
		private static readonly IntPtr NativeFieldInfoPtr_lerping;

		// Token: 0x04006F0B RID: 28427
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04006F0C RID: 28428
		private static readonly IntPtr NativeMethodInfoPtr_LerpNote_Private_IEnumerator_Transform_0;

		// Token: 0x04006F0D RID: 28429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BCE RID: 3022
		[ObfuscatedName("ScheduleOne.ObjectScripts.CashCounter+<LerpNote>d__10")]
		public sealed class _LerpNote_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600DE41 RID: 56897 RVA: 0x0034710C File Offset: 0x0034530C
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpNote_d__10()
			{
				Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "<LerpNote>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr);
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "<>1__state");
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "<>2__current");
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "<>4__this");
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr_note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "note");
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "<i>5__2");
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100683547);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100683548);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100683549);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100683550);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100683551);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100683552);
			}

			// Token: 0x0600DE42 RID: 56898 RVA: 0x00347214 File Offset: 0x00345414
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpNote_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE43 RID: 56899 RVA: 0x0034725C File Offset: 0x0034545C
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE44 RID: 56900 RVA: 0x00347290 File Offset: 0x00345490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289536, XrefRangeEnd = 289560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044E5 RID: 17637
			// (get) Token: 0x0600DE45 RID: 56901 RVA: 0x003472CC File Offset: 0x003454CC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE46 RID: 56902 RVA: 0x0034730C File Offset: 0x0034550C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289560, XrefRangeEnd = 289565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044E6 RID: 17638
			// (get) Token: 0x0600DE47 RID: 56903 RVA: 0x00347340 File Offset: 0x00345540
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE48 RID: 56904 RVA: 0x0006C5B1 File Offset: 0x0006A7B1
			public _LerpNote_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044E0 RID: 17632
			// (get) Token: 0x0600DE49 RID: 56905 RVA: 0x00347380 File Offset: 0x00345580
			// (set) Token: 0x0600DE4A RID: 56906 RVA: 0x0006C5BA File Offset: 0x0006A7BA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044E1 RID: 17633
			// (get) Token: 0x0600DE4B RID: 56907 RVA: 0x003473A8 File Offset: 0x003455A8
			// (set) Token: 0x0600DE4C RID: 56908 RVA: 0x0006C5D5 File Offset: 0x0006A7D5
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044E2 RID: 17634
			// (get) Token: 0x0600DE4D RID: 56909 RVA: 0x003473D8 File Offset: 0x003455D8
			// (set) Token: 0x0600DE4E RID: 56910 RVA: 0x0006C5F4 File Offset: 0x0006A7F4
			public unsafe CashCounter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashCounter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044E3 RID: 17635
			// (get) Token: 0x0600DE4F RID: 56911 RVA: 0x00347408 File Offset: 0x00345608
			// (set) Token: 0x0600DE50 RID: 56912 RVA: 0x0006C613 File Offset: 0x0006A813
			public unsafe Transform note
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr_note);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr_note), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044E4 RID: 17636
			// (get) Token: 0x0600DE51 RID: 56913 RVA: 0x00347438 File Offset: 0x00345638
			// (set) Token: 0x0600DE52 RID: 56914 RVA: 0x0006C632 File Offset: 0x0006A832
			public unsafe float _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040094CF RID: 38095
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094D0 RID: 38096
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094D1 RID: 38097
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094D2 RID: 38098
			private static readonly IntPtr NativeFieldInfoPtr_note;

			// Token: 0x040094D3 RID: 38099
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040094D4 RID: 38100
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094D5 RID: 38101
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094D6 RID: 38102
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094D7 RID: 38103
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094D8 RID: 38104
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094D9 RID: 38105
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
