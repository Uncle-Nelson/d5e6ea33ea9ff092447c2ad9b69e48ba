using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003EC RID: 1004
	public class ViewmodelAvatar : Singleton<ViewmodelAvatar>
	{
		// Token: 0x06005252 RID: 21074 RVA: 0x00185DF8 File Offset: 0x00183FF8
		// Note: this type is marked as 'beforefieldinit'.
		static ViewmodelAvatar()
		{
			Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "ViewmodelAvatar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr);
			ViewmodelAvatar.NativeFieldInfoPtr__IsVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "<IsVisible>k__BackingField");
			ViewmodelAvatar.NativeFieldInfoPtr_ParentAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "ParentAvatar");
			ViewmodelAvatar.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "Animator");
			ViewmodelAvatar.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "Avatar");
			ViewmodelAvatar.NativeFieldInfoPtr_RightHandContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "RightHandContainer");
			ViewmodelAvatar.NativeFieldInfoPtr_baseOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "baseOffset");
			ViewmodelAvatar.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673619);
			ViewmodelAvatar.NativeMethodInfoPtr_set_IsVisible_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673620);
			ViewmodelAvatar.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673621);
			ViewmodelAvatar.NativeMethodInfoPtr_SetVisibility_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673622);
			ViewmodelAvatar.NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673623);
			ViewmodelAvatar.NativeMethodInfoPtr_SetAnimatorController_Public_Void_RuntimeAnimatorController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673624);
			ViewmodelAvatar.NativeMethodInfoPtr_SetOffset_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673625);
			ViewmodelAvatar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673626);
			ViewmodelAvatar.NativeMethodInfoPtr__Awake_b__9_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673627);
		}

		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x06005253 RID: 21075 RVA: 0x00185F54 File Offset: 0x00184154
		// (set) Token: 0x06005254 RID: 21076 RVA: 0x00185F90 File Offset: 0x00184190
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_set_IsVisible_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005255 RID: 21077 RVA: 0x00185FD0 File Offset: 0x001841D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177890, XrefRangeEnd = 177914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViewmodelAvatar.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005256 RID: 21078 RVA: 0x0018600C File Offset: 0x0018420C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 177921, RefRangeEnd = 177926, XrefRangeStart = 177914, XrefRangeEnd = 177921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisibility(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_SetVisibility_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x0018604C File Offset: 0x0018424C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177954, RefRangeEnd = 177956, XrefRangeStart = 177926, XrefRangeEnd = 177954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAppearance(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005258 RID: 21080 RVA: 0x00186090 File Offset: 0x00184290
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177958, RefRangeEnd = 177960, XrefRangeStart = 177956, XrefRangeEnd = 177958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimatorController(RuntimeAnimatorController controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_SetAnimatorController_Public_Void_RuntimeAnimatorController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x001860D4 File Offset: 0x001842D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177962, RefRangeEnd = 177964, XrefRangeStart = 177960, XrefRangeEnd = 177962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOffset(Vector3 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_SetOffset_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600525A RID: 21082 RVA: 0x00186114 File Offset: 0x00184314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177964, XrefRangeEnd = 177967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViewmodelAvatar() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600525B RID: 21083 RVA: 0x00186150 File Offset: 0x00184350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177967, XrefRangeEnd = 177969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__9_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr__Awake_b__9_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600525C RID: 21084 RVA: 0x000272CB File Offset: 0x000254CB
		public ViewmodelAvatar(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x0600525D RID: 21085 RVA: 0x00186184 File Offset: 0x00184384
		// (set) Token: 0x0600525E RID: 21086 RVA: 0x000272D4 File Offset: 0x000254D4
		public unsafe bool _IsVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr__IsVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr__IsVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x0600525F RID: 21087 RVA: 0x001861AC File Offset: 0x001843AC
		// (set) Token: 0x06005260 RID: 21088 RVA: 0x000272EF File Offset: 0x000254EF
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar ParentAvatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_ParentAvatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_ParentAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x06005261 RID: 21089 RVA: 0x001861DC File Offset: 0x001843DC
		// (set) Token: 0x06005262 RID: 21090 RVA: 0x0002730E File Offset: 0x0002550E
		public unsafe Animator Animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_Animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x06005263 RID: 21091 RVA: 0x0018620C File Offset: 0x0018440C
		// (set) Token: 0x06005264 RID: 21092 RVA: 0x0002732D File Offset: 0x0002552D
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x06005265 RID: 21093 RVA: 0x0018623C File Offset: 0x0018443C
		// (set) Token: 0x06005266 RID: 21094 RVA: 0x0002734C File Offset: 0x0002554C
		public unsafe Transform RightHandContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_RightHandContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_RightHandContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x06005267 RID: 21095 RVA: 0x0018626C File Offset: 0x0018446C
		// (set) Token: 0x06005268 RID: 21096 RVA: 0x0002736B File Offset: 0x0002556B
		public unsafe Vector3 baseOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_baseOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_baseOffset)) = value;
			}
		}

		// Token: 0x040037D9 RID: 14297
		private static readonly IntPtr NativeFieldInfoPtr__IsVisible_k__BackingField;

		// Token: 0x040037DA RID: 14298
		private static readonly IntPtr NativeFieldInfoPtr_ParentAvatar;

		// Token: 0x040037DB RID: 14299
		private static readonly IntPtr NativeFieldInfoPtr_Animator;

		// Token: 0x040037DC RID: 14300
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x040037DD RID: 14301
		private static readonly IntPtr NativeFieldInfoPtr_RightHandContainer;

		// Token: 0x040037DE RID: 14302
		private static readonly IntPtr NativeFieldInfoPtr_baseOffset;

		// Token: 0x040037DF RID: 14303
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x040037E0 RID: 14304
		private static readonly IntPtr NativeMethodInfoPtr_set_IsVisible_Private_set_Void_Boolean_0;

		// Token: 0x040037E1 RID: 14305
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040037E2 RID: 14306
		private static readonly IntPtr NativeMethodInfoPtr_SetVisibility_Public_Void_Boolean_0;

		// Token: 0x040037E3 RID: 14307
		private static readonly IntPtr NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0;

		// Token: 0x040037E4 RID: 14308
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimatorController_Public_Void_RuntimeAnimatorController_0;

		// Token: 0x040037E5 RID: 14309
		private static readonly IntPtr NativeMethodInfoPtr_SetOffset_Public_Void_Vector3_0;

		// Token: 0x040037E6 RID: 14310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040037E7 RID: 14311
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__9_0_Private_Void_0;
	}
}
