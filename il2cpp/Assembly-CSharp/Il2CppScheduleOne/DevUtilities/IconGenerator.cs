using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Packaging;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000456 RID: 1110
	public class IconGenerator : Singleton<IconGenerator>
	{
		// Token: 0x0600608E RID: 24718 RVA: 0x001B9968 File Offset: 0x001B7B68
		// Note: this type is marked as 'beforefieldinit'.
		static IconGenerator()
		{
			Il2CppClassPointerStore<IconGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "IconGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr);
			IconGenerator.NativeFieldInfoPtr_IconSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "IconSize");
			IconGenerator.NativeFieldInfoPtr_OutputPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "OutputPath");
			IconGenerator.NativeFieldInfoPtr_ModifyLighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "ModifyLighting");
			IconGenerator.NativeFieldInfoPtr_Registry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "Registry");
			IconGenerator.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "CameraPosition");
			IconGenerator.NativeFieldInfoPtr_MainContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "MainContainer");
			IconGenerator.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "ItemContainer");
			IconGenerator.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "Canvas");
			IconGenerator.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "Visuals");
			IconGenerator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675582);
			IconGenerator.NativeMethodInfoPtr_GenerateIcon_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675583);
			IconGenerator.NativeMethodInfoPtr_GeneratePackagingIcon_Public_Texture2D_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675584);
			IconGenerator.NativeMethodInfoPtr_GetTexture_Public_Texture2D_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675585);
			IconGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675586);
		}

		// Token: 0x0600608F RID: 24719 RVA: 0x001B9AB0 File Offset: 0x001B7CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199376, XrefRangeEnd = 199393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IconGenerator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006090 RID: 24720 RVA: 0x001B9AEC File Offset: 0x001B7CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199393, XrefRangeEnd = 199431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.NativeMethodInfoPtr_GenerateIcon_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006091 RID: 24721 RVA: 0x001B9B20 File Offset: 0x001B7D20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199487, RefRangeEnd = 199488, XrefRangeStart = 199431, XrefRangeEnd = 199487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GeneratePackagingIcon(string packagingID, string productID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.NativeMethodInfoPtr_GeneratePackagingIcon_Public_Texture2D_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06006092 RID: 24722 RVA: 0x001B9B84 File Offset: 0x001B7D84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 199520, RefRangeEnd = 199524, XrefRangeStart = 199488, XrefRangeEnd = 199520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GetTexture(Transform model)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(model);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.NativeMethodInfoPtr_GetTexture_Public_Texture2D_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06006093 RID: 24723 RVA: 0x001B9BD4 File Offset: 0x001B7DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199524, XrefRangeEnd = 199527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IconGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006094 RID: 24724 RVA: 0x0002DA57 File Offset: 0x0002BC57
		public IconGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x06006095 RID: 24725 RVA: 0x001B9C10 File Offset: 0x001B7E10
		// (set) Token: 0x06006096 RID: 24726 RVA: 0x0002DA60 File Offset: 0x0002BC60
		public unsafe int IconSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_IconSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_IconSize)) = value;
			}
		}

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x06006097 RID: 24727 RVA: 0x001B9C38 File Offset: 0x001B7E38
		// (set) Token: 0x06006098 RID: 24728 RVA: 0x0002DA7B File Offset: 0x0002BC7B
		public unsafe string OutputPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_OutputPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_OutputPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x06006099 RID: 24729 RVA: 0x001B9C60 File Offset: 0x001B7E60
		// (set) Token: 0x0600609A RID: 24730 RVA: 0x0002DA9A File Offset: 0x0002BC9A
		public unsafe bool ModifyLighting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_ModifyLighting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_ModifyLighting)) = value;
			}
		}

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x0600609B RID: 24731 RVA: 0x001B9C88 File Offset: 0x001B7E88
		// (set) Token: 0x0600609C RID: 24732 RVA: 0x0002DAB5 File Offset: 0x0002BCB5
		public unsafe Registry Registry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Registry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Registry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Registry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x0600609D RID: 24733 RVA: 0x001B9CB8 File Offset: 0x001B7EB8
		// (set) Token: 0x0600609E RID: 24734 RVA: 0x0002DAD4 File Offset: 0x0002BCD4
		public unsafe Camera CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x0600609F RID: 24735 RVA: 0x001B9CE8 File Offset: 0x001B7EE8
		// (set) Token: 0x060060A0 RID: 24736 RVA: 0x0002DAF3 File Offset: 0x0002BCF3
		public unsafe Transform MainContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_MainContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_MainContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x060060A1 RID: 24737 RVA: 0x001B9D18 File Offset: 0x001B7F18
		// (set) Token: 0x060060A2 RID: 24738 RVA: 0x0002DB12 File Offset: 0x0002BD12
		public unsafe Transform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x060060A3 RID: 24739 RVA: 0x001B9D48 File Offset: 0x001B7F48
		// (set) Token: 0x060060A4 RID: 24740 RVA: 0x0002DB31 File Offset: 0x0002BD31
		public unsafe GameObject Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x060060A5 RID: 24741 RVA: 0x001B9D78 File Offset: 0x001B7F78
		// (set) Token: 0x060060A6 RID: 24742 RVA: 0x0002DB50 File Offset: 0x0002BD50
		public unsafe List<IconGenerator.PackagingVisuals> Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IconGenerator.PackagingVisuals>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040041EB RID: 16875
		private static readonly IntPtr NativeFieldInfoPtr_IconSize;

		// Token: 0x040041EC RID: 16876
		private static readonly IntPtr NativeFieldInfoPtr_OutputPath;

		// Token: 0x040041ED RID: 16877
		private static readonly IntPtr NativeFieldInfoPtr_ModifyLighting;

		// Token: 0x040041EE RID: 16878
		private static readonly IntPtr NativeFieldInfoPtr_Registry;

		// Token: 0x040041EF RID: 16879
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x040041F0 RID: 16880
		private static readonly IntPtr NativeFieldInfoPtr_MainContainer;

		// Token: 0x040041F1 RID: 16881
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x040041F2 RID: 16882
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040041F3 RID: 16883
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040041F4 RID: 16884
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040041F5 RID: 16885
		private static readonly IntPtr NativeMethodInfoPtr_GenerateIcon_Public_Void_0;

		// Token: 0x040041F6 RID: 16886
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePackagingIcon_Public_Texture2D_String_String_0;

		// Token: 0x040041F7 RID: 16887
		private static readonly IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture2D_Transform_0;

		// Token: 0x040041F8 RID: 16888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A10 RID: 2576
		[Serializable]
		public class PackagingVisuals : Il2CppSystem.Object
		{
			// Token: 0x0600CEC5 RID: 52933 RVA: 0x0031B83C File Offset: 0x00319A3C
			// Note: this type is marked as 'beforefieldinit'.
			static PackagingVisuals()
			{
				Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "PackagingVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr);
				IconGenerator.PackagingVisuals.NativeFieldInfoPtr_PackagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr, "PackagingID");
				IconGenerator.PackagingVisuals.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr, "Visuals");
				IconGenerator.PackagingVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr, 100675587);
			}

			// Token: 0x0600CEC6 RID: 52934 RVA: 0x0031B8A4 File Offset: 0x00319AA4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PackagingVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.PackagingVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEC7 RID: 52935 RVA: 0x0006490B File Offset: 0x00062B0B
			public PackagingVisuals(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700404C RID: 16460
			// (get) Token: 0x0600CEC8 RID: 52936 RVA: 0x0031B8E0 File Offset: 0x00319AE0
			// (set) Token: 0x0600CEC9 RID: 52937 RVA: 0x00064914 File Offset: 0x00062B14
			public unsafe string PackagingID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.PackagingVisuals.NativeFieldInfoPtr_PackagingID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.PackagingVisuals.NativeFieldInfoPtr_PackagingID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700404D RID: 16461
			// (get) Token: 0x0600CECA RID: 52938 RVA: 0x0031B908 File Offset: 0x00319B08
			// (set) Token: 0x0600CECB RID: 52939 RVA: 0x00064933 File Offset: 0x00062B33
			public unsafe FilledPackagingVisuals Visuals
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.PackagingVisuals.NativeFieldInfoPtr_Visuals);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.PackagingVisuals.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B87 RID: 35719
			private static readonly IntPtr NativeFieldInfoPtr_PackagingID;

			// Token: 0x04008B88 RID: 35720
			private static readonly IntPtr NativeFieldInfoPtr_Visuals;

			// Token: 0x04008B89 RID: 35721
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A11 RID: 2577
		[ObfuscatedName("ScheduleOne.DevUtilities.IconGenerator+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CECC RID: 52940 RVA: 0x0031B938 File Offset: 0x00319B38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<IconGenerator.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass12_0>.NativeClassPtr);
				IconGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_packagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass12_0>.NativeClassPtr, "packagingID");
				IconGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass12_0>.NativeClassPtr, 100675588);
				IconGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__GeneratePackagingIcon_b__0_Internal_Boolean_PackagingVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass12_0>.NativeClassPtr, 100675589);
			}

			// Token: 0x0600CECD RID: 52941 RVA: 0x0031B9A0 File Offset: 0x00319BA0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CECE RID: 52942 RVA: 0x0031B9DC File Offset: 0x00319BDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199374, XrefRangeEnd = 199376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GeneratePackagingIcon_b__0(IconGenerator.PackagingVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__GeneratePackagingIcon_b__0_Internal_Boolean_PackagingVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CECF RID: 52943 RVA: 0x00064952 File Offset: 0x00062B52
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700404E RID: 16462
			// (get) Token: 0x0600CED0 RID: 52944 RVA: 0x0031BA2C File Offset: 0x00319C2C
			// (set) Token: 0x0600CED1 RID: 52945 RVA: 0x0006495B File Offset: 0x00062B5B
			public unsafe string packagingID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_packagingID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_packagingID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B8A RID: 35722
			private static readonly IntPtr NativeFieldInfoPtr_packagingID;

			// Token: 0x04008B8B RID: 35723
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B8C RID: 35724
			private static readonly IntPtr NativeMethodInfoPtr__GeneratePackagingIcon_b__0_Internal_Boolean_PackagingVisuals_0;
		}
	}
}
