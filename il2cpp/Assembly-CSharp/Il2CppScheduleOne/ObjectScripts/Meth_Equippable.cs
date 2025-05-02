using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000737 RID: 1847
	public class Meth_Equippable : Equippable_Viewmodel
	{
		// Token: 0x0600A90E RID: 43278 RVA: 0x002A371C File Offset: 0x002A191C
		// Note: this type is marked as 'beforefieldinit'.
		static Meth_Equippable()
		{
			Il2CppClassPointerStore<Meth_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Meth_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Meth_Equippable>.NativeClassPtr);
			Meth_Equippable.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Meth_Equippable>.NativeClassPtr, "Visuals");
			Meth_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Meth_Equippable>.NativeClassPtr, 100684006);
			Meth_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Meth_Equippable>.NativeClassPtr, 100684007);
		}

		// Token: 0x0600A90F RID: 43279 RVA: 0x002A3788 File Offset: 0x002A1988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294128, XrefRangeEnd = 294138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Meth_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A910 RID: 43280 RVA: 0x002A37D8 File Offset: 0x002A19D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Meth_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Meth_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Meth_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A911 RID: 43281 RVA: 0x000533FF File Offset: 0x000515FF
		public Meth_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003438 RID: 13368
		// (get) Token: 0x0600A912 RID: 43282 RVA: 0x002A3814 File Offset: 0x002A1A14
		// (set) Token: 0x0600A913 RID: 43283 RVA: 0x00053408 File Offset: 0x00051608
		public unsafe MethVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Meth_Equippable.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Meth_Equippable.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007177 RID: 29047
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04007178 RID: 29048
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04007179 RID: 29049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
