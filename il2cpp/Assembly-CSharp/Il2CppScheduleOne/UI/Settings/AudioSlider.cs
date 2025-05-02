using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Audio;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000685 RID: 1669
	public class AudioSlider : SettingsSlider
	{
		// Token: 0x0600959F RID: 38303 RVA: 0x00265CA8 File Offset: 0x00263EA8
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSlider()
		{
			Il2CppClassPointerStore<AudioSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "AudioSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr);
			AudioSlider.NativeFieldInfoPtr_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, "MULTIPLIER");
			AudioSlider.NativeFieldInfoPtr_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, "Master");
			AudioSlider.NativeFieldInfoPtr_AudioType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, "AudioType");
			AudioSlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, 100681789);
			AudioSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, 100681790);
			AudioSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, 100681791);
		}

		// Token: 0x060095A0 RID: 38304 RVA: 0x00265D50 File Offset: 0x00263F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268999, XrefRangeEnd = 269008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioSlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095A1 RID: 38305 RVA: 0x00265D8C File Offset: 0x00263F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269008, XrefRangeEnd = 269044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095A2 RID: 38306 RVA: 0x00265DD8 File Offset: 0x00263FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269044, XrefRangeEnd = 269045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095A3 RID: 38307 RVA: 0x00048C08 File Offset: 0x00046E08
		public AudioSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DF7 RID: 11767
		// (get) Token: 0x060095A4 RID: 38308 RVA: 0x00265E14 File Offset: 0x00264014
		// (set) Token: 0x060095A5 RID: 38309 RVA: 0x00048C11 File Offset: 0x00046E11
		public unsafe static float MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioSlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioSlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002DF8 RID: 11768
		// (get) Token: 0x060095A6 RID: 38310 RVA: 0x00265E30 File Offset: 0x00264030
		// (set) Token: 0x060095A7 RID: 38311 RVA: 0x00048C1F File Offset: 0x00046E1F
		public unsafe bool Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSlider.NativeFieldInfoPtr_Master);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSlider.NativeFieldInfoPtr_Master)) = value;
			}
		}

		// Token: 0x17002DF9 RID: 11769
		// (get) Token: 0x060095A8 RID: 38312 RVA: 0x00265E58 File Offset: 0x00264058
		// (set) Token: 0x060095A9 RID: 38313 RVA: 0x00048C3A File Offset: 0x00046E3A
		public unsafe EAudioType AudioType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSlider.NativeFieldInfoPtr_AudioType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSlider.NativeFieldInfoPtr_AudioType)) = value;
			}
		}

		// Token: 0x040064E6 RID: 25830
		private static readonly IntPtr NativeFieldInfoPtr_MULTIPLIER;

		// Token: 0x040064E7 RID: 25831
		private static readonly IntPtr NativeFieldInfoPtr_Master;

		// Token: 0x040064E8 RID: 25832
		private static readonly IntPtr NativeFieldInfoPtr_AudioType;

		// Token: 0x040064E9 RID: 25833
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040064EA RID: 25834
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0;

		// Token: 0x040064EB RID: 25835
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
