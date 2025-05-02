using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006D7 RID: 1751
	public class BrickPressUIElement : WorldspaceUIElement
	{
		// Token: 0x06009D9D RID: 40349 RVA: 0x0027DC94 File Offset: 0x0027BE94
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressUIElement()
		{
			Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "BrickPressUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr);
			BrickPressUIElement.NativeFieldInfoPtr__AssignedPress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, "<AssignedPress>k__BackingField");
			BrickPressUIElement.NativeMethodInfoPtr_get_AssignedPress_Public_get_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100682626);
			BrickPressUIElement.NativeMethodInfoPtr_set_AssignedPress_Protected_set_Void_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100682627);
			BrickPressUIElement.NativeMethodInfoPtr_Initialize_Public_Void_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100682628);
			BrickPressUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100682629);
			BrickPressUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100682630);
		}

		// Token: 0x1700308E RID: 12430
		// (get) Token: 0x06009D9E RID: 40350 RVA: 0x0027DD3C File Offset: 0x0027BF3C
		// (set) Token: 0x06009D9F RID: 40351 RVA: 0x0027DD7C File Offset: 0x0027BF7C
		public unsafe BrickPress AssignedPress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16593, RefRangeEnd = 16594, XrefRangeStart = 16593, XrefRangeEnd = 16594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressUIElement.NativeMethodInfoPtr_get_AssignedPress_Public_get_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38376, RefRangeEnd = 38379, XrefRangeStart = 38376, XrefRangeEnd = 38379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressUIElement.NativeMethodInfoPtr_set_AssignedPress_Protected_set_Void_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009DA0 RID: 40352 RVA: 0x0027DDC0 File Offset: 0x0027BFC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279856, RefRangeEnd = 279857, XrefRangeStart = 279846, XrefRangeEnd = 279856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(BrickPress press)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressUIElement.NativeMethodInfoPtr_Initialize_Public_Void_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DA1 RID: 40353 RVA: 0x0027DE04 File Offset: 0x0027C004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279857, XrefRangeEnd = 279863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DA2 RID: 40354 RVA: 0x0027DE40 File Offset: 0x0027C040
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DA3 RID: 40355 RVA: 0x0004D5C1 File Offset: 0x0004B7C1
		public BrickPressUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700308D RID: 12429
		// (get) Token: 0x06009DA4 RID: 40356 RVA: 0x0027DE7C File Offset: 0x0027C07C
		// (set) Token: 0x06009DA5 RID: 40357 RVA: 0x0004D5CA File Offset: 0x0004B7CA
		public unsafe BrickPress _AssignedPress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressUIElement.NativeFieldInfoPtr__AssignedPress_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressUIElement.NativeFieldInfoPtr__AssignedPress_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069D4 RID: 27092
		private static readonly IntPtr NativeFieldInfoPtr__AssignedPress_k__BackingField;

		// Token: 0x040069D5 RID: 27093
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedPress_Public_get_BrickPress_0;

		// Token: 0x040069D6 RID: 27094
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedPress_Protected_set_Void_BrickPress_0;

		// Token: 0x040069D7 RID: 27095
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_BrickPress_0;

		// Token: 0x040069D8 RID: 27096
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040069D9 RID: 27097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
