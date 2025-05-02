using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F0 RID: 1520
	public class Accessory : MonoBehaviour
	{
		// Token: 0x060084B4 RID: 33972 RVA: 0x00233A04 File Offset: 0x00231C04
		// Note: this type is marked as 'beforefieldinit'.
		static Accessory()
		{
			Il2CppClassPointerStore<Accessory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Accessory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Accessory>.NativeClassPtr);
			Accessory.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "Name");
			Accessory.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "AssetPath");
			Accessory.NativeFieldInfoPtr_ReduceFootSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "ReduceFootSize");
			Accessory.NativeFieldInfoPtr_FootSizeReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "FootSizeReduction");
			Accessory.NativeFieldInfoPtr_ShouldBlockHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "ShouldBlockHair");
			Accessory.NativeFieldInfoPtr_ColorAllMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "ColorAllMeshes");
			Accessory.NativeFieldInfoPtr_meshesToColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "meshesToColor");
			Accessory.NativeFieldInfoPtr_skinnedMeshesToColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "skinnedMeshesToColor");
			Accessory.NativeFieldInfoPtr_skinnedMeshesToBind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "skinnedMeshesToBind");
			Accessory.NativeFieldInfoPtr_shapeKeyMeshRends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "shapeKeyMeshRends");
			Accessory.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100679903);
			Accessory.NativeMethodInfoPtr_ApplyColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100679904);
			Accessory.NativeMethodInfoPtr_ApplyShapeKeys_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100679905);
			Accessory.NativeMethodInfoPtr_BindBones_Public_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100679906);
			Accessory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100679907);
		}

		// Token: 0x060084B5 RID: 33973 RVA: 0x00233B60 File Offset: 0x00231D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249284, XrefRangeEnd = 249286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084B6 RID: 33974 RVA: 0x00233B94 File Offset: 0x00231D94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 249296, RefRangeEnd = 249301, XrefRangeStart = 249286, XrefRangeEnd = 249296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyColor(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr_ApplyColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084B7 RID: 33975 RVA: 0x00233BD4 File Offset: 0x00231DD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 249306, RefRangeEnd = 249308, XrefRangeStart = 249301, XrefRangeEnd = 249306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyShapeKeys(float gender, float weight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gender;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr_ApplyShapeKeys_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084B8 RID: 33976 RVA: 0x00233C20 File Offset: 0x00231E20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249310, RefRangeEnd = 249311, XrefRangeStart = 249308, XrefRangeEnd = 249310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindBones(Il2CppReferenceArray<Transform> bones)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bones);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr_BindBones_Public_Void_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084B9 RID: 33977 RVA: 0x00233C64 File Offset: 0x00231E64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249312, RefRangeEnd = 249313, XrefRangeStart = 249311, XrefRangeEnd = 249312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Accessory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Accessory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084BA RID: 33978 RVA: 0x0003EE99 File Offset: 0x0003D099
		public Accessory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700281B RID: 10267
		// (get) Token: 0x060084BB RID: 33979 RVA: 0x00233CA0 File Offset: 0x00231EA0
		// (set) Token: 0x060084BC RID: 33980 RVA: 0x0003EEA2 File Offset: 0x0003D0A2
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700281C RID: 10268
		// (get) Token: 0x060084BD RID: 33981 RVA: 0x00233CC8 File Offset: 0x00231EC8
		// (set) Token: 0x060084BE RID: 33982 RVA: 0x0003EEC1 File Offset: 0x0003D0C1
		public unsafe string AssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_AssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700281D RID: 10269
		// (get) Token: 0x060084BF RID: 33983 RVA: 0x00233CF0 File Offset: 0x00231EF0
		// (set) Token: 0x060084C0 RID: 33984 RVA: 0x0003EEE0 File Offset: 0x0003D0E0
		public unsafe bool ReduceFootSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ReduceFootSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ReduceFootSize)) = value;
			}
		}

		// Token: 0x1700281E RID: 10270
		// (get) Token: 0x060084C1 RID: 33985 RVA: 0x00233D18 File Offset: 0x00231F18
		// (set) Token: 0x060084C2 RID: 33986 RVA: 0x0003EEFB File Offset: 0x0003D0FB
		public unsafe float FootSizeReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_FootSizeReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_FootSizeReduction)) = value;
			}
		}

		// Token: 0x1700281F RID: 10271
		// (get) Token: 0x060084C3 RID: 33987 RVA: 0x00233D40 File Offset: 0x00231F40
		// (set) Token: 0x060084C4 RID: 33988 RVA: 0x0003EF16 File Offset: 0x0003D116
		public unsafe bool ShouldBlockHair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ShouldBlockHair);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ShouldBlockHair)) = value;
			}
		}

		// Token: 0x17002820 RID: 10272
		// (get) Token: 0x060084C5 RID: 33989 RVA: 0x00233D68 File Offset: 0x00231F68
		// (set) Token: 0x060084C6 RID: 33990 RVA: 0x0003EF31 File Offset: 0x0003D131
		public unsafe bool ColorAllMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ColorAllMeshes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ColorAllMeshes)) = value;
			}
		}

		// Token: 0x17002821 RID: 10273
		// (get) Token: 0x060084C7 RID: 33991 RVA: 0x00233D90 File Offset: 0x00231F90
		// (set) Token: 0x060084C8 RID: 33992 RVA: 0x0003EF4C File Offset: 0x0003D14C
		public unsafe Il2CppReferenceArray<MeshRenderer> meshesToColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_meshesToColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_meshesToColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002822 RID: 10274
		// (get) Token: 0x060084C9 RID: 33993 RVA: 0x00233DC0 File Offset: 0x00231FC0
		// (set) Token: 0x060084CA RID: 33994 RVA: 0x0003EF6B File Offset: 0x0003D16B
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> skinnedMeshesToColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_skinnedMeshesToColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_skinnedMeshesToColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002823 RID: 10275
		// (get) Token: 0x060084CB RID: 33995 RVA: 0x00233DF0 File Offset: 0x00231FF0
		// (set) Token: 0x060084CC RID: 33996 RVA: 0x0003EF8A File Offset: 0x0003D18A
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> skinnedMeshesToBind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_skinnedMeshesToBind);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_skinnedMeshesToBind), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002824 RID: 10276
		// (get) Token: 0x060084CD RID: 33997 RVA: 0x00233E20 File Offset: 0x00232020
		// (set) Token: 0x060084CE RID: 33998 RVA: 0x0003EFA9 File Offset: 0x0003D1A9
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> shapeKeyMeshRends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_shapeKeyMeshRends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_shapeKeyMeshRends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005A5F RID: 23135
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04005A60 RID: 23136
		private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

		// Token: 0x04005A61 RID: 23137
		private static readonly IntPtr NativeFieldInfoPtr_ReduceFootSize;

		// Token: 0x04005A62 RID: 23138
		private static readonly IntPtr NativeFieldInfoPtr_FootSizeReduction;

		// Token: 0x04005A63 RID: 23139
		private static readonly IntPtr NativeFieldInfoPtr_ShouldBlockHair;

		// Token: 0x04005A64 RID: 23140
		private static readonly IntPtr NativeFieldInfoPtr_ColorAllMeshes;

		// Token: 0x04005A65 RID: 23141
		private static readonly IntPtr NativeFieldInfoPtr_meshesToColor;

		// Token: 0x04005A66 RID: 23142
		private static readonly IntPtr NativeFieldInfoPtr_skinnedMeshesToColor;

		// Token: 0x04005A67 RID: 23143
		private static readonly IntPtr NativeFieldInfoPtr_skinnedMeshesToBind;

		// Token: 0x04005A68 RID: 23144
		private static readonly IntPtr NativeFieldInfoPtr_shapeKeyMeshRends;

		// Token: 0x04005A69 RID: 23145
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005A6A RID: 23146
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColor_Public_Void_Color_0;

		// Token: 0x04005A6B RID: 23147
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShapeKeys_Public_Void_Single_Single_0;

		// Token: 0x04005A6C RID: 23148
		private static readonly IntPtr NativeMethodInfoPtr_BindBones_Public_Void_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04005A6D RID: 23149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
