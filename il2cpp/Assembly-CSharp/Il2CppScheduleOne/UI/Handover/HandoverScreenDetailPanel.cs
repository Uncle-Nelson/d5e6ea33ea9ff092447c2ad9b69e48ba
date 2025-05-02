using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Handover
{
	// Token: 0x020006F4 RID: 1780
	public class HandoverScreenDetailPanel : MonoBehaviour
	{
		// Token: 0x06009F7A RID: 40826 RVA: 0x00283960 File Offset: 0x00281B60
		// Note: this type is marked as 'beforefieldinit'.
		static HandoverScreenDetailPanel()
		{
			Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Handover", "HandoverScreenDetailPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr);
			HandoverScreenDetailPanel.NativeFieldInfoPtr_LayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "LayoutGroup");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "Container");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "NameLabel");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "RelationshipContainer");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "RelationshipScrollbar");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_AddictionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "AddictionContainer");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_AdditionScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "AdditionScrollbar");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsStar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "StandardsStar");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "StandardsLabel");
			HandoverScreenDetailPanel.NativeFieldInfoPtr_EffectsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, "EffectsLabel");
			HandoverScreenDetailPanel.NativeMethodInfoPtr_Open_Public_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, 100682825);
			HandoverScreenDetailPanel.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, 100682826);
			HandoverScreenDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr, 100682827);
		}

		// Token: 0x06009F7B RID: 40827 RVA: 0x00283A94 File Offset: 0x00281C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281709, XrefRangeEnd = 281774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenDetailPanel.NativeMethodInfoPtr_Open_Public_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F7C RID: 40828 RVA: 0x00283AD8 File Offset: 0x00281CD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194914, RefRangeEnd = 194915, XrefRangeStart = 194914, XrefRangeEnd = 194915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenDetailPanel.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F7D RID: 40829 RVA: 0x00283B0C File Offset: 0x00281D0C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandoverScreenDetailPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandoverScreenDetailPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F7E RID: 40830 RVA: 0x0004E525 File Offset: 0x0004C725
		public HandoverScreenDetailPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700311E RID: 12574
		// (get) Token: 0x06009F7F RID: 40831 RVA: 0x00283B48 File Offset: 0x00281D48
		// (set) Token: 0x06009F80 RID: 40832 RVA: 0x0004E52E File Offset: 0x0004C72E
		public unsafe LayoutGroup LayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_LayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_LayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700311F RID: 12575
		// (get) Token: 0x06009F81 RID: 40833 RVA: 0x00283B78 File Offset: 0x00281D78
		// (set) Token: 0x06009F82 RID: 40834 RVA: 0x0004E54D File Offset: 0x0004C74D
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003120 RID: 12576
		// (get) Token: 0x06009F83 RID: 40835 RVA: 0x00283BA8 File Offset: 0x00281DA8
		// (set) Token: 0x06009F84 RID: 40836 RVA: 0x0004E56C File Offset: 0x0004C76C
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003121 RID: 12577
		// (get) Token: 0x06009F85 RID: 40837 RVA: 0x00283BD8 File Offset: 0x00281DD8
		// (set) Token: 0x06009F86 RID: 40838 RVA: 0x0004E58B File Offset: 0x0004C78B
		public unsafe RectTransform RelationshipContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003122 RID: 12578
		// (get) Token: 0x06009F87 RID: 40839 RVA: 0x00283C08 File Offset: 0x00281E08
		// (set) Token: 0x06009F88 RID: 40840 RVA: 0x0004E5AA File Offset: 0x0004C7AA
		public unsafe Scrollbar RelationshipScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003123 RID: 12579
		// (get) Token: 0x06009F89 RID: 40841 RVA: 0x00283C38 File Offset: 0x00281E38
		// (set) Token: 0x06009F8A RID: 40842 RVA: 0x0004E5C9 File Offset: 0x0004C7C9
		public unsafe RectTransform AddictionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_AddictionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_AddictionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003124 RID: 12580
		// (get) Token: 0x06009F8B RID: 40843 RVA: 0x00283C68 File Offset: 0x00281E68
		// (set) Token: 0x06009F8C RID: 40844 RVA: 0x0004E5E8 File Offset: 0x0004C7E8
		public unsafe Scrollbar AdditionScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_AdditionScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_AdditionScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003125 RID: 12581
		// (get) Token: 0x06009F8D RID: 40845 RVA: 0x00283C98 File Offset: 0x00281E98
		// (set) Token: 0x06009F8E RID: 40846 RVA: 0x0004E607 File Offset: 0x0004C807
		public unsafe Image StandardsStar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsStar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsStar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003126 RID: 12582
		// (get) Token: 0x06009F8F RID: 40847 RVA: 0x00283CC8 File Offset: 0x00281EC8
		// (set) Token: 0x06009F90 RID: 40848 RVA: 0x0004E626 File Offset: 0x0004C826
		public unsafe TextMeshProUGUI StandardsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_StandardsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003127 RID: 12583
		// (get) Token: 0x06009F91 RID: 40849 RVA: 0x00283CF8 File Offset: 0x00281EF8
		// (set) Token: 0x06009F92 RID: 40850 RVA: 0x0004E645 File Offset: 0x0004C845
		public unsafe TextMeshProUGUI EffectsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_EffectsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenDetailPanel.NativeFieldInfoPtr_EffectsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006AFA RID: 27386
		private static readonly IntPtr NativeFieldInfoPtr_LayoutGroup;

		// Token: 0x04006AFB RID: 27387
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006AFC RID: 27388
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04006AFD RID: 27389
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipContainer;

		// Token: 0x04006AFE RID: 27390
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipScrollbar;

		// Token: 0x04006AFF RID: 27391
		private static readonly IntPtr NativeFieldInfoPtr_AddictionContainer;

		// Token: 0x04006B00 RID: 27392
		private static readonly IntPtr NativeFieldInfoPtr_AdditionScrollbar;

		// Token: 0x04006B01 RID: 27393
		private static readonly IntPtr NativeFieldInfoPtr_StandardsStar;

		// Token: 0x04006B02 RID: 27394
		private static readonly IntPtr NativeFieldInfoPtr_StandardsLabel;

		// Token: 0x04006B03 RID: 27395
		private static readonly IntPtr NativeFieldInfoPtr_EffectsLabel;

		// Token: 0x04006B04 RID: 27396
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_Customer_0;

		// Token: 0x04006B05 RID: 27397
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006B06 RID: 27398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
