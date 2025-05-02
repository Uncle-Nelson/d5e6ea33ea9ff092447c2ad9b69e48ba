using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.Misc;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000771 RID: 1905
	public class AccessZone : MonoBehaviour
	{
		// Token: 0x0600B4C2 RID: 46274 RVA: 0x002CFCCC File Offset: 0x002CDECC
		// Note: this type is marked as 'beforefieldinit'.
		static AccessZone()
		{
			Il2CppClassPointerStore<AccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "AccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccessZone>.NativeClassPtr);
			AccessZone.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "<IsOpen>k__BackingField");
			AccessZone.NativeFieldInfoPtr_AllowExitWhenClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "AllowExitWhenClosed");
			AccessZone.NativeFieldInfoPtr_AutoCloseDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "AutoCloseDoor");
			AccessZone.NativeFieldInfoPtr_Doors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "Doors");
			AccessZone.NativeFieldInfoPtr_Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "Lights");
			AccessZone.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "onOpen");
			AccessZone.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "onClose");
			AccessZone.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100685533);
			AccessZone.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100685534);
			AccessZone.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100685535);
			AccessZone.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100685536);
			AccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100685537);
		}

		// Token: 0x17003810 RID: 14352
		// (get) Token: 0x0600B4C3 RID: 46275 RVA: 0x002CFDEC File Offset: 0x002CDFEC
		// (set) Token: 0x0600B4C4 RID: 46276 RVA: 0x002CFE28 File Offset: 0x002CE028
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccessZone.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccessZone.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B4C5 RID: 46277 RVA: 0x002CFE68 File Offset: 0x002CE068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309847, RefRangeEnd = 309848, XrefRangeStart = 309847, XrefRangeEnd = 309847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AccessZone.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4C6 RID: 46278 RVA: 0x002CFEA4 File Offset: 0x002CE0A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309856, RefRangeEnd = 309857, XrefRangeStart = 309848, XrefRangeEnd = 309856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AccessZone.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4C7 RID: 46279 RVA: 0x002CFEF0 File Offset: 0x002CE0F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 309858, RefRangeEnd = 309861, XrefRangeStart = 309857, XrefRangeEnd = 309858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccessZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4C8 RID: 46280 RVA: 0x00058AE3 File Offset: 0x00056CE3
		public AccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003809 RID: 14345
		// (get) Token: 0x0600B4C9 RID: 46281 RVA: 0x002CFF2C File Offset: 0x002CE12C
		// (set) Token: 0x0600B4CA RID: 46282 RVA: 0x00058AEC File Offset: 0x00056CEC
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700380A RID: 14346
		// (get) Token: 0x0600B4CB RID: 46283 RVA: 0x002CFF54 File Offset: 0x002CE154
		// (set) Token: 0x0600B4CC RID: 46284 RVA: 0x00058B07 File Offset: 0x00056D07
		public unsafe bool AllowExitWhenClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_AllowExitWhenClosed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_AllowExitWhenClosed)) = value;
			}
		}

		// Token: 0x1700380B RID: 14347
		// (get) Token: 0x0600B4CD RID: 46285 RVA: 0x002CFF7C File Offset: 0x002CE17C
		// (set) Token: 0x0600B4CE RID: 46286 RVA: 0x00058B22 File Offset: 0x00056D22
		public unsafe bool AutoCloseDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_AutoCloseDoor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_AutoCloseDoor)) = value;
			}
		}

		// Token: 0x1700380C RID: 14348
		// (get) Token: 0x0600B4CF RID: 46287 RVA: 0x002CFFA4 File Offset: 0x002CE1A4
		// (set) Token: 0x0600B4D0 RID: 46288 RVA: 0x00058B3D File Offset: 0x00056D3D
		public unsafe Il2CppReferenceArray<DoorController> Doors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_Doors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DoorController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_Doors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700380D RID: 14349
		// (get) Token: 0x0600B4D1 RID: 46289 RVA: 0x002CFFD4 File Offset: 0x002CE1D4
		// (set) Token: 0x0600B4D2 RID: 46290 RVA: 0x00058B5C File Offset: 0x00056D5C
		public unsafe Il2CppReferenceArray<ToggleableLight> Lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_Lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ToggleableLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_Lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700380E RID: 14350
		// (get) Token: 0x0600B4D3 RID: 46291 RVA: 0x002D0004 File Offset: 0x002CE204
		// (set) Token: 0x0600B4D4 RID: 46292 RVA: 0x00058B7B File Offset: 0x00056D7B
		public unsafe UnityEvent onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700380F RID: 14351
		// (get) Token: 0x0600B4D5 RID: 46293 RVA: 0x002D0034 File Offset: 0x002CE234
		// (set) Token: 0x0600B4D6 RID: 46294 RVA: 0x00058B9A File Offset: 0x00056D9A
		public unsafe UnityEvent onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040079D4 RID: 31188
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040079D5 RID: 31189
		private static readonly IntPtr NativeFieldInfoPtr_AllowExitWhenClosed;

		// Token: 0x040079D6 RID: 31190
		private static readonly IntPtr NativeFieldInfoPtr_AutoCloseDoor;

		// Token: 0x040079D7 RID: 31191
		private static readonly IntPtr NativeFieldInfoPtr_Doors;

		// Token: 0x040079D8 RID: 31192
		private static readonly IntPtr NativeFieldInfoPtr_Lights;

		// Token: 0x040079D9 RID: 31193
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x040079DA RID: 31194
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x040079DB RID: 31195
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040079DC RID: 31196
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040079DD RID: 31197
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040079DE RID: 31198
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040079DF RID: 31199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
