using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200000B RID: 11
	public class IKControl : MonoBehaviour
	{
		// Token: 0x06000111 RID: 273 RVA: 0x000740EC File Offset: 0x000722EC
		// Note: this type is marked as 'beforefieldinit'.
		static IKControl()
		{
			Il2CppClassPointerStore<IKControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "IKControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IKControl>.NativeClassPtr);
			IKControl.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IKControl>.NativeClassPtr, "animator");
			IKControl.NativeFieldInfoPtr_ikActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IKControl>.NativeClassPtr, "ikActive");
			IKControl.NativeFieldInfoPtr_rightHandObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IKControl>.NativeClassPtr, "rightHandObj");
			IKControl.NativeFieldInfoPtr_lookObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IKControl>.NativeClassPtr, "lookObj");
			IKControl.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKControl>.NativeClassPtr, 100663365);
			IKControl.NativeMethodInfoPtr_OnAnimatorIK_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKControl>.NativeClassPtr, 100663366);
			IKControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKControl>.NativeClassPtr, 100663367);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000741A8 File Offset: 0x000723A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71366, XrefRangeEnd = 71370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IKControl.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000741DC File Offset: 0x000723DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71370, XrefRangeEnd = 71377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAnimatorIK()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IKControl.NativeMethodInfoPtr_OnAnimatorIK_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00074210 File Offset: 0x00072410
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IKControl() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IKControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IKControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002ADA File Offset: 0x00000CDA
		public IKControl(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0007424C File Offset: 0x0007244C
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00002AE3 File Offset: 0x00000CE3
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IKControl.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IKControl.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0007427C File Offset: 0x0007247C
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00002B02 File Offset: 0x00000D02
		public unsafe bool ikActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IKControl.NativeFieldInfoPtr_ikActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IKControl.NativeFieldInfoPtr_ikActive)) = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000742A4 File Offset: 0x000724A4
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002B1D File Offset: 0x00000D1D
		public unsafe Transform rightHandObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IKControl.NativeFieldInfoPtr_rightHandObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IKControl.NativeFieldInfoPtr_rightHandObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000742D4 File Offset: 0x000724D4
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002B3C File Offset: 0x00000D3C
		public unsafe Transform lookObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IKControl.NativeFieldInfoPtr_lookObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IKControl.NativeFieldInfoPtr_lookObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr_ikActive;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_rightHandObj;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_lookObj;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_OnAnimatorIK_Private_Void_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
