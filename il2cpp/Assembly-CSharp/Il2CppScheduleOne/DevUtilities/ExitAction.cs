using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000477 RID: 1143
	public class ExitAction : Object
	{
		// Token: 0x060062BB RID: 25275 RVA: 0x001C0910 File Offset: 0x001BEB10
		// Note: this type is marked as 'beforefieldinit'.
		static ExitAction()
		{
			Il2CppClassPointerStore<ExitAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "ExitAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitAction>.NativeClassPtr);
			ExitAction.NativeFieldInfoPtr_exitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, "exitType");
			ExitAction.NativeFieldInfoPtr_used = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, "used");
			ExitAction.NativeMethodInfoPtr_get_Used_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, 100675815);
			ExitAction.NativeMethodInfoPtr_set_Used_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, 100675816);
			ExitAction.NativeMethodInfoPtr_Use_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, 100675817);
			ExitAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, 100675818);
		}

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x060062BC RID: 25276 RVA: 0x001C09B8 File Offset: 0x001BEBB8
		// (set) Token: 0x060062BD RID: 25277 RVA: 0x001C09F4 File Offset: 0x001BEBF4
		public unsafe bool Used
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitAction.NativeMethodInfoPtr_get_Used_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(62)]
			[CachedScanResults(RefRangeStart = 202502, RefRangeEnd = 202564, XrefRangeStart = 202502, XrefRangeEnd = 202502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitAction.NativeMethodInfoPtr_set_Used_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060062BE RID: 25278 RVA: 0x001C0A34 File Offset: 0x001BEC34
		[CallerCount(0)]
		public unsafe void Use()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitAction.NativeMethodInfoPtr_Use_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062BF RID: 25279 RVA: 0x001C0A68 File Offset: 0x001BEC68
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExitAction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062C0 RID: 25280 RVA: 0x0002EAFB File Offset: 0x0002CCFB
		public ExitAction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x060062C1 RID: 25281 RVA: 0x001C0AA4 File Offset: 0x001BECA4
		// (set) Token: 0x060062C2 RID: 25282 RVA: 0x0002EB04 File Offset: 0x0002CD04
		public unsafe ExitType exitType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitAction.NativeFieldInfoPtr_exitType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitAction.NativeFieldInfoPtr_exitType)) = value;
			}
		}

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x060062C3 RID: 25283 RVA: 0x001C0ACC File Offset: 0x001BECCC
		// (set) Token: 0x060062C4 RID: 25284 RVA: 0x0002EB1F File Offset: 0x0002CD1F
		public unsafe bool used
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitAction.NativeFieldInfoPtr_used);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitAction.NativeFieldInfoPtr_used)) = value;
			}
		}

		// Token: 0x04004358 RID: 17240
		private static readonly IntPtr NativeFieldInfoPtr_exitType;

		// Token: 0x04004359 RID: 17241
		private static readonly IntPtr NativeFieldInfoPtr_used;

		// Token: 0x0400435A RID: 17242
		private static readonly IntPtr NativeMethodInfoPtr_get_Used_Public_get_Boolean_0;

		// Token: 0x0400435B RID: 17243
		private static readonly IntPtr NativeMethodInfoPtr_set_Used_Public_set_Void_Boolean_0;

		// Token: 0x0400435C RID: 17244
		private static readonly IntPtr NativeMethodInfoPtr_Use_Public_Void_0;

		// Token: 0x0400435D RID: 17245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
