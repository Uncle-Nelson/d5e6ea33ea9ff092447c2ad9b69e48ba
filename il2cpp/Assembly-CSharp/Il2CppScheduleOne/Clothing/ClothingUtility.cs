using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Clothing
{
	// Token: 0x0200049B RID: 1179
	public class ClothingUtility : Singleton<ClothingUtility>
	{
		// Token: 0x06006651 RID: 26193 RVA: 0x001CC8E4 File Offset: 0x001CAAE4
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingUtility()
		{
			Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Clothing", "ClothingUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr);
			ClothingUtility.NativeFieldInfoPtr_ColorDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "ColorDataList");
			ClothingUtility.NativeFieldInfoPtr_ClothingSlotDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "ClothingSlotDataList");
			ClothingUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100676226);
			ClothingUtility.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100676227);
			ClothingUtility.NativeMethodInfoPtr_GetColorData_Public_ColorData_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100676228);
			ClothingUtility.NativeMethodInfoPtr_GetSlotData_Public_ClothingSlotData_EClothingSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100676229);
			ClothingUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100676230);
		}

		// Token: 0x06006652 RID: 26194 RVA: 0x001CC9A0 File Offset: 0x001CABA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206946, XrefRangeEnd = 207001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006653 RID: 26195 RVA: 0x001CC9DC File Offset: 0x001CABDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207001, XrefRangeEnd = 207098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006654 RID: 26196 RVA: 0x001CCA10 File Offset: 0x001CAC10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207112, RefRangeEnd = 207115, XrefRangeStart = 207098, XrefRangeEnd = 207112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingUtility.ColorData GetColorData(EClothingColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.NativeMethodInfoPtr_GetColorData_Public_ColorData_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClothingUtility.ColorData>(intPtr3) : null;
		}

		// Token: 0x06006655 RID: 26197 RVA: 0x001CCA5C File Offset: 0x001CAC5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207129, RefRangeEnd = 207131, XrefRangeStart = 207115, XrefRangeEnd = 207129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingUtility.ClothingSlotData GetSlotData(EClothingSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.NativeMethodInfoPtr_GetSlotData_Public_ClothingSlotData_EClothingSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClothingUtility.ClothingSlotData>(intPtr3) : null;
		}

		// Token: 0x06006656 RID: 26198 RVA: 0x001CCAA8 File Offset: 0x001CACA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207131, XrefRangeEnd = 207148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006657 RID: 26199 RVA: 0x00030671 File Offset: 0x0002E871
		public ClothingUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x06006658 RID: 26200 RVA: 0x001CCAE4 File Offset: 0x001CACE4
		// (set) Token: 0x06006659 RID: 26201 RVA: 0x0003067A File Offset: 0x0002E87A
		public unsafe List<ClothingUtility.ColorData> ColorDataList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.NativeFieldInfoPtr_ColorDataList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClothingUtility.ColorData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.NativeFieldInfoPtr_ColorDataList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x0600665A RID: 26202 RVA: 0x001CCB14 File Offset: 0x001CAD14
		// (set) Token: 0x0600665B RID: 26203 RVA: 0x00030699 File Offset: 0x0002E899
		public unsafe List<ClothingUtility.ClothingSlotData> ClothingSlotDataList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.NativeFieldInfoPtr_ClothingSlotDataList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClothingUtility.ClothingSlotData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.NativeFieldInfoPtr_ClothingSlotDataList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040045D2 RID: 17874
		private static readonly IntPtr NativeFieldInfoPtr_ColorDataList;

		// Token: 0x040045D3 RID: 17875
		private static readonly IntPtr NativeFieldInfoPtr_ClothingSlotDataList;

		// Token: 0x040045D4 RID: 17876
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040045D5 RID: 17877
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040045D6 RID: 17878
		private static readonly IntPtr NativeMethodInfoPtr_GetColorData_Public_ColorData_EClothingColor_0;

		// Token: 0x040045D7 RID: 17879
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotData_Public_ClothingSlotData_EClothingSlot_0;

		// Token: 0x040045D8 RID: 17880
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A32 RID: 2610
		[Serializable]
		public class ColorData : Il2CppSystem.Object
		{
			// Token: 0x0600CF96 RID: 53142 RVA: 0x0031DB70 File Offset: 0x0031BD70
			// Note: this type is marked as 'beforefieldinit'.
			static ColorData()
			{
				Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "ColorData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr);
				ClothingUtility.ColorData.NativeFieldInfoPtr_ColorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr, "ColorType");
				ClothingUtility.ColorData.NativeFieldInfoPtr_ActualColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr, "ActualColor");
				ClothingUtility.ColorData.NativeFieldInfoPtr_LabelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr, "LabelColor");
				ClothingUtility.ColorData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr, 100676231);
			}

			// Token: 0x0600CF97 RID: 53143 RVA: 0x0031DBEC File Offset: 0x0031BDEC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColorData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.ColorData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF98 RID: 53144 RVA: 0x0006500A File Offset: 0x0006320A
			public ColorData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004083 RID: 16515
			// (get) Token: 0x0600CF99 RID: 53145 RVA: 0x0031DC28 File Offset: 0x0031BE28
			// (set) Token: 0x0600CF9A RID: 53146 RVA: 0x00065013 File Offset: 0x00063213
			public unsafe EClothingColor ColorType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_ColorType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_ColorType)) = value;
				}
			}

			// Token: 0x17004084 RID: 16516
			// (get) Token: 0x0600CF9B RID: 53147 RVA: 0x0031DC50 File Offset: 0x0031BE50
			// (set) Token: 0x0600CF9C RID: 53148 RVA: 0x0006502E File Offset: 0x0006322E
			public unsafe Color ActualColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_ActualColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_ActualColor)) = value;
				}
			}

			// Token: 0x17004085 RID: 16517
			// (get) Token: 0x0600CF9D RID: 53149 RVA: 0x0031DC78 File Offset: 0x0031BE78
			// (set) Token: 0x0600CF9E RID: 53150 RVA: 0x00065049 File Offset: 0x00063249
			public unsafe Color LabelColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_LabelColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_LabelColor)) = value;
				}
			}

			// Token: 0x04008C02 RID: 35842
			private static readonly IntPtr NativeFieldInfoPtr_ColorType;

			// Token: 0x04008C03 RID: 35843
			private static readonly IntPtr NativeFieldInfoPtr_ActualColor;

			// Token: 0x04008C04 RID: 35844
			private static readonly IntPtr NativeFieldInfoPtr_LabelColor;

			// Token: 0x04008C05 RID: 35845
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A33 RID: 2611
		[Serializable]
		public class ClothingSlotData : Il2CppSystem.Object
		{
			// Token: 0x0600CF9F RID: 53151 RVA: 0x0031DCA0 File Offset: 0x0031BEA0
			// Note: this type is marked as 'beforefieldinit'.
			static ClothingSlotData()
			{
				Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "ClothingSlotData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr);
				ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr, "Slot");
				ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr, "Name");
				ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr, "Icon");
				ClothingUtility.ClothingSlotData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr, 100676232);
			}

			// Token: 0x0600CFA0 RID: 53152 RVA: 0x0031DD1C File Offset: 0x0031BF1C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClothingSlotData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.ClothingSlotData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFA1 RID: 53153 RVA: 0x00065064 File Offset: 0x00063264
			public ClothingSlotData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004086 RID: 16518
			// (get) Token: 0x0600CFA2 RID: 53154 RVA: 0x0031DD58 File Offset: 0x0031BF58
			// (set) Token: 0x0600CFA3 RID: 53155 RVA: 0x0006506D File Offset: 0x0006326D
			public unsafe EClothingSlot Slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Slot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Slot)) = value;
				}
			}

			// Token: 0x17004087 RID: 16519
			// (get) Token: 0x0600CFA4 RID: 53156 RVA: 0x0031DD80 File Offset: 0x0031BF80
			// (set) Token: 0x0600CFA5 RID: 53157 RVA: 0x00065088 File Offset: 0x00063288
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004088 RID: 16520
			// (get) Token: 0x0600CFA6 RID: 53158 RVA: 0x0031DDA8 File Offset: 0x0031BFA8
			// (set) Token: 0x0600CFA7 RID: 53159 RVA: 0x000650A7 File Offset: 0x000632A7
			public unsafe Sprite Icon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Icon);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C06 RID: 35846
			private static readonly IntPtr NativeFieldInfoPtr_Slot;

			// Token: 0x04008C07 RID: 35847
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04008C08 RID: 35848
			private static readonly IntPtr NativeFieldInfoPtr_Icon;

			// Token: 0x04008C09 RID: 35849
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A34 RID: 2612
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFA8 RID: 53160 RVA: 0x0031DDD8 File Offset: 0x0031BFD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass4_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr, "color");
				ClothingUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr, 100676233);
				ClothingUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_ColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr, 100676234);
			}

			// Token: 0x0600CFA9 RID: 53161 RVA: 0x0031DE40 File Offset: 0x0031C040
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFAA RID: 53162 RVA: 0x0031DE7C File Offset: 0x0031C07C
			[CallerCount(0)]
			public unsafe bool _Awake_b__0(ClothingUtility.ColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_ColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFAB RID: 53163 RVA: 0x000650C6 File Offset: 0x000632C6
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004089 RID: 16521
			// (get) Token: 0x0600CFAC RID: 53164 RVA: 0x0031DECC File Offset: 0x0031C0CC
			// (set) Token: 0x0600CFAD RID: 53165 RVA: 0x000650CF File Offset: 0x000632CF
			public unsafe EClothingColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass4_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass4_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04008C0A RID: 35850
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008C0B RID: 35851
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C0C RID: 35852
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_ColorData_0;
		}

		// Token: 0x02000A35 RID: 2613
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFAE RID: 53166 RVA: 0x0031DEF4 File Offset: 0x0031C0F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr, "color");
				ClothingUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr, 100676235);
				ClothingUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__OnValidate_b__0_Internal_Boolean_ColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr, 100676236);
			}

			// Token: 0x0600CFAF RID: 53167 RVA: 0x0031DF5C File Offset: 0x0031C15C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFB0 RID: 53168 RVA: 0x0031DF98 File Offset: 0x0031C198
			[CallerCount(0)]
			public unsafe bool _OnValidate_b__0(ClothingUtility.ColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__OnValidate_b__0_Internal_Boolean_ColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFB1 RID: 53169 RVA: 0x000650EA File Offset: 0x000632EA
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700408A RID: 16522
			// (get) Token: 0x0600CFB2 RID: 53170 RVA: 0x0031DFE8 File Offset: 0x0031C1E8
			// (set) Token: 0x0600CFB3 RID: 53171 RVA: 0x000650F3 File Offset: 0x000632F3
			public unsafe EClothingColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04008C0D RID: 35853
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008C0E RID: 35854
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C0F RID: 35855
			private static readonly IntPtr NativeMethodInfoPtr__OnValidate_b__0_Internal_Boolean_ColorData_0;
		}

		// Token: 0x02000A36 RID: 2614
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass5_1")]
		public sealed class __c__DisplayClass5_1 : Il2CppSystem.Object
		{
			// Token: 0x0600CFB4 RID: 53172 RVA: 0x0031E010 File Offset: 0x0031C210
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_1()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass5_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass5_1.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr, "slot");
				ClothingUtility.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr, 100676237);
				ClothingUtility.__c__DisplayClass5_1.NativeMethodInfoPtr__OnValidate_b__1_Internal_Boolean_ClothingSlotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr, 100676238);
			}

			// Token: 0x0600CFB5 RID: 53173 RVA: 0x0031E078 File Offset: 0x0031C278
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFB6 RID: 53174 RVA: 0x0031E0B4 File Offset: 0x0031C2B4
			[CallerCount(0)]
			public unsafe bool _OnValidate_b__1(ClothingUtility.ClothingSlotData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass5_1.NativeMethodInfoPtr__OnValidate_b__1_Internal_Boolean_ClothingSlotData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFB7 RID: 53175 RVA: 0x0006510E File Offset: 0x0006330E
			public __c__DisplayClass5_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700408B RID: 16523
			// (get) Token: 0x0600CFB8 RID: 53176 RVA: 0x0031E104 File Offset: 0x0031C304
			// (set) Token: 0x0600CFB9 RID: 53177 RVA: 0x00065117 File Offset: 0x00063317
			public unsafe EClothingSlot slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass5_1.NativeFieldInfoPtr_slot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass5_1.NativeFieldInfoPtr_slot)) = value;
				}
			}

			// Token: 0x04008C10 RID: 35856
			private static readonly IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x04008C11 RID: 35857
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C12 RID: 35858
			private static readonly IntPtr NativeMethodInfoPtr__OnValidate_b__1_Internal_Boolean_ClothingSlotData_0;
		}

		// Token: 0x02000A37 RID: 2615
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFBA RID: 53178 RVA: 0x0031E12C File Offset: 0x0031C32C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass6_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr, "color");
				ClothingUtility.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr, 100676239);
				ClothingUtility.__c__DisplayClass6_0.NativeMethodInfoPtr__GetColorData_b__0_Internal_Boolean_ColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr, 100676240);
			}

			// Token: 0x0600CFBB RID: 53179 RVA: 0x0031E194 File Offset: 0x0031C394
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFBC RID: 53180 RVA: 0x0031E1D0 File Offset: 0x0031C3D0
			[CallerCount(0)]
			public unsafe bool _GetColorData_b__0(ClothingUtility.ColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass6_0.NativeMethodInfoPtr__GetColorData_b__0_Internal_Boolean_ColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFBD RID: 53181 RVA: 0x00065132 File Offset: 0x00063332
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700408C RID: 16524
			// (get) Token: 0x0600CFBE RID: 53182 RVA: 0x0031E220 File Offset: 0x0031C420
			// (set) Token: 0x0600CFBF RID: 53183 RVA: 0x0006513B File Offset: 0x0006333B
			public unsafe EClothingColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass6_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass6_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04008C13 RID: 35859
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008C14 RID: 35860
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C15 RID: 35861
			private static readonly IntPtr NativeMethodInfoPtr__GetColorData_b__0_Internal_Boolean_ColorData_0;
		}

		// Token: 0x02000A38 RID: 2616
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFC0 RID: 53184 RVA: 0x0031E248 File Offset: 0x0031C448
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass7_0.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr, "slot");
				ClothingUtility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr, 100676241);
				ClothingUtility.__c__DisplayClass7_0.NativeMethodInfoPtr__GetSlotData_b__0_Internal_Boolean_ClothingSlotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr, 100676242);
			}

			// Token: 0x0600CFC1 RID: 53185 RVA: 0x0031E2B0 File Offset: 0x0031C4B0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFC2 RID: 53186 RVA: 0x0031E2EC File Offset: 0x0031C4EC
			[CallerCount(0)]
			public unsafe bool _GetSlotData_b__0(ClothingUtility.ClothingSlotData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass7_0.NativeMethodInfoPtr__GetSlotData_b__0_Internal_Boolean_ClothingSlotData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFC3 RID: 53187 RVA: 0x00065156 File Offset: 0x00063356
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700408D RID: 16525
			// (get) Token: 0x0600CFC4 RID: 53188 RVA: 0x0031E33C File Offset: 0x0031C53C
			// (set) Token: 0x0600CFC5 RID: 53189 RVA: 0x0006515F File Offset: 0x0006335F
			public unsafe EClothingSlot slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass7_0.NativeFieldInfoPtr_slot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass7_0.NativeFieldInfoPtr_slot)) = value;
				}
			}

			// Token: 0x04008C16 RID: 35862
			private static readonly IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x04008C17 RID: 35863
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C18 RID: 35864
			private static readonly IntPtr NativeMethodInfoPtr__GetSlotData_b__0_Internal_Boolean_ClothingSlotData_0;
		}
	}
}
