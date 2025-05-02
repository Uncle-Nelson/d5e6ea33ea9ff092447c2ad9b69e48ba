using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000541 RID: 1345
	public class NPCWalkTo : MonoBehaviour
	{
		// Token: 0x0600773B RID: 30523 RVA: 0x002059C4 File Offset: 0x00203BC4
		// Note: this type is marked as 'beforefieldinit'.
		static NPCWalkTo()
		{
			Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "NPCWalkTo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr);
			NPCWalkTo.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, "Target");
			NPCWalkTo.NativeFieldInfoPtr_RepathRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, "RepathRate");
			NPCWalkTo.NativeFieldInfoPtr_timeSinceLastPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, "timeSinceLastPath");
			NPCWalkTo.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, 100678321);
			NPCWalkTo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, 100678322);
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x00205A58 File Offset: 0x00203C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231696, XrefRangeEnd = 231702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCWalkTo.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600773D RID: 30525 RVA: 0x00205A8C File Offset: 0x00203C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCWalkTo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCWalkTo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600773E RID: 30526 RVA: 0x0003879D File Offset: 0x0003699D
		public NPCWalkTo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700240F RID: 9231
		// (get) Token: 0x0600773F RID: 30527 RVA: 0x00205AC8 File Offset: 0x00203CC8
		// (set) Token: 0x06007740 RID: 30528 RVA: 0x000387A6 File Offset: 0x000369A6
		public unsafe Transform Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002410 RID: 9232
		// (get) Token: 0x06007741 RID: 30529 RVA: 0x00205AF8 File Offset: 0x00203CF8
		// (set) Token: 0x06007742 RID: 30530 RVA: 0x000387C5 File Offset: 0x000369C5
		public unsafe float RepathRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_RepathRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_RepathRate)) = value;
			}
		}

		// Token: 0x17002411 RID: 9233
		// (get) Token: 0x06007743 RID: 30531 RVA: 0x00205B20 File Offset: 0x00203D20
		// (set) Token: 0x06007744 RID: 30532 RVA: 0x000387E0 File Offset: 0x000369E0
		public unsafe float timeSinceLastPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_timeSinceLastPath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_timeSinceLastPath)) = value;
			}
		}

		// Token: 0x04005163 RID: 20835
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x04005164 RID: 20836
		private static readonly IntPtr NativeFieldInfoPtr_RepathRate;

		// Token: 0x04005165 RID: 20837
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastPath;

		// Token: 0x04005166 RID: 20838
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005167 RID: 20839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
