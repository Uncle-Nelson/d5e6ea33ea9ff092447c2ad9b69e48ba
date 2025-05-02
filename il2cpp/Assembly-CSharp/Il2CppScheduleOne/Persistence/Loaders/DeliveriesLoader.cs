using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000225 RID: 549
	public class DeliveriesLoader : Loader
	{
		// Token: 0x06002DB8 RID: 11704 RVA: 0x00101CEC File Offset: 0x000FFEEC
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveriesLoader()
		{
			Il2CppClassPointerStore<DeliveriesLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "DeliveriesLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveriesLoader>.NativeClassPtr);
			DeliveriesLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveriesLoader>.NativeClassPtr, 100668532);
			DeliveriesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveriesLoader>.NativeClassPtr, 100668533);
			DeliveriesLoader.NativeMethodInfoPtr_LoadVehicle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveriesLoader>.NativeClassPtr, 100668534);
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x00101D58 File Offset: 0x000FFF58
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveriesLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveriesLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveriesLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x00101D94 File Offset: 0x000FFF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127285, XrefRangeEnd = 127320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveriesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x00101DE4 File Offset: 0x000FFFE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127357, RefRangeEnd = 127358, XrefRangeStart = 127320, XrefRangeEnd = 127357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadVehicle(string vehiclePath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(vehiclePath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveriesLoader.NativeMethodInfoPtr_LoadVehicle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x00018845 File Offset: 0x00016A45
		public DeliveriesLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E5A RID: 7770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E5B RID: 7771
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001E5C RID: 7772
		private static readonly IntPtr NativeMethodInfoPtr_LoadVehicle_Public_Void_String_0;
	}
}
