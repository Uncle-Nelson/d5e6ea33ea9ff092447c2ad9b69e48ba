using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000E5 RID: 229
	public class BlendingHelper : Il2CppSystem.Object
	{
		// Token: 0x0600122B RID: 4651 RVA: 0x000A9618 File Offset: 0x000A7818
		// Note: this type is marked as 'beforefieldinit'.
		static BlendingHelper()
		{
			Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BlendingHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr);
			BlendingHelper.NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, "m_State");
			BlendingHelper.NativeMethodInfoPtr__ctor_Public_Void_ProfileBlendingState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665369);
			BlendingHelper.NativeMethodInfoPtr_UpdateState_Public_Void_ProfileBlendingState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665370);
			BlendingHelper.NativeMethodInfoPtr_ProfileColorForKey_Public_Color_SkyProfile_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665371);
			BlendingHelper.NativeMethodInfoPtr_ProfileNumberForKey_Public_Single_SkyProfile_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665372);
			BlendingHelper.NativeMethodInfoPtr_ProfileSpherePointForKey_Public_SpherePoint_SkyProfile_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665373);
			BlendingHelper.NativeMethodInfoPtr_BlendColor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665374);
			BlendingHelper.NativeMethodInfoPtr_BlendColorOut_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665375);
			BlendingHelper.NativeMethodInfoPtr_BlendColorIn_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665376);
			BlendingHelper.NativeMethodInfoPtr_BlendColor_Public_Void_String_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665377);
			BlendingHelper.NativeMethodInfoPtr_BlendNumber_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665378);
			BlendingHelper.NativeMethodInfoPtr_BlendNumberOut_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665379);
			BlendingHelper.NativeMethodInfoPtr_BlendNumberIn_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665380);
			BlendingHelper.NativeMethodInfoPtr_BlendNumber_Public_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665381);
			BlendingHelper.NativeMethodInfoPtr_BlendSpherePoint_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665382);
			BlendingHelper.NativeMethodInfoPtr_BlendSpherePoint_Public_Void_String_SpherePoint_SpherePoint_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665383);
			BlendingHelper.NativeMethodInfoPtr_GetFeatureAnimationMode_Public_ProfileFeatureBlendingMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665384);
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x000A979C File Offset: 0x000A799C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88934, XrefRangeEnd = 88936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlendingHelper(ProfileBlendingState state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr__ctor_Public_Void_ProfileBlendingState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x000A97EC File Offset: 0x000A79EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88936, XrefRangeEnd = 88937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateState(ProfileBlendingState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_UpdateState_Public_Void_ProfileBlendingState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x000A9834 File Offset: 0x000A7A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88937, XrefRangeEnd = 88946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color ProfileColorForKey(SkyProfile profile, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_ProfileColorForKey_Public_Color_SkyProfile_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x000A9894 File Offset: 0x000A7A94
		[CallerCount(132)]
		[CachedScanResults(RefRangeStart = 88956, RefRangeEnd = 89088, XrefRangeStart = 88946, XrefRangeEnd = 88956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ProfileNumberForKey(SkyProfile profile, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_ProfileNumberForKey_Public_Single_SkyProfile_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x000A98F4 File Offset: 0x000A7AF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 89098, RefRangeEnd = 89100, XrefRangeStart = 89088, XrefRangeEnd = 89098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePoint ProfileSpherePointForKey(SkyProfile profile, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_ProfileSpherePointForKey_Public_SpherePoint_SkyProfile_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpherePoint>(intPtr3) : null;
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x000A9958 File Offset: 0x000A7B58
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 89118, RefRangeEnd = 89141, XrefRangeStart = 89100, XrefRangeEnd = 89118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendColor(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendColor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x000A999C File Offset: 0x000A7B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89141, XrefRangeEnd = 89159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendColorOut(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendColorOut_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x000A99E0 File Offset: 0x000A7BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89159, XrefRangeEnd = 89177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendColorIn(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendColorIn_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x000A9A24 File Offset: 0x000A7C24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 89183, RefRangeEnd = 89186, XrefRangeStart = 89177, XrefRangeEnd = 89183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendColor(string key, Color from, Color to, float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendColor_Public_Void_String_Color_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x000A9A90 File Offset: 0x000A7C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89186, XrefRangeEnd = 89189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendNumber(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendNumber_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x000A9AD4 File Offset: 0x000A7CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89189, XrefRangeEnd = 89191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendNumberOut(string key, float toValue = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendNumberOut_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x000A9B24 File Offset: 0x000A7D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89191, XrefRangeEnd = 89193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendNumberIn(string key, float fromValue = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendNumberIn_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x000A9B74 File Offset: 0x000A7D74
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 89200, RefRangeEnd = 89279, XrefRangeStart = 89193, XrefRangeEnd = 89200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendNumber(string key, float from, float to, float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendNumber_Public_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x000A9BE0 File Offset: 0x000A7DE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 89300, RefRangeEnd = 89302, XrefRangeStart = 89279, XrefRangeEnd = 89300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendSpherePoint(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendSpherePoint_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x000A9C24 File Offset: 0x000A7E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89302, XrefRangeEnd = 89318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendSpherePoint(string key, SpherePoint from, SpherePoint to, float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(from);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendSpherePoint_Public_Void_String_SpherePoint_SpherePoint_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x000A9C98 File Offset: 0x000A7E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89318, XrefRangeEnd = 89320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfileFeatureBlendingMode GetFeatureAnimationMode(string featureKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(featureKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_GetFeatureAnimationMode_Public_ProfileFeatureBlendingMode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0000B111 File Offset: 0x00009311
		public BlendingHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x000A9CE8 File Offset: 0x000A7EE8
		// (set) Token: 0x0600123E RID: 4670 RVA: 0x0000B11A File Offset: 0x0000931A
		public ProfileBlendingState m_State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendingHelper.NativeFieldInfoPtr_m_State);
				return new ProfileBlendingState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendingHelper.NativeFieldInfoPtr_m_State), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeFieldInfoPtr_m_State;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ProfileBlendingState_0;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr_UpdateState_Public_Void_ProfileBlendingState_0;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeMethodInfoPtr_ProfileColorForKey_Public_Color_SkyProfile_String_0;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr_ProfileNumberForKey_Public_Single_SkyProfile_String_0;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeMethodInfoPtr_ProfileSpherePointForKey_Public_SpherePoint_SkyProfile_String_0;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeMethodInfoPtr_BlendColor_Public_Void_String_0;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeMethodInfoPtr_BlendColorOut_Public_Void_String_0;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeMethodInfoPtr_BlendColorIn_Public_Void_String_0;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr_BlendColor_Public_Void_String_Color_Color_Single_0;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr_BlendNumber_Public_Void_String_0;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr_BlendNumberOut_Public_Void_String_Single_0;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr_BlendNumberIn_Public_Void_String_Single_0;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeMethodInfoPtr_BlendNumber_Public_Void_String_Single_Single_Single_0;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr_BlendSpherePoint_Public_Void_String_0;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr_BlendSpherePoint_Public_Void_String_SpherePoint_SpherePoint_Single_0;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr_GetFeatureAnimationMode_Public_ProfileFeatureBlendingMode_String_0;
	}
}
