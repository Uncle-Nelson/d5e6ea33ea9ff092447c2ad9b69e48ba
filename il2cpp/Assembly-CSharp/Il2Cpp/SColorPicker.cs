using System;
using Il2CppHSVPicker;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2Cpp
{
	// Token: 0x02000014 RID: 20
	public class SColorPicker : ColorPicker
	{
		// Token: 0x06000170 RID: 368 RVA: 0x00075324 File Offset: 0x00073524
		// Note: this type is marked as 'beforefieldinit'.
		static SColorPicker()
		{
			Il2CppClassPointerStore<SColorPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SColorPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr);
			SColorPicker.NativeFieldInfoPtr_PropertyIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr, "PropertyIndex");
			SColorPicker.NativeFieldInfoPtr_onValueChangeWithIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr, "onValueChangeWithIndex");
			SColorPicker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr, 100663416);
			SColorPicker.NativeMethodInfoPtr_ValueChanged_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr, 100663417);
			SColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr, 100663418);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000753B8 File Offset: 0x000735B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72005, XrefRangeEnd = 72015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SColorPicker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000753EC File Offset: 0x000735EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72015, XrefRangeEnd = 72018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueChanged(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SColorPicker.NativeMethodInfoPtr_ValueChanged_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0007542C File Offset: 0x0007362C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72018, XrefRangeEnd = 72019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SColorPicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SColorPicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002D00 File Offset: 0x00000F00
		public SColorPicker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00075468 File Offset: 0x00073668
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00002D09 File Offset: 0x00000F09
		public unsafe int PropertyIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SColorPicker.NativeFieldInfoPtr_PropertyIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SColorPicker.NativeFieldInfoPtr_PropertyIndex)) = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00075490 File Offset: 0x00073690
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002D24 File Offset: 0x00000F24
		public unsafe UnityEvent<Color, int> onValueChangeWithIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SColorPicker.NativeFieldInfoPtr_onValueChangeWithIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Color, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SColorPicker.NativeFieldInfoPtr_onValueChangeWithIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_PropertyIndex;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_onValueChangeWithIndex;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_ValueChanged_Private_Void_Color_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
