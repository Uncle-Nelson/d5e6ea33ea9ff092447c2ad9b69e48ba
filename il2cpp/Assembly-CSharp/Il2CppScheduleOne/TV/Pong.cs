using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000185 RID: 389
	public class Pong : TVApp
	{
		// Token: 0x06001F1A RID: 7962 RVA: 0x000D1A20 File Offset: 0x000CFC20
		// Note: this type is marked as 'beforefieldinit'.
		static Pong()
		{
			Il2CppClassPointerStore<Pong>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "Pong");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pong>.NativeClassPtr);
			Pong.NativeFieldInfoPtr__GameMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "<GameMode>k__BackingField");
			Pong.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "<State>k__BackingField");
			Pong.NativeFieldInfoPtr__LeftScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "<LeftScore>k__BackingField");
			Pong.NativeFieldInfoPtr__RightScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "<RightScore>k__BackingField");
			Pong.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "Rect");
			Pong.NativeFieldInfoPtr_LeftPaddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "LeftPaddle");
			Pong.NativeFieldInfoPtr_RightPaddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "RightPaddle");
			Pong.NativeFieldInfoPtr_Ball = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "Ball");
			Pong.NativeFieldInfoPtr_LeftScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "LeftScoreLabel");
			Pong.NativeFieldInfoPtr_RightScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "RightScoreLabel");
			Pong.NativeFieldInfoPtr_WinnerLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "WinnerLabel");
			Pong.NativeFieldInfoPtr_InitialVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "InitialVelocity");
			Pong.NativeFieldInfoPtr_VelocityGainPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "VelocityGainPerSecond");
			Pong.NativeFieldInfoPtr_MaxVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "MaxVelocity");
			Pong.NativeFieldInfoPtr_GoalsToWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "GoalsToWin");
			Pong.NativeFieldInfoPtr_ReactionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "ReactionTime");
			Pong.NativeFieldInfoPtr_TargetRandomization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "TargetRandomization");
			Pong.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "SpeedMultiplier");
			Pong.NativeFieldInfoPtr_onServe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onServe");
			Pong.NativeFieldInfoPtr_onLeftScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onLeftScore");
			Pong.NativeFieldInfoPtr_onRightScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onRightScore");
			Pong.NativeFieldInfoPtr_onGameOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onGameOver");
			Pong.NativeFieldInfoPtr_onLocalPlayerWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onLocalPlayerWin");
			Pong.NativeFieldInfoPtr_onReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onReset");
			Pong.NativeFieldInfoPtr_nextBallSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "nextBallSide");
			Pong.NativeFieldInfoPtr_ballVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "ballVelocity");
			Pong.NativeFieldInfoPtr_reactionTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "reactionTimer");
			Pong.NativeMethodInfoPtr_get_GameMode_Public_get_EGameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666814);
			Pong.NativeMethodInfoPtr_set_GameMode_Public_set_Void_EGameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666815);
			Pong.NativeMethodInfoPtr_get_State_Public_get_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666816);
			Pong.NativeMethodInfoPtr_set_State_Public_set_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666817);
			Pong.NativeMethodInfoPtr_get_LeftScore_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666818);
			Pong.NativeMethodInfoPtr_set_LeftScore_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666819);
			Pong.NativeMethodInfoPtr_get_RightScore_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666820);
			Pong.NativeMethodInfoPtr_set_RightScore_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666821);
			Pong.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666822);
			Pong.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666823);
			Pong.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666824);
			Pong.NativeMethodInfoPtr_UpdateInputs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666825);
			Pong.NativeMethodInfoPtr_UpdateAI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666826);
			Pong.NativeMethodInfoPtr_GoalHit_Public_Void_ESide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666827);
			Pong.NativeMethodInfoPtr_Win_Private_Void_ESide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666828);
			Pong.NativeMethodInfoPtr_ResetBall_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666829);
			Pong.NativeMethodInfoPtr_ServeBall_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666830);
			Pong.NativeMethodInfoPtr_ResetGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666831);
			Pong.NativeMethodInfoPtr_SetPaddleTargetY_Public_Void_ESide_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666832);
			Pong.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666833);
			Pong.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666834);
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x000D1E10 File Offset: 0x000D0010
		// (set) Token: 0x06001F1C RID: 7964 RVA: 0x000D1E4C File Offset: 0x000D004C
		public unsafe Pong.EGameMode GameMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_get_GameMode_Public_get_EGameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 69392, RefRangeEnd = 69401, XrefRangeStart = 69392, XrefRangeEnd = 69401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_set_GameMode_Public_set_Void_EGameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x000D1E8C File Offset: 0x000D008C
		// (set) Token: 0x06001F1E RID: 7966 RVA: 0x000D1EC8 File Offset: 0x000D00C8
		public unsafe Pong.EState State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_get_State_Public_get_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_set_State_Public_set_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06001F1F RID: 7967 RVA: 0x000D1F08 File Offset: 0x000D0108
		// (set) Token: 0x06001F20 RID: 7968 RVA: 0x000D1F44 File Offset: 0x000D0144
		public unsafe int LeftScore
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 55721, RefRangeEnd = 55722, XrefRangeStart = 55721, XrefRangeEnd = 55722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_get_LeftScore_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_set_LeftScore_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06001F21 RID: 7969 RVA: 0x000D1F84 File Offset: 0x000D0184
		// (set) Token: 0x06001F22 RID: 7970 RVA: 0x000D1FC0 File Offset: 0x000D01C0
		public unsafe int RightScore
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 108124, RefRangeEnd = 108125, XrefRangeStart = 108124, XrefRangeEnd = 108124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_get_RightScore_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_set_RightScore_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x000D2000 File Offset: 0x000D0200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108125, XrefRangeEnd = 108128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x000D2034 File Offset: 0x000D0234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108128, XrefRangeEnd = 108140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x000D2068 File Offset: 0x000D0268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108140, XrefRangeEnd = 108143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TryPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pong.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x000D20A4 File Offset: 0x000D02A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108155, RefRangeEnd = 108156, XrefRangeStart = 108143, XrefRangeEnd = 108155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInputs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_UpdateInputs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x000D20D8 File Offset: 0x000D02D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108164, RefRangeEnd = 108165, XrefRangeStart = 108156, XrefRangeEnd = 108164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_UpdateAI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x000D210C File Offset: 0x000D030C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108174, RefRangeEnd = 108175, XrefRangeStart = 108165, XrefRangeEnd = 108174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoalHit(Pong.ESide side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_GoalHit_Public_Void_ESide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x000D214C File Offset: 0x000D034C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108187, RefRangeEnd = 108188, XrefRangeStart = 108175, XrefRangeEnd = 108187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Win(Pong.ESide winner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref winner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_Win_Private_Void_ESide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x000D218C File Offset: 0x000D038C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 108205, RefRangeEnd = 108208, XrefRangeStart = 108188, XrefRangeEnd = 108205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_ResetBall_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x000D21C0 File Offset: 0x000D03C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108208, XrefRangeEnd = 108216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServeBall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_ServeBall_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x000D21F4 File Offset: 0x000D03F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108216, XrefRangeEnd = 108222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_ResetGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x000D2228 File Offset: 0x000D0428
		[CallerCount(0)]
		public unsafe void SetPaddleTargetY(Pong.ESide player, float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref player;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_SetPaddleTargetY_Public_Void_ESide_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x000D2274 File Offset: 0x000D0474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108222, XrefRangeEnd = 108224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pong.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x000D22B0 File Offset: 0x000D04B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108224, XrefRangeEnd = 108227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pong() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pong>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x000117A8 File Offset: 0x0000F9A8
		public Pong(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06001F31 RID: 7985 RVA: 0x000D22EC File Offset: 0x000D04EC
		// (set) Token: 0x06001F32 RID: 7986 RVA: 0x000117B1 File Offset: 0x0000F9B1
		public unsafe Pong.EGameMode _GameMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__GameMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__GameMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06001F33 RID: 7987 RVA: 0x000D2314 File Offset: 0x000D0514
		// (set) Token: 0x06001F34 RID: 7988 RVA: 0x000117CC File Offset: 0x0000F9CC
		public unsafe Pong.EState _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06001F35 RID: 7989 RVA: 0x000D233C File Offset: 0x000D053C
		// (set) Token: 0x06001F36 RID: 7990 RVA: 0x000117E7 File Offset: 0x0000F9E7
		public unsafe int _LeftScore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__LeftScore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__LeftScore_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06001F37 RID: 7991 RVA: 0x000D2364 File Offset: 0x000D0564
		// (set) Token: 0x06001F38 RID: 7992 RVA: 0x00011802 File Offset: 0x0000FA02
		public unsafe int _RightScore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__RightScore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__RightScore_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x000D238C File Offset: 0x000D058C
		// (set) Token: 0x06001F3A RID: 7994 RVA: 0x0001181D File Offset: 0x0000FA1D
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x000D23BC File Offset: 0x000D05BC
		// (set) Token: 0x06001F3C RID: 7996 RVA: 0x0001183C File Offset: 0x0000FA3C
		public unsafe PongPaddle LeftPaddle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_LeftPaddle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PongPaddle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_LeftPaddle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x000D23EC File Offset: 0x000D05EC
		// (set) Token: 0x06001F3E RID: 7998 RVA: 0x0001185B File Offset: 0x0000FA5B
		public unsafe PongPaddle RightPaddle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_RightPaddle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PongPaddle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_RightPaddle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06001F3F RID: 7999 RVA: 0x000D241C File Offset: 0x000D061C
		// (set) Token: 0x06001F40 RID: 8000 RVA: 0x0001187A File Offset: 0x0000FA7A
		public unsafe PongBall Ball
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_Ball);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PongBall>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_Ball), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06001F41 RID: 8001 RVA: 0x000D244C File Offset: 0x000D064C
		// (set) Token: 0x06001F42 RID: 8002 RVA: 0x00011899 File Offset: 0x0000FA99
		public unsafe TextMeshProUGUI LeftScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_LeftScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_LeftScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06001F43 RID: 8003 RVA: 0x000D247C File Offset: 0x000D067C
		// (set) Token: 0x06001F44 RID: 8004 RVA: 0x000118B8 File Offset: 0x0000FAB8
		public unsafe TextMeshProUGUI RightScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_RightScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_RightScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06001F45 RID: 8005 RVA: 0x000D24AC File Offset: 0x000D06AC
		// (set) Token: 0x06001F46 RID: 8006 RVA: 0x000118D7 File Offset: 0x0000FAD7
		public unsafe TextMeshProUGUI WinnerLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_WinnerLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_WinnerLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06001F47 RID: 8007 RVA: 0x000D24DC File Offset: 0x000D06DC
		// (set) Token: 0x06001F48 RID: 8008 RVA: 0x000118F6 File Offset: 0x0000FAF6
		public unsafe float InitialVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_InitialVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_InitialVelocity)) = value;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06001F49 RID: 8009 RVA: 0x000D2504 File Offset: 0x000D0704
		// (set) Token: 0x06001F4A RID: 8010 RVA: 0x00011911 File Offset: 0x0000FB11
		public unsafe float VelocityGainPerSecond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_VelocityGainPerSecond);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_VelocityGainPerSecond)) = value;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x000D252C File Offset: 0x000D072C
		// (set) Token: 0x06001F4C RID: 8012 RVA: 0x0001192C File Offset: 0x0000FB2C
		public unsafe float MaxVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_MaxVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_MaxVelocity)) = value;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x000D2554 File Offset: 0x000D0754
		// (set) Token: 0x06001F4E RID: 8014 RVA: 0x00011947 File Offset: 0x0000FB47
		public unsafe int GoalsToWin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_GoalsToWin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_GoalsToWin)) = value;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06001F4F RID: 8015 RVA: 0x000D257C File Offset: 0x000D077C
		// (set) Token: 0x06001F50 RID: 8016 RVA: 0x00011962 File Offset: 0x0000FB62
		public unsafe float ReactionTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_ReactionTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_ReactionTime)) = value;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x000D25A4 File Offset: 0x000D07A4
		// (set) Token: 0x06001F52 RID: 8018 RVA: 0x0001197D File Offset: 0x0000FB7D
		public unsafe float TargetRandomization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_TargetRandomization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_TargetRandomization)) = value;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x000D25CC File Offset: 0x000D07CC
		// (set) Token: 0x06001F54 RID: 8020 RVA: 0x00011998 File Offset: 0x0000FB98
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x000D25F4 File Offset: 0x000D07F4
		// (set) Token: 0x06001F56 RID: 8022 RVA: 0x000119B3 File Offset: 0x0000FBB3
		public unsafe UnityEvent onServe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onServe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onServe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x000D2624 File Offset: 0x000D0824
		// (set) Token: 0x06001F58 RID: 8024 RVA: 0x000119D2 File Offset: 0x0000FBD2
		public unsafe UnityEvent onLeftScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onLeftScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onLeftScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x000D2654 File Offset: 0x000D0854
		// (set) Token: 0x06001F5A RID: 8026 RVA: 0x000119F1 File Offset: 0x0000FBF1
		public unsafe UnityEvent onRightScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onRightScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onRightScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x000D2684 File Offset: 0x000D0884
		// (set) Token: 0x06001F5C RID: 8028 RVA: 0x00011A10 File Offset: 0x0000FC10
		public unsafe UnityEvent onGameOver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onGameOver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onGameOver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06001F5D RID: 8029 RVA: 0x000D26B4 File Offset: 0x000D08B4
		// (set) Token: 0x06001F5E RID: 8030 RVA: 0x00011A2F File Offset: 0x0000FC2F
		public unsafe UnityEvent onLocalPlayerWin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onLocalPlayerWin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onLocalPlayerWin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06001F5F RID: 8031 RVA: 0x000D26E4 File Offset: 0x000D08E4
		// (set) Token: 0x06001F60 RID: 8032 RVA: 0x00011A4E File Offset: 0x0000FC4E
		public unsafe UnityEvent onReset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onReset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onReset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06001F61 RID: 8033 RVA: 0x000D2714 File Offset: 0x000D0914
		// (set) Token: 0x06001F62 RID: 8034 RVA: 0x00011A6D File Offset: 0x0000FC6D
		public unsafe Pong.ESide nextBallSide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_nextBallSide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_nextBallSide)) = value;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06001F63 RID: 8035 RVA: 0x000D273C File Offset: 0x000D093C
		// (set) Token: 0x06001F64 RID: 8036 RVA: 0x00011A88 File Offset: 0x0000FC88
		public unsafe Vector3 ballVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_ballVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_ballVelocity)) = value;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06001F65 RID: 8037 RVA: 0x000D2764 File Offset: 0x000D0964
		// (set) Token: 0x06001F66 RID: 8038 RVA: 0x00011AA3 File Offset: 0x0000FCA3
		public unsafe float reactionTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_reactionTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_reactionTimer)) = value;
			}
		}

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeFieldInfoPtr__GameMode_k__BackingField;

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeFieldInfoPtr__LeftScore_k__BackingField;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeFieldInfoPtr__RightScore_k__BackingField;

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeFieldInfoPtr_LeftPaddle;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeFieldInfoPtr_RightPaddle;

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeFieldInfoPtr_Ball;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeFieldInfoPtr_LeftScoreLabel;

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeFieldInfoPtr_RightScoreLabel;

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeFieldInfoPtr_WinnerLabel;

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeFieldInfoPtr_InitialVelocity;

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeFieldInfoPtr_VelocityGainPerSecond;

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeFieldInfoPtr_MaxVelocity;

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeFieldInfoPtr_GoalsToWin;

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeFieldInfoPtr_ReactionTime;

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeFieldInfoPtr_TargetRandomization;

		// Token: 0x040014BD RID: 5309
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x040014BE RID: 5310
		private static readonly IntPtr NativeFieldInfoPtr_onServe;

		// Token: 0x040014BF RID: 5311
		private static readonly IntPtr NativeFieldInfoPtr_onLeftScore;

		// Token: 0x040014C0 RID: 5312
		private static readonly IntPtr NativeFieldInfoPtr_onRightScore;

		// Token: 0x040014C1 RID: 5313
		private static readonly IntPtr NativeFieldInfoPtr_onGameOver;

		// Token: 0x040014C2 RID: 5314
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerWin;

		// Token: 0x040014C3 RID: 5315
		private static readonly IntPtr NativeFieldInfoPtr_onReset;

		// Token: 0x040014C4 RID: 5316
		private static readonly IntPtr NativeFieldInfoPtr_nextBallSide;

		// Token: 0x040014C5 RID: 5317
		private static readonly IntPtr NativeFieldInfoPtr_ballVelocity;

		// Token: 0x040014C6 RID: 5318
		private static readonly IntPtr NativeFieldInfoPtr_reactionTimer;

		// Token: 0x040014C7 RID: 5319
		private static readonly IntPtr NativeMethodInfoPtr_get_GameMode_Public_get_EGameMode_0;

		// Token: 0x040014C8 RID: 5320
		private static readonly IntPtr NativeMethodInfoPtr_set_GameMode_Public_set_Void_EGameMode_0;

		// Token: 0x040014C9 RID: 5321
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_EState_0;

		// Token: 0x040014CA RID: 5322
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Public_set_Void_EState_0;

		// Token: 0x040014CB RID: 5323
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftScore_Public_get_Int32_0;

		// Token: 0x040014CC RID: 5324
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftScore_Public_set_Void_Int32_0;

		// Token: 0x040014CD RID: 5325
		private static readonly IntPtr NativeMethodInfoPtr_get_RightScore_Public_get_Int32_0;

		// Token: 0x040014CE RID: 5326
		private static readonly IntPtr NativeMethodInfoPtr_set_RightScore_Public_set_Void_Int32_0;

		// Token: 0x040014CF RID: 5327
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040014D0 RID: 5328
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040014D1 RID: 5329
		private static readonly IntPtr NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0;

		// Token: 0x040014D2 RID: 5330
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputs_Public_Void_0;

		// Token: 0x040014D3 RID: 5331
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAI_Private_Void_0;

		// Token: 0x040014D4 RID: 5332
		private static readonly IntPtr NativeMethodInfoPtr_GoalHit_Public_Void_ESide_0;

		// Token: 0x040014D5 RID: 5333
		private static readonly IntPtr NativeMethodInfoPtr_Win_Private_Void_ESide_0;

		// Token: 0x040014D6 RID: 5334
		private static readonly IntPtr NativeMethodInfoPtr_ResetBall_Private_Void_0;

		// Token: 0x040014D7 RID: 5335
		private static readonly IntPtr NativeMethodInfoPtr_ServeBall_Private_Void_0;

		// Token: 0x040014D8 RID: 5336
		private static readonly IntPtr NativeMethodInfoPtr_ResetGame_Private_Void_0;

		// Token: 0x040014D9 RID: 5337
		private static readonly IntPtr NativeMethodInfoPtr_SetPaddleTargetY_Public_Void_ESide_Single_0;

		// Token: 0x040014DA RID: 5338
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x040014DB RID: 5339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008B3 RID: 2227
		[OriginalName("Assembly-CSharp.dll", "", "EGameMode")]
		public enum EGameMode
		{
			// Token: 0x0400844C RID: 33868
			SinglePlayer,
			// Token: 0x0400844D RID: 33869
			MultiPlayer
		}

		// Token: 0x020008B4 RID: 2228
		[OriginalName("Assembly-CSharp.dll", "", "ESide")]
		public enum ESide
		{
			// Token: 0x0400844F RID: 33871
			Left,
			// Token: 0x04008450 RID: 33872
			Right
		}

		// Token: 0x020008B5 RID: 2229
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x04008452 RID: 33874
			Ready,
			// Token: 0x04008453 RID: 33875
			Playing,
			// Token: 0x04008454 RID: 33876
			GameOver
		}
	}
}
