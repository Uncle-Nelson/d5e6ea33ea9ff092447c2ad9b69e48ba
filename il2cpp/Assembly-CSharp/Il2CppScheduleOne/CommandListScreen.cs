using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.MainMenu;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x0200016C RID: 364
	public class CommandListScreen : MainMenuScreen
	{
		// Token: 0x06001D7B RID: 7547 RVA: 0x000CC258 File Offset: 0x000CA458
		// Note: this type is marked as 'beforefieldinit'.
		static CommandListScreen()
		{
			Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "CommandListScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr);
			CommandListScreen.NativeFieldInfoPtr_CommandEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, "CommandEntryContainer");
			CommandListScreen.NativeFieldInfoPtr_CommandEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, "CommandEntryPrefab");
			CommandListScreen.NativeFieldInfoPtr_commandEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, "commandEntries");
			CommandListScreen.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, 100666649);
			CommandListScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr, 100666650);
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x000CC2EC File Offset: 0x000CA4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106121, XrefRangeEnd = 106171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandListScreen.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x000CC320 File Offset: 0x000CA520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106171, XrefRangeEnd = 106179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommandListScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandListScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandListScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x00010AA4 File Offset: 0x0000ECA4
		public CommandListScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x000CC35C File Offset: 0x000CA55C
		// (set) Token: 0x06001D80 RID: 7552 RVA: 0x00010AAD File Offset: 0x0000ECAD
		public unsafe RectTransform CommandEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_CommandEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_CommandEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x000CC38C File Offset: 0x000CA58C
		// (set) Token: 0x06001D82 RID: 7554 RVA: 0x00010ACC File Offset: 0x0000ECCC
		public unsafe RectTransform CommandEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_CommandEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_CommandEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x000CC3BC File Offset: 0x000CA5BC
		// (set) Token: 0x06001D84 RID: 7556 RVA: 0x00010AEB File Offset: 0x0000ECEB
		public unsafe List<RectTransform> commandEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_commandEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandListScreen.NativeFieldInfoPtr_commandEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeFieldInfoPtr_CommandEntryContainer;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeFieldInfoPtr_CommandEntryPrefab;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeFieldInfoPtr_commandEntries;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
