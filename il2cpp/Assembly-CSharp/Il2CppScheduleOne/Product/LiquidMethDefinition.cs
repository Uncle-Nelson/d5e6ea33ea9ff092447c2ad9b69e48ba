using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000595 RID: 1429
	[Serializable]
	public class LiquidMethDefinition : QualityItemDefinition
	{
		// Token: 0x06007DBD RID: 32189 RVA: 0x0021ABD8 File Offset: 0x00218DD8
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidMethDefinition()
		{
			Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "LiquidMethDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr);
			LiquidMethDefinition.NativeFieldInfoPtr_StaticLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "StaticLiquidColor");
			LiquidMethDefinition.NativeFieldInfoPtr_LiquidVolumeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "LiquidVolumeColor");
			LiquidMethDefinition.NativeFieldInfoPtr_PourParticlesColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "PourParticlesColor");
			LiquidMethDefinition.NativeFieldInfoPtr_CookableLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "CookableLiquidColor");
			LiquidMethDefinition.NativeFieldInfoPtr_CookableSolidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "CookableSolidColor");
			LiquidMethDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, 100679022);
		}

		// Token: 0x06007DBE RID: 32190 RVA: 0x0021AC80 File Offset: 0x00218E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238376, XrefRangeEnd = 238377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidMethDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMethDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DBF RID: 32191 RVA: 0x0003BC71 File Offset: 0x00039E71
		public LiquidMethDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002612 RID: 9746
		// (get) Token: 0x06007DC0 RID: 32192 RVA: 0x0021ACBC File Offset: 0x00218EBC
		// (set) Token: 0x06007DC1 RID: 32193 RVA: 0x0003BC7A File Offset: 0x00039E7A
		public unsafe Color StaticLiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_StaticLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_StaticLiquidColor)) = value;
			}
		}

		// Token: 0x17002613 RID: 9747
		// (get) Token: 0x06007DC2 RID: 32194 RVA: 0x0021ACE4 File Offset: 0x00218EE4
		// (set) Token: 0x06007DC3 RID: 32195 RVA: 0x0003BC95 File Offset: 0x00039E95
		public unsafe Color LiquidVolumeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_LiquidVolumeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_LiquidVolumeColor)) = value;
			}
		}

		// Token: 0x17002614 RID: 9748
		// (get) Token: 0x06007DC4 RID: 32196 RVA: 0x0021AD0C File Offset: 0x00218F0C
		// (set) Token: 0x06007DC5 RID: 32197 RVA: 0x0003BCB0 File Offset: 0x00039EB0
		public unsafe Color PourParticlesColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_PourParticlesColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_PourParticlesColor)) = value;
			}
		}

		// Token: 0x17002615 RID: 9749
		// (get) Token: 0x06007DC6 RID: 32198 RVA: 0x0021AD34 File Offset: 0x00218F34
		// (set) Token: 0x06007DC7 RID: 32199 RVA: 0x0003BCCB File Offset: 0x00039ECB
		public unsafe Color CookableLiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_CookableLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_CookableLiquidColor)) = value;
			}
		}

		// Token: 0x17002616 RID: 9750
		// (get) Token: 0x06007DC8 RID: 32200 RVA: 0x0021AD5C File Offset: 0x00218F5C
		// (set) Token: 0x06007DC9 RID: 32201 RVA: 0x0003BCE6 File Offset: 0x00039EE6
		public unsafe Color CookableSolidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_CookableSolidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_CookableSolidColor)) = value;
			}
		}

		// Token: 0x04005585 RID: 21893
		private static readonly IntPtr NativeFieldInfoPtr_StaticLiquidColor;

		// Token: 0x04005586 RID: 21894
		private static readonly IntPtr NativeFieldInfoPtr_LiquidVolumeColor;

		// Token: 0x04005587 RID: 21895
		private static readonly IntPtr NativeFieldInfoPtr_PourParticlesColor;

		// Token: 0x04005588 RID: 21896
		private static readonly IntPtr NativeFieldInfoPtr_CookableLiquidColor;

		// Token: 0x04005589 RID: 21897
		private static readonly IntPtr NativeFieldInfoPtr_CookableSolidColor;

		// Token: 0x0400558A RID: 21898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
