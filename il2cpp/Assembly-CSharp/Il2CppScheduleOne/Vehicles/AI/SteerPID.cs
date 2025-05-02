using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000506 RID: 1286
	public class SteerPID : Object
	{
		// Token: 0x06007133 RID: 28979 RVA: 0x001F0D9C File Offset: 0x001EEF9C
		// Note: this type is marked as 'beforefieldinit'.
		static SteerPID()
		{
			Il2CppClassPointerStore<SteerPID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "SteerPID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteerPID>.NativeClassPtr);
			SteerPID.NativeFieldInfoPtr_error_old = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, "error_old");
			SteerPID.NativeFieldInfoPtr_error_sum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, "error_sum");
			SteerPID.NativeMethodInfoPtr_GetNewValue_Public_Single_Single_PID_Parameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, 100677529);
			SteerPID.NativeMethodInfoPtr_AddValueToAverage_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, 100677530);
			SteerPID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, 100677531);
		}

		// Token: 0x06007134 RID: 28980 RVA: 0x001F0E30 File Offset: 0x001EF030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222617, XrefRangeEnd = 222619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNewValue(float error, PID_Parameters pid_parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref error;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pid_parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteerPID.NativeMethodInfoPtr_GetNewValue_Public_Single_Single_PID_Parameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007135 RID: 28981 RVA: 0x001F0E88 File Offset: 0x001EF088
		[CallerCount(0)]
		public unsafe static float AddValueToAverage(float oldAverage, float valueToAdd, float count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldAverage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueToAdd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteerPID.NativeMethodInfoPtr_AddValueToAverage_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007136 RID: 28982 RVA: 0x001F0EE4 File Offset: 0x001EF0E4
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteerPID() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteerPID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteerPID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007137 RID: 28983 RVA: 0x00035C6C File Offset: 0x00033E6C
		public SteerPID(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002234 RID: 8756
		// (get) Token: 0x06007138 RID: 28984 RVA: 0x001F0F20 File Offset: 0x001EF120
		// (set) Token: 0x06007139 RID: 28985 RVA: 0x00035C75 File Offset: 0x00033E75
		public unsafe float error_old
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteerPID.NativeFieldInfoPtr_error_old);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteerPID.NativeFieldInfoPtr_error_old)) = value;
			}
		}

		// Token: 0x17002235 RID: 8757
		// (get) Token: 0x0600713A RID: 28986 RVA: 0x001F0F48 File Offset: 0x001EF148
		// (set) Token: 0x0600713B RID: 28987 RVA: 0x00035C90 File Offset: 0x00033E90
		public unsafe float error_sum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteerPID.NativeFieldInfoPtr_error_sum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteerPID.NativeFieldInfoPtr_error_sum)) = value;
			}
		}

		// Token: 0x04004D4C RID: 19788
		private static readonly IntPtr NativeFieldInfoPtr_error_old;

		// Token: 0x04004D4D RID: 19789
		private static readonly IntPtr NativeFieldInfoPtr_error_sum;

		// Token: 0x04004D4E RID: 19790
		private static readonly IntPtr NativeMethodInfoPtr_GetNewValue_Public_Single_Single_PID_Parameters_0;

		// Token: 0x04004D4F RID: 19791
		private static readonly IntPtr NativeMethodInfoPtr_AddValueToAverage_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04004D50 RID: 19792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
