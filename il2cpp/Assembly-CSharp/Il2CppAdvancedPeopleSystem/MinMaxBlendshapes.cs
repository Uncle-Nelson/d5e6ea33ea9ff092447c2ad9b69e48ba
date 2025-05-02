using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x0200014D RID: 333
	[Serializable]
	public class MinMaxBlendshapes : Object
	{
		// Token: 0x06001B96 RID: 7062 RVA: 0x000C6ABC File Offset: 0x000C4CBC
		// Note: this type is marked as 'beforefieldinit'.
		static MinMaxBlendshapes()
		{
			Il2CppClassPointerStore<MinMaxBlendshapes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "MinMaxBlendshapes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxBlendshapes>.NativeClassPtr);
			MinMaxBlendshapes.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxBlendshapes>.NativeClassPtr, "Min");
			MinMaxBlendshapes.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxBlendshapes>.NativeClassPtr, "Max");
			MinMaxBlendshapes.NativeMethodInfoPtr_GetRandom_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxBlendshapes>.NativeClassPtr, 100666225);
			MinMaxBlendshapes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxBlendshapes>.NativeClassPtr, 100666226);
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x000C6B3C File Offset: 0x000C4D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100481, XrefRangeEnd = 100482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRandom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxBlendshapes.NativeMethodInfoPtr_GetRandom_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x000C6B78 File Offset: 0x000C4D78
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinMaxBlendshapes() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinMaxBlendshapes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxBlendshapes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0000FA1B File Offset: 0x0000DC1B
		public MinMaxBlendshapes(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x000C6BB4 File Offset: 0x000C4DB4
		// (set) Token: 0x06001B9B RID: 7067 RVA: 0x0000FA24 File Offset: 0x0000DC24
		public unsafe float Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxBlendshapes.NativeFieldInfoPtr_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxBlendshapes.NativeFieldInfoPtr_Min)) = value;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x000C6BDC File Offset: 0x000C4DDC
		// (set) Token: 0x06001B9D RID: 7069 RVA: 0x0000FA3F File Offset: 0x0000DC3F
		public unsafe float Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxBlendshapes.NativeFieldInfoPtr_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxBlendshapes.NativeFieldInfoPtr_Max)) = value;
			}
		}

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeFieldInfoPtr_Min;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeFieldInfoPtr_Max;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr_GetRandom_Public_Single_0;

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
