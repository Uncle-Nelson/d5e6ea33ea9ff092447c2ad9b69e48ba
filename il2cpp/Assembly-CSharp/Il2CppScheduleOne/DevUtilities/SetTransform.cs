using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000469 RID: 1129
	public class SetTransform : MonoBehaviour
	{
		// Token: 0x060061D4 RID: 25044 RVA: 0x001BDBF8 File Offset: 0x001BBDF8
		// Note: this type is marked as 'beforefieldinit'.
		static SetTransform()
		{
			Il2CppClassPointerStore<SetTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "SetTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetTransform>.NativeClassPtr);
			SetTransform.NativeFieldInfoPtr_SetOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetOnAwake");
			SetTransform.NativeFieldInfoPtr_SetOnUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetOnUpdate");
			SetTransform.NativeFieldInfoPtr_SetOnLateUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetOnLateUpdate");
			SetTransform.NativeFieldInfoPtr_SetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetPosition");
			SetTransform.NativeFieldInfoPtr_LocalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "LocalPosition");
			SetTransform.NativeFieldInfoPtr_SetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetRotation");
			SetTransform.NativeFieldInfoPtr_LocalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "LocalRotation");
			SetTransform.NativeFieldInfoPtr_SetScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetScale");
			SetTransform.NativeFieldInfoPtr_LocalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "LocalScale");
			SetTransform.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100675720);
			SetTransform.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100675721);
			SetTransform.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100675722);
			SetTransform.NativeMethodInfoPtr_Set_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100675723);
			SetTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100675724);
		}

		// Token: 0x060061D5 RID: 25045 RVA: 0x001BDD40 File Offset: 0x001BBF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201455, XrefRangeEnd = 201456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061D6 RID: 25046 RVA: 0x001BDD74 File Offset: 0x001BBF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201456, XrefRangeEnd = 201457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061D7 RID: 25047 RVA: 0x001BDDA8 File Offset: 0x001BBFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201457, XrefRangeEnd = 201458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061D8 RID: 25048 RVA: 0x001BDDDC File Offset: 0x001BBFDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 201473, RefRangeEnd = 201476, XrefRangeStart = 201458, XrefRangeEnd = 201473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr_Set_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061D9 RID: 25049 RVA: 0x001BDE10 File Offset: 0x001BC010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201476, XrefRangeEnd = 201483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetTransform() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetTransform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061DA RID: 25050 RVA: 0x0002E3CC File Offset: 0x0002C5CC
		public SetTransform(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x060061DB RID: 25051 RVA: 0x001BDE4C File Offset: 0x001BC04C
		// (set) Token: 0x060061DC RID: 25052 RVA: 0x0002E3D5 File Offset: 0x0002C5D5
		public unsafe bool SetOnAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnAwake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnAwake)) = value;
			}
		}

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x060061DD RID: 25053 RVA: 0x001BDE74 File Offset: 0x001BC074
		// (set) Token: 0x060061DE RID: 25054 RVA: 0x0002E3F0 File Offset: 0x0002C5F0
		public unsafe bool SetOnUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnUpdate)) = value;
			}
		}

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x060061DF RID: 25055 RVA: 0x001BDE9C File Offset: 0x001BC09C
		// (set) Token: 0x060061E0 RID: 25056 RVA: 0x0002E40B File Offset: 0x0002C60B
		public unsafe bool SetOnLateUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnLateUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnLateUpdate)) = value;
			}
		}

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x060061E1 RID: 25057 RVA: 0x001BDEC4 File Offset: 0x001BC0C4
		// (set) Token: 0x060061E2 RID: 25058 RVA: 0x0002E426 File Offset: 0x0002C626
		public unsafe bool SetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetPosition)) = value;
			}
		}

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x060061E3 RID: 25059 RVA: 0x001BDEEC File Offset: 0x001BC0EC
		// (set) Token: 0x060061E4 RID: 25060 RVA: 0x0002E441 File Offset: 0x0002C641
		public unsafe Vector3 LocalPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalPosition)) = value;
			}
		}

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x060061E5 RID: 25061 RVA: 0x001BDF14 File Offset: 0x001BC114
		// (set) Token: 0x060061E6 RID: 25062 RVA: 0x0002E45C File Offset: 0x0002C65C
		public unsafe bool SetRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetRotation)) = value;
			}
		}

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x060061E7 RID: 25063 RVA: 0x001BDF3C File Offset: 0x001BC13C
		// (set) Token: 0x060061E8 RID: 25064 RVA: 0x0002E477 File Offset: 0x0002C677
		public unsafe Vector3 LocalRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalRotation)) = value;
			}
		}

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x060061E9 RID: 25065 RVA: 0x001BDF64 File Offset: 0x001BC164
		// (set) Token: 0x060061EA RID: 25066 RVA: 0x0002E492 File Offset: 0x0002C692
		public unsafe bool SetScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetScale)) = value;
			}
		}

		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x060061EB RID: 25067 RVA: 0x001BDF8C File Offset: 0x001BC18C
		// (set) Token: 0x060061EC RID: 25068 RVA: 0x0002E4AD File Offset: 0x0002C6AD
		public unsafe Vector3 LocalScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalScale)) = value;
			}
		}

		// Token: 0x040042B8 RID: 17080
		private static readonly IntPtr NativeFieldInfoPtr_SetOnAwake;

		// Token: 0x040042B9 RID: 17081
		private static readonly IntPtr NativeFieldInfoPtr_SetOnUpdate;

		// Token: 0x040042BA RID: 17082
		private static readonly IntPtr NativeFieldInfoPtr_SetOnLateUpdate;

		// Token: 0x040042BB RID: 17083
		private static readonly IntPtr NativeFieldInfoPtr_SetPosition;

		// Token: 0x040042BC RID: 17084
		private static readonly IntPtr NativeFieldInfoPtr_LocalPosition;

		// Token: 0x040042BD RID: 17085
		private static readonly IntPtr NativeFieldInfoPtr_SetRotation;

		// Token: 0x040042BE RID: 17086
		private static readonly IntPtr NativeFieldInfoPtr_LocalRotation;

		// Token: 0x040042BF RID: 17087
		private static readonly IntPtr NativeFieldInfoPtr_SetScale;

		// Token: 0x040042C0 RID: 17088
		private static readonly IntPtr NativeFieldInfoPtr_LocalScale;

		// Token: 0x040042C1 RID: 17089
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040042C2 RID: 17090
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040042C3 RID: 17091
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040042C4 RID: 17092
		private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_0;

		// Token: 0x040042C5 RID: 17093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
