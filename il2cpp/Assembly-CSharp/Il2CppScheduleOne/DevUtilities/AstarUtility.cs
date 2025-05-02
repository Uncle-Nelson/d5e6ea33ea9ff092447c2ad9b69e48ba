using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200044E RID: 1102
	public class AstarUtility : MonoBehaviour
	{
		// Token: 0x06005FC0 RID: 24512 RVA: 0x001B7404 File Offset: 0x001B5604
		// Note: this type is marked as 'beforefieldinit'.
		static AstarUtility()
		{
			Il2CppClassPointerStore<AstarUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AstarUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AstarUtility>.NativeClassPtr);
			AstarUtility.NativeMethodInfoPtr_GetClosestPointOnGraph_Public_Static_Vector3_Vector3_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarUtility>.NativeClassPtr, 100675510);
			AstarUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarUtility>.NativeClassPtr, 100675511);
		}

		// Token: 0x06005FC1 RID: 24513 RVA: 0x001B745C File Offset: 0x001B565C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198781, XrefRangeEnd = 198791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetClosestPointOnGraph(Vector3 point, string GraphName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GraphName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AstarUtility.NativeMethodInfoPtr_GetClosestPointOnGraph_Public_Static_Vector3_Vector3_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005FC2 RID: 24514 RVA: 0x001B74AC File Offset: 0x001B56AC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstarUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AstarUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AstarUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FC3 RID: 24515 RVA: 0x0002D2F3 File Offset: 0x0002B4F3
		public AstarUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400416C RID: 16748
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPointOnGraph_Public_Static_Vector3_Vector3_String_0;

		// Token: 0x0400416D RID: 16749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
