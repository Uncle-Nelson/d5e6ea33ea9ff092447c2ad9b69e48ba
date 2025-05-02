using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x02000166 RID: 358
	public class Console : Singleton<Console>
	{
		// Token: 0x06001CE6 RID: 7398 RVA: 0x000CA170 File Offset: 0x000C8370
		// Note: this type is marked as 'beforefieldinit'.
		static Console()
		{
			Il2CppClassPointerStore<Console>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "Console");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console>.NativeClassPtr);
			Console.NativeFieldInfoPtr_TeleportPointsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "TeleportPointsContainer");
			Console.NativeFieldInfoPtr_LabelledGameObjectList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "LabelledGameObjectList");
			Console.NativeFieldInfoPtr_startupCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "startupCommands");
			Console.NativeFieldInfoPtr_Commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "Commands");
			Console.NativeFieldInfoPtr_commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "commands");
			Console.NativeFieldInfoPtr_keyBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "keyBindings");
			Console.NativeMethodInfoPtr_get_player_Private_Static_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666319);
			Console.NativeMethodInfoPtr_LogCommandError_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666320);
			Console.NativeMethodInfoPtr_LogUnrecognizedFormat_Private_Static_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666321);
			Console.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666322);
			Console.NativeMethodInfoPtr_RunStartupCommands_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666323);
			Console.NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666324);
			Console.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666325);
			Console.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666326);
			Console.NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666327);
			Console.NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666328);
			Console.NativeMethodInfoPtr_AddBinding_Public_Void_KeyCode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666329);
			Console.NativeMethodInfoPtr_RemoveBinding_Public_Void_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666330);
			Console.NativeMethodInfoPtr_ClearBindings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666331);
			Console.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666332);
			Console.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666333);
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x000CA344 File Offset: 0x000C8544
		public unsafe static Player player
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102763, XrefRangeEnd = 102767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_get_player_Private_Static_get_Player_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x000CA378 File Offset: 0x000C8578
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 102774, RefRangeEnd = 102779, XrefRangeStart = 102767, XrefRangeEnd = 102774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogCommandError(string error)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_LogCommandError_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x000CA3B0 File Offset: 0x000C85B0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 102800, RefRangeEnd = 102811, XrefRangeStart = 102779, XrefRangeEnd = 102800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogUnrecognizedFormat(Il2CppStringArray correctExamples)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(correctExamples);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_LogUnrecognizedFormat_Private_Static_Void_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x000CA3E8 File Offset: 0x000C85E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102811, XrefRangeEnd = 103267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x000CA424 File Offset: 0x000C8624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103267, XrefRangeEnd = 103293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunStartupCommands()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_RunStartupCommands_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x000CA458 File Offset: 0x000C8658
		[CallerCount(305)]
		[CachedScanResults(RefRangeStart = 103297, RefRangeEnd = 103602, XrefRangeStart = 103293, XrefRangeEnd = 103297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(Il2CppSystem.Object message, UnityEngine.Object context = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x000CA4A0 File Offset: 0x000C86A0
		[CallerCount(279)]
		[CachedScanResults(RefRangeStart = 103606, RefRangeEnd = 103885, XrefRangeStart = 103602, XrefRangeEnd = 103606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(Il2CppSystem.Object message, UnityEngine.Object context = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x000CA4E8 File Offset: 0x000C86E8
		[CallerCount(203)]
		[CachedScanResults(RefRangeStart = 103889, RefRangeEnd = 104092, XrefRangeStart = 103885, XrefRangeEnd = 103889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(Il2CppSystem.Object message, UnityEngine.Object context = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x000CA530 File Offset: 0x000C8730
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104130, RefRangeEnd = 104131, XrefRangeStart = 104092, XrefRangeEnd = 104130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SubmitCommand(List<string> args)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_List_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x000CA568 File Offset: 0x000C8768
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 104147, RefRangeEnd = 104150, XrefRangeStart = 104131, XrefRangeEnd = 104147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SubmitCommand(string args)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x000CA5A0 File Offset: 0x000C87A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104150, XrefRangeEnd = 104172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBinding(KeyCode key, string command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(command);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_AddBinding_Public_Void_KeyCode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x000CA5F0 File Offset: 0x000C87F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104172, XrefRangeEnd = 104188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveBinding(KeyCode key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_RemoveBinding_Public_Void_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x000CA630 File Offset: 0x000C8830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104188, XrefRangeEnd = 104201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearBindings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_ClearBindings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x000CA664 File Offset: 0x000C8864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104201, XrefRangeEnd = 104230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x000CA698 File Offset: 0x000C8898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104230, XrefRangeEnd = 104247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Console() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x000107CA File Offset: 0x0000E9CA
		public Console(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x000CA6D4 File Offset: 0x000C88D4
		// (set) Token: 0x06001CF8 RID: 7416 RVA: 0x000107D3 File Offset: 0x0000E9D3
		public unsafe Transform TeleportPointsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_TeleportPointsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_TeleportPointsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x000CA704 File Offset: 0x000C8904
		// (set) Token: 0x06001CFA RID: 7418 RVA: 0x000107F2 File Offset: 0x0000E9F2
		public unsafe List<Console.LabelledGameObject> LabelledGameObjectList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_LabelledGameObjectList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Console.LabelledGameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_LabelledGameObjectList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x000CA734 File Offset: 0x000C8934
		// (set) Token: 0x06001CFC RID: 7420 RVA: 0x00010811 File Offset: 0x0000EA11
		public unsafe List<string> startupCommands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_startupCommands);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_startupCommands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x000CA764 File Offset: 0x000C8964
		// (set) Token: 0x06001CFE RID: 7422 RVA: 0x00010830 File Offset: 0x0000EA30
		public unsafe static List<Console.ConsoleCommand> Commands
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_Commands, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Console.ConsoleCommand>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_Commands, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x000CA78C File Offset: 0x000C898C
		// (set) Token: 0x06001D00 RID: 7424 RVA: 0x00010842 File Offset: 0x0000EA42
		public unsafe static Dictionary<string, Console.ConsoleCommand> commands
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_commands, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Console.ConsoleCommand>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_commands, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x000CA7B4 File Offset: 0x000C89B4
		// (set) Token: 0x06001D02 RID: 7426 RVA: 0x00010854 File Offset: 0x0000EA54
		public unsafe Dictionary<KeyCode, string> keyBindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_keyBindings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<KeyCode, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_keyBindings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeFieldInfoPtr_TeleportPointsContainer;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeFieldInfoPtr_LabelledGameObjectList;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeFieldInfoPtr_startupCommands;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeFieldInfoPtr_Commands;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeFieldInfoPtr_commands;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeFieldInfoPtr_keyBindings;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeMethodInfoPtr_get_player_Private_Static_get_Player_0;

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeMethodInfoPtr_LogCommandError_Private_Static_Void_String_0;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeMethodInfoPtr_LogUnrecognizedFormat_Private_Static_Void_Il2CppStringArray_0;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeMethodInfoPtr_RunStartupCommands_Private_Void_0;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_List_1_String_0;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_String_0;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeMethodInfoPtr_AddBinding_Public_Void_KeyCode_String_0;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeMethodInfoPtr_RemoveBinding_Public_Void_KeyCode_0;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeMethodInfoPtr_ClearBindings_Public_Void_0;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000870 RID: 2160
		public class ConsoleCommand : Il2CppSystem.Object
		{
			// Token: 0x0600C16E RID: 49518 RVA: 0x002F3624 File Offset: 0x002F1824
			// Note: this type is marked as 'beforefieldinit'.
			static ConsoleCommand()
			{
				Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ConsoleCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr);
				Console.ConsoleCommand.NativeMethodInfoPtr_get_CommandWord_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100666335);
				Console.ConsoleCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100666336);
				Console.ConsoleCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100666337);
				Console.ConsoleCommand.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100666338);
				Console.ConsoleCommand.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100666339);
			}

			// Token: 0x17003C46 RID: 15430
			// (get) Token: 0x0600C16F RID: 49519 RVA: 0x002F36B4 File Offset: 0x002F18B4
			public unsafe virtual string CommandWord
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ConsoleCommand.NativeMethodInfoPtr_get_CommandWord_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C47 RID: 15431
			// (get) Token: 0x0600C170 RID: 49520 RVA: 0x002F36F8 File Offset: 0x002F18F8
			public unsafe virtual string CommandDescription
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ConsoleCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C48 RID: 15432
			// (get) Token: 0x0600C171 RID: 49521 RVA: 0x002F373C File Offset: 0x002F193C
			public unsafe virtual string ExampleUsage
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ConsoleCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C172 RID: 49522 RVA: 0x002F3780 File Offset: 0x002F1980
			[CallerCount(0)]
			public unsafe virtual void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ConsoleCommand.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C173 RID: 49523 RVA: 0x002F37D0 File Offset: 0x002F19D0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConsoleCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ConsoleCommand.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C174 RID: 49524 RVA: 0x0005E9BC File Offset: 0x0005CBBC
			public ConsoleCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040082F6 RID: 33526
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Abstract_Virtual_New_get_String_0;

			// Token: 0x040082F7 RID: 33527
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Abstract_Virtual_New_get_String_0;

			// Token: 0x040082F8 RID: 33528
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Abstract_Virtual_New_get_String_0;

			// Token: 0x040082F9 RID: 33529
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_List_1_String_0;

			// Token: 0x040082FA RID: 33530
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
		}

		// Token: 0x02000871 RID: 2161
		public class SetTimeCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C175 RID: 49525 RVA: 0x002F380C File Offset: 0x002F1A0C
			// Note: this type is marked as 'beforefieldinit'.
			static SetTimeCommand()
			{
				Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetTimeCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr);
				Console.SetTimeCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100666340);
				Console.SetTimeCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100666341);
				Console.SetTimeCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100666342);
				Console.SetTimeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100666343);
				Console.SetTimeCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100666344);
			}

			// Token: 0x17003C49 RID: 15433
			// (get) Token: 0x0600C176 RID: 49526 RVA: 0x002F389C File Offset: 0x002F1A9C
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101417, XrefRangeEnd = 101419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C4A RID: 15434
			// (get) Token: 0x0600C177 RID: 49527 RVA: 0x002F38E0 File Offset: 0x002F1AE0
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101419, XrefRangeEnd = 101421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C4B RID: 15435
			// (get) Token: 0x0600C178 RID: 49528 RVA: 0x002F3924 File Offset: 0x002F1B24
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101421, XrefRangeEnd = 101423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C179 RID: 49529 RVA: 0x002F3968 File Offset: 0x002F1B68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101423, XrefRangeEnd = 101463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C17A RID: 49530 RVA: 0x002F39B8 File Offset: 0x002F1BB8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetTimeCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetTimeCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C17B RID: 49531 RVA: 0x0005E9C5 File Offset: 0x0005CBC5
			public SetTimeCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040082FB RID: 33531
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040082FC RID: 33532
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040082FD RID: 33533
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040082FE RID: 33534
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040082FF RID: 33535
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000872 RID: 2162
		public class SpawnVehicleCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C17C RID: 49532 RVA: 0x002F39F4 File Offset: 0x002F1BF4
			// Note: this type is marked as 'beforefieldinit'.
			static SpawnVehicleCommand()
			{
				Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SpawnVehicleCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100666345);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100666346);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100666347);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100666348);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100666349);
			}

			// Token: 0x17003C4C RID: 15436
			// (get) Token: 0x0600C17D RID: 49533 RVA: 0x002F3A84 File Offset: 0x002F1C84
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101463, XrefRangeEnd = 101465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C4D RID: 15437
			// (get) Token: 0x0600C17E RID: 49534 RVA: 0x002F3AC8 File Offset: 0x002F1CC8
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101465, XrefRangeEnd = 101467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C4E RID: 15438
			// (get) Token: 0x0600C17F RID: 49535 RVA: 0x002F3B0C File Offset: 0x002F1D0C
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101467, XrefRangeEnd = 101469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C180 RID: 49536 RVA: 0x002F3B50 File Offset: 0x002F1D50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101469, XrefRangeEnd = 101526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SpawnVehicleCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C181 RID: 49537 RVA: 0x002F3BA0 File Offset: 0x002F1DA0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpawnVehicleCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SpawnVehicleCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C182 RID: 49538 RVA: 0x0005E9CE File Offset: 0x0005CBCE
			public SpawnVehicleCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008300 RID: 33536
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008301 RID: 33537
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008302 RID: 33538
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008303 RID: 33539
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008304 RID: 33540
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000873 RID: 2163
		public class AddItemToInventoryCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C183 RID: 49539 RVA: 0x002F3BDC File Offset: 0x002F1DDC
			// Note: this type is marked as 'beforefieldinit'.
			static AddItemToInventoryCommand()
			{
				Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "AddItemToInventoryCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100666350);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100666351);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100666352);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100666353);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100666354);
			}

			// Token: 0x17003C4F RID: 15439
			// (get) Token: 0x0600C184 RID: 49540 RVA: 0x002F3C6C File Offset: 0x002F1E6C
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101526, XrefRangeEnd = 101528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C50 RID: 15440
			// (get) Token: 0x0600C185 RID: 49541 RVA: 0x002F3CB0 File Offset: 0x002F1EB0
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101528, XrefRangeEnd = 101530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C51 RID: 15441
			// (get) Token: 0x0600C186 RID: 49542 RVA: 0x002F3CF4 File Offset: 0x002F1EF4
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101530, XrefRangeEnd = 101532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C187 RID: 49543 RVA: 0x002F3D38 File Offset: 0x002F1F38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101532, XrefRangeEnd = 101569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddItemToInventoryCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C188 RID: 49544 RVA: 0x002F3D88 File Offset: 0x002F1F88
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddItemToInventoryCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.AddItemToInventoryCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C189 RID: 49545 RVA: 0x0005E9D7 File Offset: 0x0005CBD7
			public AddItemToInventoryCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008305 RID: 33541
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008306 RID: 33542
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008307 RID: 33543
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008308 RID: 33544
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008309 RID: 33545
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000874 RID: 2164
		public class ClearInventoryCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C18A RID: 49546 RVA: 0x002F3DC4 File Offset: 0x002F1FC4
			// Note: this type is marked as 'beforefieldinit'.
			static ClearInventoryCommand()
			{
				Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ClearInventoryCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr);
				Console.ClearInventoryCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100666355);
				Console.ClearInventoryCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100666356);
				Console.ClearInventoryCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100666357);
				Console.ClearInventoryCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100666358);
				Console.ClearInventoryCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100666359);
			}

			// Token: 0x17003C52 RID: 15442
			// (get) Token: 0x0600C18B RID: 49547 RVA: 0x002F3E54 File Offset: 0x002F2054
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101569, XrefRangeEnd = 101571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearInventoryCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C53 RID: 15443
			// (get) Token: 0x0600C18C RID: 49548 RVA: 0x002F3E98 File Offset: 0x002F2098
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101571, XrefRangeEnd = 101573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearInventoryCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C54 RID: 15444
			// (get) Token: 0x0600C18D RID: 49549 RVA: 0x002F3EDC File Offset: 0x002F20DC
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101573, XrefRangeEnd = 101575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearInventoryCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C18E RID: 49550 RVA: 0x002F3F20 File Offset: 0x002F2120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101575, XrefRangeEnd = 101590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearInventoryCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C18F RID: 49551 RVA: 0x002F3F70 File Offset: 0x002F2170
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClearInventoryCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ClearInventoryCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C190 RID: 49552 RVA: 0x0005E9E0 File Offset: 0x0005CBE0
			public ClearInventoryCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400830A RID: 33546
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400830B RID: 33547
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400830C RID: 33548
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400830D RID: 33549
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400830E RID: 33550
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000875 RID: 2165
		public class ChangeCashCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C191 RID: 49553 RVA: 0x002F3FAC File Offset: 0x002F21AC
			// Note: this type is marked as 'beforefieldinit'.
			static ChangeCashCommand()
			{
				Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ChangeCashCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr);
				Console.ChangeCashCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100666360);
				Console.ChangeCashCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100666361);
				Console.ChangeCashCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100666362);
				Console.ChangeCashCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100666363);
				Console.ChangeCashCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100666364);
			}

			// Token: 0x17003C55 RID: 15445
			// (get) Token: 0x0600C192 RID: 49554 RVA: 0x002F403C File Offset: 0x002F223C
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101590, XrefRangeEnd = 101592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeCashCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C56 RID: 15446
			// (get) Token: 0x0600C193 RID: 49555 RVA: 0x002F4080 File Offset: 0x002F2280
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101592, XrefRangeEnd = 101594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeCashCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C57 RID: 15447
			// (get) Token: 0x0600C194 RID: 49556 RVA: 0x002F40C4 File Offset: 0x002F22C4
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101594, XrefRangeEnd = 101596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeCashCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C195 RID: 49557 RVA: 0x002F4108 File Offset: 0x002F2308
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101596, XrefRangeEnd = 101622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeCashCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C196 RID: 49558 RVA: 0x002F4158 File Offset: 0x002F2358
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChangeCashCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ChangeCashCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C197 RID: 49559 RVA: 0x0005E9E9 File Offset: 0x0005CBE9
			public ChangeCashCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400830F RID: 33551
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008310 RID: 33552
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008311 RID: 33553
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008312 RID: 33554
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008313 RID: 33555
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000876 RID: 2166
		public class ChangeOnlineBalanceCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C198 RID: 49560 RVA: 0x002F4194 File Offset: 0x002F2394
			// Note: this type is marked as 'beforefieldinit'.
			static ChangeOnlineBalanceCommand()
			{
				Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ChangeOnlineBalanceCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100666365);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100666366);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100666367);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100666368);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100666369);
			}

			// Token: 0x17003C58 RID: 15448
			// (get) Token: 0x0600C199 RID: 49561 RVA: 0x002F4224 File Offset: 0x002F2424
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101622, XrefRangeEnd = 101624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C59 RID: 15449
			// (get) Token: 0x0600C19A RID: 49562 RVA: 0x002F4268 File Offset: 0x002F2468
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101624, XrefRangeEnd = 101626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C5A RID: 15450
			// (get) Token: 0x0600C19B RID: 49563 RVA: 0x002F42AC File Offset: 0x002F24AC
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101626, XrefRangeEnd = 101628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C19C RID: 49564 RVA: 0x002F42F0 File Offset: 0x002F24F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101628, XrefRangeEnd = 101656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C19D RID: 49565 RVA: 0x002F4340 File Offset: 0x002F2540
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChangeOnlineBalanceCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C19E RID: 49566 RVA: 0x0005E9F2 File Offset: 0x0005CBF2
			public ChangeOnlineBalanceCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008314 RID: 33556
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008315 RID: 33557
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008316 RID: 33558
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008317 RID: 33559
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008318 RID: 33560
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000877 RID: 2167
		public class SetMoveSpeedCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C19F RID: 49567 RVA: 0x002F437C File Offset: 0x002F257C
			// Note: this type is marked as 'beforefieldinit'.
			static SetMoveSpeedCommand()
			{
				Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetMoveSpeedCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100666370);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100666371);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100666372);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100666373);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100666374);
			}

			// Token: 0x17003C5B RID: 15451
			// (get) Token: 0x0600C1A0 RID: 49568 RVA: 0x002F440C File Offset: 0x002F260C
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101656, XrefRangeEnd = 101658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C5C RID: 15452
			// (get) Token: 0x0600C1A1 RID: 49569 RVA: 0x002F4450 File Offset: 0x002F2650
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101658, XrefRangeEnd = 101660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C5D RID: 15453
			// (get) Token: 0x0600C1A2 RID: 49570 RVA: 0x002F4494 File Offset: 0x002F2694
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101660, XrefRangeEnd = 101662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1A3 RID: 49571 RVA: 0x002F44D8 File Offset: 0x002F26D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101662, XrefRangeEnd = 101680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetMoveSpeedCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1A4 RID: 49572 RVA: 0x002F4528 File Offset: 0x002F2728
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetMoveSpeedCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetMoveSpeedCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1A5 RID: 49573 RVA: 0x0005E9FB File Offset: 0x0005CBFB
			public SetMoveSpeedCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008319 RID: 33561
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400831A RID: 33562
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400831B RID: 33563
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400831C RID: 33564
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400831D RID: 33565
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000878 RID: 2168
		public class SetJumpMultiplier : Console.ConsoleCommand
		{
			// Token: 0x0600C1A6 RID: 49574 RVA: 0x002F4564 File Offset: 0x002F2764
			// Note: this type is marked as 'beforefieldinit'.
			static SetJumpMultiplier()
			{
				Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetJumpMultiplier");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr);
				Console.SetJumpMultiplier.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100666375);
				Console.SetJumpMultiplier.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100666376);
				Console.SetJumpMultiplier.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100666377);
				Console.SetJumpMultiplier.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100666378);
				Console.SetJumpMultiplier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100666379);
			}

			// Token: 0x17003C5E RID: 15454
			// (get) Token: 0x0600C1A7 RID: 49575 RVA: 0x002F45F4 File Offset: 0x002F27F4
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101680, XrefRangeEnd = 101682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetJumpMultiplier.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C5F RID: 15455
			// (get) Token: 0x0600C1A8 RID: 49576 RVA: 0x002F4638 File Offset: 0x002F2838
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101682, XrefRangeEnd = 101684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetJumpMultiplier.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C60 RID: 15456
			// (get) Token: 0x0600C1A9 RID: 49577 RVA: 0x002F467C File Offset: 0x002F287C
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101684, XrefRangeEnd = 101686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetJumpMultiplier.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1AA RID: 49578 RVA: 0x002F46C0 File Offset: 0x002F28C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101686, XrefRangeEnd = 101704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetJumpMultiplier.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1AB RID: 49579 RVA: 0x002F4710 File Offset: 0x002F2910
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetJumpMultiplier() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetJumpMultiplier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1AC RID: 49580 RVA: 0x0005EA04 File Offset: 0x0005CC04
			public SetJumpMultiplier(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400831E RID: 33566
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400831F RID: 33567
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008320 RID: 33568
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008321 RID: 33569
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008322 RID: 33570
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000879 RID: 2169
		public class SetPropertyOwned : Console.ConsoleCommand
		{
			// Token: 0x0600C1AD RID: 49581 RVA: 0x002F474C File Offset: 0x002F294C
			// Note: this type is marked as 'beforefieldinit'.
			static SetPropertyOwned()
			{
				Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetPropertyOwned");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr);
				Console.SetPropertyOwned.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100666380);
				Console.SetPropertyOwned.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100666381);
				Console.SetPropertyOwned.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100666382);
				Console.SetPropertyOwned.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100666383);
				Console.SetPropertyOwned.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100666384);
			}

			// Token: 0x17003C61 RID: 15457
			// (get) Token: 0x0600C1AE RID: 49582 RVA: 0x002F47DC File Offset: 0x002F29DC
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101707, XrefRangeEnd = 101709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPropertyOwned.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C62 RID: 15458
			// (get) Token: 0x0600C1AF RID: 49583 RVA: 0x002F4820 File Offset: 0x002F2A20
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101709, XrefRangeEnd = 101711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPropertyOwned.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C63 RID: 15459
			// (get) Token: 0x0600C1B0 RID: 49584 RVA: 0x002F4864 File Offset: 0x002F2A64
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101711, XrefRangeEnd = 101713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPropertyOwned.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1B1 RID: 49585 RVA: 0x002F48A8 File Offset: 0x002F2AA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101713, XrefRangeEnd = 101742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPropertyOwned.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1B2 RID: 49586 RVA: 0x002F48F8 File Offset: 0x002F2AF8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetPropertyOwned() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetPropertyOwned.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1B3 RID: 49587 RVA: 0x0005EA0D File Offset: 0x0005CC0D
			public SetPropertyOwned(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008323 RID: 33571
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008324 RID: 33572
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008325 RID: 33573
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008326 RID: 33574
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008327 RID: 33575
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000C2D RID: 3117
			[ObfuscatedName("ScheduleOne.Console+SetPropertyOwned+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
			{
				// Token: 0x0600E12C RID: 57644 RVA: 0x0034F060 File Offset: 0x0034D260
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr);
					Console.SetPropertyOwned.__c__DisplayClass6_0.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr, "code");
					Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr, 100666385);
					Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr, 100666386);
					Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__1_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr, 100666387);
				}

				// Token: 0x0600E12D RID: 57645 RVA: 0x0034F0DC File Offset: 0x0034D2DC
				[CallerCount(2261)]
				[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E12E RID: 57646 RVA: 0x0034F118 File Offset: 0x0034D318
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101704, XrefRangeEnd = 101707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__0(Property x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600E12F RID: 57647 RVA: 0x0034F168 File Offset: 0x0034D368
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__1(Business x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__1_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600E130 RID: 57648 RVA: 0x0006DCC0 File Offset: 0x0006BEC0
				public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045C4 RID: 17860
				// (get) Token: 0x0600E131 RID: 57649 RVA: 0x0034F1B8 File Offset: 0x0034D3B8
				// (set) Token: 0x0600E132 RID: 57650 RVA: 0x0006DCC9 File Offset: 0x0006BEC9
				public unsafe string code
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeFieldInfoPtr_code);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x040096C9 RID: 38601
				private static readonly IntPtr NativeFieldInfoPtr_code;

				// Token: 0x040096CA RID: 38602
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040096CB RID: 38603
				private static readonly IntPtr NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0;

				// Token: 0x040096CC RID: 38604
				private static readonly IntPtr NativeMethodInfoPtr__Execute_b__1_Internal_Boolean_Business_0;
			}
		}

		// Token: 0x0200087A RID: 2170
		public class Teleport : Console.ConsoleCommand
		{
			// Token: 0x0600C1B4 RID: 49588 RVA: 0x002F4934 File Offset: 0x002F2B34
			// Note: this type is marked as 'beforefieldinit'.
			static Teleport()
			{
				Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Teleport");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr);
				Console.Teleport.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100666388);
				Console.Teleport.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100666389);
				Console.Teleport.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100666390);
				Console.Teleport.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100666391);
				Console.Teleport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100666392);
			}

			// Token: 0x17003C64 RID: 15460
			// (get) Token: 0x0600C1B5 RID: 49589 RVA: 0x002F49C4 File Offset: 0x002F2BC4
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101742, XrefRangeEnd = 101744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Teleport.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C65 RID: 15461
			// (get) Token: 0x0600C1B6 RID: 49590 RVA: 0x002F4A08 File Offset: 0x002F2C08
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101744, XrefRangeEnd = 101746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Teleport.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C66 RID: 15462
			// (get) Token: 0x0600C1B7 RID: 49591 RVA: 0x002F4A4C File Offset: 0x002F2C4C
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101746, XrefRangeEnd = 101748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Teleport.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1B8 RID: 49592 RVA: 0x002F4A90 File Offset: 0x002F2C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101748, XrefRangeEnd = 101776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Teleport.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1B9 RID: 49593 RVA: 0x002F4AE0 File Offset: 0x002F2CE0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Teleport() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Teleport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1BA RID: 49594 RVA: 0x0005EA16 File Offset: 0x0005CC16
			public Teleport(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008328 RID: 33576
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008329 RID: 33577
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400832A RID: 33578
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400832B RID: 33579
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400832C RID: 33580
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200087B RID: 2171
		public class PackageProduct : Console.ConsoleCommand
		{
			// Token: 0x0600C1BB RID: 49595 RVA: 0x002F4B1C File Offset: 0x002F2D1C
			// Note: this type is marked as 'beforefieldinit'.
			static PackageProduct()
			{
				Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "PackageProduct");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr);
				Console.PackageProduct.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100666393);
				Console.PackageProduct.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100666394);
				Console.PackageProduct.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100666395);
				Console.PackageProduct.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100666396);
				Console.PackageProduct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100666397);
			}

			// Token: 0x17003C67 RID: 15463
			// (get) Token: 0x0600C1BC RID: 49596 RVA: 0x002F4BAC File Offset: 0x002F2DAC
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101776, XrefRangeEnd = 101778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PackageProduct.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C68 RID: 15464
			// (get) Token: 0x0600C1BD RID: 49597 RVA: 0x002F4BF0 File Offset: 0x002F2DF0
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101778, XrefRangeEnd = 101780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PackageProduct.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C69 RID: 15465
			// (get) Token: 0x0600C1BE RID: 49598 RVA: 0x002F4C34 File Offset: 0x002F2E34
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101780, XrefRangeEnd = 101782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PackageProduct.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1BF RID: 49599 RVA: 0x002F4C78 File Offset: 0x002F2E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101782, XrefRangeEnd = 101848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PackageProduct.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1C0 RID: 49600 RVA: 0x002F4CC8 File Offset: 0x002F2EC8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PackageProduct() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.PackageProduct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1C1 RID: 49601 RVA: 0x0005EA1F File Offset: 0x0005CC1F
			public PackageProduct(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400832D RID: 33581
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400832E RID: 33582
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400832F RID: 33583
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008330 RID: 33584
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008331 RID: 33585
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200087C RID: 2172
		public class SetStaminaReserve : Console.ConsoleCommand
		{
			// Token: 0x0600C1C2 RID: 49602 RVA: 0x002F4D04 File Offset: 0x002F2F04
			// Note: this type is marked as 'beforefieldinit'.
			static SetStaminaReserve()
			{
				Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetStaminaReserve");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr);
				Console.SetStaminaReserve.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100666398);
				Console.SetStaminaReserve.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100666399);
				Console.SetStaminaReserve.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100666400);
				Console.SetStaminaReserve.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100666401);
				Console.SetStaminaReserve.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100666402);
			}

			// Token: 0x17003C6A RID: 15466
			// (get) Token: 0x0600C1C3 RID: 49603 RVA: 0x002F4D94 File Offset: 0x002F2F94
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101848, XrefRangeEnd = 101850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetStaminaReserve.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C6B RID: 15467
			// (get) Token: 0x0600C1C4 RID: 49604 RVA: 0x002F4DD8 File Offset: 0x002F2FD8
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101850, XrefRangeEnd = 101852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetStaminaReserve.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C6C RID: 15468
			// (get) Token: 0x0600C1C5 RID: 49605 RVA: 0x002F4E1C File Offset: 0x002F301C
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101852, XrefRangeEnd = 101854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetStaminaReserve.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1C6 RID: 49606 RVA: 0x002F4E60 File Offset: 0x002F3060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101854, XrefRangeEnd = 101876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetStaminaReserve.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1C7 RID: 49607 RVA: 0x002F4EB0 File Offset: 0x002F30B0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetStaminaReserve() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetStaminaReserve.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1C8 RID: 49608 RVA: 0x0005EA28 File Offset: 0x0005CC28
			public SetStaminaReserve(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008332 RID: 33586
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008333 RID: 33587
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008334 RID: 33588
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008335 RID: 33589
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008336 RID: 33590
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200087D RID: 2173
		public class RaisedWanted : Console.ConsoleCommand
		{
			// Token: 0x0600C1C9 RID: 49609 RVA: 0x002F4EEC File Offset: 0x002F30EC
			// Note: this type is marked as 'beforefieldinit'.
			static RaisedWanted()
			{
				Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "RaisedWanted");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr);
				Console.RaisedWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100666403);
				Console.RaisedWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100666404);
				Console.RaisedWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100666405);
				Console.RaisedWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100666406);
				Console.RaisedWanted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100666407);
			}

			// Token: 0x17003C6D RID: 15469
			// (get) Token: 0x0600C1CA RID: 49610 RVA: 0x002F4F7C File Offset: 0x002F317C
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101876, XrefRangeEnd = 101878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.RaisedWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C6E RID: 15470
			// (get) Token: 0x0600C1CB RID: 49611 RVA: 0x002F4FC0 File Offset: 0x002F31C0
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101878, XrefRangeEnd = 101880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.RaisedWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C6F RID: 15471
			// (get) Token: 0x0600C1CC RID: 49612 RVA: 0x002F5004 File Offset: 0x002F3204
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101880, XrefRangeEnd = 101882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.RaisedWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1CD RID: 49613 RVA: 0x002F5048 File Offset: 0x002F3248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101882, XrefRangeEnd = 101919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.RaisedWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1CE RID: 49614 RVA: 0x002F5098 File Offset: 0x002F3298
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RaisedWanted() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.RaisedWanted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1CF RID: 49615 RVA: 0x0005EA31 File Offset: 0x0005CC31
			public RaisedWanted(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008337 RID: 33591
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008338 RID: 33592
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008339 RID: 33593
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400833A RID: 33594
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400833B RID: 33595
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200087E RID: 2174
		public class LowerWanted : Console.ConsoleCommand
		{
			// Token: 0x0600C1D0 RID: 49616 RVA: 0x002F50D4 File Offset: 0x002F32D4
			// Note: this type is marked as 'beforefieldinit'.
			static LowerWanted()
			{
				Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "LowerWanted");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr);
				Console.LowerWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100666408);
				Console.LowerWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100666409);
				Console.LowerWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100666410);
				Console.LowerWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100666411);
				Console.LowerWanted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100666412);
			}

			// Token: 0x17003C70 RID: 15472
			// (get) Token: 0x0600C1D1 RID: 49617 RVA: 0x002F5164 File Offset: 0x002F3364
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101919, XrefRangeEnd = 101921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.LowerWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C71 RID: 15473
			// (get) Token: 0x0600C1D2 RID: 49618 RVA: 0x002F51A8 File Offset: 0x002F33A8
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101921, XrefRangeEnd = 101923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.LowerWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C72 RID: 15474
			// (get) Token: 0x0600C1D3 RID: 49619 RVA: 0x002F51EC File Offset: 0x002F33EC
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101923, XrefRangeEnd = 101925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.LowerWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1D4 RID: 49620 RVA: 0x002F5230 File Offset: 0x002F3430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101925, XrefRangeEnd = 101940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.LowerWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1D5 RID: 49621 RVA: 0x002F5280 File Offset: 0x002F3480
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LowerWanted() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.LowerWanted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1D6 RID: 49622 RVA: 0x0005EA3A File Offset: 0x0005CC3A
			public LowerWanted(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400833C RID: 33596
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400833D RID: 33597
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400833E RID: 33598
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400833F RID: 33599
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008340 RID: 33600
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200087F RID: 2175
		public class ClearWanted : Console.ConsoleCommand
		{
			// Token: 0x0600C1D7 RID: 49623 RVA: 0x002F52BC File Offset: 0x002F34BC
			// Note: this type is marked as 'beforefieldinit'.
			static ClearWanted()
			{
				Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ClearWanted");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr);
				Console.ClearWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100666413);
				Console.ClearWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100666414);
				Console.ClearWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100666415);
				Console.ClearWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100666416);
				Console.ClearWanted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100666417);
			}

			// Token: 0x17003C73 RID: 15475
			// (get) Token: 0x0600C1D8 RID: 49624 RVA: 0x002F534C File Offset: 0x002F354C
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101940, XrefRangeEnd = 101942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C74 RID: 15476
			// (get) Token: 0x0600C1D9 RID: 49625 RVA: 0x002F5390 File Offset: 0x002F3590
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101942, XrefRangeEnd = 101944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C75 RID: 15477
			// (get) Token: 0x0600C1DA RID: 49626 RVA: 0x002F53D4 File Offset: 0x002F35D4
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101944, XrefRangeEnd = 101946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1DB RID: 49627 RVA: 0x002F5418 File Offset: 0x002F3618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101946, XrefRangeEnd = 101966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1DC RID: 49628 RVA: 0x002F5468 File Offset: 0x002F3668
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClearWanted() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ClearWanted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1DD RID: 49629 RVA: 0x0005EA43 File Offset: 0x0005CC43
			public ClearWanted(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008341 RID: 33601
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008342 RID: 33602
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008343 RID: 33603
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008344 RID: 33604
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008345 RID: 33605
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000880 RID: 2176
		public class SetHealth : Console.ConsoleCommand
		{
			// Token: 0x0600C1DE RID: 49630 RVA: 0x002F54A4 File Offset: 0x002F36A4
			// Note: this type is marked as 'beforefieldinit'.
			static SetHealth()
			{
				Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetHealth");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr);
				Console.SetHealth.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100666418);
				Console.SetHealth.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100666419);
				Console.SetHealth.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100666420);
				Console.SetHealth.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100666421);
				Console.SetHealth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100666422);
			}

			// Token: 0x17003C76 RID: 15478
			// (get) Token: 0x0600C1DF RID: 49631 RVA: 0x002F5534 File Offset: 0x002F3734
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101966, XrefRangeEnd = 101968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetHealth.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C77 RID: 15479
			// (get) Token: 0x0600C1E0 RID: 49632 RVA: 0x002F5578 File Offset: 0x002F3778
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101968, XrefRangeEnd = 101970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetHealth.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C78 RID: 15480
			// (get) Token: 0x0600C1E1 RID: 49633 RVA: 0x002F55BC File Offset: 0x002F37BC
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101970, XrefRangeEnd = 101972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetHealth.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1E2 RID: 49634 RVA: 0x002F5600 File Offset: 0x002F3800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101972, XrefRangeEnd = 101999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetHealth.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1E3 RID: 49635 RVA: 0x002F5650 File Offset: 0x002F3850
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetHealth() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetHealth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1E4 RID: 49636 RVA: 0x0005EA4C File Offset: 0x0005CC4C
			public SetHealth(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008346 RID: 33606
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008347 RID: 33607
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008348 RID: 33608
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008349 RID: 33609
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400834A RID: 33610
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000881 RID: 2177
		public class SetEnergy : Console.ConsoleCommand
		{
			// Token: 0x0600C1E5 RID: 49637 RVA: 0x002F568C File Offset: 0x002F388C
			// Note: this type is marked as 'beforefieldinit'.
			static SetEnergy()
			{
				Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetEnergy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr);
				Console.SetEnergy.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr, 100666423);
				Console.SetEnergy.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr, 100666424);
				Console.SetEnergy.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr, 100666425);
				Console.SetEnergy.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr, 100666426);
				Console.SetEnergy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr, 100666427);
			}

			// Token: 0x17003C79 RID: 15481
			// (get) Token: 0x0600C1E6 RID: 49638 RVA: 0x002F571C File Offset: 0x002F391C
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101999, XrefRangeEnd = 102001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEnergy.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C7A RID: 15482
			// (get) Token: 0x0600C1E7 RID: 49639 RVA: 0x002F5760 File Offset: 0x002F3960
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102001, XrefRangeEnd = 102003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEnergy.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C7B RID: 15483
			// (get) Token: 0x0600C1E8 RID: 49640 RVA: 0x002F57A4 File Offset: 0x002F39A4
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102003, XrefRangeEnd = 102005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEnergy.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1E9 RID: 49641 RVA: 0x002F57E8 File Offset: 0x002F39E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102005, XrefRangeEnd = 102024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEnergy.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1EA RID: 49642 RVA: 0x002F5838 File Offset: 0x002F3A38
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetEnergy() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetEnergy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1EB RID: 49643 RVA: 0x0005EA55 File Offset: 0x0005CC55
			public SetEnergy(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400834B RID: 33611
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400834C RID: 33612
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400834D RID: 33613
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400834E RID: 33614
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400834F RID: 33615
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000882 RID: 2178
		public class FreeCamCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C1EC RID: 49644 RVA: 0x002F5874 File Offset: 0x002F3A74
			// Note: this type is marked as 'beforefieldinit'.
			static FreeCamCommand()
			{
				Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "FreeCamCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr);
				Console.FreeCamCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100666428);
				Console.FreeCamCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100666429);
				Console.FreeCamCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100666430);
				Console.FreeCamCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100666431);
				Console.FreeCamCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100666432);
			}

			// Token: 0x17003C7C RID: 15484
			// (get) Token: 0x0600C1ED RID: 49645 RVA: 0x002F5904 File Offset: 0x002F3B04
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102024, XrefRangeEnd = 102026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.FreeCamCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C7D RID: 15485
			// (get) Token: 0x0600C1EE RID: 49646 RVA: 0x002F5948 File Offset: 0x002F3B48
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102026, XrefRangeEnd = 102028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.FreeCamCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C7E RID: 15486
			// (get) Token: 0x0600C1EF RID: 49647 RVA: 0x002F598C File Offset: 0x002F3B8C
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102028, XrefRangeEnd = 102030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.FreeCamCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1F0 RID: 49648 RVA: 0x002F59D0 File Offset: 0x002F3BD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102030, XrefRangeEnd = 102043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.FreeCamCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1F1 RID: 49649 RVA: 0x002F5A20 File Offset: 0x002F3C20
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FreeCamCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.FreeCamCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1F2 RID: 49650 RVA: 0x0005EA5E File Offset: 0x0005CC5E
			public FreeCamCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008350 RID: 33616
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008351 RID: 33617
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008352 RID: 33618
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008353 RID: 33619
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008354 RID: 33620
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000883 RID: 2179
		public class Save : Console.ConsoleCommand
		{
			// Token: 0x0600C1F3 RID: 49651 RVA: 0x002F5A5C File Offset: 0x002F3C5C
			// Note: this type is marked as 'beforefieldinit'.
			static Save()
			{
				Il2CppClassPointerStore<Console.Save>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Save");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Save>.NativeClassPtr);
				Console.Save.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100666433);
				Console.Save.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100666434);
				Console.Save.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100666435);
				Console.Save.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100666436);
				Console.Save.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100666437);
			}

			// Token: 0x17003C7F RID: 15487
			// (get) Token: 0x0600C1F4 RID: 49652 RVA: 0x002F5AEC File Offset: 0x002F3CEC
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102043, XrefRangeEnd = 102045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Save.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C80 RID: 15488
			// (get) Token: 0x0600C1F5 RID: 49653 RVA: 0x002F5B30 File Offset: 0x002F3D30
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102045, XrefRangeEnd = 102047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Save.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C81 RID: 15489
			// (get) Token: 0x0600C1F6 RID: 49654 RVA: 0x002F5B74 File Offset: 0x002F3D74
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102047, XrefRangeEnd = 102049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Save.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1F7 RID: 49655 RVA: 0x002F5BB8 File Offset: 0x002F3DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102049, XrefRangeEnd = 102064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Save.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1F8 RID: 49656 RVA: 0x002F5C08 File Offset: 0x002F3E08
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Save() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Save>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Save.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1F9 RID: 49657 RVA: 0x0005EA67 File Offset: 0x0005CC67
			public Save(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008355 RID: 33621
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008356 RID: 33622
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008357 RID: 33623
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008358 RID: 33624
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008359 RID: 33625
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000884 RID: 2180
		public class SetTimeScale : Console.ConsoleCommand
		{
			// Token: 0x0600C1FA RID: 49658 RVA: 0x002F5C44 File Offset: 0x002F3E44
			// Note: this type is marked as 'beforefieldinit'.
			static SetTimeScale()
			{
				Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetTimeScale");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr);
				Console.SetTimeScale.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100666438);
				Console.SetTimeScale.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100666439);
				Console.SetTimeScale.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100666440);
				Console.SetTimeScale.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100666441);
				Console.SetTimeScale.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100666442);
			}

			// Token: 0x17003C82 RID: 15490
			// (get) Token: 0x0600C1FB RID: 49659 RVA: 0x002F5CD4 File Offset: 0x002F3ED4
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102064, XrefRangeEnd = 102066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeScale.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C83 RID: 15491
			// (get) Token: 0x0600C1FC RID: 49660 RVA: 0x002F5D18 File Offset: 0x002F3F18
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102066, XrefRangeEnd = 102068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeScale.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C84 RID: 15492
			// (get) Token: 0x0600C1FD RID: 49661 RVA: 0x002F5D5C File Offset: 0x002F3F5C
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102068, XrefRangeEnd = 102070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeScale.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1FE RID: 49662 RVA: 0x002F5DA0 File Offset: 0x002F3FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102070, XrefRangeEnd = 102091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeScale.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1FF RID: 49663 RVA: 0x002F5DF0 File Offset: 0x002F3FF0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetTimeScale() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetTimeScale.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C200 RID: 49664 RVA: 0x0005EA70 File Offset: 0x0005CC70
			public SetTimeScale(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400835A RID: 33626
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400835B RID: 33627
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400835C RID: 33628
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400835D RID: 33629
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400835E RID: 33630
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000885 RID: 2181
		public class SetVariableValue : Console.ConsoleCommand
		{
			// Token: 0x0600C201 RID: 49665 RVA: 0x002F5E2C File Offset: 0x002F402C
			// Note: this type is marked as 'beforefieldinit'.
			static SetVariableValue()
			{
				Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetVariableValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr);
				Console.SetVariableValue.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100666443);
				Console.SetVariableValue.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100666444);
				Console.SetVariableValue.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100666445);
				Console.SetVariableValue.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100666446);
				Console.SetVariableValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100666447);
			}

			// Token: 0x17003C85 RID: 15493
			// (get) Token: 0x0600C202 RID: 49666 RVA: 0x002F5EBC File Offset: 0x002F40BC
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102091, XrefRangeEnd = 102093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetVariableValue.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C86 RID: 15494
			// (get) Token: 0x0600C203 RID: 49667 RVA: 0x002F5F00 File Offset: 0x002F4100
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102093, XrefRangeEnd = 102095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetVariableValue.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C87 RID: 15495
			// (get) Token: 0x0600C204 RID: 49668 RVA: 0x002F5F44 File Offset: 0x002F4144
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102095, XrefRangeEnd = 102097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetVariableValue.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C205 RID: 49669 RVA: 0x002F5F88 File Offset: 0x002F4188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102097, XrefRangeEnd = 102119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetVariableValue.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C206 RID: 49670 RVA: 0x002F5FD8 File Offset: 0x002F41D8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetVariableValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetVariableValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C207 RID: 49671 RVA: 0x0005EA79 File Offset: 0x0005CC79
			public SetVariableValue(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400835F RID: 33631
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008360 RID: 33632
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008361 RID: 33633
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008362 RID: 33634
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008363 RID: 33635
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000886 RID: 2182
		public class SetQuestState : Console.ConsoleCommand
		{
			// Token: 0x0600C208 RID: 49672 RVA: 0x002F6014 File Offset: 0x002F4214
			// Note: this type is marked as 'beforefieldinit'.
			static SetQuestState()
			{
				Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetQuestState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr);
				Console.SetQuestState.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100666448);
				Console.SetQuestState.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100666449);
				Console.SetQuestState.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100666450);
				Console.SetQuestState.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100666451);
				Console.SetQuestState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100666452);
			}

			// Token: 0x17003C88 RID: 15496
			// (get) Token: 0x0600C209 RID: 49673 RVA: 0x002F60A4 File Offset: 0x002F42A4
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102119, XrefRangeEnd = 102121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestState.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C89 RID: 15497
			// (get) Token: 0x0600C20A RID: 49674 RVA: 0x002F60E8 File Offset: 0x002F42E8
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102121, XrefRangeEnd = 102123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestState.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C8A RID: 15498
			// (get) Token: 0x0600C20B RID: 49675 RVA: 0x002F612C File Offset: 0x002F432C
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102123, XrefRangeEnd = 102125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestState.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C20C RID: 49676 RVA: 0x002F6170 File Offset: 0x002F4370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102125, XrefRangeEnd = 102159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestState.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C20D RID: 49677 RVA: 0x002F61C0 File Offset: 0x002F43C0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetQuestState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetQuestState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C20E RID: 49678 RVA: 0x0005EA82 File Offset: 0x0005CC82
			public SetQuestState(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008364 RID: 33636
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008365 RID: 33637
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008366 RID: 33638
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008367 RID: 33639
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008368 RID: 33640
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000887 RID: 2183
		public class SetQuestEntryState : Console.ConsoleCommand
		{
			// Token: 0x0600C20F RID: 49679 RVA: 0x002F61FC File Offset: 0x002F43FC
			// Note: this type is marked as 'beforefieldinit'.
			static SetQuestEntryState()
			{
				Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetQuestEntryState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr);
				Console.SetQuestEntryState.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100666453);
				Console.SetQuestEntryState.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100666454);
				Console.SetQuestEntryState.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100666455);
				Console.SetQuestEntryState.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100666456);
				Console.SetQuestEntryState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100666457);
			}

			// Token: 0x17003C8B RID: 15499
			// (get) Token: 0x0600C210 RID: 49680 RVA: 0x002F628C File Offset: 0x002F448C
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102159, XrefRangeEnd = 102161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestEntryState.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C8C RID: 15500
			// (get) Token: 0x0600C211 RID: 49681 RVA: 0x002F62D0 File Offset: 0x002F44D0
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102161, XrefRangeEnd = 102163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestEntryState.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C8D RID: 15501
			// (get) Token: 0x0600C212 RID: 49682 RVA: 0x002F6314 File Offset: 0x002F4514
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102163, XrefRangeEnd = 102165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestEntryState.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C213 RID: 49683 RVA: 0x002F6358 File Offset: 0x002F4558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102165, XrefRangeEnd = 102204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestEntryState.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C214 RID: 49684 RVA: 0x002F63A8 File Offset: 0x002F45A8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetQuestEntryState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetQuestEntryState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C215 RID: 49685 RVA: 0x0005EA8B File Offset: 0x0005CC8B
			public SetQuestEntryState(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008369 RID: 33641
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400836A RID: 33642
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400836B RID: 33643
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400836C RID: 33644
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400836D RID: 33645
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000888 RID: 2184
		public class SetEmotion : Console.ConsoleCommand
		{
			// Token: 0x0600C216 RID: 49686 RVA: 0x002F63E4 File Offset: 0x002F45E4
			// Note: this type is marked as 'beforefieldinit'.
			static SetEmotion()
			{
				Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetEmotion");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr);
				Console.SetEmotion.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100666458);
				Console.SetEmotion.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100666459);
				Console.SetEmotion.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100666460);
				Console.SetEmotion.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100666461);
				Console.SetEmotion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100666462);
			}

			// Token: 0x17003C8E RID: 15502
			// (get) Token: 0x0600C217 RID: 49687 RVA: 0x002F6474 File Offset: 0x002F4674
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102204, XrefRangeEnd = 102206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEmotion.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C8F RID: 15503
			// (get) Token: 0x0600C218 RID: 49688 RVA: 0x002F64B8 File Offset: 0x002F46B8
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102206, XrefRangeEnd = 102208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEmotion.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C90 RID: 15504
			// (get) Token: 0x0600C219 RID: 49689 RVA: 0x002F64FC File Offset: 0x002F46FC
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102208, XrefRangeEnd = 102210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEmotion.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C21A RID: 49690 RVA: 0x002F6540 File Offset: 0x002F4740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102210, XrefRangeEnd = 102241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEmotion.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C21B RID: 49691 RVA: 0x002F6590 File Offset: 0x002F4790
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetEmotion() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetEmotion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C21C RID: 49692 RVA: 0x0005EA94 File Offset: 0x0005CC94
			public SetEmotion(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400836E RID: 33646
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400836F RID: 33647
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008370 RID: 33648
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008371 RID: 33649
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008372 RID: 33650
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000889 RID: 2185
		public class SetUnlocked : Console.ConsoleCommand
		{
			// Token: 0x0600C21D RID: 49693 RVA: 0x002F65CC File Offset: 0x002F47CC
			// Note: this type is marked as 'beforefieldinit'.
			static SetUnlocked()
			{
				Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetUnlocked");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr);
				Console.SetUnlocked.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100666463);
				Console.SetUnlocked.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100666464);
				Console.SetUnlocked.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100666465);
				Console.SetUnlocked.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100666466);
				Console.SetUnlocked.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100666467);
			}

			// Token: 0x17003C91 RID: 15505
			// (get) Token: 0x0600C21E RID: 49694 RVA: 0x002F665C File Offset: 0x002F485C
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102241, XrefRangeEnd = 102243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetUnlocked.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C92 RID: 15506
			// (get) Token: 0x0600C21F RID: 49695 RVA: 0x002F66A0 File Offset: 0x002F48A0
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102243, XrefRangeEnd = 102245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetUnlocked.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C93 RID: 15507
			// (get) Token: 0x0600C220 RID: 49696 RVA: 0x002F66E4 File Offset: 0x002F48E4
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102245, XrefRangeEnd = 102247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetUnlocked.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C221 RID: 49697 RVA: 0x002F6728 File Offset: 0x002F4928
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102247, XrefRangeEnd = 102277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetUnlocked.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C222 RID: 49698 RVA: 0x002F6778 File Offset: 0x002F4978
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetUnlocked() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetUnlocked.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C223 RID: 49699 RVA: 0x0005EA9D File Offset: 0x0005CC9D
			public SetUnlocked(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008373 RID: 33651
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008374 RID: 33652
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008375 RID: 33653
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008376 RID: 33654
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008377 RID: 33655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200088A RID: 2186
		public class SetRelationship : Console.ConsoleCommand
		{
			// Token: 0x0600C224 RID: 49700 RVA: 0x002F67B4 File Offset: 0x002F49B4
			// Note: this type is marked as 'beforefieldinit'.
			static SetRelationship()
			{
				Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetRelationship");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr);
				Console.SetRelationship.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100666468);
				Console.SetRelationship.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100666469);
				Console.SetRelationship.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100666470);
				Console.SetRelationship.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100666471);
				Console.SetRelationship.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100666472);
			}

			// Token: 0x17003C94 RID: 15508
			// (get) Token: 0x0600C225 RID: 49701 RVA: 0x002F6844 File Offset: 0x002F4A44
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102277, XrefRangeEnd = 102279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRelationship.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C95 RID: 15509
			// (get) Token: 0x0600C226 RID: 49702 RVA: 0x002F6888 File Offset: 0x002F4A88
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102279, XrefRangeEnd = 102281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRelationship.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C96 RID: 15510
			// (get) Token: 0x0600C227 RID: 49703 RVA: 0x002F68CC File Offset: 0x002F4ACC
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102281, XrefRangeEnd = 102283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRelationship.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C228 RID: 49704 RVA: 0x002F6910 File Offset: 0x002F4B10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102283, XrefRangeEnd = 102307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRelationship.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C229 RID: 49705 RVA: 0x002F6960 File Offset: 0x002F4B60
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetRelationship() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetRelationship.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C22A RID: 49706 RVA: 0x0005EAA6 File Offset: 0x0005CCA6
			public SetRelationship(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008378 RID: 33656
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008379 RID: 33657
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400837A RID: 33658
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400837B RID: 33659
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400837C RID: 33660
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200088B RID: 2187
		public class AddEmployeeCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C22B RID: 49707 RVA: 0x002F699C File Offset: 0x002F4B9C
			// Note: this type is marked as 'beforefieldinit'.
			static AddEmployeeCommand()
			{
				Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "AddEmployeeCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr);
				Console.AddEmployeeCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100666473);
				Console.AddEmployeeCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100666474);
				Console.AddEmployeeCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100666475);
				Console.AddEmployeeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100666476);
				Console.AddEmployeeCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100666477);
			}

			// Token: 0x17003C97 RID: 15511
			// (get) Token: 0x0600C22C RID: 49708 RVA: 0x002F6A2C File Offset: 0x002F4C2C
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102307, XrefRangeEnd = 102309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddEmployeeCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C98 RID: 15512
			// (get) Token: 0x0600C22D RID: 49709 RVA: 0x002F6A70 File Offset: 0x002F4C70
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102309, XrefRangeEnd = 102311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddEmployeeCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C99 RID: 15513
			// (get) Token: 0x0600C22E RID: 49710 RVA: 0x002F6AB4 File Offset: 0x002F4CB4
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102311, XrefRangeEnd = 102313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddEmployeeCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C22F RID: 49711 RVA: 0x002F6AF8 File Offset: 0x002F4CF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102313, XrefRangeEnd = 102343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddEmployeeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C230 RID: 49712 RVA: 0x002F6B48 File Offset: 0x002F4D48
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddEmployeeCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.AddEmployeeCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C231 RID: 49713 RVA: 0x0005EAAF File Offset: 0x0005CCAF
			public AddEmployeeCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400837D RID: 33661
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400837E RID: 33662
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400837F RID: 33663
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008380 RID: 33664
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008381 RID: 33665
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000C2E RID: 3118
			[ObfuscatedName("ScheduleOne.Console+AddEmployeeCommand+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
			{
				// Token: 0x0600E133 RID: 57651 RVA: 0x0034F1E0 File Offset: 0x0034D3E0
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr);
					Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr, "code");
					Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr, 100666478);
					Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr, 100666479);
				}

				// Token: 0x0600E134 RID: 57652 RVA: 0x0034F248 File Offset: 0x0034D448
				[CallerCount(2261)]
				[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E135 RID: 57653 RVA: 0x0034F284 File Offset: 0x0034D484
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__0(Property x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600E136 RID: 57654 RVA: 0x0006DCE8 File Offset: 0x0006BEE8
				public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045C5 RID: 17861
				// (get) Token: 0x0600E137 RID: 57655 RVA: 0x0034F2D4 File Offset: 0x0034D4D4
				// (set) Token: 0x0600E138 RID: 57656 RVA: 0x0006DCF1 File Offset: 0x0006BEF1
				public unsafe string code
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeFieldInfoPtr_code);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x040096CD RID: 38605
				private static readonly IntPtr NativeFieldInfoPtr_code;

				// Token: 0x040096CE RID: 38606
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040096CF RID: 38607
				private static readonly IntPtr NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0;
			}
		}

		// Token: 0x0200088C RID: 2188
		public class SetDiscovered : Console.ConsoleCommand
		{
			// Token: 0x0600C232 RID: 49714 RVA: 0x002F6B84 File Offset: 0x002F4D84
			// Note: this type is marked as 'beforefieldinit'.
			static SetDiscovered()
			{
				Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetDiscovered");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr);
				Console.SetDiscovered.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100666480);
				Console.SetDiscovered.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100666481);
				Console.SetDiscovered.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100666482);
				Console.SetDiscovered.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100666483);
				Console.SetDiscovered.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100666484);
			}

			// Token: 0x17003C9A RID: 15514
			// (get) Token: 0x0600C233 RID: 49715 RVA: 0x002F6C14 File Offset: 0x002F4E14
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102343, XrefRangeEnd = 102345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDiscovered.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C9B RID: 15515
			// (get) Token: 0x0600C234 RID: 49716 RVA: 0x002F6C58 File Offset: 0x002F4E58
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102345, XrefRangeEnd = 102347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDiscovered.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C9C RID: 15516
			// (get) Token: 0x0600C235 RID: 49717 RVA: 0x002F6C9C File Offset: 0x002F4E9C
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102347, XrefRangeEnd = 102349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDiscovered.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C236 RID: 49718 RVA: 0x002F6CE0 File Offset: 0x002F4EE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102349, XrefRangeEnd = 102395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDiscovered.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C237 RID: 49719 RVA: 0x002F6D30 File Offset: 0x002F4F30
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetDiscovered() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetDiscovered.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C238 RID: 49720 RVA: 0x0005EAB8 File Offset: 0x0005CCB8
			public SetDiscovered(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008382 RID: 33666
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008383 RID: 33667
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008384 RID: 33668
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008385 RID: 33669
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008386 RID: 33670
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200088D RID: 2189
		public class GrowPlants : Console.ConsoleCommand
		{
			// Token: 0x0600C239 RID: 49721 RVA: 0x002F6D6C File Offset: 0x002F4F6C
			// Note: this type is marked as 'beforefieldinit'.
			static GrowPlants()
			{
				Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "GrowPlants");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr);
				Console.GrowPlants.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100666485);
				Console.GrowPlants.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100666486);
				Console.GrowPlants.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100666487);
				Console.GrowPlants.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100666488);
				Console.GrowPlants.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100666489);
			}

			// Token: 0x17003C9D RID: 15517
			// (get) Token: 0x0600C23A RID: 49722 RVA: 0x002F6DFC File Offset: 0x002F4FFC
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102395, XrefRangeEnd = 102397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GrowPlants.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C9E RID: 15518
			// (get) Token: 0x0600C23B RID: 49723 RVA: 0x002F6E40 File Offset: 0x002F5040
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102397, XrefRangeEnd = 102399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GrowPlants.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C9F RID: 15519
			// (get) Token: 0x0600C23C RID: 49724 RVA: 0x002F6E84 File Offset: 0x002F5084
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102399, XrefRangeEnd = 102401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GrowPlants.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C23D RID: 49725 RVA: 0x002F6EC8 File Offset: 0x002F50C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102401, XrefRangeEnd = 102409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GrowPlants.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C23E RID: 49726 RVA: 0x002F6F18 File Offset: 0x002F5118
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GrowPlants() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.GrowPlants.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C23F RID: 49727 RVA: 0x0005EAC1 File Offset: 0x0005CCC1
			public GrowPlants(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008387 RID: 33671
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008388 RID: 33672
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008389 RID: 33673
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400838A RID: 33674
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400838B RID: 33675
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200088E RID: 2190
		public class SetLawIntensity : Console.ConsoleCommand
		{
			// Token: 0x0600C240 RID: 49728 RVA: 0x002F6F54 File Offset: 0x002F5154
			// Note: this type is marked as 'beforefieldinit'.
			static SetLawIntensity()
			{
				Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetLawIntensity");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr);
				Console.SetLawIntensity.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100666490);
				Console.SetLawIntensity.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100666491);
				Console.SetLawIntensity.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100666492);
				Console.SetLawIntensity.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100666493);
				Console.SetLawIntensity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100666494);
			}

			// Token: 0x17003CA0 RID: 15520
			// (get) Token: 0x0600C241 RID: 49729 RVA: 0x002F6FE4 File Offset: 0x002F51E4
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102409, XrefRangeEnd = 102411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetLawIntensity.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CA1 RID: 15521
			// (get) Token: 0x0600C242 RID: 49730 RVA: 0x002F7028 File Offset: 0x002F5228
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102411, XrefRangeEnd = 102413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetLawIntensity.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CA2 RID: 15522
			// (get) Token: 0x0600C243 RID: 49731 RVA: 0x002F706C File Offset: 0x002F526C
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102413, XrefRangeEnd = 102415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetLawIntensity.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C244 RID: 49732 RVA: 0x002F70B0 File Offset: 0x002F52B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102415, XrefRangeEnd = 102434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetLawIntensity.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C245 RID: 49733 RVA: 0x002F7100 File Offset: 0x002F5300
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetLawIntensity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetLawIntensity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C246 RID: 49734 RVA: 0x0005EACA File Offset: 0x0005CCCA
			public SetLawIntensity(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400838C RID: 33676
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400838D RID: 33677
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400838E RID: 33678
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400838F RID: 33679
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008390 RID: 33680
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200088F RID: 2191
		public class SetQuality : Console.ConsoleCommand
		{
			// Token: 0x0600C247 RID: 49735 RVA: 0x002F713C File Offset: 0x002F533C
			// Note: this type is marked as 'beforefieldinit'.
			static SetQuality()
			{
				Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetQuality");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr);
				Console.SetQuality.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100666495);
				Console.SetQuality.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100666496);
				Console.SetQuality.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100666497);
				Console.SetQuality.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100666498);
				Console.SetQuality.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100666499);
			}

			// Token: 0x17003CA3 RID: 15523
			// (get) Token: 0x0600C248 RID: 49736 RVA: 0x002F71CC File Offset: 0x002F53CC
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102434, XrefRangeEnd = 102436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuality.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CA4 RID: 15524
			// (get) Token: 0x0600C249 RID: 49737 RVA: 0x002F7210 File Offset: 0x002F5410
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102436, XrefRangeEnd = 102438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuality.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CA5 RID: 15525
			// (get) Token: 0x0600C24A RID: 49738 RVA: 0x002F7254 File Offset: 0x002F5454
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102438, XrefRangeEnd = 102440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuality.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C24B RID: 49739 RVA: 0x002F7298 File Offset: 0x002F5498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102440, XrefRangeEnd = 102459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuality.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C24C RID: 49740 RVA: 0x002F72E8 File Offset: 0x002F54E8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetQuality() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetQuality.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C24D RID: 49741 RVA: 0x0005EAD3 File Offset: 0x0005CCD3
			public SetQuality(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008391 RID: 33681
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008392 RID: 33682
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008393 RID: 33683
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008394 RID: 33684
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008395 RID: 33685
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000890 RID: 2192
		public class Bind : Console.ConsoleCommand
		{
			// Token: 0x0600C24E RID: 49742 RVA: 0x002F7324 File Offset: 0x002F5524
			// Note: this type is marked as 'beforefieldinit'.
			static Bind()
			{
				Il2CppClassPointerStore<Console.Bind>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Bind");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr);
				Console.Bind.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100666500);
				Console.Bind.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100666501);
				Console.Bind.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100666502);
				Console.Bind.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100666503);
				Console.Bind.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100666504);
			}

			// Token: 0x17003CA6 RID: 15526
			// (get) Token: 0x0600C24F RID: 49743 RVA: 0x002F73B4 File Offset: 0x002F55B4
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102459, XrefRangeEnd = 102461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Bind.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CA7 RID: 15527
			// (get) Token: 0x0600C250 RID: 49744 RVA: 0x002F73F8 File Offset: 0x002F55F8
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102461, XrefRangeEnd = 102463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Bind.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CA8 RID: 15528
			// (get) Token: 0x0600C251 RID: 49745 RVA: 0x002F743C File Offset: 0x002F563C
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102463, XrefRangeEnd = 102465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Bind.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C252 RID: 49746 RVA: 0x002F7480 File Offset: 0x002F5680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102465, XrefRangeEnd = 102482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Bind.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C253 RID: 49747 RVA: 0x002F74D0 File Offset: 0x002F56D0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Bind() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Bind.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C254 RID: 49748 RVA: 0x0005EADC File Offset: 0x0005CCDC
			public Bind(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008396 RID: 33686
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008397 RID: 33687
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008398 RID: 33688
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008399 RID: 33689
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400839A RID: 33690
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000891 RID: 2193
		public class Unbind : Console.ConsoleCommand
		{
			// Token: 0x0600C255 RID: 49749 RVA: 0x002F750C File Offset: 0x002F570C
			// Note: this type is marked as 'beforefieldinit'.
			static Unbind()
			{
				Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Unbind");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr);
				Console.Unbind.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100666505);
				Console.Unbind.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100666506);
				Console.Unbind.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100666507);
				Console.Unbind.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100666508);
				Console.Unbind.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100666509);
			}

			// Token: 0x17003CA9 RID: 15529
			// (get) Token: 0x0600C256 RID: 49750 RVA: 0x002F759C File Offset: 0x002F579C
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102482, XrefRangeEnd = 102484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Unbind.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CAA RID: 15530
			// (get) Token: 0x0600C257 RID: 49751 RVA: 0x002F75E0 File Offset: 0x002F57E0
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102484, XrefRangeEnd = 102486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Unbind.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CAB RID: 15531
			// (get) Token: 0x0600C258 RID: 49752 RVA: 0x002F7624 File Offset: 0x002F5824
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102486, XrefRangeEnd = 102488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Unbind.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C259 RID: 49753 RVA: 0x002F7668 File Offset: 0x002F5868
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102488, XrefRangeEnd = 102503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Unbind.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C25A RID: 49754 RVA: 0x002F76B8 File Offset: 0x002F58B8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Unbind() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Unbind.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C25B RID: 49755 RVA: 0x0005EAE5 File Offset: 0x0005CCE5
			public Unbind(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400839B RID: 33691
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400839C RID: 33692
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400839D RID: 33693
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400839E RID: 33694
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400839F RID: 33695
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000892 RID: 2194
		public class ClearBinds : Console.ConsoleCommand
		{
			// Token: 0x0600C25C RID: 49756 RVA: 0x002F76F4 File Offset: 0x002F58F4
			// Note: this type is marked as 'beforefieldinit'.
			static ClearBinds()
			{
				Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ClearBinds");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr);
				Console.ClearBinds.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100666510);
				Console.ClearBinds.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100666511);
				Console.ClearBinds.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100666512);
				Console.ClearBinds.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100666513);
				Console.ClearBinds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100666514);
			}

			// Token: 0x17003CAC RID: 15532
			// (get) Token: 0x0600C25D RID: 49757 RVA: 0x002F7784 File Offset: 0x002F5984
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102503, XrefRangeEnd = 102505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearBinds.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CAD RID: 15533
			// (get) Token: 0x0600C25E RID: 49758 RVA: 0x002F77C8 File Offset: 0x002F59C8
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102505, XrefRangeEnd = 102507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearBinds.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CAE RID: 15534
			// (get) Token: 0x0600C25F RID: 49759 RVA: 0x002F780C File Offset: 0x002F5A0C
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102507, XrefRangeEnd = 102509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearBinds.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C260 RID: 49760 RVA: 0x002F7850 File Offset: 0x002F5A50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102509, XrefRangeEnd = 102526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearBinds.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C261 RID: 49761 RVA: 0x002F78A0 File Offset: 0x002F5AA0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClearBinds() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ClearBinds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C262 RID: 49762 RVA: 0x0005EAEE File Offset: 0x0005CCEE
			public ClearBinds(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040083A0 RID: 33696
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040083A1 RID: 33697
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040083A2 RID: 33698
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040083A3 RID: 33699
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040083A4 RID: 33700
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000893 RID: 2195
		public class HideUI : Console.ConsoleCommand
		{
			// Token: 0x0600C263 RID: 49763 RVA: 0x002F78DC File Offset: 0x002F5ADC
			// Note: this type is marked as 'beforefieldinit'.
			static HideUI()
			{
				Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "HideUI");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr);
				Console.HideUI.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100666515);
				Console.HideUI.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100666516);
				Console.HideUI.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100666517);
				Console.HideUI.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100666518);
				Console.HideUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100666519);
			}

			// Token: 0x17003CAF RID: 15535
			// (get) Token: 0x0600C264 RID: 49764 RVA: 0x002F796C File Offset: 0x002F5B6C
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102526, XrefRangeEnd = 102528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideUI.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CB0 RID: 15536
			// (get) Token: 0x0600C265 RID: 49765 RVA: 0x002F79B0 File Offset: 0x002F5BB0
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102528, XrefRangeEnd = 102530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideUI.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CB1 RID: 15537
			// (get) Token: 0x0600C266 RID: 49766 RVA: 0x002F79F4 File Offset: 0x002F5BF4
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102530, XrefRangeEnd = 102532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideUI.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C267 RID: 49767 RVA: 0x002F7A38 File Offset: 0x002F5C38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102532, XrefRangeEnd = 102538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideUI.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C268 RID: 49768 RVA: 0x002F7A88 File Offset: 0x002F5C88
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HideUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.HideUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C269 RID: 49769 RVA: 0x0005EAF7 File Offset: 0x0005CCF7
			public HideUI(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040083A5 RID: 33701
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040083A6 RID: 33702
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040083A7 RID: 33703
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040083A8 RID: 33704
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040083A9 RID: 33705
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000894 RID: 2196
		public class GiveXP : Console.ConsoleCommand
		{
			// Token: 0x0600C26A RID: 49770 RVA: 0x002F7AC4 File Offset: 0x002F5CC4
			// Note: this type is marked as 'beforefieldinit'.
			static GiveXP()
			{
				Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "GiveXP");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr);
				Console.GiveXP.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100666520);
				Console.GiveXP.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100666521);
				Console.GiveXP.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100666522);
				Console.GiveXP.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100666523);
				Console.GiveXP.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100666524);
			}

			// Token: 0x17003CB2 RID: 15538
			// (get) Token: 0x0600C26B RID: 49771 RVA: 0x002F7B54 File Offset: 0x002F5D54
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102538, XrefRangeEnd = 102540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GiveXP.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CB3 RID: 15539
			// (get) Token: 0x0600C26C RID: 49772 RVA: 0x002F7B98 File Offset: 0x002F5D98
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102540, XrefRangeEnd = 102542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GiveXP.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CB4 RID: 15540
			// (get) Token: 0x0600C26D RID: 49773 RVA: 0x002F7BDC File Offset: 0x002F5DDC
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102542, XrefRangeEnd = 102544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GiveXP.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C26E RID: 49774 RVA: 0x002F7C20 File Offset: 0x002F5E20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102544, XrefRangeEnd = 102565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GiveXP.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C26F RID: 49775 RVA: 0x002F7C70 File Offset: 0x002F5E70
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GiveXP() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.GiveXP.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C270 RID: 49776 RVA: 0x0005EB00 File Offset: 0x0005CD00
			public GiveXP(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040083AA RID: 33706
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040083AB RID: 33707
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040083AC RID: 33708
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040083AD RID: 33709
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040083AE RID: 33710
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000895 RID: 2197
		public class Disable : Console.ConsoleCommand
		{
			// Token: 0x0600C271 RID: 49777 RVA: 0x002F7CAC File Offset: 0x002F5EAC
			// Note: this type is marked as 'beforefieldinit'.
			static Disable()
			{
				Il2CppClassPointerStore<Console.Disable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Disable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr);
				Console.Disable.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100666525);
				Console.Disable.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100666526);
				Console.Disable.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100666527);
				Console.Disable.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100666528);
				Console.Disable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100666529);
			}

			// Token: 0x17003CB5 RID: 15541
			// (get) Token: 0x0600C272 RID: 49778 RVA: 0x002F7D3C File Offset: 0x002F5F3C
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102568, XrefRangeEnd = 102570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Disable.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CB6 RID: 15542
			// (get) Token: 0x0600C273 RID: 49779 RVA: 0x002F7D80 File Offset: 0x002F5F80
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102570, XrefRangeEnd = 102572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Disable.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CB7 RID: 15543
			// (get) Token: 0x0600C274 RID: 49780 RVA: 0x002F7DC4 File Offset: 0x002F5FC4
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102572, XrefRangeEnd = 102574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Disable.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C275 RID: 49781 RVA: 0x002F7E08 File Offset: 0x002F6008
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102574, XrefRangeEnd = 102616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Disable.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C276 RID: 49782 RVA: 0x002F7E58 File Offset: 0x002F6058
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Disable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Disable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C277 RID: 49783 RVA: 0x0005EB09 File Offset: 0x0005CD09
			public Disable(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040083AF RID: 33711
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040083B0 RID: 33712
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040083B1 RID: 33713
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040083B2 RID: 33714
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040083B3 RID: 33715
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000C2F RID: 3119
			[ObfuscatedName("ScheduleOne.Console+Disable+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
			{
				// Token: 0x0600E139 RID: 57657 RVA: 0x0034F2FC File Offset: 0x0034D4FC
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr);
					Console.Disable.__c__DisplayClass6_0.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr, "code");
					Console.Disable.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr, 100666530);
					Console.Disable.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr, 100666531);
				}

				// Token: 0x0600E13A RID: 57658 RVA: 0x0034F364 File Offset: 0x0034D564
				[CallerCount(2261)]
				[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Disable.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E13B RID: 57659 RVA: 0x0034F3A0 File Offset: 0x0034D5A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102565, XrefRangeEnd = 102568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__0(Console.LabelledGameObject x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Disable.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600E13C RID: 57660 RVA: 0x0006DD10 File Offset: 0x0006BF10
				public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045C6 RID: 17862
				// (get) Token: 0x0600E13D RID: 57661 RVA: 0x0034F3F0 File Offset: 0x0034D5F0
				// (set) Token: 0x0600E13E RID: 57662 RVA: 0x0006DD19 File Offset: 0x0006BF19
				public unsafe string code
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.Disable.__c__DisplayClass6_0.NativeFieldInfoPtr_code);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.Disable.__c__DisplayClass6_0.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x040096D0 RID: 38608
				private static readonly IntPtr NativeFieldInfoPtr_code;

				// Token: 0x040096D1 RID: 38609
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040096D2 RID: 38610
				private static readonly IntPtr NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0;
			}
		}

		// Token: 0x02000896 RID: 2198
		public class Enable : Console.ConsoleCommand
		{
			// Token: 0x0600C278 RID: 49784 RVA: 0x002F7E94 File Offset: 0x002F6094
			// Note: this type is marked as 'beforefieldinit'.
			static Enable()
			{
				Il2CppClassPointerStore<Console.Enable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Enable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr);
				Console.Enable.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100666532);
				Console.Enable.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100666533);
				Console.Enable.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100666534);
				Console.Enable.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100666535);
				Console.Enable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100666536);
			}

			// Token: 0x17003CB8 RID: 15544
			// (get) Token: 0x0600C279 RID: 49785 RVA: 0x002F7F24 File Offset: 0x002F6124
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102616, XrefRangeEnd = 102618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Enable.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CB9 RID: 15545
			// (get) Token: 0x0600C27A RID: 49786 RVA: 0x002F7F68 File Offset: 0x002F6168
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102618, XrefRangeEnd = 102620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Enable.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CBA RID: 15546
			// (get) Token: 0x0600C27B RID: 49787 RVA: 0x002F7FAC File Offset: 0x002F61AC
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102620, XrefRangeEnd = 102622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Enable.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C27C RID: 49788 RVA: 0x002F7FF0 File Offset: 0x002F61F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102622, XrefRangeEnd = 102664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Enable.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C27D RID: 49789 RVA: 0x002F8040 File Offset: 0x002F6240
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Enable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C27E RID: 49790 RVA: 0x0005EB12 File Offset: 0x0005CD12
			public Enable(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040083B4 RID: 33716
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040083B5 RID: 33717
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040083B6 RID: 33718
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040083B7 RID: 33719
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040083B8 RID: 33720
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000C30 RID: 3120
			[ObfuscatedName("ScheduleOne.Console+Enable+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
			{
				// Token: 0x0600E13F RID: 57663 RVA: 0x0034F418 File Offset: 0x0034D618
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr);
					Console.Enable.__c__DisplayClass6_0.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr, "code");
					Console.Enable.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr, 100666537);
					Console.Enable.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr, 100666538);
				}

				// Token: 0x0600E140 RID: 57664 RVA: 0x0034F480 File Offset: 0x0034D680
				[CallerCount(2261)]
				[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Enable.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E141 RID: 57665 RVA: 0x0034F4BC File Offset: 0x0034D6BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__0(Console.LabelledGameObject x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Enable.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600E142 RID: 57666 RVA: 0x0006DD38 File Offset: 0x0006BF38
				public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045C7 RID: 17863
				// (get) Token: 0x0600E143 RID: 57667 RVA: 0x0034F50C File Offset: 0x0034D70C
				// (set) Token: 0x0600E144 RID: 57668 RVA: 0x0006DD41 File Offset: 0x0006BF41
				public unsafe string code
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.Enable.__c__DisplayClass6_0.NativeFieldInfoPtr_code);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.Enable.__c__DisplayClass6_0.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x040096D3 RID: 38611
				private static readonly IntPtr NativeFieldInfoPtr_code;

				// Token: 0x040096D4 RID: 38612
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040096D5 RID: 38613
				private static readonly IntPtr NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0;
			}
		}

		// Token: 0x02000897 RID: 2199
		public class EndTutorial : Console.ConsoleCommand
		{
			// Token: 0x0600C27F RID: 49791 RVA: 0x002F807C File Offset: 0x002F627C
			// Note: this type is marked as 'beforefieldinit'.
			static EndTutorial()
			{
				Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "EndTutorial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr);
				Console.EndTutorial.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100666539);
				Console.EndTutorial.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100666540);
				Console.EndTutorial.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100666541);
				Console.EndTutorial.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100666542);
				Console.EndTutorial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100666543);
			}

			// Token: 0x17003CBB RID: 15547
			// (get) Token: 0x0600C280 RID: 49792 RVA: 0x002F810C File Offset: 0x002F630C
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102664, XrefRangeEnd = 102666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EndTutorial.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CBC RID: 15548
			// (get) Token: 0x0600C281 RID: 49793 RVA: 0x002F8150 File Offset: 0x002F6350
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102666, XrefRangeEnd = 102668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EndTutorial.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CBD RID: 15549
			// (get) Token: 0x0600C282 RID: 49794 RVA: 0x002F8194 File Offset: 0x002F6394
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102668, XrefRangeEnd = 102670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EndTutorial.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C283 RID: 49795 RVA: 0x002F81D8 File Offset: 0x002F63D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102670, XrefRangeEnd = 102676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EndTutorial.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C284 RID: 49796 RVA: 0x002F8228 File Offset: 0x002F6428
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EndTutorial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.EndTutorial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C285 RID: 49797 RVA: 0x0005EB1B File Offset: 0x0005CD1B
			public EndTutorial(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040083B9 RID: 33721
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040083BA RID: 33722
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040083BB RID: 33723
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040083BC RID: 33724
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040083BD RID: 33725
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000898 RID: 2200
		public class DisableNPCAsset : Console.ConsoleCommand
		{
			// Token: 0x0600C286 RID: 49798 RVA: 0x002F8264 File Offset: 0x002F6464
			// Note: this type is marked as 'beforefieldinit'.
			static DisableNPCAsset()
			{
				Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "DisableNPCAsset");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr);
				Console.DisableNPCAsset.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100666544);
				Console.DisableNPCAsset.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100666545);
				Console.DisableNPCAsset.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100666546);
				Console.DisableNPCAsset.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100666547);
				Console.DisableNPCAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100666548);
			}

			// Token: 0x17003CBE RID: 15550
			// (get) Token: 0x0600C287 RID: 49799 RVA: 0x002F82F4 File Offset: 0x002F64F4
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102676, XrefRangeEnd = 102678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCAsset.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CBF RID: 15551
			// (get) Token: 0x0600C288 RID: 49800 RVA: 0x002F8338 File Offset: 0x002F6538
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102678, XrefRangeEnd = 102680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCAsset.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CC0 RID: 15552
			// (get) Token: 0x0600C289 RID: 49801 RVA: 0x002F837C File Offset: 0x002F657C
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102680, XrefRangeEnd = 102682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCAsset.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C28A RID: 49802 RVA: 0x002F83C0 File Offset: 0x002F65C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102682, XrefRangeEnd = 102725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCAsset.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C28B RID: 49803 RVA: 0x002F8410 File Offset: 0x002F6610
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DisableNPCAsset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.DisableNPCAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C28C RID: 49804 RVA: 0x0005EB24 File Offset: 0x0005CD24
			public DisableNPCAsset(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040083BE RID: 33726
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040083BF RID: 33727
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040083C0 RID: 33728
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040083C1 RID: 33729
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040083C2 RID: 33730
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000899 RID: 2201
		public class ShowFPS : Console.ConsoleCommand
		{
			// Token: 0x0600C28D RID: 49805 RVA: 0x002F844C File Offset: 0x002F664C
			// Note: this type is marked as 'beforefieldinit'.
			static ShowFPS()
			{
				Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ShowFPS");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr);
				Console.ShowFPS.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100666549);
				Console.ShowFPS.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100666550);
				Console.ShowFPS.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100666551);
				Console.ShowFPS.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100666552);
				Console.ShowFPS.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100666553);
			}

			// Token: 0x17003CC1 RID: 15553
			// (get) Token: 0x0600C28E RID: 49806 RVA: 0x002F84DC File Offset: 0x002F66DC
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102725, XrefRangeEnd = 102727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ShowFPS.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CC2 RID: 15554
			// (get) Token: 0x0600C28F RID: 49807 RVA: 0x002F8520 File Offset: 0x002F6720
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102727, XrefRangeEnd = 102729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ShowFPS.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CC3 RID: 15555
			// (get) Token: 0x0600C290 RID: 49808 RVA: 0x002F8564 File Offset: 0x002F6764
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102729, XrefRangeEnd = 102731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ShowFPS.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C291 RID: 49809 RVA: 0x002F85A8 File Offset: 0x002F67A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102731, XrefRangeEnd = 102738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ShowFPS.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C292 RID: 49810 RVA: 0x002F85F8 File Offset: 0x002F67F8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ShowFPS() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ShowFPS.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C293 RID: 49811 RVA: 0x0005EB2D File Offset: 0x0005CD2D
			public ShowFPS(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040083C3 RID: 33731
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040083C4 RID: 33732
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040083C5 RID: 33733
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040083C6 RID: 33734
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040083C7 RID: 33735
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200089A RID: 2202
		public class HideFPS : Console.ConsoleCommand
		{
			// Token: 0x0600C294 RID: 49812 RVA: 0x002F8634 File Offset: 0x002F6834
			// Note: this type is marked as 'beforefieldinit'.
			static HideFPS()
			{
				Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "HideFPS");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr);
				Console.HideFPS.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100666554);
				Console.HideFPS.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100666555);
				Console.HideFPS.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100666556);
				Console.HideFPS.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100666557);
				Console.HideFPS.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100666558);
			}

			// Token: 0x17003CC4 RID: 15556
			// (get) Token: 0x0600C295 RID: 49813 RVA: 0x002F86C4 File Offset: 0x002F68C4
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102738, XrefRangeEnd = 102740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideFPS.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CC5 RID: 15557
			// (get) Token: 0x0600C296 RID: 49814 RVA: 0x002F8708 File Offset: 0x002F6908
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102740, XrefRangeEnd = 102742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideFPS.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CC6 RID: 15558
			// (get) Token: 0x0600C297 RID: 49815 RVA: 0x002F874C File Offset: 0x002F694C
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102742, XrefRangeEnd = 102744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideFPS.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C298 RID: 49816 RVA: 0x002F8790 File Offset: 0x002F6990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102744, XrefRangeEnd = 102751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideFPS.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C299 RID: 49817 RVA: 0x002F87E0 File Offset: 0x002F69E0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HideFPS() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.HideFPS.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C29A RID: 49818 RVA: 0x0005EB36 File Offset: 0x0005CD36
			public HideFPS(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040083C8 RID: 33736
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040083C9 RID: 33737
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040083CA RID: 33738
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040083CB RID: 33739
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040083CC RID: 33740
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200089B RID: 2203
		public class ClearTrash : Console.ConsoleCommand
		{
			// Token: 0x0600C29B RID: 49819 RVA: 0x002F881C File Offset: 0x002F6A1C
			// Note: this type is marked as 'beforefieldinit'.
			static ClearTrash()
			{
				Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ClearTrash");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr);
				Console.ClearTrash.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100666559);
				Console.ClearTrash.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100666560);
				Console.ClearTrash.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100666561);
				Console.ClearTrash.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100666562);
				Console.ClearTrash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100666563);
			}

			// Token: 0x17003CC7 RID: 15559
			// (get) Token: 0x0600C29C RID: 49820 RVA: 0x002F88AC File Offset: 0x002F6AAC
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102751, XrefRangeEnd = 102753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearTrash.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CC8 RID: 15560
			// (get) Token: 0x0600C29D RID: 49821 RVA: 0x002F88F0 File Offset: 0x002F6AF0
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102753, XrefRangeEnd = 102755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearTrash.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CC9 RID: 15561
			// (get) Token: 0x0600C29E RID: 49822 RVA: 0x002F8934 File Offset: 0x002F6B34
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102755, XrefRangeEnd = 102757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearTrash.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C29F RID: 49823 RVA: 0x002F8978 File Offset: 0x002F6B78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102757, XrefRangeEnd = 102763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearTrash.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2A0 RID: 49824 RVA: 0x002F89C8 File Offset: 0x002F6BC8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClearTrash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ClearTrash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2A1 RID: 49825 RVA: 0x0005EB3F File Offset: 0x0005CD3F
			public ClearTrash(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040083CD RID: 33741
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040083CE RID: 33742
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040083CF RID: 33743
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040083D0 RID: 33744
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040083D1 RID: 33745
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200089C RID: 2204
		[Serializable]
		public class LabelledGameObject : Il2CppSystem.Object
		{
			// Token: 0x0600C2A2 RID: 49826 RVA: 0x002F8A04 File Offset: 0x002F6C04
			// Note: this type is marked as 'beforefieldinit'.
			static LabelledGameObject()
			{
				Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "LabelledGameObject");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr);
				Console.LabelledGameObject.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr, "Label");
				Console.LabelledGameObject.NativeFieldInfoPtr_GameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr, "GameObject");
				Console.LabelledGameObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr, 100666564);
			}

			// Token: 0x0600C2A3 RID: 49827 RVA: 0x002F8A6C File Offset: 0x002F6C6C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LabelledGameObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.LabelledGameObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2A4 RID: 49828 RVA: 0x0005EB48 File Offset: 0x0005CD48
			public LabelledGameObject(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CCA RID: 15562
			// (get) Token: 0x0600C2A5 RID: 49829 RVA: 0x002F8AA8 File Offset: 0x002F6CA8
			// (set) Token: 0x0600C2A6 RID: 49830 RVA: 0x0005EB51 File Offset: 0x0005CD51
			public unsafe string Label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.LabelledGameObject.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.LabelledGameObject.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003CCB RID: 15563
			// (get) Token: 0x0600C2A7 RID: 49831 RVA: 0x002F8AD0 File Offset: 0x002F6CD0
			// (set) Token: 0x0600C2A8 RID: 49832 RVA: 0x0005EB70 File Offset: 0x0005CD70
			public unsafe GameObject GameObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.LabelledGameObject.NativeFieldInfoPtr_GameObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.LabelledGameObject.NativeFieldInfoPtr_GameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040083D2 RID: 33746
			private static readonly IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x040083D3 RID: 33747
			private static readonly IntPtr NativeFieldInfoPtr_GameObject;

			// Token: 0x040083D4 RID: 33748
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
