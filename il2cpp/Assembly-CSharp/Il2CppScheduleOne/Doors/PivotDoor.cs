using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000427 RID: 1063
	public class PivotDoor : MonoBehaviour
	{
		// Token: 0x06005D86 RID: 23942 RVA: 0x001AFA78 File Offset: 0x001ADC78
		// Note: this type is marked as 'beforefieldinit'.
		static PivotDoor()
		{
			Il2CppClassPointerStore<PivotDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "PivotDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr);
			PivotDoor.NativeFieldInfoPtr_DoorTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, "DoorTransform");
			PivotDoor.NativeFieldInfoPtr_FlipSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, "FlipSide");
			PivotDoor.NativeFieldInfoPtr_OpenInwardsAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, "OpenInwardsAngle");
			PivotDoor.NativeFieldInfoPtr_OpenOutwardsAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, "OpenOutwardsAngle");
			PivotDoor.NativeFieldInfoPtr_SwingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, "SwingSpeed");
			PivotDoor.NativeFieldInfoPtr_targetDoorAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, "targetDoorAngle");
			PivotDoor.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, 100675204);
			PivotDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, 100675205);
			PivotDoor.NativeMethodInfoPtr_Opened_Public_Virtual_New_Void_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, 100675206);
			PivotDoor.NativeMethodInfoPtr_Closed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, 100675207);
			PivotDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, 100675208);
		}

		// Token: 0x06005D87 RID: 23943 RVA: 0x001AFB84 File Offset: 0x001ADD84
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotDoor.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D88 RID: 23944 RVA: 0x001AFBC0 File Offset: 0x001ADDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196170, XrefRangeEnd = 196175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PivotDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D89 RID: 23945 RVA: 0x001AFBF4 File Offset: 0x001ADDF4
		[CallerCount(0)]
		public unsafe virtual void Opened(EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotDoor.NativeMethodInfoPtr_Opened_Public_Virtual_New_Void_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D8A RID: 23946 RVA: 0x001AFC40 File Offset: 0x001ADE40
		[CallerCount(0)]
		public unsafe virtual void Closed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotDoor.NativeMethodInfoPtr_Closed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D8B RID: 23947 RVA: 0x001AFC7C File Offset: 0x001ADE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196175, XrefRangeEnd = 196176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PivotDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PivotDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D8C RID: 23948 RVA: 0x0002C167 File Offset: 0x0002A367
		public PivotDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x06005D8D RID: 23949 RVA: 0x001AFCB8 File Offset: 0x001ADEB8
		// (set) Token: 0x06005D8E RID: 23950 RVA: 0x0002C170 File Offset: 0x0002A370
		public unsafe Transform DoorTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_DoorTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_DoorTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x06005D8F RID: 23951 RVA: 0x001AFCE8 File Offset: 0x001ADEE8
		// (set) Token: 0x06005D90 RID: 23952 RVA: 0x0002C18F File Offset: 0x0002A38F
		public unsafe bool FlipSide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_FlipSide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_FlipSide)) = value;
			}
		}

		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x06005D91 RID: 23953 RVA: 0x001AFD10 File Offset: 0x001ADF10
		// (set) Token: 0x06005D92 RID: 23954 RVA: 0x0002C1AA File Offset: 0x0002A3AA
		public unsafe float OpenInwardsAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_OpenInwardsAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_OpenInwardsAngle)) = value;
			}
		}

		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x06005D93 RID: 23955 RVA: 0x001AFD38 File Offset: 0x001ADF38
		// (set) Token: 0x06005D94 RID: 23956 RVA: 0x0002C1C5 File Offset: 0x0002A3C5
		public unsafe float OpenOutwardsAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_OpenOutwardsAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_OpenOutwardsAngle)) = value;
			}
		}

		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x06005D95 RID: 23957 RVA: 0x001AFD60 File Offset: 0x001ADF60
		// (set) Token: 0x06005D96 RID: 23958 RVA: 0x0002C1E0 File Offset: 0x0002A3E0
		public unsafe float SwingSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_SwingSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_SwingSpeed)) = value;
			}
		}

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x06005D97 RID: 23959 RVA: 0x001AFD88 File Offset: 0x001ADF88
		// (set) Token: 0x06005D98 RID: 23960 RVA: 0x0002C1FB File Offset: 0x0002A3FB
		public unsafe float targetDoorAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_targetDoorAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_targetDoorAngle)) = value;
			}
		}

		// Token: 0x04004001 RID: 16385
		private static readonly IntPtr NativeFieldInfoPtr_DoorTransform;

		// Token: 0x04004002 RID: 16386
		private static readonly IntPtr NativeFieldInfoPtr_FlipSide;

		// Token: 0x04004003 RID: 16387
		private static readonly IntPtr NativeFieldInfoPtr_OpenInwardsAngle;

		// Token: 0x04004004 RID: 16388
		private static readonly IntPtr NativeFieldInfoPtr_OpenOutwardsAngle;

		// Token: 0x04004005 RID: 16389
		private static readonly IntPtr NativeFieldInfoPtr_SwingSpeed;

		// Token: 0x04004006 RID: 16390
		private static readonly IntPtr NativeFieldInfoPtr_targetDoorAngle;

		// Token: 0x04004007 RID: 16391
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004008 RID: 16392
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04004009 RID: 16393
		private static readonly IntPtr NativeMethodInfoPtr_Opened_Public_Virtual_New_Void_EDoorSide_0;

		// Token: 0x0400400A RID: 16394
		private static readonly IntPtr NativeMethodInfoPtr_Closed_Public_Virtual_New_Void_0;

		// Token: 0x0400400B RID: 16395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
