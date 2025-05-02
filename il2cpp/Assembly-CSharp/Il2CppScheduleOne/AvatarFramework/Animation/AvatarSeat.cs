using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200060E RID: 1550
	public class AvatarSeat : MonoBehaviour
	{
		// Token: 0x0600893B RID: 35131 RVA: 0x00240F10 File Offset: 0x0023F110
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarSeat()
		{
			Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarSeat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr);
			AvatarSeat.NativeFieldInfoPtr__Occupant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, "<Occupant>k__BackingField");
			AvatarSeat.NativeFieldInfoPtr_SittingPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, "SittingPoint");
			AvatarSeat.NativeFieldInfoPtr_AccessPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, "AccessPoint");
			AvatarSeat.NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100680376);
			AvatarSeat.NativeMethodInfoPtr_get_Occupant_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100680377);
			AvatarSeat.NativeMethodInfoPtr_set_Occupant_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100680378);
			AvatarSeat.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100680379);
			AvatarSeat.NativeMethodInfoPtr_SetOccupant_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100680380);
			AvatarSeat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100680381);
		}

		// Token: 0x170029D9 RID: 10713
		// (get) Token: 0x0600893C RID: 35132 RVA: 0x00240FF4 File Offset: 0x0023F1F4
		public unsafe bool IsOccupied
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253474, XrefRangeEnd = 253478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170029DA RID: 10714
		// (get) Token: 0x0600893D RID: 35133 RVA: 0x00241030 File Offset: 0x0023F230
		// (set) Token: 0x0600893E RID: 35134 RVA: 0x00241070 File Offset: 0x0023F270
		public unsafe NPC Occupant
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_get_Occupant_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_set_Occupant_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600893F RID: 35135 RVA: 0x002410B4 File Offset: 0x0023F2B4
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008940 RID: 35136 RVA: 0x002410E8 File Offset: 0x0023F2E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253493, RefRangeEnd = 253496, XrefRangeStart = 253478, XrefRangeEnd = 253493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_SetOccupant_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008941 RID: 35137 RVA: 0x0024112C File Offset: 0x0023F32C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSeat() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008942 RID: 35138 RVA: 0x000418A5 File Offset: 0x0003FAA5
		public AvatarSeat(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029D6 RID: 10710
		// (get) Token: 0x06008943 RID: 35139 RVA: 0x00241168 File Offset: 0x0023F368
		// (set) Token: 0x06008944 RID: 35140 RVA: 0x000418AE File Offset: 0x0003FAAE
		public unsafe NPC _Occupant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr__Occupant_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr__Occupant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029D7 RID: 10711
		// (get) Token: 0x06008945 RID: 35141 RVA: 0x00241198 File Offset: 0x0023F398
		// (set) Token: 0x06008946 RID: 35142 RVA: 0x000418CD File Offset: 0x0003FACD
		public unsafe Transform SittingPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr_SittingPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr_SittingPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029D8 RID: 10712
		// (get) Token: 0x06008947 RID: 35143 RVA: 0x002411C8 File Offset: 0x0023F3C8
		// (set) Token: 0x06008948 RID: 35144 RVA: 0x000418EC File Offset: 0x0003FAEC
		public unsafe Transform AccessPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr_AccessPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr_AccessPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D33 RID: 23859
		private static readonly IntPtr NativeFieldInfoPtr__Occupant_k__BackingField;

		// Token: 0x04005D34 RID: 23860
		private static readonly IntPtr NativeFieldInfoPtr_SittingPoint;

		// Token: 0x04005D35 RID: 23861
		private static readonly IntPtr NativeFieldInfoPtr_AccessPoint;

		// Token: 0x04005D36 RID: 23862
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0;

		// Token: 0x04005D37 RID: 23863
		private static readonly IntPtr NativeMethodInfoPtr_get_Occupant_Public_get_NPC_0;

		// Token: 0x04005D38 RID: 23864
		private static readonly IntPtr NativeMethodInfoPtr_set_Occupant_Protected_set_Void_NPC_0;

		// Token: 0x04005D39 RID: 23865
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005D3A RID: 23866
		private static readonly IntPtr NativeMethodInfoPtr_SetOccupant_Public_Void_NPC_0;

		// Token: 0x04005D3B RID: 23867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
