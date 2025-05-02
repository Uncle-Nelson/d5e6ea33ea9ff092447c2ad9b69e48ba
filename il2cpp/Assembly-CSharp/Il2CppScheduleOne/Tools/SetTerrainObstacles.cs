using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000550 RID: 1360
	public class SetTerrainObstacles : MonoBehaviour
	{
		// Token: 0x060077E6 RID: 30694 RVA: 0x00207890 File Offset: 0x00205A90
		// Note: this type is marked as 'beforefieldinit'.
		static SetTerrainObstacles()
		{
			Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SetTerrainObstacles");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr);
			SetTerrainObstacles.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "Bounds");
			SetTerrainObstacles.NativeFieldInfoPtr_Obstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "Obstacle");
			SetTerrainObstacles.NativeFieldInfoPtr_terrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "terrain");
			SetTerrainObstacles.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "width");
			SetTerrainObstacles.NativeFieldInfoPtr_lenght = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "lenght");
			SetTerrainObstacles.NativeFieldInfoPtr_hight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "hight");
			SetTerrainObstacles.NativeFieldInfoPtr_isError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "isError");
			SetTerrainObstacles.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, 100678380);
			SetTerrainObstacles.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, 100678381);
		}

		// Token: 0x060077E7 RID: 30695 RVA: 0x00207974 File Offset: 0x00205B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232244, XrefRangeEnd = 232394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTerrainObstacles.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x002079A8 File Offset: 0x00205BA8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetTerrainObstacles() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTerrainObstacles.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077E9 RID: 30697 RVA: 0x00038C93 File Offset: 0x00036E93
		public SetTerrainObstacles(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002439 RID: 9273
		// (get) Token: 0x060077EA RID: 30698 RVA: 0x002079E4 File Offset: 0x00205BE4
		// (set) Token: 0x060077EB RID: 30699 RVA: 0x00038C9C File Offset: 0x00036E9C
		public unsafe BoxCollider Bounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_Bounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_Bounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243A RID: 9274
		// (get) Token: 0x060077EC RID: 30700 RVA: 0x00207A14 File Offset: 0x00205C14
		// (set) Token: 0x060077ED RID: 30701 RVA: 0x00038CBB File Offset: 0x00036EBB
		public unsafe Il2CppStructArray<TreeInstance> Obstacle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_Obstacle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TreeInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_Obstacle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243B RID: 9275
		// (get) Token: 0x060077EE RID: 30702 RVA: 0x00207A44 File Offset: 0x00205C44
		// (set) Token: 0x060077EF RID: 30703 RVA: 0x00038CDA File Offset: 0x00036EDA
		public unsafe Terrain terrain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_terrain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Terrain>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_terrain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243C RID: 9276
		// (get) Token: 0x060077F0 RID: 30704 RVA: 0x00207A74 File Offset: 0x00205C74
		// (set) Token: 0x060077F1 RID: 30705 RVA: 0x00038CF9 File Offset: 0x00036EF9
		public unsafe float width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_width)) = value;
			}
		}

		// Token: 0x1700243D RID: 9277
		// (get) Token: 0x060077F2 RID: 30706 RVA: 0x00207A9C File Offset: 0x00205C9C
		// (set) Token: 0x060077F3 RID: 30707 RVA: 0x00038D14 File Offset: 0x00036F14
		public unsafe float lenght
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_lenght);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_lenght)) = value;
			}
		}

		// Token: 0x1700243E RID: 9278
		// (get) Token: 0x060077F4 RID: 30708 RVA: 0x00207AC4 File Offset: 0x00205CC4
		// (set) Token: 0x060077F5 RID: 30709 RVA: 0x00038D2F File Offset: 0x00036F2F
		public unsafe float hight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_hight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_hight)) = value;
			}
		}

		// Token: 0x1700243F RID: 9279
		// (get) Token: 0x060077F6 RID: 30710 RVA: 0x00207AEC File Offset: 0x00205CEC
		// (set) Token: 0x060077F7 RID: 30711 RVA: 0x00038D4A File Offset: 0x00036F4A
		public unsafe bool isError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_isError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_isError)) = value;
			}
		}

		// Token: 0x040051C7 RID: 20935
		private static readonly IntPtr NativeFieldInfoPtr_Bounds;

		// Token: 0x040051C8 RID: 20936
		private static readonly IntPtr NativeFieldInfoPtr_Obstacle;

		// Token: 0x040051C9 RID: 20937
		private static readonly IntPtr NativeFieldInfoPtr_terrain;

		// Token: 0x040051CA RID: 20938
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x040051CB RID: 20939
		private static readonly IntPtr NativeFieldInfoPtr_lenght;

		// Token: 0x040051CC RID: 20940
		private static readonly IntPtr NativeFieldInfoPtr_hight;

		// Token: 0x040051CD RID: 20941
		private static readonly IntPtr NativeFieldInfoPtr_isError;

		// Token: 0x040051CE RID: 20942
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040051CF RID: 20943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
