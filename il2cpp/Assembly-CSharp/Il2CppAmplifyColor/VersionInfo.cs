using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppAmplifyColor
{
	// Token: 0x02000796 RID: 1942
	[Serializable]
	public class VersionInfo : Object
	{
		// Token: 0x0600B7DD RID: 47069 RVA: 0x002DA318 File Offset: 0x002D8518
		// Note: this type is marked as 'beforefieldinit'.
		static VersionInfo()
		{
			Il2CppClassPointerStore<VersionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyColor", "VersionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr);
			VersionInfo.NativeFieldInfoPtr_Major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "Major");
			VersionInfo.NativeFieldInfoPtr_Minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "Minor");
			VersionInfo.NativeFieldInfoPtr_Release = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "Release");
			VersionInfo.NativeFieldInfoPtr_StageSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "StageSuffix");
			VersionInfo.NativeFieldInfoPtr_TrialSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "TrialSuffix");
			VersionInfo.NativeFieldInfoPtr_m_major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "m_major");
			VersionInfo.NativeFieldInfoPtr_m_minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "m_minor");
			VersionInfo.NativeFieldInfoPtr_m_release = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "m_release");
			VersionInfo.NativeMethodInfoPtr_StaticToString_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100685885);
			VersionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100685886);
			VersionInfo.NativeMethodInfoPtr_get_FullNumber_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100685887);
			VersionInfo.NativeMethodInfoPtr_get_Number_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100685888);
			VersionInfo.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100685889);
			VersionInfo.NativeMethodInfoPtr__ctor_Private_Void_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100685890);
			VersionInfo.NativeMethodInfoPtr_Current_Public_Static_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100685891);
			VersionInfo.NativeMethodInfoPtr_Matches_Public_Static_Boolean_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100685892);
		}

		// Token: 0x0600B7DE RID: 47070 RVA: 0x002DA488 File Offset: 0x002D8688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313036, XrefRangeEnd = 313051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StaticToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_StaticToString_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600B7DF RID: 47071 RVA: 0x002DA4B4 File Offset: 0x002D86B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313051, XrefRangeEnd = 313066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17003902 RID: 14594
		// (get) Token: 0x0600B7E0 RID: 47072 RVA: 0x002DA4F8 File Offset: 0x002D86F8
		public unsafe static int FullNumber
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_get_FullNumber_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003903 RID: 14595
		// (get) Token: 0x0600B7E1 RID: 47073 RVA: 0x002DA528 File Offset: 0x002D8728
		public unsafe int Number
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_get_Number_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600B7E2 RID: 47074 RVA: 0x002DA564 File Offset: 0x002D8764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313066, XrefRangeEnd = 313067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionInfo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7E3 RID: 47075 RVA: 0x002DA5A0 File Offset: 0x002D87A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313067, XrefRangeEnd = 313068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionInfo(byte major, byte minor, byte release) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref major;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref release;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr__ctor_Private_Void_Byte_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7E4 RID: 47076 RVA: 0x002DA604 File Offset: 0x002D8804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313068, XrefRangeEnd = 313072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VersionInfo Current()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_Current_Public_Static_VersionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VersionInfo>(intPtr3) : null;
		}

		// Token: 0x0600B7E5 RID: 47077 RVA: 0x002DA638 File Offset: 0x002D8838
		[CallerCount(0)]
		public unsafe static bool Matches(VersionInfo version)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(version);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_Matches_Public_Static_Boolean_VersionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B7E6 RID: 47078 RVA: 0x0005A46E File Offset: 0x0005866E
		public VersionInfo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038FA RID: 14586
		// (get) Token: 0x0600B7E7 RID: 47079 RVA: 0x002DA67C File Offset: 0x002D887C
		// (set) Token: 0x0600B7E8 RID: 47080 RVA: 0x0005A477 File Offset: 0x00058677
		public unsafe static byte Major
		{
			get
			{
				byte result;
				IL2CPP.il2cpp_field_static_get_value(VersionInfo.NativeFieldInfoPtr_Major, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VersionInfo.NativeFieldInfoPtr_Major, (void*)(&value));
			}
		}

		// Token: 0x170038FB RID: 14587
		// (get) Token: 0x0600B7E9 RID: 47081 RVA: 0x002DA698 File Offset: 0x002D8898
		// (set) Token: 0x0600B7EA RID: 47082 RVA: 0x0005A485 File Offset: 0x00058685
		public unsafe static byte Minor
		{
			get
			{
				byte result;
				IL2CPP.il2cpp_field_static_get_value(VersionInfo.NativeFieldInfoPtr_Minor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VersionInfo.NativeFieldInfoPtr_Minor, (void*)(&value));
			}
		}

		// Token: 0x170038FC RID: 14588
		// (get) Token: 0x0600B7EB RID: 47083 RVA: 0x002DA6B4 File Offset: 0x002D88B4
		// (set) Token: 0x0600B7EC RID: 47084 RVA: 0x0005A493 File Offset: 0x00058693
		public unsafe static byte Release
		{
			get
			{
				byte result;
				IL2CPP.il2cpp_field_static_get_value(VersionInfo.NativeFieldInfoPtr_Release, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VersionInfo.NativeFieldInfoPtr_Release, (void*)(&value));
			}
		}

		// Token: 0x170038FD RID: 14589
		// (get) Token: 0x0600B7ED RID: 47085 RVA: 0x002DA6D0 File Offset: 0x002D88D0
		// (set) Token: 0x0600B7EE RID: 47086 RVA: 0x0005A4A1 File Offset: 0x000586A1
		public unsafe static string StageSuffix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VersionInfo.NativeFieldInfoPtr_StageSuffix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VersionInfo.NativeFieldInfoPtr_StageSuffix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170038FE RID: 14590
		// (get) Token: 0x0600B7EF RID: 47087 RVA: 0x002DA6F0 File Offset: 0x002D88F0
		// (set) Token: 0x0600B7F0 RID: 47088 RVA: 0x0005A4B3 File Offset: 0x000586B3
		public unsafe static string TrialSuffix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VersionInfo.NativeFieldInfoPtr_TrialSuffix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VersionInfo.NativeFieldInfoPtr_TrialSuffix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170038FF RID: 14591
		// (get) Token: 0x0600B7F1 RID: 47089 RVA: 0x002DA710 File Offset: 0x002D8910
		// (set) Token: 0x0600B7F2 RID: 47090 RVA: 0x0005A4C5 File Offset: 0x000586C5
		public unsafe int m_major
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionInfo.NativeFieldInfoPtr_m_major);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionInfo.NativeFieldInfoPtr_m_major)) = value;
			}
		}

		// Token: 0x17003900 RID: 14592
		// (get) Token: 0x0600B7F3 RID: 47091 RVA: 0x002DA738 File Offset: 0x002D8938
		// (set) Token: 0x0600B7F4 RID: 47092 RVA: 0x0005A4E0 File Offset: 0x000586E0
		public unsafe int m_minor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionInfo.NativeFieldInfoPtr_m_minor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionInfo.NativeFieldInfoPtr_m_minor)) = value;
			}
		}

		// Token: 0x17003901 RID: 14593
		// (get) Token: 0x0600B7F5 RID: 47093 RVA: 0x002DA760 File Offset: 0x002D8960
		// (set) Token: 0x0600B7F6 RID: 47094 RVA: 0x0005A4FB File Offset: 0x000586FB
		public unsafe int m_release
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionInfo.NativeFieldInfoPtr_m_release);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionInfo.NativeFieldInfoPtr_m_release)) = value;
			}
		}

		// Token: 0x04007BE5 RID: 31717
		private static readonly IntPtr NativeFieldInfoPtr_Major;

		// Token: 0x04007BE6 RID: 31718
		private static readonly IntPtr NativeFieldInfoPtr_Minor;

		// Token: 0x04007BE7 RID: 31719
		private static readonly IntPtr NativeFieldInfoPtr_Release;

		// Token: 0x04007BE8 RID: 31720
		private static readonly IntPtr NativeFieldInfoPtr_StageSuffix;

		// Token: 0x04007BE9 RID: 31721
		private static readonly IntPtr NativeFieldInfoPtr_TrialSuffix;

		// Token: 0x04007BEA RID: 31722
		private static readonly IntPtr NativeFieldInfoPtr_m_major;

		// Token: 0x04007BEB RID: 31723
		private static readonly IntPtr NativeFieldInfoPtr_m_minor;

		// Token: 0x04007BEC RID: 31724
		private static readonly IntPtr NativeFieldInfoPtr_m_release;

		// Token: 0x04007BED RID: 31725
		private static readonly IntPtr NativeMethodInfoPtr_StaticToString_Public_Static_String_0;

		// Token: 0x04007BEE RID: 31726
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04007BEF RID: 31727
		private static readonly IntPtr NativeMethodInfoPtr_get_FullNumber_Public_Static_get_Int32_0;

		// Token: 0x04007BF0 RID: 31728
		private static readonly IntPtr NativeMethodInfoPtr_get_Number_Public_get_Int32_0;

		// Token: 0x04007BF1 RID: 31729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04007BF2 RID: 31730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Byte_Byte_Byte_0;

		// Token: 0x04007BF3 RID: 31731
		private static readonly IntPtr NativeMethodInfoPtr_Current_Public_Static_VersionInfo_0;

		// Token: 0x04007BF4 RID: 31732
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Static_Boolean_VersionInfo_0;
	}
}
