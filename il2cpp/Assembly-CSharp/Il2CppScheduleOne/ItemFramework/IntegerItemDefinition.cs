using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005E0 RID: 1504
	[Serializable]
	public class IntegerItemDefinition : StorableItemDefinition
	{
		// Token: 0x06008385 RID: 33669 RVA: 0x0022F5B4 File Offset: 0x0022D7B4
		// Note: this type is marked as 'beforefieldinit'.
		static IntegerItemDefinition()
		{
			Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "IntegerItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr);
			IntegerItemDefinition.NativeFieldInfoPtr_DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr, "DefaultValue");
			IntegerItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr, 100679750);
			IntegerItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr, 100679751);
		}

		// Token: 0x06008386 RID: 33670 RVA: 0x0022F620 File Offset: 0x0022D820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247608, XrefRangeEnd = 247612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008387 RID: 33671 RVA: 0x0022F678 File Offset: 0x0022D878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008388 RID: 33672 RVA: 0x0003E734 File Offset: 0x0003C934
		public IntegerItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027C3 RID: 10179
		// (get) Token: 0x06008389 RID: 33673 RVA: 0x0022F6B4 File Offset: 0x0022D8B4
		// (set) Token: 0x0600838A RID: 33674 RVA: 0x0003E73D File Offset: 0x0003C93D
		public unsafe int DefaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemDefinition.NativeFieldInfoPtr_DefaultValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemDefinition.NativeFieldInfoPtr_DefaultValue)) = value;
			}
		}

		// Token: 0x04005982 RID: 22914
		private static readonly IntPtr NativeFieldInfoPtr_DefaultValue;

		// Token: 0x04005983 RID: 22915
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005984 RID: 22916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
