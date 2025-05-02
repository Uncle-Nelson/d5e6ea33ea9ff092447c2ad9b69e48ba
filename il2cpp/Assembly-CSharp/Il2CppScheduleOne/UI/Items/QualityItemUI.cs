using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200071D RID: 1821
	public class QualityItemUI : ItemUI
	{
		// Token: 0x0600A3D5 RID: 41941 RVA: 0x002916C4 File Offset: 0x0028F8C4
		// Note: this type is marked as 'beforefieldinit'.
		static QualityItemUI()
		{
			Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "QualityItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr);
			QualityItemUI.NativeFieldInfoPtr_QualityIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, "QualityIcon");
			QualityItemUI.NativeFieldInfoPtr_qualityItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, "qualityItemInstance");
			QualityItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, 100683325);
			QualityItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, 100683326);
			QualityItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, 100683327);
		}

		// Token: 0x0600A3D6 RID: 41942 RVA: 0x00291758 File Offset: 0x0028F958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286844, XrefRangeEnd = 286852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3D7 RID: 41943 RVA: 0x002917A8 File Offset: 0x0028F9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286852, XrefRangeEnd = 286858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3D8 RID: 41944 RVA: 0x002917E4 File Offset: 0x0028F9E4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3D9 RID: 41945 RVA: 0x00050B4A File Offset: 0x0004ED4A
		public QualityItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003289 RID: 12937
		// (get) Token: 0x0600A3DA RID: 41946 RVA: 0x00291820 File Offset: 0x0028FA20
		// (set) Token: 0x0600A3DB RID: 41947 RVA: 0x00050B53 File Offset: 0x0004ED53
		public unsafe Image QualityIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemUI.NativeFieldInfoPtr_QualityIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemUI.NativeFieldInfoPtr_QualityIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700328A RID: 12938
		// (get) Token: 0x0600A3DC RID: 41948 RVA: 0x00291850 File Offset: 0x0028FA50
		// (set) Token: 0x0600A3DD RID: 41949 RVA: 0x00050B72 File Offset: 0x0004ED72
		public unsafe QualityItemInstance qualityItemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemUI.NativeFieldInfoPtr_qualityItemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemUI.NativeFieldInfoPtr_qualityItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006DDA RID: 28122
		private static readonly IntPtr NativeFieldInfoPtr_QualityIcon;

		// Token: 0x04006DDB RID: 28123
		private static readonly IntPtr NativeFieldInfoPtr_qualityItemInstance;

		// Token: 0x04006DDC RID: 28124
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006DDD RID: 28125
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04006DDE RID: 28126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
