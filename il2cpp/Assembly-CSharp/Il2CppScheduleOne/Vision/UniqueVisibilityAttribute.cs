using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x02000173 RID: 371
	[Serializable]
	public class UniqueVisibilityAttribute : VisibilityAttribute
	{
		// Token: 0x06001DD5 RID: 7637 RVA: 0x000CD23C File Offset: 0x000CB43C
		// Note: this type is marked as 'beforefieldinit'.
		static UniqueVisibilityAttribute()
		{
			Il2CppClassPointerStore<UniqueVisibilityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "UniqueVisibilityAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniqueVisibilityAttribute>.NativeClassPtr);
			UniqueVisibilityAttribute.NativeFieldInfoPtr_uniquenessCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniqueVisibilityAttribute>.NativeClassPtr, "uniquenessCode");
			UniqueVisibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Single_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueVisibilityAttribute>.NativeClassPtr, 100666681);
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x000CD294 File Offset: 0x000CB494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106439, XrefRangeEnd = 106441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniqueVisibilityAttribute(string _name, float _pointsChange, string _uniquenessCode, float _multiplier = 1f, int attributeIndex = -1) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniqueVisibilityAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _pointsChange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_uniquenessCode);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _multiplier;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attributeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueVisibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Single_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x00010DB1 File Offset: 0x0000EFB1
		public UniqueVisibilityAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x000CD31C File Offset: 0x000CB51C
		// (set) Token: 0x06001DD9 RID: 7641 RVA: 0x00010DBA File Offset: 0x0000EFBA
		public unsafe string uniquenessCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniqueVisibilityAttribute.NativeFieldInfoPtr_uniquenessCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniqueVisibilityAttribute.NativeFieldInfoPtr_uniquenessCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeFieldInfoPtr_uniquenessCode;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_String_Single_Int32_0;
	}
}
