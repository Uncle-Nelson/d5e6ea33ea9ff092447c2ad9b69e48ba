using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x02000178 RID: 376
	public class VisionObscurer : MonoBehaviour
	{
		// Token: 0x06001E73 RID: 7795 RVA: 0x000CF224 File Offset: 0x000CD424
		// Note: this type is marked as 'beforefieldinit'.
		static VisionObscurer()
		{
			Il2CppClassPointerStore<VisionObscurer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "VisionObscurer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionObscurer>.NativeClassPtr);
			VisionObscurer.NativeFieldInfoPtr_ObscuranceAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionObscurer>.NativeClassPtr, "ObscuranceAmount");
			VisionObscurer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionObscurer>.NativeClassPtr, 100666745);
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x000CF27C File Offset: 0x000CD47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionObscurer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionObscurer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionObscurer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x0001130E File Offset: 0x0000F50E
		public VisionObscurer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x000CF2B8 File Offset: 0x000CD4B8
		// (set) Token: 0x06001E77 RID: 7799 RVA: 0x00011317 File Offset: 0x0000F517
		public unsafe float ObscuranceAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionObscurer.NativeFieldInfoPtr_ObscuranceAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionObscurer.NativeFieldInfoPtr_ObscuranceAmount)) = value;
			}
		}

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeFieldInfoPtr_ObscuranceAmount;

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
