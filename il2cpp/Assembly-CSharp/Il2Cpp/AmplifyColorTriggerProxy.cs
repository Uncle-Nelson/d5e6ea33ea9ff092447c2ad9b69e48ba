using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000005 RID: 5
	public class AmplifyColorTriggerProxy : AmplifyColorTriggerProxyBase
	{
		// Token: 0x060000DD RID: 221 RVA: 0x000737CC File Offset: 0x000719CC
		// Note: this type is marked as 'beforefieldinit'.
		static AmplifyColorTriggerProxy()
		{
			Il2CppClassPointerStore<AmplifyColorTriggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AmplifyColorTriggerProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmplifyColorTriggerProxy>.NativeClassPtr);
			AmplifyColorTriggerProxy.NativeFieldInfoPtr_sphereCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorTriggerProxy>.NativeClassPtr, "sphereCollider");
			AmplifyColorTriggerProxy.NativeFieldInfoPtr_rigidBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorTriggerProxy>.NativeClassPtr, "rigidBody");
			AmplifyColorTriggerProxy.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorTriggerProxy>.NativeClassPtr, 100663349);
			AmplifyColorTriggerProxy.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorTriggerProxy>.NativeClassPtr, 100663350);
			AmplifyColorTriggerProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorTriggerProxy>.NativeClassPtr, 100663351);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00073860 File Offset: 0x00071A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71229, XrefRangeEnd = 71242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorTriggerProxy.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00073894 File Offset: 0x00071A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71242, XrefRangeEnd = 71248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorTriggerProxy.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000738C8 File Offset: 0x00071AC8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmplifyColorTriggerProxy() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmplifyColorTriggerProxy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorTriggerProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002940 File Offset: 0x00000B40
		public AmplifyColorTriggerProxy(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00073904 File Offset: 0x00071B04
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00002949 File Offset: 0x00000B49
		public unsafe SphereCollider sphereCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorTriggerProxy.NativeFieldInfoPtr_sphereCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorTriggerProxy.NativeFieldInfoPtr_sphereCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00073934 File Offset: 0x00071B34
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00002968 File Offset: 0x00000B68
		public unsafe Rigidbody rigidBody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorTriggerProxy.NativeFieldInfoPtr_rigidBody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorTriggerProxy.NativeFieldInfoPtr_rigidBody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_sphereCollider;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_rigidBody;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
