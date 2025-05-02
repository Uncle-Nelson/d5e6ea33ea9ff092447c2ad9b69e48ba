using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000471 RID: 1137
	[Serializable]
	[StructLayout(2)]
	public struct DisplaySettings
	{
		// Token: 0x06006262 RID: 25186 RVA: 0x001BF700 File Offset: 0x001BD900
		// Note: this type is marked as 'beforefieldinit'.
		static DisplaySettings()
		{
			Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "DisplaySettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr);
			DisplaySettings.NativeFieldInfoPtr_ResolutionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "ResolutionIndex");
			DisplaySettings.NativeFieldInfoPtr_DisplayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "DisplayMode");
			DisplaySettings.NativeFieldInfoPtr_VSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "VSync");
			DisplaySettings.NativeFieldInfoPtr_TargetFPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "TargetFPS");
			DisplaySettings.NativeFieldInfoPtr_UIScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "UIScale");
			DisplaySettings.NativeFieldInfoPtr_CameraBobbing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "CameraBobbing");
			DisplaySettings.NativeFieldInfoPtr_ActiveDisplayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "ActiveDisplayIndex");
			DisplaySettings.NativeMethodInfoPtr_GetResolutions_Public_Static_List_1_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, 100675772);
		}

		// Token: 0x06006263 RID: 25187 RVA: 0x001BF7D0 File Offset: 0x001BD9D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202148, RefRangeEnd = 202150, XrefRangeStart = 202118, XrefRangeEnd = 202148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Resolution> GetResolutions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplaySettings.NativeMethodInfoPtr_GetResolutions_Public_Static_List_1_Resolution_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Resolution>>(intPtr3) : null;
		}

		// Token: 0x06006264 RID: 25188 RVA: 0x0002E831 File Offset: 0x0002CA31
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, ref this));
		}

		// Token: 0x0400430F RID: 17167
		private static readonly IntPtr NativeFieldInfoPtr_ResolutionIndex;

		// Token: 0x04004310 RID: 17168
		private static readonly IntPtr NativeFieldInfoPtr_DisplayMode;

		// Token: 0x04004311 RID: 17169
		private static readonly IntPtr NativeFieldInfoPtr_VSync;

		// Token: 0x04004312 RID: 17170
		private static readonly IntPtr NativeFieldInfoPtr_TargetFPS;

		// Token: 0x04004313 RID: 17171
		private static readonly IntPtr NativeFieldInfoPtr_UIScale;

		// Token: 0x04004314 RID: 17172
		private static readonly IntPtr NativeFieldInfoPtr_CameraBobbing;

		// Token: 0x04004315 RID: 17173
		private static readonly IntPtr NativeFieldInfoPtr_ActiveDisplayIndex;

		// Token: 0x04004316 RID: 17174
		private static readonly IntPtr NativeMethodInfoPtr_GetResolutions_Public_Static_List_1_Resolution_0;

		// Token: 0x04004317 RID: 17175
		[FieldOffset(0)]
		public int ResolutionIndex;

		// Token: 0x04004318 RID: 17176
		[FieldOffset(4)]
		public DisplaySettings.EDisplayMode DisplayMode;

		// Token: 0x04004319 RID: 17177
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool VSync;

		// Token: 0x0400431A RID: 17178
		[FieldOffset(12)]
		public int TargetFPS;

		// Token: 0x0400431B RID: 17179
		[FieldOffset(16)]
		public float UIScale;

		// Token: 0x0400431C RID: 17180
		[FieldOffset(20)]
		public float CameraBobbing;

		// Token: 0x0400431D RID: 17181
		[FieldOffset(24)]
		public int ActiveDisplayIndex;

		// Token: 0x02000A1C RID: 2588
		[OriginalName("Assembly-CSharp.dll", "", "EDisplayMode")]
		public enum EDisplayMode
		{
			// Token: 0x04008BAE RID: 35758
			Windowed,
			// Token: 0x04008BAF RID: 35759
			FullscreenWindow,
			// Token: 0x04008BB0 RID: 35760
			ExclusiveFullscreen
		}

		// Token: 0x02000A1D RID: 2589
		[ObfuscatedName("ScheduleOne.DevUtilities.DisplaySettings+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CF11 RID: 53009 RVA: 0x0031C558 File Offset: 0x0031A758
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr);
				DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr_resolutions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr, "resolutions");
				DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr, "i");
				DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr, "<>9__0");
				DisplaySettings.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr, 100675773);
				DisplaySettings.__c__DisplayClass8_0.NativeMethodInfoPtr__GetResolutions_b__0_Internal_Boolean_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr, 100675774);
			}

			// Token: 0x0600CF12 RID: 53010 RVA: 0x0031C5E8 File Offset: 0x0031A7E8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplaySettings.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF13 RID: 53011 RVA: 0x0031C624 File Offset: 0x0031A824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202116, XrefRangeEnd = 202118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetResolutions_b__0(Resolution x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplaySettings.__c__DisplayClass8_0.NativeMethodInfoPtr__GetResolutions_b__0_Internal_Boolean_Resolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CF14 RID: 53012 RVA: 0x00064B70 File Offset: 0x00062D70
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004063 RID: 16483
			// (get) Token: 0x0600CF15 RID: 53013 RVA: 0x0031C670 File Offset: 0x0031A870
			// (set) Token: 0x0600CF16 RID: 53014 RVA: 0x00064B79 File Offset: 0x00062D79
			public unsafe Il2CppStructArray<Resolution> resolutions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr_resolutions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Resolution>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr_resolutions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004064 RID: 16484
			// (get) Token: 0x0600CF17 RID: 53015 RVA: 0x0031C6A0 File Offset: 0x0031A8A0
			// (set) Token: 0x0600CF18 RID: 53016 RVA: 0x00064B98 File Offset: 0x00062D98
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x17004065 RID: 16485
			// (get) Token: 0x0600CF19 RID: 53017 RVA: 0x0031C6C8 File Offset: 0x0031A8C8
			// (set) Token: 0x0600CF1A RID: 53018 RVA: 0x00064BB3 File Offset: 0x00062DB3
			public unsafe Predicate<Resolution> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Resolution>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BB1 RID: 35761
			private static readonly IntPtr NativeFieldInfoPtr_resolutions;

			// Token: 0x04008BB2 RID: 35762
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04008BB3 RID: 35763
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04008BB4 RID: 35764
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BB5 RID: 35765
			private static readonly IntPtr NativeMethodInfoPtr__GetResolutions_b__0_Internal_Boolean_Resolution_0;
		}
	}
}
