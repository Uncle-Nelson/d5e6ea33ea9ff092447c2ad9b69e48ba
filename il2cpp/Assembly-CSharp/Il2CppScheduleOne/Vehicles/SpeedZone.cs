using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E6 RID: 1254
	public class SpeedZone : MonoBehaviour
	{
		// Token: 0x06006EC7 RID: 28359 RVA: 0x001E9BC4 File Offset: 0x001E7DC4
		// Note: this type is marked as 'beforefieldinit'.
		static SpeedZone()
		{
			Il2CppClassPointerStore<SpeedZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "SpeedZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr);
			SpeedZone.NativeFieldInfoPtr_speedZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, "speedZones");
			SpeedZone.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, "col");
			SpeedZone.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, "speed");
			SpeedZone.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100677301);
			SpeedZone.NativeMethodInfoPtr_GetSpeedZones_Public_Static_List_1_SpeedZone_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100677302);
			SpeedZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100677303);
			SpeedZone.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100677304);
			SpeedZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100677305);
		}

		// Token: 0x06006EC8 RID: 28360 RVA: 0x001E9C94 File Offset: 0x001E7E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220518, XrefRangeEnd = 220528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpeedZone.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EC9 RID: 28361 RVA: 0x001E9CD0 File Offset: 0x001E7ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220528, XrefRangeEnd = 220555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<SpeedZone> GetSpeedZones(Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedZone.NativeMethodInfoPtr_GetSpeedZones_Public_Static_List_1_SpeedZone_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SpeedZone>>(intPtr3) : null;
		}

		// Token: 0x06006ECA RID: 28362 RVA: 0x001E9D10 File Offset: 0x001E7F10
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ECB RID: 28363 RVA: 0x001E9D44 File Offset: 0x001E7F44
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedZone.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ECC RID: 28364 RVA: 0x001E9D78 File Offset: 0x001E7F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220555, XrefRangeEnd = 220556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpeedZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ECD RID: 28365 RVA: 0x000346DE File Offset: 0x000328DE
		public SpeedZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002164 RID: 8548
		// (get) Token: 0x06006ECE RID: 28366 RVA: 0x001E9DB4 File Offset: 0x001E7FB4
		// (set) Token: 0x06006ECF RID: 28367 RVA: 0x000346E7 File Offset: 0x000328E7
		public unsafe static List<SpeedZone> speedZones
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpeedZone.NativeFieldInfoPtr_speedZones, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpeedZone>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpeedZone.NativeFieldInfoPtr_speedZones, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x06006ED0 RID: 28368 RVA: 0x001E9DDC File Offset: 0x001E7FDC
		// (set) Token: 0x06006ED1 RID: 28369 RVA: 0x000346F9 File Offset: 0x000328F9
		public unsafe BoxCollider col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedZone.NativeFieldInfoPtr_col);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedZone.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x06006ED2 RID: 28370 RVA: 0x001E9E0C File Offset: 0x001E800C
		// (set) Token: 0x06006ED3 RID: 28371 RVA: 0x00034718 File Offset: 0x00032918
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedZone.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedZone.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x04004BC9 RID: 19401
		private static readonly IntPtr NativeFieldInfoPtr_speedZones;

		// Token: 0x04004BCA RID: 19402
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04004BCB RID: 19403
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x04004BCC RID: 19404
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0;

		// Token: 0x04004BCD RID: 19405
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeedZones_Public_Static_List_1_SpeedZone_Vector3_0;

		// Token: 0x04004BCE RID: 19406
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04004BCF RID: 19407
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

		// Token: 0x04004BD0 RID: 19408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
