using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x0200068A RID: 1674
	public class GameSettingsWindow : MonoBehaviour
	{
		// Token: 0x060095CD RID: 38349 RVA: 0x002665F4 File Offset: 0x002647F4
		// Note: this type is marked as 'beforefieldinit'.
		static GameSettingsWindow()
		{
			Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "GameSettingsWindow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr);
			GameSettingsWindow.NativeFieldInfoPtr_ConsoleToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, "ConsoleToggle");
			GameSettingsWindow.NativeFieldInfoPtr_Blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, "Blocker");
			GameSettingsWindow.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100681809);
			GameSettingsWindow.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100681810);
			GameSettingsWindow.NativeMethodInfoPtr_ApplySettings_Public_Void_GameSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100681811);
			GameSettingsWindow.NativeMethodInfoPtr_ConsoleToggled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100681812);
			GameSettingsWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100681813);
		}

		// Token: 0x060095CE RID: 38350 RVA: 0x002666B0 File Offset: 0x002648B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269210, XrefRangeEnd = 269220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095CF RID: 38351 RVA: 0x002666E4 File Offset: 0x002648E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269220, XrefRangeEnd = 269228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095D0 RID: 38352 RVA: 0x00266718 File Offset: 0x00264918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269228, XrefRangeEnd = 269230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySettings(GameSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr_ApplySettings_Public_Void_GameSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095D1 RID: 38353 RVA: 0x0026675C File Offset: 0x0026495C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269230, XrefRangeEnd = 269234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsoleToggled(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr_ConsoleToggled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095D2 RID: 38354 RVA: 0x0026679C File Offset: 0x0026499C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSettingsWindow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095D3 RID: 38355 RVA: 0x00048CF7 File Offset: 0x00046EF7
		public GameSettingsWindow(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E00 RID: 11776
		// (get) Token: 0x060095D4 RID: 38356 RVA: 0x002667D8 File Offset: 0x002649D8
		// (set) Token: 0x060095D5 RID: 38357 RVA: 0x00048D00 File Offset: 0x00046F00
		public unsafe Toggle ConsoleToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_ConsoleToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_ConsoleToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E01 RID: 11777
		// (get) Token: 0x060095D6 RID: 38358 RVA: 0x00266808 File Offset: 0x00264A08
		// (set) Token: 0x060095D7 RID: 38359 RVA: 0x00048D1F File Offset: 0x00046F1F
		public unsafe GameObject Blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_Blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_Blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006502 RID: 25858
		private static readonly IntPtr NativeFieldInfoPtr_ConsoleToggle;

		// Token: 0x04006503 RID: 25859
		private static readonly IntPtr NativeFieldInfoPtr_Blocker;

		// Token: 0x04006504 RID: 25860
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006505 RID: 25861
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04006506 RID: 25862
		private static readonly IntPtr NativeMethodInfoPtr_ApplySettings_Public_Void_GameSettings_0;

		// Token: 0x04006507 RID: 25863
		private static readonly IntPtr NativeMethodInfoPtr_ConsoleToggled_Private_Void_Boolean_0;

		// Token: 0x04006508 RID: 25864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
