using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000583 RID: 1411
	public class StorageDoorAnimation : MonoBehaviour
	{
		// Token: 0x06007C40 RID: 31808 RVA: 0x00216658 File Offset: 0x00214858
		// Note: this type is marked as 'beforefieldinit'.
		static StorageDoorAnimation()
		{
			Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageDoorAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr);
			StorageDoorAnimation.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "<IsOpen>k__BackingField");
			StorageDoorAnimation.NativeFieldInfoPtr_overriddeIsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "overriddeIsOpen");
			StorageDoorAnimation.NativeFieldInfoPtr_overrideState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "overrideState");
			StorageDoorAnimation.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "ItemContainer");
			StorageDoorAnimation.NativeFieldInfoPtr_Anims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "Anims");
			StorageDoorAnimation.NativeFieldInfoPtr_OpenAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "OpenAnim");
			StorageDoorAnimation.NativeFieldInfoPtr_CloseAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "CloseAnim");
			StorageDoorAnimation.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "OpenSound");
			StorageDoorAnimation.NativeFieldInfoPtr_CloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "CloseSound");
			StorageDoorAnimation.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678877);
			StorageDoorAnimation.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678878);
			StorageDoorAnimation.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678879);
			StorageDoorAnimation.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678880);
			StorageDoorAnimation.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678881);
			StorageDoorAnimation.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678882);
			StorageDoorAnimation.NativeMethodInfoPtr_DisableItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678883);
			StorageDoorAnimation.NativeMethodInfoPtr_OverrideState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678884);
			StorageDoorAnimation.NativeMethodInfoPtr_ResetOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678885);
			StorageDoorAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678886);
		}

		// Token: 0x17002595 RID: 9621
		// (get) Token: 0x06007C41 RID: 31809 RVA: 0x00216804 File Offset: 0x00214A04
		// (set) Token: 0x06007C42 RID: 31810 RVA: 0x00216840 File Offset: 0x00214A40
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007C43 RID: 31811 RVA: 0x00216880 File Offset: 0x00214A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237423, XrefRangeEnd = 237429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C44 RID: 31812 RVA: 0x002168B4 File Offset: 0x00214AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237429, XrefRangeEnd = 237430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C45 RID: 31813 RVA: 0x002168E8 File Offset: 0x00214AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237430, XrefRangeEnd = 237431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C46 RID: 31814 RVA: 0x0021691C File Offset: 0x00214B1C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 237451, RefRangeEnd = 237459, XrefRangeStart = 237431, XrefRangeEnd = 237451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C47 RID: 31815 RVA: 0x0021695C File Offset: 0x00214B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237459, XrefRangeEnd = 237465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_DisableItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C48 RID: 31816 RVA: 0x00216990 File Offset: 0x00214B90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237466, RefRangeEnd = 237467, XrefRangeStart = 237465, XrefRangeEnd = 237466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideState(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_OverrideState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C49 RID: 31817 RVA: 0x002169D0 File Offset: 0x00214BD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217121, RefRangeEnd = 217123, XrefRangeStart = 217121, XrefRangeEnd = 217123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_ResetOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C4A RID: 31818 RVA: 0x00216A04 File Offset: 0x00214C04
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageDoorAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C4B RID: 31819 RVA: 0x0003AF04 File Offset: 0x00039104
		public StorageDoorAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700258C RID: 9612
		// (get) Token: 0x06007C4C RID: 31820 RVA: 0x00216A40 File Offset: 0x00214C40
		// (set) Token: 0x06007C4D RID: 31821 RVA: 0x0003AF0D File Offset: 0x0003910D
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700258D RID: 9613
		// (get) Token: 0x06007C4E RID: 31822 RVA: 0x00216A68 File Offset: 0x00214C68
		// (set) Token: 0x06007C4F RID: 31823 RVA: 0x0003AF28 File Offset: 0x00039128
		public unsafe bool overriddeIsOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_overriddeIsOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_overriddeIsOpen)) = value;
			}
		}

		// Token: 0x1700258E RID: 9614
		// (get) Token: 0x06007C50 RID: 31824 RVA: 0x00216A90 File Offset: 0x00214C90
		// (set) Token: 0x06007C51 RID: 31825 RVA: 0x0003AF43 File Offset: 0x00039143
		public unsafe bool overrideState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_overrideState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_overrideState)) = value;
			}
		}

		// Token: 0x1700258F RID: 9615
		// (get) Token: 0x06007C52 RID: 31826 RVA: 0x00216AB8 File Offset: 0x00214CB8
		// (set) Token: 0x06007C53 RID: 31827 RVA: 0x0003AF5E File Offset: 0x0003915E
		public unsafe Transform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002590 RID: 9616
		// (get) Token: 0x06007C54 RID: 31828 RVA: 0x00216AE8 File Offset: 0x00214CE8
		// (set) Token: 0x06007C55 RID: 31829 RVA: 0x0003AF7D File Offset: 0x0003917D
		public unsafe Il2CppReferenceArray<Animation> Anims
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_Anims);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Animation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_Anims), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002591 RID: 9617
		// (get) Token: 0x06007C56 RID: 31830 RVA: 0x00216B18 File Offset: 0x00214D18
		// (set) Token: 0x06007C57 RID: 31831 RVA: 0x0003AF9C File Offset: 0x0003919C
		public unsafe AnimationClip OpenAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_OpenAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_OpenAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002592 RID: 9618
		// (get) Token: 0x06007C58 RID: 31832 RVA: 0x00216B48 File Offset: 0x00214D48
		// (set) Token: 0x06007C59 RID: 31833 RVA: 0x0003AFBB File Offset: 0x000391BB
		public unsafe AnimationClip CloseAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_CloseAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_CloseAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002593 RID: 9619
		// (get) Token: 0x06007C5A RID: 31834 RVA: 0x00216B78 File Offset: 0x00214D78
		// (set) Token: 0x06007C5B RID: 31835 RVA: 0x0003AFDA File Offset: 0x000391DA
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_OpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002594 RID: 9620
		// (get) Token: 0x06007C5C RID: 31836 RVA: 0x00216BA8 File Offset: 0x00214DA8
		// (set) Token: 0x06007C5D RID: 31837 RVA: 0x0003AFF9 File Offset: 0x000391F9
		public unsafe AudioSourceController CloseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_CloseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_CloseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400549E RID: 21662
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400549F RID: 21663
		private static readonly IntPtr NativeFieldInfoPtr_overriddeIsOpen;

		// Token: 0x040054A0 RID: 21664
		private static readonly IntPtr NativeFieldInfoPtr_overrideState;

		// Token: 0x040054A1 RID: 21665
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x040054A2 RID: 21666
		private static readonly IntPtr NativeFieldInfoPtr_Anims;

		// Token: 0x040054A3 RID: 21667
		private static readonly IntPtr NativeFieldInfoPtr_OpenAnim;

		// Token: 0x040054A4 RID: 21668
		private static readonly IntPtr NativeFieldInfoPtr_CloseAnim;

		// Token: 0x040054A5 RID: 21669
		private static readonly IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x040054A6 RID: 21670
		private static readonly IntPtr NativeFieldInfoPtr_CloseSound;

		// Token: 0x040054A7 RID: 21671
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040054A8 RID: 21672
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040054A9 RID: 21673
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040054AA RID: 21674
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x040054AB RID: 21675
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040054AC RID: 21676
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x040054AD RID: 21677
		private static readonly IntPtr NativeMethodInfoPtr_DisableItems_Private_Void_0;

		// Token: 0x040054AE RID: 21678
		private static readonly IntPtr NativeMethodInfoPtr_OverrideState_Public_Void_Boolean_0;

		// Token: 0x040054AF RID: 21679
		private static readonly IntPtr NativeMethodInfoPtr_ResetOverride_Public_Void_0;

		// Token: 0x040054B0 RID: 21680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
