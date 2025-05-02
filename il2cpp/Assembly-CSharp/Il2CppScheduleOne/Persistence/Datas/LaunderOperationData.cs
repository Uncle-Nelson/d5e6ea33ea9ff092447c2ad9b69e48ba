using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200026F RID: 623
	[Serializable]
	public class LaunderOperationData : SaveData
	{
		// Token: 0x06002F60 RID: 12128 RVA: 0x00107888 File Offset: 0x00105A88
		// Note: this type is marked as 'beforefieldinit'.
		static LaunderOperationData()
		{
			Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "LaunderOperationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr);
			LaunderOperationData.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr, "Amount");
			LaunderOperationData.NativeFieldInfoPtr_MinutesSinceStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr, "MinutesSinceStarted");
			LaunderOperationData.NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr, 100668773);
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x001078F4 File Offset: 0x00105AF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130722, RefRangeEnd = 130723, XrefRangeStart = 130721, XrefRangeEnd = 130722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LaunderOperationData(float amount, int minutesSinceStarted) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderOperationData.NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x0001913E File Offset: 0x0001733E
		public LaunderOperationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06002F63 RID: 12131 RVA: 0x0010794C File Offset: 0x00105B4C
		// (set) Token: 0x06002F64 RID: 12132 RVA: 0x00019147 File Offset: 0x00017347
		public unsafe float Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderOperationData.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderOperationData.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06002F65 RID: 12133 RVA: 0x00107974 File Offset: 0x00105B74
		// (set) Token: 0x06002F66 RID: 12134 RVA: 0x00019162 File Offset: 0x00017362
		public unsafe int MinutesSinceStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderOperationData.NativeFieldInfoPtr_MinutesSinceStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderOperationData.NativeFieldInfoPtr_MinutesSinceStarted)) = value;
			}
		}

		// Token: 0x04001F3D RID: 7997
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x04001F3E RID: 7998
		private static readonly IntPtr NativeFieldInfoPtr_MinutesSinceStarted;

		// Token: 0x04001F3F RID: 7999
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0;
	}
}
