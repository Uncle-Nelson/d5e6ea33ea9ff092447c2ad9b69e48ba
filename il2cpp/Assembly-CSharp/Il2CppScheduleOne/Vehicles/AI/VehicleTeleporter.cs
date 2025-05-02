using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000509 RID: 1289
	public class VehicleTeleporter : MonoBehaviour
	{
		// Token: 0x0600721F RID: 29215 RVA: 0x001F33DC File Offset: 0x001F15DC
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleTeleporter()
		{
			Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "VehicleTeleporter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr);
			VehicleTeleporter.NativeMethodInfoPtr_MoveToGraph_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr, 100677598);
			VehicleTeleporter.NativeMethodInfoPtr_MoveToRoadNetwork_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr, 100677599);
			VehicleTeleporter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr, 100677600);
		}

		// Token: 0x06007220 RID: 29216 RVA: 0x001F3448 File Offset: 0x001F1648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223857, RefRangeEnd = 223858, XrefRangeStart = 223831, XrefRangeEnd = 223857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToGraph(bool resetRotation = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleTeleporter.NativeMethodInfoPtr_MoveToGraph_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007221 RID: 29217 RVA: 0x001F3488 File Offset: 0x001F1688
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223884, RefRangeEnd = 223885, XrefRangeStart = 223858, XrefRangeEnd = 223884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToRoadNetwork(bool resetRotation = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleTeleporter.NativeMethodInfoPtr_MoveToRoadNetwork_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007222 RID: 29218 RVA: 0x001F34C8 File Offset: 0x001F16C8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleTeleporter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleTeleporter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007223 RID: 29219 RVA: 0x00036556 File Offset: 0x00034756
		public VehicleTeleporter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004DDE RID: 19934
		private static readonly IntPtr NativeMethodInfoPtr_MoveToGraph_Public_Void_Boolean_0;

		// Token: 0x04004DDF RID: 19935
		private static readonly IntPtr NativeMethodInfoPtr_MoveToRoadNetwork_Public_Void_Boolean_0;

		// Token: 0x04004DE0 RID: 19936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
