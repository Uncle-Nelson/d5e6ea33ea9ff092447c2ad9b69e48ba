using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x0200014C RID: 332
	[Serializable]
	public class MinMaxColor : Il2CppSystem.Object
	{
		// Token: 0x06001B8E RID: 7054 RVA: 0x000C6964 File Offset: 0x000C4B64
		// Note: this type is marked as 'beforefieldinit'.
		static MinMaxColor()
		{
			Il2CppClassPointerStore<MinMaxColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "MinMaxColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxColor>.NativeClassPtr);
			MinMaxColor.NativeFieldInfoPtr_minColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxColor>.NativeClassPtr, "minColors");
			MinMaxColor.NativeFieldInfoPtr_maxColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxColor>.NativeClassPtr, "maxColors");
			MinMaxColor.NativeMethodInfoPtr_GetRandom_Public_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxColor>.NativeClassPtr, 100666223);
			MinMaxColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxColor>.NativeClassPtr, 100666224);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x000C69E4 File Offset: 0x000C4BE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 100462, RefRangeEnd = 100465, XrefRangeStart = 100453, XrefRangeEnd = 100462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetRandom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxColor.NativeMethodInfoPtr_GetRandom_Public_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x000C6A20 File Offset: 0x000C4C20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 100478, RefRangeEnd = 100481, XrefRangeStart = 100465, XrefRangeEnd = 100478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinMaxColor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinMaxColor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0000F9D4 File Offset: 0x0000DBD4
		public MinMaxColor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001B92 RID: 7058 RVA: 0x000C6A5C File Offset: 0x000C4C5C
		// (set) Token: 0x06001B93 RID: 7059 RVA: 0x0000F9DD File Offset: 0x0000DBDD
		public unsafe List<Color> minColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxColor.NativeFieldInfoPtr_minColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxColor.NativeFieldInfoPtr_minColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x000C6A8C File Offset: 0x000C4C8C
		// (set) Token: 0x06001B95 RID: 7061 RVA: 0x0000F9FC File Offset: 0x0000DBFC
		public unsafe List<Color> maxColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxColor.NativeFieldInfoPtr_maxColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxColor.NativeFieldInfoPtr_maxColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeFieldInfoPtr_minColors;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeFieldInfoPtr_maxColors;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeMethodInfoPtr_GetRandom_Public_Color_0;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
