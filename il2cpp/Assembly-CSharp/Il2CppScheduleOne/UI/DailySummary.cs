using System;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000630 RID: 1584
	public class DailySummary : NetworkSingleton<DailySummary>
	{
		// Token: 0x06008BC2 RID: 35778 RVA: 0x0024896C File Offset: 0x00246B6C
		// Note: this type is marked as 'beforefieldinit'.
		static DailySummary()
		{
			Il2CppClassPointerStore<DailySummary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DailySummary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailySummary>.NativeClassPtr);
			DailySummary.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "<IsOpen>k__BackingField");
			DailySummary.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "Canvas");
			DailySummary.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "Container");
			DailySummary.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "Anim");
			DailySummary.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "TitleLabel");
			DailySummary.NativeFieldInfoPtr_ProductEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "ProductEntries");
			DailySummary.NativeFieldInfoPtr_PlayerEarningsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "PlayerEarningsLabel");
			DailySummary.NativeFieldInfoPtr_DealerEarningsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "DealerEarningsLabel");
			DailySummary.NativeFieldInfoPtr_XPGainedLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "XPGainedLabel");
			DailySummary.NativeFieldInfoPtr_onClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "onClosed");
			DailySummary.NativeFieldInfoPtr_itemsSoldByPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "itemsSoldByPlayer");
			DailySummary.NativeFieldInfoPtr_moneyEarnedByPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "moneyEarnedByPlayer");
			DailySummary.NativeFieldInfoPtr_moneyEarnedByDealers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "moneyEarnedByDealers");
			DailySummary.NativeFieldInfoPtr__xpGained_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "<xpGained>k__BackingField");
			DailySummary.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.UI.DailySummaryAssembly-CSharp.dll_Excuted");
			DailySummary.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.UI.DailySummaryAssembly-CSharp.dll_Excuted");
			DailySummary.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680652);
			DailySummary.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680653);
			DailySummary.NativeMethodInfoPtr_get_xpGained_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680654);
			DailySummary.NativeMethodInfoPtr_set_xpGained_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680655);
			DailySummary.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680656);
			DailySummary.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680657);
			DailySummary.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680658);
			DailySummary.NativeMethodInfoPtr_SleepEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680659);
			DailySummary.NativeMethodInfoPtr_AddSoldItem_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680660);
			DailySummary.NativeMethodInfoPtr_AddPlayerMoney_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680661);
			DailySummary.NativeMethodInfoPtr_AddDealerMoney_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680662);
			DailySummary.NativeMethodInfoPtr_AddXP_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680663);
			DailySummary.NativeMethodInfoPtr_ClearStats_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680664);
			DailySummary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680665);
			DailySummary.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680666);
			DailySummary.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680667);
			DailySummary.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680668);
			DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddSoldItem_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680669);
			DailySummary.NativeMethodInfoPtr_RpcLogic___AddSoldItem_3643459082_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680670);
			DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddSoldItem_3643459082_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680671);
			DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerMoney_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680672);
			DailySummary.NativeMethodInfoPtr_RpcLogic___AddPlayerMoney_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680673);
			DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerMoney_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680674);
			DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddDealerMoney_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680675);
			DailySummary.NativeMethodInfoPtr_RpcLogic___AddDealerMoney_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680676);
			DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddDealerMoney_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680677);
			DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddXP_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680678);
			DailySummary.NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680679);
			DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddXP_3316948804_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680680);
			DailySummary.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680681);
		}

		// Token: 0x17002AAE RID: 10926
		// (get) Token: 0x06008BC3 RID: 35779 RVA: 0x00248D34 File Offset: 0x00246F34
		// (set) Token: 0x06008BC4 RID: 35780 RVA: 0x00248D70 File Offset: 0x00246F70
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002AAF RID: 10927
		// (get) Token: 0x06008BC5 RID: 35781 RVA: 0x00248DB0 File Offset: 0x00246FB0
		// (set) Token: 0x06008BC6 RID: 35782 RVA: 0x00248DEC File Offset: 0x00246FEC
		public unsafe int xpGained
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_get_xpGained_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_set_xpGained_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008BC7 RID: 35783 RVA: 0x00248E2C File Offset: 0x0024702C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256102, XrefRangeEnd = 256120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BC8 RID: 35784 RVA: 0x00248E68 File Offset: 0x00247068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256202, RefRangeEnd = 256203, XrefRangeStart = 256120, XrefRangeEnd = 256202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BC9 RID: 35785 RVA: 0x00248E9C File Offset: 0x0024709C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256203, XrefRangeEnd = 256213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BCA RID: 35786 RVA: 0x00248ED0 File Offset: 0x002470D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256213, XrefRangeEnd = 256216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_SleepEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BCB RID: 35787 RVA: 0x00248F04 File Offset: 0x00247104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256217, RefRangeEnd = 256218, XrefRangeStart = 256216, XrefRangeEnd = 256217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSoldItem(string id, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_AddSoldItem_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BCC RID: 35788 RVA: 0x00248F54 File Offset: 0x00247154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256237, RefRangeEnd = 256238, XrefRangeStart = 256218, XrefRangeEnd = 256237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerMoney(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_AddPlayerMoney_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BCD RID: 35789 RVA: 0x00248F94 File Offset: 0x00247194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256257, RefRangeEnd = 256258, XrefRangeStart = 256238, XrefRangeEnd = 256257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDealerMoney(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_AddDealerMoney_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BCE RID: 35790 RVA: 0x00248FD4 File Offset: 0x002471D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256278, RefRangeEnd = 256279, XrefRangeStart = 256258, XrefRangeEnd = 256278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddXP(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_AddXP_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BCF RID: 35791 RVA: 0x00249014 File Offset: 0x00247214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearStats()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_ClearStats_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BD0 RID: 35792 RVA: 0x00249048 File Offset: 0x00247248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256279, XrefRangeEnd = 256289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailySummary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailySummary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BD1 RID: 35793 RVA: 0x00249084 File Offset: 0x00247284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256289, XrefRangeEnd = 256317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BD2 RID: 35794 RVA: 0x002490C0 File Offset: 0x002472C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256317, XrefRangeEnd = 256320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BD3 RID: 35795 RVA: 0x002490FC File Offset: 0x002472FC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BD4 RID: 35796 RVA: 0x00249138 File Offset: 0x00247338
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256351, RefRangeEnd = 256352, XrefRangeStart = 256320, XrefRangeEnd = 256351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddSoldItem_3643459082(string id, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddSoldItem_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BD5 RID: 35797 RVA: 0x00249188 File Offset: 0x00247388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256352, XrefRangeEnd = 256365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddSoldItem_3643459082(string id, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcLogic___AddSoldItem_3643459082_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BD6 RID: 35798 RVA: 0x002491D8 File Offset: 0x002473D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256365, XrefRangeEnd = 256377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddSoldItem_3643459082(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddSoldItem_3643459082_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BD7 RID: 35799 RVA: 0x00249228 File Offset: 0x00247428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256237, RefRangeEnd = 256238, XrefRangeStart = 256237, XrefRangeEnd = 256238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddPlayerMoney_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerMoney_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BD8 RID: 35800 RVA: 0x00249268 File Offset: 0x00247468
		[CallerCount(0)]
		public unsafe void RpcLogic___AddPlayerMoney_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcLogic___AddPlayerMoney_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BD9 RID: 35801 RVA: 0x002492A8 File Offset: 0x002474A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256377, XrefRangeEnd = 256379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddPlayerMoney_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerMoney_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BDA RID: 35802 RVA: 0x002492F8 File Offset: 0x002474F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256257, RefRangeEnd = 256258, XrefRangeStart = 256257, XrefRangeEnd = 256258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddDealerMoney_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddDealerMoney_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BDB RID: 35803 RVA: 0x00249338 File Offset: 0x00247538
		[CallerCount(0)]
		public unsafe void RpcLogic___AddDealerMoney_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcLogic___AddDealerMoney_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BDC RID: 35804 RVA: 0x00249378 File Offset: 0x00247578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256379, XrefRangeEnd = 256381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddDealerMoney_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddDealerMoney_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BDD RID: 35805 RVA: 0x002493C8 File Offset: 0x002475C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256278, RefRangeEnd = 256279, XrefRangeStart = 256278, XrefRangeEnd = 256279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddXP_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddXP_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BDE RID: 35806 RVA: 0x00249408 File Offset: 0x00247608
		[CallerCount(0)]
		public unsafe void RpcLogic___AddXP_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BDF RID: 35807 RVA: 0x00249448 File Offset: 0x00247648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256381, XrefRangeEnd = 256384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddXP_3316948804(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddXP_3316948804_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BE0 RID: 35808 RVA: 0x00249498 File Offset: 0x00247698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256384, XrefRangeEnd = 256387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BE1 RID: 35809 RVA: 0x00042EE7 File Offset: 0x000410E7
		public DailySummary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A9E RID: 10910
		// (get) Token: 0x06008BE2 RID: 35810 RVA: 0x002494D4 File Offset: 0x002476D4
		// (set) Token: 0x06008BE3 RID: 35811 RVA: 0x00042EF0 File Offset: 0x000410F0
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A9F RID: 10911
		// (get) Token: 0x06008BE4 RID: 35812 RVA: 0x002494FC File Offset: 0x002476FC
		// (set) Token: 0x06008BE5 RID: 35813 RVA: 0x00042F0B File Offset: 0x0004110B
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AA0 RID: 10912
		// (get) Token: 0x06008BE6 RID: 35814 RVA: 0x0024952C File Offset: 0x0024772C
		// (set) Token: 0x06008BE7 RID: 35815 RVA: 0x00042F2A File Offset: 0x0004112A
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AA1 RID: 10913
		// (get) Token: 0x06008BE8 RID: 35816 RVA: 0x0024955C File Offset: 0x0024775C
		// (set) Token: 0x06008BE9 RID: 35817 RVA: 0x00042F49 File Offset: 0x00041149
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AA2 RID: 10914
		// (get) Token: 0x06008BEA RID: 35818 RVA: 0x0024958C File Offset: 0x0024778C
		// (set) Token: 0x06008BEB RID: 35819 RVA: 0x00042F68 File Offset: 0x00041168
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AA3 RID: 10915
		// (get) Token: 0x06008BEC RID: 35820 RVA: 0x002495BC File Offset: 0x002477BC
		// (set) Token: 0x06008BED RID: 35821 RVA: 0x00042F87 File Offset: 0x00041187
		public unsafe Il2CppReferenceArray<RectTransform> ProductEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_ProductEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_ProductEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AA4 RID: 10916
		// (get) Token: 0x06008BEE RID: 35822 RVA: 0x002495EC File Offset: 0x002477EC
		// (set) Token: 0x06008BEF RID: 35823 RVA: 0x00042FA6 File Offset: 0x000411A6
		public unsafe TextMeshProUGUI PlayerEarningsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_PlayerEarningsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_PlayerEarningsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AA5 RID: 10917
		// (get) Token: 0x06008BF0 RID: 35824 RVA: 0x0024961C File Offset: 0x0024781C
		// (set) Token: 0x06008BF1 RID: 35825 RVA: 0x00042FC5 File Offset: 0x000411C5
		public unsafe TextMeshProUGUI DealerEarningsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_DealerEarningsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_DealerEarningsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AA6 RID: 10918
		// (get) Token: 0x06008BF2 RID: 35826 RVA: 0x0024964C File Offset: 0x0024784C
		// (set) Token: 0x06008BF3 RID: 35827 RVA: 0x00042FE4 File Offset: 0x000411E4
		public unsafe TextMeshProUGUI XPGainedLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_XPGainedLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_XPGainedLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AA7 RID: 10919
		// (get) Token: 0x06008BF4 RID: 35828 RVA: 0x0024967C File Offset: 0x0024787C
		// (set) Token: 0x06008BF5 RID: 35829 RVA: 0x00043003 File Offset: 0x00041203
		public unsafe UnityEvent onClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_onClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_onClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AA8 RID: 10920
		// (get) Token: 0x06008BF6 RID: 35830 RVA: 0x002496AC File Offset: 0x002478AC
		// (set) Token: 0x06008BF7 RID: 35831 RVA: 0x00043022 File Offset: 0x00041222
		public unsafe Dictionary<string, int> itemsSoldByPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_itemsSoldByPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_itemsSoldByPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AA9 RID: 10921
		// (get) Token: 0x06008BF8 RID: 35832 RVA: 0x002496DC File Offset: 0x002478DC
		// (set) Token: 0x06008BF9 RID: 35833 RVA: 0x00043041 File Offset: 0x00041241
		public unsafe float moneyEarnedByPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_moneyEarnedByPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_moneyEarnedByPlayer)) = value;
			}
		}

		// Token: 0x17002AAA RID: 10922
		// (get) Token: 0x06008BFA RID: 35834 RVA: 0x00249704 File Offset: 0x00247904
		// (set) Token: 0x06008BFB RID: 35835 RVA: 0x0004305C File Offset: 0x0004125C
		public unsafe float moneyEarnedByDealers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_moneyEarnedByDealers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_moneyEarnedByDealers)) = value;
			}
		}

		// Token: 0x17002AAB RID: 10923
		// (get) Token: 0x06008BFC RID: 35836 RVA: 0x0024972C File Offset: 0x0024792C
		// (set) Token: 0x06008BFD RID: 35837 RVA: 0x00043077 File Offset: 0x00041277
		public unsafe int _xpGained_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr__xpGained_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr__xpGained_k__BackingField)) = value;
			}
		}

		// Token: 0x17002AAC RID: 10924
		// (get) Token: 0x06008BFE RID: 35838 RVA: 0x00249754 File Offset: 0x00247954
		// (set) Token: 0x06008BFF RID: 35839 RVA: 0x00043092 File Offset: 0x00041292
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002AAD RID: 10925
		// (get) Token: 0x06008C00 RID: 35840 RVA: 0x0024977C File Offset: 0x0024797C
		// (set) Token: 0x06008C01 RID: 35841 RVA: 0x000430AD File Offset: 0x000412AD
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04005EC1 RID: 24257
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005EC2 RID: 24258
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04005EC3 RID: 24259
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005EC4 RID: 24260
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04005EC5 RID: 24261
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04005EC6 RID: 24262
		private static readonly IntPtr NativeFieldInfoPtr_ProductEntries;

		// Token: 0x04005EC7 RID: 24263
		private static readonly IntPtr NativeFieldInfoPtr_PlayerEarningsLabel;

		// Token: 0x04005EC8 RID: 24264
		private static readonly IntPtr NativeFieldInfoPtr_DealerEarningsLabel;

		// Token: 0x04005EC9 RID: 24265
		private static readonly IntPtr NativeFieldInfoPtr_XPGainedLabel;

		// Token: 0x04005ECA RID: 24266
		private static readonly IntPtr NativeFieldInfoPtr_onClosed;

		// Token: 0x04005ECB RID: 24267
		private static readonly IntPtr NativeFieldInfoPtr_itemsSoldByPlayer;

		// Token: 0x04005ECC RID: 24268
		private static readonly IntPtr NativeFieldInfoPtr_moneyEarnedByPlayer;

		// Token: 0x04005ECD RID: 24269
		private static readonly IntPtr NativeFieldInfoPtr_moneyEarnedByDealers;

		// Token: 0x04005ECE RID: 24270
		private static readonly IntPtr NativeFieldInfoPtr__xpGained_k__BackingField;

		// Token: 0x04005ECF RID: 24271
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005ED0 RID: 24272
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005ED1 RID: 24273
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005ED2 RID: 24274
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04005ED3 RID: 24275
		private static readonly IntPtr NativeMethodInfoPtr_get_xpGained_Public_get_Int32_0;

		// Token: 0x04005ED4 RID: 24276
		private static readonly IntPtr NativeMethodInfoPtr_set_xpGained_Private_set_Void_Int32_0;

		// Token: 0x04005ED5 RID: 24277
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005ED6 RID: 24278
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04005ED7 RID: 24279
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005ED8 RID: 24280
		private static readonly IntPtr NativeMethodInfoPtr_SleepEnd_Private_Void_0;

		// Token: 0x04005ED9 RID: 24281
		private static readonly IntPtr NativeMethodInfoPtr_AddSoldItem_Public_Void_String_Int32_0;

		// Token: 0x04005EDA RID: 24282
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayerMoney_Public_Void_Single_0;

		// Token: 0x04005EDB RID: 24283
		private static readonly IntPtr NativeMethodInfoPtr_AddDealerMoney_Public_Void_Single_0;

		// Token: 0x04005EDC RID: 24284
		private static readonly IntPtr NativeMethodInfoPtr_AddXP_Public_Void_Int32_0;

		// Token: 0x04005EDD RID: 24285
		private static readonly IntPtr NativeMethodInfoPtr_ClearStats_Private_Void_0;

		// Token: 0x04005EDE RID: 24286
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005EDF RID: 24287
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005EE0 RID: 24288
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04005EE1 RID: 24289
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04005EE2 RID: 24290
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddSoldItem_3643459082_Private_Void_String_Int32_0;

		// Token: 0x04005EE3 RID: 24291
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddSoldItem_3643459082_Public_Void_String_Int32_0;

		// Token: 0x04005EE4 RID: 24292
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddSoldItem_3643459082_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005EE5 RID: 24293
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerMoney_431000436_Private_Void_Single_0;

		// Token: 0x04005EE6 RID: 24294
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddPlayerMoney_431000436_Public_Void_Single_0;

		// Token: 0x04005EE7 RID: 24295
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddPlayerMoney_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005EE8 RID: 24296
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddDealerMoney_431000436_Private_Void_Single_0;

		// Token: 0x04005EE9 RID: 24297
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddDealerMoney_431000436_Public_Void_Single_0;

		// Token: 0x04005EEA RID: 24298
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddDealerMoney_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005EEB RID: 24299
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddXP_3316948804_Private_Void_Int32_0;

		// Token: 0x04005EEC RID: 24300
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0;

		// Token: 0x04005EED RID: 24301
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddXP_3316948804_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005EEE RID: 24302
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000B19 RID: 2841
		[ObfuscatedName("ScheduleOne.UI.DailySummary+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D6F7 RID: 55031 RVA: 0x003325F4 File Offset: 0x003307F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr);
				DailySummary.__c__DisplayClass21_0.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr, "items");
				DailySummary.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				DailySummary.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr, 100680682);
				DailySummary.__c__DisplayClass21_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr, 100680683);
			}

			// Token: 0x0600D6F8 RID: 55032 RVA: 0x00332670 File Offset: 0x00330870
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6F9 RID: 55033 RVA: 0x003326AC File Offset: 0x003308AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256097, XrefRangeEnd = 256102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D6FA RID: 55034 RVA: 0x000689DF File Offset: 0x00066BDF
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004297 RID: 17047
			// (get) Token: 0x0600D6FB RID: 55035 RVA: 0x003326EC File Offset: 0x003308EC
			// (set) Token: 0x0600D6FC RID: 55036 RVA: 0x000689E8 File Offset: 0x00066BE8
			public unsafe Il2CppStringArray items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.NativeFieldInfoPtr_items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004298 RID: 17048
			// (get) Token: 0x0600D6FD RID: 55037 RVA: 0x0033271C File Offset: 0x0033091C
			// (set) Token: 0x0600D6FE RID: 55038 RVA: 0x00068A07 File Offset: 0x00066C07
			public unsafe DailySummary __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailySummary>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400908D RID: 37005
			private static readonly IntPtr NativeFieldInfoPtr_items;

			// Token: 0x0400908E RID: 37006
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400908F RID: 37007
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009090 RID: 37008
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C70 RID: 3184
			[ObfuscatedName("ScheduleOne.UI.DailySummary+<>c__DisplayClass21_0+<<Open>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E525 RID: 58661 RVA: 0x0035B380 File Offset: 0x00359580
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr, "<<Open>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680684);
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680685);
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680686);
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680687);
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680688);
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680689);
				}

				// Token: 0x0600E526 RID: 58662 RVA: 0x0035B460 File Offset: 0x00359660
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E527 RID: 58663 RVA: 0x0035B4A8 File Offset: 0x003596A8
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E528 RID: 58664 RVA: 0x0035B4DC File Offset: 0x003596DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256086, XrefRangeEnd = 256092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700473A RID: 18234
				// (get) Token: 0x0600E529 RID: 58665 RVA: 0x0035B518 File Offset: 0x00359718
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E52A RID: 58666 RVA: 0x0035B558 File Offset: 0x00359758
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256092, XrefRangeEnd = 256097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700473B RID: 18235
				// (get) Token: 0x0600E52B RID: 58667 RVA: 0x0035B58C File Offset: 0x0035978C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E52C RID: 58668 RVA: 0x0006FBEB File Offset: 0x0006DDEB
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004737 RID: 18231
				// (get) Token: 0x0600E52D RID: 58669 RVA: 0x0035B5CC File Offset: 0x003597CC
				// (set) Token: 0x0600E52E RID: 58670 RVA: 0x0006FBF4 File Offset: 0x0006DDF4
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004738 RID: 18232
				// (get) Token: 0x0600E52F RID: 58671 RVA: 0x0035B5F4 File Offset: 0x003597F4
				// (set) Token: 0x0600E530 RID: 58672 RVA: 0x0006FC0F File Offset: 0x0006DE0F
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004739 RID: 18233
				// (get) Token: 0x0600E531 RID: 58673 RVA: 0x0035B624 File Offset: 0x00359824
				// (set) Token: 0x0600E532 RID: 58674 RVA: 0x0006FC2E File Offset: 0x0006DE2E
				public unsafe DailySummary.__c__DisplayClass21_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailySummary.__c__DisplayClass21_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400993E RID: 39230
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400993F RID: 39231
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009940 RID: 39232
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009941 RID: 39233
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009942 RID: 39234
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009943 RID: 39235
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009944 RID: 39236
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009945 RID: 39237
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009946 RID: 39238
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
