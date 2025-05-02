using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000043 RID: 67
	public class MaterialChanger : MonoBehaviour
	{
		// Token: 0x060005BA RID: 1466 RVA: 0x00081824 File Offset: 0x0007FA24
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialChanger()
		{
			Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MaterialChanger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr);
			MaterialChanger.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, "_value");
			MaterialChanger.NativeFieldInfoPtr__changeMaterialSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, "_changeMaterialSetting");
			MaterialChanger.NativeFieldInfoPtr__renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, "_renderers");
			MaterialChanger.NativeFieldInfoPtr__propBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, "_propBlock");
			MaterialChanger.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, 100663840);
			MaterialChanger.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, 100663841);
			MaterialChanger.NativeMethodInfoPtr_FindAllMaterialInChild_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, 100663842);
			MaterialChanger.NativeMethodInfoPtr_SetNewValueForAllMaterial_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, 100663843);
			MaterialChanger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, 100663844);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00081908 File Offset: 0x0007FB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75582, XrefRangeEnd = 75588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialChanger.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0008193C File Offset: 0x0007FB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75588, XrefRangeEnd = 75602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialChanger.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00081970 File Offset: 0x0007FB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindAllMaterialInChild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialChanger.NativeMethodInfoPtr_FindAllMaterialInChild_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000819A4 File Offset: 0x0007FBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75602, XrefRangeEnd = 75611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNewValueForAllMaterial(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialChanger.NativeMethodInfoPtr_SetNewValueForAllMaterial_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000819E4 File Offset: 0x0007FBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75611, XrefRangeEnd = 75616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialChanger() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialChanger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00005603 File Offset: 0x00003803
		public MaterialChanger(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00081A20 File Offset: 0x0007FC20
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x0000560C File Offset: 0x0000380C
		public unsafe float _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__value)) = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00081A48 File Offset: 0x0007FC48
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x00005627 File Offset: 0x00003827
		public unsafe string _changeMaterialSetting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__changeMaterialSetting);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__changeMaterialSetting), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00081A70 File Offset: 0x0007FC70
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00005646 File Offset: 0x00003846
		public unsafe Il2CppReferenceArray<Renderer> _renderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__renderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__renderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00081AA0 File Offset: 0x0007FCA0
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x00005665 File Offset: 0x00003865
		public unsafe MaterialPropertyBlock _propBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__propBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__propBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeFieldInfoPtr__changeMaterialSetting;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeFieldInfoPtr__renderers;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeFieldInfoPtr__propBlock;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_FindAllMaterialInChild_Private_Void_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_SetNewValueForAllMaterial_Private_Void_Single_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
