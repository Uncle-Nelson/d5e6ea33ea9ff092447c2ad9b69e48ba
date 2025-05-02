using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D4 RID: 1236
	public class ImpactSoundEntity : MonoBehaviour
	{
		// Token: 0x06006C27 RID: 27687 RVA: 0x001E0A3C File Offset: 0x001DEC3C
		// Note: this type is marked as 'beforefieldinit'.
		static ImpactSoundEntity()
		{
			Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "ImpactSoundEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr);
			ImpactSoundEntity.NativeFieldInfoPtr_MIN_IMPACT_MOMENTUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, "MIN_IMPACT_MOMENTUM");
			ImpactSoundEntity.NativeFieldInfoPtr_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, "COOLDOWN");
			ImpactSoundEntity.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, "Material");
			ImpactSoundEntity.NativeFieldInfoPtr_lastImpactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, "lastImpactTime");
			ImpactSoundEntity.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, "rb");
			ImpactSoundEntity.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, 100676968);
			ImpactSoundEntity.NativeMethodInfoPtr_OnImpacted_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, 100676969);
			ImpactSoundEntity.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, 100676970);
			ImpactSoundEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, 100676971);
		}

		// Token: 0x06006C28 RID: 27688 RVA: 0x001E0B20 File Offset: 0x001DED20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216819, XrefRangeEnd = 216846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactSoundEntity.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C29 RID: 27689 RVA: 0x001E0B54 File Offset: 0x001DED54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216846, XrefRangeEnd = 216859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnImpacted(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactSoundEntity.NativeMethodInfoPtr_OnImpacted_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C2A RID: 27690 RVA: 0x001E0B98 File Offset: 0x001DED98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216859, XrefRangeEnd = 216886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactSoundEntity.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C2B RID: 27691 RVA: 0x001E0BDC File Offset: 0x001DEDDC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImpactSoundEntity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactSoundEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C2C RID: 27692 RVA: 0x0003334D File Offset: 0x0003154D
		public ImpactSoundEntity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x06006C2D RID: 27693 RVA: 0x001E0C18 File Offset: 0x001DEE18
		// (set) Token: 0x06006C2E RID: 27694 RVA: 0x00033356 File Offset: 0x00031556
		public unsafe static float MIN_IMPACT_MOMENTUM
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ImpactSoundEntity.NativeFieldInfoPtr_MIN_IMPACT_MOMENTUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImpactSoundEntity.NativeFieldInfoPtr_MIN_IMPACT_MOMENTUM, (void*)(&value));
			}
		}

		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x06006C2F RID: 27695 RVA: 0x001E0C34 File Offset: 0x001DEE34
		// (set) Token: 0x06006C30 RID: 27696 RVA: 0x00033364 File Offset: 0x00031564
		public unsafe static float COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ImpactSoundEntity.NativeFieldInfoPtr_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImpactSoundEntity.NativeFieldInfoPtr_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17002085 RID: 8325
		// (get) Token: 0x06006C31 RID: 27697 RVA: 0x001E0C50 File Offset: 0x001DEE50
		// (set) Token: 0x06006C32 RID: 27698 RVA: 0x00033372 File Offset: 0x00031572
		public unsafe ImpactSoundEntity.EMaterial Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactSoundEntity.NativeFieldInfoPtr_Material);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactSoundEntity.NativeFieldInfoPtr_Material)) = value;
			}
		}

		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x06006C33 RID: 27699 RVA: 0x001E0C78 File Offset: 0x001DEE78
		// (set) Token: 0x06006C34 RID: 27700 RVA: 0x0003338D File Offset: 0x0003158D
		public unsafe float lastImpactTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactSoundEntity.NativeFieldInfoPtr_lastImpactTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactSoundEntity.NativeFieldInfoPtr_lastImpactTime)) = value;
			}
		}

		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x06006C35 RID: 27701 RVA: 0x001E0CA0 File Offset: 0x001DEEA0
		// (set) Token: 0x06006C36 RID: 27702 RVA: 0x000333A8 File Offset: 0x000315A8
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactSoundEntity.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactSoundEntity.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040049F5 RID: 18933
		private static readonly IntPtr NativeFieldInfoPtr_MIN_IMPACT_MOMENTUM;

		// Token: 0x040049F6 RID: 18934
		private static readonly IntPtr NativeFieldInfoPtr_COOLDOWN;

		// Token: 0x040049F7 RID: 18935
		private static readonly IntPtr NativeFieldInfoPtr_Material;

		// Token: 0x040049F8 RID: 18936
		private static readonly IntPtr NativeFieldInfoPtr_lastImpactTime;

		// Token: 0x040049F9 RID: 18937
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x040049FA RID: 18938
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040049FB RID: 18939
		private static readonly IntPtr NativeMethodInfoPtr_OnImpacted_Private_Void_Impact_0;

		// Token: 0x040049FC RID: 18940
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x040049FD RID: 18941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A5F RID: 2655
		[OriginalName("Assembly-CSharp.dll", "", "EMaterial")]
		public enum EMaterial
		{
			// Token: 0x04008CDC RID: 36060
			Wood,
			// Token: 0x04008CDD RID: 36061
			HollowMetal,
			// Token: 0x04008CDE RID: 36062
			Cardboard,
			// Token: 0x04008CDF RID: 36063
			Glass,
			// Token: 0x04008CE0 RID: 36064
			Plastic,
			// Token: 0x04008CE1 RID: 36065
			Basketball,
			// Token: 0x04008CE2 RID: 36066
			SmallHollowMetal,
			// Token: 0x04008CE3 RID: 36067
			PlasticBag,
			// Token: 0x04008CE4 RID: 36068
			Punch,
			// Token: 0x04008CE5 RID: 36069
			BaseballBat
		}
	}
}
