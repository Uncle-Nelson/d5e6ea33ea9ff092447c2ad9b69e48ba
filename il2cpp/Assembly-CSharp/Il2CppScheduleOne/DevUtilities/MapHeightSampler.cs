using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200045B RID: 1115
	public class MapHeightSampler : Il2CppSystem.Object
	{
		// Token: 0x060060C9 RID: 24777 RVA: 0x001BA414 File Offset: 0x001B8614
		// Note: this type is marked as 'beforefieldinit'.
		static MapHeightSampler()
		{
			Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "MapHeightSampler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr);
			MapHeightSampler.NativeFieldInfoPtr_SampleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr, "SampleHeight");
			MapHeightSampler.NativeFieldInfoPtr_SampleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr, "SampleDistance");
			MapHeightSampler.NativeFieldInfoPtr_ResetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr, "ResetPosition");
			MapHeightSampler.NativeMethodInfoPtr_Sample_Public_Static_Boolean_Single_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr, 100675605);
			MapHeightSampler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr, 100675606);
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x001BA4A8 File Offset: 0x001B86A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 199668, RefRangeEnd = 199671, XrefRangeStart = 199646, XrefRangeEnd = 199668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Sample(float x, out float y, float z)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapHeightSampler.NativeMethodInfoPtr_Sample_Public_Static_Boolean_Single_byref_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060CB RID: 24779 RVA: 0x001BA504 File Offset: 0x001B8704
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapHeightSampler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapHeightSampler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060CC RID: 24780 RVA: 0x0002DC7E File Offset: 0x0002BE7E
		public MapHeightSampler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x060060CD RID: 24781 RVA: 0x001BA540 File Offset: 0x001B8740
		// (set) Token: 0x060060CE RID: 24782 RVA: 0x0002DC87 File Offset: 0x0002BE87
		public unsafe static float SampleHeight
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MapHeightSampler.NativeFieldInfoPtr_SampleHeight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MapHeightSampler.NativeFieldInfoPtr_SampleHeight, (void*)(&value));
			}
		}

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x060060CF RID: 24783 RVA: 0x001BA55C File Offset: 0x001B875C
		// (set) Token: 0x060060D0 RID: 24784 RVA: 0x0002DC95 File Offset: 0x0002BE95
		public unsafe static float SampleDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MapHeightSampler.NativeFieldInfoPtr_SampleDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MapHeightSampler.NativeFieldInfoPtr_SampleDistance, (void*)(&value));
			}
		}

		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x060060D1 RID: 24785 RVA: 0x001BA578 File Offset: 0x001B8778
		// (set) Token: 0x060060D2 RID: 24786 RVA: 0x0002DCA3 File Offset: 0x0002BEA3
		public unsafe static Vector3 ResetPosition
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(MapHeightSampler.NativeFieldInfoPtr_ResetPosition, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MapHeightSampler.NativeFieldInfoPtr_ResetPosition, (void*)(&value));
			}
		}

		// Token: 0x0400420D RID: 16909
		private static readonly IntPtr NativeFieldInfoPtr_SampleHeight;

		// Token: 0x0400420E RID: 16910
		private static readonly IntPtr NativeFieldInfoPtr_SampleDistance;

		// Token: 0x0400420F RID: 16911
		private static readonly IntPtr NativeFieldInfoPtr_ResetPosition;

		// Token: 0x04004210 RID: 16912
		private static readonly IntPtr NativeMethodInfoPtr_Sample_Public_Static_Boolean_Single_byref_Single_Single_0;

		// Token: 0x04004211 RID: 16913
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
