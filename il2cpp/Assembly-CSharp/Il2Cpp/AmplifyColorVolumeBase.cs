using System;
using Il2CppAmplifyColor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200000A RID: 10
	public class AmplifyColorVolumeBase : MonoBehaviour
	{
		// Token: 0x06000100 RID: 256 RVA: 0x00073E64 File Offset: 0x00072064
		// Note: this type is marked as 'beforefieldinit'.
		static AmplifyColorVolumeBase()
		{
			Il2CppClassPointerStore<AmplifyColorVolumeBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AmplifyColorVolumeBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmplifyColorVolumeBase>.NativeClassPtr);
			AmplifyColorVolumeBase.NativeFieldInfoPtr_LutTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorVolumeBase>.NativeClassPtr, "LutTexture");
			AmplifyColorVolumeBase.NativeFieldInfoPtr_Exposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorVolumeBase>.NativeClassPtr, "Exposure");
			AmplifyColorVolumeBase.NativeFieldInfoPtr_EnterBlendTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorVolumeBase>.NativeClassPtr, "EnterBlendTime");
			AmplifyColorVolumeBase.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorVolumeBase>.NativeClassPtr, "Priority");
			AmplifyColorVolumeBase.NativeFieldInfoPtr_ShowInSceneView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorVolumeBase>.NativeClassPtr, "ShowInSceneView");
			AmplifyColorVolumeBase.NativeFieldInfoPtr_EffectContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorVolumeBase>.NativeClassPtr, "EffectContainer");
			AmplifyColorVolumeBase.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorVolumeBase>.NativeClassPtr, 100663362);
			AmplifyColorVolumeBase.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorVolumeBase>.NativeClassPtr, 100663363);
			AmplifyColorVolumeBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorVolumeBase>.NativeClassPtr, 100663364);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00073F48 File Offset: 0x00072148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71306, XrefRangeEnd = 71332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorVolumeBase.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00073F7C File Offset: 0x0007217C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71332, XrefRangeEnd = 71358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorVolumeBase.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00073FB0 File Offset: 0x000721B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 71364, RefRangeEnd = 71366, XrefRangeStart = 71358, XrefRangeEnd = 71364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmplifyColorVolumeBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmplifyColorVolumeBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorVolumeBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002A27 File Offset: 0x00000C27
		public AmplifyColorVolumeBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00073FEC File Offset: 0x000721EC
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00002A30 File Offset: 0x00000C30
		public unsafe Texture2D LutTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorVolumeBase.NativeFieldInfoPtr_LutTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorVolumeBase.NativeFieldInfoPtr_LutTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0007401C File Offset: 0x0007221C
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00002A4F File Offset: 0x00000C4F
		public unsafe float Exposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorVolumeBase.NativeFieldInfoPtr_Exposure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorVolumeBase.NativeFieldInfoPtr_Exposure)) = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00074044 File Offset: 0x00072244
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00002A6A File Offset: 0x00000C6A
		public unsafe float EnterBlendTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorVolumeBase.NativeFieldInfoPtr_EnterBlendTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorVolumeBase.NativeFieldInfoPtr_EnterBlendTime)) = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0007406C File Offset: 0x0007226C
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002A85 File Offset: 0x00000C85
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorVolumeBase.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorVolumeBase.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00074094 File Offset: 0x00072294
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002AA0 File Offset: 0x00000CA0
		public unsafe bool ShowInSceneView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorVolumeBase.NativeFieldInfoPtr_ShowInSceneView);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorVolumeBase.NativeFieldInfoPtr_ShowInSceneView)) = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000740BC File Offset: 0x000722BC
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00002ABB File Offset: 0x00000CBB
		public unsafe VolumeEffectContainer EffectContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorVolumeBase.NativeFieldInfoPtr_EffectContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffectContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorVolumeBase.NativeFieldInfoPtr_EffectContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_LutTexture;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_Exposure;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_EnterBlendTime;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_ShowInSceneView;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_EffectContainer;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
