using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000428 RID: 1064
	public class RollerDoor : MonoBehaviour
	{
		// Token: 0x06005D99 RID: 23961 RVA: 0x001AFDB0 File Offset: 0x001ADFB0
		// Note: this type is marked as 'beforefieldinit'.
		static RollerDoor()
		{
			Il2CppClassPointerStore<RollerDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "RollerDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr);
			RollerDoor.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "<IsOpen>k__BackingField");
			RollerDoor.NativeFieldInfoPtr_Door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "Door");
			RollerDoor.NativeFieldInfoPtr_LocalPos_Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "LocalPos_Open");
			RollerDoor.NativeFieldInfoPtr_LocalPos_Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "LocalPos_Closed");
			RollerDoor.NativeFieldInfoPtr_LerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "LerpTime");
			RollerDoor.NativeFieldInfoPtr_Blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "Blocker");
			RollerDoor.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "startPos");
			RollerDoor.NativeFieldInfoPtr_timeSinceValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "timeSinceValueChange");
			RollerDoor.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675209);
			RollerDoor.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675210);
			RollerDoor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675211);
			RollerDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675212);
			RollerDoor.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675213);
			RollerDoor.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675214);
			RollerDoor.NativeMethodInfoPtr_CanOpen_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675215);
			RollerDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100675216);
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x06005D9A RID: 23962 RVA: 0x001AFF20 File Offset: 0x001AE120
		// (set) Token: 0x06005D9B RID: 23963 RVA: 0x001AFF5C File Offset: 0x001AE15C
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005D9C RID: 23964 RVA: 0x001AFF9C File Offset: 0x001AE19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196176, XrefRangeEnd = 196178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D9D RID: 23965 RVA: 0x001AFFD0 File Offset: 0x001AE1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196178, XrefRangeEnd = 196190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D9E RID: 23966 RVA: 0x001B0004 File Offset: 0x001AE204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196190, XrefRangeEnd = 196191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D9F RID: 23967 RVA: 0x001B0038 File Offset: 0x001AE238
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196192, RefRangeEnd = 196193, XrefRangeStart = 196191, XrefRangeEnd = 196192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DA0 RID: 23968 RVA: 0x001B006C File Offset: 0x001AE26C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RollerDoor.NativeMethodInfoPtr_CanOpen_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005DA1 RID: 23969 RVA: 0x001B00B4 File Offset: 0x001AE2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196193, XrefRangeEnd = 196196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RollerDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DA2 RID: 23970 RVA: 0x0002C216 File Offset: 0x0002A416
		public RollerDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x06005DA3 RID: 23971 RVA: 0x001B00F0 File Offset: 0x001AE2F0
		// (set) Token: 0x06005DA4 RID: 23972 RVA: 0x0002C21F File Offset: 0x0002A41F
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x06005DA5 RID: 23973 RVA: 0x001B0118 File Offset: 0x001AE318
		// (set) Token: 0x06005DA6 RID: 23974 RVA: 0x0002C23A File Offset: 0x0002A43A
		public unsafe Transform Door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_Door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_Door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x06005DA7 RID: 23975 RVA: 0x001B0148 File Offset: 0x001AE348
		// (set) Token: 0x06005DA8 RID: 23976 RVA: 0x0002C259 File Offset: 0x0002A459
		public unsafe Vector3 LocalPos_Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LocalPos_Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LocalPos_Open)) = value;
			}
		}

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x06005DA9 RID: 23977 RVA: 0x001B0170 File Offset: 0x001AE370
		// (set) Token: 0x06005DAA RID: 23978 RVA: 0x0002C274 File Offset: 0x0002A474
		public unsafe Vector3 LocalPos_Closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LocalPos_Closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LocalPos_Closed)) = value;
			}
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x06005DAB RID: 23979 RVA: 0x001B0198 File Offset: 0x001AE398
		// (set) Token: 0x06005DAC RID: 23980 RVA: 0x0002C28F File Offset: 0x0002A48F
		public unsafe float LerpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LerpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LerpTime)) = value;
			}
		}

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x06005DAD RID: 23981 RVA: 0x001B01C0 File Offset: 0x001AE3C0
		// (set) Token: 0x06005DAE RID: 23982 RVA: 0x0002C2AA File Offset: 0x0002A4AA
		public unsafe GameObject Blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_Blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_Blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x06005DAF RID: 23983 RVA: 0x001B01F0 File Offset: 0x001AE3F0
		// (set) Token: 0x06005DB0 RID: 23984 RVA: 0x0002C2C9 File Offset: 0x0002A4C9
		public unsafe Vector3 startPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_startPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_startPos)) = value;
			}
		}

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x06005DB1 RID: 23985 RVA: 0x001B0218 File Offset: 0x001AE418
		// (set) Token: 0x06005DB2 RID: 23986 RVA: 0x0002C2E4 File Offset: 0x0002A4E4
		public unsafe float timeSinceValueChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_timeSinceValueChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_timeSinceValueChange)) = value;
			}
		}

		// Token: 0x0400400C RID: 16396
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400400D RID: 16397
		private static readonly IntPtr NativeFieldInfoPtr_Door;

		// Token: 0x0400400E RID: 16398
		private static readonly IntPtr NativeFieldInfoPtr_LocalPos_Open;

		// Token: 0x0400400F RID: 16399
		private static readonly IntPtr NativeFieldInfoPtr_LocalPos_Closed;

		// Token: 0x04004010 RID: 16400
		private static readonly IntPtr NativeFieldInfoPtr_LerpTime;

		// Token: 0x04004011 RID: 16401
		private static readonly IntPtr NativeFieldInfoPtr_Blocker;

		// Token: 0x04004012 RID: 16402
		private static readonly IntPtr NativeFieldInfoPtr_startPos;

		// Token: 0x04004013 RID: 16403
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceValueChange;

		// Token: 0x04004014 RID: 16404
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04004015 RID: 16405
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04004016 RID: 16406
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004017 RID: 16407
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04004018 RID: 16408
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04004019 RID: 16409
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400401A RID: 16410
		private static readonly IntPtr NativeMethodInfoPtr_CanOpen_Protected_Virtual_New_Boolean_0;

		// Token: 0x0400401B RID: 16411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
