using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200057C RID: 1404
	public static class StorageVisualizationUtility : Object
	{
		// Token: 0x06007B96 RID: 31638 RVA: 0x0003AA3E File Offset: 0x00038C3E
		// Note: this type is marked as 'beforefieldinit'.
		static StorageVisualizationUtility()
		{
			Il2CppClassPointerStore<StorageVisualizationUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageVisualizationUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageVisualizationUtility>.NativeClassPtr);
			StorageVisualizationUtility.NativeMethodInfoPtr_GetVisualRepresentation_Public_Static_Dictionary_2_StorableItemInstance_Int32_Dictionary_2_StorableItemInstance_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizationUtility>.NativeClassPtr, 100678791);
		}

		// Token: 0x06007B97 RID: 31639 RVA: 0x0021417C File Offset: 0x0021237C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236595, RefRangeEnd = 236597, XrefRangeStart = 236531, XrefRangeEnd = 236595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<StorableItemInstance, int> GetVisualRepresentation(Dictionary<StorableItemInstance, int> inputDictionary, int TotalFootprintSize)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDictionary);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref TotalFootprintSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizationUtility.NativeMethodInfoPtr_GetVisualRepresentation_Public_Static_Dictionary_2_StorableItemInstance_Int32_Dictionary_2_StorableItemInstance_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<StorableItemInstance, int>>(intPtr3) : null;
		}

		// Token: 0x06007B98 RID: 31640 RVA: 0x0003AA77 File Offset: 0x00038C77
		public StorageVisualizationUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005429 RID: 21545
		private static readonly IntPtr NativeMethodInfoPtr_GetVisualRepresentation_Public_Static_Dictionary_2_StorableItemInstance_Int32_Dictionary_2_StorableItemInstance_Int32_Int32_0;
	}
}
