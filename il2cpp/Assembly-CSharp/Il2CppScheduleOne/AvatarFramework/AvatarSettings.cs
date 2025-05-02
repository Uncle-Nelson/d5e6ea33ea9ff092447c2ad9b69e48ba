using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F4 RID: 1524
	[Serializable]
	public class AvatarSettings : ScriptableObject
	{
		// Token: 0x060085D8 RID: 34264 RVA: 0x00237308 File Offset: 0x00235508
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarSettings()
		{
			Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "AvatarSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr);
			AvatarSettings.NativeFieldInfoPtr_SkinColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "SkinColor");
			AvatarSettings.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "Height");
			AvatarSettings.NativeFieldInfoPtr_Gender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "Gender");
			AvatarSettings.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "Weight");
			AvatarSettings.NativeFieldInfoPtr_HairPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "HairPath");
			AvatarSettings.NativeFieldInfoPtr_HairColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "HairColor");
			AvatarSettings.NativeFieldInfoPtr_EyebrowScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyebrowScale");
			AvatarSettings.NativeFieldInfoPtr_EyebrowThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyebrowThickness");
			AvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyebrowRestingHeight");
			AvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyebrowRestingAngle");
			AvatarSettings.NativeFieldInfoPtr_LeftEyeLidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "LeftEyeLidColor");
			AvatarSettings.NativeFieldInfoPtr_RightEyeLidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "RightEyeLidColor");
			AvatarSettings.NativeFieldInfoPtr_LeftEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "LeftEyeRestingState");
			AvatarSettings.NativeFieldInfoPtr_RightEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "RightEyeRestingState");
			AvatarSettings.NativeFieldInfoPtr_EyeballMaterialIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyeballMaterialIdentifier");
			AvatarSettings.NativeFieldInfoPtr_EyeBallTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyeBallTint");
			AvatarSettings.NativeFieldInfoPtr_PupilDilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "PupilDilation");
			AvatarSettings.NativeFieldInfoPtr_FaceLayerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "FaceLayerSettings");
			AvatarSettings.NativeFieldInfoPtr_BodyLayerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "BodyLayerSettings");
			AvatarSettings.NativeFieldInfoPtr_AccessorySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "AccessorySettings");
			AvatarSettings.NativeFieldInfoPtr_UseCombinedLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "UseCombinedLayer");
			AvatarSettings.NativeFieldInfoPtr_CombinedLayerPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "CombinedLayerPath");
			AvatarSettings.NativeFieldInfoPtr_ImpostorTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "ImpostorTexture");
			AvatarSettings.NativeMethodInfoPtr_get_UpperEyelidRestingPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680012);
			AvatarSettings.NativeMethodInfoPtr_get_LowerEyelidRestingPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680013);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer1Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680014);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer1Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680015);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer2Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680016);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer2Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680017);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer3Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680018);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer3Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680019);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer4Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680020);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer4Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680021);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer5Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680022);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer5Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680023);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer6Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680024);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer6Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680025);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer1Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680026);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer1Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680027);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer2Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680028);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer2Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680029);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer3Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680030);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer3Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680031);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer4Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680032);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer4Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680033);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer5Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680034);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer5Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680035);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer6Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680036);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer6Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680037);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory1Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680038);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory1Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680039);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory2Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680040);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory2Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680041);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory3Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680042);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory3Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680043);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory4Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680044);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory4Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680045);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory5Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680046);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory5Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680047);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory6Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680048);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory6Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680049);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory7Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680050);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory7Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680051);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory8Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680052);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory8Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680053);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory9Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680054);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory9Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680055);
			AvatarSettings.NativeMethodInfoPtr_get_Item_Public_get_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680056);
			AvatarSettings.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680057);
			AvatarSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100680058);
		}

		// Token: 0x17002896 RID: 10390
		// (get) Token: 0x060085D9 RID: 34265 RVA: 0x002378B0 File Offset: 0x00235AB0
		public unsafe float UpperEyelidRestingPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_UpperEyelidRestingPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002897 RID: 10391
		// (get) Token: 0x060085DA RID: 34266 RVA: 0x002378EC File Offset: 0x00235AEC
		public unsafe float LowerEyelidRestingPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_LowerEyelidRestingPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002898 RID: 10392
		// (get) Token: 0x060085DB RID: 34267 RVA: 0x00237928 File Offset: 0x00235B28
		public unsafe string FaceLayer1Path
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 250697, RefRangeEnd = 250699, XrefRangeStart = 250693, XrefRangeEnd = 250697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer1Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002899 RID: 10393
		// (get) Token: 0x060085DC RID: 34268 RVA: 0x00237960 File Offset: 0x00235B60
		public unsafe Color FaceLayer1Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250699, XrefRangeEnd = 250703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer1Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700289A RID: 10394
		// (get) Token: 0x060085DD RID: 34269 RVA: 0x0023799C File Offset: 0x00235B9C
		public unsafe string FaceLayer2Path
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 250707, RefRangeEnd = 250711, XrefRangeStart = 250703, XrefRangeEnd = 250707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer2Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700289B RID: 10395
		// (get) Token: 0x060085DE RID: 34270 RVA: 0x002379D4 File Offset: 0x00235BD4
		public unsafe Color FaceLayer2Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250711, XrefRangeEnd = 250715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer2Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700289C RID: 10396
		// (get) Token: 0x060085DF RID: 34271 RVA: 0x00237A10 File Offset: 0x00235C10
		public unsafe string FaceLayer3Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250715, XrefRangeEnd = 250719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer3Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700289D RID: 10397
		// (get) Token: 0x060085E0 RID: 34272 RVA: 0x00237A48 File Offset: 0x00235C48
		public unsafe Color FaceLayer3Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250719, XrefRangeEnd = 250723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer3Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700289E RID: 10398
		// (get) Token: 0x060085E1 RID: 34273 RVA: 0x00237A84 File Offset: 0x00235C84
		public unsafe string FaceLayer4Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250723, XrefRangeEnd = 250727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer4Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700289F RID: 10399
		// (get) Token: 0x060085E2 RID: 34274 RVA: 0x00237ABC File Offset: 0x00235CBC
		public unsafe Color FaceLayer4Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250727, XrefRangeEnd = 250731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer4Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028A0 RID: 10400
		// (get) Token: 0x060085E3 RID: 34275 RVA: 0x00237AF8 File Offset: 0x00235CF8
		public unsafe string FaceLayer5Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250731, XrefRangeEnd = 250735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer5Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028A1 RID: 10401
		// (get) Token: 0x060085E4 RID: 34276 RVA: 0x00237B30 File Offset: 0x00235D30
		public unsafe Color FaceLayer5Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250735, XrefRangeEnd = 250739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer5Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028A2 RID: 10402
		// (get) Token: 0x060085E5 RID: 34277 RVA: 0x00237B6C File Offset: 0x00235D6C
		public unsafe string FaceLayer6Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250739, XrefRangeEnd = 250743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer6Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028A3 RID: 10403
		// (get) Token: 0x060085E6 RID: 34278 RVA: 0x00237BA4 File Offset: 0x00235DA4
		public unsafe Color FaceLayer6Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250743, XrefRangeEnd = 250747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer6Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028A4 RID: 10404
		// (get) Token: 0x060085E7 RID: 34279 RVA: 0x00237BE0 File Offset: 0x00235DE0
		public unsafe string BodyLayer1Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250747, XrefRangeEnd = 250751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer1Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028A5 RID: 10405
		// (get) Token: 0x060085E8 RID: 34280 RVA: 0x00237C18 File Offset: 0x00235E18
		public unsafe Color BodyLayer1Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250751, XrefRangeEnd = 250755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer1Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028A6 RID: 10406
		// (get) Token: 0x060085E9 RID: 34281 RVA: 0x00237C54 File Offset: 0x00235E54
		public unsafe string BodyLayer2Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250755, XrefRangeEnd = 250759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer2Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028A7 RID: 10407
		// (get) Token: 0x060085EA RID: 34282 RVA: 0x00237C8C File Offset: 0x00235E8C
		public unsafe Color BodyLayer2Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250759, XrefRangeEnd = 250763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer2Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028A8 RID: 10408
		// (get) Token: 0x060085EB RID: 34283 RVA: 0x00237CC8 File Offset: 0x00235EC8
		public unsafe string BodyLayer3Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250763, XrefRangeEnd = 250767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer3Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028A9 RID: 10409
		// (get) Token: 0x060085EC RID: 34284 RVA: 0x00237D00 File Offset: 0x00235F00
		public unsafe Color BodyLayer3Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250767, XrefRangeEnd = 250771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer3Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028AA RID: 10410
		// (get) Token: 0x060085ED RID: 34285 RVA: 0x00237D3C File Offset: 0x00235F3C
		public unsafe string BodyLayer4Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250771, XrefRangeEnd = 250775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer4Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028AB RID: 10411
		// (get) Token: 0x060085EE RID: 34286 RVA: 0x00237D74 File Offset: 0x00235F74
		public unsafe Color BodyLayer4Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250775, XrefRangeEnd = 250779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer4Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028AC RID: 10412
		// (get) Token: 0x060085EF RID: 34287 RVA: 0x00237DB0 File Offset: 0x00235FB0
		public unsafe string BodyLayer5Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250779, XrefRangeEnd = 250783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer5Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028AD RID: 10413
		// (get) Token: 0x060085F0 RID: 34288 RVA: 0x00237DE8 File Offset: 0x00235FE8
		public unsafe Color BodyLayer5Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250783, XrefRangeEnd = 250787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer5Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028AE RID: 10414
		// (get) Token: 0x060085F1 RID: 34289 RVA: 0x00237E24 File Offset: 0x00236024
		public unsafe string BodyLayer6Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250787, XrefRangeEnd = 250791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer6Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028AF RID: 10415
		// (get) Token: 0x060085F2 RID: 34290 RVA: 0x00237E5C File Offset: 0x0023605C
		public unsafe Color BodyLayer6Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250791, XrefRangeEnd = 250795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer6Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028B0 RID: 10416
		// (get) Token: 0x060085F3 RID: 34291 RVA: 0x00237E98 File Offset: 0x00236098
		public unsafe string Accessory1Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250795, XrefRangeEnd = 250799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory1Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028B1 RID: 10417
		// (get) Token: 0x060085F4 RID: 34292 RVA: 0x00237ED0 File Offset: 0x002360D0
		public unsafe Color Accessory1Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250799, XrefRangeEnd = 250803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory1Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028B2 RID: 10418
		// (get) Token: 0x060085F5 RID: 34293 RVA: 0x00237F0C File Offset: 0x0023610C
		public unsafe string Accessory2Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250803, XrefRangeEnd = 250807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory2Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028B3 RID: 10419
		// (get) Token: 0x060085F6 RID: 34294 RVA: 0x00237F44 File Offset: 0x00236144
		public unsafe Color Accessory2Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250807, XrefRangeEnd = 250811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory2Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028B4 RID: 10420
		// (get) Token: 0x060085F7 RID: 34295 RVA: 0x00237F80 File Offset: 0x00236180
		public unsafe string Accessory3Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250811, XrefRangeEnd = 250815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory3Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028B5 RID: 10421
		// (get) Token: 0x060085F8 RID: 34296 RVA: 0x00237FB8 File Offset: 0x002361B8
		public unsafe Color Accessory3Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250815, XrefRangeEnd = 250819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory3Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028B6 RID: 10422
		// (get) Token: 0x060085F9 RID: 34297 RVA: 0x00237FF4 File Offset: 0x002361F4
		public unsafe string Accessory4Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250819, XrefRangeEnd = 250823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory4Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028B7 RID: 10423
		// (get) Token: 0x060085FA RID: 34298 RVA: 0x0023802C File Offset: 0x0023622C
		public unsafe Color Accessory4Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250823, XrefRangeEnd = 250827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory4Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028B8 RID: 10424
		// (get) Token: 0x060085FB RID: 34299 RVA: 0x00238068 File Offset: 0x00236268
		public unsafe string Accessory5Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250827, XrefRangeEnd = 250831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory5Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028B9 RID: 10425
		// (get) Token: 0x060085FC RID: 34300 RVA: 0x002380A0 File Offset: 0x002362A0
		public unsafe Color Accessory5Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250831, XrefRangeEnd = 250835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory5Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028BA RID: 10426
		// (get) Token: 0x060085FD RID: 34301 RVA: 0x002380DC File Offset: 0x002362DC
		public unsafe string Accessory6Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250835, XrefRangeEnd = 250839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory6Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028BB RID: 10427
		// (get) Token: 0x060085FE RID: 34302 RVA: 0x00238114 File Offset: 0x00236314
		public unsafe Color Accessory6Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250839, XrefRangeEnd = 250843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory6Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028BC RID: 10428
		// (get) Token: 0x060085FF RID: 34303 RVA: 0x00238150 File Offset: 0x00236350
		public unsafe string Accessory7Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250843, XrefRangeEnd = 250847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory7Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028BD RID: 10429
		// (get) Token: 0x06008600 RID: 34304 RVA: 0x00238188 File Offset: 0x00236388
		public unsafe Color Accessory7Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250847, XrefRangeEnd = 250851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory7Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028BE RID: 10430
		// (get) Token: 0x06008601 RID: 34305 RVA: 0x002381C4 File Offset: 0x002363C4
		public unsafe string Accessory8Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250851, XrefRangeEnd = 250855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory8Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028BF RID: 10431
		// (get) Token: 0x06008602 RID: 34306 RVA: 0x002381FC File Offset: 0x002363FC
		public unsafe Color Accessory8Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250855, XrefRangeEnd = 250859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory8Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028C0 RID: 10432
		// (get) Token: 0x06008603 RID: 34307 RVA: 0x00238238 File Offset: 0x00236438
		public unsafe string Accessory9Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250859, XrefRangeEnd = 250863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory9Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170028C1 RID: 10433
		// (get) Token: 0x06008604 RID: 34308 RVA: 0x00238270 File Offset: 0x00236470
		public unsafe Color Accessory9Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250863, XrefRangeEnd = 250867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory9Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170028C2 RID: 10434
		public unsafe Il2CppSystem.Object this[string propertyName]
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 250873, RefRangeEnd = 250876, XrefRangeStart = 250867, XrefRangeEnd = 250873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Item_Public_get_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06008606 RID: 34310 RVA: 0x002382FC File Offset: 0x002364FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250876, XrefRangeEnd = 250877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetJson(bool prettyPrint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref prettyPrint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarSettings.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008607 RID: 34311 RVA: 0x0023834C File Offset: 0x0023654C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250877, XrefRangeEnd = 250897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008608 RID: 34312 RVA: 0x0003F9B4 File Offset: 0x0003DBB4
		public AvatarSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700287F RID: 10367
		// (get) Token: 0x06008609 RID: 34313 RVA: 0x00238388 File Offset: 0x00236588
		// (set) Token: 0x0600860A RID: 34314 RVA: 0x0003F9BD File Offset: 0x0003DBBD
		public unsafe Color SkinColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_SkinColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_SkinColor)) = value;
			}
		}

		// Token: 0x17002880 RID: 10368
		// (get) Token: 0x0600860B RID: 34315 RVA: 0x002383B0 File Offset: 0x002365B0
		// (set) Token: 0x0600860C RID: 34316 RVA: 0x0003F9D8 File Offset: 0x0003DBD8
		public unsafe float Height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Height)) = value;
			}
		}

		// Token: 0x17002881 RID: 10369
		// (get) Token: 0x0600860D RID: 34317 RVA: 0x002383D8 File Offset: 0x002365D8
		// (set) Token: 0x0600860E RID: 34318 RVA: 0x0003F9F3 File Offset: 0x0003DBF3
		public unsafe float Gender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Gender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Gender)) = value;
			}
		}

		// Token: 0x17002882 RID: 10370
		// (get) Token: 0x0600860F RID: 34319 RVA: 0x00238400 File Offset: 0x00236600
		// (set) Token: 0x06008610 RID: 34320 RVA: 0x0003FA0E File Offset: 0x0003DC0E
		public unsafe float Weight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Weight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Weight)) = value;
			}
		}

		// Token: 0x17002883 RID: 10371
		// (get) Token: 0x06008611 RID: 34321 RVA: 0x00238428 File Offset: 0x00236628
		// (set) Token: 0x06008612 RID: 34322 RVA: 0x0003FA29 File Offset: 0x0003DC29
		public unsafe string HairPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_HairPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_HairPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002884 RID: 10372
		// (get) Token: 0x06008613 RID: 34323 RVA: 0x00238450 File Offset: 0x00236650
		// (set) Token: 0x06008614 RID: 34324 RVA: 0x0003FA48 File Offset: 0x0003DC48
		public unsafe Color HairColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_HairColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_HairColor)) = value;
			}
		}

		// Token: 0x17002885 RID: 10373
		// (get) Token: 0x06008615 RID: 34325 RVA: 0x00238478 File Offset: 0x00236678
		// (set) Token: 0x06008616 RID: 34326 RVA: 0x0003FA63 File Offset: 0x0003DC63
		public unsafe float EyebrowScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowScale)) = value;
			}
		}

		// Token: 0x17002886 RID: 10374
		// (get) Token: 0x06008617 RID: 34327 RVA: 0x002384A0 File Offset: 0x002366A0
		// (set) Token: 0x06008618 RID: 34328 RVA: 0x0003FA7E File Offset: 0x0003DC7E
		public unsafe float EyebrowThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowThickness)) = value;
			}
		}

		// Token: 0x17002887 RID: 10375
		// (get) Token: 0x06008619 RID: 34329 RVA: 0x002384C8 File Offset: 0x002366C8
		// (set) Token: 0x0600861A RID: 34330 RVA: 0x0003FA99 File Offset: 0x0003DC99
		public unsafe float EyebrowRestingHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight)) = value;
			}
		}

		// Token: 0x17002888 RID: 10376
		// (get) Token: 0x0600861B RID: 34331 RVA: 0x002384F0 File Offset: 0x002366F0
		// (set) Token: 0x0600861C RID: 34332 RVA: 0x0003FAB4 File Offset: 0x0003DCB4
		public unsafe float EyebrowRestingAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle)) = value;
			}
		}

		// Token: 0x17002889 RID: 10377
		// (get) Token: 0x0600861D RID: 34333 RVA: 0x00238518 File Offset: 0x00236718
		// (set) Token: 0x0600861E RID: 34334 RVA: 0x0003FACF File Offset: 0x0003DCCF
		public unsafe Color LeftEyeLidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_LeftEyeLidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_LeftEyeLidColor)) = value;
			}
		}

		// Token: 0x1700288A RID: 10378
		// (get) Token: 0x0600861F RID: 34335 RVA: 0x00238540 File Offset: 0x00236740
		// (set) Token: 0x06008620 RID: 34336 RVA: 0x0003FAEA File Offset: 0x0003DCEA
		public unsafe Color RightEyeLidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_RightEyeLidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_RightEyeLidColor)) = value;
			}
		}

		// Token: 0x1700288B RID: 10379
		// (get) Token: 0x06008621 RID: 34337 RVA: 0x00238568 File Offset: 0x00236768
		// (set) Token: 0x06008622 RID: 34338 RVA: 0x0003FB05 File Offset: 0x0003DD05
		public unsafe Eye.EyeLidConfiguration LeftEyeRestingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_LeftEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_LeftEyeRestingState)) = value;
			}
		}

		// Token: 0x1700288C RID: 10380
		// (get) Token: 0x06008623 RID: 34339 RVA: 0x00238590 File Offset: 0x00236790
		// (set) Token: 0x06008624 RID: 34340 RVA: 0x0003FB20 File Offset: 0x0003DD20
		public unsafe Eye.EyeLidConfiguration RightEyeRestingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_RightEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_RightEyeRestingState)) = value;
			}
		}

		// Token: 0x1700288D RID: 10381
		// (get) Token: 0x06008625 RID: 34341 RVA: 0x002385B8 File Offset: 0x002367B8
		// (set) Token: 0x06008626 RID: 34342 RVA: 0x0003FB3B File Offset: 0x0003DD3B
		public unsafe string EyeballMaterialIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyeballMaterialIdentifier);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyeballMaterialIdentifier), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700288E RID: 10382
		// (get) Token: 0x06008627 RID: 34343 RVA: 0x002385E0 File Offset: 0x002367E0
		// (set) Token: 0x06008628 RID: 34344 RVA: 0x0003FB5A File Offset: 0x0003DD5A
		public unsafe Color EyeBallTint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyeBallTint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyeBallTint)) = value;
			}
		}

		// Token: 0x1700288F RID: 10383
		// (get) Token: 0x06008629 RID: 34345 RVA: 0x00238608 File Offset: 0x00236808
		// (set) Token: 0x0600862A RID: 34346 RVA: 0x0003FB75 File Offset: 0x0003DD75
		public unsafe float PupilDilation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_PupilDilation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_PupilDilation)) = value;
			}
		}

		// Token: 0x17002890 RID: 10384
		// (get) Token: 0x0600862B RID: 34347 RVA: 0x00238630 File Offset: 0x00236830
		// (set) Token: 0x0600862C RID: 34348 RVA: 0x0003FB90 File Offset: 0x0003DD90
		public unsafe List<AvatarSettings.LayerSetting> FaceLayerSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_FaceLayerSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings.LayerSetting>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_FaceLayerSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002891 RID: 10385
		// (get) Token: 0x0600862D RID: 34349 RVA: 0x00238660 File Offset: 0x00236860
		// (set) Token: 0x0600862E RID: 34350 RVA: 0x0003FBAF File Offset: 0x0003DDAF
		public unsafe List<AvatarSettings.LayerSetting> BodyLayerSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_BodyLayerSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings.LayerSetting>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_BodyLayerSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002892 RID: 10386
		// (get) Token: 0x0600862F RID: 34351 RVA: 0x00238690 File Offset: 0x00236890
		// (set) Token: 0x06008630 RID: 34352 RVA: 0x0003FBCE File Offset: 0x0003DDCE
		public unsafe List<AvatarSettings.AccessorySetting> AccessorySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_AccessorySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings.AccessorySetting>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_AccessorySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002893 RID: 10387
		// (get) Token: 0x06008631 RID: 34353 RVA: 0x002386C0 File Offset: 0x002368C0
		// (set) Token: 0x06008632 RID: 34354 RVA: 0x0003FBED File Offset: 0x0003DDED
		public unsafe bool UseCombinedLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_UseCombinedLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_UseCombinedLayer)) = value;
			}
		}

		// Token: 0x17002894 RID: 10388
		// (get) Token: 0x06008633 RID: 34355 RVA: 0x002386E8 File Offset: 0x002368E8
		// (set) Token: 0x06008634 RID: 34356 RVA: 0x0003FC08 File Offset: 0x0003DE08
		public unsafe string CombinedLayerPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_CombinedLayerPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_CombinedLayerPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002895 RID: 10389
		// (get) Token: 0x06008635 RID: 34357 RVA: 0x00238710 File Offset: 0x00236910
		// (set) Token: 0x06008636 RID: 34358 RVA: 0x0003FC27 File Offset: 0x0003DE27
		public unsafe Texture2D ImpostorTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_ImpostorTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_ImpostorTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005B1B RID: 23323
		private static readonly IntPtr NativeFieldInfoPtr_SkinColor;

		// Token: 0x04005B1C RID: 23324
		private static readonly IntPtr NativeFieldInfoPtr_Height;

		// Token: 0x04005B1D RID: 23325
		private static readonly IntPtr NativeFieldInfoPtr_Gender;

		// Token: 0x04005B1E RID: 23326
		private static readonly IntPtr NativeFieldInfoPtr_Weight;

		// Token: 0x04005B1F RID: 23327
		private static readonly IntPtr NativeFieldInfoPtr_HairPath;

		// Token: 0x04005B20 RID: 23328
		private static readonly IntPtr NativeFieldInfoPtr_HairColor;

		// Token: 0x04005B21 RID: 23329
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowScale;

		// Token: 0x04005B22 RID: 23330
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowThickness;

		// Token: 0x04005B23 RID: 23331
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowRestingHeight;

		// Token: 0x04005B24 RID: 23332
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowRestingAngle;

		// Token: 0x04005B25 RID: 23333
		private static readonly IntPtr NativeFieldInfoPtr_LeftEyeLidColor;

		// Token: 0x04005B26 RID: 23334
		private static readonly IntPtr NativeFieldInfoPtr_RightEyeLidColor;

		// Token: 0x04005B27 RID: 23335
		private static readonly IntPtr NativeFieldInfoPtr_LeftEyeRestingState;

		// Token: 0x04005B28 RID: 23336
		private static readonly IntPtr NativeFieldInfoPtr_RightEyeRestingState;

		// Token: 0x04005B29 RID: 23337
		private static readonly IntPtr NativeFieldInfoPtr_EyeballMaterialIdentifier;

		// Token: 0x04005B2A RID: 23338
		private static readonly IntPtr NativeFieldInfoPtr_EyeBallTint;

		// Token: 0x04005B2B RID: 23339
		private static readonly IntPtr NativeFieldInfoPtr_PupilDilation;

		// Token: 0x04005B2C RID: 23340
		private static readonly IntPtr NativeFieldInfoPtr_FaceLayerSettings;

		// Token: 0x04005B2D RID: 23341
		private static readonly IntPtr NativeFieldInfoPtr_BodyLayerSettings;

		// Token: 0x04005B2E RID: 23342
		private static readonly IntPtr NativeFieldInfoPtr_AccessorySettings;

		// Token: 0x04005B2F RID: 23343
		private static readonly IntPtr NativeFieldInfoPtr_UseCombinedLayer;

		// Token: 0x04005B30 RID: 23344
		private static readonly IntPtr NativeFieldInfoPtr_CombinedLayerPath;

		// Token: 0x04005B31 RID: 23345
		private static readonly IntPtr NativeFieldInfoPtr_ImpostorTexture;

		// Token: 0x04005B32 RID: 23346
		private static readonly IntPtr NativeMethodInfoPtr_get_UpperEyelidRestingPosition_Public_get_Single_0;

		// Token: 0x04005B33 RID: 23347
		private static readonly IntPtr NativeMethodInfoPtr_get_LowerEyelidRestingPosition_Public_get_Single_0;

		// Token: 0x04005B34 RID: 23348
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer1Path_Public_get_String_0;

		// Token: 0x04005B35 RID: 23349
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer1Color_Public_get_Color_0;

		// Token: 0x04005B36 RID: 23350
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer2Path_Public_get_String_0;

		// Token: 0x04005B37 RID: 23351
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer2Color_Public_get_Color_0;

		// Token: 0x04005B38 RID: 23352
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer3Path_Public_get_String_0;

		// Token: 0x04005B39 RID: 23353
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer3Color_Public_get_Color_0;

		// Token: 0x04005B3A RID: 23354
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer4Path_Public_get_String_0;

		// Token: 0x04005B3B RID: 23355
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer4Color_Public_get_Color_0;

		// Token: 0x04005B3C RID: 23356
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer5Path_Public_get_String_0;

		// Token: 0x04005B3D RID: 23357
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer5Color_Public_get_Color_0;

		// Token: 0x04005B3E RID: 23358
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer6Path_Public_get_String_0;

		// Token: 0x04005B3F RID: 23359
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer6Color_Public_get_Color_0;

		// Token: 0x04005B40 RID: 23360
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer1Path_Public_get_String_0;

		// Token: 0x04005B41 RID: 23361
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer1Color_Public_get_Color_0;

		// Token: 0x04005B42 RID: 23362
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer2Path_Public_get_String_0;

		// Token: 0x04005B43 RID: 23363
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer2Color_Public_get_Color_0;

		// Token: 0x04005B44 RID: 23364
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer3Path_Public_get_String_0;

		// Token: 0x04005B45 RID: 23365
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer3Color_Public_get_Color_0;

		// Token: 0x04005B46 RID: 23366
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer4Path_Public_get_String_0;

		// Token: 0x04005B47 RID: 23367
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer4Color_Public_get_Color_0;

		// Token: 0x04005B48 RID: 23368
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer5Path_Public_get_String_0;

		// Token: 0x04005B49 RID: 23369
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer5Color_Public_get_Color_0;

		// Token: 0x04005B4A RID: 23370
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer6Path_Public_get_String_0;

		// Token: 0x04005B4B RID: 23371
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer6Color_Public_get_Color_0;

		// Token: 0x04005B4C RID: 23372
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory1Path_Public_get_String_0;

		// Token: 0x04005B4D RID: 23373
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory1Color_Public_get_Color_0;

		// Token: 0x04005B4E RID: 23374
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory2Path_Public_get_String_0;

		// Token: 0x04005B4F RID: 23375
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory2Color_Public_get_Color_0;

		// Token: 0x04005B50 RID: 23376
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory3Path_Public_get_String_0;

		// Token: 0x04005B51 RID: 23377
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory3Color_Public_get_Color_0;

		// Token: 0x04005B52 RID: 23378
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory4Path_Public_get_String_0;

		// Token: 0x04005B53 RID: 23379
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory4Color_Public_get_Color_0;

		// Token: 0x04005B54 RID: 23380
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory5Path_Public_get_String_0;

		// Token: 0x04005B55 RID: 23381
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory5Color_Public_get_Color_0;

		// Token: 0x04005B56 RID: 23382
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory6Path_Public_get_String_0;

		// Token: 0x04005B57 RID: 23383
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory6Color_Public_get_Color_0;

		// Token: 0x04005B58 RID: 23384
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory7Path_Public_get_String_0;

		// Token: 0x04005B59 RID: 23385
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory7Color_Public_get_Color_0;

		// Token: 0x04005B5A RID: 23386
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory8Path_Public_get_String_0;

		// Token: 0x04005B5B RID: 23387
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory8Color_Public_get_Color_0;

		// Token: 0x04005B5C RID: 23388
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory9Path_Public_get_String_0;

		// Token: 0x04005B5D RID: 23389
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory9Color_Public_get_Color_0;

		// Token: 0x04005B5E RID: 23390
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_String_0;

		// Token: 0x04005B5F RID: 23391
		private static readonly IntPtr NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0;

		// Token: 0x04005B60 RID: 23392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AED RID: 2797
		[Serializable]
		public sealed class LayerSetting : ValueType
		{
			// Token: 0x0600D595 RID: 54677 RVA: 0x0032E7D4 File Offset: 0x0032C9D4
			// Note: this type is marked as 'beforefieldinit'.
			static LayerSetting()
			{
				Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "LayerSetting");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr);
				AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr, "layerPath");
				AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr, "layerTint");
			}

			// Token: 0x0600D596 RID: 54678 RVA: 0x00067E67 File Offset: 0x00066067
			public LayerSetting(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D597 RID: 54679 RVA: 0x00067E70 File Offset: 0x00066070
			public LayerSetting() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr))
			{
			}

			// Token: 0x1700422F RID: 16943
			// (get) Token: 0x0600D598 RID: 54680 RVA: 0x0032E828 File Offset: 0x0032CA28
			// (set) Token: 0x0600D599 RID: 54681 RVA: 0x00067E82 File Offset: 0x00066082
			public unsafe string layerPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004230 RID: 16944
			// (get) Token: 0x0600D59A RID: 54682 RVA: 0x0032E850 File Offset: 0x0032CA50
			// (set) Token: 0x0600D59B RID: 54683 RVA: 0x00067EA1 File Offset: 0x000660A1
			public unsafe Color layerTint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerTint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerTint)) = value;
				}
			}

			// Token: 0x04008FAD RID: 36781
			private static readonly IntPtr NativeFieldInfoPtr_layerPath;

			// Token: 0x04008FAE RID: 36782
			private static readonly IntPtr NativeFieldInfoPtr_layerTint;
		}

		// Token: 0x02000AEE RID: 2798
		[Serializable]
		public class AccessorySetting : Il2CppSystem.Object
		{
			// Token: 0x0600D59C RID: 54684 RVA: 0x0032E878 File Offset: 0x0032CA78
			// Note: this type is marked as 'beforefieldinit'.
			static AccessorySetting()
			{
				Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "AccessorySetting");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr);
				AvatarSettings.AccessorySetting.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr, "path");
				AvatarSettings.AccessorySetting.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr, "color");
				AvatarSettings.AccessorySetting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr, 100680059);
			}

			// Token: 0x0600D59D RID: 54685 RVA: 0x0032E8E0 File Offset: 0x0032CAE0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AccessorySetting() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.AccessorySetting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D59E RID: 54686 RVA: 0x00067EBC File Offset: 0x000660BC
			public AccessorySetting(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004231 RID: 16945
			// (get) Token: 0x0600D59F RID: 54687 RVA: 0x0032E91C File Offset: 0x0032CB1C
			// (set) Token: 0x0600D5A0 RID: 54688 RVA: 0x00067EC5 File Offset: 0x000660C5
			public unsafe string path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.AccessorySetting.NativeFieldInfoPtr_path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.AccessorySetting.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004232 RID: 16946
			// (get) Token: 0x0600D5A1 RID: 54689 RVA: 0x0032E944 File Offset: 0x0032CB44
			// (set) Token: 0x0600D5A2 RID: 54690 RVA: 0x00067EE4 File Offset: 0x000660E4
			public unsafe Color color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.AccessorySetting.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.AccessorySetting.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04008FAF RID: 36783
			private static readonly IntPtr NativeFieldInfoPtr_path;

			// Token: 0x04008FB0 RID: 36784
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008FB1 RID: 36785
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
