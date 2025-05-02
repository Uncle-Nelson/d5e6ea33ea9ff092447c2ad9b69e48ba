using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Customization;
using UnityEngine;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x020006FC RID: 1788
	public class BaseCharacterCreatorField : MonoBehaviour
	{
		// Token: 0x0600A080 RID: 41088 RVA: 0x00286A54 File Offset: 0x00284C54
		// Note: this type is marked as 'beforefieldinit'.
		static BaseCharacterCreatorField()
		{
			Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "BaseCharacterCreatorField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr);
			BaseCharacterCreatorField.NativeFieldInfoPtr_PropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, "PropertyName");
			BaseCharacterCreatorField.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, "Category");
			BaseCharacterCreatorField.NativeFieldInfoPtr_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, "Creator");
			BaseCharacterCreatorField.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100682931);
			BaseCharacterCreatorField.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100682932);
			BaseCharacterCreatorField.NativeMethodInfoPtr_ApplyValue_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100682933);
			BaseCharacterCreatorField.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100682934);
			BaseCharacterCreatorField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100682935);
		}

		// Token: 0x0600A081 RID: 41089 RVA: 0x00286B24 File Offset: 0x00284D24
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCharacterCreatorField.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A082 RID: 41090 RVA: 0x00286B60 File Offset: 0x00284D60
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCharacterCreatorField.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A083 RID: 41091 RVA: 0x00286B9C File Offset: 0x00284D9C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCharacterCreatorField.NativeMethodInfoPtr_ApplyValue_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A084 RID: 41092 RVA: 0x00286BD8 File Offset: 0x00284DD8
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(bool applyValue = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref applyValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCharacterCreatorField.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A085 RID: 41093 RVA: 0x00286C24 File Offset: 0x00284E24
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseCharacterCreatorField() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseCharacterCreatorField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A086 RID: 41094 RVA: 0x0004EF03 File Offset: 0x0004D103
		public BaseCharacterCreatorField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003177 RID: 12663
		// (get) Token: 0x0600A087 RID: 41095 RVA: 0x00286C60 File Offset: 0x00284E60
		// (set) Token: 0x0600A088 RID: 41096 RVA: 0x0004EF0C File Offset: 0x0004D10C
		public unsafe string PropertyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_PropertyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_PropertyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003178 RID: 12664
		// (get) Token: 0x0600A089 RID: 41097 RVA: 0x00286C88 File Offset: 0x00284E88
		// (set) Token: 0x0600A08A RID: 41098 RVA: 0x0004EF2B File Offset: 0x0004D12B
		public unsafe CharacterCreator.ECategory Category
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_Category);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_Category)) = value;
			}
		}

		// Token: 0x17003179 RID: 12665
		// (get) Token: 0x0600A08B RID: 41099 RVA: 0x00286CB0 File Offset: 0x00284EB0
		// (set) Token: 0x0600A08C RID: 41100 RVA: 0x0004EF46 File Offset: 0x0004D146
		public unsafe CharacterCreator Creator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_Creator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_Creator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006B9D RID: 27549
		private static readonly IntPtr NativeFieldInfoPtr_PropertyName;

		// Token: 0x04006B9E RID: 27550
		private static readonly IntPtr NativeFieldInfoPtr_Category;

		// Token: 0x04006B9F RID: 27551
		private static readonly IntPtr NativeFieldInfoPtr_Creator;

		// Token: 0x04006BA0 RID: 27552
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04006BA1 RID: 27553
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006BA2 RID: 27554
		private static readonly IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_New_Void_0;

		// Token: 0x04006BA3 RID: 27555
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006BA4 RID: 27556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
