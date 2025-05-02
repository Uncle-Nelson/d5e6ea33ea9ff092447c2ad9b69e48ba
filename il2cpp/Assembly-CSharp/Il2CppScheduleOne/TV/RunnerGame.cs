using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000188 RID: 392
	public class RunnerGame : TVApp
	{
		// Token: 0x06001F88 RID: 8072 RVA: 0x000D2D1C File Offset: 0x000D0F1C
		// Note: this type is marked as 'beforefieldinit'.
		static RunnerGame()
		{
			Il2CppClassPointerStore<RunnerGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "RunnerGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr);
			RunnerGame.NativeFieldInfoPtr_GameSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "GameSpeed");
			RunnerGame.NativeFieldInfoPtr_MinGameSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "MinGameSpeed");
			RunnerGame.NativeFieldInfoPtr_MaxGameSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "MaxGameSpeed");
			RunnerGame.NativeFieldInfoPtr_SpeedIncreaseRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "SpeedIncreaseRate");
			RunnerGame.NativeFieldInfoPtr_ScoreRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "ScoreRate");
			RunnerGame.NativeFieldInfoPtr_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "Gravity");
			RunnerGame.NativeFieldInfoPtr_JumpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "JumpForce");
			RunnerGame.NativeFieldInfoPtr_GlobalForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "GlobalForceMultiplier");
			RunnerGame.NativeFieldInfoPtr_DropForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "DropForce");
			RunnerGame.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "Character");
			RunnerGame.NativeFieldInfoPtr_CharacterFlipboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "CharacterFlipboard");
			RunnerGame.NativeFieldInfoPtr_Ground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "Ground");
			RunnerGame.NativeFieldInfoPtr_CloudSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "CloudSpawner");
			RunnerGame.NativeFieldInfoPtr_ObstacleSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "ObstacleSpawner");
			RunnerGame.NativeFieldInfoPtr_ScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "ScoreLabel");
			RunnerGame.NativeFieldInfoPtr_HighScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "HighScoreLabel");
			RunnerGame.NativeFieldInfoPtr_StartScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "StartScreen");
			RunnerGame.NativeFieldInfoPtr_GameOverScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "GameOverScreen");
			RunnerGame.NativeFieldInfoPtr_NewHighScoreAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "NewHighScoreAnimation");
			RunnerGame.NativeFieldInfoPtr_JumpSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "JumpSprite");
			RunnerGame.NativeFieldInfoPtr_isJumping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "isJumping");
			RunnerGame.NativeFieldInfoPtr_isGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "isGrounded");
			RunnerGame.NativeFieldInfoPtr_isReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "isReady");
			RunnerGame.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "score");
			RunnerGame.NativeFieldInfoPtr_yVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "yVelocity");
			RunnerGame.NativeFieldInfoPtr_defaultCharacterY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "defaultCharacterY");
			RunnerGame.NativeFieldInfoPtr_clouds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "clouds");
			RunnerGame.NativeFieldInfoPtr_obstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "obstacles");
			RunnerGame.NativeFieldInfoPtr_onJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "onJump");
			RunnerGame.NativeFieldInfoPtr_onHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "onHit");
			RunnerGame.NativeFieldInfoPtr_onNewHighScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "onNewHighScore");
			RunnerGame.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666844);
			RunnerGame.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666845);
			RunnerGame.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666846);
			RunnerGame.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666847);
			RunnerGame.NativeMethodInfoPtr_Jump_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666848);
			RunnerGame.NativeMethodInfoPtr_CloudSpawned_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666849);
			RunnerGame.NativeMethodInfoPtr_ObstacleSpawned_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666850);
			RunnerGame.NativeMethodInfoPtr_RefreshHighScore_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666851);
			RunnerGame.NativeMethodInfoPtr_PlayerCollided_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666852);
			RunnerGame.NativeMethodInfoPtr_EndGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666853);
			RunnerGame.NativeMethodInfoPtr_StartGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666854);
			RunnerGame.NativeMethodInfoPtr_ResetGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666855);
			RunnerGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666856);
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x000D30BC File Offset: 0x000D12BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108265, XrefRangeEnd = 108284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunnerGame.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x000D30F8 File Offset: 0x000D12F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108284, XrefRangeEnd = 108286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunnerGame.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x000D3134 File Offset: 0x000D1334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108286, XrefRangeEnd = 108288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TryPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunnerGame.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x000D3170 File Offset: 0x000D1370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108288, XrefRangeEnd = 108384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x000D31A4 File Offset: 0x000D13A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108384, XrefRangeEnd = 108385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Jump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_Jump_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x000D31D8 File Offset: 0x000D13D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108385, XrefRangeEnd = 108394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloudSpawned(GameObject cloud)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cloud);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_CloudSpawned_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x000D321C File Offset: 0x000D141C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108394, XrefRangeEnd = 108403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObstacleSpawned(GameObject obstacle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obstacle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_ObstacleSpawned_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x000D3260 File Offset: 0x000D1460
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108415, RefRangeEnd = 108417, XrefRangeStart = 108403, XrefRangeEnd = 108415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshHighScore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_RefreshHighScore_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x000D3294 File Offset: 0x000D1494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108417, XrefRangeEnd = 108419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerCollided()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_PlayerCollided_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x000D32C8 File Offset: 0x000D14C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108438, RefRangeEnd = 108440, XrefRangeStart = 108419, XrefRangeEnd = 108438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_EndGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x000D32FC File Offset: 0x000D14FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108440, XrefRangeEnd = 108444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_StartGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x000D3330 File Offset: 0x000D1530
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108495, RefRangeEnd = 108497, XrefRangeStart = 108444, XrefRangeEnd = 108495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_ResetGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x000D3364 File Offset: 0x000D1564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108497, XrefRangeEnd = 108510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunnerGame() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x00011BD8 File Offset: 0x0000FDD8
		public RunnerGame(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06001F97 RID: 8087 RVA: 0x000D33A0 File Offset: 0x000D15A0
		// (set) Token: 0x06001F98 RID: 8088 RVA: 0x00011BE1 File Offset: 0x0000FDE1
		public unsafe float GameSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GameSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GameSpeed)) = value;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x000D33C8 File Offset: 0x000D15C8
		// (set) Token: 0x06001F9A RID: 8090 RVA: 0x00011BFC File Offset: 0x0000FDFC
		public unsafe float MinGameSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_MinGameSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_MinGameSpeed)) = value;
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x000D33F0 File Offset: 0x000D15F0
		// (set) Token: 0x06001F9C RID: 8092 RVA: 0x00011C17 File Offset: 0x0000FE17
		public unsafe float MaxGameSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_MaxGameSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_MaxGameSpeed)) = value;
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x000D3418 File Offset: 0x000D1618
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x00011C32 File Offset: 0x0000FE32
		public unsafe float SpeedIncreaseRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_SpeedIncreaseRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_SpeedIncreaseRate)) = value;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x000D3440 File Offset: 0x000D1640
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x00011C4D File Offset: 0x0000FE4D
		public unsafe int ScoreRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ScoreRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ScoreRate)) = value;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x000D3468 File Offset: 0x000D1668
		// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x00011C68 File Offset: 0x0000FE68
		public unsafe float Gravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Gravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Gravity)) = value;
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x000D3490 File Offset: 0x000D1690
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x00011C83 File Offset: 0x0000FE83
		public unsafe float JumpForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_JumpForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_JumpForce)) = value;
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x000D34B8 File Offset: 0x000D16B8
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x00011C9E File Offset: 0x0000FE9E
		public unsafe float GlobalForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GlobalForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GlobalForceMultiplier)) = value;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x000D34E0 File Offset: 0x000D16E0
		// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x00011CB9 File Offset: 0x0000FEB9
		public unsafe float DropForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_DropForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_DropForce)) = value;
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x000D3508 File Offset: 0x000D1708
		// (set) Token: 0x06001FAA RID: 8106 RVA: 0x00011CD4 File Offset: 0x0000FED4
		public unsafe RectTransform Character
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Character);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Character), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x000D3538 File Offset: 0x000D1738
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x00011CF3 File Offset: 0x0000FEF3
		public unsafe Flipboard CharacterFlipboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_CharacterFlipboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Flipboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_CharacterFlipboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x000D3568 File Offset: 0x000D1768
		// (set) Token: 0x06001FAE RID: 8110 RVA: 0x00011D12 File Offset: 0x0000FF12
		public unsafe SlidingRect Ground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Ground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlidingRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Ground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x000D3598 File Offset: 0x000D1798
		// (set) Token: 0x06001FB0 RID: 8112 RVA: 0x00011D31 File Offset: 0x0000FF31
		public unsafe UISpawner CloudSpawner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_CloudSpawner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISpawner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_CloudSpawner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x000D35C8 File Offset: 0x000D17C8
		// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x00011D50 File Offset: 0x0000FF50
		public unsafe UISpawner ObstacleSpawner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ObstacleSpawner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISpawner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ObstacleSpawner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x000D35F8 File Offset: 0x000D17F8
		// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x00011D6F File Offset: 0x0000FF6F
		public unsafe TextMeshProUGUI ScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x000D3628 File Offset: 0x000D1828
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x00011D8E File Offset: 0x0000FF8E
		public unsafe TextMeshProUGUI HighScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_HighScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_HighScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x000D3658 File Offset: 0x000D1858
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x00011DAD File Offset: 0x0000FFAD
		public unsafe GameObject StartScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_StartScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_StartScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x000D3688 File Offset: 0x000D1888
		// (set) Token: 0x06001FBA RID: 8122 RVA: 0x00011DCC File Offset: 0x0000FFCC
		public unsafe GameObject GameOverScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GameOverScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GameOverScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x000D36B8 File Offset: 0x000D18B8
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x00011DEB File Offset: 0x0000FFEB
		public unsafe Animation NewHighScoreAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_NewHighScoreAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_NewHighScoreAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x000D36E8 File Offset: 0x000D18E8
		// (set) Token: 0x06001FBE RID: 8126 RVA: 0x00011E0A File Offset: 0x0001000A
		public unsafe Sprite JumpSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_JumpSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_JumpSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x000D3718 File Offset: 0x000D1918
		// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x00011E29 File Offset: 0x00010029
		public unsafe bool isJumping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isJumping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isJumping)) = value;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x000D3740 File Offset: 0x000D1940
		// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x00011E44 File Offset: 0x00010044
		public unsafe bool isGrounded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isGrounded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isGrounded)) = value;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x000D3768 File Offset: 0x000D1968
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x00011E5F File Offset: 0x0001005F
		public unsafe bool isReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isReady);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isReady)) = value;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x000D3790 File Offset: 0x000D1990
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x00011E7A File Offset: 0x0001007A
		public unsafe float score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_score)) = value;
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x000D37B8 File Offset: 0x000D19B8
		// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x00011E95 File Offset: 0x00010095
		public unsafe float yVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_yVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_yVelocity)) = value;
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x000D37E0 File Offset: 0x000D19E0
		// (set) Token: 0x06001FCA RID: 8138 RVA: 0x00011EB0 File Offset: 0x000100B0
		public unsafe float defaultCharacterY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_defaultCharacterY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_defaultCharacterY)) = value;
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x000D3808 File Offset: 0x000D1A08
		// (set) Token: 0x06001FCC RID: 8140 RVA: 0x00011ECB File Offset: 0x000100CB
		public unsafe List<UIMover> clouds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_clouds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIMover>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_clouds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x000D3838 File Offset: 0x000D1A38
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x00011EEA File Offset: 0x000100EA
		public unsafe List<UIMover> obstacles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_obstacles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIMover>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_obstacles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x000D3868 File Offset: 0x000D1A68
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x00011F09 File Offset: 0x00010109
		public unsafe UnityEvent onJump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onJump);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onJump), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x000D3898 File Offset: 0x000D1A98
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x00011F28 File Offset: 0x00010128
		public unsafe UnityEvent onHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x000D38C8 File Offset: 0x000D1AC8
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x00011F47 File Offset: 0x00010147
		public unsafe UnityEvent onNewHighScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onNewHighScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onNewHighScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeFieldInfoPtr_GameSpeed;

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeFieldInfoPtr_MinGameSpeed;

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeFieldInfoPtr_MaxGameSpeed;

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeFieldInfoPtr_SpeedIncreaseRate;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeFieldInfoPtr_ScoreRate;

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeFieldInfoPtr_Gravity;

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeFieldInfoPtr_JumpForce;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeFieldInfoPtr_GlobalForceMultiplier;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeFieldInfoPtr_DropForce;

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeFieldInfoPtr_Character;

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeFieldInfoPtr_CharacterFlipboard;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeFieldInfoPtr_Ground;

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeFieldInfoPtr_CloudSpawner;

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeFieldInfoPtr_ObstacleSpawner;

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeFieldInfoPtr_ScoreLabel;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeFieldInfoPtr_HighScoreLabel;

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeFieldInfoPtr_StartScreen;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeFieldInfoPtr_GameOverScreen;

		// Token: 0x04001501 RID: 5377
		private static readonly IntPtr NativeFieldInfoPtr_NewHighScoreAnimation;

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeFieldInfoPtr_JumpSprite;

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeFieldInfoPtr_isJumping;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeFieldInfoPtr_isGrounded;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeFieldInfoPtr_isReady;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeFieldInfoPtr_score;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeFieldInfoPtr_yVelocity;

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeFieldInfoPtr_defaultCharacterY;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeFieldInfoPtr_clouds;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeFieldInfoPtr_obstacles;

		// Token: 0x0400150B RID: 5387
		private static readonly IntPtr NativeFieldInfoPtr_onJump;

		// Token: 0x0400150C RID: 5388
		private static readonly IntPtr NativeFieldInfoPtr_onHit;

		// Token: 0x0400150D RID: 5389
		private static readonly IntPtr NativeFieldInfoPtr_onNewHighScore;

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400150F RID: 5391
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x04001510 RID: 5392
		private static readonly IntPtr NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0;

		// Token: 0x04001511 RID: 5393
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001512 RID: 5394
		private static readonly IntPtr NativeMethodInfoPtr_Jump_Private_Void_0;

		// Token: 0x04001513 RID: 5395
		private static readonly IntPtr NativeMethodInfoPtr_CloudSpawned_Private_Void_GameObject_0;

		// Token: 0x04001514 RID: 5396
		private static readonly IntPtr NativeMethodInfoPtr_ObstacleSpawned_Private_Void_GameObject_0;

		// Token: 0x04001515 RID: 5397
		private static readonly IntPtr NativeMethodInfoPtr_RefreshHighScore_Private_Void_0;

		// Token: 0x04001516 RID: 5398
		private static readonly IntPtr NativeMethodInfoPtr_PlayerCollided_Public_Void_0;

		// Token: 0x04001517 RID: 5399
		private static readonly IntPtr NativeMethodInfoPtr_EndGame_Private_Void_0;

		// Token: 0x04001518 RID: 5400
		private static readonly IntPtr NativeMethodInfoPtr_StartGame_Private_Void_0;

		// Token: 0x04001519 RID: 5401
		private static readonly IntPtr NativeMethodInfoPtr_ResetGame_Private_Void_0;

		// Token: 0x0400151A RID: 5402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
