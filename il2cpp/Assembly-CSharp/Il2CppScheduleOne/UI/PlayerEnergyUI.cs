using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200065C RID: 1628
	public class PlayerEnergyUI : Singleton<PlayerEnergyUI>
	{
		// Token: 0x06009149 RID: 37193 RVA: 0x00258CCC File Offset: 0x00256ECC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerEnergyUI()
		{
			Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PlayerEnergyUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr);
			PlayerEnergyUI.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "Slider");
			PlayerEnergyUI.NativeFieldInfoPtr_SliderRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "SliderRect");
			PlayerEnergyUI.NativeFieldInfoPtr_FillImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "FillImage");
			PlayerEnergyUI.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "Label");
			PlayerEnergyUI.NativeFieldInfoPtr_SliderColor_Green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "SliderColor_Green");
			PlayerEnergyUI.NativeFieldInfoPtr_SliderColor_Red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "SliderColor_Red");
			PlayerEnergyUI.NativeFieldInfoPtr_displayedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "displayedValue");
			PlayerEnergyUI.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, 100681296);
			PlayerEnergyUI.NativeMethodInfoPtr_UpdateDisplayedEnergy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, 100681297);
			PlayerEnergyUI.NativeMethodInfoPtr_SetDisplayedEnergy_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, 100681298);
			PlayerEnergyUI.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, 100681299);
			PlayerEnergyUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, 100681300);
			PlayerEnergyUI.NativeMethodInfoPtr__Awake_b__7_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, 100681301);
		}

		// Token: 0x0600914A RID: 37194 RVA: 0x00258E00 File Offset: 0x00257000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262942, XrefRangeEnd = 262965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEnergyUI.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600914B RID: 37195 RVA: 0x00258E3C File Offset: 0x0025703C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262965, XrefRangeEnd = 262970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDisplayedEnergy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergyUI.NativeMethodInfoPtr_UpdateDisplayedEnergy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600914C RID: 37196 RVA: 0x00258E70 File Offset: 0x00257070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262970, XrefRangeEnd = 262971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedEnergy(float energy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref energy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergyUI.NativeMethodInfoPtr_SetDisplayedEnergy_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600914D RID: 37197 RVA: 0x00258EB0 File Offset: 0x002570B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262971, XrefRangeEnd = 262974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEnergyUI.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600914E RID: 37198 RVA: 0x00258EEC File Offset: 0x002570EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262974, XrefRangeEnd = 262977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerEnergyUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergyUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600914F RID: 37199 RVA: 0x00258F28 File Offset: 0x00257128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262977, XrefRangeEnd = 262994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__7_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergyUI.NativeMethodInfoPtr__Awake_b__7_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009150 RID: 37200 RVA: 0x00046389 File Offset: 0x00044589
		public PlayerEnergyUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C84 RID: 11396
		// (get) Token: 0x06009151 RID: 37201 RVA: 0x00258F5C File Offset: 0x0025715C
		// (set) Token: 0x06009152 RID: 37202 RVA: 0x00046392 File Offset: 0x00044592
		public unsafe Slider Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C85 RID: 11397
		// (get) Token: 0x06009153 RID: 37203 RVA: 0x00258F8C File Offset: 0x0025718C
		// (set) Token: 0x06009154 RID: 37204 RVA: 0x000463B1 File Offset: 0x000445B1
		public unsafe RectTransform SliderRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_SliderRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_SliderRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C86 RID: 11398
		// (get) Token: 0x06009155 RID: 37205 RVA: 0x00258FBC File Offset: 0x002571BC
		// (set) Token: 0x06009156 RID: 37206 RVA: 0x000463D0 File Offset: 0x000445D0
		public unsafe Image FillImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_FillImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_FillImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C87 RID: 11399
		// (get) Token: 0x06009157 RID: 37207 RVA: 0x00258FEC File Offset: 0x002571EC
		// (set) Token: 0x06009158 RID: 37208 RVA: 0x000463EF File Offset: 0x000445EF
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C88 RID: 11400
		// (get) Token: 0x06009159 RID: 37209 RVA: 0x0025901C File Offset: 0x0025721C
		// (set) Token: 0x0600915A RID: 37210 RVA: 0x0004640E File Offset: 0x0004460E
		public unsafe Color SliderColor_Green
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_SliderColor_Green);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_SliderColor_Green)) = value;
			}
		}

		// Token: 0x17002C89 RID: 11401
		// (get) Token: 0x0600915B RID: 37211 RVA: 0x00259044 File Offset: 0x00257244
		// (set) Token: 0x0600915C RID: 37212 RVA: 0x00046429 File Offset: 0x00044629
		public unsafe Color SliderColor_Red
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_SliderColor_Red);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_SliderColor_Red)) = value;
			}
		}

		// Token: 0x17002C8A RID: 11402
		// (get) Token: 0x0600915D RID: 37213 RVA: 0x0025906C File Offset: 0x0025726C
		// (set) Token: 0x0600915E RID: 37214 RVA: 0x00046444 File Offset: 0x00044644
		public unsafe float displayedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_displayedValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_displayedValue)) = value;
			}
		}

		// Token: 0x04006232 RID: 25138
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x04006233 RID: 25139
		private static readonly IntPtr NativeFieldInfoPtr_SliderRect;

		// Token: 0x04006234 RID: 25140
		private static readonly IntPtr NativeFieldInfoPtr_FillImage;

		// Token: 0x04006235 RID: 25141
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006236 RID: 25142
		private static readonly IntPtr NativeFieldInfoPtr_SliderColor_Green;

		// Token: 0x04006237 RID: 25143
		private static readonly IntPtr NativeFieldInfoPtr_SliderColor_Red;

		// Token: 0x04006238 RID: 25144
		private static readonly IntPtr NativeFieldInfoPtr_displayedValue;

		// Token: 0x04006239 RID: 25145
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400623A RID: 25146
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplayedEnergy_Private_Void_0;

		// Token: 0x0400623B RID: 25147
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedEnergy_Public_Void_Single_0;

		// Token: 0x0400623C RID: 25148
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400623D RID: 25149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400623E RID: 25150
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__7_0_Private_Void_0;
	}
}
