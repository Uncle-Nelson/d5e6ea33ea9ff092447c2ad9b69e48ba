using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Product;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200073A RID: 1850
	public class BrickPressContainer : MonoBehaviour
	{
		// Token: 0x0600A9DD RID: 43485 RVA: 0x002A6EC0 File Offset: 0x002A50C0
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressContainer()
		{
			Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "BrickPressContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr);
			BrickPressContainer.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, "Visuals");
			BrickPressContainer.NativeFieldInfoPtr_ContentsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, "ContentsContainer");
			BrickPressContainer.NativeFieldInfoPtr_Contents_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, "Contents_Min");
			BrickPressContainer.NativeFieldInfoPtr_Contents_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, "Contents_Max");
			BrickPressContainer.NativeMethodInfoPtr_SetContents_Public_Void_ProductItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, 100684140);
			BrickPressContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, 100684141);
		}

		// Token: 0x0600A9DE RID: 43486 RVA: 0x002A6F68 File Offset: 0x002A5168
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295565, RefRangeEnd = 295567, XrefRangeStart = 295555, XrefRangeEnd = 295565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContents(ProductItemInstance product, float fillLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressContainer.NativeMethodInfoPtr_SetContents_Public_Void_ProductItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9DF RID: 43487 RVA: 0x002A6FB8 File Offset: 0x002A51B8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9E0 RID: 43488 RVA: 0x0005392E File Offset: 0x00051B2E
		public BrickPressContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700347D RID: 13437
		// (get) Token: 0x0600A9E1 RID: 43489 RVA: 0x002A6FF4 File Offset: 0x002A51F4
		// (set) Token: 0x0600A9E2 RID: 43490 RVA: 0x00053937 File Offset: 0x00051B37
		public unsafe FilledPackagingVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700347E RID: 13438
		// (get) Token: 0x0600A9E3 RID: 43491 RVA: 0x002A7024 File Offset: 0x002A5224
		// (set) Token: 0x0600A9E4 RID: 43492 RVA: 0x00053956 File Offset: 0x00051B56
		public unsafe Transform ContentsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_ContentsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_ContentsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700347F RID: 13439
		// (get) Token: 0x0600A9E5 RID: 43493 RVA: 0x002A7054 File Offset: 0x002A5254
		// (set) Token: 0x0600A9E6 RID: 43494 RVA: 0x00053975 File Offset: 0x00051B75
		public unsafe Transform Contents_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Contents_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Contents_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003480 RID: 13440
		// (get) Token: 0x0600A9E7 RID: 43495 RVA: 0x002A7084 File Offset: 0x002A5284
		// (set) Token: 0x0600A9E8 RID: 43496 RVA: 0x00053994 File Offset: 0x00051B94
		public unsafe Transform Contents_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Contents_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Contents_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007215 RID: 29205
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04007216 RID: 29206
		private static readonly IntPtr NativeFieldInfoPtr_ContentsContainer;

		// Token: 0x04007217 RID: 29207
		private static readonly IntPtr NativeFieldInfoPtr_Contents_Min;

		// Token: 0x04007218 RID: 29208
		private static readonly IntPtr NativeFieldInfoPtr_Contents_Max;

		// Token: 0x04007219 RID: 29209
		private static readonly IntPtr NativeMethodInfoPtr_SetContents_Public_Void_ProductItemInstance_Single_0;

		// Token: 0x0400721A RID: 29210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
