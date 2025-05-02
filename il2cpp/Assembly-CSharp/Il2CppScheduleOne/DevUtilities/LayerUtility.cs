using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000458 RID: 1112
	public static class LayerUtility : Il2CppSystem.Object
	{
		// Token: 0x060060AC RID: 24748 RVA: 0x0002DB78 File Offset: 0x0002BD78
		// Note: this type is marked as 'beforefieldinit'.
		static LayerUtility()
		{
			Il2CppClassPointerStore<LayerUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "LayerUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr);
			LayerUtility.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr, 100675594);
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x001B9ED8 File Offset: 0x001B80D8
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 199556, RefRangeEnd = 199582, XrefRangeStart = 199550, XrefRangeEnd = 199556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLayerRecursively(GameObject go, int layerNumber)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerUtility.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x0002DBB1 File Offset: 0x0002BDB1
		public LayerUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040041FC RID: 16892
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0;
	}
}
