using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200062B RID: 1579
	public class CharacterDisplay : Singleton<CharacterDisplay>
	{
		// Token: 0x06008B39 RID: 35641 RVA: 0x00246E14 File Offset: 0x00245014
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterDisplay()
		{
			Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CharacterDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr);
			CharacterDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "<IsOpen>k__BackingField");
			CharacterDisplay.NativeFieldInfoPtr_AlignmentPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "AlignmentPoints");
			CharacterDisplay.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "Container");
			CharacterDisplay.NativeFieldInfoPtr_ParentAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "ParentAvatar");
			CharacterDisplay.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "Avatar");
			CharacterDisplay.NativeFieldInfoPtr_AvatarContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "AvatarContainer");
			CharacterDisplay.NativeFieldInfoPtr_targetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "targetRotation");
			CharacterDisplay.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680590);
			CharacterDisplay.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680591);
			CharacterDisplay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680592);
			CharacterDisplay.NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680593);
			CharacterDisplay.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680594);
			CharacterDisplay.NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680595);
			CharacterDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680596);
			CharacterDisplay.NativeMethodInfoPtr__Awake_b__11_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680597);
		}

		// Token: 0x17002A78 RID: 10872
		// (get) Token: 0x06008B3A RID: 35642 RVA: 0x00246F70 File Offset: 0x00245170
		// (set) Token: 0x06008B3B RID: 35643 RVA: 0x00246FAC File Offset: 0x002451AC
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37992, RefRangeEnd = 38015, XrefRangeStart = 37992, XrefRangeEnd = 38015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008B3C RID: 35644 RVA: 0x00246FEC File Offset: 0x002451EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255192, XrefRangeEnd = 255213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterDisplay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B3D RID: 35645 RVA: 0x00247028 File Offset: 0x00245228
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 255235, RefRangeEnd = 255240, XrefRangeStart = 255213, XrefRangeEnd = 255235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B3E RID: 35646 RVA: 0x00247068 File Offset: 0x00245268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255240, XrefRangeEnd = 255248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B3F RID: 35647 RVA: 0x0024709C File Offset: 0x0024529C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 255276, RefRangeEnd = 255279, XrefRangeStart = 255248, XrefRangeEnd = 255276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAppearance(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B40 RID: 35648 RVA: 0x002470E0 File Offset: 0x002452E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255279, XrefRangeEnd = 255282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B41 RID: 35649 RVA: 0x0024711C File Offset: 0x0024531C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255282, XrefRangeEnd = 255284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__11_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr__Awake_b__11_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B42 RID: 35650 RVA: 0x00042A64 File Offset: 0x00040C64
		public CharacterDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A71 RID: 10865
		// (get) Token: 0x06008B43 RID: 35651 RVA: 0x00247150 File Offset: 0x00245350
		// (set) Token: 0x06008B44 RID: 35652 RVA: 0x00042A6D File Offset: 0x00040C6D
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A72 RID: 10866
		// (get) Token: 0x06008B45 RID: 35653 RVA: 0x00247178 File Offset: 0x00245378
		// (set) Token: 0x06008B46 RID: 35654 RVA: 0x00042A88 File Offset: 0x00040C88
		public unsafe Il2CppReferenceArray<CharacterDisplay.SlotAlignmentPoint> AlignmentPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_AlignmentPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterDisplay.SlotAlignmentPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_AlignmentPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A73 RID: 10867
		// (get) Token: 0x06008B47 RID: 35655 RVA: 0x002471A8 File Offset: 0x002453A8
		// (set) Token: 0x06008B48 RID: 35656 RVA: 0x00042AA7 File Offset: 0x00040CA7
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A74 RID: 10868
		// (get) Token: 0x06008B49 RID: 35657 RVA: 0x002471D8 File Offset: 0x002453D8
		// (set) Token: 0x06008B4A RID: 35658 RVA: 0x00042AC6 File Offset: 0x00040CC6
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar ParentAvatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_ParentAvatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_ParentAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A75 RID: 10869
		// (get) Token: 0x06008B4B RID: 35659 RVA: 0x00247208 File Offset: 0x00245408
		// (set) Token: 0x06008B4C RID: 35660 RVA: 0x00042AE5 File Offset: 0x00040CE5
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A76 RID: 10870
		// (get) Token: 0x06008B4D RID: 35661 RVA: 0x00247238 File Offset: 0x00245438
		// (set) Token: 0x06008B4E RID: 35662 RVA: 0x00042B04 File Offset: 0x00040D04
		public unsafe Transform AvatarContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_AvatarContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_AvatarContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A77 RID: 10871
		// (get) Token: 0x06008B4F RID: 35663 RVA: 0x00247268 File Offset: 0x00245468
		// (set) Token: 0x06008B50 RID: 35664 RVA: 0x00042B23 File Offset: 0x00040D23
		public unsafe float targetRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_targetRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_targetRotation)) = value;
			}
		}

		// Token: 0x04005E67 RID: 24167
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005E68 RID: 24168
		private static readonly IntPtr NativeFieldInfoPtr_AlignmentPoints;

		// Token: 0x04005E69 RID: 24169
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005E6A RID: 24170
		private static readonly IntPtr NativeFieldInfoPtr_ParentAvatar;

		// Token: 0x04005E6B RID: 24171
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04005E6C RID: 24172
		private static readonly IntPtr NativeFieldInfoPtr_AvatarContainer;

		// Token: 0x04005E6D RID: 24173
		private static readonly IntPtr NativeFieldInfoPtr_targetRotation;

		// Token: 0x04005E6E RID: 24174
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005E6F RID: 24175
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04005E70 RID: 24176
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005E71 RID: 24177
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0;

		// Token: 0x04005E72 RID: 24178
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005E73 RID: 24179
		private static readonly IntPtr NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0;

		// Token: 0x04005E74 RID: 24180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005E75 RID: 24181
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__11_0_Private_Void_0;

		// Token: 0x02000B16 RID: 2838
		[Serializable]
		public class SlotAlignmentPoint : Il2CppSystem.Object
		{
			// Token: 0x0600D6DC RID: 55004 RVA: 0x00332100 File Offset: 0x00330300
			// Note: this type is marked as 'beforefieldinit'.
			static SlotAlignmentPoint()
			{
				Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "SlotAlignmentPoint");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr);
				CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_SlotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr, "SlotType");
				CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr, "Point");
				CharacterDisplay.SlotAlignmentPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr, 100680598);
			}

			// Token: 0x0600D6DD RID: 55005 RVA: 0x00332168 File Offset: 0x00330368
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SlotAlignmentPoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.SlotAlignmentPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6DE RID: 55006 RVA: 0x00068912 File Offset: 0x00066B12
			public SlotAlignmentPoint(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700428F RID: 17039
			// (get) Token: 0x0600D6DF RID: 55007 RVA: 0x003321A4 File Offset: 0x003303A4
			// (set) Token: 0x0600D6E0 RID: 55008 RVA: 0x0006891B File Offset: 0x00066B1B
			public unsafe EClothingSlot SlotType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_SlotType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_SlotType)) = value;
				}
			}

			// Token: 0x17004290 RID: 17040
			// (get) Token: 0x0600D6E1 RID: 55009 RVA: 0x003321CC File Offset: 0x003303CC
			// (set) Token: 0x0600D6E2 RID: 55010 RVA: 0x00068936 File Offset: 0x00066B36
			public unsafe Transform Point
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_Point);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_Point), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400907E RID: 36990
			private static readonly IntPtr NativeFieldInfoPtr_SlotType;

			// Token: 0x0400907F RID: 36991
			private static readonly IntPtr NativeFieldInfoPtr_Point;

			// Token: 0x04009080 RID: 36992
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
