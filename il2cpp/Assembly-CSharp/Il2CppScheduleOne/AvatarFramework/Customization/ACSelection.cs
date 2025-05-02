using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000615 RID: 1557
	public class ACSelection<T> : MonoBehaviour where T : UnityEngine.Object
	{
		// Token: 0x06008974 RID: 35188 RVA: 0x00241B90 File Offset: 0x0023FD90
		// Note: this type is marked as 'beforefieldinit'.
		static ACSelection()
		{
			Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACSelection`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr);
			ACSelection<T>.NativeFieldInfoPtr_ButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "ButtonPrefab");
			ACSelection<T>.NativeFieldInfoPtr_PropertyIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "PropertyIndex");
			ACSelection<T>.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "Options");
			ACSelection<T>.NativeFieldInfoPtr_Nullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "Nullable");
			ACSelection<T>.NativeFieldInfoPtr_DefaultOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "DefaultOptionIndex");
			ACSelection<T>.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "buttons");
			ACSelection<T>.NativeFieldInfoPtr_SelectedOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "SelectedOptionIndex");
			ACSelection<T>.NativeFieldInfoPtr_onValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "onValueChange");
			ACSelection<T>.NativeFieldInfoPtr_onValueChangeWithIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "onValueChangeWithIndex");
			ACSelection<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680412);
			ACSelection<T>.NativeMethodInfoPtr_SelectOption_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680413);
			ACSelection<T>.NativeMethodInfoPtr_CallValueChange_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680414);
			ACSelection<T>.NativeMethodInfoPtr_GetOptionLabel_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680415);
			ACSelection<T>.NativeMethodInfoPtr_GetAssetPathIndex_Public_Abstract_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680416);
			ACSelection<T>.NativeMethodInfoPtr_SetButtonHighlighted_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680417);
			ACSelection<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100680418);
		}

		// Token: 0x06008975 RID: 35189 RVA: 0x00241D3C File Offset: 0x0023FF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253687, XrefRangeEnd = 253719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSelection<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008976 RID: 35190 RVA: 0x00241D78 File Offset: 0x0023FF78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253723, RefRangeEnd = 253724, XrefRangeStart = 253719, XrefRangeEnd = 253723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectOption(int index, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.NativeMethodInfoPtr_SelectOption_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008977 RID: 35191 RVA: 0x00241DC4 File Offset: 0x0023FFC4
		[CallerCount(0)]
		public unsafe virtual void CallValueChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSelection<T>.NativeMethodInfoPtr_CallValueChange_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008978 RID: 35192 RVA: 0x00241E00 File Offset: 0x00240000
		[CallerCount(0)]
		public unsafe virtual string GetOptionLabel(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSelection<T>.NativeMethodInfoPtr_GetOptionLabel_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008979 RID: 35193 RVA: 0x00241E50 File Offset: 0x00240050
		[CallerCount(0)]
		public unsafe virtual int GetAssetPathIndex(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSelection<T>.NativeMethodInfoPtr_GetAssetPathIndex_Public_Abstract_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600897A RID: 35194 RVA: 0x00241EA8 File Offset: 0x002400A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253724, XrefRangeEnd = 253733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetButtonHighlighted(int buttonIndex, bool h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buttonIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.NativeMethodInfoPtr_SetButtonHighlighted_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600897B RID: 35195 RVA: 0x00241EF4 File Offset: 0x002400F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253745, RefRangeEnd = 253748, XrefRangeStart = 253733, XrefRangeEnd = 253745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACSelection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600897C RID: 35196 RVA: 0x000419D8 File Offset: 0x0003FBD8
		public ACSelection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029E0 RID: 10720
		// (get) Token: 0x0600897D RID: 35197 RVA: 0x00241F30 File Offset: 0x00240130
		// (set) Token: 0x0600897E RID: 35198 RVA: 0x000419E1 File Offset: 0x0003FBE1
		public unsafe GameObject ButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_ButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_ButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029E1 RID: 10721
		// (get) Token: 0x0600897F RID: 35199 RVA: 0x00241F60 File Offset: 0x00240160
		// (set) Token: 0x06008980 RID: 35200 RVA: 0x00041A00 File Offset: 0x0003FC00
		public unsafe int PropertyIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_PropertyIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_PropertyIndex)) = value;
			}
		}

		// Token: 0x170029E2 RID: 10722
		// (get) Token: 0x06008981 RID: 35201 RVA: 0x00241F88 File Offset: 0x00240188
		// (set) Token: 0x06008982 RID: 35202 RVA: 0x00041A1B File Offset: 0x0003FC1B
		public unsafe List<T> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029E3 RID: 10723
		// (get) Token: 0x06008983 RID: 35203 RVA: 0x00241FB8 File Offset: 0x002401B8
		// (set) Token: 0x06008984 RID: 35204 RVA: 0x00041A3A File Offset: 0x0003FC3A
		public unsafe bool Nullable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_Nullable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_Nullable)) = value;
			}
		}

		// Token: 0x170029E4 RID: 10724
		// (get) Token: 0x06008985 RID: 35205 RVA: 0x00241FE0 File Offset: 0x002401E0
		// (set) Token: 0x06008986 RID: 35206 RVA: 0x00041A55 File Offset: 0x0003FC55
		public unsafe int DefaultOptionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_DefaultOptionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_DefaultOptionIndex)) = value;
			}
		}

		// Token: 0x170029E5 RID: 10725
		// (get) Token: 0x06008987 RID: 35207 RVA: 0x00242008 File Offset: 0x00240208
		// (set) Token: 0x06008988 RID: 35208 RVA: 0x00041A70 File Offset: 0x0003FC70
		public unsafe List<GameObject> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029E6 RID: 10726
		// (get) Token: 0x06008989 RID: 35209 RVA: 0x00242038 File Offset: 0x00240238
		// (set) Token: 0x0600898A RID: 35210 RVA: 0x00041A8F File Offset: 0x0003FC8F
		public unsafe int SelectedOptionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_SelectedOptionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_SelectedOptionIndex)) = value;
			}
		}

		// Token: 0x170029E7 RID: 10727
		// (get) Token: 0x0600898B RID: 35211 RVA: 0x00242060 File Offset: 0x00240260
		// (set) Token: 0x0600898C RID: 35212 RVA: 0x00041AAA File Offset: 0x0003FCAA
		public unsafe UnityEvent<T> onValueChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_onValueChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_onValueChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029E8 RID: 10728
		// (get) Token: 0x0600898D RID: 35213 RVA: 0x00242090 File Offset: 0x00240290
		// (set) Token: 0x0600898E RID: 35214 RVA: 0x00041AC9 File Offset: 0x0003FCC9
		public unsafe UnityEvent<T, int> onValueChangeWithIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_onValueChangeWithIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<T, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_onValueChangeWithIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D56 RID: 23894
		private static readonly IntPtr NativeFieldInfoPtr_ButtonPrefab;

		// Token: 0x04005D57 RID: 23895
		private static readonly IntPtr NativeFieldInfoPtr_PropertyIndex;

		// Token: 0x04005D58 RID: 23896
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x04005D59 RID: 23897
		private static readonly IntPtr NativeFieldInfoPtr_Nullable;

		// Token: 0x04005D5A RID: 23898
		private static readonly IntPtr NativeFieldInfoPtr_DefaultOptionIndex;

		// Token: 0x04005D5B RID: 23899
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x04005D5C RID: 23900
		private static readonly IntPtr NativeFieldInfoPtr_SelectedOptionIndex;

		// Token: 0x04005D5D RID: 23901
		private static readonly IntPtr NativeFieldInfoPtr_onValueChange;

		// Token: 0x04005D5E RID: 23902
		private static readonly IntPtr NativeFieldInfoPtr_onValueChangeWithIndex;

		// Token: 0x04005D5F RID: 23903
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005D60 RID: 23904
		private static readonly IntPtr NativeMethodInfoPtr_SelectOption_Public_Void_Int32_Boolean_0;

		// Token: 0x04005D61 RID: 23905
		private static readonly IntPtr NativeMethodInfoPtr_CallValueChange_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04005D62 RID: 23906
		private static readonly IntPtr NativeMethodInfoPtr_GetOptionLabel_Public_Abstract_Virtual_New_String_Int32_0;

		// Token: 0x04005D63 RID: 23907
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetPathIndex_Public_Abstract_Virtual_New_Int32_String_0;

		// Token: 0x04005D64 RID: 23908
		private static readonly IntPtr NativeMethodInfoPtr_SetButtonHighlighted_Private_Void_Int32_Boolean_0;

		// Token: 0x04005D65 RID: 23909
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000B09 RID: 2825
		[ObfuscatedName("ScheduleOne.AvatarFramework.Customization.ACSelection`1+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D684 RID: 54916 RVA: 0x00331060 File Offset: 0x0032F260
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "<>c__DisplayClass9_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr);
				ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr, "index");
				ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				ACSelection<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr, 100680419);
				ACSelection<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr, 100680420);
			}

			// Token: 0x0600D685 RID: 54917 RVA: 0x00331118 File Offset: 0x0032F318
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D686 RID: 54918 RVA: 0x00331154 File Offset: 0x0032F354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253684, XrefRangeEnd = 253687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D687 RID: 54919 RVA: 0x0006867A File Offset: 0x0006687A
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004278 RID: 17016
			// (get) Token: 0x0600D688 RID: 54920 RVA: 0x00331188 File Offset: 0x0032F388
			// (set) Token: 0x0600D689 RID: 54921 RVA: 0x00068683 File Offset: 0x00066883
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17004279 RID: 17017
			// (get) Token: 0x0600D68A RID: 54922 RVA: 0x003311B0 File Offset: 0x0032F3B0
			// (set) Token: 0x0600D68B RID: 54923 RVA: 0x0006869E File Offset: 0x0006689E
			public unsafe ACSelection<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ACSelection<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009041 RID: 36929
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04009042 RID: 36930
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009043 RID: 36931
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009044 RID: 36932
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}
	}
}
