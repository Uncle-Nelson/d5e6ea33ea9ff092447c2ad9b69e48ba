using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.Input;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000671 RID: 1649
	public class TrashBagCanvas : Singleton<TrashBagCanvas>
	{
		// Token: 0x06009329 RID: 37673 RVA: 0x0025E680 File Offset: 0x0025C880
		// Note: this type is marked as 'beforefieldinit'.
		static TrashBagCanvas()
		{
			Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "TrashBagCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr);
			TrashBagCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, "<IsOpen>k__BackingField");
			TrashBagCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, "Canvas");
			TrashBagCanvas.NativeFieldInfoPtr_InputPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, "InputPrompt");
			TrashBagCanvas.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100681539);
			TrashBagCanvas.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100681540);
			TrashBagCanvas.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100681541);
			TrashBagCanvas.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100681542);
			TrashBagCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100681543);
		}

		// Token: 0x17002D20 RID: 11552
		// (get) Token: 0x0600932A RID: 37674 RVA: 0x0025E750 File Offset: 0x0025C950
		// (set) Token: 0x0600932B RID: 37675 RVA: 0x0025E78C File Offset: 0x0025C98C
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600932C RID: 37676 RVA: 0x0025E7CC File Offset: 0x0025C9CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265324, RefRangeEnd = 265325, XrefRangeStart = 265322, XrefRangeEnd = 265324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600932D RID: 37677 RVA: 0x0025E800 File Offset: 0x0025CA00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265327, RefRangeEnd = 265328, XrefRangeStart = 265325, XrefRangeEnd = 265327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600932E RID: 37678 RVA: 0x0025E834 File Offset: 0x0025CA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265328, XrefRangeEnd = 265331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashBagCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600932F RID: 37679 RVA: 0x00047491 File Offset: 0x00045691
		public TrashBagCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D1D RID: 11549
		// (get) Token: 0x06009330 RID: 37680 RVA: 0x0025E870 File Offset: 0x0025CA70
		// (set) Token: 0x06009331 RID: 37681 RVA: 0x0004749A File Offset: 0x0004569A
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D1E RID: 11550
		// (get) Token: 0x06009332 RID: 37682 RVA: 0x0025E898 File Offset: 0x0025CA98
		// (set) Token: 0x06009333 RID: 37683 RVA: 0x000474B5 File Offset: 0x000456B5
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D1F RID: 11551
		// (get) Token: 0x06009334 RID: 37684 RVA: 0x0025E8C8 File Offset: 0x0025CAC8
		// (set) Token: 0x06009335 RID: 37685 RVA: 0x000474D4 File Offset: 0x000456D4
		public unsafe InputPrompt InputPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr_InputPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr_InputPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400635B RID: 25435
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400635C RID: 25436
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400635D RID: 25437
		private static readonly IntPtr NativeFieldInfoPtr_InputPrompt;

		// Token: 0x0400635E RID: 25438
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400635F RID: 25439
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006360 RID: 25440
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006361 RID: 25441
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006362 RID: 25442
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
