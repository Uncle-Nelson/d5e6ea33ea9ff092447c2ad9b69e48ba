using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000609 RID: 1545
	public class BoneTransform : Il2CppSystem.Object
	{
		// Token: 0x0600883C RID: 34876 RVA: 0x0023E23C File Offset: 0x0023C43C
		// Note: this type is marked as 'beforefieldinit'.
		static BoneTransform()
		{
			Il2CppClassPointerStore<BoneTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "BoneTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr);
			BoneTransform.NativeFieldInfoPtr__Position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, "<Position>k__BackingField");
			BoneTransform.NativeFieldInfoPtr__Rotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, "<Rotation>k__BackingField");
			BoneTransform.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100680288);
			BoneTransform.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100680289);
			BoneTransform.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100680290);
			BoneTransform.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100680291);
			BoneTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100680292);
		}

		// Token: 0x17002979 RID: 10617
		// (get) Token: 0x0600883D RID: 34877 RVA: 0x0023E2F8 File Offset: 0x0023C4F8
		// (set) Token: 0x0600883E RID: 34878 RVA: 0x0023E334 File Offset: 0x0023C534
		public unsafe Vector3 Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700297A RID: 10618
		// (get) Token: 0x0600883F RID: 34879 RVA: 0x0023E374 File Offset: 0x0023C574
		// (set) Token: 0x06008840 RID: 34880 RVA: 0x0023E3B0 File Offset: 0x0023C5B0
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008841 RID: 34881 RVA: 0x0023E3F0 File Offset: 0x0023C5F0
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoneTransform() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008842 RID: 34882 RVA: 0x00040F47 File Offset: 0x0003F147
		public BoneTransform(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002977 RID: 10615
		// (get) Token: 0x06008843 RID: 34883 RVA: 0x0023E42C File Offset: 0x0023C62C
		// (set) Token: 0x06008844 RID: 34884 RVA: 0x00040F50 File Offset: 0x0003F150
		public unsafe Vector3 _Position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoneTransform.NativeFieldInfoPtr__Position_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoneTransform.NativeFieldInfoPtr__Position_k__BackingField)) = value;
			}
		}

		// Token: 0x17002978 RID: 10616
		// (get) Token: 0x06008845 RID: 34885 RVA: 0x0023E454 File Offset: 0x0023C654
		// (set) Token: 0x06008846 RID: 34886 RVA: 0x00040F6B File Offset: 0x0003F16B
		public unsafe Quaternion _Rotation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoneTransform.NativeFieldInfoPtr__Rotation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoneTransform.NativeFieldInfoPtr__Rotation_k__BackingField)) = value;
			}
		}

		// Token: 0x04005C95 RID: 23701
		private static readonly IntPtr NativeFieldInfoPtr__Position_k__BackingField;

		// Token: 0x04005C96 RID: 23702
		private static readonly IntPtr NativeFieldInfoPtr__Rotation_k__BackingField;

		// Token: 0x04005C97 RID: 23703
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

		// Token: 0x04005C98 RID: 23704
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0;

		// Token: 0x04005C99 RID: 23705
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04005C9A RID: 23706
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04005C9B RID: 23707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
