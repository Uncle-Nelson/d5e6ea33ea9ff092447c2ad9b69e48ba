using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000775 RID: 1909
	public class DarkMarketMainDoor : MonoBehaviour
	{
		// Token: 0x0600B510 RID: 46352 RVA: 0x002D0D40 File Offset: 0x002CEF40
		// Note: this type is marked as 'beforefieldinit'.
		static DarkMarketMainDoor()
		{
			Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "DarkMarketMainDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr);
			DarkMarketMainDoor.NativeFieldInfoPtr__KnockingEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "<KnockingEnabled>k__BackingField");
			DarkMarketMainDoor.NativeFieldInfoPtr_KnockSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "KnockSound");
			DarkMarketMainDoor.NativeFieldInfoPtr_InteractableObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "InteractableObject");
			DarkMarketMainDoor.NativeFieldInfoPtr_Peephole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "Peephole");
			DarkMarketMainDoor.NativeFieldInfoPtr_Igor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "Igor");
			DarkMarketMainDoor.NativeFieldInfoPtr_FailDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "FailDialogue");
			DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "SuccessDialogue");
			DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogueNotOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "SuccessDialogueNotOpen");
			DarkMarketMainDoor.NativeFieldInfoPtr_knockRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "knockRoutine");
			DarkMarketMainDoor.NativeMethodInfoPtr_get_KnockingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685567);
			DarkMarketMainDoor.NativeMethodInfoPtr_set_KnockingEnabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685568);
			DarkMarketMainDoor.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685569);
			DarkMarketMainDoor.NativeMethodInfoPtr_SetKnockingEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685570);
			DarkMarketMainDoor.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685571);
			DarkMarketMainDoor.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685572);
			DarkMarketMainDoor.NativeMethodInfoPtr_Knocked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685573);
			DarkMarketMainDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685574);
			DarkMarketMainDoor.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685575);
			DarkMarketMainDoor.NativeMethodInfoPtr__Knocked_b__16_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685576);
		}

		// Token: 0x17003827 RID: 14375
		// (get) Token: 0x0600B511 RID: 46353 RVA: 0x002D0EEC File Offset: 0x002CF0EC
		// (set) Token: 0x0600B512 RID: 46354 RVA: 0x002D0F28 File Offset: 0x002CF128
		public unsafe bool KnockingEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_get_KnockingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_set_KnockingEnabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B513 RID: 46355 RVA: 0x002D0F68 File Offset: 0x002CF168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254044, RefRangeEnd = 254045, XrefRangeStart = 254044, XrefRangeEnd = 254045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B514 RID: 46356 RVA: 0x002D0F9C File Offset: 0x002CF19C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310274, RefRangeEnd = 310276, XrefRangeStart = 310272, XrefRangeEnd = 310274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKnockingEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_SetKnockingEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B515 RID: 46357 RVA: 0x002D0FDC File Offset: 0x002CF1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310276, XrefRangeEnd = 310284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B516 RID: 46358 RVA: 0x002D1010 File Offset: 0x002CF210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310284, XrefRangeEnd = 310291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B517 RID: 46359 RVA: 0x002D1044 File Offset: 0x002CF244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Knocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Knocked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B518 RID: 46360 RVA: 0x002D1078 File Offset: 0x002CF278
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 162892, RefRangeEnd = 162908, XrefRangeStart = 162892, XrefRangeEnd = 162908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DarkMarketMainDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B519 RID: 46361 RVA: 0x002D10B4 File Offset: 0x002CF2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310291, XrefRangeEnd = 310296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B51A RID: 46362 RVA: 0x002D10F4 File Offset: 0x002CF2F4
		[CallerCount(0)]
		public unsafe bool _Knocked_b__16_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr__Knocked_b__16_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B51B RID: 46363 RVA: 0x00058D11 File Offset: 0x00056F11
		public DarkMarketMainDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700381E RID: 14366
		// (get) Token: 0x0600B51C RID: 46364 RVA: 0x002D1130 File Offset: 0x002CF330
		// (set) Token: 0x0600B51D RID: 46365 RVA: 0x00058D1A File Offset: 0x00056F1A
		public unsafe bool _KnockingEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr__KnockingEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr__KnockingEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700381F RID: 14367
		// (get) Token: 0x0600B51E RID: 46366 RVA: 0x002D1158 File Offset: 0x002CF358
		// (set) Token: 0x0600B51F RID: 46367 RVA: 0x00058D35 File Offset: 0x00056F35
		public unsafe AudioSource KnockSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_KnockSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_KnockSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003820 RID: 14368
		// (get) Token: 0x0600B520 RID: 46368 RVA: 0x002D1188 File Offset: 0x002CF388
		// (set) Token: 0x0600B521 RID: 46369 RVA: 0x00058D54 File Offset: 0x00056F54
		public unsafe InteractableObject InteractableObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_InteractableObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_InteractableObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003821 RID: 14369
		// (get) Token: 0x0600B522 RID: 46370 RVA: 0x002D11B8 File Offset: 0x002CF3B8
		// (set) Token: 0x0600B523 RID: 46371 RVA: 0x00058D73 File Offset: 0x00056F73
		public unsafe Peephole Peephole
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_Peephole);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Peephole>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_Peephole), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003822 RID: 14370
		// (get) Token: 0x0600B524 RID: 46372 RVA: 0x002D11E8 File Offset: 0x002CF3E8
		// (set) Token: 0x0600B525 RID: 46373 RVA: 0x00058D92 File Offset: 0x00056F92
		public unsafe Igor Igor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_Igor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Igor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_Igor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003823 RID: 14371
		// (get) Token: 0x0600B526 RID: 46374 RVA: 0x002D1218 File Offset: 0x002CF418
		// (set) Token: 0x0600B527 RID: 46375 RVA: 0x00058DB1 File Offset: 0x00056FB1
		public unsafe DialogueContainer FailDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_FailDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_FailDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003824 RID: 14372
		// (get) Token: 0x0600B528 RID: 46376 RVA: 0x002D1248 File Offset: 0x002CF448
		// (set) Token: 0x0600B529 RID: 46377 RVA: 0x00058DD0 File Offset: 0x00056FD0
		public unsafe DialogueContainer SuccessDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003825 RID: 14373
		// (get) Token: 0x0600B52A RID: 46378 RVA: 0x002D1278 File Offset: 0x002CF478
		// (set) Token: 0x0600B52B RID: 46379 RVA: 0x00058DEF File Offset: 0x00056FEF
		public unsafe DialogueContainer SuccessDialogueNotOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogueNotOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogueNotOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003826 RID: 14374
		// (get) Token: 0x0600B52C RID: 46380 RVA: 0x002D12A8 File Offset: 0x002CF4A8
		// (set) Token: 0x0600B52D RID: 46381 RVA: 0x00058E0E File Offset: 0x0005700E
		public unsafe Coroutine knockRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_knockRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_knockRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A08 RID: 31240
		private static readonly IntPtr NativeFieldInfoPtr__KnockingEnabled_k__BackingField;

		// Token: 0x04007A09 RID: 31241
		private static readonly IntPtr NativeFieldInfoPtr_KnockSound;

		// Token: 0x04007A0A RID: 31242
		private static readonly IntPtr NativeFieldInfoPtr_InteractableObject;

		// Token: 0x04007A0B RID: 31243
		private static readonly IntPtr NativeFieldInfoPtr_Peephole;

		// Token: 0x04007A0C RID: 31244
		private static readonly IntPtr NativeFieldInfoPtr_Igor;

		// Token: 0x04007A0D RID: 31245
		private static readonly IntPtr NativeFieldInfoPtr_FailDialogue;

		// Token: 0x04007A0E RID: 31246
		private static readonly IntPtr NativeFieldInfoPtr_SuccessDialogue;

		// Token: 0x04007A0F RID: 31247
		private static readonly IntPtr NativeFieldInfoPtr_SuccessDialogueNotOpen;

		// Token: 0x04007A10 RID: 31248
		private static readonly IntPtr NativeFieldInfoPtr_knockRoutine;

		// Token: 0x04007A11 RID: 31249
		private static readonly IntPtr NativeMethodInfoPtr_get_KnockingEnabled_Public_get_Boolean_0;

		// Token: 0x04007A12 RID: 31250
		private static readonly IntPtr NativeMethodInfoPtr_set_KnockingEnabled_Private_set_Void_Boolean_0;

		// Token: 0x04007A13 RID: 31251
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007A14 RID: 31252
		private static readonly IntPtr NativeMethodInfoPtr_SetKnockingEnabled_Public_Void_Boolean_0;

		// Token: 0x04007A15 RID: 31253
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04007A16 RID: 31254
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04007A17 RID: 31255
		private static readonly IntPtr NativeMethodInfoPtr_Knocked_Private_Void_0;

		// Token: 0x04007A18 RID: 31256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007A19 RID: 31257
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04007A1A RID: 31258
		private static readonly IntPtr NativeMethodInfoPtr__Knocked_b__16_1_Private_Boolean_0;

		// Token: 0x02000BFA RID: 3066
		[ObfuscatedName("ScheduleOne.Map.DarkMarketMainDoor+<<Knocked>g__Knock|16_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DFC8 RID: 57288 RVA: 0x0034B7DC File Offset: 0x003499DC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique()
			{
				Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "<<Knocked>g__Knock|16_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, "<>1__state");
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, "<>2__current");
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, "<>4__this");
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr__shouldUnlock_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, "<shouldUnlock>5__2");
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100685577);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100685578);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100685579);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100685580);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100685581);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100685582);
			}

			// Token: 0x0600DFC9 RID: 57289 RVA: 0x0034B8D0 File Offset: 0x00349AD0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFCA RID: 57290 RVA: 0x0034B918 File Offset: 0x00349B18
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFCB RID: 57291 RVA: 0x0034B94C File Offset: 0x00349B4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310170, XrefRangeEnd = 310267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700455C RID: 17756
			// (get) Token: 0x0600DFCC RID: 57292 RVA: 0x0034B988 File Offset: 0x00349B88
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFCD RID: 57293 RVA: 0x0034B9C8 File Offset: 0x00349BC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310267, XrefRangeEnd = 310272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700455D RID: 17757
			// (get) Token: 0x0600DFCE RID: 57294 RVA: 0x0034B9FC File Offset: 0x00349BFC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFCF RID: 57295 RVA: 0x0006D20E File Offset: 0x0006B40E
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004558 RID: 17752
			// (get) Token: 0x0600DFD0 RID: 57296 RVA: 0x0034BA3C File Offset: 0x00349C3C
			// (set) Token: 0x0600DFD1 RID: 57297 RVA: 0x0006D217 File Offset: 0x0006B417
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004559 RID: 17753
			// (get) Token: 0x0600DFD2 RID: 57298 RVA: 0x0034BA64 File Offset: 0x00349C64
			// (set) Token: 0x0600DFD3 RID: 57299 RVA: 0x0006D232 File Offset: 0x0006B432
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700455A RID: 17754
			// (get) Token: 0x0600DFD4 RID: 57300 RVA: 0x0034BA94 File Offset: 0x00349C94
			// (set) Token: 0x0600DFD5 RID: 57301 RVA: 0x0006D251 File Offset: 0x0006B451
			public unsafe DarkMarketMainDoor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DarkMarketMainDoor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700455B RID: 17755
			// (get) Token: 0x0600DFD6 RID: 57302 RVA: 0x0034BAC4 File Offset: 0x00349CC4
			// (set) Token: 0x0600DFD7 RID: 57303 RVA: 0x0006D270 File Offset: 0x0006B470
			public unsafe bool _shouldUnlock_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr__shouldUnlock_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr__shouldUnlock_5__2)) = value;
				}
			}

			// Token: 0x040095E1 RID: 38369
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040095E2 RID: 38370
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040095E3 RID: 38371
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095E4 RID: 38372
			private static readonly IntPtr NativeFieldInfoPtr__shouldUnlock_5__2;

			// Token: 0x040095E5 RID: 38373
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040095E6 RID: 38374
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095E7 RID: 38375
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040095E8 RID: 38376
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040095E9 RID: 38377
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095EA RID: 38378
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
