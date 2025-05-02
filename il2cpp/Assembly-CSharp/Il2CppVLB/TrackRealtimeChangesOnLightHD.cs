using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000099 RID: 153
	public class TrackRealtimeChangesOnLightHD : MonoBehaviour
	{
		// Token: 0x060009D3 RID: 2515 RVA: 0x0008ED68 File Offset: 0x0008CF68
		// Note: this type is marked as 'beforefieldinit'.
		static TrackRealtimeChangesOnLightHD()
		{
			Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "TrackRealtimeChangesOnLightHD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr);
			TrackRealtimeChangesOnLightHD.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr, "ClassName");
			TrackRealtimeChangesOnLightHD.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr, "m_Master");
			TrackRealtimeChangesOnLightHD.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr, 100664373);
			TrackRealtimeChangesOnLightHD.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr, 100664374);
			TrackRealtimeChangesOnLightHD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr, 100664375);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0008EDFC File Offset: 0x0008CFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80852, XrefRangeEnd = 80856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackRealtimeChangesOnLightHD.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0008EE30 File Offset: 0x0008D030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80856, XrefRangeEnd = 80858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackRealtimeChangesOnLightHD.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0008EE64 File Offset: 0x0008D064
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackRealtimeChangesOnLightHD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackRealtimeChangesOnLightHD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0000740A File Offset: 0x0000560A
		public TrackRealtimeChangesOnLightHD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x0008EEA0 File Offset: 0x0008D0A0
		// (set) Token: 0x060009D9 RID: 2521 RVA: 0x00007413 File Offset: 0x00005613
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TrackRealtimeChangesOnLightHD.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrackRealtimeChangesOnLightHD.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x0008EEC0 File Offset: 0x0008D0C0
		// (set) Token: 0x060009DB RID: 2523 RVA: 0x00007425 File Offset: 0x00005625
		public unsafe VolumetricLightBeamHD m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackRealtimeChangesOnLightHD.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamHD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackRealtimeChangesOnLightHD.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
