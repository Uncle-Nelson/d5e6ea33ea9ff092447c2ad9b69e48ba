using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006C7 RID: 1735
	public class NPCFieldUI : MonoBehaviour
	{
		// Token: 0x06009BC7 RID: 39879 RVA: 0x00278020 File Offset: 0x00276220
		// Note: this type is marked as 'beforefieldinit'.
		static NPCFieldUI()
		{
			Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "NPCFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr);
			NPCFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			NPCFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "FieldLabel");
			NPCFieldUI.NativeFieldInfoPtr_IconImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "IconImg");
			NPCFieldUI.NativeFieldInfoPtr_SelectionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "SelectionLabel");
			NPCFieldUI.NativeFieldInfoPtr_NoneSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "NoneSelected");
			NPCFieldUI.NativeFieldInfoPtr_MultipleSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "MultipleSelected");
			NPCFieldUI.NativeFieldInfoPtr_ClearButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "ClearButton");
			NPCFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_NPCField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682430);
			NPCFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NPCField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682431);
			NPCFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_NPCField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682432);
			NPCFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682433);
			NPCFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682434);
			NPCFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682435);
			NPCFieldUI.NativeMethodInfoPtr_NPCSelected_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682436);
			NPCFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682437);
			NPCFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682438);
		}

		// Token: 0x17002FFB RID: 12283
		// (get) Token: 0x06009BC8 RID: 39880 RVA: 0x00278190 File Offset: 0x00276390
		// (set) Token: 0x06009BC9 RID: 39881 RVA: 0x002781D0 File Offset: 0x002763D0
		public unsafe List<NPCField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_NPCField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NPCField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009BCA RID: 39882 RVA: 0x00278214 File Offset: 0x00276414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276725, XrefRangeEnd = 276752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<NPCField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_NPCField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BCB RID: 39883 RVA: 0x00278258 File Offset: 0x00276458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276798, RefRangeEnd = 276799, XrefRangeStart = 276752, XrefRangeEnd = 276798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(NPC newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BCC RID: 39884 RVA: 0x0027829C File Offset: 0x0027649C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276810, RefRangeEnd = 276812, XrefRangeStart = 276799, XrefRangeEnd = 276810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009BCD RID: 39885 RVA: 0x002782D8 File Offset: 0x002764D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276812, XrefRangeEnd = 276829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BCE RID: 39886 RVA: 0x0027830C File Offset: 0x0027650C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276851, RefRangeEnd = 276852, XrefRangeStart = 276829, XrefRangeEnd = 276851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NPCSelected(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_NPCSelected_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BCF RID: 39887 RVA: 0x00278350 File Offset: 0x00276550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276852, XrefRangeEnd = 276853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BD0 RID: 39888 RVA: 0x00278384 File Offset: 0x00276584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276853, XrefRangeEnd = 276861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BD1 RID: 39889 RVA: 0x0004C50D File Offset: 0x0004A70D
		public NPCFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FF4 RID: 12276
		// (get) Token: 0x06009BD2 RID: 39890 RVA: 0x002783C0 File Offset: 0x002765C0
		// (set) Token: 0x06009BD3 RID: 39891 RVA: 0x0004C516 File Offset: 0x0004A716
		public unsafe List<NPCField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF5 RID: 12277
		// (get) Token: 0x06009BD4 RID: 39892 RVA: 0x002783F0 File Offset: 0x002765F0
		// (set) Token: 0x06009BD5 RID: 39893 RVA: 0x0004C535 File Offset: 0x0004A735
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF6 RID: 12278
		// (get) Token: 0x06009BD6 RID: 39894 RVA: 0x00278420 File Offset: 0x00276620
		// (set) Token: 0x06009BD7 RID: 39895 RVA: 0x0004C554 File Offset: 0x0004A754
		public unsafe Image IconImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_IconImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_IconImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF7 RID: 12279
		// (get) Token: 0x06009BD8 RID: 39896 RVA: 0x00278450 File Offset: 0x00276650
		// (set) Token: 0x06009BD9 RID: 39897 RVA: 0x0004C573 File Offset: 0x0004A773
		public unsafe TextMeshProUGUI SelectionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_SelectionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_SelectionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF8 RID: 12280
		// (get) Token: 0x06009BDA RID: 39898 RVA: 0x00278480 File Offset: 0x00276680
		// (set) Token: 0x06009BDB RID: 39899 RVA: 0x0004C592 File Offset: 0x0004A792
		public unsafe GameObject NoneSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_NoneSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_NoneSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF9 RID: 12281
		// (get) Token: 0x06009BDC RID: 39900 RVA: 0x002784B0 File Offset: 0x002766B0
		// (set) Token: 0x06009BDD RID: 39901 RVA: 0x0004C5B1 File Offset: 0x0004A7B1
		public unsafe GameObject MultipleSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_MultipleSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_MultipleSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FFA RID: 12282
		// (get) Token: 0x06009BDE RID: 39902 RVA: 0x002784E0 File Offset: 0x002766E0
		// (set) Token: 0x06009BDF RID: 39903 RVA: 0x0004C5D0 File Offset: 0x0004A7D0
		public unsafe RectTransform ClearButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_ClearButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_ClearButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040068A9 RID: 26793
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x040068AA RID: 26794
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x040068AB RID: 26795
		private static readonly IntPtr NativeFieldInfoPtr_IconImg;

		// Token: 0x040068AC RID: 26796
		private static readonly IntPtr NativeFieldInfoPtr_SelectionLabel;

		// Token: 0x040068AD RID: 26797
		private static readonly IntPtr NativeFieldInfoPtr_NoneSelected;

		// Token: 0x040068AE RID: 26798
		private static readonly IntPtr NativeFieldInfoPtr_MultipleSelected;

		// Token: 0x040068AF RID: 26799
		private static readonly IntPtr NativeFieldInfoPtr_ClearButton;

		// Token: 0x040068B0 RID: 26800
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_NPCField_0;

		// Token: 0x040068B1 RID: 26801
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NPCField_0;

		// Token: 0x040068B2 RID: 26802
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_NPCField_0;

		// Token: 0x040068B3 RID: 26803
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_NPC_0;

		// Token: 0x040068B4 RID: 26804
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x040068B5 RID: 26805
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x040068B6 RID: 26806
		private static readonly IntPtr NativeMethodInfoPtr_NPCSelected_Public_Void_NPC_0;

		// Token: 0x040068B7 RID: 26807
		private static readonly IntPtr NativeMethodInfoPtr_ClearClicked_Public_Void_0;

		// Token: 0x040068B8 RID: 26808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B8C RID: 2956
		[ObfuscatedName("ScheduleOne.UI.Management.NPCFieldUI+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DBE6 RID: 56294 RVA: 0x0034073C File Offset: 0x0033E93C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr);
				NPCFieldUI.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr, "<>9");
				NPCFieldUI.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr, "<>9__11_0");
				NPCFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr, 100682440);
				NPCFieldUI.__c.NativeMethodInfoPtr__Refresh_b__11_0_Internal_Boolean_NPCField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr, 100682441);
			}

			// Token: 0x0600DBE7 RID: 56295 RVA: 0x003407B8 File Offset: 0x0033E9B8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBE8 RID: 56296 RVA: 0x003407F4 File Offset: 0x0033E9F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276720, XrefRangeEnd = 276725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Refresh_b__11_0(NPCField x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.__c.NativeMethodInfoPtr__Refresh_b__11_0_Internal_Boolean_NPCField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBE9 RID: 56297 RVA: 0x0006B23B File Offset: 0x0006943B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700442F RID: 17455
			// (get) Token: 0x0600DBEA RID: 56298 RVA: 0x00340844 File Offset: 0x0033EA44
			// (set) Token: 0x0600DBEB RID: 56299 RVA: 0x0006B244 File Offset: 0x00069444
			public unsafe static NPCFieldUI.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCFieldUI.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCFieldUI.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCFieldUI.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004430 RID: 17456
			// (get) Token: 0x0600DBEC RID: 56300 RVA: 0x0034086C File Offset: 0x0033EA6C
			// (set) Token: 0x0600DBED RID: 56301 RVA: 0x0006B256 File Offset: 0x00069456
			public unsafe static Func<NPCField, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCFieldUI.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPCField, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCFieldUI.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009371 RID: 37745
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009372 RID: 37746
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04009373 RID: 37747
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009374 RID: 37748
			private static readonly IntPtr NativeMethodInfoPtr__Refresh_b__11_0_Internal_Boolean_NPCField_0;
		}
	}
}
