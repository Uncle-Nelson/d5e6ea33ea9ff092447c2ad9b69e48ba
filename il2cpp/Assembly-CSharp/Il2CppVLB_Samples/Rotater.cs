using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppVLB_Samples
{
	// Token: 0x020000BE RID: 190
	public class Rotater : MonoBehaviour
	{
		// Token: 0x06000E2E RID: 3630 RVA: 0x0009E160 File Offset: 0x0009C360
		// Note: this type is marked as 'beforefieldinit'.
		static Rotater()
		{
			Il2CppClassPointerStore<Rotater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB_Samples", "Rotater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rotater>.NativeClassPtr);
			Rotater.NativeFieldInfoPtr_EulerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotater>.NativeClassPtr, "EulerSpeed");
			Rotater.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotater>.NativeClassPtr, 100665031);
			Rotater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotater>.NativeClassPtr, 100665032);
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x0009E1CC File Offset: 0x0009C3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85684, XrefRangeEnd = 85692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotater.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0009E200 File Offset: 0x0009C400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rotater() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rotater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00008DB2 File Offset: 0x00006FB2
		public Rotater(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x0009E23C File Offset: 0x0009C43C
		// (set) Token: 0x06000E33 RID: 3635 RVA: 0x00008DBB File Offset: 0x00006FBB
		public unsafe Vector3 EulerSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rotater.NativeFieldInfoPtr_EulerSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rotater.NativeFieldInfoPtr_EulerSpeed)) = value;
			}
		}

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeFieldInfoPtr_EulerSpeed;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
