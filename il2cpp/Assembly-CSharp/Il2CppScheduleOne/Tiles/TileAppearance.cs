using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x020001A0 RID: 416
	public class TileAppearance : MonoBehaviour
	{
		// Token: 0x0600222D RID: 8749 RVA: 0x000DB648 File Offset: 0x000D9848
		// Note: this type is marked as 'beforefieldinit'.
		static TileAppearance()
		{
			Il2CppClassPointerStore<TileAppearance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "TileAppearance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr);
			TileAppearance.NativeFieldInfoPtr_tileMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, "tileMesh");
			TileAppearance.NativeFieldInfoPtr_mat_White = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, "mat_White");
			TileAppearance.NativeFieldInfoPtr_mat_Blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, "mat_Blue");
			TileAppearance.NativeFieldInfoPtr_mat_Red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, "mat_Red");
			TileAppearance.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, 100667155);
			TileAppearance.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, 100667156);
			TileAppearance.NativeMethodInfoPtr_SetColor_Public_Void_ETileColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, 100667157);
			TileAppearance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, 100667158);
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x000DB718 File Offset: 0x000D9918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111297, XrefRangeEnd = 111299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileAppearance.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x000DB74C File Offset: 0x000D994C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 82793, RefRangeEnd = 82802, XrefRangeStart = 82793, XrefRangeEnd = 82802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileAppearance.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x000DB78C File Offset: 0x000D998C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 111309, RefRangeEnd = 111316, XrefRangeStart = 111299, XrefRangeEnd = 111309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(ETileColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileAppearance.NativeMethodInfoPtr_SetColor_Public_Void_ETileColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x000DB7CC File Offset: 0x000D99CC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TileAppearance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileAppearance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x0001312B File Offset: 0x0001132B
		public TileAppearance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06002233 RID: 8755 RVA: 0x000DB808 File Offset: 0x000D9A08
		// (set) Token: 0x06002234 RID: 8756 RVA: 0x00013134 File Offset: 0x00011334
		public unsafe MeshRenderer tileMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_tileMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_tileMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x000DB838 File Offset: 0x000D9A38
		// (set) Token: 0x06002236 RID: 8758 RVA: 0x00013153 File Offset: 0x00011353
		public unsafe Material mat_White
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_mat_White);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_mat_White), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06002237 RID: 8759 RVA: 0x000DB868 File Offset: 0x000D9A68
		// (set) Token: 0x06002238 RID: 8760 RVA: 0x00013172 File Offset: 0x00011372
		public unsafe Material mat_Blue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_mat_Blue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_mat_Blue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x000DB898 File Offset: 0x000D9A98
		// (set) Token: 0x0600223A RID: 8762 RVA: 0x00013191 File Offset: 0x00011391
		public unsafe Material mat_Red
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_mat_Red);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_mat_Red), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016BE RID: 5822
		private static readonly IntPtr NativeFieldInfoPtr_tileMesh;

		// Token: 0x040016BF RID: 5823
		private static readonly IntPtr NativeFieldInfoPtr_mat_White;

		// Token: 0x040016C0 RID: 5824
		private static readonly IntPtr NativeFieldInfoPtr_mat_Blue;

		// Token: 0x040016C1 RID: 5825
		private static readonly IntPtr NativeFieldInfoPtr_mat_Red;

		// Token: 0x040016C2 RID: 5826
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040016C3 RID: 5827
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_ETileColor_0;

		// Token: 0x040016C5 RID: 5829
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
