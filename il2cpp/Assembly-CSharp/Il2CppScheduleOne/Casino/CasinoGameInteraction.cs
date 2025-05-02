using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004A3 RID: 1187
	public class CasinoGameInteraction : MonoBehaviour
	{
		// Token: 0x0600674F RID: 26447 RVA: 0x001D072C File Offset: 0x001CE92C
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGameInteraction()
		{
			Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CasinoGameInteraction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr);
			CasinoGameInteraction.NativeFieldInfoPtr_GameName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, "GameName");
			CasinoGameInteraction.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, "Players");
			CasinoGameInteraction.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, "IntObj");
			CasinoGameInteraction.NativeFieldInfoPtr_onLocalPlayerRequestJoin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, "onLocalPlayerRequestJoin");
			CasinoGameInteraction.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, 100676393);
			CasinoGameInteraction.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, 100676394);
			CasinoGameInteraction.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, 100676395);
			CasinoGameInteraction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, 100676396);
		}

		// Token: 0x06006750 RID: 26448 RVA: 0x001D07FC File Offset: 0x001CE9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209196, XrefRangeEnd = 209210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameInteraction.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006751 RID: 26449 RVA: 0x001D0830 File Offset: 0x001CEA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209210, XrefRangeEnd = 209215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameInteraction.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006752 RID: 26450 RVA: 0x001D0864 File Offset: 0x001CEA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209215, XrefRangeEnd = 209220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameInteraction.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006753 RID: 26451 RVA: 0x001D0898 File Offset: 0x001CEA98
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGameInteraction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameInteraction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006754 RID: 26452 RVA: 0x00030CC8 File Offset: 0x0002EEC8
		public CasinoGameInteraction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x06006755 RID: 26453 RVA: 0x001D08D4 File Offset: 0x001CEAD4
		// (set) Token: 0x06006756 RID: 26454 RVA: 0x00030CD1 File Offset: 0x0002EED1
		public unsafe string GameName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_GameName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_GameName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x06006757 RID: 26455 RVA: 0x001D08FC File Offset: 0x001CEAFC
		// (set) Token: 0x06006758 RID: 26456 RVA: 0x00030CF0 File Offset: 0x0002EEF0
		public unsafe CasinoGamePlayers Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x06006759 RID: 26457 RVA: 0x001D092C File Offset: 0x001CEB2C
		// (set) Token: 0x0600675A RID: 26458 RVA: 0x00030D0F File Offset: 0x0002EF0F
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x0600675B RID: 26459 RVA: 0x001D095C File Offset: 0x001CEB5C
		// (set) Token: 0x0600675C RID: 26460 RVA: 0x00030D2E File Offset: 0x0002EF2E
		public unsafe Action<Player> onLocalPlayerRequestJoin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_onLocalPlayerRequestJoin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_onLocalPlayerRequestJoin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040046B9 RID: 18105
		private static readonly IntPtr NativeFieldInfoPtr_GameName;

		// Token: 0x040046BA RID: 18106
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x040046BB RID: 18107
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x040046BC RID: 18108
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerRequestJoin;

		// Token: 0x040046BD RID: 18109
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040046BE RID: 18110
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x040046BF RID: 18111
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x040046C0 RID: 18112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
