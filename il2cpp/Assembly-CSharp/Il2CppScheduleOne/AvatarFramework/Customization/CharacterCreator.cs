using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.CharacterCreator;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000618 RID: 1560
	public class CharacterCreator : Singleton<CharacterCreator>
	{
		// Token: 0x060089E2 RID: 35298 RVA: 0x00242CA4 File Offset: 0x00240EA4
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreator()
		{
			Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "CharacterCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr);
			CharacterCreator.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "<IsOpen>k__BackingField");
			CharacterCreator.NativeFieldInfoPtr_Fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Fields");
			CharacterCreator.NativeFieldInfoPtr__ActiveSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "<ActiveSettings>k__BackingField");
			CharacterCreator.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Container");
			CharacterCreator.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "CameraPosition");
			CharacterCreator.NativeFieldInfoPtr_RigContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "RigContainer");
			CharacterCreator.NativeFieldInfoPtr_Rig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Rig");
			CharacterCreator.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Canvas");
			CharacterCreator.NativeFieldInfoPtr_CanvasAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "CanvasAnimation");
			CharacterCreator.NativeFieldInfoPtr_DemoCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "DemoCreator");
			CharacterCreator.NativeFieldInfoPtr_DefaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "DefaultSettings");
			CharacterCreator.NativeFieldInfoPtr_Presets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Presets");
			CharacterCreator.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "onComplete");
			CharacterCreator.NativeFieldInfoPtr_onCompleteWithClothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "onCompleteWithClothing");
			CharacterCreator.NativeFieldInfoPtr_lastSelectedClothingDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "lastSelectedClothingDefinitions");
			CharacterCreator.NativeFieldInfoPtr_rigTargetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "rigTargetY");
			CharacterCreator.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680430);
			CharacterCreator.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680431);
			CharacterCreator.NativeMethodInfoPtr_get_ActiveSettings_Public_get_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680432);
			CharacterCreator.NativeMethodInfoPtr_set_ActiveSettings_Protected_set_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680433);
			CharacterCreator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680434);
			CharacterCreator.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680435);
			CharacterCreator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680436);
			CharacterCreator.NativeMethodInfoPtr_Open_Public_Void_BasicAvatarSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680437);
			CharacterCreator.NativeMethodInfoPtr_ShowUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680438);
			CharacterCreator.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680439);
			CharacterCreator.NativeMethodInfoPtr_DisableStuff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680440);
			CharacterCreator.NativeMethodInfoPtr_Done_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680441);
			CharacterCreator.NativeMethodInfoPtr_SliderChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680442);
			CharacterCreator.NativeMethodInfoPtr_SetValue_Public_T_String_T_ClothingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680443);
			CharacterCreator.NativeMethodInfoPtr_SelectPreset_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680444);
			CharacterCreator.NativeMethodInfoPtr_RefreshCategory_Public_Void_ECategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680445);
			CharacterCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680446);
			CharacterCreator.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680447);
		}

		// Token: 0x17002A1C RID: 10780
		// (get) Token: 0x060089E3 RID: 35299 RVA: 0x00242F7C File Offset: 0x0024117C
		// (set) Token: 0x060089E4 RID: 35300 RVA: 0x00242FB8 File Offset: 0x002411B8
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37992, RefRangeEnd = 38015, XrefRangeStart = 37992, XrefRangeEnd = 38015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002A1D RID: 10781
		// (get) Token: 0x060089E5 RID: 35301 RVA: 0x00242FF8 File Offset: 0x002411F8
		// (set) Token: 0x060089E6 RID: 35302 RVA: 0x00243038 File Offset: 0x00241238
		public unsafe BasicAvatarSettings ActiveSettings
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19660, RefRangeEnd = 19667, XrefRangeStart = 19660, XrefRangeEnd = 19667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_get_ActiveSettings_Public_get_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_set_ActiveSettings_Protected_set_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060089E7 RID: 35303 RVA: 0x0024307C File Offset: 0x0024127C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253932, XrefRangeEnd = 253945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089E8 RID: 35304 RVA: 0x002430B8 File Offset: 0x002412B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253945, XrefRangeEnd = 253951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreator.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089E9 RID: 35305 RVA: 0x002430F4 File Offset: 0x002412F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253951, XrefRangeEnd = 253955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089EA RID: 35306 RVA: 0x00243128 File Offset: 0x00241328
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254015, RefRangeEnd = 254017, XrefRangeStart = 253955, XrefRangeEnd = 254015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(BasicAvatarSettings initialSettings, bool showUI = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(initialSettings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showUI;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Open_Public_Void_BasicAvatarSettings_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089EB RID: 35307 RVA: 0x00243178 File Offset: 0x00241378
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254032, RefRangeEnd = 254035, XrefRangeStart = 254017, XrefRangeEnd = 254032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_ShowUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089EC RID: 35308 RVA: 0x002431AC File Offset: 0x002413AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254035, XrefRangeEnd = 254041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089ED RID: 35309 RVA: 0x002431E0 File Offset: 0x002413E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254044, RefRangeEnd = 254045, XrefRangeStart = 254041, XrefRangeEnd = 254044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableStuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_DisableStuff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089EE RID: 35310 RVA: 0x00243214 File Offset: 0x00241414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254045, XrefRangeEnd = 254099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Done()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Done_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089EF RID: 35311 RVA: 0x00243248 File Offset: 0x00241448
		[CallerCount(0)]
		public unsafe void SliderChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_SliderChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089F0 RID: 35312 RVA: 0x00243288 File Offset: 0x00241488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254119, RefRangeEnd = 254120, XrefRangeStart = 254099, XrefRangeEnd = 254119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T SetValue<T>(string fieldName, T value, ClothingDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.MethodInfoStoreGeneric_SetValue_Public_T_String_T_ClothingDefinition_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060089F1 RID: 35313 RVA: 0x00243344 File Offset: 0x00241544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254120, XrefRangeEnd = 254158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectPreset(string presetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(presetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_SelectPreset_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089F2 RID: 35314 RVA: 0x00243388 File Offset: 0x00241588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254162, RefRangeEnd = 254163, XrefRangeStart = 254158, XrefRangeEnd = 254162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshCategory(CharacterCreator.ECategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_RefreshCategory_Public_Void_ECategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089F3 RID: 35315 RVA: 0x002433C8 File Offset: 0x002415C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254163, XrefRangeEnd = 254180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089F4 RID: 35316 RVA: 0x00243404 File Offset: 0x00241604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254180, XrefRangeEnd = 254185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060089F5 RID: 35317 RVA: 0x00041EC4 File Offset: 0x000400C4
		public CharacterCreator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A0C RID: 10764
		// (get) Token: 0x060089F6 RID: 35318 RVA: 0x00243444 File Offset: 0x00241644
		// (set) Token: 0x060089F7 RID: 35319 RVA: 0x00041ECD File Offset: 0x000400CD
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A0D RID: 10765
		// (get) Token: 0x060089F8 RID: 35320 RVA: 0x0024346C File Offset: 0x0024166C
		// (set) Token: 0x060089F9 RID: 35321 RVA: 0x00041EE8 File Offset: 0x000400E8
		public unsafe List<BaseCharacterCreatorField> Fields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Fields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseCharacterCreatorField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Fields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A0E RID: 10766
		// (get) Token: 0x060089FA RID: 35322 RVA: 0x0024349C File Offset: 0x0024169C
		// (set) Token: 0x060089FB RID: 35323 RVA: 0x00041F07 File Offset: 0x00040107
		public unsafe BasicAvatarSettings _ActiveSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr__ActiveSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr__ActiveSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A0F RID: 10767
		// (get) Token: 0x060089FC RID: 35324 RVA: 0x002434CC File Offset: 0x002416CC
		// (set) Token: 0x060089FD RID: 35325 RVA: 0x00041F26 File Offset: 0x00040126
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A10 RID: 10768
		// (get) Token: 0x060089FE RID: 35326 RVA: 0x002434FC File Offset: 0x002416FC
		// (set) Token: 0x060089FF RID: 35327 RVA: 0x00041F45 File Offset: 0x00040145
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A11 RID: 10769
		// (get) Token: 0x06008A00 RID: 35328 RVA: 0x0024352C File Offset: 0x0024172C
		// (set) Token: 0x06008A01 RID: 35329 RVA: 0x00041F64 File Offset: 0x00040164
		public unsafe Transform RigContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_RigContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_RigContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A12 RID: 10770
		// (get) Token: 0x06008A02 RID: 35330 RVA: 0x0024355C File Offset: 0x0024175C
		// (set) Token: 0x06008A03 RID: 35331 RVA: 0x00041F83 File Offset: 0x00040183
		public unsafe Avatar Rig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Rig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Rig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A13 RID: 10771
		// (get) Token: 0x06008A04 RID: 35332 RVA: 0x0024358C File Offset: 0x0024178C
		// (set) Token: 0x06008A05 RID: 35333 RVA: 0x00041FA2 File Offset: 0x000401A2
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A14 RID: 10772
		// (get) Token: 0x06008A06 RID: 35334 RVA: 0x002435BC File Offset: 0x002417BC
		// (set) Token: 0x06008A07 RID: 35335 RVA: 0x00041FC1 File Offset: 0x000401C1
		public unsafe Animation CanvasAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_CanvasAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_CanvasAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A15 RID: 10773
		// (get) Token: 0x06008A08 RID: 35336 RVA: 0x002435EC File Offset: 0x002417EC
		// (set) Token: 0x06008A09 RID: 35337 RVA: 0x00041FE0 File Offset: 0x000401E0
		public unsafe bool DemoCreator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_DemoCreator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_DemoCreator)) = value;
			}
		}

		// Token: 0x17002A16 RID: 10774
		// (get) Token: 0x06008A0A RID: 35338 RVA: 0x00243614 File Offset: 0x00241814
		// (set) Token: 0x06008A0B RID: 35339 RVA: 0x00041FFB File Offset: 0x000401FB
		public unsafe BasicAvatarSettings DefaultSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_DefaultSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_DefaultSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A17 RID: 10775
		// (get) Token: 0x06008A0C RID: 35340 RVA: 0x00243644 File Offset: 0x00241844
		// (set) Token: 0x06008A0D RID: 35341 RVA: 0x0004201A File Offset: 0x0004021A
		public unsafe List<BasicAvatarSettings> Presets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Presets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BasicAvatarSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Presets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A18 RID: 10776
		// (get) Token: 0x06008A0E RID: 35342 RVA: 0x00243674 File Offset: 0x00241874
		// (set) Token: 0x06008A0F RID: 35343 RVA: 0x00042039 File Offset: 0x00040239
		public unsafe UnityEvent<BasicAvatarSettings> onComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_onComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<BasicAvatarSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A19 RID: 10777
		// (get) Token: 0x06008A10 RID: 35344 RVA: 0x002436A4 File Offset: 0x002418A4
		// (set) Token: 0x06008A11 RID: 35345 RVA: 0x00042058 File Offset: 0x00040258
		public unsafe UnityEvent<BasicAvatarSettings, List<ClothingInstance>> onCompleteWithClothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_onCompleteWithClothing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<BasicAvatarSettings, List<ClothingInstance>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_onCompleteWithClothing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A1A RID: 10778
		// (get) Token: 0x06008A12 RID: 35346 RVA: 0x002436D4 File Offset: 0x002418D4
		// (set) Token: 0x06008A13 RID: 35347 RVA: 0x00042077 File Offset: 0x00040277
		public unsafe Dictionary<string, ClothingDefinition> lastSelectedClothingDefinitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_lastSelectedClothingDefinitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ClothingDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_lastSelectedClothingDefinitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A1B RID: 10779
		// (get) Token: 0x06008A14 RID: 35348 RVA: 0x00243704 File Offset: 0x00241904
		// (set) Token: 0x06008A15 RID: 35349 RVA: 0x00042096 File Offset: 0x00040296
		public unsafe float rigTargetY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_rigTargetY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_rigTargetY)) = value;
			}
		}

		// Token: 0x04005D92 RID: 23954
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005D93 RID: 23955
		private static readonly IntPtr NativeFieldInfoPtr_Fields;

		// Token: 0x04005D94 RID: 23956
		private static readonly IntPtr NativeFieldInfoPtr__ActiveSettings_k__BackingField;

		// Token: 0x04005D95 RID: 23957
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005D96 RID: 23958
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04005D97 RID: 23959
		private static readonly IntPtr NativeFieldInfoPtr_RigContainer;

		// Token: 0x04005D98 RID: 23960
		private static readonly IntPtr NativeFieldInfoPtr_Rig;

		// Token: 0x04005D99 RID: 23961
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04005D9A RID: 23962
		private static readonly IntPtr NativeFieldInfoPtr_CanvasAnimation;

		// Token: 0x04005D9B RID: 23963
		private static readonly IntPtr NativeFieldInfoPtr_DemoCreator;

		// Token: 0x04005D9C RID: 23964
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSettings;

		// Token: 0x04005D9D RID: 23965
		private static readonly IntPtr NativeFieldInfoPtr_Presets;

		// Token: 0x04005D9E RID: 23966
		private static readonly IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x04005D9F RID: 23967
		private static readonly IntPtr NativeFieldInfoPtr_onCompleteWithClothing;

		// Token: 0x04005DA0 RID: 23968
		private static readonly IntPtr NativeFieldInfoPtr_lastSelectedClothingDefinitions;

		// Token: 0x04005DA1 RID: 23969
		private static readonly IntPtr NativeFieldInfoPtr_rigTargetY;

		// Token: 0x04005DA2 RID: 23970
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005DA3 RID: 23971
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04005DA4 RID: 23972
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveSettings_Public_get_BasicAvatarSettings_0;

		// Token: 0x04005DA5 RID: 23973
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveSettings_Protected_set_Void_BasicAvatarSettings_0;

		// Token: 0x04005DA6 RID: 23974
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005DA7 RID: 23975
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005DA8 RID: 23976
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005DA9 RID: 23977
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_BasicAvatarSettings_Boolean_0;

		// Token: 0x04005DAA RID: 23978
		private static readonly IntPtr NativeMethodInfoPtr_ShowUI_Public_Void_0;

		// Token: 0x04005DAB RID: 23979
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005DAC RID: 23980
		private static readonly IntPtr NativeMethodInfoPtr_DisableStuff_Public_Void_0;

		// Token: 0x04005DAD RID: 23981
		private static readonly IntPtr NativeMethodInfoPtr_Done_Public_Void_0;

		// Token: 0x04005DAE RID: 23982
		private static readonly IntPtr NativeMethodInfoPtr_SliderChanged_Public_Void_Single_0;

		// Token: 0x04005DAF RID: 23983
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_T_String_T_ClothingDefinition_0;

		// Token: 0x04005DB0 RID: 23984
		private static readonly IntPtr NativeMethodInfoPtr_SelectPreset_Public_Void_String_0;

		// Token: 0x04005DB1 RID: 23985
		private static readonly IntPtr NativeMethodInfoPtr_RefreshCategory_Public_Void_ECategory_0;

		// Token: 0x04005DB2 RID: 23986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005DB3 RID: 23987
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B0C RID: 2828
		[OriginalName("Assembly-CSharp.dll", "", "ECategory")]
		public enum ECategory
		{
			// Token: 0x04009048 RID: 36936
			Body,
			// Token: 0x04009049 RID: 36937
			Hair,
			// Token: 0x0400904A RID: 36938
			Face,
			// Token: 0x0400904B RID: 36939
			Eyes,
			// Token: 0x0400904C RID: 36940
			Eyebrows,
			// Token: 0x0400904D RID: 36941
			Clothing,
			// Token: 0x0400904E RID: 36942
			Accessories
		}

		// Token: 0x02000B0D RID: 2829
		[ObfuscatedName("ScheduleOne.AvatarFramework.Customization.CharacterCreator+<<Close>g__Close|28_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D68E RID: 54926 RVA: 0x00331288 File Offset: 0x0032F488
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique()
			{
				Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "<<Close>g__Close|28_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr);
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, "<>1__state");
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, "<>2__current");
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, "<>4__this");
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, 100680448);
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, 100680449);
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, 100680450);
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, 100680451);
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, 100680452);
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, 100680453);
			}

			// Token: 0x0600D68F RID: 54927 RVA: 0x00331368 File Offset: 0x0032F568
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D690 RID: 54928 RVA: 0x003313B0 File Offset: 0x0032F5B0
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D691 RID: 54929 RVA: 0x003313E4 File Offset: 0x0032F5E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253909, XrefRangeEnd = 253924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700427D RID: 17021
			// (get) Token: 0x0600D692 RID: 54930 RVA: 0x00331420 File Offset: 0x0032F620
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D693 RID: 54931 RVA: 0x00331460 File Offset: 0x0032F660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253924, XrefRangeEnd = 253929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700427E RID: 17022
			// (get) Token: 0x0600D694 RID: 54932 RVA: 0x00331494 File Offset: 0x0032F694
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D695 RID: 54933 RVA: 0x000686BD File Offset: 0x000668BD
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700427A RID: 17018
			// (get) Token: 0x0600D696 RID: 54934 RVA: 0x003314D4 File Offset: 0x0032F6D4
			// (set) Token: 0x0600D697 RID: 54935 RVA: 0x000686C6 File Offset: 0x000668C6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700427B RID: 17019
			// (get) Token: 0x0600D698 RID: 54936 RVA: 0x003314FC File Offset: 0x0032F6FC
			// (set) Token: 0x0600D699 RID: 54937 RVA: 0x000686E1 File Offset: 0x000668E1
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700427C RID: 17020
			// (get) Token: 0x0600D69A RID: 54938 RVA: 0x0033152C File Offset: 0x0032F72C
			// (set) Token: 0x0600D69B RID: 54939 RVA: 0x00068700 File Offset: 0x00066900
			public unsafe CharacterCreator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400904F RID: 36943
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009050 RID: 36944
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009051 RID: 36945
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009052 RID: 36946
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009053 RID: 36947
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009054 RID: 36948
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009055 RID: 36949
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009056 RID: 36950
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009057 RID: 36951
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B0E RID: 2830
		[ObfuscatedName("ScheduleOne.AvatarFramework.Customization.CharacterCreator+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D69C RID: 54940 RVA: 0x0033155C File Offset: 0x0032F75C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr);
				CharacterCreator.__c__DisplayClass33_0.NativeFieldInfoPtr_presetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr, "presetName");
				CharacterCreator.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr, 100680454);
				CharacterCreator.__c__DisplayClass33_0.NativeMethodInfoPtr__SelectPreset_b__0_Internal_Boolean_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr, 100680455);
			}

			// Token: 0x0600D69D RID: 54941 RVA: 0x003315C4 File Offset: 0x0032F7C4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D69E RID: 54942 RVA: 0x00331600 File Offset: 0x0032F800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253929, XrefRangeEnd = 253932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectPreset_b__0(BasicAvatarSettings p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.__c__DisplayClass33_0.NativeMethodInfoPtr__SelectPreset_b__0_Internal_Boolean_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D69F RID: 54943 RVA: 0x0006871F File Offset: 0x0006691F
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700427F RID: 17023
			// (get) Token: 0x0600D6A0 RID: 54944 RVA: 0x00331650 File Offset: 0x0032F850
			// (set) Token: 0x0600D6A1 RID: 54945 RVA: 0x00068728 File Offset: 0x00066928
			public unsafe string presetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.__c__DisplayClass33_0.NativeFieldInfoPtr_presetName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.__c__DisplayClass33_0.NativeFieldInfoPtr_presetName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009058 RID: 36952
			private static readonly IntPtr NativeFieldInfoPtr_presetName;

			// Token: 0x04009059 RID: 36953
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400905A RID: 36954
			private static readonly IntPtr NativeMethodInfoPtr__SelectPreset_b__0_Internal_Boolean_BasicAvatarSettings_0;
		}

		// Token: 0x02000B0F RID: 2831
		private sealed class MethodInfoStoreGeneric_SetValue_Public_T_String_T_ClothingDefinition_0<T>
		{
			// Token: 0x0400905B RID: 36955
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CharacterCreator.NativeMethodInfoPtr_SetValue_Public_T_String_T_ClothingDefinition_0, Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
