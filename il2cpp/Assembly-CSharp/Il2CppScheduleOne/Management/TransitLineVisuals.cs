using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A6 RID: 934
	public class TransitLineVisuals : MonoBehaviour
	{
		// Token: 0x06004930 RID: 18736 RVA: 0x00165114 File Offset: 0x00163314
		// Note: this type is marked as 'beforefieldinit'.
		static TransitLineVisuals()
		{
			Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "TransitLineVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr);
			TransitLineVisuals.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr, "Renderer");
			TransitLineVisuals.NativeMethodInfoPtr_SetSourcePosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr, 100672369);
			TransitLineVisuals.NativeMethodInfoPtr_SetDestinationPosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr, 100672370);
			TransitLineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr, 100672371);
		}

		// Token: 0x06004931 RID: 18737 RVA: 0x00165194 File Offset: 0x00163394
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 163117, RefRangeEnd = 163120, XrefRangeStart = 163116, XrefRangeEnd = 163117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSourcePosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitLineVisuals.NativeMethodInfoPtr_SetSourcePosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004932 RID: 18738 RVA: 0x001651D4 File Offset: 0x001633D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163121, RefRangeEnd = 163123, XrefRangeStart = 163120, XrefRangeEnd = 163121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestinationPosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitLineVisuals.NativeMethodInfoPtr_SetDestinationPosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x00165214 File Offset: 0x00163414
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitLineVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitLineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004934 RID: 18740 RVA: 0x000234B8 File Offset: 0x000216B8
		public TransitLineVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x06004935 RID: 18741 RVA: 0x00165250 File Offset: 0x00163450
		// (set) Token: 0x06004936 RID: 18742 RVA: 0x000234C1 File Offset: 0x000216C1
		public unsafe LineRenderer Renderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitLineVisuals.NativeFieldInfoPtr_Renderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitLineVisuals.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400315E RID: 12638
		private static readonly IntPtr NativeFieldInfoPtr_Renderer;

		// Token: 0x0400315F RID: 12639
		private static readonly IntPtr NativeMethodInfoPtr_SetSourcePosition_Public_Void_Vector3_0;

		// Token: 0x04003160 RID: 12640
		private static readonly IntPtr NativeMethodInfoPtr_SetDestinationPosition_Public_Void_Vector3_0;

		// Token: 0x04003161 RID: 12641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
