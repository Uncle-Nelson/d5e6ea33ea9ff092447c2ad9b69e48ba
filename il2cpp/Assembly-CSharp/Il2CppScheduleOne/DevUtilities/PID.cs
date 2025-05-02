using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000464 RID: 1124
	[Serializable]
	public class PID : Object
	{
		// Token: 0x06006194 RID: 24980 RVA: 0x001BCF44 File Offset: 0x001BB144
		// Note: this type is marked as 'beforefieldinit'.
		static PID()
		{
			Il2CppClassPointerStore<PID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PID>.NativeClassPtr);
			PID.NativeFieldInfoPtr_pFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "pFactor");
			PID.NativeFieldInfoPtr_iFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "iFactor");
			PID.NativeFieldInfoPtr_dFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "dFactor");
			PID.NativeFieldInfoPtr_integral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "integral");
			PID.NativeFieldInfoPtr_lastError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "lastError");
			PID.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PID>.NativeClassPtr, 100675698);
			PID.NativeMethodInfoPtr_Update_Public_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PID>.NativeClassPtr, 100675699);
		}

		// Token: 0x06006195 RID: 24981 RVA: 0x001BD000 File Offset: 0x001BB200
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201143, RefRangeEnd = 201145, XrefRangeStart = 201142, XrefRangeEnd = 201143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PID(float pFactor, float iFactor, float dFactor) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PID>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pFactor;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iFactor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PID.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006196 RID: 24982 RVA: 0x001BD064 File Offset: 0x001BB264
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 201145, RefRangeEnd = 201148, XrefRangeStart = 201145, XrefRangeEnd = 201145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Update(float setpoint, float actual, float timeFrame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref setpoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actual;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeFrame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PID.NativeMethodInfoPtr_Update_Public_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006197 RID: 24983 RVA: 0x0002E1FA File Offset: 0x0002C3FA
		public PID(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x06006198 RID: 24984 RVA: 0x001BD0CC File Offset: 0x001BB2CC
		// (set) Token: 0x06006199 RID: 24985 RVA: 0x0002E203 File Offset: 0x0002C403
		public unsafe float pFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_pFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_pFactor)) = value;
			}
		}

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x0600619A RID: 24986 RVA: 0x001BD0F4 File Offset: 0x001BB2F4
		// (set) Token: 0x0600619B RID: 24987 RVA: 0x0002E21E File Offset: 0x0002C41E
		public unsafe float iFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_iFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_iFactor)) = value;
			}
		}

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x0600619C RID: 24988 RVA: 0x001BD11C File Offset: 0x001BB31C
		// (set) Token: 0x0600619D RID: 24989 RVA: 0x0002E239 File Offset: 0x0002C439
		public unsafe float dFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_dFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_dFactor)) = value;
			}
		}

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x0600619E RID: 24990 RVA: 0x001BD144 File Offset: 0x001BB344
		// (set) Token: 0x0600619F RID: 24991 RVA: 0x0002E254 File Offset: 0x0002C454
		public unsafe float integral
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_integral);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_integral)) = value;
			}
		}

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x060061A0 RID: 24992 RVA: 0x001BD16C File Offset: 0x001BB36C
		// (set) Token: 0x060061A1 RID: 24993 RVA: 0x0002E26F File Offset: 0x0002C46F
		public unsafe float lastError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_lastError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_lastError)) = value;
			}
		}

		// Token: 0x04004292 RID: 17042
		private static readonly IntPtr NativeFieldInfoPtr_pFactor;

		// Token: 0x04004293 RID: 17043
		private static readonly IntPtr NativeFieldInfoPtr_iFactor;

		// Token: 0x04004294 RID: 17044
		private static readonly IntPtr NativeFieldInfoPtr_dFactor;

		// Token: 0x04004295 RID: 17045
		private static readonly IntPtr NativeFieldInfoPtr_integral;

		// Token: 0x04004296 RID: 17046
		private static readonly IntPtr NativeFieldInfoPtr_lastError;

		// Token: 0x04004297 RID: 17047
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x04004298 RID: 17048
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Single_Single_Single_Single_0;
	}
}
