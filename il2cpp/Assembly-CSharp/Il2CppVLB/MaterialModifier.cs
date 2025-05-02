using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000A0 RID: 160
	public static class MaterialModifier : Il2CppSystem.Object
	{
		// Token: 0x06000B0F RID: 2831 RVA: 0x00007AC1 File Offset: 0x00005CC1
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialModifier()
		{
			Il2CppClassPointerStore<MaterialModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "MaterialModifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialModifier>.NativeClassPtr);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00007AE6 File Offset: 0x00005CE6
		public MaterialModifier(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x02000829 RID: 2089
		public class Interface : Il2CppObjectBase
		{
			// Token: 0x0600BEAA RID: 48810 RVA: 0x002ECA04 File Offset: 0x002EAC04
			// Note: this type is marked as 'beforefieldinit'.
			static Interface()
			{
				Il2CppClassPointerStore<MaterialModifier.Interface>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialModifier>.NativeClassPtr, "Interface");
				MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Interface>.NativeClassPtr, 100664585);
				MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Interface>.NativeClassPtr, 100664586);
				MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Interface>.NativeClassPtr, 100664587);
				MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Interface>.NativeClassPtr, 100664588);
				MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Interface>.NativeClassPtr, 100664589);
			}

			// Token: 0x0600BEAB RID: 48811 RVA: 0x002ECA8C File Offset: 0x002EAC8C
			[CallerCount(0)]
			public unsafe virtual void SetMaterialProp(int nameID, float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref nameID;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEAC RID: 48812 RVA: 0x002ECAE4 File Offset: 0x002EACE4
			[CallerCount(0)]
			public unsafe virtual void SetMaterialProp(int nameID, Vector4 value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref nameID;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Vector4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEAD RID: 48813 RVA: 0x002ECB3C File Offset: 0x002EAD3C
			[CallerCount(0)]
			public unsafe virtual void SetMaterialProp(int nameID, Color value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref nameID;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEAE RID: 48814 RVA: 0x002ECB94 File Offset: 0x002EAD94
			[CallerCount(0)]
			public unsafe virtual void SetMaterialProp(int nameID, Matrix4x4 value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref nameID;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Matrix4x4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEAF RID: 48815 RVA: 0x002ECBEC File Offset: 0x002EADEC
			[CallerCount(0)]
			public unsafe virtual void SetMaterialProp(int nameID, Texture value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref nameID;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEB0 RID: 48816 RVA: 0x0005D3C3 File Offset: 0x0005B5C3
			public Interface(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400812F RID: 33071
			private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Single_0;

			// Token: 0x04008130 RID: 33072
			private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Vector4_0;

			// Token: 0x04008131 RID: 33073
			private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Color_0;

			// Token: 0x04008132 RID: 33074
			private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Matrix4x4_0;

			// Token: 0x04008133 RID: 33075
			private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Texture_0;
		}

		// Token: 0x0200082A RID: 2090
		public sealed class Callback : MulticastDelegate
		{
			// Token: 0x0600BEB1 RID: 48817 RVA: 0x002ECC48 File Offset: 0x002EAE48
			// Note: this type is marked as 'beforefieldinit'.
			static Callback()
			{
				Il2CppClassPointerStore<MaterialModifier.Callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialModifier>.NativeClassPtr, "Callback");
				MaterialModifier.Callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Callback>.NativeClassPtr, 100664590);
				MaterialModifier.Callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Interface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Callback>.NativeClassPtr, 100664591);
				MaterialModifier.Callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Interface_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Callback>.NativeClassPtr, 100664592);
				MaterialModifier.Callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Callback>.NativeClassPtr, 100664593);
			}

			// Token: 0x0600BEB2 RID: 48818 RVA: 0x002ECCBC File Offset: 0x002EAEBC
			[CallerCount(632)]
			[CachedScanResults(RefRangeStart = 81889, RefRangeEnd = 82521, XrefRangeStart = 81880, XrefRangeEnd = 81889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Callback(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialModifier.Callback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialModifier.Callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEB3 RID: 48819 RVA: 0x002ECD18 File Offset: 0x002EAF18
			[CallerCount(0)]
			public unsafe void Invoke(MaterialModifier.Interface owner)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialModifier.Callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Interface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEB4 RID: 48820 RVA: 0x002ECD5C File Offset: 0x002EAF5C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74827, RefRangeEnd = 74828, XrefRangeStart = 74827, XrefRangeEnd = 74828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(MaterialModifier.Interface owner, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialModifier.Callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Interface_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600BEB5 RID: 48821 RVA: 0x002ECDD0 File Offset: 0x002EAFD0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialModifier.Callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEB6 RID: 48822 RVA: 0x0005D3CC File Offset: 0x0005B5CC
			public Callback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BEB7 RID: 48823 RVA: 0x0005D3D5 File Offset: 0x0005B5D5
			public static implicit operator MaterialModifier.Callback(Action<MaterialModifier.Interface> A_0)
			{
				return DelegateSupport.ConvertDelegate<MaterialModifier.Callback>(A_0);
			}

			// Token: 0x0600BEB8 RID: 48824 RVA: 0x0005D3DD File Offset: 0x0005B5DD
			public static MaterialModifier.Callback operator +(MaterialModifier.Callback A_0, MaterialModifier.Callback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<MaterialModifier.Callback>();
			}

			// Token: 0x0600BEB9 RID: 48825 RVA: 0x0005D3EB File Offset: 0x0005B5EB
			public static MaterialModifier.Callback operator -(MaterialModifier.Callback A_0, MaterialModifier.Callback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<MaterialModifier.Callback>();
				}
				return result;
			}

			// Token: 0x04008134 RID: 33076
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008135 RID: 33077
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Interface_0;

			// Token: 0x04008136 RID: 33078
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Interface_AsyncCallback_Object_0;

			// Token: 0x04008137 RID: 33079
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
