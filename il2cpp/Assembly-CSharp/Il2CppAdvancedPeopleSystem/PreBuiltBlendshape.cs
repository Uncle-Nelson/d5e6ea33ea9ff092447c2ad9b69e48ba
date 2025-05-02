using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000152 RID: 338
	[Serializable]
	public class PreBuiltBlendshape : Object
	{
		// Token: 0x06001BB8 RID: 7096 RVA: 0x000C6FBC File Offset: 0x000C51BC
		// Note: this type is marked as 'beforefieldinit'.
		static PreBuiltBlendshape()
		{
			Il2CppClassPointerStore<PreBuiltBlendshape>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "PreBuiltBlendshape");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreBuiltBlendshape>.NativeClassPtr);
			PreBuiltBlendshape.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreBuiltBlendshape>.NativeClassPtr, "name");
			PreBuiltBlendshape.NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreBuiltBlendshape>.NativeClassPtr, "weight");
			PreBuiltBlendshape.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreBuiltBlendshape>.NativeClassPtr, 100666231);
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x000C7028 File Offset: 0x000C5228
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70203, RefRangeEnd = 70204, XrefRangeStart = 70203, XrefRangeEnd = 70204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreBuiltBlendshape(string name, float weight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreBuiltBlendshape>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreBuiltBlendshape.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0000FB55 File Offset: 0x0000DD55
		public PreBuiltBlendshape(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x000C7084 File Offset: 0x000C5284
		// (set) Token: 0x06001BBC RID: 7100 RVA: 0x0000FB5E File Offset: 0x0000DD5E
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltBlendshape.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltBlendshape.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x000C70AC File Offset: 0x000C52AC
		// (set) Token: 0x06001BBE RID: 7102 RVA: 0x0000FB7D File Offset: 0x0000DD7D
		public unsafe float weight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltBlendshape.NativeFieldInfoPtr_weight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltBlendshape.NativeFieldInfoPtr_weight)) = value;
			}
		}

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeFieldInfoPtr_weight;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_0;
	}
}
