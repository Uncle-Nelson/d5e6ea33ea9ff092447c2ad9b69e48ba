using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.UI.Relations;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000631 RID: 1585
	public class DealCompletionPopup : Singleton<DealCompletionPopup>
	{
		// Token: 0x06008C02 RID: 35842 RVA: 0x002497A4 File Offset: 0x002479A4
		// Note: this type is marked as 'beforefieldinit'.
		static DealCompletionPopup()
		{
			Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DealCompletionPopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr);
			DealCompletionPopup.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "<IsPlaying>k__BackingField");
			DealCompletionPopup.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Canvas");
			DealCompletionPopup.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Container");
			DealCompletionPopup.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Group");
			DealCompletionPopup.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Anim");
			DealCompletionPopup.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Title");
			DealCompletionPopup.NativeFieldInfoPtr_PaymentLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "PaymentLabel");
			DealCompletionPopup.NativeFieldInfoPtr_SatisfactionValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "SatisfactionValueLabel");
			DealCompletionPopup.NativeFieldInfoPtr_RelationCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "RelationCircle");
			DealCompletionPopup.NativeFieldInfoPtr_RelationshipLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "RelationshipLabel");
			DealCompletionPopup.NativeFieldInfoPtr_SatisfactionGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "SatisfactionGradient");
			DealCompletionPopup.NativeFieldInfoPtr_SoundEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "SoundEffect");
			DealCompletionPopup.NativeFieldInfoPtr_BonusLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "BonusLabels");
			DealCompletionPopup.NativeFieldInfoPtr_routine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "routine");
			DealCompletionPopup.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100680690);
			DealCompletionPopup.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100680691);
			DealCompletionPopup.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100680692);
			DealCompletionPopup.NativeMethodInfoPtr_PlayPopup_Public_Void_Customer_Single_Single_Single_List_1_BonusPayment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100680693);
			DealCompletionPopup.NativeMethodInfoPtr_SetRelationshipLabel_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100680694);
			DealCompletionPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100680695);
		}

		// Token: 0x17002ABE RID: 10942
		// (get) Token: 0x06008C03 RID: 35843 RVA: 0x00249964 File Offset: 0x00247B64
		// (set) Token: 0x06008C04 RID: 35844 RVA: 0x002499A0 File Offset: 0x00247BA0
		public unsafe bool IsPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008C05 RID: 35845 RVA: 0x002499E0 File Offset: 0x00247BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256513, XrefRangeEnd = 256520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealCompletionPopup.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C06 RID: 35846 RVA: 0x00249A1C File Offset: 0x00247C1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256536, RefRangeEnd = 256537, XrefRangeStart = 256520, XrefRangeEnd = 256536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayPopup(Customer customer, float satisfaction, float originalRelationshipDelta, float basePayment, List<Contract.BonusPayment> bonuses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originalRelationshipDelta;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref basePayment;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bonuses);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr_PlayPopup_Public_Void_Customer_Single_Single_Single_List_1_BonusPayment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C07 RID: 35847 RVA: 0x00249A9C File Offset: 0x00247C9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 256545, RefRangeEnd = 256548, XrefRangeStart = 256537, XrefRangeEnd = 256545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRelationshipLabel(float delta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr_SetRelationshipLabel_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C08 RID: 35848 RVA: 0x00249ADC File Offset: 0x00247CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256548, XrefRangeEnd = 256551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealCompletionPopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C09 RID: 35849 RVA: 0x000430C8 File Offset: 0x000412C8
		public DealCompletionPopup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AB0 RID: 10928
		// (get) Token: 0x06008C0A RID: 35850 RVA: 0x00249B18 File Offset: 0x00247D18
		// (set) Token: 0x06008C0B RID: 35851 RVA: 0x000430D1 File Offset: 0x000412D1
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17002AB1 RID: 10929
		// (get) Token: 0x06008C0C RID: 35852 RVA: 0x00249B40 File Offset: 0x00247D40
		// (set) Token: 0x06008C0D RID: 35853 RVA: 0x000430EC File Offset: 0x000412EC
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AB2 RID: 10930
		// (get) Token: 0x06008C0E RID: 35854 RVA: 0x00249B70 File Offset: 0x00247D70
		// (set) Token: 0x06008C0F RID: 35855 RVA: 0x0004310B File Offset: 0x0004130B
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AB3 RID: 10931
		// (get) Token: 0x06008C10 RID: 35856 RVA: 0x00249BA0 File Offset: 0x00247DA0
		// (set) Token: 0x06008C11 RID: 35857 RVA: 0x0004312A File Offset: 0x0004132A
		public unsafe CanvasGroup Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AB4 RID: 10932
		// (get) Token: 0x06008C12 RID: 35858 RVA: 0x00249BD0 File Offset: 0x00247DD0
		// (set) Token: 0x06008C13 RID: 35859 RVA: 0x00043149 File Offset: 0x00041349
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AB5 RID: 10933
		// (get) Token: 0x06008C14 RID: 35860 RVA: 0x00249C00 File Offset: 0x00247E00
		// (set) Token: 0x06008C15 RID: 35861 RVA: 0x00043168 File Offset: 0x00041368
		public unsafe TextMeshProUGUI Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AB6 RID: 10934
		// (get) Token: 0x06008C16 RID: 35862 RVA: 0x00249C30 File Offset: 0x00247E30
		// (set) Token: 0x06008C17 RID: 35863 RVA: 0x00043187 File Offset: 0x00041387
		public unsafe TextMeshProUGUI PaymentLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_PaymentLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_PaymentLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AB7 RID: 10935
		// (get) Token: 0x06008C18 RID: 35864 RVA: 0x00249C60 File Offset: 0x00247E60
		// (set) Token: 0x06008C19 RID: 35865 RVA: 0x000431A6 File Offset: 0x000413A6
		public unsafe TextMeshProUGUI SatisfactionValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SatisfactionValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SatisfactionValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AB8 RID: 10936
		// (get) Token: 0x06008C1A RID: 35866 RVA: 0x00249C90 File Offset: 0x00247E90
		// (set) Token: 0x06008C1B RID: 35867 RVA: 0x000431C5 File Offset: 0x000413C5
		public unsafe RelationCircle RelationCircle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_RelationCircle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_RelationCircle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AB9 RID: 10937
		// (get) Token: 0x06008C1C RID: 35868 RVA: 0x00249CC0 File Offset: 0x00247EC0
		// (set) Token: 0x06008C1D RID: 35869 RVA: 0x000431E4 File Offset: 0x000413E4
		public unsafe TextMeshProUGUI RelationshipLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_RelationshipLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_RelationshipLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ABA RID: 10938
		// (get) Token: 0x06008C1E RID: 35870 RVA: 0x00249CF0 File Offset: 0x00247EF0
		// (set) Token: 0x06008C1F RID: 35871 RVA: 0x00043203 File Offset: 0x00041403
		public unsafe Gradient SatisfactionGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SatisfactionGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SatisfactionGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ABB RID: 10939
		// (get) Token: 0x06008C20 RID: 35872 RVA: 0x00249D20 File Offset: 0x00247F20
		// (set) Token: 0x06008C21 RID: 35873 RVA: 0x00043222 File Offset: 0x00041422
		public unsafe AudioSourceController SoundEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SoundEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SoundEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ABC RID: 10940
		// (get) Token: 0x06008C22 RID: 35874 RVA: 0x00249D50 File Offset: 0x00247F50
		// (set) Token: 0x06008C23 RID: 35875 RVA: 0x00043241 File Offset: 0x00041441
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> BonusLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_BonusLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_BonusLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ABD RID: 10941
		// (get) Token: 0x06008C24 RID: 35876 RVA: 0x00249D80 File Offset: 0x00247F80
		// (set) Token: 0x06008C25 RID: 35877 RVA: 0x00043260 File Offset: 0x00041460
		public unsafe Coroutine routine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_routine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_routine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005EEF RID: 24303
		private static readonly IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x04005EF0 RID: 24304
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04005EF1 RID: 24305
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005EF2 RID: 24306
		private static readonly IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x04005EF3 RID: 24307
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04005EF4 RID: 24308
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04005EF5 RID: 24309
		private static readonly IntPtr NativeFieldInfoPtr_PaymentLabel;

		// Token: 0x04005EF6 RID: 24310
		private static readonly IntPtr NativeFieldInfoPtr_SatisfactionValueLabel;

		// Token: 0x04005EF7 RID: 24311
		private static readonly IntPtr NativeFieldInfoPtr_RelationCircle;

		// Token: 0x04005EF8 RID: 24312
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipLabel;

		// Token: 0x04005EF9 RID: 24313
		private static readonly IntPtr NativeFieldInfoPtr_SatisfactionGradient;

		// Token: 0x04005EFA RID: 24314
		private static readonly IntPtr NativeFieldInfoPtr_SoundEffect;

		// Token: 0x04005EFB RID: 24315
		private static readonly IntPtr NativeFieldInfoPtr_BonusLabels;

		// Token: 0x04005EFC RID: 24316
		private static readonly IntPtr NativeFieldInfoPtr_routine;

		// Token: 0x04005EFD RID: 24317
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04005EFE RID: 24318
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0;

		// Token: 0x04005EFF RID: 24319
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005F00 RID: 24320
		private static readonly IntPtr NativeMethodInfoPtr_PlayPopup_Public_Void_Customer_Single_Single_Single_List_1_BonusPayment_0;

		// Token: 0x04005F01 RID: 24321
		private static readonly IntPtr NativeMethodInfoPtr_SetRelationshipLabel_Private_Void_Single_0;

		// Token: 0x04005F02 RID: 24322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B1A RID: 2842
		[ObfuscatedName("ScheduleOne.UI.DealCompletionPopup+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D6FF RID: 55039 RVA: 0x0033274C File Offset: 0x0033094C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr);
				DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_customer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "customer");
				DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_bonuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "bonuses");
				DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_originalRelationshipDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "originalRelationshipDelta");
				DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_basePayment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "basePayment");
				DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_satisfaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "satisfaction");
				DealCompletionPopup.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, 100680696);
				DealCompletionPopup.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, 100680697);
				DealCompletionPopup.__c__DisplayClass18_0.NativeMethodInfoPtr__PlayPopup_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, 100680698);
			}

			// Token: 0x0600D700 RID: 55040 RVA: 0x0033282C File Offset: 0x00330A2C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D701 RID: 55041 RVA: 0x00332868 File Offset: 0x00330A68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256507, XrefRangeEnd = 256512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D702 RID: 55042 RVA: 0x003328A8 File Offset: 0x00330AA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256512, XrefRangeEnd = 256513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayPopup_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.NativeMethodInfoPtr__PlayPopup_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D703 RID: 55043 RVA: 0x00068A26 File Offset: 0x00066C26
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004299 RID: 17049
			// (get) Token: 0x0600D704 RID: 55044 RVA: 0x003328E4 File Offset: 0x00330AE4
			// (set) Token: 0x0600D705 RID: 55045 RVA: 0x00068A2F File Offset: 0x00066C2F
			public unsafe DealCompletionPopup __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealCompletionPopup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700429A RID: 17050
			// (get) Token: 0x0600D706 RID: 55046 RVA: 0x00332914 File Offset: 0x00330B14
			// (set) Token: 0x0600D707 RID: 55047 RVA: 0x00068A4E File Offset: 0x00066C4E
			public unsafe Customer customer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_customer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_customer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700429B RID: 17051
			// (get) Token: 0x0600D708 RID: 55048 RVA: 0x00332944 File Offset: 0x00330B44
			// (set) Token: 0x0600D709 RID: 55049 RVA: 0x00068A6D File Offset: 0x00066C6D
			public unsafe List<Contract.BonusPayment> bonuses
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_bonuses);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Contract.BonusPayment>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_bonuses), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700429C RID: 17052
			// (get) Token: 0x0600D70A RID: 55050 RVA: 0x00332974 File Offset: 0x00330B74
			// (set) Token: 0x0600D70B RID: 55051 RVA: 0x00068A8C File Offset: 0x00066C8C
			public unsafe float originalRelationshipDelta
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_originalRelationshipDelta);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_originalRelationshipDelta)) = value;
				}
			}

			// Token: 0x1700429D RID: 17053
			// (get) Token: 0x0600D70C RID: 55052 RVA: 0x0033299C File Offset: 0x00330B9C
			// (set) Token: 0x0600D70D RID: 55053 RVA: 0x00068AA7 File Offset: 0x00066CA7
			public unsafe float basePayment
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_basePayment);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_basePayment)) = value;
				}
			}

			// Token: 0x1700429E RID: 17054
			// (get) Token: 0x0600D70E RID: 55054 RVA: 0x003329C4 File Offset: 0x00330BC4
			// (set) Token: 0x0600D70F RID: 55055 RVA: 0x00068AC2 File Offset: 0x00066CC2
			public unsafe float satisfaction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_satisfaction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_satisfaction)) = value;
				}
			}

			// Token: 0x04009091 RID: 37009
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009092 RID: 37010
			private static readonly IntPtr NativeFieldInfoPtr_customer;

			// Token: 0x04009093 RID: 37011
			private static readonly IntPtr NativeFieldInfoPtr_bonuses;

			// Token: 0x04009094 RID: 37012
			private static readonly IntPtr NativeFieldInfoPtr_originalRelationshipDelta;

			// Token: 0x04009095 RID: 37013
			private static readonly IntPtr NativeFieldInfoPtr_basePayment;

			// Token: 0x04009096 RID: 37014
			private static readonly IntPtr NativeFieldInfoPtr_satisfaction;

			// Token: 0x04009097 RID: 37015
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009098 RID: 37016
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009099 RID: 37017
			private static readonly IntPtr NativeMethodInfoPtr__PlayPopup_b__1_Internal_Boolean_0;

			// Token: 0x02000C71 RID: 3185
			[ObfuscatedName("ScheduleOne.UI.DealCompletionPopup+<>c__DisplayClass18_0+<<PlayPopup>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E533 RID: 58675 RVA: 0x0035B654 File Offset: 0x00359854
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique()
				{
					Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "<<PlayPopup>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr);
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<>1__state");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<>2__current");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<>4__this");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__paymentLerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<paymentLerpTime>5__2");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__satisfactionLerpTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<satisfactionLerpTime>5__3");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__endDelta_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<endDelta>5__4");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__lerpTime_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<lerpTime>5__5");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<i>5__6");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, 100680699);
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, 100680700);
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, 100680701);
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, 100680702);
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, 100680703);
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, 100680704);
				}

				// Token: 0x0600E534 RID: 58676 RVA: 0x0035B798 File Offset: 0x00359998
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E535 RID: 58677 RVA: 0x0035B7E0 File Offset: 0x003599E0
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E536 RID: 58678 RVA: 0x0035B814 File Offset: 0x00359A14
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256387, XrefRangeEnd = 256502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004744 RID: 18244
				// (get) Token: 0x0600E537 RID: 58679 RVA: 0x0035B850 File Offset: 0x00359A50
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E538 RID: 58680 RVA: 0x0035B890 File Offset: 0x00359A90
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256502, XrefRangeEnd = 256507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004745 RID: 18245
				// (get) Token: 0x0600E539 RID: 58681 RVA: 0x0035B8C4 File Offset: 0x00359AC4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E53A RID: 58682 RVA: 0x0006FC4D File Offset: 0x0006DE4D
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700473C RID: 18236
				// (get) Token: 0x0600E53B RID: 58683 RVA: 0x0035B904 File Offset: 0x00359B04
				// (set) Token: 0x0600E53C RID: 58684 RVA: 0x0006FC56 File Offset: 0x0006DE56
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700473D RID: 18237
				// (get) Token: 0x0600E53D RID: 58685 RVA: 0x0035B92C File Offset: 0x00359B2C
				// (set) Token: 0x0600E53E RID: 58686 RVA: 0x0006FC71 File Offset: 0x0006DE71
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700473E RID: 18238
				// (get) Token: 0x0600E53F RID: 58687 RVA: 0x0035B95C File Offset: 0x00359B5C
				// (set) Token: 0x0600E540 RID: 58688 RVA: 0x0006FC90 File Offset: 0x0006DE90
				public unsafe DealCompletionPopup.__c__DisplayClass18_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealCompletionPopup.__c__DisplayClass18_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700473F RID: 18239
				// (get) Token: 0x0600E541 RID: 58689 RVA: 0x0035B98C File Offset: 0x00359B8C
				// (set) Token: 0x0600E542 RID: 58690 RVA: 0x0006FCAF File Offset: 0x0006DEAF
				public unsafe float _paymentLerpTime_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__paymentLerpTime_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__paymentLerpTime_5__2)) = value;
					}
				}

				// Token: 0x17004740 RID: 18240
				// (get) Token: 0x0600E543 RID: 58691 RVA: 0x0035B9B4 File Offset: 0x00359BB4
				// (set) Token: 0x0600E544 RID: 58692 RVA: 0x0006FCCA File Offset: 0x0006DECA
				public unsafe float _satisfactionLerpTime_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__satisfactionLerpTime_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__satisfactionLerpTime_5__3)) = value;
					}
				}

				// Token: 0x17004741 RID: 18241
				// (get) Token: 0x0600E545 RID: 58693 RVA: 0x0035B9DC File Offset: 0x00359BDC
				// (set) Token: 0x0600E546 RID: 58694 RVA: 0x0006FCE5 File Offset: 0x0006DEE5
				public unsafe float _endDelta_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__endDelta_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__endDelta_5__4)) = value;
					}
				}

				// Token: 0x17004742 RID: 18242
				// (get) Token: 0x0600E547 RID: 58695 RVA: 0x0035BA04 File Offset: 0x00359C04
				// (set) Token: 0x0600E548 RID: 58696 RVA: 0x0006FD00 File Offset: 0x0006DF00
				public unsafe float _lerpTime_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__lerpTime_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__lerpTime_5__5)) = value;
					}
				}

				// Token: 0x17004743 RID: 18243
				// (get) Token: 0x0600E549 RID: 58697 RVA: 0x0035BA2C File Offset: 0x00359C2C
				// (set) Token: 0x0600E54A RID: 58698 RVA: 0x0006FD1B File Offset: 0x0006DF1B
				public unsafe float _i_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__i_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__i_5__6)) = value;
					}
				}

				// Token: 0x04009947 RID: 39239
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009948 RID: 39240
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009949 RID: 39241
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400994A RID: 39242
				private static readonly IntPtr NativeFieldInfoPtr__paymentLerpTime_5__2;

				// Token: 0x0400994B RID: 39243
				private static readonly IntPtr NativeFieldInfoPtr__satisfactionLerpTime_5__3;

				// Token: 0x0400994C RID: 39244
				private static readonly IntPtr NativeFieldInfoPtr__endDelta_5__4;

				// Token: 0x0400994D RID: 39245
				private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__5;

				// Token: 0x0400994E RID: 39246
				private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

				// Token: 0x0400994F RID: 39247
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009950 RID: 39248
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009951 RID: 39249
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009952 RID: 39250
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009953 RID: 39251
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009954 RID: 39252
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
