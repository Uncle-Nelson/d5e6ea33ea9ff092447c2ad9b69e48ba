using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000041 RID: 65
	public class Interpolate : Il2CppSystem.Object
	{
		// Token: 0x0600055B RID: 1371 RVA: 0x0007FC70 File Offset: 0x0007DE70
		// Note: this type is marked as 'beforefieldinit'.
		static Interpolate()
		{
			Il2CppClassPointerStore<Interpolate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Interpolate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interpolate>.NativeClassPtr);
			Interpolate.NativeMethodInfoPtr_Identity_Private_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663742);
			Interpolate.NativeMethodInfoPtr_TransformDotPosition_Private_Static_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663743);
			Interpolate.NativeMethodInfoPtr_NewTimer_Private_Static_IEnumerable_1_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663744);
			Interpolate.NativeMethodInfoPtr_NewCounter_Private_Static_IEnumerable_1_Single_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663745);
			Interpolate.NativeMethodInfoPtr_NewEase_Public_Static_IEnumerator_Function_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663746);
			Interpolate.NativeMethodInfoPtr_NewEase_Public_Static_IEnumerator_Function_Vector3_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663747);
			Interpolate.NativeMethodInfoPtr_NewEase_Private_Static_IEnumerator_Function_Vector3_Vector3_Single_IEnumerable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663748);
			Interpolate.NativeMethodInfoPtr_Ease_Private_Static_Vector3_Function_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663749);
			Interpolate.NativeMethodInfoPtr_Ease_Public_Static_Function_EaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663750);
			Interpolate.NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppReferenceArray_1_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663751);
			Interpolate.NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppReferenceArray_1_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663752);
			Interpolate.NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663753);
			Interpolate.NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppStructArray_1_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663754);
			Interpolate.NativeMethodInfoPtr_NewBezier_Private_Static_IEnumerable_1_Vector3_Function_IList_ToVector3_1_T_Single_IEnumerable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663755);
			Interpolate.NativeMethodInfoPtr_Bezier_Private_Static_Vector3_Function_Il2CppStructArray_1_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663756);
			Interpolate.NativeMethodInfoPtr_NewCatmullRom_Public_Static_IEnumerable_1_Vector3_Il2CppReferenceArray_1_Transform_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663757);
			Interpolate.NativeMethodInfoPtr_NewCatmullRom_Public_Static_IEnumerable_1_Vector3_Il2CppStructArray_1_Vector3_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663758);
			Interpolate.NativeMethodInfoPtr_NewCatmullRom_Private_Static_IEnumerable_1_Vector3_IList_ToVector3_1_T_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663759);
			Interpolate.NativeMethodInfoPtr_CatmullRom_Private_Static_Vector3_Vector3_Vector3_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663760);
			Interpolate.NativeMethodInfoPtr_Linear_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663761);
			Interpolate.NativeMethodInfoPtr_EaseInQuad_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663762);
			Interpolate.NativeMethodInfoPtr_EaseOutQuad_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663763);
			Interpolate.NativeMethodInfoPtr_EaseInOutQuad_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663764);
			Interpolate.NativeMethodInfoPtr_EaseInCubic_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663765);
			Interpolate.NativeMethodInfoPtr_EaseOutCubic_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663766);
			Interpolate.NativeMethodInfoPtr_EaseInOutCubic_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663767);
			Interpolate.NativeMethodInfoPtr_EaseInQuart_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663768);
			Interpolate.NativeMethodInfoPtr_EaseOutQuart_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663769);
			Interpolate.NativeMethodInfoPtr_EaseInOutQuart_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663770);
			Interpolate.NativeMethodInfoPtr_EaseInQuint_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663771);
			Interpolate.NativeMethodInfoPtr_EaseOutQuint_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663772);
			Interpolate.NativeMethodInfoPtr_EaseInOutQuint_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663773);
			Interpolate.NativeMethodInfoPtr_EaseInSine_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663774);
			Interpolate.NativeMethodInfoPtr_EaseOutSine_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663775);
			Interpolate.NativeMethodInfoPtr_EaseInOutSine_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663776);
			Interpolate.NativeMethodInfoPtr_EaseInExpo_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663777);
			Interpolate.NativeMethodInfoPtr_EaseOutExpo_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663778);
			Interpolate.NativeMethodInfoPtr_EaseInOutExpo_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663779);
			Interpolate.NativeMethodInfoPtr_EaseInCirc_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663780);
			Interpolate.NativeMethodInfoPtr_EaseOutCirc_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663781);
			Interpolate.NativeMethodInfoPtr_EaseInOutCirc_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663782);
			Interpolate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663783);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0007FFE8 File Offset: 0x0007E1E8
		[CallerCount(0)]
		public unsafe static Vector3 Identity(Vector3 v)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_Identity_Private_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00080028 File Offset: 0x0007E228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75046, XrefRangeEnd = 75047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 TransformDotPosition(Transform t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_TransformDotPosition_Private_Static_Vector3_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0008006C File Offset: 0x0007E26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75047, XrefRangeEnd = 75052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<float> NewTimer(float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewTimer_Private_Static_IEnumerable_1_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<float>>(intPtr3) : null;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x000800AC File Offset: 0x0007E2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75052, XrefRangeEnd = 75057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<float> NewCounter(int start, int end, int step)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewCounter_Private_Static_IEnumerable_1_Single_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<float>>(intPtr3) : null;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00080108 File Offset: 0x0007E308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75057, XrefRangeEnd = 75068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator NewEase(Interpolate.Function ease, Vector3 start, Vector3 end, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewEase_Public_Static_IEnumerator_Function_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00080178 File Offset: 0x0007E378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75068, XrefRangeEnd = 75079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator NewEase(Interpolate.Function ease, Vector3 start, Vector3 end, int slices)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slices;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewEase_Public_Static_IEnumerator_Function_Vector3_Vector3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x000801E8 File Offset: 0x0007E3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75079, XrefRangeEnd = 75085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator NewEase(Interpolate.Function ease, Vector3 start, Vector3 end, float total, IEnumerable<float> driver)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref total;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(driver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewEase_Private_Static_IEnumerator_Function_Vector3_Vector3_Single_IEnumerable_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0008026C File Offset: 0x0007E46C
		[CallerCount(0)]
		public unsafe static Vector3 Ease(Interpolate.Function ease, Vector3 start, Vector3 distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_Ease_Private_Static_Vector3_Function_Vector3_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000802E8 File Offset: 0x0007E4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75085, XrefRangeEnd = 75196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Interpolate.Function Ease(Interpolate.EaseType type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_Ease_Public_Static_Function_EaseType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Interpolate.Function>(intPtr3) : null;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00080328 File Offset: 0x0007E528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75196, XrefRangeEnd = 75210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Il2CppReferenceArray<Transform> nodes, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppReferenceArray_1_Transform_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0008038C File Offset: 0x0007E58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75210, XrefRangeEnd = 75224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Il2CppReferenceArray<Transform> nodes, int slices)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slices;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppReferenceArray_1_Transform_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000803F0 File Offset: 0x0007E5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75224, XrefRangeEnd = 75238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Il2CppStructArray<Vector3> points, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppStructArray_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00080454 File Offset: 0x0007E654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75238, XrefRangeEnd = 75252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Il2CppStructArray<Vector3> points, int slices)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slices;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppStructArray_1_Vector3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000804B8 File Offset: 0x0007E6B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 75260, RefRangeEnd = 75264, XrefRangeStart = 75252, XrefRangeEnd = 75260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Vector3> NewBezier<T>(Interpolate.Function ease, IList nodes, Interpolate.ToVector3<T> toVector3, float maxStep, IEnumerable<float> steps)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toVector3);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxStep;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(steps);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.MethodInfoStoreGeneric_NewBezier_Private_Static_IEnumerable_1_Vector3_Function_IList_ToVector3_1_T_Single_IEnumerable_1_Single_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00080544 File Offset: 0x0007E744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75264, RefRangeEnd = 75265, XrefRangeStart = 75264, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Bezier(Interpolate.Function ease, Il2CppStructArray<Vector3> points, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_Bezier_Private_Static_Vector3_Function_Il2CppStructArray_1_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x000805B4 File Offset: 0x0007E7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75265, XrefRangeEnd = 75274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Vector3> NewCatmullRom(Il2CppReferenceArray<Transform> nodes, int slices, bool loop)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slices;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewCatmullRom_Public_Static_IEnumerable_1_Vector3_Il2CppReferenceArray_1_Transform_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00080614 File Offset: 0x0007E814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75283, RefRangeEnd = 75285, XrefRangeStart = 75274, XrefRangeEnd = 75283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Vector3> NewCatmullRom(Il2CppStructArray<Vector3> points, int slices, bool loop)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slices;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewCatmullRom_Public_Static_IEnumerable_1_Vector3_Il2CppStructArray_1_Vector3_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00080674 File Offset: 0x0007E874
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75291, RefRangeEnd = 75293, XrefRangeStart = 75285, XrefRangeEnd = 75291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Vector3> NewCatmullRom<T>(IList nodes, Interpolate.ToVector3<T> toVector3, int slices, bool loop)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toVector3);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slices;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.MethodInfoStoreGeneric_NewCatmullRom_Private_Static_IEnumerable_1_Vector3_IList_ToVector3_1_T_Int32_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000806E8 File Offset: 0x0007E8E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75293, RefRangeEnd = 75294, XrefRangeStart = 75293, XrefRangeEnd = 75293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 CatmullRom(Vector3 previous, Vector3 start, Vector3 end, Vector3 next, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref previous;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref next;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_CatmullRom_Private_Static_Vector3_Vector3_Vector3_Vector3_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0008076C File Offset: 0x0007E96C
		[CallerCount(0)]
		public unsafe static float Linear(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_Linear_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x000807D4 File Offset: 0x0007E9D4
		[CallerCount(0)]
		public unsafe static float EaseInQuad(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInQuad_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0008083C File Offset: 0x0007EA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75294, XrefRangeEnd = 75295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseOutQuad(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseOutQuad_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x000808A4 File Offset: 0x0007EAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75295, XrefRangeEnd = 75296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInOutQuad(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInOutQuad_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0008090C File Offset: 0x0007EB0C
		[CallerCount(0)]
		public unsafe static float EaseInCubic(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInCubic_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00080974 File Offset: 0x0007EB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75296, XrefRangeEnd = 75297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseOutCubic(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseOutCubic_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x000809DC File Offset: 0x0007EBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75297, XrefRangeEnd = 75298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInOutCubic(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInOutCubic_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00080A44 File Offset: 0x0007EC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75298, XrefRangeEnd = 75299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInQuart(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInQuart_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00080AAC File Offset: 0x0007ECAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75299, XrefRangeEnd = 75300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseOutQuart(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseOutQuart_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00080B14 File Offset: 0x0007ED14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75300, XrefRangeEnd = 75301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInOutQuart(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInOutQuart_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00080B7C File Offset: 0x0007ED7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75301, XrefRangeEnd = 75302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInQuint(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInQuint_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00080BE4 File Offset: 0x0007EDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75302, XrefRangeEnd = 75303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseOutQuint(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseOutQuint_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00080C4C File Offset: 0x0007EE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75303, XrefRangeEnd = 75304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInOutQuint(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInOutQuint_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00080CB4 File Offset: 0x0007EEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75304, XrefRangeEnd = 75305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInSine(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInSine_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00080D1C File Offset: 0x0007EF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75305, XrefRangeEnd = 75306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseOutSine(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseOutSine_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00080D84 File Offset: 0x0007EF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75306, XrefRangeEnd = 75307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInOutSine(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInOutSine_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00080DEC File Offset: 0x0007EFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75307, XrefRangeEnd = 75308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInExpo(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInExpo_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00080E54 File Offset: 0x0007F054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75308, XrefRangeEnd = 75309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseOutExpo(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseOutExpo_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00080EBC File Offset: 0x0007F0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75309, XrefRangeEnd = 75313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInOutExpo(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInOutExpo_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00080F24 File Offset: 0x0007F124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75313, XrefRangeEnd = 75316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInCirc(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInCirc_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00080F8C File Offset: 0x0007F18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75316, XrefRangeEnd = 75319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseOutCirc(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseOutCirc_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00080FF4 File Offset: 0x0007F1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75319, XrefRangeEnd = 75325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInOutCirc(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInOutCirc_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0008105C File Offset: 0x0007F25C
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Interpolate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Interpolate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00005396 File Offset: 0x00003596
		public Interpolate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_Identity_Private_Static_Vector3_Vector3_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_TransformDotPosition_Private_Static_Vector3_Transform_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_NewTimer_Private_Static_IEnumerable_1_Single_Single_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_NewCounter_Private_Static_IEnumerable_1_Single_Int32_Int32_Int32_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_NewEase_Public_Static_IEnumerator_Function_Vector3_Vector3_Single_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_NewEase_Public_Static_IEnumerator_Function_Vector3_Vector3_Int32_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_NewEase_Private_Static_IEnumerator_Function_Vector3_Vector3_Single_IEnumerable_1_Single_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_Ease_Private_Static_Vector3_Function_Vector3_Vector3_Single_Single_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_Ease_Public_Static_Function_EaseType_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppReferenceArray_1_Transform_Single_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppReferenceArray_1_Transform_Int32_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppStructArray_1_Vector3_Single_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppStructArray_1_Vector3_Int32_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_NewBezier_Private_Static_IEnumerable_1_Vector3_Function_IList_ToVector3_1_T_Single_IEnumerable_1_Single_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_Bezier_Private_Static_Vector3_Function_Il2CppStructArray_1_Vector3_Single_Single_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_NewCatmullRom_Public_Static_IEnumerable_1_Vector3_Il2CppReferenceArray_1_Transform_Int32_Boolean_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_NewCatmullRom_Public_Static_IEnumerable_1_Vector3_Il2CppStructArray_1_Vector3_Int32_Boolean_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_NewCatmullRom_Private_Static_IEnumerable_1_Vector3_IList_ToVector3_1_T_Int32_Boolean_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_CatmullRom_Private_Static_Vector3_Vector3_Vector3_Vector3_Vector3_Single_Single_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_Linear_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_EaseInQuad_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_EaseOutQuad_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOutQuad_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_EaseInCubic_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_EaseOutCubic_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOutCubic_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_EaseInQuart_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_EaseOutQuart_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOutQuart_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_EaseInQuint_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_EaseOutQuint_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOutQuint_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_EaseInSine_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_EaseOutSine_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOutSine_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_EaseInExpo_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_EaseOutExpo_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOutExpo_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_EaseInCirc_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_EaseOutCirc_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOutCirc_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007B7 RID: 1975
		[OriginalName("Assembly-CSharp.dll", "", "EaseType")]
		public enum EaseType
		{
			// Token: 0x04007D76 RID: 32118
			Linear,
			// Token: 0x04007D77 RID: 32119
			EaseInQuad,
			// Token: 0x04007D78 RID: 32120
			EaseOutQuad,
			// Token: 0x04007D79 RID: 32121
			EaseInOutQuad,
			// Token: 0x04007D7A RID: 32122
			EaseInCubic,
			// Token: 0x04007D7B RID: 32123
			EaseOutCubic,
			// Token: 0x04007D7C RID: 32124
			EaseInOutCubic,
			// Token: 0x04007D7D RID: 32125
			EaseInQuart,
			// Token: 0x04007D7E RID: 32126
			EaseOutQuart,
			// Token: 0x04007D7F RID: 32127
			EaseInOutQuart,
			// Token: 0x04007D80 RID: 32128
			EaseInQuint,
			// Token: 0x04007D81 RID: 32129
			EaseOutQuint,
			// Token: 0x04007D82 RID: 32130
			EaseInOutQuint,
			// Token: 0x04007D83 RID: 32131
			EaseInSine,
			// Token: 0x04007D84 RID: 32132
			EaseOutSine,
			// Token: 0x04007D85 RID: 32133
			EaseInOutSine,
			// Token: 0x04007D86 RID: 32134
			EaseInExpo,
			// Token: 0x04007D87 RID: 32135
			EaseOutExpo,
			// Token: 0x04007D88 RID: 32136
			EaseInOutExpo,
			// Token: 0x04007D89 RID: 32137
			EaseInCirc,
			// Token: 0x04007D8A RID: 32138
			EaseOutCirc,
			// Token: 0x04007D8B RID: 32139
			EaseInOutCirc
		}

		// Token: 0x020007B8 RID: 1976
		public sealed class ToVector3<T> : MulticastDelegate
		{
			// Token: 0x0600BA05 RID: 47621 RVA: 0x002E266C File Offset: 0x002E086C
			// Note: this type is marked as 'beforefieldinit'.
			static ToVector3()
			{
				Il2CppClassPointerStore<Interpolate.ToVector3<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, "ToVector3`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				Interpolate.ToVector3<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate.ToVector3<T>>.NativeClassPtr, 100663784);
				Interpolate.ToVector3<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector3_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate.ToVector3<T>>.NativeClassPtr, 100663785);
				Interpolate.ToVector3<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate.ToVector3<T>>.NativeClassPtr, 100663786);
				Interpolate.ToVector3<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector3_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate.ToVector3<T>>.NativeClassPtr, 100663787);
			}

			// Token: 0x0600BA06 RID: 47622 RVA: 0x002E2718 File Offset: 0x002E0918
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 74822, RefRangeEnd = 74826, XrefRangeStart = 74813, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ToVector3(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Interpolate.ToVector3<T>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.ToVector3<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA07 RID: 47623 RVA: 0x002E2774 File Offset: 0x002E0974
			[CallerCount(0)]
			public unsafe Vector3 Invoke(T v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = v;
					if (!(t is string))
					{
						ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
						if (ref ptr3 != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref v;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.ToVector3<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector3_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BA08 RID: 47624 RVA: 0x002E280C File Offset: 0x002E0A0C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74827, RefRangeEnd = 74828, XrefRangeStart = 74826, XrefRangeEnd = 74827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(T v, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = v;
					if (!(t is string))
					{
						ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
						if (ref ptr3 != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref v;
				}
				*ptr2 = ref ptr4;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.ToVector3<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600BA09 RID: 47625 RVA: 0x002E28CC File Offset: 0x002E0ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74828, XrefRangeEnd = 74830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.ToVector3<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector3_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BA0A RID: 47626 RVA: 0x0005AF27 File Offset: 0x00059127
			public ToVector3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BA0B RID: 47627 RVA: 0x0005AF30 File Offset: 0x00059130
			public static implicit operator Interpolate.ToVector3<T>(Func<T, Vector3> A_0)
			{
				return DelegateSupport.ConvertDelegate<Interpolate.ToVector3<T>>(A_0);
			}

			// Token: 0x0600BA0C RID: 47628 RVA: 0x0005AF38 File Offset: 0x00059138
			public static Interpolate.ToVector3<T>operator +(Interpolate.ToVector3<T> A_0, Interpolate.ToVector3<T> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Interpolate.ToVector3<T>>();
			}

			// Token: 0x0600BA0D RID: 47629 RVA: 0x0005AF46 File Offset: 0x00059146
			public static Interpolate.ToVector3<T>operator -(Interpolate.ToVector3<T> A_0, Interpolate.ToVector3<T> A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Interpolate.ToVector3<T>>();
				}
				return result;
			}

			// Token: 0x04007D8C RID: 32140
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04007D8D RID: 32141
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector3_T_0;

			// Token: 0x04007D8E RID: 32142
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0;

			// Token: 0x04007D8F RID: 32143
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector3_IAsyncResult_0;
		}

		// Token: 0x020007B9 RID: 1977
		public sealed class Function : MulticastDelegate
		{
			// Token: 0x0600BA0E RID: 47630 RVA: 0x002E291C File Offset: 0x002E0B1C
			// Note: this type is marked as 'beforefieldinit'.
			static Function()
			{
				Il2CppClassPointerStore<Interpolate.Function>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, "Function");
				Interpolate.Function.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate.Function>.NativeClassPtr, 100663788);
				Interpolate.Function.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate.Function>.NativeClassPtr, 100663789);
				Interpolate.Function.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_Single_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate.Function>.NativeClassPtr, 100663790);
				Interpolate.Function.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate.Function>.NativeClassPtr, 100663791);
			}

			// Token: 0x0600BA0F RID: 47631 RVA: 0x002E2990 File Offset: 0x002E0B90
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74833, RefRangeEnd = 74834, XrefRangeStart = 74830, XrefRangeEnd = 74833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Function(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Interpolate.Function>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.Function.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA10 RID: 47632 RVA: 0x002E29EC File Offset: 0x002E0BEC
			[CallerCount(0)]
			public unsafe float Invoke(float a, float b, float c, float d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.Function.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BA11 RID: 47633 RVA: 0x002E2A60 File Offset: 0x002E0C60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74834, XrefRangeEnd = 74844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(float a, float b, float c, float d, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.Function.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_Single_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600BA12 RID: 47634 RVA: 0x002E2AFC File Offset: 0x002E0CFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74844, XrefRangeEnd = 74846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.Function.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BA13 RID: 47635 RVA: 0x0005AF57 File Offset: 0x00059157
			public Function(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BA14 RID: 47636 RVA: 0x0005AF60 File Offset: 0x00059160
			public static implicit operator Interpolate.Function(Func<float, float, float, float, float> A_0)
			{
				return DelegateSupport.ConvertDelegate<Interpolate.Function>(A_0);
			}

			// Token: 0x0600BA15 RID: 47637 RVA: 0x0005AF68 File Offset: 0x00059168
			public static Interpolate.Function operator +(Interpolate.Function A_0, Interpolate.Function A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Interpolate.Function>();
			}

			// Token: 0x0600BA16 RID: 47638 RVA: 0x0005AF76 File Offset: 0x00059176
			public static Interpolate.Function operator -(Interpolate.Function A_0, Interpolate.Function A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Interpolate.Function>();
				}
				return result;
			}

			// Token: 0x04007D90 RID: 32144
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04007D91 RID: 32145
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_Single_Single_Single_Single_0;

			// Token: 0x04007D92 RID: 32146
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_Single_Single_AsyncCallback_Object_0;

			// Token: 0x04007D93 RID: 32147
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0;
		}

		// Token: 0x020007BA RID: 1978
		[ObfuscatedName("Interpolate+<NewBezier>d__16`1")]
		public sealed class _NewBezier_d__16<T> : Il2CppSystem.Object
		{
			// Token: 0x0600BA17 RID: 47639 RVA: 0x002E2B4C File Offset: 0x002E0D4C
			// Note: this type is marked as 'beforefieldinit'.
			static _NewBezier_d__16()
			{
				Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, "<NewBezier>d__16`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr);
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<>1__state");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<>2__current");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<>l__initialThreadId");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "nodes");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<>3__nodes");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_steps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "steps");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__steps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<>3__steps");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_toVector3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "toVector3");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__toVector3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<>3__toVector3");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "ease");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<>3__ease");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_maxStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "maxStep");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__maxStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<>3__maxStep");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr__points_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<points>5__2");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<>7__wrap2");
				Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, 100663792);
				Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, 100663793);
				Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, 100663794);
				Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, 100663795);
				Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Vector3__get_Current_Private_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, 100663796);
				Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, 100663797);
				Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, 100663798);
				Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Vector3__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, 100663799);
				Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, 100663800);
			}

			// Token: 0x0600BA18 RID: 47640 RVA: 0x002E2D94 File Offset: 0x002E0F94
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 25614, RefRangeEnd = 25637, XrefRangeStart = 25614, XrefRangeEnd = 25637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _NewBezier_d__16(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA19 RID: 47641 RVA: 0x002E2DDC File Offset: 0x002E0FDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74846, XrefRangeEnd = 74851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA1A RID: 47642 RVA: 0x002E2E10 File Offset: 0x002E1010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74851, XrefRangeEnd = 74889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BA1B RID: 47643 RVA: 0x002E2E4C File Offset: 0x002E104C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74889, XrefRangeEnd = 74892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003977 RID: 14711
			// (get) Token: 0x0600BA1C RID: 47644 RVA: 0x002E2E80 File Offset: 0x002E1080
			public unsafe Vector3 Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Vector3__get_Current_Private_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BA1D RID: 47645 RVA: 0x002E2EBC File Offset: 0x002E10BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003978 RID: 14712
			// (get) Token: 0x0600BA1E RID: 47646 RVA: 0x002E2EF0 File Offset: 0x002E10F0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74892, XrefRangeEnd = 74895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BA1F RID: 47647 RVA: 0x002E2F30 File Offset: 0x002E1130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74895, XrefRangeEnd = 74905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Vector3> System_Collections_Generic_IEnumerable_UnityEngine_Vector3__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Vector3__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Vector3>>(intPtr3) : null;
			}

			// Token: 0x0600BA20 RID: 47648 RVA: 0x002E2F70 File Offset: 0x002E1170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74905, XrefRangeEnd = 74915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BA21 RID: 47649 RVA: 0x0005AF87 File Offset: 0x00059187
			public _NewBezier_d__16(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003968 RID: 14696
			// (get) Token: 0x0600BA22 RID: 47650 RVA: 0x002E2FB0 File Offset: 0x002E11B0
			// (set) Token: 0x0600BA23 RID: 47651 RVA: 0x0005AF90 File Offset: 0x00059190
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003969 RID: 14697
			// (get) Token: 0x0600BA24 RID: 47652 RVA: 0x002E2FD8 File Offset: 0x002E11D8
			// (set) Token: 0x0600BA25 RID: 47653 RVA: 0x0005AFAB File Offset: 0x000591AB
			public unsafe Vector3 __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x1700396A RID: 14698
			// (get) Token: 0x0600BA26 RID: 47654 RVA: 0x002E3000 File Offset: 0x002E1200
			// (set) Token: 0x0600BA27 RID: 47655 RVA: 0x0005AFC6 File Offset: 0x000591C6
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700396B RID: 14699
			// (get) Token: 0x0600BA28 RID: 47656 RVA: 0x002E3028 File Offset: 0x002E1228
			// (set) Token: 0x0600BA29 RID: 47657 RVA: 0x0005AFE1 File Offset: 0x000591E1
			public unsafe IList nodes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_nodes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700396C RID: 14700
			// (get) Token: 0x0600BA2A RID: 47658 RVA: 0x002E3058 File Offset: 0x002E1258
			// (set) Token: 0x0600BA2B RID: 47659 RVA: 0x0005B000 File Offset: 0x00059200
			public unsafe IList __3__nodes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__nodes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700396D RID: 14701
			// (get) Token: 0x0600BA2C RID: 47660 RVA: 0x002E3088 File Offset: 0x002E1288
			// (set) Token: 0x0600BA2D RID: 47661 RVA: 0x0005B01F File Offset: 0x0005921F
			public unsafe IEnumerable<float> steps
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_steps);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_steps), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700396E RID: 14702
			// (get) Token: 0x0600BA2E RID: 47662 RVA: 0x002E30B8 File Offset: 0x002E12B8
			// (set) Token: 0x0600BA2F RID: 47663 RVA: 0x0005B03E File Offset: 0x0005923E
			public unsafe IEnumerable<float> __3__steps
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__steps);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__steps), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700396F RID: 14703
			// (get) Token: 0x0600BA30 RID: 47664 RVA: 0x002E30E8 File Offset: 0x002E12E8
			// (set) Token: 0x0600BA31 RID: 47665 RVA: 0x0005B05D File Offset: 0x0005925D
			public unsafe Interpolate.ToVector3<T> toVector3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_toVector3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interpolate.ToVector3<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_toVector3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003970 RID: 14704
			// (get) Token: 0x0600BA32 RID: 47666 RVA: 0x002E3118 File Offset: 0x002E1318
			// (set) Token: 0x0600BA33 RID: 47667 RVA: 0x0005B07C File Offset: 0x0005927C
			public unsafe Interpolate.ToVector3<T> __3__toVector3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__toVector3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interpolate.ToVector3<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__toVector3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003971 RID: 14705
			// (get) Token: 0x0600BA34 RID: 47668 RVA: 0x002E3148 File Offset: 0x002E1348
			// (set) Token: 0x0600BA35 RID: 47669 RVA: 0x0005B09B File Offset: 0x0005929B
			public unsafe Interpolate.Function ease
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_ease);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interpolate.Function>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_ease), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003972 RID: 14706
			// (get) Token: 0x0600BA36 RID: 47670 RVA: 0x002E3178 File Offset: 0x002E1378
			// (set) Token: 0x0600BA37 RID: 47671 RVA: 0x0005B0BA File Offset: 0x000592BA
			public unsafe Interpolate.Function __3__ease
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__ease);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interpolate.Function>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__ease), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003973 RID: 14707
			// (get) Token: 0x0600BA38 RID: 47672 RVA: 0x002E31A8 File Offset: 0x002E13A8
			// (set) Token: 0x0600BA39 RID: 47673 RVA: 0x0005B0D9 File Offset: 0x000592D9
			public unsafe float maxStep
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_maxStep);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_maxStep)) = value;
				}
			}

			// Token: 0x17003974 RID: 14708
			// (get) Token: 0x0600BA3A RID: 47674 RVA: 0x002E31D0 File Offset: 0x002E13D0
			// (set) Token: 0x0600BA3B RID: 47675 RVA: 0x0005B0F4 File Offset: 0x000592F4
			public unsafe float __3__maxStep
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__maxStep);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__maxStep)) = value;
				}
			}

			// Token: 0x17003975 RID: 14709
			// (get) Token: 0x0600BA3C RID: 47676 RVA: 0x002E31F8 File Offset: 0x002E13F8
			// (set) Token: 0x0600BA3D RID: 47677 RVA: 0x0005B10F File Offset: 0x0005930F
			public unsafe Il2CppStructArray<Vector3> _points_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr__points_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr__points_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003976 RID: 14710
			// (get) Token: 0x0600BA3E RID: 47678 RVA: 0x002E3228 File Offset: 0x002E1428
			// (set) Token: 0x0600BA3F RID: 47679 RVA: 0x0005B12E File Offset: 0x0005932E
			public unsafe IEnumerator<float> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D94 RID: 32148
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007D95 RID: 32149
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007D96 RID: 32150
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007D97 RID: 32151
			private static readonly IntPtr NativeFieldInfoPtr_nodes;

			// Token: 0x04007D98 RID: 32152
			private static readonly IntPtr NativeFieldInfoPtr___3__nodes;

			// Token: 0x04007D99 RID: 32153
			private static readonly IntPtr NativeFieldInfoPtr_steps;

			// Token: 0x04007D9A RID: 32154
			private static readonly IntPtr NativeFieldInfoPtr___3__steps;

			// Token: 0x04007D9B RID: 32155
			private static readonly IntPtr NativeFieldInfoPtr_toVector3;

			// Token: 0x04007D9C RID: 32156
			private static readonly IntPtr NativeFieldInfoPtr___3__toVector3;

			// Token: 0x04007D9D RID: 32157
			private static readonly IntPtr NativeFieldInfoPtr_ease;

			// Token: 0x04007D9E RID: 32158
			private static readonly IntPtr NativeFieldInfoPtr___3__ease;

			// Token: 0x04007D9F RID: 32159
			private static readonly IntPtr NativeFieldInfoPtr_maxStep;

			// Token: 0x04007DA0 RID: 32160
			private static readonly IntPtr NativeFieldInfoPtr___3__maxStep;

			// Token: 0x04007DA1 RID: 32161
			private static readonly IntPtr NativeFieldInfoPtr__points_5__2;

			// Token: 0x04007DA2 RID: 32162
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04007DA3 RID: 32163
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007DA4 RID: 32164
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007DA5 RID: 32165
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007DA6 RID: 32166
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04007DA7 RID: 32167
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Vector3__get_Current_Private_Virtual_Final_New_get_Vector3_0;

			// Token: 0x04007DA8 RID: 32168
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007DA9 RID: 32169
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007DAA RID: 32170
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Vector3__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Vector3_0;

			// Token: 0x04007DAB RID: 32171
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020007BB RID: 1979
		[ObfuscatedName("Interpolate+<NewCatmullRom>d__20`1")]
		public sealed class _NewCatmullRom_d__20<T> : Il2CppSystem.Object
		{
			// Token: 0x0600BA40 RID: 47680 RVA: 0x002E3258 File Offset: 0x002E1458
			// Note: this type is marked as 'beforefieldinit'.
			static _NewCatmullRom_d__20()
			{
				Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, "<NewCatmullRom>d__20`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr);
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<>1__state");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<>2__current");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<>l__initialThreadId");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "nodes");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<>3__nodes");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_toVector3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "toVector3");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__toVector3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<>3__toVector3");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "loop");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<>3__loop");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_slices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "slices");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__slices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<>3__slices");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__last_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<last>5__2");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__current_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<current>5__3");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__previous_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<previous>5__4");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__start_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<start>5__5");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__end_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<end>5__6");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__next_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<next>5__7");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__stepCount_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<stepCount>5__8");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__step_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<step>5__9");
				Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, 100663801);
				Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, 100663802);
				Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, 100663803);
				Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Vector3__get_Current_Private_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, 100663804);
				Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, 100663805);
				Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, 100663806);
				Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Vector3__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, 100663807);
				Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, 100663808);
			}

			// Token: 0x0600BA41 RID: 47681 RVA: 0x002E34DC File Offset: 0x002E16DC
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 25614, RefRangeEnd = 25637, XrefRangeStart = 25614, XrefRangeEnd = 25637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _NewCatmullRom_d__20(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA42 RID: 47682 RVA: 0x002E3524 File Offset: 0x002E1724
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA43 RID: 47683 RVA: 0x002E3558 File Offset: 0x002E1758
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74915, XrefRangeEnd = 74948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700398C RID: 14732
			// (get) Token: 0x0600BA44 RID: 47684 RVA: 0x002E3594 File Offset: 0x002E1794
			public unsafe Vector3 Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Vector3__get_Current_Private_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BA45 RID: 47685 RVA: 0x002E35D0 File Offset: 0x002E17D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700398D RID: 14733
			// (get) Token: 0x0600BA46 RID: 47686 RVA: 0x002E3604 File Offset: 0x002E1804
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74948, XrefRangeEnd = 74951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BA47 RID: 47687 RVA: 0x002E3644 File Offset: 0x002E1844
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74951, XrefRangeEnd = 74959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Vector3> System_Collections_Generic_IEnumerable_UnityEngine_Vector3__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Vector3__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Vector3>>(intPtr3) : null;
			}

			// Token: 0x0600BA48 RID: 47688 RVA: 0x002E3684 File Offset: 0x002E1884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74959, XrefRangeEnd = 74967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BA49 RID: 47689 RVA: 0x0005B14D File Offset: 0x0005934D
			public _NewCatmullRom_d__20(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003979 RID: 14713
			// (get) Token: 0x0600BA4A RID: 47690 RVA: 0x002E36C4 File Offset: 0x002E18C4
			// (set) Token: 0x0600BA4B RID: 47691 RVA: 0x0005B156 File Offset: 0x00059356
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700397A RID: 14714
			// (get) Token: 0x0600BA4C RID: 47692 RVA: 0x002E36EC File Offset: 0x002E18EC
			// (set) Token: 0x0600BA4D RID: 47693 RVA: 0x0005B171 File Offset: 0x00059371
			public unsafe Vector3 __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x1700397B RID: 14715
			// (get) Token: 0x0600BA4E RID: 47694 RVA: 0x002E3714 File Offset: 0x002E1914
			// (set) Token: 0x0600BA4F RID: 47695 RVA: 0x0005B18C File Offset: 0x0005938C
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700397C RID: 14716
			// (get) Token: 0x0600BA50 RID: 47696 RVA: 0x002E373C File Offset: 0x002E193C
			// (set) Token: 0x0600BA51 RID: 47697 RVA: 0x0005B1A7 File Offset: 0x000593A7
			public unsafe IList nodes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_nodes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700397D RID: 14717
			// (get) Token: 0x0600BA52 RID: 47698 RVA: 0x002E376C File Offset: 0x002E196C
			// (set) Token: 0x0600BA53 RID: 47699 RVA: 0x0005B1C6 File Offset: 0x000593C6
			public unsafe IList __3__nodes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__nodes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700397E RID: 14718
			// (get) Token: 0x0600BA54 RID: 47700 RVA: 0x002E379C File Offset: 0x002E199C
			// (set) Token: 0x0600BA55 RID: 47701 RVA: 0x0005B1E5 File Offset: 0x000593E5
			public unsafe Interpolate.ToVector3<T> toVector3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_toVector3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interpolate.ToVector3<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_toVector3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700397F RID: 14719
			// (get) Token: 0x0600BA56 RID: 47702 RVA: 0x002E37CC File Offset: 0x002E19CC
			// (set) Token: 0x0600BA57 RID: 47703 RVA: 0x0005B204 File Offset: 0x00059404
			public unsafe Interpolate.ToVector3<T> __3__toVector3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__toVector3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interpolate.ToVector3<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__toVector3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003980 RID: 14720
			// (get) Token: 0x0600BA58 RID: 47704 RVA: 0x002E37FC File Offset: 0x002E19FC
			// (set) Token: 0x0600BA59 RID: 47705 RVA: 0x0005B223 File Offset: 0x00059423
			public unsafe bool loop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_loop);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_loop)) = value;
				}
			}

			// Token: 0x17003981 RID: 14721
			// (get) Token: 0x0600BA5A RID: 47706 RVA: 0x002E3824 File Offset: 0x002E1A24
			// (set) Token: 0x0600BA5B RID: 47707 RVA: 0x0005B23E File Offset: 0x0005943E
			public unsafe bool __3__loop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__loop);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__loop)) = value;
				}
			}

			// Token: 0x17003982 RID: 14722
			// (get) Token: 0x0600BA5C RID: 47708 RVA: 0x002E384C File Offset: 0x002E1A4C
			// (set) Token: 0x0600BA5D RID: 47709 RVA: 0x0005B259 File Offset: 0x00059459
			public unsafe int slices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_slices);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_slices)) = value;
				}
			}

			// Token: 0x17003983 RID: 14723
			// (get) Token: 0x0600BA5E RID: 47710 RVA: 0x002E3874 File Offset: 0x002E1A74
			// (set) Token: 0x0600BA5F RID: 47711 RVA: 0x0005B274 File Offset: 0x00059474
			public unsafe int __3__slices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__slices);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__slices)) = value;
				}
			}

			// Token: 0x17003984 RID: 14724
			// (get) Token: 0x0600BA60 RID: 47712 RVA: 0x002E389C File Offset: 0x002E1A9C
			// (set) Token: 0x0600BA61 RID: 47713 RVA: 0x0005B28F File Offset: 0x0005948F
			public unsafe int _last_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__last_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__last_5__2)) = value;
				}
			}

			// Token: 0x17003985 RID: 14725
			// (get) Token: 0x0600BA62 RID: 47714 RVA: 0x002E38C4 File Offset: 0x002E1AC4
			// (set) Token: 0x0600BA63 RID: 47715 RVA: 0x0005B2AA File Offset: 0x000594AA
			public unsafe int _current_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__current_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__current_5__3)) = value;
				}
			}

			// Token: 0x17003986 RID: 14726
			// (get) Token: 0x0600BA64 RID: 47716 RVA: 0x002E38EC File Offset: 0x002E1AEC
			// (set) Token: 0x0600BA65 RID: 47717 RVA: 0x0005B2C5 File Offset: 0x000594C5
			public unsafe int _previous_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__previous_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__previous_5__4)) = value;
				}
			}

			// Token: 0x17003987 RID: 14727
			// (get) Token: 0x0600BA66 RID: 47718 RVA: 0x002E3914 File Offset: 0x002E1B14
			// (set) Token: 0x0600BA67 RID: 47719 RVA: 0x0005B2E0 File Offset: 0x000594E0
			public unsafe int _start_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__start_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__start_5__5)) = value;
				}
			}

			// Token: 0x17003988 RID: 14728
			// (get) Token: 0x0600BA68 RID: 47720 RVA: 0x002E393C File Offset: 0x002E1B3C
			// (set) Token: 0x0600BA69 RID: 47721 RVA: 0x0005B2FB File Offset: 0x000594FB
			public unsafe int _end_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__end_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__end_5__6)) = value;
				}
			}

			// Token: 0x17003989 RID: 14729
			// (get) Token: 0x0600BA6A RID: 47722 RVA: 0x002E3964 File Offset: 0x002E1B64
			// (set) Token: 0x0600BA6B RID: 47723 RVA: 0x0005B316 File Offset: 0x00059516
			public unsafe int _next_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__next_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__next_5__7)) = value;
				}
			}

			// Token: 0x1700398A RID: 14730
			// (get) Token: 0x0600BA6C RID: 47724 RVA: 0x002E398C File Offset: 0x002E1B8C
			// (set) Token: 0x0600BA6D RID: 47725 RVA: 0x0005B331 File Offset: 0x00059531
			public unsafe int _stepCount_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__stepCount_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__stepCount_5__8)) = value;
				}
			}

			// Token: 0x1700398B RID: 14731
			// (get) Token: 0x0600BA6E RID: 47726 RVA: 0x002E39B4 File Offset: 0x002E1BB4
			// (set) Token: 0x0600BA6F RID: 47727 RVA: 0x0005B34C File Offset: 0x0005954C
			public unsafe int _step_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__step_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__step_5__9)) = value;
				}
			}

			// Token: 0x04007DAC RID: 32172
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007DAD RID: 32173
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007DAE RID: 32174
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007DAF RID: 32175
			private static readonly IntPtr NativeFieldInfoPtr_nodes;

			// Token: 0x04007DB0 RID: 32176
			private static readonly IntPtr NativeFieldInfoPtr___3__nodes;

			// Token: 0x04007DB1 RID: 32177
			private static readonly IntPtr NativeFieldInfoPtr_toVector3;

			// Token: 0x04007DB2 RID: 32178
			private static readonly IntPtr NativeFieldInfoPtr___3__toVector3;

			// Token: 0x04007DB3 RID: 32179
			private static readonly IntPtr NativeFieldInfoPtr_loop;

			// Token: 0x04007DB4 RID: 32180
			private static readonly IntPtr NativeFieldInfoPtr___3__loop;

			// Token: 0x04007DB5 RID: 32181
			private static readonly IntPtr NativeFieldInfoPtr_slices;

			// Token: 0x04007DB6 RID: 32182
			private static readonly IntPtr NativeFieldInfoPtr___3__slices;

			// Token: 0x04007DB7 RID: 32183
			private static readonly IntPtr NativeFieldInfoPtr__last_5__2;

			// Token: 0x04007DB8 RID: 32184
			private static readonly IntPtr NativeFieldInfoPtr__current_5__3;

			// Token: 0x04007DB9 RID: 32185
			private static readonly IntPtr NativeFieldInfoPtr__previous_5__4;

			// Token: 0x04007DBA RID: 32186
			private static readonly IntPtr NativeFieldInfoPtr__start_5__5;

			// Token: 0x04007DBB RID: 32187
			private static readonly IntPtr NativeFieldInfoPtr__end_5__6;

			// Token: 0x04007DBC RID: 32188
			private static readonly IntPtr NativeFieldInfoPtr__next_5__7;

			// Token: 0x04007DBD RID: 32189
			private static readonly IntPtr NativeFieldInfoPtr__stepCount_5__8;

			// Token: 0x04007DBE RID: 32190
			private static readonly IntPtr NativeFieldInfoPtr__step_5__9;

			// Token: 0x04007DBF RID: 32191
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007DC0 RID: 32192
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007DC1 RID: 32193
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007DC2 RID: 32194
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Vector3__get_Current_Private_Virtual_Final_New_get_Vector3_0;

			// Token: 0x04007DC3 RID: 32195
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007DC4 RID: 32196
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007DC5 RID: 32197
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Vector3__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Vector3_0;

			// Token: 0x04007DC6 RID: 32198
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020007BC RID: 1980
		[ObfuscatedName("Interpolate+<NewCounter>d__6")]
		public sealed class _NewCounter_d__6 : Il2CppSystem.Object
		{
			// Token: 0x0600BA70 RID: 47728 RVA: 0x002E39DC File Offset: 0x002E1BDC
			// Note: this type is marked as 'beforefieldinit'.
			static _NewCounter_d__6()
			{
				Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, "<NewCounter>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr);
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "<>1__state");
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "<>2__current");
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "<>l__initialThreadId");
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "start");
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr___3__start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "<>3__start");
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr_step = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "step");
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr___3__step = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "<>3__step");
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "end");
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr___3__end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "<>3__end");
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "<i>5__2");
				Interpolate._NewCounter_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, 100663809);
				Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, 100663810);
				Interpolate._NewCounter_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, 100663811);
				Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Single__get_Current_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, 100663812);
				Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, 100663813);
				Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, 100663814);
				Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Single__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, 100663815);
				Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, 100663816);
			}

			// Token: 0x0600BA71 RID: 47729 RVA: 0x002E3B70 File Offset: 0x002E1D70
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 74969, RefRangeEnd = 74977, XrefRangeStart = 74967, XrefRangeEnd = 74969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _NewCounter_d__6(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCounter_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA72 RID: 47730 RVA: 0x002E3BB8 File Offset: 0x002E1DB8
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA73 RID: 47731 RVA: 0x002E3BEC File Offset: 0x002E1DEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74977, XrefRangeEnd = 74978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCounter_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003998 RID: 14744
			// (get) Token: 0x0600BA74 RID: 47732 RVA: 0x002E3C28 File Offset: 0x002E1E28
			public unsafe float Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Single__get_Current_Private_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BA75 RID: 47733 RVA: 0x002E3C64 File Offset: 0x002E1E64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74978, XrefRangeEnd = 74983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003999 RID: 14745
			// (get) Token: 0x0600BA76 RID: 47734 RVA: 0x002E3C98 File Offset: 0x002E1E98
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74983, XrefRangeEnd = 74986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BA77 RID: 47735 RVA: 0x002E3CD8 File Offset: 0x002E1ED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74986, XrefRangeEnd = 74993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<float> System_Collections_Generic_IEnumerable_System_Single__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Single__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<float>>(intPtr3) : null;
			}

			// Token: 0x0600BA78 RID: 47736 RVA: 0x002E3D18 File Offset: 0x002E1F18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BA79 RID: 47737 RVA: 0x0005B367 File Offset: 0x00059567
			public _NewCounter_d__6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700398E RID: 14734
			// (get) Token: 0x0600BA7A RID: 47738 RVA: 0x002E3D58 File Offset: 0x002E1F58
			// (set) Token: 0x0600BA7B RID: 47739 RVA: 0x0005B370 File Offset: 0x00059570
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700398F RID: 14735
			// (get) Token: 0x0600BA7C RID: 47740 RVA: 0x002E3D80 File Offset: 0x002E1F80
			// (set) Token: 0x0600BA7D RID: 47741 RVA: 0x0005B38B File Offset: 0x0005958B
			public unsafe float __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x17003990 RID: 14736
			// (get) Token: 0x0600BA7E RID: 47742 RVA: 0x002E3DA8 File Offset: 0x002E1FA8
			// (set) Token: 0x0600BA7F RID: 47743 RVA: 0x0005B3A6 File Offset: 0x000595A6
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003991 RID: 14737
			// (get) Token: 0x0600BA80 RID: 47744 RVA: 0x002E3DD0 File Offset: 0x002E1FD0
			// (set) Token: 0x0600BA81 RID: 47745 RVA: 0x0005B3C1 File Offset: 0x000595C1
			public unsafe int start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x17003992 RID: 14738
			// (get) Token: 0x0600BA82 RID: 47746 RVA: 0x002E3DF8 File Offset: 0x002E1FF8
			// (set) Token: 0x0600BA83 RID: 47747 RVA: 0x0005B3DC File Offset: 0x000595DC
			public unsafe int __3__start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___3__start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___3__start)) = value;
				}
			}

			// Token: 0x17003993 RID: 14739
			// (get) Token: 0x0600BA84 RID: 47748 RVA: 0x002E3E20 File Offset: 0x002E2020
			// (set) Token: 0x0600BA85 RID: 47749 RVA: 0x0005B3F7 File Offset: 0x000595F7
			public unsafe int step
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr_step);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr_step)) = value;
				}
			}

			// Token: 0x17003994 RID: 14740
			// (get) Token: 0x0600BA86 RID: 47750 RVA: 0x002E3E48 File Offset: 0x002E2048
			// (set) Token: 0x0600BA87 RID: 47751 RVA: 0x0005B412 File Offset: 0x00059612
			public unsafe int __3__step
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___3__step);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___3__step)) = value;
				}
			}

			// Token: 0x17003995 RID: 14741
			// (get) Token: 0x0600BA88 RID: 47752 RVA: 0x002E3E70 File Offset: 0x002E2070
			// (set) Token: 0x0600BA89 RID: 47753 RVA: 0x0005B42D File Offset: 0x0005962D
			public unsafe int end
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr_end);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr_end)) = value;
				}
			}

			// Token: 0x17003996 RID: 14742
			// (get) Token: 0x0600BA8A RID: 47754 RVA: 0x002E3E98 File Offset: 0x002E2098
			// (set) Token: 0x0600BA8B RID: 47755 RVA: 0x0005B448 File Offset: 0x00059648
			public unsafe int __3__end
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___3__end);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___3__end)) = value;
				}
			}

			// Token: 0x17003997 RID: 14743
			// (get) Token: 0x0600BA8C RID: 47756 RVA: 0x002E3EC0 File Offset: 0x002E20C0
			// (set) Token: 0x0600BA8D RID: 47757 RVA: 0x0005B463 File Offset: 0x00059663
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04007DC7 RID: 32199
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007DC8 RID: 32200
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007DC9 RID: 32201
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007DCA RID: 32202
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x04007DCB RID: 32203
			private static readonly IntPtr NativeFieldInfoPtr___3__start;

			// Token: 0x04007DCC RID: 32204
			private static readonly IntPtr NativeFieldInfoPtr_step;

			// Token: 0x04007DCD RID: 32205
			private static readonly IntPtr NativeFieldInfoPtr___3__step;

			// Token: 0x04007DCE RID: 32206
			private static readonly IntPtr NativeFieldInfoPtr_end;

			// Token: 0x04007DCF RID: 32207
			private static readonly IntPtr NativeFieldInfoPtr___3__end;

			// Token: 0x04007DD0 RID: 32208
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04007DD1 RID: 32209
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007DD2 RID: 32210
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007DD3 RID: 32211
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007DD4 RID: 32212
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Single__get_Current_Private_Virtual_Final_New_get_Single_0;

			// Token: 0x04007DD5 RID: 32213
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007DD6 RID: 32214
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007DD7 RID: 32215
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Single__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Single_0;

			// Token: 0x04007DD8 RID: 32216
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020007BD RID: 1981
		[ObfuscatedName("Interpolate+<NewEase>d__9")]
		public sealed class _NewEase_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600BA8E RID: 47758 RVA: 0x002E3EE8 File Offset: 0x002E20E8
			// Note: this type is marked as 'beforefieldinit'.
			static _NewEase_d__9()
			{
				Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, "<NewEase>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr);
				Interpolate._NewEase_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, "<>1__state");
				Interpolate._NewEase_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, "<>2__current");
				Interpolate._NewEase_d__9.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, "end");
				Interpolate._NewEase_d__9.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, "start");
				Interpolate._NewEase_d__9.NativeFieldInfoPtr_driver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, "driver");
				Interpolate._NewEase_d__9.NativeFieldInfoPtr_ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, "ease");
				Interpolate._NewEase_d__9.NativeFieldInfoPtr_total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, "total");
				Interpolate._NewEase_d__9.NativeFieldInfoPtr__distance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, "<distance>5__2");
				Interpolate._NewEase_d__9.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, "<>7__wrap2");
				Interpolate._NewEase_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, 100663817);
				Interpolate._NewEase_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, 100663818);
				Interpolate._NewEase_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, 100663819);
				Interpolate._NewEase_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, 100663820);
				Interpolate._NewEase_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, 100663821);
				Interpolate._NewEase_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, 100663822);
				Interpolate._NewEase_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, 100663823);
			}

			// Token: 0x0600BA8F RID: 47759 RVA: 0x002E4054 File Offset: 0x002E2254
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _NewEase_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewEase_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA90 RID: 47760 RVA: 0x002E409C File Offset: 0x002E229C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74996, RefRangeEnd = 74997, XrefRangeStart = 74993, XrefRangeEnd = 74996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewEase_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA91 RID: 47761 RVA: 0x002E40D0 File Offset: 0x002E22D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74997, XrefRangeEnd = 75020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewEase_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BA92 RID: 47762 RVA: 0x002E410C File Offset: 0x002E230C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 75023, RefRangeEnd = 75026, XrefRangeStart = 75020, XrefRangeEnd = 75023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewEase_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170039A3 RID: 14755
			// (get) Token: 0x0600BA93 RID: 47763 RVA: 0x002E4140 File Offset: 0x002E2340
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewEase_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BA94 RID: 47764 RVA: 0x002E4180 File Offset: 0x002E2380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75026, XrefRangeEnd = 75031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewEase_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170039A4 RID: 14756
			// (get) Token: 0x0600BA95 RID: 47765 RVA: 0x002E41B4 File Offset: 0x002E23B4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewEase_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BA96 RID: 47766 RVA: 0x0005B47E File Offset: 0x0005967E
			public _NewEase_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700399A RID: 14746
			// (get) Token: 0x0600BA97 RID: 47767 RVA: 0x002E41F4 File Offset: 0x002E23F4
			// (set) Token: 0x0600BA98 RID: 47768 RVA: 0x0005B487 File Offset: 0x00059687
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700399B RID: 14747
			// (get) Token: 0x0600BA99 RID: 47769 RVA: 0x002E421C File Offset: 0x002E241C
			// (set) Token: 0x0600BA9A RID: 47770 RVA: 0x0005B4A2 File Offset: 0x000596A2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700399C RID: 14748
			// (get) Token: 0x0600BA9B RID: 47771 RVA: 0x002E424C File Offset: 0x002E244C
			// (set) Token: 0x0600BA9C RID: 47772 RVA: 0x0005B4C1 File Offset: 0x000596C1
			public unsafe Vector3 end
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_end);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_end)) = value;
				}
			}

			// Token: 0x1700399D RID: 14749
			// (get) Token: 0x0600BA9D RID: 47773 RVA: 0x002E4274 File Offset: 0x002E2474
			// (set) Token: 0x0600BA9E RID: 47774 RVA: 0x0005B4DC File Offset: 0x000596DC
			public unsafe Vector3 start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x1700399E RID: 14750
			// (get) Token: 0x0600BA9F RID: 47775 RVA: 0x002E429C File Offset: 0x002E249C
			// (set) Token: 0x0600BAA0 RID: 47776 RVA: 0x0005B4F7 File Offset: 0x000596F7
			public unsafe IEnumerable<float> driver
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_driver);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_driver), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700399F RID: 14751
			// (get) Token: 0x0600BAA1 RID: 47777 RVA: 0x002E42CC File Offset: 0x002E24CC
			// (set) Token: 0x0600BAA2 RID: 47778 RVA: 0x0005B516 File Offset: 0x00059716
			public unsafe Interpolate.Function ease
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_ease);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interpolate.Function>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_ease), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170039A0 RID: 14752
			// (get) Token: 0x0600BAA3 RID: 47779 RVA: 0x002E42FC File Offset: 0x002E24FC
			// (set) Token: 0x0600BAA4 RID: 47780 RVA: 0x0005B535 File Offset: 0x00059735
			public unsafe float total
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_total);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_total)) = value;
				}
			}

			// Token: 0x170039A1 RID: 14753
			// (get) Token: 0x0600BAA5 RID: 47781 RVA: 0x002E4324 File Offset: 0x002E2524
			// (set) Token: 0x0600BAA6 RID: 47782 RVA: 0x0005B550 File Offset: 0x00059750
			public unsafe Vector3 _distance_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr__distance_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr__distance_5__2)) = value;
				}
			}

			// Token: 0x170039A2 RID: 14754
			// (get) Token: 0x0600BAA7 RID: 47783 RVA: 0x002E434C File Offset: 0x002E254C
			// (set) Token: 0x0600BAA8 RID: 47784 RVA: 0x0005B56B File Offset: 0x0005976B
			public unsafe IEnumerator<float> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007DD9 RID: 32217
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007DDA RID: 32218
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007DDB RID: 32219
			private static readonly IntPtr NativeFieldInfoPtr_end;

			// Token: 0x04007DDC RID: 32220
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x04007DDD RID: 32221
			private static readonly IntPtr NativeFieldInfoPtr_driver;

			// Token: 0x04007DDE RID: 32222
			private static readonly IntPtr NativeFieldInfoPtr_ease;

			// Token: 0x04007DDF RID: 32223
			private static readonly IntPtr NativeFieldInfoPtr_total;

			// Token: 0x04007DE0 RID: 32224
			private static readonly IntPtr NativeFieldInfoPtr__distance_5__2;

			// Token: 0x04007DE1 RID: 32225
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04007DE2 RID: 32226
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007DE3 RID: 32227
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007DE4 RID: 32228
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007DE5 RID: 32229
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04007DE6 RID: 32230
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007DE7 RID: 32231
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007DE8 RID: 32232
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020007BE RID: 1982
		[ObfuscatedName("Interpolate+<NewTimer>d__3")]
		public sealed class _NewTimer_d__3 : Il2CppSystem.Object
		{
			// Token: 0x0600BAA9 RID: 47785 RVA: 0x002E437C File Offset: 0x002E257C
			// Note: this type is marked as 'beforefieldinit'.
			static _NewTimer_d__3()
			{
				Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, "<NewTimer>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr);
				Interpolate._NewTimer_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, "<>1__state");
				Interpolate._NewTimer_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, "<>2__current");
				Interpolate._NewTimer_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, "<>l__initialThreadId");
				Interpolate._NewTimer_d__3.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, "duration");
				Interpolate._NewTimer_d__3.NativeFieldInfoPtr___3__duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, "<>3__duration");
				Interpolate._NewTimer_d__3.NativeFieldInfoPtr__elapsedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, "<elapsedTime>5__2");
				Interpolate._NewTimer_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, 100663824);
				Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, 100663825);
				Interpolate._NewTimer_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, 100663826);
				Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Single__get_Current_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, 100663827);
				Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, 100663828);
				Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, 100663829);
				Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Single__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, 100663830);
				Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, 100663831);
			}

			// Token: 0x0600BAAA RID: 47786 RVA: 0x002E44C0 File Offset: 0x002E26C0
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 74969, RefRangeEnd = 74977, XrefRangeStart = 74969, XrefRangeEnd = 74977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _NewTimer_d__3(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewTimer_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAAB RID: 47787 RVA: 0x002E4508 File Offset: 0x002E2708
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAAC RID: 47788 RVA: 0x002E453C File Offset: 0x002E273C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewTimer_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170039AB RID: 14763
			// (get) Token: 0x0600BAAD RID: 47789 RVA: 0x002E4578 File Offset: 0x002E2778
			public unsafe float Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Single__get_Current_Private_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BAAE RID: 47790 RVA: 0x002E45B4 File Offset: 0x002E27B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75031, XrefRangeEnd = 75036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170039AC RID: 14764
			// (get) Token: 0x0600BAAF RID: 47791 RVA: 0x002E45E8 File Offset: 0x002E27E8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75036, XrefRangeEnd = 75039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BAB0 RID: 47792 RVA: 0x002E4628 File Offset: 0x002E2828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75039, XrefRangeEnd = 75046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<float> System_Collections_Generic_IEnumerable_System_Single__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Single__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<float>>(intPtr3) : null;
			}

			// Token: 0x0600BAB1 RID: 47793 RVA: 0x002E4668 File Offset: 0x002E2868
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BAB2 RID: 47794 RVA: 0x0005B58A File Offset: 0x0005978A
			public _NewTimer_d__3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039A5 RID: 14757
			// (get) Token: 0x0600BAB3 RID: 47795 RVA: 0x002E46A8 File Offset: 0x002E28A8
			// (set) Token: 0x0600BAB4 RID: 47796 RVA: 0x0005B593 File Offset: 0x00059793
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170039A6 RID: 14758
			// (get) Token: 0x0600BAB5 RID: 47797 RVA: 0x002E46D0 File Offset: 0x002E28D0
			// (set) Token: 0x0600BAB6 RID: 47798 RVA: 0x0005B5AE File Offset: 0x000597AE
			public unsafe float __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x170039A7 RID: 14759
			// (get) Token: 0x0600BAB7 RID: 47799 RVA: 0x002E46F8 File Offset: 0x002E28F8
			// (set) Token: 0x0600BAB8 RID: 47800 RVA: 0x0005B5C9 File Offset: 0x000597C9
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170039A8 RID: 14760
			// (get) Token: 0x0600BAB9 RID: 47801 RVA: 0x002E4720 File Offset: 0x002E2920
			// (set) Token: 0x0600BABA RID: 47802 RVA: 0x0005B5E4 File Offset: 0x000597E4
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x170039A9 RID: 14761
			// (get) Token: 0x0600BABB RID: 47803 RVA: 0x002E4748 File Offset: 0x002E2948
			// (set) Token: 0x0600BABC RID: 47804 RVA: 0x0005B5FF File Offset: 0x000597FF
			public unsafe float __3__duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr___3__duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr___3__duration)) = value;
				}
			}

			// Token: 0x170039AA RID: 14762
			// (get) Token: 0x0600BABD RID: 47805 RVA: 0x002E4770 File Offset: 0x002E2970
			// (set) Token: 0x0600BABE RID: 47806 RVA: 0x0005B61A File Offset: 0x0005981A
			public unsafe float _elapsedTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr__elapsedTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr__elapsedTime_5__2)) = value;
				}
			}

			// Token: 0x04007DE9 RID: 32233
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007DEA RID: 32234
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007DEB RID: 32235
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007DEC RID: 32236
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04007DED RID: 32237
			private static readonly IntPtr NativeFieldInfoPtr___3__duration;

			// Token: 0x04007DEE RID: 32238
			private static readonly IntPtr NativeFieldInfoPtr__elapsedTime_5__2;

			// Token: 0x04007DEF RID: 32239
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007DF0 RID: 32240
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007DF1 RID: 32241
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007DF2 RID: 32242
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Single__get_Current_Private_Virtual_Final_New_get_Single_0;

			// Token: 0x04007DF3 RID: 32243
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007DF4 RID: 32244
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007DF5 RID: 32245
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Single__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Single_0;

			// Token: 0x04007DF6 RID: 32246
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020007BF RID: 1983
		private sealed class MethodInfoStoreGeneric_NewBezier_Private_Static_IEnumerable_1_Vector3_Function_IList_ToVector3_1_T_Single_IEnumerable_1_Single_0<T>
		{
			// Token: 0x04007DF7 RID: 32247
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Interpolate.NativeMethodInfoPtr_NewBezier_Private_Static_IEnumerable_1_Vector3_Function_IList_ToVector3_1_T_Single_IEnumerable_1_Single_0, Il2CppClassPointerStore<Interpolate>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020007C0 RID: 1984
		private sealed class MethodInfoStoreGeneric_NewCatmullRom_Private_Static_IEnumerable_1_Vector3_IList_ToVector3_1_T_Int32_Boolean_0<T>
		{
			// Token: 0x04007DF8 RID: 32248
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Interpolate.NativeMethodInfoPtr_NewCatmullRom_Private_Static_IEnumerable_1_Vector3_IList_ToVector3_1_T_Int32_Boolean_0, Il2CppClassPointerStore<Interpolate>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
