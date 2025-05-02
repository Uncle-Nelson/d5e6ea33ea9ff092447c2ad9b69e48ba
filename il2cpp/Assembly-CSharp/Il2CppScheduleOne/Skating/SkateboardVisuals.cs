using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x020001A9 RID: 425
	public class SkateboardVisuals : MonoBehaviour
	{
		// Token: 0x06002417 RID: 9239 RVA: 0x000E0788 File Offset: 0x000DE988
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardVisuals()
		{
			Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "SkateboardVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr);
			SkateboardVisuals.NativeFieldInfoPtr_MaxBoardLean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, "MaxBoardLean");
			SkateboardVisuals.NativeFieldInfoPtr_BoardLeanRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, "BoardLeanRate");
			SkateboardVisuals.NativeFieldInfoPtr_Board = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, "Board");
			SkateboardVisuals.NativeFieldInfoPtr_skateboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, "skateboard");
			SkateboardVisuals.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, 100667293);
			SkateboardVisuals.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, 100667294);
			SkateboardVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, 100667295);
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x000E0844 File Offset: 0x000DEA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112942, XrefRangeEnd = 112946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardVisuals.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x000E0878 File Offset: 0x000DEA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112946, XrefRangeEnd = 112951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardVisuals.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x000E08AC File Offset: 0x000DEAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112951, XrefRangeEnd = 112952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x000144DA File Offset: 0x000126DA
		public SkateboardVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x0600241C RID: 9244 RVA: 0x000E08E8 File Offset: 0x000DEAE8
		// (set) Token: 0x0600241D RID: 9245 RVA: 0x000144E3 File Offset: 0x000126E3
		public unsafe float MaxBoardLean
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_MaxBoardLean);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_MaxBoardLean)) = value;
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x0600241E RID: 9246 RVA: 0x000E0910 File Offset: 0x000DEB10
		// (set) Token: 0x0600241F RID: 9247 RVA: 0x000144FE File Offset: 0x000126FE
		public unsafe float BoardLeanRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_BoardLeanRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_BoardLeanRate)) = value;
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06002420 RID: 9248 RVA: 0x000E0938 File Offset: 0x000DEB38
		// (set) Token: 0x06002421 RID: 9249 RVA: 0x00014519 File Offset: 0x00012719
		public unsafe Transform Board
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_Board);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_Board), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06002422 RID: 9250 RVA: 0x000E0968 File Offset: 0x000DEB68
		// (set) Token: 0x06002423 RID: 9251 RVA: 0x00014538 File Offset: 0x00012738
		public unsafe Skateboard skateboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_skateboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_skateboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017E9 RID: 6121
		private static readonly IntPtr NativeFieldInfoPtr_MaxBoardLean;

		// Token: 0x040017EA RID: 6122
		private static readonly IntPtr NativeFieldInfoPtr_BoardLeanRate;

		// Token: 0x040017EB RID: 6123
		private static readonly IntPtr NativeFieldInfoPtr_Board;

		// Token: 0x040017EC RID: 6124
		private static readonly IntPtr NativeFieldInfoPtr_skateboard;

		// Token: 0x040017ED RID: 6125
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040017EE RID: 6126
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040017EF RID: 6127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
