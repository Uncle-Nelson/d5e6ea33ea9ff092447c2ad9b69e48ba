using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000125 RID: 293
	public class BaseSpriteItemData : Il2CppSystem.Object
	{
		// Token: 0x06001908 RID: 6408 RVA: 0x000BEB48 File Offset: 0x000BCD48
		// Note: this type is marked as 'beforefieldinit'.
		static BaseSpriteItemData()
		{
			Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BaseSpriteItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr);
			BaseSpriteItemData.NativeFieldInfoPtr_spriteSheetData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, "spriteSheetData");
			BaseSpriteItemData.NativeFieldInfoPtr__modelMatrix_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, "<modelMatrix>k__BackingField");
			BaseSpriteItemData.NativeFieldInfoPtr__state_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, "<state>k__BackingField");
			BaseSpriteItemData.NativeFieldInfoPtr__spritePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, "<spritePosition>k__BackingField");
			BaseSpriteItemData.NativeFieldInfoPtr__startTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, "<startTime>k__BackingField");
			BaseSpriteItemData.NativeFieldInfoPtr__endTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, "<endTime>k__BackingField");
			BaseSpriteItemData.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, "delay");
			BaseSpriteItemData.NativeMethodInfoPtr_get_modelMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, 100665959);
			BaseSpriteItemData.NativeMethodInfoPtr_set_modelMatrix_Protected_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, 100665960);
			BaseSpriteItemData.NativeMethodInfoPtr_get_state_Public_get_SpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, 100665961);
			BaseSpriteItemData.NativeMethodInfoPtr_set_state_Protected_set_Void_SpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, 100665962);
			BaseSpriteItemData.NativeMethodInfoPtr_get_spritePosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, 100665963);
			BaseSpriteItemData.NativeMethodInfoPtr_set_spritePosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, 100665964);
			BaseSpriteItemData.NativeMethodInfoPtr_get_startTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, 100665965);
			BaseSpriteItemData.NativeMethodInfoPtr_set_startTime_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, 100665966);
			BaseSpriteItemData.NativeMethodInfoPtr_get_endTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, 100665967);
			BaseSpriteItemData.NativeMethodInfoPtr_set_endTime_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, 100665968);
			BaseSpriteItemData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, 100665969);
			BaseSpriteItemData.NativeMethodInfoPtr_SetTRSMatrix_Public_Void_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, 100665970);
			BaseSpriteItemData.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, 100665971);
			BaseSpriteItemData.NativeMethodInfoPtr_Continue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, 100665972);
			BaseSpriteItemData.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, 100665973);
			BaseSpriteItemData.NativeMethodInfoPtr_CalculateStartTimeWithDelay_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, 100665974);
			BaseSpriteItemData.NativeMethodInfoPtr_CalculateEndTime_Public_Static_Single_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr, 100665975);
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001909 RID: 6409 RVA: 0x000BED58 File Offset: 0x000BCF58
		// (set) Token: 0x0600190A RID: 6410 RVA: 0x000BED94 File Offset: 0x000BCF94
		public unsafe Matrix4x4 modelMatrix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteItemData.NativeMethodInfoPtr_get_modelMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteItemData.NativeMethodInfoPtr_set_modelMatrix_Protected_set_Void_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x0600190B RID: 6411 RVA: 0x000BEDD4 File Offset: 0x000BCFD4
		// (set) Token: 0x0600190C RID: 6412 RVA: 0x000BEE10 File Offset: 0x000BD010
		public unsafe BaseSpriteItemData.SpriteState state
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 47051, RefRangeEnd = 47054, XrefRangeStart = 47051, XrefRangeEnd = 47054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteItemData.NativeMethodInfoPtr_get_state_Public_get_SpriteState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 48697, RefRangeEnd = 48700, XrefRangeStart = 48697, XrefRangeEnd = 48700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteItemData.NativeMethodInfoPtr_set_state_Protected_set_Void_SpriteState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x000BEE50 File Offset: 0x000BD050
		// (set) Token: 0x0600190E RID: 6414 RVA: 0x000BEE8C File Offset: 0x000BD08C
		public unsafe Vector3 spritePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteItemData.NativeMethodInfoPtr_get_spritePosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteItemData.NativeMethodInfoPtr_set_spritePosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x000BEECC File Offset: 0x000BD0CC
		// (set) Token: 0x06001910 RID: 6416 RVA: 0x000BEF08 File Offset: 0x000BD108
		public unsafe float startTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteItemData.NativeMethodInfoPtr_get_startTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteItemData.NativeMethodInfoPtr_set_startTime_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x000BEF48 File Offset: 0x000BD148
		// (set) Token: 0x06001912 RID: 6418 RVA: 0x000BEF84 File Offset: 0x000BD184
		public unsafe float endTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteItemData.NativeMethodInfoPtr_get_endTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteItemData.NativeMethodInfoPtr_set_endTime_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x000BEFC4 File Offset: 0x000BD1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95953, XrefRangeEnd = 95954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseSpriteItemData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseSpriteItemData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteItemData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x000BF000 File Offset: 0x000BD200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95954, XrefRangeEnd = 95955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTRSMatrix(Vector3 worldPosition, Quaternion rotation, Vector3 scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteItemData.NativeMethodInfoPtr_SetTRSMatrix_Public_Void_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x000BF05C File Offset: 0x000BD25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95955, XrefRangeEnd = 95956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteItemData.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x000BF090 File Offset: 0x000BD290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95956, XrefRangeEnd = 95957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Continue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteItemData.NativeMethodInfoPtr_Continue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x000BF0C4 File Offset: 0x000BD2C4
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteItemData.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x000BF0F8 File Offset: 0x000BD2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95957, XrefRangeEnd = 95958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CalculateStartTimeWithDelay(float delay)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteItemData.NativeMethodInfoPtr_CalculateStartTimeWithDelay_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x000BF138 File Offset: 0x000BD338
		[CallerCount(0)]
		public unsafe static float CalculateEndTime(float startTime, int itemCount, int animationSpeed)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref animationSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSpriteItemData.NativeMethodInfoPtr_CalculateEndTime_Public_Static_Single_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x0000E523 File Offset: 0x0000C723
		public BaseSpriteItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x000BF194 File Offset: 0x000BD394
		// (set) Token: 0x0600191C RID: 6428 RVA: 0x0000E52C File Offset: 0x0000C72C
		public unsafe SpriteSheetData spriteSheetData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteItemData.NativeFieldInfoPtr_spriteSheetData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteSheetData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteItemData.NativeFieldInfoPtr_spriteSheetData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x000BF1C4 File Offset: 0x000BD3C4
		// (set) Token: 0x0600191E RID: 6430 RVA: 0x0000E54B File Offset: 0x0000C74B
		public unsafe Matrix4x4 _modelMatrix_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteItemData.NativeFieldInfoPtr__modelMatrix_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteItemData.NativeFieldInfoPtr__modelMatrix_k__BackingField)) = value;
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x0600191F RID: 6431 RVA: 0x000BF1EC File Offset: 0x000BD3EC
		// (set) Token: 0x06001920 RID: 6432 RVA: 0x0000E566 File Offset: 0x0000C766
		public unsafe BaseSpriteItemData.SpriteState _state_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteItemData.NativeFieldInfoPtr__state_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteItemData.NativeFieldInfoPtr__state_k__BackingField)) = value;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x000BF214 File Offset: 0x000BD414
		// (set) Token: 0x06001922 RID: 6434 RVA: 0x0000E581 File Offset: 0x0000C781
		public unsafe Vector3 _spritePosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteItemData.NativeFieldInfoPtr__spritePosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteItemData.NativeFieldInfoPtr__spritePosition_k__BackingField)) = value;
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x000BF23C File Offset: 0x000BD43C
		// (set) Token: 0x06001924 RID: 6436 RVA: 0x0000E59C File Offset: 0x0000C79C
		public unsafe float _startTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteItemData.NativeFieldInfoPtr__startTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteItemData.NativeFieldInfoPtr__startTime_k__BackingField)) = value;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x000BF264 File Offset: 0x000BD464
		// (set) Token: 0x06001926 RID: 6438 RVA: 0x0000E5B7 File Offset: 0x0000C7B7
		public unsafe float _endTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteItemData.NativeFieldInfoPtr__endTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteItemData.NativeFieldInfoPtr__endTime_k__BackingField)) = value;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x000BF28C File Offset: 0x000BD48C
		// (set) Token: 0x06001928 RID: 6440 RVA: 0x0000E5D2 File Offset: 0x0000C7D2
		public unsafe float delay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteItemData.NativeFieldInfoPtr_delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSpriteItemData.NativeFieldInfoPtr_delay)) = value;
			}
		}

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeFieldInfoPtr_spriteSheetData;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeFieldInfoPtr__modelMatrix_k__BackingField;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeFieldInfoPtr__state_k__BackingField;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeFieldInfoPtr__spritePosition_k__BackingField;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeFieldInfoPtr__startTime_k__BackingField;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeFieldInfoPtr__endTime_k__BackingField;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeFieldInfoPtr_delay;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr_get_modelMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeMethodInfoPtr_set_modelMatrix_Protected_set_Void_Matrix4x4_0;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeMethodInfoPtr_get_state_Public_get_SpriteState_0;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeMethodInfoPtr_set_state_Protected_set_Void_SpriteState_0;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeMethodInfoPtr_get_spritePosition_Public_get_Vector3_0;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeMethodInfoPtr_set_spritePosition_Public_set_Void_Vector3_0;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeMethodInfoPtr_get_startTime_Public_get_Single_0;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeMethodInfoPtr_set_startTime_Protected_set_Void_Single_0;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeMethodInfoPtr_get_endTime_Public_get_Single_0;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeMethodInfoPtr_set_endTime_Protected_set_Void_Single_0;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeMethodInfoPtr_SetTRSMatrix_Public_Void_Vector3_Quaternion_Vector3_0;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeMethodInfoPtr_Continue_Public_Void_0;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeMethodInfoPtr_CalculateStartTimeWithDelay_Public_Static_Single_Single_0;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeMethodInfoPtr_CalculateEndTime_Public_Static_Single_Single_Int32_Int32_0;

		// Token: 0x02000858 RID: 2136
		[OriginalName("Assembly-CSharp.dll", "", "SpriteState")]
		public enum SpriteState
		{
			// Token: 0x04008266 RID: 33382
			Unknown,
			// Token: 0x04008267 RID: 33383
			NotStarted,
			// Token: 0x04008268 RID: 33384
			Animating,
			// Token: 0x04008269 RID: 33385
			Complete
		}
	}
}
