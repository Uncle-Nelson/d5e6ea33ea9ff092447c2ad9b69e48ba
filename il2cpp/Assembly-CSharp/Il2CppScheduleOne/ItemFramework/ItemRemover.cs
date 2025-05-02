using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005E9 RID: 1513
	public class ItemRemover : MonoBehaviour
	{
		// Token: 0x06008417 RID: 33815 RVA: 0x002311B0 File Offset: 0x0022F3B0
		// Note: this type is marked as 'beforefieldinit'.
		static ItemRemover()
		{
			Il2CppClassPointerStore<ItemRemover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemRemover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr);
			ItemRemover.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr, "Item");
			ItemRemover.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr, "Quantity");
			ItemRemover.NativeMethodInfoPtr_Remove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr, 100679810);
			ItemRemover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr, 100679811);
		}

		// Token: 0x06008418 RID: 33816 RVA: 0x00231230 File Offset: 0x0022F430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248126, XrefRangeEnd = 248132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemRemover.NativeMethodInfoPtr_Remove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008419 RID: 33817 RVA: 0x00231264 File Offset: 0x0022F464
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemRemover() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemRemover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600841A RID: 33818 RVA: 0x0003EB88 File Offset: 0x0003CD88
		public ItemRemover(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027F4 RID: 10228
		// (get) Token: 0x0600841B RID: 33819 RVA: 0x002312A0 File Offset: 0x0022F4A0
		// (set) Token: 0x0600841C RID: 33820 RVA: 0x0003EB91 File Offset: 0x0003CD91
		public unsafe ItemDefinition Item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemRemover.NativeFieldInfoPtr_Item);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemRemover.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F5 RID: 10229
		// (get) Token: 0x0600841D RID: 33821 RVA: 0x002312D0 File Offset: 0x0022F4D0
		// (set) Token: 0x0600841E RID: 33822 RVA: 0x0003EBB0 File Offset: 0x0003CDB0
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemRemover.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemRemover.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x040059E9 RID: 23017
		private static readonly IntPtr NativeFieldInfoPtr_Item;

		// Token: 0x040059EA RID: 23018
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x040059EB RID: 23019
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_0;

		// Token: 0x040059EC RID: 23020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
