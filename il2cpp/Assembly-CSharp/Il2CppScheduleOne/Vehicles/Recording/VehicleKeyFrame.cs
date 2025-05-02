using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Recording
{
	// Token: 0x020004F7 RID: 1271
	[Serializable]
	public class VehicleKeyFrame : Il2CppSystem.Object
	{
		// Token: 0x06007081 RID: 28801 RVA: 0x001EECA4 File Offset: 0x001ECEA4
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleKeyFrame()
		{
			Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Recording", "VehicleKeyFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr);
			VehicleKeyFrame.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "position");
			VehicleKeyFrame.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "rotation");
			VehicleKeyFrame.NativeFieldInfoPtr_brakesApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "brakesApplied");
			VehicleKeyFrame.NativeFieldInfoPtr_reversing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "reversing");
			VehicleKeyFrame.NativeFieldInfoPtr_headlightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "headlightsOn");
			VehicleKeyFrame.NativeFieldInfoPtr_wheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "wheels");
			VehicleKeyFrame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, 100677438);
		}

		// Token: 0x06007082 RID: 28802 RVA: 0x001EED60 File Offset: 0x001ECF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221735, XrefRangeEnd = 221743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleKeyFrame() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleKeyFrame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007083 RID: 28803 RVA: 0x00035661 File Offset: 0x00033861
		public VehicleKeyFrame(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x06007084 RID: 28804 RVA: 0x001EED9C File Offset: 0x001ECF9C
		// (set) Token: 0x06007085 RID: 28805 RVA: 0x0003566A File Offset: 0x0003386A
		public unsafe Vector3 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x06007086 RID: 28806 RVA: 0x001EEDC4 File Offset: 0x001ECFC4
		// (set) Token: 0x06007087 RID: 28807 RVA: 0x00035685 File Offset: 0x00033885
		public unsafe Quaternion rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x06007088 RID: 28808 RVA: 0x001EEDEC File Offset: 0x001ECFEC
		// (set) Token: 0x06007089 RID: 28809 RVA: 0x000356A0 File Offset: 0x000338A0
		public unsafe bool brakesApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_brakesApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_brakesApplied)) = value;
			}
		}

		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x0600708A RID: 28810 RVA: 0x001EEE14 File Offset: 0x001ED014
		// (set) Token: 0x0600708B RID: 28811 RVA: 0x000356BB File Offset: 0x000338BB
		public unsafe bool reversing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_reversing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_reversing)) = value;
			}
		}

		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x0600708C RID: 28812 RVA: 0x001EEE3C File Offset: 0x001ED03C
		// (set) Token: 0x0600708D RID: 28813 RVA: 0x000356D6 File Offset: 0x000338D6
		public unsafe bool headlightsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_headlightsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_headlightsOn)) = value;
			}
		}

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x0600708E RID: 28814 RVA: 0x001EEE64 File Offset: 0x001ED064
		// (set) Token: 0x0600708F RID: 28815 RVA: 0x000356F1 File Offset: 0x000338F1
		public unsafe List<VehicleKeyFrame.WheelTransform> wheels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_wheels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleKeyFrame.WheelTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_wheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004CD7 RID: 19671
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04004CD8 RID: 19672
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x04004CD9 RID: 19673
		private static readonly IntPtr NativeFieldInfoPtr_brakesApplied;

		// Token: 0x04004CDA RID: 19674
		private static readonly IntPtr NativeFieldInfoPtr_reversing;

		// Token: 0x04004CDB RID: 19675
		private static readonly IntPtr NativeFieldInfoPtr_headlightsOn;

		// Token: 0x04004CDC RID: 19676
		private static readonly IntPtr NativeFieldInfoPtr_wheels;

		// Token: 0x04004CDD RID: 19677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A6D RID: 2669
		[Serializable]
		public class WheelTransform : Il2CppSystem.Object
		{
			// Token: 0x0600D13A RID: 53562 RVA: 0x0032213C File Offset: 0x0032033C
			// Note: this type is marked as 'beforefieldinit'.
			static WheelTransform()
			{
				Il2CppClassPointerStore<VehicleKeyFrame.WheelTransform>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "WheelTransform");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleKeyFrame.WheelTransform>.NativeClassPtr);
				VehicleKeyFrame.WheelTransform.NativeFieldInfoPtr_yPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame.WheelTransform>.NativeClassPtr, "yPos");
				VehicleKeyFrame.WheelTransform.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame.WheelTransform>.NativeClassPtr, "rotation");
				VehicleKeyFrame.WheelTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleKeyFrame.WheelTransform>.NativeClassPtr, 100677439);
			}

			// Token: 0x0600D13B RID: 53563 RVA: 0x003221A4 File Offset: 0x003203A4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WheelTransform() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleKeyFrame.WheelTransform>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleKeyFrame.WheelTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D13C RID: 53564 RVA: 0x00065DB7 File Offset: 0x00063FB7
			public WheelTransform(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040F7 RID: 16631
			// (get) Token: 0x0600D13D RID: 53565 RVA: 0x003221E0 File Offset: 0x003203E0
			// (set) Token: 0x0600D13E RID: 53566 RVA: 0x00065DC0 File Offset: 0x00063FC0
			public unsafe float yPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.WheelTransform.NativeFieldInfoPtr_yPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.WheelTransform.NativeFieldInfoPtr_yPos)) = value;
				}
			}

			// Token: 0x170040F8 RID: 16632
			// (get) Token: 0x0600D13F RID: 53567 RVA: 0x00322208 File Offset: 0x00320408
			// (set) Token: 0x0600D140 RID: 53568 RVA: 0x00065DDB File Offset: 0x00063FDB
			public unsafe Quaternion rotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.WheelTransform.NativeFieldInfoPtr_rotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.WheelTransform.NativeFieldInfoPtr_rotation)) = value;
				}
			}

			// Token: 0x04008D2B RID: 36139
			private static readonly IntPtr NativeFieldInfoPtr_yPos;

			// Token: 0x04008D2C RID: 36140
			private static readonly IntPtr NativeFieldInfoPtr_rotation;

			// Token: 0x04008D2D RID: 36141
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
