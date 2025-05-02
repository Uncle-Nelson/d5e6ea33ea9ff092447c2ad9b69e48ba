using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities.Power
{
	// Token: 0x0200051B RID: 1307
	public class PowerNodeTag : MonoBehaviour
	{
		// Token: 0x06007463 RID: 29795 RVA: 0x001FB678 File Offset: 0x001F9878
		// Note: this type is marked as 'beforefieldinit'.
		static PowerNodeTag()
		{
			Il2CppClassPointerStore<PowerNodeTag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities.Power", "PowerNodeTag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerNodeTag>.NativeClassPtr);
			PowerNodeTag.NativeFieldInfoPtr_powerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerNodeTag>.NativeClassPtr, "powerNode");
			PowerNodeTag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerNodeTag>.NativeClassPtr, 100677927);
		}

		// Token: 0x06007464 RID: 29796 RVA: 0x001FB6D0 File Offset: 0x001F98D0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerNodeTag() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerNodeTag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerNodeTag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007465 RID: 29797 RVA: 0x0003748E File Offset: 0x0003568E
		public PowerNodeTag(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002346 RID: 9030
		// (get) Token: 0x06007466 RID: 29798 RVA: 0x001FB70C File Offset: 0x001F990C
		// (set) Token: 0x06007467 RID: 29799 RVA: 0x00037497 File Offset: 0x00035697
		public unsafe PowerNode powerNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNodeTag.NativeFieldInfoPtr_powerNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNodeTag.NativeFieldInfoPtr_powerNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004F78 RID: 20344
		private static readonly IntPtr NativeFieldInfoPtr_powerNode;

		// Token: 0x04004F79 RID: 20345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
