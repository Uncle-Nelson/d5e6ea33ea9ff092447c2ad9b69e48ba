using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Animation;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Other
{
	// Token: 0x020002F6 RID: 758
	public class SmokeCigarette : MonoBehaviour
	{
		// Token: 0x06003942 RID: 14658 RVA: 0x0012AA98 File Offset: 0x00128C98
		// Note: this type is marked as 'beforefieldinit'.
		static SmokeCigarette()
		{
			Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Other", "SmokeCigarette");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr);
			SmokeCigarette.NativeFieldInfoPtr_Npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, "Npc");
			SmokeCigarette.NativeFieldInfoPtr_CigarettePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, "CigarettePrefab");
			SmokeCigarette.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, "Anim");
			SmokeCigarette.NativeFieldInfoPtr_cigarette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, "cigarette");
			SmokeCigarette.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, 100669956);
			SmokeCigarette.NativeMethodInfoPtr_Begin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, 100669957);
			SmokeCigarette.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, 100669958);
			SmokeCigarette.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, 100669959);
		}

		// Token: 0x06003943 RID: 14659 RVA: 0x0012AB68 File Offset: 0x00128D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141923, XrefRangeEnd = 141931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeCigarette.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003944 RID: 14660 RVA: 0x0012AB9C File Offset: 0x00128D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141931, XrefRangeEnd = 141943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeCigarette.NativeMethodInfoPtr_Begin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x0012ABD0 File Offset: 0x00128DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141943, XrefRangeEnd = 141957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeCigarette.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003946 RID: 14662 RVA: 0x0012AC04 File Offset: 0x00128E04
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmokeCigarette() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeCigarette.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003947 RID: 14663 RVA: 0x0001D702 File Offset: 0x0001B902
		public SmokeCigarette(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x06003948 RID: 14664 RVA: 0x0012AC40 File Offset: 0x00128E40
		// (set) Token: 0x06003949 RID: 14665 RVA: 0x0001D70B File Offset: 0x0001B90B
		public unsafe NPC Npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_Npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_Npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x0600394A RID: 14666 RVA: 0x0012AC70 File Offset: 0x00128E70
		// (set) Token: 0x0600394B RID: 14667 RVA: 0x0001D72A File Offset: 0x0001B92A
		public unsafe GameObject CigarettePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_CigarettePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_CigarettePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x0600394C RID: 14668 RVA: 0x0012ACA0 File Offset: 0x00128EA0
		// (set) Token: 0x0600394D RID: 14669 RVA: 0x0001D749 File Offset: 0x0001B949
		public unsafe AvatarAnimation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x0600394E RID: 14670 RVA: 0x0012ACD0 File Offset: 0x00128ED0
		// (set) Token: 0x0600394F RID: 14671 RVA: 0x0001D768 File Offset: 0x0001B968
		public unsafe GameObject cigarette
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_cigarette);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_cigarette), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040025CA RID: 9674
		private static readonly IntPtr NativeFieldInfoPtr_Npc;

		// Token: 0x040025CB RID: 9675
		private static readonly IntPtr NativeFieldInfoPtr_CigarettePrefab;

		// Token: 0x040025CC RID: 9676
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x040025CD RID: 9677
		private static readonly IntPtr NativeFieldInfoPtr_cigarette;

		// Token: 0x040025CE RID: 9678
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040025CF RID: 9679
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_0;

		// Token: 0x040025D0 RID: 9680
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x040025D1 RID: 9681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
