using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200007D RID: 125
	public static class Consts : Il2CppSystem.Object
	{
		// Token: 0x06000935 RID: 2357 RVA: 0x00006FB3 File Offset: 0x000051B3
		// Note: this type is marked as 'beforefieldinit'.
		static Consts()
		{
			Il2CppClassPointerStore<Consts>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "Consts");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts>.NativeClassPtr);
			Consts.NativeFieldInfoPtr_PluginFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "PluginFolder");
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00006FEC File Offset: 0x000051EC
		public Consts(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x0008CD68 File Offset: 0x0008AF68
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x00006FF5 File Offset: 0x000051F5
		public unsafe static string PluginFolder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_PluginFolder, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_PluginFolder, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeFieldInfoPtr_PluginFolder;

		// Token: 0x0200080E RID: 2062
		public static class Help : Il2CppSystem.Object
		{
			// Token: 0x0600BD21 RID: 48417 RVA: 0x002E9788 File Offset: 0x002E7988
			// Note: this type is marked as 'beforefieldinit'.
			static Help()
			{
				Il2CppClassPointerStore<Consts.Help>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Help");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr);
				Consts.Help.NativeFieldInfoPtr_UrlBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlBase");
				Consts.Help.NativeFieldInfoPtr_UrlSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlSuffix");
				Consts.Help.NativeFieldInfoPtr_UrlDustParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlDustParticles");
				Consts.Help.NativeFieldInfoPtr_UrlTriggerZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlTriggerZone");
				Consts.Help.NativeFieldInfoPtr_UrlEffectFlicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlEffectFlicker");
				Consts.Help.NativeFieldInfoPtr_UrlEffectPulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlEffectPulse");
				Consts.Help.NativeFieldInfoPtr_UrlEffectFromProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlEffectFromProfile");
				Consts.Help.NativeFieldInfoPtr_UrlConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlConfig");
			}

			// Token: 0x0600BD22 RID: 48418 RVA: 0x0005C949 File Offset: 0x0005AB49
			public Help(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003AA2 RID: 15010
			// (get) Token: 0x0600BD23 RID: 48419 RVA: 0x002E9854 File Offset: 0x002E7A54
			// (set) Token: 0x0600BD24 RID: 48420 RVA: 0x0005C952 File Offset: 0x0005AB52
			public unsafe static string UrlBase
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlBase, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlBase, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003AA3 RID: 15011
			// (get) Token: 0x0600BD25 RID: 48421 RVA: 0x002E9874 File Offset: 0x002E7A74
			// (set) Token: 0x0600BD26 RID: 48422 RVA: 0x0005C964 File Offset: 0x0005AB64
			public unsafe static string UrlSuffix
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlSuffix, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlSuffix, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003AA4 RID: 15012
			// (get) Token: 0x0600BD27 RID: 48423 RVA: 0x002E9894 File Offset: 0x002E7A94
			// (set) Token: 0x0600BD28 RID: 48424 RVA: 0x0005C976 File Offset: 0x0005AB76
			public unsafe static string UrlDustParticles
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlDustParticles, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlDustParticles, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003AA5 RID: 15013
			// (get) Token: 0x0600BD29 RID: 48425 RVA: 0x002E98B4 File Offset: 0x002E7AB4
			// (set) Token: 0x0600BD2A RID: 48426 RVA: 0x0005C988 File Offset: 0x0005AB88
			public unsafe static string UrlTriggerZone
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlTriggerZone, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlTriggerZone, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003AA6 RID: 15014
			// (get) Token: 0x0600BD2B RID: 48427 RVA: 0x002E98D4 File Offset: 0x002E7AD4
			// (set) Token: 0x0600BD2C RID: 48428 RVA: 0x0005C99A File Offset: 0x0005AB9A
			public unsafe static string UrlEffectFlicker
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlEffectFlicker, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlEffectFlicker, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003AA7 RID: 15015
			// (get) Token: 0x0600BD2D RID: 48429 RVA: 0x002E98F4 File Offset: 0x002E7AF4
			// (set) Token: 0x0600BD2E RID: 48430 RVA: 0x0005C9AC File Offset: 0x0005ABAC
			public unsafe static string UrlEffectPulse
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlEffectPulse, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlEffectPulse, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003AA8 RID: 15016
			// (get) Token: 0x0600BD2F RID: 48431 RVA: 0x002E9914 File Offset: 0x002E7B14
			// (set) Token: 0x0600BD30 RID: 48432 RVA: 0x0005C9BE File Offset: 0x0005ABBE
			public unsafe static string UrlEffectFromProfile
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlEffectFromProfile, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlEffectFromProfile, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003AA9 RID: 15017
			// (get) Token: 0x0600BD31 RID: 48433 RVA: 0x002E9934 File Offset: 0x002E7B34
			// (set) Token: 0x0600BD32 RID: 48434 RVA: 0x0005C9D0 File Offset: 0x0005ABD0
			public unsafe static string UrlConfig
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlConfig, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlConfig, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008029 RID: 32809
			private static readonly IntPtr NativeFieldInfoPtr_UrlBase;

			// Token: 0x0400802A RID: 32810
			private static readonly IntPtr NativeFieldInfoPtr_UrlSuffix;

			// Token: 0x0400802B RID: 32811
			private static readonly IntPtr NativeFieldInfoPtr_UrlDustParticles;

			// Token: 0x0400802C RID: 32812
			private static readonly IntPtr NativeFieldInfoPtr_UrlTriggerZone;

			// Token: 0x0400802D RID: 32813
			private static readonly IntPtr NativeFieldInfoPtr_UrlEffectFlicker;

			// Token: 0x0400802E RID: 32814
			private static readonly IntPtr NativeFieldInfoPtr_UrlEffectPulse;

			// Token: 0x0400802F RID: 32815
			private static readonly IntPtr NativeFieldInfoPtr_UrlEffectFromProfile;

			// Token: 0x04008030 RID: 32816
			private static readonly IntPtr NativeFieldInfoPtr_UrlConfig;

			// Token: 0x02000C1F RID: 3103
			public static class SD : Il2CppSystem.Object
			{
				// Token: 0x0600E0C7 RID: 57543 RVA: 0x0034E494 File Offset: 0x0034C694
				// Note: this type is marked as 'beforefieldinit'.
				static SD()
				{
					Il2CppClassPointerStore<Consts.Help.SD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "SD");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Help.SD>.NativeClassPtr);
					Consts.Help.SD.NativeFieldInfoPtr_UrlBeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.SD>.NativeClassPtr, "UrlBeam");
					Consts.Help.SD.NativeFieldInfoPtr_UrlDynamicOcclusionRaycasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.SD>.NativeClassPtr, "UrlDynamicOcclusionRaycasting");
					Consts.Help.SD.NativeFieldInfoPtr_UrlDynamicOcclusionDepthBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.SD>.NativeClassPtr, "UrlDynamicOcclusionDepthBuffer");
					Consts.Help.SD.NativeFieldInfoPtr_UrlSkewingHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.SD>.NativeClassPtr, "UrlSkewingHandle");
				}

				// Token: 0x0600E0C8 RID: 57544 RVA: 0x0006D98B File Offset: 0x0006BB8B
				public SD(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700459A RID: 17818
				// (get) Token: 0x0600E0C9 RID: 57545 RVA: 0x0034E510 File Offset: 0x0034C710
				// (set) Token: 0x0600E0CA RID: 57546 RVA: 0x0006D994 File Offset: 0x0006BB94
				public unsafe static string UrlBeam
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.SD.NativeFieldInfoPtr_UrlBeam, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.SD.NativeFieldInfoPtr_UrlBeam, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x1700459B RID: 17819
				// (get) Token: 0x0600E0CB RID: 57547 RVA: 0x0034E530 File Offset: 0x0034C730
				// (set) Token: 0x0600E0CC RID: 57548 RVA: 0x0006D9A6 File Offset: 0x0006BBA6
				public unsafe static string UrlDynamicOcclusionRaycasting
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.SD.NativeFieldInfoPtr_UrlDynamicOcclusionRaycasting, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.SD.NativeFieldInfoPtr_UrlDynamicOcclusionRaycasting, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x1700459C RID: 17820
				// (get) Token: 0x0600E0CD RID: 57549 RVA: 0x0034E550 File Offset: 0x0034C750
				// (set) Token: 0x0600E0CE RID: 57550 RVA: 0x0006D9B8 File Offset: 0x0006BBB8
				public unsafe static string UrlDynamicOcclusionDepthBuffer
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.SD.NativeFieldInfoPtr_UrlDynamicOcclusionDepthBuffer, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.SD.NativeFieldInfoPtr_UrlDynamicOcclusionDepthBuffer, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x1700459D RID: 17821
				// (get) Token: 0x0600E0CF RID: 57551 RVA: 0x0034E570 File Offset: 0x0034C770
				// (set) Token: 0x0600E0D0 RID: 57552 RVA: 0x0006D9CA File Offset: 0x0006BBCA
				public unsafe static string UrlSkewingHandle
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.SD.NativeFieldInfoPtr_UrlSkewingHandle, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.SD.NativeFieldInfoPtr_UrlSkewingHandle, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x0400967C RID: 38524
				private static readonly IntPtr NativeFieldInfoPtr_UrlBeam;

				// Token: 0x0400967D RID: 38525
				private static readonly IntPtr NativeFieldInfoPtr_UrlDynamicOcclusionRaycasting;

				// Token: 0x0400967E RID: 38526
				private static readonly IntPtr NativeFieldInfoPtr_UrlDynamicOcclusionDepthBuffer;

				// Token: 0x0400967F RID: 38527
				private static readonly IntPtr NativeFieldInfoPtr_UrlSkewingHandle;
			}

			// Token: 0x02000C20 RID: 3104
			public static class HD : Il2CppSystem.Object
			{
				// Token: 0x0600E0D1 RID: 57553 RVA: 0x0034E590 File Offset: 0x0034C790
				// Note: this type is marked as 'beforefieldinit'.
				static HD()
				{
					Il2CppClassPointerStore<Consts.Help.HD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "HD");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Help.HD>.NativeClassPtr);
					Consts.Help.HD.NativeFieldInfoPtr_UrlBeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.HD>.NativeClassPtr, "UrlBeam");
					Consts.Help.HD.NativeFieldInfoPtr_UrlShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.HD>.NativeClassPtr, "UrlShadow");
					Consts.Help.HD.NativeFieldInfoPtr_UrlCookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.HD>.NativeClassPtr, "UrlCookie");
					Consts.Help.HD.NativeFieldInfoPtr_UrlTrackRealtimeChangesOnLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.HD>.NativeClassPtr, "UrlTrackRealtimeChangesOnLight");
				}

				// Token: 0x0600E0D2 RID: 57554 RVA: 0x0006D9DC File Offset: 0x0006BBDC
				public HD(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700459E RID: 17822
				// (get) Token: 0x0600E0D3 RID: 57555 RVA: 0x0034E60C File Offset: 0x0034C80C
				// (set) Token: 0x0600E0D4 RID: 57556 RVA: 0x0006D9E5 File Offset: 0x0006BBE5
				public unsafe static string UrlBeam
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.HD.NativeFieldInfoPtr_UrlBeam, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.HD.NativeFieldInfoPtr_UrlBeam, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x1700459F RID: 17823
				// (get) Token: 0x0600E0D5 RID: 57557 RVA: 0x0034E62C File Offset: 0x0034C82C
				// (set) Token: 0x0600E0D6 RID: 57558 RVA: 0x0006D9F7 File Offset: 0x0006BBF7
				public unsafe static string UrlShadow
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.HD.NativeFieldInfoPtr_UrlShadow, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.HD.NativeFieldInfoPtr_UrlShadow, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x170045A0 RID: 17824
				// (get) Token: 0x0600E0D7 RID: 57559 RVA: 0x0034E64C File Offset: 0x0034C84C
				// (set) Token: 0x0600E0D8 RID: 57560 RVA: 0x0006DA09 File Offset: 0x0006BC09
				public unsafe static string UrlCookie
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.HD.NativeFieldInfoPtr_UrlCookie, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.HD.NativeFieldInfoPtr_UrlCookie, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x170045A1 RID: 17825
				// (get) Token: 0x0600E0D9 RID: 57561 RVA: 0x0034E66C File Offset: 0x0034C86C
				// (set) Token: 0x0600E0DA RID: 57562 RVA: 0x0006DA1B File Offset: 0x0006BC1B
				public unsafe static string UrlTrackRealtimeChangesOnLight
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.HD.NativeFieldInfoPtr_UrlTrackRealtimeChangesOnLight, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.HD.NativeFieldInfoPtr_UrlTrackRealtimeChangesOnLight, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x04009680 RID: 38528
				private static readonly IntPtr NativeFieldInfoPtr_UrlBeam;

				// Token: 0x04009681 RID: 38529
				private static readonly IntPtr NativeFieldInfoPtr_UrlShadow;

				// Token: 0x04009682 RID: 38530
				private static readonly IntPtr NativeFieldInfoPtr_UrlCookie;

				// Token: 0x04009683 RID: 38531
				private static readonly IntPtr NativeFieldInfoPtr_UrlTrackRealtimeChangesOnLight;
			}
		}

		// Token: 0x0200080F RID: 2063
		public static class Internal : Il2CppSystem.Object
		{
			// Token: 0x0600BD33 RID: 48435 RVA: 0x002E9954 File Offset: 0x002E7B54
			// Note: this type is marked as 'beforefieldinit'.
			static Internal()
			{
				Il2CppClassPointerStore<Consts.Internal>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Internal");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Internal>.NativeClassPtr);
				Consts.Internal.NativeFieldInfoPtr_ProceduralObjectsVisibleInEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Internal>.NativeClassPtr, "ProceduralObjectsVisibleInEditor");
				Consts.Internal.NativeMethodInfoPtr_get_ProceduralObjectsHideFlags_Public_Static_get_HideFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Consts.Internal>.NativeClassPtr, 100664269);
			}

			// Token: 0x17003AAB RID: 15019
			// (get) Token: 0x0600BD34 RID: 48436 RVA: 0x002E99A8 File Offset: 0x002E7BA8
			public unsafe static HideFlags ProceduralObjectsHideFlags
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 80034, RefRangeEnd = 80040, XrefRangeStart = 80030, XrefRangeEnd = 80034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Consts.Internal.NativeMethodInfoPtr_get_ProceduralObjectsHideFlags_Public_Static_get_HideFlags_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BD35 RID: 48437 RVA: 0x0005C9E2 File Offset: 0x0005ABE2
			public Internal(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003AAA RID: 15018
			// (get) Token: 0x0600BD36 RID: 48438 RVA: 0x002E99D8 File Offset: 0x002E7BD8
			// (set) Token: 0x0600BD37 RID: 48439 RVA: 0x0005C9EB File Offset: 0x0005ABEB
			public unsafe static bool ProceduralObjectsVisibleInEditor
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Internal.NativeFieldInfoPtr_ProceduralObjectsVisibleInEditor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Internal.NativeFieldInfoPtr_ProceduralObjectsVisibleInEditor, (void*)(&value));
				}
			}

			// Token: 0x04008031 RID: 32817
			private static readonly IntPtr NativeFieldInfoPtr_ProceduralObjectsVisibleInEditor;

			// Token: 0x04008032 RID: 32818
			private static readonly IntPtr NativeMethodInfoPtr_get_ProceduralObjectsHideFlags_Public_Static_get_HideFlags_0;
		}

		// Token: 0x02000810 RID: 2064
		public static class Beam : Il2CppSystem.Object
		{
			// Token: 0x0600BD38 RID: 48440 RVA: 0x002E99F4 File Offset: 0x002E7BF4
			// Note: this type is marked as 'beforefieldinit'.
			static Beam()
			{
				Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Beam");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr);
				Consts.Beam.NativeFieldInfoPtr_FlatColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "FlatColor");
				Consts.Beam.NativeFieldInfoPtr_ColorModeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "ColorModeDefault");
				Consts.Beam.NativeFieldInfoPtr_MultiplierDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "MultiplierDefault");
				Consts.Beam.NativeFieldInfoPtr_MultiplierMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "MultiplierMin");
				Consts.Beam.NativeFieldInfoPtr_IntensityDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "IntensityDefault");
				Consts.Beam.NativeFieldInfoPtr_IntensityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "IntensityMin");
				Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "HDRPExposureWeightDefault");
				Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "HDRPExposureWeightMin");
				Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "HDRPExposureWeightMax");
				Consts.Beam.NativeFieldInfoPtr_SpotAngleDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "SpotAngleDefault");
				Consts.Beam.NativeFieldInfoPtr_SpotAngleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "SpotAngleMin");
				Consts.Beam.NativeFieldInfoPtr_SpotAngleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "SpotAngleMax");
				Consts.Beam.NativeFieldInfoPtr_ConeRadiusStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "ConeRadiusStart");
				Consts.Beam.NativeFieldInfoPtr_GeomMeshType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomMeshType");
				Consts.Beam.NativeFieldInfoPtr_GeomSidesDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomSidesDefault");
				Consts.Beam.NativeFieldInfoPtr_GeomSidesMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomSidesMin");
				Consts.Beam.NativeFieldInfoPtr_GeomSidesMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomSidesMax");
				Consts.Beam.NativeFieldInfoPtr_GeomSegmentsDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomSegmentsDefault");
				Consts.Beam.NativeFieldInfoPtr_GeomSegmentsMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomSegmentsMin");
				Consts.Beam.NativeFieldInfoPtr_GeomSegmentsMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomSegmentsMax");
				Consts.Beam.NativeFieldInfoPtr_GeomCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomCap");
				Consts.Beam.NativeFieldInfoPtr_ScalableDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "ScalableDefault");
				Consts.Beam.NativeFieldInfoPtr_AttenuationEquationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "AttenuationEquationDefault");
				Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "AttenuationCustomBlendingDefault");
				Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "AttenuationCustomBlendingMin");
				Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "AttenuationCustomBlendingMax");
				Consts.Beam.NativeFieldInfoPtr_FallOffStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "FallOffStart");
				Consts.Beam.NativeFieldInfoPtr_FallOffEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "FallOffEnd");
				Consts.Beam.NativeFieldInfoPtr_FallOffDistancesMinThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "FallOffDistancesMinThreshold");
				Consts.Beam.NativeFieldInfoPtr_DepthBlendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "DepthBlendDistance");
				Consts.Beam.NativeFieldInfoPtr_CameraClippingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "CameraClippingDistance");
				Consts.Beam.NativeFieldInfoPtr_NoiseModeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseModeDefault");
				Consts.Beam.NativeFieldInfoPtr_NoiseIntensityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseIntensityMin");
				Consts.Beam.NativeFieldInfoPtr_NoiseIntensityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseIntensityMax");
				Consts.Beam.NativeFieldInfoPtr_NoiseIntensityDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseIntensityDefault");
				Consts.Beam.NativeFieldInfoPtr_NoiseScaleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseScaleMin");
				Consts.Beam.NativeFieldInfoPtr_NoiseScaleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseScaleMax");
				Consts.Beam.NativeFieldInfoPtr_NoiseScaleDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseScaleDefault");
				Consts.Beam.NativeFieldInfoPtr_NoiseVelocityDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseVelocityDefault");
				Consts.Beam.NativeFieldInfoPtr_BlendingModeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "BlendingModeDefault");
				Consts.Beam.NativeFieldInfoPtr_ShaderAccuracyDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "ShaderAccuracyDefault");
				Consts.Beam.NativeFieldInfoPtr_FadeOutBeginDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "FadeOutBeginDefault");
				Consts.Beam.NativeFieldInfoPtr_FadeOutEndDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "FadeOutEndDefault");
				Consts.Beam.NativeFieldInfoPtr_DimensionsDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "DimensionsDefault");
			}

			// Token: 0x0600BD39 RID: 48441 RVA: 0x0005C9F9 File Offset: 0x0005ABF9
			public Beam(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003AAC RID: 15020
			// (get) Token: 0x0600BD3A RID: 48442 RVA: 0x002E9D90 File Offset: 0x002E7F90
			// (set) Token: 0x0600BD3B RID: 48443 RVA: 0x0005CA02 File Offset: 0x0005AC02
			public unsafe static Color FlatColor
			{
				get
				{
					Color result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_FlatColor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_FlatColor, (void*)(&value));
				}
			}

			// Token: 0x17003AAD RID: 15021
			// (get) Token: 0x0600BD3C RID: 48444 RVA: 0x002E9DAC File Offset: 0x002E7FAC
			// (set) Token: 0x0600BD3D RID: 48445 RVA: 0x0005CA10 File Offset: 0x0005AC10
			public unsafe static ColorMode ColorModeDefault
			{
				get
				{
					ColorMode result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_ColorModeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_ColorModeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AAE RID: 15022
			// (get) Token: 0x0600BD3E RID: 48446 RVA: 0x002E9DC8 File Offset: 0x002E7FC8
			// (set) Token: 0x0600BD3F RID: 48447 RVA: 0x0005CA1E File Offset: 0x0005AC1E
			public unsafe static float MultiplierDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_MultiplierDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_MultiplierDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AAF RID: 15023
			// (get) Token: 0x0600BD40 RID: 48448 RVA: 0x002E9DE4 File Offset: 0x002E7FE4
			// (set) Token: 0x0600BD41 RID: 48449 RVA: 0x0005CA2C File Offset: 0x0005AC2C
			public unsafe static float MultiplierMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_MultiplierMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_MultiplierMin, (void*)(&value));
				}
			}

			// Token: 0x17003AB0 RID: 15024
			// (get) Token: 0x0600BD42 RID: 48450 RVA: 0x002E9E00 File Offset: 0x002E8000
			// (set) Token: 0x0600BD43 RID: 48451 RVA: 0x0005CA3A File Offset: 0x0005AC3A
			public unsafe static float IntensityDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_IntensityDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_IntensityDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AB1 RID: 15025
			// (get) Token: 0x0600BD44 RID: 48452 RVA: 0x002E9E1C File Offset: 0x002E801C
			// (set) Token: 0x0600BD45 RID: 48453 RVA: 0x0005CA48 File Offset: 0x0005AC48
			public unsafe static float IntensityMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_IntensityMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_IntensityMin, (void*)(&value));
				}
			}

			// Token: 0x17003AB2 RID: 15026
			// (get) Token: 0x0600BD46 RID: 48454 RVA: 0x002E9E38 File Offset: 0x002E8038
			// (set) Token: 0x0600BD47 RID: 48455 RVA: 0x0005CA56 File Offset: 0x0005AC56
			public unsafe static float HDRPExposureWeightDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AB3 RID: 15027
			// (get) Token: 0x0600BD48 RID: 48456 RVA: 0x002E9E54 File Offset: 0x002E8054
			// (set) Token: 0x0600BD49 RID: 48457 RVA: 0x0005CA64 File Offset: 0x0005AC64
			public unsafe static float HDRPExposureWeightMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightMin, (void*)(&value));
				}
			}

			// Token: 0x17003AB4 RID: 15028
			// (get) Token: 0x0600BD4A RID: 48458 RVA: 0x002E9E70 File Offset: 0x002E8070
			// (set) Token: 0x0600BD4B RID: 48459 RVA: 0x0005CA72 File Offset: 0x0005AC72
			public unsafe static float HDRPExposureWeightMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightMax, (void*)(&value));
				}
			}

			// Token: 0x17003AB5 RID: 15029
			// (get) Token: 0x0600BD4C RID: 48460 RVA: 0x002E9E8C File Offset: 0x002E808C
			// (set) Token: 0x0600BD4D RID: 48461 RVA: 0x0005CA80 File Offset: 0x0005AC80
			public unsafe static float SpotAngleDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_SpotAngleDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_SpotAngleDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AB6 RID: 15030
			// (get) Token: 0x0600BD4E RID: 48462 RVA: 0x002E9EA8 File Offset: 0x002E80A8
			// (set) Token: 0x0600BD4F RID: 48463 RVA: 0x0005CA8E File Offset: 0x0005AC8E
			public unsafe static float SpotAngleMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_SpotAngleMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_SpotAngleMin, (void*)(&value));
				}
			}

			// Token: 0x17003AB7 RID: 15031
			// (get) Token: 0x0600BD50 RID: 48464 RVA: 0x002E9EC4 File Offset: 0x002E80C4
			// (set) Token: 0x0600BD51 RID: 48465 RVA: 0x0005CA9C File Offset: 0x0005AC9C
			public unsafe static float SpotAngleMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_SpotAngleMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_SpotAngleMax, (void*)(&value));
				}
			}

			// Token: 0x17003AB8 RID: 15032
			// (get) Token: 0x0600BD52 RID: 48466 RVA: 0x002E9EE0 File Offset: 0x002E80E0
			// (set) Token: 0x0600BD53 RID: 48467 RVA: 0x0005CAAA File Offset: 0x0005ACAA
			public unsafe static float ConeRadiusStart
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_ConeRadiusStart, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_ConeRadiusStart, (void*)(&value));
				}
			}

			// Token: 0x17003AB9 RID: 15033
			// (get) Token: 0x0600BD54 RID: 48468 RVA: 0x002E9EFC File Offset: 0x002E80FC
			// (set) Token: 0x0600BD55 RID: 48469 RVA: 0x0005CAB8 File Offset: 0x0005ACB8
			public unsafe static MeshType GeomMeshType
			{
				get
				{
					MeshType result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomMeshType, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomMeshType, (void*)(&value));
				}
			}

			// Token: 0x17003ABA RID: 15034
			// (get) Token: 0x0600BD56 RID: 48470 RVA: 0x002E9F18 File Offset: 0x002E8118
			// (set) Token: 0x0600BD57 RID: 48471 RVA: 0x0005CAC6 File Offset: 0x0005ACC6
			public unsafe static int GeomSidesDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomSidesDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomSidesDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ABB RID: 15035
			// (get) Token: 0x0600BD58 RID: 48472 RVA: 0x002E9F34 File Offset: 0x002E8134
			// (set) Token: 0x0600BD59 RID: 48473 RVA: 0x0005CAD4 File Offset: 0x0005ACD4
			public unsafe static int GeomSidesMin
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomSidesMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomSidesMin, (void*)(&value));
				}
			}

			// Token: 0x17003ABC RID: 15036
			// (get) Token: 0x0600BD5A RID: 48474 RVA: 0x002E9F50 File Offset: 0x002E8150
			// (set) Token: 0x0600BD5B RID: 48475 RVA: 0x0005CAE2 File Offset: 0x0005ACE2
			public unsafe static int GeomSidesMax
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomSidesMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomSidesMax, (void*)(&value));
				}
			}

			// Token: 0x17003ABD RID: 15037
			// (get) Token: 0x0600BD5C RID: 48476 RVA: 0x002E9F6C File Offset: 0x002E816C
			// (set) Token: 0x0600BD5D RID: 48477 RVA: 0x0005CAF0 File Offset: 0x0005ACF0
			public unsafe static int GeomSegmentsDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomSegmentsDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomSegmentsDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ABE RID: 15038
			// (get) Token: 0x0600BD5E RID: 48478 RVA: 0x002E9F88 File Offset: 0x002E8188
			// (set) Token: 0x0600BD5F RID: 48479 RVA: 0x0005CAFE File Offset: 0x0005ACFE
			public unsafe static int GeomSegmentsMin
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomSegmentsMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomSegmentsMin, (void*)(&value));
				}
			}

			// Token: 0x17003ABF RID: 15039
			// (get) Token: 0x0600BD60 RID: 48480 RVA: 0x002E9FA4 File Offset: 0x002E81A4
			// (set) Token: 0x0600BD61 RID: 48481 RVA: 0x0005CB0C File Offset: 0x0005AD0C
			public unsafe static int GeomSegmentsMax
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomSegmentsMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomSegmentsMax, (void*)(&value));
				}
			}

			// Token: 0x17003AC0 RID: 15040
			// (get) Token: 0x0600BD62 RID: 48482 RVA: 0x002E9FC0 File Offset: 0x002E81C0
			// (set) Token: 0x0600BD63 RID: 48483 RVA: 0x0005CB1A File Offset: 0x0005AD1A
			public unsafe static bool GeomCap
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomCap, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomCap, (void*)(&value));
				}
			}

			// Token: 0x17003AC1 RID: 15041
			// (get) Token: 0x0600BD64 RID: 48484 RVA: 0x002E9FDC File Offset: 0x002E81DC
			// (set) Token: 0x0600BD65 RID: 48485 RVA: 0x0005CB28 File Offset: 0x0005AD28
			public unsafe static bool ScalableDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_ScalableDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_ScalableDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AC2 RID: 15042
			// (get) Token: 0x0600BD66 RID: 48486 RVA: 0x002E9FF8 File Offset: 0x002E81F8
			// (set) Token: 0x0600BD67 RID: 48487 RVA: 0x0005CB36 File Offset: 0x0005AD36
			public unsafe static AttenuationEquation AttenuationEquationDefault
			{
				get
				{
					AttenuationEquation result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_AttenuationEquationDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_AttenuationEquationDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AC3 RID: 15043
			// (get) Token: 0x0600BD68 RID: 48488 RVA: 0x002EA014 File Offset: 0x002E8214
			// (set) Token: 0x0600BD69 RID: 48489 RVA: 0x0005CB44 File Offset: 0x0005AD44
			public unsafe static float AttenuationCustomBlendingDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AC4 RID: 15044
			// (get) Token: 0x0600BD6A RID: 48490 RVA: 0x002EA030 File Offset: 0x002E8230
			// (set) Token: 0x0600BD6B RID: 48491 RVA: 0x0005CB52 File Offset: 0x0005AD52
			public unsafe static float AttenuationCustomBlendingMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingMin, (void*)(&value));
				}
			}

			// Token: 0x17003AC5 RID: 15045
			// (get) Token: 0x0600BD6C RID: 48492 RVA: 0x002EA04C File Offset: 0x002E824C
			// (set) Token: 0x0600BD6D RID: 48493 RVA: 0x0005CB60 File Offset: 0x0005AD60
			public unsafe static float AttenuationCustomBlendingMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingMax, (void*)(&value));
				}
			}

			// Token: 0x17003AC6 RID: 15046
			// (get) Token: 0x0600BD6E RID: 48494 RVA: 0x002EA068 File Offset: 0x002E8268
			// (set) Token: 0x0600BD6F RID: 48495 RVA: 0x0005CB6E File Offset: 0x0005AD6E
			public unsafe static float FallOffStart
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_FallOffStart, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_FallOffStart, (void*)(&value));
				}
			}

			// Token: 0x17003AC7 RID: 15047
			// (get) Token: 0x0600BD70 RID: 48496 RVA: 0x002EA084 File Offset: 0x002E8284
			// (set) Token: 0x0600BD71 RID: 48497 RVA: 0x0005CB7C File Offset: 0x0005AD7C
			public unsafe static float FallOffEnd
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_FallOffEnd, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_FallOffEnd, (void*)(&value));
				}
			}

			// Token: 0x17003AC8 RID: 15048
			// (get) Token: 0x0600BD72 RID: 48498 RVA: 0x002EA0A0 File Offset: 0x002E82A0
			// (set) Token: 0x0600BD73 RID: 48499 RVA: 0x0005CB8A File Offset: 0x0005AD8A
			public unsafe static float FallOffDistancesMinThreshold
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_FallOffDistancesMinThreshold, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_FallOffDistancesMinThreshold, (void*)(&value));
				}
			}

			// Token: 0x17003AC9 RID: 15049
			// (get) Token: 0x0600BD74 RID: 48500 RVA: 0x002EA0BC File Offset: 0x002E82BC
			// (set) Token: 0x0600BD75 RID: 48501 RVA: 0x0005CB98 File Offset: 0x0005AD98
			public unsafe static float DepthBlendDistance
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_DepthBlendDistance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_DepthBlendDistance, (void*)(&value));
				}
			}

			// Token: 0x17003ACA RID: 15050
			// (get) Token: 0x0600BD76 RID: 48502 RVA: 0x002EA0D8 File Offset: 0x002E82D8
			// (set) Token: 0x0600BD77 RID: 48503 RVA: 0x0005CBA6 File Offset: 0x0005ADA6
			public unsafe static float CameraClippingDistance
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_CameraClippingDistance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_CameraClippingDistance, (void*)(&value));
				}
			}

			// Token: 0x17003ACB RID: 15051
			// (get) Token: 0x0600BD78 RID: 48504 RVA: 0x002EA0F4 File Offset: 0x002E82F4
			// (set) Token: 0x0600BD79 RID: 48505 RVA: 0x0005CBB4 File Offset: 0x0005ADB4
			public unsafe static NoiseMode NoiseModeDefault
			{
				get
				{
					NoiseMode result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseModeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseModeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ACC RID: 15052
			// (get) Token: 0x0600BD7A RID: 48506 RVA: 0x002EA110 File Offset: 0x002E8310
			// (set) Token: 0x0600BD7B RID: 48507 RVA: 0x0005CBC2 File Offset: 0x0005ADC2
			public unsafe static float NoiseIntensityMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseIntensityMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseIntensityMin, (void*)(&value));
				}
			}

			// Token: 0x17003ACD RID: 15053
			// (get) Token: 0x0600BD7C RID: 48508 RVA: 0x002EA12C File Offset: 0x002E832C
			// (set) Token: 0x0600BD7D RID: 48509 RVA: 0x0005CBD0 File Offset: 0x0005ADD0
			public unsafe static float NoiseIntensityMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseIntensityMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseIntensityMax, (void*)(&value));
				}
			}

			// Token: 0x17003ACE RID: 15054
			// (get) Token: 0x0600BD7E RID: 48510 RVA: 0x002EA148 File Offset: 0x002E8348
			// (set) Token: 0x0600BD7F RID: 48511 RVA: 0x0005CBDE File Offset: 0x0005ADDE
			public unsafe static float NoiseIntensityDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseIntensityDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseIntensityDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ACF RID: 15055
			// (get) Token: 0x0600BD80 RID: 48512 RVA: 0x002EA164 File Offset: 0x002E8364
			// (set) Token: 0x0600BD81 RID: 48513 RVA: 0x0005CBEC File Offset: 0x0005ADEC
			public unsafe static float NoiseScaleMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseScaleMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseScaleMin, (void*)(&value));
				}
			}

			// Token: 0x17003AD0 RID: 15056
			// (get) Token: 0x0600BD82 RID: 48514 RVA: 0x002EA180 File Offset: 0x002E8380
			// (set) Token: 0x0600BD83 RID: 48515 RVA: 0x0005CBFA File Offset: 0x0005ADFA
			public unsafe static float NoiseScaleMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseScaleMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseScaleMax, (void*)(&value));
				}
			}

			// Token: 0x17003AD1 RID: 15057
			// (get) Token: 0x0600BD84 RID: 48516 RVA: 0x002EA19C File Offset: 0x002E839C
			// (set) Token: 0x0600BD85 RID: 48517 RVA: 0x0005CC08 File Offset: 0x0005AE08
			public unsafe static float NoiseScaleDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseScaleDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseScaleDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AD2 RID: 15058
			// (get) Token: 0x0600BD86 RID: 48518 RVA: 0x002EA1B8 File Offset: 0x002E83B8
			// (set) Token: 0x0600BD87 RID: 48519 RVA: 0x0005CC16 File Offset: 0x0005AE16
			public unsafe static Vector3 NoiseVelocityDefault
			{
				get
				{
					Vector3 result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseVelocityDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseVelocityDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AD3 RID: 15059
			// (get) Token: 0x0600BD88 RID: 48520 RVA: 0x002EA1D4 File Offset: 0x002E83D4
			// (set) Token: 0x0600BD89 RID: 48521 RVA: 0x0005CC24 File Offset: 0x0005AE24
			public unsafe static BlendingMode BlendingModeDefault
			{
				get
				{
					BlendingMode result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_BlendingModeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_BlendingModeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AD4 RID: 15060
			// (get) Token: 0x0600BD8A RID: 48522 RVA: 0x002EA1F0 File Offset: 0x002E83F0
			// (set) Token: 0x0600BD8B RID: 48523 RVA: 0x0005CC32 File Offset: 0x0005AE32
			public unsafe static ShaderAccuracy ShaderAccuracyDefault
			{
				get
				{
					ShaderAccuracy result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_ShaderAccuracyDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_ShaderAccuracyDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AD5 RID: 15061
			// (get) Token: 0x0600BD8C RID: 48524 RVA: 0x002EA20C File Offset: 0x002E840C
			// (set) Token: 0x0600BD8D RID: 48525 RVA: 0x0005CC40 File Offset: 0x0005AE40
			public unsafe static float FadeOutBeginDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_FadeOutBeginDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_FadeOutBeginDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AD6 RID: 15062
			// (get) Token: 0x0600BD8E RID: 48526 RVA: 0x002EA228 File Offset: 0x002E8428
			// (set) Token: 0x0600BD8F RID: 48527 RVA: 0x0005CC4E File Offset: 0x0005AE4E
			public unsafe static float FadeOutEndDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_FadeOutEndDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_FadeOutEndDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AD7 RID: 15063
			// (get) Token: 0x0600BD90 RID: 48528 RVA: 0x002EA244 File Offset: 0x002E8444
			// (set) Token: 0x0600BD91 RID: 48529 RVA: 0x0005CC5C File Offset: 0x0005AE5C
			public unsafe static Dimensions DimensionsDefault
			{
				get
				{
					Dimensions result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_DimensionsDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_DimensionsDefault, (void*)(&value));
				}
			}

			// Token: 0x04008033 RID: 32819
			private static readonly IntPtr NativeFieldInfoPtr_FlatColor;

			// Token: 0x04008034 RID: 32820
			private static readonly IntPtr NativeFieldInfoPtr_ColorModeDefault;

			// Token: 0x04008035 RID: 32821
			private static readonly IntPtr NativeFieldInfoPtr_MultiplierDefault;

			// Token: 0x04008036 RID: 32822
			private static readonly IntPtr NativeFieldInfoPtr_MultiplierMin;

			// Token: 0x04008037 RID: 32823
			private static readonly IntPtr NativeFieldInfoPtr_IntensityDefault;

			// Token: 0x04008038 RID: 32824
			private static readonly IntPtr NativeFieldInfoPtr_IntensityMin;

			// Token: 0x04008039 RID: 32825
			private static readonly IntPtr NativeFieldInfoPtr_HDRPExposureWeightDefault;

			// Token: 0x0400803A RID: 32826
			private static readonly IntPtr NativeFieldInfoPtr_HDRPExposureWeightMin;

			// Token: 0x0400803B RID: 32827
			private static readonly IntPtr NativeFieldInfoPtr_HDRPExposureWeightMax;

			// Token: 0x0400803C RID: 32828
			private static readonly IntPtr NativeFieldInfoPtr_SpotAngleDefault;

			// Token: 0x0400803D RID: 32829
			private static readonly IntPtr NativeFieldInfoPtr_SpotAngleMin;

			// Token: 0x0400803E RID: 32830
			private static readonly IntPtr NativeFieldInfoPtr_SpotAngleMax;

			// Token: 0x0400803F RID: 32831
			private static readonly IntPtr NativeFieldInfoPtr_ConeRadiusStart;

			// Token: 0x04008040 RID: 32832
			private static readonly IntPtr NativeFieldInfoPtr_GeomMeshType;

			// Token: 0x04008041 RID: 32833
			private static readonly IntPtr NativeFieldInfoPtr_GeomSidesDefault;

			// Token: 0x04008042 RID: 32834
			private static readonly IntPtr NativeFieldInfoPtr_GeomSidesMin;

			// Token: 0x04008043 RID: 32835
			private static readonly IntPtr NativeFieldInfoPtr_GeomSidesMax;

			// Token: 0x04008044 RID: 32836
			private static readonly IntPtr NativeFieldInfoPtr_GeomSegmentsDefault;

			// Token: 0x04008045 RID: 32837
			private static readonly IntPtr NativeFieldInfoPtr_GeomSegmentsMin;

			// Token: 0x04008046 RID: 32838
			private static readonly IntPtr NativeFieldInfoPtr_GeomSegmentsMax;

			// Token: 0x04008047 RID: 32839
			private static readonly IntPtr NativeFieldInfoPtr_GeomCap;

			// Token: 0x04008048 RID: 32840
			private static readonly IntPtr NativeFieldInfoPtr_ScalableDefault;

			// Token: 0x04008049 RID: 32841
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationEquationDefault;

			// Token: 0x0400804A RID: 32842
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationCustomBlendingDefault;

			// Token: 0x0400804B RID: 32843
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationCustomBlendingMin;

			// Token: 0x0400804C RID: 32844
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationCustomBlendingMax;

			// Token: 0x0400804D RID: 32845
			private static readonly IntPtr NativeFieldInfoPtr_FallOffStart;

			// Token: 0x0400804E RID: 32846
			private static readonly IntPtr NativeFieldInfoPtr_FallOffEnd;

			// Token: 0x0400804F RID: 32847
			private static readonly IntPtr NativeFieldInfoPtr_FallOffDistancesMinThreshold;

			// Token: 0x04008050 RID: 32848
			private static readonly IntPtr NativeFieldInfoPtr_DepthBlendDistance;

			// Token: 0x04008051 RID: 32849
			private static readonly IntPtr NativeFieldInfoPtr_CameraClippingDistance;

			// Token: 0x04008052 RID: 32850
			private static readonly IntPtr NativeFieldInfoPtr_NoiseModeDefault;

			// Token: 0x04008053 RID: 32851
			private static readonly IntPtr NativeFieldInfoPtr_NoiseIntensityMin;

			// Token: 0x04008054 RID: 32852
			private static readonly IntPtr NativeFieldInfoPtr_NoiseIntensityMax;

			// Token: 0x04008055 RID: 32853
			private static readonly IntPtr NativeFieldInfoPtr_NoiseIntensityDefault;

			// Token: 0x04008056 RID: 32854
			private static readonly IntPtr NativeFieldInfoPtr_NoiseScaleMin;

			// Token: 0x04008057 RID: 32855
			private static readonly IntPtr NativeFieldInfoPtr_NoiseScaleMax;

			// Token: 0x04008058 RID: 32856
			private static readonly IntPtr NativeFieldInfoPtr_NoiseScaleDefault;

			// Token: 0x04008059 RID: 32857
			private static readonly IntPtr NativeFieldInfoPtr_NoiseVelocityDefault;

			// Token: 0x0400805A RID: 32858
			private static readonly IntPtr NativeFieldInfoPtr_BlendingModeDefault;

			// Token: 0x0400805B RID: 32859
			private static readonly IntPtr NativeFieldInfoPtr_ShaderAccuracyDefault;

			// Token: 0x0400805C RID: 32860
			private static readonly IntPtr NativeFieldInfoPtr_FadeOutBeginDefault;

			// Token: 0x0400805D RID: 32861
			private static readonly IntPtr NativeFieldInfoPtr_FadeOutEndDefault;

			// Token: 0x0400805E RID: 32862
			private static readonly IntPtr NativeFieldInfoPtr_DimensionsDefault;

			// Token: 0x02000C21 RID: 3105
			public static class SD : Il2CppSystem.Object
			{
				// Token: 0x0600E0DB RID: 57563 RVA: 0x0034E68C File Offset: 0x0034C88C
				// Note: this type is marked as 'beforefieldinit'.
				static SD()
				{
					Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "SD");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr);
					Consts.Beam.SD.NativeFieldInfoPtr_FresnelPowMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "FresnelPowMaxValue");
					Consts.Beam.SD.NativeFieldInfoPtr_FresnelPow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "FresnelPow");
					Consts.Beam.SD.NativeFieldInfoPtr_GlareFrontalDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "GlareFrontalDefault");
					Consts.Beam.SD.NativeFieldInfoPtr_GlareBehindDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "GlareBehindDefault");
					Consts.Beam.SD.NativeFieldInfoPtr_GlareMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "GlareMin");
					Consts.Beam.SD.NativeFieldInfoPtr_GlareMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "GlareMax");
					Consts.Beam.SD.NativeFieldInfoPtr_TiltDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "TiltDefault");
					Consts.Beam.SD.NativeFieldInfoPtr_SkewingLocalForwardDirectionDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "SkewingLocalForwardDirectionDefault");
					Consts.Beam.SD.NativeFieldInfoPtr_ClippingPlaneTransformDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "ClippingPlaneTransformDefault");
				}

				// Token: 0x0600E0DC RID: 57564 RVA: 0x0006DA2D File Offset: 0x0006BC2D
				public SD(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045A2 RID: 17826
				// (get) Token: 0x0600E0DD RID: 57565 RVA: 0x0034E76C File Offset: 0x0034C96C
				// (set) Token: 0x0600E0DE RID: 57566 RVA: 0x0006DA36 File Offset: 0x0006BC36
				public unsafe static float FresnelPowMaxValue
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_FresnelPowMaxValue, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_FresnelPowMaxValue, (void*)(&value));
					}
				}

				// Token: 0x170045A3 RID: 17827
				// (get) Token: 0x0600E0DF RID: 57567 RVA: 0x0034E788 File Offset: 0x0034C988
				// (set) Token: 0x0600E0E0 RID: 57568 RVA: 0x0006DA44 File Offset: 0x0006BC44
				public unsafe static float FresnelPow
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_FresnelPow, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_FresnelPow, (void*)(&value));
					}
				}

				// Token: 0x170045A4 RID: 17828
				// (get) Token: 0x0600E0E1 RID: 57569 RVA: 0x0034E7A4 File Offset: 0x0034C9A4
				// (set) Token: 0x0600E0E2 RID: 57570 RVA: 0x0006DA52 File Offset: 0x0006BC52
				public unsafe static float GlareFrontalDefault
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareFrontalDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareFrontalDefault, (void*)(&value));
					}
				}

				// Token: 0x170045A5 RID: 17829
				// (get) Token: 0x0600E0E3 RID: 57571 RVA: 0x0034E7C0 File Offset: 0x0034C9C0
				// (set) Token: 0x0600E0E4 RID: 57572 RVA: 0x0006DA60 File Offset: 0x0006BC60
				public unsafe static float GlareBehindDefault
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareBehindDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareBehindDefault, (void*)(&value));
					}
				}

				// Token: 0x170045A6 RID: 17830
				// (get) Token: 0x0600E0E5 RID: 57573 RVA: 0x0034E7DC File Offset: 0x0034C9DC
				// (set) Token: 0x0600E0E6 RID: 57574 RVA: 0x0006DA6E File Offset: 0x0006BC6E
				public unsafe static float GlareMin
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareMin, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareMin, (void*)(&value));
					}
				}

				// Token: 0x170045A7 RID: 17831
				// (get) Token: 0x0600E0E7 RID: 57575 RVA: 0x0034E7F8 File Offset: 0x0034C9F8
				// (set) Token: 0x0600E0E8 RID: 57576 RVA: 0x0006DA7C File Offset: 0x0006BC7C
				public unsafe static float GlareMax
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareMax, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareMax, (void*)(&value));
					}
				}

				// Token: 0x170045A8 RID: 17832
				// (get) Token: 0x0600E0E9 RID: 57577 RVA: 0x0034E814 File Offset: 0x0034CA14
				// (set) Token: 0x0600E0EA RID: 57578 RVA: 0x0006DA8A File Offset: 0x0006BC8A
				public unsafe static Vector2 TiltDefault
				{
					get
					{
						Vector2 result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_TiltDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_TiltDefault, (void*)(&value));
					}
				}

				// Token: 0x170045A9 RID: 17833
				// (get) Token: 0x0600E0EB RID: 57579 RVA: 0x0034E830 File Offset: 0x0034CA30
				// (set) Token: 0x0600E0EC RID: 57580 RVA: 0x0006DA98 File Offset: 0x0006BC98
				public unsafe static Vector3 SkewingLocalForwardDirectionDefault
				{
					get
					{
						Vector3 result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_SkewingLocalForwardDirectionDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_SkewingLocalForwardDirectionDefault, (void*)(&value));
					}
				}

				// Token: 0x170045AA RID: 17834
				// (get) Token: 0x0600E0ED RID: 57581 RVA: 0x0034E84C File Offset: 0x0034CA4C
				// (set) Token: 0x0600E0EE RID: 57582 RVA: 0x0006DAA6 File Offset: 0x0006BCA6
				public unsafe static Transform ClippingPlaneTransformDefault
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_ClippingPlaneTransformDefault, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_ClippingPlaneTransformDefault, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009684 RID: 38532
				private static readonly IntPtr NativeFieldInfoPtr_FresnelPowMaxValue;

				// Token: 0x04009685 RID: 38533
				private static readonly IntPtr NativeFieldInfoPtr_FresnelPow;

				// Token: 0x04009686 RID: 38534
				private static readonly IntPtr NativeFieldInfoPtr_GlareFrontalDefault;

				// Token: 0x04009687 RID: 38535
				private static readonly IntPtr NativeFieldInfoPtr_GlareBehindDefault;

				// Token: 0x04009688 RID: 38536
				private static readonly IntPtr NativeFieldInfoPtr_GlareMin;

				// Token: 0x04009689 RID: 38537
				private static readonly IntPtr NativeFieldInfoPtr_GlareMax;

				// Token: 0x0400968A RID: 38538
				private static readonly IntPtr NativeFieldInfoPtr_TiltDefault;

				// Token: 0x0400968B RID: 38539
				private static readonly IntPtr NativeFieldInfoPtr_SkewingLocalForwardDirectionDefault;

				// Token: 0x0400968C RID: 38540
				private static readonly IntPtr NativeFieldInfoPtr_ClippingPlaneTransformDefault;
			}

			// Token: 0x02000C22 RID: 3106
			public static class HD : Il2CppSystem.Object
			{
				// Token: 0x0600E0EF RID: 57583 RVA: 0x0034E874 File Offset: 0x0034CA74
				// Note: this type is marked as 'beforefieldinit'.
				static HD()
				{
					Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "HD");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr);
					Consts.Beam.HD.NativeFieldInfoPtr_AttenuationEquationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "AttenuationEquationDefault");
					Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "SideSoftnessDefault");
					Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "SideSoftnessMin");
					Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "SideSoftnessMax");
					Consts.Beam.HD.NativeFieldInfoPtr_JitteringFactorDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "JitteringFactorDefault");
					Consts.Beam.HD.NativeFieldInfoPtr_JitteringFactorMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "JitteringFactorMin");
					Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "JitteringFrameRateDefault");
					Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "JitteringFrameRateMin");
					Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "JitteringFrameRateMax");
					Consts.Beam.HD.NativeFieldInfoPtr_JitteringLerpRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "JitteringLerpRange");
				}

				// Token: 0x0600E0F0 RID: 57584 RVA: 0x0006DAB8 File Offset: 0x0006BCB8
				public HD(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045AB RID: 17835
				// (get) Token: 0x0600E0F1 RID: 57585 RVA: 0x0034E968 File Offset: 0x0034CB68
				// (set) Token: 0x0600E0F2 RID: 57586 RVA: 0x0006DAC1 File Offset: 0x0006BCC1
				public unsafe static AttenuationEquationHD AttenuationEquationDefault
				{
					get
					{
						AttenuationEquationHD result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_AttenuationEquationDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_AttenuationEquationDefault, (void*)(&value));
					}
				}

				// Token: 0x170045AC RID: 17836
				// (get) Token: 0x0600E0F3 RID: 57587 RVA: 0x0034E984 File Offset: 0x0034CB84
				// (set) Token: 0x0600E0F4 RID: 57588 RVA: 0x0006DACF File Offset: 0x0006BCCF
				public unsafe static float SideSoftnessDefault
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessDefault, (void*)(&value));
					}
				}

				// Token: 0x170045AD RID: 17837
				// (get) Token: 0x0600E0F5 RID: 57589 RVA: 0x0034E9A0 File Offset: 0x0034CBA0
				// (set) Token: 0x0600E0F6 RID: 57590 RVA: 0x0006DADD File Offset: 0x0006BCDD
				public unsafe static float SideSoftnessMin
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessMin, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessMin, (void*)(&value));
					}
				}

				// Token: 0x170045AE RID: 17838
				// (get) Token: 0x0600E0F7 RID: 57591 RVA: 0x0034E9BC File Offset: 0x0034CBBC
				// (set) Token: 0x0600E0F8 RID: 57592 RVA: 0x0006DAEB File Offset: 0x0006BCEB
				public unsafe static float SideSoftnessMax
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessMax, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessMax, (void*)(&value));
					}
				}

				// Token: 0x170045AF RID: 17839
				// (get) Token: 0x0600E0F9 RID: 57593 RVA: 0x0034E9D8 File Offset: 0x0034CBD8
				// (set) Token: 0x0600E0FA RID: 57594 RVA: 0x0006DAF9 File Offset: 0x0006BCF9
				public unsafe static float JitteringFactorDefault
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFactorDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFactorDefault, (void*)(&value));
					}
				}

				// Token: 0x170045B0 RID: 17840
				// (get) Token: 0x0600E0FB RID: 57595 RVA: 0x0034E9F4 File Offset: 0x0034CBF4
				// (set) Token: 0x0600E0FC RID: 57596 RVA: 0x0006DB07 File Offset: 0x0006BD07
				public unsafe static float JitteringFactorMin
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFactorMin, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFactorMin, (void*)(&value));
					}
				}

				// Token: 0x170045B1 RID: 17841
				// (get) Token: 0x0600E0FD RID: 57597 RVA: 0x0034EA10 File Offset: 0x0034CC10
				// (set) Token: 0x0600E0FE RID: 57598 RVA: 0x0006DB15 File Offset: 0x0006BD15
				public unsafe static int JitteringFrameRateDefault
				{
					get
					{
						int result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateDefault, (void*)(&value));
					}
				}

				// Token: 0x170045B2 RID: 17842
				// (get) Token: 0x0600E0FF RID: 57599 RVA: 0x0034EA2C File Offset: 0x0034CC2C
				// (set) Token: 0x0600E100 RID: 57600 RVA: 0x0006DB23 File Offset: 0x0006BD23
				public unsafe static int JitteringFrameRateMin
				{
					get
					{
						int result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateMin, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateMin, (void*)(&value));
					}
				}

				// Token: 0x170045B3 RID: 17843
				// (get) Token: 0x0600E101 RID: 57601 RVA: 0x0034EA48 File Offset: 0x0034CC48
				// (set) Token: 0x0600E102 RID: 57602 RVA: 0x0006DB31 File Offset: 0x0006BD31
				public unsafe static int JitteringFrameRateMax
				{
					get
					{
						int result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateMax, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateMax, (void*)(&value));
					}
				}

				// Token: 0x170045B4 RID: 17844
				// (get) Token: 0x0600E103 RID: 57603 RVA: 0x0034EA64 File Offset: 0x0034CC64
				// (set) Token: 0x0600E104 RID: 57604 RVA: 0x0006DB3F File Offset: 0x0006BD3F
				public unsafe static MinMaxRangeFloat JitteringLerpRange
				{
					get
					{
						MinMaxRangeFloat result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringLerpRange, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringLerpRange, (void*)(&value));
					}
				}

				// Token: 0x0400968D RID: 38541
				private static readonly IntPtr NativeFieldInfoPtr_AttenuationEquationDefault;

				// Token: 0x0400968E RID: 38542
				private static readonly IntPtr NativeFieldInfoPtr_SideSoftnessDefault;

				// Token: 0x0400968F RID: 38543
				private static readonly IntPtr NativeFieldInfoPtr_SideSoftnessMin;

				// Token: 0x04009690 RID: 38544
				private static readonly IntPtr NativeFieldInfoPtr_SideSoftnessMax;

				// Token: 0x04009691 RID: 38545
				private static readonly IntPtr NativeFieldInfoPtr_JitteringFactorDefault;

				// Token: 0x04009692 RID: 38546
				private static readonly IntPtr NativeFieldInfoPtr_JitteringFactorMin;

				// Token: 0x04009693 RID: 38547
				private static readonly IntPtr NativeFieldInfoPtr_JitteringFrameRateDefault;

				// Token: 0x04009694 RID: 38548
				private static readonly IntPtr NativeFieldInfoPtr_JitteringFrameRateMin;

				// Token: 0x04009695 RID: 38549
				private static readonly IntPtr NativeFieldInfoPtr_JitteringFrameRateMax;

				// Token: 0x04009696 RID: 38550
				private static readonly IntPtr NativeFieldInfoPtr_JitteringLerpRange;
			}
		}

		// Token: 0x02000811 RID: 2065
		public static class DustParticles : Il2CppSystem.Object
		{
			// Token: 0x0600BD92 RID: 48530 RVA: 0x002EA260 File Offset: 0x002E8460
			// Note: this type is marked as 'beforefieldinit'.
			static DustParticles()
			{
				Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DustParticles");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr);
				Consts.DustParticles.NativeFieldInfoPtr_AlphaDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "AlphaDefault");
				Consts.DustParticles.NativeFieldInfoPtr_SizeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "SizeDefault");
				Consts.DustParticles.NativeFieldInfoPtr_DirectionDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "DirectionDefault");
				Consts.DustParticles.NativeFieldInfoPtr_VelocityDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "VelocityDefault");
				Consts.DustParticles.NativeFieldInfoPtr_DensityDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "DensityDefault");
				Consts.DustParticles.NativeFieldInfoPtr_DensityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "DensityMin");
				Consts.DustParticles.NativeFieldInfoPtr_DensityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "DensityMax");
				Consts.DustParticles.NativeFieldInfoPtr_SpawnDistanceRangeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "SpawnDistanceRangeDefault");
				Consts.DustParticles.NativeFieldInfoPtr_CullingEnabledDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "CullingEnabledDefault");
				Consts.DustParticles.NativeFieldInfoPtr_CullingMaxDistanceDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "CullingMaxDistanceDefault");
				Consts.DustParticles.NativeFieldInfoPtr_CullingMaxDistanceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "CullingMaxDistanceMin");
			}

			// Token: 0x0600BD93 RID: 48531 RVA: 0x0005CC6A File Offset: 0x0005AE6A
			public DustParticles(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003AD8 RID: 15064
			// (get) Token: 0x0600BD94 RID: 48532 RVA: 0x002EA368 File Offset: 0x002E8568
			// (set) Token: 0x0600BD95 RID: 48533 RVA: 0x0005CC73 File Offset: 0x0005AE73
			public unsafe static float AlphaDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_AlphaDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_AlphaDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AD9 RID: 15065
			// (get) Token: 0x0600BD96 RID: 48534 RVA: 0x002EA384 File Offset: 0x002E8584
			// (set) Token: 0x0600BD97 RID: 48535 RVA: 0x0005CC81 File Offset: 0x0005AE81
			public unsafe static float SizeDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_SizeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_SizeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ADA RID: 15066
			// (get) Token: 0x0600BD98 RID: 48536 RVA: 0x002EA3A0 File Offset: 0x002E85A0
			// (set) Token: 0x0600BD99 RID: 48537 RVA: 0x0005CC8F File Offset: 0x0005AE8F
			public unsafe static ParticlesDirection DirectionDefault
			{
				get
				{
					ParticlesDirection result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_DirectionDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_DirectionDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ADB RID: 15067
			// (get) Token: 0x0600BD9A RID: 48538 RVA: 0x002EA3BC File Offset: 0x002E85BC
			// (set) Token: 0x0600BD9B RID: 48539 RVA: 0x0005CC9D File Offset: 0x0005AE9D
			public unsafe static Vector3 VelocityDefault
			{
				get
				{
					Vector3 result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_VelocityDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_VelocityDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ADC RID: 15068
			// (get) Token: 0x0600BD9C RID: 48540 RVA: 0x002EA3D8 File Offset: 0x002E85D8
			// (set) Token: 0x0600BD9D RID: 48541 RVA: 0x0005CCAB File Offset: 0x0005AEAB
			public unsafe static float DensityDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_DensityDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_DensityDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ADD RID: 15069
			// (get) Token: 0x0600BD9E RID: 48542 RVA: 0x002EA3F4 File Offset: 0x002E85F4
			// (set) Token: 0x0600BD9F RID: 48543 RVA: 0x0005CCB9 File Offset: 0x0005AEB9
			public unsafe static float DensityMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_DensityMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_DensityMin, (void*)(&value));
				}
			}

			// Token: 0x17003ADE RID: 15070
			// (get) Token: 0x0600BDA0 RID: 48544 RVA: 0x002EA410 File Offset: 0x002E8610
			// (set) Token: 0x0600BDA1 RID: 48545 RVA: 0x0005CCC7 File Offset: 0x0005AEC7
			public unsafe static float DensityMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_DensityMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_DensityMax, (void*)(&value));
				}
			}

			// Token: 0x17003ADF RID: 15071
			// (get) Token: 0x0600BDA2 RID: 48546 RVA: 0x002EA42C File Offset: 0x002E862C
			// (set) Token: 0x0600BDA3 RID: 48547 RVA: 0x0005CCD5 File Offset: 0x0005AED5
			public unsafe static MinMaxRangeFloat SpawnDistanceRangeDefault
			{
				get
				{
					MinMaxRangeFloat result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_SpawnDistanceRangeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_SpawnDistanceRangeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AE0 RID: 15072
			// (get) Token: 0x0600BDA4 RID: 48548 RVA: 0x002EA448 File Offset: 0x002E8648
			// (set) Token: 0x0600BDA5 RID: 48549 RVA: 0x0005CCE3 File Offset: 0x0005AEE3
			public unsafe static bool CullingEnabledDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_CullingEnabledDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_CullingEnabledDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AE1 RID: 15073
			// (get) Token: 0x0600BDA6 RID: 48550 RVA: 0x002EA464 File Offset: 0x002E8664
			// (set) Token: 0x0600BDA7 RID: 48551 RVA: 0x0005CCF1 File Offset: 0x0005AEF1
			public unsafe static float CullingMaxDistanceDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_CullingMaxDistanceDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_CullingMaxDistanceDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AE2 RID: 15074
			// (get) Token: 0x0600BDA8 RID: 48552 RVA: 0x002EA480 File Offset: 0x002E8680
			// (set) Token: 0x0600BDA9 RID: 48553 RVA: 0x0005CCFF File Offset: 0x0005AEFF
			public unsafe static float CullingMaxDistanceMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_CullingMaxDistanceMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_CullingMaxDistanceMin, (void*)(&value));
				}
			}

			// Token: 0x0400805F RID: 32863
			private static readonly IntPtr NativeFieldInfoPtr_AlphaDefault;

			// Token: 0x04008060 RID: 32864
			private static readonly IntPtr NativeFieldInfoPtr_SizeDefault;

			// Token: 0x04008061 RID: 32865
			private static readonly IntPtr NativeFieldInfoPtr_DirectionDefault;

			// Token: 0x04008062 RID: 32866
			private static readonly IntPtr NativeFieldInfoPtr_VelocityDefault;

			// Token: 0x04008063 RID: 32867
			private static readonly IntPtr NativeFieldInfoPtr_DensityDefault;

			// Token: 0x04008064 RID: 32868
			private static readonly IntPtr NativeFieldInfoPtr_DensityMin;

			// Token: 0x04008065 RID: 32869
			private static readonly IntPtr NativeFieldInfoPtr_DensityMax;

			// Token: 0x04008066 RID: 32870
			private static readonly IntPtr NativeFieldInfoPtr_SpawnDistanceRangeDefault;

			// Token: 0x04008067 RID: 32871
			private static readonly IntPtr NativeFieldInfoPtr_CullingEnabledDefault;

			// Token: 0x04008068 RID: 32872
			private static readonly IntPtr NativeFieldInfoPtr_CullingMaxDistanceDefault;

			// Token: 0x04008069 RID: 32873
			private static readonly IntPtr NativeFieldInfoPtr_CullingMaxDistanceMin;
		}

		// Token: 0x02000812 RID: 2066
		public static class DynOcclusion : Il2CppSystem.Object
		{
			// Token: 0x0600BDAA RID: 48554 RVA: 0x002EA49C File Offset: 0x002E869C
			// Note: this type is marked as 'beforefieldinit'.
			static DynOcclusion()
			{
				Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusion");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr);
				Consts.DynOcclusion.NativeFieldInfoPtr_LayerMaskDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "LayerMaskDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_UpdateRateDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "UpdateRateDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_WaitFramesCountDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "WaitFramesCountDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingDimensionsDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingDimensionsDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingConsiderTriggersDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingConsiderTriggersDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinOccluderAreaDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMinOccluderAreaDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMinSurfaceRatioDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMinSurfaceRatioMin");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMinSurfaceRatioMax");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceDotDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMaxSurfaceDotDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMaxSurfaceAngleMin");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMaxSurfaceAngleMax");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingPlaneAlignmentDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingPlaneAlignmentDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingPlaneOffsetDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingPlaneOffsetDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingFadeDistanceToSurfaceDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingFadeDistanceToSurfaceDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferDepthMapResolutionDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "DepthBufferDepthMapResolutionDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferOcclusionCullingDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "DepthBufferOcclusionCullingDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferFadeDistanceToSurfaceDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "DepthBufferFadeDistanceToSurfaceDefault");
			}

			// Token: 0x0600BDAB RID: 48555 RVA: 0x0005CD0D File Offset: 0x0005AF0D
			public DynOcclusion(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003AE3 RID: 15075
			// (get) Token: 0x0600BDAC RID: 48556 RVA: 0x002EA630 File Offset: 0x002E8830
			// (set) Token: 0x0600BDAD RID: 48557 RVA: 0x0005CD16 File Offset: 0x0005AF16
			public unsafe static LayerMask LayerMaskDefault
			{
				get
				{
					LayerMask result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_LayerMaskDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_LayerMaskDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AE4 RID: 15076
			// (get) Token: 0x0600BDAE RID: 48558 RVA: 0x002EA64C File Offset: 0x002E884C
			// (set) Token: 0x0600BDAF RID: 48559 RVA: 0x0005CD24 File Offset: 0x0005AF24
			public unsafe static DynamicOcclusionUpdateRate UpdateRateDefault
			{
				get
				{
					DynamicOcclusionUpdateRate result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_UpdateRateDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_UpdateRateDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AE5 RID: 15077
			// (get) Token: 0x0600BDB0 RID: 48560 RVA: 0x002EA668 File Offset: 0x002E8868
			// (set) Token: 0x0600BDB1 RID: 48561 RVA: 0x0005CD32 File Offset: 0x0005AF32
			public unsafe static int WaitFramesCountDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_WaitFramesCountDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_WaitFramesCountDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AE6 RID: 15078
			// (get) Token: 0x0600BDB2 RID: 48562 RVA: 0x002EA684 File Offset: 0x002E8884
			// (set) Token: 0x0600BDB3 RID: 48563 RVA: 0x0005CD40 File Offset: 0x0005AF40
			public unsafe static Dimensions RaycastingDimensionsDefault
			{
				get
				{
					Dimensions result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingDimensionsDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingDimensionsDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AE7 RID: 15079
			// (get) Token: 0x0600BDB4 RID: 48564 RVA: 0x002EA6A0 File Offset: 0x002E88A0
			// (set) Token: 0x0600BDB5 RID: 48565 RVA: 0x0005CD4E File Offset: 0x0005AF4E
			public unsafe static bool RaycastingConsiderTriggersDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingConsiderTriggersDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingConsiderTriggersDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AE8 RID: 15080
			// (get) Token: 0x0600BDB6 RID: 48566 RVA: 0x002EA6BC File Offset: 0x002E88BC
			// (set) Token: 0x0600BDB7 RID: 48567 RVA: 0x0005CD5C File Offset: 0x0005AF5C
			public unsafe static float RaycastingMinOccluderAreaDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinOccluderAreaDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinOccluderAreaDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AE9 RID: 15081
			// (get) Token: 0x0600BDB8 RID: 48568 RVA: 0x002EA6D8 File Offset: 0x002E88D8
			// (set) Token: 0x0600BDB9 RID: 48569 RVA: 0x0005CD6A File Offset: 0x0005AF6A
			public unsafe static float RaycastingMinSurfaceRatioDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AEA RID: 15082
			// (get) Token: 0x0600BDBA RID: 48570 RVA: 0x002EA6F4 File Offset: 0x002E88F4
			// (set) Token: 0x0600BDBB RID: 48571 RVA: 0x0005CD78 File Offset: 0x0005AF78
			public unsafe static float RaycastingMinSurfaceRatioMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioMin, (void*)(&value));
				}
			}

			// Token: 0x17003AEB RID: 15083
			// (get) Token: 0x0600BDBC RID: 48572 RVA: 0x002EA710 File Offset: 0x002E8910
			// (set) Token: 0x0600BDBD RID: 48573 RVA: 0x0005CD86 File Offset: 0x0005AF86
			public unsafe static float RaycastingMinSurfaceRatioMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioMax, (void*)(&value));
				}
			}

			// Token: 0x17003AEC RID: 15084
			// (get) Token: 0x0600BDBE RID: 48574 RVA: 0x002EA72C File Offset: 0x002E892C
			// (set) Token: 0x0600BDBF RID: 48575 RVA: 0x0005CD94 File Offset: 0x0005AF94
			public unsafe static float RaycastingMaxSurfaceDotDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceDotDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceDotDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AED RID: 15085
			// (get) Token: 0x0600BDC0 RID: 48576 RVA: 0x002EA748 File Offset: 0x002E8948
			// (set) Token: 0x0600BDC1 RID: 48577 RVA: 0x0005CDA2 File Offset: 0x0005AFA2
			public unsafe static float RaycastingMaxSurfaceAngleMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMin, (void*)(&value));
				}
			}

			// Token: 0x17003AEE RID: 15086
			// (get) Token: 0x0600BDC2 RID: 48578 RVA: 0x002EA764 File Offset: 0x002E8964
			// (set) Token: 0x0600BDC3 RID: 48579 RVA: 0x0005CDB0 File Offset: 0x0005AFB0
			public unsafe static float RaycastingMaxSurfaceAngleMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMax, (void*)(&value));
				}
			}

			// Token: 0x17003AEF RID: 15087
			// (get) Token: 0x0600BDC4 RID: 48580 RVA: 0x002EA780 File Offset: 0x002E8980
			// (set) Token: 0x0600BDC5 RID: 48581 RVA: 0x0005CDBE File Offset: 0x0005AFBE
			public unsafe static PlaneAlignment RaycastingPlaneAlignmentDefault
			{
				get
				{
					PlaneAlignment result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingPlaneAlignmentDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingPlaneAlignmentDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AF0 RID: 15088
			// (get) Token: 0x0600BDC6 RID: 48582 RVA: 0x002EA79C File Offset: 0x002E899C
			// (set) Token: 0x0600BDC7 RID: 48583 RVA: 0x0005CDCC File Offset: 0x0005AFCC
			public unsafe static float RaycastingPlaneOffsetDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingPlaneOffsetDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingPlaneOffsetDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AF1 RID: 15089
			// (get) Token: 0x0600BDC8 RID: 48584 RVA: 0x002EA7B8 File Offset: 0x002E89B8
			// (set) Token: 0x0600BDC9 RID: 48585 RVA: 0x0005CDDA File Offset: 0x0005AFDA
			public unsafe static float RaycastingFadeDistanceToSurfaceDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingFadeDistanceToSurfaceDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingFadeDistanceToSurfaceDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AF2 RID: 15090
			// (get) Token: 0x0600BDCA RID: 48586 RVA: 0x002EA7D4 File Offset: 0x002E89D4
			// (set) Token: 0x0600BDCB RID: 48587 RVA: 0x0005CDE8 File Offset: 0x0005AFE8
			public unsafe static int DepthBufferDepthMapResolutionDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferDepthMapResolutionDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferDepthMapResolutionDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AF3 RID: 15091
			// (get) Token: 0x0600BDCC RID: 48588 RVA: 0x002EA7F0 File Offset: 0x002E89F0
			// (set) Token: 0x0600BDCD RID: 48589 RVA: 0x0005CDF6 File Offset: 0x0005AFF6
			public unsafe static bool DepthBufferOcclusionCullingDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferOcclusionCullingDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferOcclusionCullingDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AF4 RID: 15092
			// (get) Token: 0x0600BDCE RID: 48590 RVA: 0x002EA80C File Offset: 0x002E8A0C
			// (set) Token: 0x0600BDCF RID: 48591 RVA: 0x0005CE04 File Offset: 0x0005B004
			public unsafe static float DepthBufferFadeDistanceToSurfaceDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferFadeDistanceToSurfaceDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferFadeDistanceToSurfaceDefault, (void*)(&value));
				}
			}

			// Token: 0x0400806A RID: 32874
			private static readonly IntPtr NativeFieldInfoPtr_LayerMaskDefault;

			// Token: 0x0400806B RID: 32875
			private static readonly IntPtr NativeFieldInfoPtr_UpdateRateDefault;

			// Token: 0x0400806C RID: 32876
			private static readonly IntPtr NativeFieldInfoPtr_WaitFramesCountDefault;

			// Token: 0x0400806D RID: 32877
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingDimensionsDefault;

			// Token: 0x0400806E RID: 32878
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingConsiderTriggersDefault;

			// Token: 0x0400806F RID: 32879
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMinOccluderAreaDefault;

			// Token: 0x04008070 RID: 32880
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMinSurfaceRatioDefault;

			// Token: 0x04008071 RID: 32881
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMinSurfaceRatioMin;

			// Token: 0x04008072 RID: 32882
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMinSurfaceRatioMax;

			// Token: 0x04008073 RID: 32883
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMaxSurfaceDotDefault;

			// Token: 0x04008074 RID: 32884
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMin;

			// Token: 0x04008075 RID: 32885
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMax;

			// Token: 0x04008076 RID: 32886
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingPlaneAlignmentDefault;

			// Token: 0x04008077 RID: 32887
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingPlaneOffsetDefault;

			// Token: 0x04008078 RID: 32888
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingFadeDistanceToSurfaceDefault;

			// Token: 0x04008079 RID: 32889
			private static readonly IntPtr NativeFieldInfoPtr_DepthBufferDepthMapResolutionDefault;

			// Token: 0x0400807A RID: 32890
			private static readonly IntPtr NativeFieldInfoPtr_DepthBufferOcclusionCullingDefault;

			// Token: 0x0400807B RID: 32891
			private static readonly IntPtr NativeFieldInfoPtr_DepthBufferFadeDistanceToSurfaceDefault;
		}

		// Token: 0x02000813 RID: 2067
		public static class Effects : Il2CppSystem.Object
		{
			// Token: 0x0600BDD0 RID: 48592 RVA: 0x002EA828 File Offset: 0x002E8A28
			// Note: this type is marked as 'beforefieldinit'.
			static Effects()
			{
				Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Effects");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr);
				Consts.Effects.NativeFieldInfoPtr_ComponentsToChangeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "ComponentsToChangeDefault");
				Consts.Effects.NativeFieldInfoPtr_RestoreIntensityOnDisableDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "RestoreIntensityOnDisableDefault");
				Consts.Effects.NativeFieldInfoPtr_FrequencyDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "FrequencyDefault");
				Consts.Effects.NativeFieldInfoPtr_PerformPausesDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "PerformPausesDefault");
				Consts.Effects.NativeFieldInfoPtr_RestoreIntensityOnPauseDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "RestoreIntensityOnPauseDefault");
				Consts.Effects.NativeFieldInfoPtr_FlickeringDurationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "FlickeringDurationDefault");
				Consts.Effects.NativeFieldInfoPtr_PauseDurationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "PauseDurationDefault");
				Consts.Effects.NativeFieldInfoPtr_IntensityAmplitudeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "IntensityAmplitudeDefault");
				Consts.Effects.NativeFieldInfoPtr_SmoothingDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "SmoothingDefault");
			}

			// Token: 0x0600BDD1 RID: 48593 RVA: 0x0005CE12 File Offset: 0x0005B012
			public Effects(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003AF5 RID: 15093
			// (get) Token: 0x0600BDD2 RID: 48594 RVA: 0x002EA908 File Offset: 0x002E8B08
			// (set) Token: 0x0600BDD3 RID: 48595 RVA: 0x0005CE1B File Offset: 0x0005B01B
			public unsafe static EffectAbstractBase.ComponentsToChange ComponentsToChangeDefault
			{
				get
				{
					EffectAbstractBase.ComponentsToChange result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_ComponentsToChangeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_ComponentsToChangeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AF6 RID: 15094
			// (get) Token: 0x0600BDD4 RID: 48596 RVA: 0x002EA924 File Offset: 0x002E8B24
			// (set) Token: 0x0600BDD5 RID: 48597 RVA: 0x0005CE29 File Offset: 0x0005B029
			public unsafe static bool RestoreIntensityOnDisableDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_RestoreIntensityOnDisableDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_RestoreIntensityOnDisableDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AF7 RID: 15095
			// (get) Token: 0x0600BDD6 RID: 48598 RVA: 0x002EA940 File Offset: 0x002E8B40
			// (set) Token: 0x0600BDD7 RID: 48599 RVA: 0x0005CE37 File Offset: 0x0005B037
			public unsafe static float FrequencyDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_FrequencyDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_FrequencyDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AF8 RID: 15096
			// (get) Token: 0x0600BDD8 RID: 48600 RVA: 0x002EA95C File Offset: 0x002E8B5C
			// (set) Token: 0x0600BDD9 RID: 48601 RVA: 0x0005CE45 File Offset: 0x0005B045
			public unsafe static bool PerformPausesDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_PerformPausesDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_PerformPausesDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AF9 RID: 15097
			// (get) Token: 0x0600BDDA RID: 48602 RVA: 0x002EA978 File Offset: 0x002E8B78
			// (set) Token: 0x0600BDDB RID: 48603 RVA: 0x0005CE53 File Offset: 0x0005B053
			public unsafe static bool RestoreIntensityOnPauseDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_RestoreIntensityOnPauseDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_RestoreIntensityOnPauseDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AFA RID: 15098
			// (get) Token: 0x0600BDDC RID: 48604 RVA: 0x002EA994 File Offset: 0x002E8B94
			// (set) Token: 0x0600BDDD RID: 48605 RVA: 0x0005CE61 File Offset: 0x0005B061
			public unsafe static MinMaxRangeFloat FlickeringDurationDefault
			{
				get
				{
					MinMaxRangeFloat result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_FlickeringDurationDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_FlickeringDurationDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AFB RID: 15099
			// (get) Token: 0x0600BDDE RID: 48606 RVA: 0x002EA9B0 File Offset: 0x002E8BB0
			// (set) Token: 0x0600BDDF RID: 48607 RVA: 0x0005CE6F File Offset: 0x0005B06F
			public unsafe static MinMaxRangeFloat PauseDurationDefault
			{
				get
				{
					MinMaxRangeFloat result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_PauseDurationDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_PauseDurationDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AFC RID: 15100
			// (get) Token: 0x0600BDE0 RID: 48608 RVA: 0x002EA9CC File Offset: 0x002E8BCC
			// (set) Token: 0x0600BDE1 RID: 48609 RVA: 0x0005CE7D File Offset: 0x0005B07D
			public unsafe static MinMaxRangeFloat IntensityAmplitudeDefault
			{
				get
				{
					MinMaxRangeFloat result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_IntensityAmplitudeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_IntensityAmplitudeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AFD RID: 15101
			// (get) Token: 0x0600BDE2 RID: 48610 RVA: 0x002EA9E8 File Offset: 0x002E8BE8
			// (set) Token: 0x0600BDE3 RID: 48611 RVA: 0x0005CE8B File Offset: 0x0005B08B
			public unsafe static float SmoothingDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_SmoothingDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_SmoothingDefault, (void*)(&value));
				}
			}

			// Token: 0x0400807C RID: 32892
			private static readonly IntPtr NativeFieldInfoPtr_ComponentsToChangeDefault;

			// Token: 0x0400807D RID: 32893
			private static readonly IntPtr NativeFieldInfoPtr_RestoreIntensityOnDisableDefault;

			// Token: 0x0400807E RID: 32894
			private static readonly IntPtr NativeFieldInfoPtr_FrequencyDefault;

			// Token: 0x0400807F RID: 32895
			private static readonly IntPtr NativeFieldInfoPtr_PerformPausesDefault;

			// Token: 0x04008080 RID: 32896
			private static readonly IntPtr NativeFieldInfoPtr_RestoreIntensityOnPauseDefault;

			// Token: 0x04008081 RID: 32897
			private static readonly IntPtr NativeFieldInfoPtr_FlickeringDurationDefault;

			// Token: 0x04008082 RID: 32898
			private static readonly IntPtr NativeFieldInfoPtr_PauseDurationDefault;

			// Token: 0x04008083 RID: 32899
			private static readonly IntPtr NativeFieldInfoPtr_IntensityAmplitudeDefault;

			// Token: 0x04008084 RID: 32900
			private static readonly IntPtr NativeFieldInfoPtr_SmoothingDefault;
		}

		// Token: 0x02000814 RID: 2068
		public static class Shadow : Il2CppSystem.Object
		{
			// Token: 0x0600BDE4 RID: 48612 RVA: 0x002EAA04 File Offset: 0x002E8C04
			// Note: this type is marked as 'beforefieldinit'.
			static Shadow()
			{
				Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Shadow");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr);
				Consts.Shadow.NativeFieldInfoPtr_StrengthDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "StrengthDefault");
				Consts.Shadow.NativeFieldInfoPtr_StrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "StrengthMin");
				Consts.Shadow.NativeFieldInfoPtr_StrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "StrengthMax");
				Consts.Shadow.NativeFieldInfoPtr_LayerMaskDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "LayerMaskDefault");
				Consts.Shadow.NativeFieldInfoPtr_UpdateRateDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "UpdateRateDefault");
				Consts.Shadow.NativeFieldInfoPtr_WaitFramesCountDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "WaitFramesCountDefault");
				Consts.Shadow.NativeFieldInfoPtr_DepthMapResolutionDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "DepthMapResolutionDefault");
				Consts.Shadow.NativeFieldInfoPtr_OcclusionCullingDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "OcclusionCullingDefault");
				Consts.Shadow.NativeMethodInfoPtr_GetErrorChangeRuntimeDepthMapResolution_Public_Static_String_VolumetricShadowHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, 100664277);
			}

			// Token: 0x0600BDE5 RID: 48613 RVA: 0x002EAAE4 File Offset: 0x002E8CE4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 80048, RefRangeEnd = 80049, XrefRangeStart = 80040, XrefRangeEnd = 80048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string GetErrorChangeRuntimeDepthMapResolution(VolumetricShadowHD comp)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Consts.Shadow.NativeMethodInfoPtr_GetErrorChangeRuntimeDepthMapResolution_Public_Static_String_VolumetricShadowHD_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600BDE6 RID: 48614 RVA: 0x0005CE99 File Offset: 0x0005B099
			public Shadow(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003AFE RID: 15102
			// (get) Token: 0x0600BDE7 RID: 48615 RVA: 0x002EAB20 File Offset: 0x002E8D20
			// (set) Token: 0x0600BDE8 RID: 48616 RVA: 0x0005CEA2 File Offset: 0x0005B0A2
			public unsafe static float StrengthDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_StrengthDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_StrengthDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AFF RID: 15103
			// (get) Token: 0x0600BDE9 RID: 48617 RVA: 0x002EAB3C File Offset: 0x002E8D3C
			// (set) Token: 0x0600BDEA RID: 48618 RVA: 0x0005CEB0 File Offset: 0x0005B0B0
			public unsafe static float StrengthMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_StrengthMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_StrengthMin, (void*)(&value));
				}
			}

			// Token: 0x17003B00 RID: 15104
			// (get) Token: 0x0600BDEB RID: 48619 RVA: 0x002EAB58 File Offset: 0x002E8D58
			// (set) Token: 0x0600BDEC RID: 48620 RVA: 0x0005CEBE File Offset: 0x0005B0BE
			public unsafe static float StrengthMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_StrengthMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_StrengthMax, (void*)(&value));
				}
			}

			// Token: 0x17003B01 RID: 15105
			// (get) Token: 0x0600BDED RID: 48621 RVA: 0x002EAB74 File Offset: 0x002E8D74
			// (set) Token: 0x0600BDEE RID: 48622 RVA: 0x0005CECC File Offset: 0x0005B0CC
			public unsafe static LayerMask LayerMaskDefault
			{
				get
				{
					LayerMask result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_LayerMaskDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_LayerMaskDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B02 RID: 15106
			// (get) Token: 0x0600BDEF RID: 48623 RVA: 0x002EAB90 File Offset: 0x002E8D90
			// (set) Token: 0x0600BDF0 RID: 48624 RVA: 0x0005CEDA File Offset: 0x0005B0DA
			public unsafe static ShadowUpdateRate UpdateRateDefault
			{
				get
				{
					ShadowUpdateRate result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_UpdateRateDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_UpdateRateDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B03 RID: 15107
			// (get) Token: 0x0600BDF1 RID: 48625 RVA: 0x002EABAC File Offset: 0x002E8DAC
			// (set) Token: 0x0600BDF2 RID: 48626 RVA: 0x0005CEE8 File Offset: 0x0005B0E8
			public unsafe static int WaitFramesCountDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_WaitFramesCountDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_WaitFramesCountDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B04 RID: 15108
			// (get) Token: 0x0600BDF3 RID: 48627 RVA: 0x002EABC8 File Offset: 0x002E8DC8
			// (set) Token: 0x0600BDF4 RID: 48628 RVA: 0x0005CEF6 File Offset: 0x0005B0F6
			public unsafe static int DepthMapResolutionDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_DepthMapResolutionDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_DepthMapResolutionDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B05 RID: 15109
			// (get) Token: 0x0600BDF5 RID: 48629 RVA: 0x002EABE4 File Offset: 0x002E8DE4
			// (set) Token: 0x0600BDF6 RID: 48630 RVA: 0x0005CF04 File Offset: 0x0005B104
			public unsafe static bool OcclusionCullingDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_OcclusionCullingDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_OcclusionCullingDefault, (void*)(&value));
				}
			}

			// Token: 0x04008085 RID: 32901
			private static readonly IntPtr NativeFieldInfoPtr_StrengthDefault;

			// Token: 0x04008086 RID: 32902
			private static readonly IntPtr NativeFieldInfoPtr_StrengthMin;

			// Token: 0x04008087 RID: 32903
			private static readonly IntPtr NativeFieldInfoPtr_StrengthMax;

			// Token: 0x04008088 RID: 32904
			private static readonly IntPtr NativeFieldInfoPtr_LayerMaskDefault;

			// Token: 0x04008089 RID: 32905
			private static readonly IntPtr NativeFieldInfoPtr_UpdateRateDefault;

			// Token: 0x0400808A RID: 32906
			private static readonly IntPtr NativeFieldInfoPtr_WaitFramesCountDefault;

			// Token: 0x0400808B RID: 32907
			private static readonly IntPtr NativeFieldInfoPtr_DepthMapResolutionDefault;

			// Token: 0x0400808C RID: 32908
			private static readonly IntPtr NativeFieldInfoPtr_OcclusionCullingDefault;

			// Token: 0x0400808D RID: 32909
			private static readonly IntPtr NativeMethodInfoPtr_GetErrorChangeRuntimeDepthMapResolution_Public_Static_String_VolumetricShadowHD_0;
		}

		// Token: 0x02000815 RID: 2069
		public static class Cookie : Il2CppSystem.Object
		{
			// Token: 0x0600BDF7 RID: 48631 RVA: 0x002EAC00 File Offset: 0x002E8E00
			// Note: this type is marked as 'beforefieldinit'.
			static Cookie()
			{
				Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Cookie");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr);
				Consts.Cookie.NativeFieldInfoPtr_ContributionDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "ContributionDefault");
				Consts.Cookie.NativeFieldInfoPtr_ContributionMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "ContributionMin");
				Consts.Cookie.NativeFieldInfoPtr_ContributionMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "ContributionMax");
				Consts.Cookie.NativeFieldInfoPtr_CookieTextureDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "CookieTextureDefault");
				Consts.Cookie.NativeFieldInfoPtr_ChannelDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "ChannelDefault");
				Consts.Cookie.NativeFieldInfoPtr_NegativeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "NegativeDefault");
				Consts.Cookie.NativeFieldInfoPtr_TranslationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "TranslationDefault");
				Consts.Cookie.NativeFieldInfoPtr_RotationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "RotationDefault");
				Consts.Cookie.NativeFieldInfoPtr_ScaleDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "ScaleDefault");
			}

			// Token: 0x0600BDF8 RID: 48632 RVA: 0x0005CF12 File Offset: 0x0005B112
			public Cookie(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B06 RID: 15110
			// (get) Token: 0x0600BDF9 RID: 48633 RVA: 0x002EACE0 File Offset: 0x002E8EE0
			// (set) Token: 0x0600BDFA RID: 48634 RVA: 0x0005CF1B File Offset: 0x0005B11B
			public unsafe static float ContributionDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_ContributionDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_ContributionDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B07 RID: 15111
			// (get) Token: 0x0600BDFB RID: 48635 RVA: 0x002EACFC File Offset: 0x002E8EFC
			// (set) Token: 0x0600BDFC RID: 48636 RVA: 0x0005CF29 File Offset: 0x0005B129
			public unsafe static float ContributionMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_ContributionMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_ContributionMin, (void*)(&value));
				}
			}

			// Token: 0x17003B08 RID: 15112
			// (get) Token: 0x0600BDFD RID: 48637 RVA: 0x002EAD18 File Offset: 0x002E8F18
			// (set) Token: 0x0600BDFE RID: 48638 RVA: 0x0005CF37 File Offset: 0x0005B137
			public unsafe static float ContributionMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_ContributionMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_ContributionMax, (void*)(&value));
				}
			}

			// Token: 0x17003B09 RID: 15113
			// (get) Token: 0x0600BDFF RID: 48639 RVA: 0x002EAD34 File Offset: 0x002E8F34
			// (set) Token: 0x0600BE00 RID: 48640 RVA: 0x0005CF45 File Offset: 0x0005B145
			public unsafe static Texture CookieTextureDefault
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_CookieTextureDefault, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_CookieTextureDefault, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B0A RID: 15114
			// (get) Token: 0x0600BE01 RID: 48641 RVA: 0x002EAD5C File Offset: 0x002E8F5C
			// (set) Token: 0x0600BE02 RID: 48642 RVA: 0x0005CF57 File Offset: 0x0005B157
			public unsafe static CookieChannel ChannelDefault
			{
				get
				{
					CookieChannel result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_ChannelDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_ChannelDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B0B RID: 15115
			// (get) Token: 0x0600BE03 RID: 48643 RVA: 0x002EAD78 File Offset: 0x002E8F78
			// (set) Token: 0x0600BE04 RID: 48644 RVA: 0x0005CF65 File Offset: 0x0005B165
			public unsafe static bool NegativeDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_NegativeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_NegativeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B0C RID: 15116
			// (get) Token: 0x0600BE05 RID: 48645 RVA: 0x002EAD94 File Offset: 0x002E8F94
			// (set) Token: 0x0600BE06 RID: 48646 RVA: 0x0005CF73 File Offset: 0x0005B173
			public unsafe static Vector2 TranslationDefault
			{
				get
				{
					Vector2 result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_TranslationDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_TranslationDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B0D RID: 15117
			// (get) Token: 0x0600BE07 RID: 48647 RVA: 0x002EADB0 File Offset: 0x002E8FB0
			// (set) Token: 0x0600BE08 RID: 48648 RVA: 0x0005CF81 File Offset: 0x0005B181
			public unsafe static float RotationDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_RotationDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_RotationDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B0E RID: 15118
			// (get) Token: 0x0600BE09 RID: 48649 RVA: 0x002EADCC File Offset: 0x002E8FCC
			// (set) Token: 0x0600BE0A RID: 48650 RVA: 0x0005CF8F File Offset: 0x0005B18F
			public unsafe static Vector2 ScaleDefault
			{
				get
				{
					Vector2 result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_ScaleDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_ScaleDefault, (void*)(&value));
				}
			}

			// Token: 0x0400808E RID: 32910
			private static readonly IntPtr NativeFieldInfoPtr_ContributionDefault;

			// Token: 0x0400808F RID: 32911
			private static readonly IntPtr NativeFieldInfoPtr_ContributionMin;

			// Token: 0x04008090 RID: 32912
			private static readonly IntPtr NativeFieldInfoPtr_ContributionMax;

			// Token: 0x04008091 RID: 32913
			private static readonly IntPtr NativeFieldInfoPtr_CookieTextureDefault;

			// Token: 0x04008092 RID: 32914
			private static readonly IntPtr NativeFieldInfoPtr_ChannelDefault;

			// Token: 0x04008093 RID: 32915
			private static readonly IntPtr NativeFieldInfoPtr_NegativeDefault;

			// Token: 0x04008094 RID: 32916
			private static readonly IntPtr NativeFieldInfoPtr_TranslationDefault;

			// Token: 0x04008095 RID: 32917
			private static readonly IntPtr NativeFieldInfoPtr_RotationDefault;

			// Token: 0x04008096 RID: 32918
			private static readonly IntPtr NativeFieldInfoPtr_ScaleDefault;
		}

		// Token: 0x02000816 RID: 2070
		public static class Config : Il2CppSystem.Object
		{
			// Token: 0x0600BE0B RID: 48651 RVA: 0x002EADE8 File Offset: 0x002E8FE8
			// Note: this type is marked as 'beforefieldinit'.
			static Config()
			{
				Il2CppClassPointerStore<Consts.Config>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Config");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr);
				Consts.Config.NativeFieldInfoPtr_GeometryOverrideLayerDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "GeometryOverrideLayerDefault");
				Consts.Config.NativeFieldInfoPtr_GeometryLayerIDDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "GeometryLayerIDDefault");
				Consts.Config.NativeFieldInfoPtr_GeometryTagDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "GeometryTagDefault");
				Consts.Config.NativeFieldInfoPtr_FadeOutCameraTagDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "FadeOutCameraTagDefault");
				Consts.Config.NativeFieldInfoPtr_GeometryRenderQueueDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "GeometryRenderQueueDefault");
				Consts.Config.NativeFieldInfoPtr_GeometryRenderPipelineDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "GeometryRenderPipelineDefault");
				Consts.Config.NativeFieldInfoPtr_GeometryRenderingModeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "GeometryRenderingModeDefault");
				Consts.Config.NativeFieldInfoPtr_Noise3DSizeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "Noise3DSizeDefault");
				Consts.Config.NativeFieldInfoPtr_DitheringFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "DitheringFactor");
				Consts.Config.NativeFieldInfoPtr_UseLightColorTemperatureDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "UseLightColorTemperatureDefault");
				Consts.Config.NativeFieldInfoPtr_FeatureEnabledDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "FeatureEnabledDefault");
				Consts.Config.NativeFieldInfoPtr_FeatureEnabledColorGradientDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "FeatureEnabledColorGradientDefault");
				Consts.Config.NativeFieldInfoPtr_SharedMeshSidesDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "SharedMeshSidesDefault");
				Consts.Config.NativeFieldInfoPtr_SharedMeshSidesMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "SharedMeshSidesMin");
				Consts.Config.NativeFieldInfoPtr_SharedMeshSidesMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "SharedMeshSidesMax");
				Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "SharedMeshSegmentsDefault");
				Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "SharedMeshSegmentsMin");
				Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "SharedMeshSegmentsMax");
			}

			// Token: 0x0600BE0C RID: 48652 RVA: 0x0005CF9D File Offset: 0x0005B19D
			public Config(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B0F RID: 15119
			// (get) Token: 0x0600BE0D RID: 48653 RVA: 0x002EAF7C File Offset: 0x002E917C
			// (set) Token: 0x0600BE0E RID: 48654 RVA: 0x0005CFA6 File Offset: 0x0005B1A6
			public unsafe static bool GeometryOverrideLayerDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_GeometryOverrideLayerDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_GeometryOverrideLayerDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B10 RID: 15120
			// (get) Token: 0x0600BE0F RID: 48655 RVA: 0x002EAF98 File Offset: 0x002E9198
			// (set) Token: 0x0600BE10 RID: 48656 RVA: 0x0005CFB4 File Offset: 0x0005B1B4
			public unsafe static int GeometryLayerIDDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_GeometryLayerIDDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_GeometryLayerIDDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B11 RID: 15121
			// (get) Token: 0x0600BE11 RID: 48657 RVA: 0x002EAFB4 File Offset: 0x002E91B4
			// (set) Token: 0x0600BE12 RID: 48658 RVA: 0x0005CFC2 File Offset: 0x0005B1C2
			public unsafe static string GeometryTagDefault
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_GeometryTagDefault, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_GeometryTagDefault, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B12 RID: 15122
			// (get) Token: 0x0600BE13 RID: 48659 RVA: 0x002EAFD4 File Offset: 0x002E91D4
			// (set) Token: 0x0600BE14 RID: 48660 RVA: 0x0005CFD4 File Offset: 0x0005B1D4
			public unsafe static string FadeOutCameraTagDefault
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_FadeOutCameraTagDefault, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_FadeOutCameraTagDefault, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B13 RID: 15123
			// (get) Token: 0x0600BE15 RID: 48661 RVA: 0x002EAFF4 File Offset: 0x002E91F4
			// (set) Token: 0x0600BE16 RID: 48662 RVA: 0x0005CFE6 File Offset: 0x0005B1E6
			public unsafe static RenderQueue GeometryRenderQueueDefault
			{
				get
				{
					RenderQueue result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_GeometryRenderQueueDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_GeometryRenderQueueDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B14 RID: 15124
			// (get) Token: 0x0600BE17 RID: 48663 RVA: 0x002EB010 File Offset: 0x002E9210
			// (set) Token: 0x0600BE18 RID: 48664 RVA: 0x0005CFF4 File Offset: 0x0005B1F4
			public unsafe static RenderPipeline GeometryRenderPipelineDefault
			{
				get
				{
					RenderPipeline result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_GeometryRenderPipelineDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_GeometryRenderPipelineDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B15 RID: 15125
			// (get) Token: 0x0600BE19 RID: 48665 RVA: 0x002EB02C File Offset: 0x002E922C
			// (set) Token: 0x0600BE1A RID: 48666 RVA: 0x0005D002 File Offset: 0x0005B202
			public unsafe static RenderingMode GeometryRenderingModeDefault
			{
				get
				{
					RenderingMode result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_GeometryRenderingModeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_GeometryRenderingModeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B16 RID: 15126
			// (get) Token: 0x0600BE1B RID: 48667 RVA: 0x002EB048 File Offset: 0x002E9248
			// (set) Token: 0x0600BE1C RID: 48668 RVA: 0x0005D010 File Offset: 0x0005B210
			public unsafe static int Noise3DSizeDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_Noise3DSizeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_Noise3DSizeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B17 RID: 15127
			// (get) Token: 0x0600BE1D RID: 48669 RVA: 0x002EB064 File Offset: 0x002E9264
			// (set) Token: 0x0600BE1E RID: 48670 RVA: 0x0005D01E File Offset: 0x0005B21E
			public unsafe static float DitheringFactor
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_DitheringFactor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_DitheringFactor, (void*)(&value));
				}
			}

			// Token: 0x17003B18 RID: 15128
			// (get) Token: 0x0600BE1F RID: 48671 RVA: 0x002EB080 File Offset: 0x002E9280
			// (set) Token: 0x0600BE20 RID: 48672 RVA: 0x0005D02C File Offset: 0x0005B22C
			public unsafe static bool UseLightColorTemperatureDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_UseLightColorTemperatureDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_UseLightColorTemperatureDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B19 RID: 15129
			// (get) Token: 0x0600BE21 RID: 48673 RVA: 0x002EB09C File Offset: 0x002E929C
			// (set) Token: 0x0600BE22 RID: 48674 RVA: 0x0005D03A File Offset: 0x0005B23A
			public unsafe static bool FeatureEnabledDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_FeatureEnabledDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_FeatureEnabledDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B1A RID: 15130
			// (get) Token: 0x0600BE23 RID: 48675 RVA: 0x002EB0B8 File Offset: 0x002E92B8
			// (set) Token: 0x0600BE24 RID: 48676 RVA: 0x0005D048 File Offset: 0x0005B248
			public unsafe static FeatureEnabledColorGradient FeatureEnabledColorGradientDefault
			{
				get
				{
					FeatureEnabledColorGradient result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_FeatureEnabledColorGradientDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_FeatureEnabledColorGradientDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B1B RID: 15131
			// (get) Token: 0x0600BE25 RID: 48677 RVA: 0x002EB0D4 File Offset: 0x002E92D4
			// (set) Token: 0x0600BE26 RID: 48678 RVA: 0x0005D056 File Offset: 0x0005B256
			public unsafe static int SharedMeshSidesDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSidesDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSidesDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B1C RID: 15132
			// (get) Token: 0x0600BE27 RID: 48679 RVA: 0x002EB0F0 File Offset: 0x002E92F0
			// (set) Token: 0x0600BE28 RID: 48680 RVA: 0x0005D064 File Offset: 0x0005B264
			public unsafe static int SharedMeshSidesMin
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSidesMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSidesMin, (void*)(&value));
				}
			}

			// Token: 0x17003B1D RID: 15133
			// (get) Token: 0x0600BE29 RID: 48681 RVA: 0x002EB10C File Offset: 0x002E930C
			// (set) Token: 0x0600BE2A RID: 48682 RVA: 0x0005D072 File Offset: 0x0005B272
			public unsafe static int SharedMeshSidesMax
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSidesMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSidesMax, (void*)(&value));
				}
			}

			// Token: 0x17003B1E RID: 15134
			// (get) Token: 0x0600BE2B RID: 48683 RVA: 0x002EB128 File Offset: 0x002E9328
			// (set) Token: 0x0600BE2C RID: 48684 RVA: 0x0005D080 File Offset: 0x0005B280
			public unsafe static int SharedMeshSegmentsDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B1F RID: 15135
			// (get) Token: 0x0600BE2D RID: 48685 RVA: 0x002EB144 File Offset: 0x002E9344
			// (set) Token: 0x0600BE2E RID: 48686 RVA: 0x0005D08E File Offset: 0x0005B28E
			public unsafe static int SharedMeshSegmentsMin
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsMin, (void*)(&value));
				}
			}

			// Token: 0x17003B20 RID: 15136
			// (get) Token: 0x0600BE2F RID: 48687 RVA: 0x002EB160 File Offset: 0x002E9360
			// (set) Token: 0x0600BE30 RID: 48688 RVA: 0x0005D09C File Offset: 0x0005B29C
			public unsafe static int SharedMeshSegmentsMax
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsMax, (void*)(&value));
				}
			}

			// Token: 0x04008097 RID: 32919
			private static readonly IntPtr NativeFieldInfoPtr_GeometryOverrideLayerDefault;

			// Token: 0x04008098 RID: 32920
			private static readonly IntPtr NativeFieldInfoPtr_GeometryLayerIDDefault;

			// Token: 0x04008099 RID: 32921
			private static readonly IntPtr NativeFieldInfoPtr_GeometryTagDefault;

			// Token: 0x0400809A RID: 32922
			private static readonly IntPtr NativeFieldInfoPtr_FadeOutCameraTagDefault;

			// Token: 0x0400809B RID: 32923
			private static readonly IntPtr NativeFieldInfoPtr_GeometryRenderQueueDefault;

			// Token: 0x0400809C RID: 32924
			private static readonly IntPtr NativeFieldInfoPtr_GeometryRenderPipelineDefault;

			// Token: 0x0400809D RID: 32925
			private static readonly IntPtr NativeFieldInfoPtr_GeometryRenderingModeDefault;

			// Token: 0x0400809E RID: 32926
			private static readonly IntPtr NativeFieldInfoPtr_Noise3DSizeDefault;

			// Token: 0x0400809F RID: 32927
			private static readonly IntPtr NativeFieldInfoPtr_DitheringFactor;

			// Token: 0x040080A0 RID: 32928
			private static readonly IntPtr NativeFieldInfoPtr_UseLightColorTemperatureDefault;

			// Token: 0x040080A1 RID: 32929
			private static readonly IntPtr NativeFieldInfoPtr_FeatureEnabledDefault;

			// Token: 0x040080A2 RID: 32930
			private static readonly IntPtr NativeFieldInfoPtr_FeatureEnabledColorGradientDefault;

			// Token: 0x040080A3 RID: 32931
			private static readonly IntPtr NativeFieldInfoPtr_SharedMeshSidesDefault;

			// Token: 0x040080A4 RID: 32932
			private static readonly IntPtr NativeFieldInfoPtr_SharedMeshSidesMin;

			// Token: 0x040080A5 RID: 32933
			private static readonly IntPtr NativeFieldInfoPtr_SharedMeshSidesMax;

			// Token: 0x040080A6 RID: 32934
			private static readonly IntPtr NativeFieldInfoPtr_SharedMeshSegmentsDefault;

			// Token: 0x040080A7 RID: 32935
			private static readonly IntPtr NativeFieldInfoPtr_SharedMeshSegmentsMin;

			// Token: 0x040080A8 RID: 32936
			private static readonly IntPtr NativeFieldInfoPtr_SharedMeshSegmentsMax;

			// Token: 0x02000C23 RID: 3107
			public static class HD : Il2CppSystem.Object
			{
				// Token: 0x0600E105 RID: 57605 RVA: 0x0034EA80 File Offset: 0x0034CC80
				// Note: this type is marked as 'beforefieldinit'.
				static HD()
				{
					Il2CppClassPointerStore<Consts.Config.HD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "HD");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Config.HD>.NativeClassPtr);
					Consts.Config.HD.NativeFieldInfoPtr_GeometryRenderQueueDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config.HD>.NativeClassPtr, "GeometryRenderQueueDefault");
					Consts.Config.HD.NativeFieldInfoPtr_CameraBlendingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config.HD>.NativeClassPtr, "CameraBlendingDistance");
					Consts.Config.HD.NativeFieldInfoPtr_RaymarchingQualitiesStepsMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config.HD>.NativeClassPtr, "RaymarchingQualitiesStepsMin");
				}

				// Token: 0x0600E106 RID: 57606 RVA: 0x0006DB4D File Offset: 0x0006BD4D
				public HD(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045B5 RID: 17845
				// (get) Token: 0x0600E107 RID: 57607 RVA: 0x0034EAE8 File Offset: 0x0034CCE8
				// (set) Token: 0x0600E108 RID: 57608 RVA: 0x0006DB56 File Offset: 0x0006BD56
				public unsafe static RenderQueue GeometryRenderQueueDefault
				{
					get
					{
						RenderQueue result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Config.HD.NativeFieldInfoPtr_GeometryRenderQueueDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Config.HD.NativeFieldInfoPtr_GeometryRenderQueueDefault, (void*)(&value));
					}
				}

				// Token: 0x170045B6 RID: 17846
				// (get) Token: 0x0600E109 RID: 57609 RVA: 0x0034EB04 File Offset: 0x0034CD04
				// (set) Token: 0x0600E10A RID: 57610 RVA: 0x0006DB64 File Offset: 0x0006BD64
				public unsafe static float CameraBlendingDistance
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Config.HD.NativeFieldInfoPtr_CameraBlendingDistance, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Config.HD.NativeFieldInfoPtr_CameraBlendingDistance, (void*)(&value));
					}
				}

				// Token: 0x170045B7 RID: 17847
				// (get) Token: 0x0600E10B RID: 57611 RVA: 0x0034EB20 File Offset: 0x0034CD20
				// (set) Token: 0x0600E10C RID: 57612 RVA: 0x0006DB72 File Offset: 0x0006BD72
				public unsafe static int RaymarchingQualitiesStepsMin
				{
					get
					{
						int result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Config.HD.NativeFieldInfoPtr_RaymarchingQualitiesStepsMin, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Config.HD.NativeFieldInfoPtr_RaymarchingQualitiesStepsMin, (void*)(&value));
					}
				}

				// Token: 0x04009697 RID: 38551
				private static readonly IntPtr NativeFieldInfoPtr_GeometryRenderQueueDefault;

				// Token: 0x04009698 RID: 38552
				private static readonly IntPtr NativeFieldInfoPtr_CameraBlendingDistance;

				// Token: 0x04009699 RID: 38553
				private static readonly IntPtr NativeFieldInfoPtr_RaymarchingQualitiesStepsMin;
			}
		}
	}
}
