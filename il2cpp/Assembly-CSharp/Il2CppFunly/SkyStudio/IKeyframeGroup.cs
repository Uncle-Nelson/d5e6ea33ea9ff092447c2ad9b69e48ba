using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000F7 RID: 247
	public class IKeyframeGroup : Il2CppObjectBase
	{
		// Token: 0x060012E6 RID: 4838 RVA: 0x000AC5EC File Offset: 0x000AA7EC
		// Note: this type is marked as 'beforefieldinit'.
		static IKeyframeGroup()
		{
			Il2CppClassPointerStore<IKeyframeGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "IKeyframeGroup");
			IKeyframeGroup.NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyframeGroup>.NativeClassPtr, 100665461);
			IKeyframeGroup.NativeMethodInfoPtr_set_name_Public_Abstract_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyframeGroup>.NativeClassPtr, 100665462);
			IKeyframeGroup.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyframeGroup>.NativeClassPtr, 100665463);
			IKeyframeGroup.NativeMethodInfoPtr_SortKeyframes_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyframeGroup>.NativeClassPtr, 100665464);
			IKeyframeGroup.NativeMethodInfoPtr_TrimToSingleKeyframe_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyframeGroup>.NativeClassPtr, 100665465);
			IKeyframeGroup.NativeMethodInfoPtr_RemoveKeyFrame_Public_Abstract_Virtual_New_Void_IBaseKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyframeGroup>.NativeClassPtr, 100665466);
			IKeyframeGroup.NativeMethodInfoPtr_GetKeyFrameCount_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyframeGroup>.NativeClassPtr, 100665467);
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x000AC6A0 File Offset: 0x000AA8A0
		// (set) Token: 0x060012E8 RID: 4840 RVA: 0x000AC6E4 File Offset: 0x000AA8E4
		public unsafe virtual string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyframeGroup.NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyframeGroup.NativeMethodInfoPtr_set_name_Public_Abstract_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x000AC734 File Offset: 0x000AA934
		public unsafe virtual string id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyframeGroup.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x000AC778 File Offset: 0x000AA978
		[CallerCount(0)]
		public unsafe virtual void SortKeyframes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyframeGroup.NativeMethodInfoPtr_SortKeyframes_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x000AC7B4 File Offset: 0x000AA9B4
		[CallerCount(0)]
		public unsafe virtual void TrimToSingleKeyframe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyframeGroup.NativeMethodInfoPtr_TrimToSingleKeyframe_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x000AC7F0 File Offset: 0x000AA9F0
		[CallerCount(0)]
		public unsafe virtual void RemoveKeyFrame(IBaseKeyframe keyframe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyframe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyframeGroup.NativeMethodInfoPtr_RemoveKeyFrame_Public_Abstract_Virtual_New_Void_IBaseKeyframe_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x000AC840 File Offset: 0x000AAA40
		[CallerCount(0)]
		public unsafe virtual int GetKeyFrameCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyframeGroup.NativeMethodInfoPtr_GetKeyFrameCount_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0000B5C4 File Offset: 0x000097C4
		public IKeyframeGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_Abstract_Virtual_New_set_Void_String_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr_SortKeyframes_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr_TrimToSingleKeyframe_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKeyFrame_Public_Abstract_Virtual_New_Void_IBaseKeyframe_0;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyFrameCount_Public_Abstract_Virtual_New_Int32_0;
	}
}
