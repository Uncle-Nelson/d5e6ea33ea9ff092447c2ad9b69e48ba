using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200060F RID: 1551
	public class AvatarSeatSet : MonoBehaviour
	{
		// Token: 0x06008949 RID: 35145 RVA: 0x002411F8 File Offset: 0x0023F3F8
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarSeatSet()
		{
			Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarSeatSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr);
			AvatarSeatSet.NativeFieldInfoPtr_Seats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, "Seats");
			AvatarSeatSet.NativeMethodInfoPtr_GetFirstFreeSeat_Public_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, 100680382);
			AvatarSeatSet.NativeMethodInfoPtr_GetRandomFreeSeat_Public_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, 100680383);
			AvatarSeatSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, 100680384);
		}

		// Token: 0x0600894A RID: 35146 RVA: 0x00241278 File Offset: 0x0023F478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253500, XrefRangeEnd = 253507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSeat GetFirstFreeSeat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.NativeMethodInfoPtr_GetFirstFreeSeat_Public_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSeat>(intPtr3) : null;
		}

		// Token: 0x0600894B RID: 35147 RVA: 0x002412B8 File Offset: 0x0023F4B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 253535, RefRangeEnd = 253542, XrefRangeStart = 253507, XrefRangeEnd = 253535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSeat GetRandomFreeSeat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.NativeMethodInfoPtr_GetRandomFreeSeat_Public_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSeat>(intPtr3) : null;
		}

		// Token: 0x0600894C RID: 35148 RVA: 0x002412F8 File Offset: 0x0023F4F8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSeatSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600894D RID: 35149 RVA: 0x0004190B File Offset: 0x0003FB0B
		public AvatarSeatSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029DB RID: 10715
		// (get) Token: 0x0600894E RID: 35150 RVA: 0x00241334 File Offset: 0x0023F534
		// (set) Token: 0x0600894F RID: 35151 RVA: 0x00041914 File Offset: 0x0003FB14
		public unsafe Il2CppReferenceArray<AvatarSeat> Seats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeatSet.NativeFieldInfoPtr_Seats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarSeat>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeatSet.NativeFieldInfoPtr_Seats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D3C RID: 23868
		private static readonly IntPtr NativeFieldInfoPtr_Seats;

		// Token: 0x04005D3D RID: 23869
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstFreeSeat_Public_AvatarSeat_0;

		// Token: 0x04005D3E RID: 23870
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomFreeSeat_Public_AvatarSeat_0;

		// Token: 0x04005D3F RID: 23871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B05 RID: 2821
		[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarSeatSet+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D66A RID: 54890 RVA: 0x00330BB4 File Offset: 0x0032EDB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr);
				AvatarSeatSet.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr, "<>9");
				AvatarSeatSet.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr, "<>9__2_0");
				AvatarSeatSet.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr, 100680386);
				AvatarSeatSet.__c.NativeMethodInfoPtr__GetRandomFreeSeat_b__2_0_Internal_Boolean_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr, 100680387);
			}

			// Token: 0x0600D66B RID: 54891 RVA: 0x00330C30 File Offset: 0x0032EE30
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D66C RID: 54892 RVA: 0x00330C6C File Offset: 0x0032EE6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253496, XrefRangeEnd = 253500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRandomFreeSeat_b__2_0(AvatarSeat x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.__c.NativeMethodInfoPtr__GetRandomFreeSeat_b__2_0_Internal_Boolean_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D66D RID: 54893 RVA: 0x000685D5 File Offset: 0x000667D5
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004273 RID: 17011
			// (get) Token: 0x0600D66E RID: 54894 RVA: 0x00330CBC File Offset: 0x0032EEBC
			// (set) Token: 0x0600D66F RID: 54895 RVA: 0x000685DE File Offset: 0x000667DE
			public unsafe static AvatarSeatSet.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarSeatSet.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSeatSet.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarSeatSet.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004274 RID: 17012
			// (get) Token: 0x0600D670 RID: 54896 RVA: 0x00330CE4 File Offset: 0x0032EEE4
			// (set) Token: 0x0600D671 RID: 54897 RVA: 0x000685F0 File Offset: 0x000667F0
			public unsafe static Func<AvatarSeat, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarSeatSet.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AvatarSeat, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarSeatSet.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009034 RID: 36916
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009035 RID: 36917
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04009036 RID: 36918
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009037 RID: 36919
			private static readonly IntPtr NativeMethodInfoPtr__GetRandomFreeSeat_b__2_0_Internal_Boolean_AvatarSeat_0;
		}
	}
}
