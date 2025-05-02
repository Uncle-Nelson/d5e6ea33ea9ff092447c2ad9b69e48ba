using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200012F RID: 303
	public class WeatherEnclosure : MonoBehaviour
	{
		// Token: 0x060019EF RID: 6639 RVA: 0x000C1A90 File Offset: 0x000BFC90
		// Note: this type is marked as 'beforefieldinit'.
		static WeatherEnclosure()
		{
			Il2CppClassPointerStore<WeatherEnclosure>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "WeatherEnclosure");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherEnclosure>.NativeClassPtr);
			WeatherEnclosure.NativeFieldInfoPtr_nearTextureTiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEnclosure>.NativeClassPtr, "nearTextureTiling");
			WeatherEnclosure.NativeFieldInfoPtr_farTextureTiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEnclosure>.NativeClassPtr, "farTextureTiling");
			WeatherEnclosure.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEnclosure>.NativeClassPtr, 100666051);
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x000C1AFC File Offset: 0x000BFCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96841, XrefRangeEnd = 96846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeatherEnclosure() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherEnclosure>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEnclosure.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x0000EC33 File Offset: 0x0000CE33
		public WeatherEnclosure(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x000C1B38 File Offset: 0x000BFD38
		// (set) Token: 0x060019F3 RID: 6643 RVA: 0x0000EC3C File Offset: 0x0000CE3C
		public unsafe Vector2 nearTextureTiling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosure.NativeFieldInfoPtr_nearTextureTiling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosure.NativeFieldInfoPtr_nearTextureTiling)) = value;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x000C1B60 File Offset: 0x000BFD60
		// (set) Token: 0x060019F5 RID: 6645 RVA: 0x0000EC57 File Offset: 0x0000CE57
		public unsafe Vector2 farTextureTiling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosure.NativeFieldInfoPtr_farTextureTiling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosure.NativeFieldInfoPtr_farTextureTiling)) = value;
			}
		}

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeFieldInfoPtr_nearTextureTiling;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeFieldInfoPtr_farTextureTiling;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
