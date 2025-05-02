using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000647 RID: 1607
	public class ItemSelectorButtonLink : MonoBehaviour
	{
		// Token: 0x06008E3F RID: 36415 RVA: 0x0004462D File Offset: 0x0004282D
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSelectorButtonLink()
		{
			Il2CppClassPointerStore<ItemSelectorButtonLink>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ItemSelectorButtonLink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSelectorButtonLink>.NativeClassPtr);
			ItemSelectorButtonLink.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelectorButtonLink>.NativeClassPtr, 100680957);
		}

		// Token: 0x06008E40 RID: 36416 RVA: 0x00250118 File Offset: 0x0024E318
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSelectorButtonLink() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSelectorButtonLink>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelectorButtonLink.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E41 RID: 36417 RVA: 0x00044666 File Offset: 0x00042866
		public ItemSelectorButtonLink(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04006050 RID: 24656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
