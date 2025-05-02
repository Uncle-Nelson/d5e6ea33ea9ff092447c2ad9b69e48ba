using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.WorldspacePopup
{
	// Token: 0x02000678 RID: 1656
	public class WorldspacePopupUI : MonoBehaviour
	{
		// Token: 0x060093E7 RID: 37863 RVA: 0x002608A0 File Offset: 0x0025EAA0
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspacePopupUI()
		{
			Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.WorldspacePopup", "WorldspacePopupUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr);
			WorldspacePopupUI.NativeFieldInfoPtr_Popup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, "Popup");
			WorldspacePopupUI.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, "Rect");
			WorldspacePopupUI.NativeFieldInfoPtr_FillImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, "FillImage");
			WorldspacePopupUI.NativeFieldInfoPtr_onDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, "onDestroyed");
			WorldspacePopupUI.NativeMethodInfoPtr_SetFill_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, 100681625);
			WorldspacePopupUI.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, 100681626);
			WorldspacePopupUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, 100681627);
		}

		// Token: 0x060093E8 RID: 37864 RVA: 0x0026095C File Offset: 0x0025EB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266293, XrefRangeEnd = 266295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFill(float fill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fill;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupUI.NativeMethodInfoPtr_SetFill_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093E9 RID: 37865 RVA: 0x0026099C File Offset: 0x0025EB9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 266301, RefRangeEnd = 266304, XrefRangeStart = 266295, XrefRangeEnd = 266301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupUI.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093EA RID: 37866 RVA: 0x002609D0 File Offset: 0x0025EBD0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopupUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093EB RID: 37867 RVA: 0x00047B98 File Offset: 0x00045D98
		public WorldspacePopupUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D5C RID: 11612
		// (get) Token: 0x060093EC RID: 37868 RVA: 0x00260A0C File Offset: 0x0025EC0C
		// (set) Token: 0x060093ED RID: 37869 RVA: 0x00047BA1 File Offset: 0x00045DA1
		public unsafe WorldspacePopup Popup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_Popup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_Popup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D5D RID: 11613
		// (get) Token: 0x060093EE RID: 37870 RVA: 0x00260A3C File Offset: 0x0025EC3C
		// (set) Token: 0x060093EF RID: 37871 RVA: 0x00047BC0 File Offset: 0x00045DC0
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D5E RID: 11614
		// (get) Token: 0x060093F0 RID: 37872 RVA: 0x00260A6C File Offset: 0x0025EC6C
		// (set) Token: 0x060093F1 RID: 37873 RVA: 0x00047BDF File Offset: 0x00045DDF
		public unsafe Image FillImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_FillImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_FillImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D5F RID: 11615
		// (get) Token: 0x060093F2 RID: 37874 RVA: 0x00260A9C File Offset: 0x0025EC9C
		// (set) Token: 0x060093F3 RID: 37875 RVA: 0x00047BFE File Offset: 0x00045DFE
		public unsafe UnityEvent onDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_onDestroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_onDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040063CF RID: 25551
		private static readonly IntPtr NativeFieldInfoPtr_Popup;

		// Token: 0x040063D0 RID: 25552
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040063D1 RID: 25553
		private static readonly IntPtr NativeFieldInfoPtr_FillImage;

		// Token: 0x040063D2 RID: 25554
		private static readonly IntPtr NativeFieldInfoPtr_onDestroyed;

		// Token: 0x040063D3 RID: 25555
		private static readonly IntPtr NativeMethodInfoPtr_SetFill_Public_Void_Single_0;

		// Token: 0x040063D4 RID: 25556
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x040063D5 RID: 25557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
