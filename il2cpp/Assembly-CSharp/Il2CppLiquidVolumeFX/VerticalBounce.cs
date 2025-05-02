using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000D0 RID: 208
	public class VerticalBounce : MonoBehaviour
	{
		// Token: 0x06000F72 RID: 3954 RVA: 0x000A1054 File Offset: 0x0009F254
		// Note: this type is marked as 'beforefieldinit'.
		static VerticalBounce()
		{
			Il2CppClassPointerStore<VerticalBounce>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "VerticalBounce");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerticalBounce>.NativeClassPtr);
			VerticalBounce.NativeFieldInfoPtr_acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalBounce>.NativeClassPtr, "acceleration");
			VerticalBounce.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalBounce>.NativeClassPtr, "direction");
			VerticalBounce.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalBounce>.NativeClassPtr, "y");
			VerticalBounce.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalBounce>.NativeClassPtr, "speed");
			VerticalBounce.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalBounce>.NativeClassPtr, 100665089);
			VerticalBounce.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalBounce>.NativeClassPtr, 100665090);
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x000A10FC File Offset: 0x0009F2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86262, XrefRangeEnd = 86270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalBounce.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x000A1130 File Offset: 0x0009F330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86270, XrefRangeEnd = 86271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VerticalBounce() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VerticalBounce>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalBounce.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00009B09 File Offset: 0x00007D09
		public VerticalBounce(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x000A116C File Offset: 0x0009F36C
		// (set) Token: 0x06000F77 RID: 3959 RVA: 0x00009B12 File Offset: 0x00007D12
		public unsafe float acceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalBounce.NativeFieldInfoPtr_acceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalBounce.NativeFieldInfoPtr_acceleration)) = value;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x000A1194 File Offset: 0x0009F394
		// (set) Token: 0x06000F79 RID: 3961 RVA: 0x00009B2D File Offset: 0x00007D2D
		public unsafe float direction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalBounce.NativeFieldInfoPtr_direction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalBounce.NativeFieldInfoPtr_direction)) = value;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x000A11BC File Offset: 0x0009F3BC
		// (set) Token: 0x06000F7B RID: 3963 RVA: 0x00009B48 File Offset: 0x00007D48
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalBounce.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalBounce.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x000A11E4 File Offset: 0x0009F3E4
		// (set) Token: 0x06000F7D RID: 3965 RVA: 0x00009B63 File Offset: 0x00007D63
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalBounce.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalBounce.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeFieldInfoPtr_acceleration;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeFieldInfoPtr_direction;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
