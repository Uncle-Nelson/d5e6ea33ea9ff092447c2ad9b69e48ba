using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppItemIconCreator
{
	// Token: 0x02000162 RID: 354
	public class PrefabIconCreator : IconCreator
	{
		// Token: 0x06001CAB RID: 7339 RVA: 0x000C9800 File Offset: 0x000C7A00
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabIconCreator()
		{
			Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ItemIconCreator", "PrefabIconCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr);
			PrefabIconCreator.NativeFieldInfoPtr_itemsToShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, "itemsToShot");
			PrefabIconCreator.NativeFieldInfoPtr_itemPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, "itemPosition");
			PrefabIconCreator.NativeFieldInfoPtr_instantiatedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, "instantiatedItem");
			PrefabIconCreator.NativeMethodInfoPtr_BuildIcons_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100666294);
			PrefabIconCreator.NativeMethodInfoPtr_CheckConditions_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100666295);
			PrefabIconCreator.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100666296);
			PrefabIconCreator.NativeMethodInfoPtr_ClearShit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100666297);
			PrefabIconCreator.NativeMethodInfoPtr_BuildAllIcons_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100666298);
			PrefabIconCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100666299);
			PrefabIconCreator.NativeMethodInfoPtr__BuildAllIcons_b__7_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100666300);
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x000C98F8 File Offset: 0x000C7AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101227, XrefRangeEnd = 101233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BuildIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabIconCreator.NativeMethodInfoPtr_BuildIcons_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x000C9934 File Offset: 0x000C7B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101233, XrefRangeEnd = 101241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckConditions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabIconCreator.NativeMethodInfoPtr_CheckConditions_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x000C997C File Offset: 0x000C7B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101241, XrefRangeEnd = 101285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabIconCreator.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x000C99B8 File Offset: 0x000C7BB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101309, RefRangeEnd = 101310, XrefRangeStart = 101285, XrefRangeEnd = 101309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator.NativeMethodInfoPtr_ClearShit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x000C99EC File Offset: 0x000C7BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101310, XrefRangeEnd = 101315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator BuildAllIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator.NativeMethodInfoPtr_BuildAllIcons_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x000C9A2C File Offset: 0x000C7C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabIconCreator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x000C9A68 File Offset: 0x000C7C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _BuildAllIcons_b__7_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator.NativeMethodInfoPtr__BuildAllIcons_b__7_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x0001054A File Offset: 0x0000E74A
		public PrefabIconCreator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x000C9AA4 File Offset: 0x000C7CA4
		// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x00010553 File Offset: 0x0000E753
		public unsafe Il2CppReferenceArray<GameObject> itemsToShot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator.NativeFieldInfoPtr_itemsToShot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator.NativeFieldInfoPtr_itemsToShot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x000C9AD4 File Offset: 0x000C7CD4
		// (set) Token: 0x06001CB7 RID: 7351 RVA: 0x00010572 File Offset: 0x0000E772
		public unsafe Transform itemPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator.NativeFieldInfoPtr_itemPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator.NativeFieldInfoPtr_itemPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x000C9B04 File Offset: 0x000C7D04
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x00010591 File Offset: 0x0000E791
		public unsafe GameObject instantiatedItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator.NativeFieldInfoPtr_instantiatedItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator.NativeFieldInfoPtr_instantiatedItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001302 RID: 4866
		private static readonly IntPtr NativeFieldInfoPtr_itemsToShot;

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeFieldInfoPtr_itemPosition;

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeFieldInfoPtr_instantiatedItem;

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeMethodInfoPtr_BuildIcons_Public_Virtual_Void_0;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeMethodInfoPtr_CheckConditions_Public_Virtual_Boolean_0;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeMethodInfoPtr_ClearShit_Private_Void_0;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeMethodInfoPtr_BuildAllIcons_Public_IEnumerator_0;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeMethodInfoPtr__BuildAllIcons_b__7_0_Private_Boolean_0;

		// Token: 0x02000868 RID: 2152
		[ObfuscatedName("ItemIconCreator.PrefabIconCreator+<BuildAllIcons>d__7")]
		public sealed class _BuildAllIcons_d__7 : Il2CppSystem.Object
		{
			// Token: 0x0600C120 RID: 49440 RVA: 0x002F2A90 File Offset: 0x002F0C90
			// Note: this type is marked as 'beforefieldinit'.
			static _BuildAllIcons_d__7()
			{
				Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, "<BuildAllIcons>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr);
				PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, "<>1__state");
				PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, "<>2__current");
				PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, "<>4__this");
				PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, "<i>5__2");
				PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, 100666301);
				PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, 100666302);
				PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, 100666303);
				PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, 100666304);
				PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, 100666305);
				PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, 100666306);
			}

			// Token: 0x0600C121 RID: 49441 RVA: 0x002F2B84 File Offset: 0x002F0D84
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BuildAllIcons_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C122 RID: 49442 RVA: 0x002F2BCC File Offset: 0x002F0DCC
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C123 RID: 49443 RVA: 0x002F2C00 File Offset: 0x002F0E00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101211, XrefRangeEnd = 101222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003C30 RID: 15408
			// (get) Token: 0x0600C124 RID: 49444 RVA: 0x002F2C3C File Offset: 0x002F0E3C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C125 RID: 49445 RVA: 0x002F2C7C File Offset: 0x002F0E7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101222, XrefRangeEnd = 101227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003C31 RID: 15409
			// (get) Token: 0x0600C126 RID: 49446 RVA: 0x002F2CB0 File Offset: 0x002F0EB0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C127 RID: 49447 RVA: 0x0005E6BC File Offset: 0x0005C8BC
			public _BuildAllIcons_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C2C RID: 15404
			// (get) Token: 0x0600C128 RID: 49448 RVA: 0x002F2CF0 File Offset: 0x002F0EF0
			// (set) Token: 0x0600C129 RID: 49449 RVA: 0x0005E6C5 File Offset: 0x0005C8C5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003C2D RID: 15405
			// (get) Token: 0x0600C12A RID: 49450 RVA: 0x002F2D18 File Offset: 0x002F0F18
			// (set) Token: 0x0600C12B RID: 49451 RVA: 0x0005E6E0 File Offset: 0x0005C8E0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C2E RID: 15406
			// (get) Token: 0x0600C12C RID: 49452 RVA: 0x002F2D48 File Offset: 0x002F0F48
			// (set) Token: 0x0600C12D RID: 49453 RVA: 0x0005E6FF File Offset: 0x0005C8FF
			public unsafe PrefabIconCreator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabIconCreator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C2F RID: 15407
			// (get) Token: 0x0600C12E RID: 49454 RVA: 0x002F2D78 File Offset: 0x002F0F78
			// (set) Token: 0x0600C12F RID: 49455 RVA: 0x0005E71E File Offset: 0x0005C91E
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040082D0 RID: 33488
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040082D1 RID: 33489
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040082D2 RID: 33490
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040082D3 RID: 33491
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040082D4 RID: 33492
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040082D5 RID: 33493
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040082D6 RID: 33494
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040082D7 RID: 33495
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040082D8 RID: 33496
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040082D9 RID: 33497
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
