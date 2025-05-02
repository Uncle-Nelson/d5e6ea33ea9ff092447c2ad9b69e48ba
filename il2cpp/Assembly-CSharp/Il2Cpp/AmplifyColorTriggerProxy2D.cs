using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000006 RID: 6
	public class AmplifyColorTriggerProxy2D : AmplifyColorTriggerProxyBase
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x00073964 File Offset: 0x00071B64
		// Note: this type is marked as 'beforefieldinit'.
		static AmplifyColorTriggerProxy2D()
		{
			Il2CppClassPointerStore<AmplifyColorTriggerProxy2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AmplifyColorTriggerProxy2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmplifyColorTriggerProxy2D>.NativeClassPtr);
			AmplifyColorTriggerProxy2D.NativeFieldInfoPtr_circleCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorTriggerProxy2D>.NativeClassPtr, "circleCollider");
			AmplifyColorTriggerProxy2D.NativeFieldInfoPtr_rigidBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorTriggerProxy2D>.NativeClassPtr, "rigidBody");
			AmplifyColorTriggerProxy2D.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorTriggerProxy2D>.NativeClassPtr, 100663352);
			AmplifyColorTriggerProxy2D.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorTriggerProxy2D>.NativeClassPtr, 100663353);
			AmplifyColorTriggerProxy2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorTriggerProxy2D>.NativeClassPtr, 100663354);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000739F8 File Offset: 0x00071BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71248, XrefRangeEnd = 71261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorTriggerProxy2D.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00073A2C File Offset: 0x00071C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorTriggerProxy2D.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00073A60 File Offset: 0x00071C60
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmplifyColorTriggerProxy2D() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmplifyColorTriggerProxy2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorTriggerProxy2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002987 File Offset: 0x00000B87
		public AmplifyColorTriggerProxy2D(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00073A9C File Offset: 0x00071C9C
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00002990 File Offset: 0x00000B90
		public unsafe CircleCollider2D circleCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorTriggerProxy2D.NativeFieldInfoPtr_circleCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorTriggerProxy2D.NativeFieldInfoPtr_circleCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00073ACC File Offset: 0x00071CCC
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000029AF File Offset: 0x00000BAF
		public unsafe Rigidbody2D rigidBody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorTriggerProxy2D.NativeFieldInfoPtr_rigidBody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorTriggerProxy2D.NativeFieldInfoPtr_rigidBody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_circleCollider;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_rigidBody;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
