using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000046 RID: 70
	public class ExampleWheelController : MonoBehaviour
	{
		// Token: 0x060005F0 RID: 1520 RVA: 0x000821C0 File Offset: 0x000803C0
		// Note: this type is marked as 'beforefieldinit'.
		static ExampleWheelController()
		{
			Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ExampleWheelController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr);
			ExampleWheelController.NativeFieldInfoPtr_acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr, "acceleration");
			ExampleWheelController.NativeFieldInfoPtr_motionVectorRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr, "motionVectorRenderer");
			ExampleWheelController.NativeFieldInfoPtr_m_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr, "m_Rigidbody");
			ExampleWheelController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr, 100663856);
			ExampleWheelController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr, 100663857);
			ExampleWheelController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr, 100663858);
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00082268 File Offset: 0x00080468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75739, XrefRangeEnd = 75745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExampleWheelController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0008229C File Offset: 0x0008049C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75745, XrefRangeEnd = 75760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExampleWheelController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x000822D0 File Offset: 0x000804D0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExampleWheelController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExampleWheelController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x000057EE File Offset: 0x000039EE
		public ExampleWheelController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0008230C File Offset: 0x0008050C
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x000057F7 File Offset: 0x000039F7
		public unsafe float acceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExampleWheelController.NativeFieldInfoPtr_acceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExampleWheelController.NativeFieldInfoPtr_acceleration)) = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00082334 File Offset: 0x00080534
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00005812 File Offset: 0x00003A12
		public unsafe Renderer motionVectorRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExampleWheelController.NativeFieldInfoPtr_motionVectorRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExampleWheelController.NativeFieldInfoPtr_motionVectorRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00082364 File Offset: 0x00080564
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00005831 File Offset: 0x00003A31
		public unsafe Rigidbody m_Rigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExampleWheelController.NativeFieldInfoPtr_m_Rigidbody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExampleWheelController.NativeFieldInfoPtr_m_Rigidbody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeFieldInfoPtr_acceleration;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeFieldInfoPtr_motionVectorRenderer;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeFieldInfoPtr_m_Rigidbody;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007C2 RID: 1986
		public static class Uniforms : Il2CppSystem.Object
		{
			// Token: 0x0600BACA RID: 47818 RVA: 0x0005B68F File Offset: 0x0005988F
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<ExampleWheelController.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExampleWheelController.Uniforms>.NativeClassPtr);
				ExampleWheelController.Uniforms.NativeFieldInfoPtr__MotionAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExampleWheelController.Uniforms>.NativeClassPtr, "_MotionAmount");
			}

			// Token: 0x0600BACB RID: 47819 RVA: 0x0005B6C3 File Offset: 0x000598C3
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039B0 RID: 14768
			// (get) Token: 0x0600BACC RID: 47820 RVA: 0x002E4970 File Offset: 0x002E2B70
			// (set) Token: 0x0600BACD RID: 47821 RVA: 0x0005B6CC File Offset: 0x000598CC
			public unsafe static int _MotionAmount
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ExampleWheelController.Uniforms.NativeFieldInfoPtr__MotionAmount, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExampleWheelController.Uniforms.NativeFieldInfoPtr__MotionAmount, (void*)(&value));
				}
			}

			// Token: 0x04007DFD RID: 32253
			private static readonly IntPtr NativeFieldInfoPtr__MotionAmount;
		}
	}
}
