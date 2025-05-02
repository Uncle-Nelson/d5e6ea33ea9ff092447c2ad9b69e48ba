using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000776 RID: 1910
	public class Dealership : MonoBehaviour
	{
		// Token: 0x0600B52E RID: 46382 RVA: 0x002D12D8 File Offset: 0x002CF4D8
		// Note: this type is marked as 'beforefieldinit'.
		static Dealership()
		{
			Il2CppClassPointerStore<Dealership>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "Dealership");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealership>.NativeClassPtr);
			Dealership.NativeFieldInfoPtr_SpawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealership>.NativeClassPtr, "SpawnPoints");
			Dealership.NativeMethodInfoPtr_SpawnVehicle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealership>.NativeClassPtr, 100685583);
			Dealership.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealership>.NativeClassPtr, 100685584);
		}

		// Token: 0x0600B52F RID: 46383 RVA: 0x002D1344 File Offset: 0x002CF544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310296, XrefRangeEnd = 310304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnVehicle(string vehicleCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(vehicleCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealership.NativeMethodInfoPtr_SpawnVehicle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B530 RID: 46384 RVA: 0x002D1388 File Offset: 0x002CF588
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dealership() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealership>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealership.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B531 RID: 46385 RVA: 0x00058E2D File Offset: 0x0005702D
		public Dealership(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003828 RID: 14376
		// (get) Token: 0x0600B532 RID: 46386 RVA: 0x002D13C4 File Offset: 0x002CF5C4
		// (set) Token: 0x0600B533 RID: 46387 RVA: 0x00058E36 File Offset: 0x00057036
		public unsafe Il2CppReferenceArray<Transform> SpawnPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealership.NativeFieldInfoPtr_SpawnPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealership.NativeFieldInfoPtr_SpawnPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A1B RID: 31259
		private static readonly IntPtr NativeFieldInfoPtr_SpawnPoints;

		// Token: 0x04007A1C RID: 31260
		private static readonly IntPtr NativeMethodInfoPtr_SpawnVehicle_Public_Void_String_0;

		// Token: 0x04007A1D RID: 31261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
