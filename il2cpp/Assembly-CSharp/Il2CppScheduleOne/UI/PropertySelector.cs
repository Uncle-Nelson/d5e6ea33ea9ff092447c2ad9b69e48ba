using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000662 RID: 1634
	public class PropertySelector : MonoBehaviour
	{
		// Token: 0x060091E2 RID: 37346 RVA: 0x0025A958 File Offset: 0x00258B58
		// Note: this type is marked as 'beforefieldinit'.
		static PropertySelector()
		{
			Il2CppClassPointerStore<PropertySelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PropertySelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr);
			PropertySelector.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, "container");
			PropertySelector.NativeFieldInfoPtr_buttonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, "buttonContainer");
			PropertySelector.NativeFieldInfoPtr_buttonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, "buttonPrefab");
			PropertySelector.NativeFieldInfoPtr_pCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, "pCallback");
			PropertySelector.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681373);
			PropertySelector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681374);
			PropertySelector.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681375);
			PropertySelector.NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681376);
			PropertySelector.NativeMethodInfoPtr_OpenSelector_Public_Void_PropertySelected_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681377);
			PropertySelector.NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681378);
			PropertySelector.NativeMethodInfoPtr_SelectProperty_Private_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681379);
			PropertySelector.NativeMethodInfoPtr_Close_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681380);
			PropertySelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681381);
		}

		// Token: 0x17002CB8 RID: 11448
		// (get) Token: 0x060091E3 RID: 37347 RVA: 0x0025AA8C File Offset: 0x00258C8C
		public unsafe bool isOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 263885, RefRangeEnd = 263886, XrefRangeStart = 263883, XrefRangeEnd = 263885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060091E4 RID: 37348 RVA: 0x0025AAC8 File Offset: 0x00258CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263886, XrefRangeEnd = 263908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertySelector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091E5 RID: 37349 RVA: 0x0025AB04 File Offset: 0x00258D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263908, XrefRangeEnd = 263917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertySelector.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091E6 RID: 37350 RVA: 0x0025AB40 File Offset: 0x00258D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263917, XrefRangeEnd = 263920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertySelector.NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091E7 RID: 37351 RVA: 0x0025AB90 File Offset: 0x00258D90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263951, RefRangeEnd = 263952, XrefRangeStart = 263920, XrefRangeEnd = 263951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenSelector(PropertySelector.PropertySelected p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.NativeMethodInfoPtr_OpenSelector_Public_Void_PropertySelected_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091E8 RID: 37352 RVA: 0x0025ABD4 File Offset: 0x00258DD4
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PropertyAcquired(Property p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091E9 RID: 37353 RVA: 0x0025AC18 File Offset: 0x00258E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263952, XrefRangeEnd = 263954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectProperty(Property p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.NativeMethodInfoPtr_SelectProperty_Private_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091EA RID: 37354 RVA: 0x0025AC5C File Offset: 0x00258E5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263983, RefRangeEnd = 263985, XrefRangeStart = 263954, XrefRangeEnd = 263983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool reenableShit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref reenableShit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.NativeMethodInfoPtr_Close_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091EB RID: 37355 RVA: 0x0025AC9C File Offset: 0x00258E9C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertySelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091EC RID: 37356 RVA: 0x000468F5 File Offset: 0x00044AF5
		public PropertySelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CB4 RID: 11444
		// (get) Token: 0x060091ED RID: 37357 RVA: 0x0025ACD8 File Offset: 0x00258ED8
		// (set) Token: 0x060091EE RID: 37358 RVA: 0x000468FE File Offset: 0x00044AFE
		public unsafe GameObject container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CB5 RID: 11445
		// (get) Token: 0x060091EF RID: 37359 RVA: 0x0025AD08 File Offset: 0x00258F08
		// (set) Token: 0x060091F0 RID: 37360 RVA: 0x0004691D File Offset: 0x00044B1D
		public unsafe RectTransform buttonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_buttonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_buttonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CB6 RID: 11446
		// (get) Token: 0x060091F1 RID: 37361 RVA: 0x0025AD38 File Offset: 0x00258F38
		// (set) Token: 0x060091F2 RID: 37362 RVA: 0x0004693C File Offset: 0x00044B3C
		public unsafe GameObject buttonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_buttonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_buttonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CB7 RID: 11447
		// (get) Token: 0x060091F3 RID: 37363 RVA: 0x0025AD68 File Offset: 0x00258F68
		// (set) Token: 0x060091F4 RID: 37364 RVA: 0x0004695B File Offset: 0x00044B5B
		public unsafe PropertySelector.PropertySelected pCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_pCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertySelector.PropertySelected>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_pCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006291 RID: 25233
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04006292 RID: 25234
		private static readonly IntPtr NativeFieldInfoPtr_buttonContainer;

		// Token: 0x04006293 RID: 25235
		private static readonly IntPtr NativeFieldInfoPtr_buttonPrefab;

		// Token: 0x04006294 RID: 25236
		private static readonly IntPtr NativeFieldInfoPtr_pCallback;

		// Token: 0x04006295 RID: 25237
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006296 RID: 25238
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04006297 RID: 25239
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006298 RID: 25240
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0;

		// Token: 0x04006299 RID: 25241
		private static readonly IntPtr NativeMethodInfoPtr_OpenSelector_Public_Void_PropertySelected_0;

		// Token: 0x0400629A RID: 25242
		private static readonly IntPtr NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0;

		// Token: 0x0400629B RID: 25243
		private static readonly IntPtr NativeMethodInfoPtr_SelectProperty_Private_Void_Property_0;

		// Token: 0x0400629C RID: 25244
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_Boolean_0;

		// Token: 0x0400629D RID: 25245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B48 RID: 2888
		public sealed class PropertySelected : MulticastDelegate
		{
			// Token: 0x0600D947 RID: 55623 RVA: 0x00338EB0 File Offset: 0x003370B0
			// Note: this type is marked as 'beforefieldinit'.
			static PropertySelected()
			{
				Il2CppClassPointerStore<PropertySelector.PropertySelected>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, "PropertySelected");
				PropertySelector.PropertySelected.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector.PropertySelected>.NativeClassPtr, 100681382);
				PropertySelector.PropertySelected.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector.PropertySelected>.NativeClassPtr, 100681383);
				PropertySelector.PropertySelected.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Property_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector.PropertySelected>.NativeClassPtr, 100681384);
				PropertySelector.PropertySelected.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector.PropertySelected>.NativeClassPtr, 100681385);
			}

			// Token: 0x0600D948 RID: 55624 RVA: 0x00338F24 File Offset: 0x00337124
			[CallerCount(257)]
			[CachedScanResults(RefRangeStart = 104856, RefRangeEnd = 105113, XrefRangeStart = 104856, XrefRangeEnd = 105113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PropertySelected(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertySelector.PropertySelected>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.PropertySelected.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D949 RID: 55625 RVA: 0x00338F80 File Offset: 0x00337180
			[CallerCount(0)]
			public unsafe void Invoke(Property p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.PropertySelected.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D94A RID: 55626 RVA: 0x00338FC4 File Offset: 0x003371C4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74827, RefRangeEnd = 74828, XrefRangeStart = 74827, XrefRangeEnd = 74828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Property p, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.PropertySelected.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Property_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D94B RID: 55627 RVA: 0x00339038 File Offset: 0x00337238
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.PropertySelected.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D94C RID: 55628 RVA: 0x00069DA5 File Offset: 0x00067FA5
			public PropertySelected(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D94D RID: 55629 RVA: 0x00069DAE File Offset: 0x00067FAE
			public static implicit operator PropertySelector.PropertySelected(Action<Property> A_0)
			{
				return DelegateSupport.ConvertDelegate<PropertySelector.PropertySelected>(A_0);
			}

			// Token: 0x0600D94E RID: 55630 RVA: 0x00069DB6 File Offset: 0x00067FB6
			public static PropertySelector.PropertySelected operator +(PropertySelector.PropertySelected A_0, PropertySelector.PropertySelected A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PropertySelector.PropertySelected>();
			}

			// Token: 0x0600D94F RID: 55631 RVA: 0x00069DC4 File Offset: 0x00067FC4
			public static PropertySelector.PropertySelected operator -(PropertySelector.PropertySelected A_0, PropertySelector.PropertySelected A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<PropertySelector.PropertySelected>();
				}
				return result;
			}

			// Token: 0x040091F6 RID: 37366
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040091F7 RID: 37367
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Property_0;

			// Token: 0x040091F8 RID: 37368
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Property_AsyncCallback_Object_0;

			// Token: 0x040091F9 RID: 37369
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
