using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200053C RID: 1340
	public class GameVersionEvents : MonoBehaviour
	{
		// Token: 0x060076FE RID: 30462 RVA: 0x00204E20 File Offset: 0x00203020
		// Note: this type is marked as 'beforefieldinit'.
		static GameVersionEvents()
		{
			Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "GameVersionEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr);
			GameVersionEvents.NativeFieldInfoPtr_onFullGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr, "onFullGame");
			GameVersionEvents.NativeFieldInfoPtr_onDemoGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr, "onDemoGame");
			GameVersionEvents.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr, 100678289);
			GameVersionEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr, 100678290);
		}

		// Token: 0x060076FF RID: 30463 RVA: 0x00204EA0 File Offset: 0x002030A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameVersionEvents.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007700 RID: 30464 RVA: 0x00204ED4 File Offset: 0x002030D4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameVersionEvents() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameVersionEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007701 RID: 30465 RVA: 0x000385D6 File Offset: 0x000367D6
		public GameVersionEvents(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023FF RID: 9215
		// (get) Token: 0x06007702 RID: 30466 RVA: 0x00204F10 File Offset: 0x00203110
		// (set) Token: 0x06007703 RID: 30467 RVA: 0x000385DF File Offset: 0x000367DF
		public unsafe UnityEvent onFullGame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVersionEvents.NativeFieldInfoPtr_onFullGame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVersionEvents.NativeFieldInfoPtr_onFullGame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002400 RID: 9216
		// (get) Token: 0x06007704 RID: 30468 RVA: 0x00204F40 File Offset: 0x00203140
		// (set) Token: 0x06007705 RID: 30469 RVA: 0x000385FE File Offset: 0x000367FE
		public unsafe UnityEvent onDemoGame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVersionEvents.NativeFieldInfoPtr_onDemoGame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVersionEvents.NativeFieldInfoPtr_onDemoGame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400513E RID: 20798
		private static readonly IntPtr NativeFieldInfoPtr_onFullGame;

		// Token: 0x0400513F RID: 20799
		private static readonly IntPtr NativeFieldInfoPtr_onDemoGame;

		// Token: 0x04005140 RID: 20800
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005141 RID: 20801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
