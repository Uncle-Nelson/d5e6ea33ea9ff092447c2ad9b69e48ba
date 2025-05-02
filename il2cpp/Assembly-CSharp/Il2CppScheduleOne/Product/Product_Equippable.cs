using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Packaging;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005AC RID: 1452
	public class Product_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06007FB5 RID: 32693 RVA: 0x002233D0 File Offset: 0x002215D0
		// Note: this type is marked as 'beforefieldinit'.
		static Product_Equippable()
		{
			Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "Product_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr);
			Product_Equippable.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "Visuals");
			Product_Equippable.NativeFieldInfoPtr_ModelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ModelContainer");
			Product_Equippable.NativeFieldInfoPtr_Consumable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "Consumable");
			Product_Equippable.NativeFieldInfoPtr_ConsumeDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ConsumeDescription");
			Product_Equippable.NativeFieldInfoPtr_ConsumeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ConsumeTime");
			Product_Equippable.NativeFieldInfoPtr_EffectsApplyDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "EffectsApplyDelay");
			Product_Equippable.NativeFieldInfoPtr_ConsumeAnimationBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ConsumeAnimationBool");
			Product_Equippable.NativeFieldInfoPtr_ConsumeAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ConsumeAnimationTrigger");
			Product_Equippable.NativeFieldInfoPtr_ConsumeEquippableAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ConsumeEquippableAssetPath");
			Product_Equippable.NativeFieldInfoPtr_onConsumeInputStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "onConsumeInputStart");
			Product_Equippable.NativeFieldInfoPtr_onConsumeInputComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "onConsumeInputComplete");
			Product_Equippable.NativeFieldInfoPtr_onConsumeInputCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "onConsumeInputCancel");
			Product_Equippable.NativeFieldInfoPtr_consumeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "consumeTime");
			Product_Equippable.NativeFieldInfoPtr_consumingInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "consumingInProgress");
			Product_Equippable.NativeFieldInfoPtr_defaultModelPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "defaultModelPosition");
			Product_Equippable.NativeFieldInfoPtr_productAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "productAmount");
			Product_Equippable.NativeFieldInfoPtr_consumeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "consumeRoutine");
			Product_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679335);
			Product_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679336);
			Product_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679337);
			Product_Equippable.NativeMethodInfoPtr_Consume_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679338);
			Product_Equippable.NativeMethodInfoPtr_ApplyEffects_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679339);
			Product_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679340);
			Product_Equippable.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679341);
		}

		// Token: 0x06007FB6 RID: 32694 RVA: 0x002235E0 File Offset: 0x002217E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243437, XrefRangeEnd = 243499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FB7 RID: 32695 RVA: 0x00223630 File Offset: 0x00221830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243499, XrefRangeEnd = 243525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FB8 RID: 32696 RVA: 0x0022366C File Offset: 0x0022186C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243525, XrefRangeEnd = 243571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FB9 RID: 32697 RVA: 0x002236A8 File Offset: 0x002218A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243571, XrefRangeEnd = 243604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Consume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_Consume_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FBA RID: 32698 RVA: 0x002236E4 File Offset: 0x002218E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243604, XrefRangeEnd = 243614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_ApplyEffects_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FBB RID: 32699 RVA: 0x00223720 File Offset: 0x00221920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243614, XrefRangeEnd = 243628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Product_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FBC RID: 32700 RVA: 0x0022375C File Offset: 0x0022195C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243628, XrefRangeEnd = 243633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007FBD RID: 32701 RVA: 0x0003C7DD File Offset: 0x0003A9DD
		public Product_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002692 RID: 9874
		// (get) Token: 0x06007FBE RID: 32702 RVA: 0x0022379C File Offset: 0x0022199C
		// (set) Token: 0x06007FBF RID: 32703 RVA: 0x0003C7E6 File Offset: 0x0003A9E6
		public unsafe FilledPackagingVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002693 RID: 9875
		// (get) Token: 0x06007FC0 RID: 32704 RVA: 0x002237CC File Offset: 0x002219CC
		// (set) Token: 0x06007FC1 RID: 32705 RVA: 0x0003C805 File Offset: 0x0003AA05
		public unsafe Transform ModelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ModelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ModelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002694 RID: 9876
		// (get) Token: 0x06007FC2 RID: 32706 RVA: 0x002237FC File Offset: 0x002219FC
		// (set) Token: 0x06007FC3 RID: 32707 RVA: 0x0003C824 File Offset: 0x0003AA24
		public unsafe bool Consumable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_Consumable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_Consumable)) = value;
			}
		}

		// Token: 0x17002695 RID: 9877
		// (get) Token: 0x06007FC4 RID: 32708 RVA: 0x00223824 File Offset: 0x00221A24
		// (set) Token: 0x06007FC5 RID: 32709 RVA: 0x0003C83F File Offset: 0x0003AA3F
		public unsafe string ConsumeDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002696 RID: 9878
		// (get) Token: 0x06007FC6 RID: 32710 RVA: 0x0022384C File Offset: 0x00221A4C
		// (set) Token: 0x06007FC7 RID: 32711 RVA: 0x0003C85E File Offset: 0x0003AA5E
		public unsafe float ConsumeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeTime)) = value;
			}
		}

		// Token: 0x17002697 RID: 9879
		// (get) Token: 0x06007FC8 RID: 32712 RVA: 0x00223874 File Offset: 0x00221A74
		// (set) Token: 0x06007FC9 RID: 32713 RVA: 0x0003C879 File Offset: 0x0003AA79
		public unsafe float EffectsApplyDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_EffectsApplyDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_EffectsApplyDelay)) = value;
			}
		}

		// Token: 0x17002698 RID: 9880
		// (get) Token: 0x06007FCA RID: 32714 RVA: 0x0022389C File Offset: 0x00221A9C
		// (set) Token: 0x06007FCB RID: 32715 RVA: 0x0003C894 File Offset: 0x0003AA94
		public unsafe string ConsumeAnimationBool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeAnimationBool);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeAnimationBool), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002699 RID: 9881
		// (get) Token: 0x06007FCC RID: 32716 RVA: 0x002238C4 File Offset: 0x00221AC4
		// (set) Token: 0x06007FCD RID: 32717 RVA: 0x0003C8B3 File Offset: 0x0003AAB3
		public unsafe string ConsumeAnimationTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700269A RID: 9882
		// (get) Token: 0x06007FCE RID: 32718 RVA: 0x002238EC File Offset: 0x00221AEC
		// (set) Token: 0x06007FCF RID: 32719 RVA: 0x0003C8D2 File Offset: 0x0003AAD2
		public unsafe string ConsumeEquippableAssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeEquippableAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeEquippableAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700269B RID: 9883
		// (get) Token: 0x06007FD0 RID: 32720 RVA: 0x00223914 File Offset: 0x00221B14
		// (set) Token: 0x06007FD1 RID: 32721 RVA: 0x0003C8F1 File Offset: 0x0003AAF1
		public unsafe UnityEvent onConsumeInputStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_onConsumeInputStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_onConsumeInputStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700269C RID: 9884
		// (get) Token: 0x06007FD2 RID: 32722 RVA: 0x00223944 File Offset: 0x00221B44
		// (set) Token: 0x06007FD3 RID: 32723 RVA: 0x0003C910 File Offset: 0x0003AB10
		public unsafe UnityEvent onConsumeInputComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_onConsumeInputComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_onConsumeInputComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700269D RID: 9885
		// (get) Token: 0x06007FD4 RID: 32724 RVA: 0x00223974 File Offset: 0x00221B74
		// (set) Token: 0x06007FD5 RID: 32725 RVA: 0x0003C92F File Offset: 0x0003AB2F
		public unsafe UnityEvent onConsumeInputCancel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_onConsumeInputCancel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_onConsumeInputCancel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700269E RID: 9886
		// (get) Token: 0x06007FD6 RID: 32726 RVA: 0x002239A4 File Offset: 0x00221BA4
		// (set) Token: 0x06007FD7 RID: 32727 RVA: 0x0003C94E File Offset: 0x0003AB4E
		public unsafe float consumeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumeTime)) = value;
			}
		}

		// Token: 0x1700269F RID: 9887
		// (get) Token: 0x06007FD8 RID: 32728 RVA: 0x002239CC File Offset: 0x00221BCC
		// (set) Token: 0x06007FD9 RID: 32729 RVA: 0x0003C969 File Offset: 0x0003AB69
		public unsafe bool consumingInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumingInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumingInProgress)) = value;
			}
		}

		// Token: 0x170026A0 RID: 9888
		// (get) Token: 0x06007FDA RID: 32730 RVA: 0x002239F4 File Offset: 0x00221BF4
		// (set) Token: 0x06007FDB RID: 32731 RVA: 0x0003C984 File Offset: 0x0003AB84
		public unsafe Vector3 defaultModelPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_defaultModelPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_defaultModelPosition)) = value;
			}
		}

		// Token: 0x170026A1 RID: 9889
		// (get) Token: 0x06007FDC RID: 32732 RVA: 0x00223A1C File Offset: 0x00221C1C
		// (set) Token: 0x06007FDD RID: 32733 RVA: 0x0003C99F File Offset: 0x0003AB9F
		public unsafe int productAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_productAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_productAmount)) = value;
			}
		}

		// Token: 0x170026A2 RID: 9890
		// (get) Token: 0x06007FDE RID: 32734 RVA: 0x00223A44 File Offset: 0x00221C44
		// (set) Token: 0x06007FDF RID: 32735 RVA: 0x0003C9BA File Offset: 0x0003ABBA
		public unsafe Coroutine consumeRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumeRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400570C RID: 22284
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x0400570D RID: 22285
		private static readonly IntPtr NativeFieldInfoPtr_ModelContainer;

		// Token: 0x0400570E RID: 22286
		private static readonly IntPtr NativeFieldInfoPtr_Consumable;

		// Token: 0x0400570F RID: 22287
		private static readonly IntPtr NativeFieldInfoPtr_ConsumeDescription;

		// Token: 0x04005710 RID: 22288
		private static readonly IntPtr NativeFieldInfoPtr_ConsumeTime;

		// Token: 0x04005711 RID: 22289
		private static readonly IntPtr NativeFieldInfoPtr_EffectsApplyDelay;

		// Token: 0x04005712 RID: 22290
		private static readonly IntPtr NativeFieldInfoPtr_ConsumeAnimationBool;

		// Token: 0x04005713 RID: 22291
		private static readonly IntPtr NativeFieldInfoPtr_ConsumeAnimationTrigger;

		// Token: 0x04005714 RID: 22292
		private static readonly IntPtr NativeFieldInfoPtr_ConsumeEquippableAssetPath;

		// Token: 0x04005715 RID: 22293
		private static readonly IntPtr NativeFieldInfoPtr_onConsumeInputStart;

		// Token: 0x04005716 RID: 22294
		private static readonly IntPtr NativeFieldInfoPtr_onConsumeInputComplete;

		// Token: 0x04005717 RID: 22295
		private static readonly IntPtr NativeFieldInfoPtr_onConsumeInputCancel;

		// Token: 0x04005718 RID: 22296
		private static readonly IntPtr NativeFieldInfoPtr_consumeTime;

		// Token: 0x04005719 RID: 22297
		private static readonly IntPtr NativeFieldInfoPtr_consumingInProgress;

		// Token: 0x0400571A RID: 22298
		private static readonly IntPtr NativeFieldInfoPtr_defaultModelPosition;

		// Token: 0x0400571B RID: 22299
		private static readonly IntPtr NativeFieldInfoPtr_productAmount;

		// Token: 0x0400571C RID: 22300
		private static readonly IntPtr NativeFieldInfoPtr_consumeRoutine;

		// Token: 0x0400571D RID: 22301
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x0400571E RID: 22302
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x0400571F RID: 22303
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005720 RID: 22304
		private static readonly IntPtr NativeMethodInfoPtr_Consume_Protected_Virtual_New_Void_0;

		// Token: 0x04005721 RID: 22305
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffects_Protected_Virtual_New_Void_0;

		// Token: 0x04005722 RID: 22306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005723 RID: 22307
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000AD4 RID: 2772
		[ObfuscatedName("ScheduleOne.Product.Product_Equippable+<<Consume>g__ConsumeRoutine|20_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D4AC RID: 54444 RVA: 0x0032BCF8 File Offset: 0x00329EF8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique()
			{
				Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "<<Consume>g__ConsumeRoutine|20_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>1__state");
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>2__current");
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>4__this");
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679342);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679343);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679344);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679345);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679346);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679347);
			}

			// Token: 0x0600D4AD RID: 54445 RVA: 0x0032BDD8 File Offset: 0x00329FD8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4AE RID: 54446 RVA: 0x0032BE20 File Offset: 0x0032A020
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4AF RID: 54447 RVA: 0x0032BE54 File Offset: 0x0032A054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243421, XrefRangeEnd = 243426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170041EB RID: 16875
			// (get) Token: 0x0600D4B0 RID: 54448 RVA: 0x0032BE90 File Offset: 0x0032A090
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4B1 RID: 54449 RVA: 0x0032BED0 File Offset: 0x0032A0D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243426, XrefRangeEnd = 243431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170041EC RID: 16876
			// (get) Token: 0x0600D4B2 RID: 54450 RVA: 0x0032BF04 File Offset: 0x0032A104
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4B3 RID: 54451 RVA: 0x000677F6 File Offset: 0x000659F6
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041E8 RID: 16872
			// (get) Token: 0x0600D4B4 RID: 54452 RVA: 0x0032BF44 File Offset: 0x0032A144
			// (set) Token: 0x0600D4B5 RID: 54453 RVA: 0x000677FF File Offset: 0x000659FF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170041E9 RID: 16873
			// (get) Token: 0x0600D4B6 RID: 54454 RVA: 0x0032BF6C File Offset: 0x0032A16C
			// (set) Token: 0x0600D4B7 RID: 54455 RVA: 0x0006781A File Offset: 0x00065A1A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041EA RID: 16874
			// (get) Token: 0x0600D4B8 RID: 54456 RVA: 0x0032BF9C File Offset: 0x0032A19C
			// (set) Token: 0x0600D4B9 RID: 54457 RVA: 0x00067839 File Offset: 0x00065A39
			public unsafe Product_Equippable __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Product_Equippable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F22 RID: 36642
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F23 RID: 36643
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F24 RID: 36644
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F25 RID: 36645
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F26 RID: 36646
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F27 RID: 36647
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F28 RID: 36648
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F29 RID: 36649
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F2A RID: 36650
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AD5 RID: 2773
		[ObfuscatedName("ScheduleOne.Product.Product_Equippable+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D4BA RID: 54458 RVA: 0x0032BFCC File Offset: 0x0032A1CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr);
				Product_Equippable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr, "<>9");
				Product_Equippable.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr, "<>9__17_0");
				Product_Equippable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr, 100679349);
				Product_Equippable.__c.NativeMethodInfoPtr__Equip_b__17_0_Internal_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr, 100679350);
			}

			// Token: 0x0600D4BB RID: 54459 RVA: 0x0032C048 File Offset: 0x0032A248
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4BC RID: 54460 RVA: 0x0032C084 File Offset: 0x0032A284
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243431, XrefRangeEnd = 243437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Equip_b__17_0(Transform c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.__c.NativeMethodInfoPtr__Equip_b__17_0_Internal_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4BD RID: 54461 RVA: 0x00067858 File Offset: 0x00065A58
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041ED RID: 16877
			// (get) Token: 0x0600D4BE RID: 54462 RVA: 0x0032C0D4 File Offset: 0x0032A2D4
			// (set) Token: 0x0600D4BF RID: 54463 RVA: 0x00067861 File Offset: 0x00065A61
			public unsafe static Product_Equippable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Product_Equippable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Product_Equippable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Product_Equippable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041EE RID: 16878
			// (get) Token: 0x0600D4C0 RID: 54464 RVA: 0x0032C0FC File Offset: 0x0032A2FC
			// (set) Token: 0x0600D4C1 RID: 54465 RVA: 0x00067873 File Offset: 0x00065A73
			public unsafe static Func<Transform, bool> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Product_Equippable.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Transform, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Product_Equippable.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F2B RID: 36651
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008F2C RID: 36652
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04008F2D RID: 36653
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F2E RID: 36654
			private static readonly IntPtr NativeMethodInfoPtr__Equip_b__17_0_Internal_Boolean_Transform_0;
		}
	}
}
