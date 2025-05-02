using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005B7 RID: 1463
	public class Equippable_Cuke : Equippable_Viewmodel
	{
		// Token: 0x06008075 RID: 32885 RVA: 0x00225840 File Offset: 0x00223A40
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Cuke()
		{
			Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Cuke");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr);
			Equippable_Cuke.NativeFieldInfoPtr__IsDrinking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "<IsDrinking>k__BackingField");
			Equippable_Cuke.NativeFieldInfoPtr_BaseEnergyGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "BaseEnergyGain");
			Equippable_Cuke.NativeFieldInfoPtr_MinEnergyGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "MinEnergyGain");
			Equippable_Cuke.NativeFieldInfoPtr_ConsecutiveReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "ConsecutiveReduction");
			Equippable_Cuke.NativeFieldInfoPtr_HealthGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "HealthGain");
			Equippable_Cuke.NativeFieldInfoPtr_AnimationDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "AnimationDuration");
			Equippable_Cuke.NativeFieldInfoPtr_ClearDrugEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "ClearDrugEffects");
			Equippable_Cuke.NativeFieldInfoPtr_OpenAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "OpenAnim");
			Equippable_Cuke.NativeFieldInfoPtr_DrinkAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "DrinkAnim");
			Equippable_Cuke.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "OpenSound");
			Equippable_Cuke.NativeFieldInfoPtr_SlurpSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "SlurpSound");
			Equippable_Cuke.NativeFieldInfoPtr_TrashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "TrashPrefab");
			Equippable_Cuke.NativeMethodInfoPtr_get_IsDrinking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679420);
			Equippable_Cuke.NativeMethodInfoPtr_set_IsDrinking_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679421);
			Equippable_Cuke.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679422);
			Equippable_Cuke.NativeMethodInfoPtr_Drink_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679423);
			Equippable_Cuke.NativeMethodInfoPtr_ApplyEffects_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679424);
			Equippable_Cuke.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679425);
			Equippable_Cuke.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679426);
		}

		// Token: 0x170026D8 RID: 9944
		// (get) Token: 0x06008076 RID: 32886 RVA: 0x002259EC File Offset: 0x00223BEC
		// (set) Token: 0x06008077 RID: 32887 RVA: 0x00225A28 File Offset: 0x00223C28
		public unsafe bool IsDrinking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_get_IsDrinking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_set_IsDrinking_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008078 RID: 32888 RVA: 0x00225A68 File Offset: 0x00223C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244629, XrefRangeEnd = 244646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cuke.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008079 RID: 32889 RVA: 0x00225AA4 File Offset: 0x00223CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244646, XrefRangeEnd = 244652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Drink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_Drink_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600807A RID: 32890 RVA: 0x00225AD8 File Offset: 0x00223CD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244681, RefRangeEnd = 244682, XrefRangeStart = 244652, XrefRangeEnd = 244681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_ApplyEffects_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600807B RID: 32891 RVA: 0x00225B0C File Offset: 0x00223D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244682, XrefRangeEnd = 244685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Cuke() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600807C RID: 32892 RVA: 0x00225B48 File Offset: 0x00223D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244685, XrefRangeEnd = 244690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600807D RID: 32893 RVA: 0x0003CED2 File Offset: 0x0003B0D2
		public Equippable_Cuke(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026CC RID: 9932
		// (get) Token: 0x0600807E RID: 32894 RVA: 0x00225B88 File Offset: 0x00223D88
		// (set) Token: 0x0600807F RID: 32895 RVA: 0x0003CEDB File Offset: 0x0003B0DB
		public unsafe bool _IsDrinking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr__IsDrinking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr__IsDrinking_k__BackingField)) = value;
			}
		}

		// Token: 0x170026CD RID: 9933
		// (get) Token: 0x06008080 RID: 32896 RVA: 0x00225BB0 File Offset: 0x00223DB0
		// (set) Token: 0x06008081 RID: 32897 RVA: 0x0003CEF6 File Offset: 0x0003B0F6
		public unsafe float BaseEnergyGain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_BaseEnergyGain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_BaseEnergyGain)) = value;
			}
		}

		// Token: 0x170026CE RID: 9934
		// (get) Token: 0x06008082 RID: 32898 RVA: 0x00225BD8 File Offset: 0x00223DD8
		// (set) Token: 0x06008083 RID: 32899 RVA: 0x0003CF11 File Offset: 0x0003B111
		public unsafe float MinEnergyGain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_MinEnergyGain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_MinEnergyGain)) = value;
			}
		}

		// Token: 0x170026CF RID: 9935
		// (get) Token: 0x06008084 RID: 32900 RVA: 0x00225C00 File Offset: 0x00223E00
		// (set) Token: 0x06008085 RID: 32901 RVA: 0x0003CF2C File Offset: 0x0003B12C
		public unsafe float ConsecutiveReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_ConsecutiveReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_ConsecutiveReduction)) = value;
			}
		}

		// Token: 0x170026D0 RID: 9936
		// (get) Token: 0x06008086 RID: 32902 RVA: 0x00225C28 File Offset: 0x00223E28
		// (set) Token: 0x06008087 RID: 32903 RVA: 0x0003CF47 File Offset: 0x0003B147
		public unsafe float HealthGain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_HealthGain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_HealthGain)) = value;
			}
		}

		// Token: 0x170026D1 RID: 9937
		// (get) Token: 0x06008088 RID: 32904 RVA: 0x00225C50 File Offset: 0x00223E50
		// (set) Token: 0x06008089 RID: 32905 RVA: 0x0003CF62 File Offset: 0x0003B162
		public unsafe float AnimationDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_AnimationDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_AnimationDuration)) = value;
			}
		}

		// Token: 0x170026D2 RID: 9938
		// (get) Token: 0x0600808A RID: 32906 RVA: 0x00225C78 File Offset: 0x00223E78
		// (set) Token: 0x0600808B RID: 32907 RVA: 0x0003CF7D File Offset: 0x0003B17D
		public unsafe bool ClearDrugEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_ClearDrugEffects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_ClearDrugEffects)) = value;
			}
		}

		// Token: 0x170026D3 RID: 9939
		// (get) Token: 0x0600808C RID: 32908 RVA: 0x00225CA0 File Offset: 0x00223EA0
		// (set) Token: 0x0600808D RID: 32909 RVA: 0x0003CF98 File Offset: 0x0003B198
		public unsafe Animation OpenAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_OpenAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_OpenAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026D4 RID: 9940
		// (get) Token: 0x0600808E RID: 32910 RVA: 0x00225CD0 File Offset: 0x00223ED0
		// (set) Token: 0x0600808F RID: 32911 RVA: 0x0003CFB7 File Offset: 0x0003B1B7
		public unsafe Animation DrinkAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_DrinkAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_DrinkAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026D5 RID: 9941
		// (get) Token: 0x06008090 RID: 32912 RVA: 0x00225D00 File Offset: 0x00223F00
		// (set) Token: 0x06008091 RID: 32913 RVA: 0x0003CFD6 File Offset: 0x0003B1D6
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_OpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026D6 RID: 9942
		// (get) Token: 0x06008092 RID: 32914 RVA: 0x00225D30 File Offset: 0x00223F30
		// (set) Token: 0x06008093 RID: 32915 RVA: 0x0003CFF5 File Offset: 0x0003B1F5
		public unsafe AudioSourceController SlurpSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_SlurpSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_SlurpSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026D7 RID: 9943
		// (get) Token: 0x06008094 RID: 32916 RVA: 0x00225D60 File Offset: 0x00223F60
		// (set) Token: 0x06008095 RID: 32917 RVA: 0x0003D014 File Offset: 0x0003B214
		public unsafe TrashItem TrashPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_TrashPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_TrashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005783 RID: 22403
		private static readonly IntPtr NativeFieldInfoPtr__IsDrinking_k__BackingField;

		// Token: 0x04005784 RID: 22404
		private static readonly IntPtr NativeFieldInfoPtr_BaseEnergyGain;

		// Token: 0x04005785 RID: 22405
		private static readonly IntPtr NativeFieldInfoPtr_MinEnergyGain;

		// Token: 0x04005786 RID: 22406
		private static readonly IntPtr NativeFieldInfoPtr_ConsecutiveReduction;

		// Token: 0x04005787 RID: 22407
		private static readonly IntPtr NativeFieldInfoPtr_HealthGain;

		// Token: 0x04005788 RID: 22408
		private static readonly IntPtr NativeFieldInfoPtr_AnimationDuration;

		// Token: 0x04005789 RID: 22409
		private static readonly IntPtr NativeFieldInfoPtr_ClearDrugEffects;

		// Token: 0x0400578A RID: 22410
		private static readonly IntPtr NativeFieldInfoPtr_OpenAnim;

		// Token: 0x0400578B RID: 22411
		private static readonly IntPtr NativeFieldInfoPtr_DrinkAnim;

		// Token: 0x0400578C RID: 22412
		private static readonly IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x0400578D RID: 22413
		private static readonly IntPtr NativeFieldInfoPtr_SlurpSound;

		// Token: 0x0400578E RID: 22414
		private static readonly IntPtr NativeFieldInfoPtr_TrashPrefab;

		// Token: 0x0400578F RID: 22415
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDrinking_Public_get_Boolean_0;

		// Token: 0x04005790 RID: 22416
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDrinking_Protected_set_Void_Boolean_0;

		// Token: 0x04005791 RID: 22417
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005792 RID: 22418
		private static readonly IntPtr NativeMethodInfoPtr_Drink_Public_Void_0;

		// Token: 0x04005793 RID: 22419
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffects_Public_Void_0;

		// Token: 0x04005794 RID: 22420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005795 RID: 22421
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000ADF RID: 2783
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_Cuke+<<Drink>g__DrinkRoutine|16_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D506 RID: 54534 RVA: 0x0032CC60 File Offset: 0x0032AE60
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique()
			{
				Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "<<Drink>g__DrinkRoutine|16_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>1__state");
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>2__current");
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>4__this");
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679427);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679428);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679429);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679430);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679431);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679432);
			}

			// Token: 0x0600D507 RID: 54535 RVA: 0x0032CD40 File Offset: 0x0032AF40
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D508 RID: 54536 RVA: 0x0032CD88 File Offset: 0x0032AF88
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D509 RID: 54537 RVA: 0x0032CDBC File Offset: 0x0032AFBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244578, XrefRangeEnd = 244624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004203 RID: 16899
			// (get) Token: 0x0600D50A RID: 54538 RVA: 0x0032CDF8 File Offset: 0x0032AFF8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D50B RID: 54539 RVA: 0x0032CE38 File Offset: 0x0032B038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244624, XrefRangeEnd = 244629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004204 RID: 16900
			// (get) Token: 0x0600D50C RID: 54540 RVA: 0x0032CE6C File Offset: 0x0032B06C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D50D RID: 54541 RVA: 0x00067A91 File Offset: 0x00065C91
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004200 RID: 16896
			// (get) Token: 0x0600D50E RID: 54542 RVA: 0x0032CEAC File Offset: 0x0032B0AC
			// (set) Token: 0x0600D50F RID: 54543 RVA: 0x00067A9A File Offset: 0x00065C9A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004201 RID: 16897
			// (get) Token: 0x0600D510 RID: 54544 RVA: 0x0032CED4 File Offset: 0x0032B0D4
			// (set) Token: 0x0600D511 RID: 54545 RVA: 0x00067AB5 File Offset: 0x00065CB5
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004202 RID: 16898
			// (get) Token: 0x0600D512 RID: 54546 RVA: 0x0032CF04 File Offset: 0x0032B104
			// (set) Token: 0x0600D513 RID: 54547 RVA: 0x00067AD4 File Offset: 0x00065CD4
			public unsafe Equippable_Cuke __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_Cuke>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F50 RID: 36688
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F51 RID: 36689
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F52 RID: 36690
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F53 RID: 36691
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F54 RID: 36692
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F55 RID: 36693
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F56 RID: 36694
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F57 RID: 36695
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F58 RID: 36696
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
