using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.UI.Tooltips;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Delivery
{
	// Token: 0x020006AC RID: 1708
	public class DeliveryStatusDisplay : MonoBehaviour
	{
		// Token: 0x0600994F RID: 39247 RVA: 0x002711CC File Offset: 0x0026F3CC
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryStatusDisplay()
		{
			Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Delivery", "DeliveryStatusDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr);
			DeliveryStatusDisplay.NativeFieldInfoPtr__DeliveryInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "<DeliveryInstance>k__BackingField");
			DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "ItemEntryPrefab");
			DeliveryStatusDisplay.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "Rect");
			DeliveryStatusDisplay.NativeFieldInfoPtr_DestinationLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "DestinationLabel");
			DeliveryStatusDisplay.NativeFieldInfoPtr_ShopLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "ShopLabel");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusImage");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusLabel");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusTooltip");
			DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "ItemEntryContainer");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Transit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusColor_Transit");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Waiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusColor_Waiting");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Arrived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusColor_Arrived");
			DeliveryStatusDisplay.NativeMethodInfoPtr_get_DeliveryInstance_Public_get_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100682216);
			DeliveryStatusDisplay.NativeMethodInfoPtr_set_DeliveryInstance_Private_set_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100682217);
			DeliveryStatusDisplay.NativeMethodInfoPtr_AssignDelivery_Public_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100682218);
			DeliveryStatusDisplay.NativeMethodInfoPtr_RefreshStatus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100682219);
			DeliveryStatusDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100682220);
		}

		// Token: 0x17002F24 RID: 12068
		// (get) Token: 0x06009950 RID: 39248 RVA: 0x00271350 File Offset: 0x0026F550
		// (set) Token: 0x06009951 RID: 39249 RVA: 0x00271390 File Offset: 0x0026F590
		public unsafe DeliveryInstance DeliveryInstance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_get_DeliveryInstance_Public_get_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_set_DeliveryInstance_Private_set_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009952 RID: 39250 RVA: 0x002713D4 File Offset: 0x0026F5D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273871, RefRangeEnd = 273873, XrefRangeStart = 273835, XrefRangeEnd = 273871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignDelivery(DeliveryInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_AssignDelivery_Public_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009953 RID: 39251 RVA: 0x00271418 File Offset: 0x0026F618
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 273885, RefRangeEnd = 273888, XrefRangeStart = 273873, XrefRangeEnd = 273885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_RefreshStatus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009954 RID: 39252 RVA: 0x0027144C File Offset: 0x0026F64C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryStatusDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009955 RID: 39253 RVA: 0x0004ABC5 File Offset: 0x00048DC5
		public DeliveryStatusDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F18 RID: 12056
		// (get) Token: 0x06009956 RID: 39254 RVA: 0x00271488 File Offset: 0x0026F688
		// (set) Token: 0x06009957 RID: 39255 RVA: 0x0004ABCE File Offset: 0x00048DCE
		public unsafe DeliveryInstance _DeliveryInstance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr__DeliveryInstance_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr__DeliveryInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F19 RID: 12057
		// (get) Token: 0x06009958 RID: 39256 RVA: 0x002714B8 File Offset: 0x0026F6B8
		// (set) Token: 0x06009959 RID: 39257 RVA: 0x0004ABED File Offset: 0x00048DED
		public unsafe GameObject ItemEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F1A RID: 12058
		// (get) Token: 0x0600995A RID: 39258 RVA: 0x002714E8 File Offset: 0x0026F6E8
		// (set) Token: 0x0600995B RID: 39259 RVA: 0x0004AC0C File Offset: 0x00048E0C
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F1B RID: 12059
		// (get) Token: 0x0600995C RID: 39260 RVA: 0x00271518 File Offset: 0x0026F718
		// (set) Token: 0x0600995D RID: 39261 RVA: 0x0004AC2B File Offset: 0x00048E2B
		public unsafe Text DestinationLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_DestinationLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_DestinationLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F1C RID: 12060
		// (get) Token: 0x0600995E RID: 39262 RVA: 0x00271548 File Offset: 0x0026F748
		// (set) Token: 0x0600995F RID: 39263 RVA: 0x0004AC4A File Offset: 0x00048E4A
		public unsafe Text ShopLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ShopLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ShopLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F1D RID: 12061
		// (get) Token: 0x06009960 RID: 39264 RVA: 0x00271578 File Offset: 0x0026F778
		// (set) Token: 0x06009961 RID: 39265 RVA: 0x0004AC69 File Offset: 0x00048E69
		public unsafe Image StatusImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F1E RID: 12062
		// (get) Token: 0x06009962 RID: 39266 RVA: 0x002715A8 File Offset: 0x0026F7A8
		// (set) Token: 0x06009963 RID: 39267 RVA: 0x0004AC88 File Offset: 0x00048E88
		public unsafe Text StatusLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F1F RID: 12063
		// (get) Token: 0x06009964 RID: 39268 RVA: 0x002715D8 File Offset: 0x0026F7D8
		// (set) Token: 0x06009965 RID: 39269 RVA: 0x0004ACA7 File Offset: 0x00048EA7
		public unsafe Tooltip StatusTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusTooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F20 RID: 12064
		// (get) Token: 0x06009966 RID: 39270 RVA: 0x00271608 File Offset: 0x0026F808
		// (set) Token: 0x06009967 RID: 39271 RVA: 0x0004ACC6 File Offset: 0x00048EC6
		public unsafe RectTransform ItemEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F21 RID: 12065
		// (get) Token: 0x06009968 RID: 39272 RVA: 0x00271638 File Offset: 0x0026F838
		// (set) Token: 0x06009969 RID: 39273 RVA: 0x0004ACE5 File Offset: 0x00048EE5
		public unsafe Color StatusColor_Transit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Transit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Transit)) = value;
			}
		}

		// Token: 0x17002F22 RID: 12066
		// (get) Token: 0x0600996A RID: 39274 RVA: 0x00271660 File Offset: 0x0026F860
		// (set) Token: 0x0600996B RID: 39275 RVA: 0x0004AD00 File Offset: 0x00048F00
		public unsafe Color StatusColor_Waiting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Waiting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Waiting)) = value;
			}
		}

		// Token: 0x17002F23 RID: 12067
		// (get) Token: 0x0600996C RID: 39276 RVA: 0x00271688 File Offset: 0x0026F888
		// (set) Token: 0x0600996D RID: 39277 RVA: 0x0004AD1B File Offset: 0x00048F1B
		public unsafe Color StatusColor_Arrived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Arrived);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Arrived)) = value;
			}
		}

		// Token: 0x0400673A RID: 26426
		private static readonly IntPtr NativeFieldInfoPtr__DeliveryInstance_k__BackingField;

		// Token: 0x0400673B RID: 26427
		private static readonly IntPtr NativeFieldInfoPtr_ItemEntryPrefab;

		// Token: 0x0400673C RID: 26428
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x0400673D RID: 26429
		private static readonly IntPtr NativeFieldInfoPtr_DestinationLabel;

		// Token: 0x0400673E RID: 26430
		private static readonly IntPtr NativeFieldInfoPtr_ShopLabel;

		// Token: 0x0400673F RID: 26431
		private static readonly IntPtr NativeFieldInfoPtr_StatusImage;

		// Token: 0x04006740 RID: 26432
		private static readonly IntPtr NativeFieldInfoPtr_StatusLabel;

		// Token: 0x04006741 RID: 26433
		private static readonly IntPtr NativeFieldInfoPtr_StatusTooltip;

		// Token: 0x04006742 RID: 26434
		private static readonly IntPtr NativeFieldInfoPtr_ItemEntryContainer;

		// Token: 0x04006743 RID: 26435
		private static readonly IntPtr NativeFieldInfoPtr_StatusColor_Transit;

		// Token: 0x04006744 RID: 26436
		private static readonly IntPtr NativeFieldInfoPtr_StatusColor_Waiting;

		// Token: 0x04006745 RID: 26437
		private static readonly IntPtr NativeFieldInfoPtr_StatusColor_Arrived;

		// Token: 0x04006746 RID: 26438
		private static readonly IntPtr NativeMethodInfoPtr_get_DeliveryInstance_Public_get_DeliveryInstance_0;

		// Token: 0x04006747 RID: 26439
		private static readonly IntPtr NativeMethodInfoPtr_set_DeliveryInstance_Private_set_Void_DeliveryInstance_0;

		// Token: 0x04006748 RID: 26440
		private static readonly IntPtr NativeMethodInfoPtr_AssignDelivery_Public_Void_DeliveryInstance_0;

		// Token: 0x04006749 RID: 26441
		private static readonly IntPtr NativeMethodInfoPtr_RefreshStatus_Public_Void_0;

		// Token: 0x0400674A RID: 26442
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
