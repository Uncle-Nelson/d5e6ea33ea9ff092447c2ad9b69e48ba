using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004B4 RID: 1204
	public class BuildStart_Base : MonoBehaviour
	{
		// Token: 0x060069FB RID: 27131 RVA: 0x001DA268 File Offset: 0x001D8468
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStart_Base()
		{
			Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStart_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr);
			BuildStart_Base.NativeMethodInfoPtr_StartBuilding_Public_Abstract_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr, 100676755);
			BuildStart_Base.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr, 100676756);
		}

		// Token: 0x060069FC RID: 27132 RVA: 0x001DA2C0 File Offset: 0x001D84C0
		[CallerCount(0)]
		public unsafe virtual void StartBuilding(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_Base.NativeMethodInfoPtr_StartBuilding_Public_Abstract_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069FD RID: 27133 RVA: 0x001DA310 File Offset: 0x001D8510
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStart_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStart_Base.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069FE RID: 27134 RVA: 0x0003219F File Offset: 0x0003039F
		public BuildStart_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004897 RID: 18583
		private static readonly IntPtr NativeMethodInfoPtr_StartBuilding_Public_Abstract_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04004898 RID: 18584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
