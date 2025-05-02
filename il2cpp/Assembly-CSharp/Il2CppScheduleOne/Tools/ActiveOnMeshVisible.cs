using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200052C RID: 1324
	public class ActiveOnMeshVisible : MonoBehaviour
	{
		// Token: 0x06007651 RID: 30289 RVA: 0x00202DC8 File Offset: 0x00200FC8
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveOnMeshVisible()
		{
			Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ActiveOnMeshVisible");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr);
			ActiveOnMeshVisible.NativeFieldInfoPtr_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, "Mesh");
			ActiveOnMeshVisible.NativeFieldInfoPtr_ObjectsToActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, "ObjectsToActivate");
			ActiveOnMeshVisible.NativeFieldInfoPtr_Reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, "Reverse");
			ActiveOnMeshVisible.NativeFieldInfoPtr_isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, "isVisible");
			ActiveOnMeshVisible.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, 100678200);
			ActiveOnMeshVisible.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, 100678201);
		}

		// Token: 0x06007652 RID: 30290 RVA: 0x00202E70 File Offset: 0x00201070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230918, XrefRangeEnd = 230924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveOnMeshVisible.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007653 RID: 30291 RVA: 0x00202EA4 File Offset: 0x002010A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230924, XrefRangeEnd = 230925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveOnMeshVisible() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveOnMeshVisible.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007654 RID: 30292 RVA: 0x0003811D File Offset: 0x0003631D
		public ActiveOnMeshVisible(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023D4 RID: 9172
		// (get) Token: 0x06007655 RID: 30293 RVA: 0x00202EE0 File Offset: 0x002010E0
		// (set) Token: 0x06007656 RID: 30294 RVA: 0x00038126 File Offset: 0x00036326
		public unsafe MeshRenderer Mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_Mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D5 RID: 9173
		// (get) Token: 0x06007657 RID: 30295 RVA: 0x00202F10 File Offset: 0x00201110
		// (set) Token: 0x06007658 RID: 30296 RVA: 0x00038145 File Offset: 0x00036345
		public unsafe Il2CppReferenceArray<GameObject> ObjectsToActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_ObjectsToActivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_ObjectsToActivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D6 RID: 9174
		// (get) Token: 0x06007659 RID: 30297 RVA: 0x00202F40 File Offset: 0x00201140
		// (set) Token: 0x0600765A RID: 30298 RVA: 0x00038164 File Offset: 0x00036364
		public unsafe bool Reverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_Reverse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_Reverse)) = value;
			}
		}

		// Token: 0x170023D7 RID: 9175
		// (get) Token: 0x0600765B RID: 30299 RVA: 0x00202F68 File Offset: 0x00201168
		// (set) Token: 0x0600765C RID: 30300 RVA: 0x0003817F File Offset: 0x0003637F
		public unsafe bool isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_isVisible)) = value;
			}
		}

		// Token: 0x040050D7 RID: 20695
		private static readonly IntPtr NativeFieldInfoPtr_Mesh;

		// Token: 0x040050D8 RID: 20696
		private static readonly IntPtr NativeFieldInfoPtr_ObjectsToActivate;

		// Token: 0x040050D9 RID: 20697
		private static readonly IntPtr NativeFieldInfoPtr_Reverse;

		// Token: 0x040050DA RID: 20698
		private static readonly IntPtr NativeFieldInfoPtr_isVisible;

		// Token: 0x040050DB RID: 20699
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040050DC RID: 20700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
