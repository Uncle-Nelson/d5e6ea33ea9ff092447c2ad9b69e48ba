using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x0200018B RID: 395
	public class SnakeTile : MonoBehaviour
	{
		// Token: 0x06002025 RID: 8229 RVA: 0x000D4854 File Offset: 0x000D2A54
		// Note: this type is marked as 'beforefieldinit'.
		static SnakeTile()
		{
			Il2CppClassPointerStore<SnakeTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "SnakeTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr);
			SnakeTile.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, "<Type>k__BackingField");
			SnakeTile.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, "Position");
			SnakeTile.NativeFieldInfoPtr_SnakeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, "SnakeColor");
			SnakeTile.NativeFieldInfoPtr_FoodColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, "FoodColor");
			SnakeTile.NativeFieldInfoPtr_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, "RectTransform");
			SnakeTile.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, "Image");
			SnakeTile.NativeMethodInfoPtr_get_Type_Public_get_TileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, 100666887);
			SnakeTile.NativeMethodInfoPtr_set_Type_Private_set_Void_TileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, 100666888);
			SnakeTile.NativeMethodInfoPtr_SetType_Public_Void_TileType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, 100666889);
			SnakeTile.NativeMethodInfoPtr_SetPosition_Public_Void_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, 100666890);
			SnakeTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, 100666891);
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x000D4960 File Offset: 0x000D2B60
		// (set) Token: 0x06002027 RID: 8231 RVA: 0x000D499C File Offset: 0x000D2B9C
		public unsafe SnakeTile.TileType Type
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20564, RefRangeEnd = 20565, XrefRangeStart = 20564, XrefRangeEnd = 20565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnakeTile.NativeMethodInfoPtr_get_Type_Public_get_TileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29976, RefRangeEnd = 29977, XrefRangeStart = 29976, XrefRangeEnd = 29977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnakeTile.NativeMethodInfoPtr_set_Type_Private_set_Void_TileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x000D49DC File Offset: 0x000D2BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108678, XrefRangeEnd = 108680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetType(SnakeTile.TileType type, int index = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnakeTile.NativeMethodInfoPtr_SetType_Public_Void_TileType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x000D4A28 File Offset: 0x000D2C28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108692, RefRangeEnd = 108693, XrefRangeStart = 108680, XrefRangeEnd = 108692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(Vector2 position, float tileSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnakeTile.NativeMethodInfoPtr_SetPosition_Public_Void_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x000D4A74 File Offset: 0x000D2C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108693, XrefRangeEnd = 108696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SnakeTile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnakeTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x000121F7 File Offset: 0x000103F7
		public SnakeTile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x0600202C RID: 8236 RVA: 0x000D4AB0 File Offset: 0x000D2CB0
		// (set) Token: 0x0600202D RID: 8237 RVA: 0x00012200 File Offset: 0x00010400
		public unsafe SnakeTile.TileType _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr__Type_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr__Type_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x000D4AD8 File Offset: 0x000D2CD8
		// (set) Token: 0x0600202F RID: 8239 RVA: 0x0001221B File Offset: 0x0001041B
		public unsafe Vector2 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x000D4B00 File Offset: 0x000D2D00
		// (set) Token: 0x06002031 RID: 8241 RVA: 0x00012236 File Offset: 0x00010436
		public unsafe Color SnakeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_SnakeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_SnakeColor)) = value;
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06002032 RID: 8242 RVA: 0x000D4B28 File Offset: 0x000D2D28
		// (set) Token: 0x06002033 RID: 8243 RVA: 0x00012251 File Offset: 0x00010451
		public unsafe Color FoodColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_FoodColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_FoodColor)) = value;
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06002034 RID: 8244 RVA: 0x000D4B50 File Offset: 0x000D2D50
		// (set) Token: 0x06002035 RID: 8245 RVA: 0x0001226C File Offset: 0x0001046C
		public unsafe RectTransform RectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_RectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x000D4B80 File Offset: 0x000D2D80
		// (set) Token: 0x06002037 RID: 8247 RVA: 0x0001228B File Offset: 0x0001048B
		public unsafe Image Image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_Image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001550 RID: 5456
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x04001551 RID: 5457
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04001552 RID: 5458
		private static readonly IntPtr NativeFieldInfoPtr_SnakeColor;

		// Token: 0x04001553 RID: 5459
		private static readonly IntPtr NativeFieldInfoPtr_FoodColor;

		// Token: 0x04001554 RID: 5460
		private static readonly IntPtr NativeFieldInfoPtr_RectTransform;

		// Token: 0x04001555 RID: 5461
		private static readonly IntPtr NativeFieldInfoPtr_Image;

		// Token: 0x04001556 RID: 5462
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_TileType_0;

		// Token: 0x04001557 RID: 5463
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Private_set_Void_TileType_0;

		// Token: 0x04001558 RID: 5464
		private static readonly IntPtr NativeMethodInfoPtr_SetType_Public_Void_TileType_Int32_0;

		// Token: 0x04001559 RID: 5465
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Vector2_Single_0;

		// Token: 0x0400155A RID: 5466
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008B7 RID: 2231
		[OriginalName("Assembly-CSharp.dll", "", "TileType")]
		public enum TileType
		{
			// Token: 0x04008459 RID: 33881
			Empty,
			// Token: 0x0400845A RID: 33882
			Snake,
			// Token: 0x0400845B RID: 33883
			Food
		}
	}
}
