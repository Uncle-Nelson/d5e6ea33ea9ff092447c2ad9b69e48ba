using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002BF RID: 703
	[Serializable]
	public class WorldStorageEntitiesData : SaveData
	{
		// Token: 0x06003218 RID: 12824 RVA: 0x0010F31C File Offset: 0x0010D51C
		// Note: this type is marked as 'beforefieldinit'.
		static WorldStorageEntitiesData()
		{
			Il2CppClassPointerStore<WorldStorageEntitiesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "WorldStorageEntitiesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldStorageEntitiesData>.NativeClassPtr);
			WorldStorageEntitiesData.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntitiesData>.NativeClassPtr, "Entities");
			WorldStorageEntitiesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_WorldStorageEntityData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntitiesData>.NativeClassPtr, 100668863);
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x0010F374 File Offset: 0x0010D574
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 130499, RefRangeEnd = 130507, XrefRangeStart = 130499, XrefRangeEnd = 130507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldStorageEntitiesData(Il2CppReferenceArray<WorldStorageEntityData> entities) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldStorageEntitiesData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntitiesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_WorldStorageEntityData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x0001ADEA File Offset: 0x00018FEA
		public WorldStorageEntitiesData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x0600321B RID: 12827 RVA: 0x0010F3C0 File Offset: 0x0010D5C0
		// (set) Token: 0x0600321C RID: 12828 RVA: 0x0001ADF3 File Offset: 0x00018FF3
		public unsafe Il2CppReferenceArray<WorldStorageEntityData> Entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntitiesData.NativeFieldInfoPtr_Entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WorldStorageEntityData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntitiesData.NativeFieldInfoPtr_Entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002076 RID: 8310
		private static readonly IntPtr NativeFieldInfoPtr_Entities;

		// Token: 0x04002077 RID: 8311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_WorldStorageEntityData_0;
	}
}
