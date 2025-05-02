using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x0200014B RID: 331
	[Serializable]
	public class MinMaxIndex : Object
	{
		// Token: 0x06001B86 RID: 7046 RVA: 0x000C680C File Offset: 0x000C4A0C
		// Note: this type is marked as 'beforefieldinit'.
		static MinMaxIndex()
		{
			Il2CppClassPointerStore<MinMaxIndex>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "MinMaxIndex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxIndex>.NativeClassPtr);
			MinMaxIndex.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxIndex>.NativeClassPtr, "Min");
			MinMaxIndex.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxIndex>.NativeClassPtr, "Max");
			MinMaxIndex.NativeMethodInfoPtr_GetRandom_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxIndex>.NativeClassPtr, 100666221);
			MinMaxIndex.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxIndex>.NativeClassPtr, 100666222);
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x000C688C File Offset: 0x000C4A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100452, XrefRangeEnd = 100453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRandom(int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxIndex.NativeMethodInfoPtr_GetRandom_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x000C68D8 File Offset: 0x000C4AD8
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinMaxIndex() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinMaxIndex>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxIndex.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0000F995 File Offset: 0x0000DB95
		public MinMaxIndex(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001B8A RID: 7050 RVA: 0x000C6914 File Offset: 0x000C4B14
		// (set) Token: 0x06001B8B RID: 7051 RVA: 0x0000F99E File Offset: 0x0000DB9E
		public unsafe int Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxIndex.NativeFieldInfoPtr_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxIndex.NativeFieldInfoPtr_Min)) = value;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001B8C RID: 7052 RVA: 0x000C693C File Offset: 0x000C4B3C
		// (set) Token: 0x06001B8D RID: 7053 RVA: 0x0000F9B9 File Offset: 0x0000DBB9
		public unsafe int Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxIndex.NativeFieldInfoPtr_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxIndex.NativeFieldInfoPtr_Max)) = value;
			}
		}

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeFieldInfoPtr_Min;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeFieldInfoPtr_Max;

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeMethodInfoPtr_GetRandom_Public_Int32_Int32_0;

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
