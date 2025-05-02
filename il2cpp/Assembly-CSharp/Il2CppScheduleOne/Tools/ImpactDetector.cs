using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200053E RID: 1342
	public class ImpactDetector : MonoBehaviour
	{
		// Token: 0x0600771E RID: 30494 RVA: 0x002054B8 File Offset: 0x002036B8
		// Note: this type is marked as 'beforefieldinit'.
		static ImpactDetector()
		{
			Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ImpactDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr);
			ImpactDetector.NativeFieldInfoPtr_DestroyScriptOnImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr, "DestroyScriptOnImpact");
			ImpactDetector.NativeFieldInfoPtr_onImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr, "onImpact");
			ImpactDetector.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr, 100678312);
			ImpactDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr, 100678313);
		}

		// Token: 0x0600771F RID: 30495 RVA: 0x00205538 File Offset: 0x00203738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231679, XrefRangeEnd = 231684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactDetector.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x0020557C File Offset: 0x0020377C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231684, XrefRangeEnd = 231690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImpactDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007721 RID: 30497 RVA: 0x000386B1 File Offset: 0x000368B1
		public ImpactDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002408 RID: 9224
		// (get) Token: 0x06007722 RID: 30498 RVA: 0x002055B8 File Offset: 0x002037B8
		// (set) Token: 0x06007723 RID: 30499 RVA: 0x000386BA File Offset: 0x000368BA
		public unsafe bool DestroyScriptOnImpact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactDetector.NativeFieldInfoPtr_DestroyScriptOnImpact);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactDetector.NativeFieldInfoPtr_DestroyScriptOnImpact)) = value;
			}
		}

		// Token: 0x17002409 RID: 9225
		// (get) Token: 0x06007724 RID: 30500 RVA: 0x002055E0 File Offset: 0x002037E0
		// (set) Token: 0x06007725 RID: 30501 RVA: 0x000386D5 File Offset: 0x000368D5
		public unsafe UnityEvent onImpact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactDetector.NativeFieldInfoPtr_onImpact);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactDetector.NativeFieldInfoPtr_onImpact), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005153 RID: 20819
		private static readonly IntPtr NativeFieldInfoPtr_DestroyScriptOnImpact;

		// Token: 0x04005154 RID: 20820
		private static readonly IntPtr NativeFieldInfoPtr_onImpact;

		// Token: 0x04005155 RID: 20821
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x04005156 RID: 20822
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
