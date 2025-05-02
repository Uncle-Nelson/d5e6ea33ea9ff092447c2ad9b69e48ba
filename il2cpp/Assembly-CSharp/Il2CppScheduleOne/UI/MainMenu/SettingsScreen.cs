using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Settings;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006EE RID: 1774
	public class SettingsScreen : MainMenuScreen
	{
		// Token: 0x06009EBD RID: 40637 RVA: 0x00281730 File Offset: 0x0027F930
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsScreen()
		{
			Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "SettingsScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr);
			SettingsScreen.NativeFieldInfoPtr_Categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "Categories");
			SettingsScreen.NativeFieldInfoPtr_ApplyDisplayButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "ApplyDisplayButton");
			SettingsScreen.NativeFieldInfoPtr_ConfirmDisplaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "ConfirmDisplaySettings");
			SettingsScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100682770);
			SettingsScreen.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100682771);
			SettingsScreen.NativeMethodInfoPtr_ShowCategory_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100682772);
			SettingsScreen.NativeMethodInfoPtr_DisplayChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100682773);
			SettingsScreen.NativeMethodInfoPtr_ApplyDisplaySettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100682774);
			SettingsScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100682775);
		}

		// Token: 0x06009EBE RID: 40638 RVA: 0x00281814 File Offset: 0x0027FA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280836, XrefRangeEnd = 280847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EBF RID: 40639 RVA: 0x00281850 File Offset: 0x0027FA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280847, XrefRangeEnd = 280863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EC0 RID: 40640 RVA: 0x00281884 File Offset: 0x0027FA84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280866, RefRangeEnd = 280867, XrefRangeStart = 280863, XrefRangeEnd = 280866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowCategory(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr_ShowCategory_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EC1 RID: 40641 RVA: 0x002818C4 File Offset: 0x0027FAC4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 280870, RefRangeEnd = 280877, XrefRangeStart = 280867, XrefRangeEnd = 280870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr_DisplayChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EC2 RID: 40642 RVA: 0x002818F8 File Offset: 0x0027FAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280877, XrefRangeEnd = 280891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDisplaySettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr_ApplyDisplaySettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EC3 RID: 40643 RVA: 0x0028192C File Offset: 0x0027FB2C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EC4 RID: 40644 RVA: 0x0004DDA5 File Offset: 0x0004BFA5
		public SettingsScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030D9 RID: 12505
		// (get) Token: 0x06009EC5 RID: 40645 RVA: 0x00281968 File Offset: 0x0027FB68
		// (set) Token: 0x06009EC6 RID: 40646 RVA: 0x0004DDAE File Offset: 0x0004BFAE
		public unsafe Il2CppReferenceArray<SettingsScreen.SettingsCategory> Categories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_Categories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SettingsScreen.SettingsCategory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_Categories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030DA RID: 12506
		// (get) Token: 0x06009EC7 RID: 40647 RVA: 0x00281998 File Offset: 0x0027FB98
		// (set) Token: 0x06009EC8 RID: 40648 RVA: 0x0004DDCD File Offset: 0x0004BFCD
		public unsafe Button ApplyDisplayButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_ApplyDisplayButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_ApplyDisplayButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030DB RID: 12507
		// (get) Token: 0x06009EC9 RID: 40649 RVA: 0x002819C8 File Offset: 0x0027FBC8
		// (set) Token: 0x06009ECA RID: 40650 RVA: 0x0004DDEC File Offset: 0x0004BFEC
		public unsafe ConfirmDisplaySettings ConfirmDisplaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_ConfirmDisplaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmDisplaySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_ConfirmDisplaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A88 RID: 27272
		private static readonly IntPtr NativeFieldInfoPtr_Categories;

		// Token: 0x04006A89 RID: 27273
		private static readonly IntPtr NativeFieldInfoPtr_ApplyDisplayButton;

		// Token: 0x04006A8A RID: 27274
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmDisplaySettings;

		// Token: 0x04006A8B RID: 27275
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006A8C RID: 27276
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x04006A8D RID: 27277
		private static readonly IntPtr NativeMethodInfoPtr_ShowCategory_Public_Void_Int32_0;

		// Token: 0x04006A8E RID: 27278
		private static readonly IntPtr NativeMethodInfoPtr_DisplayChanged_Public_Void_0;

		// Token: 0x04006A8F RID: 27279
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDisplaySettings_Private_Void_0;

		// Token: 0x04006A90 RID: 27280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B9E RID: 2974
		[Serializable]
		public class SettingsCategory : Il2CppSystem.Object
		{
			// Token: 0x0600DC83 RID: 56451 RVA: 0x00342418 File Offset: 0x00340618
			// Note: this type is marked as 'beforefieldinit'.
			static SettingsCategory()
			{
				Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "SettingsCategory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr);
				SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr, "Button");
				SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr, "Panel");
				SettingsScreen.SettingsCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr, 100682776);
			}

			// Token: 0x0600DC84 RID: 56452 RVA: 0x00342480 File Offset: 0x00340680
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SettingsCategory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.SettingsCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC85 RID: 56453 RVA: 0x0006B6D5 File Offset: 0x000698D5
			public SettingsCategory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004457 RID: 17495
			// (get) Token: 0x0600DC86 RID: 56454 RVA: 0x003424BC File Offset: 0x003406BC
			// (set) Token: 0x0600DC87 RID: 56455 RVA: 0x0006B6DE File Offset: 0x000698DE
			public unsafe Button Button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004458 RID: 17496
			// (get) Token: 0x0600DC88 RID: 56456 RVA: 0x003424EC File Offset: 0x003406EC
			// (set) Token: 0x0600DC89 RID: 56457 RVA: 0x0006B6FD File Offset: 0x000698FD
			public unsafe GameObject Panel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Panel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093C4 RID: 37828
			private static readonly IntPtr NativeFieldInfoPtr_Button;

			// Token: 0x040093C5 RID: 37829
			private static readonly IntPtr NativeFieldInfoPtr_Panel;

			// Token: 0x040093C6 RID: 37830
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B9F RID: 2975
		[ObfuscatedName("ScheduleOne.UI.MainMenu.SettingsScreen+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DC8A RID: 56458 RVA: 0x0034251C File Offset: 0x0034071C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr);
				SettingsScreen.__c__DisplayClass5_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr, "index");
				SettingsScreen.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
				SettingsScreen.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr, 100682777);
				SettingsScreen.__c__DisplayClass5_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr, 100682778);
			}

			// Token: 0x0600DC8B RID: 56459 RVA: 0x00342598 File Offset: 0x00340798
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC8C RID: 56460 RVA: 0x003425D4 File Offset: 0x003407D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280834, XrefRangeEnd = 280836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.__c__DisplayClass5_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC8D RID: 56461 RVA: 0x0006B71C File Offset: 0x0006991C
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004459 RID: 17497
			// (get) Token: 0x0600DC8E RID: 56462 RVA: 0x00342608 File Offset: 0x00340808
			// (set) Token: 0x0600DC8F RID: 56463 RVA: 0x0006B725 File Offset: 0x00069925
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass5_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass5_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x1700445A RID: 17498
			// (get) Token: 0x0600DC90 RID: 56464 RVA: 0x00342630 File Offset: 0x00340830
			// (set) Token: 0x0600DC91 RID: 56465 RVA: 0x0006B740 File Offset: 0x00069940
			public unsafe SettingsScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093C7 RID: 37831
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040093C8 RID: 37832
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093C9 RID: 37833
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093CA RID: 37834
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}
	}
}
