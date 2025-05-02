using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppStylizedGrassDemo
{
	// Token: 0x020000C2 RID: 194
	public class MoveInCircle : MonoBehaviour
	{
		// Token: 0x06000E81 RID: 3713 RVA: 0x0009ED14 File Offset: 0x0009CF14
		// Note: this type is marked as 'beforefieldinit'.
		static MoveInCircle()
		{
			Il2CppClassPointerStore<MoveInCircle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "StylizedGrassDemo", "MoveInCircle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveInCircle>.NativeClassPtr);
			MoveInCircle.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveInCircle>.NativeClassPtr, "radius");
			MoveInCircle.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveInCircle>.NativeClassPtr, "speed");
			MoveInCircle.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveInCircle>.NativeClassPtr, "offset");
			MoveInCircle.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveInCircle>.NativeClassPtr, 100665042);
			MoveInCircle.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveInCircle>.NativeClassPtr, 100665043);
			MoveInCircle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveInCircle>.NativeClassPtr, 100665044);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0009EDBC File Offset: 0x0009CFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85803, XrefRangeEnd = 85811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveInCircle.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0009EDF0 File Offset: 0x0009CFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveInCircle.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0009EE24 File Offset: 0x0009D024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85811, XrefRangeEnd = 85812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveInCircle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveInCircle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveInCircle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0000914E File Offset: 0x0000734E
		public MoveInCircle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x0009EE60 File Offset: 0x0009D060
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x00009157 File Offset: 0x00007357
		public unsafe float radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveInCircle.NativeFieldInfoPtr_radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveInCircle.NativeFieldInfoPtr_radius)) = value;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x0009EE88 File Offset: 0x0009D088
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x00009172 File Offset: 0x00007372
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveInCircle.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveInCircle.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x0009EEB0 File Offset: 0x0009D0B0
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x0000918D File Offset: 0x0000738D
		public unsafe Vector3 offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveInCircle.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveInCircle.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeFieldInfoPtr_radius;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
