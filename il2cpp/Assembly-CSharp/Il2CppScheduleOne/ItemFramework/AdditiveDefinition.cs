using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005D0 RID: 1488
	[Serializable]
	public class AdditiveDefinition : StorableItemDefinition
	{
		// Token: 0x06008324 RID: 33572 RVA: 0x0022E008 File Offset: 0x0022C208
		// Note: this type is marked as 'beforefieldinit'.
		static AdditiveDefinition()
		{
			Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "AdditiveDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr);
			AdditiveDefinition.NativeFieldInfoPtr_AdditivePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, "AdditivePrefab");
			AdditiveDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, 100679704);
		}

		// Token: 0x06008325 RID: 33573 RVA: 0x0022E060 File Offset: 0x0022C260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdditiveDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditiveDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008326 RID: 33574 RVA: 0x0003E555 File Offset: 0x0003C755
		public AdditiveDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027B5 RID: 10165
		// (get) Token: 0x06008327 RID: 33575 RVA: 0x0022E09C File Offset: 0x0022C29C
		// (set) Token: 0x06008328 RID: 33576 RVA: 0x0003E55E File Offset: 0x0003C75E
		public unsafe Additive AdditivePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditiveDefinition.NativeFieldInfoPtr_AdditivePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Additive>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditiveDefinition.NativeFieldInfoPtr_AdditivePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400593E RID: 22846
		private static readonly IntPtr NativeFieldInfoPtr_AdditivePrefab;

		// Token: 0x0400593F RID: 22847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
