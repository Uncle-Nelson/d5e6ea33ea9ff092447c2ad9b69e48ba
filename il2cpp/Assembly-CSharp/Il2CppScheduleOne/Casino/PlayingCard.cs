using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004A6 RID: 1190
	public class PlayingCard : MonoBehaviour
	{
		// Token: 0x060067C0 RID: 26560 RVA: 0x001D2A1C File Offset: 0x001D0C1C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayingCard()
		{
			Il2CppClassPointerStore<PlayingCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "PlayingCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr);
			PlayingCard.NativeFieldInfoPtr__IsFaceUp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<IsFaceUp>k__BackingField");
			PlayingCard.NativeFieldInfoPtr__Suit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<Suit>k__BackingField");
			PlayingCard.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<Value>k__BackingField");
			PlayingCard.NativeFieldInfoPtr__CardController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<CardController>k__BackingField");
			PlayingCard.NativeFieldInfoPtr_CardID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardID");
			PlayingCard.NativeFieldInfoPtr_CardSpriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardSpriteRenderer");
			PlayingCard.NativeFieldInfoPtr_CardSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardSprites");
			PlayingCard.NativeFieldInfoPtr_FlipAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "FlipAnimation");
			PlayingCard.NativeFieldInfoPtr_FlipFaceUpClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "FlipFaceUpClip");
			PlayingCard.NativeFieldInfoPtr_FlipFaceDownClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "FlipFaceDownClip");
			PlayingCard.NativeFieldInfoPtr_FlipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "FlipSound");
			PlayingCard.NativeFieldInfoPtr_LandSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "LandSound");
			PlayingCard.NativeFieldInfoPtr_moveRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "moveRoutine");
			PlayingCard.NativeFieldInfoPtr_lastGlideTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "lastGlideTarget");
			PlayingCard.NativeMethodInfoPtr_get_IsFaceUp_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676471);
			PlayingCard.NativeMethodInfoPtr_set_IsFaceUp_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676472);
			PlayingCard.NativeMethodInfoPtr_get_Suit_Public_get_ECardSuit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676473);
			PlayingCard.NativeMethodInfoPtr_set_Suit_Private_set_Void_ECardSuit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676474);
			PlayingCard.NativeMethodInfoPtr_get_Value_Public_get_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676475);
			PlayingCard.NativeMethodInfoPtr_set_Value_Private_set_Void_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676476);
			PlayingCard.NativeMethodInfoPtr_get_CardController_Public_get_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676477);
			PlayingCard.NativeMethodInfoPtr_set_CardController_Private_set_Void_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676478);
			PlayingCard.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676479);
			PlayingCard.NativeMethodInfoPtr_SetCardController_Public_Void_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676480);
			PlayingCard.NativeMethodInfoPtr_SetCard_Public_Void_ECardSuit_ECardValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676481);
			PlayingCard.NativeMethodInfoPtr_ClearCard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676482);
			PlayingCard.NativeMethodInfoPtr_SetFaceUp_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676483);
			PlayingCard.NativeMethodInfoPtr_GlideTo_Public_Void_Vector3_Quaternion_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676484);
			PlayingCard.NativeMethodInfoPtr_GetCardSprite_Private_CardSprite_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676485);
			PlayingCard.NativeMethodInfoPtr_VerifyCardSprites_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676486);
			PlayingCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676487);
		}

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x060067C1 RID: 26561 RVA: 0x001D2CB8 File Offset: 0x001D0EB8
		// (set) Token: 0x060067C2 RID: 26562 RVA: 0x001D2CF4 File Offset: 0x001D0EF4
		public unsafe bool IsFaceUp
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_get_IsFaceUp_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_set_IsFaceUp_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x060067C3 RID: 26563 RVA: 0x001D2D34 File Offset: 0x001D0F34
		// (set) Token: 0x060067C4 RID: 26564 RVA: 0x001D2D70 File Offset: 0x001D0F70
		public unsafe PlayingCard.ECardSuit Suit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_get_Suit_Public_get_ECardSuit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29963, RefRangeEnd = 29964, XrefRangeStart = 29963, XrefRangeEnd = 29964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_set_Suit_Private_set_Void_ECardSuit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x060067C5 RID: 26565 RVA: 0x001D2DB0 File Offset: 0x001D0FB0
		// (set) Token: 0x060067C6 RID: 26566 RVA: 0x001D2DEC File Offset: 0x001D0FEC
		public unsafe PlayingCard.ECardValue Value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29988, RefRangeEnd = 29989, XrefRangeStart = 29988, XrefRangeEnd = 29989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_get_Value_Public_get_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29989, RefRangeEnd = 29990, XrefRangeStart = 29989, XrefRangeEnd = 29990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_set_Value_Private_set_Void_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x060067C7 RID: 26567 RVA: 0x001D2E2C File Offset: 0x001D102C
		// (set) Token: 0x060067C8 RID: 26568 RVA: 0x001D2E6C File Offset: 0x001D106C
		public unsafe CardController CardController
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_get_CardController_Public_get_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardController>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_set_CardController_Private_set_Void_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060067C9 RID: 26569 RVA: 0x001D2EB0 File Offset: 0x001D10B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210425, XrefRangeEnd = 210433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067CA RID: 26570 RVA: 0x001D2EE4 File Offset: 0x001D10E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCardController(CardController cardController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_SetCardController_Public_Void_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067CB RID: 26571 RVA: 0x001D2F28 File Offset: 0x001D1128
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 210438, RefRangeEnd = 210442, XrefRangeStart = 210433, XrefRangeEnd = 210438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCard(PlayingCard.ECardSuit suit, PlayingCard.ECardValue value, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref suit;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_SetCard_Public_Void_ECardSuit_ECardValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067CC RID: 26572 RVA: 0x001D2F84 File Offset: 0x001D1184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210442, XrefRangeEnd = 210443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_ClearCard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067CD RID: 26573 RVA: 0x001D2FB8 File Offset: 0x001D11B8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 210451, RefRangeEnd = 210459, XrefRangeStart = 210443, XrefRangeEnd = 210451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFaceUp(bool faceUp, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref faceUp;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_SetFaceUp_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067CE RID: 26574 RVA: 0x001D3004 File Offset: 0x001D1204
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 210473, RefRangeEnd = 210483, XrefRangeStart = 210459, XrefRangeEnd = 210473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GlideTo(Vector3 position, Quaternion rotation, float duration = 0.5f, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_GlideTo_Public_Void_Vector3_Quaternion_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067CF RID: 26575 RVA: 0x001D306C File Offset: 0x001D126C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210497, RefRangeEnd = 210498, XrefRangeStart = 210483, XrefRangeEnd = 210497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard.CardSprite GetCardSprite(PlayingCard.ECardSuit suit, PlayingCard.ECardValue val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref suit;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_GetCardSprite_Private_CardSprite_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayingCard.CardSprite>(intPtr3) : null;
		}

		// Token: 0x060067D0 RID: 26576 RVA: 0x001D30C8 File Offset: 0x001D12C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210498, XrefRangeEnd = 210578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VerifyCardSprites()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_VerifyCardSprites_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067D1 RID: 26577 RVA: 0x001D30FC File Offset: 0x001D12FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210578, XrefRangeEnd = 210583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067D2 RID: 26578 RVA: 0x00030EC7 File Offset: 0x0002F0C7
		public PlayingCard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x060067D3 RID: 26579 RVA: 0x001D3138 File Offset: 0x001D1338
		// (set) Token: 0x060067D4 RID: 26580 RVA: 0x00030ED0 File Offset: 0x0002F0D0
		public unsafe bool _IsFaceUp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__IsFaceUp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__IsFaceUp_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x060067D5 RID: 26581 RVA: 0x001D3160 File Offset: 0x001D1360
		// (set) Token: 0x060067D6 RID: 26582 RVA: 0x00030EEB File Offset: 0x0002F0EB
		public unsafe PlayingCard.ECardSuit _Suit_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__Suit_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__Suit_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x060067D7 RID: 26583 RVA: 0x001D3188 File Offset: 0x001D1388
		// (set) Token: 0x060067D8 RID: 26584 RVA: 0x00030F06 File Offset: 0x0002F106
		public unsafe PlayingCard.ECardValue _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__Value_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__Value_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x060067D9 RID: 26585 RVA: 0x001D31B0 File Offset: 0x001D13B0
		// (set) Token: 0x060067DA RID: 26586 RVA: 0x00030F21 File Offset: 0x0002F121
		public unsafe CardController _CardController_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__CardController_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__CardController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x060067DB RID: 26587 RVA: 0x001D31E0 File Offset: 0x001D13E0
		// (set) Token: 0x060067DC RID: 26588 RVA: 0x00030F40 File Offset: 0x0002F140
		public unsafe string CardID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x060067DD RID: 26589 RVA: 0x001D3208 File Offset: 0x001D1408
		// (set) Token: 0x060067DE RID: 26590 RVA: 0x00030F5F File Offset: 0x0002F15F
		public unsafe SpriteRenderer CardSpriteRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardSpriteRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardSpriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x060067DF RID: 26591 RVA: 0x001D3238 File Offset: 0x001D1438
		// (set) Token: 0x060067E0 RID: 26592 RVA: 0x00030F7E File Offset: 0x0002F17E
		public unsafe Il2CppReferenceArray<PlayingCard.CardSprite> CardSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardSprites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayingCard.CardSprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x060067E1 RID: 26593 RVA: 0x001D3268 File Offset: 0x001D1468
		// (set) Token: 0x060067E2 RID: 26594 RVA: 0x00030F9D File Offset: 0x0002F19D
		public unsafe Animation FlipAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x060067E3 RID: 26595 RVA: 0x001D3298 File Offset: 0x001D1498
		// (set) Token: 0x060067E4 RID: 26596 RVA: 0x00030FBC File Offset: 0x0002F1BC
		public unsafe AnimationClip FlipFaceUpClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipFaceUpClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipFaceUpClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x060067E5 RID: 26597 RVA: 0x001D32C8 File Offset: 0x001D14C8
		// (set) Token: 0x060067E6 RID: 26598 RVA: 0x00030FDB File Offset: 0x0002F1DB
		public unsafe AnimationClip FlipFaceDownClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipFaceDownClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipFaceDownClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x060067E7 RID: 26599 RVA: 0x001D32F8 File Offset: 0x001D14F8
		// (set) Token: 0x060067E8 RID: 26600 RVA: 0x00030FFA File Offset: 0x0002F1FA
		public unsafe AudioSourceController FlipSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x060067E9 RID: 26601 RVA: 0x001D3328 File Offset: 0x001D1528
		// (set) Token: 0x060067EA RID: 26602 RVA: 0x00031019 File Offset: 0x0002F219
		public unsafe AudioSourceController LandSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_LandSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_LandSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x060067EB RID: 26603 RVA: 0x001D3358 File Offset: 0x001D1558
		// (set) Token: 0x060067EC RID: 26604 RVA: 0x00031038 File Offset: 0x0002F238
		public unsafe Coroutine moveRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_moveRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_moveRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x060067ED RID: 26605 RVA: 0x001D3388 File Offset: 0x001D1588
		// (set) Token: 0x060067EE RID: 26606 RVA: 0x00031057 File Offset: 0x0002F257
		public unsafe Tuple<Vector3, Quaternion> lastGlideTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_lastGlideTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tuple<Vector3, Quaternion>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_lastGlideTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004714 RID: 18196
		private static readonly IntPtr NativeFieldInfoPtr__IsFaceUp_k__BackingField;

		// Token: 0x04004715 RID: 18197
		private static readonly IntPtr NativeFieldInfoPtr__Suit_k__BackingField;

		// Token: 0x04004716 RID: 18198
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x04004717 RID: 18199
		private static readonly IntPtr NativeFieldInfoPtr__CardController_k__BackingField;

		// Token: 0x04004718 RID: 18200
		private static readonly IntPtr NativeFieldInfoPtr_CardID;

		// Token: 0x04004719 RID: 18201
		private static readonly IntPtr NativeFieldInfoPtr_CardSpriteRenderer;

		// Token: 0x0400471A RID: 18202
		private static readonly IntPtr NativeFieldInfoPtr_CardSprites;

		// Token: 0x0400471B RID: 18203
		private static readonly IntPtr NativeFieldInfoPtr_FlipAnimation;

		// Token: 0x0400471C RID: 18204
		private static readonly IntPtr NativeFieldInfoPtr_FlipFaceUpClip;

		// Token: 0x0400471D RID: 18205
		private static readonly IntPtr NativeFieldInfoPtr_FlipFaceDownClip;

		// Token: 0x0400471E RID: 18206
		private static readonly IntPtr NativeFieldInfoPtr_FlipSound;

		// Token: 0x0400471F RID: 18207
		private static readonly IntPtr NativeFieldInfoPtr_LandSound;

		// Token: 0x04004720 RID: 18208
		private static readonly IntPtr NativeFieldInfoPtr_moveRoutine;

		// Token: 0x04004721 RID: 18209
		private static readonly IntPtr NativeFieldInfoPtr_lastGlideTarget;

		// Token: 0x04004722 RID: 18210
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFaceUp_Public_get_Boolean_0;

		// Token: 0x04004723 RID: 18211
		private static readonly IntPtr NativeMethodInfoPtr_set_IsFaceUp_Private_set_Void_Boolean_0;

		// Token: 0x04004724 RID: 18212
		private static readonly IntPtr NativeMethodInfoPtr_get_Suit_Public_get_ECardSuit_0;

		// Token: 0x04004725 RID: 18213
		private static readonly IntPtr NativeMethodInfoPtr_set_Suit_Private_set_Void_ECardSuit_0;

		// Token: 0x04004726 RID: 18214
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_ECardValue_0;

		// Token: 0x04004727 RID: 18215
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Private_set_Void_ECardValue_0;

		// Token: 0x04004728 RID: 18216
		private static readonly IntPtr NativeMethodInfoPtr_get_CardController_Public_get_CardController_0;

		// Token: 0x04004729 RID: 18217
		private static readonly IntPtr NativeMethodInfoPtr_set_CardController_Private_set_Void_CardController_0;

		// Token: 0x0400472A RID: 18218
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400472B RID: 18219
		private static readonly IntPtr NativeMethodInfoPtr_SetCardController_Public_Void_CardController_0;

		// Token: 0x0400472C RID: 18220
		private static readonly IntPtr NativeMethodInfoPtr_SetCard_Public_Void_ECardSuit_ECardValue_Boolean_0;

		// Token: 0x0400472D RID: 18221
		private static readonly IntPtr NativeMethodInfoPtr_ClearCard_Public_Void_0;

		// Token: 0x0400472E RID: 18222
		private static readonly IntPtr NativeMethodInfoPtr_SetFaceUp_Public_Void_Boolean_Boolean_0;

		// Token: 0x0400472F RID: 18223
		private static readonly IntPtr NativeMethodInfoPtr_GlideTo_Public_Void_Vector3_Quaternion_Single_Boolean_0;

		// Token: 0x04004730 RID: 18224
		private static readonly IntPtr NativeMethodInfoPtr_GetCardSprite_Private_CardSprite_ECardSuit_ECardValue_0;

		// Token: 0x04004731 RID: 18225
		private static readonly IntPtr NativeMethodInfoPtr_VerifyCardSprites_Public_Void_0;

		// Token: 0x04004732 RID: 18226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A43 RID: 2627
		[Serializable]
		public class CardSprite : Il2CppSystem.Object
		{
			// Token: 0x0600CFF7 RID: 53239 RVA: 0x0031EC2C File Offset: 0x0031CE2C
			// Note: this type is marked as 'beforefieldinit'.
			static CardSprite()
			{
				Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardSprite");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr);
				PlayingCard.CardSprite.NativeFieldInfoPtr_Suit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr, "Suit");
				PlayingCard.CardSprite.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr, "Value");
				PlayingCard.CardSprite.NativeFieldInfoPtr_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr, "Sprite");
				PlayingCard.CardSprite.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr, 100676488);
			}

			// Token: 0x0600CFF8 RID: 53240 RVA: 0x0031ECA8 File Offset: 0x0031CEA8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CardSprite() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.CardSprite.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFF9 RID: 53241 RVA: 0x000652E7 File Offset: 0x000634E7
			public CardSprite(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004099 RID: 16537
			// (get) Token: 0x0600CFFA RID: 53242 RVA: 0x0031ECE4 File Offset: 0x0031CEE4
			// (set) Token: 0x0600CFFB RID: 53243 RVA: 0x000652F0 File Offset: 0x000634F0
			public unsafe PlayingCard.ECardSuit Suit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Suit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Suit)) = value;
				}
			}

			// Token: 0x1700409A RID: 16538
			// (get) Token: 0x0600CFFC RID: 53244 RVA: 0x0031ED0C File Offset: 0x0031CF0C
			// (set) Token: 0x0600CFFD RID: 53245 RVA: 0x0006530B File Offset: 0x0006350B
			public unsafe PlayingCard.ECardValue Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Value)) = value;
				}
			}

			// Token: 0x1700409B RID: 16539
			// (get) Token: 0x0600CFFE RID: 53246 RVA: 0x0031ED34 File Offset: 0x0031CF34
			// (set) Token: 0x0600CFFF RID: 53247 RVA: 0x00065326 File Offset: 0x00063526
			public unsafe Sprite Sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C3E RID: 35902
			private static readonly IntPtr NativeFieldInfoPtr_Suit;

			// Token: 0x04008C3F RID: 35903
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04008C40 RID: 35904
			private static readonly IntPtr NativeFieldInfoPtr_Sprite;

			// Token: 0x04008C41 RID: 35905
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A44 RID: 2628
		[StructLayout(2)]
		public struct CardData
		{
			// Token: 0x0600D000 RID: 53248 RVA: 0x0031ED64 File Offset: 0x0031CF64
			// Note: this type is marked as 'beforefieldinit'.
			static CardData()
			{
				Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr);
				PlayingCard.CardData.NativeFieldInfoPtr_Suit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr, "Suit");
				PlayingCard.CardData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr, "Value");
				PlayingCard.CardData.NativeMethodInfoPtr__ctor_Public_Void_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr, 100676489);
			}

			// Token: 0x0600D001 RID: 53249 RVA: 0x0031EDCC File Offset: 0x0031CFCC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 34315, RefRangeEnd = 34409, XrefRangeStart = 34315, XrefRangeEnd = 34409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CardData(PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref suit;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.CardData.NativeMethodInfoPtr__ctor_Public_Void_ECardSuit_ECardValue_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D002 RID: 53250 RVA: 0x00065345 File Offset: 0x00063545
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr, ref this));
			}

			// Token: 0x04008C42 RID: 35906
			private static readonly IntPtr NativeFieldInfoPtr_Suit;

			// Token: 0x04008C43 RID: 35907
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04008C44 RID: 35908
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ECardSuit_ECardValue_0;

			// Token: 0x04008C45 RID: 35909
			[FieldOffset(0)]
			public PlayingCard.ECardSuit Suit;

			// Token: 0x04008C46 RID: 35910
			[FieldOffset(4)]
			public PlayingCard.ECardValue Value;
		}

		// Token: 0x02000A45 RID: 2629
		[OriginalName("Assembly-CSharp.dll", "", "ECardSuit")]
		public enum ECardSuit
		{
			// Token: 0x04008C48 RID: 35912
			Spades,
			// Token: 0x04008C49 RID: 35913
			Hearts,
			// Token: 0x04008C4A RID: 35914
			Diamonds,
			// Token: 0x04008C4B RID: 35915
			Clubs
		}

		// Token: 0x02000A46 RID: 2630
		[OriginalName("Assembly-CSharp.dll", "", "ECardValue")]
		public enum ECardValue
		{
			// Token: 0x04008C4D RID: 35917
			Blank,
			// Token: 0x04008C4E RID: 35918
			Ace,
			// Token: 0x04008C4F RID: 35919
			Two,
			// Token: 0x04008C50 RID: 35920
			Three,
			// Token: 0x04008C51 RID: 35921
			Four,
			// Token: 0x04008C52 RID: 35922
			Five,
			// Token: 0x04008C53 RID: 35923
			Six,
			// Token: 0x04008C54 RID: 35924
			Seven,
			// Token: 0x04008C55 RID: 35925
			Eight,
			// Token: 0x04008C56 RID: 35926
			Nine,
			// Token: 0x04008C57 RID: 35927
			Ten,
			// Token: 0x04008C58 RID: 35928
			Jack,
			// Token: 0x04008C59 RID: 35929
			Queen,
			// Token: 0x04008C5A RID: 35930
			King
		}

		// Token: 0x02000A47 RID: 2631
		[ObfuscatedName("ScheduleOne.Casino.PlayingCard+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D003 RID: 53251 RVA: 0x0031EE0C File Offset: 0x0031D00C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr);
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "duration");
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "position");
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_verticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "verticalOffset");
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "rotation");
				PlayingCard.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, 100676490);
				PlayingCard.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, 100676491);
			}

			// Token: 0x0600D004 RID: 53252 RVA: 0x0031EEC4 File Offset: 0x0031D0C4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D005 RID: 53253 RVA: 0x0031EF00 File Offset: 0x0031D100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210420, XrefRangeEnd = 210425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D006 RID: 53254 RVA: 0x00065357 File Offset: 0x00063557
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700409C RID: 16540
			// (get) Token: 0x0600D007 RID: 53255 RVA: 0x0031EF40 File Offset: 0x0031D140
			// (set) Token: 0x0600D008 RID: 53256 RVA: 0x00065360 File Offset: 0x00063560
			public unsafe PlayingCard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayingCard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700409D RID: 16541
			// (get) Token: 0x0600D009 RID: 53257 RVA: 0x0031EF70 File Offset: 0x0031D170
			// (set) Token: 0x0600D00A RID: 53258 RVA: 0x0006537F File Offset: 0x0006357F
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x1700409E RID: 16542
			// (get) Token: 0x0600D00B RID: 53259 RVA: 0x0031EF98 File Offset: 0x0031D198
			// (set) Token: 0x0600D00C RID: 53260 RVA: 0x0006539A File Offset: 0x0006359A
			public unsafe Vector3 position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x1700409F RID: 16543
			// (get) Token: 0x0600D00D RID: 53261 RVA: 0x0031EFC0 File Offset: 0x0031D1C0
			// (set) Token: 0x0600D00E RID: 53262 RVA: 0x000653B5 File Offset: 0x000635B5
			public unsafe float verticalOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_verticalOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_verticalOffset)) = value;
				}
			}

			// Token: 0x170040A0 RID: 16544
			// (get) Token: 0x0600D00F RID: 53263 RVA: 0x0031EFE8 File Offset: 0x0031D1E8
			// (set) Token: 0x0600D010 RID: 53264 RVA: 0x000653D0 File Offset: 0x000635D0
			public unsafe Quaternion rotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_rotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_rotation)) = value;
				}
			}

			// Token: 0x04008C5B RID: 35931
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C5C RID: 35932
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04008C5D RID: 35933
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04008C5E RID: 35934
			private static readonly IntPtr NativeFieldInfoPtr_verticalOffset;

			// Token: 0x04008C5F RID: 35935
			private static readonly IntPtr NativeFieldInfoPtr_rotation;

			// Token: 0x04008C60 RID: 35936
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C61 RID: 35937
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C5A RID: 3162
			[ObfuscatedName("ScheduleOne.Casino.PlayingCard+<>c__DisplayClass35_0+<<GlideTo>g__MoveRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E3B0 RID: 58288 RVA: 0x00356E78 File Offset: 0x00355078
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique()
				{
					Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "<<GlideTo>g__MoveRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<>1__state");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<>2__current");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<>4__this");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startPosition_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<startPosition>5__2");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startRotation_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<startRotation>5__3");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__time_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<time>5__4");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100676492);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100676493);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100676494);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100676495);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100676496);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100676497);
				}

				// Token: 0x0600E3B1 RID: 58289 RVA: 0x00356F94 File Offset: 0x00355194
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3B2 RID: 58290 RVA: 0x00356FDC File Offset: 0x003551DC
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3B3 RID: 58291 RVA: 0x00357010 File Offset: 0x00355210
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210395, XrefRangeEnd = 210415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046AE RID: 18094
				// (get) Token: 0x0600E3B4 RID: 58292 RVA: 0x0035704C File Offset: 0x0035524C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3B5 RID: 58293 RVA: 0x0035708C File Offset: 0x0035528C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210415, XrefRangeEnd = 210420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046AF RID: 18095
				// (get) Token: 0x0600E3B6 RID: 58294 RVA: 0x003570C0 File Offset: 0x003552C0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3B7 RID: 58295 RVA: 0x0006EFB6 File Offset: 0x0006D1B6
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046A8 RID: 18088
				// (get) Token: 0x0600E3B8 RID: 58296 RVA: 0x00357100 File Offset: 0x00355300
				// (set) Token: 0x0600E3B9 RID: 58297 RVA: 0x0006EFBF File Offset: 0x0006D1BF
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046A9 RID: 18089
				// (get) Token: 0x0600E3BA RID: 58298 RVA: 0x00357128 File Offset: 0x00355328
				// (set) Token: 0x0600E3BB RID: 58299 RVA: 0x0006EFDA File Offset: 0x0006D1DA
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046AA RID: 18090
				// (get) Token: 0x0600E3BC RID: 58300 RVA: 0x00357158 File Offset: 0x00355358
				// (set) Token: 0x0600E3BD RID: 58301 RVA: 0x0006EFF9 File Offset: 0x0006D1F9
				public unsafe PlayingCard.__c__DisplayClass35_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayingCard.__c__DisplayClass35_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046AB RID: 18091
				// (get) Token: 0x0600E3BE RID: 58302 RVA: 0x00357188 File Offset: 0x00355388
				// (set) Token: 0x0600E3BF RID: 58303 RVA: 0x0006F018 File Offset: 0x0006D218
				public unsafe Vector3 _startPosition_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startPosition_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startPosition_5__2)) = value;
					}
				}

				// Token: 0x170046AC RID: 18092
				// (get) Token: 0x0600E3C0 RID: 58304 RVA: 0x003571B0 File Offset: 0x003553B0
				// (set) Token: 0x0600E3C1 RID: 58305 RVA: 0x0006F033 File Offset: 0x0006D233
				public unsafe Quaternion _startRotation_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startRotation_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startRotation_5__3)) = value;
					}
				}

				// Token: 0x170046AD RID: 18093
				// (get) Token: 0x0600E3C2 RID: 58306 RVA: 0x003571D8 File Offset: 0x003553D8
				// (set) Token: 0x0600E3C3 RID: 58307 RVA: 0x0006F04E File Offset: 0x0006D24E
				public unsafe float _time_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__time_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__time_5__4)) = value;
					}
				}

				// Token: 0x0400985A RID: 39002
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400985B RID: 39003
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400985C RID: 39004
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400985D RID: 39005
				private static readonly IntPtr NativeFieldInfoPtr__startPosition_5__2;

				// Token: 0x0400985E RID: 39006
				private static readonly IntPtr NativeFieldInfoPtr__startRotation_5__3;

				// Token: 0x0400985F RID: 39007
				private static readonly IntPtr NativeFieldInfoPtr__time_5__4;

				// Token: 0x04009860 RID: 39008
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009861 RID: 39009
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009862 RID: 39010
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009863 RID: 39011
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009864 RID: 39012
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009865 RID: 39013
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A48 RID: 2632
		[ObfuscatedName("ScheduleOne.Casino.PlayingCard+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D011 RID: 53265 RVA: 0x0031F010 File Offset: 0x0031D210
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr);
				PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_suit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr, "suit");
				PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr, "val");
				PlayingCard.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr, 100676498);
				PlayingCard.__c__DisplayClass36_0.NativeMethodInfoPtr__GetCardSprite_b__0_Internal_Boolean_CardSprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr, 100676499);
			}

			// Token: 0x0600D012 RID: 53266 RVA: 0x0031F08C File Offset: 0x0031D28C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D013 RID: 53267 RVA: 0x0031F0C8 File Offset: 0x0031D2C8
			[CallerCount(0)]
			public unsafe bool _GetCardSprite_b__0(PlayingCard.CardSprite x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass36_0.NativeMethodInfoPtr__GetCardSprite_b__0_Internal_Boolean_CardSprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D014 RID: 53268 RVA: 0x000653EB File Offset: 0x000635EB
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040A1 RID: 16545
			// (get) Token: 0x0600D015 RID: 53269 RVA: 0x0031F118 File Offset: 0x0031D318
			// (set) Token: 0x0600D016 RID: 53270 RVA: 0x000653F4 File Offset: 0x000635F4
			public unsafe PlayingCard.ECardSuit suit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_suit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_suit)) = value;
				}
			}

			// Token: 0x170040A2 RID: 16546
			// (get) Token: 0x0600D017 RID: 53271 RVA: 0x0031F140 File Offset: 0x0031D340
			// (set) Token: 0x0600D018 RID: 53272 RVA: 0x0006540F File Offset: 0x0006360F
			public unsafe PlayingCard.ECardValue val
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_val);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_val)) = value;
				}
			}

			// Token: 0x04008C62 RID: 35938
			private static readonly IntPtr NativeFieldInfoPtr_suit;

			// Token: 0x04008C63 RID: 35939
			private static readonly IntPtr NativeFieldInfoPtr_val;

			// Token: 0x04008C64 RID: 35940
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C65 RID: 35941
			private static readonly IntPtr NativeMethodInfoPtr__GetCardSprite_b__0_Internal_Boolean_CardSprite_0;
		}
	}
}
