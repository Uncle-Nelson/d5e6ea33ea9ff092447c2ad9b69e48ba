using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200072D RID: 1837
	public class Toilet : GridItem
	{
		// Token: 0x0600A6A0 RID: 42656 RVA: 0x0029ABBC File Offset: 0x00298DBC
		// Note: this type is marked as 'beforefieldinit'.
		static Toilet()
		{
			Il2CppClassPointerStore<Toilet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Toilet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Toilet>.NativeClassPtr);
			Toilet.NativeFieldInfoPtr_InitialDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "InitialDelay");
			Toilet.NativeFieldInfoPtr_FlushTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "FlushTime");
			Toilet.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "IntObj");
			Toilet.NativeFieldInfoPtr_ItemLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "ItemLayerMask");
			Toilet.NativeFieldInfoPtr_ItemDetectionCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "ItemDetectionCollider");
			Toilet.NativeFieldInfoPtr_OnFlush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "OnFlush");
			Toilet.NativeFieldInfoPtr__flushCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "_flushCoroutine");
			Toilet.NativeFieldInfoPtr_isFlushing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "isFlushing");
			Toilet.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.ToiletAssembly-CSharp.dll_Excuted");
			Toilet.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.ToiletAssembly-CSharp.dll_Excuted");
			Toilet.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683689);
			Toilet.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683690);
			Toilet.NativeMethodInfoPtr_SendFlush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683691);
			Toilet.NativeMethodInfoPtr_Flush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683692);
			Toilet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683693);
			Toilet.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683694);
			Toilet.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683695);
			Toilet.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683696);
			Toilet.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683697);
			Toilet.NativeMethodInfoPtr_RpcWriter___Server_SendFlush_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683698);
			Toilet.NativeMethodInfoPtr_RpcLogic___SendFlush_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683699);
			Toilet.NativeMethodInfoPtr_RpcReader___Server_SendFlush_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683700);
			Toilet.NativeMethodInfoPtr_RpcWriter___Observers_Flush_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683701);
			Toilet.NativeMethodInfoPtr_RpcLogic___Flush_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683702);
			Toilet.NativeMethodInfoPtr_RpcReader___Observers_Flush_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683703);
			Toilet.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683704);
		}

		// Token: 0x0600A6A1 RID: 42657 RVA: 0x0029ADF4 File Offset: 0x00298FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290995, XrefRangeEnd = 290996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6A2 RID: 42658 RVA: 0x0029AE28 File Offset: 0x00299028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290996, XrefRangeEnd = 291014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6A3 RID: 42659 RVA: 0x0029AE5C File Offset: 0x0029905C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291014, XrefRangeEnd = 291032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendFlush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_SendFlush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6A4 RID: 42660 RVA: 0x0029AE90 File Offset: 0x00299090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291032, XrefRangeEnd = 291050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_Flush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6A5 RID: 42661 RVA: 0x0029AEC4 File Offset: 0x002990C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291050, XrefRangeEnd = 291051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Toilet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Toilet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6A6 RID: 42662 RVA: 0x0029AF00 File Offset: 0x00299100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291051, XrefRangeEnd = 291056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A6A7 RID: 42663 RVA: 0x0029AF40 File Offset: 0x00299140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291056, XrefRangeEnd = 291071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toilet.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6A8 RID: 42664 RVA: 0x0029AF7C File Offset: 0x0029917C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291071, XrefRangeEnd = 291072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toilet.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6A9 RID: 42665 RVA: 0x0029AFB8 File Offset: 0x002991B8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toilet.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6AA RID: 42666 RVA: 0x0029AFF4 File Offset: 0x002991F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendFlush_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcWriter___Server_SendFlush_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6AB RID: 42667 RVA: 0x0029B028 File Offset: 0x00299228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendFlush_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcLogic___SendFlush_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6AC RID: 42668 RVA: 0x0029B05C File Offset: 0x0029925C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291072, XrefRangeEnd = 291082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendFlush_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcReader___Server_SendFlush_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6AD RID: 42669 RVA: 0x0029B0C0 File Offset: 0x002992C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Flush_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcWriter___Observers_Flush_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6AE RID: 42670 RVA: 0x0029B0F4 File Offset: 0x002992F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291082, XrefRangeEnd = 291089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Flush_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcLogic___Flush_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6AF RID: 42671 RVA: 0x0029B128 File Offset: 0x00299328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291089, XrefRangeEnd = 291097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Flush_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcReader___Observers_Flush_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6B0 RID: 42672 RVA: 0x0029B178 File Offset: 0x00299378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291098, RefRangeEnd = 291099, XrefRangeStart = 291097, XrefRangeEnd = 291098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toilet.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6B1 RID: 42673 RVA: 0x0005216D File Offset: 0x0005036D
		public Toilet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003369 RID: 13161
		// (get) Token: 0x0600A6B2 RID: 42674 RVA: 0x0029B1B4 File Offset: 0x002993B4
		// (set) Token: 0x0600A6B3 RID: 42675 RVA: 0x00052176 File Offset: 0x00050376
		public unsafe float InitialDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_InitialDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_InitialDelay)) = value;
			}
		}

		// Token: 0x1700336A RID: 13162
		// (get) Token: 0x0600A6B4 RID: 42676 RVA: 0x0029B1DC File Offset: 0x002993DC
		// (set) Token: 0x0600A6B5 RID: 42677 RVA: 0x00052191 File Offset: 0x00050391
		public unsafe float FlushTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_FlushTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_FlushTime)) = value;
			}
		}

		// Token: 0x1700336B RID: 13163
		// (get) Token: 0x0600A6B6 RID: 42678 RVA: 0x0029B204 File Offset: 0x00299404
		// (set) Token: 0x0600A6B7 RID: 42679 RVA: 0x000521AC File Offset: 0x000503AC
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700336C RID: 13164
		// (get) Token: 0x0600A6B8 RID: 42680 RVA: 0x0029B234 File Offset: 0x00299434
		// (set) Token: 0x0600A6B9 RID: 42681 RVA: 0x000521CB File Offset: 0x000503CB
		public unsafe LayerMask ItemLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_ItemLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_ItemLayerMask)) = value;
			}
		}

		// Token: 0x1700336D RID: 13165
		// (get) Token: 0x0600A6BA RID: 42682 RVA: 0x0029B25C File Offset: 0x0029945C
		// (set) Token: 0x0600A6BB RID: 42683 RVA: 0x000521E6 File Offset: 0x000503E6
		public unsafe SphereCollider ItemDetectionCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_ItemDetectionCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_ItemDetectionCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700336E RID: 13166
		// (get) Token: 0x0600A6BC RID: 42684 RVA: 0x0029B28C File Offset: 0x0029948C
		// (set) Token: 0x0600A6BD RID: 42685 RVA: 0x00052205 File Offset: 0x00050405
		public unsafe UnityEvent OnFlush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_OnFlush);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_OnFlush), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700336F RID: 13167
		// (get) Token: 0x0600A6BE RID: 42686 RVA: 0x0029B2BC File Offset: 0x002994BC
		// (set) Token: 0x0600A6BF RID: 42687 RVA: 0x00052224 File Offset: 0x00050424
		public unsafe Coroutine _flushCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr__flushCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr__flushCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003370 RID: 13168
		// (get) Token: 0x0600A6C0 RID: 42688 RVA: 0x0029B2EC File Offset: 0x002994EC
		// (set) Token: 0x0600A6C1 RID: 42689 RVA: 0x00052243 File Offset: 0x00050443
		public unsafe bool isFlushing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_isFlushing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_isFlushing)) = value;
			}
		}

		// Token: 0x17003371 RID: 13169
		// (get) Token: 0x0600A6C2 RID: 42690 RVA: 0x0029B314 File Offset: 0x00299514
		// (set) Token: 0x0600A6C3 RID: 42691 RVA: 0x0005225E File Offset: 0x0005045E
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003372 RID: 13170
		// (get) Token: 0x0600A6C4 RID: 42692 RVA: 0x0029B33C File Offset: 0x0029953C
		// (set) Token: 0x0600A6C5 RID: 42693 RVA: 0x00052279 File Offset: 0x00050479
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006FC2 RID: 28610
		private static readonly IntPtr NativeFieldInfoPtr_InitialDelay;

		// Token: 0x04006FC3 RID: 28611
		private static readonly IntPtr NativeFieldInfoPtr_FlushTime;

		// Token: 0x04006FC4 RID: 28612
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04006FC5 RID: 28613
		private static readonly IntPtr NativeFieldInfoPtr_ItemLayerMask;

		// Token: 0x04006FC6 RID: 28614
		private static readonly IntPtr NativeFieldInfoPtr_ItemDetectionCollider;

		// Token: 0x04006FC7 RID: 28615
		private static readonly IntPtr NativeFieldInfoPtr_OnFlush;

		// Token: 0x04006FC8 RID: 28616
		private static readonly IntPtr NativeFieldInfoPtr__flushCoroutine;

		// Token: 0x04006FC9 RID: 28617
		private static readonly IntPtr NativeFieldInfoPtr_isFlushing;

		// Token: 0x04006FCA RID: 28618
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006FCB RID: 28619
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006FCC RID: 28620
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04006FCD RID: 28621
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04006FCE RID: 28622
		private static readonly IntPtr NativeMethodInfoPtr_SendFlush_Private_Void_0;

		// Token: 0x04006FCF RID: 28623
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Private_Void_0;

		// Token: 0x04006FD0 RID: 28624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006FD1 RID: 28625
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04006FD2 RID: 28626
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006FD3 RID: 28627
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006FD4 RID: 28628
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006FD5 RID: 28629
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendFlush_2166136261_Private_Void_0;

		// Token: 0x04006FD6 RID: 28630
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendFlush_2166136261_Private_Void_0;

		// Token: 0x04006FD7 RID: 28631
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendFlush_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006FD8 RID: 28632
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Flush_2166136261_Private_Void_0;

		// Token: 0x04006FD9 RID: 28633
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Flush_2166136261_Private_Void_0;

		// Token: 0x04006FDA RID: 28634
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Flush_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006FDB RID: 28635
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000BD4 RID: 3028
		[ObfuscatedName("ScheduleOne.ObjectScripts.Toilet+<<Flush>g__Routine|11_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DE97 RID: 56983 RVA: 0x00348118 File Offset: 0x00346318
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique()
			{
				Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "<<Flush>g__Routine|11_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<>1__state");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<>2__current");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<>4__this");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__checkRate_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<checkRate>5__2");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__reps_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<reps>5__3");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<i>5__4");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100683705);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100683706);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100683707);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100683708);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100683709);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100683710);
			}

			// Token: 0x0600DE98 RID: 56984 RVA: 0x00348234 File Offset: 0x00346434
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE99 RID: 56985 RVA: 0x0034827C File Offset: 0x0034647C
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE9A RID: 56986 RVA: 0x003482B0 File Offset: 0x003464B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290939, XrefRangeEnd = 290990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004507 RID: 17671
			// (get) Token: 0x0600DE9B RID: 56987 RVA: 0x003482EC File Offset: 0x003464EC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE9C RID: 56988 RVA: 0x0034832C File Offset: 0x0034652C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290990, XrefRangeEnd = 290995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004508 RID: 17672
			// (get) Token: 0x0600DE9D RID: 56989 RVA: 0x00348360 File Offset: 0x00346560
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE9E RID: 56990 RVA: 0x0006C877 File Offset: 0x0006AA77
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004501 RID: 17665
			// (get) Token: 0x0600DE9F RID: 56991 RVA: 0x003483A0 File Offset: 0x003465A0
			// (set) Token: 0x0600DEA0 RID: 56992 RVA: 0x0006C880 File Offset: 0x0006AA80
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004502 RID: 17666
			// (get) Token: 0x0600DEA1 RID: 56993 RVA: 0x003483C8 File Offset: 0x003465C8
			// (set) Token: 0x0600DEA2 RID: 56994 RVA: 0x0006C89B File Offset: 0x0006AA9B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004503 RID: 17667
			// (get) Token: 0x0600DEA3 RID: 56995 RVA: 0x003483F8 File Offset: 0x003465F8
			// (set) Token: 0x0600DEA4 RID: 56996 RVA: 0x0006C8BA File Offset: 0x0006AABA
			public unsafe Toilet __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toilet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004504 RID: 17668
			// (get) Token: 0x0600DEA5 RID: 56997 RVA: 0x00348428 File Offset: 0x00346628
			// (set) Token: 0x0600DEA6 RID: 56998 RVA: 0x0006C8D9 File Offset: 0x0006AAD9
			public unsafe float _checkRate_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__checkRate_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__checkRate_5__2)) = value;
				}
			}

			// Token: 0x17004505 RID: 17669
			// (get) Token: 0x0600DEA7 RID: 56999 RVA: 0x00348450 File Offset: 0x00346650
			// (set) Token: 0x0600DEA8 RID: 57000 RVA: 0x0006C8F4 File Offset: 0x0006AAF4
			public unsafe int _reps_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__reps_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__reps_5__3)) = value;
				}
			}

			// Token: 0x17004506 RID: 17670
			// (get) Token: 0x0600DEA9 RID: 57001 RVA: 0x00348478 File Offset: 0x00346678
			// (set) Token: 0x0600DEAA RID: 57002 RVA: 0x0006C90F File Offset: 0x0006AB0F
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x04009508 RID: 38152
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009509 RID: 38153
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400950A RID: 38154
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400950B RID: 38155
			private static readonly IntPtr NativeFieldInfoPtr__checkRate_5__2;

			// Token: 0x0400950C RID: 38156
			private static readonly IntPtr NativeFieldInfoPtr__reps_5__3;

			// Token: 0x0400950D RID: 38157
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x0400950E RID: 38158
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400950F RID: 38159
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009510 RID: 38160
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009511 RID: 38161
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009512 RID: 38162
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009513 RID: 38163
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
