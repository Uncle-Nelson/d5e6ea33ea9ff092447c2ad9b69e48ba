using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000531 RID: 1329
	[Serializable]
	public class ColorSmoother : Il2CppSystem.Object
	{
		// Token: 0x06007676 RID: 30326 RVA: 0x002033F8 File Offset: 0x002015F8
		// Note: this type is marked as 'beforefieldinit'.
		static ColorSmoother()
		{
			Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ColorSmoother");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr);
			ColorSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "<CurrentValue>k__BackingField");
			ColorSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "<Multiplier>k__BackingField");
			ColorSmoother.NativeFieldInfoPtr_DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "DefaultValue");
			ColorSmoother.NativeFieldInfoPtr_SmoothingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "SmoothingSpeed");
			ColorSmoother.NativeFieldInfoPtr_overrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "overrides");
			ColorSmoother.NativeMethodInfoPtr_get_CurrentValue_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678211);
			ColorSmoother.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678212);
			ColorSmoother.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678213);
			ColorSmoother.NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678214);
			ColorSmoother.NativeMethodInfoPtr_get_Default_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678215);
			ColorSmoother.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678216);
			ColorSmoother.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678217);
			ColorSmoother.NativeMethodInfoPtr_SetDefault_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678218);
			ColorSmoother.NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678219);
			ColorSmoother.NativeMethodInfoPtr_AddOverride_Public_Void_Color_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678220);
			ColorSmoother.NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678221);
			ColorSmoother.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678222);
			ColorSmoother.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678223);
		}

		// Token: 0x170023E1 RID: 9185
		// (get) Token: 0x06007677 RID: 30327 RVA: 0x00203590 File Offset: 0x00201790
		// (set) Token: 0x06007678 RID: 30328 RVA: 0x002035CC File Offset: 0x002017CC
		public unsafe Color CurrentValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29961, RefRangeEnd = 29962, XrefRangeStart = 29961, XrefRangeEnd = 29962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_get_CurrentValue_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170023E2 RID: 9186
		// (get) Token: 0x06007679 RID: 30329 RVA: 0x0020360C File Offset: 0x0020180C
		// (set) Token: 0x0600767A RID: 30330 RVA: 0x00203648 File Offset: 0x00201848
		public unsafe float Multiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29962, RefRangeEnd = 29963, XrefRangeStart = 29962, XrefRangeEnd = 29963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170023E3 RID: 9187
		// (get) Token: 0x0600767B RID: 30331 RVA: 0x00203688 File Offset: 0x00201888
		public unsafe Color Default
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_get_Default_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600767C RID: 30332 RVA: 0x002036C4 File Offset: 0x002018C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 231009, RefRangeEnd = 231010, XrefRangeStart = 230988, XrefRangeEnd = 231009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600767D RID: 30333 RVA: 0x002036F8 File Offset: 0x002018F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231010, XrefRangeEnd = 231028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600767E RID: 30334 RVA: 0x0020372C File Offset: 0x0020192C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 231031, RefRangeEnd = 231032, XrefRangeStart = 231028, XrefRangeEnd = 231031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefault(Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_SetDefault_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600767F RID: 30335 RVA: 0x0020376C File Offset: 0x0020196C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29962, RefRangeEnd = 29963, XrefRangeStart = 29962, XrefRangeEnd = 29963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMultiplier(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007680 RID: 30336 RVA: 0x002037AC File Offset: 0x002019AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 231076, RefRangeEnd = 231081, XrefRangeStart = 231032, XrefRangeEnd = 231076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOverride(Color value, int priority, string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_AddOverride_Public_Void_Color_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007681 RID: 30337 RVA: 0x0020380C File Offset: 0x00201A0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 231117, RefRangeEnd = 231119, XrefRangeStart = 231081, XrefRangeEnd = 231117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOverride(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007682 RID: 30338 RVA: 0x00203850 File Offset: 0x00201A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231119, XrefRangeEnd = 231125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007683 RID: 30339 RVA: 0x00203884 File Offset: 0x00201A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231125, XrefRangeEnd = 231133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorSmoother() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007684 RID: 30340 RVA: 0x00038225 File Offset: 0x00036425
		public ColorSmoother(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023DC RID: 9180
		// (get) Token: 0x06007685 RID: 30341 RVA: 0x002038C0 File Offset: 0x00201AC0
		// (set) Token: 0x06007686 RID: 30342 RVA: 0x0003822E File Offset: 0x0003642E
		public unsafe Color _CurrentValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField)) = value;
			}
		}

		// Token: 0x170023DD RID: 9181
		// (get) Token: 0x06007687 RID: 30343 RVA: 0x002038E8 File Offset: 0x00201AE8
		// (set) Token: 0x06007688 RID: 30344 RVA: 0x00038249 File Offset: 0x00036449
		public unsafe float _Multiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x170023DE RID: 9182
		// (get) Token: 0x06007689 RID: 30345 RVA: 0x00203910 File Offset: 0x00201B10
		// (set) Token: 0x0600768A RID: 30346 RVA: 0x00038264 File Offset: 0x00036464
		public unsafe Color DefaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr_DefaultValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr_DefaultValue)) = value;
			}
		}

		// Token: 0x170023DF RID: 9183
		// (get) Token: 0x0600768B RID: 30347 RVA: 0x00203938 File Offset: 0x00201B38
		// (set) Token: 0x0600768C RID: 30348 RVA: 0x0003827F File Offset: 0x0003647F
		public unsafe float SmoothingSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr_SmoothingSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr_SmoothingSpeed)) = value;
			}
		}

		// Token: 0x170023E0 RID: 9184
		// (get) Token: 0x0600768D RID: 30349 RVA: 0x00203960 File Offset: 0x00201B60
		// (set) Token: 0x0600768E RID: 30350 RVA: 0x0003829A File Offset: 0x0003649A
		public unsafe List<ColorSmoother.Override> overrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr_overrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ColorSmoother.Override>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr_overrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040050EA RID: 20714
		private static readonly IntPtr NativeFieldInfoPtr__CurrentValue_k__BackingField;

		// Token: 0x040050EB RID: 20715
		private static readonly IntPtr NativeFieldInfoPtr__Multiplier_k__BackingField;

		// Token: 0x040050EC RID: 20716
		private static readonly IntPtr NativeFieldInfoPtr_DefaultValue;

		// Token: 0x040050ED RID: 20717
		private static readonly IntPtr NativeFieldInfoPtr_SmoothingSpeed;

		// Token: 0x040050EE RID: 20718
		private static readonly IntPtr NativeFieldInfoPtr_overrides;

		// Token: 0x040050EF RID: 20719
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_get_Color_0;

		// Token: 0x040050F0 RID: 20720
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Color_0;

		// Token: 0x040050F1 RID: 20721
		private static readonly IntPtr NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0;

		// Token: 0x040050F2 RID: 20722
		private static readonly IntPtr NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0;

		// Token: 0x040050F3 RID: 20723
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_get_Color_0;

		// Token: 0x040050F4 RID: 20724
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x040050F5 RID: 20725
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x040050F6 RID: 20726
		private static readonly IntPtr NativeMethodInfoPtr_SetDefault_Public_Void_Color_0;

		// Token: 0x040050F7 RID: 20727
		private static readonly IntPtr NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0;

		// Token: 0x040050F8 RID: 20728
		private static readonly IntPtr NativeMethodInfoPtr_AddOverride_Public_Void_Color_Int32_String_0;

		// Token: 0x040050F9 RID: 20729
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0;

		// Token: 0x040050FA RID: 20730
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040050FB RID: 20731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A98 RID: 2712
		[Serializable]
		public class Override : Il2CppSystem.Object
		{
			// Token: 0x0600D2CD RID: 53965 RVA: 0x003268B4 File Offset: 0x00324AB4
			// Note: this type is marked as 'beforefieldinit'.
			static Override()
			{
				Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "Override");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr);
				ColorSmoother.Override.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr, "Value");
				ColorSmoother.Override.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr, "Priority");
				ColorSmoother.Override.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr, "Label");
				ColorSmoother.Override.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr, 100678224);
			}

			// Token: 0x0600D2CE RID: 53966 RVA: 0x00326930 File Offset: 0x00324B30
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Override() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.Override.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2CF RID: 53967 RVA: 0x000669EB File Offset: 0x00064BEB
			public Override(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004164 RID: 16740
			// (get) Token: 0x0600D2D0 RID: 53968 RVA: 0x0032696C File Offset: 0x00324B6C
			// (set) Token: 0x0600D2D1 RID: 53969 RVA: 0x000669F4 File Offset: 0x00064BF4
			public unsafe Color Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.Override.NativeFieldInfoPtr_Value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.Override.NativeFieldInfoPtr_Value)) = value;
				}
			}

			// Token: 0x17004165 RID: 16741
			// (get) Token: 0x0600D2D2 RID: 53970 RVA: 0x00326994 File Offset: 0x00324B94
			// (set) Token: 0x0600D2D3 RID: 53971 RVA: 0x00066A0F File Offset: 0x00064C0F
			public unsafe int Priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.Override.NativeFieldInfoPtr_Priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.Override.NativeFieldInfoPtr_Priority)) = value;
				}
			}

			// Token: 0x17004166 RID: 16742
			// (get) Token: 0x0600D2D4 RID: 53972 RVA: 0x003269BC File Offset: 0x00324BBC
			// (set) Token: 0x0600D2D5 RID: 53973 RVA: 0x00066A2A File Offset: 0x00064C2A
			public unsafe string Label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.Override.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.Override.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008E1A RID: 36378
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04008E1B RID: 36379
			private static readonly IntPtr NativeFieldInfoPtr_Priority;

			// Token: 0x04008E1C RID: 36380
			private static readonly IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x04008E1D RID: 36381
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A99 RID: 2713
		[ObfuscatedName("ScheduleOne.Tools.ColorSmoother+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D2D6 RID: 53974 RVA: 0x003269E4 File Offset: 0x00324BE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr);
				ColorSmoother.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr, "<>9");
				ColorSmoother.__c.NativeFieldInfoPtr___9__18_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr, "<>9__18_1");
				ColorSmoother.__c.NativeFieldInfoPtr___9__19_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr, "<>9__19_1");
				ColorSmoother.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr, 100678226);
				ColorSmoother.__c.NativeMethodInfoPtr__AddOverride_b__18_1_Internal_Int32_Override_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr, 100678227);
				ColorSmoother.__c.NativeMethodInfoPtr__RemoveOverride_b__19_1_Internal_Int32_Override_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr, 100678228);
			}

			// Token: 0x0600D2D7 RID: 53975 RVA: 0x00326A88 File Offset: 0x00324C88
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2D8 RID: 53976 RVA: 0x00326AC4 File Offset: 0x00324CC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230982, XrefRangeEnd = 230984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AddOverride_b__18_1(ColorSmoother.Override x, ColorSmoother.Override y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c.NativeMethodInfoPtr__AddOverride_b__18_1_Internal_Int32_Override_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D2D9 RID: 53977 RVA: 0x00326B24 File Offset: 0x00324D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RemoveOverride_b__19_1(ColorSmoother.Override x, ColorSmoother.Override y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c.NativeMethodInfoPtr__RemoveOverride_b__19_1_Internal_Int32_Override_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D2DA RID: 53978 RVA: 0x00066A49 File Offset: 0x00064C49
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004167 RID: 16743
			// (get) Token: 0x0600D2DB RID: 53979 RVA: 0x00326B84 File Offset: 0x00324D84
			// (set) Token: 0x0600D2DC RID: 53980 RVA: 0x00066A52 File Offset: 0x00064C52
			public unsafe static ColorSmoother.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ColorSmoother.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorSmoother.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorSmoother.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004168 RID: 16744
			// (get) Token: 0x0600D2DD RID: 53981 RVA: 0x00326BAC File Offset: 0x00324DAC
			// (set) Token: 0x0600D2DE RID: 53982 RVA: 0x00066A64 File Offset: 0x00064C64
			public unsafe static Comparison<ColorSmoother.Override> __9__18_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ColorSmoother.__c.NativeFieldInfoPtr___9__18_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ColorSmoother.Override>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorSmoother.__c.NativeFieldInfoPtr___9__18_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004169 RID: 16745
			// (get) Token: 0x0600D2DF RID: 53983 RVA: 0x00326BD4 File Offset: 0x00324DD4
			// (set) Token: 0x0600D2E0 RID: 53984 RVA: 0x00066A76 File Offset: 0x00064C76
			public unsafe static Comparison<ColorSmoother.Override> __9__19_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ColorSmoother.__c.NativeFieldInfoPtr___9__19_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ColorSmoother.Override>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorSmoother.__c.NativeFieldInfoPtr___9__19_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E1E RID: 36382
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008E1F RID: 36383
			private static readonly IntPtr NativeFieldInfoPtr___9__18_1;

			// Token: 0x04008E20 RID: 36384
			private static readonly IntPtr NativeFieldInfoPtr___9__19_1;

			// Token: 0x04008E21 RID: 36385
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E22 RID: 36386
			private static readonly IntPtr NativeMethodInfoPtr__AddOverride_b__18_1_Internal_Int32_Override_Override_0;

			// Token: 0x04008E23 RID: 36387
			private static readonly IntPtr NativeMethodInfoPtr__RemoveOverride_b__19_1_Internal_Int32_Override_Override_0;
		}

		// Token: 0x02000A9A RID: 2714
		[ObfuscatedName("ScheduleOne.Tools.ColorSmoother+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D2E1 RID: 53985 RVA: 0x00326BFC File Offset: 0x00324DFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass18_0>.NativeClassPtr);
				ColorSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass18_0>.NativeClassPtr, "label");
				ColorSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass18_0>.NativeClassPtr, 100678229);
				ColorSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass18_0>.NativeClassPtr, 100678230);
			}

			// Token: 0x0600D2E2 RID: 53986 RVA: 0x00326C64 File Offset: 0x00324E64
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2E3 RID: 53987 RVA: 0x00326CA0 File Offset: 0x00324EA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230984, XrefRangeEnd = 230988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddOverride_b__0(ColorSmoother.Override x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D2E4 RID: 53988 RVA: 0x00066A88 File Offset: 0x00064C88
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700416A RID: 16746
			// (get) Token: 0x0600D2E5 RID: 53989 RVA: 0x00326CF0 File Offset: 0x00324EF0
			// (set) Token: 0x0600D2E6 RID: 53990 RVA: 0x00066A91 File Offset: 0x00064C91
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008E24 RID: 36388
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04008E25 RID: 36389
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E26 RID: 36390
			private static readonly IntPtr NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0;
		}

		// Token: 0x02000A9B RID: 2715
		[ObfuscatedName("ScheduleOne.Tools.ColorSmoother+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D2E7 RID: 53991 RVA: 0x00326D18 File Offset: 0x00324F18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass19_0>.NativeClassPtr);
				ColorSmoother.__c__DisplayClass19_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass19_0>.NativeClassPtr, "label");
				ColorSmoother.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass19_0>.NativeClassPtr, 100678231);
				ColorSmoother.__c__DisplayClass19_0.NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass19_0>.NativeClassPtr, 100678232);
			}

			// Token: 0x0600D2E8 RID: 53992 RVA: 0x00326D80 File Offset: 0x00324F80
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2E9 RID: 53993 RVA: 0x00326DBC File Offset: 0x00324FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveOverride_b__0(ColorSmoother.Override x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c__DisplayClass19_0.NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D2EA RID: 53994 RVA: 0x00066AB0 File Offset: 0x00064CB0
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700416B RID: 16747
			// (get) Token: 0x0600D2EB RID: 53995 RVA: 0x00326E0C File Offset: 0x0032500C
			// (set) Token: 0x0600D2EC RID: 53996 RVA: 0x00066AB9 File Offset: 0x00064CB9
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.__c__DisplayClass19_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.__c__DisplayClass19_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008E27 RID: 36391
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04008E28 RID: 36392
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E29 RID: 36393
			private static readonly IntPtr NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0;
		}
	}
}
