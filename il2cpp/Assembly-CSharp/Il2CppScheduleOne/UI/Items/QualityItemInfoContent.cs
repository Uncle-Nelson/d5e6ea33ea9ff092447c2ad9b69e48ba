using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppTMPro;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200071C RID: 1820
	public class QualityItemInfoContent : ItemInfoContent
	{
		// Token: 0x0600A3CD RID: 41933 RVA: 0x00291558 File Offset: 0x0028F758
		// Note: this type is marked as 'beforefieldinit'.
		static QualityItemInfoContent()
		{
			Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "QualityItemInfoContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr);
			QualityItemInfoContent.NativeFieldInfoPtr_Star = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr, "Star");
			QualityItemInfoContent.NativeFieldInfoPtr_QualityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr, "QualityLabel");
			QualityItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr, 100683323);
			QualityItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr, 100683324);
		}

		// Token: 0x0600A3CE RID: 41934 RVA: 0x002915D8 File Offset: 0x0028F7D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286843, RefRangeEnd = 286844, XrefRangeStart = 286829, XrefRangeEnd = 286843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3CF RID: 41935 RVA: 0x00291628 File Offset: 0x0028F828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemInfoContent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3D0 RID: 41936 RVA: 0x00050B03 File Offset: 0x0004ED03
		public QualityItemInfoContent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003287 RID: 12935
		// (get) Token: 0x0600A3D1 RID: 41937 RVA: 0x00291664 File Offset: 0x0028F864
		// (set) Token: 0x0600A3D2 RID: 41938 RVA: 0x00050B0C File Offset: 0x0004ED0C
		public unsafe Image Star
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInfoContent.NativeFieldInfoPtr_Star);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInfoContent.NativeFieldInfoPtr_Star), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003288 RID: 12936
		// (get) Token: 0x0600A3D3 RID: 41939 RVA: 0x00291694 File Offset: 0x0028F894
		// (set) Token: 0x0600A3D4 RID: 41940 RVA: 0x00050B2B File Offset: 0x0004ED2B
		public unsafe TextMeshProUGUI QualityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInfoContent.NativeFieldInfoPtr_QualityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInfoContent.NativeFieldInfoPtr_QualityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006DD6 RID: 28118
		private static readonly IntPtr NativeFieldInfoPtr_Star;

		// Token: 0x04006DD7 RID: 28119
		private static readonly IntPtr NativeFieldInfoPtr_QualityLabel;

		// Token: 0x04006DD8 RID: 28120
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006DD9 RID: 28121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
