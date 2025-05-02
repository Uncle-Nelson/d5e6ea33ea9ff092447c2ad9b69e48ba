using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000710 RID: 1808
	public class ShopInterfaceDetailPanel : MonoBehaviour
	{
		// Token: 0x0600A2C7 RID: 41671 RVA: 0x0028E2F0 File Offset: 0x0028C4F0
		// Note: this type is marked as 'beforefieldinit'.
		static ShopInterfaceDetailPanel()
		{
			Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopInterfaceDetailPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr);
			ShopInterfaceDetailPanel.NativeFieldInfoPtr_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, "Panel");
			ShopInterfaceDetailPanel.NativeFieldInfoPtr_LayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, "LayoutGroup");
			ShopInterfaceDetailPanel.NativeFieldInfoPtr_DescriptionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, "DescriptionLabel");
			ShopInterfaceDetailPanel.NativeFieldInfoPtr_UnlockLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, "UnlockLabel");
			ShopInterfaceDetailPanel.NativeFieldInfoPtr_listing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, "listing");
			ShopInterfaceDetailPanel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683220);
			ShopInterfaceDetailPanel.NativeMethodInfoPtr_Open_Public_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683221);
			ShopInterfaceDetailPanel.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683222);
			ShopInterfaceDetailPanel.NativeMethodInfoPtr_Position_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683223);
			ShopInterfaceDetailPanel.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683224);
			ShopInterfaceDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683225);
			ShopInterfaceDetailPanel.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683226);
		}

		// Token: 0x0600A2C8 RID: 41672 RVA: 0x0028E410 File Offset: 0x0028C610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285787, XrefRangeEnd = 285790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2C9 RID: 41673 RVA: 0x0028E444 File Offset: 0x0028C644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285813, RefRangeEnd = 285814, XrefRangeStart = 285790, XrefRangeEnd = 285813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ListingUI _listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr_Open_Public_Void_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2CA RID: 41674 RVA: 0x0028E488 File Offset: 0x0028C688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285814, XrefRangeEnd = 285815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2CB RID: 41675 RVA: 0x0028E4BC File Offset: 0x0028C6BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285825, RefRangeEnd = 285826, XrefRangeStart = 285815, XrefRangeEnd = 285825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Position()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr_Position_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2CC RID: 41676 RVA: 0x0028E4F0 File Offset: 0x0028C6F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285830, RefRangeEnd = 285832, XrefRangeStart = 285826, XrefRangeEnd = 285830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2CD RID: 41677 RVA: 0x0028E524 File Offset: 0x0028C724
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopInterfaceDetailPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2CE RID: 41678 RVA: 0x0028E560 File Offset: 0x0028C760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285832, XrefRangeEnd = 285837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A2CF RID: 41679 RVA: 0x000501D4 File Offset: 0x0004E3D4
		public ShopInterfaceDetailPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700322F RID: 12847
		// (get) Token: 0x0600A2D0 RID: 41680 RVA: 0x0028E5A0 File Offset: 0x0028C7A0
		// (set) Token: 0x0600A2D1 RID: 41681 RVA: 0x000501DD File Offset: 0x0004E3DD
		public unsafe RectTransform Panel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_Panel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003230 RID: 12848
		// (get) Token: 0x0600A2D2 RID: 41682 RVA: 0x0028E5D0 File Offset: 0x0028C7D0
		// (set) Token: 0x0600A2D3 RID: 41683 RVA: 0x000501FC File Offset: 0x0004E3FC
		public unsafe VerticalLayoutGroup LayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_LayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_LayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003231 RID: 12849
		// (get) Token: 0x0600A2D4 RID: 41684 RVA: 0x0028E600 File Offset: 0x0028C800
		// (set) Token: 0x0600A2D5 RID: 41685 RVA: 0x0005021B File Offset: 0x0004E41B
		public unsafe TextMeshProUGUI DescriptionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_DescriptionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_DescriptionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003232 RID: 12850
		// (get) Token: 0x0600A2D6 RID: 41686 RVA: 0x0028E630 File Offset: 0x0028C830
		// (set) Token: 0x0600A2D7 RID: 41687 RVA: 0x0005023A File Offset: 0x0004E43A
		public unsafe TextMeshProUGUI UnlockLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_UnlockLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_UnlockLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003233 RID: 12851
		// (get) Token: 0x0600A2D8 RID: 41688 RVA: 0x0028E660 File Offset: 0x0028C860
		// (set) Token: 0x0600A2D9 RID: 41689 RVA: 0x00050259 File Offset: 0x0004E459
		public unsafe ListingUI listing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_listing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_listing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D34 RID: 27956
		private static readonly IntPtr NativeFieldInfoPtr_Panel;

		// Token: 0x04006D35 RID: 27957
		private static readonly IntPtr NativeFieldInfoPtr_LayoutGroup;

		// Token: 0x04006D36 RID: 27958
		private static readonly IntPtr NativeFieldInfoPtr_DescriptionLabel;

		// Token: 0x04006D37 RID: 27959
		private static readonly IntPtr NativeFieldInfoPtr_UnlockLabel;

		// Token: 0x04006D38 RID: 27960
		private static readonly IntPtr NativeFieldInfoPtr_listing;

		// Token: 0x04006D39 RID: 27961
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006D3A RID: 27962
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ListingUI_0;

		// Token: 0x04006D3B RID: 27963
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006D3C RID: 27964
		private static readonly IntPtr NativeMethodInfoPtr_Position_Private_Void_0;

		// Token: 0x04006D3D RID: 27965
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006D3E RID: 27966
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006D3F RID: 27967
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000BBD RID: 3005
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterfaceDetailPanel+<<Open>g__Wait|6_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DD8B RID: 56715 RVA: 0x003451C4 File Offset: 0x003433C4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique()
			{
				Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, "<<Open>g__Wait|6_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr);
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, "<>1__state");
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, "<>2__current");
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, "<>4__this");
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, 100683227);
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, 100683228);
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, 100683229);
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, 100683230);
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, 100683231);
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, 100683232);
			}

			// Token: 0x0600DD8C RID: 56716 RVA: 0x003452A4 File Offset: 0x003434A4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD8D RID: 56717 RVA: 0x003452EC File Offset: 0x003434EC
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD8E RID: 56718 RVA: 0x00345320 File Offset: 0x00343520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285775, XrefRangeEnd = 285782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044A8 RID: 17576
			// (get) Token: 0x0600DD8F RID: 56719 RVA: 0x0034535C File Offset: 0x0034355C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD90 RID: 56720 RVA: 0x0034539C File Offset: 0x0034359C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285782, XrefRangeEnd = 285787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044A9 RID: 17577
			// (get) Token: 0x0600DD91 RID: 56721 RVA: 0x003453D0 File Offset: 0x003435D0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD92 RID: 56722 RVA: 0x0006BF6F File Offset: 0x0006A16F
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044A5 RID: 17573
			// (get) Token: 0x0600DD93 RID: 56723 RVA: 0x00345410 File Offset: 0x00343610
			// (set) Token: 0x0600DD94 RID: 56724 RVA: 0x0006BF78 File Offset: 0x0006A178
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044A6 RID: 17574
			// (get) Token: 0x0600DD95 RID: 56725 RVA: 0x00345438 File Offset: 0x00343638
			// (set) Token: 0x0600DD96 RID: 56726 RVA: 0x0006BF93 File Offset: 0x0006A193
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044A7 RID: 17575
			// (get) Token: 0x0600DD97 RID: 56727 RVA: 0x00345468 File Offset: 0x00343668
			// (set) Token: 0x0600DD98 RID: 56728 RVA: 0x0006BFB2 File Offset: 0x0006A1B2
			public unsafe ShopInterfaceDetailPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterfaceDetailPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009467 RID: 37991
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009468 RID: 37992
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009469 RID: 37993
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400946A RID: 37994
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400946B RID: 37995
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400946C RID: 37996
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400946D RID: 37997
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400946E RID: 37998
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400946F RID: 37999
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
