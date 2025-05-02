using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Properties
{
	// Token: 0x020001E1 RID: 481
	public class Lethal : Property
	{
		// Token: 0x060027D6 RID: 10198 RVA: 0x000EE100 File Offset: 0x000EC300
		// Note: this type is marked as 'beforefieldinit'.
		static Lethal()
		{
			Il2CppClassPointerStore<Lethal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties", "Lethal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lethal>.NativeClassPtr);
			Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lethal>.NativeClassPtr, "HEALTH_DRAIN_PLAYER");
			Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_NPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lethal>.NativeClassPtr, "HEALTH_DRAIN_NPC");
			Lethal.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100667767);
			Lethal.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100667768);
			Lethal.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100667769);
			Lethal.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100667770);
			Lethal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100667771);
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x000EE1BC File Offset: 0x000EC3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118083, XrefRangeEnd = 118089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lethal.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x000EE20C File Offset: 0x000EC40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118089, XrefRangeEnd = 118108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lethal.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x000EE25C File Offset: 0x000EC45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118108, XrefRangeEnd = 118113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lethal.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x000EE2AC File Offset: 0x000EC4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118113, XrefRangeEnd = 118131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lethal.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x000EE2FC File Offset: 0x000EC4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lethal() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lethal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lethal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x00015D4B File Offset: 0x00013F4B
		public Lethal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x000EE338 File Offset: 0x000EC538
		// (set) Token: 0x060027DE RID: 10206 RVA: 0x00015D54 File Offset: 0x00013F54
		public unsafe static float HEALTH_DRAIN_PLAYER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_PLAYER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_PLAYER, (void*)(&value));
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x000EE354 File Offset: 0x000EC554
		// (set) Token: 0x060027E0 RID: 10208 RVA: 0x00015D62 File Offset: 0x00013F62
		public unsafe static float HEALTH_DRAIN_NPC
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_NPC, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_NPC, (void*)(&value));
			}
		}

		// Token: 0x04001A76 RID: 6774
		private static readonly IntPtr NativeFieldInfoPtr_HEALTH_DRAIN_PLAYER;

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeFieldInfoPtr_HEALTH_DRAIN_NPC;

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A79 RID: 6777
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A7B RID: 6779
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001A7C RID: 6780
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
