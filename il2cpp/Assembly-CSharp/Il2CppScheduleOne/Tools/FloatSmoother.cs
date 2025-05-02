using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200053A RID: 1338
	[Serializable]
	public class FloatSmoother : Object
	{
		// Token: 0x060076E1 RID: 30433 RVA: 0x002047AC File Offset: 0x002029AC
		// Note: this type is marked as 'beforefieldinit'.
		static FloatSmoother()
		{
			Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "FloatSmoother");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr);
			FloatSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<CurrentValue>k__BackingField");
			FloatSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<Multiplier>k__BackingField");
			FloatSmoother.NativeFieldInfoPtr_DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "DefaultValue");
			FloatSmoother.NativeFieldInfoPtr_SmoothingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "SmoothingSpeed");
			FloatSmoother.NativeFieldInfoPtr_overrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "overrides");
			FloatSmoother.NativeMethodInfoPtr_get_CurrentValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678265);
			FloatSmoother.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678266);
			FloatSmoother.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678267);
			FloatSmoother.NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678268);
			FloatSmoother.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678269);
			FloatSmoother.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678270);
			FloatSmoother.NativeMethodInfoPtr_SetDefault_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678271);
			FloatSmoother.NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678272);
			FloatSmoother.NativeMethodInfoPtr_SetSmoothingSpeed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678273);
			FloatSmoother.NativeMethodInfoPtr_AddOverride_Public_Void_Single_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678274);
			FloatSmoother.NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678275);
			FloatSmoother.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678276);
			FloatSmoother.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678277);
		}

		// Token: 0x170023FD RID: 9213
		// (get) Token: 0x060076E2 RID: 30434 RVA: 0x00204944 File Offset: 0x00202B44
		// (set) Token: 0x060076E3 RID: 30435 RVA: 0x00204980 File Offset: 0x00202B80
		public unsafe float CurrentValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_get_CurrentValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 29950, RefRangeEnd = 29954, XrefRangeStart = 29950, XrefRangeEnd = 29954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170023FE RID: 9214
		// (get) Token: 0x060076E4 RID: 30436 RVA: 0x002049C0 File Offset: 0x00202BC0
		// (set) Token: 0x060076E5 RID: 30437 RVA: 0x002049FC File Offset: 0x00202BFC
		public unsafe float Multiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27829, RefRangeEnd = 27830, XrefRangeStart = 27829, XrefRangeEnd = 27830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060076E6 RID: 30438 RVA: 0x00204A3C File Offset: 0x00202C3C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 231316, RefRangeEnd = 231329, XrefRangeStart = 231295, XrefRangeEnd = 231316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076E7 RID: 30439 RVA: 0x00204A70 File Offset: 0x00202C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231329, XrefRangeEnd = 231347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076E8 RID: 30440 RVA: 0x00204AA4 File Offset: 0x00202CA4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 231350, RefRangeEnd = 231361, XrefRangeStart = 231347, XrefRangeEnd = 231350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefault(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_SetDefault_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076E9 RID: 30441 RVA: 0x00204AE4 File Offset: 0x00202CE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 27829, RefRangeEnd = 27830, XrefRangeStart = 27829, XrefRangeEnd = 27830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMultiplier(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076EA RID: 30442 RVA: 0x00204B24 File Offset: 0x00202D24
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 29999, RefRangeEnd = 30010, XrefRangeStart = 29999, XrefRangeEnd = 30010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSmoothingSpeed(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_SetSmoothingSpeed_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076EB RID: 30443 RVA: 0x00204B64 File Offset: 0x00202D64
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 231405, RefRangeEnd = 231434, XrefRangeStart = 231361, XrefRangeEnd = 231405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOverride(float value, int priority, string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_AddOverride_Public_Void_Single_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076EC RID: 30444 RVA: 0x00204BC4 File Offset: 0x00202DC4
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 231470, RefRangeEnd = 231497, XrefRangeStart = 231434, XrefRangeEnd = 231470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOverride(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076ED RID: 30445 RVA: 0x00204C08 File Offset: 0x00202E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231497, XrefRangeEnd = 231503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076EE RID: 30446 RVA: 0x00204C3C File Offset: 0x00202E3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 231511, RefRangeEnd = 231512, XrefRangeStart = 231503, XrefRangeEnd = 231511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloatSmoother() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076EF RID: 30447 RVA: 0x00038539 File Offset: 0x00036739
		public FloatSmoother(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023F8 RID: 9208
		// (get) Token: 0x060076F0 RID: 30448 RVA: 0x00204C78 File Offset: 0x00202E78
		// (set) Token: 0x060076F1 RID: 30449 RVA: 0x00038542 File Offset: 0x00036742
		public unsafe float _CurrentValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField)) = value;
			}
		}

		// Token: 0x170023F9 RID: 9209
		// (get) Token: 0x060076F2 RID: 30450 RVA: 0x00204CA0 File Offset: 0x00202EA0
		// (set) Token: 0x060076F3 RID: 30451 RVA: 0x0003855D File Offset: 0x0003675D
		public unsafe float _Multiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x170023FA RID: 9210
		// (get) Token: 0x060076F4 RID: 30452 RVA: 0x00204CC8 File Offset: 0x00202EC8
		// (set) Token: 0x060076F5 RID: 30453 RVA: 0x00038578 File Offset: 0x00036778
		public unsafe float DefaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_DefaultValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_DefaultValue)) = value;
			}
		}

		// Token: 0x170023FB RID: 9211
		// (get) Token: 0x060076F6 RID: 30454 RVA: 0x00204CF0 File Offset: 0x00202EF0
		// (set) Token: 0x060076F7 RID: 30455 RVA: 0x00038593 File Offset: 0x00036793
		public unsafe float SmoothingSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_SmoothingSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_SmoothingSpeed)) = value;
			}
		}

		// Token: 0x170023FC RID: 9212
		// (get) Token: 0x060076F8 RID: 30456 RVA: 0x00204D18 File Offset: 0x00202F18
		// (set) Token: 0x060076F9 RID: 30457 RVA: 0x000385AE File Offset: 0x000367AE
		public unsafe List<FloatSmoother.Override> overrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_overrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FloatSmoother.Override>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_overrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400512A RID: 20778
		private static readonly IntPtr NativeFieldInfoPtr__CurrentValue_k__BackingField;

		// Token: 0x0400512B RID: 20779
		private static readonly IntPtr NativeFieldInfoPtr__Multiplier_k__BackingField;

		// Token: 0x0400512C RID: 20780
		private static readonly IntPtr NativeFieldInfoPtr_DefaultValue;

		// Token: 0x0400512D RID: 20781
		private static readonly IntPtr NativeFieldInfoPtr_SmoothingSpeed;

		// Token: 0x0400512E RID: 20782
		private static readonly IntPtr NativeFieldInfoPtr_overrides;

		// Token: 0x0400512F RID: 20783
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_get_Single_0;

		// Token: 0x04005130 RID: 20784
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Single_0;

		// Token: 0x04005131 RID: 20785
		private static readonly IntPtr NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0;

		// Token: 0x04005132 RID: 20786
		private static readonly IntPtr NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0;

		// Token: 0x04005133 RID: 20787
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x04005134 RID: 20788
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x04005135 RID: 20789
		private static readonly IntPtr NativeMethodInfoPtr_SetDefault_Public_Void_Single_0;

		// Token: 0x04005136 RID: 20790
		private static readonly IntPtr NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0;

		// Token: 0x04005137 RID: 20791
		private static readonly IntPtr NativeMethodInfoPtr_SetSmoothingSpeed_Public_Void_Single_0;

		// Token: 0x04005138 RID: 20792
		private static readonly IntPtr NativeMethodInfoPtr_AddOverride_Public_Void_Single_Int32_String_0;

		// Token: 0x04005139 RID: 20793
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0;

		// Token: 0x0400513A RID: 20794
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400513B RID: 20795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A9E RID: 2718
		public class Override : Object
		{
			// Token: 0x0600D2FB RID: 54011 RVA: 0x00327108 File Offset: 0x00325308
			// Note: this type is marked as 'beforefieldinit'.
			static Override()
			{
				Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "Override");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr);
				FloatSmoother.Override.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr, "Value");
				FloatSmoother.Override.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr, "Priority");
				FloatSmoother.Override.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr, "Label");
				FloatSmoother.Override.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr, 100678278);
			}

			// Token: 0x0600D2FC RID: 54012 RVA: 0x00327184 File Offset: 0x00325384
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Override() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.Override.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2FD RID: 54013 RVA: 0x00066B3A File Offset: 0x00064D3A
			public Override(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004171 RID: 16753
			// (get) Token: 0x0600D2FE RID: 54014 RVA: 0x003271C0 File Offset: 0x003253C0
			// (set) Token: 0x0600D2FF RID: 54015 RVA: 0x00066B43 File Offset: 0x00064D43
			public unsafe float Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Value)) = value;
				}
			}

			// Token: 0x17004172 RID: 16754
			// (get) Token: 0x0600D300 RID: 54016 RVA: 0x003271E8 File Offset: 0x003253E8
			// (set) Token: 0x0600D301 RID: 54017 RVA: 0x00066B5E File Offset: 0x00064D5E
			public unsafe int Priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Priority)) = value;
				}
			}

			// Token: 0x17004173 RID: 16755
			// (get) Token: 0x0600D302 RID: 54018 RVA: 0x00327210 File Offset: 0x00325410
			// (set) Token: 0x0600D303 RID: 54019 RVA: 0x00066B79 File Offset: 0x00064D79
			public unsafe string Label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008E36 RID: 36406
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04008E37 RID: 36407
			private static readonly IntPtr NativeFieldInfoPtr_Priority;

			// Token: 0x04008E38 RID: 36408
			private static readonly IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x04008E39 RID: 36409
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A9F RID: 2719
		[ObfuscatedName("ScheduleOne.Tools.FloatSmoother+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600D304 RID: 54020 RVA: 0x00327238 File Offset: 0x00325438
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr);
				FloatSmoother.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, "<>9");
				FloatSmoother.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, "<>9__17_1");
				FloatSmoother.__c.NativeFieldInfoPtr___9__18_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, "<>9__18_1");
				FloatSmoother.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, 100678280);
				FloatSmoother.__c.NativeMethodInfoPtr__AddOverride_b__17_1_Internal_Int32_Override_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, 100678281);
				FloatSmoother.__c.NativeMethodInfoPtr__RemoveOverride_b__18_1_Internal_Int32_Override_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, 100678282);
			}

			// Token: 0x0600D305 RID: 54021 RVA: 0x003272DC File Offset: 0x003254DC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D306 RID: 54022 RVA: 0x00327318 File Offset: 0x00325518
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231289, XrefRangeEnd = 231291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AddOverride_b__17_1(FloatSmoother.Override x, FloatSmoother.Override y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c.NativeMethodInfoPtr__AddOverride_b__17_1_Internal_Int32_Override_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D307 RID: 54023 RVA: 0x00327378 File Offset: 0x00325578
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RemoveOverride_b__18_1(FloatSmoother.Override x, FloatSmoother.Override y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c.NativeMethodInfoPtr__RemoveOverride_b__18_1_Internal_Int32_Override_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D308 RID: 54024 RVA: 0x00066B98 File Offset: 0x00064D98
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004174 RID: 16756
			// (get) Token: 0x0600D309 RID: 54025 RVA: 0x003273D8 File Offset: 0x003255D8
			// (set) Token: 0x0600D30A RID: 54026 RVA: 0x00066BA1 File Offset: 0x00064DA1
			public unsafe static FloatSmoother.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FloatSmoother.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FloatSmoother.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004175 RID: 16757
			// (get) Token: 0x0600D30B RID: 54027 RVA: 0x00327400 File Offset: 0x00325600
			// (set) Token: 0x0600D30C RID: 54028 RVA: 0x00066BB3 File Offset: 0x00064DB3
			public unsafe static Comparison<FloatSmoother.Override> __9__17_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FloatSmoother.__c.NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<FloatSmoother.Override>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FloatSmoother.__c.NativeFieldInfoPtr___9__17_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004176 RID: 16758
			// (get) Token: 0x0600D30D RID: 54029 RVA: 0x00327428 File Offset: 0x00325628
			// (set) Token: 0x0600D30E RID: 54030 RVA: 0x00066BC5 File Offset: 0x00064DC5
			public unsafe static Comparison<FloatSmoother.Override> __9__18_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FloatSmoother.__c.NativeFieldInfoPtr___9__18_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<FloatSmoother.Override>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FloatSmoother.__c.NativeFieldInfoPtr___9__18_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E3A RID: 36410
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008E3B RID: 36411
			private static readonly IntPtr NativeFieldInfoPtr___9__17_1;

			// Token: 0x04008E3C RID: 36412
			private static readonly IntPtr NativeFieldInfoPtr___9__18_1;

			// Token: 0x04008E3D RID: 36413
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E3E RID: 36414
			private static readonly IntPtr NativeMethodInfoPtr__AddOverride_b__17_1_Internal_Int32_Override_Override_0;

			// Token: 0x04008E3F RID: 36415
			private static readonly IntPtr NativeMethodInfoPtr__RemoveOverride_b__18_1_Internal_Int32_Override_Override_0;
		}

		// Token: 0x02000AA0 RID: 2720
		[ObfuscatedName("ScheduleOne.Tools.FloatSmoother+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x0600D30F RID: 54031 RVA: 0x00327450 File Offset: 0x00325650
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr);
				FloatSmoother.__c__DisplayClass17_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr, "label");
				FloatSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr, 100678283);
				FloatSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr, 100678284);
			}

			// Token: 0x0600D310 RID: 54032 RVA: 0x003274B8 File Offset: 0x003256B8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D311 RID: 54033 RVA: 0x003274F4 File Offset: 0x003256F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231291, XrefRangeEnd = 231295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddOverride_b__0(FloatSmoother.Override x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D312 RID: 54034 RVA: 0x00066BD7 File Offset: 0x00064DD7
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004177 RID: 16759
			// (get) Token: 0x0600D313 RID: 54035 RVA: 0x00327544 File Offset: 0x00325744
			// (set) Token: 0x0600D314 RID: 54036 RVA: 0x00066BE0 File Offset: 0x00064DE0
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.__c__DisplayClass17_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.__c__DisplayClass17_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008E40 RID: 36416
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04008E41 RID: 36417
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E42 RID: 36418
			private static readonly IntPtr NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0;
		}

		// Token: 0x02000AA1 RID: 2721
		[ObfuscatedName("ScheduleOne.Tools.FloatSmoother+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Object
		{
			// Token: 0x0600D315 RID: 54037 RVA: 0x0032756C File Offset: 0x0032576C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr);
				FloatSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr, "label");
				FloatSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr, 100678285);
				FloatSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr, 100678286);
			}

			// Token: 0x0600D316 RID: 54038 RVA: 0x003275D4 File Offset: 0x003257D4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D317 RID: 54039 RVA: 0x00327610 File Offset: 0x00325810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveOverride_b__0(FloatSmoother.Override x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D318 RID: 54040 RVA: 0x00066BFF File Offset: 0x00064DFF
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004178 RID: 16760
			// (get) Token: 0x0600D319 RID: 54041 RVA: 0x00327660 File Offset: 0x00325860
			// (set) Token: 0x0600D31A RID: 54042 RVA: 0x00066C08 File Offset: 0x00064E08
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008E43 RID: 36419
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04008E44 RID: 36420
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E45 RID: 36421
			private static readonly IntPtr NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0;
		}
	}
}
