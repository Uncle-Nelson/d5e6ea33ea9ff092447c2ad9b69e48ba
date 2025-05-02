using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000495 RID: 1173
	[Serializable]
	public class Impact : Il2CppSystem.Object
	{
		// Token: 0x0600654A RID: 25930 RVA: 0x001C95B0 File Offset: 0x001C77B0
		// Note: this type is marked as 'beforefieldinit'.
		static Impact()
		{
			Il2CppClassPointerStore<Impact>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "Impact");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Impact>.NativeClassPtr);
			Impact.NativeFieldInfoPtr_Hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "Hit");
			Impact.NativeFieldInfoPtr_HitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "HitPoint");
			Impact.NativeFieldInfoPtr_ImpactForceDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactForceDirection");
			Impact.NativeFieldInfoPtr_ImpactForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactForce");
			Impact.NativeFieldInfoPtr_ImpactDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactDamage");
			Impact.NativeFieldInfoPtr_ImpactType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactType");
			Impact.NativeFieldInfoPtr_ImpactSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactSource");
			Impact.NativeFieldInfoPtr_ImpactID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactID");
			Impact.NativeMethodInfoPtr__ctor_Public_Void_RaycastHit_Vector3_Vector3_Single_Single_EImpactType_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Impact>.NativeClassPtr, 100676117);
			Impact.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Impact>.NativeClassPtr, 100676118);
			Impact.NativeMethodInfoPtr_IsLethal_Public_Static_Boolean_EImpactType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Impact>.NativeClassPtr, 100676119);
			Impact.NativeMethodInfoPtr_IsPlayerImpact_Public_Boolean_byref_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Impact>.NativeClassPtr, 100676120);
		}

		// Token: 0x0600654B RID: 25931 RVA: 0x001C96D0 File Offset: 0x001C78D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205929, RefRangeEnd = 205931, XrefRangeStart = 205923, XrefRangeEnd = 205929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Impact(RaycastHit hit, Vector3 hitPoint, Vector3 impactForceDirection, float impactForce, float impactDamage, EImpactType impactType, Player impactSource, int impactID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Impact>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactForceDirection;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactForce;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactDamage;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impactSource);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Impact.NativeMethodInfoPtr__ctor_Public_Void_RaycastHit_Vector3_Vector3_Single_Single_EImpactType_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600654C RID: 25932 RVA: 0x001C9780 File Offset: 0x001C7980
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Impact() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Impact>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Impact.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600654D RID: 25933 RVA: 0x001C97BC File Offset: 0x001C79BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205931, RefRangeEnd = 205932, XrefRangeStart = 205931, XrefRangeEnd = 205931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLethal(EImpactType impactType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref impactType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Impact.NativeMethodInfoPtr_IsLethal_Public_Static_Boolean_EImpactType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600654E RID: 25934 RVA: 0x001C97FC File Offset: 0x001C79FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205944, RefRangeEnd = 205945, XrefRangeStart = 205932, XrefRangeEnd = 205944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerImpact(out Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Impact.NativeMethodInfoPtr_IsPlayerImpact_Public_Boolean_byref_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			player = ((intPtr4 == 0) ? null : new Player(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600654F RID: 25935 RVA: 0x0002FE59 File Offset: 0x0002E059
		public Impact(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x06006550 RID: 25936 RVA: 0x001C985C File Offset: 0x001C7A5C
		// (set) Token: 0x06006551 RID: 25937 RVA: 0x0002FE62 File Offset: 0x0002E062
		public unsafe RaycastHit Hit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_Hit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_Hit)) = value;
			}
		}

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x06006552 RID: 25938 RVA: 0x001C9884 File Offset: 0x001C7A84
		// (set) Token: 0x06006553 RID: 25939 RVA: 0x0002FE7D File Offset: 0x0002E07D
		public unsafe Vector3 HitPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_HitPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_HitPoint)) = value;
			}
		}

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x06006554 RID: 25940 RVA: 0x001C98AC File Offset: 0x001C7AAC
		// (set) Token: 0x06006555 RID: 25941 RVA: 0x0002FE98 File Offset: 0x0002E098
		public unsafe Vector3 ImpactForceDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactForceDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactForceDirection)) = value;
			}
		}

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x06006556 RID: 25942 RVA: 0x001C98D4 File Offset: 0x001C7AD4
		// (set) Token: 0x06006557 RID: 25943 RVA: 0x0002FEB3 File Offset: 0x0002E0B3
		public unsafe float ImpactForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactForce)) = value;
			}
		}

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x06006558 RID: 25944 RVA: 0x001C98FC File Offset: 0x001C7AFC
		// (set) Token: 0x06006559 RID: 25945 RVA: 0x0002FECE File Offset: 0x0002E0CE
		public unsafe float ImpactDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactDamage)) = value;
			}
		}

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x0600655A RID: 25946 RVA: 0x001C9924 File Offset: 0x001C7B24
		// (set) Token: 0x0600655B RID: 25947 RVA: 0x0002FEE9 File Offset: 0x0002E0E9
		public unsafe EImpactType ImpactType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactType)) = value;
			}
		}

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x0600655C RID: 25948 RVA: 0x001C994C File Offset: 0x001C7B4C
		// (set) Token: 0x0600655D RID: 25949 RVA: 0x0002FF04 File Offset: 0x0002E104
		public unsafe NetworkObject ImpactSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x0600655E RID: 25950 RVA: 0x001C997C File Offset: 0x001C7B7C
		// (set) Token: 0x0600655F RID: 25951 RVA: 0x0002FF23 File Offset: 0x0002E123
		public unsafe int ImpactID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactID)) = value;
			}
		}

		// Token: 0x04004525 RID: 17701
		private static readonly IntPtr NativeFieldInfoPtr_Hit;

		// Token: 0x04004526 RID: 17702
		private static readonly IntPtr NativeFieldInfoPtr_HitPoint;

		// Token: 0x04004527 RID: 17703
		private static readonly IntPtr NativeFieldInfoPtr_ImpactForceDirection;

		// Token: 0x04004528 RID: 17704
		private static readonly IntPtr NativeFieldInfoPtr_ImpactForce;

		// Token: 0x04004529 RID: 17705
		private static readonly IntPtr NativeFieldInfoPtr_ImpactDamage;

		// Token: 0x0400452A RID: 17706
		private static readonly IntPtr NativeFieldInfoPtr_ImpactType;

		// Token: 0x0400452B RID: 17707
		private static readonly IntPtr NativeFieldInfoPtr_ImpactSource;

		// Token: 0x0400452C RID: 17708
		private static readonly IntPtr NativeFieldInfoPtr_ImpactID;

		// Token: 0x0400452D RID: 17709
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RaycastHit_Vector3_Vector3_Single_Single_EImpactType_Player_Int32_0;

		// Token: 0x0400452E RID: 17710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400452F RID: 17711
		private static readonly IntPtr NativeMethodInfoPtr_IsLethal_Public_Static_Boolean_EImpactType_0;

		// Token: 0x04004530 RID: 17712
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerImpact_Public_Boolean_byref_Player_0;
	}
}
