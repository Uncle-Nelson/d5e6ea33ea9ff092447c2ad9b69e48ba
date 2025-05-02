using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppVLB_Samples
{
	// Token: 0x020000BD RID: 189
	public class LightGenerator : MonoBehaviour
	{
		// Token: 0x06000E1E RID: 3614 RVA: 0x0009DF30 File Offset: 0x0009C130
		// Note: this type is marked as 'beforefieldinit'.
		static LightGenerator()
		{
			Il2CppClassPointerStore<LightGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB_Samples", "LightGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr);
			LightGenerator.NativeFieldInfoPtr_CountX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, "CountX");
			LightGenerator.NativeFieldInfoPtr_CountY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, "CountY");
			LightGenerator.NativeFieldInfoPtr_OffsetUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, "OffsetUnits");
			LightGenerator.NativeFieldInfoPtr_PositionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, "PositionY");
			LightGenerator.NativeFieldInfoPtr_NoiseEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, "NoiseEnabled");
			LightGenerator.NativeFieldInfoPtr_AddLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, "AddLight");
			LightGenerator.NativeMethodInfoPtr_Generate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, 100665029);
			LightGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, 100665030);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x0009E000 File Offset: 0x0009C200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85595, XrefRangeEnd = 85683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Generate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightGenerator.NativeMethodInfoPtr_Generate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x0009E034 File Offset: 0x0009C234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85683, XrefRangeEnd = 85684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00008D07 File Offset: 0x00006F07
		public LightGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x0009E070 File Offset: 0x0009C270
		// (set) Token: 0x06000E23 RID: 3619 RVA: 0x00008D10 File Offset: 0x00006F10
		public unsafe int CountX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_CountX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_CountX)) = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x0009E098 File Offset: 0x0009C298
		// (set) Token: 0x06000E25 RID: 3621 RVA: 0x00008D2B File Offset: 0x00006F2B
		public unsafe int CountY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_CountY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_CountY)) = value;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x0009E0C0 File Offset: 0x0009C2C0
		// (set) Token: 0x06000E27 RID: 3623 RVA: 0x00008D46 File Offset: 0x00006F46
		public unsafe float OffsetUnits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_OffsetUnits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_OffsetUnits)) = value;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x0009E0E8 File Offset: 0x0009C2E8
		// (set) Token: 0x06000E29 RID: 3625 RVA: 0x00008D61 File Offset: 0x00006F61
		public unsafe float PositionY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_PositionY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_PositionY)) = value;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x0009E110 File Offset: 0x0009C310
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x00008D7C File Offset: 0x00006F7C
		public unsafe bool NoiseEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_NoiseEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_NoiseEnabled)) = value;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x0009E138 File Offset: 0x0009C338
		// (set) Token: 0x06000E2D RID: 3629 RVA: 0x00008D97 File Offset: 0x00006F97
		public unsafe bool AddLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_AddLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_AddLight)) = value;
			}
		}

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeFieldInfoPtr_CountX;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeFieldInfoPtr_CountY;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeFieldInfoPtr_OffsetUnits;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeFieldInfoPtr_PositionY;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeFieldInfoPtr_NoiseEnabled;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeFieldInfoPtr_AddLight;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Void_0;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
