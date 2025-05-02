using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200004A RID: 74
	public sealed class GetSetAttribute : PropertyAttribute
	{
		// Token: 0x0600061F RID: 1567 RVA: 0x00082950 File Offset: 0x00080B50
		// Note: this type is marked as 'beforefieldinit'.
		static GetSetAttribute()
		{
			Il2CppClassPointerStore<GetSetAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "GetSetAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetSetAttribute>.NativeClassPtr);
			GetSetAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSetAttribute>.NativeClassPtr, "name");
			GetSetAttribute.NativeFieldInfoPtr_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSetAttribute>.NativeClassPtr, "dirty");
			GetSetAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSetAttribute>.NativeClassPtr, 100663868);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x000829BC File Offset: 0x00080BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75783, XrefRangeEnd = 75785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetSetAttribute(string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetSetAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSetAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x000059B8 File Offset: 0x00003BB8
		public GetSetAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x00082A08 File Offset: 0x00080C08
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x000059C1 File Offset: 0x00003BC1
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSetAttribute.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSetAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x00082A30 File Offset: 0x00080C30
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x000059E0 File Offset: 0x00003BE0
		public unsafe bool dirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSetAttribute.NativeFieldInfoPtr_dirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSetAttribute.NativeFieldInfoPtr_dirty)) = value;
			}
		}

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeFieldInfoPtr_dirty;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
