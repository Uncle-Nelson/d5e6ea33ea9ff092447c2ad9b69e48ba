using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000144 RID: 324
	[Serializable]
	public class BlendshapeEmotionValue : Il2CppSystem.Object
	{
		// Token: 0x06001B11 RID: 6929 RVA: 0x000C55E4 File Offset: 0x000C37E4
		// Note: this type is marked as 'beforefieldinit'.
		static BlendshapeEmotionValue()
		{
			Il2CppClassPointerStore<BlendshapeEmotionValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "BlendshapeEmotionValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendshapeEmotionValue>.NativeClassPtr);
			BlendshapeEmotionValue.NativeFieldInfoPtr_BlendType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendshapeEmotionValue>.NativeClassPtr, "BlendType");
			BlendshapeEmotionValue.NativeFieldInfoPtr_BlendValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendshapeEmotionValue>.NativeClassPtr, "BlendValue");
			BlendshapeEmotionValue.NativeFieldInfoPtr_BlendAnimationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendshapeEmotionValue>.NativeClassPtr, "BlendAnimationCurve");
			BlendshapeEmotionValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendshapeEmotionValue>.NativeClassPtr, 100666195);
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x000C5664 File Offset: 0x000C3864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99613, RefRangeEnd = 99614, XrefRangeStart = 99602, XrefRangeEnd = 99613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlendshapeEmotionValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlendshapeEmotionValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendshapeEmotionValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0000F481 File Offset: 0x0000D681
		public BlendshapeEmotionValue(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x000C56A0 File Offset: 0x000C38A0
		// (set) Token: 0x06001B15 RID: 6933 RVA: 0x0000F48A File Offset: 0x0000D68A
		public unsafe CharacterBlendShapeType BlendType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendshapeEmotionValue.NativeFieldInfoPtr_BlendType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendshapeEmotionValue.NativeFieldInfoPtr_BlendType)) = value;
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x000C56C8 File Offset: 0x000C38C8
		// (set) Token: 0x06001B17 RID: 6935 RVA: 0x0000F4A5 File Offset: 0x0000D6A5
		public unsafe float BlendValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendshapeEmotionValue.NativeFieldInfoPtr_BlendValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendshapeEmotionValue.NativeFieldInfoPtr_BlendValue)) = value;
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x000C56F0 File Offset: 0x000C38F0
		// (set) Token: 0x06001B19 RID: 6937 RVA: 0x0000F4C0 File Offset: 0x0000D6C0
		public unsafe AnimationCurve BlendAnimationCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendshapeEmotionValue.NativeFieldInfoPtr_BlendAnimationCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendshapeEmotionValue.NativeFieldInfoPtr_BlendAnimationCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeFieldInfoPtr_BlendType;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeFieldInfoPtr_BlendValue;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeFieldInfoPtr_BlendAnimationCurve;

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
