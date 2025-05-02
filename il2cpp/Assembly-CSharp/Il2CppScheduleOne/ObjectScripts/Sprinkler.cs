using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000754 RID: 1876
	public class Sprinkler : GridItem
	{
		// Token: 0x0600B243 RID: 45635 RVA: 0x002C7B14 File Offset: 0x002C5D14
		// Note: this type is marked as 'beforefieldinit'.
		static Sprinkler()
		{
			Il2CppClassPointerStore<Sprinkler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Sprinkler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr);
			Sprinkler.NativeFieldInfoPtr__IsSprinkling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "<IsSprinkling>k__BackingField");
			Sprinkler.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "IntObj");
			Sprinkler.NativeFieldInfoPtr_WaterParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "WaterParticles");
			Sprinkler.NativeFieldInfoPtr_ClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "ClickSound");
			Sprinkler.NativeFieldInfoPtr_WaterSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "WaterSound");
			Sprinkler.NativeFieldInfoPtr_ApplyWaterDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "ApplyWaterDelay");
			Sprinkler.NativeFieldInfoPtr_ParticleStopDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "ParticleStopDelay");
			Sprinkler.NativeFieldInfoPtr_onSprinklerStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "onSprinklerStart");
			Sprinkler.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.SprinklerAssembly-CSharp.dll_Excuted");
			Sprinkler.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.SprinklerAssembly-CSharp.dll_Excuted");
			Sprinkler.NativeMethodInfoPtr_get_IsSprinkling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685263);
			Sprinkler.NativeMethodInfoPtr_set_IsSprinkling_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685264);
			Sprinkler.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685265);
			Sprinkler.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685266);
			Sprinkler.NativeMethodInfoPtr_CanWater_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685267);
			Sprinkler.NativeMethodInfoPtr_SendWater_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685268);
			Sprinkler.NativeMethodInfoPtr_Water_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685269);
			Sprinkler.NativeMethodInfoPtr_ApplyWater_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685270);
			Sprinkler.NativeMethodInfoPtr_GetPots_Protected_Virtual_New_List_1_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685271);
			Sprinkler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685272);
			Sprinkler.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685273);
			Sprinkler.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685274);
			Sprinkler.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685275);
			Sprinkler.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685276);
			Sprinkler.NativeMethodInfoPtr_RpcWriter___Server_SendWater_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685277);
			Sprinkler.NativeMethodInfoPtr_RpcLogic___SendWater_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685278);
			Sprinkler.NativeMethodInfoPtr_RpcReader___Server_SendWater_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685279);
			Sprinkler.NativeMethodInfoPtr_RpcWriter___Observers_Water_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685280);
			Sprinkler.NativeMethodInfoPtr_RpcLogic___Water_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685281);
			Sprinkler.NativeMethodInfoPtr_RpcReader___Observers_Water_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685282);
			Sprinkler.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685283);
		}

		// Token: 0x1700375A RID: 14170
		// (get) Token: 0x0600B244 RID: 45636 RVA: 0x002C7DB0 File Offset: 0x002C5FB0
		// (set) Token: 0x0600B245 RID: 45637 RVA: 0x002C7DEC File Offset: 0x002C5FEC
		public unsafe bool IsSprinkling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_get_IsSprinkling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_set_IsSprinkling_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B246 RID: 45638 RVA: 0x002C7E2C File Offset: 0x002C602C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307528, XrefRangeEnd = 307529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B247 RID: 45639 RVA: 0x002C7E60 File Offset: 0x002C6060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307529, XrefRangeEnd = 307549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B248 RID: 45640 RVA: 0x002C7E94 File Offset: 0x002C6094
		[CallerCount(0)]
		public unsafe bool CanWater()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_CanWater_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B249 RID: 45641 RVA: 0x002C7ED0 File Offset: 0x002C60D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307549, XrefRangeEnd = 307570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendWater()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_SendWater_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B24A RID: 45642 RVA: 0x002C7F04 File Offset: 0x002C6104
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307591, RefRangeEnd = 307594, XrefRangeStart = 307570, XrefRangeEnd = 307591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Water()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_Water_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B24B RID: 45643 RVA: 0x002C7F38 File Offset: 0x002C6138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307594, XrefRangeEnd = 307603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyWater(float normalizedAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_ApplyWater_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B24C RID: 45644 RVA: 0x002C7F78 File Offset: 0x002C6178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307603, XrefRangeEnd = 307662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<Pot> GetPots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sprinkler.NativeMethodInfoPtr_GetPots_Protected_Virtual_New_List_1_Pot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr3) : null;
		}

		// Token: 0x0600B24D RID: 45645 RVA: 0x002C7FC4 File Offset: 0x002C61C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307662, XrefRangeEnd = 307663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprinkler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B24E RID: 45646 RVA: 0x002C8000 File Offset: 0x002C6200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307663, XrefRangeEnd = 307668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B24F RID: 45647 RVA: 0x002C8040 File Offset: 0x002C6240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307668, XrefRangeEnd = 307683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sprinkler.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B250 RID: 45648 RVA: 0x002C807C File Offset: 0x002C627C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307683, XrefRangeEnd = 307684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sprinkler.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B251 RID: 45649 RVA: 0x002C80B8 File Offset: 0x002C62B8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sprinkler.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B252 RID: 45650 RVA: 0x002C80F4 File Offset: 0x002C62F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307684, XrefRangeEnd = 307702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendWater_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_RpcWriter___Server_SendWater_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B253 RID: 45651 RVA: 0x002C8128 File Offset: 0x002C6328
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307591, RefRangeEnd = 307594, XrefRangeStart = 307591, XrefRangeEnd = 307594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendWater_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_RpcLogic___SendWater_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B254 RID: 45652 RVA: 0x002C815C File Offset: 0x002C635C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307702, XrefRangeEnd = 307705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendWater_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_RpcReader___Server_SendWater_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B255 RID: 45653 RVA: 0x002C81C0 File Offset: 0x002C63C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307705, XrefRangeEnd = 307723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Water_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_RpcWriter___Observers_Water_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B256 RID: 45654 RVA: 0x002C81F4 File Offset: 0x002C63F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307729, RefRangeEnd = 307732, XrefRangeStart = 307723, XrefRangeEnd = 307729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Water_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_RpcLogic___Water_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B257 RID: 45655 RVA: 0x002C8228 File Offset: 0x002C6428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307732, XrefRangeEnd = 307735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Water_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_RpcReader___Observers_Water_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B258 RID: 45656 RVA: 0x002C8278 File Offset: 0x002C6478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291098, RefRangeEnd = 291099, XrefRangeStart = 291098, XrefRangeEnd = 291099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sprinkler.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B259 RID: 45657 RVA: 0x0005770A File Offset: 0x0005590A
		public Sprinkler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003750 RID: 14160
		// (get) Token: 0x0600B25A RID: 45658 RVA: 0x002C82B4 File Offset: 0x002C64B4
		// (set) Token: 0x0600B25B RID: 45659 RVA: 0x00057713 File Offset: 0x00055913
		public unsafe bool _IsSprinkling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr__IsSprinkling_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr__IsSprinkling_k__BackingField)) = value;
			}
		}

		// Token: 0x17003751 RID: 14161
		// (get) Token: 0x0600B25C RID: 45660 RVA: 0x002C82DC File Offset: 0x002C64DC
		// (set) Token: 0x0600B25D RID: 45661 RVA: 0x0005772E File Offset: 0x0005592E
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003752 RID: 14162
		// (get) Token: 0x0600B25E RID: 45662 RVA: 0x002C830C File Offset: 0x002C650C
		// (set) Token: 0x0600B25F RID: 45663 RVA: 0x0005774D File Offset: 0x0005594D
		public unsafe Il2CppReferenceArray<ParticleSystem> WaterParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_WaterParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_WaterParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003753 RID: 14163
		// (get) Token: 0x0600B260 RID: 45664 RVA: 0x002C833C File Offset: 0x002C653C
		// (set) Token: 0x0600B261 RID: 45665 RVA: 0x0005776C File Offset: 0x0005596C
		public unsafe AudioSourceController ClickSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_ClickSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_ClickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003754 RID: 14164
		// (get) Token: 0x0600B262 RID: 45666 RVA: 0x002C836C File Offset: 0x002C656C
		// (set) Token: 0x0600B263 RID: 45667 RVA: 0x0005778B File Offset: 0x0005598B
		public unsafe AudioSourceController WaterSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_WaterSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_WaterSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003755 RID: 14165
		// (get) Token: 0x0600B264 RID: 45668 RVA: 0x002C839C File Offset: 0x002C659C
		// (set) Token: 0x0600B265 RID: 45669 RVA: 0x000577AA File Offset: 0x000559AA
		public unsafe float ApplyWaterDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_ApplyWaterDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_ApplyWaterDelay)) = value;
			}
		}

		// Token: 0x17003756 RID: 14166
		// (get) Token: 0x0600B266 RID: 45670 RVA: 0x002C83C4 File Offset: 0x002C65C4
		// (set) Token: 0x0600B267 RID: 45671 RVA: 0x000577C5 File Offset: 0x000559C5
		public unsafe float ParticleStopDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_ParticleStopDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_ParticleStopDelay)) = value;
			}
		}

		// Token: 0x17003757 RID: 14167
		// (get) Token: 0x0600B268 RID: 45672 RVA: 0x002C83EC File Offset: 0x002C65EC
		// (set) Token: 0x0600B269 RID: 45673 RVA: 0x000577E0 File Offset: 0x000559E0
		public unsafe UnityEvent onSprinklerStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_onSprinklerStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_onSprinklerStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003758 RID: 14168
		// (get) Token: 0x0600B26A RID: 45674 RVA: 0x002C841C File Offset: 0x002C661C
		// (set) Token: 0x0600B26B RID: 45675 RVA: 0x000577FF File Offset: 0x000559FF
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003759 RID: 14169
		// (get) Token: 0x0600B26C RID: 45676 RVA: 0x002C8444 File Offset: 0x002C6644
		// (set) Token: 0x0600B26D RID: 45677 RVA: 0x0005781A File Offset: 0x00055A1A
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007838 RID: 30776
		private static readonly IntPtr NativeFieldInfoPtr__IsSprinkling_k__BackingField;

		// Token: 0x04007839 RID: 30777
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x0400783A RID: 30778
		private static readonly IntPtr NativeFieldInfoPtr_WaterParticles;

		// Token: 0x0400783B RID: 30779
		private static readonly IntPtr NativeFieldInfoPtr_ClickSound;

		// Token: 0x0400783C RID: 30780
		private static readonly IntPtr NativeFieldInfoPtr_WaterSound;

		// Token: 0x0400783D RID: 30781
		private static readonly IntPtr NativeFieldInfoPtr_ApplyWaterDelay;

		// Token: 0x0400783E RID: 30782
		private static readonly IntPtr NativeFieldInfoPtr_ParticleStopDelay;

		// Token: 0x0400783F RID: 30783
		private static readonly IntPtr NativeFieldInfoPtr_onSprinklerStart;

		// Token: 0x04007840 RID: 30784
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007841 RID: 30785
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007842 RID: 30786
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSprinkling_Public_get_Boolean_0;

		// Token: 0x04007843 RID: 30787
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSprinkling_Private_set_Void_Boolean_0;

		// Token: 0x04007844 RID: 30788
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04007845 RID: 30789
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04007846 RID: 30790
		private static readonly IntPtr NativeMethodInfoPtr_CanWater_Private_Boolean_0;

		// Token: 0x04007847 RID: 30791
		private static readonly IntPtr NativeMethodInfoPtr_SendWater_Private_Void_0;

		// Token: 0x04007848 RID: 30792
		private static readonly IntPtr NativeMethodInfoPtr_Water_Private_Void_0;

		// Token: 0x04007849 RID: 30793
		private static readonly IntPtr NativeMethodInfoPtr_ApplyWater_Public_Void_Single_0;

		// Token: 0x0400784A RID: 30794
		private static readonly IntPtr NativeMethodInfoPtr_GetPots_Protected_Virtual_New_List_1_Pot_0;

		// Token: 0x0400784B RID: 30795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400784C RID: 30796
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x0400784D RID: 30797
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400784E RID: 30798
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400784F RID: 30799
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007850 RID: 30800
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendWater_2166136261_Private_Void_0;

		// Token: 0x04007851 RID: 30801
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendWater_2166136261_Private_Void_0;

		// Token: 0x04007852 RID: 30802
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendWater_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007853 RID: 30803
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Water_2166136261_Private_Void_0;

		// Token: 0x04007854 RID: 30804
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Water_2166136261_Private_Void_0;

		// Token: 0x04007855 RID: 30805
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Water_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007856 RID: 30806
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000BF5 RID: 3061
		[ObfuscatedName("ScheduleOne.ObjectScripts.Sprinkler+<<Water>g__Routine|15_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DF88 RID: 57224 RVA: 0x0034ACA4 File Offset: 0x00348EA4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique()
			{
				Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "<<Water>g__Routine|15_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr);
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, "<>1__state");
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, "<>2__current");
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, "<>4__this");
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr__segments_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, "<segments>5__2");
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, "<i>5__3");
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, 100685284);
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, 100685285);
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, 100685286);
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, 100685287);
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, 100685288);
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, 100685289);
			}

			// Token: 0x0600DF89 RID: 57225 RVA: 0x0034ADAC File Offset: 0x00348FAC
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF8A RID: 57226 RVA: 0x0034ADF4 File Offset: 0x00348FF4
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF8B RID: 57227 RVA: 0x0034AE28 File Offset: 0x00349028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307500, XrefRangeEnd = 307523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004549 RID: 17737
			// (get) Token: 0x0600DF8C RID: 57228 RVA: 0x0034AE64 File Offset: 0x00349064
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF8D RID: 57229 RVA: 0x0034AEA4 File Offset: 0x003490A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307523, XrefRangeEnd = 307528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700454A RID: 17738
			// (get) Token: 0x0600DF8E RID: 57230 RVA: 0x0034AED8 File Offset: 0x003490D8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF8F RID: 57231 RVA: 0x0006CFE6 File Offset: 0x0006B1E6
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004544 RID: 17732
			// (get) Token: 0x0600DF90 RID: 57232 RVA: 0x0034AF18 File Offset: 0x00349118
			// (set) Token: 0x0600DF91 RID: 57233 RVA: 0x0006CFEF File Offset: 0x0006B1EF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004545 RID: 17733
			// (get) Token: 0x0600DF92 RID: 57234 RVA: 0x0034AF40 File Offset: 0x00349140
			// (set) Token: 0x0600DF93 RID: 57235 RVA: 0x0006D00A File Offset: 0x0006B20A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004546 RID: 17734
			// (get) Token: 0x0600DF94 RID: 57236 RVA: 0x0034AF70 File Offset: 0x00349170
			// (set) Token: 0x0600DF95 RID: 57237 RVA: 0x0006D029 File Offset: 0x0006B229
			public unsafe Sprinkler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprinkler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004547 RID: 17735
			// (get) Token: 0x0600DF96 RID: 57238 RVA: 0x0034AFA0 File Offset: 0x003491A0
			// (set) Token: 0x0600DF97 RID: 57239 RVA: 0x0006D048 File Offset: 0x0006B248
			public unsafe int _segments_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr__segments_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr__segments_5__2)) = value;
				}
			}

			// Token: 0x17004548 RID: 17736
			// (get) Token: 0x0600DF98 RID: 57240 RVA: 0x0034AFC8 File Offset: 0x003491C8
			// (set) Token: 0x0600DF99 RID: 57241 RVA: 0x0006D063 File Offset: 0x0006B263
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040095BE RID: 38334
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040095BF RID: 38335
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040095C0 RID: 38336
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095C1 RID: 38337
			private static readonly IntPtr NativeFieldInfoPtr__segments_5__2;

			// Token: 0x040095C2 RID: 38338
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040095C3 RID: 38339
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040095C4 RID: 38340
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095C5 RID: 38341
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040095C6 RID: 38342
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040095C7 RID: 38343
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095C8 RID: 38344
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
