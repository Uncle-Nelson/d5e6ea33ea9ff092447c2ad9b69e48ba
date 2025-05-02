using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006B8 RID: 1720
	public class AssignedWorkerDisplay : MonoBehaviour
	{
		// Token: 0x06009B2E RID: 39726 RVA: 0x00276444 File Offset: 0x00274644
		// Note: this type is marked as 'beforefieldinit'.
		static AssignedWorkerDisplay()
		{
			Il2CppClassPointerStore<AssignedWorkerDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "AssignedWorkerDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignedWorkerDisplay>.NativeClassPtr);
			AssignedWorkerDisplay.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignedWorkerDisplay>.NativeClassPtr, "Icon");
			AssignedWorkerDisplay.NativeMethodInfoPtr_Set_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignedWorkerDisplay>.NativeClassPtr, 100682379);
			AssignedWorkerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignedWorkerDisplay>.NativeClassPtr, 100682380);
		}

		// Token: 0x06009B2F RID: 39727 RVA: 0x002764B0 File Offset: 0x002746B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275921, RefRangeEnd = 275922, XrefRangeStart = 275910, XrefRangeEnd = 275921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignedWorkerDisplay.NativeMethodInfoPtr_Set_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B30 RID: 39728 RVA: 0x002764F4 File Offset: 0x002746F4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssignedWorkerDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignedWorkerDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignedWorkerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B31 RID: 39729 RVA: 0x0004BFC6 File Offset: 0x0004A1C6
		public AssignedWorkerDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FCA RID: 12234
		// (get) Token: 0x06009B32 RID: 39730 RVA: 0x00276530 File Offset: 0x00274730
		// (set) Token: 0x06009B33 RID: 39731 RVA: 0x0004BFCF File Offset: 0x0004A1CF
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignedWorkerDisplay.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignedWorkerDisplay.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006856 RID: 26710
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04006857 RID: 26711
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_NPC_0;

		// Token: 0x04006858 RID: 26712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
