using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000128 RID: 296
	public class LightningSpawnArea : MonoBehaviour
	{
		// Token: 0x06001961 RID: 6497 RVA: 0x000BFEEC File Offset: 0x000BE0EC
		// Note: this type is marked as 'beforefieldinit'.
		static LightningSpawnArea()
		{
			Il2CppClassPointerStore<LightningSpawnArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "LightningSpawnArea");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningSpawnArea>.NativeClassPtr);
			LightningSpawnArea.NativeFieldInfoPtr_lightningArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningSpawnArea>.NativeClassPtr, "lightningArea");
			LightningSpawnArea.NativeMethodInfoPtr_OnDrawGizmosSelected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningSpawnArea>.NativeClassPtr, 100666001);
			LightningSpawnArea.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningSpawnArea>.NativeClassPtr, 100666002);
			LightningSpawnArea.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningSpawnArea>.NativeClassPtr, 100666003);
			LightningSpawnArea.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningSpawnArea>.NativeClassPtr, 100666004);
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x000BFF80 File Offset: 0x000BE180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96223, XrefRangeEnd = 96238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningSpawnArea.NativeMethodInfoPtr_OnDrawGizmosSelected_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x000BFFB4 File Offset: 0x000BE1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96238, XrefRangeEnd = 96254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningSpawnArea.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x000BFFE8 File Offset: 0x000BE1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96254, XrefRangeEnd = 96270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningSpawnArea.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x000C001C File Offset: 0x000BE21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96270, XrefRangeEnd = 96271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightningSpawnArea() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningSpawnArea>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningSpawnArea.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x0000E777 File Offset: 0x0000C977
		public LightningSpawnArea(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x000C0058 File Offset: 0x000BE258
		// (set) Token: 0x06001968 RID: 6504 RVA: 0x0000E780 File Offset: 0x0000C980
		public unsafe Vector3 lightningArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningSpawnArea.NativeFieldInfoPtr_lightningArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningSpawnArea.NativeFieldInfoPtr_lightningArea)) = value;
			}
		}

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeFieldInfoPtr_lightningArea;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Public_Void_0;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
