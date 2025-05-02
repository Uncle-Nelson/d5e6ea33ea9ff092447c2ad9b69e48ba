using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Impostors
{
	// Token: 0x020005FC RID: 1532
	public class AvatarImpostor : MonoBehaviour
	{
		// Token: 0x06008710 RID: 34576 RVA: 0x0023AE40 File Offset: 0x00239040
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarImpostor()
		{
			Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Impostors", "AvatarImpostor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr);
			AvatarImpostor.NativeFieldInfoPtr__HasTexture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, "<HasTexture>k__BackingField");
			AvatarImpostor.NativeFieldInfoPtr_meshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, "meshRenderer");
			AvatarImpostor.NativeFieldInfoPtr_cachedCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, "cachedCamera");
			AvatarImpostor.NativeMethodInfoPtr_get_HasTexture_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680160);
			AvatarImpostor.NativeMethodInfoPtr_set_HasTexture_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680161);
			AvatarImpostor.NativeMethodInfoPtr_get_Camera_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680162);
			AvatarImpostor.NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680163);
			AvatarImpostor.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680164);
			AvatarImpostor.NativeMethodInfoPtr_Realign_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680165);
			AvatarImpostor.NativeMethodInfoPtr_EnableImpostor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680166);
			AvatarImpostor.NativeMethodInfoPtr_DisableImpostor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680167);
			AvatarImpostor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680168);
		}

		// Token: 0x1700290F RID: 10511
		// (get) Token: 0x06008711 RID: 34577 RVA: 0x0023AF60 File Offset: 0x00239160
		// (set) Token: 0x06008712 RID: 34578 RVA: 0x0023AF9C File Offset: 0x0023919C
		public unsafe bool HasTexture
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_get_HasTexture_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_set_HasTexture_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002910 RID: 10512
		// (get) Token: 0x06008713 RID: 34579 RVA: 0x0023AFDC File Offset: 0x002391DC
		public unsafe Transform Camera
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 251507, RefRangeEnd = 251509, XrefRangeStart = 251496, XrefRangeEnd = 251507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_get_Camera_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06008714 RID: 34580 RVA: 0x0023B01C File Offset: 0x0023921C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251509, XrefRangeEnd = 251515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAvatarSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008715 RID: 34581 RVA: 0x0023B060 File Offset: 0x00239260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251515, XrefRangeEnd = 251516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008716 RID: 34582 RVA: 0x0023B094 File Offset: 0x00239294
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 251530, RefRangeEnd = 251533, XrefRangeStart = 251516, XrefRangeEnd = 251530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Realign()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_Realign_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008717 RID: 34583 RVA: 0x0023B0C8 File Offset: 0x002392C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251533, XrefRangeEnd = 251537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableImpostor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_EnableImpostor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008718 RID: 34584 RVA: 0x0023B0FC File Offset: 0x002392FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194914, RefRangeEnd = 194915, XrefRangeStart = 194914, XrefRangeEnd = 194915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableImpostor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_DisableImpostor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008719 RID: 34585 RVA: 0x0023B130 File Offset: 0x00239330
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarImpostor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600871A RID: 34586 RVA: 0x0004042F File Offset: 0x0003E62F
		public AvatarImpostor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700290C RID: 10508
		// (get) Token: 0x0600871B RID: 34587 RVA: 0x0023B16C File Offset: 0x0023936C
		// (set) Token: 0x0600871C RID: 34588 RVA: 0x00040438 File Offset: 0x0003E638
		public unsafe bool _HasTexture_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr__HasTexture_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr__HasTexture_k__BackingField)) = value;
			}
		}

		// Token: 0x1700290D RID: 10509
		// (get) Token: 0x0600871D RID: 34589 RVA: 0x0023B194 File Offset: 0x00239394
		// (set) Token: 0x0600871E RID: 34590 RVA: 0x00040453 File Offset: 0x0003E653
		public unsafe MeshRenderer meshRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr_meshRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr_meshRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700290E RID: 10510
		// (get) Token: 0x0600871F RID: 34591 RVA: 0x0023B1C4 File Offset: 0x002393C4
		// (set) Token: 0x06008720 RID: 34592 RVA: 0x00040472 File Offset: 0x0003E672
		public unsafe Transform cachedCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr_cachedCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr_cachedCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BE7 RID: 23527
		private static readonly IntPtr NativeFieldInfoPtr__HasTexture_k__BackingField;

		// Token: 0x04005BE8 RID: 23528
		private static readonly IntPtr NativeFieldInfoPtr_meshRenderer;

		// Token: 0x04005BE9 RID: 23529
		private static readonly IntPtr NativeFieldInfoPtr_cachedCamera;

		// Token: 0x04005BEA RID: 23530
		private static readonly IntPtr NativeMethodInfoPtr_get_HasTexture_Public_get_Boolean_0;

		// Token: 0x04005BEB RID: 23531
		private static readonly IntPtr NativeMethodInfoPtr_set_HasTexture_Private_set_Void_Boolean_0;

		// Token: 0x04005BEC RID: 23532
		private static readonly IntPtr NativeMethodInfoPtr_get_Camera_Private_get_Transform_0;

		// Token: 0x04005BED RID: 23533
		private static readonly IntPtr NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005BEE RID: 23534
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005BEF RID: 23535
		private static readonly IntPtr NativeMethodInfoPtr_Realign_Private_Void_0;

		// Token: 0x04005BF0 RID: 23536
		private static readonly IntPtr NativeMethodInfoPtr_EnableImpostor_Public_Void_0;

		// Token: 0x04005BF1 RID: 23537
		private static readonly IntPtr NativeMethodInfoPtr_DisableImpostor_Public_Void_0;

		// Token: 0x04005BF2 RID: 23538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
