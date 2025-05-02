using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200001D RID: 29
	public class TrailerSaleAnim : MonoBehaviour
	{
		// Token: 0x060001D0 RID: 464 RVA: 0x000763F4 File Offset: 0x000745F4
		// Note: this type is marked as 'beforefieldinit'.
		static TrailerSaleAnim()
		{
			Il2CppClassPointerStore<TrailerSaleAnim>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TrailerSaleAnim");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailerSaleAnim>.NativeClassPtr);
			TrailerSaleAnim.NativeFieldInfoPtr_NPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerSaleAnim>.NativeClassPtr, "NPCs");
			TrailerSaleAnim.NativeMethodInfoPtr_PlayAnim_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerSaleAnim>.NativeClassPtr, 100663466);
			TrailerSaleAnim.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerSaleAnim>.NativeClassPtr, 100663467);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00076460 File Offset: 0x00074660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72290, XrefRangeEnd = 72300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerSaleAnim.NativeMethodInfoPtr_PlayAnim_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00076494 File Offset: 0x00074694
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrailerSaleAnim() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrailerSaleAnim>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerSaleAnim.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00003021 File Offset: 0x00001221
		public TrailerSaleAnim(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x000764D0 File Offset: 0x000746D0
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x0000302A File Offset: 0x0000122A
		public unsafe Il2CppReferenceArray<NPC> NPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerSaleAnim.NativeFieldInfoPtr_NPCs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerSaleAnim.NativeFieldInfoPtr_NPCs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_NPCs;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_PlayAnim_Public_Void_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
