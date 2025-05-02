using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000B2 RID: 178
	public static class TransformUtils : Il2CppSystem.Object
	{
		// Token: 0x06000D36 RID: 3382 RVA: 0x000087A1 File Offset: 0x000069A1
		// Note: this type is marked as 'beforefieldinit'.
		static TransformUtils()
		{
			Il2CppClassPointerStore<TransformUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "TransformUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformUtils>.NativeClassPtr);
			TransformUtils.NativeMethodInfoPtr_GetWorldPacked_Public_Static_Packed_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformUtils>.NativeClassPtr, 100664911);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0009ABE0 File Offset: 0x00098DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84488, XrefRangeEnd = 84491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TransformUtils.Packed GetWorldPacked(this Transform self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformUtils.NativeMethodInfoPtr_GetWorldPacked_Public_Static_Packed_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x000087DA File Offset: 0x000069DA
		public TransformUtils(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldPacked_Public_Static_Packed_Transform_0;

		// Token: 0x0200083C RID: 2108
		[StructLayout(2)]
		public struct Packed
		{
			// Token: 0x0600BF92 RID: 49042 RVA: 0x002EEF20 File Offset: 0x002ED120
			// Note: this type is marked as 'beforefieldinit'.
			static Packed()
			{
				Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransformUtils>.NativeClassPtr, "Packed");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr);
				TransformUtils.Packed.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, "position");
				TransformUtils.Packed.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, "rotation");
				TransformUtils.Packed.NativeFieldInfoPtr_lossyScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, "lossyScale");
				TransformUtils.Packed.NativeMethodInfoPtr_IsSame_Public_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, 100664912);
			}

			// Token: 0x0600BF93 RID: 49043 RVA: 0x002EEF9C File Offset: 0x002ED19C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 84486, RefRangeEnd = 84488, XrefRangeStart = 84483, XrefRangeEnd = 84486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsSame(Transform transf)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transf);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformUtils.Packed.NativeMethodInfoPtr_IsSame_Public_Boolean_Transform_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BF94 RID: 49044 RVA: 0x0005D9F4 File Offset: 0x0005BBF4
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, ref this));
			}

			// Token: 0x040081C1 RID: 33217
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x040081C2 RID: 33218
			private static readonly IntPtr NativeFieldInfoPtr_rotation;

			// Token: 0x040081C3 RID: 33219
			private static readonly IntPtr NativeFieldInfoPtr_lossyScale;

			// Token: 0x040081C4 RID: 33220
			private static readonly IntPtr NativeMethodInfoPtr_IsSame_Public_Boolean_Transform_0;

			// Token: 0x040081C5 RID: 33221
			[FieldOffset(0)]
			public Vector3 position;

			// Token: 0x040081C6 RID: 33222
			[FieldOffset(12)]
			public Quaternion rotation;

			// Token: 0x040081C7 RID: 33223
			[FieldOffset(28)]
			public Vector3 lossyScale;
		}
	}
}
