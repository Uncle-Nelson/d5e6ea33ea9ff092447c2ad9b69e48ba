using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000121 RID: 289
	[Serializable]
	public class SpherePoint : Il2CppSystem.Object
	{
		// Token: 0x0600189E RID: 6302 RVA: 0x000BD428 File Offset: 0x000BB628
		// Note: this type is marked as 'beforefieldinit'.
		static SpherePoint()
		{
			Il2CppClassPointerStore<SpherePoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SpherePoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr);
			SpherePoint.NativeFieldInfoPtr_horizontalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, "horizontalRotation");
			SpherePoint.NativeFieldInfoPtr_verticalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, "verticalRotation");
			SpherePoint.NativeFieldInfoPtr_MinHorizontalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, "MinHorizontalRotation");
			SpherePoint.NativeFieldInfoPtr_MaxHorizontalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, "MaxHorizontalRotation");
			SpherePoint.NativeFieldInfoPtr_MinVerticalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, "MinVerticalRotation");
			SpherePoint.NativeFieldInfoPtr_MaxVerticalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, "MaxVerticalRotation");
			SpherePoint.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, 100665913);
			SpherePoint.NativeMethodInfoPtr__ctor_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, 100665914);
			SpherePoint.NativeMethodInfoPtr_SetFromWorldDirection_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, 100665915);
			SpherePoint.NativeMethodInfoPtr_GetWorldDirection_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr, 100665916);
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x000BD520 File Offset: 0x000BB720
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 95687, RefRangeEnd = 95694, XrefRangeStart = 95686, XrefRangeEnd = 95687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePoint(float horizontalRotation, float verticalRotation) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref horizontalRotation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref verticalRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePoint.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x000BD578 File Offset: 0x000BB778
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 95696, RefRangeEnd = 95699, XrefRangeStart = 95694, XrefRangeEnd = 95696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePoint(Vector3 worldDirection) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpherePoint>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePoint.NativeMethodInfoPtr__ctor_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x000BD5C0 File Offset: 0x000BB7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95699, XrefRangeEnd = 95700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFromWorldDirection(Vector3 worldDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePoint.NativeMethodInfoPtr_SetFromWorldDirection_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x000BD600 File Offset: 0x000BB800
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 95704, RefRangeEnd = 95711, XrefRangeStart = 95700, XrefRangeEnd = 95704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetWorldDirection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePoint.NativeMethodInfoPtr_GetWorldDirection_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0000E25F File Offset: 0x0000C45F
		public SpherePoint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x060018A4 RID: 6308 RVA: 0x000BD63C File Offset: 0x000BB83C
		// (set) Token: 0x060018A5 RID: 6309 RVA: 0x0000E268 File Offset: 0x0000C468
		public unsafe float horizontalRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpherePoint.NativeFieldInfoPtr_horizontalRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpherePoint.NativeFieldInfoPtr_horizontalRotation)) = value;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x060018A6 RID: 6310 RVA: 0x000BD664 File Offset: 0x000BB864
		// (set) Token: 0x060018A7 RID: 6311 RVA: 0x0000E283 File Offset: 0x0000C483
		public unsafe float verticalRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpherePoint.NativeFieldInfoPtr_verticalRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpherePoint.NativeFieldInfoPtr_verticalRotation)) = value;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x000BD68C File Offset: 0x000BB88C
		// (set) Token: 0x060018A9 RID: 6313 RVA: 0x0000E29E File Offset: 0x0000C49E
		public unsafe static float MinHorizontalRotation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpherePoint.NativeFieldInfoPtr_MinHorizontalRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpherePoint.NativeFieldInfoPtr_MinHorizontalRotation, (void*)(&value));
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x000BD6A8 File Offset: 0x000BB8A8
		// (set) Token: 0x060018AB RID: 6315 RVA: 0x0000E2AC File Offset: 0x0000C4AC
		public unsafe static float MaxHorizontalRotation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpherePoint.NativeFieldInfoPtr_MaxHorizontalRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpherePoint.NativeFieldInfoPtr_MaxHorizontalRotation, (void*)(&value));
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x000BD6C4 File Offset: 0x000BB8C4
		// (set) Token: 0x060018AD RID: 6317 RVA: 0x0000E2BA File Offset: 0x0000C4BA
		public unsafe static float MinVerticalRotation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpherePoint.NativeFieldInfoPtr_MinVerticalRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpherePoint.NativeFieldInfoPtr_MinVerticalRotation, (void*)(&value));
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x000BD6E0 File Offset: 0x000BB8E0
		// (set) Token: 0x060018AF RID: 6319 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
		public unsafe static float MaxVerticalRotation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpherePoint.NativeFieldInfoPtr_MaxVerticalRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpherePoint.NativeFieldInfoPtr_MaxVerticalRotation, (void*)(&value));
			}
		}

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeFieldInfoPtr_horizontalRotation;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeFieldInfoPtr_verticalRotation;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeFieldInfoPtr_MinHorizontalRotation;

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeFieldInfoPtr_MaxHorizontalRotation;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeFieldInfoPtr_MinVerticalRotation;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeFieldInfoPtr_MaxVerticalRotation;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_0;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeMethodInfoPtr_SetFromWorldDirection_Public_Void_Vector3_0;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldDirection_Public_Vector3_0;
	}
}
