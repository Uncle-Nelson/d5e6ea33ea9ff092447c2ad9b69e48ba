using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x02000510 RID: 1296
	public class PropertyContentsContainer : MonoBehaviour
	{
		// Token: 0x06007341 RID: 29505 RVA: 0x001F75D0 File Offset: 0x001F57D0
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyContentsContainer()
		{
			Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "PropertyContentsContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr);
			PropertyContentsContainer.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr, "Property");
			PropertyContentsContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr, 100677768);
		}

		// Token: 0x06007342 RID: 29506 RVA: 0x001F7628 File Offset: 0x001F5828
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyContentsContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyContentsContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007343 RID: 29507 RVA: 0x00036D1B File Offset: 0x00034F1B
		public PropertyContentsContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022F5 RID: 8949
		// (get) Token: 0x06007344 RID: 29508 RVA: 0x001F7664 File Offset: 0x001F5864
		// (set) Token: 0x06007345 RID: 29509 RVA: 0x00036D24 File Offset: 0x00034F24
		public unsafe Property Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyContentsContainer.NativeFieldInfoPtr_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyContentsContainer.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004EAD RID: 20141
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x04004EAE RID: 20142
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
