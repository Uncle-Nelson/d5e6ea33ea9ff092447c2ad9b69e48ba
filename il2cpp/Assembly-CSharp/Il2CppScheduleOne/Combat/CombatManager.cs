using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000490 RID: 1168
	public class CombatManager : NetworkSingleton<CombatManager>
	{
		// Token: 0x0600651C RID: 25884 RVA: 0x001C8AF0 File Offset: 0x001C6CF0
		// Note: this type is marked as 'beforefieldinit'.
		static CombatManager()
		{
			Il2CppClassPointerStore<CombatManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "CombatManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatManager>.NativeClassPtr);
			CombatManager.NativeFieldInfoPtr_MeleeLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "MeleeLayerMask");
			CombatManager.NativeFieldInfoPtr_ExplosionLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "ExplosionLayerMask");
			CombatManager.NativeFieldInfoPtr_RangedWeaponLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "RangedWeaponLayerMask");
			CombatManager.NativeFieldInfoPtr_ExplosionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "ExplosionPrefab");
			CombatManager.NativeFieldInfoPtr_explosionIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "explosionIDs");
			CombatManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Combat.CombatManagerAssembly-CSharp.dll_Excuted");
			CombatManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Combat.CombatManagerAssembly-CSharp.dll_Excuted");
			CombatManager.NativeMethodInfoPtr_CreateTestExplosion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676096);
			CombatManager.NativeMethodInfoPtr_CreateExplosion_Public_Void_Vector3_ExplosionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676097);
			CombatManager.NativeMethodInfoPtr_CreateExplosion_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676098);
			CombatManager.NativeMethodInfoPtr_Explosion_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676099);
			CombatManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676100);
			CombatManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676101);
			CombatManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676102);
			CombatManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676103);
			CombatManager.NativeMethodInfoPtr_RpcWriter___Server_CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676104);
			CombatManager.NativeMethodInfoPtr_RpcLogic___CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676105);
			CombatManager.NativeMethodInfoPtr_RpcReader___Server_CreateExplosion_2907189355_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676106);
			CombatManager.NativeMethodInfoPtr_RpcWriter___Observers_Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676107);
			CombatManager.NativeMethodInfoPtr_RpcLogic___Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676108);
			CombatManager.NativeMethodInfoPtr_RpcReader___Observers_Explosion_2907189355_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676109);
			CombatManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676110);
		}

		// Token: 0x0600651D RID: 25885 RVA: 0x001C8CD8 File Offset: 0x001C6ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205637, XrefRangeEnd = 205659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTestExplosion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_CreateTestExplosion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600651E RID: 25886 RVA: 0x001C8D0C File Offset: 0x001C6F0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205661, RefRangeEnd = 205662, XrefRangeStart = 205659, XrefRangeEnd = 205661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateExplosion(Vector3 origin, ExplosionData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_CreateExplosion_Public_Void_Vector3_ExplosionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600651F RID: 25887 RVA: 0x001C8D58 File Offset: 0x001C6F58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205688, RefRangeEnd = 205690, XrefRangeStart = 205662, XrefRangeEnd = 205688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateExplosion(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_CreateExplosion_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006520 RID: 25888 RVA: 0x001C8DB4 File Offset: 0x001C6FB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 205716, RefRangeEnd = 205719, XrefRangeStart = 205690, XrefRangeEnd = 205716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Explosion(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_Explosion_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006521 RID: 25889 RVA: 0x001C8E10 File Offset: 0x001C7010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205719, XrefRangeEnd = 205731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CombatManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006522 RID: 25890 RVA: 0x001C8E4C File Offset: 0x001C704C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205731, XrefRangeEnd = 205748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006523 RID: 25891 RVA: 0x001C8E88 File Offset: 0x001C7088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205748, XrefRangeEnd = 205751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006524 RID: 25892 RVA: 0x001C8EC4 File Offset: 0x001C70C4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006525 RID: 25893 RVA: 0x001C8F00 File Offset: 0x001C7100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205751, XrefRangeEnd = 205766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CreateExplosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcWriter___Server_CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006526 RID: 25894 RVA: 0x001C8F5C File Offset: 0x001C715C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205766, XrefRangeEnd = 205767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateExplosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcLogic___CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006527 RID: 25895 RVA: 0x001C8FB8 File Offset: 0x001C71B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205767, XrefRangeEnd = 205776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CreateExplosion_2907189355(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcReader___Server_CreateExplosion_2907189355_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006528 RID: 25896 RVA: 0x001C901C File Offset: 0x001C721C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205776, XrefRangeEnd = 205791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Explosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcWriter___Observers_Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006529 RID: 25897 RVA: 0x001C9078 File Offset: 0x001C7278
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205807, RefRangeEnd = 205809, XrefRangeStart = 205791, XrefRangeEnd = 205807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Explosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcLogic___Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600652A RID: 25898 RVA: 0x001C90D4 File Offset: 0x001C72D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205809, XrefRangeEnd = 205818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Explosion_2907189355(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcReader___Observers_Explosion_2907189355_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600652B RID: 25899 RVA: 0x001C9124 File Offset: 0x001C7324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205818, XrefRangeEnd = 205821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x0002FD3A File Offset: 0x0002DF3A
		public CombatManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E70 RID: 7792
		// (get) Token: 0x0600652D RID: 25901 RVA: 0x001C9160 File Offset: 0x001C7360
		// (set) Token: 0x0600652E RID: 25902 RVA: 0x0002FD43 File Offset: 0x0002DF43
		public unsafe LayerMask MeleeLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_MeleeLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_MeleeLayerMask)) = value;
			}
		}

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x0600652F RID: 25903 RVA: 0x001C9188 File Offset: 0x001C7388
		// (set) Token: 0x06006530 RID: 25904 RVA: 0x0002FD5E File Offset: 0x0002DF5E
		public unsafe LayerMask ExplosionLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_ExplosionLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_ExplosionLayerMask)) = value;
			}
		}

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x06006531 RID: 25905 RVA: 0x001C91B0 File Offset: 0x001C73B0
		// (set) Token: 0x06006532 RID: 25906 RVA: 0x0002FD79 File Offset: 0x0002DF79
		public unsafe LayerMask RangedWeaponLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_RangedWeaponLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_RangedWeaponLayerMask)) = value;
			}
		}

		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x06006533 RID: 25907 RVA: 0x001C91D8 File Offset: 0x001C73D8
		// (set) Token: 0x06006534 RID: 25908 RVA: 0x0002FD94 File Offset: 0x0002DF94
		public unsafe Explosion ExplosionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_ExplosionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Explosion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_ExplosionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x06006535 RID: 25909 RVA: 0x001C9208 File Offset: 0x001C7408
		// (set) Token: 0x06006536 RID: 25910 RVA: 0x0002FDB3 File Offset: 0x0002DFB3
		public unsafe List<int> explosionIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_explosionIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_explosionIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x06006537 RID: 25911 RVA: 0x001C9238 File Offset: 0x001C7438
		// (set) Token: 0x06006538 RID: 25912 RVA: 0x0002FDD2 File Offset: 0x0002DFD2
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x06006539 RID: 25913 RVA: 0x001C9260 File Offset: 0x001C7460
		// (set) Token: 0x0600653A RID: 25914 RVA: 0x0002FDED File Offset: 0x0002DFED
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040044F9 RID: 17657
		private static readonly IntPtr NativeFieldInfoPtr_MeleeLayerMask;

		// Token: 0x040044FA RID: 17658
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionLayerMask;

		// Token: 0x040044FB RID: 17659
		private static readonly IntPtr NativeFieldInfoPtr_RangedWeaponLayerMask;

		// Token: 0x040044FC RID: 17660
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionPrefab;

		// Token: 0x040044FD RID: 17661
		private static readonly IntPtr NativeFieldInfoPtr_explosionIDs;

		// Token: 0x040044FE RID: 17662
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040044FF RID: 17663
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004500 RID: 17664
		private static readonly IntPtr NativeMethodInfoPtr_CreateTestExplosion_Public_Void_0;

		// Token: 0x04004501 RID: 17665
		private static readonly IntPtr NativeMethodInfoPtr_CreateExplosion_Public_Void_Vector3_ExplosionData_0;

		// Token: 0x04004502 RID: 17666
		private static readonly IntPtr NativeMethodInfoPtr_CreateExplosion_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x04004503 RID: 17667
		private static readonly IntPtr NativeMethodInfoPtr_Explosion_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x04004504 RID: 17668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004505 RID: 17669
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004506 RID: 17670
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004507 RID: 17671
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004508 RID: 17672
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x04004509 RID: 17673
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x0400450A RID: 17674
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_CreateExplosion_2907189355_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400450B RID: 17675
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x0400450C RID: 17676
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x0400450D RID: 17677
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Explosion_2907189355_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400450E RID: 17678
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
