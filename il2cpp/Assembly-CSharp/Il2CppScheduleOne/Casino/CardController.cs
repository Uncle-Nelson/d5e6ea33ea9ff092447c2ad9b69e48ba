using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004A1 RID: 1185
	public class CardController : NetworkBehaviour
	{
		// Token: 0x06006703 RID: 26371 RVA: 0x001CF1E8 File Offset: 0x001CD3E8
		// Note: this type is marked as 'beforefieldinit'.
		static CardController()
		{
			Il2CppClassPointerStore<CardController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CardController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardController>.NativeClassPtr);
			CardController.NativeFieldInfoPtr_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, "cards");
			CardController.NativeFieldInfoPtr_cardDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, "cardDictionary");
			CardController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.CardControllerAssembly-CSharp.dll_Excuted");
			CardController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.CardControllerAssembly-CSharp.dll_Excuted");
			CardController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676347);
			CardController.NativeMethodInfoPtr_SendCardValue_Public_Void_String_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676348);
			CardController.NativeMethodInfoPtr_SetCardValue_Private_Void_String_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676349);
			CardController.NativeMethodInfoPtr_SendCardFaceUp_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676350);
			CardController.NativeMethodInfoPtr_SetCardFaceUp_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676351);
			CardController.NativeMethodInfoPtr_SendCardGlide_Public_Void_String_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676352);
			CardController.NativeMethodInfoPtr_SetCardGlide_Private_Void_String_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676353);
			CardController.NativeMethodInfoPtr_GetCard_Private_PlayingCard_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676354);
			CardController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676355);
			CardController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676356);
			CardController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676357);
			CardController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676358);
			CardController.NativeMethodInfoPtr_RpcWriter___Server_SendCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676359);
			CardController.NativeMethodInfoPtr_RpcLogic___SendCardValue_3709737967_Public_Void_String_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676360);
			CardController.NativeMethodInfoPtr_RpcReader___Server_SendCardValue_3709737967_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676361);
			CardController.NativeMethodInfoPtr_RpcWriter___Observers_SetCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676362);
			CardController.NativeMethodInfoPtr_RpcLogic___SetCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676363);
			CardController.NativeMethodInfoPtr_RpcReader___Observers_SetCardValue_3709737967_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676364);
			CardController.NativeMethodInfoPtr_RpcWriter___Server_SendCardFaceUp_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676365);
			CardController.NativeMethodInfoPtr_RpcLogic___SendCardFaceUp_310431262_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676366);
			CardController.NativeMethodInfoPtr_RpcReader___Server_SendCardFaceUp_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676367);
			CardController.NativeMethodInfoPtr_RpcWriter___Observers_SetCardFaceUp_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676368);
			CardController.NativeMethodInfoPtr_RpcLogic___SetCardFaceUp_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676369);
			CardController.NativeMethodInfoPtr_RpcReader___Observers_SetCardFaceUp_310431262_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676370);
			CardController.NativeMethodInfoPtr_RpcWriter___Server_SendCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676371);
			CardController.NativeMethodInfoPtr_RpcLogic___SendCardGlide_2833372058_Public_Void_String_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676372);
			CardController.NativeMethodInfoPtr_RpcReader___Server_SendCardGlide_2833372058_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676373);
			CardController.NativeMethodInfoPtr_RpcWriter___Observers_SetCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676374);
			CardController.NativeMethodInfoPtr_RpcLogic___SetCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676375);
			CardController.NativeMethodInfoPtr_RpcReader___Observers_SetCardGlide_2833372058_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676376);
			CardController.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676377);
		}

		// Token: 0x06006704 RID: 26372 RVA: 0x001CF4D4 File Offset: 0x001CD6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208589, XrefRangeEnd = 208590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006705 RID: 26373 RVA: 0x001CF510 File Offset: 0x001CD710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208614, RefRangeEnd = 208615, XrefRangeStart = 208590, XrefRangeEnd = 208614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCardValue(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_SendCardValue_Public_Void_String_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006706 RID: 26374 RVA: 0x001CF570 File Offset: 0x001CD770
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208639, RefRangeEnd = 208641, XrefRangeStart = 208615, XrefRangeEnd = 208639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCardValue(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_SetCardValue_Private_Void_String_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006707 RID: 26375 RVA: 0x001CF5D0 File Offset: 0x001CD7D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208664, RefRangeEnd = 208666, XrefRangeStart = 208641, XrefRangeEnd = 208664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCardFaceUp(string cardId, bool faceUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_SendCardFaceUp_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006708 RID: 26376 RVA: 0x001CF620 File Offset: 0x001CD820
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208689, RefRangeEnd = 208691, XrefRangeStart = 208666, XrefRangeEnd = 208689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCardFaceUp(string cardId, bool faceUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_SetCardFaceUp_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006709 RID: 26377 RVA: 0x001CF670 File Offset: 0x001CD870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208694, RefRangeEnd = 208695, XrefRangeStart = 208691, XrefRangeEnd = 208694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCardGlide(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glideTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_SendCardGlide_Public_Void_String_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600670A RID: 26378 RVA: 0x001CF6DC File Offset: 0x001CD8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208695, XrefRangeEnd = 208697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCardGlide(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glideTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_SetCardGlide_Private_Void_String_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600670B RID: 26379 RVA: 0x001CF748 File Offset: 0x001CD948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208697, XrefRangeEnd = 208701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard GetCard(string cardId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_GetCard_Private_PlayingCard_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayingCard>(intPtr3) : null;
		}

		// Token: 0x0600670C RID: 26380 RVA: 0x001CF798 File Offset: 0x001CD998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208701, XrefRangeEnd = 208716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CardController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600670D RID: 26381 RVA: 0x001CF7D4 File Offset: 0x001CD9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208716, XrefRangeEnd = 208754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600670E RID: 26382 RVA: 0x001CF810 File Offset: 0x001CDA10
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600670F RID: 26383 RVA: 0x001CF84C File Offset: 0x001CDA4C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006710 RID: 26384 RVA: 0x001CF888 File Offset: 0x001CDA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208754, XrefRangeEnd = 208766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcWriter___Server_SendCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006711 RID: 26385 RVA: 0x001CF8E8 File Offset: 0x001CDAE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208639, RefRangeEnd = 208641, XrefRangeStart = 208639, XrefRangeEnd = 208641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcLogic___SendCardValue_3709737967_Public_Void_String_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006712 RID: 26386 RVA: 0x001CF948 File Offset: 0x001CDB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208766, XrefRangeEnd = 208772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendCardValue_3709737967(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcReader___Server_SendCardValue_3709737967_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006713 RID: 26387 RVA: 0x001CF9AC File Offset: 0x001CDBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208772, XrefRangeEnd = 208784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcWriter___Observers_SetCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006714 RID: 26388 RVA: 0x001CFA0C File Offset: 0x001CDC0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 208792, RefRangeEnd = 208795, XrefRangeStart = 208784, XrefRangeEnd = 208792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcLogic___SetCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006715 RID: 26389 RVA: 0x001CFA6C File Offset: 0x001CDC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208795, XrefRangeEnd = 208801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCardValue_3709737967(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcReader___Observers_SetCardValue_3709737967_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006716 RID: 26390 RVA: 0x001CFABC File Offset: 0x001CDCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208801, XrefRangeEnd = 208821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendCardFaceUp_310431262(string cardId, bool faceUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcWriter___Server_SendCardFaceUp_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006717 RID: 26391 RVA: 0x001CFB0C File Offset: 0x001CDD0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208689, RefRangeEnd = 208691, XrefRangeStart = 208689, XrefRangeEnd = 208691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendCardFaceUp_310431262(string cardId, bool faceUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcLogic___SendCardFaceUp_310431262_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006718 RID: 26392 RVA: 0x001CFB5C File Offset: 0x001CDD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208821, XrefRangeEnd = 208825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendCardFaceUp_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcReader___Server_SendCardFaceUp_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006719 RID: 26393 RVA: 0x001CFBC0 File Offset: 0x001CDDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208825, XrefRangeEnd = 208845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCardFaceUp_310431262(string cardId, bool faceUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcWriter___Observers_SetCardFaceUp_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671A RID: 26394 RVA: 0x001CFC10 File Offset: 0x001CDE10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 208853, RefRangeEnd = 208856, XrefRangeStart = 208845, XrefRangeEnd = 208853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetCardFaceUp_310431262(string cardId, bool faceUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcLogic___SetCardFaceUp_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x001CFC60 File Offset: 0x001CDE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208856, XrefRangeEnd = 208860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCardFaceUp_310431262(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcReader___Observers_SetCardFaceUp_310431262_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671C RID: 26396 RVA: 0x001CFCB0 File Offset: 0x001CDEB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208886, RefRangeEnd = 208887, XrefRangeStart = 208860, XrefRangeEnd = 208886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glideTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcWriter___Server_SendCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671D RID: 26397 RVA: 0x001CFD1C File Offset: 0x001CDF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glideTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcLogic___SendCardGlide_2833372058_Public_Void_String_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671E RID: 26398 RVA: 0x001CFD88 File Offset: 0x001CDF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208887, XrefRangeEnd = 208898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendCardGlide_2833372058(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcReader___Server_SendCardGlide_2833372058_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671F RID: 26399 RVA: 0x001CFDEC File Offset: 0x001CDFEC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 208924, RefRangeEnd = 208928, XrefRangeStart = 208898, XrefRangeEnd = 208924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glideTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcWriter___Observers_SetCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006720 RID: 26400 RVA: 0x001CFE58 File Offset: 0x001CE058
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 208936, RefRangeEnd = 208941, XrefRangeStart = 208928, XrefRangeEnd = 208936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glideTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcLogic___SetCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006721 RID: 26401 RVA: 0x001CFEC4 File Offset: 0x001CE0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208941, XrefRangeEnd = 208951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCardGlide_2833372058(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcReader___Observers_SetCardGlide_2833372058_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006722 RID: 26402 RVA: 0x001CFF14 File Offset: 0x001CE114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208992, RefRangeEnd = 208993, XrefRangeStart = 208951, XrefRangeEnd = 208992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006723 RID: 26403 RVA: 0x00030B59 File Offset: 0x0002ED59
		public CardController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x06006724 RID: 26404 RVA: 0x001CFF48 File Offset: 0x001CE148
		// (set) Token: 0x06006725 RID: 26405 RVA: 0x00030B62 File Offset: 0x0002ED62
		public unsafe List<PlayingCard> cards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x06006726 RID: 26406 RVA: 0x001CFF78 File Offset: 0x001CE178
		// (set) Token: 0x06006727 RID: 26407 RVA: 0x00030B81 File Offset: 0x0002ED81
		public unsafe Dictionary<string, PlayingCard> cardDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cardDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cardDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x06006728 RID: 26408 RVA: 0x001CFFA8 File Offset: 0x001CE1A8
		// (set) Token: 0x06006729 RID: 26409 RVA: 0x00030BA0 File Offset: 0x0002EDA0
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x0600672A RID: 26410 RVA: 0x001CFFD0 File Offset: 0x001CE1D0
		// (set) Token: 0x0600672B RID: 26411 RVA: 0x00030BBB File Offset: 0x0002EDBB
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400467E RID: 18046
		private static readonly IntPtr NativeFieldInfoPtr_cards;

		// Token: 0x0400467F RID: 18047
		private static readonly IntPtr NativeFieldInfoPtr_cardDictionary;

		// Token: 0x04004680 RID: 18048
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004681 RID: 18049
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004682 RID: 18050
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004683 RID: 18051
		private static readonly IntPtr NativeMethodInfoPtr_SendCardValue_Public_Void_String_ECardSuit_ECardValue_0;

		// Token: 0x04004684 RID: 18052
		private static readonly IntPtr NativeMethodInfoPtr_SetCardValue_Private_Void_String_ECardSuit_ECardValue_0;

		// Token: 0x04004685 RID: 18053
		private static readonly IntPtr NativeMethodInfoPtr_SendCardFaceUp_Public_Void_String_Boolean_0;

		// Token: 0x04004686 RID: 18054
		private static readonly IntPtr NativeMethodInfoPtr_SetCardFaceUp_Private_Void_String_Boolean_0;

		// Token: 0x04004687 RID: 18055
		private static readonly IntPtr NativeMethodInfoPtr_SendCardGlide_Public_Void_String_Vector3_Quaternion_Single_0;

		// Token: 0x04004688 RID: 18056
		private static readonly IntPtr NativeMethodInfoPtr_SetCardGlide_Private_Void_String_Vector3_Quaternion_Single_0;

		// Token: 0x04004689 RID: 18057
		private static readonly IntPtr NativeMethodInfoPtr_GetCard_Private_PlayingCard_String_0;

		// Token: 0x0400468A RID: 18058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400468B RID: 18059
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400468C RID: 18060
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400468D RID: 18061
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400468E RID: 18062
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0;

		// Token: 0x0400468F RID: 18063
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendCardValue_3709737967_Public_Void_String_ECardSuit_ECardValue_0;

		// Token: 0x04004690 RID: 18064
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendCardValue_3709737967_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004691 RID: 18065
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0;

		// Token: 0x04004692 RID: 18066
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0;

		// Token: 0x04004693 RID: 18067
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCardValue_3709737967_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004694 RID: 18068
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendCardFaceUp_310431262_Private_Void_String_Boolean_0;

		// Token: 0x04004695 RID: 18069
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendCardFaceUp_310431262_Public_Void_String_Boolean_0;

		// Token: 0x04004696 RID: 18070
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendCardFaceUp_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004697 RID: 18071
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCardFaceUp_310431262_Private_Void_String_Boolean_0;

		// Token: 0x04004698 RID: 18072
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCardFaceUp_310431262_Private_Void_String_Boolean_0;

		// Token: 0x04004699 RID: 18073
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCardFaceUp_310431262_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400469A RID: 18074
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0;

		// Token: 0x0400469B RID: 18075
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendCardGlide_2833372058_Public_Void_String_Vector3_Quaternion_Single_0;

		// Token: 0x0400469C RID: 18076
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendCardGlide_2833372058_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400469D RID: 18077
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0;

		// Token: 0x0400469E RID: 18078
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0;

		// Token: 0x0400469F RID: 18079
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCardGlide_2833372058_Private_Void_PooledReader_Channel_0;

		// Token: 0x040046A0 RID: 18080
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
