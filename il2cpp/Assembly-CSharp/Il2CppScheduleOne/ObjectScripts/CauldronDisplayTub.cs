using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200073D RID: 1853
	public class CauldronDisplayTub : MonoBehaviour
	{
		// Token: 0x0600AAFE RID: 43774 RVA: 0x002AB5CC File Offset: 0x002A97CC
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronDisplayTub()
		{
			Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "CauldronDisplayTub");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr);
			CauldronDisplayTub.NativeFieldInfoPtr_CocaLeafContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, "CocaLeafContainer");
			CauldronDisplayTub.NativeFieldInfoPtr_Container_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, "Container_Min");
			CauldronDisplayTub.NativeFieldInfoPtr_Container_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, "Container_Max");
			CauldronDisplayTub.NativeMethodInfoPtr_Configure_Public_Void_EContents_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, 100684294);
			CauldronDisplayTub.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, 100684295);
		}

		// Token: 0x0600AAFF RID: 43775 RVA: 0x002AB660 File Offset: 0x002A9860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 297309, RefRangeEnd = 297311, XrefRangeStart = 297296, XrefRangeEnd = 297309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Configure(CauldronDisplayTub.EContents contentsType, float fillLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref contentsType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronDisplayTub.NativeMethodInfoPtr_Configure_Public_Void_EContents_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB00 RID: 43776 RVA: 0x002AB6AC File Offset: 0x002A98AC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronDisplayTub() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronDisplayTub.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB01 RID: 43777 RVA: 0x00054184 File Offset: 0x00052384
		public CauldronDisplayTub(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170034E0 RID: 13536
		// (get) Token: 0x0600AB02 RID: 43778 RVA: 0x002AB6E8 File Offset: 0x002A98E8
		// (set) Token: 0x0600AB03 RID: 43779 RVA: 0x0005418D File Offset: 0x0005238D
		public unsafe Transform CocaLeafContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_CocaLeafContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_CocaLeafContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E1 RID: 13537
		// (get) Token: 0x0600AB04 RID: 43780 RVA: 0x002AB718 File Offset: 0x002A9918
		// (set) Token: 0x0600AB05 RID: 43781 RVA: 0x000541AC File Offset: 0x000523AC
		public unsafe Transform Container_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_Container_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_Container_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E2 RID: 13538
		// (get) Token: 0x0600AB06 RID: 43782 RVA: 0x002AB748 File Offset: 0x002A9948
		// (set) Token: 0x0600AB07 RID: 43783 RVA: 0x000541CB File Offset: 0x000523CB
		public unsafe Transform Container_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_Container_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_Container_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040072E9 RID: 29417
		private static readonly IntPtr NativeFieldInfoPtr_CocaLeafContainer;

		// Token: 0x040072EA RID: 29418
		private static readonly IntPtr NativeFieldInfoPtr_Container_Min;

		// Token: 0x040072EB RID: 29419
		private static readonly IntPtr NativeFieldInfoPtr_Container_Max;

		// Token: 0x040072EC RID: 29420
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_EContents_Single_0;

		// Token: 0x040072ED RID: 29421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BE6 RID: 3046
		[OriginalName("Assembly-CSharp.dll", "", "EContents")]
		public enum EContents
		{
			// Token: 0x04009567 RID: 38247
			None,
			// Token: 0x04009568 RID: 38248
			CocaLeaf
		}
	}
}
