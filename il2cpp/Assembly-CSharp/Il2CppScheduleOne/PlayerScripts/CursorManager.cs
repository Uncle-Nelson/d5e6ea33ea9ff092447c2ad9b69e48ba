using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003E0 RID: 992
	public class CursorManager : Singleton<CursorManager>
	{
		// Token: 0x06004CB7 RID: 19639 RVA: 0x00170644 File Offset: 0x0016E844
		// Note: this type is marked as 'beforefieldinit'.
		static CursorManager()
		{
			Il2CppClassPointerStore<CursorManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "CursorManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorManager>.NativeClassPtr);
			CursorManager.NativeFieldInfoPtr_Cursors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "Cursors");
			CursorManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100672762);
			CursorManager.NativeMethodInfoPtr_SetCursorAppearance_Public_Void_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100672763);
			CursorManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100672764);
		}

		// Token: 0x06004CB8 RID: 19640 RVA: 0x001706C4 File Offset: 0x0016E8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166017, XrefRangeEnd = 166035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CursorManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CB9 RID: 19641 RVA: 0x00170700 File Offset: 0x0016E900
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 166050, RefRangeEnd = 166061, XrefRangeStart = 166035, XrefRangeEnd = 166050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCursorAppearance(CursorManager.ECursorType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr_SetCursorAppearance_Public_Void_ECursorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CBA RID: 19642 RVA: 0x00170740 File Offset: 0x0016E940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166061, XrefRangeEnd = 166071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CursorManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CBB RID: 19643 RVA: 0x00024E7C File Offset: 0x0002307C
		public CursorManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x06004CBC RID: 19644 RVA: 0x0017077C File Offset: 0x0016E97C
		// (set) Token: 0x06004CBD RID: 19645 RVA: 0x00024E85 File Offset: 0x00023085
		public unsafe List<CursorManager.CursorConfig> Cursors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr_Cursors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CursorManager.CursorConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr_Cursors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033A8 RID: 13224
		private static readonly IntPtr NativeFieldInfoPtr_Cursors;

		// Token: 0x040033A9 RID: 13225
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040033AA RID: 13226
		private static readonly IntPtr NativeMethodInfoPtr_SetCursorAppearance_Public_Void_ECursorType_0;

		// Token: 0x040033AB RID: 13227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200098C RID: 2444
		[OriginalName("Assembly-CSharp.dll", "", "ECursorType")]
		public enum ECursorType
		{
			// Token: 0x040088F1 RID: 35057
			Default,
			// Token: 0x040088F2 RID: 35058
			Finger,
			// Token: 0x040088F3 RID: 35059
			OpenHand,
			// Token: 0x040088F4 RID: 35060
			Grab,
			// Token: 0x040088F5 RID: 35061
			Scissors
		}

		// Token: 0x0200098D RID: 2445
		[Serializable]
		public class CursorConfig : Il2CppSystem.Object
		{
			// Token: 0x0600CA71 RID: 51825 RVA: 0x0030F4B4 File Offset: 0x0030D6B4
			// Note: this type is marked as 'beforefieldinit'.
			static CursorConfig()
			{
				Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "CursorConfig");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr);
				CursorManager.CursorConfig.NativeFieldInfoPtr_CursorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr, "CursorType");
				CursorManager.CursorConfig.NativeFieldInfoPtr_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr, "Texture");
				CursorManager.CursorConfig.NativeFieldInfoPtr_HotSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr, "HotSpot");
				CursorManager.CursorConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr, 100672765);
			}

			// Token: 0x0600CA72 RID: 51826 RVA: 0x0030F530 File Offset: 0x0030D730
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CursorConfig() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.CursorConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA73 RID: 51827 RVA: 0x000626B4 File Offset: 0x000608B4
			public CursorConfig(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F12 RID: 16146
			// (get) Token: 0x0600CA74 RID: 51828 RVA: 0x0030F56C File Offset: 0x0030D76C
			// (set) Token: 0x0600CA75 RID: 51829 RVA: 0x000626BD File Offset: 0x000608BD
			public unsafe CursorManager.ECursorType CursorType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_CursorType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_CursorType)) = value;
				}
			}

			// Token: 0x17003F13 RID: 16147
			// (get) Token: 0x0600CA76 RID: 51830 RVA: 0x0030F594 File Offset: 0x0030D794
			// (set) Token: 0x0600CA77 RID: 51831 RVA: 0x000626D8 File Offset: 0x000608D8
			public unsafe Texture2D Texture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_Texture);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_Texture), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F14 RID: 16148
			// (get) Token: 0x0600CA78 RID: 51832 RVA: 0x0030F5C4 File Offset: 0x0030D7C4
			// (set) Token: 0x0600CA79 RID: 51833 RVA: 0x000626F7 File Offset: 0x000608F7
			public unsafe Vector2 HotSpot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_HotSpot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_HotSpot)) = value;
				}
			}

			// Token: 0x040088F6 RID: 35062
			private static readonly IntPtr NativeFieldInfoPtr_CursorType;

			// Token: 0x040088F7 RID: 35063
			private static readonly IntPtr NativeFieldInfoPtr_Texture;

			// Token: 0x040088F8 RID: 35064
			private static readonly IntPtr NativeFieldInfoPtr_HotSpot;

			// Token: 0x040088F9 RID: 35065
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200098E RID: 2446
		[ObfuscatedName("ScheduleOne.PlayerScripts.CursorManager+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CA7A RID: 51834 RVA: 0x0030F5EC File Offset: 0x0030D7EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr);
				CursorManager.__c__DisplayClass4_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr, "type");
				CursorManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr, 100672766);
				CursorManager.__c__DisplayClass4_0.NativeMethodInfoPtr__SetCursorAppearance_b__0_Internal_Boolean_CursorConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr, 100672767);
			}

			// Token: 0x0600CA7B RID: 51835 RVA: 0x0030F654 File Offset: 0x0030D854
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA7C RID: 51836 RVA: 0x0030F690 File Offset: 0x0030D890
			[CallerCount(0)]
			public unsafe bool _SetCursorAppearance_b__0(CursorManager.CursorConfig x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.__c__DisplayClass4_0.NativeMethodInfoPtr__SetCursorAppearance_b__0_Internal_Boolean_CursorConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CA7D RID: 51837 RVA: 0x00062712 File Offset: 0x00060912
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F15 RID: 16149
			// (get) Token: 0x0600CA7E RID: 51838 RVA: 0x0030F6E0 File Offset: 0x0030D8E0
			// (set) Token: 0x0600CA7F RID: 51839 RVA: 0x0006271B File Offset: 0x0006091B
			public unsafe CursorManager.ECursorType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.__c__DisplayClass4_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.__c__DisplayClass4_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x040088FA RID: 35066
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x040088FB RID: 35067
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088FC RID: 35068
			private static readonly IntPtr NativeMethodInfoPtr__SetCursorAppearance_b__0_Internal_Boolean_CursorConfig_0;
		}
	}
}
