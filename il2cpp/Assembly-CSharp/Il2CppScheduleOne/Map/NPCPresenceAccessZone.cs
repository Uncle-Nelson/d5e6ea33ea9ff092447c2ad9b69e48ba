using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000781 RID: 1921
	public class NPCPresenceAccessZone : AccessZone
	{
		// Token: 0x0600B5DA RID: 46554 RVA: 0x002D321C File Offset: 0x002D141C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCPresenceAccessZone()
		{
			Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "NPCPresenceAccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr);
			NPCPresenceAccessZone.NativeFieldInfoPtr_CooldownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, "CooldownTime");
			NPCPresenceAccessZone.NativeFieldInfoPtr_DetectionZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, "DetectionZone");
			NPCPresenceAccessZone.NativeFieldInfoPtr_TargetNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, "TargetNPC");
			NPCPresenceAccessZone.NativeFieldInfoPtr_timeSinceNPCSensed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, "timeSinceNPCSensed");
			NPCPresenceAccessZone.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, 100685650);
			NPCPresenceAccessZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, 100685651);
			NPCPresenceAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, 100685652);
			NPCPresenceAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, 100685653);
		}

		// Token: 0x0600B5DB RID: 46555 RVA: 0x002D32EC File Offset: 0x002D14EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310856, XrefRangeEnd = 310857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCPresenceAccessZone.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5DC RID: 46556 RVA: 0x002D3328 File Offset: 0x002D1528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310857, XrefRangeEnd = 310873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCPresenceAccessZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5DD RID: 46557 RVA: 0x002D3364 File Offset: 0x002D1564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310873, XrefRangeEnd = 310880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCPresenceAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5DE RID: 46558 RVA: 0x002D33A0 File Offset: 0x002D15A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310881, RefRangeEnd = 310882, XrefRangeStart = 310880, XrefRangeEnd = 310881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCPresenceAccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPresenceAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5DF RID: 46559 RVA: 0x00059403 File Offset: 0x00057603
		public NPCPresenceAccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700385F RID: 14431
		// (get) Token: 0x0600B5E0 RID: 46560 RVA: 0x002D33DC File Offset: 0x002D15DC
		// (set) Token: 0x0600B5E1 RID: 46561 RVA: 0x0005940C File Offset: 0x0005760C
		public unsafe static float CooldownTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCPresenceAccessZone.NativeFieldInfoPtr_CooldownTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCPresenceAccessZone.NativeFieldInfoPtr_CooldownTime, (void*)(&value));
			}
		}

		// Token: 0x17003860 RID: 14432
		// (get) Token: 0x0600B5E2 RID: 46562 RVA: 0x002D33F8 File Offset: 0x002D15F8
		// (set) Token: 0x0600B5E3 RID: 46563 RVA: 0x0005941A File Offset: 0x0005761A
		public unsafe Collider DetectionZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_DetectionZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_DetectionZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003861 RID: 14433
		// (get) Token: 0x0600B5E4 RID: 46564 RVA: 0x002D3428 File Offset: 0x002D1628
		// (set) Token: 0x0600B5E5 RID: 46565 RVA: 0x00059439 File Offset: 0x00057639
		public unsafe NPC TargetNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_TargetNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_TargetNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003862 RID: 14434
		// (get) Token: 0x0600B5E6 RID: 46566 RVA: 0x002D3458 File Offset: 0x002D1658
		// (set) Token: 0x0600B5E7 RID: 46567 RVA: 0x00059458 File Offset: 0x00057658
		public unsafe float timeSinceNPCSensed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_timeSinceNPCSensed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_timeSinceNPCSensed)) = value;
			}
		}

		// Token: 0x04007A89 RID: 31369
		private static readonly IntPtr NativeFieldInfoPtr_CooldownTime;

		// Token: 0x04007A8A RID: 31370
		private static readonly IntPtr NativeFieldInfoPtr_DetectionZone;

		// Token: 0x04007A8B RID: 31371
		private static readonly IntPtr NativeFieldInfoPtr_TargetNPC;

		// Token: 0x04007A8C RID: 31372
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceNPCSensed;

		// Token: 0x04007A8D RID: 31373
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007A8E RID: 31374
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007A8F RID: 31375
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04007A90 RID: 31376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
