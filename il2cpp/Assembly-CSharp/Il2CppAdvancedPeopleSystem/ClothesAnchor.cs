using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000143 RID: 323
	[Serializable]
	public class ClothesAnchor : Il2CppSystem.Object
	{
		// Token: 0x06001B0A RID: 6922 RVA: 0x000C54E4 File Offset: 0x000C36E4
		// Note: this type is marked as 'beforefieldinit'.
		static ClothesAnchor()
		{
			Il2CppClassPointerStore<ClothesAnchor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "ClothesAnchor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothesAnchor>.NativeClassPtr);
			ClothesAnchor.NativeFieldInfoPtr_partType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesAnchor>.NativeClassPtr, "partType");
			ClothesAnchor.NativeFieldInfoPtr_skinnedMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesAnchor>.NativeClassPtr, "skinnedMesh");
			ClothesAnchor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothesAnchor>.NativeClassPtr, 100666194);
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x000C5550 File Offset: 0x000C3750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99601, RefRangeEnd = 99602, XrefRangeStart = 99593, XrefRangeEnd = 99601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothesAnchor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothesAnchor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothesAnchor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x0000F43E File Offset: 0x0000D63E
		public ClothesAnchor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x000C558C File Offset: 0x000C378C
		// (set) Token: 0x06001B0E RID: 6926 RVA: 0x0000F447 File Offset: 0x0000D647
		public unsafe CharacterElementType partType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesAnchor.NativeFieldInfoPtr_partType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesAnchor.NativeFieldInfoPtr_partType)) = value;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x000C55B4 File Offset: 0x000C37B4
		// (set) Token: 0x06001B10 RID: 6928 RVA: 0x0000F462 File Offset: 0x0000D662
		public unsafe List<SkinnedMeshRenderer> skinnedMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesAnchor.NativeFieldInfoPtr_skinnedMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesAnchor.NativeFieldInfoPtr_skinnedMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeFieldInfoPtr_partType;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeFieldInfoPtr_skinnedMesh;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
