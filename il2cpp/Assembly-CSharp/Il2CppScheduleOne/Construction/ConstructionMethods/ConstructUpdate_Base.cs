using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x0200048C RID: 1164
	public class ConstructUpdate_Base : MonoBehaviour
	{
		// Token: 0x060064BD RID: 25789 RVA: 0x001C7810 File Offset: 0x001C5A10
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructUpdate_Base()
		{
			Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructUpdate_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr);
			ConstructUpdate_Base.NativeFieldInfoPtr_MovedConstructable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr, "MovedConstructable");
			ConstructUpdate_Base.NativeMethodInfoPtr_get_isMoving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr, 100676059);
			ConstructUpdate_Base.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr, 100676060);
			ConstructUpdate_Base.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr, 100676061);
			ConstructUpdate_Base.NativeMethodInfoPtr_ConstructionStop_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr, 100676062);
			ConstructUpdate_Base.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr, 100676063);
		}

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x060064BE RID: 25790 RVA: 0x001C78B8 File Offset: 0x001C5AB8
		public unsafe bool isMoving
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 204727, RefRangeEnd = 204729, XrefRangeStart = 204723, XrefRangeEnd = 204727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_Base.NativeMethodInfoPtr_get_isMoving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060064BF RID: 25791 RVA: 0x001C78F4 File Offset: 0x001C5AF4
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_Base.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064C0 RID: 25792 RVA: 0x001C7930 File Offset: 0x001C5B30
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_Base.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064C1 RID: 25793 RVA: 0x001C796C File Offset: 0x001C5B6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204733, RefRangeEnd = 204735, XrefRangeStart = 204729, XrefRangeEnd = 204733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ConstructionStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_Base.NativeMethodInfoPtr_ConstructionStop_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064C2 RID: 25794 RVA: 0x001C79A8 File Offset: 0x001C5BA8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructUpdate_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_Base.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064C3 RID: 25795 RVA: 0x0002FA2B File Offset: 0x0002DC2B
		public ConstructUpdate_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x060064C4 RID: 25796 RVA: 0x001C79E4 File Offset: 0x001C5BE4
		// (set) Token: 0x060064C5 RID: 25797 RVA: 0x0002FA34 File Offset: 0x0002DC34
		public unsafe Constructable_GridBased MovedConstructable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_Base.NativeFieldInfoPtr_MovedConstructable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_Base.NativeFieldInfoPtr_MovedConstructable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040044BB RID: 17595
		private static readonly IntPtr NativeFieldInfoPtr_MovedConstructable;

		// Token: 0x040044BC RID: 17596
		private static readonly IntPtr NativeMethodInfoPtr_get_isMoving_Public_get_Boolean_0;

		// Token: 0x040044BD RID: 17597
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040044BE RID: 17598
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040044BF RID: 17599
		private static readonly IntPtr NativeMethodInfoPtr_ConstructionStop_Public_Virtual_New_Void_0;

		// Token: 0x040044C0 RID: 17600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
