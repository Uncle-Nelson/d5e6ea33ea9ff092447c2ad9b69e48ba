using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000576 RID: 1398
	public class StorageEntityInteractable : InteractableObject
	{
		// Token: 0x06007B32 RID: 31538 RVA: 0x00212B74 File Offset: 0x00210D74
		// Note: this type is marked as 'beforefieldinit'.
		static StorageEntityInteractable()
		{
			Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageEntityInteractable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr);
			StorageEntityInteractable.NativeFieldInfoPtr_StorageEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, "StorageEntity");
			StorageEntityInteractable.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, 100678745);
			StorageEntityInteractable.NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, 100678746);
			StorageEntityInteractable.NativeMethodInfoPtr_StartInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, 100678747);
			StorageEntityInteractable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, 100678748);
		}

		// Token: 0x06007B33 RID: 31539 RVA: 0x00212C08 File Offset: 0x00210E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236125, XrefRangeEnd = 236129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageEntityInteractable.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B34 RID: 31540 RVA: 0x00212C3C File Offset: 0x00210E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236129, XrefRangeEnd = 236130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageEntityInteractable.NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B35 RID: 31541 RVA: 0x00212C78 File Offset: 0x00210E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236130, XrefRangeEnd = 236147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageEntityInteractable.NativeMethodInfoPtr_StartInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B36 RID: 31542 RVA: 0x00212CB4 File Offset: 0x00210EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236147, XrefRangeEnd = 236148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageEntityInteractable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageEntityInteractable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B37 RID: 31543 RVA: 0x0003A790 File Offset: 0x00038990
		public StorageEntityInteractable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002534 RID: 9524
		// (get) Token: 0x06007B38 RID: 31544 RVA: 0x00212CF0 File Offset: 0x00210EF0
		// (set) Token: 0x06007B39 RID: 31545 RVA: 0x0003A799 File Offset: 0x00038999
		public unsafe StorageEntity StorageEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageEntityInteractable.NativeFieldInfoPtr_StorageEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageEntityInteractable.NativeFieldInfoPtr_StorageEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040053E7 RID: 21479
		private static readonly IntPtr NativeFieldInfoPtr_StorageEntity;

		// Token: 0x040053E8 RID: 21480
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040053E9 RID: 21481
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0;

		// Token: 0x040053EA RID: 21482
		private static readonly IntPtr NativeMethodInfoPtr_StartInteract_Public_Virtual_Void_0;

		// Token: 0x040053EB RID: 21483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
