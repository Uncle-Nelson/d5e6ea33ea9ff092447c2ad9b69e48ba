using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Levelling
{
	// Token: 0x020003BC RID: 956
	[Serializable]
	[StructLayout(2)]
	public struct FullRank
	{
		// Token: 0x06004A6A RID: 19050 RVA: 0x00168DEC File Offset: 0x00166FEC
		// Note: this type is marked as 'beforefieldinit'.
		static FullRank()
		{
			Il2CppClassPointerStore<FullRank>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Levelling", "FullRank");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullRank>.NativeClassPtr);
			FullRank.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullRank>.NativeClassPtr, "Rank");
			FullRank.NativeFieldInfoPtr_Tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullRank>.NativeClassPtr, "Tier");
			FullRank.NativeMethodInfoPtr__ctor_Public_Void_ERank_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672513);
			FullRank.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672514);
			FullRank.NativeMethodInfoPtr_NextRank_Public_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672515);
			FullRank.NativeMethodInfoPtr_GetString_Public_Static_String_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672516);
			FullRank.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672517);
			FullRank.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672518);
			FullRank.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672519);
			FullRank.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672520);
			FullRank.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672521);
			FullRank.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672522);
			FullRank.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672523);
			FullRank.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672524);
			FullRank.NativeMethodInfoPtr_CompareTo_Public_Int32_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672525);
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x00168F48 File Offset: 0x00167148
		[CallerCount(94)]
		[CachedScanResults(RefRangeStart = 34315, RefRangeEnd = 34409, XrefRangeStart = 34315, XrefRangeEnd = 34409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullRank(ERank rank, int tier)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr__ctor_Public_Void_ERank_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x00168F88 File Offset: 0x00167188
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 164073, RefRangeEnd = 164082, XrefRangeStart = 164057, XrefRangeEnd = 164073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x00168FB4 File Offset: 0x001671B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164082, RefRangeEnd = 164084, XrefRangeStart = 164082, XrefRangeEnd = 164082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullRank NextRank()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_NextRank_Public_FullRank_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x00168FE4 File Offset: 0x001671E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 164100, RefRangeEnd = 164103, XrefRangeStart = 164084, XrefRangeEnd = 164100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(FullRank rank)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_GetString_Public_Static_String_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x0016901C File Offset: 0x0016721C
		[CallerCount(0)]
		public unsafe static bool operator >(FullRank a, FullRank b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x00169068 File Offset: 0x00167268
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164103, RefRangeEnd = 164105, XrefRangeStart = 164103, XrefRangeEnd = 164103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(FullRank a, FullRank b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A71 RID: 19057 RVA: 0x001690B4 File Offset: 0x001672B4
		[CallerCount(0)]
		public unsafe static bool operator <=(FullRank a, FullRank b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A72 RID: 19058 RVA: 0x00169100 File Offset: 0x00167300
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 164105, RefRangeEnd = 164109, XrefRangeStart = 164105, XrefRangeEnd = 164105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >=(FullRank a, FullRank b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x0016914C File Offset: 0x0016734C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58816, RefRangeEnd = 58818, XrefRangeStart = 58816, XrefRangeEnd = 58818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(FullRank a, FullRank b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x00169198 File Offset: 0x00167398
		[CallerCount(0)]
		public unsafe static bool operator !=(FullRank a, FullRank b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x001691E4 File Offset: 0x001673E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164109, XrefRangeEnd = 164112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x00169228 File Offset: 0x00167428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164112, XrefRangeEnd = 164116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x00169258 File Offset: 0x00167458
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164116, RefRangeEnd = 164118, XrefRangeStart = 164116, XrefRangeEnd = 164116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(FullRank other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_CompareTo_Public_Int32_FullRank_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x00023EB1 File Offset: 0x000220B1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FullRank>.NativeClassPtr, ref this));
		}

		// Token: 0x0400321D RID: 12829
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x0400321E RID: 12830
		private static readonly IntPtr NativeFieldInfoPtr_Tier;

		// Token: 0x0400321F RID: 12831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ERank_Int32_0;

		// Token: 0x04003220 RID: 12832
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003221 RID: 12833
		private static readonly IntPtr NativeMethodInfoPtr_NextRank_Public_FullRank_0;

		// Token: 0x04003222 RID: 12834
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_FullRank_0;

		// Token: 0x04003223 RID: 12835
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x04003224 RID: 12836
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x04003225 RID: 12837
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x04003226 RID: 12838
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x04003227 RID: 12839
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x04003228 RID: 12840
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x04003229 RID: 12841
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400322A RID: 12842
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400322B RID: 12843
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_FullRank_0;

		// Token: 0x0400322C RID: 12844
		[FieldOffset(0)]
		public ERank Rank;

		// Token: 0x0400322D RID: 12845
		[FieldOffset(4)]
		public int Tier;
	}
}
