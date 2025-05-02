using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Tooltips
{
	// Token: 0x02000679 RID: 1657
	public class Tooltip : MonoBehaviour
	{
		// Token: 0x060093F4 RID: 37876 RVA: 0x00260ACC File Offset: 0x0025ECCC
		// Note: this type is marked as 'beforefieldinit'.
		static Tooltip()
		{
			Il2CppClassPointerStore<Tooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Tooltips", "Tooltip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tooltip>.NativeClassPtr);
			Tooltip.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "text");
			Tooltip.NativeFieldInfoPtr_labelOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "labelOffset");
			Tooltip.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "rect");
			Tooltip.NativeFieldInfoPtr__isWorldspace_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "<isWorldspace>k__BackingField");
			Tooltip.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "canvas");
			Tooltip.NativeMethodInfoPtr_get_labelPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100681628);
			Tooltip.NativeMethodInfoPtr_get_isWorldspace_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100681629);
			Tooltip.NativeMethodInfoPtr_set_isWorldspace_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100681630);
			Tooltip.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100681631);
			Tooltip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100681632);
		}

		// Token: 0x17002D65 RID: 11621
		// (get) Token: 0x060093F5 RID: 37877 RVA: 0x00260BC4 File Offset: 0x0025EDC4
		public unsafe Vector3 labelPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 266307, RefRangeEnd = 266308, XrefRangeStart = 266304, XrefRangeEnd = 266307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tooltip.NativeMethodInfoPtr_get_labelPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002D66 RID: 11622
		// (get) Token: 0x060093F6 RID: 37878 RVA: 0x00260C00 File Offset: 0x0025EE00
		// (set) Token: 0x060093F7 RID: 37879 RVA: 0x00260C3C File Offset: 0x0025EE3C
		public unsafe bool isWorldspace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tooltip.NativeMethodInfoPtr_get_isWorldspace_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tooltip.NativeMethodInfoPtr_set_isWorldspace_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060093F8 RID: 37880 RVA: 0x00260C7C File Offset: 0x0025EE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266308, XrefRangeEnd = 266333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tooltip.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093F9 RID: 37881 RVA: 0x00260CB8 File Offset: 0x0025EEB8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tooltip() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tooltip>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tooltip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093FA RID: 37882 RVA: 0x00047C1D File Offset: 0x00045E1D
		public Tooltip(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D60 RID: 11616
		// (get) Token: 0x060093FB RID: 37883 RVA: 0x00260CF4 File Offset: 0x0025EEF4
		// (set) Token: 0x060093FC RID: 37884 RVA: 0x00047C26 File Offset: 0x00045E26
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002D61 RID: 11617
		// (get) Token: 0x060093FD RID: 37885 RVA: 0x00260D1C File Offset: 0x0025EF1C
		// (set) Token: 0x060093FE RID: 37886 RVA: 0x00047C45 File Offset: 0x00045E45
		public unsafe Vector2 labelOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_labelOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_labelOffset)) = value;
			}
		}

		// Token: 0x17002D62 RID: 11618
		// (get) Token: 0x060093FF RID: 37887 RVA: 0x00260D44 File Offset: 0x0025EF44
		// (set) Token: 0x06009400 RID: 37888 RVA: 0x00047C60 File Offset: 0x00045E60
		public unsafe RectTransform rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D63 RID: 11619
		// (get) Token: 0x06009401 RID: 37889 RVA: 0x00260D74 File Offset: 0x0025EF74
		// (set) Token: 0x06009402 RID: 37890 RVA: 0x00047C7F File Offset: 0x00045E7F
		public unsafe bool _isWorldspace_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr__isWorldspace_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr__isWorldspace_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D64 RID: 11620
		// (get) Token: 0x06009403 RID: 37891 RVA: 0x00260D9C File Offset: 0x0025EF9C
		// (set) Token: 0x06009404 RID: 37892 RVA: 0x00047C9A File Offset: 0x00045E9A
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040063D6 RID: 25558
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040063D7 RID: 25559
		private static readonly IntPtr NativeFieldInfoPtr_labelOffset;

		// Token: 0x040063D8 RID: 25560
		private static readonly IntPtr NativeFieldInfoPtr_rect;

		// Token: 0x040063D9 RID: 25561
		private static readonly IntPtr NativeFieldInfoPtr__isWorldspace_k__BackingField;

		// Token: 0x040063DA RID: 25562
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x040063DB RID: 25563
		private static readonly IntPtr NativeMethodInfoPtr_get_labelPosition_Public_get_Vector3_0;

		// Token: 0x040063DC RID: 25564
		private static readonly IntPtr NativeMethodInfoPtr_get_isWorldspace_Public_get_Boolean_0;

		// Token: 0x040063DD RID: 25565
		private static readonly IntPtr NativeMethodInfoPtr_set_isWorldspace_Private_set_Void_Boolean_0;

		// Token: 0x040063DE RID: 25566
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040063DF RID: 25567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
