using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000657 RID: 1623
	public class EyelidOverlay : Singleton<EyelidOverlay>
	{
		// Token: 0x060090E4 RID: 37092 RVA: 0x00257B30 File Offset: 0x00255D30
		// Note: this type is marked as 'beforefieldinit'.
		static EyelidOverlay()
		{
			Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "EyelidOverlay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr);
			EyelidOverlay.NativeFieldInfoPtr_MaxTiredOpenAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "MaxTiredOpenAmount");
			EyelidOverlay.NativeFieldInfoPtr_AutoUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "AutoUpdate");
			EyelidOverlay.NativeFieldInfoPtr_Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Open");
			EyelidOverlay.NativeFieldInfoPtr_Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Closed");
			EyelidOverlay.NativeFieldInfoPtr_Upper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Upper");
			EyelidOverlay.NativeFieldInfoPtr_Lower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Lower");
			EyelidOverlay.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "Canvas");
			EyelidOverlay.NativeFieldInfoPtr_CurrentOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "CurrentOpen");
			EyelidOverlay.NativeFieldInfoPtr_OpenMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, "OpenMultiplier");
			EyelidOverlay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, 100681249);
			EyelidOverlay.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, 100681250);
			EyelidOverlay.NativeMethodInfoPtr_SetOpen_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, 100681251);
			EyelidOverlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr, 100681252);
		}

		// Token: 0x060090E5 RID: 37093 RVA: 0x00257C64 File Offset: 0x00255E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262465, XrefRangeEnd = 262471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EyelidOverlay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060090E6 RID: 37094 RVA: 0x00257CA0 File Offset: 0x00255EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262471, XrefRangeEnd = 262487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidOverlay.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060090E7 RID: 37095 RVA: 0x00257CD4 File Offset: 0x00255ED4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 262493, RefRangeEnd = 262498, XrefRangeStart = 262487, XrefRangeEnd = 262493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOpen(float openness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref openness;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidOverlay.NativeMethodInfoPtr_SetOpen_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060090E8 RID: 37096 RVA: 0x00257D14 File Offset: 0x00255F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262498, XrefRangeEnd = 262501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyelidOverlay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyelidOverlay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidOverlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060090E9 RID: 37097 RVA: 0x00045FFF File Offset: 0x000441FF
		public EyelidOverlay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C61 RID: 11361
		// (get) Token: 0x060090EA RID: 37098 RVA: 0x00257D50 File Offset: 0x00255F50
		// (set) Token: 0x060090EB RID: 37099 RVA: 0x00046008 File Offset: 0x00044208
		public unsafe static float MaxTiredOpenAmount
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyelidOverlay.NativeFieldInfoPtr_MaxTiredOpenAmount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyelidOverlay.NativeFieldInfoPtr_MaxTiredOpenAmount, (void*)(&value));
			}
		}

		// Token: 0x17002C62 RID: 11362
		// (get) Token: 0x060090EC RID: 37100 RVA: 0x00257D6C File Offset: 0x00255F6C
		// (set) Token: 0x060090ED RID: 37101 RVA: 0x00046016 File Offset: 0x00044216
		public unsafe bool AutoUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_AutoUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_AutoUpdate)) = value;
			}
		}

		// Token: 0x17002C63 RID: 11363
		// (get) Token: 0x060090EE RID: 37102 RVA: 0x00257D94 File Offset: 0x00255F94
		// (set) Token: 0x060090EF RID: 37103 RVA: 0x00046031 File Offset: 0x00044231
		public unsafe float Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Open)) = value;
			}
		}

		// Token: 0x17002C64 RID: 11364
		// (get) Token: 0x060090F0 RID: 37104 RVA: 0x00257DBC File Offset: 0x00255FBC
		// (set) Token: 0x060090F1 RID: 37105 RVA: 0x0004604C File Offset: 0x0004424C
		public unsafe float Closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Closed)) = value;
			}
		}

		// Token: 0x17002C65 RID: 11365
		// (get) Token: 0x060090F2 RID: 37106 RVA: 0x00257DE4 File Offset: 0x00255FE4
		// (set) Token: 0x060090F3 RID: 37107 RVA: 0x00046067 File Offset: 0x00044267
		public unsafe RectTransform Upper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Upper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Upper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C66 RID: 11366
		// (get) Token: 0x060090F4 RID: 37108 RVA: 0x00257E14 File Offset: 0x00256014
		// (set) Token: 0x060090F5 RID: 37109 RVA: 0x00046086 File Offset: 0x00044286
		public unsafe RectTransform Lower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Lower);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Lower), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C67 RID: 11367
		// (get) Token: 0x060090F6 RID: 37110 RVA: 0x00257E44 File Offset: 0x00256044
		// (set) Token: 0x060090F7 RID: 37111 RVA: 0x000460A5 File Offset: 0x000442A5
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C68 RID: 11368
		// (get) Token: 0x060090F8 RID: 37112 RVA: 0x00257E74 File Offset: 0x00256074
		// (set) Token: 0x060090F9 RID: 37113 RVA: 0x000460C4 File Offset: 0x000442C4
		public unsafe float CurrentOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_CurrentOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_CurrentOpen)) = value;
			}
		}

		// Token: 0x17002C69 RID: 11369
		// (get) Token: 0x060090FA RID: 37114 RVA: 0x00257E9C File Offset: 0x0025609C
		// (set) Token: 0x060090FB RID: 37115 RVA: 0x000460DF File Offset: 0x000442DF
		public unsafe FloatSmoother OpenMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_OpenMultiplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidOverlay.NativeFieldInfoPtr_OpenMultiplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040061F6 RID: 25078
		private static readonly IntPtr NativeFieldInfoPtr_MaxTiredOpenAmount;

		// Token: 0x040061F7 RID: 25079
		private static readonly IntPtr NativeFieldInfoPtr_AutoUpdate;

		// Token: 0x040061F8 RID: 25080
		private static readonly IntPtr NativeFieldInfoPtr_Open;

		// Token: 0x040061F9 RID: 25081
		private static readonly IntPtr NativeFieldInfoPtr_Closed;

		// Token: 0x040061FA RID: 25082
		private static readonly IntPtr NativeFieldInfoPtr_Upper;

		// Token: 0x040061FB RID: 25083
		private static readonly IntPtr NativeFieldInfoPtr_Lower;

		// Token: 0x040061FC RID: 25084
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040061FD RID: 25085
		private static readonly IntPtr NativeFieldInfoPtr_CurrentOpen;

		// Token: 0x040061FE RID: 25086
		private static readonly IntPtr NativeFieldInfoPtr_OpenMultiplier;

		// Token: 0x040061FF RID: 25087
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006200 RID: 25088
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006201 RID: 25089
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Void_Single_0;

		// Token: 0x04006202 RID: 25090
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
