using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000C8 RID: 200
	public class CubeSpawn : MonoBehaviour
	{
		// Token: 0x06000EDF RID: 3807 RVA: 0x0009FBB8 File Offset: 0x0009DDB8
		// Note: this type is marked as 'beforefieldinit'.
		static CubeSpawn()
		{
			Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "CubeSpawn");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr);
			CubeSpawn.NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr, "instances");
			CubeSpawn.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr, "radius");
			CubeSpawn.NativeFieldInfoPtr_jitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr, "jitter");
			CubeSpawn.NativeFieldInfoPtr_expansion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr, "expansion");
			CubeSpawn.NativeFieldInfoPtr_laps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr, "laps");
			CubeSpawn.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr, 100665068);
			CubeSpawn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr, 100665069);
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0009FC74 File Offset: 0x0009DE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86044, XrefRangeEnd = 86071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubeSpawn.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0009FCA8 File Offset: 0x0009DEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86071, XrefRangeEnd = 86072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubeSpawn() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubeSpawn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x000094EC File Offset: 0x000076EC
		public CubeSpawn(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x0009FCE4 File Offset: 0x0009DEE4
		// (set) Token: 0x06000EE4 RID: 3812 RVA: 0x000094F5 File Offset: 0x000076F5
		public unsafe int instances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_instances);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_instances)) = value;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x0009FD0C File Offset: 0x0009DF0C
		// (set) Token: 0x06000EE6 RID: 3814 RVA: 0x00009510 File Offset: 0x00007710
		public unsafe float radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_radius)) = value;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x0009FD34 File Offset: 0x0009DF34
		// (set) Token: 0x06000EE8 RID: 3816 RVA: 0x0000952B File Offset: 0x0000772B
		public unsafe float jitter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_jitter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_jitter)) = value;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x0009FD5C File Offset: 0x0009DF5C
		// (set) Token: 0x06000EEA RID: 3818 RVA: 0x00009546 File Offset: 0x00007746
		public unsafe float expansion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_expansion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_expansion)) = value;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x0009FD84 File Offset: 0x0009DF84
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x00009561 File Offset: 0x00007761
		public unsafe float laps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_laps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_laps)) = value;
			}
		}

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeFieldInfoPtr_instances;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeFieldInfoPtr_radius;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeFieldInfoPtr_jitter;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeFieldInfoPtr_expansion;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeFieldInfoPtr_laps;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
