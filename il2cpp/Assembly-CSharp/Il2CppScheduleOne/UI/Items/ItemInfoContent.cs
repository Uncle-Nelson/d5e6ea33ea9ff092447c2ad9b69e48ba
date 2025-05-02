using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000717 RID: 1815
	public class ItemInfoContent : MonoBehaviour
	{
		// Token: 0x0600A336 RID: 41782 RVA: 0x0028F860 File Offset: 0x0028DA60
		// Note: this type is marked as 'beforefieldinit'.
		static ItemInfoContent()
		{
			Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemInfoContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr);
			ItemInfoContent.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, "Height");
			ItemInfoContent.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, "NameLabel");
			ItemInfoContent.NativeFieldInfoPtr_DescriptionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, "DescriptionLabel");
			ItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, 100683268);
			ItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, 100683269);
			ItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, 100683270);
		}

		// Token: 0x0600A337 RID: 41783 RVA: 0x0028F908 File Offset: 0x0028DB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285995, XrefRangeEnd = 285996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A338 RID: 41784 RVA: 0x0028F958 File Offset: 0x0028DB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285996, XrefRangeEnd = 285997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ItemDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A339 RID: 41785 RVA: 0x0028F9A8 File Offset: 0x0028DBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285997, XrefRangeEnd = 285998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInfoContent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A33A RID: 41786 RVA: 0x00050566 File Offset: 0x0004E766
		public ItemInfoContent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003253 RID: 12883
		// (get) Token: 0x0600A33B RID: 41787 RVA: 0x0028F9E4 File Offset: 0x0028DBE4
		// (set) Token: 0x0600A33C RID: 41788 RVA: 0x0005056F File Offset: 0x0004E76F
		public unsafe float Height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_Height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_Height)) = value;
			}
		}

		// Token: 0x17003254 RID: 12884
		// (get) Token: 0x0600A33D RID: 41789 RVA: 0x0028FA0C File Offset: 0x0028DC0C
		// (set) Token: 0x0600A33E RID: 41790 RVA: 0x0005058A File Offset: 0x0004E78A
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003255 RID: 12885
		// (get) Token: 0x0600A33F RID: 41791 RVA: 0x0028FA3C File Offset: 0x0028DC3C
		// (set) Token: 0x0600A340 RID: 41792 RVA: 0x000505A9 File Offset: 0x0004E7A9
		public unsafe TextMeshProUGUI DescriptionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_DescriptionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_DescriptionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D78 RID: 28024
		private static readonly IntPtr NativeFieldInfoPtr_Height;

		// Token: 0x04006D79 RID: 28025
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04006D7A RID: 28026
		private static readonly IntPtr NativeFieldInfoPtr_DescriptionLabel;

		// Token: 0x04006D7B RID: 28027
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04006D7C RID: 28028
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemDefinition_0;

		// Token: 0x04006D7D RID: 28029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
