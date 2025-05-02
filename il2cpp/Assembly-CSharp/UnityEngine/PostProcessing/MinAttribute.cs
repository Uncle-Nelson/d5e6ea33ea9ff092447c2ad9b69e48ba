using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200004B RID: 75
	public sealed class MinAttribute : PropertyAttribute
	{
		// Token: 0x06000626 RID: 1574 RVA: 0x00082A58 File Offset: 0x00080C58
		// Note: this type is marked as 'beforefieldinit'.
		static MinAttribute()
		{
			Il2CppClassPointerStore<MinAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "MinAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr);
			MinAttribute.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr, "min");
			MinAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr, 100663869);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00082AB0 File Offset: 0x00080CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75785, XrefRangeEnd = 75786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinAttribute(float min) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000059FB File Offset: 0x00003BFB
		public MinAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x00082AF8 File Offset: 0x00080CF8
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x00005A04 File Offset: 0x00003C04
		public unsafe float min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinAttribute.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinAttribute.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
