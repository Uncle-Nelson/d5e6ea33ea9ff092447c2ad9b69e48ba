using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x02000172 RID: 370
	public class LightVisibilityAffector : MonoBehaviour
	{
		// Token: 0x06001DBE RID: 7614 RVA: 0x000CCE54 File Offset: 0x000CB054
		// Note: this type is marked as 'beforefieldinit'.
		static LightVisibilityAffector()
		{
			Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "LightVisibilityAffector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr);
			LightVisibilityAffector.NativeFieldInfoPtr_PointLightEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "PointLightEffect");
			LightVisibilityAffector.NativeFieldInfoPtr_SpotLightEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "SpotLightEffect");
			LightVisibilityAffector.NativeFieldInfoPtr_EffectMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "EffectMultiplier");
			LightVisibilityAffector.NativeFieldInfoPtr_uniquenessCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "uniquenessCode");
			LightVisibilityAffector.NativeFieldInfoPtr_updateDistanceThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "updateDistanceThreshold");
			LightVisibilityAffector.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "light");
			LightVisibilityAffector.NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "attribute");
			LightVisibilityAffector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100666674);
			LightVisibilityAffector.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100666675);
			LightVisibilityAffector.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100666676);
			LightVisibilityAffector.NativeMethodInfoPtr_UpdateVisibility_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100666677);
			LightVisibilityAffector.NativeMethodInfoPtr_UpdateAttribute_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100666678);
			LightVisibilityAffector.NativeMethodInfoPtr_ClearAttribute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100666679);
			LightVisibilityAffector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100666680);
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x000CCF9C File Offset: 0x000CB19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106287, XrefRangeEnd = 106311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightVisibilityAffector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x000CCFD8 File Offset: 0x000CB1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106311, XrefRangeEnd = 106340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightVisibilityAffector.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x000CD00C File Offset: 0x000CB20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106340, XrefRangeEnd = 106358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightVisibilityAffector.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x000CD040 File Offset: 0x000CB240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106358, XrefRangeEnd = 106419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightVisibilityAffector.NativeMethodInfoPtr_UpdateVisibility_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x000CD07C File Offset: 0x000CB27C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106424, RefRangeEnd = 106425, XrefRangeStart = 106419, XrefRangeEnd = 106424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAttribute(float visibity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visibity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightVisibilityAffector.NativeMethodInfoPtr_UpdateAttribute_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x000CD0BC File Offset: 0x000CB2BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106433, RefRangeEnd = 106434, XrefRangeStart = 106425, XrefRangeEnd = 106433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightVisibilityAffector.NativeMethodInfoPtr_ClearAttribute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x000CD0F0 File Offset: 0x000CB2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106434, XrefRangeEnd = 106439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightVisibilityAffector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightVisibilityAffector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00010CF9 File Offset: 0x0000EEF9
		public LightVisibilityAffector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x000CD12C File Offset: 0x000CB32C
		// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x00010D02 File Offset: 0x0000EF02
		public unsafe static float PointLightEffect
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LightVisibilityAffector.NativeFieldInfoPtr_PointLightEffect, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightVisibilityAffector.NativeFieldInfoPtr_PointLightEffect, (void*)(&value));
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x000CD148 File Offset: 0x000CB348
		// (set) Token: 0x06001DCA RID: 7626 RVA: 0x00010D10 File Offset: 0x0000EF10
		public unsafe static float SpotLightEffect
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LightVisibilityAffector.NativeFieldInfoPtr_SpotLightEffect, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightVisibilityAffector.NativeFieldInfoPtr_SpotLightEffect, (void*)(&value));
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06001DCB RID: 7627 RVA: 0x000CD164 File Offset: 0x000CB364
		// (set) Token: 0x06001DCC RID: 7628 RVA: 0x00010D1E File Offset: 0x0000EF1E
		public unsafe float EffectMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_EffectMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_EffectMultiplier)) = value;
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06001DCD RID: 7629 RVA: 0x000CD18C File Offset: 0x000CB38C
		// (set) Token: 0x06001DCE RID: 7630 RVA: 0x00010D39 File Offset: 0x0000EF39
		public unsafe string uniquenessCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_uniquenessCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_uniquenessCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06001DCF RID: 7631 RVA: 0x000CD1B4 File Offset: 0x000CB3B4
		// (set) Token: 0x06001DD0 RID: 7632 RVA: 0x00010D58 File Offset: 0x0000EF58
		public unsafe int updateDistanceThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_updateDistanceThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_updateDistanceThreshold)) = value;
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x000CD1DC File Offset: 0x000CB3DC
		// (set) Token: 0x06001DD2 RID: 7634 RVA: 0x00010D73 File Offset: 0x0000EF73
		public unsafe Light light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x000CD20C File Offset: 0x000CB40C
		// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x00010D92 File Offset: 0x0000EF92
		public unsafe VisibilityAttribute attribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_attribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_attribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeFieldInfoPtr_PointLightEffect;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeFieldInfoPtr_SpotLightEffect;

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeFieldInfoPtr_EffectMultiplier;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeFieldInfoPtr_uniquenessCode;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeFieldInfoPtr_updateDistanceThreshold;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeFieldInfoPtr_light;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeFieldInfoPtr_attribute;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeMethodInfoPtr_PlayerSpawned_Private_Void_0;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisibility_Protected_Virtual_New_Void_0;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAttribute_Private_Void_Single_0;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeMethodInfoPtr_ClearAttribute_Private_Void_0;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
