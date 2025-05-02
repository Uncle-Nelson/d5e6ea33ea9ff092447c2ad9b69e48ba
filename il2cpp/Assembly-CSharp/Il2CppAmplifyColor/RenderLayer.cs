using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppAmplifyColor
{
	// Token: 0x02000795 RID: 1941
	[Serializable]
	[StructLayout(2)]
	public struct RenderLayer
	{
		// Token: 0x0600B7DA RID: 47066 RVA: 0x002DA26C File Offset: 0x002D846C
		// Note: this type is marked as 'beforefieldinit'.
		static RenderLayer()
		{
			Il2CppClassPointerStore<RenderLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyColor", "RenderLayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderLayer>.NativeClassPtr);
			RenderLayer.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderLayer>.NativeClassPtr, "mask");
			RenderLayer.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderLayer>.NativeClassPtr, "color");
			RenderLayer.NativeMethodInfoPtr__ctor_Public_Void_LayerMask_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderLayer>.NativeClassPtr, 100685884);
		}

		// Token: 0x0600B7DB RID: 47067 RVA: 0x002DA2D8 File Offset: 0x002D84D8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 313025, RefRangeEnd = 313036, XrefRangeStart = 313025, XrefRangeEnd = 313025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderLayer(LayerMask mask, Color color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mask;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderLayer.NativeMethodInfoPtr__ctor_Public_Void_LayerMask_Color_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7DC RID: 47068 RVA: 0x0005A45C File Offset: 0x0005865C
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderLayer>.NativeClassPtr, ref this));
		}

		// Token: 0x04007BE0 RID: 31712
		private static readonly IntPtr NativeFieldInfoPtr_mask;

		// Token: 0x04007BE1 RID: 31713
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04007BE2 RID: 31714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LayerMask_Color_0;

		// Token: 0x04007BE3 RID: 31715
		[FieldOffset(0)]
		public LayerMask mask;

		// Token: 0x04007BE4 RID: 31716
		[FieldOffset(4)]
		public Color color;
	}
}
