using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004A4 RID: 1188
	public class CasinoGamePlayerData : Object
	{
		// Token: 0x0600675D RID: 26461 RVA: 0x001D098C File Offset: 0x001CEB8C
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGamePlayerData()
		{
			Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CasinoGamePlayerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr);
			CasinoGamePlayerData.NativeFieldInfoPtr__Parent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, "<Parent>k__BackingField");
			CasinoGamePlayerData.NativeFieldInfoPtr__Player_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, "<Player>k__BackingField");
			CasinoGamePlayerData.NativeFieldInfoPtr_bools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, "bools");
			CasinoGamePlayerData.NativeFieldInfoPtr_floats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, "floats");
			CasinoGamePlayerData.NativeMethodInfoPtr_get_Parent_Public_get_CasinoGamePlayers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676397);
			CasinoGamePlayerData.NativeMethodInfoPtr_set_Parent_Private_set_Void_CasinoGamePlayers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676398);
			CasinoGamePlayerData.NativeMethodInfoPtr_get_Player_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676399);
			CasinoGamePlayerData.NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676400);
			CasinoGamePlayerData.NativeMethodInfoPtr__ctor_Public_Void_CasinoGamePlayers_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676401);
			CasinoGamePlayerData.NativeMethodInfoPtr_GetData_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676402);
			CasinoGamePlayerData.NativeMethodInfoPtr_SetData_Public_Void_String_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676403);
		}

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x0600675E RID: 26462 RVA: 0x001D0A98 File Offset: 0x001CEC98
		// (set) Token: 0x0600675F RID: 26463 RVA: 0x001D0AD8 File Offset: 0x001CECD8
		public unsafe CasinoGamePlayers Parent
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17380, RefRangeEnd = 17390, XrefRangeStart = 17380, XrefRangeEnd = 17390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr_get_Parent_Public_get_CasinoGamePlayers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29995, RefRangeEnd = 29997, XrefRangeStart = 29995, XrefRangeEnd = 29997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr_set_Parent_Private_set_Void_CasinoGamePlayers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x06006760 RID: 26464 RVA: 0x001D0B1C File Offset: 0x001CED1C
		// (set) Token: 0x06006761 RID: 26465 RVA: 0x001D0B5C File Offset: 0x001CED5C
		public unsafe Player Player
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr_get_Player_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006762 RID: 26466 RVA: 0x001D0BA0 File Offset: 0x001CEDA0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 209247, RefRangeEnd = 209252, XrefRangeStart = 209220, XrefRangeEnd = 209247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerData(CasinoGamePlayers parent, Player player) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr__ctor_Public_Void_CasinoGamePlayers_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006763 RID: 26467 RVA: 0x001D0C00 File Offset: 0x001CEE00
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 209284, RefRangeEnd = 209295, XrefRangeStart = 209252, XrefRangeEnd = 209284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetData<T>(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.MethodInfoStoreGeneric_GetData_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06006764 RID: 26468 RVA: 0x001D0C4C File Offset: 0x001CEE4C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 209342, RefRangeEnd = 209348, XrefRangeStart = 209295, XrefRangeEnd = 209342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData<T>(string key, T value, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.MethodInfoStoreGeneric_SetData_Public_Void_String_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006765 RID: 26469 RVA: 0x00030D4D File Offset: 0x0002EF4D
		public CasinoGamePlayerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x06006766 RID: 26470 RVA: 0x001D0CFC File Offset: 0x001CEEFC
		// (set) Token: 0x06006767 RID: 26471 RVA: 0x00030D56 File Offset: 0x0002EF56
		public unsafe CasinoGamePlayers _Parent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr__Parent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr__Parent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x06006768 RID: 26472 RVA: 0x001D0D2C File Offset: 0x001CEF2C
		// (set) Token: 0x06006769 RID: 26473 RVA: 0x00030D75 File Offset: 0x0002EF75
		public unsafe Player _Player_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr__Player_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr__Player_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x0600676A RID: 26474 RVA: 0x001D0D5C File Offset: 0x001CEF5C
		// (set) Token: 0x0600676B RID: 26475 RVA: 0x00030D94 File Offset: 0x0002EF94
		public unsafe Dictionary<string, bool> bools
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr_bools);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr_bools), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x0600676C RID: 26476 RVA: 0x001D0D8C File Offset: 0x001CEF8C
		// (set) Token: 0x0600676D RID: 26477 RVA: 0x00030DB3 File Offset: 0x0002EFB3
		public unsafe Dictionary<string, float> floats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr_floats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr_floats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040046C1 RID: 18113
		private static readonly IntPtr NativeFieldInfoPtr__Parent_k__BackingField;

		// Token: 0x040046C2 RID: 18114
		private static readonly IntPtr NativeFieldInfoPtr__Player_k__BackingField;

		// Token: 0x040046C3 RID: 18115
		private static readonly IntPtr NativeFieldInfoPtr_bools;

		// Token: 0x040046C4 RID: 18116
		private static readonly IntPtr NativeFieldInfoPtr_floats;

		// Token: 0x040046C5 RID: 18117
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_CasinoGamePlayers_0;

		// Token: 0x040046C6 RID: 18118
		private static readonly IntPtr NativeMethodInfoPtr_set_Parent_Private_set_Void_CasinoGamePlayers_0;

		// Token: 0x040046C7 RID: 18119
		private static readonly IntPtr NativeMethodInfoPtr_get_Player_Public_get_Player_0;

		// Token: 0x040046C8 RID: 18120
		private static readonly IntPtr NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0;

		// Token: 0x040046C9 RID: 18121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CasinoGamePlayers_Player_0;

		// Token: 0x040046CA RID: 18122
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_T_String_0;

		// Token: 0x040046CB RID: 18123
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_String_T_Boolean_0;

		// Token: 0x02000A40 RID: 2624
		private sealed class MethodInfoStoreGeneric_GetData_Public_T_String_0<T>
		{
			// Token: 0x04008C38 RID: 35896
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CasinoGamePlayerData.NativeMethodInfoPtr_GetData_Public_T_String_0, Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A41 RID: 2625
		private sealed class MethodInfoStoreGeneric_SetData_Public_Void_String_T_Boolean_0<T>
		{
			// Token: 0x04008C39 RID: 35897
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CasinoGamePlayerData.NativeMethodInfoPtr_SetData_Public_Void_String_T_Boolean_0, Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
