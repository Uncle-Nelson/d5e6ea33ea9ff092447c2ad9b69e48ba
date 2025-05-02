using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000470 RID: 1136
	[Serializable]
	public class AudioSettings : Object
	{
		// Token: 0x06006251 RID: 25169 RVA: 0x001BF4DC File Offset: 0x001BD6DC
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSettings()
		{
			Il2CppClassPointerStore<AudioSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AudioSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr);
			AudioSettings.NativeFieldInfoPtr_MasterVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "MasterVolume");
			AudioSettings.NativeFieldInfoPtr_AmbientVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "AmbientVolume");
			AudioSettings.NativeFieldInfoPtr_MusicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "MusicVolume");
			AudioSettings.NativeFieldInfoPtr_SFXVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "SFXVolume");
			AudioSettings.NativeFieldInfoPtr_UIVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "UIVolume");
			AudioSettings.NativeFieldInfoPtr_DialogueVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "DialogueVolume");
			AudioSettings.NativeFieldInfoPtr_FootstepsVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "FootstepsVolume");
			AudioSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100675771);
		}

		// Token: 0x06006252 RID: 25170 RVA: 0x001BF5AC File Offset: 0x001BD7AC
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006253 RID: 25171 RVA: 0x0002E76B File Offset: 0x0002C96B
		public AudioSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x06006254 RID: 25172 RVA: 0x001BF5E8 File Offset: 0x001BD7E8
		// (set) Token: 0x06006255 RID: 25173 RVA: 0x0002E774 File Offset: 0x0002C974
		public unsafe float MasterVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_MasterVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_MasterVolume)) = value;
			}
		}

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x06006256 RID: 25174 RVA: 0x001BF610 File Offset: 0x001BD810
		// (set) Token: 0x06006257 RID: 25175 RVA: 0x0002E78F File Offset: 0x0002C98F
		public unsafe float AmbientVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_AmbientVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_AmbientVolume)) = value;
			}
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x06006258 RID: 25176 RVA: 0x001BF638 File Offset: 0x001BD838
		// (set) Token: 0x06006259 RID: 25177 RVA: 0x0002E7AA File Offset: 0x0002C9AA
		public unsafe float MusicVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_MusicVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_MusicVolume)) = value;
			}
		}

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x0600625A RID: 25178 RVA: 0x001BF660 File Offset: 0x001BD860
		// (set) Token: 0x0600625B RID: 25179 RVA: 0x0002E7C5 File Offset: 0x0002C9C5
		public unsafe float SFXVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_SFXVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_SFXVolume)) = value;
			}
		}

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x0600625C RID: 25180 RVA: 0x001BF688 File Offset: 0x001BD888
		// (set) Token: 0x0600625D RID: 25181 RVA: 0x0002E7E0 File Offset: 0x0002C9E0
		public unsafe float UIVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_UIVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_UIVolume)) = value;
			}
		}

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x0600625E RID: 25182 RVA: 0x001BF6B0 File Offset: 0x001BD8B0
		// (set) Token: 0x0600625F RID: 25183 RVA: 0x0002E7FB File Offset: 0x0002C9FB
		public unsafe float DialogueVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_DialogueVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_DialogueVolume)) = value;
			}
		}

		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x06006260 RID: 25184 RVA: 0x001BF6D8 File Offset: 0x001BD8D8
		// (set) Token: 0x06006261 RID: 25185 RVA: 0x0002E816 File Offset: 0x0002CA16
		public unsafe float FootstepsVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_FootstepsVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_FootstepsVolume)) = value;
			}
		}

		// Token: 0x04004307 RID: 17159
		private static readonly IntPtr NativeFieldInfoPtr_MasterVolume;

		// Token: 0x04004308 RID: 17160
		private static readonly IntPtr NativeFieldInfoPtr_AmbientVolume;

		// Token: 0x04004309 RID: 17161
		private static readonly IntPtr NativeFieldInfoPtr_MusicVolume;

		// Token: 0x0400430A RID: 17162
		private static readonly IntPtr NativeFieldInfoPtr_SFXVolume;

		// Token: 0x0400430B RID: 17163
		private static readonly IntPtr NativeFieldInfoPtr_UIVolume;

		// Token: 0x0400430C RID: 17164
		private static readonly IntPtr NativeFieldInfoPtr_DialogueVolume;

		// Token: 0x0400430D RID: 17165
		private static readonly IntPtr NativeFieldInfoPtr_FootstepsVolume;

		// Token: 0x0400430E RID: 17166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
