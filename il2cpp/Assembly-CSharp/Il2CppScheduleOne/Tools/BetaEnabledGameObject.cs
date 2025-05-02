using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200052D RID: 1325
	public class BetaEnabledGameObject : MonoBehaviour
	{
		// Token: 0x0600765D RID: 30301 RVA: 0x00202F90 File Offset: 0x00201190
		// Note: this type is marked as 'beforefieldinit'.
		static BetaEnabledGameObject()
		{
			Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "BetaEnabledGameObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr);
			BetaEnabledGameObject.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr, 100678202);
			BetaEnabledGameObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr, 100678203);
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x00202FE8 File Offset: 0x002011E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230925, XrefRangeEnd = 230929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BetaEnabledGameObject.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600765F RID: 30303 RVA: 0x0020301C File Offset: 0x0020121C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BetaEnabledGameObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BetaEnabledGameObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007660 RID: 30304 RVA: 0x0003819A File Offset: 0x0003639A
		public BetaEnabledGameObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040050DD RID: 20701
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040050DE RID: 20702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
