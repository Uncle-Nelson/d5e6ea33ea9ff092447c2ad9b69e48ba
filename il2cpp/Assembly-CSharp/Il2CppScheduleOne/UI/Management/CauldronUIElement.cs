using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006D8 RID: 1752
	public class CauldronUIElement : WorldspaceUIElement
	{
		// Token: 0x06009DA6 RID: 40358 RVA: 0x0027DEAC File Offset: 0x0027C0AC
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronUIElement()
		{
			Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "CauldronUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr);
			CauldronUIElement.NativeFieldInfoPtr__AssignedCauldron_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, "<AssignedCauldron>k__BackingField");
			CauldronUIElement.NativeMethodInfoPtr_get_AssignedCauldron_Public_get_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100682631);
			CauldronUIElement.NativeMethodInfoPtr_set_AssignedCauldron_Protected_set_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100682632);
			CauldronUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100682633);
			CauldronUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100682634);
			CauldronUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100682635);
		}

		// Token: 0x17003090 RID: 12432
		// (get) Token: 0x06009DA7 RID: 40359 RVA: 0x0027DF54 File Offset: 0x0027C154
		// (set) Token: 0x06009DA8 RID: 40360 RVA: 0x0027DF94 File Offset: 0x0027C194
		public unsafe Cauldron AssignedCauldron
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16593, RefRangeEnd = 16594, XrefRangeStart = 16593, XrefRangeEnd = 16594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronUIElement.NativeMethodInfoPtr_get_AssignedCauldron_Public_get_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38376, RefRangeEnd = 38379, XrefRangeStart = 38376, XrefRangeEnd = 38379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronUIElement.NativeMethodInfoPtr_set_AssignedCauldron_Protected_set_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009DA9 RID: 40361 RVA: 0x0027DFD8 File Offset: 0x0027C1D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279873, RefRangeEnd = 279874, XrefRangeStart = 279863, XrefRangeEnd = 279873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Cauldron cauldron)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cauldron);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DAA RID: 40362 RVA: 0x0027E01C File Offset: 0x0027C21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279874, XrefRangeEnd = 279880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DAB RID: 40363 RVA: 0x0027E058 File Offset: 0x0027C258
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DAC RID: 40364 RVA: 0x0004D5E9 File Offset: 0x0004B7E9
		public CauldronUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700308F RID: 12431
		// (get) Token: 0x06009DAD RID: 40365 RVA: 0x0027E094 File Offset: 0x0027C294
		// (set) Token: 0x06009DAE RID: 40366 RVA: 0x0004D5F2 File Offset: 0x0004B7F2
		public unsafe Cauldron _AssignedCauldron_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronUIElement.NativeFieldInfoPtr__AssignedCauldron_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronUIElement.NativeFieldInfoPtr__AssignedCauldron_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069DA RID: 27098
		private static readonly IntPtr NativeFieldInfoPtr__AssignedCauldron_k__BackingField;

		// Token: 0x040069DB RID: 27099
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedCauldron_Public_get_Cauldron_0;

		// Token: 0x040069DC RID: 27100
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedCauldron_Protected_set_Void_Cauldron_0;

		// Token: 0x040069DD RID: 27101
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Cauldron_0;

		// Token: 0x040069DE RID: 27102
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040069DF RID: 27103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
