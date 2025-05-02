using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000780 RID: 1920
	public class NPCPoI : POI
	{
		// Token: 0x0600B5D1 RID: 46545 RVA: 0x002D3004 File Offset: 0x002D1204
		// Note: this type is marked as 'beforefieldinit'.
		static NPCPoI()
		{
			Il2CppClassPointerStore<NPCPoI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "NPCPoI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr);
			NPCPoI.NativeFieldInfoPtr__NPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr, "<NPC>k__BackingField");
			NPCPoI.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr, 100685645);
			NPCPoI.NativeMethodInfoPtr_set_NPC_Private_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr, 100685646);
			NPCPoI.NativeMethodInfoPtr_InitializeUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr, 100685647);
			NPCPoI.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr, 100685648);
			NPCPoI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr, 100685649);
		}

		// Token: 0x1700385E RID: 14430
		// (get) Token: 0x0600B5D2 RID: 46546 RVA: 0x002D30AC File Offset: 0x002D12AC
		// (set) Token: 0x0600B5D3 RID: 46547 RVA: 0x002D30EC File Offset: 0x002D12EC
		public unsafe NPC NPC
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPoI.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPoI.NativeMethodInfoPtr_set_NPC_Private_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B5D4 RID: 46548 RVA: 0x002D3130 File Offset: 0x002D1330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310815, XrefRangeEnd = 310830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCPoI.NativeMethodInfoPtr_InitializeUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5D5 RID: 46549 RVA: 0x002D316C File Offset: 0x002D136C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 310845, RefRangeEnd = 310848, XrefRangeStart = 310830, XrefRangeEnd = 310845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPoI.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5D6 RID: 46550 RVA: 0x002D31B0 File Offset: 0x002D13B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310848, XrefRangeEnd = 310856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCPoI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPoI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5D7 RID: 46551 RVA: 0x000593DB File Offset: 0x000575DB
		public NPCPoI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700385D RID: 14429
		// (get) Token: 0x0600B5D8 RID: 46552 RVA: 0x002D31EC File Offset: 0x002D13EC
		// (set) Token: 0x0600B5D9 RID: 46553 RVA: 0x000593E4 File Offset: 0x000575E4
		public unsafe NPC _NPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPoI.NativeFieldInfoPtr__NPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPoI.NativeFieldInfoPtr__NPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A83 RID: 31363
		private static readonly IntPtr NativeFieldInfoPtr__NPC_k__BackingField;

		// Token: 0x04007A84 RID: 31364
		private static readonly IntPtr NativeMethodInfoPtr_get_NPC_Public_get_NPC_0;

		// Token: 0x04007A85 RID: 31365
		private static readonly IntPtr NativeMethodInfoPtr_set_NPC_Private_set_Void_NPC_0;

		// Token: 0x04007A86 RID: 31366
		private static readonly IntPtr NativeMethodInfoPtr_InitializeUI_Public_Virtual_Void_0;

		// Token: 0x04007A87 RID: 31367
		private static readonly IntPtr NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0;

		// Token: 0x04007A88 RID: 31368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
