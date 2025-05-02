using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x020005FF RID: 1535
	public class AvatarEquippableLookAt : MonoBehaviour
	{
		// Token: 0x06008747 RID: 34631 RVA: 0x0023B924 File Offset: 0x00239B24
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEquippableLookAt()
		{
			Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarEquippableLookAt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr);
			AvatarEquippableLookAt.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, "Priority");
			AvatarEquippableLookAt.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, "avatar");
			AvatarEquippableLookAt.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, 100680181);
			AvatarEquippableLookAt.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, 100680182);
			AvatarEquippableLookAt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, 100680183);
		}

		// Token: 0x06008748 RID: 34632 RVA: 0x0023B9B8 File Offset: 0x00239BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251696, XrefRangeEnd = 251710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippableLookAt.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008749 RID: 34633 RVA: 0x0023B9EC File Offset: 0x00239BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251710, XrefRangeEnd = 251717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippableLookAt.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600874A RID: 34634 RVA: 0x0023BA20 File Offset: 0x00239C20
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEquippableLookAt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippableLookAt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600874B RID: 34635 RVA: 0x000405EC File Offset: 0x0003E7EC
		public AvatarEquippableLookAt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700291C RID: 10524
		// (get) Token: 0x0600874C RID: 34636 RVA: 0x0023BA5C File Offset: 0x00239C5C
		// (set) Token: 0x0600874D RID: 34637 RVA: 0x000405F5 File Offset: 0x0003E7F5
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippableLookAt.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippableLookAt.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x1700291D RID: 10525
		// (get) Token: 0x0600874E RID: 34638 RVA: 0x0023BA84 File Offset: 0x00239C84
		// (set) Token: 0x0600874F RID: 34639 RVA: 0x00040610 File Offset: 0x0003E810
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippableLookAt.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippableLookAt.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005C0A RID: 23562
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04005C0B RID: 23563
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04005C0C RID: 23564
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005C0D RID: 23565
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005C0E RID: 23566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
