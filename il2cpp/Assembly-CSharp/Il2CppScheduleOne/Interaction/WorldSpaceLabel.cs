using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Interaction
{
	// Token: 0x020003F5 RID: 1013
	public class WorldSpaceLabel : Il2CppSystem.Object
	{
		// Token: 0x0600542C RID: 21548 RVA: 0x0018B57C File Offset: 0x0018977C
		// Note: this type is marked as 'beforefieldinit'.
		static WorldSpaceLabel()
		{
			Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Interaction", "WorldSpaceLabel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr);
			WorldSpaceLabel.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "text");
			WorldSpaceLabel.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "color");
			WorldSpaceLabel.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "position");
			WorldSpaceLabel.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "scale");
			WorldSpaceLabel.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "rect");
			WorldSpaceLabel.NativeFieldInfoPtr_textComp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "textComp");
			WorldSpaceLabel.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "active");
			WorldSpaceLabel.NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, 100673794);
			WorldSpaceLabel.NativeMethodInfoPtr_RefreshDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, 100673795);
			WorldSpaceLabel.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, 100673796);
		}

		// Token: 0x0600542D RID: 21549 RVA: 0x0018B674 File Offset: 0x00189874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179918, RefRangeEnd = 179919, XrefRangeStart = 179878, XrefRangeEnd = 179918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldSpaceLabel(string _text, Vector3 _position) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceLabel.NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600542E RID: 21550 RVA: 0x0018B6D0 File Offset: 0x001898D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 179948, RefRangeEnd = 179950, XrefRangeStart = 179919, XrefRangeEnd = 179948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceLabel.NativeMethodInfoPtr_RefreshDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600542F RID: 21551 RVA: 0x0018B704 File Offset: 0x00189904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179965, RefRangeEnd = 179966, XrefRangeStart = 179950, XrefRangeEnd = 179965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceLabel.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005430 RID: 21552 RVA: 0x0002842C File Offset: 0x0002662C
		public WorldSpaceLabel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x06005431 RID: 21553 RVA: 0x0018B738 File Offset: 0x00189938
		// (set) Token: 0x06005432 RID: 21554 RVA: 0x00028435 File Offset: 0x00026635
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x06005433 RID: 21555 RVA: 0x0018B760 File Offset: 0x00189960
		// (set) Token: 0x06005434 RID: 21556 RVA: 0x00028454 File Offset: 0x00026654
		public unsafe Color32 color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x06005435 RID: 21557 RVA: 0x0018B788 File Offset: 0x00189988
		// (set) Token: 0x06005436 RID: 21558 RVA: 0x0002846F File Offset: 0x0002666F
		public unsafe Vector3 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x06005437 RID: 21559 RVA: 0x0018B7B0 File Offset: 0x001899B0
		// (set) Token: 0x06005438 RID: 21560 RVA: 0x0002848A File Offset: 0x0002668A
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x06005439 RID: 21561 RVA: 0x0018B7D8 File Offset: 0x001899D8
		// (set) Token: 0x0600543A RID: 21562 RVA: 0x000284A5 File Offset: 0x000266A5
		public unsafe RectTransform rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x0600543B RID: 21563 RVA: 0x0018B808 File Offset: 0x00189A08
		// (set) Token: 0x0600543C RID: 21564 RVA: 0x000284C4 File Offset: 0x000266C4
		public unsafe Text textComp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_textComp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_textComp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x0600543D RID: 21565 RVA: 0x0018B838 File Offset: 0x00189A38
		// (set) Token: 0x0600543E RID: 21566 RVA: 0x000284E3 File Offset: 0x000266E3
		public unsafe bool active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_active)) = value;
			}
		}

		// Token: 0x0400390A RID: 14602
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400390B RID: 14603
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400390C RID: 14604
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x0400390D RID: 14605
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x0400390E RID: 14606
		private static readonly IntPtr NativeFieldInfoPtr_rect;

		// Token: 0x0400390F RID: 14607
		private static readonly IntPtr NativeFieldInfoPtr_textComp;

		// Token: 0x04003910 RID: 14608
		private static readonly IntPtr NativeFieldInfoPtr_active;

		// Token: 0x04003911 RID: 14609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_0;

		// Token: 0x04003912 RID: 14610
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDisplay_Public_Void_0;

		// Token: 0x04003913 RID: 14611
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;
	}
}
