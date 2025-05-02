using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F7 RID: 1527
	public class EyebrowController : MonoBehaviour
	{
		// Token: 0x0600868E RID: 34446 RVA: 0x002396B4 File Offset: 0x002378B4
		// Note: this type is marked as 'beforefieldinit'.
		static EyebrowController()
		{
			Il2CppClassPointerStore<EyebrowController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "EyebrowController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr);
			EyebrowController.NativeFieldInfoPtr_leftBrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, "leftBrow");
			EyebrowController.NativeFieldInfoPtr_rightBrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, "rightBrow");
			EyebrowController.NativeMethodInfoPtr_ApplySettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, 100680102);
			EyebrowController.NativeMethodInfoPtr_SetLeftBrowRestingHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, 100680103);
			EyebrowController.NativeMethodInfoPtr_SetRightBrowRestingHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, 100680104);
			EyebrowController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, 100680105);
		}

		// Token: 0x0600868F RID: 34447 RVA: 0x0023975C File Offset: 0x0023795C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 251174, RefRangeEnd = 251178, XrefRangeStart = 251162, XrefRangeEnd = 251174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyebrowController.NativeMethodInfoPtr_ApplySettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008690 RID: 34448 RVA: 0x002397A0 File Offset: 0x002379A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251178, XrefRangeEnd = 251180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLeftBrowRestingHeight(float normalizedHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyebrowController.NativeMethodInfoPtr_SetLeftBrowRestingHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008691 RID: 34449 RVA: 0x002397E0 File Offset: 0x002379E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251180, XrefRangeEnd = 251182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRightBrowRestingHeight(float normalizedHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyebrowController.NativeMethodInfoPtr_SetRightBrowRestingHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008692 RID: 34450 RVA: 0x00239820 File Offset: 0x00237A20
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyebrowController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyebrowController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008693 RID: 34451 RVA: 0x0003FF7D File Offset: 0x0003E17D
		public EyebrowController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028E3 RID: 10467
		// (get) Token: 0x06008694 RID: 34452 RVA: 0x0023985C File Offset: 0x00237A5C
		// (set) Token: 0x06008695 RID: 34453 RVA: 0x0003FF86 File Offset: 0x0003E186
		public unsafe Eyebrow leftBrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyebrowController.NativeFieldInfoPtr_leftBrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eyebrow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyebrowController.NativeFieldInfoPtr_leftBrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028E4 RID: 10468
		// (get) Token: 0x06008696 RID: 34454 RVA: 0x0023988C File Offset: 0x00237A8C
		// (set) Token: 0x06008697 RID: 34455 RVA: 0x0003FFA5 File Offset: 0x0003E1A5
		public unsafe Eyebrow rightBrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyebrowController.NativeFieldInfoPtr_rightBrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eyebrow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyebrowController.NativeFieldInfoPtr_rightBrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005B96 RID: 23446
		private static readonly IntPtr NativeFieldInfoPtr_leftBrow;

		// Token: 0x04005B97 RID: 23447
		private static readonly IntPtr NativeFieldInfoPtr_rightBrow;

		// Token: 0x04005B98 RID: 23448
		private static readonly IntPtr NativeMethodInfoPtr_ApplySettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005B99 RID: 23449
		private static readonly IntPtr NativeMethodInfoPtr_SetLeftBrowRestingHeight_Public_Void_Single_0;

		// Token: 0x04005B9A RID: 23450
		private static readonly IntPtr NativeMethodInfoPtr_SetRightBrowRestingHeight_Public_Void_Single_0;

		// Token: 0x04005B9B RID: 23451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
