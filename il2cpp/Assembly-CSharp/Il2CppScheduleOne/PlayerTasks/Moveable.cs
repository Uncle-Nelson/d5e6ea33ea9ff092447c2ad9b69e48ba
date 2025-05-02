using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x020001FE RID: 510
	public class Moveable : Clickable
	{
		// Token: 0x06002A35 RID: 10805 RVA: 0x000F6548 File Offset: 0x000F4748
		// Note: this type is marked as 'beforefieldinit'.
		static Moveable()
		{
			Il2CppClassPointerStore<Moveable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "Moveable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Moveable>.NativeClassPtr);
			Moveable.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Moveable>.NativeClassPtr, "clickOffset");
			Moveable.NativeFieldInfoPtr_clickDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Moveable>.NativeClassPtr, "clickDist");
			Moveable.NativeFieldInfoPtr_yMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Moveable>.NativeClassPtr, "yMax");
			Moveable.NativeFieldInfoPtr_yMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Moveable>.NativeClassPtr, "yMin");
			Moveable.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Moveable>.NativeClassPtr, 100668051);
			Moveable.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Moveable>.NativeClassPtr, 100668052);
			Moveable.NativeMethodInfoPtr_EndClick_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Moveable>.NativeClassPtr, 100668053);
			Moveable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Moveable>.NativeClassPtr, 100668054);
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x000F6618 File Offset: 0x000F4818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120499, XrefRangeEnd = 120521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Moveable.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x000F6664 File Offset: 0x000F4864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120521, XrefRangeEnd = 120542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Moveable.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x000F66A0 File Offset: 0x000F48A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120542, XrefRangeEnd = 120543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Moveable.NativeMethodInfoPtr_EndClick_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x000F66DC File Offset: 0x000F48DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120543, XrefRangeEnd = 120546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Moveable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Moveable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Moveable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x00016DAA File Offset: 0x00014FAA
		public Moveable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06002A3B RID: 10811 RVA: 0x000F6718 File Offset: 0x000F4918
		// (set) Token: 0x06002A3C RID: 10812 RVA: 0x00016DB3 File Offset: 0x00014FB3
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06002A3D RID: 10813 RVA: 0x000F6740 File Offset: 0x000F4940
		// (set) Token: 0x06002A3E RID: 10814 RVA: 0x00016DCE File Offset: 0x00014FCE
		public unsafe float clickDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_clickDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_clickDist)) = value;
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06002A3F RID: 10815 RVA: 0x000F6768 File Offset: 0x000F4968
		// (set) Token: 0x06002A40 RID: 10816 RVA: 0x00016DE9 File Offset: 0x00014FE9
		public unsafe float yMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_yMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_yMax)) = value;
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06002A41 RID: 10817 RVA: 0x000F6790 File Offset: 0x000F4990
		// (set) Token: 0x06002A42 RID: 10818 RVA: 0x00016E04 File Offset: 0x00015004
		public unsafe float yMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_yMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_yMin)) = value;
			}
		}

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeFieldInfoPtr_clickDist;

		// Token: 0x04001C0B RID: 7179
		private static readonly IntPtr NativeFieldInfoPtr_yMax;

		// Token: 0x04001C0C RID: 7180
		private static readonly IntPtr NativeFieldInfoPtr_yMin;

		// Token: 0x04001C0D RID: 7181
		private static readonly IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0;

		// Token: 0x04001C0E RID: 7182
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04001C0F RID: 7183
		private static readonly IntPtr NativeMethodInfoPtr_EndClick_Public_Virtual_Void_0;

		// Token: 0x04001C10 RID: 7184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
