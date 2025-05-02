using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Relation
{
	// Token: 0x020002F3 RID: 755
	public class NPCUnlockTracker : MonoBehaviour
	{
		// Token: 0x0600391D RID: 14621 RVA: 0x0012A368 File Offset: 0x00128568
		// Note: this type is marked as 'beforefieldinit'.
		static NPCUnlockTracker()
		{
			Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Relation", "NPCUnlockTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr);
			NPCUnlockTracker.NativeFieldInfoPtr_Npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, "Npc");
			NPCUnlockTracker.NativeFieldInfoPtr_onUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, "onUnlocked");
			NPCUnlockTracker.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, 100669941);
			NPCUnlockTracker.NativeMethodInfoPtr_Invoke_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, 100669942);
			NPCUnlockTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, 100669943);
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x0012A3FC File Offset: 0x001285FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141873, XrefRangeEnd = 141890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCUnlockTracker.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600391F RID: 14623 RVA: 0x0012A430 File Offset: 0x00128630
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141891, RefRangeEnd = 141895, XrefRangeStart = 141890, XrefRangeEnd = 141891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(NPCRelationData.EUnlockType type, bool t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCUnlockTracker.NativeMethodInfoPtr_Invoke_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x0012A47C File Offset: 0x0012867C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCUnlockTracker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCUnlockTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x0001D5F7 File Offset: 0x0001B7F7
		public NPCUnlockTracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x06003922 RID: 14626 RVA: 0x0012A4B8 File Offset: 0x001286B8
		// (set) Token: 0x06003923 RID: 14627 RVA: 0x0001D600 File Offset: 0x0001B800
		public unsafe NPC Npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCUnlockTracker.NativeFieldInfoPtr_Npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCUnlockTracker.NativeFieldInfoPtr_Npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x06003924 RID: 14628 RVA: 0x0012A4E8 File Offset: 0x001286E8
		// (set) Token: 0x06003925 RID: 14629 RVA: 0x0001D61F File Offset: 0x0001B81F
		public unsafe UnityEvent onUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCUnlockTracker.NativeFieldInfoPtr_onUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCUnlockTracker.NativeFieldInfoPtr_onUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040025B3 RID: 9651
		private static readonly IntPtr NativeFieldInfoPtr_Npc;

		// Token: 0x040025B4 RID: 9652
		private static readonly IntPtr NativeFieldInfoPtr_onUnlocked;

		// Token: 0x040025B5 RID: 9653
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040025B6 RID: 9654
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Private_Void_EUnlockType_Boolean_0;

		// Token: 0x040025B7 RID: 9655
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
