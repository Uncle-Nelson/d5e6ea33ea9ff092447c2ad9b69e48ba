using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000569 RID: 1385
	public class FilledPackagingVisuals : MonoBehaviour
	{
		// Token: 0x060079B8 RID: 31160 RVA: 0x0020C8E8 File Offset: 0x0020AAE8
		// Note: this type is marked as 'beforefieldinit'.
		static FilledPackagingVisuals()
		{
			Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FilledPackagingVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr);
			FilledPackagingVisuals.NativeFieldInfoPtr_weedVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "weedVisuals");
			FilledPackagingVisuals.NativeFieldInfoPtr_methVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "methVisuals");
			FilledPackagingVisuals.NativeFieldInfoPtr_cocaineVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "cocaineVisuals");
			FilledPackagingVisuals.NativeMethodInfoPtr_ResetVisuals_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, 100678529);
			FilledPackagingVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, 100678530);
		}

		// Token: 0x060079B9 RID: 31161 RVA: 0x0020C97C File Offset: 0x0020AB7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233480, RefRangeEnd = 233483, XrefRangeStart = 233464, XrefRangeEnd = 233480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.NativeMethodInfoPtr_ResetVisuals_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079BA RID: 31162 RVA: 0x0020C9B0 File Offset: 0x0020ABB0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilledPackagingVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x00039EDD File Offset: 0x000380DD
		public FilledPackagingVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024D8 RID: 9432
		// (get) Token: 0x060079BC RID: 31164 RVA: 0x0020C9EC File Offset: 0x0020ABEC
		// (set) Token: 0x060079BD RID: 31165 RVA: 0x00039EE6 File Offset: 0x000380E6
		public unsafe FilledPackagingVisuals.WeedVisuals weedVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.NativeFieldInfoPtr_weedVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals.WeedVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.NativeFieldInfoPtr_weedVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D9 RID: 9433
		// (get) Token: 0x060079BE RID: 31166 RVA: 0x0020CA1C File Offset: 0x0020AC1C
		// (set) Token: 0x060079BF RID: 31167 RVA: 0x00039F05 File Offset: 0x00038105
		public unsafe FilledPackagingVisuals.MethVisuals methVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.NativeFieldInfoPtr_methVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals.MethVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.NativeFieldInfoPtr_methVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024DA RID: 9434
		// (get) Token: 0x060079C0 RID: 31168 RVA: 0x0020CA4C File Offset: 0x0020AC4C
		// (set) Token: 0x060079C1 RID: 31169 RVA: 0x00039F24 File Offset: 0x00038124
		public unsafe FilledPackagingVisuals.CocaineVisuals cocaineVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.NativeFieldInfoPtr_cocaineVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals.CocaineVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.NativeFieldInfoPtr_cocaineVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040052D1 RID: 21201
		private static readonly IntPtr NativeFieldInfoPtr_weedVisuals;

		// Token: 0x040052D2 RID: 21202
		private static readonly IntPtr NativeFieldInfoPtr_methVisuals;

		// Token: 0x040052D3 RID: 21203
		private static readonly IntPtr NativeFieldInfoPtr_cocaineVisuals;

		// Token: 0x040052D4 RID: 21204
		private static readonly IntPtr NativeMethodInfoPtr_ResetVisuals_Public_Void_0;

		// Token: 0x040052D5 RID: 21205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AAC RID: 2732
		[Serializable]
		public class MeshIndexPair : Il2CppSystem.Object
		{
			// Token: 0x0600D381 RID: 54145 RVA: 0x0032884C File Offset: 0x00326A4C
			// Note: this type is marked as 'beforefieldinit'.
			static MeshIndexPair()
			{
				Il2CppClassPointerStore<FilledPackagingVisuals.MeshIndexPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "MeshIndexPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackagingVisuals.MeshIndexPair>.NativeClassPtr);
				FilledPackagingVisuals.MeshIndexPair.NativeFieldInfoPtr_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.MeshIndexPair>.NativeClassPtr, "Mesh");
				FilledPackagingVisuals.MeshIndexPair.NativeFieldInfoPtr_MaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.MeshIndexPair>.NativeClassPtr, "MaterialIndex");
				FilledPackagingVisuals.MeshIndexPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals.MeshIndexPair>.NativeClassPtr, 100678531);
			}

			// Token: 0x0600D382 RID: 54146 RVA: 0x003288B4 File Offset: 0x00326AB4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeshIndexPair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackagingVisuals.MeshIndexPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.MeshIndexPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D383 RID: 54147 RVA: 0x00066F61 File Offset: 0x00065161
			public MeshIndexPair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004198 RID: 16792
			// (get) Token: 0x0600D384 RID: 54148 RVA: 0x003288F0 File Offset: 0x00326AF0
			// (set) Token: 0x0600D385 RID: 54149 RVA: 0x00066F6A File Offset: 0x0006516A
			public unsafe MeshRenderer Mesh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.MeshIndexPair.NativeFieldInfoPtr_Mesh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.MeshIndexPair.NativeFieldInfoPtr_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004199 RID: 16793
			// (get) Token: 0x0600D386 RID: 54150 RVA: 0x00328920 File Offset: 0x00326B20
			// (set) Token: 0x0600D387 RID: 54151 RVA: 0x00066F89 File Offset: 0x00065189
			public unsafe int MaterialIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.MeshIndexPair.NativeFieldInfoPtr_MaterialIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.MeshIndexPair.NativeFieldInfoPtr_MaterialIndex)) = value;
				}
			}

			// Token: 0x04008E7D RID: 36477
			private static readonly IntPtr NativeFieldInfoPtr_Mesh;

			// Token: 0x04008E7E RID: 36478
			private static readonly IntPtr NativeFieldInfoPtr_MaterialIndex;

			// Token: 0x04008E7F RID: 36479
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AAD RID: 2733
		[Serializable]
		public class BaseVisuals : Il2CppSystem.Object
		{
			// Token: 0x0600D388 RID: 54152 RVA: 0x00328948 File Offset: 0x00326B48
			// Note: this type is marked as 'beforefieldinit'.
			static BaseVisuals()
			{
				Il2CppClassPointerStore<FilledPackagingVisuals.BaseVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "BaseVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackagingVisuals.BaseVisuals>.NativeClassPtr);
				FilledPackagingVisuals.BaseVisuals.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.BaseVisuals>.NativeClassPtr, "Container");
				FilledPackagingVisuals.BaseVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals.BaseVisuals>.NativeClassPtr, 100678532);
			}

			// Token: 0x0600D389 RID: 54153 RVA: 0x0032899C File Offset: 0x00326B9C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BaseVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackagingVisuals.BaseVisuals>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.BaseVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D38A RID: 54154 RVA: 0x00066FA4 File Offset: 0x000651A4
			public BaseVisuals(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700419A RID: 16794
			// (get) Token: 0x0600D38B RID: 54155 RVA: 0x003289D8 File Offset: 0x00326BD8
			// (set) Token: 0x0600D38C RID: 54156 RVA: 0x00066FAD File Offset: 0x000651AD
			public unsafe Transform Container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.BaseVisuals.NativeFieldInfoPtr_Container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.BaseVisuals.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E80 RID: 36480
			private static readonly IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x04008E81 RID: 36481
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AAE RID: 2734
		[Serializable]
		public class WeedVisuals : FilledPackagingVisuals.BaseVisuals
		{
			// Token: 0x0600D38D RID: 54157 RVA: 0x00328A08 File Offset: 0x00326C08
			// Note: this type is marked as 'beforefieldinit'.
			static WeedVisuals()
			{
				Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "WeedVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr);
				FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_MainMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr, "MainMeshes");
				FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_SecondaryMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr, "SecondaryMeshes");
				FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_LeafMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr, "LeafMeshes");
				FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_StemMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr, "StemMeshes");
				FilledPackagingVisuals.WeedVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr, 100678533);
			}

			// Token: 0x0600D38E RID: 54158 RVA: 0x00328A98 File Offset: 0x00326C98
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WeedVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.WeedVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D38F RID: 54159 RVA: 0x00066FCC File Offset: 0x000651CC
			public WeedVisuals(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700419B RID: 16795
			// (get) Token: 0x0600D390 RID: 54160 RVA: 0x00328AD4 File Offset: 0x00326CD4
			// (set) Token: 0x0600D391 RID: 54161 RVA: 0x00066FD5 File Offset: 0x000651D5
			public unsafe Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair> MainMeshes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_MainMeshes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_MainMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700419C RID: 16796
			// (get) Token: 0x0600D392 RID: 54162 RVA: 0x00328B04 File Offset: 0x00326D04
			// (set) Token: 0x0600D393 RID: 54163 RVA: 0x00066FF4 File Offset: 0x000651F4
			public unsafe Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair> SecondaryMeshes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_SecondaryMeshes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_SecondaryMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700419D RID: 16797
			// (get) Token: 0x0600D394 RID: 54164 RVA: 0x00328B34 File Offset: 0x00326D34
			// (set) Token: 0x0600D395 RID: 54165 RVA: 0x00067013 File Offset: 0x00065213
			public unsafe Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair> LeafMeshes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_LeafMeshes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_LeafMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700419E RID: 16798
			// (get) Token: 0x0600D396 RID: 54166 RVA: 0x00328B64 File Offset: 0x00326D64
			// (set) Token: 0x0600D397 RID: 54167 RVA: 0x00067032 File Offset: 0x00065232
			public unsafe Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair> StemMeshes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_StemMeshes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_StemMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E82 RID: 36482
			private static readonly IntPtr NativeFieldInfoPtr_MainMeshes;

			// Token: 0x04008E83 RID: 36483
			private static readonly IntPtr NativeFieldInfoPtr_SecondaryMeshes;

			// Token: 0x04008E84 RID: 36484
			private static readonly IntPtr NativeFieldInfoPtr_LeafMeshes;

			// Token: 0x04008E85 RID: 36485
			private static readonly IntPtr NativeFieldInfoPtr_StemMeshes;

			// Token: 0x04008E86 RID: 36486
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AAF RID: 2735
		[Serializable]
		public class MethVisuals : FilledPackagingVisuals.BaseVisuals
		{
			// Token: 0x0600D398 RID: 54168 RVA: 0x00328B94 File Offset: 0x00326D94
			// Note: this type is marked as 'beforefieldinit'.
			static MethVisuals()
			{
				Il2CppClassPointerStore<FilledPackagingVisuals.MethVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "MethVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackagingVisuals.MethVisuals>.NativeClassPtr);
				FilledPackagingVisuals.MethVisuals.NativeFieldInfoPtr_CrystalMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.MethVisuals>.NativeClassPtr, "CrystalMeshes");
				FilledPackagingVisuals.MethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals.MethVisuals>.NativeClassPtr, 100678534);
			}

			// Token: 0x0600D399 RID: 54169 RVA: 0x00328BE8 File Offset: 0x00326DE8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MethVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackagingVisuals.MethVisuals>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.MethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D39A RID: 54170 RVA: 0x00067051 File Offset: 0x00065251
			public MethVisuals(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700419F RID: 16799
			// (get) Token: 0x0600D39B RID: 54171 RVA: 0x00328C24 File Offset: 0x00326E24
			// (set) Token: 0x0600D39C RID: 54172 RVA: 0x0006705A File Offset: 0x0006525A
			public unsafe Il2CppReferenceArray<MeshRenderer> CrystalMeshes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.MethVisuals.NativeFieldInfoPtr_CrystalMeshes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.MethVisuals.NativeFieldInfoPtr_CrystalMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E87 RID: 36487
			private static readonly IntPtr NativeFieldInfoPtr_CrystalMeshes;

			// Token: 0x04008E88 RID: 36488
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AB0 RID: 2736
		[Serializable]
		public class CocaineVisuals : FilledPackagingVisuals.BaseVisuals
		{
			// Token: 0x0600D39D RID: 54173 RVA: 0x00328C54 File Offset: 0x00326E54
			// Note: this type is marked as 'beforefieldinit'.
			static CocaineVisuals()
			{
				Il2CppClassPointerStore<FilledPackagingVisuals.CocaineVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "CocaineVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackagingVisuals.CocaineVisuals>.NativeClassPtr);
				FilledPackagingVisuals.CocaineVisuals.NativeFieldInfoPtr_RockMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.CocaineVisuals>.NativeClassPtr, "RockMeshes");
				FilledPackagingVisuals.CocaineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals.CocaineVisuals>.NativeClassPtr, 100678535);
			}

			// Token: 0x0600D39E RID: 54174 RVA: 0x00328CA8 File Offset: 0x00326EA8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CocaineVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackagingVisuals.CocaineVisuals>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.CocaineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D39F RID: 54175 RVA: 0x00067079 File Offset: 0x00065279
			public CocaineVisuals(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041A0 RID: 16800
			// (get) Token: 0x0600D3A0 RID: 54176 RVA: 0x00328CE4 File Offset: 0x00326EE4
			// (set) Token: 0x0600D3A1 RID: 54177 RVA: 0x00067082 File Offset: 0x00065282
			public unsafe Il2CppReferenceArray<MeshRenderer> RockMeshes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.CocaineVisuals.NativeFieldInfoPtr_RockMeshes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.CocaineVisuals.NativeFieldInfoPtr_RockMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E89 RID: 36489
			private static readonly IntPtr NativeFieldInfoPtr_RockMeshes;

			// Token: 0x04008E8A RID: 36490
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
