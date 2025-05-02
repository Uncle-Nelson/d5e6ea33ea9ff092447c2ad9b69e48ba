using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006D6 RID: 1750
	public class BotanistUIElement : WorldspaceUIElement
	{
		// Token: 0x06009D8C RID: 40332 RVA: 0x0027D96C File Offset: 0x0027BB6C
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistUIElement()
		{
			Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "BotanistUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr);
			BotanistUIElement.NativeFieldInfoPtr_SupplyIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "SupplyIcon");
			BotanistUIElement.NativeFieldInfoPtr_NoSupply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "NoSupply");
			BotanistUIElement.NativeFieldInfoPtr_SupplyLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "SupplyLabel");
			BotanistUIElement.NativeFieldInfoPtr_PotRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "PotRects");
			BotanistUIElement.NativeFieldInfoPtr__AssignedBotanist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, "<AssignedBotanist>k__BackingField");
			BotanistUIElement.NativeMethodInfoPtr_get_AssignedBotanist_Public_get_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100682621);
			BotanistUIElement.NativeMethodInfoPtr_set_AssignedBotanist_Protected_set_Void_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100682622);
			BotanistUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100682623);
			BotanistUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100682624);
			BotanistUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr, 100682625);
		}

		// Token: 0x1700308C RID: 12428
		// (get) Token: 0x06009D8D RID: 40333 RVA: 0x0027DA64 File Offset: 0x0027BC64
		// (set) Token: 0x06009D8E RID: 40334 RVA: 0x0027DAA4 File Offset: 0x0027BCA4
		public unsafe Botanist AssignedBotanist
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22968, RefRangeEnd = 22969, XrefRangeStart = 22968, XrefRangeEnd = 22969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistUIElement.NativeMethodInfoPtr_get_AssignedBotanist_Public_get_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistUIElement.NativeMethodInfoPtr_set_AssignedBotanist_Protected_set_Void_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009D8F RID: 40335 RVA: 0x0027DAE8 File Offset: 0x0027BCE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279808, RefRangeEnd = 279809, XrefRangeStart = 279797, XrefRangeEnd = 279808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Botanist bot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D90 RID: 40336 RVA: 0x0027DB2C File Offset: 0x0027BD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279809, XrefRangeEnd = 279846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D91 RID: 40337 RVA: 0x0027DB68 File Offset: 0x0027BD68
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D92 RID: 40338 RVA: 0x0004D51D File Offset: 0x0004B71D
		public BotanistUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003087 RID: 12423
		// (get) Token: 0x06009D93 RID: 40339 RVA: 0x0027DBA4 File Offset: 0x0027BDA4
		// (set) Token: 0x06009D94 RID: 40340 RVA: 0x0004D526 File Offset: 0x0004B726
		public unsafe Image SupplyIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_SupplyIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_SupplyIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003088 RID: 12424
		// (get) Token: 0x06009D95 RID: 40341 RVA: 0x0027DBD4 File Offset: 0x0027BDD4
		// (set) Token: 0x06009D96 RID: 40342 RVA: 0x0004D545 File Offset: 0x0004B745
		public unsafe GameObject NoSupply
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_NoSupply);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_NoSupply), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003089 RID: 12425
		// (get) Token: 0x06009D97 RID: 40343 RVA: 0x0027DC04 File Offset: 0x0027BE04
		// (set) Token: 0x06009D98 RID: 40344 RVA: 0x0004D564 File Offset: 0x0004B764
		public unsafe TextMeshProUGUI SupplyLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_SupplyLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_SupplyLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700308A RID: 12426
		// (get) Token: 0x06009D99 RID: 40345 RVA: 0x0027DC34 File Offset: 0x0027BE34
		// (set) Token: 0x06009D9A RID: 40346 RVA: 0x0004D583 File Offset: 0x0004B783
		public unsafe Il2CppReferenceArray<RectTransform> PotRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_PotRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr_PotRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700308B RID: 12427
		// (get) Token: 0x06009D9B RID: 40347 RVA: 0x0027DC64 File Offset: 0x0027BE64
		// (set) Token: 0x06009D9C RID: 40348 RVA: 0x0004D5A2 File Offset: 0x0004B7A2
		public unsafe Botanist _AssignedBotanist_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr__AssignedBotanist_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistUIElement.NativeFieldInfoPtr__AssignedBotanist_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069CA RID: 27082
		private static readonly IntPtr NativeFieldInfoPtr_SupplyIcon;

		// Token: 0x040069CB RID: 27083
		private static readonly IntPtr NativeFieldInfoPtr_NoSupply;

		// Token: 0x040069CC RID: 27084
		private static readonly IntPtr NativeFieldInfoPtr_SupplyLabel;

		// Token: 0x040069CD RID: 27085
		private static readonly IntPtr NativeFieldInfoPtr_PotRects;

		// Token: 0x040069CE RID: 27086
		private static readonly IntPtr NativeFieldInfoPtr__AssignedBotanist_k__BackingField;

		// Token: 0x040069CF RID: 27087
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedBotanist_Public_get_Botanist_0;

		// Token: 0x040069D0 RID: 27088
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedBotanist_Protected_set_Void_Botanist_0;

		// Token: 0x040069D1 RID: 27089
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Botanist_0;

		// Token: 0x040069D2 RID: 27090
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040069D3 RID: 27091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
