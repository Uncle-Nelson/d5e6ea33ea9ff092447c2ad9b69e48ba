using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Decoration
{
	// Token: 0x02000767 RID: 1895
	public class RockerSwitch : MonoBehaviour
	{
		// Token: 0x0600B3F1 RID: 46065 RVA: 0x002CD808 File Offset: 0x002CBA08
		// Note: this type is marked as 'beforefieldinit'.
		static RockerSwitch()
		{
			Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Decoration", "RockerSwitch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr);
			RockerSwitch.NativeFieldInfoPtr_ButtonMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, "ButtonMesh");
			RockerSwitch.NativeFieldInfoPtr_ButtonTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, "ButtonTransform");
			RockerSwitch.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, "Light");
			RockerSwitch.NativeFieldInfoPtr_isOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, "isOn");
			RockerSwitch.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, 100685469);
			RockerSwitch.NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, 100685470);
			RockerSwitch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, 100685471);
		}

		// Token: 0x0600B3F2 RID: 46066 RVA: 0x002CD8C4 File Offset: 0x002CBAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309168, XrefRangeEnd = 309169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockerSwitch.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3F3 RID: 46067 RVA: 0x002CD8F8 File Offset: 0x002CBAF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309172, RefRangeEnd = 309174, XrefRangeStart = 309169, XrefRangeEnd = 309172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOn(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockerSwitch.NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3F4 RID: 46068 RVA: 0x002CD938 File Offset: 0x002CBB38
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RockerSwitch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockerSwitch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3F5 RID: 46069 RVA: 0x0005833D File Offset: 0x0005653D
		public RockerSwitch(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037C8 RID: 14280
		// (get) Token: 0x0600B3F6 RID: 46070 RVA: 0x002CD974 File Offset: 0x002CBB74
		// (set) Token: 0x0600B3F7 RID: 46071 RVA: 0x00058346 File Offset: 0x00056546
		public unsafe MeshRenderer ButtonMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_ButtonMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_ButtonMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037C9 RID: 14281
		// (get) Token: 0x0600B3F8 RID: 46072 RVA: 0x002CD9A4 File Offset: 0x002CBBA4
		// (set) Token: 0x0600B3F9 RID: 46073 RVA: 0x00058365 File Offset: 0x00056565
		public unsafe Transform ButtonTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_ButtonTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_ButtonTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037CA RID: 14282
		// (get) Token: 0x0600B3FA RID: 46074 RVA: 0x002CD9D4 File Offset: 0x002CBBD4
		// (set) Token: 0x0600B3FB RID: 46075 RVA: 0x00058384 File Offset: 0x00056584
		public unsafe Light Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037CB RID: 14283
		// (get) Token: 0x0600B3FC RID: 46076 RVA: 0x002CDA04 File Offset: 0x002CBC04
		// (set) Token: 0x0600B3FD RID: 46077 RVA: 0x000583A3 File Offset: 0x000565A3
		public unsafe bool isOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_isOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_isOn)) = value;
			}
		}

		// Token: 0x04007958 RID: 31064
		private static readonly IntPtr NativeFieldInfoPtr_ButtonMesh;

		// Token: 0x04007959 RID: 31065
		private static readonly IntPtr NativeFieldInfoPtr_ButtonTransform;

		// Token: 0x0400795A RID: 31066
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x0400795B RID: 31067
		private static readonly IntPtr NativeFieldInfoPtr_isOn;

		// Token: 0x0400795C RID: 31068
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400795D RID: 31069
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0;

		// Token: 0x0400795E RID: 31070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
