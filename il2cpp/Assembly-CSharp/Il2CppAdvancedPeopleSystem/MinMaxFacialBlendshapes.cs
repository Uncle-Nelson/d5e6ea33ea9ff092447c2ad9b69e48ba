using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000151 RID: 337
	[Serializable]
	public class MinMaxFacialBlendshapes : Object
	{
		// Token: 0x06001BAE RID: 7086 RVA: 0x000C6E38 File Offset: 0x000C5038
		// Note: this type is marked as 'beforefieldinit'.
		static MinMaxFacialBlendshapes()
		{
			Il2CppClassPointerStore<MinMaxFacialBlendshapes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "MinMaxFacialBlendshapes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxFacialBlendshapes>.NativeClassPtr);
			MinMaxFacialBlendshapes.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxFacialBlendshapes>.NativeClassPtr, "name");
			MinMaxFacialBlendshapes.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxFacialBlendshapes>.NativeClassPtr, "Min");
			MinMaxFacialBlendshapes.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxFacialBlendshapes>.NativeClassPtr, "Max");
			MinMaxFacialBlendshapes.NativeMethodInfoPtr_GetRandom_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxFacialBlendshapes>.NativeClassPtr, 100666229);
			MinMaxFacialBlendshapes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxFacialBlendshapes>.NativeClassPtr, 100666230);
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x000C6ECC File Offset: 0x000C50CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100490, XrefRangeEnd = 100491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRandom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxFacialBlendshapes.NativeMethodInfoPtr_GetRandom_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x000C6F08 File Offset: 0x000C5108
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinMaxFacialBlendshapes() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinMaxFacialBlendshapes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxFacialBlendshapes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0000FAF7 File Offset: 0x0000DCF7
		public MinMaxFacialBlendshapes(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x000C6F44 File Offset: 0x000C5144
		// (set) Token: 0x06001BB3 RID: 7091 RVA: 0x0000FB00 File Offset: 0x0000DD00
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxFacialBlendshapes.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxFacialBlendshapes.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x000C6F6C File Offset: 0x000C516C
		// (set) Token: 0x06001BB5 RID: 7093 RVA: 0x0000FB1F File Offset: 0x0000DD1F
		public unsafe float Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxFacialBlendshapes.NativeFieldInfoPtr_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxFacialBlendshapes.NativeFieldInfoPtr_Min)) = value;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x000C6F94 File Offset: 0x000C5194
		// (set) Token: 0x06001BB7 RID: 7095 RVA: 0x0000FB3A File Offset: 0x0000DD3A
		public unsafe float Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxFacialBlendshapes.NativeFieldInfoPtr_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxFacialBlendshapes.NativeFieldInfoPtr_Max)) = value;
			}
		}

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeFieldInfoPtr_Min;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeFieldInfoPtr_Max;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeMethodInfoPtr_GetRandom_Public_Single_0;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
