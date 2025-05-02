using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000492 RID: 1170
	[StructLayout(2)]
	public struct ExplosionData
	{
		// Token: 0x06006541 RID: 25921 RVA: 0x001C93AC File Offset: 0x001C75AC
		// Note: this type is marked as 'beforefieldinit'.
		static ExplosionData()
		{
			Il2CppClassPointerStore<ExplosionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "ExplosionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr);
			ExplosionData.NativeFieldInfoPtr_DamageRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "DamageRadius");
			ExplosionData.NativeFieldInfoPtr_MaxDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "MaxDamage");
			ExplosionData.NativeFieldInfoPtr_PushForceRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "PushForceRadius");
			ExplosionData.NativeFieldInfoPtr_MaxPushForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "MaxPushForce");
			ExplosionData.NativeFieldInfoPtr_DefaultSmall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "DefaultSmall");
			ExplosionData.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, 100676113);
		}

		// Token: 0x06006542 RID: 25922 RVA: 0x001C9454 File Offset: 0x001C7654
		[CallerCount(0)]
		public unsafe ExplosionData(float damageRadius, float maxDamage, float maxPushForce)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damageRadius;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDamage;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPushForce;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExplosionData.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006543 RID: 25923 RVA: 0x0002FE30 File Offset: 0x0002E030
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, ref this));
		}

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x06006544 RID: 25924 RVA: 0x001C94A4 File Offset: 0x001C76A4
		// (set) Token: 0x06006545 RID: 25925 RVA: 0x0002FE42 File Offset: 0x0002E042
		public unsafe static ExplosionData DefaultSmall
		{
			get
			{
				ExplosionData result;
				IL2CPP.il2cpp_field_static_get_value(ExplosionData.NativeFieldInfoPtr_DefaultSmall, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExplosionData.NativeFieldInfoPtr_DefaultSmall, (void*)(&value));
			}
		}

		// Token: 0x04004512 RID: 17682
		private static readonly IntPtr NativeFieldInfoPtr_DamageRadius;

		// Token: 0x04004513 RID: 17683
		private static readonly IntPtr NativeFieldInfoPtr_MaxDamage;

		// Token: 0x04004514 RID: 17684
		private static readonly IntPtr NativeFieldInfoPtr_PushForceRadius;

		// Token: 0x04004515 RID: 17685
		private static readonly IntPtr NativeFieldInfoPtr_MaxPushForce;

		// Token: 0x04004516 RID: 17686
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSmall;

		// Token: 0x04004517 RID: 17687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x04004518 RID: 17688
		[FieldOffset(0)]
		public float DamageRadius;

		// Token: 0x04004519 RID: 17689
		[FieldOffset(4)]
		public float MaxDamage;

		// Token: 0x0400451A RID: 17690
		[FieldOffset(8)]
		public float PushForceRadius;

		// Token: 0x0400451B RID: 17691
		[FieldOffset(12)]
		public float MaxPushForce;
	}
}
