using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x0200059E RID: 1438
	[Serializable]
	public class PropertyContainer : Object
	{
		// Token: 0x06007DFE RID: 32254 RVA: 0x0021B98C File Offset: 0x00219B8C
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyContainer()
		{
			Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "PropertyContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr);
			PropertyContainer.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr, "Property");
			PropertyContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr, 100679050);
		}

		// Token: 0x06007DFF RID: 32255 RVA: 0x0021B9E4 File Offset: 0x00219BE4
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E00 RID: 32256 RVA: 0x0003BE23 File Offset: 0x0003A023
		public PropertyContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002620 RID: 9760
		// (get) Token: 0x06007E01 RID: 32257 RVA: 0x0021BA20 File Offset: 0x00219C20
		// (set) Token: 0x06007E02 RID: 32258 RVA: 0x0003BE2C File Offset: 0x0003A02C
		public unsafe EProperty Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyContainer.NativeFieldInfoPtr_Property);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyContainer.NativeFieldInfoPtr_Property)) = value;
			}
		}

		// Token: 0x040055C4 RID: 21956
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x040055C5 RID: 21957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
