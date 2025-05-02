using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000E3 RID: 227
	public class SpriteArtItem : ScriptableObject
	{
		// Token: 0x06001217 RID: 4631 RVA: 0x000A93A8 File Offset: 0x000A75A8
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteArtItem()
		{
			Il2CppClassPointerStore<SpriteArtItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SpriteArtItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteArtItem>.NativeClassPtr);
			SpriteArtItem.NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteArtItem>.NativeClassPtr, "mesh");
			SpriteArtItem.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteArtItem>.NativeClassPtr, "material");
			SpriteArtItem.NativeFieldInfoPtr_rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteArtItem>.NativeClassPtr, "rows");
			SpriteArtItem.NativeFieldInfoPtr_columns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteArtItem>.NativeClassPtr, "columns");
			SpriteArtItem.NativeFieldInfoPtr_totalFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteArtItem>.NativeClassPtr, "totalFrames");
			SpriteArtItem.NativeFieldInfoPtr_animateSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteArtItem>.NativeClassPtr, "animateSpeed");
			SpriteArtItem.NativeFieldInfoPtr_tintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteArtItem>.NativeClassPtr, "tintColor");
			SpriteArtItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteArtItem>.NativeClassPtr, 100665367);
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x000A9478 File Offset: 0x000A7678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88933, XrefRangeEnd = 88934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteArtItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteArtItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteArtItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0000B001 File Offset: 0x00009201
		public SpriteArtItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x000A94B4 File Offset: 0x000A76B4
		// (set) Token: 0x0600121B RID: 4635 RVA: 0x0000B00A File Offset: 0x0000920A
		public unsafe Mesh mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteArtItem.NativeFieldInfoPtr_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteArtItem.NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x000A94E4 File Offset: 0x000A76E4
		// (set) Token: 0x0600121D RID: 4637 RVA: 0x0000B029 File Offset: 0x00009229
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteArtItem.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteArtItem.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x000A9514 File Offset: 0x000A7714
		// (set) Token: 0x0600121F RID: 4639 RVA: 0x0000B048 File Offset: 0x00009248
		public unsafe int rows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteArtItem.NativeFieldInfoPtr_rows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteArtItem.NativeFieldInfoPtr_rows)) = value;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x000A953C File Offset: 0x000A773C
		// (set) Token: 0x06001221 RID: 4641 RVA: 0x0000B063 File Offset: 0x00009263
		public unsafe int columns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteArtItem.NativeFieldInfoPtr_columns);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteArtItem.NativeFieldInfoPtr_columns)) = value;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x000A9564 File Offset: 0x000A7764
		// (set) Token: 0x06001223 RID: 4643 RVA: 0x0000B07E File Offset: 0x0000927E
		public unsafe int totalFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteArtItem.NativeFieldInfoPtr_totalFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteArtItem.NativeFieldInfoPtr_totalFrames)) = value;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x000A958C File Offset: 0x000A778C
		// (set) Token: 0x06001225 RID: 4645 RVA: 0x0000B099 File Offset: 0x00009299
		public unsafe int animateSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteArtItem.NativeFieldInfoPtr_animateSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteArtItem.NativeFieldInfoPtr_animateSpeed)) = value;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x000A95B4 File Offset: 0x000A77B4
		// (set) Token: 0x06001227 RID: 4647 RVA: 0x0000B0B4 File Offset: 0x000092B4
		public unsafe Color tintColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteArtItem.NativeFieldInfoPtr_tintColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteArtItem.NativeFieldInfoPtr_tintColor)) = value;
			}
		}

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeFieldInfoPtr_mesh;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeFieldInfoPtr_rows;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeFieldInfoPtr_columns;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeFieldInfoPtr_totalFrames;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeFieldInfoPtr_animateSpeed;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeFieldInfoPtr_tintColor;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
