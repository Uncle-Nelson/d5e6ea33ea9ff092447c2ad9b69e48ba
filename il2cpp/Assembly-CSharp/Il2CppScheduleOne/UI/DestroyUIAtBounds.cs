using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200066B RID: 1643
	public class DestroyUIAtBounds : MonoBehaviour
	{
		// Token: 0x060092C0 RID: 37568 RVA: 0x0025D51C File Offset: 0x0025B71C
		// Note: this type is marked as 'beforefieldinit'.
		static DestroyUIAtBounds()
		{
			Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DestroyUIAtBounds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr);
			DestroyUIAtBounds.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, "Rect");
			DestroyUIAtBounds.NativeFieldInfoPtr_MinBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, "MinBounds");
			DestroyUIAtBounds.NativeFieldInfoPtr_MaxBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, "MaxBounds");
			DestroyUIAtBounds.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, 100681510);
			DestroyUIAtBounds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, 100681511);
		}

		// Token: 0x060092C1 RID: 37569 RVA: 0x0025D5B0 File Offset: 0x0025B7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265117, XrefRangeEnd = 265126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyUIAtBounds.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092C2 RID: 37570 RVA: 0x0025D5E4 File Offset: 0x0025B7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265126, XrefRangeEnd = 265127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DestroyUIAtBounds() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyUIAtBounds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092C3 RID: 37571 RVA: 0x0004708D File Offset: 0x0004528D
		public DestroyUIAtBounds(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CFA RID: 11514
		// (get) Token: 0x060092C4 RID: 37572 RVA: 0x0025D620 File Offset: 0x0025B820
		// (set) Token: 0x060092C5 RID: 37573 RVA: 0x00047096 File Offset: 0x00045296
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CFB RID: 11515
		// (get) Token: 0x060092C6 RID: 37574 RVA: 0x0025D650 File Offset: 0x0025B850
		// (set) Token: 0x060092C7 RID: 37575 RVA: 0x000470B5 File Offset: 0x000452B5
		public unsafe Vector2 MinBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_MinBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_MinBounds)) = value;
			}
		}

		// Token: 0x17002CFC RID: 11516
		// (get) Token: 0x060092C8 RID: 37576 RVA: 0x0025D678 File Offset: 0x0025B878
		// (set) Token: 0x060092C9 RID: 37577 RVA: 0x000470D0 File Offset: 0x000452D0
		public unsafe Vector2 MaxBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_MaxBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_MaxBounds)) = value;
			}
		}

		// Token: 0x04006320 RID: 25376
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04006321 RID: 25377
		private static readonly IntPtr NativeFieldInfoPtr_MinBounds;

		// Token: 0x04006322 RID: 25378
		private static readonly IntPtr NativeFieldInfoPtr_MaxBounds;

		// Token: 0x04006323 RID: 25379
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04006324 RID: 25380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
