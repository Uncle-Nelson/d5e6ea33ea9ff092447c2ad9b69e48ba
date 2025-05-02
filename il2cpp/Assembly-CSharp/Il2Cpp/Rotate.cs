using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000018 RID: 24
	public class Rotate : MonoBehaviour
	{
		// Token: 0x06000193 RID: 403 RVA: 0x000759AC File Offset: 0x00073BAC
		// Note: this type is marked as 'beforefieldinit'.
		static Rotate()
		{
			Il2CppClassPointerStore<Rotate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Rotate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rotate>.NativeClassPtr);
			Rotate.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotate>.NativeClassPtr, "Speed");
			Rotate.NativeFieldInfoPtr_Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotate>.NativeClassPtr, "Axis");
			Rotate.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotate>.NativeClassPtr, 100663443);
			Rotate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotate>.NativeClassPtr, 100663444);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00075A2C File Offset: 0x00073C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72160, XrefRangeEnd = 72163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotate.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00075A60 File Offset: 0x00073C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72163, XrefRangeEnd = 72166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rotate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rotate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002DF9 File Offset: 0x00000FF9
		public Rotate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00075A9C File Offset: 0x00073C9C
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002E02 File Offset: 0x00001002
		public unsafe float Speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rotate.NativeFieldInfoPtr_Speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rotate.NativeFieldInfoPtr_Speed)) = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00075AC4 File Offset: 0x00073CC4
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00002E1D File Offset: 0x0000101D
		public unsafe Vector3 Axis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rotate.NativeFieldInfoPtr_Axis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rotate.NativeFieldInfoPtr_Axis)) = value;
			}
		}

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeFieldInfoPtr_Speed;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr_Axis;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
