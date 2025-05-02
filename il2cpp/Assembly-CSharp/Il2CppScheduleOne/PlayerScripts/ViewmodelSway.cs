using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003ED RID: 1005
	public class ViewmodelSway : PlayerSingleton<ViewmodelSway>
	{
		// Token: 0x06005269 RID: 21097 RVA: 0x00186294 File Offset: 0x00184494
		// Note: this type is marked as 'beforefieldinit'.
		static ViewmodelSway()
		{
			Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "ViewmodelSway");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr);
			ViewmodelSway.NativeFieldInfoPtr_breatheBobbingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "breatheBobbingEnabled");
			ViewmodelSway.NativeFieldInfoPtr_breathingHeightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "breathingHeightMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_breathingSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "breathingSpeedMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_lastHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "lastHeight");
			ViewmodelSway.NativeFieldInfoPtr_breatheBobPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "breatheBobPos");
			ViewmodelSway.NativeFieldInfoPtr_swayingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "swayingEnabled");
			ViewmodelSway.NativeFieldInfoPtr_horizontalSwayMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "horizontalSwayMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_verticalSwayMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "verticalSwayMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_maxHorizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "maxHorizontal");
			ViewmodelSway.NativeFieldInfoPtr_maxVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "maxVertical");
			ViewmodelSway.NativeFieldInfoPtr_swaySmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "swaySmooth");
			ViewmodelSway.NativeFieldInfoPtr_returnMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "returnMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_initialPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "initialPos");
			ViewmodelSway.NativeFieldInfoPtr_swayPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "swayPos");
			ViewmodelSway.NativeFieldInfoPtr_walkBobbingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "walkBobbingEnabled");
			ViewmodelSway.NativeFieldInfoPtr_verticalMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "verticalMovement");
			ViewmodelSway.NativeFieldInfoPtr_horizontalMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "horizontalMovement");
			ViewmodelSway.NativeFieldInfoPtr_verticalBobHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "verticalBobHeight");
			ViewmodelSway.NativeFieldInfoPtr_verticalBobSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "verticalBobSpeed");
			ViewmodelSway.NativeFieldInfoPtr_horizontalBobWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "horizontalBobWidth");
			ViewmodelSway.NativeFieldInfoPtr_horizontalBobSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "horizontalBobSpeed");
			ViewmodelSway.NativeFieldInfoPtr_walkBobSmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "walkBobSmooth");
			ViewmodelSway.NativeFieldInfoPtr_sprintSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "sprintSpeedMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_walkBobMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "walkBobMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_walkBobPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "walkBobPos");
			ViewmodelSway.NativeFieldInfoPtr_timeSinceWalkStart_vert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "timeSinceWalkStart_vert");
			ViewmodelSway.NativeFieldInfoPtr_timeSinceWalkStart_horiz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "timeSinceWalkStart_horiz");
			ViewmodelSway.NativeFieldInfoPtr_jumpJoltEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "jumpJoltEnabled");
			ViewmodelSway.NativeFieldInfoPtr_jumpCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "jumpCurve");
			ViewmodelSway.NativeFieldInfoPtr_jumpJoltTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "jumpJoltTime");
			ViewmodelSway.NativeFieldInfoPtr_jumpJoltHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "jumpJoltHeight");
			ViewmodelSway.NativeFieldInfoPtr_jumpJoltSmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "jumpJoltSmooth");
			ViewmodelSway.NativeFieldInfoPtr_equipBopVerticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "equipBopVerticalOffset");
			ViewmodelSway.NativeFieldInfoPtr_equipBopTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "equipBopTime");
			ViewmodelSway.NativeFieldInfoPtr_equipBopPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "equipBopPos");
			ViewmodelSway.NativeFieldInfoPtr_timeSinceJumpStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "timeSinceJumpStart");
			ViewmodelSway.NativeFieldInfoPtr_jumpPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "jumpPos");
			ViewmodelSway.NativeFieldInfoPtr_fallOffsetRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "fallOffsetRate");
			ViewmodelSway.NativeFieldInfoPtr_maxFallOffsetAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "maxFallOffsetAmount");
			ViewmodelSway.NativeFieldInfoPtr_fallOffsetPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "fallOffsetPos");
			ViewmodelSway.NativeFieldInfoPtr_landCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "landCurve");
			ViewmodelSway.NativeFieldInfoPtr_landJoltTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "landJoltTime");
			ViewmodelSway.NativeFieldInfoPtr_landJoltSmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "landJoltSmooth");
			ViewmodelSway.NativeFieldInfoPtr_landPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "landPos");
			ViewmodelSway.NativeFieldInfoPtr_timeSinceLanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "timeSinceLanded");
			ViewmodelSway.NativeFieldInfoPtr_landJoltMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "landJoltMultiplier");
			ViewmodelSway.NativeMethodInfoPtr_get_calculatedJumpJoltHeight_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673628);
			ViewmodelSway.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673629);
			ViewmodelSway.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673630);
			ViewmodelSway.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673631);
			ViewmodelSway.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673632);
			ViewmodelSway.NativeMethodInfoPtr_InventoryStateChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673633);
			ViewmodelSway.NativeMethodInfoPtr_RefreshViewmodel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673634);
			ViewmodelSway.NativeMethodInfoPtr_BreatheBob_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673635);
			ViewmodelSway.NativeMethodInfoPtr_Sway_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673636);
			ViewmodelSway.NativeMethodInfoPtr_WalkBob_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673637);
			ViewmodelSway.NativeMethodInfoPtr_StartJump_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673638);
			ViewmodelSway.NativeMethodInfoPtr_UpdateJump_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673639);
			ViewmodelSway.NativeMethodInfoPtr_Land_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673640);
			ViewmodelSway.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673641);
		}

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x0600526A RID: 21098 RVA: 0x00186774 File Offset: 0x00184974
		public unsafe float calculatedJumpJoltHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_get_calculatedJumpJoltHeight_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x001867B0 File Offset: 0x001849B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177969, XrefRangeEnd = 177972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViewmodelSway.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x001867EC File Offset: 0x001849EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177972, XrefRangeEnd = 177977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViewmodelSway.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600526D RID: 21101 RVA: 0x00186828 File Offset: 0x00184A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177977, XrefRangeEnd = 178032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViewmodelSway.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600526E RID: 21102 RVA: 0x00186874 File Offset: 0x00184A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178061, RefRangeEnd = 178062, XrefRangeStart = 178032, XrefRangeEnd = 178061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x001868A8 File Offset: 0x00184AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178062, XrefRangeEnd = 178063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InventoryStateChanged(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_InventoryStateChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x001868E8 File Offset: 0x00184AE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 178070, RefRangeEnd = 178072, XrefRangeStart = 178063, XrefRangeEnd = 178070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshViewmodel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_RefreshViewmodel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x0018691C File Offset: 0x00184B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178072, XrefRangeEnd = 178074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BreatheBob()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_BreatheBob_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x00186950 File Offset: 0x00184B50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178097, RefRangeEnd = 178098, XrefRangeStart = 178074, XrefRangeEnd = 178097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sway()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_Sway_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x00186984 File Offset: 0x00184B84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178126, RefRangeEnd = 178127, XrefRangeStart = 178098, XrefRangeEnd = 178126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WalkBob()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_WalkBob_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005274 RID: 21108 RVA: 0x001869B8 File Offset: 0x00184BB8
		[CallerCount(0)]
		public unsafe void StartJump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_StartJump_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005275 RID: 21109 RVA: 0x001869EC File Offset: 0x00184BEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178165, RefRangeEnd = 178166, XrefRangeStart = 178127, XrefRangeEnd = 178165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateJump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_UpdateJump_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005276 RID: 21110 RVA: 0x00186A20 File Offset: 0x00184C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178166, XrefRangeEnd = 178168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Land()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_Land_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005277 RID: 21111 RVA: 0x00186A54 File Offset: 0x00184C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178168, XrefRangeEnd = 178179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViewmodelSway() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005278 RID: 21112 RVA: 0x00027386 File Offset: 0x00025586
		public ViewmodelSway(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x06005279 RID: 21113 RVA: 0x00186A90 File Offset: 0x00184C90
		// (set) Token: 0x0600527A RID: 21114 RVA: 0x0002738F File Offset: 0x0002558F
		public unsafe bool breatheBobbingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breatheBobbingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breatheBobbingEnabled)) = value;
			}
		}

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x0600527B RID: 21115 RVA: 0x00186AB8 File Offset: 0x00184CB8
		// (set) Token: 0x0600527C RID: 21116 RVA: 0x000273AA File Offset: 0x000255AA
		public unsafe float breathingHeightMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breathingHeightMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breathingHeightMultiplier)) = value;
			}
		}

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x0600527D RID: 21117 RVA: 0x00186AE0 File Offset: 0x00184CE0
		// (set) Token: 0x0600527E RID: 21118 RVA: 0x000273C5 File Offset: 0x000255C5
		public unsafe float breathingSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breathingSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breathingSpeedMultiplier)) = value;
			}
		}

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x0600527F RID: 21119 RVA: 0x00186B08 File Offset: 0x00184D08
		// (set) Token: 0x06005280 RID: 21120 RVA: 0x000273E0 File Offset: 0x000255E0
		public unsafe float lastHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_lastHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_lastHeight)) = value;
			}
		}

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x06005281 RID: 21121 RVA: 0x00186B30 File Offset: 0x00184D30
		// (set) Token: 0x06005282 RID: 21122 RVA: 0x000273FB File Offset: 0x000255FB
		public unsafe Vector3 breatheBobPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breatheBobPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breatheBobPos)) = value;
			}
		}

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x06005283 RID: 21123 RVA: 0x00186B58 File Offset: 0x00184D58
		// (set) Token: 0x06005284 RID: 21124 RVA: 0x00027416 File Offset: 0x00025616
		public unsafe bool swayingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_swayingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_swayingEnabled)) = value;
			}
		}

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x06005285 RID: 21125 RVA: 0x00186B80 File Offset: 0x00184D80
		// (set) Token: 0x06005286 RID: 21126 RVA: 0x00027431 File Offset: 0x00025631
		public unsafe float horizontalSwayMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalSwayMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalSwayMultiplier)) = value;
			}
		}

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x06005287 RID: 21127 RVA: 0x00186BA8 File Offset: 0x00184DA8
		// (set) Token: 0x06005288 RID: 21128 RVA: 0x0002744C File Offset: 0x0002564C
		public unsafe float verticalSwayMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalSwayMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalSwayMultiplier)) = value;
			}
		}

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x06005289 RID: 21129 RVA: 0x00186BD0 File Offset: 0x00184DD0
		// (set) Token: 0x0600528A RID: 21130 RVA: 0x00027467 File Offset: 0x00025667
		public unsafe float maxHorizontal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_maxHorizontal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_maxHorizontal)) = value;
			}
		}

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x0600528B RID: 21131 RVA: 0x00186BF8 File Offset: 0x00184DF8
		// (set) Token: 0x0600528C RID: 21132 RVA: 0x00027482 File Offset: 0x00025682
		public unsafe float maxVertical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_maxVertical);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_maxVertical)) = value;
			}
		}

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x0600528D RID: 21133 RVA: 0x00186C20 File Offset: 0x00184E20
		// (set) Token: 0x0600528E RID: 21134 RVA: 0x0002749D File Offset: 0x0002569D
		public unsafe float swaySmooth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_swaySmooth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_swaySmooth)) = value;
			}
		}

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x0600528F RID: 21135 RVA: 0x00186C48 File Offset: 0x00184E48
		// (set) Token: 0x06005290 RID: 21136 RVA: 0x000274B8 File Offset: 0x000256B8
		public unsafe float returnMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_returnMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_returnMultiplier)) = value;
			}
		}

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x06005291 RID: 21137 RVA: 0x00186C70 File Offset: 0x00184E70
		// (set) Token: 0x06005292 RID: 21138 RVA: 0x000274D3 File Offset: 0x000256D3
		public unsafe Vector3 initialPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_initialPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_initialPos)) = value;
			}
		}

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x06005293 RID: 21139 RVA: 0x00186C98 File Offset: 0x00184E98
		// (set) Token: 0x06005294 RID: 21140 RVA: 0x000274EE File Offset: 0x000256EE
		public unsafe Vector3 swayPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_swayPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_swayPos)) = value;
			}
		}

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x06005295 RID: 21141 RVA: 0x00186CC0 File Offset: 0x00184EC0
		// (set) Token: 0x06005296 RID: 21142 RVA: 0x00027509 File Offset: 0x00025709
		public unsafe bool walkBobbingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobbingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobbingEnabled)) = value;
			}
		}

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x06005297 RID: 21143 RVA: 0x00186CE8 File Offset: 0x00184EE8
		// (set) Token: 0x06005298 RID: 21144 RVA: 0x00027524 File Offset: 0x00025724
		public unsafe AnimationCurve verticalMovement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalMovement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalMovement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x06005299 RID: 21145 RVA: 0x00186D18 File Offset: 0x00184F18
		// (set) Token: 0x0600529A RID: 21146 RVA: 0x00027543 File Offset: 0x00025743
		public unsafe AnimationCurve horizontalMovement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalMovement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalMovement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x0600529B RID: 21147 RVA: 0x00186D48 File Offset: 0x00184F48
		// (set) Token: 0x0600529C RID: 21148 RVA: 0x00027562 File Offset: 0x00025762
		public unsafe float verticalBobHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalBobHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalBobHeight)) = value;
			}
		}

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x0600529D RID: 21149 RVA: 0x00186D70 File Offset: 0x00184F70
		// (set) Token: 0x0600529E RID: 21150 RVA: 0x0002757D File Offset: 0x0002577D
		public unsafe float verticalBobSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalBobSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalBobSpeed)) = value;
			}
		}

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x0600529F RID: 21151 RVA: 0x00186D98 File Offset: 0x00184F98
		// (set) Token: 0x060052A0 RID: 21152 RVA: 0x00027598 File Offset: 0x00025798
		public unsafe float horizontalBobWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalBobWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalBobWidth)) = value;
			}
		}

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x060052A1 RID: 21153 RVA: 0x00186DC0 File Offset: 0x00184FC0
		// (set) Token: 0x060052A2 RID: 21154 RVA: 0x000275B3 File Offset: 0x000257B3
		public unsafe float horizontalBobSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalBobSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalBobSpeed)) = value;
			}
		}

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x060052A3 RID: 21155 RVA: 0x00186DE8 File Offset: 0x00184FE8
		// (set) Token: 0x060052A4 RID: 21156 RVA: 0x000275CE File Offset: 0x000257CE
		public unsafe float walkBobSmooth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobSmooth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobSmooth)) = value;
			}
		}

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x060052A5 RID: 21157 RVA: 0x00186E10 File Offset: 0x00185010
		// (set) Token: 0x060052A6 RID: 21158 RVA: 0x000275E9 File Offset: 0x000257E9
		public unsafe float sprintSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_sprintSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_sprintSpeedMultiplier)) = value;
			}
		}

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x060052A7 RID: 21159 RVA: 0x00186E38 File Offset: 0x00185038
		// (set) Token: 0x060052A8 RID: 21160 RVA: 0x00027604 File Offset: 0x00025804
		public unsafe float walkBobMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobMultiplier)) = value;
			}
		}

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x060052A9 RID: 21161 RVA: 0x00186E60 File Offset: 0x00185060
		// (set) Token: 0x060052AA RID: 21162 RVA: 0x0002761F File Offset: 0x0002581F
		public unsafe Vector3 walkBobPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobPos)) = value;
			}
		}

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x060052AB RID: 21163 RVA: 0x00186E88 File Offset: 0x00185088
		// (set) Token: 0x060052AC RID: 21164 RVA: 0x0002763A File Offset: 0x0002583A
		public unsafe float timeSinceWalkStart_vert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceWalkStart_vert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceWalkStart_vert)) = value;
			}
		}

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x060052AD RID: 21165 RVA: 0x00186EB0 File Offset: 0x001850B0
		// (set) Token: 0x060052AE RID: 21166 RVA: 0x00027655 File Offset: 0x00025855
		public unsafe float timeSinceWalkStart_horiz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceWalkStart_horiz);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceWalkStart_horiz)) = value;
			}
		}

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x060052AF RID: 21167 RVA: 0x00186ED8 File Offset: 0x001850D8
		// (set) Token: 0x060052B0 RID: 21168 RVA: 0x00027670 File Offset: 0x00025870
		public unsafe bool jumpJoltEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltEnabled)) = value;
			}
		}

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x060052B1 RID: 21169 RVA: 0x00186F00 File Offset: 0x00185100
		// (set) Token: 0x060052B2 RID: 21170 RVA: 0x0002768B File Offset: 0x0002588B
		public unsafe AnimationCurve jumpCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x060052B3 RID: 21171 RVA: 0x00186F30 File Offset: 0x00185130
		// (set) Token: 0x060052B4 RID: 21172 RVA: 0x000276AA File Offset: 0x000258AA
		public unsafe float jumpJoltTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltTime)) = value;
			}
		}

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x060052B5 RID: 21173 RVA: 0x00186F58 File Offset: 0x00185158
		// (set) Token: 0x060052B6 RID: 21174 RVA: 0x000276C5 File Offset: 0x000258C5
		public unsafe float jumpJoltHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltHeight)) = value;
			}
		}

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x060052B7 RID: 21175 RVA: 0x00186F80 File Offset: 0x00185180
		// (set) Token: 0x060052B8 RID: 21176 RVA: 0x000276E0 File Offset: 0x000258E0
		public unsafe float jumpJoltSmooth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltSmooth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltSmooth)) = value;
			}
		}

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x060052B9 RID: 21177 RVA: 0x00186FA8 File Offset: 0x001851A8
		// (set) Token: 0x060052BA RID: 21178 RVA: 0x000276FB File Offset: 0x000258FB
		public unsafe float equipBopVerticalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_equipBopVerticalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_equipBopVerticalOffset)) = value;
			}
		}

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x060052BB RID: 21179 RVA: 0x00186FD0 File Offset: 0x001851D0
		// (set) Token: 0x060052BC RID: 21180 RVA: 0x00027716 File Offset: 0x00025916
		public unsafe float equipBopTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_equipBopTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_equipBopTime)) = value;
			}
		}

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x060052BD RID: 21181 RVA: 0x00186FF8 File Offset: 0x001851F8
		// (set) Token: 0x060052BE RID: 21182 RVA: 0x00027731 File Offset: 0x00025931
		public unsafe Vector3 equipBopPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_equipBopPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_equipBopPos)) = value;
			}
		}

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x060052BF RID: 21183 RVA: 0x00187020 File Offset: 0x00185220
		// (set) Token: 0x060052C0 RID: 21184 RVA: 0x0002774C File Offset: 0x0002594C
		public unsafe float timeSinceJumpStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceJumpStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceJumpStart)) = value;
			}
		}

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x060052C1 RID: 21185 RVA: 0x00187048 File Offset: 0x00185248
		// (set) Token: 0x060052C2 RID: 21186 RVA: 0x00027767 File Offset: 0x00025967
		public unsafe Vector3 jumpPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpPos)) = value;
			}
		}

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x060052C3 RID: 21187 RVA: 0x00187070 File Offset: 0x00185270
		// (set) Token: 0x060052C4 RID: 21188 RVA: 0x00027782 File Offset: 0x00025982
		public unsafe float fallOffsetRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_fallOffsetRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_fallOffsetRate)) = value;
			}
		}

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x060052C5 RID: 21189 RVA: 0x00187098 File Offset: 0x00185298
		// (set) Token: 0x060052C6 RID: 21190 RVA: 0x0002779D File Offset: 0x0002599D
		public unsafe float maxFallOffsetAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_maxFallOffsetAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_maxFallOffsetAmount)) = value;
			}
		}

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x060052C7 RID: 21191 RVA: 0x001870C0 File Offset: 0x001852C0
		// (set) Token: 0x060052C8 RID: 21192 RVA: 0x000277B8 File Offset: 0x000259B8
		public unsafe Vector3 fallOffsetPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_fallOffsetPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_fallOffsetPos)) = value;
			}
		}

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x060052C9 RID: 21193 RVA: 0x001870E8 File Offset: 0x001852E8
		// (set) Token: 0x060052CA RID: 21194 RVA: 0x000277D3 File Offset: 0x000259D3
		public unsafe AnimationCurve landCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x060052CB RID: 21195 RVA: 0x00187118 File Offset: 0x00185318
		// (set) Token: 0x060052CC RID: 21196 RVA: 0x000277F2 File Offset: 0x000259F2
		public unsafe float landJoltTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landJoltTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landJoltTime)) = value;
			}
		}

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x060052CD RID: 21197 RVA: 0x00187140 File Offset: 0x00185340
		// (set) Token: 0x060052CE RID: 21198 RVA: 0x0002780D File Offset: 0x00025A0D
		public unsafe float landJoltSmooth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landJoltSmooth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landJoltSmooth)) = value;
			}
		}

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x060052CF RID: 21199 RVA: 0x00187168 File Offset: 0x00185368
		// (set) Token: 0x060052D0 RID: 21200 RVA: 0x00027828 File Offset: 0x00025A28
		public unsafe Vector3 landPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landPos)) = value;
			}
		}

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x060052D1 RID: 21201 RVA: 0x00187190 File Offset: 0x00185390
		// (set) Token: 0x060052D2 RID: 21202 RVA: 0x00027843 File Offset: 0x00025A43
		public unsafe float timeSinceLanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceLanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceLanded)) = value;
			}
		}

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x060052D3 RID: 21203 RVA: 0x001871B8 File Offset: 0x001853B8
		// (set) Token: 0x060052D4 RID: 21204 RVA: 0x0002785E File Offset: 0x00025A5E
		public unsafe float landJoltMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landJoltMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landJoltMultiplier)) = value;
			}
		}

		// Token: 0x040037E8 RID: 14312
		private static readonly IntPtr NativeFieldInfoPtr_breatheBobbingEnabled;

		// Token: 0x040037E9 RID: 14313
		private static readonly IntPtr NativeFieldInfoPtr_breathingHeightMultiplier;

		// Token: 0x040037EA RID: 14314
		private static readonly IntPtr NativeFieldInfoPtr_breathingSpeedMultiplier;

		// Token: 0x040037EB RID: 14315
		private static readonly IntPtr NativeFieldInfoPtr_lastHeight;

		// Token: 0x040037EC RID: 14316
		private static readonly IntPtr NativeFieldInfoPtr_breatheBobPos;

		// Token: 0x040037ED RID: 14317
		private static readonly IntPtr NativeFieldInfoPtr_swayingEnabled;

		// Token: 0x040037EE RID: 14318
		private static readonly IntPtr NativeFieldInfoPtr_horizontalSwayMultiplier;

		// Token: 0x040037EF RID: 14319
		private static readonly IntPtr NativeFieldInfoPtr_verticalSwayMultiplier;

		// Token: 0x040037F0 RID: 14320
		private static readonly IntPtr NativeFieldInfoPtr_maxHorizontal;

		// Token: 0x040037F1 RID: 14321
		private static readonly IntPtr NativeFieldInfoPtr_maxVertical;

		// Token: 0x040037F2 RID: 14322
		private static readonly IntPtr NativeFieldInfoPtr_swaySmooth;

		// Token: 0x040037F3 RID: 14323
		private static readonly IntPtr NativeFieldInfoPtr_returnMultiplier;

		// Token: 0x040037F4 RID: 14324
		private static readonly IntPtr NativeFieldInfoPtr_initialPos;

		// Token: 0x040037F5 RID: 14325
		private static readonly IntPtr NativeFieldInfoPtr_swayPos;

		// Token: 0x040037F6 RID: 14326
		private static readonly IntPtr NativeFieldInfoPtr_walkBobbingEnabled;

		// Token: 0x040037F7 RID: 14327
		private static readonly IntPtr NativeFieldInfoPtr_verticalMovement;

		// Token: 0x040037F8 RID: 14328
		private static readonly IntPtr NativeFieldInfoPtr_horizontalMovement;

		// Token: 0x040037F9 RID: 14329
		private static readonly IntPtr NativeFieldInfoPtr_verticalBobHeight;

		// Token: 0x040037FA RID: 14330
		private static readonly IntPtr NativeFieldInfoPtr_verticalBobSpeed;

		// Token: 0x040037FB RID: 14331
		private static readonly IntPtr NativeFieldInfoPtr_horizontalBobWidth;

		// Token: 0x040037FC RID: 14332
		private static readonly IntPtr NativeFieldInfoPtr_horizontalBobSpeed;

		// Token: 0x040037FD RID: 14333
		private static readonly IntPtr NativeFieldInfoPtr_walkBobSmooth;

		// Token: 0x040037FE RID: 14334
		private static readonly IntPtr NativeFieldInfoPtr_sprintSpeedMultiplier;

		// Token: 0x040037FF RID: 14335
		private static readonly IntPtr NativeFieldInfoPtr_walkBobMultiplier;

		// Token: 0x04003800 RID: 14336
		private static readonly IntPtr NativeFieldInfoPtr_walkBobPos;

		// Token: 0x04003801 RID: 14337
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceWalkStart_vert;

		// Token: 0x04003802 RID: 14338
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceWalkStart_horiz;

		// Token: 0x04003803 RID: 14339
		private static readonly IntPtr NativeFieldInfoPtr_jumpJoltEnabled;

		// Token: 0x04003804 RID: 14340
		private static readonly IntPtr NativeFieldInfoPtr_jumpCurve;

		// Token: 0x04003805 RID: 14341
		private static readonly IntPtr NativeFieldInfoPtr_jumpJoltTime;

		// Token: 0x04003806 RID: 14342
		private static readonly IntPtr NativeFieldInfoPtr_jumpJoltHeight;

		// Token: 0x04003807 RID: 14343
		private static readonly IntPtr NativeFieldInfoPtr_jumpJoltSmooth;

		// Token: 0x04003808 RID: 14344
		private static readonly IntPtr NativeFieldInfoPtr_equipBopVerticalOffset;

		// Token: 0x04003809 RID: 14345
		private static readonly IntPtr NativeFieldInfoPtr_equipBopTime;

		// Token: 0x0400380A RID: 14346
		private static readonly IntPtr NativeFieldInfoPtr_equipBopPos;

		// Token: 0x0400380B RID: 14347
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceJumpStart;

		// Token: 0x0400380C RID: 14348
		private static readonly IntPtr NativeFieldInfoPtr_jumpPos;

		// Token: 0x0400380D RID: 14349
		private static readonly IntPtr NativeFieldInfoPtr_fallOffsetRate;

		// Token: 0x0400380E RID: 14350
		private static readonly IntPtr NativeFieldInfoPtr_maxFallOffsetAmount;

		// Token: 0x0400380F RID: 14351
		private static readonly IntPtr NativeFieldInfoPtr_fallOffsetPos;

		// Token: 0x04003810 RID: 14352
		private static readonly IntPtr NativeFieldInfoPtr_landCurve;

		// Token: 0x04003811 RID: 14353
		private static readonly IntPtr NativeFieldInfoPtr_landJoltTime;

		// Token: 0x04003812 RID: 14354
		private static readonly IntPtr NativeFieldInfoPtr_landJoltSmooth;

		// Token: 0x04003813 RID: 14355
		private static readonly IntPtr NativeFieldInfoPtr_landPos;

		// Token: 0x04003814 RID: 14356
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLanded;

		// Token: 0x04003815 RID: 14357
		private static readonly IntPtr NativeFieldInfoPtr_landJoltMultiplier;

		// Token: 0x04003816 RID: 14358
		private static readonly IntPtr NativeMethodInfoPtr_get_calculatedJumpJoltHeight_Protected_get_Single_0;

		// Token: 0x04003817 RID: 14359
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003818 RID: 14360
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003819 RID: 14361
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400381A RID: 14362
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

		// Token: 0x0400381B RID: 14363
		private static readonly IntPtr NativeMethodInfoPtr_InventoryStateChanged_Private_Void_Boolean_0;

		// Token: 0x0400381C RID: 14364
		private static readonly IntPtr NativeMethodInfoPtr_RefreshViewmodel_Public_Void_0;

		// Token: 0x0400381D RID: 14365
		private static readonly IntPtr NativeMethodInfoPtr_BreatheBob_Protected_Void_0;

		// Token: 0x0400381E RID: 14366
		private static readonly IntPtr NativeMethodInfoPtr_Sway_Protected_Void_0;

		// Token: 0x0400381F RID: 14367
		private static readonly IntPtr NativeMethodInfoPtr_WalkBob_Protected_Void_0;

		// Token: 0x04003820 RID: 14368
		private static readonly IntPtr NativeMethodInfoPtr_StartJump_Protected_Void_0;

		// Token: 0x04003821 RID: 14369
		private static readonly IntPtr NativeMethodInfoPtr_UpdateJump_Protected_Void_0;

		// Token: 0x04003822 RID: 14370
		private static readonly IntPtr NativeMethodInfoPtr_Land_Protected_Void_0;

		// Token: 0x04003823 RID: 14371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
