using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x020002DE RID: 734
	public class ConversationLocation : MonoBehaviour
	{
		// Token: 0x06003649 RID: 13897 RVA: 0x0011F5BC File Offset: 0x0011D7BC
		// Note: this type is marked as 'beforefieldinit'.
		static ConversationLocation()
		{
			Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "ConversationLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr);
			ConversationLocation.NativeFieldInfoPtr_StandPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "StandPoints");
			ConversationLocation.NativeFieldInfoPtr_NPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "NPCs");
			ConversationLocation.NativeFieldInfoPtr_npcReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "npcReady");
			ConversationLocation.NativeMethodInfoPtr_get_NPCsReady_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100669472);
			ConversationLocation.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100669473);
			ConversationLocation.NativeMethodInfoPtr_GetStandPoint_Public_Transform_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100669474);
			ConversationLocation.NativeMethodInfoPtr_SetNPCReady_Public_Void_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100669475);
			ConversationLocation.NativeMethodInfoPtr_GetOtherNPC_Public_NPC_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100669476);
			ConversationLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100669477);
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x0600364A RID: 13898 RVA: 0x0011F6A0 File Offset: 0x0011D8A0
		public unsafe bool NPCsReady
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138814, XrefRangeEnd = 138835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_get_NPCsReady_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x0011F6DC File Offset: 0x0011D8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138835, XrefRangeEnd = 138859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x0011F710 File Offset: 0x0011D910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138859, XrefRangeEnd = 138867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetStandPoint(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_GetStandPoint_Public_Transform_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x0011F760 File Offset: 0x0011D960
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138880, RefRangeEnd = 138883, XrefRangeStart = 138867, XrefRangeEnd = 138880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNPCReady(NPC npc, bool ready)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ready;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_SetNPCReady_Public_Void_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x0011F7B0 File Offset: 0x0011D9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138883, XrefRangeEnd = 138909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPC GetOtherNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_GetOtherNPC_Public_NPC_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x0011F800 File Offset: 0x0011DA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138909, XrefRangeEnd = 138924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConversationLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x0001C79E File Offset: 0x0001A99E
		public ConversationLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x06003651 RID: 13905 RVA: 0x0011F83C File Offset: 0x0011DA3C
		// (set) Token: 0x06003652 RID: 13906 RVA: 0x0001C7A7 File Offset: 0x0001A9A7
		public unsafe Il2CppReferenceArray<Transform> StandPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_StandPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_StandPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x06003653 RID: 13907 RVA: 0x0011F86C File Offset: 0x0011DA6C
		// (set) Token: 0x06003654 RID: 13908 RVA: 0x0001C7C6 File Offset: 0x0001A9C6
		public unsafe List<NPC> NPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_NPCs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_NPCs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x06003655 RID: 13909 RVA: 0x0011F89C File Offset: 0x0011DA9C
		// (set) Token: 0x06003656 RID: 13910 RVA: 0x0001C7E5 File Offset: 0x0001A9E5
		public unsafe Dictionary<NPC, bool> npcReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_npcReady);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<NPC, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_npcReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002385 RID: 9093
		private static readonly IntPtr NativeFieldInfoPtr_StandPoints;

		// Token: 0x04002386 RID: 9094
		private static readonly IntPtr NativeFieldInfoPtr_NPCs;

		// Token: 0x04002387 RID: 9095
		private static readonly IntPtr NativeFieldInfoPtr_npcReady;

		// Token: 0x04002388 RID: 9096
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCsReady_Public_get_Boolean_0;

		// Token: 0x04002389 RID: 9097
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x0400238A RID: 9098
		private static readonly IntPtr NativeMethodInfoPtr_GetStandPoint_Public_Transform_NPC_0;

		// Token: 0x0400238B RID: 9099
		private static readonly IntPtr NativeMethodInfoPtr_SetNPCReady_Public_Void_NPC_Boolean_0;

		// Token: 0x0400238C RID: 9100
		private static readonly IntPtr NativeMethodInfoPtr_GetOtherNPC_Public_NPC_NPC_0;

		// Token: 0x0400238D RID: 9101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200092D RID: 2349
		[ObfuscatedName("ScheduleOne.NPCs.Schedules.ConversationLocation+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C6C4 RID: 50884 RVA: 0x003041E4 File Offset: 0x003023E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr);
				ConversationLocation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr, "<>9");
				ConversationLocation.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr, "<>9__3_0");
				ConversationLocation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr, 100669479);
				ConversationLocation.__c.NativeMethodInfoPtr__get_NPCsReady_b__3_0_Internal_Boolean_KeyValuePair_2_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr, 100669480);
			}

			// Token: 0x0600C6C5 RID: 50885 RVA: 0x00304260 File Offset: 0x00302460
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C6C6 RID: 50886 RVA: 0x0030429C File Offset: 0x0030249C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138809, XrefRangeEnd = 138810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_NPCsReady_b__3_0(KeyValuePair<NPC, bool> npcReady)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(npcReady));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.__c.NativeMethodInfoPtr__get_NPCsReady_b__3_0_Internal_Boolean_KeyValuePair_2_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C6C7 RID: 50887 RVA: 0x00060BFD File Offset: 0x0005EDFD
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DEB RID: 15851
			// (get) Token: 0x0600C6C8 RID: 50888 RVA: 0x003042F0 File Offset: 0x003024F0
			// (set) Token: 0x0600C6C9 RID: 50889 RVA: 0x00060C06 File Offset: 0x0005EE06
			public unsafe static ConversationLocation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConversationLocation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConversationLocation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConversationLocation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DEC RID: 15852
			// (get) Token: 0x0600C6CA RID: 50890 RVA: 0x00304318 File Offset: 0x00302518
			// (set) Token: 0x0600C6CB RID: 50891 RVA: 0x00060C18 File Offset: 0x0005EE18
			public unsafe static Func<KeyValuePair<NPC, bool>, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConversationLocation.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<NPC, bool>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConversationLocation.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008688 RID: 34440
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008689 RID: 34441
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400868A RID: 34442
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400868B RID: 34443
			private static readonly IntPtr NativeMethodInfoPtr__get_NPCsReady_b__3_0_Internal_Boolean_KeyValuePair_2_NPC_Boolean_0;
		}

		// Token: 0x0200092E RID: 2350
		[ObfuscatedName("ScheduleOne.NPCs.Schedules.ConversationLocation+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C6CC RID: 50892 RVA: 0x00304340 File Offset: 0x00302540
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr);
				ConversationLocation.__c__DisplayClass8_0.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr, "npc");
				ConversationLocation.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr, 100669481);
				ConversationLocation.__c__DisplayClass8_0.NativeMethodInfoPtr__GetOtherNPC_b__0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr, 100669482);
			}

			// Token: 0x0600C6CD RID: 50893 RVA: 0x003043A8 File Offset: 0x003025A8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C6CE RID: 50894 RVA: 0x003043E4 File Offset: 0x003025E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138810, XrefRangeEnd = 138814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetOtherNPC_b__0(NPC otherNPC)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherNPC);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.__c__DisplayClass8_0.NativeMethodInfoPtr__GetOtherNPC_b__0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C6CF RID: 50895 RVA: 0x00060C2A File Offset: 0x0005EE2A
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DED RID: 15853
			// (get) Token: 0x0600C6D0 RID: 50896 RVA: 0x00304434 File Offset: 0x00302634
			// (set) Token: 0x0600C6D1 RID: 50897 RVA: 0x00060C33 File Offset: 0x0005EE33
			public unsafe NPC npc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.__c__DisplayClass8_0.NativeFieldInfoPtr_npc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.__c__DisplayClass8_0.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400868C RID: 34444
			private static readonly IntPtr NativeFieldInfoPtr_npc;

			// Token: 0x0400868D RID: 34445
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400868E RID: 34446
			private static readonly IntPtr NativeMethodInfoPtr__GetOtherNPC_b__0_Internal_Boolean_NPC_0;
		}
	}
}
