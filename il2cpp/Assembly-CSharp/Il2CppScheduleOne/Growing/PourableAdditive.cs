using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200055D RID: 1373
	public class PourableAdditive : Pourable
	{
		// Token: 0x060078BB RID: 30907 RVA: 0x00209CC4 File Offset: 0x00207EC4
		// Note: this type is marked as 'beforefieldinit'.
		static PourableAdditive()
		{
			Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "PourableAdditive");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr);
			PourableAdditive.NativeFieldInfoPtr_NormalizedAmountForSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, "NormalizedAmountForSuccess");
			PourableAdditive.NativeFieldInfoPtr_AdditiveDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, "AdditiveDefinition");
			PourableAdditive.NativeFieldInfoPtr_LiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, "LiquidColor");
			PourableAdditive.NativeFieldInfoPtr_pouredAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, "pouredAmount");
			PourableAdditive.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, 100678439);
			PourableAdditive.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, 100678440);
		}

		// Token: 0x060078BC RID: 30908 RVA: 0x00209D6C File Offset: 0x00207F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232835, XrefRangeEnd = 232836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableAdditive.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078BD RID: 30909 RVA: 0x00209DB8 File Offset: 0x00207FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232836, XrefRangeEnd = 232837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourableAdditive() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableAdditive.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078BE RID: 30910 RVA: 0x000394C0 File Offset: 0x000376C0
		public PourableAdditive(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002482 RID: 9346
		// (get) Token: 0x060078BF RID: 30911 RVA: 0x00209DF4 File Offset: 0x00207FF4
		// (set) Token: 0x060078C0 RID: 30912 RVA: 0x000394C9 File Offset: 0x000376C9
		public unsafe static float NormalizedAmountForSuccess
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PourableAdditive.NativeFieldInfoPtr_NormalizedAmountForSuccess, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PourableAdditive.NativeFieldInfoPtr_NormalizedAmountForSuccess, (void*)(&value));
			}
		}

		// Token: 0x17002483 RID: 9347
		// (get) Token: 0x060078C1 RID: 30913 RVA: 0x00209E10 File Offset: 0x00208010
		// (set) Token: 0x060078C2 RID: 30914 RVA: 0x000394D7 File Offset: 0x000376D7
		public unsafe AdditiveDefinition AdditiveDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_AdditiveDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdditiveDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_AdditiveDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002484 RID: 9348
		// (get) Token: 0x060078C3 RID: 30915 RVA: 0x00209E40 File Offset: 0x00208040
		// (set) Token: 0x060078C4 RID: 30916 RVA: 0x000394F6 File Offset: 0x000376F6
		public unsafe Color LiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_LiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_LiquidColor)) = value;
			}
		}

		// Token: 0x17002485 RID: 9349
		// (get) Token: 0x060078C5 RID: 30917 RVA: 0x00209E68 File Offset: 0x00208068
		// (set) Token: 0x060078C6 RID: 30918 RVA: 0x00039511 File Offset: 0x00037711
		public unsafe float pouredAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_pouredAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_pouredAmount)) = value;
			}
		}

		// Token: 0x0400523E RID: 21054
		private static readonly IntPtr NativeFieldInfoPtr_NormalizedAmountForSuccess;

		// Token: 0x0400523F RID: 21055
		private static readonly IntPtr NativeFieldInfoPtr_AdditiveDefinition;

		// Token: 0x04005240 RID: 21056
		private static readonly IntPtr NativeFieldInfoPtr_LiquidColor;

		// Token: 0x04005241 RID: 21057
		private static readonly IntPtr NativeFieldInfoPtr_pouredAmount;

		// Token: 0x04005242 RID: 21058
		private static readonly IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0;

		// Token: 0x04005243 RID: 21059
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
