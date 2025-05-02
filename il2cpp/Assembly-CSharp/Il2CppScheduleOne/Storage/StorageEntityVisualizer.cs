using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000577 RID: 1399
	public class StorageEntityVisualizer : StorageVisualizer
	{
		// Token: 0x06007B3A RID: 31546 RVA: 0x00212D20 File Offset: 0x00210F20
		// Note: this type is marked as 'beforefieldinit'.
		static StorageEntityVisualizer()
		{
			Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageEntityVisualizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr);
			StorageEntityVisualizer.NativeFieldInfoPtr_storageEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr, "storageEntity");
			StorageEntityVisualizer.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr, 100678749);
			StorageEntityVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr, 100678750);
		}

		// Token: 0x06007B3B RID: 31547 RVA: 0x00212D8C File Offset: 0x00210F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236148, XrefRangeEnd = 236166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageEntityVisualizer.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B3C RID: 31548 RVA: 0x00212DC8 File Offset: 0x00210FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236166, XrefRangeEnd = 236181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageEntityVisualizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageEntityVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B3D RID: 31549 RVA: 0x0003A7B8 File Offset: 0x000389B8
		public StorageEntityVisualizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002535 RID: 9525
		// (get) Token: 0x06007B3E RID: 31550 RVA: 0x00212E04 File Offset: 0x00211004
		// (set) Token: 0x06007B3F RID: 31551 RVA: 0x0003A7C1 File Offset: 0x000389C1
		public unsafe StorageEntity storageEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageEntityVisualizer.NativeFieldInfoPtr_storageEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageEntityVisualizer.NativeFieldInfoPtr_storageEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040053EC RID: 21484
		private static readonly IntPtr NativeFieldInfoPtr_storageEntity;

		// Token: 0x040053ED RID: 21485
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040053EE RID: 21486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
