using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000030 RID: 48
	public class WarehouseModular : MonoBehaviour
	{
		// Token: 0x06000355 RID: 853 RVA: 0x0007AD30 File Offset: 0x00078F30
		// Note: this type is marked as 'beforefieldinit'.
		static WarehouseModular()
		{
			Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WarehouseModular");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr);
			WarehouseModular.NativeFieldInfoPtr_itemsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr, "itemsList");
			WarehouseModular.NativeFieldInfoPtr_largeWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr, "largeWall");
			WarehouseModular.NativeFieldInfoPtr_mediumWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr, "mediumWall");
			WarehouseModular.NativeFieldInfoPtr_smallWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr, "smallWall");
			WarehouseModular.NativeFieldInfoPtr_miniWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr, "miniWall");
			WarehouseModular.NativeFieldInfoPtr_tinyWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr, "tinyWall");
			WarehouseModular.NativeFieldInfoPtr_windowWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr, "windowWall");
			WarehouseModular.NativeFieldInfoPtr_smallWindowWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr, "smallWindowWall");
			WarehouseModular.NativeFieldInfoPtr_innerCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr, "innerCorner");
			WarehouseModular.NativeFieldInfoPtr_outerCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr, "outerCorner");
			WarehouseModular.NativeFieldInfoPtr_garageFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr, "garageFrame");
			WarehouseModular.NativeFieldInfoPtr_doorFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr, "doorFrame");
			WarehouseModular.NativeFieldInfoPtr_doubleDoorFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr, "doubleDoorFrame");
			WarehouseModular.NativeFieldInfoPtr_myMeshFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr, "myMeshFilter");
			WarehouseModular.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr, 100663626);
			WarehouseModular.NativeMethodInfoPtr_BuildNextItem_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr, 100663627);
			WarehouseModular.NativeMethodInfoPtr_DeleteLastItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr, 100663628);
			WarehouseModular.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr, 100663629);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0007AEC8 File Offset: 0x000790C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73445, XrefRangeEnd = 73534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarehouseModular.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0007AEFC File Offset: 0x000790FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73534, XrefRangeEnd = 73564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildNextItem(GameObject item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarehouseModular.NativeMethodInfoPtr_BuildNextItem_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0007AF40 File Offset: 0x00079140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73564, XrefRangeEnd = 73585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteLastItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarehouseModular.NativeMethodInfoPtr_DeleteLastItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0007AF74 File Offset: 0x00079174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73585, XrefRangeEnd = 73593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WarehouseModular() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarehouseModular>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarehouseModular.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00003DC7 File Offset: 0x00001FC7
		public WarehouseModular(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0007AFB0 File Offset: 0x000791B0
		// (set) Token: 0x0600035C RID: 860 RVA: 0x00003DD0 File Offset: 0x00001FD0
		public unsafe List<GameObject> itemsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_itemsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_itemsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0007AFE0 File Offset: 0x000791E0
		// (set) Token: 0x0600035E RID: 862 RVA: 0x00003DEF File Offset: 0x00001FEF
		public unsafe GameObject largeWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_largeWall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_largeWall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600035F RID: 863 RVA: 0x0007B010 File Offset: 0x00079210
		// (set) Token: 0x06000360 RID: 864 RVA: 0x00003E0E File Offset: 0x0000200E
		public unsafe GameObject mediumWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_mediumWall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_mediumWall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000361 RID: 865 RVA: 0x0007B040 File Offset: 0x00079240
		// (set) Token: 0x06000362 RID: 866 RVA: 0x00003E2D File Offset: 0x0000202D
		public unsafe GameObject smallWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_smallWall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_smallWall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000363 RID: 867 RVA: 0x0007B070 File Offset: 0x00079270
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00003E4C File Offset: 0x0000204C
		public unsafe GameObject miniWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_miniWall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_miniWall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000365 RID: 869 RVA: 0x0007B0A0 File Offset: 0x000792A0
		// (set) Token: 0x06000366 RID: 870 RVA: 0x00003E6B File Offset: 0x0000206B
		public unsafe GameObject tinyWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_tinyWall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_tinyWall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000367 RID: 871 RVA: 0x0007B0D0 File Offset: 0x000792D0
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00003E8A File Offset: 0x0000208A
		public unsafe GameObject windowWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_windowWall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_windowWall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0007B100 File Offset: 0x00079300
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00003EA9 File Offset: 0x000020A9
		public unsafe GameObject smallWindowWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_smallWindowWall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_smallWindowWall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0007B130 File Offset: 0x00079330
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00003EC8 File Offset: 0x000020C8
		public unsafe GameObject innerCorner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_innerCorner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_innerCorner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0007B160 File Offset: 0x00079360
		// (set) Token: 0x0600036E RID: 878 RVA: 0x00003EE7 File Offset: 0x000020E7
		public unsafe GameObject outerCorner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_outerCorner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_outerCorner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0007B190 File Offset: 0x00079390
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00003F06 File Offset: 0x00002106
		public unsafe GameObject garageFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_garageFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_garageFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000371 RID: 881 RVA: 0x0007B1C0 File Offset: 0x000793C0
		// (set) Token: 0x06000372 RID: 882 RVA: 0x00003F25 File Offset: 0x00002125
		public unsafe GameObject doorFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_doorFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_doorFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000373 RID: 883 RVA: 0x0007B1F0 File Offset: 0x000793F0
		// (set) Token: 0x06000374 RID: 884 RVA: 0x00003F44 File Offset: 0x00002144
		public unsafe GameObject doubleDoorFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_doubleDoorFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_doubleDoorFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000375 RID: 885 RVA: 0x0007B220 File Offset: 0x00079420
		// (set) Token: 0x06000376 RID: 886 RVA: 0x00003F63 File Offset: 0x00002163
		public unsafe MeshFilter myMeshFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_myMeshFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarehouseModular.NativeFieldInfoPtr_myMeshFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr_itemsList;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeFieldInfoPtr_largeWall;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr_mediumWall;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr_smallWall;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_miniWall;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_tinyWall;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeFieldInfoPtr_windowWall;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr_smallWindowWall;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeFieldInfoPtr_innerCorner;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeFieldInfoPtr_outerCorner;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeFieldInfoPtr_garageFrame;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeFieldInfoPtr_doorFrame;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr_doubleDoorFrame;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeFieldInfoPtr_myMeshFilter;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_BuildNextItem_Public_Void_GameObject_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_DeleteLastItem_Public_Void_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
