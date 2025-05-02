using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000520 RID: 1312
	public class TrashContainerContents : MonoBehaviour
	{
		// Token: 0x060074D8 RID: 29912 RVA: 0x001FD244 File Offset: 0x001FB444
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContainerContents()
		{
			Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashContainerContents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr);
			TrashContainerContents.NativeFieldInfoPtr_TrashContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, "TrashContainer");
			TrashContainerContents.NativeFieldInfoPtr_ContentsTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, "ContentsTransform");
			TrashContainerContents.NativeFieldInfoPtr_VisualsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, "VisualsContainer");
			TrashContainerContents.NativeFieldInfoPtr_VisualsMinTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, "VisualsMinTransform");
			TrashContainerContents.NativeFieldInfoPtr_VisualsMaxTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, "VisualsMaxTransform");
			TrashContainerContents.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, "Collider");
			TrashContainerContents.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, 100677988);
			TrashContainerContents.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, 100677989);
			TrashContainerContents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, 100677990);
		}

		// Token: 0x060074D9 RID: 29913 RVA: 0x001FD328 File Offset: 0x001FB528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228366, XrefRangeEnd = 228375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerContents.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074DA RID: 29914 RVA: 0x001FD35C File Offset: 0x001FB55C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228393, RefRangeEnd = 228394, XrefRangeStart = 228375, XrefRangeEnd = 228393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerContents.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074DB RID: 29915 RVA: 0x001FD390 File Offset: 0x001FB590
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainerContents() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerContents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074DC RID: 29916 RVA: 0x00037720 File Offset: 0x00035920
		public TrashContainerContents(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002364 RID: 9060
		// (get) Token: 0x060074DD RID: 29917 RVA: 0x001FD3CC File Offset: 0x001FB5CC
		// (set) Token: 0x060074DE RID: 29918 RVA: 0x00037729 File Offset: 0x00035929
		public unsafe TrashContainer TrashContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_TrashContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_TrashContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002365 RID: 9061
		// (get) Token: 0x060074DF RID: 29919 RVA: 0x001FD3FC File Offset: 0x001FB5FC
		// (set) Token: 0x060074E0 RID: 29920 RVA: 0x00037748 File Offset: 0x00035948
		public unsafe Transform ContentsTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_ContentsTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_ContentsTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002366 RID: 9062
		// (get) Token: 0x060074E1 RID: 29921 RVA: 0x001FD42C File Offset: 0x001FB62C
		// (set) Token: 0x060074E2 RID: 29922 RVA: 0x00037767 File Offset: 0x00035967
		public unsafe Transform VisualsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_VisualsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_VisualsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002367 RID: 9063
		// (get) Token: 0x060074E3 RID: 29923 RVA: 0x001FD45C File Offset: 0x001FB65C
		// (set) Token: 0x060074E4 RID: 29924 RVA: 0x00037786 File Offset: 0x00035986
		public unsafe Transform VisualsMinTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_VisualsMinTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_VisualsMinTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002368 RID: 9064
		// (get) Token: 0x060074E5 RID: 29925 RVA: 0x001FD48C File Offset: 0x001FB68C
		// (set) Token: 0x060074E6 RID: 29926 RVA: 0x000377A5 File Offset: 0x000359A5
		public unsafe Transform VisualsMaxTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_VisualsMaxTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_VisualsMaxTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002369 RID: 9065
		// (get) Token: 0x060074E7 RID: 29927 RVA: 0x001FD4BC File Offset: 0x001FB6BC
		// (set) Token: 0x060074E8 RID: 29928 RVA: 0x000377C4 File Offset: 0x000359C4
		public unsafe Collider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004FCC RID: 20428
		private static readonly IntPtr NativeFieldInfoPtr_TrashContainer;

		// Token: 0x04004FCD RID: 20429
		private static readonly IntPtr NativeFieldInfoPtr_ContentsTransform;

		// Token: 0x04004FCE RID: 20430
		private static readonly IntPtr NativeFieldInfoPtr_VisualsContainer;

		// Token: 0x04004FCF RID: 20431
		private static readonly IntPtr NativeFieldInfoPtr_VisualsMinTransform;

		// Token: 0x04004FD0 RID: 20432
		private static readonly IntPtr NativeFieldInfoPtr_VisualsMaxTransform;

		// Token: 0x04004FD1 RID: 20433
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04004FD2 RID: 20434
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x04004FD3 RID: 20435
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisuals_Private_Void_0;

		// Token: 0x04004FD4 RID: 20436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
