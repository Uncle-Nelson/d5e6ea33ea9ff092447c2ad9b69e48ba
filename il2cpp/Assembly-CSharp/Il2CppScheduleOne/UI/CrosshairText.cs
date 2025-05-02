using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200062F RID: 1583
	public class CrosshairText : MonoBehaviour
	{
		// Token: 0x06008BB7 RID: 35767 RVA: 0x00248730 File Offset: 0x00246930
		// Note: this type is marked as 'beforefieldinit'.
		static CrosshairText()
		{
			Il2CppClassPointerStore<CrosshairText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CrosshairText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr);
			CrosshairText.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, "Label");
			CrosshairText.NativeFieldInfoPtr_setThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, "setThisFrame");
			CrosshairText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100680647);
			CrosshairText.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100680648);
			CrosshairText.NativeMethodInfoPtr_Show_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100680649);
			CrosshairText.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100680650);
			CrosshairText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100680651);
		}

		// Token: 0x06008BB8 RID: 35768 RVA: 0x002487EC File Offset: 0x002469EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BB9 RID: 35769 RVA: 0x00248820 File Offset: 0x00246A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256079, XrefRangeEnd = 256080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BBA RID: 35770 RVA: 0x00248854 File Offset: 0x00246A54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 256083, RefRangeEnd = 256086, XrefRangeStart = 256080, XrefRangeEnd = 256083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show(string text, Color col = default(Color))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr_Show_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BBB RID: 35771 RVA: 0x002488A4 File Offset: 0x00246AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BBC RID: 35772 RVA: 0x002488D8 File Offset: 0x00246AD8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrosshairText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BBD RID: 35773 RVA: 0x00042EA4 File Offset: 0x000410A4
		public CrosshairText(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A9C RID: 10908
		// (get) Token: 0x06008BBE RID: 35774 RVA: 0x00248914 File Offset: 0x00246B14
		// (set) Token: 0x06008BBF RID: 35775 RVA: 0x00042EAD File Offset: 0x000410AD
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrosshairText.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrosshairText.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A9D RID: 10909
		// (get) Token: 0x06008BC0 RID: 35776 RVA: 0x00248944 File Offset: 0x00246B44
		// (set) Token: 0x06008BC1 RID: 35777 RVA: 0x00042ECC File Offset: 0x000410CC
		public unsafe bool setThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrosshairText.NativeFieldInfoPtr_setThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrosshairText.NativeFieldInfoPtr_setThisFrame)) = value;
			}
		}

		// Token: 0x04005EBA RID: 24250
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04005EBB RID: 24251
		private static readonly IntPtr NativeFieldInfoPtr_setThisFrame;

		// Token: 0x04005EBC RID: 24252
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005EBD RID: 24253
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005EBE RID: 24254
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_String_Color_0;

		// Token: 0x04005EBF RID: 24255
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

		// Token: 0x04005EC0 RID: 24256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
