using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x0200070E RID: 1806
	public class ShopColorPicker : MonoBehaviour
	{
		// Token: 0x0600A23B RID: 41531 RVA: 0x0028C5CC File Offset: 0x0028A7CC
		// Note: this type is marked as 'beforefieldinit'.
		static ShopColorPicker()
		{
			Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopColorPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr);
			ShopColorPicker.NativeFieldInfoPtr_AssetIconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "AssetIconImage");
			ShopColorPicker.NativeFieldInfoPtr_ColorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "ColorLabel");
			ShopColorPicker.NativeFieldInfoPtr_ColorButtonParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "ColorButtonParent");
			ShopColorPicker.NativeFieldInfoPtr_ColorButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "ColorButtonPrefab");
			ShopColorPicker.NativeFieldInfoPtr_onColorPicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "onColorPicked");
			ShopColorPicker.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683135);
			ShopColorPicker.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683136);
			ShopColorPicker.NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683137);
			ShopColorPicker.NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683138);
			ShopColorPicker.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683139);
			ShopColorPicker.NativeMethodInfoPtr_ColorHovered_Private_Void_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683140);
			ShopColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683141);
		}

		// Token: 0x17003204 RID: 12804
		// (get) Token: 0x0600A23C RID: 41532 RVA: 0x0028C6EC File Offset: 0x0028A8EC
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284677, XrefRangeEnd = 284680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600A23D RID: 41533 RVA: 0x0028C728 File Offset: 0x0028A928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284680, XrefRangeEnd = 284759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A23E RID: 41534 RVA: 0x0028C75C File Offset: 0x0028A95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284759, XrefRangeEnd = 284765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColorPicked(EClothingColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A23F RID: 41535 RVA: 0x0028C79C File Offset: 0x0028A99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284765, XrefRangeEnd = 284770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A240 RID: 41536 RVA: 0x0028C7E0 File Offset: 0x0028A9E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194914, RefRangeEnd = 194915, XrefRangeStart = 194914, XrefRangeEnd = 194915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A241 RID: 41537 RVA: 0x0028C814 File Offset: 0x0028AA14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284773, RefRangeEnd = 284775, XrefRangeStart = 284770, XrefRangeEnd = 284773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColorHovered(EClothingColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_ColorHovered_Private_Void_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A242 RID: 41538 RVA: 0x0028C854 File Offset: 0x0028AA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284775, XrefRangeEnd = 284783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopColorPicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A243 RID: 41539 RVA: 0x0004FD3F File Offset: 0x0004DF3F
		public ShopColorPicker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031FF RID: 12799
		// (get) Token: 0x0600A244 RID: 41540 RVA: 0x0028C890 File Offset: 0x0028AA90
		// (set) Token: 0x0600A245 RID: 41541 RVA: 0x0004FD48 File Offset: 0x0004DF48
		public unsafe Image AssetIconImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_AssetIconImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_AssetIconImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003200 RID: 12800
		// (get) Token: 0x0600A246 RID: 41542 RVA: 0x0028C8C0 File Offset: 0x0028AAC0
		// (set) Token: 0x0600A247 RID: 41543 RVA: 0x0004FD67 File Offset: 0x0004DF67
		public unsafe TextMeshProUGUI ColorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003201 RID: 12801
		// (get) Token: 0x0600A248 RID: 41544 RVA: 0x0028C8F0 File Offset: 0x0028AAF0
		// (set) Token: 0x0600A249 RID: 41545 RVA: 0x0004FD86 File Offset: 0x0004DF86
		public unsafe RectTransform ColorButtonParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorButtonParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorButtonParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003202 RID: 12802
		// (get) Token: 0x0600A24A RID: 41546 RVA: 0x0028C920 File Offset: 0x0028AB20
		// (set) Token: 0x0600A24B RID: 41547 RVA: 0x0004FDA5 File Offset: 0x0004DFA5
		public unsafe GameObject ColorButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003203 RID: 12803
		// (get) Token: 0x0600A24C RID: 41548 RVA: 0x0028C950 File Offset: 0x0028AB50
		// (set) Token: 0x0600A24D RID: 41549 RVA: 0x0004FDC4 File Offset: 0x0004DFC4
		public unsafe UnityEvent<EClothingColor> onColorPicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_onColorPicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EClothingColor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_onColorPicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006CD3 RID: 27859
		private static readonly IntPtr NativeFieldInfoPtr_AssetIconImage;

		// Token: 0x04006CD4 RID: 27860
		private static readonly IntPtr NativeFieldInfoPtr_ColorLabel;

		// Token: 0x04006CD5 RID: 27861
		private static readonly IntPtr NativeFieldInfoPtr_ColorButtonParent;

		// Token: 0x04006CD6 RID: 27862
		private static readonly IntPtr NativeFieldInfoPtr_ColorButtonPrefab;

		// Token: 0x04006CD7 RID: 27863
		private static readonly IntPtr NativeFieldInfoPtr_onColorPicked;

		// Token: 0x04006CD8 RID: 27864
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006CD9 RID: 27865
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04006CDA RID: 27866
		private static readonly IntPtr NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0;

		// Token: 0x04006CDB RID: 27867
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_0;

		// Token: 0x04006CDC RID: 27868
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006CDD RID: 27869
		private static readonly IntPtr NativeMethodInfoPtr_ColorHovered_Private_Void_EClothingColor_0;

		// Token: 0x04006CDE RID: 27870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BB5 RID: 2997
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopColorPicker+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD50 RID: 56656 RVA: 0x003446F8 File Offset: 0x003428F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr);
				ShopColorPicker.__c__DisplayClass7_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr, "color");
				ShopColorPicker.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				ShopColorPicker.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr, 100683142);
				ShopColorPicker.__c__DisplayClass7_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr, 100683143);
				ShopColorPicker.__c__DisplayClass7_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr, 100683144);
			}

			// Token: 0x0600DD51 RID: 56657 RVA: 0x00344788 File Offset: 0x00342988
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD52 RID: 56658 RVA: 0x003447C4 File Offset: 0x003429C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284669, XrefRangeEnd = 284675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.__c__DisplayClass7_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD53 RID: 56659 RVA: 0x003447F8 File Offset: 0x003429F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284675, XrefRangeEnd = 284677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__1(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.__c__DisplayClass7_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD54 RID: 56660 RVA: 0x0006BDD9 File Offset: 0x00069FD9
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004498 RID: 17560
			// (get) Token: 0x0600DD55 RID: 56661 RVA: 0x0034483C File Offset: 0x00342A3C
			// (set) Token: 0x0600DD56 RID: 56662 RVA: 0x0006BDE2 File Offset: 0x00069FE2
			public unsafe EClothingColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.__c__DisplayClass7_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.__c__DisplayClass7_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x17004499 RID: 17561
			// (get) Token: 0x0600DD57 RID: 56663 RVA: 0x00344864 File Offset: 0x00342A64
			// (set) Token: 0x0600DD58 RID: 56664 RVA: 0x0006BDFD File Offset: 0x00069FFD
			public unsafe ShopColorPicker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopColorPicker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009442 RID: 37954
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04009443 RID: 37955
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009444 RID: 37956
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009445 RID: 37957
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;

			// Token: 0x04009446 RID: 37958
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_Internal_Void_BaseEventData_0;
		}
	}
}
