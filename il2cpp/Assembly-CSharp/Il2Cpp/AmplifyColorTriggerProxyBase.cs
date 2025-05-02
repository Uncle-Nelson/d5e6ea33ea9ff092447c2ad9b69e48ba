using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000007 RID: 7
	public class AmplifyColorTriggerProxyBase : MonoBehaviour
	{
		// Token: 0x060000EF RID: 239 RVA: 0x00073AFC File Offset: 0x00071CFC
		// Note: this type is marked as 'beforefieldinit'.
		static AmplifyColorTriggerProxyBase()
		{
			Il2CppClassPointerStore<AmplifyColorTriggerProxyBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AmplifyColorTriggerProxyBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmplifyColorTriggerProxyBase>.NativeClassPtr);
			AmplifyColorTriggerProxyBase.NativeFieldInfoPtr_Reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorTriggerProxyBase>.NativeClassPtr, "Reference");
			AmplifyColorTriggerProxyBase.NativeFieldInfoPtr_OwnerEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorTriggerProxyBase>.NativeClassPtr, "OwnerEffect");
			AmplifyColorTriggerProxyBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorTriggerProxyBase>.NativeClassPtr, 100663355);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00073B68 File Offset: 0x00071D68
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmplifyColorTriggerProxyBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmplifyColorTriggerProxyBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorTriggerProxyBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000029CE File Offset: 0x00000BCE
		public AmplifyColorTriggerProxyBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00073BA4 File Offset: 0x00071DA4
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x000029D7 File Offset: 0x00000BD7
		public unsafe Transform Reference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorTriggerProxyBase.NativeFieldInfoPtr_Reference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorTriggerProxyBase.NativeFieldInfoPtr_Reference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00073BD4 File Offset: 0x00071DD4
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x000029F6 File Offset: 0x00000BF6
		public unsafe AmplifyColorEffect OwnerEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorTriggerProxyBase.NativeFieldInfoPtr_OwnerEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmplifyColorEffect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorTriggerProxyBase.NativeFieldInfoPtr_OwnerEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_Reference;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_OwnerEffect;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
