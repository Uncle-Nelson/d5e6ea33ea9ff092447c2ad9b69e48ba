using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000C7 RID: 199
	public class SpillController : MonoBehaviour
	{
		// Token: 0x06000ED0 RID: 3792 RVA: 0x0009F900 File Offset: 0x0009DB00
		// Note: this type is marked as 'beforefieldinit'.
		static SpillController()
		{
			Il2CppClassPointerStore<SpillController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "SpillController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpillController>.NativeClassPtr);
			SpillController.NativeFieldInfoPtr_spill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpillController>.NativeClassPtr, "spill");
			SpillController.NativeFieldInfoPtr_lv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpillController>.NativeClassPtr, "lv");
			SpillController.NativeFieldInfoPtr_dropTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpillController>.NativeClassPtr, "dropTemplates");
			SpillController.NativeFieldInfoPtr_DROP_TEMPLATES_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpillController>.NativeClassPtr, "DROP_TEMPLATES_COUNT");
			SpillController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController>.NativeClassPtr, 100665057);
			SpillController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController>.NativeClassPtr, 100665058);
			SpillController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController>.NativeClassPtr, 100665059);
			SpillController.NativeMethodInfoPtr_DestroySpill_Private_IEnumerator_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController>.NativeClassPtr, 100665060);
			SpillController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController>.NativeClassPtr, 100665061);
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0009F9E4 File Offset: 0x0009DBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85970, XrefRangeEnd = 85997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x0009FA18 File Offset: 0x0009DC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85997, XrefRangeEnd = 86009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x0009FA4C File Offset: 0x0009DC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86009, XrefRangeEnd = 86039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0009FA80 File Offset: 0x0009DC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86039, XrefRangeEnd = 86044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DestroySpill(GameObject spill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spill);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController.NativeMethodInfoPtr_DestroySpill_Private_IEnumerator_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0009FAD0 File Offset: 0x0009DCD0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpillController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpillController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00009478 File Offset: 0x00007678
		public SpillController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x0009FB0C File Offset: 0x0009DD0C
		// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x00009481 File Offset: 0x00007681
		public unsafe GameObject spill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController.NativeFieldInfoPtr_spill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController.NativeFieldInfoPtr_spill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x0009FB3C File Offset: 0x0009DD3C
		// (set) Token: 0x06000EDA RID: 3802 RVA: 0x000094A0 File Offset: 0x000076A0
		public unsafe LiquidVolume lv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController.NativeFieldInfoPtr_lv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController.NativeFieldInfoPtr_lv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x0009FB6C File Offset: 0x0009DD6C
		// (set) Token: 0x06000EDC RID: 3804 RVA: 0x000094BF File Offset: 0x000076BF
		public unsafe Il2CppReferenceArray<GameObject> dropTemplates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController.NativeFieldInfoPtr_dropTemplates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController.NativeFieldInfoPtr_dropTemplates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x0009FB9C File Offset: 0x0009DD9C
		// (set) Token: 0x06000EDE RID: 3806 RVA: 0x000094DE File Offset: 0x000076DE
		public unsafe static int DROP_TEMPLATES_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SpillController.NativeFieldInfoPtr_DROP_TEMPLATES_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpillController.NativeFieldInfoPtr_DROP_TEMPLATES_COUNT, (void*)(&value));
			}
		}

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeFieldInfoPtr_spill;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeFieldInfoPtr_lv;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeFieldInfoPtr_dropTemplates;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeFieldInfoPtr_DROP_TEMPLATES_COUNT;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_DestroySpill_Private_IEnumerator_GameObject_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000847 RID: 2119
		[ObfuscatedName("LiquidVolumeFX.SpillController+<DestroySpill>d__7")]
		public sealed class _DestroySpill_d__7 : Il2CppSystem.Object
		{
			// Token: 0x0600BFA3 RID: 49059 RVA: 0x002EF324 File Offset: 0x002ED524
			// Note: this type is marked as 'beforefieldinit'.
			static _DestroySpill_d__7()
			{
				Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpillController>.NativeClassPtr, "<DestroySpill>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr);
				SpillController._DestroySpill_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr, "<>1__state");
				SpillController._DestroySpill_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr, "<>2__current");
				SpillController._DestroySpill_d__7.NativeFieldInfoPtr_spill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr, "spill");
				SpillController._DestroySpill_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr, 100665062);
				SpillController._DestroySpill_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr, 100665063);
				SpillController._DestroySpill_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr, 100665064);
				SpillController._DestroySpill_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr, 100665065);
				SpillController._DestroySpill_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr, 100665066);
				SpillController._DestroySpill_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr, 100665067);
			}

			// Token: 0x0600BFA4 RID: 49060 RVA: 0x002EF404 File Offset: 0x002ED604
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DestroySpill_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController._DestroySpill_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BFA5 RID: 49061 RVA: 0x002EF44C File Offset: 0x002ED64C
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController._DestroySpill_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BFA6 RID: 49062 RVA: 0x002EF480 File Offset: 0x002ED680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85959, XrefRangeEnd = 85965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController._DestroySpill_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B9F RID: 15263
			// (get) Token: 0x0600BFA7 RID: 49063 RVA: 0x002EF4BC File Offset: 0x002ED6BC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController._DestroySpill_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BFA8 RID: 49064 RVA: 0x002EF4FC File Offset: 0x002ED6FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85965, XrefRangeEnd = 85970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController._DestroySpill_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003BA0 RID: 15264
			// (get) Token: 0x0600BFA9 RID: 49065 RVA: 0x002EF530 File Offset: 0x002ED730
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController._DestroySpill_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BFAA RID: 49066 RVA: 0x0005DA33 File Offset: 0x0005BC33
			public _DestroySpill_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B9C RID: 15260
			// (get) Token: 0x0600BFAB RID: 49067 RVA: 0x002EF570 File Offset: 0x002ED770
			// (set) Token: 0x0600BFAC RID: 49068 RVA: 0x0005DA3C File Offset: 0x0005BC3C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController._DestroySpill_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController._DestroySpill_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003B9D RID: 15261
			// (get) Token: 0x0600BFAD RID: 49069 RVA: 0x002EF598 File Offset: 0x002ED798
			// (set) Token: 0x0600BFAE RID: 49070 RVA: 0x0005DA57 File Offset: 0x0005BC57
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController._DestroySpill_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController._DestroySpill_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B9E RID: 15262
			// (get) Token: 0x0600BFAF RID: 49071 RVA: 0x002EF5C8 File Offset: 0x002ED7C8
			// (set) Token: 0x0600BFB0 RID: 49072 RVA: 0x0005DA76 File Offset: 0x0005BC76
			public unsafe GameObject spill
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController._DestroySpill_d__7.NativeFieldInfoPtr_spill);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController._DestroySpill_d__7.NativeFieldInfoPtr_spill), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040081DD RID: 33245
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040081DE RID: 33246
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040081DF RID: 33247
			private static readonly IntPtr NativeFieldInfoPtr_spill;

			// Token: 0x040081E0 RID: 33248
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040081E1 RID: 33249
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040081E2 RID: 33250
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040081E3 RID: 33251
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040081E4 RID: 33252
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040081E5 RID: 33253
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
