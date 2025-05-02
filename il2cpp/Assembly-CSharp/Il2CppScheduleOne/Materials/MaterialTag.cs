using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Materials
{
	// Token: 0x0200037B RID: 891
	public class MaterialTag : MonoBehaviour
	{
		// Token: 0x060045D7 RID: 17879 RVA: 0x00157C40 File Offset: 0x00155E40
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialTag()
		{
			Il2CppClassPointerStore<MaterialTag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Materials", "MaterialTag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialTag>.NativeClassPtr);
			MaterialTag.NativeFieldInfoPtr_MaterialType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialTag>.NativeClassPtr, "MaterialType");
			MaterialTag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialTag>.NativeClassPtr, 100671885);
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x00157C98 File Offset: 0x00155E98
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialTag() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialTag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialTag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x00022021 File Offset: 0x00020221
		public MaterialTag(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x060045DA RID: 17882 RVA: 0x00157CD4 File Offset: 0x00155ED4
		// (set) Token: 0x060045DB RID: 17883 RVA: 0x0002202A File Offset: 0x0002022A
		public unsafe EMaterialType MaterialType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialTag.NativeFieldInfoPtr_MaterialType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialTag.NativeFieldInfoPtr_MaterialType)) = value;
			}
		}

		// Token: 0x04002EE4 RID: 12004
		private static readonly IntPtr NativeFieldInfoPtr_MaterialType;

		// Token: 0x04002EE5 RID: 12005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
