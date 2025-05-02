using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x02000174 RID: 372
	[Serializable]
	public class VisibilityAttribute : Object
	{
		// Token: 0x06001DDA RID: 7642 RVA: 0x000CD344 File Offset: 0x000CB544
		// Note: this type is marked as 'beforefieldinit'.
		static VisibilityAttribute()
		{
			Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "VisibilityAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr);
			VisibilityAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, "name");
			VisibilityAttribute.NativeFieldInfoPtr_pointsChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, "pointsChange");
			VisibilityAttribute.NativeFieldInfoPtr_multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, "multiplier");
			VisibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, 100666682);
			VisibilityAttribute.NativeMethodInfoPtr_Delete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, 100666683);
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x000CD3D8 File Offset: 0x000CB5D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 106455, RefRangeEnd = 106459, XrefRangeStart = 106441, XrefRangeEnd = 106455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibilityAttribute(string _name, float _pointsChange, float _multiplier = 1f, int attributeIndex = -1) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _pointsChange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _multiplier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attributeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x000CD450 File Offset: 0x000CB650
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106467, RefRangeEnd = 106469, XrefRangeStart = 106459, XrefRangeEnd = 106467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityAttribute.NativeMethodInfoPtr_Delete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x00010DD9 File Offset: 0x0000EFD9
		public VisibilityAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x000CD484 File Offset: 0x000CB684
		// (set) Token: 0x06001DDF RID: 7647 RVA: 0x00010DE2 File Offset: 0x0000EFE2
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x000CD4AC File Offset: 0x000CB6AC
		// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x00010E01 File Offset: 0x0000F001
		public unsafe float pointsChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_pointsChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_pointsChange)) = value;
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x000CD4D4 File Offset: 0x000CB6D4
		// (set) Token: 0x06001DE3 RID: 7651 RVA: 0x00010E1C File Offset: 0x0000F01C
		public unsafe float multiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_multiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_multiplier)) = value;
			}
		}

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeFieldInfoPtr_pointsChange;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeFieldInfoPtr_multiplier;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Int32_0;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Void_0;
	}
}
