using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006D4 RID: 1748
	public class SelectionInfoUI : MonoBehaviour
	{
		// Token: 0x06009D49 RID: 40265 RVA: 0x0027CCBC File Offset: 0x0027AEBC
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionInfoUI()
		{
			Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "SelectionInfoUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr);
			SelectionInfoUI.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "Icon");
			SelectionInfoUI.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "Title");
			SelectionInfoUI.NativeFieldInfoPtr_SelfUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "SelfUpdate");
			SelectionInfoUI.NativeFieldInfoPtr_NonUniformTypeSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "NonUniformTypeSprite");
			SelectionInfoUI.NativeFieldInfoPtr_CrossSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "CrossSprite");
			SelectionInfoUI.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, 100682598);
			SelectionInfoUI.NativeMethodInfoPtr_Set_Public_Void_List_1_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, 100682599);
			SelectionInfoUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, 100682600);
		}

		// Token: 0x06009D4A RID: 40266 RVA: 0x0027CD8C File Offset: 0x0027AF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279363, XrefRangeEnd = 279390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionInfoUI.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D4B RID: 40267 RVA: 0x0027CDC0 File Offset: 0x0027AFC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279423, RefRangeEnd = 279425, XrefRangeStart = 279390, XrefRangeEnd = 279423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(List<IConfigurable> Configurables)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(Configurables);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionInfoUI.NativeMethodInfoPtr_Set_Public_Void_List_1_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D4C RID: 40268 RVA: 0x0027CE04 File Offset: 0x0027B004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279425, XrefRangeEnd = 279426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionInfoUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionInfoUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D4D RID: 40269 RVA: 0x0004D292 File Offset: 0x0004B492
		public SelectionInfoUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003070 RID: 12400
		// (get) Token: 0x06009D4E RID: 40270 RVA: 0x0027CE40 File Offset: 0x0027B040
		// (set) Token: 0x06009D4F RID: 40271 RVA: 0x0004D29B File Offset: 0x0004B49B
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003071 RID: 12401
		// (get) Token: 0x06009D50 RID: 40272 RVA: 0x0027CE70 File Offset: 0x0027B070
		// (set) Token: 0x06009D51 RID: 40273 RVA: 0x0004D2BA File Offset: 0x0004B4BA
		public unsafe TextMeshProUGUI Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003072 RID: 12402
		// (get) Token: 0x06009D52 RID: 40274 RVA: 0x0027CEA0 File Offset: 0x0027B0A0
		// (set) Token: 0x06009D53 RID: 40275 RVA: 0x0004D2D9 File Offset: 0x0004B4D9
		public unsafe bool SelfUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_SelfUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_SelfUpdate)) = value;
			}
		}

		// Token: 0x17003073 RID: 12403
		// (get) Token: 0x06009D54 RID: 40276 RVA: 0x0027CEC8 File Offset: 0x0027B0C8
		// (set) Token: 0x06009D55 RID: 40277 RVA: 0x0004D2F4 File Offset: 0x0004B4F4
		public unsafe Sprite NonUniformTypeSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_NonUniformTypeSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_NonUniformTypeSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003074 RID: 12404
		// (get) Token: 0x06009D56 RID: 40278 RVA: 0x0027CEF8 File Offset: 0x0027B0F8
		// (set) Token: 0x06009D57 RID: 40279 RVA: 0x0004D313 File Offset: 0x0004B513
		public unsafe Sprite CrossSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_CrossSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_CrossSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069A1 RID: 27041
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x040069A2 RID: 27042
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x040069A3 RID: 27043
		private static readonly IntPtr NativeFieldInfoPtr_SelfUpdate;

		// Token: 0x040069A4 RID: 27044
		private static readonly IntPtr NativeFieldInfoPtr_NonUniformTypeSprite;

		// Token: 0x040069A5 RID: 27045
		private static readonly IntPtr NativeFieldInfoPtr_CrossSprite;

		// Token: 0x040069A6 RID: 27046
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040069A7 RID: 27047
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_List_1_IConfigurable_0;

		// Token: 0x040069A8 RID: 27048
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
