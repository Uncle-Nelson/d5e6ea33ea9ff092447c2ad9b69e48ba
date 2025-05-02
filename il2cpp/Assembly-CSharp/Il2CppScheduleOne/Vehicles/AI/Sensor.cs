using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000505 RID: 1285
	public class Sensor : MonoBehaviour
	{
		// Token: 0x06007117 RID: 28951 RVA: 0x001F0984 File Offset: 0x001EEB84
		// Note: this type is marked as 'beforefieldinit'.
		static Sensor()
		{
			Il2CppClassPointerStore<Sensor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "Sensor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sensor>.NativeClassPtr);
			Sensor.NativeFieldInfoPtr_obstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "obstruction");
			Sensor.NativeFieldInfoPtr_obstructionDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "obstructionDistance");
			Sensor.NativeFieldInfoPtr_checkRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "checkRate");
			Sensor.NativeFieldInfoPtr_minDetectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "minDetectionRange");
			Sensor.NativeFieldInfoPtr_maxDetectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "maxDetectionRange");
			Sensor.NativeFieldInfoPtr_checkRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "checkRadius");
			Sensor.NativeFieldInfoPtr_checkMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "checkMask");
			Sensor.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "vehicle");
			Sensor.NativeFieldInfoPtr_calculatedDetectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "calculatedDetectionRange");
			Sensor.NativeFieldInfoPtr_hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "hit");
			Sensor.NativeFieldInfoPtr_hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "hits");
			Sensor.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensor>.NativeClassPtr, 100677525);
			Sensor.NativeMethodInfoPtr_Check_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensor>.NativeClassPtr, 100677526);
			Sensor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensor>.NativeClassPtr, 100677527);
			Sensor.NativeMethodInfoPtr__Check_b__12_0_Private_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensor>.NativeClassPtr, 100677528);
		}

		// Token: 0x06007118 RID: 28952 RVA: 0x001F0AE0 File Offset: 0x001EECE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222494, XrefRangeEnd = 222501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sensor.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007119 RID: 28953 RVA: 0x001F0B1C File Offset: 0x001EED1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222501, XrefRangeEnd = 222603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Check()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensor.NativeMethodInfoPtr_Check_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600711A RID: 28954 RVA: 0x001F0B50 File Offset: 0x001EED50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222603, XrefRangeEnd = 222611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sensor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sensor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600711B RID: 28955 RVA: 0x001F0B8C File Offset: 0x001EED8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222611, XrefRangeEnd = 222617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _Check_b__12_0(RaycastHit x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensor.NativeMethodInfoPtr__Check_b__12_0_Private_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600711C RID: 28956 RVA: 0x00035B3B File Offset: 0x00033D3B
		public Sensor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002229 RID: 8745
		// (get) Token: 0x0600711D RID: 28957 RVA: 0x001F0BD8 File Offset: 0x001EEDD8
		// (set) Token: 0x0600711E RID: 28958 RVA: 0x00035B44 File Offset: 0x00033D44
		public unsafe Collider obstruction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_obstruction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_obstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700222A RID: 8746
		// (get) Token: 0x0600711F RID: 28959 RVA: 0x001F0C08 File Offset: 0x001EEE08
		// (set) Token: 0x06007120 RID: 28960 RVA: 0x00035B63 File Offset: 0x00033D63
		public unsafe float obstructionDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_obstructionDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_obstructionDistance)) = value;
			}
		}

		// Token: 0x1700222B RID: 8747
		// (get) Token: 0x06007121 RID: 28961 RVA: 0x001F0C30 File Offset: 0x001EEE30
		// (set) Token: 0x06007122 RID: 28962 RVA: 0x00035B7E File Offset: 0x00033D7E
		public unsafe static float checkRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Sensor.NativeFieldInfoPtr_checkRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Sensor.NativeFieldInfoPtr_checkRate, (void*)(&value));
			}
		}

		// Token: 0x1700222C RID: 8748
		// (get) Token: 0x06007123 RID: 28963 RVA: 0x001F0C4C File Offset: 0x001EEE4C
		// (set) Token: 0x06007124 RID: 28964 RVA: 0x00035B8C File Offset: 0x00033D8C
		public unsafe float minDetectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_minDetectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_minDetectionRange)) = value;
			}
		}

		// Token: 0x1700222D RID: 8749
		// (get) Token: 0x06007125 RID: 28965 RVA: 0x001F0C74 File Offset: 0x001EEE74
		// (set) Token: 0x06007126 RID: 28966 RVA: 0x00035BA7 File Offset: 0x00033DA7
		public unsafe float maxDetectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_maxDetectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_maxDetectionRange)) = value;
			}
		}

		// Token: 0x1700222E RID: 8750
		// (get) Token: 0x06007127 RID: 28967 RVA: 0x001F0C9C File Offset: 0x001EEE9C
		// (set) Token: 0x06007128 RID: 28968 RVA: 0x00035BC2 File Offset: 0x00033DC2
		public unsafe float checkRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_checkRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_checkRadius)) = value;
			}
		}

		// Token: 0x1700222F RID: 8751
		// (get) Token: 0x06007129 RID: 28969 RVA: 0x001F0CC4 File Offset: 0x001EEEC4
		// (set) Token: 0x0600712A RID: 28970 RVA: 0x00035BDD File Offset: 0x00033DDD
		public unsafe LayerMask checkMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_checkMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_checkMask)) = value;
			}
		}

		// Token: 0x17002230 RID: 8752
		// (get) Token: 0x0600712B RID: 28971 RVA: 0x001F0CEC File Offset: 0x001EEEEC
		// (set) Token: 0x0600712C RID: 28972 RVA: 0x00035BF8 File Offset: 0x00033DF8
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002231 RID: 8753
		// (get) Token: 0x0600712D RID: 28973 RVA: 0x001F0D1C File Offset: 0x001EEF1C
		// (set) Token: 0x0600712E RID: 28974 RVA: 0x00035C17 File Offset: 0x00033E17
		public unsafe float calculatedDetectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_calculatedDetectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_calculatedDetectionRange)) = value;
			}
		}

		// Token: 0x17002232 RID: 8754
		// (get) Token: 0x0600712F RID: 28975 RVA: 0x001F0D44 File Offset: 0x001EEF44
		// (set) Token: 0x06007130 RID: 28976 RVA: 0x00035C32 File Offset: 0x00033E32
		public unsafe RaycastHit hit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_hit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_hit)) = value;
			}
		}

		// Token: 0x17002233 RID: 8755
		// (get) Token: 0x06007131 RID: 28977 RVA: 0x001F0D6C File Offset: 0x001EEF6C
		// (set) Token: 0x06007132 RID: 28978 RVA: 0x00035C4D File Offset: 0x00033E4D
		public unsafe List<RaycastHit> hits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_hits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RaycastHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_hits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D3D RID: 19773
		private static readonly IntPtr NativeFieldInfoPtr_obstruction;

		// Token: 0x04004D3E RID: 19774
		private static readonly IntPtr NativeFieldInfoPtr_obstructionDistance;

		// Token: 0x04004D3F RID: 19775
		private static readonly IntPtr NativeFieldInfoPtr_checkRate;

		// Token: 0x04004D40 RID: 19776
		private static readonly IntPtr NativeFieldInfoPtr_minDetectionRange;

		// Token: 0x04004D41 RID: 19777
		private static readonly IntPtr NativeFieldInfoPtr_maxDetectionRange;

		// Token: 0x04004D42 RID: 19778
		private static readonly IntPtr NativeFieldInfoPtr_checkRadius;

		// Token: 0x04004D43 RID: 19779
		private static readonly IntPtr NativeFieldInfoPtr_checkMask;

		// Token: 0x04004D44 RID: 19780
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004D45 RID: 19781
		private static readonly IntPtr NativeFieldInfoPtr_calculatedDetectionRange;

		// Token: 0x04004D46 RID: 19782
		private static readonly IntPtr NativeFieldInfoPtr_hit;

		// Token: 0x04004D47 RID: 19783
		private static readonly IntPtr NativeFieldInfoPtr_hits;

		// Token: 0x04004D48 RID: 19784
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004D49 RID: 19785
		private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Void_0;

		// Token: 0x04004D4A RID: 19786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004D4B RID: 19787
		private static readonly IntPtr NativeMethodInfoPtr__Check_b__12_0_Private_Single_RaycastHit_0;
	}
}
