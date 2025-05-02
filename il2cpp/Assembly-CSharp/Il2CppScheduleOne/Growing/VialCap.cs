using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000557 RID: 1367
	public class VialCap : Clickable
	{
		// Token: 0x06007853 RID: 30803 RVA: 0x00208964 File Offset: 0x00206B64
		// Note: this type is marked as 'beforefieldinit'.
		static VialCap()
		{
			Il2CppClassPointerStore<VialCap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "VialCap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VialCap>.NativeClassPtr);
			VialCap.NativeFieldInfoPtr__Removed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VialCap>.NativeClassPtr, "<Removed>k__BackingField");
			VialCap.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VialCap>.NativeClassPtr, "Collider");
			VialCap.NativeFieldInfoPtr_RigidBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VialCap>.NativeClassPtr, "RigidBody");
			VialCap.NativeMethodInfoPtr_get_Removed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678409);
			VialCap.NativeMethodInfoPtr_set_Removed_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678410);
			VialCap.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678411);
			VialCap.NativeMethodInfoPtr_Pop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678412);
			VialCap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678413);
		}

		// Token: 0x17002461 RID: 9313
		// (get) Token: 0x06007854 RID: 30804 RVA: 0x00208A34 File Offset: 0x00206C34
		// (set) Token: 0x06007855 RID: 30805 RVA: 0x00208A70 File Offset: 0x00206C70
		public unsafe bool Removed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VialCap.NativeMethodInfoPtr_get_Removed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VialCap.NativeMethodInfoPtr_set_Removed_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007856 RID: 30806 RVA: 0x00208AB0 File Offset: 0x00206CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232539, XrefRangeEnd = 232541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VialCap.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007857 RID: 30807 RVA: 0x00208AFC File Offset: 0x00206CFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232567, RefRangeEnd = 232568, XrefRangeStart = 232541, XrefRangeEnd = 232567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VialCap.NativeMethodInfoPtr_Pop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007858 RID: 30808 RVA: 0x00208B30 File Offset: 0x00206D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232568, XrefRangeEnd = 232569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VialCap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VialCap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VialCap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007859 RID: 30809 RVA: 0x000390F9 File Offset: 0x000372F9
		public VialCap(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700245E RID: 9310
		// (get) Token: 0x0600785A RID: 30810 RVA: 0x00208B6C File Offset: 0x00206D6C
		// (set) Token: 0x0600785B RID: 30811 RVA: 0x00039102 File Offset: 0x00037302
		public unsafe bool _Removed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr__Removed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr__Removed_k__BackingField)) = value;
			}
		}

		// Token: 0x1700245F RID: 9311
		// (get) Token: 0x0600785C RID: 30812 RVA: 0x00208B94 File Offset: 0x00206D94
		// (set) Token: 0x0600785D RID: 30813 RVA: 0x0003911D File Offset: 0x0003731D
		public unsafe Collider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002460 RID: 9312
		// (get) Token: 0x0600785E RID: 30814 RVA: 0x00208BC4 File Offset: 0x00206DC4
		// (set) Token: 0x0600785F RID: 30815 RVA: 0x0003913C File Offset: 0x0003733C
		public unsafe Rigidbody RigidBody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr_RigidBody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr_RigidBody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005201 RID: 20993
		private static readonly IntPtr NativeFieldInfoPtr__Removed_k__BackingField;

		// Token: 0x04005202 RID: 20994
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04005203 RID: 20995
		private static readonly IntPtr NativeFieldInfoPtr_RigidBody;

		// Token: 0x04005204 RID: 20996
		private static readonly IntPtr NativeMethodInfoPtr_get_Removed_Public_get_Boolean_0;

		// Token: 0x04005205 RID: 20997
		private static readonly IntPtr NativeMethodInfoPtr_set_Removed_Protected_set_Void_Boolean_0;

		// Token: 0x04005206 RID: 20998
		private static readonly IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0;

		// Token: 0x04005207 RID: 20999
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_Void_0;

		// Token: 0x04005208 RID: 21000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
