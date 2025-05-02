using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000F2 RID: 242
	public class IFeatureBlender : Il2CppObjectBase
	{
		// Token: 0x060012C7 RID: 4807 RVA: 0x0000B496 File Offset: 0x00009696
		// Note: this type is marked as 'beforefieldinit'.
		static IFeatureBlender()
		{
			Il2CppClassPointerStore<IFeatureBlender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "IFeatureBlender");
			IFeatureBlender.NativeMethodInfoPtr_Blend_Public_Abstract_Virtual_New_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFeatureBlender>.NativeClassPtr, 100665453);
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x000AC014 File Offset: 0x000AA214
		[CallerCount(0)]
		public unsafe virtual void Blend(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFeatureBlender.NativeMethodInfoPtr_Blend_Public_Abstract_Virtual_New_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0000B4C5 File Offset: 0x000096C5
		public IFeatureBlender(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeMethodInfoPtr_Blend_Public_Abstract_Virtual_New_Void_ProfileBlendingState_BlendingHelper_0;
	}
}
