using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003BA RID: 954
	public class UsableLightSource : MonoBehaviour
	{
		// Token: 0x06004A52 RID: 19026 RVA: 0x00168A5C File Offset: 0x00166C5C
		// Note: this type is marked as 'beforefieldinit'.
		static UsableLightSource()
		{
			Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "UsableLightSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr);
			UsableLightSource.NativeFieldInfoPtr_GrowSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr, "GrowSpeedMultiplier");
			UsableLightSource.NativeFieldInfoPtr_isEmitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr, "isEmitting");
			UsableLightSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr, 100672509);
		}

		// Token: 0x06004A53 RID: 19027 RVA: 0x00168AC8 File Offset: 0x00166CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164011, XrefRangeEnd = 164012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UsableLightSource() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UsableLightSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x00023DB7 File Offset: 0x00021FB7
		public UsableLightSource(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x06004A55 RID: 19029 RVA: 0x00168B04 File Offset: 0x00166D04
		// (set) Token: 0x06004A56 RID: 19030 RVA: 0x00023DC0 File Offset: 0x00021FC0
		public unsafe float GrowSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsableLightSource.NativeFieldInfoPtr_GrowSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsableLightSource.NativeFieldInfoPtr_GrowSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06004A57 RID: 19031 RVA: 0x00168B2C File Offset: 0x00166D2C
		// (set) Token: 0x06004A58 RID: 19032 RVA: 0x00023DDB File Offset: 0x00021FDB
		public unsafe bool isEmitting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsableLightSource.NativeFieldInfoPtr_isEmitting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsableLightSource.NativeFieldInfoPtr_isEmitting)) = value;
			}
		}

		// Token: 0x04003211 RID: 12817
		private static readonly IntPtr NativeFieldInfoPtr_GrowSpeedMultiplier;

		// Token: 0x04003212 RID: 12818
		private static readonly IntPtr NativeFieldInfoPtr_isEmitting;

		// Token: 0x04003213 RID: 12819
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
