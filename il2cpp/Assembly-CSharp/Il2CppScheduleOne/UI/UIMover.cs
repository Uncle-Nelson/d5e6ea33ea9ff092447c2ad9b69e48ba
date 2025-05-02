using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200066F RID: 1647
	public class UIMover : MonoBehaviour
	{
		// Token: 0x06009301 RID: 37633 RVA: 0x0025E0BC File Offset: 0x0025C2BC
		// Note: this type is marked as 'beforefieldinit'.
		static UIMover()
		{
			Il2CppClassPointerStore<UIMover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "UIMover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIMover>.NativeClassPtr);
			UIMover.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "Rect");
			UIMover.NativeFieldInfoPtr_MinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "MinSpeed");
			UIMover.NativeFieldInfoPtr_MaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "MaxSpeed");
			UIMover.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "SpeedMultiplier");
			UIMover.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "speed");
			UIMover.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMover>.NativeClassPtr, 100681533);
			UIMover.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMover>.NativeClassPtr, 100681534);
			UIMover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMover>.NativeClassPtr, 100681535);
		}

		// Token: 0x06009302 RID: 37634 RVA: 0x0025E18C File Offset: 0x0025C38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265273, XrefRangeEnd = 265275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMover.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009303 RID: 37635 RVA: 0x0025E1C0 File Offset: 0x0025C3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265275, XrefRangeEnd = 265279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMover.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009304 RID: 37636 RVA: 0x0025E1F4 File Offset: 0x0025C3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265279, XrefRangeEnd = 265286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIMover() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIMover>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009305 RID: 37637 RVA: 0x000472DA File Offset: 0x000454DA
		public UIMover(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D0E RID: 11534
		// (get) Token: 0x06009306 RID: 37638 RVA: 0x0025E230 File Offset: 0x0025C430
		// (set) Token: 0x06009307 RID: 37639 RVA: 0x000472E3 File Offset: 0x000454E3
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D0F RID: 11535
		// (get) Token: 0x06009308 RID: 37640 RVA: 0x0025E260 File Offset: 0x0025C460
		// (set) Token: 0x06009309 RID: 37641 RVA: 0x00047302 File Offset: 0x00045502
		public unsafe Vector2 MinSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_MinSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_MinSpeed)) = value;
			}
		}

		// Token: 0x17002D10 RID: 11536
		// (get) Token: 0x0600930A RID: 37642 RVA: 0x0025E288 File Offset: 0x0025C488
		// (set) Token: 0x0600930B RID: 37643 RVA: 0x0004731D File Offset: 0x0004551D
		public unsafe Vector2 MaxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_MaxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_MaxSpeed)) = value;
			}
		}

		// Token: 0x17002D11 RID: 11537
		// (get) Token: 0x0600930C RID: 37644 RVA: 0x0025E2B0 File Offset: 0x0025C4B0
		// (set) Token: 0x0600930D RID: 37645 RVA: 0x00047338 File Offset: 0x00045538
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17002D12 RID: 11538
		// (get) Token: 0x0600930E RID: 37646 RVA: 0x0025E2D8 File Offset: 0x0025C4D8
		// (set) Token: 0x0600930F RID: 37647 RVA: 0x00047353 File Offset: 0x00045553
		public unsafe Vector2 speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x04006346 RID: 25414
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04006347 RID: 25415
		private static readonly IntPtr NativeFieldInfoPtr_MinSpeed;

		// Token: 0x04006348 RID: 25416
		private static readonly IntPtr NativeFieldInfoPtr_MaxSpeed;

		// Token: 0x04006349 RID: 25417
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x0400634A RID: 25418
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x0400634B RID: 25419
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400634C RID: 25420
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400634D RID: 25421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
