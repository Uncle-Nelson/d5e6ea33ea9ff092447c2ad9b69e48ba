using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000DA RID: 218
	public class OrbitingBody : MonoBehaviour
	{
		// Token: 0x060011C2 RID: 4546 RVA: 0x000A8438 File Offset: 0x000A6638
		// Note: this type is marked as 'beforefieldinit'.
		static OrbitingBody()
		{
			Il2CppClassPointerStore<OrbitingBody>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "OrbitingBody");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrbitingBody>.NativeClassPtr);
			OrbitingBody.NativeFieldInfoPtr_m_PositionTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitingBody>.NativeClassPtr, "m_PositionTransform");
			OrbitingBody.NativeFieldInfoPtr_m_RotateBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitingBody>.NativeClassPtr, "m_RotateBody");
			OrbitingBody.NativeFieldInfoPtr_m_SpherePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitingBody>.NativeClassPtr, "m_SpherePoint");
			OrbitingBody.NativeFieldInfoPtr_m_CachedWorldDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitingBody>.NativeClassPtr, "m_CachedWorldDirection");
			OrbitingBody.NativeFieldInfoPtr_m_BodyLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitingBody>.NativeClassPtr, "m_BodyLight");
			OrbitingBody.NativeMethodInfoPtr_get_positionTransform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitingBody>.NativeClassPtr, 100665332);
			OrbitingBody.NativeMethodInfoPtr_get_rotateBody_Public_get_RotateBody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitingBody>.NativeClassPtr, 100665333);
			OrbitingBody.NativeMethodInfoPtr_get_Point_Public_get_SpherePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitingBody>.NativeClassPtr, 100665334);
			OrbitingBody.NativeMethodInfoPtr_set_Point_Public_set_Void_SpherePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitingBody>.NativeClassPtr, 100665335);
			OrbitingBody.NativeMethodInfoPtr_get_BodyGlobalDirection_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitingBody>.NativeClassPtr, 100665336);
			OrbitingBody.NativeMethodInfoPtr_get_BodyLight_Public_get_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitingBody>.NativeClassPtr, 100665337);
			OrbitingBody.NativeMethodInfoPtr_ResetOrbit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitingBody>.NativeClassPtr, 100665338);
			OrbitingBody.NativeMethodInfoPtr_LayoutOribit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitingBody>.NativeClassPtr, 100665339);
			OrbitingBody.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitingBody>.NativeClassPtr, 100665340);
			OrbitingBody.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitingBody>.NativeClassPtr, 100665341);
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x000A8594 File Offset: 0x000A6794
		public unsafe Transform positionTransform
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 88453, RefRangeEnd = 88462, XrefRangeStart = 88444, XrefRangeEnd = 88453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitingBody.NativeMethodInfoPtr_get_positionTransform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x000A85D4 File Offset: 0x000A67D4
		public unsafe RotateBody rotateBody
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 88476, RefRangeEnd = 88486, XrefRangeStart = 88462, XrefRangeEnd = 88476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitingBody.NativeMethodInfoPtr_get_rotateBody_Public_get_RotateBody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RotateBody>(intPtr3) : null;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060011C5 RID: 4549 RVA: 0x000A8614 File Offset: 0x000A6814
		// (set) Token: 0x060011C6 RID: 4550 RVA: 0x000A8654 File Offset: 0x000A6854
		public unsafe SpherePoint Point
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitingBody.NativeMethodInfoPtr_get_Point_Public_get_SpherePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpherePoint>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 88494, RefRangeEnd = 88496, XrefRangeStart = 88486, XrefRangeEnd = 88494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitingBody.NativeMethodInfoPtr_set_Point_Public_set_Void_SpherePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060011C7 RID: 4551 RVA: 0x000A8698 File Offset: 0x000A6898
		public unsafe Vector3 BodyGlobalDirection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitingBody.NativeMethodInfoPtr_get_BodyGlobalDirection_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x000A86D4 File Offset: 0x000A68D4
		public unsafe Light BodyLight
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 88512, RefRangeEnd = 88527, XrefRangeStart = 88496, XrefRangeEnd = 88512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitingBody.NativeMethodInfoPtr_get_BodyLight_Public_get_Light_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Light>(intPtr3) : null;
			}
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x000A8714 File Offset: 0x000A6914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88527, XrefRangeEnd = 88529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetOrbit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitingBody.NativeMethodInfoPtr_ResetOrbit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x000A8748 File Offset: 0x000A6948
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 88539, RefRangeEnd = 88542, XrefRangeStart = 88529, XrefRangeEnd = 88539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LayoutOribit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitingBody.NativeMethodInfoPtr_LayoutOribit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x000A877C File Offset: 0x000A697C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88542, XrefRangeEnd = 88543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitingBody.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x000A87B0 File Offset: 0x000A69B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88543, XrefRangeEnd = 88551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrbitingBody() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrbitingBody>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitingBody.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0000AD48 File Offset: 0x00008F48
		public OrbitingBody(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x000A87EC File Offset: 0x000A69EC
		// (set) Token: 0x060011CF RID: 4559 RVA: 0x0000AD51 File Offset: 0x00008F51
		public unsafe Transform m_PositionTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitingBody.NativeFieldInfoPtr_m_PositionTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitingBody.NativeFieldInfoPtr_m_PositionTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x000A881C File Offset: 0x000A6A1C
		// (set) Token: 0x060011D1 RID: 4561 RVA: 0x0000AD70 File Offset: 0x00008F70
		public unsafe RotateBody m_RotateBody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitingBody.NativeFieldInfoPtr_m_RotateBody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RotateBody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitingBody.NativeFieldInfoPtr_m_RotateBody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x000A884C File Offset: 0x000A6A4C
		// (set) Token: 0x060011D3 RID: 4563 RVA: 0x0000AD8F File Offset: 0x00008F8F
		public unsafe SpherePoint m_SpherePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitingBody.NativeFieldInfoPtr_m_SpherePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpherePoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitingBody.NativeFieldInfoPtr_m_SpherePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x000A887C File Offset: 0x000A6A7C
		// (set) Token: 0x060011D5 RID: 4565 RVA: 0x0000ADAE File Offset: 0x00008FAE
		public unsafe Vector3 m_CachedWorldDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitingBody.NativeFieldInfoPtr_m_CachedWorldDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitingBody.NativeFieldInfoPtr_m_CachedWorldDirection)) = value;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x000A88A4 File Offset: 0x000A6AA4
		// (set) Token: 0x060011D7 RID: 4567 RVA: 0x0000ADC9 File Offset: 0x00008FC9
		public unsafe Light m_BodyLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitingBody.NativeFieldInfoPtr_m_BodyLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitingBody.NativeFieldInfoPtr_m_BodyLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeFieldInfoPtr_m_PositionTransform;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeFieldInfoPtr_m_RotateBody;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeFieldInfoPtr_m_SpherePoint;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedWorldDirection;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeFieldInfoPtr_m_BodyLight;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeMethodInfoPtr_get_positionTransform_Public_get_Transform_0;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeMethodInfoPtr_get_rotateBody_Public_get_RotateBody_0;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeMethodInfoPtr_get_Point_Public_get_SpherePoint_0;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeMethodInfoPtr_set_Point_Public_set_Void_SpherePoint_0;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyGlobalDirection_Public_get_Vector3_0;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLight_Public_get_Light_0;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeMethodInfoPtr_ResetOrbit_Public_Void_0;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeMethodInfoPtr_LayoutOribit_Public_Void_0;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
