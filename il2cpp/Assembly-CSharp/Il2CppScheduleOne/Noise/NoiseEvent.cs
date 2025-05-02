using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Noise
{
	// Token: 0x0200036B RID: 875
	public class NoiseEvent : Il2CppSystem.Object
	{
		// Token: 0x06004475 RID: 17525 RVA: 0x001526CC File Offset: 0x001508CC
		// Note: this type is marked as 'beforefieldinit'.
		static NoiseEvent()
		{
			Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Noise", "NoiseEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr);
			NoiseEvent.NativeFieldInfoPtr_origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, "origin");
			NoiseEvent.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, "range");
			NoiseEvent.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, "type");
			NoiseEvent.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, "source");
			NoiseEvent.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_ENoiseType_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, 100671658);
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x00152760 File Offset: 0x00150960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155061, XrefRangeEnd = 155063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoiseEvent(Vector3 _origin, float _range, ENoiseType _type, GameObject _source = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _range;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _type;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoiseEvent.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_ENoiseType_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004477 RID: 17527 RVA: 0x000216E4 File Offset: 0x0001F8E4
		public NoiseEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06004478 RID: 17528 RVA: 0x001527D8 File Offset: 0x001509D8
		// (set) Token: 0x06004479 RID: 17529 RVA: 0x000216ED File Offset: 0x0001F8ED
		public unsafe Vector3 origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_origin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_origin)) = value;
			}
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x0600447A RID: 17530 RVA: 0x00152800 File Offset: 0x00150A00
		// (set) Token: 0x0600447B RID: 17531 RVA: 0x00021708 File Offset: 0x0001F908
		public unsafe float range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_range)) = value;
			}
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x0600447C RID: 17532 RVA: 0x00152828 File Offset: 0x00150A28
		// (set) Token: 0x0600447D RID: 17533 RVA: 0x00021723 File Offset: 0x0001F923
		public unsafe ENoiseType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x0600447E RID: 17534 RVA: 0x00152850 File Offset: 0x00150A50
		// (set) Token: 0x0600447F RID: 17535 RVA: 0x0002173E File Offset: 0x0001F93E
		public unsafe GameObject source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002DD6 RID: 11734
		private static readonly IntPtr NativeFieldInfoPtr_origin;

		// Token: 0x04002DD7 RID: 11735
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04002DD8 RID: 11736
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04002DD9 RID: 11737
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04002DDA RID: 11738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_ENoiseType_GameObject_0;
	}
}
